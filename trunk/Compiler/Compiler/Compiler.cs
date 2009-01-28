using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   /*
Expression := PL0 { ( : ) PL0 }

PL0        := PL1 { ( + | - ) PL1 }

PL1        := PL2 { ( * | / ) PL2 }

PL2        := PL3 { ( < | <= | = | => | > | <> | # ) PL3 }

PL3        := PL4 '<' Expression '>' |
              PL4 '<' Expression ',' Expression '>' |
              PL4 '<' Expression ',' Expression ',' Expression '>' |
              PL4 '[' Expression ']' |
              PL4 '[' Expression ',' Expression ']'        

PL4        := int_lit_sym |
              '(' expression ')' |
              identifier


Precedence
----------
 
+ | -
* | /
< | <= | = | >= | > | <> | #
< > | <,> | <,,>
( )
[,] | []
 
 
 
 */
   public class Compiler
   {
      Symbols[] symbolList = new Symbols[100];

      enum Symbols
      {
         eos,
         concat,
         plus,
         minus,
         multiply,
         divide,
         lt,
         lte,
         eq,
         gte,
         gt,
         neq,
         openbracket,
         closebracket,
         opensquare,
         closesquare,
         comma,
         int_lit,
         str_lit,
         ident
      }

      enum CompileResult
      {
         OK,
         UnknownError,
         IncompleteDynArray
      }

      int symPointer = 0;
      string[] expressionStack = new string[30];

      public Compiler()
      {
         symbolList[0] = Symbols.ident;
         symbolList[1] = Symbols.lt;
         symbolList[2] = Symbols.ident;
         symbolList[3] = Symbols.lt;
         symbolList[4] = Symbols.ident;
         symbolList[5] = Symbols.lt;
         symbolList[6] = Symbols.ident;
         symbolList[7] = Symbols.gt;
         symbolList[8] = Symbols.opensquare;
         symbolList[9] = Symbols.int_lit;
         symbolList[10] = Symbols.comma;
         symbolList[11] = Symbols.int_lit;
         symbolList[12] = Symbols.closesquare;
         Expression();
         for (int i = 0; i <= symPointer; i++)
         {
            Console.Write(expressionStack[i]);
         }
      }
      CompileResult Expression()
      {
         PL0();
         bool done = false;
         do
         {
            if (NextIs(Symbols.concat))
            {
               SaveElement(":");
               PL0();
            }
            else
            {
               done = true;
            }
         } while (!done);
         return CompileResult.OK;
      }
      CompileResult PL0()
      {
         PL1();
         bool done = false;
         do
         {
            if (NextIs(Symbols.plus))
            {
               SaveElement("+");
               PL1();
            }
            else if (NextIs(Symbols.minus))
            {
               SaveElement("-");
               PL1();
            }
            else
            {
               done = true;
            }
         } while (!done);
         return CompileResult.OK;
      }
      CompileResult PL1()
      {
         PL2();
         bool done = false;
         do
         {
            if (NextIs(Symbols.multiply))
            {
               SaveElement("*");
               PL2();
            }
            else if (NextIs(Symbols.divide))
            {
               SaveElement("/");
               PL2();
            }
            else
            {
               done = true;
            }
         } while (!done);
         return CompileResult.OK;
      }
      CompileResult PL2()
      {
         PL3();
         bool done = false;
         do
         {
            if (NextIs(Symbols.lt))
            {
               SaveElement(" never used ");
               PL3();
            }
            else if (NextIs(Symbols.lte))
            {
               SaveElement(" <= ");
               PL3();
            }
            else if (NextIs(Symbols.eq))
            {
               SaveElement(" == ");
               PL3();
            }
            else if (NextIs(Symbols.gte))
            {
               SaveElement(" >= ");
               PL3();
            }
            else if (NextIs(Symbols.gt))
            {
               SaveElement(" > ");
               PL3();
            }
            else if (NextIs(Symbols.neq))
            {
               SaveElement(" != ");
               PL3();
            }
            else
            {
               done = true;
            }
         } while (!done);
         return CompileResult.OK;
      }
      CompileResult PL3()
      {
         int saveSymPointer = 0;

         PL4();
         bool done = false;
         do
         {
            if (NextIs(Symbols.lt))
            {
               SaveElement("[");
               saveSymPointer = symPointer; // It might be condition not DynArray
               Expression();
               if (NextIs(Symbols.gt))
               {
                  SaveElement("]");
                  Expression();
                  done = true;
               }
               else if (NextIs(Symbols.comma))
               {
                  SaveElement(" ,");
                  Expression();
                  if (NextIs(Symbols.gt))
                  {
                     SaveElement("]");
                     Expression();
                     done = true;
                  }
                  else if (NextIs(Symbols.comma))
                  {
                     SaveElement(" ,");
                     Expression();
                     if (NextIs(Symbols.gt))
                     {
                        SaveElement("]");
                        Expression();
                        done = true;
                     }
                     else
                     {
                        throw new ApplicationException("Not DynArray1");
                     }
                  }
                  else
                  {
                     throw new ApplicationException("Not DynArray2");
                  }
               }
               else
               {
                  symPointer = saveSymPointer;
                  for (int i = symPointer; i < expressionStack.Length; i++) expressionStack[i] = "";
                  SaveElement(" < ");
                  PL3();
               }
            }
            else if (NextIs(Symbols.opensquare))
            {
               SaveElement(".Substring(");
               Expression();
               if (NextIs(Symbols.closesquare))
               {
                  SaveElement(")");
                  done = true;
               }
               else if (NextIs(Symbols.comma))
               {
                  SaveElement(",");
                  Expression();
                  if (NextIs(Symbols.closesquare))
                  {
                     SaveElement(")");
                     done = true;
                  }
                  else
                  {
                     throw new ApplicationException("Substring not closed");
                  }
               }
               else
               {
                  throw new ApplicationException("Substring not closed");
               }
            }
            else
            {
               done = true;
            }
         } while (!done);
         return CompileResult.OK;
      }
      //CompileResult PL4()
      //{
      //   PL5();
      //   bool done = false;
      //   do
      //   {
      //      if (NextIs(Symbols.opensquare))
      //      {
      //         SaveElement(".Substring(");
      //         PL5();
      //         if (NextIs(Symbols.closesquare))
      //         {
      //            SaveElement(")");
      //            done = true;
      //         }
      //         else if (NextIs(Symbols.comma))
      //         {
      //            SaveElement(",");
      //            PL5();
      //            if (NextIs(Symbols.closesquare))
      //            {
      //               SaveElement(")");
      //               done = true;
      //            }
      //            else
      //            {
      //               throw new ApplicationException("Substring not closed");
      //            }
      //         }
      //         else
      //         {
      //            throw new ApplicationException("Substring not closed");
      //         }
      //      }
      //      else
      //      {
      //         done = true;
      //      }
      //   } while (!done);
      //   return CompileResult.OK;
      //}
      CompileResult PL4()
      {

         if (NextIs(Symbols.int_lit))
         {
            SaveElement("NumericLiteral");
         }
         else if (NextIs(Symbols.str_lit))
         {
            SaveElement("StringLiteral");
         }
         else if (NextIs(Symbols.ident))
         {
            SaveElement("Identifier");
         }
         else if (NextIs(Symbols.openbracket))
         {
            SaveElement("(");
            Expression();
            if (NextIs(Symbols.closebracket))
            {
               SaveElement(")");
               return CompileResult.OK;
            }
            else
            {
               throw new ApplicationException("No closing bracket");
            }
         }
         else
         {
            //done = true;
            //throw new ApplicationException("Invalid symbol in PL5");
         }
         return CompileResult.OK;
      }
      bool NextIs(Symbols symbol)
      {
         if (symbolList[symPointer] == symbol)
         {
            symPointer++;
            return true;
         }
         else
         {
            return false;
         }
      }
      void SaveElement(string element)
      {
         expressionStack[symPointer] = element;
      }
   }

}
