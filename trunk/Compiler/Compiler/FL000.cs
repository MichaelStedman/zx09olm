//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL000 : UvBase
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
      readonly UvVar FL_TILL_NUMBERS = 14;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar PORT_NUMBER = "";
      UvVar U_INITS = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar ALL_CLEAR = "";
      UvVar AUTH_ID = "";
      UvVar TILL_NUMBER = "";
      UvVar PROGRAM = "";
      FLTX1 FLTX1;
      FL001 FL001;
      FL004 FL004;
      FL002 FL002;
      FL005 FL005;
      FL0002_910 FL0002_910;
      UvVar TILL_MULTIUSER_TOUCHSCREEN = "";
      UvVar TC_TABLE_USERS = "";
      UvVar TC_STAFF_SWIPES = "";
      FL003 FL003;
      FL0002_900 FL0002_900;
      FL099 FL099;
      UvVar MENU_TYPE = "";
      FL0111 FL0111;
      FL010 FL010;
      UvVar TCL = "";
      UvVar TCL_PASS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
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
      // THE CONTROL PROGRAM
      public FL000()
      {
         PROGRAM = "FL000";
         // Establish Transaction Logging
         FLTX1 = new FLTX1();
         // Get the port Number *        Required for FL001
         FL004 = new FL004();
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         // Set up the Constants *
         FL001 = new FL001();
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         // Open All Files *
         FL002 = new FL002();
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         // Check the Machine is Authorised *
         FL005 = new FL005();
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         //!*
         //!* Get the Till Number *
         //!*
         //!!!!!!!!!   SET BY FL001
         //!     CALL FL000.4
         //!     IF ALL.CLEAR THEN NULL ELSE GO 20
         // Define File used in this program *
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

         #endregion
         // Get the Authority's Id *
         if (!READV(ref AUTH_ID, COMMON.FILES[FL_CONTROL], "AUTH.ID", 1)) { goto L20; }
         //     AUTHORITY.ID = AUTH.ID
         // Determine Terminal Type *
         //    READ TILL.REC FROM FILES(14), TILL.NUMBER ELSE
         //      PRINT "TILL INFORMATION NOT READ FROM 'TILL.NUMBERS"
         //      ALL.CLEAR = FALSE
         //      INPUT A,2:;IF LEN(A) > 1 THEN PRINT @(-9):' ':;A=A[1,1]
         //      GO 10
         //    END
         //    TERMINAL.TYPE = TILL.REC<4>
         //    INSTRUCTION = "TERM ":TERMINAL.TYPE
         //*    EXECUTE INSTRUCTION
         //     BEGIN CASE
         //       CASE TERMINAL.TYPE = "J"
         //       DBL.WID.OFF = SPACE(29)
         //       SCREEN.WIDTH = 80
         //       CASE TERMINAL.TYPE = "U"
         //       DBL.WID.OFF = @(-24)
         //       SCREEN.WIDTH = 78
         //       CASE TERMINAL.TYPE = "C"
         //        TERMINAL.TYPE = "U"
         //       DBL.WID.OFF = @(-24)
         //       SCREEN.WIDTH = 78
         //    CASE TERMINAL.TYPE = "I"
         //       DBL.WID.OFF = SPACE(29)
         //      SCREEN.WIDTH = 78
         //      TERMINAL.TYPE = "U"
         //     END CASE
         // Input and check password *
         U_INITS = "";
         nrf0 = FALSE;
         FL0002_910 = new FL0002_910(ref nrf0);
      L10:
         // DJA 27.8.02
         if (!READV(ref TILL_MULTIUSER_TOUCHSCREEN, COMMON.FILES[FL_TILL_NUMBERS], TILL_NUMBER, 15)) { TILL_MULTIUSER_TOUCHSCREEN = ""; }
         if (!READV(ref TC_TABLE_USERS, COMMON.FILES[FL_CONTROL], "TOUCH.CONTROL", 9)) { TC_TABLE_USERS = ""; }
         TC_TABLE_USERS = TC_TABLE_USERS[1, 1];
         if (!READV(ref TC_STAFF_SWIPES, COMMON.FILES[FL_CONTROL], "TOUCH.CONTROL", 10)) { TC_STAFF_SWIPES = ""; }
         TC_STAFF_SWIPES = TC_STAFF_SWIPES[1, 1];
         // BEGIN CASE
         //!*  CASE TC.STAFF.SWIPES = "Y"
         //!*     CALL FL003
         // CASE
         if (TILL_MULTIUSER_TOUCHSCREEN == "M" || (TILL_MULTIUSER_TOUCHSCREEN == "T" && TC_TABLE_USERS != "N"))
         {
            U_INITS = "MULTIUSER";
         }// CASE
         else if (OTHERWISE)
         {
            FL003 = new FL003();
         }
         // END CASE
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         // Call any Specials *
         FL0002_900 = new FL0002_900();
         //PRINT @(10,10):DIM.VID:'DDDDDDDDDDDD':NRM.VID:;INPUT WAIT,1:
         // Assign the correct printer
         FL099 = new FL099();
         // Check all System parameters *
         if (ALL_CLEAR) { NULL(); } else { goto L20; }
         // Main Menu *
         if (!(READV(ref MENU_TYPE, COMMON.FILES[FL_CONTROL], "ALL*MENU.TYPE", 1)))
         {
            if (!(READV(ref MENU_TYPE, COMMON.FILES[FL_CONTROL], U_INITS + "*MENU.TYPE", 1)))
            {
               if (!(READV(ref MENU_TYPE, COMMON.FILES[FL_CONTROL], PORT_NUMBER + "*MENU.TYPE", 1)))
               {
                  MENU_TYPE = "";
               }
            }
         }
         if (MENU_TYPE == "WIN")
         {
            FL0111 = new FL0111();
         }
         else
         {
            FL010 = new FL010();
            // MENU DRIVER
         }
         if (ALL_CLEAR == COMMON.BELL)
         {
            PRINT(ERR_LINE + "TCL PASSWORD PLEASE ");
            ECHO_OFF();
            INPUT(out TCL, 16);
            if (LEN(TCL) > 15) { PRINT(AT(-9) + " "); TCL = TCL.Substring(1, 15); }
            ECHO_ON();
            PRINT(CLR_ERR);
            if (!READV(ref TCL_PASS, COMMON.FILES[FL_CONTROL], "TCL.PASSWORD", 1)) { goto L20; }
            if (TCL != TCL_PASS) { goto L10; } else { CHAIN("HELLO"); }
         }
      L20:
         // A Fatal error has occurred *
         CHAIN("OFF");
         STOP();
      }
   }
}
