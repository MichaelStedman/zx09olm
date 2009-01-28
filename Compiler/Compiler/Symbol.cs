using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler
{
   public enum Symbol
   {
      // Base symbols in approx precedence order
      eof, ident, number, text, boolLit, boolVar,
      openround, closeround,
      eq, neq, lt, lt2, lte, gt, gt2, gte, or, and,
      multiply, divide, plus, minus,
      comma, colon, semicolon,
      opensquare, closesquare, pling, backslash, underscore,

      MATCH,
      MATCHES,

      // Assignment operators
      assign, assplus, assminus, assmultiply, assdivide, assconcat,

      // Not part of Universe BASIC but used to
      // differentiate between < and > which are 
      // used for both conditions and dynamic
      // array delimiters
      opencurly, closecurly,

      // Compiler directives
      COMMON,
      DEFFUN,
      DIM,
      EQU,
      EQUATE,
      INCLUDE,
      SUBROUTINE,

      // Keywords for EXECUTE statement
      CAPTURING,
      RETURNING,
      PASSLIST,
      RTNLIST,
      SETTING,

      // Keywords for LOCATE statement
      IN,
      BY,

      // Keyword for BREAK statement
      KEY,

      // Keyword for PRINTER statement
      RESET,

      // Keyword for READU statement
      LOCKED,

      // Keyword for INS statement
      BEFORE,

      // Statements
      BEGIN,
      BREAK,
      CALL,
      CASE,
      CHAIN,
      CLEARFILE,
      CLOSE,
      CLOSESEQ,
      CREATE,
      CRT,
      DATA,
      DEL,
      DISPLAY,
      DO,
      ECHO,
      ELSE,
      END,
      EXECUTE,
      FILELOCK,
      FILEUNLOCK,
      FOOTING,
      FOR,
      FROM,
      GET,
      GO,
      GOSUB,
      GOTO,
      HEADING,
      IF,
      INS,
      INPUT,
      LOCATE,
      LOCK,
      LOOP,
      MAT,
      MATPARSE,
      MATREAD,
      MATREADL,
      MATREADU,
      MATWRITE,
      MATWRITEU,
      NAP,
      NEXT,
      NULL,
      OFF,
      ON,
      OPEN,
      OPENSEQ,
      PAGE,
      PRINT,
      PRINTER,
      PROMPT,
      READ,
      READBLK,
      READNEXT,
      READU,
      READVU,
      READV,
      RELEASE,
      REPEAT,
      RETURN,
      RQM,
      SELECT,
      SEND,
      SLEEP,
      STEP,
      STOP,
      THEN,
      TO,
      UNTIL,
      WAITING,
      WEOFSEQ,
      WHILE,
      WRITE,
      WRITEBLK,
      WRITESEQ,
      WRITEU,
      WRITEVU,
      WRITEV,

      //Functions - with no arguments
      COL1 = 1000,
      COL2,
      DATE,
      KEYIN,
      TIME,
      TIMEDATE,

      //Functions - with 1 argument
      ABS = 1100,
      ALPHA,
      ASCII,
      ASSIGNED,
      CHAR,
      DQUOTE,
      EBCDIC,
      INT,
      LEN,
      LN,
      NOT,
      NUM,
      QUOTE,
      RND,
      SEQ,
      SOUNDEX,
      SPACE,
      SYSTEM,
      TERMINFO,

      //Functions - with 2 arguments
      COUNT = 1200,
      DCOUNT,
      ICONV,
      MOD,
      OCONV,
      REM,
      STR,

      //Functions - with 3 arguments
      CHANGE = 1300,
      CONVERT,
      FIELD,
      INDEX,

      //Functions - others
      AT = 1400,         //@ ( column [,row])
      //@ (-code [,arg])
      CHECKSUM,         //CHECKSUM (string)
      DELETE,           //DELETE(dynamic.array, field# [,value# [,subvalue#]])
      //DELETE [file.variable ,] record.ID
      EXTRACT,          //EXTRACT (dynamic.array, field# [,value# [,subvalue#]])
      INSERT,           //INSERT (dynamic.array, field#, value#, subvalue#, expression)
      REPLACE,          //REPLACE (expression, field#, value#, subvalue# {, | ;} replacement)                                       
      //REPLACE (expression [,field# [,value#]] ; replacement)
      STATUS,
      TRIM,             //TRIM (expression [,character [,option]] )
      UNASSIGNED        //UNASSIGNED (variable)
   }
   /* All statements
ABORT
ABORTE
ABORTM
ASSIGN
AUTHORIZATION
AUXMAP
BEGIN
BREAK
BSCAN
CALL
CHAIN
CLEAR
CLEARCOM
CLEARDATA
CLEARFILE
CLEARPROMPTS
CLEARSELECT
CLOSE
CLOSESEQ
COM
COMMON
CONTINUE
CONVERT
CREATE
CRT
DATA
DEBUG
DECLARE
DEFFUN
DEL
DELETE
DELETELIST
DELETEU
DIMENSION
ECHO
ENTER
EQUATE
ERRMSG
EXECUTE
EXIT
FILELOCK
FILEUNLOCK
FIND
FINDSTR
FLUSH
FOOTING
FOR
GET
GETLIST
GETX
GOSUB
GOTO
GROUPSTORE
HEADING
HEADINGE
HEADINGN
HUSH
IF
INPUT
INPUTCLEAR
INPUTDISP
INPUTDP
INPUTERR
INPUTIF
INPUTNULL
INPUTTRAP
INS
KEYEDIT
KEYEXIT
KEYTRAP
LET
LOCATE
LOCATEP
LOCK
LOOP
LOOPEOL
MAT
MATBUILD
MATPARSE
MATREAD
MATREADL
MATREADU
MATWRITE
MATWRITEU
NAP
NOBUF
NULL
ON
OPEN
OPENCHECK
OPENDEV
OPENPATH
OPENSEQ
PAGE
PCDRIVER
PERFORM
PRECISION
PRINT
PRINTER
PRINTERIO
PRINTERR
PRINTERRX
PROCREAD
PROCWRITE
PROMPT
RANDOMIZE
READ
READBLK
READL
READLIST
READNEXT
READSEQ
READT
READU
READV
READVL
READVU
RECIO
RECORDLOCKL
RECORDLOCKU
RELEASE
REMOVE
RETURN
REVREMOVE
REWIND
SEEK
SELECT
SELECTE
SELECTN
SELECTV
SELIND
SEND
SETIT
SETREM
SLEEP
SSELECT
SSELECTN
SSELECTV
STATUS
STOP
STOPE
STOPM
STORAGE
SWAP
TABSTOP
TIMEOUT
TPRINT
TRANSACTION
TTYCTL
TTYGET
*/
}
