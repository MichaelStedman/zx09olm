//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL756 : UvBase
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
FL757 FL757;
#endregion
public FL756() {
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
/*     RE-ENROLMENT PREFERENCES */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
PROGRAM = "FL756";
SCREEN_CODE = PROGRAM;
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
PRINTCR("CAN'T READ SCREEN");
STOP();
}
FL757 = new FL757(ref SCREEN_CODE, ref SC_POS);
return;
}
}
}
