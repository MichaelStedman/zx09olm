//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL000_10 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar SCREENS = 8;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar TERMINAL_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar ALL_CLEAR = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar REV_UND_VID = "";
      UvVar MENU_HEAD_BACK = "";
      UvVar MENU_HEAD_FORE = "";
      UvVar MENU_NOS = "";
      UvVar MENU_TEXT = "";
      UvVar MENU_BACK = "";
      UvVar SCREEN_HEAD_BACK = "";
      UvVar SCREEN_HEAD_FORE = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar SCREEN_TEXT2 = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SCREEN_FOOT_FORE2 = "";
      UvVar ERR_MESS_BACK = "";
      UvVar ERR_MESS_FORE = "";
      UvVar DBL_WID_ON = "";
      UvVar DBL_WID_OFF = "";
      UvVar DBL_HEIGHT_TOP_ON = "";
      UvVar DBL_HEIGHT_BOT_ON = "";
      UvVar SCREEN_WIDTH = "";
      UvVar VIDEO_STYLE = "";
      UvVar AMD_KEY = "";
      UvVar AMD_REC = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar COLOR_C = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar CLIENT_APP_TYPE = "";
      UvVar TRANS_LOG_REC = "";
      UvVar SCREEN = "";
      UvVar DOTS = "";
      UvVar DIMMED = "";
      UvVar SCREEN_NAME = "";
      UvVar PROGRAM = "";
      UvVar ORIG_SCREEN_FOOT_BACK = "";
      UvVar ORIG_SCREEN_FOOT_FORE = "";
      UvVar ORIG_SCREEN_FOOT_FORE2 = "";
      UvVar MULTIPLIER = "";
      UvVar RESET_BACK = "";
      UvVar VIDEO_SPACE = "";
      UvVar TT_BOX_WIDTH = "";
      UvVar SCREEN_REC = "";
      UvVar SBC = "";
      UvVar FOOTING_PRINTED = "";
      UvVar SCREEN_LINE = "";
      UvVar SC_POS_LINE = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar SCREEN_BACKGROUND = "";
      UvVar HEAD_FORE = "";
      UvVar HEAD_BACK = "";
      UvVar TEXT_TO_DISPLAY = "";
      UvVar COL_NUMBER = "";
      UvVar JUST = "";
      UvVar DOT_LINE = "";
      UvVar START_POS = "";
      UvVar PROMPT_LEN = "";
      UvVar REC_LINE = "";
      UvVar REC_COL = "";
      UvVar REC_ROW = "";
      UvVar ATT_MV = "";
      UvVar ATTR = "";
      UvVar MULT = "";
      UvVar DETAIL = "";
      UvVar DETAIL_JUST = "";
      UvVar AMD_NO = "";
      UvVar AMD_COL = "";
      UvVar AMD_ROW = "";
      UvVar INPUT_NO = "";
      FL006 FL006;
      FLTX2 FLTX2;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL000_10(ref UvVar SCREEN_CODE, ref UvVar DOTS_ONLY)
      {
         this.SCREEN_CODE = SCREEN_CODE;
         this.DOTS_ONLY = DOTS_ONLY;
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
         /*  STANDARD UTILITY (BOOKINGS) */
         /*  PRINTS SCREEN AND RELEVANT DOTS READY FOR INPUT */
         /*  BUT LOOKS TO SEE IF LINE TO BE DIMMED OR REVERSE VIDEOED */
         SCREEN_NAME = FIELD(SCREEN_CODE, "*", 2);
         PROGRAM = SCREEN_NAME;
         /* *Establish Client Software */
         if (SCREEN_CODE != "FL003")
         {
            /* !*        CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
         }
         if (SCREEN_NAME == "FL0001.2.2")
         {
            ORIG_SCREEN_FOOT_BACK = SCREEN_FOOT_BACK;
            SCREEN_FOOT_BACK = ERR_MESS_BACK;
            ORIG_SCREEN_FOOT_FORE = SCREEN_FOOT_FORE;
            SCREEN_FOOT_FORE = ERR_MESS_FORE;
            ORIG_SCREEN_FOOT_FORE2 = SCREEN_FOOT_FORE2;
            SCREEN_FOOT_FORE2 = ERR_MESS_FORE;
         }
         /*    DETERMINE IF DOUBLE WIDTH TO BE USED */
         if (DBL_HEIGHT_TOP_ON != "")
         {
            MULTIPLIER = 2;
         }
         else
         {
            MULTIPLIER = 1;
         }
         RESET_BACK = SCREEN_BACK;
         if (DBL_WID_ON != "" && DBL_WID_ON != " ")
         {
            if (VIDEO_STYLE == "C")
            {
               VIDEO_SPACE = SPACE(1);
            }
            else
            {
               VIDEO_SPACE = "";
               RESET_BACK = "";
            }
         }
         else
         {
            if (VIDEO_STYLE == "C")
            {
               VIDEO_SPACE = SPACE(2);
            }
            else
            {
               VIDEO_SPACE = SPACE(1);
            }
         }
         if (DBL_WID_ON == "")
         {
            TT_BOX_WIDTH = 0;
         }
         else
         {
            TT_BOX_WIDTH = 6;
         }
         /*    FILE USED   * */
         DIMMED = DIM_VID;
         // BEGIN CASE
         // CASE
         if (DOTS_ONLY == 1)
         {
            /*  DISPLAY DOTS */
            if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE)))
            {
               if (SCREEN_CODE == COMMON.CENTRE + "*FL0001.2.4" || SCREEN_CODE == COMMON.CENTRE + "*FL0001.2.1")
               {
                  SCREEN_CODE = "NOT FOUND";
               }
               goto L80;
            }
            if (READ(ref SCREEN_REC, COMMON.FILES[SCREENS], "$" + SCREEN_CODE + "*DOTS*" + TERMINAL_TYPE))
            {
               PRINT(SCREEN_REC[2]);
               goto L100;
            }
            else
            {
               SCREEN = "";
               goto L30;
            }
         }// CASE
         else if (DOTS_ONLY == 2)
         {
            /*  DISPLAY RECORD */
            goto L50;
         }// CASE
         else if (OTHERWISE)
         {
            /*  DISPLAY SCREEN ONLY */
            if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE)))
            {
               /*  The following code inserted by LB 22feb2000 */
               SC_POS = 0 + VM + 0 + VM + "(" + SCREEN_CODE + ")" + VM + VM + VM + VM + "SH";
               SC_POS[2] = 6 + VM + 1 + VM + "Standard Screen for Program " + SCREEN_CODE + VM + VM + VM + VM + "SH";
               SC_POS[3] = 23 + 3 + VM + VM + VM + VM + VM + "SB";
            }
            if (READ(ref SCREEN_REC, COMMON.FILES[SCREENS], "$" + SCREEN_CODE + "*" + TERMINAL_TYPE))
            {
               PRINT(SCREEN_REC[2]);
               SCREEN_LINES = SCREEN_REC[1];
               goto L100;
            }
            else
            {
               SCREEN = "";
               goto L10;
            }
         }
      // END CASE
      L10: ;
         /*  Display Screen * */
         SCREEN = SCREEN + AT(0, 0) + NRM_VID;
         SCREEN = SCREEN + AT(0, 0) + SCREEN_BACK + SCREEN_DATA;
         SCREEN = SCREEN + COMMON.WASH + "scrn" + AT(0, 0) + "  " + AT(0, 0);
         SCREEN_LINES = COUNT(SC_POS, AM) + 1;
         SBC = "";
         FOOTING_PRINTED = "NO";
         for (SCREEN_LINE = 1; SCREEN_LINE <= SCREEN_LINES; SCREEN_LINE += 1)
         {
            SC_POS_LINE = SC_POS[SCREEN_LINE];
            if (CLIENT_APP_TYPE.Substring(1, 1) != "W" && SC_POS_LINE[1, 3] == "WinPanel") { SC_POS_LINE[1, 3] = ""; }
            ST_COL = SC_POS_LINE[1, 1];
            ST_ROW = SC_POS_LINE[1, 2];
            // BEGIN CASE
            // CASE
            if (SC_POS_LINE[1, 7] == "MH" || (SC_POS_LINE[1, 7] == "SH" && SC_POS_LINE[1, 2] < 3))
            {
               if (SC_POS_LINE[1, 7] == "MH")
               {
                  SCREEN_BACKGROUND = MENU_HEAD_BACK + MENU_HEAD_FORE;
                  HEAD_FORE = MENU_HEAD_FORE;
                  HEAD_BACK = MENU_HEAD_BACK;
               }
               else
               {
                  SCREEN_BACKGROUND = SCREEN_HEAD_BACK + SCREEN_HEAD_FORE;
                  HEAD_FORE = SCREEN_HEAD_FORE;
                  HEAD_BACK = SCREEN_HEAD_BACK;
               }
               if (SC_POS_LINE[1, 2] > 0)
               {
                  TEXT_TO_DISPLAY = SC_POS_LINE[1, 3];
                  COL_NUMBER = INT((SCREEN_WIDTH - LEN(TEXT_TO_DISPLAY) * MULTIPLIER) / 2 / COMMON.DIVISOR);
                  SCREEN = SCREEN + AT(0, 1) + DBL_HEIGHT_TOP_ON;
                  SCREEN = SCREEN + AT(COL_NUMBER, 1) + TEXT_TO_DISPLAY;
                  /*  Print Row 2 */
                  if (DBL_HEIGHT_BOT_ON == "")
                  {
                     /*  DO NOTHING */
                  }
                  else
                  {
                     SCREEN = SCREEN + AT(0, 2) + DBL_HEIGHT_BOT_ON;
                     SCREEN = SCREEN + AT(COL_NUMBER, 2) + TEXT_TO_DISPLAY;
                  }
               }
               else
               {
                  /*  Print Row 0 */
                  SCREEN = SCREEN + AT(79, 0) + NRM_VID + AT(79, 1) + NRM_VID + AT(79, 2) + NRM_VID;
                  SCREEN = SCREEN + AT(0, 3) + SCREEN_BACK + SCREEN_DATA;
                  SCREEN = SCREEN + AT(0, 1) + DBL_HEIGHT_TOP_ON;
                  SCREEN = SCREEN + AT(0, 2) + DBL_HEIGHT_BOT_ON;
                  SCREEN = SCREEN + AT(0, 2) + VIDEO_SPACE + HEAD_BACK + AT(0, 2) + RESET_BACK;
                  SCREEN = SCREEN + AT(0, 1) + VIDEO_SPACE + HEAD_BACK + AT(0, 1) + RESET_BACK;
                  SCREEN = SCREEN + AT(0, 0) + HEAD_FORE + HEAD_BACK;
                  SCREEN = SCREEN + AT(0, 1) + HEAD_FORE + HEAD_BACK;
                  SCREEN = SCREEN + AT(0, 2) + HEAD_FORE + HEAD_BACK;
                  SCREEN = SCREEN + AT(2, 0) + SPACE((SCREEN_WIDTH - 2));
                  SCREEN = SCREEN + AT(2 / COMMON.DIVISOR, 1) + SPACE((SCREEN_WIDTH - 2) / COMMON.DIVISOR);
                  SCREEN = SCREEN + AT(2 / COMMON.DIVISOR, 2) + SPACE((SCREEN_WIDTH - 2) / COMMON.DIVISOR);
                  SCREEN = SCREEN + AT(0, 0) + HEAD_BACK + HEAD_FORE;
                  SCREEN = SCREEN + AT(2, ST_ROW) + SC_POS_LINE[1, 3];
               }
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SH" && SC_POS_LINE[1, 2] > 2)
            {
               SCREEN = SCREEN + AT(78, ST_ROW) + NRM_VID;
               /*            SCREEN = SCREEN: @(0,ST.ROW+1): SCREEN.BACK: SCREEN.DATA */
               SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE;
               SCREEN = SCREEN + AT(2, ST_ROW) + SPACE(SCREEN_WIDTH - 2);
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "MN")
            {
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + MENU_BACK;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + MENU_NOS;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "MT")
            {
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + MENU_BACK;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + MENU_TEXT;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SA")
            {
               if (SBC[ST_ROW + 1] == "")
               {
                  JUST = "L#" + SCREEN_WIDTH;
                  SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_BACK + "";
                  /*  JUST */
                  SBC[ST_ROW + 1] = 1;
               }
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + SCREEN_BACK;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + SCREEN_TEXT;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SB")
            {
               if (SBC[ST_ROW + 1] == "")
               {
                  JUST = "L#" + SCREEN_WIDTH;
                  SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_BACK + FORMAT("", JUST);
                  SBC[ST_ROW + 1] = 1;
               }
               else
               {
                  SCREEN = SCREEN + SCREEN_BACK;
               }
               SCREEN = SCREEN + AT(ST_COL + LEN(SC_POS_LINE[1, 3]), ST_ROW) + NRM_VID;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + SCREEN_TEXT2;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SC")
            {
               if (SBC[ST_ROW + 1] == "")
               {
                  JUST = "L#" + SCREEN_WIDTH;
                  SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_BACK + "";
                  /*  JUST */
                  SBC[ST_ROW + 1] = 1;
               }
               else
               {
                  SCREEN = SCREEN + SCREEN_BACK + SCREEN_TEXT;
               }
               SCREEN = SCREEN + AT(ST_COL + LEN(SC_POS_LINE[1, 3]), ST_ROW) + NRM_VID;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + REV_UND_VID;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SD")
            {
               if (SBC[ST_ROW + 1] == "")
               {
                  JUST = "L#" + SCREEN_WIDTH;
                  SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_BACK + "";
                  /*  JUST */
                  SBC[ST_ROW + 1] = 1;
               }
               else
               {
                  SCREEN = SCREEN + SCREEN_BACK;
               }
               SCREEN = SCREEN + AT(ST_COL + LEN(SC_POS_LINE[1, 3]), ST_ROW) + NRM_VID;
               SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + COLOR_C;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SF" && SC_POS_LINE[1, 2] > 18 && SC_POS_LINE[1, 2] < 22)
            {
               if (FOOTING_PRINTED == "NO")
               {
                  FOOTING_PRINTED = "YES";
                  /*   PRINT BOX AT BASE OF SCREEN */
                  SCREEN = SCREEN + AT(79, 19) + NRM_VID + AT(79, 20) + NRM_VID + AT(79, 21) + NRM_VID;
                  SCREEN = SCREEN + AT(0, 22) + SCREEN_BACK + SCREEN_TEXT;
                  SCREEN = SCREEN + AT(0, 20) + DBL_WID_ON;
                  SCREEN = SCREEN + AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK;
                  SCREEN = SCREEN + AT(0, 20) + SCREEN_BACK;
                  SCREEN = SCREEN + AT(0, 20) + VIDEO_SPACE + SCREEN_FOOT_BACK + AT(0, 20) + RESET_BACK;
                  SCREEN = SCREEN + AT(0, 19) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK;
                  SCREEN = SCREEN + AT(0, 20) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK;
                  SCREEN = SCREEN + AT(2, 19) + SPACE(SCREEN_WIDTH - 2);
                  SCREEN = SCREEN + AT(2 / COMMON.DIVISOR, 20) + SPACE((62 - TT_BOX_WIDTH - 2) / COMMON.DIVISOR);
                  SCREEN = SCREEN + AT(76 / COMMON.DIVISOR, 20) + SPACE((4 / COMMON.DIVISOR) - 2);
                  SCREEN = SCREEN + AT(2, 21) + SPACE(SCREEN_WIDTH - 2);
                  SCREEN = SCREEN + AT(79, 19) + NRM_VID + AT(79, 20) + NRM_VID + AT(79, 21) + NRM_VID;
                  /*   PRINT BLANK BOX FOR TICKET TOTAL */
                  SCREEN = SCREEN + AT((62 - TT_BOX_WIDTH) / COMMON.DIVISOR, 20) + SCREEN_BACK + SCREEN_DATA;
                  SCREEN = SCREEN + AT(74 / COMMON.DIVISOR, 20) + SCREEN_FOOT_BACK;
                  SCREEN = SCREEN + AT(SCREEN_WIDTH / COMMON.DIVISOR, 20) + DBL_WID_OFF;
               }
               /*            SCREEN = SCREEN: @(0,19): SCREEN.FOOT.FORE: SCREEN.FOOT.BACK */
               if (SC_POS_LINE[1, 1] == 2)
               {
                  SCREEN = SCREEN + AT(2, ST_ROW) + SC_POS_LINE[1, 3];
               }
               else
               {
                  SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
               }
            }// CASE
            else if (SC_POS_LINE[1, 7] == "SF")
            {
               SCREEN = SCREEN + AT(0, ST_ROW + 1) + SCREEN_BACK + SCREEN_DATA;
               SCREEN = SCREEN + AT(0, ST_ROW) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE;
               SCREEN = SCREEN + AT(ST_COL, ST_ROW) + SC_POS_LINE[1, 3];
            }
         // END CASE
         L20: ;
         }
      L30: ;
         /*  Display Dots * */
         if (FIELD(SCREEN_CODE, ".", 2) != 2)
         {
            SCREEN_LINES = COUNT(SC_POS, AM) + 1;
            /*     DOTS ON MENUS DIFFERENT COLOUR TO THOSE ON SCREENS */
            SCREEN = SCREEN + SCREEN_BACK;
            for (DOT_LINE = 1; DOT_LINE <= SCREEN_LINES; DOT_LINE += 1)
            {
               if (SC_POS[DOT_LINE, 4])
               {
                  START_POS = LEN(SC_POS[DOT_LINE, 3]) + 2;
                  PROMPT_LEN = SC_POS[DOT_LINE, 4];
                  DOTS = STR(".", PROMPT_LEN);
                  ST_COL = SC_POS[DOT_LINE, 1] + START_POS;
                  ST_ROW = SC_POS[DOT_LINE, 2];
                  SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + SCREEN_BACK;
                  SCREEN = SCREEN + AT(ST_COL - 1, ST_ROW) + SCREEN_DATA;
                  SCREEN = SCREEN + AT(ST_COL, ST_ROW) + DOTS + " " + AT(ST_COL, ST_ROW);
               }
            }
         }
         ALL_CLEAR = 1;
         goto L90;
      L50: ;
         /*  Display Record * */
         for (REC_LINE = 1; REC_LINE <= SCREEN_LINES; REC_LINE += 1)
         {
            if (SC_POS[REC_LINE, 4])
            {
               START_POS = LEN(SC_POS[REC_LINE, 3]) + 2;
               REC_COL = SC_POS[REC_LINE, 1] + START_POS;
               REC_ROW = SC_POS[REC_LINE, 2];
               ATT_MV = SC_POS[REC_LINE, 5];
               ATTR = FIELD(ATT_MV, ",", 1);
               MULT = FIELD(ATT_MV, ",", 2);
               if (ATTR == 0) { DETAIL = AMD_KEY; } else { DETAIL = AMD_REC[ATTR, MULT]; }
               if (SC_POS[REC_LINE, 9] != "")
               {
                  DETAIL = OCONV(DETAIL, SC_POS[REC_LINE, 9]);
               }
               DETAIL_JUST = "";
               if (SC_POS[REC_LINE, 8] != "")
               {
                  DETAIL_JUST = SC_POS[REC_LINE, 8] + "#" + SC_POS[REC_LINE, 4];
               }
               AMD_NO = SC_POS[REC_LINE, 6];
               if (AMD_NO == "" && SCREEN_CODE == "FL0001.4.2") { goto L70; }
               if (AMD_NO == "")
               {
                  AMD_COL = SC_POS[REC_LINE, 1];
               }
               else
               {
                  if (AMD_NO < 10) { AMD_NO = COMMON.SP[1] + AMD_NO; }
                  AMD_NO = AMD_NO + ")";
                  AMD_COL = SC_POS[REC_LINE, 1] - 4;
               }
               AMD_ROW = REC_ROW;
               PRINT(AT(0, REC_ROW) + SCREEN_BACK);
               if (SCREEN_CODE != "FL0001.1.2" && SCREEN_CODE != "FL0001.1.3" && SCREEN_CODE != "FL0001.1.7")
               {
                  PRINT(AT(AMD_COL - 1, REC_ROW) + SCREEN_TEXT);
               }
               if (INDEX(AMD_NO, ".", 1) && CLIENT_APP_TYPE.Substring(1, 1) != "W")
               {
                  AMD_NO = "";
               }
               PRINTCR(AT(AMD_COL, AMD_ROW) + AMD_NO);
               PRINT(AT(REC_COL - 1, REC_ROW) + SCREEN_DATA);
               PRINT(AT(REC_COL, REC_ROW) + FORMAT(DETAIL, DETAIL_JUST));
            }
         L70: ;
         }
         ALL_CLEAR = 1;
         goto L90;
      L80: ;
         /*  Error Display * */
         INPUT_NO = 1;
         nrf0 = INIT; FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
         ALL_CLEAR = 0;
         goto L100;
      L90: ;
         /*  THE END */
         if (SCREEN_NAME == "FL0001.2.2")
         {
            SCREEN_FOOT_BACK = ORIG_SCREEN_FOOT_BACK;
            SCREEN_FOOT_FORE = ORIG_SCREEN_FOOT_FORE;
            /*        SCREEN.FOOT.FORE = ORIG.SCREEN.FOOT.FORE */
         }
         // BEGIN CASE
         // CASE
         if (DOTS_ONLY == 0)
         {
            PRINT(SCREEN);
            SCREEN_REC = "";
            SCREEN_REC[1] = SCREEN_LINES;
            SCREEN_REC[2] = SCREEN;
            /* *AB**        WRITE SCREEN.REC ON SCREENS, '$':SCREEN.CODE: '*': TERMINAL.TYPE */
            TRANS_LOG_REC = SCREEN_REC;
            nrf0 = "W"; nrf1 = "FL.SCREENS"; nrf2 = "$"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
         }// CASE
         else if (DOTS_ONLY == 1)
         {
            PRINT(SCREEN);
            SCREEN_REC = "";
            SCREEN_REC[2] = SCREEN;
            /* *AB**        WRITE SCREEN.REC ON SCREENS, '$':SCREEN.CODE:'*DOTS*': TERMINAL.TYPE */
            TRANS_LOG_REC = SCREEN_REC;
            nrf0 = "W"; nrf1 = "FL.SCREENS"; nrf2 = "$"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
         }
      // END CASE
      L100: ;
         /*  THE END */
         if (SCREEN_CODE != "FL198")
         {
            PRINT(AT(0, 0) + SCREEN_HEAD_BACK + SCREEN_HEAD_FORE);
            PRINTCR(AT(67, 0) + OCONV(TODAYS_DATE, "D"));
         }
         if (VIDEO_STYLE == "C")
         {
            PRINT(SCREEN_BACK + SCREEN_TEXT);
         }
         return;
      }
   }
}
