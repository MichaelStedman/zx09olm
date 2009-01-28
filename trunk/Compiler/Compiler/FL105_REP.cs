//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL105_REP : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar EXECUTE_PROG = "";
      FL006 FL006;
      UvVar FILESIZE_STATUS = "";
      UvVar ANS = "";
      UvVar INSTRUCTION = "";
      UvVar MEDIA = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL105_REP()
      {
         #region INCLUDE FL.COMMON FL.COMMON

         /*  FILES */
         /*     Standard */
         /*     Screen Control */
         /*     Slave Printer Control */
         /*     Special Video */
         /*     User input control */
         /*     Application Specific */
         /* COMMON SC.POS */
         /*     Theatre */
         /*     Standard EQUates */
         /*     Client app control */
         /* \ */
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion

         #endregion
         /*  File Size report for NT users */
         PROGRAM = "FL105";
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         /*  Include Files */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /*  Check for universe machine and set up local Variables */
         if (MACHINE_TYPE != "UNIVERSE")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         if (!(READ(ref FILESIZE_STATUS, COMMON.FILES[FL_CONTROL], "NT.FILE.SIZE.STATUS")))
         {
            FILESIZE_STATUS = "1";
         }
         FILESIZE_STATUS = 1;
         INTERACT = VALID_DATA;
         /*  Main Control Block */
         L1000();
         /*  CONFIRM OK TO CONTINUE */
         do
         {
            if (INTERACT == EXIT || INTERACT == FINISH) break;
            /*         GOSUB 1500 ; * Delete Stat File */
            /*         GOSUB 1100 ; * Select Programs to Compile */
            L1200();
            /*  list file stats to printer */
            L1300();
            /*  Confirm Print Out */
         } while (true);
         return;
         /*  End of Subroutine */
         /* ***************************************** */
      }
      void L1000()
      {
         /*  Check that it is ok to continue * */
         /* ***************************************** */
         L1050();
         /*  Print title */
         PRINT(AT(10, 10) + "Do you wish to compile this Report? (y/n) ");
         INTERACT = INVALID_DATA;
         do
         {
            if (INTERACT == VALID_DATA || INTERACT == EXIT) break;
            PRINT(AT(53, 10));
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
            else if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (OTHERWISE)
            {
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            // END CASE
         } while (true);
         return;
         /* *** */
      }
      void L1050()
      {
         /*  PRINT TITLE SCREEN */
         /* *** */
         PRINTCR(COMMON.WASH);
         PRINTCR(AT(0, 0) + "(" + PROGRAM + ")" + SPACE(10) + "N.T File Size Statistics Report");
         PRINTCR(AT(17, 1) + STR("=", 31));
         return;
      /* *************************** */
      L1100: ;
         /*  Generate Stats file * */
         /* *************************** */
         DATA("ACCOUNT.FILE.STATS ");
         INSTRUCTION = "FORM-LIST FL.CONTROL FL.SYSTEM.FILES";
         /*      CALL @EXECUTE.PROG(INSTRUCTION,"O",LIST.1,LIST.AVAILABLE,MESSAGES,OTHERS) */
         EXECUTE(INSTRUCTION, string.Empty, string.Empty, string.Empty, string.Empty);
         /* INSTRUCTION = "ACCOUNT.FILE.STATS LOCAL" */
         /* EXECUTE INSTRUCTION */
         return;
         /* *************************** */
      }
      void L1200()
      {
         /*  Print/Display Stats  * */
         /* **************************** */
         L1050();
         PRINT(AT(10, 10) + COMMON.EOL + AT(10, 10) + "Do you want output to Screen or Printer (S/P) ?");
         PRINT(AT(60, 10));
         INPUTCR(out ANS, 2);
         if (ANS == "S" || ANS == "s")
         {
            MEDIA = "";
         }
         else
         {
            MEDIA = "RUNDATE LPTR";
            PRINTCR(AT(10, 12) + "Sending to printer.....");
         }
         INSTRUCTION = "SORT UNIVERSE.STAT.FILE WITH FILENAME # \"D_]\" BY ACCOUNTNAME BY FILENAME ACCOUNTNAME FILENAME FILEMOD FILESIZE RECORDS GRP100 GRP100+  ID-SUPP " + MEDIA;
         /*      CALL @EXECUTE.PROG(INSTRUCTION,"O",LIST.1,LIST.AVAILABLE,MESSAGES,OTHERS) */
         EXECUTE(INSTRUCTION, string.Empty, string.Empty, string.Empty, string.Empty);
         return;
         /* ******************************** */
      }
      void L1300()
      {
         /*  Is print Ok or Try again * */
         /* ******************************** */
         L1050();
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(AT(10, 10) + COMMON.EOL + AT(10, 10) + "Do you wish to reprint this Report? (y/n) ");
            if (!(INTERACT == INVALID_DATA)) break;
            PRINT(AT(52, 10));
            INPUTCR(out ANS, 2);
            // BEGIN CASE
            // CASE
            if (ANS == "Y" || ANS == "y")
            {
               L1200();
               L1050();
            }// CASE
            else if (ANS == "N" || ANS == "n")
            {
               INTERACT = FINISH;
            }// CASE
            else if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (OTHERWISE)
            {
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            // END CASE
         } while (true);
         return;
      /* *********************** */
      L1500: ;
         /*  Clear down Stats */
         /* *********************** */
         INSTRUCTION = "CLEAR-FILE DATA STAT.FILE";
         /*      CALL @EXECUTE.PROG(INSTRUCTION,"O",LIST.1,LIST.AVAILABLE,MESSAGES,OTHERS) */
         EXECUTE(INSTRUCTION, string.Empty, string.Empty, string.Empty, string.Empty);
         return;
      }
   }
}
