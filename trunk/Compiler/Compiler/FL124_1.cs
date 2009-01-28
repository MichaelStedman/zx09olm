//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL124_1 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_BANK_DETAILS = 108;
      readonly UvVar BANK_SORT_CODE = 1;
      readonly UvVar BANK_ACCOUNT_NO = 2;
      readonly UvVar BANK_NAME = 3;
      readonly UvVar BANK_INSTALL_RECORDS = 4;
      readonly UvVar BANK_ACCOUNT_NAME = 5;
      readonly UvVar BANK_TRANS_CODE = 6;
      readonly UvVar BANK_BACS_REF = 7;
      readonly UvVar BANK_HOLDERS_ADDRESS = 8;
      readonly UvVar FL_DIRECT_DEBITS = 117;
      readonly UvVar DIRECT_DEBIT_INST_AMOUNT = 1;
      readonly UvVar DIRECT_DEBIT_ANNUAL_FEE = 2;
      readonly UvVar DIRECT_DEBIT_LETTER = 3;
      readonly UvVar DIRECT_DEBIT_ORIGINAL_DATE = 4;
      readonly UvVar DIRECT_DEBIT_NUMBER = 5;
      readonly UvVar DIRECT_DEBIT_AMOUNTS = 6;
      readonly UvVar DIRECT_DEBIT_DATES = 7;
      readonly UvVar DIRECT_DEBIT_OPERATOR = 8;
      readonly UvVar DIRECT_DEBIT_ADJ = 9;
      readonly UvVar DIRECT_DEBIT_PAID = 10;
      readonly UvVar DIRECT_DEBIT_TRANS_CNT = 11;
      readonly UvVar DIRECT_DEBIT_LAST_REQ_AMOUNT = 12;
      readonly UvVar DIRECT_DEBIT_LAST_DATE = 13;
      readonly UvVar DIRECT_DEBIT_LAST_RECD_AMOUNT = 14;
      readonly UvVar DIRECT_DEBIT_CANCELLED_DATE = 15;
      readonly UvVar DIRECT_DEBIT_DEPOSIT = 16;
      readonly UvVar DIRECT_DEBIT_REJECTIONS = 17;
      readonly UvVar DIRECT_DEBIT_ADJ_TYPE = 18;
      readonly UvVar DIRECT_DEBIT_FREEZE_DATE = 19;
      readonly UvVar DIRECT_DEBIT_CANCEL_REASON = 20;
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] BANK_REC = new UvVar[10];
      UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar REFERENCE = "";
      UvVar TYPE = "";
      UvVar DEBIT_NUMBER = "";
      UvVar DEBIT_LIST = "";
      UvVar TODAYS_DATE = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar COLOR_C = "";
      UvVar PROGRAM = "";
      UvVar INTERACT = "";
      UvVar DEBIT_CNT = "";
      UvVar WINDOW_ID = "";
      UvVar WINDOW = "";
      UvVar TOP_WINDOW = "";
      UvVar REDISPLAY = "";
      UvVar BOTTOM_WINDOW = "";
      UvVar LEFT_WINDOW = "";
      UvVar RIGHT_WINDOW = "";
      UvVar WINDOW_JUST = "";
      UvVar WINDOW_DEPTH = "";
      UvVar HEADING_TEXT = "";
      UvVar FOOTER = "";
      UvVar HEAD_ROW = "";
      UvVar DEBIT_TEXT_LIST = "";
      UvVar DEBIT_SET = "";
      UvVar REQUIRED_ID = "";
      FL006 FL006;
      UvVar POSTN = "";
      UvVar WAIT = "";
      UvVar BLANK_DISPLAY_COMPLETE = "";
      UvVar CNT = "";
      UvVar DEBIT_ID = "";
      UvVar DEBIT_TEXT = "";
      UvVar DEBIT_LINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL124_1(ref UvVar REFERENCE, ref UvVar TYPE, ref UvVar DEBIT_NUMBER, ref UvVar DEBIT_LIST)
      {
         this.REFERENCE = REFERENCE;
         this.TYPE = TYPE;
         this.DEBIT_NUMBER = DEBIT_NUMBER;
         this.DEBIT_LIST = DEBIT_LIST;
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
         /*     DIRECT DEBIT NUMBER SELECTION AND VALIDATION SUBROUTINE */
         /*  MODIFIED FL717 BY RT */
         /* ******************************************************************** */
         PROGRAM = "FL124.1";
         /*  Files */
         #region INCLUDE FL.FILES FL.BANK.DETAILS

         #endregion
         #region INCLUDE FL.FILES FL.DIRECT.DEBITS

         #endregion
         /*  Initialise variables */
         DEBIT_NUMBER = 0;
         MAT(ref DIRECT_DEBIT_REC, "");
         /*  GET LIST OF VALID DEBIT SETS, IF ONLY ONE IS FOUND RETURN IT */
         L1000();
         if (DEBIT_CNT == 1 || DEBIT_NUMBER == COMMON.ABANDON) { return; }
         WINDOW_ID = PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 9;
            WINDOW[2] = 18;
            WINDOW[3] = 2;
            WINDOW[4] = 77;
            WINDOW[5] = "Available Direct Debit Sets";
            WINDOW[6] = "Select Direct Debit Set or <RETURN> to scroll";
         }
         /*  SET WINDOW VARIABLES */
         TOP_WINDOW = WINDOW[1];
         REDISPLAY = TOP_WINDOW;
         BOTTOM_WINDOW = WINDOW[2];
         LEFT_WINDOW = WINDOW[3];
         RIGHT_WINDOW = WINDOW[4];
         WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
         WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
         HEADING_TEXT = WINDOW[5];
         FOOTER = WINDOW[6];
         /*  Box heading */
         /*  Display header one line lower when there are no input prompts */
         HEAD_ROW = TOP_WINDOW;
         PRINT(AT(79, HEAD_ROW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, HEAD_ROW) + UND_VID);
         PRINT(AT(LEFT_WINDOW, HEAD_ROW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
         L3000();
         /*  Display data portion of window */
         /*  Display blank box footing */
         PRINT(AT(79, 1 + BOTTOM_WINDOW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, 1 + BOTTOM_WINDOW) + UND_VID);
         PRINT(AT(LEFT_WINDOW, 1 + BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
         PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 1 + BOTTOM_WINDOW));
         return;
         /*   Return to calling program */
      }
      void L1000()
      {
         /*  GATHER DEBIT NUMBERS */
         DEBIT_NUMBER = 0;
         DEBIT_CNT = 0;
         DEBIT_LIST = "";
         DEBIT_TEXT_LIST = "";
         DEBIT_SET = 0;
         REQUIRED_ID = TYPE + "*" + REFERENCE;
         /*  READ CURRENT DEBIT SET FROM BANK DETAILS, THEN STEP BACK THROUGH */
         /*  HISTORIC SETS STRIPPING OUT INVALID/OUT OF DATE ENTRIES */
         /*  NB. Due to archiving the sequence could have been broken * */
         if (!(READV(ref DEBIT_SET, COMMON.FILES[FL_BANK_DETAILS], REQUIRED_ID, 4)))
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            DEBIT_SET = 1;
         }
         if (DEBIT_SET == "") { DEBIT_SET = 1; }
         do
         {
            if (!(DEBIT_SET > 0)) break;
            REQUIRED_ID = TYPE + "*" + REFERENCE + "*" + DEBIT_SET;
            if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], REQUIRED_ID))
            {
               if (!LOCATE(TODAYS_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref POSTN, "AR")) { NULL(); }
               if (POSTN <= DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER] || POSTN == 1)
               {
                  DEBIT_CNT = DEBIT_CNT + 1;
                  DEBIT_LIST[1, -1] = DEBIT_SET;
                  DEBIT_TEXT_LIST[1, -1] = "Started On " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE], "D2/") + ", Original amount of " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ANNUAL_FEE], "MD2") + FORMAT("  Set up by ", DIRECT_DEBIT_REC[DIRECT_DEBIT_OPERATOR]);
               }
            }
            DEBIT_SET = DEBIT_SET - 1;
         } while (true);
         if (DEBIT_CNT == 1) { DEBIT_NUMBER = 1; /*  SELECT FIRST ONE */ }
         /*  ignore all of above as different direct debit sets are no */
         /*  longer used - just set DEBIT.CNT = 1 and DEBIT.NUMBER = 1 */
         DEBIT_CNT = 1;
         DEBIT_NUMBER = 1;
         DEBIT_LIST = 1;
         return;
      }
      void L2000()
      {
         /*  Display last line message */
         INTERACT = INVALID_DATA;
         do
         {
            if (!(INTERACT == INVALID_DATA)) break;
            PRINT(AT(79, 1 + BOTTOM_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, 1 + BOTTOM_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, 1 + BOTTOM_WINDOW) + FORMAT(FOOTER, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 1 + BOTTOM_WINDOW));
            INPUT(out WAIT, 4);
            // BEGIN CASE
            // CASE
            if (WAIT == COMMON.ABANDON)
            {
               DEBIT_NUMBER = COMMON.ABANDON;
               INTERACT = FINISH;
            }// CASE
            else if (MATCH(WAIT, "0N") && WAIT != "")
            {
               DEBIT_NUMBER = WAIT;
               if (DEBIT_LIST[1, WAIT] == "")
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  INTERACT = FINISH;
               }
            }// CASE
            else if (OTHERWISE)
            {
               INTERACT = LIMIT;
            }
            // END CASE
         } while (true);
         return;
         /* **************************************************** */
      }
      void L3000()
      {
         /*   Display data section of window               * */
         /* **************************************************** */
         DEBIT_CNT = 1;
         INTERACT = INVALID_DATA;
         BLANK_DISPLAY_COMPLETE = FALSE;
         do
         {
            if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               DEBIT_ID = DEBIT_LIST[1, DEBIT_CNT];
               DEBIT_TEXT = DEBIT_TEXT_LIST[1, DEBIT_CNT];
               if (CNT > WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + TOP_WINDOW) + NRM_VID);
               if (DEBIT_ID == "")
               {
                  PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  DEBIT_LINE = FORMAT(DEBIT_CNT, "R#4") + SPACE(2) + FORMAT(DEBIT_ID, "R#5") + SPACE(2) + FORMAT(DEBIT_TEXT, "L#60");
                  PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT(DEBIT_LINE, WINDOW_JUST));
                  DEBIT_CNT = DEBIT_CNT + 1;
               }
            } while (true);
            /*  Don't prompt for course no. if this is the initial call to display a */
            /*  'blank' window */
            if (DEBIT_LIST != "") { L2000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
            /*  Restart display from first date when end of list is reached */
            if (DEBIT_ID == "")
            {
               DEBIT_CNT = 1;
            }
            CNT = 0;
         } while (true);
         return;
         return;
      }
   }
}
