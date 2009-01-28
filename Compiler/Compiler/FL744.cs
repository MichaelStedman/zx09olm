//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL744 : UvBase
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
UvVar TILL_NUMBER = "";
UvVar SC_POS = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_MULTIPAY = "";
UvVar MULTIPAY_REC = "";
UvVar BASKET_COUNT = "";
FL006 FL006;
UvVar SCREEN_CODE = "";
FL745 FL745;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL744() {
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
/*  COURSE FEE ADJUSTMENTS */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
PROGRAM = "FL744";
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
if (BASKET_COUNT > 0) {
nrf0 = 85;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
SCREEN_CODE = PROGRAM;
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
PRINTCR("CAN'T READ SCREEN");
STOP();
}
FL745 = new FL745(ref SCREEN_CODE, ref SC_POS);
return;
}
}
}
