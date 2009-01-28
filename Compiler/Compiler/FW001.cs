//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FW001 : UvBase
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
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar ALL_CLEAR = "";
      UvVar AUTH_ID = "";
      FLTX1 FLTX1;
      UvVar PROGRAM = "";
      UvVar EXECUTE_PROG = "";
      #endregion
      public FW001(ref UvVar ERROR_STATUS, ref UvVar MESSAGE)
      {
         this.ERROR_STATUS = ERROR_STATUS;
         this.MESSAGE = MESSAGE;
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
         FLTX1 = new FLTX1();
         /*     Set up core, essential common variables to support calls */
         /*     to other LeisureFlex routines */
         /*     Returned:  ERROR.STATUS    0 = OK,    1 -  999 = User Warning */
         /*                                        1000 - 1999 = User Fatal */
         /*                                        2000 - 2999 = Technical Fatal */
         /*                MESSAGE           If status > 0 */
         TODAYS_DATE = DATE();
         PROGRAM = "FW001";
         ERROR_STATUS = 0;
         MESSAGE = "";
         /*  Initialise variables */
         /*  IMPORTANT: This routine always opens 'LOCAL.CONTROL' to FILES(10) */
         /*             This is the control file on the central account from */
         /*             which web bookings runs. Any routines which require access */
         /*             to the control file (or any other file) on the account to */
         /*             which the booking relates will need to open it using a */
         /*             Q-Pointer */
         if (!OPEN("FL.CONTROL", out COMMON.FILES[10])) { ERROR_STATUS = 2054; MESSAGE = PROGRAM + ": Unable to access local control file"; }
         /*  The following lines were selected from FL001 and */
         /*  exclude all colour/terminal control details */
         if (!(READ(ref MACHINE_TYPE, COMMON.FILES[10], "MACHINE.TYPE")))
         {
            MACHINE_TYPE = "UNIVERSE";
         }
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (!READ(ref AUTH_ID, COMMON.FILES[10], "AUTH.ID")) { AUTH_ID = "???"; }
         COMMON.MD2 = "MD2";
         COMMON.D2 = "D2";
         COMMON.MTS = "MTS";
         ALL_CLEAR = 1;
         /*  Return to calling program */
         return;
         /* ****************************** */
         /*  End of program              * */
         /* ****************************** */
      }
   }
}
