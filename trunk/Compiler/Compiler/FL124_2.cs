//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL124_2 : UvBase
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
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      readonly UvVar REFRESH = 7;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar WNDO_TEXT_LIST = "";
      UvVar WNDO_DATA_POS = "";
      UvVar REQD_ITEM = "";
      UvVar CALLING_PROGRAM = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar COLOR_C = "";
      UvVar WINDOW = "";
      UvVar PROGRAM = "";
      UvVar DFL_DIRECT_DEBITS = "";
      UvVar INTERACT = "";
      UvVar DD_DAY_PARAM = "";
      UvVar WINDOW_ID = "";
      UvVar TOP_WINDOW = "";
      UvVar REDISPLAY = "";
      UvVar BOTTOM_WINDOW = "";
      UvVar LEFT_WINDOW = "";
      UvVar RIGHT_WINDOW = "";
      UvVar WINDOW_JUST = "";
      UvVar WINDOW_DEPTH = "";
      UvVar HEADING_TEXT = "";
      UvVar FOOTER = "";
      UvVar WNDO_CNT = "";
      UvVar HEAD_ROW = "";
      UvVar WAIT = "";
      FL006 FL006;
      UvVar BLANK_DISPLAY_COMPLETE = "";
      UvVar CNT = "";
      UvVar WNDO_TEXT = "";
      UvVar WDNO_LINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL124_2(ref UvVar WNDO_TEXT_LIST, ref UvVar WNDO_DATA_POS, ref UvVar REQD_ITEM, ref UvVar CALLING_PROGRAM)
      {
         this.WNDO_TEXT_LIST = WNDO_TEXT_LIST;
         this.WNDO_DATA_POS = WNDO_DATA_POS;
         this.REQD_ITEM = REQD_ITEM;
         this.CALLING_PROGRAM = CALLING_PROGRAM;
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
         /*  SCROLLING WINDOW - SUPPLY MV TEXT AND CURRENT.DATA LINE */
         /*     RETURNS ITEM ID REQUIRED */
         /*  MODIFIED FL717 BY RT */
         PROGRAM = "FL124.2";
         /*  Include relevant file info */
         if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
         /*  SET LOCAL VARIABLES */
         if (!(READV(ref DD_DAY_PARAM, DFL_DIRECT_DEBITS, "BACS.CONTROL", 1)))
         {
            DD_DAY_PARAM = "";
         }
         /*      WINDOW.ID = PROGRAM : ".WINDOW" */
         WINDOW_ID = CALLING_PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 8;
            WINDOW[2] = 21;
            WINDOW[3] = 2;
            WINDOW[4] = 77;
            WINDOW[5] = "   Date         Debit        Adj.  Type   Balance    Paid    New Adj.  Type";
            if (DD_DAY_PARAM[1, 2] == "")
            {
               WINDOW[6] = "No to Adjust,(I)nsrt,(C)ncl,(F)rz,(L)tr,<RTN> to scrl,END to file";
            }
            else
            {
               /* WINDOW<6> = "Number to Adjust, (I)nsert,  (C)ancel, (L)etter, (D)ay, END to file" */
               WINDOW[6] = "No to Adjust,(I)nsrt,(C)ncl,(F)rz,(D)ay,(L)tr,<RTN> to scrl,END to file";
            }
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
         if (WNDO_DATA_POS > 0)
         {
            WNDO_CNT = WNDO_DATA_POS;
         }
         else
         {
            /*  Box heading */
            HEAD_ROW = TOP_WINDOW;
            PRINT(AT(79, HEAD_ROW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, HEAD_ROW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, HEAD_ROW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
            L3000();
            /*  Display data portion of window */
            /*  Display blank box footing */
            PRINT(AT(79, BOTTOM_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, BOTTOM_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), BOTTOM_WINDOW));
            /*      PRINT @(LEFT.WINDOW+2+LEN(FOOTER),BOTTOM.WINDOW): */
            /*  Return to calling program */
            return;
         }
      }
      void L2000()
      {
         /* * */
         /*  Display last line message */
         /* * */
         INTERACT = INVALID_DATA;
         do
         {
            if (!(INTERACT == INVALID_DATA)) break;
            PRINT(AT(79, BOTTOM_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, BOTTOM_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, BOTTOM_WINDOW) + FORMAT(FOOTER, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + 1 + LEN(FOOTER), BOTTOM_WINDOW));
            INPUT(out WAIT, 4);
            /* * */
            // BEGIN CASE
            // CASE
            if (WAIT == "END" || WAIT == "end")
            {
               INTERACT = FINISH;
               REQD_ITEM = "END";
            }// CASE
            else if (WAIT == COMMON.ABANDON)
            {
               REQD_ITEM = COMMON.ABANDON;
               INTERACT = FINISH;
               /*  CHECK THAT USER SELECTS VALID ENTRY AND MAKE SURE THAT IT IS ON SCREEN */
            }// CASE
            else if (MATCH(WAIT, "0N") && WAIT != "" && WAIT != "0")
            {
               REQD_ITEM = WAIT;
               if (WNDO_TEXT_LIST[1, WAIT].Substring(1, 1) == " ")
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  if (WAIT <= WNDO_CNT - WINDOW_DEPTH || WAIT >= WNDO_CNT)
                  {
                     INTERACT = REFRESH;
                     WNDO_CNT = WAIT;
                  }
                  else
                  {
                     INTERACT = FINISH;
                  }
               }
            }// CASE
            else if (WAIT == "P" || WAIT == "N")
            {
               REQD_ITEM = WAIT;
               INTERACT = FINISH;
            }// CASE
            else if (WAIT == "")
            {
               INTERACT = LIMIT;
            }// CASE
            else if (OTHERWISE)
            {
               INTERACT = FINISH;
               REQD_ITEM = WAIT;
            }
            // END CASE
            /* * */
         } while (true);
         return;
         /* * */
         /* * */
         /* **************************************************** */
      }
      void L3000()
      {
         /*   Display data section of window              * */
         /* **************************************************** */
         /* * */
         INTERACT = INVALID_DATA;
         BLANK_DISPLAY_COMPLETE = FALSE;
         do
         {
            if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT || INTERACT == REFRESH) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
            WNDO_DATA_POS = WNDO_CNT;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               WNDO_TEXT = WNDO_TEXT_LIST[1, WNDO_CNT];
               if (CNT >= WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + TOP_WINDOW) + NRM_VID);
               if (WNDO_TEXT_LIST == "")
               {
                  PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  WDNO_LINE = FORMAT(WNDO_CNT, "R#4") + SPACE(2) + WNDO_TEXT;
                  PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT(WNDO_TEXT, WINDOW_JUST));
                  WNDO_CNT = WNDO_CNT + 1;
               }
            } while (true);
            if (INTERACT != REFRESH)
            {
               if (WNDO_TEXT_LIST != "") { L2000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
               /*  Restart display from first line when end of list is reached */
               if (WNDO_TEXT == "")
               {
                  WNDO_CNT = 1;
               }
               CNT = 0;
            }
            else
            {
               INTERACT = FINISH;
            }
         } while (true);
         return;
         /* ********************************************************* */
      }
   }
}
