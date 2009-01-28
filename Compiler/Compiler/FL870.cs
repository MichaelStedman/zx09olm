//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL870 : UvBase
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
      UvVar BOX_HEAD = "";
      UvVar OPTIONS = "";
      UvVar DESCRIPTIONS = "";
      UvVar REPLY = "";
      UvVar INTERACT = "";
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar COLOR_C = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar REDISPLAY = "";
      UvVar OPTION_TEXT = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar WINDOW_ID = "";
      UvVar WINDOW = "";
      UvVar TOP_WINDOW = "";
      UvVar BOTTOM_WINDOW = "";
      UvVar LEFT_WINDOW = "";
      UvVar RIGHT_WINDOW = "";
      UvVar WINDOW_JUST = "";
      UvVar WINDOW_DEPTH = "";
      UvVar HEADING_TEXT = "";
      UvVar HEADING_TEXT2 = "";
      UvVar FOOTER = "";
      UvVar WAIT = "";
      UvVar OPTION1 = "";
      UvVar OPTION2 = "";
      UvVar FKEY_LEAD_CHAR = "";
      FL872 FL872;
      UvVar OPTION_NO = "";
      UvVar CNT = "";
      UvVar DISPLAY_LINE = "";
      #endregion
      public FL870(ref UvVar BOX_HEAD, ref UvVar OPTIONS, ref UvVar DESCRIPTIONS, ref UvVar REPLY, ref UvVar INTERACT)
      {
         this.BOX_HEAD = BOX_HEAD;
         this.OPTIONS = OPTIONS;
         this.DESCRIPTIONS = DESCRIPTIONS;
         this.REPLY = REPLY;
         this.INTERACT = INTERACT;
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
         /*     GENERAL PURPOSE HELP FOR USE BY DATA ENTRY SCREENS�1 */
         PROGRAM = "FL870";
         /* ************************ */
         /*     DEFINE FILES USED  * */
         /* ************************ */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         INTERACT = INVALID_DATA;
         REDISPLAY = "";
         COMMON.CLR = "\\";
         OPTION_TEXT = "";
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         WINDOW_ID = PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 9;
            WINDOW[2] = 18;
            WINDOW[3] = 1;
            WINDOW[4] = 77;
         }
         /* *     TOP.WINDOW    = WINDOW<1> */
         BOTTOM_WINDOW = WINDOW[2];
         TOP_WINDOW = BOTTOM_WINDOW - DCOUNT(OPTIONS, VM) - 1;
         LEFT_WINDOW = WINDOW[3];
         RIGHT_WINDOW = WINDOW[4];
         WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
         WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
         HEADING_TEXT = BOX_HEAD;
         HEADING_TEXT2 = WINDOW[6];
         FOOTER = "  Select Option ";
         /*  Box heading */
         PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
         /*  Box Sub-Heading */
         PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
         /*  Display blank box footing */
         PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(INIT, WINDOW_JUST));
         PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
         /*  Function is set to LIMIT if the user hits <Return> to scroll the display */
         L3000();
         /*  Display data portion of window */
         /*  Return to calling program */
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
            /* *      CALL FL019( 5, WAIT ) */
            OPTION1 = "";
            OPTION2 = "";
            FKEY_LEAD_CHAR = "";
            FL872 = new FL872(ref FKEY_LEAD_CHAR, ref OPTION1, ref OPTION2);
            // BEGIN CASE
            // CASE
            if (OPTION1 == COMMON.RIGHT || OPTION1 == COMMON.LEFT || OPTION1 == COMMON.ABANDON)
            {
               WAIT = OPTION1;
            }// CASE
            else if (OTHERWISE)
            {
               WAIT = OPTION1 + OPTION2;
            }
            // END CASE
            // BEGIN CASE
            // CASE
            if (WAIT == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               REPLY = "";
            }// CASE
            else if (OTHERWISE)
            {
               INTERACT = VALID_DATA;
               REPLY = WAIT;
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         REDISPLAY = TOP_WINDOW;
         return;
         /* *************************************************** */
      }
      void L3000()
      {
         /*   Display data section of window              * */
         /* *************************************************** */
         OPTION_NO = 1;
         INTERACT = INVALID_DATA;
         do
         {
            if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT))) break;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               OPTION_TEXT = OPTIONS[1, OPTION_NO];
               if (CNT >= WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + TOP_WINDOW + 2) + NRM_VID);
               if (OPTION_TEXT == "")
               {
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + COLOR_C + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  DISPLAY_LINE = "  " + FORMAT(OPTION_TEXT, "L#10") + "  " + DESCRIPTIONS[1, OPTION_NO];
                  PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
               }
               OPTION_NO = OPTION_NO + 1;
            } while (true);
            L1000();
            /*  Restart display from first field when end of list is reached */
            if (OPTION_TEXT == "")
            {
               OPTION_NO = 1;
            }
            CNT = 0;
         } while (true);
         return;
      }
   }
}
