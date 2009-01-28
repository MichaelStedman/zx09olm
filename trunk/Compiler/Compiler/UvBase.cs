using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   public enum ReadUResult
   {
      Success,
      Failed,
      Locked
   }
   public class UvBase
   {
      protected Stack<int> rs = new Stack<int>();
      //ToDo: public UniSession Session { get; private set; }
      private string prompt = "";
      protected ReadUResult readUResult = ReadUResult.Success;
      public UvBase()
      {
         //ToDo: Session = UvSession.GetInstance();
      }

      public static void PROMPT(string value)
      {
         //this.prompt = value;
      }
      public static bool READNEXT(ref UvVar dynarray, UvVar value, UvVar subValue, UvVar from)
      {
         return true;
      }
      public static bool READ(ref UvVar dynArray, UvVar uvFile, UvVar itemId)
      {
         //ToDo: uvFile.RecordID = itemId;
         try
         {
            //ToDo: uvFile.Read();
            //ToDo: dynArray = new UvVar(uvFile.Record.StringValue);
            return true;
         }
         catch { }
         return false;
      }
      public static bool READ(ref string text, UvVar uvFile, string itemId)
      {
         //ToDo: uvFile.RecordID = itemId;
         try
         {
            //ToDo: uvFile.Read();
            //ToDo: text = uvFile.Record.StringValue;
            return true;
         }
         catch { }
         return false;
      }
      public static bool READBLK(ref string text, UvVar uvFile)
      {
         return true;
      }
      public static bool READU(ref UvVar dynArray, UvVar uvFile, string itemId)
      {
         return true;
      }
      public static ReadUResult READU_LOCKED(ref UvVar dynArray, UvVar uvFile, string itemId)
      {
         return ReadUResult.Success;
      }
      public static bool READV(ref int singleValue, UvVar uvFile, string itemId, int attributeNo)
      {
         //ToDo: uvFile.RecordID = itemId;
         try
         {
            //ToDo: uvFile.ReadField(attributeNo);
            //ToDo: singleValue = int.Parse(uvFile.ReadField(attributeNo).StringValue);
            return true;
         }
         catch { }
         return false;
      }
      public static bool READV(ref string singleValue, UvVar uvFile, string itemId, int attributeNo)
      {
         return true;
      }
      public static bool READV(ref UvVar dynArray, UvVar uvFile, UvVar itemId, UvVar attributeNo)
      {
         return true;
      }
      public static bool READVU(ref int singleValue, UvVar uvFile, string itemId, int attributeNo)
      {
         return true;
      }
      public static bool READVU(ref string singleValue, UvVar uvFile, string itemId, int attributeNo)
      {
         return true;
      }
      public static bool READVU(ref UvVar dynArray, UvVar uvFile, string itemId, int attributeNo)
      {
         return true;
      }
      public static void WEOFSEQ(UvVar filevar)
      {
      }
      public static void WRITE(UvVar dynArray, UvVar uvFile, string itemId)
      {
      }
      public static void WRITEU(UvVar dynArray, UvVar uvFile, string itemId)
      {
      }
      public static void WRITE(string value, UvVar uvFile, string itemId)
      {
      }
      public static void WRITE(int value, UvVar uvFile, string itemId)
      {
      }
      public static bool WRITEBLK(UvVar value, UvVar uvFile)
      {
         return true;
      }
      public static bool WRITESEQ(UvVar value, UvVar uvFile)
      {
         return true;
      }
      public static void WRITEV(UvVar value, UvVar uvFile, UvVar itemId, UvVar attributeNo)
      {
      }
      public static bool MATREAD(ref UvVar[] dimensionedArray, UvVar uvFile, UvVar itemId)
      {
         return true;
      }
      public static bool MATREADU(ref UvVar[] dimensionedArray, UvVar uvFile, UvVar itemId)
      {
         return true;
      }
      public static ReadUResult MATREADU_LOCKED(ref UvVar[] dimensionedArray, UvVar uvFile, UvVar itemId)
      {
         return ReadUResult.Success;
      }
      public static void MATWRITE(UvVar[] dimensionedArray, UvVar uvFile, string itemId)
      {
      }
      public static void SELECT(UvVar value)
      {
      }
      public static void SELECT_TO(UvVar value)
      {
      }
      public static void SELECT_TO(UvVar value, UvVar value2)
      {
      }
      public static void PAGE_ON(UvVar printChannel)
      {
      }
      public static void PAGE_ON(UvVar printChannel, UvVar pageNumber)
      {
      }
      public static void PAGE(UvVar pageNumber)
      {
      }
      public static void PAGE()
      {
      }
      public static void PRINT()
      {
         Console.WriteLine("");
      }
      //public static void PRINT(string text)
      //{
      //   Console.Write(text);
      //}
      public static void PRINT(UvVar text)
      {
         Console.Write((string)text);
      }
      //public static void PRINTCR(string text)
      //{
      //   Console.WriteLine(text);
      //}
      public static void PRINTCR(UvVar text)
      {
         Console.WriteLine((string)text);
      }
      public static bool CREATE(UvVar file)
      {
         return true;
      }
      public static void CRT()
      {
         Console.WriteLine("");
      }
      public static void CRT(UvVar text)
      {
         Console.WriteLine((string)text);
      }
      public static void CRTCR(UvVar text)
      {
         Console.WriteLine((string)text);
      }
      public static bool STATUS(ref UvVar rec, UvVar file)
      {
         rec = "";
         return true;
      }
      public static UvVar STATUS()
      {
         return "";
      }
      public static void STOP()
      {
      }
      public static void STOP(int errorNo)
      {
      }
      public static void STOP(int errorNo, string message)
      {
      }
      public static void STOP(string errorNo)
      {
      }
      public static void STOP(string errorNo, string message)
      {
      }
      //public static string AT(int column, int row)
      //{
      //   return string.Format("[{0}][{1}]", column, row);
      //}
      public static string AT(UvVar column, UvVar row)
      {
         return string.Format("[{0}][{1}]", column, row);
      }
      public static string AT(int column)
      {
         return string.Format("[{0}]", column);
      }
      public static void INPUT(out UvVar text, int length)
      {
         text = "";
      }
      public static void INPUT(out UvVar text, UvVar length)
      {
         text = "";
      }
      public static void INPUT(out UvVar text)
      {
         text = "";
      }
      public static void INPUTCR(out UvVar text, UvVar length)
      {
         text = "";
      }
      public static void INPUTCR(out UvVar text)
      {
         text = "";
      }
      public static void EXECUTE(UvVar A, UvVar B, UvVar C, UvVar D, UvVar E)
      {
      }
      public static string STR(string text, UvVar repeats)
      {
         return new System.Text.StringBuilder().Insert(0, text, repeats).ToString();
      }
      public static string SPACE(UvVar length)
      {
         return new string(' ', length);
      }
      public static string SPACE(int length)
      {
         return new string(' ', length);
      }
      public static UvVar CHANGE(UvVar from, UvVar to)
      {
         return "";
      }
      public static UvVar ICONV(UvVar array, string conversion)
      {
         return "";
      }
      public static UvVar OCONV(UvVar array, string conversion)
      {
         return "";
      }
      public static UvVar OCONV(string text, string conversion)
      {
         return "";
      }
      public static UvVar OCONV(int value, string conversion)
      {
         return "";
      }
      public static string FORMAT(UvVar text, UvVar justification)
      {
         return "";
      }
      public static bool LOCATE(string text, UvVar dynArray, int pointer, string direction)
      {
         return true;
      }
      public static bool LOCATE(UvVar text, UvVar dynArray, int attribute, int value, int start, ref UvVar pointer, string direction)
      {
         return true;
      }
      public static UvVar FIELD(string text, string delimiter, int occurrence)
      {
         return "";
      }
      public static UvVar FIELD(string text, char delimiter, int occurrence)
      {
         return text;
      }
      public static void FILELOCK(UvVar fileVar)
      {
      }
      public static void FILEUNLOCK(UvVar fileVar)
      {
      }
      public static void GO(string label)
      {
         throw new ApplicationException("GO " + label);
      }
      public static void GO(int label)
      {
         throw new ApplicationException("GO " + label.ToString());
      }
      public static void CLEARFILE(UvVar filevar)
      {
      }
      public static void CLOSE(UvVar filevar)
      {
      }
      public static void CLOSESEQ(UvVar filevar)
      {
      }
      public static int COUNT(string text, char delimiter)
      {
         return 0;
      }
      public static int COUNT(string text, string delimiter)
      {
         return 0;
      }
      public static int COUNT(UvVar array, char delimiter)
      {
         switch (delimiter)
         {
            case (char)254:
               {
                  return 0;//ToDo: return array.Count();
               }
            case (char)253:
               {
                  return 0;//ToDo: return array.Count(1);
               }
            case (char)252:
               {
                  return 0;//ToDo: return array.Count(1, 1);
               }
            default:
               {
                  return 0;
               }
         }
      }
      public static int DCOUNT(UvVar array, UvVar delimiter)
      {

         switch ((char)delimiter)
         {
            case (char)254:
               {
                  return 0;//ToDo: return array.Count();
               }
            case (char)253:
               {
                  return 0;//ToDo: return array.Count(1);
               }
            case (char)252:
               {
                  return 0;//ToDo: return array.Count(1, 1);
               }
            default:
               {
                  return 0;
               }
         }
      }
      public static UvVar KEYIN()
      {
         return "";
      }
      public static int LEN(string text)
      {
         return text.Length;
      }
      //public static int INT(decimal value)
      //{
      //   return (int)value;
      //}
      public static int INT(UvVar value)
      {
         return (int)value;
      }
      public static int ABS(UvVar value)
      {
         return 0;
      }
      public static bool ASSIGNED(UvVar value)
      {
         return true;
      }
      public static UvVar INDEX(string text, string search, int occurrence)
      {
         return 0;
      }
      public static bool OPEN(string fileName, out UvVar file)
      {
         file = 0;//ToDo: file = UvSession.GetInstance().CreateUvVar(fileName);
         return true;
      }
      public static bool OPENDICT(string fileName, out UvVar file)
      {
         file = 0;//ToDo: file = UvSession.GetInstance().CreateUvVar(fileName);
         return true;
      }
      public static bool OPENSEQ(string fileName, out UvVar file)
      {
         file = 0;
         return true;
      }
      public static void CALL(string routineName)
      {
      }
      public static void CALL(string routineName, params UvVar[] args)
      {
      }
      public static void DATA(params UvVar[] args)
      {
      }
      public static UvVar SEQ(UvVar value)
      {
         return "";
      }
      public static void NULL() { }
      //ToDo:
      //public static void CALL_EXECUTE(
      //   string routineName,
      //   string instruction,
      //   string options,
      //   out UvVar returnList,
      //   out bool listAvailable,
      //   out UvVar messages,
      //   out UvVar errors)
      //{
      //   //ToDo: returnList = new UvVar();
      //   listAvailable = false;
      //   //ToDo: messages = new UvVar();
      //   //ToDo: errors = new UvVar();
      //}
      public static UvVar SYSTEM(UvVar systemNo)
      {
         return "";
      }
      public static void ECHO_ON()
      {
      }
      public static void ECHO_OFF()
      {
      }
      public static void ECHO(UvVar value)
      {
      }
      public static void BREAK_ON()
      {
      }
      public static void BREAK_OFF()
      {
      }
      public static void BREAK(UvVar value)
      {
      }
      public static void NAP(int milliseconds)
      {
      }
      public static string CHAR(int asciiValue)
      {
         return "";
      }
      public static string TIMEDATE()
      {
         return "";
      }
      public static string TRIM(UvVar value)
      {
         return "";
      }
      public static void CHAIN(string command)
      {
      }
      public static void RQM()
      {
      }
      public static decimal RND(UvVar value)
      {
         return 0;
      }
      public static int DATE()
      {
         return 0;
      }
      public static int TIME()
      {
         return 0;
      }
      public static bool NOT(UvVar value)
      {
         return true;
      }
      public static void MAT(ref UvVar[] destination, UvVar[] source)
      {
      }
      public static void MAT(ref UvVar[] destination, UvVar source)
      {
      }
      public static void MAT(ref UvVar[,] destination, UvVar[] source)
      {
      }
      public static void MAT(ref UvVar[,] destination, UvVar source)
      {
      }
      public static UvVar MOD(UvVar value1, UvVar value2)
      {
         return 0;
      }
      public static UvVar NUM(UvVar value)
      {
         return 0;
      }
      public static UvVar MATCH(UvVar value, UvVar pattern)
      {
         return 0;
      }
      public static UvVar INSERT(UvVar dynarray, UvVar att, UvVar mv, UvVar sv, UvVar value)
      {
         return "";
      }
      public static UvVar INSERT(UvVar dynarray, UvVar att, UvVar value)
      {
         return "";
      }
      public static UvVar INS(UvVar value, UvVar dynarray)
      {
         return "";
      }
      public static UvVar DEL(UvVar dynarray)
      {
         return "";
      }
      public static UvVar DELETE(UvVar dynarray, UvVar att)
      {
         return "";
      }
      public static UvVar DELETE(UvVar dynarray, UvVar att, UvVar mv)
      {
         return "";
      }
      public static UvVar DELETE(UvVar dynarray, UvVar att, UvVar mv, UvVar sv)
      {
         return "";
      }
      public static void RELEASE()
      {
      }
      public static void PRINTER_CLOSE()
      {
      }
      public static void PRINTER_ON()
      {
      }
      public static void PRINTER_OFF()
      {
      }
   }
}
