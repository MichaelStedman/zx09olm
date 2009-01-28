using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   class ConverterPM
   {
      Stack<string> expressionStack = new Stack<string>();

      int symPointer = 0;
      Symbol[] symbolList = new Symbol[20];
      string[] tokenList = new string[20];

      enum Symbol
      {
         eof, ident, number, lparen, rparen, multiply, divide, plus,
         minus, eq, neq, lt, lte, gt, gte, callsym, beginsym, semicolon,
         endsym, ifsym, becomes, thensym, constsym, comma,
         varsym, procsym, oddsym, or, and, concat, text, openbracket, closebracket,
         opensquarebracket, closesquarebracket
      } ;

      Symbol sym;

      void getsym()
      {
         sym = symbolList[symPointer++];
      }
      bool accept(Symbol s)
      {
         if (sym == s)
         {
            getsym();
            return true;
         }
         return false;
      }

      bool expect(Symbol s)
      {
         if (accept(s)) return true;
         error("expect: unexpected symbol");
         return false;
      }
      public ConverterPM()
      {
         symbolList[0] = Symbol.ident; tokenList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; tokenList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; tokenList[4] = "C";
         symbolList[5] = Symbol.lt;
         symbolList[6] = Symbol.ident; tokenList[6] = "D";
         symbolList[7] = Symbol.gt;
         symbolList[8] = Symbol.gt;
         symbolList[9] = Symbol.gt;
         symbolList[10] = Symbol.ident; tokenList[10] = "D";
         symbolList[11] = Symbol.gt;
         //symbolList[11] = Symbol.ident;
         //symbolList[12] = Symbol.comma;
         //symbolList[13] = Symbol.ident;
         //symbolList[14] = Symbol.comma;
         //symbolList[15] = Symbol.ident;
         //symbolList[16] = Symbol.gt;
         //symbolList[0] = Symbol.ident; tokenList[0] = "REC";
         //symbolList[1] = Symbol.eq;
         //symbolList[2] = Symbol.text; tokenList[2] = "mike";
         //symbolList[3] = Symbol.gt;
         //symbolList[4] = Symbol.ident; tokenList[4] = "JUST";



         expression();
         Stack<string> reversed = new Stack<string>();
         int popCount = expressionStack.Count;
         for (int i = 0; i < popCount; i++)
         {
            reversed.Push(expressionStack.Pop());
         }
         Console.WriteLine("Start");
         for (int i = 0; i < popCount; i++)
         {
            Console.Write(reversed.Pop() + " ");
         }
         Console.WriteLine();
         Console.WriteLine("End");
      }
      void expression()
      {
         int saveSymPointer;
         getsym();
         while (sym != Symbol.eof)
         {
            switch (sym)
            {
               case Symbol.number:
                  {
                     expressionStack.Push(tokenList[symPointer-1]);
                     break;
                  }
               case Symbol.text:
                  {
                     expressionStack.Push("\"" + tokenList[symPointer - 1] + "\"");
                     break;
                  }
               case Symbol.concat:
                  {
                     // Addition
                     expressionStack.Push(":");
                     break;
                  }
               case Symbol.ident:
                  {
                     expressionStack.Push(tokenList[symPointer - 1]);
                     saveSymPointer = symPointer;
                     getsym();
                     switch (sym)
                     {
                        case Symbol.opensquarebracket:
                           {
                              expressionStack.Push("[");
                              expression();
                              if (sym == Symbol.comma)
                              {
                                 expressionStack.Push(",");
                                 expression();
                              }
                              if (sym != Symbol.closesquarebracket)
                              {
                                 throw new ApplicationException("Invalid Substring Reference");
                              }
                              expressionStack.Push("]");
                              break;
                           }
                        case Symbol.openbracket:
                           {
                              expressionStack.Push("(");
                              expression();
                              if (sym == Symbol.comma)
                              {
                                 expressionStack.Push(",");
                                 expression();
                              }
                              if (sym != Symbol.closebracket)
                              {
                                 throw new ApplicationException("Invalid Array Reference");
                              }
                              expressionStack.Push(")");
                              break;
                           }
                        case Symbol.lt:
                           {
                              saveSymPointer = symPointer;
                              expressionStack.Push("<");
                              if (daexpression())
                              {
                                 if (sym == Symbol.gt)
                                 {
                                    //dynarray<1>
                                    expressionStack.Push(string.Format("{2}.Extract({0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                                 }
                                 else if (sym == Symbol.comma)
                                 {
                                    expressionStack.Push(", ");
                                    if (daexpression())
                                    {
                                       if (sym == Symbol.gt)
                                       {
                                          //dynarray<1,1>
                                          expressionStack.Push(string.Format("{4}.Extract({2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                                       }
                                       else if (sym == Symbol.comma)
                                       {
                                          expressionStack.Push(", ");
                                          if (daexpression())
                                          {
                                             if (sym == Symbol.gt)
                                             {
                                                //dynarray<1,1,1>
                                                expressionStack.Push(string.Format("{6}.Extract({4}, {2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                                             }
                                          }
                                       }
                                    }
                                 }
                              }
                              else
                              {
                                 expressionStack.Pop();
                                 expressionStack.Pop();
                                 symPointer = saveSymPointer - 1;
                              }
                              break;
                           }
                        case Symbol.gt:
                           {
                              // Condition
                              expressionStack.Push("GT");
                              break;
                           }
                        case Symbol.eq:
                           {
                              // Condition
                              expressionStack.Push("EQ");
                              break;
                           }
                        case Symbol.neq:
                           {
                              // Condition
                              expressionStack.Push("NE");
                              break;
                           }
                        case Symbol.lte:
                           {
                              // Condition
                              expressionStack.Push("LE");
                              break;
                           }
                        case Symbol.gte:
                           {
                              // Condition
                              expressionStack.Push("GE");
                              break;
                           }
                        case Symbol.and:
                           {
                              // Condition
                              expressionStack.Push(string.Format("{2} {1} {0} AND", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                              break;
                           }
                        case Symbol.or:
                           {
                              // Condition
                              expressionStack.Push(string.Format("{2} {1} {0} OR", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                              break;
                           }
                        case Symbol.plus:
                           {
                              // Addition
                              expressionStack.Push("+");
                              break;
                           }
                        case Symbol.minus:
                           {
                              // Addition
                              expressionStack.Push("-");
                              break;
                           }
                        case Symbol.multiply:
                           {
                              // Addition
                              expressionStack.Push("*");
                              break;
                           }
                        case Symbol.divide:
                           {
                              // Addition
                              expressionStack.Push("/");
                              break;
                           }
                        case Symbol.concat:
                           {
                              // Addition
                              expressionStack.Push(":");
                              break;
                           }
                        default:
                           {
                              symPointer = saveSymPointer;
                              expression();
                              expressionStack.Push(string.Format("{1}.Justify({0})", expressionStack.Pop(), expressionStack.Pop()));
                              break;
                           }
                     }
                     break;
                  }
               case Symbol.gt:
                  {
                     // Condition
                     expressionStack.Push("GT");
                     break;
                  }
               case Symbol.lt:
                  {
                     // Condition
                     expressionStack.Push("LT");
                     break;
                  }
               default: return;
            }
            getsym();
         }
      }
      bool daexpression()
      {
         int saveSymPointer = symPointer;
         getsym();
         while (sym != Symbol.eof)
         {

            if (sym == Symbol.ident || sym == Symbol.number)
            {
               expressionStack.Push(tokenList[symPointer - 1]);
               getsym();
               if (sym == Symbol.lt)
               {
                  //saveSymPointer = symPointer;
                  expressionStack.Push("<");
                  if (daexpression())
                  {
                     if (sym == Symbol.gt)
                     {
                        //dynarray
                        expressionStack.Push(string.Format("{2}.Extract({0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                        getsym();
                        return true;
                     }
                     else if (sym == Symbol.comma)
                     {
                        expressionStack.Push(", ");
                        if (daexpression())
                        {
                           if (sym == Symbol.gt)
                           {
                              //dynarray
                              expressionStack.Push(string.Format("{4}.Extract({2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                              break;
                           }
                           else if (sym == Symbol.comma)
                           {
                              expressionStack.Push(", ");
                              if (daexpression())
                              {
                                 if (sym == Symbol.gt)
                                 {
                                    //dynarray
                                    expressionStack.Push(string.Format("{6}.Extract({4}, {2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                                    break;
                                 }
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     expressionStack.Pop();
                     expressionStack.Pop();
                     symPointer = saveSymPointer - 1;
                  }
               }
               else if (sym == Symbol.gt)
               {
                  return true;
               }
               else if (sym == Symbol.comma)
               {
                  return true;
               }
               symPointer = saveSymPointer - 1;
               return false;
               
            }
            getsym();
         }
         return false;
      }
      void error(string text)
      {
         Console.WriteLine(text);
      }
   }
}
