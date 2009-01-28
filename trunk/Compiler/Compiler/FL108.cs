//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL108 : UvBase
   {
      #region Int Constants
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar ERROR = 7;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      #endregion
      #region Variables
      UvVar FL_FILE_SIZES = "";
      UvVar WASH = "";
      UvVar EOS = "";
      UvVar ABANDON = "";
      UvVar INTERACT = "";
      UvVar HISTORY_KEY = "";
      UvVar SCRXPOS = "";
      UvVar SCRYPOS = "";
      UvVar OTHERWISE = "";
      UvVar FL_CONTROL = "";
      UvVar ERRORMSG = "";
      UvVar RESIZE_REC = "";
      UvVar UPDATE_RESIZE_REC = "";
      UvVar SPEC_PASS = "";
      UvVar FILE_NO = "";
      UvVar MAXFILES = "";
      UvVar START_TIME = "";
      UvVar FILENAME = "";
      UvVar FILETYPE = "";
      UvVar FILEMOD = "";
      UvVar FILEDATE = "";
      UvVar MESSAGE = "";
      UvVar STATEMENT = "";
      UvVar INSTRUCTION = "";
      UvVar FILEN = "";
      UvVar END_TIME = "";
      UvVar LOGNAME = "";
      UvVar ANS = "";
      UvVar CUR_USER_POS = "";
      UvVar CUR_USERS = "";
      UvVar RLOOP = "";
      UvVar RESIZED_FILES = "";
      UvVar REPLY = "";
      #endregion
      public FL108()
      {
         /* ************************** */
         /*  RESIZE FILES           */
         /*  Stand alone program to resize files on NT */
         /* ****************************************** */
         /*  Set up local variables */
         /*  This program needs to be run from TCL or Logged To as it relies on */
         /*  all files being shut and a single user on the system */
         /*  The basic idea is that the Item FILES.TO.CHANGE in the FL.FILE.SIZES */
         /*  file contains a list on file names and */
         WASH = AT(-1);
         EOS = AT(-4);
         ABANDON = ".";
         PROMPT("");
         INTERACT = VALID_DATA;
         HISTORY_KEY = "FILES.CHANGED*" + DATE();
         SCRXPOS = 0;
         SCRYPOS = 5;
         OTHERWISE = 1;
         /* **** */
         /*  Open files */
         /* **** */
         if (!(OPEN("FL.FILE.SIZES", out FL_FILE_SIZES)))
         {
            PRINTCR(WASH + AT(10, 10) + "SERIOUS ERROR !!!!!!");
            PRINTCR(AT(10, 12) + "FL.FILE.SIZES MISSING");
            PRINTCR(AT(10, 14) + "Contact Flex Systems");
            PRINT(AT(10, 16) + "Press <Return>");
            return;;
         }
         if (!(OPEN("FL.CONTROL", out FL_CONTROL)))
         {
            ERRORMSG = "Cannot Open FL.CONTROL";
            L9000();
            return;;
         }
         if (!(READ(ref RESIZE_REC, FL_FILE_SIZES, "FILES.TO.CHANGE")))
         {
            ERRORMSG = "File Size Parameter have not been set";
            L9000();
            return;
         }
         UPDATE_RESIZE_REC = RESIZE_REC;
         if (!(READ(ref SPEC_PASS, FL_CONTROL, "SPECIALS.PASS")))
         {
            SPEC_PASS = "SYZYGY";
         }
         /* ** */
         /*  Check that it is ok to run this routine */
         /* ** */
         L0100();
         /*  Verify that all is ok to continue */
         if (INTERACT == EXIT) { return;; }
         L0200();
         /*  Check for logged on users */
         L0300();
         /*  Update Screen */
         /* ** */
         /*  LOOP THROUGH EACH FILE AND RESIZE IT */
         /* ** */
         FILE_NO = 1;
         MAXFILES = RESIZE_REC[1];
         START_TIME = TIME();
         WRITEV(START_TIME, FL_FILE_SIZES, "START.TIME", 1);
         do
         {
            if (FILE_NO > MAXFILES) break;
            FILENAME = RESIZE_REC[2, FILE_NO];
            L0400();
            /* Get Screen Pos */
            PRINTCR(AT(SCRXPOS, SCRYPOS) + FORMAT(FILENAME, "L#18"));
            FILETYPE = RESIZE_REC[3, FILE_NO];
            FILEMOD = RESIZE_REC[4, FILE_NO];
            FILEDATE = RESIZE_REC[5, FILE_NO];
            /* !!!!!!!!! */
            EXECUTE("CLEAR-FILE DATA WORK.RESIZE", MESSAGE, string.Empty, string.Empty, string.Empty);
            CRTCR(MESSAGE);
            DATA("(WORK.RESIZE)");
            STATEMENT = "COPY " + FILENAME + " * (I)";
            EXECUTE(STATEMENT, MESSAGE, string.Empty, string.Empty, string.Empty);
            CRTCR(MESSAGE);
            INSTRUCTION = "DELETE-FILE DATA " + FILENAME;
            EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
            CRTCR(MESSAGE);
            INSTRUCTION = "CREATE-FILE DATA " + FILENAME + " " + FILEMOD;
            CRTCR(INSTRUCTION);
            EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
            CRTCR(MESSAGE);
            FILEN = "(" + FILENAME;
            DATA(FILEN);
            EXECUTE("COPY WORK.RESIZE * (I,D)", MESSAGE, string.Empty, string.Empty, string.Empty);
            CRTCR(MESSAGE);
            /* !!!!!!!!! */
            L1000();
            /*  Check message & write to completed item */
            FILE_NO = FILE_NO + 1;
         } while (true);
         /* *** */
         /*  ALL DONE */
         /* *** */
         END_TIME = TIME();
         WRITEV(END_TIME, FL_FILE_SIZES, "END.TIME", 1);
         return;;
      }
      void L0100()
      {
         /*  Check that the user want to continue */
         /* ***** */
         PRINTCR(WASH);
         PRINTCR("User : " + AT(LOGNAME));
         /*  IF @LOGNAME # "ADMINISTRATOR" THEN  */
         /*  ERRORMSG = "MUST BE ADMINISTRATOR" */
         /*  END */
         PRINTCR(AT(15, 1) + "Flex - Windows NT File Resizing routine");
         PRINTCR(AT(15, 2) + "=======================================");
         PRINTCR(AT(10, 5) + "Please ensure that : ");
         PRINTCR(AT(10, 6) + "1) All other users are logged off");
         PRINTCR(AT(10, 7) + "2) You have correct authority within NT");
         PRINTCR(AT(10, 8) + "3) There is enough disk space available on NT");
         PRINTCR(AT(10, 10) + "======================================");
         PRINT(AT(10, 12) + "ARE YOU SURE THAT YOU WISH TO CONTINUE (y/n) ");
         INTERACT = INVALID_DATA;
         do
         {
            if (INTERACT != INVALID_DATA) break;
            PRINT(AT(55, 12));
            INPUTCR(out ANS, 2);
            // BEGIN CASE
            // CASE
            if (ANS == "Y" || ANS == "y")
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS == "N" || ANS == "n")
            {
               INTERACT = EXIT;
            }// CASE
            else if (ANS == ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (OTHERWISE)
            {
               PRINT(AT(0, 22) + " Please Type either Y to Continue or N to exit without resizing ");
               INPUTCR(out ANS, 2);
               PRINT(AT(0, 22) + SPACE(70));
            }
            // END CASE
         } while (true);
         return;
         /* ***** */
      }
      void L0200()
      {
         /*  Check that all users are logged off */
         /* ***** */
         EXECUTE("LISTU", MESSAGE, string.Empty, string.Empty, string.Empty);
         CUR_USER_POS = INDEX(MESSAGE, "currently", 1) + 10;
         MESSAGE = MESSAGE.Substring(CUR_USER_POS, 10);
         CUR_USER_POS = INDEX(MESSAGE, " ", 1);
         CUR_USERS = MESSAGE.Substring(1, CUR_USER_POS);
         if (CUR_USERS > 1)
         {
            ERRORMSG = "THERE ARE CURRENTLY " + CUR_USERS + " Logged on!!!";
            L9000();
            if (INTERACT == EXIT) { return;; }
         }
         return;
         /* ***** */
      }
      void L0300()
      {
         /*  Display Resize screen */
         /* ***** */
         PRINTCR(AT(0, 4) + EOS);
         PRINTCR(AT(5, 4) + "Please Wait... Resizing in process : ");
         return;
         /* ***** */
      }
      void L0400()
      {
         /*  Get next screen position */
         /* ***** */
         SCRYPOS = SCRYPOS + 1;
         if (SCRYPOS > 20)
         {
            SCRXPOS = SCRXPOS + 20;
            if (SCRXPOS >= 80)
            {
               PRINTCR(AT(0, 5) + EOS);
               SCRXPOS = 0;
               SCRYPOS = 5;
            }
         }
         return;
         /* ** */
      }
      void L1000()
      {
         /*  Check error message & write to completed item */
         /* *** */
         UPDATE_RESIZE_REC = UPDATE_RESIZE_REC[1] - 1;
         for (RLOOP = 2; RLOOP <= 5; RLOOP += 1)
         {
            UPDATE_RESIZE_REC = DELETE(UPDATE_RESIZE_REC, RLOOP, 1);
         }
         if (UPDATE_RESIZE_REC[1] > 0)
         {
            WRITE(UPDATE_RESIZE_REC, FL_FILE_SIZES, "FILES.TO.CHANGE");
         }
         else
         {
            DELETE(FL_FILE_SIZES, "FILES.TO.CHANGE");
         }
         if (!(READ(ref RESIZED_FILES, FL_FILE_SIZES, HISTORY_KEY)))
         {
            RESIZED_FILES = "";
            RESIZED_FILES[1] = 0;
         }
         RESIZED_FILES[1] = RESIZED_FILES[1] + 1;
         RESIZED_FILES[2, -1] = FILENAME;
         RESIZED_FILES[3, -1] = FILETYPE;
         RESIZED_FILES[4, -1] = FILEMOD;
         RESIZED_FILES[5, -1] = FILEDATE;
         WRITE(RESIZED_FILES, FL_FILE_SIZES, HISTORY_KEY);
         return;
      }
      void L9000()
      {
         /*  ERROR MESSAGE */
         PRINTCR(AT(0, 5) + EOS);
         PRINTCR(AT(10, 10) + ERRORMSG);
         PRINTCR(AT(10, 12) + "See your administrator");
         PRINT(AT(10, 14) + "Press <Return>");
         ECHO_OFF();
         INPUTCR(out REPLY);
         ECHO_ON();
         if (REPLY == SPEC_PASS)
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = EXIT;
         }
         return;
      
         /*  END OF PROGRAM */
         /*  EXECUTE "OFF" */
      }
   }
}
