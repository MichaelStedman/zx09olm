//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL872 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar FKEY_LEAD_CHAR = "";
      UvVar OPTION1 = "";
      UvVar OPTION2 = "";
      UvVar MACHINE_TYPE = "";
      UvVar CUR_BACK = "";
      UvVar PROGRAM = "";
      UvVar FL_DATA_ENTRY = "";
      UvVar BACKSPACE = "";
      UvVar RET = "";
      UvVar INPUT_COMPLETE = "";
      UvVar OPTION = "";
      UvVar KEY = "";
      CallAt_FL_DATA_ENTRY CallAt_FL_DATA_ENTRY;
      UvVar KEY_CHAR = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL872(ref UvVar FKEY_LEAD_CHAR, ref UvVar OPTION1, ref UvVar OPTION2)
      {
         this.FKEY_LEAD_CHAR = FKEY_LEAD_CHAR;
         this.OPTION1 = OPTION1;
         this.OPTION2 = OPTION2;
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
         /*     GET KEYBOARD INPUTS, SUPPORTING PC ARROW KEYS�1 */
         PROGRAM = "FL872";
         FL_DATA_ENTRY = "FL." + MACHINE_TYPE + ".DATA.ENTRY";
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         BACKSPACE = 8;
         RET = 13;
         INPUT_COMPLETE = FALSE;
         OPTION = "";
         do
         {
            /* *      IN KEY */
            nrf0 = 1;
            nrf1 = "";
            CallAt_FL_DATA_ENTRY = new CallAt_FL_DATA_ENTRY(ref FL_DATA_ENTRY, ref nrf0, ref nrf1, ref KEY);
            KEY_CHAR = CHAR(KEY);
            // BEGIN CASE
            // CASE
            if (KEY_CHAR == FKEY_LEAD_CHAR)
            {
               /* *         IN KEY */
               nrf0 = 1;
               nrf1 = "";
               CallAt_FL_DATA_ENTRY = new CallAt_FL_DATA_ENTRY(ref FL_DATA_ENTRY, ref nrf0, ref nrf1, ref KEY);
               KEY_CHAR = CHAR(KEY);
               OPTION = FKEY_LEAD_CHAR + KEY_CHAR;
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY == BACKSPACE)
            {
               if (OPTION != "")
               {
                  OPTION = OPTION.Substring(1, LEN(OPTION) - 1);
                  PRINT(AT(-9) + " " + AT(-9));
               }
            }// CASE
            else if (KEY == RET)
            {
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY_CHAR == COMMON.UP)
            {
               OPTION = COMMON.UP;
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY_CHAR == COMMON.DOWN)
            {
               OPTION = COMMON.DOWN;
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY_CHAR == COMMON.LEFT)
            {
               OPTION = COMMON.LEFT;
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY_CHAR == COMMON.RIGHT)
            {
               OPTION = COMMON.RIGHT;
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (KEY_CHAR == COMMON.ABANDON)
            {
               OPTION = COMMON.ABANDON;
               INPUT_COMPLETE = TRUE;
               /* *      CASE LEN(OPTION) < 3 */
            }// CASE
            else if (LEN(OPTION) < 5)
            {
               OPTION = OPTION + CHAR(KEY);
            }// CASE
            else if (KEY > 30)
            {
               PRINT(CUR_BACK + " " + CUR_BACK);
            }
            // END CASE
            if (INPUT_COMPLETE) break;
         } while (true);
         OPTION1 = OPTION.Substring(1, 1);
         OPTION2 = OPTION.Substring(2, 4);
         return;
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
