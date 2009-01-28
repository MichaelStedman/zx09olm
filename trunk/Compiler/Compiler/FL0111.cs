//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL0111 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MONITOR = 54;
readonly UvVar MON_MENU = 1;
readonly UvVar MON_DESC = 2;
readonly UvVar MON_PROG = 3;
readonly UvVar MON_OPT = 4;
readonly UvVar FL_MENUS = 51;
readonly UvVar MENU_DESC = 1;
readonly UvVar FL_MENU_SELECTIONS = 50;
readonly UvVar MENU_SELECT_OPTION = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] MON_REC = new UvVar[4];
UvVar[] MENUS_REC = new UvVar[50];
UvVar[] MENU_SELECT_REC = new UvVar[1];
UvVar[] MENU_SELECTIONS = new UvVar[20];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar TERMINAL_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar ALL_CLEAR = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar REV_UND_VID = "";
UvVar AM = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar TX_ATT = "";
UvVar PROGRAM = "";
UvVar MAX_DEPTH = "";
UvVar DISTANCE = "";
UvVar MENU_NO = "";
UvVar COL_DISP = "";
UvVar ROW_DISP = "";
UvVar SEL = "";
UvVar IDENT = "";
UvVar QUICK_CALLS = "";
UvVar OPTION_TEXT = "";
UvVar OPTION_TEXT_LEN = "";
UvVar FUNCT_PREFIX = "";
UvVar FUNCTION_LINE1 = "";
UvVar FUNCTION_LINE2 = "";
UvVar SELECTION_CHOSEN = "";
UvVar DISPLAY_WIDTH = "";
UvVar DISPLAY_MASK = "";
UvVar TOP_COLOUR = "";
UvVar MENU_BAR_COLOUR = "";
UvVar OPTION_COLOUR = "";
UvVar HIGHLIGHT_COLOUR = "";
UvVar MENU_NORM_COLOUR = "";
UvVar FUNCT_COLOUR = "";
//FL0001_110 FL0001_110;
UvVar FUNCTION_KEY_CONVERT = "";
UvVar TOP_MENU = "";
UvVar MENU_NAME = "";
UvVar MENU_KEY = "";
UvVar PROCESS_TYPE = "";
UvVar LINE = "";
UvVar MENU_REC = "";
UvVar OPTION_LINE = "";
FL006 FL006;
UvVar SEL_NO = "";
UvVar PROCESS_NAME = "";
//CallAt_PROCESS_NAME CallAt_PROCESS_NAME;
//FL100_ALL FL100_ALL;
UvVar REDISP_NO = "";
UvVar PREVIOUS_SELECTION = "";
UvVar MAX_POSSIBLE = "";
UvVar MENU_LINES = "";
UvVar LAST_LINE = "";
UvVar MENU_REC2 = "";
UvVar MENU_LINE = "";
UvVar SECOND_HALF = "";
FLTX2 FLTX2;
UvVar SEL_KEY = "";
UvVar SELECTION = "";
UvVar MAX = "";
UvVar FRONT = "";
UvVar TAIL = "";
UvVar THIS_COLOUR = "";
UvVar SEL2 = "";
UvVar FNUM = "";
FL024 FL024;
UvVar AUTH = "";
UvVar FUNC_KEY = "";
UvVar CLEAR_LINE = "";
UvVar CLEAR_DISP = "";
UvVar BEFORE_FUNCTION = "";
UvVar XLINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL0111() {
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
// MENU DRIVER (WINDOWS)
PROGRAM = "FL0111";
MAX_DEPTH = 18;
DISTANCE = 3;
MENU_NO = 0;
MENU_NO = MENU_NO + 1;
MAT(ref MENU_SELECTIONS, "");
COL_DISP = (MENU_NO * DISTANCE) - DISTANCE;
ROW_DISP = MENU_NO;
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MONITOR

#endregion
#region INCLUDE FL.FILES FL.MENUS

#endregion
#region INCLUDE FL.FILES FL.MENU.SELECTIONS

#endregion
if (!(MATREAD(ref CENTRES_REC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE))) {
MAT(ref CENTRES_REC, INIT);
}
SEL = "!";
// Quick Calls
if (TERMINAL_TYPE != "I" && TERMINAL_TYPE != "M" && TERMINAL_TYPE != "S") {
IDENT = "QUICK.CALLS";
} else {
IDENT = "QUICK.CALLS*I";
}
if (!(READ(ref QUICK_CALLS, COMMON.FILES[FL_CONTROL], IDENT))) {
QUICK_CALLS = "";
}
OPTION_TEXT = " Choose option ";
OPTION_TEXT_LEN = LEN(OPTION_TEXT);
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
FUNCT_PREFIX = "_";
} else {
FUNCT_PREFIX = "f";
}
FUNCTION_LINE1 = 21;
FUNCTION_LINE2 = FUNCTION_LINE1 + 1;
SELECTION_CHOSEN = "";
DISPLAY_WIDTH = 33;
DISPLAY_MASK = "L#" + DISPLAY_WIDTH;
// colours to use
TOP_COLOUR = DIM_REV_VID;
MENU_BAR_COLOUR = REV_UND_VID;
OPTION_COLOUR = DIM_VID;
HIGHLIGHT_COLOUR = REV_VID;
MENU_NORM_COLOUR = DIM_REV_UND_VID;
FUNCT_COLOUR = TOP_COLOUR;
nrf0 = "FL011";
//FL0001_110 = new FL0001_110(ref nrf0, ref FUNCTION_KEY_CONVERT);
if (!(READ(ref TOP_MENU, COMMON.FILES[FL_CONTROL], "TOP.MENU"))) {
TOP_MENU = "FL0001";
}
MENU_NAME = TOP_MENU;
MENU_KEY = MENU_NAME;
L0300();
MENU_SELECTIONS[MENU_NO] = MENU_NAME;
do {
if (MENU_NO < 1) break;
L0100();
L0200();
if (SEL == COMMON.BELL) {
ALL_CLEAR = COMMON.BELL;
return;
}
// BEGIN CASE
if (PROCESS_TYPE == "M") {
PRINT(AT(COL_DISP, MENU_NO + LINE) + TOP_COLOUR);
PRINT(FORMAT((FORMAT(LINE - 1, "R#2") + " " + MENU_REC[(LINE), 1]), DISPLAY_MASK) + " " + NRM_VID);
PRINT(AT(COL_DISP, OPTION_LINE) + MENU_BAR_COLOUR + FORMAT(OPTION_TEXT, DISPLAY_MASK) + " " + NRM_VID);
MENU_NO = MENU_NO + 1;
if (MENU_NO > 15) {
nrf0 = 99;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
MENU_NO = MENU_NO - 1;
} else {
COL_DISP = (MENU_NO * DISTANCE) - DISTANCE;
ROW_DISP = MENU_NO;
MENU_NAME = MENU_REC[SEL_NO, 3];
MENU_SELECTIONS[MENU_NO] = MENU_NAME;
}
} else if (PROCESS_TYPE == "P" || PROCESS_TYPE == "Q") {
// BEGIN CASE
if (PROCESS_TYPE == "P") {
//CallAt_PROCESS_NAME = new CallAt_PROCESS_NAME(PROCESS_NAME);
PRINT(AT(0, 0) + NRM_VID);
} else if (PROCESS_TYPE == "Q") {
//FL100_ALL = new FL100_ALL(ref PROCESS_NAME);
}
nrf0 = "FL011";
//FL0001_110 = new FL0001_110(ref nrf0, ref FUNCTION_KEY_CONVERT);
L0300();
REDISP_NO = MENU_NO;
MENU_NO = 0;
do {
MENU_NO = MENU_NO + 1;
if (MENU_NO > REDISP_NO) break;
COL_DISP = (MENU_NO * DISTANCE) - DISTANCE;
ROW_DISP = MENU_NO;
L0100();
PRINT(AT(COL_DISP, MENU_NO + PREVIOUS_SELECTION) + TOP_COLOUR);
PRINT(FORMAT((FORMAT(PREVIOUS_SELECTION - 1, "R#2") + " " + MENU_REC[(PREVIOUS_SELECTION), 1]), DISPLAY_MASK) + NRM_VID + " ");
PRINT(AT(COL_DISP, OPTION_LINE) + MENU_BAR_COLOUR + FORMAT(OPTION_TEXT, DISPLAY_MASK) + " " + NRM_VID);
} while (true);
MENU_NO = REDISP_NO;
}
} while (true);
return;
}
void L0100() {
MENU_KEY = MENU_SELECTIONS[MENU_NO];
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
PRINT(AT(35, 0) + TOP_COLOUR + FORMAT(("(" + MENU_KEY + ")"), "L#25"));
} else {
PRINT(AT(35, 0) + TOP_COLOUR + FORMAT(("(" + MENU_KEY + ")"), "L#24"));
}
if (!(READ(ref MENU_REC, COMMON.FILES[FL_MENUS], MENU_KEY))) {
nrf0 = 1;
nrf1 = MENU_KEY + "*" + MENU_NO;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
MENU_REC = "";
}
MAX_POSSIBLE = ROW_DISP + DCOUNT(MENU_REC, AM) - 1;
if (MAX_POSSIBLE > MAX_DEPTH) {
MENU_LINES = DCOUNT(MENU_REC, AM);
LAST_LINE = (MENU_LINES - (MAX_POSSIBLE - MAX_DEPTH));
MENU_REC2 = MENU_REC[1] + " 2nd Half";
for(MENU_LINE = MENU_LINES; MENU_LINE <= LAST_LINE; MENU_LINE += -1) {
MENU_REC2 = INSERT(MENU_REC2, 2, 0, 0, MENU_REC[MENU_LINE]);
MENU_REC = DELETE(MENU_REC, MENU_LINE);
}
SECOND_HALF = MENU_KEY + "**1";
MENU_REC[-1] = "More to view -->" + VM + "M" + VM + SECOND_HALF;
TRANS_LOG_REC = MENU_REC2;
nrf0 = "W";nrf1 = "FL.MENUS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SECOND_HALF);
WRITE(MENU_REC2, COMMON.FILES[FL_MENUS], SECOND_HALF);
}
SEL_KEY = PORT_NUMBER + "*" + MENU_KEY;
if (!(READV(ref PREVIOUS_SELECTION, COMMON.FILES[FL_MENU_SELECTIONS], SEL_KEY, 1))) {
PREVIOUS_SELECTION = 1;
}
PREVIOUS_SELECTION = PREVIOUS_SELECTION + 1;
// display menu
LINE = 0;
do {
LINE = LINE + 1;
SELECTION = MENU_REC[LINE, 1];
if (SELECTION == "") break;
MAX = LINE;
PRINT(AT(COL_DISP + DISPLAY_WIDTH + 1, ROW_DISP + LINE) + NRM_VID + COMMON.EOL);
if (LINE == 1) {
FRONT = INT((DISPLAY_WIDTH - LEN(SELECTION)) / 2);
TAIL = DISPLAY_WIDTH - (FRONT + LEN(SELECTION));
SELECTION = SPACE(FRONT) + SELECTION + SPACE(TAIL);
THIS_COLOUR = MENU_BAR_COLOUR;
} else {
THIS_COLOUR = MENU_NORM_COLOUR;
}
if (LINE == 1) {
PRINT(AT(COL_DISP, ROW_DISP + LINE) + THIS_COLOUR + FORMAT(SELECTION, DISPLAY_MASK) + " " + NRM_VID);
} else {
PRINT(AT(COL_DISP, ROW_DISP + LINE) + THIS_COLOUR + FORMAT(((FORMAT(LINE - 1, "R#2")) + " " + SELECTION), DISPLAY_MASK) + " " + NRM_VID);
}
} while (true);
OPTION_LINE = ROW_DISP + LINE;
PRINT(AT(COL_DISP + DISPLAY_WIDTH + 1, OPTION_LINE) + NRM_VID + COMMON.EOL);
if (SEL == COMMON.ABANDON) {
L0400();
}
PRINT(AT(COL_DISP, OPTION_LINE) + OPTION_COLOUR + FORMAT(OPTION_TEXT, DISPLAY_MASK) + " " + NRM_VID);
return;
}
void L0200() {
if (PREVIOUS_SELECTION > MAX) {
LINE = 2;
} else {
LINE = PREVIOUS_SELECTION;
}
LAST_LINE = LINE;
do {
PRINT(AT(COL_DISP, ROW_DISP + LAST_LINE) + MENU_NORM_COLOUR);
PRINT(FORMAT((FORMAT(LAST_LINE - 1, "R#2") + " " + MENU_REC[(LAST_LINE), 1]), DISPLAY_MASK) + " " + NRM_VID + " ");
PRINT(AT(COL_DISP, MENU_NO + LINE) + HIGHLIGHT_COLOUR);
PRINT(FORMAT((FORMAT(LINE - 1, "R#2") + " " + MENU_REC[(LINE), 1]), DISPLAY_MASK) + " " + NRM_VID);
LAST_LINE = LINE;
PRINT(AT(COL_DISP + OPTION_TEXT_LEN + 5, OPTION_LINE));
ECHO(0);
INPUT(out SEL, 1);
ECHO(1);
if (SEL == COMMON.ABANDON) {
if (MENU_NO == 1) {
SEL = "DRIPDRY";
} else {
MENU_NO = MENU_NO - 1;
COL_DISP = (MENU_NO * DISTANCE) - DISTANCE;
ROW_DISP = MENU_NO;
PROCESS_TYPE = "";
return;
}
}
if (SEL == COMMON.BELL) break;
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
PRINT(AT(72, 0) + TOP_COLOUR + OCONV(TIME(), "MT") + NRM_VID);
} else {
PRINT(AT(71, 0) + TOP_COLOUR + OCONV(TIME(), "MT") + NRM_VID);
}
// BEGIN CASE
if (SEL == FUNCT_PREFIX) {
ECHO(0);
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
INPUT(out SEL2, 1);
} else {
INPUT(out SEL2, 2);
}
ECHO(1);
SEL = SEL + SEL2;
if (!LOCATE(SEL, QUICK_CALLS, 1, 0, 1, ref FNUM, "AL")) { FNUM = 0; }
if (FNUM) {
PROCESS_NAME = QUICK_CALLS[2, FNUM];
nrf0 = "P";
FL024 = new FL024(ref PROCESS_NAME, ref nrf0, ref AUTH);
if (AUTH) {
PROCESS_TYPE = "P";
return;
}
}
} else if (SEL == COMMON.DOWN) {
LINE = LINE + 1;
if (LINE > MAX) {
LINE = 2;
}
} else if (SEL == COMMON.UP) {
LINE = LINE - 1;
if (LINE < 2) {
LINE = MAX;
}
} else if (SEL == SELECTION_CHOSEN || (NUM(SEL) && SEL > 0 && SEL < MAX)) {
if (NUM(SEL) && SEL != "") {
PRINT(AT(COL_DISP + OPTION_TEXT_LEN + 5, OPTION_LINE) + SEL);
INPUT(out SEL2, 2);
SEL = SEL + SEL2;
if (SEL > 0 && SEL < MAX) {
LINE = SEL + 1;
LAST_LINE = PREVIOUS_SELECTION;
PRINT(AT(COL_DISP, ROW_DISP + LAST_LINE) + MENU_NORM_COLOUR);
PRINT(FORMAT((FORMAT(LAST_LINE - 1, "R#2") + " " + MENU_REC[(LAST_LINE), 1]), DISPLAY_MASK) + " " + NRM_VID + " ");
PRINT(AT(COL_DISP, MENU_NO + LINE) + HIGHLIGHT_COLOUR);
PRINT(FORMAT((FORMAT(LINE - 1, "R#2") + " " + MENU_REC[(LINE), 1]), DISPLAY_MASK) + " " + NRM_VID);
} else {
SEL = 999;
}
}
if (SEL != 999) {
SEL_NO = LINE;
PROCESS_TYPE = MENU_REC[SEL_NO, 2];
PROCESS_NAME = MENU_REC[SEL_NO, 3];
if (INDEX(PROCESS_NAME, "**", 1)) {
AUTH = TRUE;
} else {
FL024 = new FL024(ref PROCESS_NAME, ref PROCESS_TYPE, ref AUTH);
}
if (AUTH) {
if (PROCESS_NAME != "FL999") {
TRANS_LOG_REC = SEL_NO - 1;
TX_ATT = 1;
nrf0 = "WV";nrf1 = "FL.MENU.SELECTIONS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SEL_KEY);
WRITEV(SEL_NO - 1, COMMON.FILES[FL_MENU_SELECTIONS], SEL_KEY, 1);
}
return;
}
} else {
nrf0 = 3;
nrf1 = MAX - 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINT(AT(COL_DISP + OPTION_TEXT_LEN + 5, OPTION_LINE) + "   ");
}
} else if (OTHERWISE) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} while (true);
return;
}
void L0300() {
PRINT(COMMON.WASH);
PRINTCR(AT(78, 0) + NRM_VID);
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
PRINT(AT(0, 0) + TOP_COLOUR + FORMAT((PORT_NUMBER + " " + U_INITS), "L#10") + FORMAT(CENTRES_REC[CENTRE_NAME], "L#25") + " " + AT(60, 0) + OCONV(TODAYS_DATE, "D") + " " + OCONV(TIME(), "MT"));
} else {
PRINT(AT(0, 0) + TOP_COLOUR + FORMAT((PORT_NUMBER + " " + U_INITS), "L#10") + FORMAT(CENTRES_REC[CENTRE_NAME], "L#25") + TOP_COLOUR + AT(60, 0) + OCONV(TODAYS_DATE, "D") + TOP_COLOUR + OCONV(TIME(), "MT"));
}
PRINT(AT(1, FUNCTION_LINE2 + 1) + NRM_VID);
for(FUNC_KEY = 1; FUNC_KEY <= 12; FUNC_KEY += 1) {
if (FUNC_KEY < 7) {
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
if (FUNC_KEY == 1) {
PRINT(AT((FUNC_KEY - 1) * 13, FUNCTION_LINE1) + FUNCT_COLOUR + "f1" + MENU_NORM_COLOUR + " " + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
} else {
PRINT(AT((FUNC_KEY - 1) * 13, FUNCTION_LINE1) + "f" + FORMAT(FUNC_KEY, "L#2") + MENU_NORM_COLOUR + " " + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
}
} else {
if (FUNC_KEY == 1) {
PRINT(AT((FUNC_KEY - 1) * 13, FUNCTION_LINE1) + FUNCT_COLOUR + "f1" + MENU_NORM_COLOUR + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
} else {
PRINT(AT((FUNC_KEY - 1) * 13, FUNCTION_LINE1) + "f" + FORMAT(FUNC_KEY, "L#2") + MENU_NORM_COLOUR + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
}
}
} else {
if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "S") {
if (FUNC_KEY == 7) {
PRINT(AT((FUNC_KEY - 7) * 13, FUNCTION_LINE2) + FUNCT_COLOUR + "f9" + MENU_NORM_COLOUR + " " + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
} else {
PRINT(AT((FUNC_KEY - 7) * 13, FUNCTION_LINE2) + "f" + FORMAT(FUNC_KEY, "L#2") + MENU_NORM_COLOUR + " " + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
}
} else {
if (FUNC_KEY == 7) {
PRINT(AT((FUNC_KEY - 7) * 13, FUNCTION_LINE2) + FUNCT_COLOUR + "f9" + MENU_NORM_COLOUR + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
} else {
PRINT(AT((FUNC_KEY - 7) * 13, FUNCTION_LINE2) + "f" + FORMAT(FUNC_KEY, "L#2") + MENU_NORM_COLOUR + QUICK_CALLS[3, FUNC_KEY] + FUNCT_COLOUR);
}
}
}
}
PRINT(AT(0, FUNCTION_LINE2 + 1) + NRM_VID);
return;
}
void L0400() {
CLEAR_LINE = OPTION_LINE + 1;
CLEAR_DISP = ((MENU_NO + 1) * DISTANCE) - DISTANCE;
BEFORE_FUNCTION = FUNCTION_LINE1 - 1;
for(XLINE = CLEAR_LINE; XLINE <= BEFORE_FUNCTION; XLINE += 1) {
PRINT(AT(CLEAR_DISP, XLINE) + NRM_VID + COMMON.EOL);
}
return;
}
}
}
