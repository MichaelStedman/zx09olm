//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL732 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_SCREENS = 8;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar SC_POS = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar REFUND_SCREEN = "";
FL730 FL730;
#endregion
public FL732() {
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
/*  COURSE PAYMENT */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
PROGRAM = "FL732";
SCREEN_CODE = PROGRAM;
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
PRINTCR("CAN'T READ SCREEN");
STOP();
}
REFUND_SCREEN = FALSE;
FL730 = new FL730(ref REFUND_SCREEN, ref SCREEN_CODE, ref SC_POS);
return;
}
}
}
