//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL822 : UvBase
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
      readonly UvVar FL_TICKET_FEES = 12;
      readonly UvVar TICK_FEES_DESC = 1;
      readonly UvVar TICK_FEES_PRICE = 2;
      readonly UvVar TICK_FEES_GLCODE = 3;
      readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
      readonly UvVar TICK_FEES_OFF_PRICES = 5;
      readonly UvVar TICK_FEES_OFF_START_MON = 6;
      readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
      readonly UvVar TICK_FEES_OFF_START_SAT = 8;
      readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
      readonly UvVar TICK_FEES_OFF_START_SUN = 10;
      readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
      readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
      readonly UvVar TICK_FEES_NEW_PRICE = 13;
      readonly UvVar TICK_FEES_OPEN_RANGE = 14;
      readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
      readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
      readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
      readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
      readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
      readonly UvVar TICK_FEES_VAT_QUESTION = 20;
      readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
      readonly UvVar TICK_FEES_GROUP_CODE = 22;
      readonly UvVar TICK_FEES_HEADCOUNT = 23;
      readonly UvVar TICK_FEES_CONCESSIONS = 24;
      readonly UvVar TICK_FEES_PEAK_PRICES = 25;
      readonly UvVar TICK_FEES_OFF1_PRICES = 26;
      readonly UvVar TICK_FEES_OFF2_PRICES = 27;
      readonly UvVar TICK_FEES_OFF3_PRICES = 28;
      readonly UvVar TICK_FEES_OFF4_PRICES = 29;
      readonly UvVar TICK_FEES_SPLIT_OWED = 30;
      readonly UvVar TICK_FEES_SPLIT_PAID = 31;
      readonly UvVar TICK_FEES_SPORTS = 32;
      readonly UvVar TICK_FEES_RESALE_RATE = 33;
      readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
      readonly UvVar TICK_FEES_TEXT = 35;
      readonly UvVar TICK_FEES_MEMBER_REQ = 36;
      readonly UvVar TICK_FEES_STYLE = 37;
      readonly UvVar TICK_FEES_GROUPED = 38;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] TICK_FEES_REC = new UvVar[40];
      #endregion
      #region Variables
      UvVar FEE_TYPE = "";
      UvVar TICKET_FEE = "";
      UvVar INTERACT = "";
      UvVar REDISPLAY = "";
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar COLOR_C = "";
      UvVar AM = "";
      UvVar WINDOW = "";
      UvVar PROGRAM = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar WINDOW_ID = "";
      UvVar TOP_WINDOW = "";
      UvVar BOTTOM_WINDOW = "";
      UvVar LEFT_WINDOW = "";
      UvVar RIGHT_WINDOW = "";
      UvVar WINDOW_JUST = "";
      UvVar WINDOW_DEPTH = "";
      UvVar HEADING_TEXT = "";
      UvVar HEADING_TEXT2 = "";
      UvVar FOOTER = "";
      UvVar FEE_LIST = "";
      UvVar DESC_LIST = "";
      UvVar CODES_FOUND = "";
      UvVar ID_STRING = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar CC = "";
      UvVar ID = "";
      UvVar CONTROL_REC = "";
      UvVar NO_ATTS = "";
      UvVar FEE_CODE = "";
      UvVar FEE_ID = "";
      UvVar DESC = "";
      FL006 FL006;
      UvVar WAIT = "";
      UvVar FEE_NO = "";
      UvVar BLANK_DISPLAY_COMPLETE = "";
      UvVar CNT = "";
      UvVar DISPLAY_LINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL822(ref UvVar FEE_TYPE, ref UvVar TICKET_FEE, ref UvVar INTERACT, ref UvVar REDISPLAY)
      {
         this.FEE_TYPE = FEE_TYPE;
         this.TICKET_FEE = TICKET_FEE;
         this.INTERACT = INTERACT;
         this.REDISPLAY = REDISPLAY;
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
         /*     TICKET FEE SELECTION WINDOW */
         PROGRAM = "FL822";
         INTERACT = INVALID_DATA;
         REDISPLAY = "";
         COMMON.CLR = "\\";
         TICKET_FEE = "";
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         /*  Include relevant file info */
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         WINDOW_ID = PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 9;
            WINDOW[2] = 18;
            WINDOW[3] = 1;
            WINDOW[4] = 77;
         }
         TOP_WINDOW = WINDOW[1];
         BOTTOM_WINDOW = WINDOW[2];
         LEFT_WINDOW = WINDOW[3];
         RIGHT_WINDOW = WINDOW[4];
         WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
         WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
         HEADING_TEXT = WINDOW[5];
         HEADING_TEXT2 = WINDOW[6];
         FOOTER = " Select Code No. or <Return> to scroll ";
         FEE_LIST = "";
         DESC_LIST = "";
         /*  Box heading */
         PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
         /*  Box Sub-Heading */
         PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
         L3000();
         /*  Display data portion of window */
         /*  Display box footing */
         PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT("  Searching...", WINDOW_JUST));
         PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
         CODES_FOUND = FALSE;
         /* *   LOOP */
         /* *     UNTIL INTERACT = EXIT OR CODES.FOUND DO */
         if (FEE_TYPE == "C")
         {
            ID_STRING = "CONTROL*" + COMMON.CENTRE + "*]";
         }
         else
         {
            if (FEE_TYPE == "CO")
            {
               ID_STRING = "CONTROL*" + COMMON.CENTRE + "*C*]";
            }
            else
            {
               ID_STRING = "CONTROL*" + COMMON.CENTRE + "*" + FEE_TYPE + "*]";
            }
         }
         /* !!  INSTRUCTION = 'SSELECT FL.TICKET.FEES = "CONTROL*':CENTRE:'*C*]" BY CONTROL.DESC' */
         INSTRUCTION = "SSELECT FL.TICKET.FEES = \"" + ID_STRING + "\" BY CONTROL.DESC";
         if (FEE_TYPE == "C")
         {
            /*  ID.STRING will return too many items - exclude those with more than */
            /*  two asterisks in the key */
            INSTRUCTION = INSTRUCTION + " AND WITH KEY4 = \"\"";
         }
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         EOF = FALSE;
         CC = 0;
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            /*  Read in the latest ticket fee record */
            if (!READ(ref CONTROL_REC, COMMON.FILES[FL_TICKET_FEES], ID)) { CONTROL_REC = ""; }
            NO_ATTS = DCOUNT(CONTROL_REC, AM);
            if (FEE_TYPE == "C")
            {
               FEE_CODE = FIELD(ID, "*", 3);
            }
            else
            {
               FEE_CODE = FIELD(ID, "*", 4);
            }
            if (FEE_TYPE == "C")
            {
               FEE_ID = COMMON.CENTRE + "*" + FEE_CODE + "*" + CONTROL_REC[NO_ATTS];
            }
            else
            {
               if (FEE_TYPE == "CO")
               {
                  FEE_ID = COMMON.CENTRE + "*C*" + FEE_CODE + "*" + CONTROL_REC[NO_ATTS];
               }
               else
               {
                  FEE_ID = COMMON.CENTRE + "*" + FEE_TYPE + "*" + FEE_CODE + "*" + CONTROL_REC[NO_ATTS];
               }
            }
            /* !!     FEE.ID = CENTRE:"*C*":FEE.CODE:"*":CONTROL.REC<NO.ATTS> */
            CC = CC + 1;
            FEE_LIST[1, CC] = FEE_CODE;
            if (!READV(ref DESC, COMMON.FILES[FL_TICKET_FEES], FEE_ID, 1)) { DESC = ""; }
            DESC_LIST[1, CC] = DESC;
         } while (true);
         if (CC == 0)
         {
            /*     No items selected */
            nrf0 = 2;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = FINISH;
         }
         else
         {
            CODES_FOUND = TRUE;
         }
         /* *   REPEAT */
         /*  Function is set to LIMIT if the user hits <Return> to scroll the display */
         if (INTERACT != EXIT)
         {
            L3000();
            /*  Display data portion of window */
         }
         /*  Return to calling program */
         if (INTERACT == FINISH)
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L1000()
      {
         /*  Display last line message */
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
            INPUT(out WAIT, 4);
            // BEGIN CASE
            // CASE
            if (WAIT == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               REDISPLAY = TOP_WINDOW;
            }// CASE
            else if (WAIT == "0")
            {
               nrf0 = 1;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (MATCH(WAIT, "0N") && WAIT != "")
            {
               TICKET_FEE = FEE_LIST[1, WAIT];
               if (TICKET_FEE == "")
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  INTERACT = FINISH;
                  REDISPLAY = TOP_WINDOW;
               }
            }// CASE
            else if (OTHERWISE)
            {
               INTERACT = LIMIT;
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* *************************************************** */
      }
      void L3000()
      {
         /*   Display data section of window              * */
         /* *************************************************** */
         FEE_NO = 1;
         INTERACT = INVALID_DATA;
         BLANK_DISPLAY_COMPLETE = FALSE;
         do
         {
            if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               TICKET_FEE = FEE_LIST[1, FEE_NO];
               if (CNT >= WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + 4) + NRM_VID);
               if (TICKET_FEE == "")
               {
                  PRINT(AT(LEFT_WINDOW, CNT + 4) + COLOR_C + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  DISPLAY_LINE = FORMAT(FEE_NO, "R#4") + "  " + FORMAT(TICKET_FEE, "L#7") + "  " + DESC_LIST[1, FEE_NO];
                  PRINT(AT(LEFT_WINDOW, CNT + 4) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
               }
               FEE_NO = FEE_NO + 1;
            } while (true);
            /*  Don't prompt for course no. if this is the initial call to display a */
            /*  'blank' window */
            if (FEE_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
            /*  Restart display from first date when end of list is reached */
            if (TICKET_FEE == "")
            {
               FEE_NO = 1;
            }
            CNT = 0;
         } while (true);
         return;
      }
   }
}
