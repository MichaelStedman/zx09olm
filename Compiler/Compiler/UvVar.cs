using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Compiler
{
   [Serializable()]
   public class UvVar //: ICloneable
   {
      #region Type
      enum UvVarType
      {
         Unassigned,
         Number,
         Text,
         FileVar,
         DynArray,
         SelectList
      }
      UvVarType Type;
      #endregion //Type

      #region Member Vars

      // Define the standard Universe dynamic array delimiters
      protected char[] AM = { (char)254 };
      protected char[] VM = { (char)253 };
      protected char[] SVM = { (char)252 };

      //protected char[] AM = { '^' };
      //protected char[] VM = { ']' };
      //protected char[] SVM = { '/' };

      decimal DecimalValue;
      string StringValue;
      ArrayList dynAr = new ArrayList();
      bool stringValid = false;
      #endregion // Member vars

      #region Constructors
      private UvVar(decimal value)
      {
         Type = UvVarType.Number;
         DecimalValue = value;
      }
      private UvVar(string value)
      {
         Type = UvVarType.Text;
         StringValue = value;
      }
      private UvVar(int value)
      {
         Type = UvVarType.Number;
         DecimalValue = value;
      }
      private UvVar(bool value)
      {
         Type = UvVarType.Number;
         if (value)
         {
            DecimalValue = 1;
         }
         else
         {
            DecimalValue = 0;
         }
      }
      private UvVar(ArrayList value)
      {
         Type = UvVarType.DynArray;
         dynAr = value;
      }
      #endregion //Constructors

      #region Implicit Operators
      public static implicit operator UvVar(decimal value)
      {
         return new UvVar(value);
      }
      public static implicit operator UvVar(string value)
      {
         return new UvVar(value);
      }
      public static implicit operator UvVar(int value)
      {
         return new UvVar(value);
      }
      public static implicit operator UvVar(bool value)
      {
         return new UvVar(value);
      }
      public static implicit operator decimal(UvVar value)
      {
         switch (value.Type)
         {
            case UvVarType.Number: return value.DecimalValue;
            case UvVarType.Text: return Convert.ToDecimal(value.StringValue);
            case UvVarType.DynArray:
               {
                  return 0;
               }
            default: return 0;
         }
      }
      public static implicit operator string(UvVar value)
      {
         switch (value.Type)
         {
            case UvVarType.Number: return value.DecimalValue.ToString();
            case UvVarType.Text: return value.StringValue;
            case UvVarType.DynArray:
               {
                  if (!value.stringValid)
                  {
                     value.ConvertDynArrayToStringValue();
                  }
                  return value.StringValue;
               }
            default: return "";
         }
      }
      public static implicit operator int(UvVar value)
      {
         switch (value.Type)
         {
            case UvVarType.Number: return (int)value.DecimalValue;
            case UvVarType.Text: return Int32.Parse(value.StringValue);
            case UvVarType.DynArray:
               {
                  return 0;
               }
            default: return 0;
         }
      }
      public static implicit operator bool(UvVar value)
      {
         if (value.DecimalValue > 0) return true; else return false;
      }
      public static implicit operator UvVar(ArrayList value)
      {
         return new UvVar(value);
      }
      #endregion Implicit Operators

      #region Overload Binary Operators

      public static UvVar operator +(UvVar operand1, UvVar operand2)
      {
         return operand1.DecimalValue + operand2.DecimalValue;
      }
      public static UvVar operator -(UvVar operand1, UvVar operand2)
      {
         return operand1.DecimalValue - operand2.DecimalValue;
      }
      public static UvVar operator *(UvVar operand1, UvVar operand2)
      {
         return operand1.DecimalValue * operand2.DecimalValue;
      }
      public static UvVar operator /(UvVar operand1, UvVar operand2)
      {
         return operand1.DecimalValue / operand2.DecimalValue;
      }
      
      #endregion //Overload Binary Operators

      #region Overload Unary Operators
      public static UvVar operator +(UvVar operand1)
      {
         return +operand1.DecimalValue;
      }
      public static UvVar operator -(UvVar operand1)
      {
         return -operand1.DecimalValue;
      }
      public static UvVar operator ++(UvVar operand1)
      {
         return ++operand1.DecimalValue;
      }
      public static UvVar operator --(UvVar operand1)
      {
         return --operand1.DecimalValue;
      }
      #endregion // Overload Unary Operators

      #region Comparison
      public static bool operator ==(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) == 0;
      }
      public static bool operator !=(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) > 0;
      }
      public static bool operator <(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) < 0;
      }
      public static bool operator >(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) > 0;
      }
      public static bool operator <=(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) <= 0;
      }
      public static bool operator >=(UvVar operand1, UvVar operand2)
      {
         return operand1.CompareTo(operand2) >= 0;
      }
      private int CompareTo(UvVar operand)
      {
         if ((this.Type | operand.Type) == UvVarType.Number) return this.DecimalValue.CompareTo(operand.DecimalValue);
         if ((this.Type | operand.Type) == UvVarType.Text)
         {
            int result1;
            int result2;
            if (Int32.TryParse(this.StringValue, out result1) &&
                Int32.TryParse(operand.StringValue, out result2))
            {
               return result1.CompareTo(result2);
            }
            else
            {
               return (this.StringValue).CompareTo(operand.StringValue);
            }
         }
         if ((this.Type == UvVarType.Number && operand.Type == UvVarType.Text))
         {
            // Convert Text to Number, if possible and do a Numeric comparison otherwise
            // do a Text comparison
            int result2;
            if (Int32.TryParse(operand.StringValue, out result2))
            {
               return this.DecimalValue.CompareTo(result2);
            }
            else
            {
               return this.DecimalValue.ToString().CompareTo(operand.StringValue);
            }
         }
         if ((this.Type == UvVarType.Text && operand.Type == UvVarType.Number))
         {
            // Convert Text to Number, if possible and do a Numeric comparison otherwise
            // do a Text comparison
            int result1;
            if (Int32.TryParse(this.StringValue, out result1))
            {
               return result1.CompareTo(operand.DecimalValue);
            }
            else
            {
               return this.StringValue.CompareTo(operand.DecimalValue.ToString());
            }
         }
         return 0;
      }
      #endregion // Comparison

      #region Indexers
      public UvVar this[int attNo]
      {
         get { return this[attNo, 1, 1]; }
         set { this[attNo, 1, 1] = value; }
      }
      public UvVar this[int attNo, int mvNo]
      {
         get { return this[attNo, mvNo, 1]; }
         set { this[attNo, mvNo, 1] = value; }
      }
      public UvVar this[int attNo, int mvNo, int svNo]
      {
         get
         {
            if (attNo > dynAr.Count)
            {
               return new UvVar("");
            }
            else if (dynAr[attNo - 1] == null)
            {
               return new UvVar("");
            }
            else if (mvNo > (dynAr[attNo - 1] as ArrayList).Count)
            {
               return new UvVar("");
            }
            else if ((dynAr[attNo - 1] as ArrayList)[mvNo - 1] == null)
            {
               return new UvVar("");
            }
            else if (svNo > ((dynAr[attNo - 1] as ArrayList)[mvNo - 1] as ArrayList).Count)
            {
               return new UvVar("");
            }
            else
            {
               return new UvVar((((dynAr[attNo - 1] as ArrayList)[mvNo - 1] as ArrayList)[svNo - 1] as UvVar).StringValue);
            }
         }
         set
         {
            // The dynamic array is changing so indicate that the
            // string representation is now invalid and will need to
            // be rebuilt if referenced. This prevents us having to
            // rebuild the string representation unnecessarily every
            // time that the dynamic array is updated.
            stringValid = false;

            // Special condition - deal with AttNo = -1
            if (attNo == -1) attNo = dynAr.Count + 1;

            // Externally Dynamic Arrays are one based, internally
            // the ArrayLists are zero based.
            int internalAttNo = attNo - 1;

            // Append new attributes if required
            if (attNo > dynAr.Count)
            {
               dynAr.AddRange(new ArrayList[attNo - dynAr.Count]);
            }

            // Ensure that referenced attribute is an ArrayList (to hold multivalues)
            if (dynAr[internalAttNo] == null) dynAr[internalAttNo] = new ArrayList();

            // Special condition - deal with MvNo = -1
            if (mvNo == -1) mvNo = (dynAr[internalAttNo] as ArrayList).Count + 1;

            // Externally Dynamic Arrays are one based, internally
            // the ArrayLists are zero based.
            int internalMvNo = mvNo - 1;

            // Append new multivalues if required
            if (mvNo > (dynAr[internalAttNo] as ArrayList).Count)
            {
               (dynAr[internalAttNo] as ArrayList).AddRange(new ArrayList[mvNo - (dynAr[internalAttNo] as ArrayList).Count]);
            }

            // Ensure that referenced multivalue is an ArrayList (to hold subvalues)
            if ((dynAr[internalAttNo] as ArrayList)[internalMvNo] == null) (dynAr[internalAttNo] as ArrayList)[internalMvNo] = new ArrayList();

            // Special condition - deal with SvNo = -1
            if (svNo == -1) svNo = ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count + 1;

            // Externally Dynamic Arrays are one based, internally
            // the ArrayLists are zero based.
            int internalSvNo = svNo - 1;

            // Append new subvalues is required
            if (svNo > ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count)
            {
               ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).AddRange(new ArrayList[svNo - ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count]);
            }

            // Ensure that referenced subvalue is a string
            if (((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo] == null) ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo] = string.Empty;

            // Finally, assign the value to the appropriate array position
            ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo] = value;
         }
      }
      #endregion //Indexers

      public UvVar Substring(int start, int length)
      {
         switch (this.Type)
         {
            case UvVarType.Number: return this.DecimalValue.ToString().Substring(start - 1, length);
            case UvVarType.Text: return this.StringValue.Substring(start - 1, length);
            case UvVarType.DynArray:
               {
                  if (!stringValid)
                  {
                     ConvertDynArrayToStringValue();
                  }
                  return this.StringValue.Substring(start - 1, length);
               }
            default: return "";
         }
      }
      public UvVar Substring(int start)
      {
         switch (this.Type)
         {
            case UvVarType.Number: return this.DecimalValue.ToString().Substring(start - 1);
            case UvVarType.Text: return this.StringValue.Substring(start - 1);
            case UvVarType.DynArray:
               {
                  if (!stringValid)
                  {
                     ConvertDynArrayToStringValue();
                  }
                  return this.StringValue.Substring(start - 1);
               }
            default: return "";
         }
      }
      private void ConvertDynArrayToStringValue()
      {
         StringBuilder result = new StringBuilder();
         int highestAtt = dynAr.Count - 1;
         for (int internalAttNo = 0; internalAttNo <= highestAtt; internalAttNo++)
         {
            if (dynAr[internalAttNo] != null)
            {
               int highestMv = (dynAr[internalAttNo] as ArrayList).Count - 1;
               for (int internalMvNo = 0; internalMvNo <= highestMv; internalMvNo++)
               {
                  if ((dynAr[internalAttNo] as ArrayList)[internalMvNo] != null)
                  {
                     int highestSv = ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count - 1;
                     for (int internalSvNo = 0; internalSvNo <= highestSv; internalSvNo++)
                     {
                        if (((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo] != null)
                        {
                           result.Append(((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo]);
                           //Console.WriteLine("{0},{1},{2} = {3}", internalAttNo + 1, internalMvNo + 1, internalSvNo + 1, ((xxx[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo]);
                        }
                        if (internalSvNo < highestSv) result.Append(SVM);
                     }
                  }
                  if (internalMvNo < highestMv) result.Append(VM);
               }
            }
            if (internalAttNo < highestAtt) result.Append(AM);
         }
         StringValue = result.ToString();
         stringValid = true;
      }
      
      #region Length Methods
      public int Length(int attNo)
      {
         return this[attNo, 1, 1].ToString().Length;
      }
      public int Length(int attNo, int mvNo)
      {
         return this[attNo, mvNo, 1].ToString().Length;
      }
      public int Length(int attNo, int mvNo, int svNo)
      {
         return this[attNo, mvNo, svNo].ToString().Length;
      }
      #endregion // Length Methods

      public UvVar Clone()
      {
         // deep copy in separate memory space
         MemoryStream memoryStream = new MemoryStream();
         BinaryFormatter binaryFormatter = new BinaryFormatter();
         binaryFormatter.Serialize(memoryStream, this);
         memoryStream.Position = 0;
         UvVar copyPv2 = (UvVar)binaryFormatter.Deserialize(memoryStream);
         memoryStream.Close();
         return copyPv2;
      }

      #region Insert Methods
      public void Insert(int attNo, string text)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;

         if (attNo <= dynAr.Count)
         {
            dynAr.Insert(internalAttNo, null);
         }
         this[attNo] = text;
      }
      public void Insert(int attNo, int mvNo, string text)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;
         int internalMvNo = mvNo - 1;

         if (attNo <= dynAr.Count)
         {
            if (dynAr[internalAttNo] != null)
            {
               if (mvNo <= (dynAr[internalAttNo] as ArrayList).Count)
               {
                  (dynAr[internalAttNo] as ArrayList).Insert(internalMvNo, null);
               }
            }
         }
         this[attNo, mvNo] = text;
      }
      public void Insert(int attNo, int mvNo, int svNo, string text)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;
         int internalMvNo = mvNo - 1;
         int internalSvNo = svNo - 1;

         if (attNo <= dynAr.Count)
         {
            if (dynAr[internalAttNo] != null)
            {
               if (mvNo <= (dynAr[internalAttNo] as ArrayList).Count)
               {
                  if ((dynAr[internalAttNo] as ArrayList)[internalMvNo] != null)
                  {
                     if (mvNo <= ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count)
                     {
                        ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Insert(internalSvNo, null);
                     }
                  }
               }
            }
         }
         this[attNo, mvNo] = text;

      }
      #endregion //Insert Methods

      #region Delete Methods
      public void Delete(int attNo)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;

         if (internalAttNo <= dynAr.Count)
         {
            dynAr.RemoveAt(internalAttNo);
            stringValid = false;
         }
         // Tidy up any preceding attributes that are null and
         // have been left dangling
         if (internalAttNo > 0)
         {
            if (dynAr[internalAttNo - 1] == null)
            {
               Delete(attNo - 1);
            }
         }
      }
      public void Delete(int attNo, int mvNo)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;
         int internalMvNo = mvNo - 1;

         if (internalAttNo <= dynAr.Count)
         {
            if (dynAr[internalAttNo] != null)
            {
               if (internalMvNo <= (dynAr[internalAttNo] as ArrayList).Count)
               {
                  (dynAr[internalAttNo] as ArrayList).RemoveAt(internalMvNo);
                  stringValid = false;
               }
               // Tidy up any preceding multivalues that are null and
               // have been left dangling
               if (internalMvNo > 0)
               {
                  if ((dynAr[internalAttNo] as ArrayList)[internalMvNo - 1] == null)
                  {
                     Delete(attNo, mvNo - 1);
                  }
               }
               // If there are no multivalues left in the attribute
               // go ahead and delete the whole attribute
               if (internalAttNo < dynAr.Count)
               {
                  if ((dynAr[internalAttNo] as ArrayList).Count == 0)
                  {
                     Delete(attNo);
                  }
               }
            }
         }
      }
      public void Delete(int attNo, int mvNo, int svNo)
      {
         // Change from external DynamicArray indices to
         // internal ArrayList indices
         int internalAttNo = attNo - 1;
         int internalMvNo = mvNo - 1;
         int internalSvNo = svNo - 1;

         if (internalAttNo <= dynAr.Count)
         {
            if (dynAr[internalAttNo] != null)
            {
               if (internalMvNo <= (dynAr[internalAttNo] as ArrayList).Count)
               {
                  if ((dynAr[internalAttNo] as ArrayList)[internalMvNo] != null)
                  {
                     if (internalSvNo <= ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count)
                     {
                        ((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).RemoveAt(internalSvNo);
                        stringValid = false;
                     }
                     // Tidy up any preceding subvalues that are null and
                     // have been left dangling
                     if (internalSvNo > 0)
                     {
                        if (((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList)[internalSvNo - 1] == null)
                        {
                           Delete(attNo, mvNo, svNo - 1);
                        }
                     }
                     // If there are no subvalues left in the multivalue
                     // go ahead and delete the whole multivalue
                     if (internalAttNo < dynAr.Count)
                     {
                        if (internalMvNo < ((dynAr[internalAttNo] as ArrayList).Count))
                        {
                           if (((dynAr[internalAttNo] as ArrayList)[internalMvNo] as ArrayList).Count == 0)
                           {
                              Delete(attNo, mvNo);
                           }
                        }
                     }
                  }
               }
            }
         }
      }
      #endregion //Delete Methods
   }
}
