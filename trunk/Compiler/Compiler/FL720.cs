//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL720 : UvBase
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
readonly UvVar SCHED_START = 1;
readonly UvVar SCHED_END = 2;
readonly UvVar SCHED_BOOKING_DATES = 3;
readonly UvVar SCHED_CLOSE_DATE = 4;
readonly UvVar SCHED_COURSE_CODES = 5;
readonly UvVar SCHED_BLOCK_REFS = 6;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] SCHEDULE_REC = new UvVar[15];
#endregion
#region Variables
UvVar SCHEDULE_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar MACHINE_TYPE = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_SCHEDULES = "";
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
UvVar SCHEDULE_LIST = "";
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
UvVar FOOTER2 = "";
UvVar REPLY2 = "";
UvVar SCHEDULE_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar COURSE_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL720(ref UvVar SCHEDULE_ID, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.SCHEDULE_ID = SCHEDULE_ID;
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
/*     SCHEDULE DATES LIST / SELECTION SCREEN */
PROGRAM = "FL720";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
SCHEDULE_ID = "";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.SCHEDULES

if (!OPEN("FL.SCHEDULES", out FL_SCHEDULES)) { STOP("201", "FL.SCHEDULES"); }

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
FOOTER = " Schedule No, 'Dn' to Delete or <Return> ";
SCHEDULE_LIST = "";
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
do {
if (INTERACT == EXIT || CODES_FOUND) break;
INSTRUCTION = "SSELECT FL.SCHEDULES BY 1";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
CC = CC + 1;
SCHEDULE_LIST[1, CC] = ID;
} while (true);
if (CC == 0) {
/*     No items selected */
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
} else {
CODES_FOUND = TRUE;
}
} while (true);
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
SCHEDULE_ID = SCHEDULE_LIST[1, WAIT];
if (SCHEDULE_ID == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = FINISH;
REDISPLAY = TOP_WINDOW;
}
}// CASE
else if (WAIT.Substring(1, 1) == "D" && MATCH(WAIT.Substring(2, 99),"0N")) {
SCHEDULE_ID = SCHEDULE_LIST[1, WAIT.Substring(2, 99)];
if (SCHEDULE_ID == "") {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
FOOTER2 = " Delete " + SCHEDULE_ID + "? (Y/N) ";
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER2, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER2), 2 + BOTTOM_WINDOW));
INPUT(out REPLY2, 2);
if (REPLY2 == "Y") {
DELETE(FL_SCHEDULES, SCHEDULE_ID);
SCHEDULE_LIST = DELETE(SCHEDULE_LIST, 1, WAIT.Substring(2, 99), 0);
}
SCHEDULE_NO = 1;
INTERACT = LIMIT;
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
SCHEDULE_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
SCHEDULE_ID = SCHEDULE_LIST[1, SCHEDULE_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 10) + NRM_VID);
if (SCHEDULE_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
if (!MATREAD(ref SCHEDULE_REC, FL_SCHEDULES, SCHEDULE_ID)) { MAT(ref SCHEDULE_REC, ""); }
COURSE_LINE = FORMAT(SCHEDULE_NO, "R#4") + "  " + FORMAT(SCHEDULE_ID, "L#10") + "  " + OCONV(SCHEDULE_REC[SCHED_START], "D") + "   " + OCONV(SCHEDULE_REC[SCHED_END], "D");
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT(COURSE_LINE, WINDOW_JUST));
}
SCHEDULE_NO = SCHEDULE_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (SCHEDULE_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (SCHEDULE_ID == "") {
SCHEDULE_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}
