//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL992 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_MD = 58;
      readonly UvVar FL_PASSWORDS = 1;
      readonly UvVar PASS_PASS = 1;
      readonly UvVar PASS_NAME = 2;
      readonly UvVar PASS_STATUS = 3;
      readonly UvVar PASS_PRIVILEGE = 4;
      readonly UvVar PASS_SPECIAL = 5;
      readonly UvVar PASS_DEPT = 6;
      readonly UvVar PASS_DATE = 7;
      readonly UvVar PASS_USER_CHANGED = 8;
      readonly UvVar PASS_DATE_CHANGED = 9;
      readonly UvVar PASS_TIME_CHANGED = 10;
      readonly UvVar PASS_EMAIL_ADDRESS = 11;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] PASS_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar PORT_NUMBER = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar PROG_MESS = "";
      UvVar PROGRAM = "";
      UvVar LOGTO_ACCOUNT = "";
      UvVar FLEX_BYPASS = "";
      UvVar PASS_ID = "";
      UvVar PASSREC = "";
      FL006 FL006;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL992()
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
         /*  Logto Another Account */
         PROGRAM = "FL992";
         LOGTO_ACCOUNT = FIELD(PROG_MESS, "", 1);
         #region INCLUDE FL.FILES FL.MD

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         /* ****************************** */
         /*   Main Process Section       * */
         /* ****************************** */
         if (LOGTO_ACCOUNT != "")
         {
            if (READ(ref FLEX_BYPASS, COMMON.FILES[FL_MD], "FLEX.BYPASS"))
            {
               if (FLEX_BYPASS[1, 1] == "NTMULTISITE")
               {
                  PASS_ID = "PASS*" + PORT_NUMBER;
                  PASSREC = U_INITS;
                  PASSREC[2] = COMMON.PASSWORD;
                  PASSREC[3] = TODAYS_DATE;
                  PASSREC[4] = TIME();
                  WRITE(PASSREC, COMMON.FILES[FL_PASSWORDS], PASS_ID);
               }
            }
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
