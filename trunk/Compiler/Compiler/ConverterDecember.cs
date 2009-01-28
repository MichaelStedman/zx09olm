using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   class ConverterDecember
   {
      Stack<string> expressionStack = new Stack<string>();

      int symPointer = 0;
      Symbol[] symbolList = new Symbol[15];

      enum Symbol
      {
         eof, ident, number, lparen, rparen, multiply, divide, plus,
         minus, eq, neq, lt, lte, gt, gte, callsym, beginsym, semicolon,
         endsym, ifsym, becomes, thensym, constsym, comma,
         varsym, procsym, oddsym, or, and
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

      void factor()
      {
         if (accept(Symbol.ident))
         {
            expressionStack.Push("IDENT");
         }
         else if (accept(Symbol.number))
         {
            expressionStack.Push("NUMBER");
         }
         else if (accept(Symbol.lparen))
         {
            or_expr();
            expect(Symbol.rparen);
         }
         else
         {
            error("factor: syntax error");
            getsym();
         }
      }

      void term()
      {

         factor();
         while (sym == Symbol.multiply || sym == Symbol.divide)
         {
            expressionStack.Push(sym.ToString().ToUpper());
            getsym();
            // Unary minus after multiply/divide
            if (sym == Symbol.plus || sym == Symbol.minus) getsym();
            factor();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
      }

      void expression()
      {
         if (sym == Symbol.plus || sym == Symbol.minus) getsym();
         term();
         while (sym == Symbol.plus || sym == Symbol.minus)
         {
            expressionStack.Push(sym.ToString().ToUpper());
            getsym();
            term();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
      }
      void and_expr()
      {
         condition();
         while (sym == Symbol.and)
         {
            expressionStack.Push(sym.ToString().ToUpper());
            getsym();
            condition();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
      }
      void or_expr()
      {
         and_expr();
         while (sym == Symbol.or)
         {
            expressionStack.Push(sym.ToString().ToUpper());
            getsym();
            and_expr();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
      }
      void condition()
      {
         if (accept(Symbol.oddsym))
         {
            expression();
         }
         else
         {
            expression();
            if (sym == Symbol.eq || sym == Symbol.neq || sym == Symbol.lt ||
                sym == Symbol.lte || sym == Symbol.gt || sym == Symbol.gte)
            {
               //if (sym == Symbol.lt)
               //{
               //   ConditionOrDynArray();
               //}
               //else if (sym == Symbol.gt)
               //{

               //}
               //else
               //{
               //   expressionStack.Push(sym.ToString().ToUpper());
               //   getsym();
               //   expression();
               //   expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
               //}
            }
            else
            {
               //error("condition: invalid operator");
               //getsym();
            }
         }
      }
      void ConditionOrDynArray()
      {
         int saveSymPointer = symPointer;
         expressionStack.Push("DynArray?");
         getsym();
         or_expr();
         if (sym == Symbol.gt)
         {
            // dynArray
            expressionStack.Push(string.Format("{2}.Extract({0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         else
         {
            expressionStack.Push(string.Format("{2} LT {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }

      }
      void statement()
      {
         if (accept(Symbol.ident))
         {
            expressionStack.Push("IDENT");
            expect(Symbol.becomes);
            expressionStack.Push(Symbol.becomes.ToString().ToUpper());
            or_expr();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         else if (accept(Symbol.callsym))
         {
            expect(Symbol.ident);
         }
         else if (accept(Symbol.beginsym))
         {
            do
            {
               statement();
            } while (accept(Symbol.semicolon));
            expect(Symbol.endsym);
         }
         else if (accept(Symbol.ifsym))
         {
            condition();
            expect(Symbol.thensym);
            statement();
         }
      }

      void block()
      {
         if (accept(Symbol.constsym))
         {
            do
            {
               expect(Symbol.ident);
               expect(Symbol.eq);
               expect(Symbol.number);
            } while (accept(Symbol.comma));
            expect(Symbol.semicolon);
         }
         if (accept(Symbol.varsym))
         {
            do
            {
               expect(Symbol.ident);
            } while (accept(Symbol.comma));
            expect(Symbol.semicolon);
         }
         while (accept(Symbol.procsym))
         {
            expect(Symbol.ident);
            expect(Symbol.semicolon);
            block();
            expect(Symbol.semicolon);
         }
         statement();
      }
      public void program()
      {
         symbolList[0] = Symbol.ident;
         symbolList[1] = Symbol.becomes;
         symbolList[2] = Symbol.ident;
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident;
         symbolList[5] = Symbol.minus;
         symbolList[6] = Symbol.number;
         //symbolList[7] = Symbol.number;
         //symbolList[8] = Symbol.ident;
         //symbolList[9] = Symbol.ident;
         //symbolList[10] = Symbol.number;
         getsym();
         block();
         expect(Symbol.eof);
      }

      void error(string text)
      {
         Console.WriteLine(text);
      }
   }
}
