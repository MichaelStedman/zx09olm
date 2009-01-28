//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL049 : UvBase
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar ROUTINE = "";
      UvVar MESSAGE = "";
      UvVar REDISPLAY = "";
      UvVar ERR_LINE = "";
      UvVar AM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar FL_HELP = "";
      UvVar HELP_MESSAGE = "";
      UvVar PREFIX = "";
      UvVar FZ019 = "";
      UvVar ROUTINE_ID = "";
      UvVar HELP_PROCESS = "";
      CallAt_HELP_PROCESS CallAt_HELP_PROCESS;
      UvVar HELP_ID = "";
      UvVar LENGTH_OF_INPUT = "";
      UvVar ANS = "";
      CallAt_FZ019 CallAt_FZ019;
      UvVar XX = "";
      UvVar NO_OF_LINES = "";
      UvVar PAGE_SIZE = "";
      UvVar PAGE_NO = "";
      UvVar CONTINUED = "";
      UvVar LINE_NO = "";
      UvVar I = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL049(ref UvVar ROUTINE, ref UvVar MESSAGE, ref UvVar REDISPLAY)
      {
         this.ROUTINE = ROUTINE;
         this.MESSAGE = MESSAGE;
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
         /*     DISPLAY PAGE OF HELP MESSAGE�28.3 */
         PROMPT("");
         PROGRAM = "FL049";
         INTERACT = INIT;
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.HELP
         if (!(OPEN("FL.HELP", out FL_HELP)))
         {

            PRINTCR(COMMON.WASH);
            PRINTCR("FL.HELP IS NOT A FILE NAME");
            STOP();
         }
         HELP_MESSAGE = INIT;

         #endregion
         /* **************************** */
         /*     ASSIGN FILE VARIABLES  * */
         /* **************************** */
         /* *************************************** */
         /*     INCLUDE HELP INCLUDE */
         /* *************************************** */
         #region INCLUDE FZ.LIBRARY FZ049
         /*     INCLUDE  INCLUDE */

         /*     STANDARD INCLUDE CODE STANDARD */
         PREFIX = PROGRAM.Substring(1, 2);
         FZ019 = PREFIX + "019";
         /* ******************************** */
         /*   MAIN PROCESSING SECTION      * */
         /* ******************************** */
         ROUTINE_ID = ROUTINE + "*" + MESSAGE + "*ROUTINE";
         if (READ(ref HELP_PROCESS, FL_HELP, ROUTINE_ID))
         {
            CallAt_HELP_PROCESS = new CallAt_HELP_PROCESS(ref HELP_PROCESS, ref REDISPLAY);
         }
         else
         {
            L0050();
         }
         return;
         /* *************************** */
      }
      void L0050()
      {
         /*   DISPLAY HELP TEXT   * */
         /* *************************** */
         HELP_ID = ROUTINE + "*" + MESSAGE;
         if (!(READ(ref HELP_MESSAGE, FL_HELP, HELP_ID)))
         {
            HELP_MESSAGE = "There is no help information available at this point.";
         }
         PRINT(ERR_LINE + HELP_MESSAGE[1]);
         LENGTH_OF_INPUT = 3;
         CallAt_FZ019 = new CallAt_FZ019(ref FZ019, ref LENGTH_OF_INPUT, ref ANS);
         REDISPLAY = FALSE;
         if (ANS == COMMON.HELP) { L0100(); }
         if (ANS == COMMON.HELP + COMMON.HELP) { PRINT(ERR_LINE + HELP_ID); nrf0 = 3; CallAt_FZ019 = new CallAt_FZ019(ref FZ019, ref nrf0, ref XX); }
         PRINT(ERR_LINE + COMMON.EOL);
         return;
         /* ****************************** */
      }
      void L0100()
      {
         /*   DISPLAY PAGE OF HELP   * */
         /* ****************************** */
         NO_OF_LINES = COUNT(HELP_MESSAGE, AM);
         if (NO_OF_LINES > 1)
         {
            REDISPLAY = TRUE;
            PAGE_SIZE = 21;
            PAGE_NO = 0;
            do
            {
               if (PAGE_NO * PAGE_SIZE > NO_OF_LINES) { PAGE_NO = 0; }
               if ((PAGE_NO + 1) * PAGE_SIZE > NO_OF_LINES)
               {
                  CONTINUED = "";
               }
               else
               {
                  CONTINUED = "Continued ->";
               }
               PRINT(AT(0, 1) + COMMON.EOS);
               LINE_NO = PAGE_NO * (PAGE_SIZE - 1) + 2;
               for (I = 2; I <= PAGE_SIZE; I += 1)
               {
                  PRINT(AT(0, I) + HELP_MESSAGE[LINE_NO]);
                  LINE_NO = LINE_NO + 1;
               }
               PRINT(AT(66, 23) + CONTINUED);
               PRINT(ERR_LINE + "Press <RETURN> for next page or " + COMMON.ABANDON + " to leave this help screen ");
               LENGTH_OF_INPUT = 3;
               CallAt_FZ019 = new CallAt_FZ019(ref FZ019, ref LENGTH_OF_INPUT, ref ANS);
               if (!(ANS == "")) break;
               PAGE_NO = PAGE_NO + 1;
            } while (true);
         }
         return;
         /* ************************** */
         /*     END OF INCLUDE INCLUDE END */
         /* ************************** */

         #endregion
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
