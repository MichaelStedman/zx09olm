//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL791 : UvBase
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
UvVar ANS = "";
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
UvVar OPTION_LIST = "";
UvVar WAIT = "";
UvVar OPTION_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar DISPLAY_LINE = "";
#endregion
public FL791(ref UvVar ANS, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.ANS = ANS;
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
/*     ACTIVITY DAY ENROLMENT HELP */
PROGRAM = "FL791";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
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
FOOTER = " Enter your choice here: ";
OPTION_LIST = "";
OPTION_LIST[1, 1] = "# no";
OPTION_LIST[1, 2] = "Enter no. on the right of a date to amend individual sessions";
OPTION_LIST[2, 1] = "Sn";
OPTION_LIST[2, 2] = "S1 selects session 1 for all dates, S2 selects session 2 etc";
OPTION_LIST[3, 1] = "ALL";
OPTION_LIST[3, 2] = "Select all available sessions for all listed dates";
OPTION_LIST[4, 1] = "NONE";
OPTION_LIST[4, 2] = "Deselect all sessions for all listed dates";
OPTION_LIST[5, 1] = "R";
OPTION_LIST[5, 2] = "All sessions on a range of dates you specify will be selected";
OPTION_LIST[6, 1] = "Rn";
OPTION_LIST[6, 2] = "R1 selects session 1 on a range of dates you specify etc";
OPTION_LIST[7, 1] = "AAn";
OPTION_LIST[7, 2] = "Day and session, e.g. MO1 selects session 1 for every Monday";
OPTION_LIST[8, 1] = "F";
OPTION_LIST[8, 2] = "Finish session selection, calculate and process fee/payment";
OPTION_LIST[9, 1] = "H";
OPTION_LIST[9, 2] = "Hide membership photograph";
OPTION_LIST[10, 1] = "C";
OPTION_LIST[10, 2] = "Display comments about this activity day";
OPTION_LIST[11, 1] = "Vnn";
OPTION_LIST[11, 2] = "Vacancy enquiry where 'nn' is number of spaces required";
/* !*  OPTION.LIST<12,1> = "." */
/* !*  OPTION.LIST<12,2> = "Abandon (no updates)" */
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
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
/*  Return to calling program */
REDISPLAY = TOP_WINDOW;
return;
}
void L1000() {
/*  Display last line message */
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
INPUT(out WAIT, 6);
// BEGIN CASE
// CASE
if (WAIT == COMMON.ABANDON) {
INTERACT = EXIT;
ANS = COMMON.ABANDON;
}// CASE
else if (OTHERWISE) {
ANS = WAIT;
INTERACT = VALID_DATA;
}
// END CASE
} while (true);
return;
/* *************************************************** */
}
void L3000() {
/*   Display data section of window              * */
/* *************************************************** */
OPTION_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 7) + NRM_VID);
if (OPTION_LIST[OPTION_NO] == "") {
PRINT(AT(LEFT_WINDOW, CNT + 7) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
DISPLAY_LINE = " " + FORMAT(OPTION_LIST[OPTION_NO, 1], "L#6") + " " + OPTION_LIST[OPTION_NO, 2];
PRINT(AT(LEFT_WINDOW, CNT + 7) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
OPTION_NO = OPTION_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (OPTION_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
CNT = 0;
} while (true);
return;
}
}
}
