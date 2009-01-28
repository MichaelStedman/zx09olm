//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL707 : UvBase
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
readonly UvVar FOUND = 7;
readonly UvVar NOT_FOUND = 8;
readonly UvVar DISPLAY_WINDOW = 0;
readonly UvVar INPUT_ALL = 1;
readonly UvVar INPUT_SINGLE = 2;
readonly UvVar LOAD_CODES = 3;
readonly UvVar REDISPLAY = 4;
readonly UvVar INSERT_SINGLE = 5;
readonly UvVar DELETE_SINGLE = 6;
readonly UvVar SCROLL = 7;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_BLOCK_HEADER = 87;
readonly UvVar BLOCK_SDESC = 1;
readonly UvVar BLOCK_STIME = 2;
readonly UvVar BLOCK_ETIME = 3;
readonly UvVar BLOCK_SPORT = 4;
readonly UvVar BLOCK_FLOORS1 = 5;
readonly UvVar BLOCK_FLOORS2 = 6;
readonly UvVar BLOCK_FLOORS3 = 7;
readonly UvVar BLOCK_DATES1 = 8;
readonly UvVar BLOCK_DATES2 = 9;
readonly UvVar BLOCK_DATES3 = 10;
readonly UvVar BLOCK_PRICE_REF = 11;
readonly UvVar BLOCK_LETTER = 12;
readonly UvVar BLOCK_INSTALL = 13;
readonly UvVar BLOCK_START = 14;
readonly UvVar BLOCK_FREQUENCY = 15;
readonly UvVar BLOCK_NO_INSTALLS = 16;
readonly UvVar BLOCK_NOTES = 17;
readonly UvVar BLOCK_DATE_MADE = 18;
readonly UvVar BLOCK_USER = 19;
readonly UvVar BLOCK_DEALER = 20;
readonly UvVar BLOCK_FLOORS4 = 21;
readonly UvVar BLOCK_FLOORS5 = 22;
readonly UvVar BLOCK_FLOORS6 = 23;
readonly UvVar BLOCK_FLOORS7 = 24;
readonly UvVar BLOCK_DATES4 = 25;
readonly UvVar BLOCK_DATES5 = 26;
readonly UvVar BLOCK_DATES6 = 27;
readonly UvVar BLOCK_DATES7 = 28;
readonly UvVar COURSE_MSTR_DESC = 1;
readonly UvVar COURSE_MSTR_DATES = 2;
readonly UvVar COURSE_MSTR_ACTIVITY_CODE = 3;
readonly UvVar COURSE_MSTR_CENTRE = 4;
readonly UvVar COURSE_MSTR_WET_DRY = 5;
readonly UvVar COURSE_MSTR_AWARD_CODE1 = 6;
readonly UvVar COURSE_MSTR_PAY_CODE = 7;
readonly UvVar COURSE_MSTR_AWARD_CODE2 = 8;
readonly UvVar COURSE_MSTR_AWARD_CODE3 = 9;
readonly UvVar COURSE_MSTR_AWARD_CODE4 = 10;
readonly UvVar COURSE_MSTR_TYPE = 11;
readonly UvVar COURSE_MSTR_WEB_TYPE = 12;
readonly UvVar COURSE_MSTR_WEB_BOOKABLE = 13;
readonly UvVar COURSE_MSTR_EXCEPTIONS = 14;
readonly UvVar ELEM_W = 1;
readonly UvVar ELEM_X = 2;
readonly UvVar ELEM_Y = 3;
readonly UvVar ELEM_DESCRIPTION = 4;
readonly UvVar ELEM_A = 5;
readonly UvVar ELEM_NO_OF_SUB_FIELDS = 6;
readonly UvVar ELEM_SUB_FIELD_1 = 7;
readonly UvVar ELEM_SUB_FIELD_2 = 8;
readonly UvVar ELEM_SUB_FIELD_3 = 9;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BLOCK_REC = new UvVar[30];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] TEMP_REC = new UvVar[50];
UvVar[] ELEMENT_REC = new UvVar[10];
#endregion
#region Variables
UvVar ACTION = "";
UvVar REQUESTED_LINE_NO = "";
UvVar DATA_FIELDS = "";
UvVar WINDOW_CODE_LIST = "";
UvVar START_LINE = "";
UvVar LINE_NO = "";
UvVar INTERACT = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
UvVar WINDOW = "";
UvVar PROGRAM = "";
UvVar FL_COURSE_MASTER = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar HEADING_TEXT = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar FOOTER = "";
UvVar WIDTH = "";
UvVar CLR_LINE = "";
UvVar JUST = "";
UvVar WINDOW_SIZE = "";
UvVar START_POS = "";
UvVar INSERT_MODE = "";
UvVar TEST_MV = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
UvVar MAX_FIELDS = "";
UvVar WINDOW_POS = "";
UvVar SUB_FIELD_NUMBER = "";
UvVar FIELD_DATA = "";
UvVar L0200_LINE_NO = "";
UvVar ST_AMENDABLE = "";
FL006 FL006;
UvVar VALUE = "";
UvVar ST_ATT = "";
UvVar COURSE_DESC = "";
UvVar OLD_VALUE = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar ANS = "";
FL823 FL823;
UvVar COURSE_CODE = "";
UvVar STORED_FIELD_DATA = "";
UvVar STORED_L0200_LINE_NO = "";
UvVar ST_ICONVERSION = "";
UvVar CONV_ANS = "";
UvVar ST_SUB_FIELDS = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar CNT = "";
UvVar DISP_LINE_NO = "";
UvVar END_LINE = "";
UvVar FIELD_NUMBER = "";
UvVar AMD_NO = "";
UvVar TEXT_COL = "";
UvVar TEXT_JUST = "";
UvVar TEXT = "";
UvVar ST_VCODE = "";
UvVar ELEM_NO = "";
UvVar J = "";
UvVar POS = "";
UvVar TEST_REC = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL707(ref UvVar ACTION, ref UvVar[] TEMP_REC, ref UvVar REQUESTED_LINE_NO, ref UvVar DATA_FIELDS, ref UvVar WINDOW_CODE_LIST, ref UvVar START_LINE, ref UvVar LINE_NO, ref UvVar INTERACT) {
this.ACTION = ACTION;
this.TEMP_REC = TEMP_REC;
this.REQUESTED_LINE_NO = REQUESTED_LINE_NO;
this.DATA_FIELDS = DATA_FIELDS;
this.WINDOW_CODE_LIST = WINDOW_CODE_LIST;
this.START_LINE = START_LINE;
this.LINE_NO = LINE_NO;
this.INTERACT = INTERACT;
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
/*     ENTER DOCUMENT DETAILS IN SCROLLING WINDOW�33 */
PROGRAM = "FL707";
/* ***************************** */
/*   DEFINE FILES USED PROGRAM * */
/* ***************************** */
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
/* ******************************* */
/*     ASSIGN ELEMENT CONSTANTS  * */
/* ******************************* */
ELEMENT_REC[ELEM_W] = "W";
ELEMENT_REC[ELEM_X] = 34;
ELEMENT_REC[ELEM_Y] = 0;
ELEMENT_REC[ELEM_DESCRIPTION] = "";
ELEMENT_REC[ELEM_A] = "A";
ELEMENT_REC[ELEM_NO_OF_SUB_FIELDS] = 2;
ELEMENT_REC[ELEM_SUB_FIELD_1] = "";
ELEMENT_REC[ELEM_SUB_FIELD_1][1, 1] = 33;
ELEMENT_REC[ELEM_SUB_FIELD_1][1, 3] = 11;
ELEMENT_REC[ELEM_SUB_FIELD_1][1, 4] = "L";
ELEMENT_REC[ELEM_SUB_FIELD_1][1, 8] = 12;
ELEMENT_REC[ELEM_SUB_FIELD_2] = "";
ELEMENT_REC[ELEM_SUB_FIELD_2][1, 1] = 68;
ELEMENT_REC[ELEM_SUB_FIELD_2][1, 3] = 9;
ELEMENT_REC[ELEM_SUB_FIELD_2][1, 4] = "L";
ELEMENT_REC[ELEM_SUB_FIELD_2][1, 8] = 13;
/* ****************************** */
/*   Main Processing Section    * */
/* ****************************** */
if (!READ(ref WINDOW, COMMON.FILES[FL_CONTROL], "FL707.WINDOW")) { STOP(); }
TOP_WINDOW = WINDOW[1] + 1;
BOTTOM_WINDOW = WINDOW[2] - 1;
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = 77;
HEADING_TEXT = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
FOOTER = "";
WIDTH = RIGHT_WINDOW - LEFT_WINDOW + 1;
CLR_LINE = SPACE(WIDTH - 4);
JUST = "L#" + WIDTH - 1;
WINDOW_SIZE = BOTTOM_WINDOW - TOP_WINDOW - 1;
LINE_NO = REQUESTED_LINE_NO - 10;
START_POS = "";
INSERT_MODE = FALSE;
// BEGIN CASE
// CASE
if (ACTION == SCROLL) {
/*  The mechanism used to scroll is to make 0500 think we need to amend */
/*  the last code on the next 'page'.  This will cause a full redisplay */
/*  (instead of a one-line scroll).  It is also necessary to check that */
/*  there will be at lease one line of data on the next 'page'.  If not, */
/*  start back at page one. */
LINE_NO = START_LINE + (2 * WINDOW_SIZE) + 1;
TEST_MV = LINE_NO - WINDOW_SIZE;
if (TEMP_REC[12][1, TEST_MV] == "") {
LINE_NO = 1;
}
L0500();
}// CASE
else if (ACTION == DISPLAY_WINDOW) {
L0100();
}// CASE
else if (ACTION == INPUT_ALL) {
AMENDING = FALSE;
START_POS = 1;
FIELD_NO = 1;
L0150();
FIELD_NO = 1;
L0020();
}// CASE
else if (ACTION == INPUT_SINGLE) {
AMENDING = TRUE;
L0500();
if (INTERACT == FOUND) { L0020(); }
}// CASE
else if (ACTION == INSERT_SINGLE) {
INSERT_MODE = TRUE;
L0500();
AMENDING = TRUE;
L0020();
}// CASE
else if (ACTION == DELETE_SINGLE) {
TEMP_REC[12] = DELETE(TEMP_REC[12], 1, LINE_NO, 0);
TEMP_REC[13] = DELETE(TEMP_REC[13], 1, LINE_NO, 0);
START_POS = LINE_NO;
L0150();
}// CASE
else if (ACTION == LOAD_CODES) {
L0010();
}// CASE
else if (ACTION == REDISPLAY) {
START_POS = 1;
L0150();
}
// END CASE
return;
/* ******************************* */
}
void L0010() {
/*   Load R.V. Element Codes * */
/* ******************************* */
DATA_FIELDS = INIT;
MAX_FIELDS = 0;
START_LINE = 1;
START_POS = 1;
WINDOW_POS = 1;
L0400();
/*      GOSUB 0150 ; * Display codes in window */
return;
/* ********************************************** */
}
void L0020() {
/*   Get User input for all/single code(s)  * */
/* ********************************************** */
MAX_FIELDS = 999;
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == FINISH) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (INTERACT == BACKUP && SUB_FIELD_NUMBER > 1) {
SUB_FIELD_NUMBER = SUB_FIELD_NUMBER - 1;
}// CASE
else if (FIELD_NO == MAX_FIELDS) {
INTERACT = FINISH;
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
INTERACT = FINISH;
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (INTERACT != EXIT) { INTERACT = INVALID_DATA; }
return;
/* ****************************** */
}
void L0060() {
/*   Standard Input Routine * */
/* ****************************** */
LINE_NO = FIELD_NO;
FIELD_DATA = DATA_FIELDS[1];
if (INTERACT != BACKUP) {
SUB_FIELD_NUMBER = 1;
}
INTERACT = INVALID_DATA;
L0200_LINE_NO = LINE_NO;
L0200();
/*  Set-up input/display parameters */
L0500();
do {
L0200_LINE_NO = LINE_NO;
L0200();
// BEGIN CASE
// CASE
if (ST_AMENDABLE == "N") {
if (AMENDING) { nrf0 = 3;nrf1 = INIT;FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1); }
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
VALUE = TEMP_REC[ST_ATT][1, LINE_NO];
if (SUB_FIELD_NUMBER == 1) {
if (!READV(ref COURSE_DESC, FL_COURSE_MASTER, VALUE, 1)) { COURSE_DESC = ""; }
}
OLD_VALUE = VALUE;
INTERACT = INVALID_DATA;
do {
/* *PRINT @(ST.COL-1,ST.ROW):COLOR.C: */
PRINT(AT(LEFT_WINDOW - 1, ST_ROW) + COLOR_C);
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
INPUT(out ANS, ST_LENGTH);
if (ANS == COMMON.HELP) {
if (SUB_FIELD_NUMBER == 1) {
nrf0 = REDISPLAY;
FL823 = new FL823(ref COURSE_CODE, ref INTERACT, ref nrf0);
STORED_FIELD_DATA = FIELD_DATA;
STORED_L0200_LINE_NO = L0200_LINE_NO;
/* !*                 STORED.FIELD.NO = FIELD.NO */
if (START_POS == "") { START_POS = 1; }
L0100();
L0150();
FIELD_DATA = STORED_FIELD_DATA;
/* !*                 FIELD.NO = STORED.FIELD.NO */
/* !*                 LINE.NO  = FIELD.NO */
L0200_LINE_NO = STORED_L0200_LINE_NO;
L0200();
PRINT(AT(ST_COL, ST_ROW));
if (INTERACT != EXIT) { ANS = COURSE_CODE; }
}
}
if (!(ANS == COMMON.HELP)) break;
} while (true);
if (ST_ICONVERSION != "") {
CONV_ANS = ICONV(ANS, ST_ICONVERSION);
} else {
CONV_ANS = ANS;
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK) {
if (SUB_FIELD_NUMBER == 1) {
MAX_FIELDS = FIELD_NO;
INTERACT = FINISH;
AMENDING = TRUE;
} else {
INTERACT = BACKUP;
}
}// CASE
else if (ANS == COMMON.SKIP) {
do {
if (DATA_FIELDS[1, SUB_FIELD_NUMBER + 6, 10] != "" || FIELD_NO > MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
}// CASE
else if (ANS == COMMON.CLR && SUB_FIELD_NUMBER == 1) {
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.CLR) {
VALUE = "";
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && SUB_FIELD_NUMBER == 1) {
SUB_FIELD_NUMBER = ST_SUB_FIELDS;
MAX_FIELDS = FIELD_NO;
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
VALUE = CONV_ANS;
#region ON SUB_FIELD_NUMBER GOSUB ...
switch ((int)SUB_FIELD_NUMBER) {
case 1: L1000(); break;
case 2: L1100(); break;
}
#endregion
}
// END CASE
if (ST_CONVERSION != "") {
PRINT(AT(LEFT_WINDOW - 1, ST_ROW) + COLOR_C);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(AT(LEFT_WINDOW - 1, ST_ROW) + COLOR_C);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
}
if (SUB_FIELD_NUMBER == 1) {
PRINT(SPACE(1) + FORMAT(COURSE_DESC, "L#22"));
}
// BEGIN CASE
// CASE
if (ANS != "" && (INTERACT == VALID_DATA || INTERACT == LIMIT)) {
TEMP_REC[ST_ATT][1, LINE_NO] = VALUE;
}
// END CASE
}
// END CASE
if ((SUB_FIELD_NUMBER >= ST_SUB_FIELDS && INTERACT != INVALID_DATA) || INTERACT == FINISH || INTERACT == BACKUP || INTERACT == EXIT) break;
if (INTERACT == VALID_DATA) {
SUB_FIELD_NUMBER = SUB_FIELD_NUMBER + 1;
}
} while (true);
return;
/* ********************************* */
}
void L0100() {
/*   Display Window Boundaries * */
/* ********************************* */
PRINT(AT(79, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
CNT = 0;
do {
CNT = CNT + 1;
if (CNT > WINDOW_DEPTH) break;
PRINT(AT(79, TOP_WINDOW + CNT) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + CNT) + COLOR_C);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + CNT) + FORMAT("", WINDOW_JUST));
} while (true);
PRINT(AT(79, TOP_WINDOW + CNT) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + CNT) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + CNT) + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), TOP_WINDOW + CNT));
return;
/* **************************** */
}
void L0150() {
/*   Display Window Data  * */
/* **************************** */
SUB_FIELD_NUMBER = 1;
DISP_LINE_NO = START_POS;
END_LINE = START_LINE + WINDOW_SIZE;
ST_ROW = BOTTOM_WINDOW;
do {
if (DISP_LINE_NO > END_LINE) break;
FIELD_NUMBER = DISP_LINE_NO;
FIELD_DATA = DATA_FIELDS[1];
L0200_LINE_NO = DISP_LINE_NO;
L0200();
AMD_NO = FORMAT(DISP_LINE_NO + 99, "R#3");
PRINT(AT(TEXT_COL - 7, ST_ROW) + COLOR_C);
PRINT(AT(TEXT_COL - 6, ST_ROW) + " " + AMD_NO);
TEXT_JUST = "L#" + 74 - TEXT_COL;
PRINT(AT(TEXT_COL, ST_ROW) + FORMAT(TEXT, TEXT_JUST));
for(SUB_FIELD_NUMBER = 1; SUB_FIELD_NUMBER <= ST_SUB_FIELDS; SUB_FIELD_NUMBER += 1) {
L0200_LINE_NO = DISP_LINE_NO;
L0200();
PRINT(AT(ST_COL, ST_ROW));
VALUE = TEMP_REC[ST_ATT][1, DISP_LINE_NO];
if (VALUE != "") {
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
if (SUB_FIELD_NUMBER == 1) {
if (!READV(ref COURSE_DESC, FL_COURSE_MASTER, VALUE, 1)) { COURSE_DESC = ""; }
PRINT(SPACE(1) + FORMAT(COURSE_DESC, "L#22"));
}
}
} else {
PRINT(FORMAT("", ST_JUST));
}
}
DISP_LINE_NO = DISP_LINE_NO + 1;
} while (true);
ST_ROW = ST_ROW + 1;
if (ST_ROW < BOTTOM_WINDOW) {
do {
if (ST_ROW > BOTTOM_WINDOW - 1) break;
PRINT(AT(LEFT_WINDOW + 2, ST_ROW) + CLR_LINE);
ST_ROW = ST_ROW + 1;
} while (true);
}
SUB_FIELD_NUMBER = 1;
return;
/* *************************** */
}
void L0200() {
/*   Extract Field Data  * */
/* *************************** */
TEXT_COL = FIELD_DATA[1, 2];
TEXT = FIELD_DATA[1, 4];
ST_SUB_FIELDS = FIELD_DATA[1, 6];
ST_COL = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 1];
ST_ROW = L0200_LINE_NO - START_LINE + TOP_WINDOW + 1;
ST_LENGTH = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 3];
ST_JUST = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 4] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 5];
ST_AMENDABLE = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 6];
ST_VCODE = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 7];
ST_ATT = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 8];
ST_ICONVERSION = FIELD_DATA[1, SUB_FIELD_NUMBER + 6, 9];
if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
return;
/* ******************************************** */
}
void L0400() {
/*   Insert an Element code into the list * */
/* ******************************************** */
FIELD_NO = WINDOW_POS;
if (INSERT_MODE) {
TEMP_REC[12] = INSERT(TEMP_REC[12], 1, WINDOW_POS, 0, "");
TEMP_REC[13] = INSERT(TEMP_REC[13], 1, WINDOW_POS, 0, "");
INSERT_MODE = FALSE;
}
DATA_FIELDS[FIELD_NO, 1] = ELEMENT_REC[1];
DATA_FIELDS[FIELD_NO, 2] = ELEMENT_REC[2];
DATA_FIELDS[FIELD_NO, 3] = ELEMENT_REC[3];
DATA_FIELDS[FIELD_NO, 4] = ELEMENT_REC[4];
DATA_FIELDS[FIELD_NO, 5] = ELEMENT_REC[5];
DATA_FIELDS[FIELD_NO, 6] = ELEMENT_REC[6];
for(ELEM_NO = 1; ELEM_NO <= ELEMENT_REC[6]; ELEM_NO += 1) {
for(J = 1; J <= 9; J += 1) {
DATA_FIELDS[FIELD_NO, ELEM_NO + 6, J] = ELEMENT_REC[ELEM_NO + 6][1, J];
}
}
return;
/* ******************************************** */
}
void L0500() {
/*   Determine position of Code in window * */
/* ******************************************** */
INTERACT = FOUND;
WINDOW_POS = LINE_NO;
if (INSERT_MODE) {
L0400();
if (WINDOW_POS >= START_LINE && WINDOW_POS <= START_LINE + WINDOW_SIZE) {
START_POS = WINDOW_POS;
L0150();
}
}
if (WINDOW_POS < START_LINE || WINDOW_POS > START_LINE + WINDOW_SIZE) {
START_LINE = WINDOW_POS - WINDOW_SIZE;
if (START_LINE < 1) { START_LINE = 1; }
START_POS = START_LINE;
L0150();
}
FIELD_NO = WINDOW_POS;
return;
}
void L1000() {
/*  Course Code Validation Routine */
if (READV(ref COURSE_DESC, FL_COURSE_MASTER, ANS, 1)) {
if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_TYPE], FL_COURSE_MASTER, ANS, 11)) { COURSE_MSTR_REC[COURSE_MSTR_TYPE] = ""; }
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "") {
/*  Check this course has not already been nominated */
if (LOCATE(ANS, TEMP_REC[12], 1, 0, 1, ref POS, "AL")) {
if (POS != LINE_NO) {
INTERACT = INVALID_DATA;
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_DESC = "";
} else {
INTERACT = VALID_DATA;
}
} else {
INTERACT = VALID_DATA;
}
} else {
nrf0 = 45;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
COURSE_DESC = "";
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_DESC = "";
}
return;
}
void L1100() {
/*  Block Book Ref Validation Routine */
// BEGIN CASE
// CASE
if (ANS == "") {
/*  Field is optional */
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
if (READ(ref TEST_REC, COMMON.FILES[FL_BLOCK_HEADER], ANS)) {
INTERACT = VALID_DATA;
} else {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
// END CASE
return;
/*     END OF PROGRAM */
}
}
}
