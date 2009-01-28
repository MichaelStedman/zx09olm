//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL930 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar VALID_DATA = 0;
readonly UvVar EXIT = 2;
readonly UvVar BACKUP = 3;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_SPORTS = 23;
readonly UvVar SPORTS_DESC = 1;
readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
readonly UvVar SPORTS_CODE1 = 3;
readonly UvVar SPORTS_CODE2 = 4;
readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
readonly UvVar SPORTS_TYPE = 6;
readonly UvVar SPORTS_BOOK_OR_CAS = 7;
readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
readonly UvVar SPORTS_RESTRICTION_CODE = 9;
readonly UvVar SPORTS_PERSON_BOOKING = 10;
readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
readonly UvVar SPORTS_SETUP_TIME = 12;
readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
readonly UvVar SPORTS_PLAYERS = 14;
readonly UvVar SPORTS_ADMINISTRATOR = 15;
readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
readonly UvVar SPORTS_VISIBILITY = 17;
readonly UvVar SPORTS_SUB_LIST = 18;
readonly UvVar SPORTS_TOP_LEVEL = 19;
readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] SPORTS_REC = new UvVar[25];
#endregion
#region Variables
UvVar RESOURCE_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar SP_CODES = "";
UvVar RESOURCES_ONLY = "";
UvVar MACHINE_TYPE = "";
UvVar NRM_VID = "";
UvVar REV_UND_VID = "";
UvVar DIM_UND_VID = "";
UvVar ID = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar HEADING_TEXT = "";
UvVar HEADING_TEXT2 = "";
UvVar FOOTER = "";
UvVar RESOURCE_LIST = "";
UvVar CODES_FOUND = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar CC = "";
UvVar RES_MVC = "";
UvVar TEST_POS = "";
FL006 FL006;
UvVar WAIT = "";
UvVar RESOURCE_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar DISPLAY_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL930(ref UvVar RESOURCE_ID, ref UvVar INTERACT, ref UvVar REDISPLAY, ref UvVar SP_CODES, ref UvVar RESOURCES_ONLY) {
this.RESOURCE_ID = RESOURCE_ID;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
this.SP_CODES = SP_CODES;
this.RESOURCES_ONLY = RESOURCES_ONLY;
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
/*     RESOURCE & CATEGORY ID LIST / SELECTION SCREEN */
PROGRAM = "FL930";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
RESOURCE_ID = "";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.SPORTS
#region INCLUDE FL.FILES FL.SPORTS.EQU

#endregion

#region INCLUDE FL.FILES FL.SPORTS.DIM

#endregion
#region INCLUDE FL.FILES FL.SPORTS.VAR

/*  Introduced for Warrington: */

#endregion

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 9;
WINDOW[2] = 18;
WINDOW[3] = 1;
WINDOW[4] = 77;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
FOOTER = " Select User No. or <Return> to scroll ";
RESOURCE_LIST = "";
/*  Box heading */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + DIM_UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + DIM_UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
L3000();
/*  Display data portion of window */
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + DIM_UND_VID + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
CODES_FOUND = FALSE;
/* !!  INSTRUCTION = 'SSELECT FL.SPORTS' */
INSTRUCTION = "SSELECT FL.SPORTS BY 1";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
RES_MVC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
CC = CC + 1;
if (SP_CODES == "") {
if (!READV(ref SPORTS_REC[SPORTS_CAT_OR_RESOURCE], COMMON.FILES[FL_SPORTS], ID, 16)) { SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R"; }
if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "") { SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R"; }
if (RESOURCES_ONLY == FALSE || SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "R") {
RES_MVC = RES_MVC + 1;
RESOURCE_LIST[1, RES_MVC] = ID;
}
} else {
if (LOCATE(ID, SP_CODES, 1, 0, 1, ref TEST_POS, "AL")) {
/*  Resource is available at this centre */
RES_MVC = RES_MVC + 1;
RESOURCE_LIST[1, RES_MVC] = ID;
}
}
} while (true);
if (RES_MVC == 0) {
/*     No items selected */
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = FINISH;
} else {
CODES_FOUND = TRUE;
}
/* *   REPEAT */
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
if (INTERACT != EXIT) {
L3000();
/*  Display data portion of window */
}
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
}
void L1000() {
/*  Display last line message */
INTERACT = INVALID_DATA;
do {
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + DIM_UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
INPUT(out WAIT, 4);
// BEGIN CASE
// CASE
if (WAIT == COMMON.ABANDON) {
INTERACT = EXIT;
REDISPLAY = TOP_WINDOW;
}// CASE
else if (WAIT == "0") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(WAIT,"0N") && WAIT != "") {
RESOURCE_ID = RESOURCE_LIST[1, WAIT];
if (RESOURCE_ID == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = FINISH;
REDISPLAY = TOP_WINDOW;
}
}// CASE
else if (OTHERWISE) {
INTERACT = LIMIT;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* *************************************************** */
}
void L3000() {
/*   Display data section of window              * */
/* *************************************************** */
RESOURCE_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
RESOURCE_ID = RESOURCE_LIST[1, RESOURCE_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + TOP_WINDOW + 2) + NRM_VID);
if (RESOURCE_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + REV_UND_VID + FORMAT("", WINDOW_JUST));
} else {
if (!MATREAD(ref SPORTS_REC, COMMON.FILES[FL_SPORTS], RESOURCE_ID)) { MAT(ref SPORTS_REC, ""); }
/*  Set default values for old resources, created on old version */
if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "") {
SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R";
}
if (SPORTS_REC[SPORTS_VISIBILITY] == "") {
SPORTS_REC[SPORTS_VISIBILITY] = "B";
}
DISPLAY_LINE = FORMAT(RESOURCE_NO, "R#4") + " " + FORMAT(RESOURCE_ID, "L#5") + " " + FORMAT(SPORTS_REC[SPORTS_DESC], "L#30") + " " + FORMAT(SPORTS_REC[SPORTS_CAT_OR_RESOURCE], "R#2") + SPACE(3) + SPORTS_REC[SPORTS_VISIBILITY];
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + REV_UND_VID + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
RESOURCE_NO = RESOURCE_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (RESOURCE_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (RESOURCE_ID == "") {
RESOURCE_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}
