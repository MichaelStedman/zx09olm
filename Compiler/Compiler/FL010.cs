//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL010 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar U_INITS = "";
UvVar ALL_CLEAR = "";
UvVar MENU = "";
UvVar TOP_MENU = "";
UvVar MENU_ID = "";
UvVar FIRST_MENU = "";
UvVar SCREEN_IND = "";
UvVar PROCESS = "";
UvVar PROCESS_TYPE = "";
//FL011 FL011;
#endregion
public FL010() {
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
// CALLS MAIN MENU DRIVER
// Last updated : 11:16 10/01/92
TOP_MENU = "TOP.MENU";
if (!(READV(ref MENU_ID, COMMON.FILES[CONTROL], U_INITS + "*" + TOP_MENU, 1))) {
if (!(READV(ref MENU_ID, COMMON.FILES[CONTROL], TOP_MENU, 1))) {
MENU_ID = "FL0001";
}
}
FIRST_MENU = MENU_ID;
L10:
MENU = FIRST_MENU;
SCREEN_IND = "M";
PROCESS = INIT;
PROCESS_TYPE = INIT;
//FL011 = new FL011(ref MENU, ref SCREEN_IND, ref PROCESS, ref PROCESS_TYPE);
if (ALL_CLEAR == COMMON.BELL) { goto L99; }
if (NOT(ALL_CLEAR)) {
PRINT();
PRINTCR("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
PRINT();
PRINTCR("A serious error has occurred contact the supervisor");
PRINT();
PRINTCR("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
STOP();
}
if (PROCESS == COMMON.SKIP) {
goto L10;
}
L99:
return;
}
}
}
