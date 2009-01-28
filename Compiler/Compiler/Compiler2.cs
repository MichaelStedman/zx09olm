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

PL3        := PL4 '<' PL4 '>' |
              PL4 '<' PL4 ',' PL4 '>' |
              PL4 '<' PL4 ',' PL4 ',' PL4 '>'

PL4        := PL5 '[' PL5 ']' |
              PL5 '[' PL5 ',' PL5 ']'        

PL5        := int_lit_sym |
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
         Continue,
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

         CompileResult done = Expression();

         if (done == CompileResult.OK)
         {
            for (int i = 0; i <= symPointer; i++)
            {
               Console.Write(expressionStack[i]);
            }
         }
      }
      CompileResult Expression()
      {
         CompileResult done = PL0();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.concat))
            {
               SaveElement(":");
               done = PL0();
            }
            else
            {
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL0()
      {
         CompileResult done = PL1();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.plus))
            {
               SaveElement("+");
               done = PL1();
            }
            else if (NextIs(Symbols.minus))
            {
               SaveElement("-");
               done = PL1();
            }
            else
            {
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL1()
      {
         CompileResult done = PL2();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.multiply))
            {
               SaveElement("*");
               done = PL2();
            }
            else if (NextIs(Symbols.divide))
            {
               SaveElement("/");
               done = PL2();
            }
            else
            {
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL2()
      {
         CompileResult done = PL3();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.lt))
            {
               SaveElement(" never used ");
               done = PL3();
            }
            else if (NextIs(Symbols.lte))
            {
               SaveElement(" <= ");
               done = PL3();
            }
            else if (NextIs(Symbols.eq))
            {
               SaveElement(" == ");
               done = PL3();
            }
            else if (NextIs(Symbols.gte))
            {
               SaveElement(" >= ");
               done = PL3();
            }
            else if (NextIs(Symbols.gt))
            {
               SaveElement(" > ");
               done = PL3();
            }
            else if (NextIs(Symbols.neq))
            {
               SaveElement(" != ");
               done = PL3();
            }
            else
            {
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL3()
      {
         int saveSymPointer = 0;

         CompileResult done = PL4();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.lt))
            {
               SaveElement("[");
               saveSymPointer = symPointer; // It might be condition not DynArray
               Expression();
               if (NextIs(Symbols.gt))
               {
                  SaveElement("]");
                  done = PL4();
                  done = CompileResult.OK;
               }
               else if (NextIs(Symbols.comma))
               {
                  SaveElement(" ,");
                  Expression();
                  if (NextIs(Symbols.gt))
                  {
                     SaveElement("]");
                     done = PL4();
                     done = CompileResult.OK;
                  }
                  else if (NextIs(Symbols.comma))
                  {
                     SaveElement(" ,");
                     done = PL4();
                     if (NextIs(Symbols.gt))
                     {
                        SaveElement("]");
                        done = PL4();
                        done = CompileResult.OK;
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

            else
            {
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL4()
      {
         CompileResult done = PL5();
         while (done == CompileResult.Continue)
         {
            if (NextIs(Symbols.opensquare))
            {
               SaveElement(".Substring(");
               done = PL5();
               if (NextIs(Symbols.closesquare))
               {
                  SaveElement(")");
                  done = CompileResult.OK;
               }
               else if (NextIs(Symbols.comma))
               {
                  SaveElement(",");
                  done = PL5();
                  if (NextIs(Symbols.closesquare))
                  {
                     SaveElement(")");
                     done = CompileResult.OK;
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
               done = CompileResult.OK;
            }
         }
         return done;
      }
      CompileResult PL5()
      {
         CompileResult done = CompileResult.Continue;

         if (NextIs(Symbols.ident))
         {
            SaveElement("Identifier");
         }
         else if (NextIs(Symbols.int_lit))
         {
            SaveElement("NumericLiteral");
         }
         else if (NextIs(Symbols.str_lit))
         {
            SaveElement("StringLiteral");
         }
         else if (NextIs(Symbols.openbracket))
         {
            SaveElement("(");
            Expression();
            if (NextIs(Symbols.closebracket))
            {
               SaveElement(")");
               return done;
            }
            else
            {
               throw new ApplicationException("No closing bracket");
            }
         }
         else
         {
            //done = CompileResult.OK;
            //throw new ApplicationException("Invalid symbol in PL5");
         }
         return done;
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
