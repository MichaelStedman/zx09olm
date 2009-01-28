//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL991 : UvBase
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar PROGRAM = "";
      UvVar LOGTO_ACCOUNT = "";
      FL006 FL006;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL991()
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
         /*     LOGTO TO TEST ACCOUNT */
         PROGRAM = "FL991";
         /* ****************************** */
         /*   Define Files               * */
         /* ****************************** */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /* ****************************** */
         /*   Read Control Parameter     * */
         /* ****************************** */
         if (!(READV(ref LOGTO_ACCOUNT, COMMON.FILES[FL_CONTROL], "LOGTO.ACCOUNT", 1)))
         {
            LOGTO_ACCOUNT = INIT;
         }
         /* ****************************** */
         /*   Main Process Section       * */
         /* ****************************** */
         if (LOGTO_ACCOUNT != "")
         {
            CHAIN("LOGTO " + LOGTO_ACCOUNT);
         }
         else
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         /* ******************** */
         /*   End of Program   * */
         /* ******************** */
      }
   }
}
