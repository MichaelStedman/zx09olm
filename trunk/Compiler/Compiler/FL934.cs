//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL934 : UvBase
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
#endregion
#region Variables
UvVar CENTRE_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar MACHINE_TYPE = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
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
UvVar CENTRE_LIST = "";
UvVar CODES_FOUND = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar CC = "";
UvVar ID = "";
FL006 FL006;
UvVar WAIT = "";
UvVar CENTRE_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar DISPLAY_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL934(ref UvVar CENTRE_ID, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.CENTRE_ID = CENTRE_ID;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
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
/*     CENTRE CODE LIST / SELECTION SCREEN */
/*     NB: COPY OF FL722. THIS ROUTINE WORKS FROM FL.CENTRES, WHEREAS FL722 */
/*         WORKS OF FL.MASTER.CENTRES. THESE NEED COMBINING AT SOME POINT. */
PROGRAM = "FL934";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
CENTRE_ID = "";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

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
FOOTER = " Select Centre No. or <Return> to scroll ";
CENTRE_LIST = "";
/*  Box heading */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
L3000();
/*  Display data portion of window */
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
CODES_FOUND = FALSE;
/* *   LOOP */
/* **    UNTIL INTERACT = EXIT OR CODES.FOUND DO */
INSTRUCTION = "SSELECT FL.CENTRES BY 1";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
CC = CC + 1;
CENTRE_LIST[1, CC] = ID;
} while (true);
if (CC == 0) {
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
if (INTERACT != EXIT && CODES_FOUND) {
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
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
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
CENTRE_ID = CENTRE_LIST[1, WAIT];
if (CENTRE_ID == "") {
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
CENTRE_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
CENTRE_ID = CENTRE_LIST[1, CENTRE_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 10) + NRM_VID);
if (CENTRE_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
if (!MATREAD(ref CENTRES_REC, COMMON.FILES[FL_CENTRES], CENTRE_ID)) { MAT(ref CENTRES_REC, ""); }
DISPLAY_LINE = FORMAT(CENTRE_NO, "R#4") + "  " + FORMAT(CENTRE_ID, "L#4") + "  " + CENTRES_REC[CENTRE_NAME];
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
CENTRE_NO = CENTRE_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (CENTRE_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (CENTRE_ID == "") {
CENTRE_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}