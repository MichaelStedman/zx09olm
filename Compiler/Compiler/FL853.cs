//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL853 : UvBase
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
      UvVar FL_TOUCHSCREEN_SESSIONS = "";
      #endregion
      public FL853()
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
         /*  RESET MULTIUSER AND TOUCHSCREEN SESSIONS */
         #region INCLUDE FL.FILES FL.TOUCHSCREEN.SESSIONS
         if (!OPEN("FL.TOUCHSCREEN.SESSIONS", out FL_TOUCHSCREEN_SESSIONS)) { STOP("201", "FL.TOUCHSCREEN.SESSIONS"); }

         #endregion
         CLEARFILE(FL_TOUCHSCREEN_SESSIONS);
         PRINT(AT(10, 18) + "* * * PROCESS COMPLETE * * *");
         return;
      }
   }
}
