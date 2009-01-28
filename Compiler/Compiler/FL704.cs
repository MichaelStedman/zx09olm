//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL704 : UvBase
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
readonly UvVar COURSE_DET_SESSIONS = 1;
readonly UvVar COURSE_DET_END = 2;
readonly UvVar COURSE_DET_BOOKING_DATES = 3;
readonly UvVar COURSE_DET_CLOSE_DATE = 4;
readonly UvVar COURSE_DET_SCHEDULE_CODE = 5;
readonly UvVar COURSE_DET_MAXIMUM_PLACES = 6;
readonly UvVar COURSE_DET_MINIMUM_PLACES = 7;
readonly UvVar COURSE_DET_FEE_CODE = 8;
readonly UvVar COURSE_DET_START_TIME = 9;
readonly UvVar COURSE_DET_END_TIME = 10;
readonly UvVar COURSE_DET_FREQUENCY = 11;
readonly UvVar COURSE_DET_DAYS = 12;
readonly UvVar COURSE_DET_INSTRUCTOR = 13;
readonly UvVar COURSE_DET_COMMENTS = 14;
readonly UvVar COURSE_DET_BLOCK_REF = 15;
readonly UvVar COURSE_DET_VACANCIES = 16;
readonly UvVar COURSE_DET_GROUP_NAMES = 17;
readonly UvVar COURSE_DET_GROUP_NAMES_SUMM = 18;
readonly UvVar COURSE_DET_GROUP_MAXIMUMS = 19;
readonly UvVar COURSE_DET_GROUP_VACANCIES = 20;
readonly UvVar COURSE_DET_STUDENT_IDS = 21;
readonly UvVar COURSE_DET_INSTRUCTOR2 = 22;
readonly UvVar COURSE_DET_UNAVAILABLE_SESSIONS = 23;
readonly UvVar COURSE_DET_SESSION_DATES = 24;
readonly UvVar COURSE_DET_SESSION_FLAGS = 25;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_DET_REC = new UvVar[25];
#endregion
#region Variables
UvVar DATE_LIST = "";
UvVar NEW_COURSE = "";
UvVar CREATION_ALLOWED = "";
UvVar SELECT_DATE = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar PROG_MESS = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar COURSE_CODE = "";
UvVar FL_COURSE_DETAILS = "";
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
UvVar DATE_NO = "";
UvVar CNT = "";
UvVar COURSE_DATE = "";
UvVar DETAILS_ID = "";
UvVar COURSE_END_DATE = "";
UvVar VACS = "";
UvVar COURSE_LINE = "";
UvVar WAIT = "";
FL006 FL006;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL704(ref UvVar DATE_LIST, ref UvVar NEW_COURSE, ref UvVar CREATION_ALLOWED, ref UvVar SELECT_DATE, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.DATE_LIST = DATE_LIST;
this.NEW_COURSE = NEW_COURSE;
this.CREATION_ALLOWED = CREATION_ALLOWED;
this.SELECT_DATE = SELECT_DATE;
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
/*     DISPLAY/SELECT EXISTING COURSE PERIODS */
PROGRAM = "FL704";
INTERACT = INVALID_DATA;
REDISPLAY = "";
SELECT_DATE = "";
COURSE_CODE = PROG_MESS[2];
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.COURSE.DETAILS
#region INCLUDE FL.FILES FL.COURSE.DETAILS.EQU
if (!OPEN("FL.COURSE.DETAILS", out FL_COURSE_DETAILS)) { STOP("201", "FL.COURSE.DETAILS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.DETAILS.DIM

#endregion
#region INCLUDE FL.FILES FL.COURSE.DETAILS.VAR

/*  Course maintenance, page 2, column 1 fields :- */
/*  Course maintenance, page 2, column 2 fields :- */
/*  The MV's in the following attribute correspond with */
/*  COURSE.DET.BOOKING.DATES and are only used for activity */
/*  day courses */
/*  The following attributes are also used only for activity */
/*  days. There is one attribute per date on which the course */
/*  runs, i.e. a fully expanded list of all bookable dates. */
/*  The second of the two attributes holds "Y" indicators to */
/*  show available sessions, subvalued within each date. */
/*  These attributes will be referenced when enrolling. */

#endregion

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 5;
WINDOW[2] = 19;
WINDOW[3] = 35;
WINDOW[4] = 76;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
if (CREATION_ALLOWED) {
FOOTER = " Enter no, 'N'ew or <RET> to scroll";
} else {
FOOTER = " Enter no. or <RET> to scroll";
}
PRINT(AT(79, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
DATE_NO = 1;
do {
if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
CNT = 0;
do {
CNT = CNT + 1;
COURSE_DATE = DATE_LIST[1, DATE_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 6) + NRM_VID);
if (COURSE_DATE == "") {
PRINT(AT(LEFT_WINDOW, CNT + 6) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
if (!READV(ref COURSE_END_DATE, FL_COURSE_DETAILS, DETAILS_ID, 2)) { COURSE_END_DATE = ""; }
if (!READV(ref VACS, FL_COURSE_DETAILS, DETAILS_ID, 16)) { VACS = 0; }
if (NOT(NUM(VACS))) {
/*  Its an activity day course */
VACS = SPACE(3);
}
COURSE_LINE = FORMAT(DATE_NO, "R#4") + SPACE(2) + FORMAT(OCONV(COURSE_DATE, "D"), "R#11") + SPACE(2) + FORMAT(OCONV(COURSE_END_DATE, "D"), "R#11") + SPACE(2) + FORMAT(VACS, "R#4");
PRINT(AT(LEFT_WINDOW, CNT + 6) + COLOR_C + FORMAT(COURSE_LINE, WINDOW_JUST));
}
DATE_NO = DATE_NO + 1;
} while (true);
L1000();
/*  Restart display from first date when end of list is reached */
if (COURSE_DATE == "") {
DATE_NO = 1;
}
CNT = 0;
} while (true);
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
PRINT(AT(79, CNT + 6) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + 6) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + 6));
INPUT(out WAIT, 4);
// BEGIN CASE
// CASE
if (WAIT == COMMON.ABANDON) {
INTERACT = EXIT;
REDISPLAY = TOP_WINDOW;
}// CASE
else if (WAIT == "N" && CREATION_ALLOWED == TRUE) {
NEW_COURSE = TRUE;
/*  Select.date indicates data set to copy core details from */
SELECT_DATE = DATE_LIST[1, 1];
INTERACT = FINISH;
REDISPLAY = TOP_WINDOW;
}// CASE
else if (WAIT == "0") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(WAIT,"0N") && WAIT != "") {
SELECT_DATE = DATE_LIST[1, WAIT];
if (SELECT_DATE == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = FINISH;
NEW_COURSE = FALSE;
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
}
}
}
