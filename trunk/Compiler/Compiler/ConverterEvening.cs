using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Compiler
{

   class ConverterEvening
   {
      Stack<string> expressionStack = new Stack<string>();

      int symPointer = 0;
      Symbol[] symbolList;
      string[] identList;
      Dictionary<string, VarUsage> variableNames = new Dictionary<string, VarUsage>();
      Dictionary<string, Dictionary<string, string>> commonVars = new Dictionary<string, Dictionary<string, string>>();
      IList<string> argumentVars = new List<string>();
      Dictionary<string, string> dimVars = new Dictionary<string, string>();
      Dictionary<string, string> equateVars = new Dictionary<string, string>();
      Dictionary<string, string> intConsts = new Dictionary<string, string>();
      Dictionary<string, string> stringConsts = new Dictionary<string, string>();
      int nonrefVarsCount = 0;
      Symbol sym;
      Dictionary<string, Symbol> keyWords = new Dictionary<string, Symbol>();
      int callLevel = 0;
      Stack<string> tracestack = new Stack<string>();
      OrderedDictionary labels = new OrderedDictionary();
      string inputPath;
      string inputFile;
      string inputItem;
      bool firstCaseStatement = true;
      int pass = 1;
      bool simpleVariable = false;

      //=======================================================================
      public ConverterEvening()
      {
         // Conditional Operators
         keyWords.Add("EQ", Symbol.eq);
         keyWords.Add("NE", Symbol.neq);
         keyWords.Add("LT", Symbol.lt);
         keyWords.Add("LE", Symbol.lte);
         keyWords.Add("GT", Symbol.gt);
         keyWords.Add("GE", Symbol.gte);
         keyWords.Add("AND", Symbol.and);
         keyWords.Add("OR", Symbol.or);

         keyWords.Add(Symbol.MATCH.ToString(), Symbol.MATCH);
         keyWords.Add(Symbol.MATCHES.ToString(), Symbol.MATCHES);
         keyWords.Add("_", Symbol.underscore);

         // Load the Statement Keywords
         keyWords.Add(Symbol.BEFORE.ToString(), Symbol.BEFORE);
         keyWords.Add(Symbol.BEGIN.ToString(), Symbol.BEGIN);
         keyWords.Add(Symbol.BREAK.ToString(), Symbol.BREAK);
         keyWords.Add(Symbol.BY.ToString(), Symbol.BY);
         keyWords.Add(Symbol.CALL.ToString(), Symbol.CALL);
         keyWords.Add(Symbol.CAPTURING.ToString(), Symbol.CAPTURING);
         keyWords.Add(Symbol.CASE.ToString(), Symbol.CASE);
         keyWords.Add(Symbol.CHAIN.ToString(), Symbol.CHAIN);
         keyWords.Add(Symbol.CLEARFILE.ToString(), Symbol.CLEARFILE);
         keyWords.Add(Symbol.CLOSE.ToString(), Symbol.CLOSE);
         keyWords.Add(Symbol.CLOSESEQ.ToString(), Symbol.CLOSESEQ);
         keyWords.Add(Symbol.COMMON.ToString(), Symbol.COMMON);
         keyWords.Add(Symbol.CREATE.ToString(), Symbol.CREATE);
         keyWords.Add(Symbol.CRT.ToString(), Symbol.CRT);
         keyWords.Add(Symbol.DATA.ToString(), Symbol.DATA);
         keyWords.Add(Symbol.DEFFUN.ToString(), Symbol.DEFFUN);
         keyWords.Add(Symbol.DEL.ToString(), Symbol.DEL);
         keyWords.Add(Symbol.DELETE.ToString(), Symbol.DELETE); // Statement and Function
         keyWords.Add(Symbol.DIM.ToString(), Symbol.DIM);
         keyWords.Add(Symbol.DISPLAY.ToString(), Symbol.CRT); // DISPLAY is a synonym of CRT
         keyWords.Add(Symbol.DO.ToString(), Symbol.DO);
         keyWords.Add(Symbol.ECHO.ToString(), Symbol.ECHO);
         keyWords.Add(Symbol.ELSE.ToString(), Symbol.ELSE);
         keyWords.Add(Symbol.END.ToString(), Symbol.END);
         keyWords.Add(Symbol.EQU.ToString(), Symbol.EQU);
         keyWords.Add(Symbol.EQUATE.ToString(), Symbol.EQU);
         keyWords.Add(Symbol.EXECUTE.ToString(), Symbol.EXECUTE);
         keyWords.Add(Symbol.FILELOCK.ToString(), Symbol.FILELOCK);
         keyWords.Add(Symbol.FILEUNLOCK.ToString(), Symbol.FILEUNLOCK);
         keyWords.Add(Symbol.FOOTING.ToString(), Symbol.FOOTING);
         keyWords.Add(Symbol.FOR.ToString(), Symbol.FOR);
         keyWords.Add(Symbol.FROM.ToString(), Symbol.FROM);
         keyWords.Add(Symbol.GET.ToString(), Symbol.GET);
         keyWords.Add(Symbol.GO.ToString(), Symbol.GO);
         keyWords.Add(Symbol.GOSUB.ToString(), Symbol.GOSUB);
         keyWords.Add(Symbol.GOTO.ToString(), Symbol.GOTO);
         keyWords.Add(Symbol.HEADING.ToString(), Symbol.HEADING);
         keyWords.Add(Symbol.IF.ToString(), Symbol.IF);
         keyWords.Add(Symbol.IN.ToString(), Symbol.IN);
         keyWords.Add(Symbol.INS.ToString(), Symbol.INS);
         keyWords.Add(Symbol.INCLUDE.ToString(), Symbol.INCLUDE);
         keyWords.Add(Symbol.INPUT.ToString(), Symbol.INPUT);
         keyWords.Add(Symbol.LOCATE.ToString(), Symbol.LOCATE);
         keyWords.Add(Symbol.LOCK.ToString(), Symbol.LOCK);
         keyWords.Add(Symbol.LOCKED.ToString(), Symbol.LOCKED);
         keyWords.Add(Symbol.LOOP.ToString(), Symbol.LOOP);
         keyWords.Add(Symbol.MAT.ToString(), Symbol.MAT);
         keyWords.Add(Symbol.MATPARSE.ToString(), Symbol.MATPARSE);
         keyWords.Add(Symbol.MATREAD.ToString(), Symbol.MATREAD);
         keyWords.Add(Symbol.MATREADL.ToString(), Symbol.MATREADL);
         keyWords.Add(Symbol.MATREADU.ToString(), Symbol.MATREADU);
         keyWords.Add(Symbol.MATWRITE.ToString(), Symbol.MATWRITE);
         keyWords.Add(Symbol.MATWRITEU.ToString(), Symbol.MATWRITEU);
         keyWords.Add(Symbol.NAP.ToString(), Symbol.NAP);
         keyWords.Add(Symbol.NEXT.ToString(), Symbol.NEXT);
         keyWords.Add(Symbol.NULL.ToString(), Symbol.NULL);
         keyWords.Add(Symbol.OFF.ToString(), Symbol.OFF);
         keyWords.Add(Symbol.ON.ToString(), Symbol.ON);
         keyWords.Add(Symbol.OPEN.ToString(), Symbol.OPEN);
         keyWords.Add(Symbol.OPENSEQ.ToString(), Symbol.OPENSEQ);
         keyWords.Add(Symbol.PAGE.ToString(), Symbol.PAGE);
         keyWords.Add(Symbol.PASSLIST.ToString(), Symbol.PASSLIST);
         keyWords.Add(Symbol.PRINT.ToString(), Symbol.PRINT);
         keyWords.Add(Symbol.PRINTER.ToString(), Symbol.PRINTER);
         keyWords.Add(Symbol.PROMPT.ToString(), Symbol.PROMPT);
         keyWords.Add(Symbol.READ.ToString(), Symbol.READ);
         keyWords.Add(Symbol.READBLK.ToString(), Symbol.READBLK);
         keyWords.Add(Symbol.READNEXT.ToString(), Symbol.READNEXT);
         keyWords.Add(Symbol.READU.ToString(), Symbol.READU);
         keyWords.Add(Symbol.READVU.ToString(), Symbol.READVU);
         keyWords.Add(Symbol.READV.ToString(), Symbol.READV);
         keyWords.Add(Symbol.RELEASE.ToString(), Symbol.RELEASE);
         keyWords.Add(Symbol.REPEAT.ToString(), Symbol.REPEAT);
         keyWords.Add(Symbol.RETURN.ToString(), Symbol.RETURN);
         keyWords.Add(Symbol.RETURNING.ToString(), Symbol.RETURNING);
         keyWords.Add(Symbol.RQM.ToString(), Symbol.RQM);
         keyWords.Add(Symbol.RTNLIST.ToString(), Symbol.RTNLIST);
         keyWords.Add(Symbol.SELECT.ToString(), Symbol.SELECT);
         keyWords.Add(Symbol.SEND.ToString(), Symbol.SEND);
         keyWords.Add(Symbol.SETTING.ToString(), Symbol.SETTING);
         keyWords.Add(Symbol.SLEEP.ToString(), Symbol.SLEEP);
         keyWords.Add(Symbol.STEP.ToString(), Symbol.STEP);
         keyWords.Add(Symbol.STATUS.ToString(), Symbol.STATUS);
         keyWords.Add(Symbol.STOP.ToString(), Symbol.STOP);
         keyWords.Add(Symbol.SUBROUTINE.ToString(), Symbol.SUBROUTINE);
         keyWords.Add(Symbol.THEN.ToString(), Symbol.THEN);
         keyWords.Add(Symbol.TO.ToString(), Symbol.TO);
         keyWords.Add(Symbol.UNTIL.ToString(), Symbol.UNTIL);
         keyWords.Add(Symbol.WAITING.ToString(), Symbol.WAITING);
         keyWords.Add(Symbol.WEOFSEQ.ToString(), Symbol.WEOFSEQ);
         keyWords.Add(Symbol.WHILE.ToString(), Symbol.WHILE);
         keyWords.Add(Symbol.WRITE.ToString(), Symbol.WRITE);
         keyWords.Add(Symbol.WRITEBLK.ToString(), Symbol.WRITEBLK);
         keyWords.Add(Symbol.WRITESEQ.ToString(), Symbol.WRITESEQ);
         keyWords.Add(Symbol.WRITEU.ToString(), Symbol.WRITEU);
         keyWords.Add(Symbol.WRITEVU.ToString(), Symbol.WRITEVU);
         keyWords.Add(Symbol.WRITEV.ToString(), Symbol.WRITEV);

         // Load the Function Keywords
         keyWords.Add(Symbol.ABS.ToString(), Symbol.ABS);
         keyWords.Add(Symbol.ALPHA.ToString(), Symbol.ALPHA);
         keyWords.Add(Symbol.ASCII.ToString(), Symbol.ASCII);
         keyWords.Add(Symbol.ASSIGNED.ToString(), Symbol.ASSIGNED);
         keyWords.Add(Symbol.CHANGE.ToString(), Symbol.CHANGE);
         keyWords.Add(Symbol.CHAR.ToString(), Symbol.CHAR);
         keyWords.Add(Symbol.CHECKSUM.ToString(), Symbol.CHECKSUM);
         keyWords.Add(Symbol.COL1.ToString(), Symbol.COL1);
         keyWords.Add(Symbol.COL2.ToString(), Symbol.COL2);
         keyWords.Add(Symbol.CONVERT.ToString(), Symbol.CONVERT);
         keyWords.Add(Symbol.COUNT.ToString(), Symbol.COUNT);
         keyWords.Add(Symbol.DATE.ToString(), Symbol.DATE);
         keyWords.Add(Symbol.DCOUNT.ToString(), Symbol.DCOUNT);
         keyWords.Add(Symbol.DQUOTE.ToString(), Symbol.DQUOTE);
         keyWords.Add(Symbol.EBCDIC.ToString(), Symbol.EBCDIC);
         keyWords.Add(Symbol.EXTRACT.ToString(), Symbol.EXTRACT);
         keyWords.Add(Symbol.FIELD.ToString(), Symbol.FIELD);
         keyWords.Add(Symbol.ICONV.ToString(), Symbol.ICONV);
         keyWords.Add(Symbol.INDEX.ToString(), Symbol.INDEX);
         keyWords.Add(Symbol.INSERT.ToString(), Symbol.INSERT);
         keyWords.Add(Symbol.INT.ToString(), Symbol.INT);
         keyWords.Add(Symbol.KEYIN.ToString(), Symbol.KEYIN);
         keyWords.Add(Symbol.LEN.ToString(), Symbol.LEN);
         keyWords.Add(Symbol.LN.ToString(), Symbol.LN);
         keyWords.Add(Symbol.MOD.ToString(), Symbol.MOD);
         keyWords.Add(Symbol.NOT.ToString(), Symbol.NOT);
         keyWords.Add(Symbol.NUM.ToString(), Symbol.NUM);
         keyWords.Add(Symbol.OCONV.ToString(), Symbol.OCONV);
         keyWords.Add(Symbol.QUOTE.ToString(), Symbol.QUOTE);
         keyWords.Add(Symbol.REM.ToString(), Symbol.REM);
         keyWords.Add(Symbol.RND.ToString(), Symbol.RND);
         keyWords.Add(Symbol.REPLACE.ToString(), Symbol.REPLACE);
         keyWords.Add(Symbol.SEQ.ToString(), Symbol.SEQ);
         keyWords.Add(Symbol.SOUNDEX.ToString(), Symbol.SOUNDEX);
         keyWords.Add(Symbol.SPACE.ToString(), Symbol.SPACE);
         keyWords.Add(Symbol.STR.ToString(), Symbol.STR);
         keyWords.Add(Symbol.SYSTEM.ToString(), Symbol.SYSTEM);
         keyWords.Add(Symbol.TERMINFO.ToString(), Symbol.TERMINFO);
         keyWords.Add(Symbol.TIME.ToString(), Symbol.TIME);
         keyWords.Add(Symbol.TIMEDATE.ToString(), Symbol.TIMEDATE);
         keyWords.Add(Symbol.TRIM.ToString(), Symbol.TRIM);
         keyWords.Add(Symbol.UNASSIGNED.ToString(), Symbol.UNASSIGNED);
      }
      //=======================================================================
      bool accept(Symbol s)
      {
         if (sym == s)
         {
            getsym();
            return true;
         }
         return false;
      }
      //=======================================================================
      void getsym()
      {
         sym = symbolList[symPointer++];
      }
      //=======================================================================
      bool expect(Symbol s)
      {
         if (accept(s)) return true;
         error("expect: unexpected symbol");
         return false;
      }
      //=======================================================================
      bool nextis(Symbol s)
      {
         if (symbolList[symPointer] == s)
         {
            return true;
         }
         return false;
      }
      //=======================================================================
      void equStatement()
      {
         TraceIn("equStatement");
         if (sym == Symbol.multiply || sym == Symbol.pling)
         {
            comment();
            return;
         }
         if (sym == Symbol.number)
         {
            label();
         }
         if (accept(Symbol.EQU))
         {
            do
            {
               string ident = identList[symPointer - 1];
               getsym();
               expect(Symbol.TO);
               switch (sym)
               {
                  case Symbol.number:
                     {
                        factor();
                        intConsts.Add(ident, expressionStack.Pop());
                        break;
                     }
                  case Symbol.text:
                     {
                        factor();
                        stringConsts.Add(ident, expressionStack.Pop());
                        break;
                     }
                  case Symbol.ident:
                     {
                        if (nextis(Symbol.openround))
                        {
                           string identTo = identList[symPointer - 1];
                           accept(Symbol.ident);
                           expect(Symbol.openround);
                           factor();
                           string index = expressionStack.Pop();
                           intConsts.Add(ident, index);
                           equateVars.Add(ident, RenameIdent(identTo) + "[" + RenameIdent(ident) + "]");
                        }
                        else
                        {
                           factor();
                           string identTo = expressionStack.Pop();
                           equateVars.Add(ident, RenameIdent(identTo));
                        }
                        break;
                     }
               }
            } while (accept(Symbol.comma));
         }
         TraceOut("equStatement");
      }
      //=======================================================================
      void statementBlock()
      {
         do
         {
            statement();
         } while (accept(Symbol.semicolon));
      }
      //=======================================================================
      void statement()
      {
         TraceIn("statement");
         if (sym == Symbol.multiply || sym == Symbol.pling)
         {
            comment();
            return;
         }
         if (sym == Symbol.number)
         {
            label();
            if (sym == Symbol.multiply || sym == Symbol.pling)
            {
               comment();
               return;
            }
         }
         if (sym == Symbol.ident)
         {
            if (nextis(Symbol.colon))
            {
               label();
            }
         }
         if (sym == Symbol.ident)
         {
            assignment();
         }
         else
         {
            switch (sym)
            {
               case Symbol.BEGIN: { BEGIN(); break; }
               case Symbol.BREAK: { BREAK(); break; }
               case Symbol.CALL: { CALL(); break; }
               case Symbol.CASE: { CASE(); break; }
               case Symbol.CHAIN: { CHAIN(); break; }
               case Symbol.CLEARFILE: { CLEARFILE(); break; }
               case Symbol.CLOSE: { CLOSE(); break; }
               case Symbol.CLOSESEQ: { CLOSESEQ(); break; }
               case Symbol.CREATE: { CREATE(); break; }
               case Symbol.CRT: { CRT(); break; }
               case Symbol.DATA: { DATA(); break; }
               case Symbol.DEL: { DEL(); break; }
               case Symbol.DELETE: { DELETE(); break; }
               case Symbol.ECHO: { ECHO(); break; }
               case Symbol.END: { END(); break; }
               case Symbol.EXECUTE: { EXECUTE(); break; }
               case Symbol.FILELOCK: { FILELOCK(); break; }
               case Symbol.FILEUNLOCK: { FILEUNLOCK(); break; }
               case Symbol.FOOTING: { FOOTING(); break; }
               case Symbol.FOR: { FOR(); break; }
               case Symbol.GET: { GET(); break; }
               case Symbol.GO: { GO(); break; }
               case Symbol.GOSUB: { GOSUB(); break; }
               case Symbol.GOTO: { GOTO(); break; }
               case Symbol.HEADING: { HEADING(); break; }
               case Symbol.IF: { IF(); break; }
               case Symbol.INS: { INS(); break; }
               case Symbol.INPUT: { INPUT(); break; }
               case Symbol.LOCATE: { LOCATE(); break; }
               case Symbol.LOCK: { LOCK(); break; }
               case Symbol.LOOP: { LOOP(); break; }
               case Symbol.MAT: { MAT(); break; }
               case Symbol.MATPARSE: { MATPARSE(); break; }
               case Symbol.MATREAD: { MATREAD(); break; }
               case Symbol.MATREADL: { MATREADL(); break; }
               case Symbol.MATREADU: { MATREADU(); break; }
               case Symbol.MATWRITE: { MATWRITE(); break; }
               case Symbol.MATWRITEU: { MATWRITEU(); break; }
               case Symbol.NAP: { NAP(); break; }
               case Symbol.NEXT: { NEXT(); break; }
               case Symbol.NULL: { NULL(); break; }
               case Symbol.ON: { ON(); break; }
               case Symbol.OPEN: { OPEN(); break; }
               case Symbol.OPENSEQ: { OPENSEQ(); break; }
               case Symbol.PAGE: { PAGE(); break; }
               case Symbol.PRINT: { PRINT(); break; }
               case Symbol.PRINTER: { PRINTER(); break; }
               case Symbol.PROMPT: { PROMPT(); break; }
               case Symbol.READ: { READ(); break; }
               case Symbol.READBLK: { READBLK(); break; }
               case Symbol.READNEXT: { READNEXT(); break; }
               case Symbol.READU: { READU(); break; }
               case Symbol.READVU: { READVU(); break; }
               case Symbol.READV: { READV(); break; }
               case Symbol.RELEASE: { RELEASE(); break; }
               case Symbol.REPEAT: { REPEAT(); break; }
               case Symbol.RETURN: { RETURN(); break; }
               case Symbol.RQM: { RQM(); break; }
               case Symbol.SELECT: { SELECT(); break; }
               case Symbol.SEND: { SEND(); break; }
               case Symbol.SLEEP: { SLEEP(); break; }
               case Symbol.STATUS: { STATUS(); break; }
               case Symbol.STOP: { STOP(); break; }
               case Symbol.UNTIL: { UNTIL(); break; }
               case Symbol.WEOFSEQ: { WEOFSEQ(); break; }
               case Symbol.WHILE: { WHILE(); break; }
               case Symbol.WRITE: { WRITE(); break; }
               case Symbol.WRITEBLK: { WRITEBLK(); break; }
               case Symbol.WRITESEQ: { WRITESEQ(); break; }
               case Symbol.WRITEU: { WRITEU(); break; }
               case Symbol.WRITEVU: { WRITEVU(); break; }
               case Symbol.WRITEV: { WRITEV(); break; }
               // compiler directives
               case Symbol.COMMON: { COMMON(); break; }
               case Symbol.DIM: { DIM(); break; }
               case Symbol.EQU: { EQU(); break; }
               case Symbol.INCLUDE: { INCLUDE(); break; }
               case Symbol.SUBROUTINE: { SUBROUTINE(); break; }
            }
         }
         TraceOut("statement");
      }
      //=======================================================================
      void BEGIN()
      {
         getsym();
         expect(Symbol.CASE);
         expressionStack.Push("// BEGIN CASE");
         firstCaseStatement = true;
      }
      //=======================================================================
      void BREAK()
      {
         /*
         BREAK [KEY] {ON | OFF | expression}
         */
         getsym();
         accept(Symbol.KEY);
         if (accept(Symbol.ON))
         {
            expressionStack.Push(string.Format("BREAK(1);"));
            return;
         }
         if (accept(Symbol.OFF))
         {
            expressionStack.Push(string.Format("BREAK(0);"));
            return;
         }
         boolExpression();
         expressionStack.Push(string.Format("BREAK({0});", expressionStack.Pop()));

      }
      //=======================================================================
      void CALL()
      {
         /*
         CALL subroutine [( [MAT] argument [, [MAT] argument ...] )]
                                                           
         variable = 'subroutine'                                    
         CALL @variable [( [MAT] argument [, [MAT] argument ...] )] 
         */
         bool firstArgument = true;
         IList<string> nonrefVars = new List<string>();
         int saveSymPointer = symPointer;
         getsym();
         if (sym == Symbol.AT)
         {
            accept(Symbol.AT);
            // Substitute the Ident value with "dummy" class value
            string ident = GetIdent();
            string className = "CallAt_" + ident;
            if (!variableNames.ContainsKey(className)) variableNames.Add(className, VarUsage.Subroutine);
            expressionStack.Push(string.Format("{0} = new {0}(ref {1}", className, ident));
            firstArgument = false;
         }
         else
         {
            string ident = GetIdent(VarUsage.Subroutine);
            expressionStack.Push(string.Format("{0} = new {0}(", ident));
         }
         accept(Symbol.ident);
         if (accept(Symbol.openround))
         {
            do
            {
               if (sym == Symbol.MAT)
               {
                  // Deal with arrays
                  accept(Symbol.MAT);
               }
               if (sym == Symbol.number)
               {
                  factor();
                  nonrefVars.Add(string.Format("nrf{0} = {1};", nonrefVars.Count, expressionStack.Pop()));
                  expressionStack.Push(string.Format("nrf{0}", nonrefVars.Count - 1));
               }
               else if (sym == Symbol.text)
               {
                  factor();
                  nonrefVars.Add(string.Format("nrf{0} = {1};", nonrefVars.Count, expressionStack.Pop()));
                  expressionStack.Push(string.Format("nrf{0}", nonrefVars.Count - 1));
               }
               else if ((int)sym >= 1000)
               {
                  boolExpression();
                  nonrefVars.Add(string.Format("nrf{0} = {1};", nonrefVars.Count, expressionStack.Pop()));
                  expressionStack.Push(string.Format("nrf{0}", nonrefVars.Count - 1));
               }
               else
               {
                  string ident = GetOriginalIdent();
                  simpleVariable = true;
                  boolExpression();
                  if (stringConsts.ContainsKey(ident) || intConsts.ContainsKey(ident) || simpleVariable == false)
                  {
                     nonrefVars.Add(string.Format("nrf{0} = {1};", nonrefVars.Count, expressionStack.Pop()));
                     expressionStack.Push(string.Format("nrf{0}", nonrefVars.Count - 1));
                  }
               }
               if (firstArgument)
               {
                  expressionStack.Push(string.Format("{1}ref {0}", expressionStack.Pop(), expressionStack.Pop()));
                  firstArgument = false;
               }
               else
               {
                  expressionStack.Push(string.Format("{1}, ref {0}", expressionStack.Pop(), expressionStack.Pop()));
               }
            } while (accept(Symbol.comma));
            expect(Symbol.closeround);
         }
         expressionStack.Push(expressionStack.Pop() + ");");
         if (nonrefVars.Count > nonrefVarsCount) nonrefVarsCount = nonrefVars.Count;
         if (nonrefVars.Count > 0)
         {
            StringBuilder nonrefArgs = new StringBuilder();
            string saveCall = expressionStack.Pop();
            bool pushArgs = false;
            if (expressionStack.Count == 0 && sym == Symbol.eof) pushArgs = true;
            foreach (string nrf in nonrefVars)
            {
               if (pushArgs)
               {
                  expressionStack.Push(nrf);
               }
               else
               {
                  nonrefArgs.Append(nrf);
               }
            }
            expressionStack.Push(nonrefArgs.ToString() + saveCall);
         }
         symPointer = saveSymPointer;
         BuildSubroutineSignature();
      }
      //=======================================================================
      void BuildSubroutineSignature()
      {
         string ident = "";
         int argCount = 0;
         bool firstArgument = true;
         bool callAt = false;
         getsym();
         if (accept(Symbol.AT))
         {
            ident = "CallAt_" + GetIdent();
            callAt = true;
         }
         else
         {
            ident = GetIdent(VarUsage.Subroutine);
         }

         if (!File.Exists("C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy\\LF\\" + ident + ".cs"))
         {
            expressionStack.Push(string.Format("using Legacy.Library;"));
            expressionStack.Push(string.Format("namespace Legacy.LeisureFlex {{"));
            expressionStack.Push(string.Format("public class {0} : UvBase{{", ident));
            if (callAt)
            {
               expressionStack.Push(string.Format("public {0}(ref UvVar subroutineName", ident));
               firstArgument = false;
            }
            else
            {
               expressionStack.Push(string.Format("public {0}(", ident));
            }

            accept(Symbol.ident);
            // Get any arguments
            if (accept(Symbol.openround))
            {
               // Check for empty subroutine argument list
               if (sym != Symbol.closeround)
               {
                  do
                  {
                     string varType = "UvVar";
                     if (sym == Symbol.MAT)
                     {
                        // Deal with arrays
                        accept(Symbol.MAT);
                        varType = "UvVar[]";
                     }

                     boolExpression();
                     expressionStack.Pop();
                     string argumentName = "arg" + (argCount++).ToString();

                     if (firstArgument)
                     {
                        expressionStack.Push(string.Format("{1}ref {2} {0}", argumentName, expressionStack.Pop(), varType));
                        firstArgument = false;
                     }
                     else
                     {
                        expressionStack.Push(string.Format("{1}, ref {2} {0}", argumentName, expressionStack.Pop(), varType));
                     }
                  } while (accept(Symbol.comma));
               }
               expect(Symbol.closeround);
            }
            expressionStack.Push(string.Format("{0}) {{ }} }} }}", expressionStack.Pop()));

            TextWriter dummy = new StreamWriter("C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy\\LF\\" + ident + ".cs");
            Stack<string> newStack = new Stack<string>();
            for (int i = 0; i < 4; i++)
            {
               newStack.Push(expressionStack.Pop());
            }
            while (newStack.Count > 0)
            {
               dummy.WriteLine(newStack.Pop());
            }
            dummy.Close();

         }
      }
      //=======================================================================
      void CASE()
      {
         /*
         BEGIN CASE        
         CASE expression 
           statements    
         [CASE expression
           statements    
            .           
            .           
            .]          
         END CASE          
         */
         getsym();
         boolExpression();
         string condition = expressionStack.Pop();
         if (firstCaseStatement)
         {
            expressionStack.Push(string.Format("// CASE\r\nif ({0}) {{", condition)); ;
         }
         else
         {
            //special case - look for the default CASE statement of CASE 1
            if (condition == "1")
            {
               expressionStack.Push(string.Format("}}// CASE DEFAULT\r\nelse {{", condition)); ;
            }
            else
            {
               expressionStack.Push(string.Format("}}// CASE\r\nelse if ({0}) {{", condition)); ;
            }
         }
         firstCaseStatement = false;
      }
      //=======================================================================
      void CHAIN()
      {
         /*
         CHAIN command 
         */
         getsym();
         boolExpression();
         expressionStack.Push(string.Format("CHAIN({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void CLEARFILE()
      {
         /*
         CLEARFILE [file.variable] [ON ERROR statements] [LOCKED statements]                                          
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("CLEARFILE({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void CLOSE()
      {
         /*
         CLOSE [file.variable] [ON ERROR statements]
         */
         getsym();
         if (sym == Symbol.ident || sym == Symbol.text || sym == Symbol.number)
         {
            //accept(sym);
            factor();
            expressionStack.Push(string.Format("CLOSE(ref {0});", expressionStack.Pop()));
            return;
         }
         expressionStack.Push("CLOSE();");
      }
      //=======================================================================
      void COMMON()
      {
         /*
         COM[MON] [/name/] variable [,variable ...]
         */

         string name = "COMMON";

         getsym();
         if (accept(Symbol.divide))
         {
            name = GetIdent(true);
            getsym();
            expect(Symbol.divide);
         }
         do
         {
            //factor();

            string varName = GetOriginalIdent();// expressionStack.Pop();
            accept(Symbol.ident);
            if (!commonVars.ContainsKey(name))
            {
               commonVars.Add(name, new Dictionary<string, string>());
            }
            // HACK - Stop the variable being added again with the "COMMON" prefix
            // I haven't got to the bottom of why this bug is happening
            if (!varName.Contains(name + "."))
            {
               string fullVarName = RenameIdent(varName);

               // For dimensioned arrays store the varName as the Key
               // and the fullName including the subscript definition in the Value
               if (accept(Symbol.openround))
               {
                  factor();
                  if (accept(Symbol.comma))
                  {
                     factor();
                  }
                  else
                  {
                  }
                  expect(Symbol.closeround);
                  fullVarName = RenameIdent(varName) + "[" + expressionStack.Pop() + "]"; ;
               }

               // Check/avoid duplicate entries
               if (!commonVars[name].ContainsKey(varName))
               {
                  commonVars[name].Add(varName, fullVarName);
               }
            }

         } while (accept(Symbol.comma));
      }
      //=======================================================================
      void CLOSESEQ()
      {
         /*
         CLOSESEQ file.variable [ON ERROR statements] 
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("CLOSESEQ(ref {0});", expressionStack.Pop()));
      }
      //=======================================================================
      void CREATE()
      {
         /*
         CREATE file.variable {THEN statements [ELSE statements] | ELSE statements}                                  
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("CREATE({0})", expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void CRT()
      {
         /*
         CRT [print.list]
         */
         getsym();
         if (sym == Symbol.eof || sym == Symbol.semicolon)
         {
            expressionStack.Push("CRT();");
            return;
         }
         boolExpression();
         if (accept(Symbol.colon))
         {
            expressionStack.Push(string.Format("CRT({0});", expressionStack.Pop()));
         }
         else
         {
            expressionStack.Push(string.Format("CRTCR({0});", expressionStack.Pop()));
         }
      }
      //=======================================================================
      void DATA()
      {
         /*
         DATA expression [,expression ...]
         */
         getsym();
         boolExpression();
         expressionStack.Push(string.Format("{0}", expressionStack.Pop()));
         while (accept(Symbol.comma))
         {
            boolExpression();
            expressionStack.Push(string.Format("{1}, {0}", expressionStack.Pop(), expressionStack.Pop()));
         }
         expressionStack.Push(string.Format("DATA({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void DEL()
      {
         /*
          DEL dynamic.array < field# [,value# [,subvalue#]] >
         */
         getsym();
         string ident = RenameIdent(GetOriginalIdent());
         dynarray();
         expressionStack.Push(string.Format("{1} = DEL({0});", expressionStack.Pop(), ident));
      }
      //=======================================================================
      void DELETE()
      {
         /*
         DELETE [file.variable ,] record.ID [ON ERROR statements] 
         [LOCKED statements]                                      
         [THEN statements] [ELSE statements]                      
                                             
         DELETEU [file.variable ,] record.ID [ON ERROR statements]
         [LOCKED statements]                                      
         [THEN statements] [ELSE statements]                      
         */
         getsym();
         factor();
         expect(Symbol.comma);
         boolExpression();
         expressionStack.Push(string.Format("DELETE({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void ECHO()
      {
         /*
         ECHO {ON | OFF | expression}
         */
         getsym();
         if (accept(Symbol.ON))
         {
            expressionStack.Push(string.Format("ECHO_ON();"));
            return;
         }
         if (accept(Symbol.OFF))
         {
            expressionStack.Push(string.Format("ECHO_OFF();"));
            return;
         }
         boolExpression();
         expressionStack.Push(string.Format("ECHO({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void END()
      {
         /*
         END
         */
         getsym();
         if (accept(Symbol.ELSE))
         {
            if (sym == Symbol.eof)
            {
               expressionStack.Push("} else {");
            }
            else
            {
               statement();
               while (accept(Symbol.semicolon))
               {
                  statement();
                  expressionStack.Push(string.Format("{1} {0}", expressionStack.Pop(), expressionStack.Pop()));
               }
               expressionStack.Push(string.Format("}} else {{ {0} }}", expressionStack.Pop()));
            }

            return;
         }
         if (accept(Symbol.CASE))
         {
            expressionStack.Push("}");
            expressionStack.Push("// END CASE");
            return;
         }
         if (accept(Symbol.THEN))
         {
            expressionStack.Push("} else if (readUResult == ReadUResult.Success) {");
            return;
         }
         expressionStack.Push("}");
      }
      //=======================================================================
      void EXECUTE()
      {
         /*
         EXECUTE commands [CAPTURING variable]            
         [PASSLIST [dynamic.array]] [RTNLIST [variable]]
         [{SETTING | RETURNING} variable]               
         */
         getsym();
         dynarray();
         string commands = expressionStack.Pop();
         string capturing = "string.Empty";
         string passlist = "string.Empty";
         string rtnlist = "string.Empty";
         string setting = "string.Empty";
         while (sym == Symbol.CAPTURING || sym == Symbol.PASSLIST || sym == Symbol.RTNLIST || sym == Symbol.SETTING || sym == Symbol.RETURNING)
         {
            if (accept(Symbol.CAPTURING))
            {
               factor();
               capturing = expressionStack.Pop();
            }
            else if (accept(Symbol.PASSLIST))
            {
               factor();
               passlist = expressionStack.Pop();
            }
            else if (accept(Symbol.RTNLIST))
            {
               factor();
               rtnlist = expressionStack.Pop();
            }
            else if (accept(Symbol.SETTING) || accept(Symbol.RETURNING))
            {
               factor();
               setting = expressionStack.Pop();
            }
         }
         expressionStack.Push(string.Format("EXECUTE({0}, {1}, {2}, {3}, {4});", commands, capturing, passlist, rtnlist, setting));
      }
      //=======================================================================
      void FILELOCK()
      {
         /*
         FILELOCK [file.variable] [,lock.type]       
            [ON ERROR statements] [LOCKED statements] 
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("FILELOCK({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void FILEUNLOCK()
      {
         /*
         FILEUNLOCK [file.variable] [ON ERROR statements] 
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("FILEUNLOCK({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void FOOTING()
      {
         /*
         FOOTING [ON print.channel] footing 
         */
         getsym();
         boolExpression();
         expressionStack.Push(string.Format("FOOTING({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void FOR()
      {
         /*
         FOR variable = start TO end [STEP increment]
         [loop.statements]                         
         [CONTINUE]                                
         [{WHILE | UNTIL} expression]                
         [loop.statements]                         
         [CONTINUE]                                
         NEXT [variable]                             
         */
         getsym();
         factor();
         string controlValue = expressionStack.Pop();

         expect(Symbol.eq);
         boolExpression();
         string startValue = expressionStack.Pop();

         expect(Symbol.TO);
         boolExpression();
         string endValue = expressionStack.Pop();

         string stepValue = "1";
         string untilValue = "";
         string whileValue = "";

         if (accept(Symbol.STEP))
         {
            boolExpression();
            stepValue = expressionStack.Pop();
         }
         while (sym == Symbol.UNTIL || sym == Symbol.WHILE)
         {
            if (accept(Symbol.UNTIL))
            {
               boolExpression();
               untilValue = expressionStack.Pop();
            }
            if (accept(Symbol.WHILE))
            {
               boolExpression();
               whileValue = expressionStack.Pop();
            }
         }
         if (whileValue != "")
         {
            whileValue = controlValue + " <= " + endValue + " && " + whileValue;
         }
         if (untilValue != "")
         {
            whileValue = controlValue + " <= " + endValue + " && NOT(" + untilValue + ")";
         }
         if (whileValue == "")
         {
            whileValue = controlValue + " <= " + endValue;
         }

         expressionStack.Push(string.Format("for({0} = {1}; {2}; {0} += {3}) {{", controlValue, startValue, whileValue, stepValue));

      }
      //=======================================================================
      void GET()
      {
         //GET MESSAGE,200 FROM 5 UNTIL (CHAR(13):CHAR(10)) WAITING 30 ELSE
         getsym();
         boolExpression();
         expect(Symbol.comma);
         boolExpression();
         expect(Symbol.FROM);
         boolExpression();
         expect(Symbol.UNTIL);
         boolExpression();
         expect(Symbol.WAITING);
         boolExpression();
         if (sym == Symbol.ELSE || sym == Symbol.THEN)
         {
            expressionStack.Push(string.Format("GET(ref {4}, {3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
         }
         else
         {
            expressionStack.Push(string.Format("GET(ref {4}, {3}, {2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
      }
      //=======================================================================
      void GO()
      {
         //Synonym of GOTO
         GOTO();
      }
      //=======================================================================
      void GOSUB()
      {
         /*
         GOSUB statement.label [:] 
                          
         GO SUB statement.label [:]
         */
         getsym();
         if (sym == Symbol.number)
         {
            factor();
            string label = "L" + expressionStack.Pop();
            //if (pass == 2)
            {
               if (!labels.Contains(label))
               {
                  //labels.Add(label, 1);
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 1;

                  // Ensure that label is only used by GOSUB
                  if ((int)labels[label] != 1)
                  {
                     error(string.Format("Label {0} used by more than just GOSUB", label));
                     labels[label] = 1;
                  }
               }

               expressionStack.Push(string.Format("{0}();", label));
            }
         }
         else if (sym == Symbol.ident)
         {
            factor();
            string label = expressionStack.Pop();
            //if (pass == 2)
            {
               if (!labels.Contains(label))
               {
                  //labels.Add(label, 1);
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 1;

                  // Ensure that label is only used by GOSUB
                  if ((int)labels[label] != 1)
                  {
                     error(string.Format("Label {0} used by more than just GOSUB", label));
                     labels[label] = 1;
                  }
               }
               expressionStack.Push(string.Format("{0}();", label));
            }
         }
      }
      //=======================================================================
      void GOTO()
      {
         /*
         GO[TO] statement.label [:]
                          
         GO TO statement.label [:] 
         */
         getsym();
         if (sym == Symbol.number)
         {
            factor();
            string label = "L" + expressionStack.Pop();
            //if (pass == 2)
            {
               if (!labels.Contains(label))
               {
                  //labels.Add(label, 2);
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 2;

                  // Ensure that label is only used by GOTO
                  if ((int)labels[label] != 2) error(string.Format("Label {0} used by more than just GOTO", label));
               }
               expressionStack.Push(string.Format("goto {0};", label));
            }
         }
         else if (sym == Symbol.ident)
         {
            factor();
            string label = expressionStack.Pop();
            //if (pass == 2)
            {
               if (!labels.Contains(label))
               {
                  //labels.Add(label, 2);
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 2;

                  // Ensure that label is only used by GOTO
                  if ((int)labels[label] != 2) error(string.Format("Label {0} used by more than just GOTO", label));
               }
               expressionStack.Push(string.Format("goto {0};", label));
            }
         }
      }
      //=======================================================================
      void HEADING()
      {
         /*
         HEADING [ON print.channel] heading 
         HEADINGE [ON print.channel] heading
         HEADINGN [ON print.channel] heading 
         */
         getsym();
         boolExpression();
         expressionStack.Push(string.Format("HEADING({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void IF()
      {
         /*
1)       IF expression {THEN statements [ELSE statements] | ELSE
            statements}                                         
                                                                
2)       IF expression                                          
         {THEN statements                                       
         [ELSE statements] |                                    
         ELSE statements}                                       
                                                                
3)       IF expression {THEN                                    
           statements                                           
         END [ELSE                                              
           statements                                           
         END] | ELSE                                            
           statements
         END}                                                   
                                                                
4)       IF expression                                          
         {THEN                                                  
           statements                                           
         END                                                    
         [ELSE                                                  
           statements                                           
         END] |                                                 
         ELSE                                                   
           statements                                           
         END}                                                   
         */
         getsym();
         boolExpression();
         thenElse();
      }
      //=======================================================================
      void INS()
      {
         /*
         INS expression BEFORE dynamic.array < field# [,value# [,subvalue#]] >                                    
         */
         string att = "0";
         string mv = "0";
         string sv = "0";
         getsym();
         boolExpression();
         expect(Symbol.BEFORE);
         string ident = RenameIdent(GetOriginalIdent());
         getsym();
         expect(Symbol.opencurly);
         boolExpression();
         att = expressionStack.Pop();
         if (accept(Symbol.comma))
         {
            boolExpression();
            mv = expressionStack.Pop();
            if (accept(Symbol.comma))
            {
               boolExpression();
               sv = expressionStack.Pop();
            }
         }
         expect(Symbol.closecurly);
         expressionStack.Push(string.Format("{1} = INSERT({1}, {2}, {3}, {4}, {0});", expressionStack.Pop(), ident, att, mv, sv));
      }
      //=======================================================================
      void INPUT()
      {
         /*
1)       INPUT variable [,length] [:] [_]                              
                                                              
2)       INPUT @ (col, row) [, | :] variable [,length] [:] [format] [_]
                                                              
3)       INPUTIF @ (col, row) [, | :] variable [,length] [:]           
               [format] [_] [THEN statements] [ELSE statements]           
         */
         getsym();
         factor();
         if (accept(Symbol.comma))
         {
            boolExpression();
            if (accept(Symbol.colon))
            {
               expressionStack.Push(string.Format("INPUT(out {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
            }
            else if (accept(Symbol.underscore))
            {
               if (accept(Symbol.colon))
               {
                  expressionStack.Push(string.Format("INPUT_WAIT(out {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
               }
               else
               {
                  expressionStack.Push(string.Format("INPUTCR_WAIT(out {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
               }
            }
            else
            {
               expressionStack.Push(string.Format("INPUTCR(out {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
            }
         }
         else
         {
            if (accept(Symbol.colon))
            {
               expressionStack.Push(string.Format("INPUT(out {0});", expressionStack.Pop()));
            }
            else
            {
               expressionStack.Push(string.Format("INPUTCR(out {0});", expressionStack.Pop()));
            }
         }
      }
      //=======================================================================
      void LOCATE()
      {
         /*
1)       Pick Style
         LOCATE (expression, dynamic.array [,field# [,value#]] ;
            variable [;seq] ) {THEN statements [ELSE statements]
            | ELSE statements}
          
2)       Reality Style
         LOCATE expression IN dynamic.array [< field# [,value#] >]
            [,start] [BY seq] SETTING variable {THEN statements    
            [ELSE statements] | ELSE statements}   

         */
         getsym();
         if (accept(Symbol.openround))
         {
            //Locate using the Pick style
            boolExpression();                   //expression
            expect(Symbol.comma);               //,
            boolExpression();                           //dynamic array
            if (accept(Symbol.comma))           //,
            {
               boolExpression();                //field#
               if (accept(Symbol.comma))        //,
               {
                  boolExpression();             //value#
               }
               else
               {
                  expressionStack.Push("0");    //value# (default value)
               }
            }
            else
            {
               expressionStack.Push("0");       //field# (default value)
               expressionStack.Push("0");       //value# (default value)
            }
            expect(Symbol.semicolon);           //;
            factor();                           //variable
            if (accept(Symbol.semicolon))       //;
            {
               factor();                        //Seq
            }
            else
            {
               expressionStack.Push("\"AL\"");  //Seq (default value)
            }
            expect(Symbol.closeround);
            expressionStack.Push(string.Format("LOCATE({5}, {4}, {3}, {2}, 1, ref {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
         }
         else
         {
            //Locate using the Reality style
            boolExpression();                   //expression
            expect(Symbol.IN);                  //IN
            factor();                           //dynamic array
            if (accept(Symbol.opencurly))       //<
            {
               boolExpression();                //field#
               if (accept(Symbol.comma))        //,
               {
                  boolExpression();             //value#
               }
               else
               {
                  expressionStack.Push("0");    //value# (default value)
               }
               expect(Symbol.closecurly);       //>
            }
            else
            {
               expressionStack.Push("0");       //field# (default value)
               expressionStack.Push("0");       //value# (default value)
            }

            if (accept(Symbol.comma))           //,
            {
               boolExpression();                //start
            }
            else
            {
               expressionStack.Push("1");       //start (default value)
            }
            if (accept(Symbol.BY))              //BY
            {
               factor();                        //Seq
            }
            else
            {
               expressionStack.Push("\"AL\"");  //Seq (default value)
            }
            expect(Symbol.SETTING);             //SETTING
            factor();                           //variable
            expressionStack.Push(string.Format("LOCATE({6}, {5}, {4}, {3}, {2}, ref {0}, {1})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
         }
      }
      //=======================================================================
      void LOCK()
      {
         /*
          
         */
         getsym();
         boolExpression();
         expressionStack.Push(string.Format("LOCK({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void LOOP()
      {
         /*
         LOCK expression [THEN statements] [ELSE statements] 
         */
         getsym();
         expressionStack.Push("do {");
         if (sym == Symbol.UNTIL)
         {
            UNTIL();
         }
         else if (sym == Symbol.WHILE)
         {
            WHILE();
         }
      }
      //=======================================================================
      void MAT()
      {
         /*
         MAT array = expression 
         MAT array1 = MAT array2
         */
         getsym();
         expressionStack.Push(GetIdent());
         getsym();
         expect(Symbol.eq);
         if (accept(Symbol.MAT))
         {
            boolExpression();
            expressionStack.Push(string.Format("MAT(ref {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
         }
         else
         {
            boolExpression();
            expressionStack.Push(string.Format("MAT(ref {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
         }
      }
      //=======================================================================
      void MATPARSE()
      {
         /*
         MATPARSE array FROM dynamic.array                           
         */
         getsym();
         factor();               // dimensioned array
         expect(Symbol.FROM);
         boolExpression();       // dynamic array
         expressionStack.Push(string.Format("MATPARSE(ref {1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void MATREAD()
      {
         /*
         MATREAD array FROM [file.variable,] record.ID [ON ERROR    
            statements] {THEN statements [ELSE statements]          
            | ELSE statements}                                      
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expressionStack.Push(string.Format("MATREAD(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void MATREADL()
      {
         /*
         MATREADL array FROM [file.variable,] record.ID
            [ON ERROR statements] [LOCKED statements]                
            {THEN statements [ELSE statements] | ELSE statements}     
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (accept(Symbol.LOCKED))
         {
            expressionStack.Push(string.Format("MATREADL_LOCKED(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            locked();
         }
         else
         {
            expressionStack.Push(string.Format("MATREADL(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         thenElse();
      }
      //=======================================================================
      void MATREADU()
      {
         /*
         MATREADU array FROM [file.variable,] record.ID
            [ON ERROR statements] [LOCKED statements]                
            {THEN statements [ELSE statements] | ELSE statements}     
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (accept(Symbol.LOCKED))
         {
            expressionStack.Push(string.Format("MATREADU_LOCKED(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            locked();
         }
         else
         {
            expressionStack.Push(string.Format("MATREADU(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         thenElse();
      }
      //=======================================================================
      void MATWRITE()
      {
         /*
         MATWRITEU array ON | TO [file.variable,] record.ID
            [ON ERROR statements] [LOCKED statements]        
            [THEN statements] [ELSE statements]              
         */
         getsym();
         factor();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("MATWRITE({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("MATWRITE({2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void MATWRITEU()
      {
         /*
         MATWRITEU array ON | TO [file.variable,] record.ID
            [ON ERROR statements] [LOCKED statements]        
            [THEN statements] [ELSE statements]              
         */
         getsym();
         factor();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("MATWRITEU({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("MATWRITEU({2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void NAP()
      {
         /*
         NAP [milliseconds] 
         */
         getsym();
         if (sym == Symbol.eof || sym == Symbol.semicolon)
         {
            expressionStack.Push("NAP();");
            return;
         }
         boolExpression();
         expressionStack.Push(string.Format("NAP({0});", expressionStack.Pop()));
      }//=======================================================================
      void NEXT()
      {
         /*
         NEXT [variable] 
         */
         getsym();
         expressionStack.Push("}");
      }
      //=======================================================================
      void NULL()
      {
         /*
         NULL 
         */
         getsym();
         expressionStack.Push("NULL();");
      }
      //=======================================================================
      void ON()
      {
         /*
         ON expression GOSUB statement.label [:] 
               [,statement.label [:]...]         
                                                 
         ON expression GO[TO] statement.label [:]
               [,statement.label [:]...]                   
         */
         getsym();
         boolExpression();
         string varName = expressionStack.Pop();
         if (sym == Symbol.GOSUB)
         {
            onGosub(varName);
         }
         else if (sym == Symbol.GOTO)
         {
            onGoto(varName);
         }
      }
      //=======================================================================
      private void onGosub(string varName)
      {
         /*
          
         */
         expressionStack.Push(string.Format("#region ON {0} GOSUB ...", varName));
         expressionStack.Push(string.Format("switch ((int){0}) {{", varName));
         getsym();
         int caseCount = 1;
         do
         {
            if (sym == Symbol.number)
            {
               factor();
               string label = "L" + expressionStack.Pop();
               //if (pass == 1)
               //{
               if (!labels.Contains(label))
               {
                  //labels.Add(label, 1);
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 1;

                  // Ensure that label is only used by GOSUB
                  if ((int)labels[label] != 1) error(string.Format("Label {0} used by more than just GOSUB", label));
               }
               //}
               expressionStack.Push(string.Format("case {0}: {1}(); break;", caseCount, label));
            }
            else if (sym == Symbol.ident)
            {
               factor();
               string label = expressionStack.Pop();
               if (pass == 1)
               {
                  if (!labels.Contains(label))
                  {
                     //labels.Add(label, 1);
                  }
                  else
                  {
                     // Deal with unreferenced labels
                     if ((int)labels[label] == 0) labels[label] = 1;

                     // Ensure that label is only used by GOSUB
                     if ((int)labels[label] != 1) error(string.Format("Label {0} used by more than just GOSUB", label));
                  }
               }
               expressionStack.Push(string.Format("case {0}: {1}(); break;", caseCount, label));
            }
            caseCount++;
         } while (accept(Symbol.comma));
         expressionStack.Push("}");
         expressionStack.Push("#endregion");
      }
      //=======================================================================
      private void onGoto(string varName)
      {
         /*
          
         */
         expressionStack.Push(string.Format("#region ON {0} GOTO ...", varName));
         expressionStack.Push(string.Format("switch ((int){0}) {{", varName));
         getsym();
         int caseCount = 1;
         do
         {
            if (sym == Symbol.number)
            {
               factor();
               string label = "L" + expressionStack.Pop();
               if (!labels.Contains(label))
               {
               }
               else
               {
                  // Deal with unreferenced labels
                  if ((int)labels[label] == 0) labels[label] = 2;

                  // Ensure that label is only used by GOTO
                  if ((int)labels[label] != 2) error(string.Format("Label {0} used by more than just GOTO", label));
               }
               expressionStack.Push(string.Format("case {0}: goto {1};", caseCount, label));
            }
            else if (sym == Symbol.ident)
            {
               factor();
               string label = expressionStack.Pop();
               if (pass == 1)
               {
                  if (!labels.Contains(label))
                  {
                  }
                  else
                  {
                     // Deal with unreferenced labels
                     if ((int)labels[label] == 0) labels[label] = 2;

                     // Ensure that label is only used by GOTO
                     if ((int)labels[label] != 2) error(string.Format("Label {0} used by more than just GOTO", label));
                  }
               }
               expressionStack.Push(string.Format("case {0}: goto {1};", caseCount, label));
            }
            caseCount++;
         } while (accept(Symbol.comma));
         expressionStack.Push("}");
         expressionStack.Push("#endregion");
      }
      //=======================================================================
      void OPEN()
      {
         /*
         OPEN [dict,] filename [TO file.variable]                   
            [ON ERROR statements] {THEN statements [ELSE statements]
            | ELSE statements}                                                
         */
         getsym();
         boolExpression();
         if (accept(Symbol.comma))
         {
            expressionStack.Pop();
            boolExpression();
            expect(Symbol.TO);
            factor();
            expressionStack.Push(string.Format("OPENDICT({1}, out {0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         else
         {
            expect(Symbol.TO);
            factor();
            expressionStack.Push(string.Format("OPEN({1}, out {0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         thenElse();
      }
      //=======================================================================
      void OPENSEQ()
      {
         /*
         OPENSEQ filename, record.ID TO file.variable [USING        
            dynamic.array] [ON ERROR statements] [LOCKED statements]
            {THEN statements [ELSE statements] | ELSE statements}   
                                                                    
         OPENSEQ pathname TO file.variable [USING dynamic.array]    
            [ON ERROR statements] [LOCKED statements]               
            {THEN statements [ELSE statements] | ELSE statements}             
         */
         getsym();
         boolExpression();
         expect(Symbol.TO);
         factor();
         expressionStack.Push(string.Format("OPENSEQ({1}, out {0})", expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void PAGE()
      {
         /*
         PAGE [ON print.channel] [page#]
         */
         getsym();
         if (accept(Symbol.ON))
         {
            //ON print.channel
            boolExpression();
            if (!(sym == Symbol.eof || sym == Symbol.semicolon))
            {
               //Page #
               boolExpression();
               expressionStack.Push(string.Format("PAGE_ON({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
               return;
            }
            else
            {
               expressionStack.Push(string.Format("PAGE_ON({0});", expressionStack.Pop()));
               return;
            }
         }
         if (!(sym == Symbol.eof || sym == Symbol.semicolon))
         {
            //Page #
            boolExpression();
            expressionStack.Push(string.Format("PAGE({0});", expressionStack.Pop()));
            return;
         }
         else
         {
            expressionStack.Push(string.Format("PAGE();"));
            return;
         }
      }
      //=======================================================================
      void PRINT()
      {
         /*
         PRINT [ON print.channel] [print.list]          
         */
         getsym();
         if (sym == Symbol.eof || sym == Symbol.semicolon)
         {
            expressionStack.Push("PRINT();");
            return;
         }
         boolExpression();
         if (accept(Symbol.colon))
         {
            expressionStack.Push(string.Format("PRINT({0});", expressionStack.Pop()));
         }
         else
         {
            expressionStack.Push(string.Format("PRINTCR({0});", expressionStack.Pop()));
         }
      }
      //=======================================================================
      void PRINTER()
      {
         /*
         PRINTER {ON | OFF | RESET}      
         PRINTER CLOSE [ON print.channel]
         */
         getsym();
         if (accept(Symbol.ON))
         {
            if (sym == Symbol.eof || sym == Symbol.semicolon)
            {
               expressionStack.Push("PRINTER_ON();");
            }
            else
            {
               boolExpression();
               expressionStack.Push(string.Format("PRINTER_ON({0});", expressionStack.Pop()));
            }
            return;
         }
         if (accept(Symbol.OFF))
         {
            if (sym == Symbol.eof || sym == Symbol.semicolon)
            {
               expressionStack.Push("PRINTER_OFF();");
            }
            else
            {
               boolExpression();
               expressionStack.Push(string.Format("PRINTER_OFF({0});", expressionStack.Pop()));
            }
            return;
         }
         if (accept(Symbol.RESET))
         {
            if (sym == Symbol.eof || sym == Symbol.semicolon)
            {
               expressionStack.Push("PRINTER_RESET();");
            }
            else
            {
               boolExpression();
               expressionStack.Push(string.Format("PRINTER_RESET({0});", expressionStack.Pop()));
            }
            return;
         }
         if (accept(Symbol.CLOSE))
         {
            if (accept(Symbol.ON))
            {
               if (sym == Symbol.eof || sym == Symbol.semicolon)
               {
                  expressionStack.Push("PRINTER_CLOSE();");
               }
               else
               {
                  boolExpression();
                  expressionStack.Push(string.Format("PRINTER_CLOSE({0});", expressionStack.Pop()));
               }
               return;
            }
            expressionStack.Push("PRINTER_CLOSE();");
            return;
         }
      }
      //=======================================================================
      void PROMPT()
      {
         /*
         PROMPT character          
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("PROMPT({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void READ()
      {
         /*
         READ  dynamic.array  FROM [file.variable,]  record.ID
            [ON ERROR  statements] {THEN  statements          
            [ELSE  statements] | ELSE  statements}            
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expressionStack.Push(string.Format("READ(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void READBLK()
      {
         /*
         READBLK variable FROM file.variable, blocksize          
            {THEN statements [ELSE statements] | ELSE statements}          
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expressionStack.Push(string.Format("READ(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void READNEXT()
      {
         /*          
         READNEXT dynamic.array [,value [,subvalue]] [FROM list] 
         {THEN statements [ELSE statements] | ELSE statements}
         */
         getsym();
         factor();                           //dynamic array
         if (accept(Symbol.comma))           //,
         {
            boolExpression();                //value#
            if (accept(Symbol.comma))        //,
            {
               boolExpression();             //subvalue#
            }
            else
            {
               expressionStack.Push("0");    //subvalue# (default value)
            }
         }
         else
         {
            expressionStack.Push("0");       //value# (default value)
            expressionStack.Push("0");       //subvalue# (default value)
         }
         if (accept(Symbol.FROM))            //FROM
         {
            factor();                        //list
         }
         else
         {
            expressionStack.Push("\"\"");    //list (default value)
         }
         expressionStack.Push(string.Format("READNEXT(ref {3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void READU()
      {
         /*
         READU dynamic.array FROM [file.variable,] record.ID
            [ON ERROR  statements] [LOCKED  statements]               
            {THEN  statements [ELSE  statements] | ELSE  statements}  
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         //expressionStack.Push(string.Format("READU(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         if (accept(Symbol.LOCKED))
         {
            expressionStack.Push(string.Format("READU_LOCKED(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            locked();
         }
         else
         {
            expressionStack.Push(string.Format("READU(ref {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         thenElse();
      }
      //=======================================================================
      void READVU()
      {
         /*
         {READVL | READVU} dynamic.array  FROM [file.variable,]      
            record.ID, field# [ON ERROR  statements]                 
            [LOCKED  statements] {THEN  statements [ELSE  statements]
            | ELSE  statements}                                                
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expect(Symbol.comma);
         boolExpression();       // attribute#
         expressionStack.Push(string.Format("READVU(ref {3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void READV()
      {
         /*
         READV dynamic.array FROM [file.variable,] record.ID,  field#  
            [ON ERROR  statements] {THEN  statements [ELSE  statements]
            | ELSE  statements}                                                  
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expect(Symbol.comma);
         boolExpression();       // attribute#
         expressionStack.Push(string.Format("READV(ref {3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         thenElse();
      }
      //=======================================================================
      void RELEASE()
      {
         /*
         RELEASE [file.variable [,record.ID]] [ON ERROR statements]
         */
         if (accept(Symbol.ident))
         {
            factor();
            if (accept(Symbol.comma))
            {
               boolExpression();
               expressionStack.Push(string.Format("RELEASE({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
            }
            else
            {
               expressionStack.Push(string.Format("RELEASE({0});", expressionStack.Pop()));
            }
         }
         else
         {
            expressionStack.Push("RELEASE();");
         }
      }
      //=======================================================================
      void REPEAT()
      {
         /*
         REPEAT 
         */
         getsym();
         expressionStack.Push("} while (true);");
      }
      //=======================================================================
      void RETURN()
      {
         /*
         RETURN [TO statement.label] 
         */
         accept(Symbol.RETURN);
         expressionStack.Push("return;");
      }
      //=======================================================================
      void RQM()
      {
         /*
          
         */
         accept(Symbol.RQM);
         expressionStack.Push("RQM();");
      }
      //=======================================================================
      void SELECT()
      {
         /*
         SELECT [variable] [TO list.number] [ON ERROR statements] 
         SELECTN [variable] [TO list.number] [ON ERROR statements]
         SELECTV [variable] TO list.variable [ON ERROR statements]          
         */
         getsym();
         if (accept(Symbol.TO))
         {
            factor();
            expressionStack.Push(string.Format("SELECT_TO({0});", expressionStack.Pop()));
            return;
         }
         factor();
         if (accept(Symbol.TO))
         {
            factor();
            expressionStack.Push(string.Format("SELECT_TO({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
            return;
         }
         factor();
         expressionStack.Push(string.Format("SELECT({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void SEND()
      {
         getsym();
         boolExpression();
         if (accept(Symbol.colon))
         {
            expect(Symbol.TO);
            boolExpression();
            expressionStack.Push(string.Format("SEND({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         else
         {
            expect(Symbol.TO);
            boolExpression();
            expressionStack.Push(string.Format("SENDCR({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         thenElse();
      }
      //=======================================================================
      void SLEEP()
      {
         /*
         SLEEP [seconds] 
         */
         getsym();
         if (sym == Symbol.eof || sym == Symbol.semicolon)
         {
            expressionStack.Push("SLEEP();");
            return;
         }
         boolExpression();
         expressionStack.Push(string.Format("SLEEP({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void STATUS()
      {
         /*
          
         */
         getsym();
         factor();               // record var
         expect(Symbol.FROM);
         factor();               // file var
         expressionStack.Push(string.Format("STATUS(ref {1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
         thenElse();

      }
      //=======================================================================
      void STOP()
      {
         /*
          
         */
         getsym();
         if (sym == Symbol.ident || sym == Symbol.text || sym == Symbol.number)
         {
            factor();
            if (accept(Symbol.comma))
            {
               if (sym == Symbol.ident || sym == Symbol.text)
               {
                  factor();
                  expressionStack.Push(string.Format("STOP({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
               }
            }
            else
            {
               expressionStack.Push(string.Format("STOP({0});", expressionStack.Pop()));
            }
         }
         else
         {
            expressionStack.Push("STOP();");
         }
      }
      //=======================================================================
      void UNTIL()
      {
         /*
          
         */
         getsym();
         boolExpression();
         accept(Symbol.DO);
         if (sym == Symbol.REPEAT)
         {
            expressionStack.Push(string.Format("}} while (!({0}));", expressionStack.Pop()));
         }
         else
         {
            expressionStack.Push(string.Format("if ({0}) break;", expressionStack.Pop()));
         }
      }
      //=======================================================================
      void WEOFSEQ()
      {
         /*
          
         */
         getsym();
         factor();
         expressionStack.Push(string.Format("WEOFSEQ({0});", expressionStack.Pop()));
      }
      //=======================================================================
      void WHILE()
      {
         /*
          
         */
         getsym();
         boolExpression();
         string condition = expressionStack.Pop();
         accept(Symbol.DO);
         if (sym == Symbol.REPEAT)
         {
            expressionStack.Push(string.Format("}} while ({0});", condition));
         }
         else
         {
            //Test for special conditions of "0" & "1"
            if (condition == "0")
            {
               expressionStack.Push(string.Format("if (true) break;", condition));
            }
            else if (condition == "1")
            {
               expressionStack.Push(string.Format("if (false) break;", condition));
            }
            else
            {
               expressionStack.Push(string.Format("if (!({0})) break;", condition));
            }
         }
      }
      //=======================================================================
      void WRITE()
      {
         /*
          
         */
         getsym();
         boolExpression();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITE({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITE({2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void WRITEBLK()
      {
         /*
          
         */
         getsym();
         boolExpression();
         expect(Symbol.ON);
         factor();
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITEBLK({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITEBLK({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void WRITESEQ()
      {
         /*
          
         */
         getsym();
         boolExpression();
         expect(Symbol.ON);
         factor();
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITESEQ({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITESEQ({1}, {0});", expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void WRITEU()
      {
         /*
          
         */
         getsym();
         boolExpression();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITEU({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITEU({2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void WRITEVU()
      {
         /*
          
         */
         getsym();
         boolExpression();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expect(Symbol.comma);
         boolExpression();       // attribute#
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITEVU({3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITEVU({3}, {2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void WRITEV()
      {
         /*
          
         */
         getsym();
         boolExpression();               // record var
         expect(Symbol.ON);
         factor();               // file var
         expect(Symbol.comma);
         boolExpression();       // item id
         expect(Symbol.comma);
         boolExpression();       // attribute#
         if (sym == Symbol.THEN || sym == Symbol.ELSE)
         {
            expressionStack.Push(string.Format("WRITEV({3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            thenElse();
            return;
         }
         expressionStack.Push(string.Format("WRITEV({3}, {2}, {1}, {0});", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void DIM()
      {
         /*
          
         */
         if (pass == 1) return;

         getsym();
         string varName = GetOriginalIdent();
         accept(Symbol.ident);
         if (accept(Symbol.openround))
         {
            factor();
            if (accept(Symbol.comma))
            {
               factor();
               if (!dimVars.ContainsKey(varName))
               {
                  dimVars.Add(varName, expressionStack.Pop() + "," + expressionStack.Pop());
               }
               else
               {
                  expressionStack.Pop();
               }
            }
            else
            {
               if (!dimVars.ContainsKey(varName))
               {
                  dimVars.Add(varName, expressionStack.Pop());
               }
               else
               {
                  expressionStack.Pop();
               }
            }
            expect(Symbol.closeround);
         }
         else
         {
            // standard variables are dealt with by preamble code already
         }
      }
      //=======================================================================
      void EQU()
      {
         /*
          
         */
         if (pass > 1) return;
         getsym();
         do
         {
            string ident = identList[symPointer - 1];
            getsym();
            expect(Symbol.TO);
            if ((int)sym >= 1000)
            {
               factor();
               if (!stringConsts.ContainsKey(ident))
               {
                  stringConsts.Add(ident, expressionStack.Pop());
               }
               else
               {
                  expressionStack.Pop();
               }
            }
            else
            {
               switch (sym)
               {
                  case Symbol.number:
                     {
                        factor();
                        if (!intConsts.ContainsKey(ident))
                        {
                           intConsts.Add(ident, expressionStack.Pop());
                        }
                        else
                        {
                           expressionStack.Pop();
                        }
                        break;
                     }
                  case Symbol.text:
                     {
                        factor();
                        if (!stringConsts.ContainsKey(ident))
                        {
                           stringConsts.Add(ident, expressionStack.Pop());
                        }
                        else
                        {
                           expressionStack.Pop();
                        }
                        break;
                     }
                  case Symbol.ident:
                     {
                        if (nextis(Symbol.openround))
                        {
                           string identTo = identList[symPointer - 1];
                           accept(Symbol.ident);
                           expect(Symbol.openround);
                           factor();
                           string index = expressionStack.Pop();
                           if (!intConsts.ContainsKey(ident)) intConsts.Add(ident, index);
                           if (IsCommonVar(identTo))
                           {
                              identTo = GetCommonVar(identTo);
                           }
                           else
                           {
                              identTo = RenameIdent(identTo);
                           }
                           if (!equateVars.ContainsKey(ident)) equateVars.Add(ident, identTo + "[" + RenameIdent(ident) + "]");
                        }
                        else
                        {
                           factor();
                           string identTo = expressionStack.Pop();
                           if (!equateVars.ContainsKey(ident)) equateVars.Add(ident, RenameIdent(identTo));
                        }
                        break;
                     }
               }
            }
         } while (accept(Symbol.comma));
      }
      //=======================================================================
      void INCLUDE()
      {
         /*
          
         */
         getsym();
         string fileName = GetOriginalIdent();
         getsym();
         string itemName = GetOriginalIdent();
         expect(Symbol.ident);

         StringBuilder convertedSourceCode;
         string firstLine;
         Convertfile2(inputPath, fileName, itemName, out convertedSourceCode, out firstLine);
         expressionStack.Push(string.Format("#region INCLUDE {0} {1}", fileName, itemName));
         expressionStack.Push(firstLine);
         if (convertedSourceCode.Length > 0) expressionStack.Push(convertedSourceCode.ToString());
         expressionStack.Push("#endregion");
      }
      //=======================================================================
      void SUBROUTINE()
      {
         /*
          
         */
         getsym();

         // Get name of the subroutine
         expressionStack.Push(string.Format("public {0}(", GetIdent(true)));
         getsym();

         // Get any arguments
         if (accept(Symbol.openround))
         {
            // Check for empty subroutine argument list
            if (sym != Symbol.closeround)
            {
               bool firstArgument = true;
               do
               {
                  string varType = "UvVar";
                  string argumentName;
                  if (sym == Symbol.MAT)
                  {
                     // Deal with arrays
                     accept(Symbol.MAT);
                     string ident = GetOriginalIdent();
                     varType = "UvVar[]";
                     factor();
                     argumentName = expressionStack.Pop();
                     if (pass == 1) dimVars.Add(ident, "");
                  }
                  else
                  {
                     factor();
                     argumentName = expressionStack.Pop();
                  }
                  if (pass == 1) argumentVars.Add(argumentName);

                  if (firstArgument)
                  {
                     expressionStack.Push(string.Format("{1}ref {2} {0}", argumentName, expressionStack.Pop(), varType));
                     firstArgument = false;
                  }
                  else
                  {
                     expressionStack.Push(string.Format("{1}, ref {2} {0}", argumentName, expressionStack.Pop(), varType));
                  }
               } while (accept(Symbol.comma));
            }
            expect(Symbol.closeround);
         }
         expressionStack.Push(string.Format("{0}) {{", expressionStack.Pop()));
         foreach (string varName in argumentVars)
         {
            expressionStack.Push(string.Format("this.{0} = {0};", varName));
         }
      }
      //=======================================================================
      void assignment()
      {
         /*
          
         */
         TraceIn("assignment");
         factor();
         factor();
         switch (sym)
         {
            case Symbol.eq:
               {
                  sym = Symbol.assign;
                  break;
               }
            case Symbol.assplus:
               {
                  break;
               }
            case Symbol.assminus:
               {
                  break;
               }
            case Symbol.assmultiply:
               {
                  break;
               }
            case Symbol.assdivide:
               {
                  break;
               }
            case Symbol.assconcat:
               {
                  break;
               }
            default:
               {
                  error("Invalid assignment operator");
                  return;
               }
         }
         expressionStack.Push(ConvertSymToString(sym));
         accept(sym);
         boolExpression();
         expressionStack.Push(string.Format("{2} {1} {0};", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         TraceOut("assignment");
      }
      //=======================================================================
      void comment()
      {
         /*
          
         */
         string comment = GetOriginalIdent();
         if (comment != "")
         {
            if (!(Regex.Matches(comment, "[*]").Count == comment.Length))
            {
               expressionStack.Push("/* " + comment + " */");
            }
         }
         symPointer = symbolList.Length - 1;
         getsym();
         return;
      }
      //=======================================================================
      void label()
      {
         /*
          
         */
         string label = identList[symPointer - 1];
         if (sym == Symbol.number)
         {
            label = "L" + label;
            if (!labels.Contains(label)) labels.Add(label, 0);
            if ((int)labels[label] == 1)
            {
               // End the previous method
               expressionStack.Push("}");

               // Start the new method for this label
               expressionStack.Push(string.Format("void {0}() {{", label));
            }
            else
            {
               // Check for preceding GOSUB labels that will make
               // this label unreachable.
               for (int i = 0; i < labels.Count; i++)
               {
                  if ((int)labels[i] == 2)
                  {
                     error("Label " + label + " unreachable");
                     break;
                  }
               }
               // Standard label for use by GOTO
               expressionStack.Push(string.Format("{0}:;", label));
            }
         }
         else
         {
            if (!labels.Contains(label)) labels.Add(label, 0);
            if ((int)labels[label] == 1)
            {
               // End the previous method
               expressionStack.Push("}");

               // Start the new method for this label
               expressionStack.Push(string.Format("void {0}() {{", label));
            }
            else
            {
               // Standard label for use by GOTO
               expressionStack.Push(string.Format("{0}:;", label));
            }
         }
         getsym();
         accept(Symbol.colon);
      }
      //=======================================================================
      void command()
      {
         TraceIn("command");
         TraceOut("command");
      }
      //=======================================================================
      void locked()
      {
         accept(Symbol.LOCKED);
         if (sym == Symbol.eof)
         {
            expressionStack.Push(string.Format("readUResult = {0};", expressionStack.Pop()));
            expressionStack.Push("if (readUResult==ReadUResult.Locked){");
         }
      }
      //=======================================================================
      void thenElse()
      {
         if (sym == Symbol.ELSE)
         {
            accept(Symbol.ELSE);
            if (sym == Symbol.eof)
            {
               expressionStack.Push(string.Format("if (!({0})) {{", expressionStack.Pop()));
            }
            else
            {
               statement();
               while (accept(Symbol.semicolon))
               {
                  statement();
                  expressionStack.Push(string.Format("{1} {0}", expressionStack.Pop(), expressionStack.Pop()));
               }
               expressionStack.Push(string.Format("if (!{1}) {{ {0} }}", expressionStack.Pop(), expressionStack.Pop()));
            }
            return;
         }
         if (accept(Symbol.THEN))
         {
            if (sym == Symbol.eof)
            {
               expressionStack.Push(string.Format("if ({0}) {{", expressionStack.Pop()));
            }
            else
            {
               if (nextis(Symbol.multiply) || nextis(Symbol.pling))
               {
                  getsym();
                  comment();
                  expressionStack.Push(string.Format("if ({1}) {{ {0}", expressionStack.Pop(), expressionStack.Pop()));
                  return;
               }

               statement();
               while (accept(Symbol.semicolon))
               {
                  statement();
                  expressionStack.Push(string.Format("{1} {0}", expressionStack.Pop(), expressionStack.Pop()));
               }
               if (accept(Symbol.ELSE))
               {
                  if (sym == Symbol.eof)
                  {
                     expressionStack.Push(string.Format("if ({1}) {{ {0} }} else {{", expressionStack.Pop(), expressionStack.Pop()));
                  }
                  else
                  {
                     statement();
                     while (accept(Symbol.semicolon))
                     {
                        statement();
                        expressionStack.Push(string.Format("{1} {0}", expressionStack.Pop(), expressionStack.Pop()));
                     }
                     expressionStack.Push(string.Format("if ({2}) {{ {1} }} else {{ {0} }}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                  }
               }
               else
               {
                  expressionStack.Push(string.Format("if ({1}) {{ {0} }}", expressionStack.Pop(), expressionStack.Pop()));
               }

            }
         }
      }
      //=======================================================================
      void boolExpression()
      {
         TraceIn("boolExpression");
         boolTerm();
         while (sym == Symbol.or)
         {
            simpleVariable = false;
            expressionStack.Push(ConvertSymToString(sym));
            getsym();
            boolTerm();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("boolExpression");
      }
      //=======================================================================
      void boolTerm()
      {
         TraceIn("boolTerm");
         boolFactor();
         while (sym == Symbol.and)
         {
            simpleVariable = false;
            expressionStack.Push(ConvertSymToString(sym));
            getsym();
            boolFactor();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("boolTerm");
      }
      //=======================================================================
      void boolFactor()
      {
         TraceIn("boolFactor");
         if (accept(Symbol.boolLit))
         {
            ;
         }
         else if (accept(Symbol.boolVar))
         {
            ;
         }
         else
         {
            relation();
         }
         TraceOut("boolFactor");

      }
      //=======================================================================
      void relation()
      {
         TraceIn("relation");
         match();// concat();
         if (sym == Symbol.eq || sym == Symbol.lte || sym == Symbol.gt || sym == Symbol.gt2 ||
             sym == Symbol.lt || sym == Symbol.lt2 || sym == Symbol.neq || sym == Symbol.gte)
         {
            simpleVariable = false;
            // Deal with ambiguous >= pair
            if (nextis(Symbol.eq))
            {
               getsym();
               expressionStack.Push(ConvertSymToString(Symbol.gte));
            }
            else
            {
               expressionStack.Push(ConvertSymToString(sym));
            }
            getsym();
            boolExpression();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("relation");
      }
      //=======================================================================
      void match()
      {
         TraceIn("match");
         concat();
         if (accept(Symbol.MATCH) || accept(Symbol.MATCHES))
         {
            simpleVariable = false;
            concat();
            expressionStack.Push(string.Format("MATCH({1},{0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("match");
      }
      //=======================================================================
      void concat()
      {
         TraceIn("concat");
         format();
         while (sym == Symbol.colon)
         {
            simpleVariable = false;
            if (nextis(Symbol.eof) || nextis(Symbol.semicolon) || nextis(Symbol.TO)) break;
            expressionStack.Push("CONCAT");
            accept(Symbol.colon);
            boolTerm();
            //expressionStack.Push(string.Format("CAT({2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            expressionStack.Push(string.Format("{2} + {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("concat");
      }
      //=======================================================================
      void format()
      {
         TraceIn("format");
         dynarray();
         if (sym == Symbol.ident || sym == Symbol.text)
         {
            simpleVariable = false;
            factor();
            //expressionStack.Push(GetIdent());
            //getsym();
            expressionStack.Push(string.Format("FORMAT({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("format");
      }
      //=======================================================================
      void dynarray()
      {
         TraceIn("dynarray");
         expression();
         if (sym == Symbol.opencurly)
         {
            simpleVariable = false;
            boolExpression();
         }
         TraceOut("dynarray");
      }
      //=======================================================================
      void expression()
      {
         TraceIn("expression");
         term();
         while (sym == Symbol.plus || sym == Symbol.minus)
         {
            simpleVariable = false;
            expressionStack.Push(ConvertSymToString(sym));
            getsym();
            term();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("expression");
      }
      //=======================================================================
      void term()
      {
         TraceIn("term");
         substring();
         while (sym == Symbol.multiply || sym == Symbol.divide)
         {
            simpleVariable = false;
            expressionStack.Push(ConvertSymToString(sym));
            getsym();
            factor();
            expressionStack.Push(string.Format("{2} {1} {0}", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
         }
         TraceOut("term");
      }
      //=======================================================================
      void substring()
      {
         TraceIn("substring");
         signedFactor();
         if (accept(Symbol.opensquare))
         {
            simpleVariable = false;
            expressionStack.Push("SUBSTRING");
            boolTerm();
            if (accept(Symbol.comma))
            {
               expressionStack.Push(",");
               boolTerm();
               expect(Symbol.closesquare);
               expressionStack.Push(string.Format("{4}.Substring({2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            }
            else if (accept(Symbol.closesquare))
            {
               //boolTerm();
               expect(Symbol.closesquare);
               expressionStack.Push(string.Format("{2}.Substring({0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            }
         }
         TraceOut("substring");
      }
      //=======================================================================
      void signedFactor()
      {
         TraceIn("signedFactor");
         if (sym == Symbol.plus || sym == Symbol.minus)
         {
            simpleVariable = false;
            expressionStack.Push(ConvertSymToString(sym));
            getsym();
            factor();
            expressionStack.Push(string.Format("{1}{0}", expressionStack.Pop(), expressionStack.Pop()));
         }
         else
         {
            factor();
         }
         TraceOut("signedFactor");
      }
      //=======================================================================
      void factor()
      {
         TraceIn("factor");
         if (sym == Symbol.ident)
         {
            string ident = GetIdent();
            expressionStack.Push(ident);
            bool isIdentAnArray = false;
            if (dimVars.ContainsKey(GetOriginalIdent()))
            {
               isIdentAnArray = true;
            }
            if (IsCommonVar(GetOriginalIdent()))
            {
               isIdentAnArray = IsCommonVarAnArray(GetOriginalIdent());
            }
            getsym();

            // Arrays
            if (sym == Symbol.openround && isIdentAnArray)
            {
               accept(Symbol.openround);
               // Get First Dimension
               expressionStack.Push("[");
               boolExpression();
               if (accept(Symbol.comma))
               {
                  // Second Dimension
                  expressionStack.Push(",");
                  boolExpression();
                  expect(Symbol.closeround);
                  // Push two dimension array
                  expressionStack.Push(string.Format("{4}[{2}, {0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
               }
               else
               {
                  expect(Symbol.closeround);
                  // Push single dimension array
                  expressionStack.Push(string.Format("{2}[{0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
               }
            }
            // The only reason for this section of code is to cope
            // with non-dimensioned variables being followed by an
            // OpenBracket. This situation only arises for formatting
            // where the format expression is surrounded by "(...)"
            if (sym == Symbol.openround && !isIdentAnArray)
            {
               accept(Symbol.openround);
               //expressionStack.Push("(");
               boolExpression();
               expect(Symbol.closeround);
               expressionStack.Push(string.Format("FORMAT({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
            }
         }
         else if (sym == Symbol.number)
         {
            expressionStack.Push(identList[symPointer - 1]);
            getsym();
         }
         else if (sym == Symbol.text)
         {
            expressionStack.Push(identList[symPointer - 1]);
            getsym();
         }
         else if (sym == Symbol.AT)
         {
            // Special situation to deal with "@" variables
            getsym();
            if (accept(Symbol.openround))
            {
               simpleVariable = false;
               function_others(Symbol.AT);
            }
            else
            {
               atVariable();
            }
         }
         else if ((int)sym >= 1000)
         {
            simpleVariable = false;
            Symbol localSym = sym;
            getsym();
            accept(Symbol.openround);

            if ((int)localSym >= 1400)
            {
               function_others(localSym);
            }
            else if ((int)localSym >= 1300)
            {
               function_3args(localSym);
            }
            else if ((int)localSym >= 1200)
            {
               function_2args(localSym);
            }
            else if ((int)localSym >= 1100)
            {
               function_1arg(localSym);
            }
            else
            {
               function_0args(localSym);
            }
         }
         else if (accept(Symbol.opencurly))
         {
            // Get First Dimension
            expressionStack.Push("{");
            boolExpression();
            if (accept(Symbol.comma))
            {
               // Get Second Dimension
               expressionStack.Push(",");
               boolExpression();
               if (accept(Symbol.comma))
               {
                  // Get Third Dimension
                  expressionStack.Push(",");
                  boolExpression();
                  expect(Symbol.closecurly);
                  // Push three dimension array
                  //expressionStack.Push(string.Format("{6}.Extract({4}, {2}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                  expressionStack.Push(string.Format("{6}[{4}, {2}, {0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
               }
               else
               {
                  expect(Symbol.closecurly);
                  // Push two dimension array
                  expressionStack.Push(string.Format("{4}[{2}, {0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
               }
            }
            else
            {
               expect(Symbol.closecurly);
               // Push single dimension array
               expressionStack.Push(string.Format("{2}[{0}]", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
            }
         }
         else if (accept(Symbol.openround))
         {
            expressionStack.Push("(");
            boolExpression();
            expect(Symbol.closeround);
            expressionStack.Push(string.Format("{1}{0})", expressionStack.Pop(), expressionStack.Pop()));
         }
         else if (sym == Symbol.opensquare)
         {
            // do nothing - substring isn't a syntax error
         }
         else
         {
            //error("factor: syntax error");
            //getsym();
         }
         TraceOut("factor");
      }
      //=======================================================================
      private void atVariable()
      {
         //getsym();
         string ident = GetOriginalIdent();
         if (ident == "SELECTED")
         {
            getsym();
            expressionStack.Push("AT_SELECTED()");
            return;
         }
         if (ident == "AM")
         {
            getsym();
            expressionStack.Push("AT_AM()");
            return;
         }
         if (ident == "VM")
         {
            getsym();
            expressionStack.Push("AT_VM()");
            return;
         }
         if (ident == "SVM")
         {
            getsym();
            expressionStack.Push("AT_SVM()");
            return;
         }
         throw new ApplicationException("Unhandled @variable of " + ident);
      }
      //=======================================================================
      private string GetIdent()
      {
         return GetIdent(false);
      }
      //=======================================================================
      private string GetIdent(bool hide)
      {
         string ident = GetOriginalIdent();
         if (equateVars.ContainsKey(ident))
         {
            ident = equateVars[ident];
         }
         else if (IsCommonVar(ident))
         {
            ident = GetCommonVar(ident);
         }
         else
         {
            if (hide)
            {
               variableNames[ident] = VarUsage.Hide;
            }
            else
            {
               if (sym == Symbol.ident)
               {
                  variableNames[ident] = VarUsage.Assigned;
               }
            }
            ident = RenameIdent(ident);
         }
         return ident;
      }
      //=======================================================================
      private string GetIdent(VarUsage varUsage)
      {
         string ident = GetOriginalIdent();
         if (equateVars.ContainsKey(ident))
         {
            ident = equateVars[ident];
         }
         else if (IsCommonVar(ident))
         {
            ident = GetCommonVar(ident);
         }
         else
         {
            variableNames[ident] = varUsage;
            ident = RenameIdent(ident);
         }
         return ident;
      }
      //=======================================================================
      private string GetOriginalIdent()
      {
         return identList[symPointer - 1];
      }
      //=======================================================================
      private string RenameIdent(string ident)
      {
         return ident.Replace('.', '_');
      }
      //=======================================================================
      void function_0args(Symbol localSym)
      {
         expect(Symbol.closeround);
         expressionStack.Push(string.Format(localSym.ToString() + "()"));
      }
      //=======================================================================
      void function_1arg(Symbol localSym)
      {
         boolExpression();
         expect(Symbol.closeround);
         expressionStack.Push(string.Format(localSym.ToString() + "({0})", expressionStack.Pop()));
      }
      //=======================================================================
      void function_2args(Symbol localSym)
      {
         boolExpression();
         expect(Symbol.comma);
         boolExpression();
         expect(Symbol.closeround);
         expressionStack.Push(string.Format(localSym.ToString() + "({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void function_3args(Symbol localSym)
      {
         boolExpression();
         expect(Symbol.comma);
         boolExpression();
         expect(Symbol.comma);
         boolExpression();
         expect(Symbol.closeround);
         expressionStack.Push(string.Format(localSym.ToString() + "({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
      }
      //=======================================================================
      void function_others(Symbol localSym)
      {
         switch (localSym)
         {
            case Symbol.AT:
               {
                  boolExpression();
                  if (accept(Symbol.comma))
                  {
                     boolExpression();
                     expect(Symbol.closeround);
                     expressionStack.Push(string.Format("AT({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
                  }
                  else
                  {
                     expect(Symbol.closeround);
                     expressionStack.Push(string.Format("AT({0})", expressionStack.Pop()));
                  }
                  break;
               }
            case Symbol.DELETE:
               {
                  //DELETE(dynamic.array, field# [,value# [,subvalue#]])
                  boolExpression();//dynamic.array
                  expect(Symbol.comma);
                  boolExpression();//field#
                  if (accept(Symbol.comma))
                  {
                     boolExpression();//value#
                     if (accept(Symbol.comma))
                     {
                        boolExpression();//subvalue#
                        expect(Symbol.closeround);//dynamic.array, field# ,value# ,subvalue#
                        expressionStack.Push(string.Format("DELETE({3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                     }
                     else
                     {
                        expect(Symbol.closeround);//dynamic.array, field# ,value#
                        expressionStack.Push(string.Format("DELETE({2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                     }
                  }
                  else
                  {
                     expect(Symbol.closeround);//dynamic.array, field#
                     expressionStack.Push(string.Format("DELETE({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
                  }
                  break;
               }
            case Symbol.INSERT:
               {
                  /*
                  INSERT (dynamic.array, field#, value#, subvalue#, expression)
                  INSERT (dynamic.array, field# [,value# [,subvalue#]]; expression)                                               
                  */
                  boolExpression();//dynamic.array
                  expect(Symbol.comma);
                  boolExpression();//field#
                  if (accept(Symbol.comma))
                  {
                     boolExpression();//value#
                     if (accept(Symbol.comma))
                     {
                        boolExpression();//subvalue# or expression
                        if (accept(Symbol.comma) || accept(Symbol.semicolon))
                        {
                           boolExpression();//expression
                           expect(Symbol.closeround);//dynamic.array, field# ,value# ,subvalue#, expression
                           expressionStack.Push(string.Format("INSERT({4}, {3}, {2}, {1}, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                        }
                     }
                     else if (accept(Symbol.semicolon))
                     {
                        boolExpression();
                        expect(Symbol.closeround);//dynamic.array, field# 
                        expressionStack.Push(string.Format("INSERT({3}, {2}, {1}, 0, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                     }
                     else
                     {
                        expect(Symbol.closeround);//dynamic.array, field# ,value#
                        expressionStack.Push(string.Format("INSERT({2}, {1}, 0, 0, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                     }
                  }
                  else if (accept(Symbol.semicolon))
                  {
                     boolExpression();
                     expect(Symbol.closeround);//dynamic.array, field# ,value#
                     expressionStack.Push(string.Format("INSERT({2}, {1}, 0, 0, {0})", expressionStack.Pop(), expressionStack.Pop(), expressionStack.Pop()));
                  }
                  else
                  {
                     expect(Symbol.closeround);//dynamic.array, field#
                     expressionStack.Push(string.Format("INSERT({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
                  }
                  break;
               }
            case Symbol.STATUS:
               {
                  if (accept(Symbol.closeround))
                  {
                     expressionStack.Push(string.Format(localSym.ToString() + "()"));
                  }
                  break;
               }
            case Symbol.TRIM:
               {
                  boolExpression();
                  if (accept(Symbol.comma))
                  {
                     boolExpression();
                     expect(Symbol.closeround);
                     expressionStack.Push(string.Format("TRIM({1}, {0})", expressionStack.Pop(), expressionStack.Pop()));
                     break;
                  }
                  expect(Symbol.closeround);
                  expressionStack.Push(string.Format("TRIM({0})", expressionStack.Pop()));
                  break;
               }
         }
      }
      //=======================================================================
      string ConvertSymToString(Symbol localSym)
      {
         switch (localSym)
         {
            case Symbol.eq: return "==";
            case Symbol.neq: return "!=";
            case Symbol.lt: return "<";
            case Symbol.lt2: return "<";
            case Symbol.lte: return "<=";
            case Symbol.gt: return ">";
            case Symbol.gt2: return ">";
            case Symbol.gte: return ">=";
            case Symbol.and: return "&&";
            case Symbol.or: return "||";
            case Symbol.plus: return "+";
            case Symbol.minus: return "-";
            case Symbol.multiply: return "*";
            case Symbol.divide: return "/";
            case Symbol.assign: return "=";
            case Symbol.assplus: return "+=";
            case Symbol.assminus: return "-=";
            case Symbol.assmultiply: return "*=";
            case Symbol.assdivide: return "/=";
            case Symbol.assconcat: return "+=";
            default: return localSym.ToString().ToUpper();
         }
      }
      //=======================================================================
      void ResolveAmbiguities()
      {
         ResolveLT(-1);
         ResolveSTATUS();
      }
      //=======================================================================
      int ResolveLT(int sp)
      {
         //int saveSp = sp;
         sp++;
         while (sp < symbolList.Length)
         {
            Symbol symbol = symbolList[sp];
            if (symbol == Symbol.eof) break;
            switch (symbol)
            {
               case Symbol.lt:
                  {
                     sp = ResolveLT_GT(sp);
                     break;
                  }
            }
            sp++;
         }
         return sp;
      }
      //=======================================================================
      int ResolveLT_GT(int sp)
      {
         int saveSp = sp;
         sp++;
         while (sp < symbolList.Length)
         {
            Symbol symbol = symbolList[sp];
            if (symbol == Symbol.eof) break;
            switch (symbol)
            {
               case Symbol.lt:
                  {
                     sp = ResolveLT_GT(sp);
                     break;
                  }
               case Symbol.gt:
                  {
                     symbolList[saveSp] = Symbol.opencurly;
                     symbolList[sp] = Symbol.closecurly;
                     return sp;
                  }
               case Symbol.and:
                  {
                     return sp;
                  }
               case Symbol.or:
                  {
                     return sp;
                  }
            }
            sp++;
         }
         return sp;
      }
      //=======================================================================
      void ResolveSTATUS()
      {
         const string ChangeStatusTo = "ZZZ_STATUS";

         for (int sp = 0; sp < symbolList.Length && symbolList[sp] != Symbol.eof; sp++)
         {
            if (symbolList[sp] == Symbol.STATUS)
            {
               switch (symbolList[sp + 1])
               {
                  case Symbol.openround:
                     {
                        // STATUS function
                        break;
                     }
                  case Symbol.FROM:
                     {
                        // STATUS statement
                        break;
                     }
                  default:
                     {
                        // STATUS variable. Change it to ZZZ_STATUS
                        symbolList[sp] = Symbol.ident;
                        identList[sp] = ChangeStatusTo;
                        if (!variableNames.ContainsKey(ChangeStatusTo))
                        {
                           variableNames.Add(ChangeStatusTo, VarUsage.Unknown);
                        }
                        break;
                     }
               }
            }
         }
      }
      //=======================================================================
      public string Convert(Symbol[] symbolList, string[] identList)
      {
         this.symbolList = symbolList;
         this.identList = identList;

         ResolveAmbiguities();

         symPointer = 0;
         getsym();
         boolExpression();

         return expressionStack.Pop();
      }
      //=======================================================================
      public string Compile(Symbol[] symbolList, string[] identList)
      {
         this.symbolList = symbolList;
         this.identList = identList;
         expressionStack.Clear();

         ResolveAmbiguities();

         symPointer = 0;
         getsym();
         statementBlock();
         if (expressionStack.Count > 0)
         {
            Stack<string> newStack = new Stack<string>(expressionStack);

            StringBuilder newSource = new StringBuilder();
            while (newStack.Count > 0)
            {
               newSource.AppendLine(newStack.Pop());
            }
            expressionStack.Clear();
            return newSource.ToString();
         }
         else
         {
            return "";
         }
      }
      //=======================================================================
      public void Pass1(Symbol[] symbolList, string[] identList)
      {
         this.symbolList = symbolList;
         this.identList = identList;

         ResolveAmbiguities();

         symPointer = 0;
         getsym();
         equStatement();
      }
      //=======================================================================
      public void ConvertFile(string inputPath, string inputFile, string inputItem, string outputPath, string outputFile, string outputItem)
      {
         this.inputPath = inputPath;
         this.inputFile = inputFile;
         this.inputItem = inputItem;

         StringBuilder convertedSourceCode;
         string firstLine;
         Convertfile2(inputPath, inputFile, inputItem, out convertedSourceCode, out firstLine);

         CreateOutput(outputPath, outputFile, outputItem, convertedSourceCode, firstLine);
      }

      //=======================================================================
      private void Convertfile2(string inputPath, string inputFile, string inputItem, out StringBuilder convertedSourceCode, out string firstLine)
      {

         // PASS 1 - look for EQUATE statements       
         TextReader inputSource = new StreamReader(inputPath + "\\" + inputFile + "\\" + inputItem);
         string line;

         while ((line = inputSource.ReadLine()) != null)
         {
            Parse(line, out symbolList, out identList);
            //Pass1(symbolList, identList);
            pass = 1;
            Compile(symbolList, identList);
         }

         inputSource.Close();

         // PASS 2 - convert the code
         convertedSourceCode = new StringBuilder();

         inputSource = new StreamReader(inputPath + "\\" + inputFile + "\\" + inputItem);
         line = inputSource.ReadLine();
         Parse(line, out symbolList, out identList);
         pass = 2;
         firstLine = Compile(symbolList, identList);

         while ((line = inputSource.ReadLine()) != null)
         {
            Parse(line, out symbolList, out identList);

            pass = 2;
            string result = Compile(symbolList, identList);
            if (result != "\r\n" && result != "") convertedSourceCode.Append(result);
         }
         inputSource.Close();
      }

      //=======================================================================
      private void CreateOutput(string outputPath, string outputFile, string outputItem, StringBuilder convertedSourceCode, string firstLine)
      {
         // Build the Preamble
         StringBuilder preamble = new StringBuilder();

         preamble.AppendLine("using Legacy.Library;");
         preamble.AppendLine("namespace Legacy.LeisureFlex");
         preamble.AppendLine("{");
         preamble.AppendLine(string.Format("public class {0} : UvBase", RenameIdent(this.inputItem)));
         preamble.AppendLine("{");

         // Build the Variable initialisation
         StringBuilder varDecl = new StringBuilder();
         if (commonVars.Count > 0)
         {
            varDecl.AppendLine("#region Common instances");
            foreach (string commonName in (from k in commonVars.Keys orderby k ascending select k))
            {
               varDecl.AppendLine(string.Format("{0} {0} = {0}.Instance;", commonName));
            }
            varDecl.AppendLine("#endregion");
         }

         if (intConsts.Count > 0)
         {
            varDecl.AppendLine("#region Int Constants");
            foreach (string varName in (from k in intConsts.Keys orderby k ascending select k))
            {
               varDecl.AppendLine(string.Format("readonly UvVar {0} = {1};", RenameIdent(varName), intConsts[varName]));
            }
            varDecl.AppendLine("#endregion");
         }

         if (stringConsts.Count > 0)
         {
            varDecl.AppendLine("#region String Constants");
            foreach (string varName in (from k in stringConsts.Keys orderby k ascending select k))
            {
               varDecl.AppendLine(string.Format("readonly UvVar {0} = {1};", RenameIdent(varName), stringConsts[varName]));
            }
            varDecl.AppendLine("#endregion");
         }

         if (dimVars.Count > 0)
         {
            varDecl.AppendLine("#region Arrays");
            foreach (string varName in (from k in dimVars.Keys orderby k ascending select k))
            {
               if (dimVars[varName] == "")
               {
                  varDecl.AppendLine(string.Format("UvVar[] {0};", RenameIdent(varName)));
               }
               else if (dimVars[varName].Contains(","))
               {
                  //Two dimension arrays
                  varDecl.AppendLine(string.Format("UvVar[,] {0} = UvBase.DIM({1});", RenameIdent(varName), dimVars[varName]));
               }
               else
               {
                  //Single dimension arrays
                  varDecl.AppendLine(string.Format("UvVar[] {0} = UvBase.DIM({1});", RenameIdent(varName), dimVars[varName]));
               }
            }
            varDecl.AppendLine("#endregion");
         }

         if (variableNames.Count > 0)
         {
            varDecl.AppendLine("#region Variables");
            foreach (string varName in (from k in variableNames.Keys orderby k ascending select k))
            {
               if (!intConsts.ContainsKey(varName) &&
                   !stringConsts.ContainsKey(varName) &&
                   !equateVars.ContainsKey(varName) &&
                   !labels.Contains(varName) &&
                   !dimVars.ContainsKey(varName))
               {
                  bool found = IsCommonVar(varName);

                  if (!found)
                  {
                     if (variableNames[varName] == VarUsage.Assigned)
                     {
                        varDecl.AppendLine(string.Format("UvVar {0} = \"\";", RenameIdent(varName)));
                     }
                     if (variableNames[varName] == VarUsage.Subroutine)
                     {
                        varDecl.AppendLine(string.Format("{0} {0};", RenameIdent(varName)));
                     }
                  }
               }
            }
            varDecl.AppendLine("#endregion");
         }

         if (nonrefVarsCount > 0)
         {
            varDecl.AppendLine("#region Non Referenced Vars used by CALLs");
            for (int i = 0; i < nonrefVarsCount; i++)
            {
               varDecl.AppendLine(string.Format("UvVar nrf{0} = \"\";", i));
            }
            varDecl.AppendLine("#endregion");
         }

         StringBuilder postamble = new StringBuilder();
         postamble.AppendLine("}");
         postamble.AppendLine("}");

         // Some legacy programs do not have the final END statement
         // Check for this situation and add the closing } if necessary
         int numOfOpenCurly = Regex.Matches(convertedSourceCode.ToString(), "{").Count;
         int numOfCloseCurly = Regex.Matches(convertedSourceCode.ToString(), "}").Count;
         if (numOfOpenCurly == (numOfCloseCurly)) convertedSourceCode.AppendLine("}");

         TextWriter outputSource = new StreamWriter(outputPath + "\\" + outputFile + "\\" + RenameIdent(outputItem) + ".cs");

         outputSource.Write(preamble.ToString());
         outputSource.Write(varDecl.ToString());
         outputSource.Write(firstLine.ToString());
         outputSource.Write(convertedSourceCode.ToString());
         outputSource.Write(postamble);
         outputSource.Close();

         // Create the COMMON classes
         if (commonVars.Count > 0)
         {
            foreach (string commonName in commonVars.Keys)
            {
               outputSource = new StreamWriter(outputPath + "\\" + outputFile + "\\" + commonName + ".cs");
               outputSource.WriteLine("using Legacy.Library;");
               outputSource.WriteLine("namespace Legacy.LeisureFlex {");
               outputSource.WriteLine(string.Format("class {0}:UvCommon {{", commonName));


               foreach (KeyValuePair<string, string> commonVar in commonVars[commonName])
               {
                  string varName = commonVar.Key;
                  string fullVarName = commonVar.Value;
                  if (fullVarName.Contains("["))
                  {
                     int pos1 = fullVarName.IndexOf('[');
                     int pos2 = fullVarName.IndexOf(']');
                     string indexValue = fullVarName.Substring(pos1 + 1, pos2 - pos1 - 1);
                     outputSource.WriteLine(string.Format("public UvVar[] {0} = UvBase.DIM({1});", RenameIdent(varName), indexValue));
                  }
                  else
                  {
                     outputSource.WriteLine(string.Format("public UvVar {0} = \"\";", RenameIdent(varName)));
                  }
               }

               outputSource.WriteLine(string.Format("static readonly {0} instance = new {0}();", commonName));
               outputSource.WriteLine(string.Format("{0}() {{", commonName));
               outputSource.WriteLine("}");

               outputSource.WriteLine(string.Format("public static {0} Instance {{", commonName));
               outputSource.WriteLine("get { return instance; }");
               outputSource.WriteLine("}");

               outputSource.WriteLine("// Explicit static constructor to tell C# compiler");
               outputSource.WriteLine("// not to mark type as beforefieldinit");
               outputSource.WriteLine(string.Format("static {0}() {{ }}", commonName));

               outputSource.WriteLine("public override void Clear() {");

               foreach (KeyValuePair<string, string> commonVar in commonVars[commonName])
               {
                  string varName = commonVar.Key;
                  string fullVarName = commonVar.Value;
                  if (fullVarName.Contains("["))
                  {
                     int pos1 = fullVarName.IndexOf('[');
                     int pos2 = fullVarName.IndexOf(']');
                     string indexValue = fullVarName.Substring(pos1 + 1, pos2 - pos1 - 1);
                     outputSource.WriteLine(string.Format("{0} = UvBase.DIM({1});", RenameIdent(varName), indexValue));
                  }
                  else
                  {
                     outputSource.WriteLine(string.Format("{0} = \"\";", RenameIdent(varName)));
                  }
               }

               outputSource.WriteLine("}");
               outputSource.WriteLine("}");
               outputSource.WriteLine("}");
               outputSource.Close();
            }
         }

      }
      //=======================================================================
      private bool IsCommonVar(string varName)
      {
         bool found = false;
         foreach (string commonName in commonVars.Keys)
         {
            //if (commonVars[commonName].ContainsKey(RenameIdent(varName)))
            if (commonVars[commonName].ContainsKey(varName))
            {
               found = true;
               break;
            }
         }
         return found;
      }
      //=======================================================================
      private bool IsCommonVarAnArray(string varName)
      {
         foreach (string commonName in commonVars.Keys)
         {
            if (commonVars[commonName].ContainsKey(varName))
            {
               Dictionary<string, string> varList = commonVars[commonName];
               if (varList[varName].Contains("["))
               {
                  return true;
               }
               else
               {
                  return false;

               }
            }
         }
         return false;
      }
      //=======================================================================
      private string GetCommonVar(string varName)
      {
         foreach (string commonName in commonVars.Keys)
         {
            if (commonVars[commonName].ContainsKey(varName))
            {
               Dictionary<string, string> varList = commonVars[commonName];

               return commonName + "." + RenameIdent(varName);
            }
         }
         return "";
      }
      //=======================================================================
      void error(string text)
      {
         Console.WriteLine(text);
      }
      //=======================================================================
      public void Parse(string text, out Symbol[] symbolList, out string[] tokenList)
      {
         // Append Terminator Character
         text += "|";

         bool firstIdent = true;
         int sp = 0;
         symbolList = new Symbol[200];
         tokenList = new string[200];

         int i = 0;
         while (i < text.Length)
         {
            char letter = (char)text[i];
            if (letter == '|') break;

            // Skip over White Space
            if (letter == ' ' || letter == '\t' || letter == (char)65533)
            {
               do
               {
                  letter = (char)text[++i];
               } while (letter == ' ' || letter == '\t' || letter == (char)65533);
            }

            // Look for Ident starting with Alpha digit
            else if (letter >= 'A' && letter <= 'Z' ||
               letter >= 'a' && letter <= 'z')
            {
               int j = i;
               do
               {
                  letter = (char)text[++j];
               } while (letter >= 'A' && letter <= 'Z' ||
                        letter >= 'a' && letter <= 'z' ||
                        letter >= '0' && letter <= '9' ||
                        letter == '.' ||
                        letter == '_');

               string tokenValue = text.Substring(i, j - i);

               //Convert Keyword to Symbol
               if (keyWords.ContainsKey(tokenValue.ToUpper()))
               {
                  //Some programs use function names as Variable names
                  //Lookahead to see if this reserved word is
                  //followed by "(" - if not, treat it as just a variable
                  //However DELETE and STATUS are special cases because they
                  //are both a function and a statement.
                  if ((int)keyWords[tokenValue.ToUpper()] >= 1000 &&
                     keyWords[tokenValue.ToUpper()] != Symbol.DELETE &&
                     keyWords[tokenValue.ToUpper()] != Symbol.STATUS)
                  {
                     if (text.Substring(j, 1) != "(")
                     {
                        //Disambiguate
                        tokenValue = "ZZZ_" + tokenValue;
                        if (!variableNames.ContainsKey(tokenValue))
                        {
                           // Only add if it isn't a label
                           if (!(firstIdent && text[j] == ':'))
                           {
                              variableNames.Add(tokenValue, VarUsage.Unknown);
                           }
                        }
                        tokenList[sp] = tokenValue;
                        symbolList[sp++] = Symbol.ident;
                        firstIdent = false;
                     }
                     else
                     {
                        // Keyword is a Function and is followed by (
                        symbolList[sp++] = keyWords[tokenValue.ToUpper()];
                     }
                  }
                  else
                  {
                     // Keyword but not a Function
                     symbolList[sp++] = keyWords[tokenValue.ToUpper()];
                  }
               }
               else
               {
                  //tokenValue = tokenValue.Replace('.', '_');
                  if (!variableNames.ContainsKey(tokenValue))
                  {
                     // Only add if it isn't a label
                     if (!(firstIdent && text[j] == ':'))
                     {
                        variableNames.Add(tokenValue, VarUsage.Unknown);
                     }
                  }
                  tokenList[sp] = tokenValue;
                  symbolList[sp++] = Symbol.ident;
                  firstIdent = false;
               }
               i = j;
            }

            // Look for Double Quote delimited text
            else if (letter == '"')
            {
               int j = i;
               do
               {
                  letter = (char)text[++j];
               } while (letter != '"');
               string tokenValue = text.Substring(++i, j - i);
               tokenValue = tokenValue.Replace("\\", "\\\\");
               tokenList[sp] = "\"" + tokenValue + "\"";
               symbolList[sp++] = Symbol.text;
               i = ++j;
               letter = (char)text[i];
            }

            // Look for Single Quote delimited text
            else if (letter == '\'')
            {
               int j = i;
               do
               {
                  letter = (char)text[++j];
               } while (letter != '\'' && j < (text.Length - 1));

               string tokenValue = text.Substring(++i, j - i);
               tokenValue = tokenValue.Replace("\\", "\\\\");
               tokenList[sp] = "\"" + tokenValue.Replace("\"", "\\\"") + "\"";
               symbolList[sp++] = Symbol.text;
               i = ++j;
               if (i < text.Length)
               {
                  letter = (char)text[i];
               }
               else
               {
                  break;
               }
            }

            // Look for Numbers
            else if (letter >= '0' && letter <= '9' || letter == '.')
            {
               int j = i;
               do
               {
                  letter = (char)text[++j];
               } while ((letter >= '0' && letter <= '9') || letter == '.');

               string tokenValue = text.Substring(i, j - i);
               // Check for decimal point and if present treat as a Decimal
               if (tokenValue.Contains('.')) tokenValue += "M";
               tokenList[sp] = tokenValue;
               symbolList[sp++] = Symbol.number;
               i = j;
               letter = (char)text[i];
            }
            else
            {

               //Special characters
               switch (letter)
               {
                  case '<':
                     {
                        // Lookahead to see if we have a <>  (not equals) pair
                        if (text[i + 1] == '>')
                        {
                           i++;
                           symbolList[sp++] = Symbol.neq;
                        }
                        else
                           // Lookahead to see if we have a <= (less than or equals) pair
                           if (text[i + 1] == '=')
                           {
                              i++;
                              symbolList[sp++] = Symbol.lte;
                           }
                           else
                           {
                              symbolList[sp++] = Symbol.lt;
                           }
                        break;
                     }
                  case '>':
                     {
                        symbolList[sp++] = Symbol.gt;
                        break;
                     }
                  case '=':
                     {
                        symbolList[sp++] = Symbol.eq;
                        break;
                     }
                  case '#':
                     {
                        symbolList[sp++] = Symbol.neq;
                        break;
                     }
                  case '*':
                     {
                        // Store the remaining text in case this is a comment
                        tokenList[sp] = text.Substring(i + 1).Replace("|", "");

                        // Lookahead to see if we have a *= pair
                        if (text[i + 1] == '=')
                        {
                           i++;
                           symbolList[sp++] = Symbol.assmultiply;
                        }
                        else
                        {
                           symbolList[sp++] = Symbol.multiply;
                        }
                        break;
                     }
                  case '/':
                     {
                        // Lookahead to see if we have a /= pair
                        if (text[i + 1] == '=')
                        {
                           i++;
                           symbolList[sp++] = Symbol.assdivide;
                        }
                        else
                        {
                           symbolList[sp++] = Symbol.divide;
                        }
                        break;
                     }
                  case '+':
                     {
                        // Lookahead to see if we have a += pair
                        if (text[i + 1] == '=')
                        {
                           i++;
                           symbolList[sp++] = Symbol.assplus;
                        }
                        else
                        {
                           symbolList[sp++] = Symbol.plus;
                        }
                        break;
                     }
                  case '-':
                     {
                        // Lookahead to see if we have a -= pair
                        if (text[i + 1] == '=')
                        {
                           i++;
                           symbolList[sp++] = Symbol.assminus;
                        }
                        else
                        {
                           symbolList[sp++] = Symbol.minus;
                        }
                        break;
                     }
                  case '(':
                     {
                        symbolList[sp++] = Symbol.openround;
                        break;
                     }
                  case ')':
                     {
                        symbolList[sp++] = Symbol.closeround;
                        break;
                     }
                  case '[':
                     {
                        symbolList[sp++] = Symbol.opensquare;
                        break;
                     }
                  case ']':
                     {
                        symbolList[sp++] = Symbol.closesquare;
                        break;
                     }
                  case '@':
                     {
                        symbolList[sp++] = Symbol.AT;
                        break;
                     }
                  case ':':
                     {
                        // Lookahead to see if we have a := pair
                        if (text[i + 1] == '=')
                        {
                           i++;
                           symbolList[sp++] = Symbol.assconcat;
                        }
                        else
                        {
                           symbolList[sp++] = Symbol.colon;
                        }
                        break;
                     }
                  case ';':
                     {
                        symbolList[sp++] = Symbol.semicolon;
                        break;
                     }
                  case ',':
                     {
                        symbolList[sp++] = Symbol.comma;
                        break;
                     }
                  case '&':
                     {
                        symbolList[sp++] = Symbol.and;
                        break;
                     }
                  case '!':
                     {
                        // Store the remaining text in case this is a comment
                        tokenList[sp] = text.Substring(i + 1).Replace("|", "");
                        symbolList[sp++] = Symbol.pling;
                        break;
                     }
                  case '\\':
                     {
                        symbolList[sp++] = Symbol.backslash;
                        break;
                     }
                  case '_':
                     {
                        symbolList[sp++] = Symbol.underscore;
                        break;
                     }
                  case '$': break; // Ignore
                  case '?': break; // Ignore
                  case '^': break; // Ignore
                  case '%': break; // Ignore
                  case '|': break; //End of line
                  default:
                     {
                        throw new ApplicationException("Token " + letter + " is not recognised");
                     }
               }
               i++;
            }
         }
      }
      //=======================================================================
      void TraceIn(string text)
      {
         callLevel++;
         tracestack.Push(callLevel.ToString() + text);
         //string spaces = new string(' ', callLevel++);
         //Console.WriteLine(">" + spaces + text);
      }
      //=======================================================================
      void TraceOut(string text)
      {
         tracestack.Pop();
         --callLevel;
      }
      //=======================================================================
      void TraceOut(string text, bool success)
      {
         tracestack.Pop();
         --callLevel;
         //string spaces = new string(' ', --callLevel);
         //Console.WriteLine("<" + spaces + text + " " + success.ToString());
      }
   }
}


