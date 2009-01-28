//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL998 : UvBase
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
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar INVALID_USE = "";
UvVar ANS = "";
UvVar NUMBER = "";
UvVar MD = "";
UvVar KEY = "";
UvVar SUBROUTINE_NAME = "";
CallAt_SUBROUTINE_NAME CallAt_SUBROUTINE_NAME;
UvVar VERB = "";
FL006 FL006;
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL998() {
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
/*  ALLOW ACCESS TO TCL FACILITIES FROM MENU */
/* EXEC.FIX 05.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL998";
INVALID_USE = TRUE;
PRINTCR(COMMON.WASH);
do {
PROMPT("}");
PRINT();
INPUTCR(out ANS);
if (ANS == "") break;
if (TRIM(ANS).Substring(1, 4) == "CALL") {
NUMBER = TRIM(ANS).Substring(5, 2);
if (!OPEN("MD", out MD)) { STOP(); }
KEY = "BP" + PORT_NUMBER + NUMBER + "3";
if (!READ(ref SUBROUTINE_NAME, MD, KEY)) { STOP(); }
CallAt_SUBROUTINE_NAME = new CallAt_SUBROUTINE_NAME(ref SUBROUTINE_NAME);
} else {
VERB = FIELD(ANS, " ", 1);
// BEGIN CASE
// CASE
if (VERB == "ED") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "EED") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "EDIT") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "EEDIT") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "DELETE") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "COPY") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (VERB == "ECOPY") {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref VERB);
}// CASE
else if (OTHERWISE) {
INVALID_USE = FALSE;
}
// END CASE
if (NOT(INVALID_USE)) {
/*            EXECUTE ANS */
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref ANS, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
}
}
} while (true);
PROMPT("");
return;
}
}
}
