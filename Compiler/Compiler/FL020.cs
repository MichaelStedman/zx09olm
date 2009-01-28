//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL020 : UvBase
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
UvVar LENGTH_OF_INPUT = "";
UvVar MAX_LENGTH = "";
UvVar OUTSTR = "";
UvVar DOTS = "";
UvVar INPUT_COMPLETE = "";
UvVar DONE = "";
UvVar HIDE = "";
UvVar THIS_CHAR = "";
UvVar THIS_MAX_LEN = "";
UvVar A = "";
UvVar B = "";
#endregion
public FL020(ref UvVar LENGTH_OF_INPUT, ref UvVar MAX_LENGTH, ref UvVar OUTSTR, ref UvVar DOTS, ref UvVar INPUT_COMPLETE) {
this.LENGTH_OF_INPUT = LENGTH_OF_INPUT;
this.MAX_LENGTH = MAX_LENGTH;
this.OUTSTR = OUTSTR;
this.DOTS = DOTS;
this.INPUT_COMPLETE = INPUT_COMPLETE;
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
// LENGTH OF INPUT = length of input this time round
INPUT_COMPLETE = FALSE;
// Max length = maximum overvall length, if 0 or blank assume 255
// Improved version of 019 that captures the backspace and processes it
// simply send the existing string, the number of chars reqd this time
// and the maximum required
// Use this program when you need to check for fast keys etc
// Example programs are 380, 011 & Mag Stripe Full line.
//  ans = ""
//  for charno = 1 to promptlen
//   call fl020(1,promptlen,ans,".")
//   if len(ans) < promptlen then user has press return
//   check the contents for a fast key
//  next charno
DONE = FALSE;
if (DOTS.Substring(2, 1) == "*") {
HIDE = TRUE;
} else {
HIDE = FALSE;
}
DOTS = DOTS.Substring(1, 1);
if (MAX_LENGTH == "" || MAX_LENGTH == 0) { MAX_LENGTH = 255; }
THIS_CHAR = LEN(OUTSTR);
THIS_MAX_LEN = THIS_CHAR + LENGTH_OF_INPUT;
do {
do {
INPUTCR(out A, -1);
B = KEYIN();
if (B != "" || A == 49) break;
} while (true);
// BEGIN CASE
// CASE
if (SEQ(B) == 8) {
THIS_CHAR = THIS_CHAR - 1;
if (THIS_CHAR < 0) {
OUTSTR = "";
THIS_CHAR = 0;
} else {
//   PRINT @(X-1,10):" ":
PRINT(CHAR(8) + DOTS + CHAR(8));
OUTSTR = OUTSTR.Substring(1, THIS_CHAR);
THIS_MAX_LEN = THIS_MAX_LEN - 1;
}
}// CASE
else if (SEQ(B) == 10) {
INPUT_COMPLETE = TRUE;
return;
}// CASE
else if (OTHERWISE) {
if (SEQ(B) == SEQ(OCONV(B, "MCP")) || B == COMMON.BELL) {
OUTSTR = OUTSTR + B;
THIS_CHAR = THIS_CHAR + 1;
if (HIDE) {
PRINT("*");
} else {
PRINT(B);
}
}
}
// END CASE
if (THIS_CHAR >= MAX_LENGTH || THIS_CHAR >= THIS_MAX_LEN) break;
} while (true);
if (LEN(OUTSTR) >= MAX_LENGTH) { INPUT_COMPLETE = TRUE; }
return;
}
}
}
