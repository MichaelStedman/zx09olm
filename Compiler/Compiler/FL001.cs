//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL001 : UvBase
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
#region Arrays
UvVar[] TERMINAL_CONTROL_REC = new UvVar[130];
UvVar[] TERMINAL_OBJECT_REC = new UvVar[130];
UvVar[] PRINTER_OBJECT_REC = new UvVar[130];
UvVar[] TILL_REC = new UvVar[10];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar TERMINAL_TYPE = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar ALL_CLEAR = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar REV_UND_VID = "";
UvVar UND_VID = "";
UvVar DIM_UND_VID = "";
UvVar BLINK_VID = "";
UvVar CUR_BACK = "";
UvVar CUR_DOWN = "";
UvVar CUR_UP = "";
UvVar CUR_RIGHT = "";
UvVar SLAVE_ON = "";
UvVar SLAVE_OFF = "";
UvVar SLAVE_DBL_WID_ON = "";
UvVar SLAVE_DBL_WID_OFF = "";
UvVar SLAVE_RED_ON = "";
UvVar SLAVE_RED_OFF = "";
UvVar SLAVE_DRAWER_OPEN = "";
UvVar FORM_FEED = "";
UvVar LINE_FEED = "";
UvVar MENU_HEAD_BACK = "";
UvVar MENU_HEAD_FORE = "";
UvVar MENU_NOS = "";
UvVar MENU_TEXT = "";
UvVar MENU_BACK = "";
UvVar SCREEN_HEAD_BACK = "";
UvVar SCREEN_HEAD_FORE = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_TEXT2 = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_FOOT_FORE2 = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar DBL_WID_ON = "";
UvVar DBL_WID_OFF = "";
UvVar DBL_HEIGHT_TOP_ON = "";
UvVar DBL_HEIGHT_TOP_OFF = "";
UvVar DBL_HEIGHT_BOT_ON = "";
UvVar DBL_HEIGHT_BOT_OFF = "";
UvVar SCREEN_WIDTH = "";
UvVar VIDEO_STYLE = "";
UvVar AUTH_ID = "";
UvVar GO_BACK = "";
UvVar CLR_ERROR = "";
UvVar TILL_NUMBER = "";
UvVar TICKET_SWITCH = "";
UvVar PROG_MESS = "";
UvVar DISP_OFF = "";
UvVar DISP_LINE = "";
UvVar DISP_BLOCK = "";
UvVar PROGRAM = "";
UvVar TILL_NUMBERS = "";
UvVar FL_CONTROL = "";
UvVar FL_CURSOR = "";
UvVar CONTROL = "";
UvVar WAIT = "";
UvVar PRINTER_TYPE = "";
UvVar BR_KEY_ON_OR_OFF = "";
UvVar EXECUTE_PROG = "";
UvVar FL_CURSOR_ERROR = "";
UvVar TERM_SETTING = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar COLOUR_REC = "";
UvVar A = "";
UvVar HEADING_STYLE = "";
UvVar PREFERENCES = "";
FL_CLIENT_TYPE FL_CLIENT_TYPE;
UvVar TAB_KEY = "";
UvVar CURRENT_SESSION = "";
UvVar TEST_SYSTEM_DATE = "";
UvVar ANS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL001() {
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
// SETS UP THE COMMON VARIABLES
// Last updated : 11:11 10/01/92
//EXEC.FIX 07.08.92 - LBCH
PROGRAM = "FL001";
// Open Files *
//   Machine Constants   *
if (!OPEN("FL.TILL.NUMBERS", out TILL_NUMBERS)) { STOP(201, "TILL.NUMBERS"); }
if (!OPEN("FL.CONTROL", out FL_CONTROL)) { STOP(201, "CONTROL"); }
if (!OPEN("FL.CURSOR", out FL_CURSOR)) { STOP(201, "FL.CURSOR"); }
if (!OPEN("FL.CONTROL", out CONTROL)) { STOP(201, "CONTROL"); }
if (!(MATREAD(ref TILL_REC, TILL_NUMBERS, PORT_NUMBER))) {
//       STOP 202, 'FILE FL.TILL.NUMBERS, ITEM ':PORT.NUMBER
if (!(MATREAD(ref TILL_REC, TILL_NUMBERS, 1))) {
TILL_REC[2] = "ZZ";
TILL_REC[4] = "S";
TILL_REC[3] = "NONE";
}
TILL_REC[1] = PORT_NUMBER;
MATWRITE(TILL_REC, TILL_NUMBERS, PORT_NUMBER);
PRINT(AT(-1));
PRINTCR(AT(10, 10) + "  This is the First Time that you have logged on");
PRINTCR(AT(10, 11) + " to this Till, default settings have been assumed");
PRINTCR(AT(10, 13) + "PLEASE CHECK YOUR CENTRE CODE AND PRINTER SETTINGS");
PRINTCR(AT(10, 14) + "       (Using Till Number Allocation)");
PRINT(AT(10, 17) + "        PRESS <RETURN> TO CONTINUE");
INPUT(out WAIT, 2);
}
TILL_NUMBER = TILL_REC[1];
COMMON.CENTRE = TILL_REC[2];
TERMINAL_TYPE = TILL_REC[4];
PRINTER_TYPE = TILL_REC[3];
// Do things with the break key
BR_KEY_ON_OR_OFF = TILL_REC[5];
if (BR_KEY_ON_OR_OFF == "ON") {
BREAK(1);
} else {
BREAK(0);
}
if (!(READ(ref MACHINE_TYPE, FL_CONTROL, "MACHINE.TYPE"))) {
MACHINE_TYPE = "M9000";
}
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
FL_CURSOR_ERROR = 0;
if (!MATREAD(ref TERMINAL_OBJECT_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*OBJECT")) { FL_CURSOR_ERROR = 1; }
if (!MATREAD(ref TERMINAL_CONTROL_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*CONTROL")) { FL_CURSOR_ERROR = 1; }
if (!MATREAD(ref PRINTER_OBJECT_REC, FL_CURSOR, PRINTER_TYPE + "*OBJECT")) { MAT(ref PRINTER_OBJECT_REC, ""); }
if (FL_CURSOR_ERROR == 1) {
PRINTCR(AT(-1) + "MACHINE TYPE = [" + MACHINE_TYPE + "]");
PRINTCR("TERMINAL TYPE = [" + TERMINAL_TYPE + "]");
PRINT("Item on FL.CURSOR does not exist, Reading in FLEX Default");
if (!(MATREAD(ref TERMINAL_OBJECT_REC, FL_CURSOR, "FLEX*OBJECT"))) {
ALL_CLEAR = FALSE;
return;
}
if (!(MATREAD(ref TERMINAL_CONTROL_REC, FL_CURSOR, "FLEX*CONTROL"))) {
ALL_CLEAR = FALSE;
return;
}
} else {
TERM_SETTING = TERMINAL_CONTROL_REC[1];
if (MACHINE_TYPE != "M9000") {
//         EXECUTE "TERM ": TERM.SETTING
INSTRUCTION = "TERM " + TERM_SETTING;
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
}
}
if (!READ(ref AUTH_ID, CONTROL, "AUTH.ID")) { STOP(202, "CONTROL"); }
if (!(READ(ref COLOUR_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*COLOUR"))) {
if (!(READ(ref COLOUR_REC, CONTROL, "TERMINAL.DEFAULT*" + TERMINAL_TYPE))) {
PRINT("Unable to read colours from CONTROL file. See Programmers. ");
INPUT(out A, 2);
ALL_CLEAR = FALSE;
return;
}
}
//  ASSIGN SYSTEM COLOURS USING CONTROL INFO.
if (COLOUR_REC[1, 2] != "") {
MENU_HEAD_BACK = TERMINAL_OBJECT_REC[COLOUR_REC[1, 2]];
} else {
MENU_HEAD_BACK = "";
}
if (COLOUR_REC[2, 2] != "") {
MENU_HEAD_FORE = TERMINAL_OBJECT_REC[COLOUR_REC[2, 2]];
} else {
MENU_HEAD_FORE = "";
}
if (COLOUR_REC[3, 2] != "") {
MENU_NOS = TERMINAL_OBJECT_REC[COLOUR_REC[3, 2]];
} else {
MENU_NOS = "";
}
if (COLOUR_REC[4, 2] != "") {
MENU_TEXT = TERMINAL_OBJECT_REC[COLOUR_REC[4, 2]];
} else {
MENU_TEXT = "";
}
MENU_BACK = TERMINAL_OBJECT_REC[33];
if (COLOUR_REC[5, 2] != "") {
SCREEN_HEAD_BACK = TERMINAL_OBJECT_REC[COLOUR_REC[5, 2]];
} else {
SCREEN_HEAD_BACK = "";
}
if (COLOUR_REC[6, 2] != "") {
SCREEN_HEAD_FORE = TERMINAL_OBJECT_REC[COLOUR_REC[6, 2]];
} else {
SCREEN_HEAD_FORE = "";
}
if (COLOUR_REC[7, 2] != "") {
SCREEN_BACK = TERMINAL_OBJECT_REC[COLOUR_REC[7, 2]];
} else {
SCREEN_BACK = "";
}
if (COLOUR_REC[8, 2] != "") {
SCREEN_TEXT = TERMINAL_OBJECT_REC[COLOUR_REC[8, 2]];
} else {
SCREEN_TEXT = "";
}
if (COLOUR_REC[9, 2] != "") {
SCREEN_TEXT2 = TERMINAL_OBJECT_REC[COLOUR_REC[9, 2]];
} else {
SCREEN_TEXT2 = "";
}
if (COLOUR_REC[10, 2] != "") {
SCREEN_DATA = TERMINAL_OBJECT_REC[COLOUR_REC[10, 2]];
} else {
SCREEN_DATA = "";
}
if (COLOUR_REC[11, 2] != "") {
SCREEN_FOOT_BACK = TERMINAL_OBJECT_REC[COLOUR_REC[11, 2]];
} else {
SCREEN_FOOT_BACK = "";
}
if (COLOUR_REC[12, 2] != "") {
SCREEN_FOOT_FORE = TERMINAL_OBJECT_REC[COLOUR_REC[12, 2]];
} else {
SCREEN_FOOT_FORE = "";
}
if (COLOUR_REC[13, 2] != "") {
SCREEN_FOOT_FORE2 = TERMINAL_OBJECT_REC[COLOUR_REC[13, 2]];
} else {
SCREEN_FOOT_FORE2 = "";
}
if (COLOUR_REC[14, 2] != "") {
ERR_MESS_BACK = TERMINAL_OBJECT_REC[COLOUR_REC[14, 2]];
} else {
ERR_MESS_BACK = "";
}
if (COLOUR_REC[15, 2] != "") {
ERR_MESS_FORE = TERMINAL_OBJECT_REC[COLOUR_REC[15, 2]];
} else {
ERR_MESS_FORE = "";
}
COMMON.BELL = CHAR(7);
NRM_VID = TERMINAL_OBJECT_REC[80];
REV_VID = TERMINAL_OBJECT_REC[81];
DIM_VID = TERMINAL_OBJECT_REC[82];
DIM_REV_VID = TERMINAL_OBJECT_REC[83];
UND_VID = TERMINAL_OBJECT_REC[84];
REV_UND_VID = TERMINAL_OBJECT_REC[85];
DIM_UND_VID = TERMINAL_OBJECT_REC[86];
DIM_REV_UND_VID = TERMINAL_OBJECT_REC[87];
BLINK_VID = TERMINAL_OBJECT_REC[88];
COMMON.WASH = TERMINAL_OBJECT_REC[01];
COMMON.EOS = TERMINAL_OBJECT_REC[03];
COMMON.EOL = TERMINAL_OBJECT_REC[04];
CUR_BACK = TERMINAL_OBJECT_REC[09];
CUR_UP = TERMINAL_OBJECT_REC[10];
CUR_RIGHT = TERMINAL_OBJECT_REC[15];
CUR_DOWN = TERMINAL_OBJECT_REC[16];
SLAVE_ON = TERMINAL_OBJECT_REC[17];
SLAVE_OFF = TERMINAL_OBJECT_REC[18];
DBL_WID_ON = TERMINAL_OBJECT_REC[70];
DBL_WID_OFF = TERMINAL_OBJECT_REC[71];
DBL_HEIGHT_TOP_ON = TERMINAL_OBJECT_REC[72];
DBL_HEIGHT_TOP_OFF = TERMINAL_OBJECT_REC[73];
DBL_HEIGHT_BOT_ON = TERMINAL_OBJECT_REC[74];
DBL_HEIGHT_BOT_OFF = TERMINAL_OBJECT_REC[75];
VIDEO_STYLE = TERMINAL_CONTROL_REC[02];
HEADING_STYLE = TERMINAL_CONTROL_REC[03];
SCREEN_WIDTH = TERMINAL_CONTROL_REC[04];
COMMON.DIVISOR = TERMINAL_CONTROL_REC[05];
COMMON.LEFT = TERMINAL_CONTROL_REC[06];
COMMON.UP = TERMINAL_CONTROL_REC[07];
COMMON.RIGHT = TERMINAL_CONTROL_REC[08];
COMMON.DOWN = TERMINAL_CONTROL_REC[09];
SLAVE_DBL_WID_ON = PRINTER_OBJECT_REC[19];
SLAVE_DBL_WID_OFF = PRINTER_OBJECT_REC[20];
SLAVE_RED_ON = PRINTER_OBJECT_REC[21];
SLAVE_RED_OFF = PRINTER_OBJECT_REC[22];
SLAVE_DRAWER_OPEN = PRINTER_OBJECT_REC[23];
FORM_FEED = PRINTER_OBJECT_REC[24];
LINE_FEED = PRINTER_OBJECT_REC[25];
//   Standard Constants           *
COMMON.MD2 = "MD2";
COMMON.D2 = "D2";
COMMON.MTS = "MTS";
ERR_LINE = AT(1, 23);
CLR_ERR = AT(1, 23) + COMMON.EOL;
CLR_ERROR = CLR_ERR;
ALL_CLEAR = 1;
//    Application Dependant Constants  *
//    Set User Preferences
if (!OPEN("FL.CONTROL", out FL_CONTROL)) { NULL(); }
if (!(READV(ref AUTH_ID, FL_CONTROL, "AUTH.ID", 1))) {
PRINTCR("NO AUTHORITY ID SETUP");
STOP();
}
if (!(READ(ref PREFERENCES, FL_CONTROL, AUTH_ID + "*P"))) {
PREFERENCES = "";
PREFERENCES[1] = "^";
PREFERENCES[2] = "@";
PREFERENCES[3] = "?";
PREFERENCES[4] = "\\";
PREFERENCES[5] = ".";
PREFERENCES[6] = "N";
}
COMMON.BACK = PREFERENCES[1];
COMMON.ABANDON = PREFERENCES[2];
COMMON.QUERY = PREFERENCES[3];
COMMON.HELP = PREFERENCES[3];
COMMON.CLR = PREFERENCES[4];
COMMON.SKIP = PREFERENCES[5];
// Set cursor Keys, Esc, Tab, Pageup, Pagedown for FwTerm on NT
FL_CLIENT_TYPE = new FL_CLIENT_TYPE();
TAB_KEY = "";
if (MACHINE_TYPE == "UNIVERSE") {
PRINTCR(CHAR(28) + "30," + COMMON.UP + "," + COMMON.DOWN + "," + COMMON.LEFT + "," + COMMON.RIGHT + CHAR(20));
PRINTCR(CHAR(28) + "32," + COMMON.ABANDON + "," + TAB_KEY + CHAR(20));
}
if (PREFERENCES[6] == "N") {
PROMPT(INIT);
} else {
PROMPT(COMMON.BELL);
}
PROMPT(INIT);
TICKET_SWITCH = "!";
CURRENT_SESSION = "";
GO_BACK = "^";
for(COMMON.X = 1; COMMON.X <= 30; COMMON.X += 1) {
COMMON.SP[COMMON.X] = SPACE(COMMON.X);
}
PROG_MESS = INIT;
DISP_LINE = "";
// CHAR(27):"`3"
DISP_BLOCK = CHAR(27) + "`5";
DISP_OFF = CHAR(27) + "`0";
//   If you wish to change the system date set up an item on the file *
//   TEST.SYSTEM.DATE with an item id of DATE.  Store the required    *
//   system date in attribute 1 in INTERNAL format.                   *
if (!(OPEN("FL.TEST.SYSTEM.DATE", out TEST_SYSTEM_DATE))) {
TODAYS_DATE = DATE();
goto L9999;
}
if (!(READV(ref TODAYS_DATE, TEST_SYSTEM_DATE, "DATE", 1))) {
TODAYS_DATE = DATE();
goto L9999;
}
PRINTCR(COMMON.WASH);
PRINT(AT(10, 10) + "THE RUN DATE WILL BE " + OCONV(TODAYS_DATE, COMMON.D2));
PRINT(" FOR THIS SESSION");
PRINTCR(AT(10, 12) + "PRESS <RETURN> IF THIS IS OK");
PRINT(AT(10, 14) + "OTHERWISE TYPE ANY KEY TO SET DATE TO ");
PRINT(OCONV(DATE(), COMMON.D2) + " ");
INPUT(out ANS, 2);
if (LEN(ANS) > 1) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 1); }
if (ANS != "") { TODAYS_DATE = DATE(); }
L9999:
return;
}
}
}