//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL723 : UvBase
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
readonly UvVar SURNAME = 1;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_SCREENS = 8;
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
readonly UvVar FL_MEMBERS = 2;
readonly UvVar MEMBER_CENTRE = 1;
readonly UvVar MEMBER_TYPE = 2;
readonly UvVar MEMBER_ORIG_PRICE = 3;
readonly UvVar MEMBER_SURNAMES = 4;
readonly UvVar MEMBER_INITIALS = 5;
readonly UvVar MEMBER_TITLES = 6;
readonly UvVar MEMBER_SEXES = 7;
readonly UvVar MEMBER_AGES = 8;
readonly UvVar MEMBER_RENEW_LETTER = 9;
readonly UvVar MEMBER_SALUTATION = 9;
readonly UvVar MEMBER_ADDRESS = 10;
readonly UvVar MEMBER_HOME_PHONE = 11;
readonly UvVar MEMBER_BUS_PHONE = 12;
readonly UvVar MEMBER_EXPIRY_DATE = 13;
readonly UvVar MEMBER_DATE_JOINED = 14;
readonly UvVar MEMBER_ISSUING_OPER = 15;
readonly UvVar MEMBER_ANALYSIS_CODES = 16;
readonly UvVar MEMBER_USED_CODES = 17;
readonly UvVar MEMBER_MAIN = 18;
readonly UvVar MEMBER_SUB = 19;
readonly UvVar MEMBER_RECEIPT = 20;
readonly UvVar MEMBER_DOBS = 21;
readonly UvVar MEMBER_LAST_CHANGED = 22;
readonly UvVar MEMBER_HF_CARD_DATE = 23;
readonly UvVar MEMBER_INSTALMENTS = 24;
readonly UvVar MEMBER_FULL_EXPIRY = 25;
readonly UvVar MEMBER_REMINDER_DATES = 26;
readonly UvVar MEMBER_RESTRICTIONS = 27;
readonly UvVar MEMBER_DIRECT_DEBIT = 28;
readonly UvVar MEMBER_FORENAMES = 29;
readonly UvVar MEMBER_COMMENTS = 30;
readonly UvVar MEMBER_PART_COMPLETE = 31;
readonly UvVar MEMBER_START_DATE = 32;
readonly UvVar MEMBER_RENEWAL_DATE = 33;
readonly UvVar MEMBER_DD_DAY = 34;
readonly UvVar MEMBER_PRICES = 35;
readonly UvVar MEMBER_WEB_BARRED = 36;
readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
readonly UvVar MEMBER_EMAIL_SALES = 38;
readonly UvVar MEMBER_DDFLAGS = 39;
readonly UvVar MEMBER_OLDNOS = 40;
readonly UvVar MEMBER_PROSPECT_NO = 41;
readonly UvVar MEMBER_APACS_NO = 42;
readonly UvVar MEMBER_MOBILE_PHONE = 43;
readonly UvVar MEMBER_JOB_TITLE = 44;
readonly UvVar MEMBER_DEPARTMENT = 45;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] NAME_REC = new UvVar[3];
#endregion
#region Variables
UvVar STUDENT_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar MATCH_LIST = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar GO_BACK = "";
UvVar SC_POS = "";
UvVar COLOR_C = "";
UvVar VM = "";
UvVar NAME = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_DETAILS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
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
FL006 FL006;
UvVar STUDENT_LIST = "";
UvVar MATCH_COUNT = "";
UvVar CODES_FOUND = "";
UvVar SELECTION_CRITERIA = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar CC = "";
UvVar ID = "";
UvVar WAIT = "";
UvVar FIELD_NO = "";
UvVar ST_ROW = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_LENGTH = "";
UvVar VALUE = "";
UvVar ST_ATT = "";
UvVar ANS = "";
UvVar ST_CONVERSION = "";
UvVar CONV_ANS = "";
UvVar ST_JUST = "";
UvVar UPPER_CASE_SURNAME = "";
UvVar LOWER_CASE_SURNAME = "";
UvVar SENTENCE_CASE_SURNAME = "";
UvVar PREFIX = "";
UvVar DESC_COL = "";
UvVar ST_DESC = "";
UvVar AMC = "";
UvVar STUDENT_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar CURRENT_COURSES = "";
UvVar NO_OF_COURSES = "";
UvVar FOUND_ONE = "";
UvVar COURSE_COUNT = "";
UvVar DETAIL_ID = "";
UvVar END_DATE = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar ADDRESS_LINE1 = "";
UvVar DISPLAY_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL723(ref UvVar STUDENT_ID, ref UvVar INTERACT, ref UvVar REDISPLAY, ref UvVar MATCH_LIST) {
this.STUDENT_ID = STUDENT_ID;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
this.MATCH_LIST = MATCH_LIST;
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
/*     STUDENT NAME SEARCH */
PROGRAM = "FL723";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
STUDENT_ID = "";
MAT(ref NAME_REC, "");
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

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
#region INCLUDE FL.FILES FL.MEMBERS

/*  DJA 14.8.01 Separate file includes for web bookings */
/*              (see FL.MEMBERS.VAR for field names) */
#region INCLUDE FL.FILES FL.MEMBERS.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.DIM

SIZE_OF_MEMBERS_REC = 45;
/*  Must keep in tandem */

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.VAR

/*  Hammersmith & Fulham - Membership Card production systems */
/*  Two tier reminder system */

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
FOOTER = " Select Student No. or <Return> to scroll ";
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
SC_POS = "";
}
STUDENT_LIST = "";
/*  Box heading */
if (MATCH_LIST == "") {
PRINT(AT(79, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
L2400();
/*  Display input prompts */
}
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 2) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
L3000();
/*  Display data portion of window */
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
/*  DJA 25.4.02 */
MATCH_COUNT = DCOUNT(MATCH_LIST, VM);
if (MATCH_COUNT >= 1) {
STUDENT_LIST = MATCH_LIST;
} else {
CODES_FOUND = FALSE;
do {
if (INTERACT == EXIT || CODES_FOUND) break;
SELECTION_CRITERIA = "";
L2000();
/*  Get selection criteria */
if (SELECTION_CRITERIA == "") {
INSTRUCTION = "SSELECT FL.STUDENTS BY 3";
} else {
INSTRUCTION = "SSELECT FL.STUDENTS BY 3 " + SELECTION_CRITERIA;
}
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
CC = CC + 1;
STUDENT_LIST[1, CC] = ID;
} while (true);
if (CC == 0) {
/*  No courses meet the criteria */
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
L2400();
/*  Redisplay input prompts */
} else {
CODES_FOUND = TRUE;
}
} while (true);
}
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
PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(FOOTER, WINDOW_JUST));
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
STUDENT_ID = STUDENT_LIST[1, WAIT];
if (STUDENT_ID == "") {
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
void L2000() {
/*   ASCERTAIN SELECTION CRITERIA                * */
/* *************************************************** */
FIELD_NO = 1;
ST_ROW = TOP_WINDOW + 1;
MAT(ref NAME_REC, "");
do {
FIELD_DATA = SC_POS[FIELD_NO];
if (!(FIELD_DATA != "" && INTERACT != EXIT)) break;
L2200();
PRINT(AT(1, ST_ROW) + COLOR_C);
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
VALUE = NAME_REC[ST_ATT];
INPUT(out ANS, ST_LENGTH);
if (ST_CONVERSION != "") {
CONV_ANS = ICONV(ANS, ST_CONVERSION);
} else {
CONV_ANS = "";
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.CLR) {
ANS = "";
VALUE = "";
NAME_REC[ST_ATT] = "";
INTERACT = VALID_DATA;
FIELD_NO = FIELD_NO + 1;
}// CASE
else if (ANS == GO_BACK) {
if (VALUE == "") {
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
} else {
PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
}
FIELD_NO = FIELD_NO - 1;
if (FIELD_NO < 1) { FIELD_NO = 1; }
INTERACT = BACKUP;
}// CASE
else if (ST_CONVERSION != "" && ANS != "" && CONV_ANS == "") {
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
if (ST_CONVERSION != "") {
ANS = OCONV(VALUE, ST_CONVERSION);
} else {
ANS = VALUE;
}
FIELD_NO = FIELD_NO + 1;
}// CASE
else if (ANS == "") {
INTERACT = VALID_DATA;
FIELD_NO = FIELD_NO + 1;
}// CASE
else if (OTHERWISE) {
/*  Further validation for 'code' fields */
INTERACT = VALID_DATA;
if (INTERACT == VALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
}
// END CASE
if (INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
VALUE = ANS;
PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
}
NAME_REC[ST_ATT] = VALUE;
}
} while (true);
if (INTERACT != EXIT) {
/*  DJA 9.8.01 Cater for sentence-case membership records */
UPPER_CASE_SURNAME = OCONV(NAME_REC[SURNAME], "MCU");
LOWER_CASE_SURNAME = OCONV(NAME_REC[SURNAME], "MCL");
SENTENCE_CASE_SURNAME = OCONV(LOWER_CASE_SURNAME.Substring(1, 1), "MCU") + LOWER_CASE_SURNAME.Substring(2, 99);
PREFIX = " WITH";
if (NAME_REC[SURNAME] != "") {
SELECTION_CRITERIA = PREFIX + " SURNAME = \"[" + UPPER_CASE_SURNAME + "]\" OR WITH SURNAME = \"[" + SENTENCE_CASE_SURNAME + "]\"";
PREFIX = "";
}
}
return;
/* ************************************* */
}
void L2200() {
/*   Get field parameters          * */
/* ************************************* */
DESC_COL = FIELD_DATA[1, 1];
ST_DESC = FIELD_DATA[1, 3];
ST_COL = FIELD_DATA[1, 1] + 2 + LEN(ST_DESC);
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT = FIELD_DATA[1, 5];
ST_JUST = "L#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
return;
/* ***************************************************** */
}
void L2400() {
/*   Display selection criteria prompts            * */
/* ***************************************************** */
/*  Input fields line:- */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + COLOR_C);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT("", WINDOW_JUST));
AMC = 1;
do {
FIELD_DATA = SC_POS[AMC];
if (FIELD_DATA == "") break;
L2200();
/*  Get field parameters */
PRINT(AT(DESC_COL - 2, TOP_WINDOW + 1) + COLOR_C);
/* *PRINT @(2,TOP.WINDOW+1):COLOR.C: */
PRINT(AT(DESC_COL, TOP_WINDOW + 1) + ST_DESC);
PRINT(AT(ST_COL, TOP_WINDOW + 1) + STR(".", ST_LENGTH));
AMC = AMC + 1;
} while (true);
return;
/* *************************************************** */
}
void L3000() {
/*   Display data section of window              * */
/* *************************************************** */
STUDENT_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
STUDENT_ID = STUDENT_LIST[1, STUDENT_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 10) + NRM_VID);
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW - 1, CNT + 10) + COLOR_C);
PRINT(AT(LEFT_WINDOW, CNT + 10) + FORMAT("", WINDOW_JUST));
} else {
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
CURRENT_COURSES = "";
NO_OF_COURSES = DCOUNT(STUDENT_REC[STUDENT_DETAIL_IDS], VM);
FOUND_ONE = FALSE;
COURSE_COUNT = NO_OF_COURSES;
do {
if (COURSE_COUNT < 1 || FOUND_ONE == TRUE) break;
DETAIL_ID = STUDENT_REC[STUDENT_DETAIL_IDS][1, COURSE_COUNT];
if (READV(ref END_DATE, FL_COURSE_DETAILS, DETAIL_ID, 2)) {
if (END_DATE >= TODAYS_DATE) {
CURRENT_COURSES = CURRENT_COURSES + " " + FIELD(DETAIL_ID, "*", 2);
FOUND_ONE = TRUE;
}
}
COURSE_COUNT = COURSE_COUNT - 1;
} while (true);
CURRENT_COURSES = TRIM(CURRENT_COURSES);
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
} else {
NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
}
DISPLAY_LINE = FORMAT(STUDENT_NO, "R#4") + " " + FORMAT(STUDENT_ID, "L#8") + " " + FORMAT(NAME, "L#23") + " " + FORMAT(ADDRESS_LINE1, "L#25") + " " + FORMAT(CURRENT_COURSES, "L#11");
PRINT(AT(LEFT_WINDOW - 1, CNT + 10) + COLOR_C);
PRINT(AT(LEFT_WINDOW, CNT + 10) + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
STUDENT_NO = STUDENT_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
if (STUDENT_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (STUDENT_ID == "") {
STUDENT_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}
