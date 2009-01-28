//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL113 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] UNAUTH_REC = new UvVar[4];
#endregion
#region Variables
UvVar CALLING_PROG = "";
UvVar FIELD_NO = "";
UvVar MULTIV = "";
UvVar ORIGINAL_DATA = "";
UvVar NEW_DATA = "";
UvVar PORT_NUMBER = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar PROCESS = "";
UvVar AUTH_REC = "";
UvVar AUTH = "";
FLTX2 FLTX2;
FL006 FL006;
UvVar INPUT_DATA = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL113(ref UvVar CALLING_PROG, ref UvVar FIELD_NO, ref UvVar MULTIV, ref UvVar ORIGINAL_DATA, ref UvVar NEW_DATA) {
this.CALLING_PROG = CALLING_PROG;
this.FIELD_NO = FIELD_NO;
this.MULTIV = MULTIV;
this.ORIGINAL_DATA = ORIGINAL_DATA;
this.NEW_DATA = NEW_DATA;
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
/*  CHECKS TO SEE IF USER CAN AMEND THIS FIELD */
/*    FILES USED   * */
#region INCLUDE FL.FILES FL.UNAUTHORISED

#endregion
#region INCLUDE FL.FILES FL.AUTHORISED

/*  each attributes contains an authorised user */

#endregion
PROGRAM = "FL113";
PROCESS = "FLD*" + CALLING_PROG + "*" + FIELD_NO + "*" + MULTIV;
if (!(READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], PROCESS))) {
AUTH_REC = "";
}
if (AUTH_REC != "" && ORIGINAL_DATA != "") {
if (!LOCATE(U_INITS, AUTH_REC, 0, 0, 1, ref AUTH, "AL")) { AUTH = 0; }
/* ** Record Unauthorised Attempt *** */
if (NOT(AUTH)) {
if (!(MATREAD(ref UNAUTH_REC, COMMON.FILES[FL_UNAUTHORISED], PROCESS))) {
MAT(ref UNAUTH_REC, INIT);
}
UNAUTH_REC[UNAUTH_IDENTIFIER][1, -1] = U_INITS;
UNAUTH_REC[UNAUTH_DATE][1, -1] = TODAYS_DATE;
UNAUTH_REC[UNAUTH_TIME][1, -1] = ICONV(TIMEDATE().Substring(1, 8), COMMON.MTS);
UNAUTH_REC[UNAUTH_TILL][1, -1] = PORT_NUMBER;
MATWRITE(UNAUTH_REC, COMMON.FILES[FL_UNAUTHORISED], PROCESS);
if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_UNAUTHORISED], PROCESS)) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.UNAUTHORISED";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PROCESS);
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref PROCESS);
NEW_DATA = ORIGINAL_DATA;
}
INPUT_DATA = "";
}
return;
}
}
}
