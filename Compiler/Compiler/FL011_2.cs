//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL011_2 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_UNAUTHORISED = 40;
      readonly UvVar UNAUTH_IDENTIFIER = 1;
      readonly UvVar UNAUTH_DATE = 2;
      readonly UvVar UNAUTH_TIME = 3;
      readonly UvVar UNAUTH_TILL = 4;
      readonly UvVar FL_AUTHORISED = 113;
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
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] UNAUTH_REC = new UvVar[4];
      UvVar[] PASS_REC = new UvVar[15];
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar MENU_POS = "";
      UvVar DISP_ALL = "";
      UvVar U_INITS = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar AUTO_HIDE_COLOUR = "";
      UvVar LHBRAK = "";
      UvVar RHBRAK = "";
      UvVar HIDE_OPTS = "";
      UvVar AUTH_LEVEL = "";
      UvVar ORIG_MENU = "";
      UvVar MENU_LINES = "";
      UvVar THIS_LINE = "";
      UvVar PROCESS = "";
      UvVar TYPE = "";
      UvVar AUTHORISED = "";
      UvVar AUTH_PROCESS = "";
      UvVar AUTH_REC = "";
      UvVar AUTH = "";
      #endregion
      public FL011_2(ref UvVar MENU_POS, ref UvVar DISP_ALL)
      {
         this.MENU_POS = MENU_POS;
         this.DISP_ALL = DISP_ALL;
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion
         #region INCLUDE FL.COMMON FL.COMMON

         // FILES
         //    Standard
         //    Screen Control
         //    Slave Printer Control
         //    Special Video
         //    User input control
         //    Application Specific
         //COMMON SC.POS
         //    Theatre
         //    Standard EQUates
         //    Client app control
         //\
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion

         #endregion
         // HIDE ALL UNAUTHORISED MENU OPTIONS
         PROGRAM = "FL011.2";
         //   FILES USED   *
         #region INCLUDE FL.FILES FL.UNAUTHORISED

         #endregion
         #region INCLUDE FL.FILES FL.AUTHORISED

         // each attributes contains an authorised user

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         if (!(READV(ref AUTO_HIDE_COLOUR, COMMON.FILES[FL_CONTROL], "AUTO.HIDE.COLOUR", 1)))
         {
            AUTO_HIDE_COLOUR = "I";
         }
         LHBRAK = CHAR(3) + AUTO_HIDE_COLOUR;
         RHBRAK = CHAR(3) + CHAR(65);
         // Check auto hide is valid
         // Get Authorisation Level
         HIDE_OPTS = TRUE;
         if (READV(ref AUTH_LEVEL, COMMON.FILES[FL_PASSWORDS], U_INITS, 4))
         {
            if (AUTH_LEVEL == "M" || DISP_ALL)
            {
               HIDE_OPTS = FALSE;
            }
         }
         ORIG_MENU = MENU_POS;
         MENU_POS = ORIG_MENU[1];
         MENU_LINES = DCOUNT(ORIG_MENU, AM);
         for (THIS_LINE = 2; THIS_LINE <= MENU_LINES; THIS_LINE += 1)
         {
            PROCESS = ORIG_MENU[THIS_LINE, 3];
            TYPE = ORIG_MENU[THIS_LINE, 2];
            L0100();
            if (AUTHORISED)
            {
               MENU_POS[-1] = ORIG_MENU[THIS_LINE];
            }
            else
            {
               if (NOT(HIDE_OPTS))
               {
                  MENU_POS[-1] = LHBRAK + ORIG_MENU[THIS_LINE, 1] + RHBRAK + VM + ORIG_MENU[THIS_LINE, 2] + VM + ORIG_MENU[THIS_LINE, 3];
               }
            }
         }
         if (MENU_POS[2] == "")
         {
            MENU_POS[2] = "Sorry No Access To Menu";
         }
         return;
      }
      void L0100()
      {
         if (PROCESS == "FL999" || PROCESS == "FT099")
         {
            AUTHORISED = TRUE;
            return;
         }
         // CHECKS TO SEE IF USER IS ALLOWED ACCESS TO THIS PROCESS
         AUTH_PROCESS = TYPE + "*" + PROCESS;
         if (!(READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], AUTH_PROCESS)))
         {
            AUTH_REC = "";
         }
         if (!LOCATE(U_INITS, AUTH_REC, 0, 0, 1, ref AUTH, "AL")) { AUTH = 0; }
         if (AUTH > 0) { AUTHORISED = TRUE; } else { AUTHORISED = FALSE; }
         return;
      }
   }
}
