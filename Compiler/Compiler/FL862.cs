//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL862 : UvBase
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
readonly UvVar FIRST_CALL = 1;
readonly UvVar SCROLL = 2;
readonly UvVar TOGGLE = 3;
readonly UvVar FL_CONTROL = 10;
readonly UvVar STUDENT_TITLE = 1;
readonly UvVar STUDENT_FORENAME = 2;
readonly UvVar STUDENT_SURNAME = 3;
readonly UvVar STUDENT_ADDRESS1 = 4;
readonly UvVar STUDENT_ADDRESS2 = 5;
readonly UvVar STUDENT_ADDRESS3 = 6;
readonly UvVar STUDENT_ADDRESS4 = 7;
readonly UvVar STUDENT_POST_CODE = 8;
readonly UvVar STUDENT_SEX = 9;
readonly UvVar STUDENT_HOME_TEL = 10;
readonly UvVar STUDENT_WORK_TEL = 11;
readonly UvVar STUDENT_DOB = 12;
readonly UvVar STUDENT_MEDICAL1 = 13;
readonly UvVar STUDENT_MEDICAL2 = 14;
readonly UvVar STUDENT_MEDICAL3 = 15;
readonly UvVar STUDENT_COMMENT1 = 16;
readonly UvVar STUDENT_COMMENT2 = 17;
readonly UvVar STUDENT_COMMENT3 = 18;
readonly UvVar STUDENT_COMMENT4 = 19;
readonly UvVar STUDENT_CONTACT_NAME = 20;
readonly UvVar STUDENT_CONTACT_PHONE = 21;
readonly UvVar STUDENT_DETAIL_IDS = 22;
readonly UvVar STUDENT_BALANCE = 23;
readonly UvVar STUDENT_TRANS_DETAILS_IDS = 24;
readonly UvVar STUDENT_TRANS_DATES = 25;
readonly UvVar STUDENT_TRANS_TYPES = 26;
readonly UvVar STUDENT_TRANS_AMOUNTS = 27;
readonly UvVar STUDENT_TRANS_RECEIPT_NOS = 28;
readonly UvVar STUDENT_TRANS_MOPS = 29;
readonly UvVar STUDENT_TRANS_MAN_RECEIPT = 30;
readonly UvVar STUDENT_TRANS_WEB = 30;
readonly UvVar STUDENT_TRANS_ADJ_REASON = 31;
readonly UvVar STUDENT_TRANS_USER = 32;
readonly UvVar STUDENT_OLD_NUMBERS = 33;
readonly UvVar STUDENT_AWARD1 = 34;
readonly UvVar STUDENT_AWARD2 = 35;
readonly UvVar STUDENT_AWARD3 = 36;
readonly UvVar STUDENT_AWARD4 = 37;
readonly UvVar STUDENT_DOCTOR_NAME = 38;
readonly UvVar STUDENT_DOCTOR_TEL = 39;
readonly UvVar STUDENT_KEYWORD = 40;
readonly UvVar STUDENT_AWARD5 = 41;
readonly UvVar STUDENT_AWARD6 = 42;
readonly UvVar STUDENT_AWARD7 = 43;
readonly UvVar STUDENT_AWARD8 = 44;
readonly UvVar STUDENT_AWARD9 = 45;
readonly UvVar STUDENT_AWARD10 = 46;
readonly UvVar STUDENT_AWARD11 = 47;
readonly UvVar STUDENT_AWARD12 = 48;
readonly UvVar STUDENT_GROUP_ENROLLED = 49;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
#endregion
#region Variables
UvVar ACTION = "";
UvVar TOGGLE_POS = "";
UvVar STUDENT_SELECT_LIST = "";
UvVar SPARE1 = "";
UvVar REDISPLAY = "";
UvVar STUDENT_COUNT = "";
UvVar STUDENT_LIST = "";
UvVar SURNAME_LIST = "";
UvVar FULL_NAME_LIST = "";
UvVar COURSE_CODE_LIST = "";
UvVar COURSE_DESC_LIST = "";
UvVar COURSE_DATE_LIST = "";
UvVar ERROR_LIST = "";
UvVar WINDOW_DEPTH = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar FL_STUDENTS = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar HEADING_TEXT = "";
UvVar HEADING_TEXT2 = "";
UvVar FOOTER = "";
UvVar CNT = "";
UvVar STUDENT_ID = "";
UvVar COURSE_LINE = "";
UvVar TEMP_STUDENT_COUNT = "";
UvVar OFFSET = "";
UvVar TOGGLE_ROW = "";
#endregion
public FL862(ref UvVar ACTION, ref UvVar TOGGLE_POS, ref UvVar STUDENT_SELECT_LIST, ref UvVar SPARE1, ref UvVar REDISPLAY, ref UvVar STUDENT_COUNT, ref UvVar STUDENT_LIST, ref UvVar SURNAME_LIST, ref UvVar FULL_NAME_LIST, ref UvVar COURSE_CODE_LIST, ref UvVar COURSE_DESC_LIST, ref UvVar COURSE_DATE_LIST, ref UvVar ERROR_LIST, ref UvVar WINDOW_DEPTH) {
this.ACTION = ACTION;
this.TOGGLE_POS = TOGGLE_POS;
this.STUDENT_SELECT_LIST = STUDENT_SELECT_LIST;
this.SPARE1 = SPARE1;
this.REDISPLAY = REDISPLAY;
this.STUDENT_COUNT = STUDENT_COUNT;
this.STUDENT_LIST = STUDENT_LIST;
this.SURNAME_LIST = SURNAME_LIST;
this.FULL_NAME_LIST = FULL_NAME_LIST;
this.COURSE_CODE_LIST = COURSE_CODE_LIST;
this.COURSE_DESC_LIST = COURSE_DESC_LIST;
this.COURSE_DATE_LIST = COURSE_DATE_LIST;
this.ERROR_LIST = ERROR_LIST;
this.WINDOW_DEPTH = WINDOW_DEPTH;
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
/*     DISPLAY COURSE MEMBER DETAILS FOR ENROLMENT CHANGES */
PROGRAM = "FL862";
INTERACT = INVALID_DATA;
REDISPLAY = "";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 14;
WINDOW[2] = 19;
WINDOW[3] = 45;
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
FOOTER = "";
/* **************************************************** */
/*  Main processing section                           * */
/* **************************************************** */
// BEGIN CASE
// CASE
if (ACTION == FIRST_CALL) {
L0200();
}// CASE
else if (ACTION == SCROLL) {
L0200();
}// CASE
else if (ACTION == TOGGLE) {
L0300();
}
// END CASE
return;
/* **************************************************** */
}
void L0200() {
/*   Print a page of detail                       * */
/* **************************************************** */
CNT = 0;
do {
if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
do {
CNT = CNT + 1;
STUDENT_ID = STUDENT_LIST[1, STUDENT_COUNT];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(RIGHT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID);
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
COURSE_LINE = "";
COURSE_LINE = FORMAT(STUDENT_COUNT, "R#3") + SPACE(2) + FORMAT(STUDENT_ID, "L#10");
COURSE_LINE = COURSE_LINE + FORMAT(FULL_NAME_LIST[1, STUDENT_COUNT], "L#20") + SPACE(2) + FORMAT((COURSE_DESC_LIST[1, STUDENT_COUNT] + "(" + COURSE_CODE_LIST[1, STUDENT_COUNT] + ")"), "L#42");
if (STUDENT_SELECT_LIST[1, STUDENT_COUNT] == TRUE) {
PRINT(AT(78, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + REV_VID);
} else {
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + NRM_VID);
}
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(COURSE_LINE, WINDOW_JUST));
}
STUDENT_COUNT = STUDENT_COUNT + 1;
} while (true);
INTERACT = VALID_DATA;
/*  Restart display from first date when end of list is reached */
if (STUDENT_ID == "") {
STUDENT_COUNT = 1;
}
CNT = 0;
} while (true);
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
/* **************************************************** */
}
void L0300() {
/*  Scroll window as necessary prior to a toggle! * */
/* **************************************************** */
// BEGIN CASE
// CASE
if (DCOUNT(STUDENT_LIST, VM) < WINDOW_DEPTH - 1) {
/*  No scrolling necessary.  Only one screen of students */
NULL();
}// CASE
else if (STUDENT_COUNT == 1) {
/*  As there are multiple pages of students this indicates that the last */
/*  page of details is currently on-screen. */
if (TOGGLE_POS > (WINDOW_DEPTH - 1)) {
/*  Student is on a page later than page 1 */
TEMP_STUDENT_COUNT = WINDOW_DEPTH;
do {
if (!(TOGGLE_POS >= (TEMP_STUDENT_COUNT + WINDOW_DEPTH - 1))) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT + (WINDOW_DEPTH - 1);
} while (true);
/* *        STUDENT.COUNT = TEMP.STUDENT.COUNT - (WINDOW.DEPTH-1) */
STUDENT_COUNT = TEMP_STUDENT_COUNT;
L0200();
/*  Scroll */
} else {
L0200();
/*  Scroll */
}
}// CASE
else if (TOGGLE_POS < STUDENT_COUNT - (WINDOW_DEPTH - 1)) {
/*  Student is earlier in the list */
TEMP_STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
do {
if (!(TOGGLE_POS < TEMP_STUDENT_COUNT)) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT - (WINDOW_DEPTH - 1);
} while (true);
STUDENT_COUNT = TEMP_STUDENT_COUNT;
L0200();
/*  Scroll */
}// CASE
else if (TOGGLE_POS >= STUDENT_COUNT) {
/*  Student is later in the list */
TEMP_STUDENT_COUNT = STUDENT_COUNT + (WINDOW_DEPTH - 1);
do {
if (!(TOGGLE_POS > (TEMP_STUDENT_COUNT + WINDOW_DEPTH - 1))) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT + (WINDOW_DEPTH - 1);
} while (true);
STUDENT_COUNT = TEMP_STUDENT_COUNT - (WINDOW_DEPTH - 1);
L0200();
/*  Scroll */
}
// END CASE
L0400();
/*  Perform the toggle! */
return;
/* ****************************************************** */
}
void L0400() {
/*   Perform a toggle                               * */
/* ****************************************************** */
STUDENT_ID = STUDENT_LIST[1, TOGGLE_POS];
OFFSET = MOD(TOGGLE_POS, (WINDOW_DEPTH - 1));
if (OFFSET == 0) { OFFSET = (WINDOW_DEPTH - 1); }
TOGGLE_ROW = TOP_WINDOW + OFFSET + 1;
PRINT(AT(RIGHT_WINDOW, TOGGLE_ROW) + NRM_VID);
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
COURSE_LINE = "";
COURSE_LINE = FORMAT(TOGGLE_POS, "R#3") + SPACE(2) + FORMAT(STUDENT_ID, "L#10");
COURSE_LINE = COURSE_LINE + FORMAT(FULL_NAME_LIST[1, TOGGLE_POS], "L#20") + SPACE(2) + FORMAT((COURSE_DESC_LIST[1, TOGGLE_POS] + "(" + COURSE_CODE_LIST[1, TOGGLE_POS] + ")"), "L#42");
if (STUDENT_SELECT_LIST[1, TOGGLE_POS] == TRUE) {
PRINT(AT(78, TOGGLE_ROW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOGGLE_ROW) + REV_VID);
} else {
PRINT(AT(LEFT_WINDOW - 1, TOGGLE_ROW) + NRM_VID);
}
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + FORMAT(COURSE_LINE, WINDOW_JUST));
}
}
return;
/* ********************************* */
L1000:;
/*  Display last line message  * */
/* ********************************* */
INTERACT = INVALID_DATA;
PRINT(AT(79, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW + 1));
return;
}
}
}
