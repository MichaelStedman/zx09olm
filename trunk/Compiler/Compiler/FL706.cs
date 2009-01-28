//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL706 : UvBase
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
readonly UvVar DISPLAY_WINDOW = 0;
readonly UvVar INPUT_ALL = 1;
readonly UvVar INPUT_SINGLE = 2;
readonly UvVar LOAD_CODES = 3;
readonly UvVar REDISPLAY = 4;
readonly UvVar INSERT_SINGLE = 5;
readonly UvVar DELETE_SINGLE = 6;
readonly UvVar SCROLL = 7;
readonly UvVar SCREENS = 8;
readonly UvVar SCHED_START = 1;
readonly UvVar SCHED_END = 2;
readonly UvVar SCHED_BOOKING_DATES = 3;
readonly UvVar SCHED_CLOSE_DATE = 4;
readonly UvVar SCHED_COURSE_CODES = 5;
readonly UvVar SCHED_BLOCK_REFS = 6;
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
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] SCHEDULE_REC = new UvVar[15];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar NEW_SCHEDULE = "";
UvVar TERMINAL_TYPE = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar GO_BACK = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar JUST = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_SCHEDULES = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar ATT = "";
UvVar BLANK_LEVEL_FOUND = "";
UvVar SCREEN_ATT = "";
UvVar ATT2 = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar REQUESTED_LINE_NO = "";
UvVar START_LINE = "";
UvVar FL707_DATA_FIELDS = "";
UvVar AMENDING = "";
FL707 FL707;
UvVar WINDOW_CODE_LIST = "";
UvVar CODE_POS = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar ST_ATT = "";
UvVar START_FIELD_NO = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar OK_TO_SELECT = "";
UvVar SELECTED_MV = "";
UvVar PREVIOUS_MV = "";
FL006 FL006;
UvVar OK_TO_FILE = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar PROMPT_NO = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
FL720 FL720;
UvVar COURSE_DATE = "";
UvVar COURSE_MVC = "";
UvVar OK_TO_PROCEED = "";
UvVar COURSE_CODE = "";
UvVar DATE_POS = "";
UvVar DETAILS_ID = "";
UvVar PREVIOUS_COURSE_DATE = "";
UvVar PREVIOUS_DETAILS_ID = "";
UvVar MVC = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL706(ref UvVar[] SCHEDULE_REC, ref UvVar NEW_SCHEDULE) {
this.SCHEDULE_REC = SCHEDULE_REC;
this.NEW_SCHEDULE = NEW_SCHEDULE;
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
/*     SCHEDULE MAINTENANCE (NEW MODULE) */
PROMPT("");
PROGRAM = "FL706";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.SCHEDULES

if (!OPEN("FL.SCHEDULES", out FL_SCHEDULES)) { STOP("201", "FL.SCHEDULES"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
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
MAT(ref TEMP_REC, "");
/* ************************************ */
/*   GET SCREEN DEFINITION ITEM       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
if (MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "COURSE.BOOKING.LEVELS")) {
ATT = 1;
BLANK_LEVEL_FOUND = FALSE;
do {
if (!(ATT <= 8 && NOT(BLANK_LEVEL_FOUND))) break;
if (COURSE_PARAM_REC[ATT] == "") {
BLANK_LEVEL_FOUND = TRUE;
} else {
SCREEN_ATT = 10 + ((ATT * 2) - 1);
SC_POS[SCREEN_ATT, 3] = FORMAT(COURSE_PARAM_REC[ATT], "L#8");
}
if (NOT(BLANK_LEVEL_FOUND)) { ATT = ATT + 1; }
} while (true);
if (BLANK_LEVEL_FOUND) {
for(ATT2 = ATT; ATT2 <= 8; ATT2 += 1) {
SCREEN_ATT = 10 + ((ATT2 * 2) - 1);
SC_POS[SCREEN_ATT, 3] = FORMAT("", "L#8");
}
}
WRITE(SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE);
}
/*  Changed for centralised course parameters :- */
DELETE(COMMON.FILES[SCREENS], ("$" + SCREEN_CODE + "*" + TERMINAL_TYPE));
/* ********************************** */
/*   EXTRACT DATA INPUT FIELDS      * */
/* ********************************** */
MAX_FIELDS = 0;
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = "";
do {
LINE = SC_POS[SCREEN_LINES + 1];
if (LINE == "") break;
if (LINE[1, 4] != "") {
MAX_FIELDS = MAX_FIELDS + 1;
if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0) {
FIRST_FIELD = MAX_FIELDS;
}
DATA_FIELDS[MAX_FIELDS] = LINE;
}
SCREEN_LINES = SCREEN_LINES + 1;
} while (true);
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
REQUESTED_LINE_NO = "";
START_LINE = 1;
FL707_DATA_FIELDS = INIT;
L0100();
AMENDING = FALSE;
nrf0 = LOAD_CODES;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
if (PROG_MESS[2] != "") {
MAIN_KEY = PROG_MESS[2];
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
L0300();
/*  Display data */
} else {
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
}
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
// BEGIN CASE
// CASE
if (ST_ATT == 0) {
FIELD_NO = FIELD_NO + 1;
}// CASE
else if (AMENDING == FALSE && INTERACT == VALID_DATA && TEMP_REC[ST_ATT] == "" && (ST_ATT >= 3 && ST_ATT <= 9)) {
START_FIELD_NO = FIELD_NO + 1;
for(FIELD_NO = START_FIELD_NO; FIELD_NO <= 11; FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
}
FIELD_NO = 12;
}// CASE
else if (OTHERWISE) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (FIELD_NO == MAX_FIELDS) {
if (NOT(AMENDING)) {
nrf0 = INPUT_ALL;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
if (INTERACT != EXIT) { L0050(); }
} else {
L0050();
}
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (MAIN_KEY != "" && INTERACT != EXIT) {
/*  Transfer data out of TEMP.REC */
L9000();
}
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (INTERACT == EXIT) { PROG_MESS[1] = COMMON.ABANDON; }
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
INPUT_LINE = " Field, 'Dn' to delete, <RET> to scroll, 'C'reate, 'U'ndo or 'F'ile ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 5);
PRINT(AT(2, 21) + SPACE(74));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == "") {
nrf0 = SCROLL;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "C") {
L0055();
if (INTERACT == FINISH) {
/*  Confirm user wants to create this batch of courses */
L7000();
if (INTERACT == FINISH) {
PROG_MESS[1] = "";
} else {
/*  Reprompt for action */
INTERACT = INVALID_DATA;
}
}
}// CASE
else if (ANS == "U") {
L0055();
if (INTERACT == FINISH) {
/*  Confirm user wants to delete this batch of courses */
L6000();
if (INTERACT == FINISH) {
PROG_MESS[1] = "";
} else {
/*  Reprompt for action */
INTERACT = INVALID_DATA;
}
}
}// CASE
else if (ANS == "F") {
L0055();
if (INTERACT == FINISH) {
PROG_MESS[1] = "";
}
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
L0055();
if (INTERACT == FINISH) {
PROG_MESS[1] = ANS.Substring(2, 1);
}
}// CASE
else if (ANS.Substring(1, 1) == "D" && ANS.Substring(2, 99) >= 100 && ANS.Substring(2, 99) <= 999) {
REQUESTED_LINE_NO = ANS.Substring(2, 99) - 89;
nrf0 = DELETE_SINGLE;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 100 && ANS <= 999) {
REQUESTED_LINE_NO = ANS - 89;
/*  Check this is an existing code or the next available one */
OK_TO_SELECT = TRUE;
SELECTED_MV = ANS - 99;
PREVIOUS_MV = SELECTED_MV - 1;
// BEGIN CASE
// CASE
if (SELECTED_MV == 1) {
NULL();
}// CASE
else if (TEMP_REC[12][1, SELECTED_MV] == "" && TEMP_REC[12][1, PREVIOUS_MV] == "") {
OK_TO_SELECT = FALSE;
}
// END CASE
if (OK_TO_SELECT) {
nrf0 = INPUT_SINGLE;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
} else {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ***************************************** */
}
void L0055() {
/*   Check its ok to file/update       * */
/* ***************************************** */
OK_TO_FILE = TRUE;
// BEGIN CASE
// CASE
if (TEMP_REC[1] > TEMP_REC[2]) {
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
OK_TO_FILE = FALSE;
}
// END CASE
if (OK_TO_FILE) {
INTERACT = FINISH;
}
return;
/* ******************************** */
}
void L0060() {
/*   DATA ENTRY ROUTINE       * */
/* ******************************** */
INTERACT = INVALID_DATA;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = TEMP_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == GO_BACK) {
INTERACT = BACKUP;
/*  Deal with default values for certain fields here */
}// CASE
else if (AMENDING == FALSE && ST_ATT == 11 && ANS == "" && VALUE == "") {
VALUE = TEMP_REC[2];
INTERACT = VALID_DATA;
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
}// CASE
else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "") {
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1200(); break;
case 3: L1300(); break;
case 4: L1500(); break;
case 5: L1500(); break;
case 6: L1500(); break;
case 7: L1500(); break;
case 8: L1500(); break;
case 9: L1500(); break;
case 10: L1500(); break;
case 11: L1500(); break;
case 12: L2300(); break;
}
#endregion
if (INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
}
}
// END CASE
PRINT(AT(ST_COL - 1, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
/* ******************************* */
}
void L0100() {
/*   DISPLAY SCREEN FORMAT  * */
/* ******************************** */
PROMPT_NO = 1;
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
for(PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1) {
PRINT(AT(79, PRINT_LINE) + NRM_VID);
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
}
/*  Display the page 1 window */
nrf0 = DISPLAY_WINDOW;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
return;
/* ********************************* */
}
void L0200() {
/*   EXTRACT FIELD DATA      * */
/* ********************************* */
ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
ST_ROW = FIELD_DATA[1, 2];
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT_MV = FIELD_DATA[1, 5];
ST_ATT = FIELD(ST_ATT_MV, ",", 1);
ST_MV = FIELD(ST_ATT_MV, ",", 2);
ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
ST_MANDATORY = FIELD_DATA[1, 10];
return;
/* ********************************* */
}
void L0300() {
/*   DISPLAY ITEM CONTENTS */
/* ********************************* */
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
/* *     IF DISP.ATT # 0 THEN */
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL - 2, DISP_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4] + 1;
DISP_CONVERSION = FIELD_DATA[1, 9];
// BEGIN CASE
// CASE
if (DISP_ATT == 0) {
PRINT(FORMAT(MAIN_KEY, DISP_JUST));
}// CASE
else if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
// END CASE
/* *     END */
}
nrf0 = REDISPLAY;
FL707 = new FL707(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL707_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1000() {
/*   Schedule Code Validation Routine */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
nrf0 = REDISPLAY;
FL720 = new FL720(ref ANS, ref INTERACT, ref nrf0);
L0100();
}
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
ANS = "";
MAIN_KEY = "";
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
PROG_MESS[2] = MAIN_KEY;
if (MATREADU(ref SCHEDULE_REC, FL_SCHEDULES, MAIN_KEY)) {
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
NEW_SCHEDULE = FALSE;
} else {
AMENDING = FALSE;
MAT(ref TEMP_REC, "");
NEW_SCHEDULE = TRUE;
}
if (INTERACT != INVALID_DATA) {
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
}
} else {
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINT(SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(0, 23) + FORMAT("", JUST));
}
}// CASE
else if (OTHERWISE) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}
// END CASE
return;
}
void L1200() {
/*   PERIOD START Validation Routine */
if (ICONV(ANS, "D") == "") {
/*  Invalid.date */
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
}
void L1300() {
/*   PERIOD END Validation Routine */
if (ICONV(ANS, "D") == "") {
/*  Invalid.date */
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
}
void L1500() {
/*   BOOKING LEVELS Validation Routine */
if (ICONV(ANS, "D") == "") {
/*  Invalid.date */
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
}
void L2300() {
/*   BOOKING CLOSING DATE */
if (ANS == "") {
VALUE = TEMP_REC[2];
/*  Course Start Date */
ANS = OCONV(VALUE, "D");
}
if (ICONV(ANS, "D") == "") {
/*  Invalid.date */
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
/* ******************************************************* */
}
void L6000() {
/*   Confirm user wants to delete courses and then   * */
/*       perform the updates                             * */
/* ******************************************************* */
INTERACT = INVALID_DATA;
do {
INPUT_LINE = " Are you sure you wish to delete the above course(s)? (Y/N) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(74));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "N") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "Y") {
L6500();
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ********************************************* */
}
void L6500() {
/*  Update processing                      * */
/* ********************************************* */
COURSE_DATE = TEMP_REC[1];
COURSE_MVC = 1;
OK_TO_PROCEED = TRUE;
do {
COURSE_CODE = TEMP_REC[12][1, COURSE_MVC];
if (COURSE_CODE == "" || OK_TO_PROCEED == FALSE) break;
/*  Check no enrolments have taken place */
if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) {
if (LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR")) {
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
if (COURSE_DET_REC[COURSE_DET_STUDENT_IDS] != "") {
nrf0 = 11;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
OK_TO_PROCEED = FALSE;
}
} else {
OK_TO_PROCEED = FALSE;
nrf0 = 12;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref COURSE_CODE);
}
} else {
OK_TO_PROCEED = FALSE;
nrf0 = 12;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref COURSE_CODE);
}
} else {
OK_TO_PROCEED = FALSE;
nrf0 = 13;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref COURSE_CODE);
}
COURSE_MVC = COURSE_MVC + 1;
} while (true);
INTERACT = VALID_DATA;
if (OK_TO_PROCEED) {
COURSE_MVC = 1;
do {
COURSE_CODE = TEMP_REC[12][1, COURSE_MVC];
if (COURSE_CODE == "") break;
if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
if (LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR")) {
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
DELETE(FL_COURSE_DETAILS, DETAILS_ID);
COURSE_MSTR_REC[COURSE_MSTR_DATES] = DELETE(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, DATE_POS, 0);
if (COURSE_MSTR_REC[COURSE_MSTR_DATES] == "") {
DELETE(FL_COURSE_MASTER, COURSE_CODE);
} else {
MATWRITE(COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE);
}
}
COURSE_MVC = COURSE_MVC + 1;
} while (true);
INPUT_LINE = " The above courses have been successfully deleted.  Press <RETURN>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(74));
INTERACT = FINISH;
}
return;
/* ******************************************************* */
}
void L7000() {
/*   Confirm user wants to create courses and then   * */
/*       perform the updates                             * */
/* ******************************************************* */
INTERACT = INVALID_DATA;
do {
INPUT_LINE = " Are you sure you wish to create the above courses? (Y/N) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(73));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "N") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "Y") {
L7500();
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ********************************************* */
}
void L7500() {
/*  Update processing                      * */
/* ********************************************* */
COURSE_DATE = TEMP_REC[1];
COURSE_MVC = 1;
OK_TO_PROCEED = TRUE;
do {
COURSE_CODE = TEMP_REC[12][1, COURSE_MVC];
if (COURSE_CODE == "" || OK_TO_PROCEED == FALSE) break;
/*  Check no duplicate course detail ids will be generated */
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
if (LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR")) {
nrf0 = 10;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref COURSE_CODE);
OK_TO_PROCEED = FALSE;
}
COURSE_MVC = COURSE_MVC + 1;
} while (true);
INTERACT = VALID_DATA;
if (OK_TO_PROCEED) {
COURSE_MVC = 1;
do {
COURSE_CODE = TEMP_REC[12][1, COURSE_MVC];
if (COURSE_CODE == "") break;
if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
if (!(LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR"))) {
/*  Base the detail record on the last course */
PREVIOUS_COURSE_DATE = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, 1];
PREVIOUS_DETAILS_ID = PREVIOUS_COURSE_DATE + "*" + COURSE_CODE;
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, PREVIOUS_DETAILS_ID)) { MAT(ref COURSE_DET_REC, ""); }
COURSE_MSTR_REC[COURSE_MSTR_DATES] = INSERT(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, DATE_POS, 0, COURSE_DATE);
COURSE_DET_REC[COURSE_DET_END] = TEMP_REC[2];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 1] = TEMP_REC[3];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 2] = TEMP_REC[4];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 3] = TEMP_REC[5];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 4] = TEMP_REC[6];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 5] = TEMP_REC[7];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 6] = TEMP_REC[8];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 7] = TEMP_REC[9];
COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 8] = TEMP_REC[10];
COURSE_DET_REC[COURSE_DET_CLOSE_DATE] = TEMP_REC[11];
COURSE_DET_REC[COURSE_DET_SCHEDULE_CODE] = MAIN_KEY;
COURSE_DET_REC[COURSE_DET_BLOCK_REF] = TEMP_REC[13][1, COURSE_MVC];
/*  Make maximum places available */
COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
for(MVC = 1; MVC <= 8; MVC += 1) {
COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, MVC] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, MVC];
}
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = "";
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
MATWRITE(COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE);
}
COURSE_MVC = COURSE_MVC + 1;
} while (true);
INPUT_LINE = " The above courses have been successfully created.  Press <RETURN>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(73));
INTERACT = FINISH;
}
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = SCHEDULE_REC[SCHED_START];
TEMP_REC[2] = SCHEDULE_REC[SCHED_END];
TEMP_REC[3] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 1];
TEMP_REC[4] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 2];
TEMP_REC[5] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 3];
TEMP_REC[6] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 4];
TEMP_REC[7] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 5];
TEMP_REC[8] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 6];
TEMP_REC[9] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 7];
TEMP_REC[10] = SCHEDULE_REC[SCHED_BOOKING_DATES][1, 8];
TEMP_REC[11] = SCHEDULE_REC[SCHED_CLOSE_DATE];
TEMP_REC[12] = SCHEDULE_REC[SCHED_COURSE_CODES];
TEMP_REC[13] = SCHEDULE_REC[SCHED_BLOCK_REFS];
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
SCHEDULE_REC[SCHED_START] = TEMP_REC[1];
SCHEDULE_REC[SCHED_END] = TEMP_REC[2];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 1] = TEMP_REC[3];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 2] = TEMP_REC[4];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 3] = TEMP_REC[5];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 4] = TEMP_REC[6];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 5] = TEMP_REC[7];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 6] = TEMP_REC[8];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 7] = TEMP_REC[9];
SCHEDULE_REC[SCHED_BOOKING_DATES][1, 8] = TEMP_REC[10];
SCHEDULE_REC[SCHED_CLOSE_DATE] = TEMP_REC[11];
SCHEDULE_REC[SCHED_COURSE_CODES] = TEMP_REC[12];
SCHEDULE_REC[SCHED_BLOCK_REFS] = TEMP_REC[13];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
