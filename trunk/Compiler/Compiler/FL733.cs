//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL733 : UvBase
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
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_FOOT_FORE2 = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar SC_POS = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar REFUND_SCREEN = "";
UvVar ORIG_SCREEN_FOOT_BACK = "";
UvVar ORIG_SCREEN_FOOT_FORE = "";
UvVar ORIG_SCREEN_FOOT_FORE2 = "";
FL730 FL730;
#endregion
public FL733() {
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
/*  COURSE REFUNDS */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
PROGRAM = "FL733";
SCREEN_CODE = PROGRAM;
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
PRINTCR("CAN'T READ SCREEN");
STOP();
}
REFUND_SCREEN = TRUE;
ORIG_SCREEN_FOOT_BACK = SCREEN_FOOT_BACK;
SCREEN_FOOT_BACK = ERR_MESS_BACK;
ORIG_SCREEN_FOOT_FORE = SCREEN_FOOT_FORE;
SCREEN_FOOT_FORE = ERR_MESS_FORE;
ORIG_SCREEN_FOOT_FORE2 = SCREEN_FOOT_FORE2;
SCREEN_FOOT_FORE2 = ERR_MESS_FORE;
FL730 = new FL730(ref REFUND_SCREEN, ref SCREEN_CODE, ref SC_POS);
SCREEN_FOOT_BACK = ORIG_SCREEN_FOOT_BACK;
SCREEN_FOOT_FORE = ORIG_SCREEN_FOOT_FORE;
SCREEN_FOOT_FORE = ORIG_SCREEN_FOOT_FORE;
return;
}
}
}
