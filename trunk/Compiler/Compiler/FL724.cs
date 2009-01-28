//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL724 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar AVAILABILITY_ID = "";
UvVar AVAILABILITY_LIST = "";
UvVar AVAILABILITY_CODE_DESCRIPTION_LIST = "";
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
UvVar WAIT = "";
FL006 FL006;
UvVar AVAILABILITY_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar AVAILABILITY_CODE_DESCRIPTION = "";
UvVar DISPLAY_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL724(ref UvVar AVAILABILITY_ID, ref UvVar AVAILABILITY_LIST, ref UvVar AVAILABILITY_CODE_DESCRIPTION_LIST, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.AVAILABILITY_ID = AVAILABILITY_ID;
this.AVAILABILITY_LIST = AVAILABILITY_LIST;
this.AVAILABILITY_CODE_DESCRIPTION_LIST = AVAILABILITY_CODE_DESCRIPTION_LIST;
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
/*     AVAILABILITY CODES / SELECTION SCREEN */
PROGRAM = "FL724";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
AVAILABILITY_ID = "";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
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
FOOTER = " Select AVAILABILITY No. or <Return> to scroll ";
/*  Box heading */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
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
AVAILABILITY_ID = AVAILABILITY_LIST[WAIT];
if (AVAILABILITY_ID == "") {
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
AVAILABILITY_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
AVAILABILITY_ID = AVAILABILITY_LIST[AVAILABILITY_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + TOP_WINDOW + 2) + NRM_VID);
if (AVAILABILITY_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
AVAILABILITY_CODE_DESCRIPTION = AVAILABILITY_CODE_DESCRIPTION_LIST[AVAILABILITY_NO];
DISPLAY_LINE = FORMAT(AVAILABILITY_NO, "R#4") + "  " + FORMAT(AVAILABILITY_ID, "L#7") + "  " + AVAILABILITY_CODE_DESCRIPTION;
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 2) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
AVAILABILITY_NO = AVAILABILITY_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (AVAILABILITY_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (AVAILABILITY_ID == "") {
AVAILABILITY_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}
