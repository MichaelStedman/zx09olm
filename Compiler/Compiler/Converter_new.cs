using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   /*
assignment := variable '=' expression
    
variable   := ident
              arrayvar
              dynarrayvar
              substring
    
arrayvar   := ident '(' expression ')'
              ident '(' expression ',' expression ')'

dynarrayvar:= ident '<' expression '>'   
              ident '<' expression ',' expression '>'
              ident '<' expression ',' expression ',' expression '>'

substring  := ident '[' expression ']'
              ident '[' expression ',' expression ']'
    
filevar    := ident
              ident '(' expression ')'
              ident '(' expression ',' expression ')'

expression := operand operator expression

operand    := numlit
              strlit
              variable
              function
              '(' expression ')'

operator   := 'or'
              'and'
              '<'
              '>'
              '='
              '<='
              '>='
              '<>'
              '#'
              'matches'
              '+'
              '-'
              '*'
              '/'
              ':'    

    */
   class Converter
   {
      int callLevel = 0;

      Stack<string> expressionStack = new Stack<string>();

      Symbols[] symbolList = new Symbols[100];
      string[] identList = new string[100];
      int symPointer = 0;


      public string Convert(Symbols[] symbolList, string[] identList)
      {

         this.symbolList = symbolList;
         this.identList = identList;
         StringBuilder result = new StringBuilder();
         if (Expression())
         {
            for (int i = 0; i <= expressionStack.Count; i++)
            {
               result.Append(expressionStack.Pop() + " ");
            }
         }
         return result.ToString();
      }
      bool Assignment()
      {
         TraceIn("Assignment");
         /*
         variable '=' expression
         */
         TraceOut("Assignment", false);
         return false;
      }

      bool Variable()
      {
         /*
         ident
         arrayvar
         dynarrayvar
         substring
         */
         TraceIn("Variable");

         if (ArrayVar())
         {
            TraceOut("Variable", true);
            return true;
         }
         else if (NextIs(Symbols.ident))
         {
            expressionStack.Push(identList[symPointer - 1]);
            TraceOut("Variable", true);
            return true; // ident
         }
         TraceOut("Variable", false);
         return false;
      }
      bool ArrayVar()
      {
         /*
         ident '(' expression ')'
         ident '(' expression ',' expression ')'
         */
         TraceIn("ArrayVar");
         int saveSymPointer = symPointer;

         if (NextIs(Symbols.ident))
         {
            expressionStack.Push(identList[symPointer - 1]);
            if (NextIs(Symbols.openbracket))
            {
               if (Expression())
               {
                  if (NextIs(Symbols.closebracket))
                  {
                     expressionStack.Push(string.Format("{1}[{0}]", expressionStack.Pop(), expressionStack.Pop()));
                     TraceOut("ArrayVar", true);
                     return true; // ident '(' expression ')'
                  }
                  else if (NextIs(Symbols.comma))
                  {
                     if (Expression())
                     {
                        if (NextIs(Symbols.closebracket))
                        {
                           expressionStack.Push(string.Format("{2}[{1}, {0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                           TraceOut("ArrayVar", true);
                           return true; // ident '(' expression ',' expression ')'
                        }
                     }
                  }
                  else
                  {
                     expressionStack.Pop();
                     symPointer = saveSymPointer + 1;
                     TraceOut("ArrayVar", true);
                     return true;
                  }
               }
               else
               {
                  expressionStack.Pop();
                  symPointer = saveSymPointer;
                  TraceOut("ArrayVar", true);
                  return true;
               }
            }
            else
            {
               expressionStack.Pop();
               symPointer = saveSymPointer;
               TraceOut("ArrayVar", false);
               return false;
            }
         }
         TraceOut("ArrayVar", false);
         return false;
      }
      bool Expression()
      {
         TraceIn("Expression");
         if (ResultStr())
         {
            if (ResultStr())
            {
               expressionStack.Push(string.Format("{1}.Justify({0})", expressionStack.Pop(), expressionStack.Pop()));
               TraceOut("Expression", true);
               return true;
            }
            else
            {
               TraceOut("Expression", true);
               return true;
            }
         }
         TraceOut("Expression", false);
         return false;
      }
      bool ResultStr()
      {
         TraceIn("ResultStr");
         if (BinaryOp())
         {
            if (DynArrayRef())
            {
               if (Substring())
               {
                  expressionStack.Push(string.Format("{1}", expressionStack.Pop()));
                  TraceOut("ResultStr", true);
                  return true;
               }
            }
            else if (Substring())
            {
               expressionStack.Push(string.Format("{1}", expressionStack.Pop()));
               TraceOut("ResultStr", true);
               return true;
            }
            else
            {
               TraceOut("ResultStr", true);
               return true;
            }
         }

         TraceOut("ResultStr", false);
         return false;
      }
      bool DynArrayRef()
      {
         /*
         ident '<' expression '>'
         ident '<' expression ',' expression '>'
         ident '<' expression ',' expression ',' expression '>'
         */
         TraceIn("DynArrayVar");
         int saveSymPointer = symPointer;

         //expressionStack.Push(identList[symPointer - 1]);
         if (NextIs(Symbols.lt))
         {
            if (Expression())
            {
               if (NextIs(Symbols.gt))
               {
                  expressionStack.Push(string.Format("{1}.Extract({0})", expressionStack.Pop(), expressionStack.Pop()));
                  TraceOut("DynArrayVar", true);
                  return true; // ident '<' expression '>'
               }
               else if (NextIs(Symbols.comma))
               {
                  if (Expression())
                  {
                     if (NextIs(Symbols.gt))
                     {
                        expressionStack.Push(string.Format("{2}.Extract({1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                        TraceOut("DynArrayVar", true);
                        return true; // ident '<' expression ',' expression '>'
                     }
                     else if (NextIs(Symbols.comma))
                     {
                        if (Expression())
                        {
                           if (NextIs(Symbols.gt))
                           {
                              expressionStack.Push(string.Format("{3}.Extract({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                              TraceOut("DynArrayVar", true);
                              return true; // ident '<' expression ',' expression ',' expression '>'
                           }
                        }
                     }
                  }
               }
               else
               {
                  expressionStack.Pop();
                  symPointer = saveSymPointer + 1;
                  TraceOut("DynArrayVar", true);
                  return true;
               }
            }
            else
            {
               expressionStack.Pop();
               symPointer = saveSymPointer;
               TraceOut("DynArrayVar", true);
               return true;
            }
         }
         else
         {
            //expressionStack.Pop();
            //symPointer = saveSymPointer;
            TraceOut("DynArrayVar", false);
            return false;
         }
         TraceOut("DynArrayVar", false);
         return false;
      }
      bool Substring()
      {
         /*
         ident '[' expression ']'
         ident '[' expression ',' expression ']'
         */
         TraceIn("SubstringVar");
         int saveSymPointer = symPointer;

         //expressionStack.Push(identList[symPointer - 1]);
         if (NextIs(Symbols.opensquare))
         {
            if (Expression())
            {
               if (NextIs(Symbols.closesquare))
               {
                  expressionStack.Push(string.Format("{1}.Substring({0})", expressionStack.Pop(), expressionStack.Pop()));
                  TraceOut("SubstringVar", true);
                  return true; // ident '[' expression ']'
               }
               else if (NextIs(Symbols.comma))
               {
                  if (Expression())
                  {
                     if (NextIs(Symbols.closesquare))
                     {
                        expressionStack.Push(string.Format("{2}.Substring({1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                        TraceOut("SubstringVar", true);
                        return true; // ident '[' expression ',' expression ']'
                     }
                  }
               }
               else
               {
                  expressionStack.Pop();
                  symPointer = saveSymPointer + 1;
                  TraceOut("SubstringVar", true);
                  return true;
               }
            }
            else
            {
               expressionStack.Pop();
               symPointer = saveSymPointer;
               TraceOut("SubstringVar", true);
               return true;
            }
         }
         else
         {
            //expressionStack.Pop();
            //symPointer = saveSymPointer;
            TraceOut("SubstringVar", false);
            return false;
         }
         TraceOut("SubstringVar", false);
         return false;
      }
      bool BinaryOp()
      {
         /*
         operand 
         operand operator BinaryOp
         */
         TraceIn("BinaryOp");
         int saveSymPointer = symPointer;

         if (Operand())
         {
            if (Operator())
            {
               // move these to make it consistent
               //saveSymPointer = symPointer;
               //saveSymPointer--;

               if (BinaryOp())
               {
                  expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                  TraceOut("BinaryOp", true);
                  return true;
               }
               else
               {
                  // do I need to rework stack here with the Operator?
                  expressionStack.Pop();
                  symPointer = saveSymPointer;
                  TraceOut("BinaryOp", true);
                  return false;
               }
            }
            else
            {
               // do I need to rework stack here with the Operator?
               TraceOut("BinaryOp", true);
               return true;
            }
         }
         else
         {
            // do I need to rework stack here with the Operator?

            TraceOut("BinaryOp", false);
            return false;
         }
         TraceOut("BinaryOp", false);
         return false;
      }
      bool Operand()
      {
         /*
         numlit
         strlit
         variable
         function
         '(' expression ')'
         */

         TraceIn("Operand");
         if (NextIs(Symbols.int_lit))
         {
            TraceOut("Operand", true);
            return true;
         }
         if (NextIs(Symbols.str_lit))
         {
            TraceOut("Operand", true);
            return true;
         }
         if (Variable())
         {
            TraceOut("Operand", true);
            return true;
         }
         if (Function())
         {
            TraceOut("Operand", true);
            return true;
         }
         if (NextIs(Symbols.openbracket))
         {
            if (Expression())
            {
               if (NextIs(Symbols.closebracket))
               {
                  TraceOut("Operand", true);
                  return true;
               }
            }
         }

         TraceOut("Operand", false);
         return false;
      }
      bool Operator()
      {
         /*
         'or'
         'and'
         '<'
         '>'
         '='
         '<='
         '>='
         '<>'
         '#'
         'matches'
         '+'
         '-'
         '*'
         '/'
         ':' 
         */
         TraceIn("Operator");
         if (NextIs(Symbols.or))
         {
            expressionStack.Push("OR");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.and))
         {
            expressionStack.Push("AND");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.lt))
         {
            expressionStack.Push("LT");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.gt))
         {
            expressionStack.Push("GT");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.eq))
         {
            expressionStack.Push("EQ");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.lte))
         {
            expressionStack.Push("LE");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.gte))
         {
            expressionStack.Push("GE");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.neq))
         {
            expressionStack.Push("NE");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.matches))
         {
            expressionStack.Push("MATCHES");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.plus))
         {
            expressionStack.Push("+");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.minus))
         {
            expressionStack.Push("-");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.multiply))
         {
            expressionStack.Push("*");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.divide))
         {
            expressionStack.Push("/");
            TraceOut("Operator", true);
            return true;
         }
         if (NextIs(Symbols.concat))
         {
            expressionStack.Push(":");
            TraceOut("Operator", true);
            return true;
         }

         TraceOut("Operator", false);
         return false;
      }
      bool Function()
      {
         TraceIn("Function");
         TraceOut("Function", false);
         return false;
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

      void TraceIn(string text)
      {
         string spaces = new string(' ', callLevel++);
         Console.WriteLine(">" + spaces + text);
      }
      void TraceOut(string text, bool success)
      {
         string spaces = new string(' ', --callLevel);
         Console.WriteLine("<" + spaces + text + " " + success.ToString());
      }
   }
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
      ident,
      or,
      and,
      matches
   }
}