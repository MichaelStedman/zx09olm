//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_BFREQ : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_BLOCK_HEADER = 87;
readonly UvVar BLOCK_SDESC = 1;
readonly UvVar BLOCK_STIME = 2;
readonly UvVar BLOCK_ETIME = 3;
readonly UvVar BLOCK_SPORT = 4;
readonly UvVar BLOCK_FLOORS1 = 5;
readonly UvVar BLOCK_FLOORS2 = 6;
readonly UvVar BLOCK_FLOORS3 = 7;
readonly UvVar BLOCK_DATES1 = 8;
readonly UvVar BLOCK_DATES2 = 9;
readonly UvVar BLOCK_DATES3 = 10;
readonly UvVar BLOCK_PRICE_REF = 11;
readonly UvVar BLOCK_LETTER = 12;
readonly UvVar BLOCK_INSTALL = 13;
readonly UvVar BLOCK_START = 14;
readonly UvVar BLOCK_FREQUENCY = 15;
readonly UvVar BLOCK_NO_INSTALLS = 16;
readonly UvVar BLOCK_NOTES = 17;
readonly UvVar BLOCK_DATE_MADE = 18;
readonly UvVar BLOCK_USER = 19;
readonly UvVar BLOCK_DEALER = 20;
readonly UvVar BLOCK_FLOORS4 = 21;
readonly UvVar BLOCK_FLOORS5 = 22;
readonly UvVar BLOCK_FLOORS6 = 23;
readonly UvVar BLOCK_FLOORS7 = 24;
readonly UvVar BLOCK_DATES4 = 25;
readonly UvVar BLOCK_DATES5 = 26;
readonly UvVar BLOCK_DATES6 = 27;
readonly UvVar BLOCK_DATES7 = 28;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BLOCK_REC = new UvVar[30];
#endregion
#region Variables
UvVar DICTVAR = "";
UvVar KEY = "";
#endregion
public FL_BFREQ(ref UvVar DICTVAR, ref UvVar KEY) {
this.DICTVAR = DICTVAR;
this.KEY = KEY;
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
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
if (!(MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], KEY))) {
MAT(ref BLOCK_REC, "");
}
// BEGIN CASE
// CASE
if (BLOCK_REC[BLOCK_FREQUENCY] == "W") {
DICTVAR = "Weekly";
}// CASE
else if (BLOCK_REC[BLOCK_FREQUENCY] == "M") {
DICTVAR = "Monthly";
}// CASE
else if (BLOCK_REC[BLOCK_FREQUENCY] == "Q") {
DICTVAR = "Quarterly";
}
// END CASE
return;
}
}
}
