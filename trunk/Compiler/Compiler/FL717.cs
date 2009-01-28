//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL717 : UvBase
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
readonly UvVar ACTIVITY_CODE = 1;
readonly UvVar START_DATE = 3;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_SCREENS = 8;
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
readonly UvVar WAIT_MAST_IDS = 1;
readonly UvVar WAIT_MAST_STATUS = 2;
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
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
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
readonly UvVar MC_NAME = 1;
readonly UvVar MC_ACCOUNT = 2;
readonly UvVar MC_TELEPHONE = 3;
readonly UvVar MC_ADDRESS1 = 4;
readonly UvVar MC_ADDRESS2 = 5;
readonly UvVar MC_ADDRESS3 = 6;
readonly UvVar MC_ADDRESS4 = 7;
readonly UvVar MC_ADDRESS5 = 8;
readonly UvVar MC_VAT_NUMBER = 9;
readonly UvVar MC_NOTE1 = 10;
readonly UvVar MC_NOTE2 = 11;
readonly UvVar MC_NOTE3 = 12;
readonly UvVar MC_SHORT_NAME = 13;
readonly UvVar MC_WEB_BOOKABLE = 14;
readonly UvVar MC_WEB_ENROLMENT = 15;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] MASTER_CENTRE_REC = new UvVar[15];
UvVar[] ANALYSIS_REC = new UvVar[5];
#endregion
#region Variables
UvVar DISPLAY_MODE = "";
UvVar STUDENT_ID = "";
UvVar COURSE_ID = "";
UvVar COURSE_DATE = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar DIM_UND_VID = "";
UvVar GO_BACK = "";
UvVar SC_POS = "";
UvVar VM = "";
UvVar WINDOW_BACKGROUND_COLOR = "";
UvVar PROGRAM = "";
UvVar FF = "";
UvVar PRINTER_OUTPUT = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_MASTER_CENTRES = "";
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
UvVar HIDE_CLOSED = "";
UvVar SORT_CRITERIA = "";
UvVar CENTRALISED_COURSES = "";
UvVar CENTRE_SCAN = "";
UvVar BLOCK_FUTURE_COURSES = "";
UvVar DISPLAY_COURSE_CODES = "";
UvVar COURSE_CODE_LENGTH = "";
UvVar COLOUR_CODING = "";
UvVar EXACT_DATE = "";
UvVar IGNORE_VACANCIES = "";
UvVar ALL_CENTRES = "";
UvVar SELECTED_CENTRE = "";
UvVar CODE_LIST = "";
UvVar DATE_LIST = "";
UvVar DET_ID_LIST = "";
UvVar BALANCE_LIST = "";
UvVar OVERALL_BALANCE = "";
UvVar FIRST_WINDOW_DISPLAY = "";
UvVar FOOTER = "";
UvVar COURSE_IDS = "";
UvVar COURSE_LIST = "";
UvVar COURSE_CNT = "";
UvVar POS = "";
UvVar ID = "";
UvVar CC = "";
FL006 FL006;
UvVar HEAD_ROW = "";
UvVar CODES_FOUND = "";
UvVar SELECTION_CRITERIA = "";
UvVar INSTRUCTION = "";
UvVar WAIT = "";
UvVar TEST_REC = "";
UvVar COURSE_NO = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar FIELD_NO = "";
UvVar ST_ROW = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_LENGTH = "";
UvVar VALUE = "";
UvVar ST_ATT = "";
UvVar ANS = "";
FL721 FL721;
UvVar RETURNED_ANS = "";
UvVar CNT = "";
UvVar DISPLAY_LIMIT = "";
UvVar ST_CONVERSION = "";
UvVar CONV_ANS = "";
UvVar ST_JUST = "";
UvVar ACTIVITY_DESC = "";
UvVar PREFIX = "";
UvVar DESC_COL = "";
UvVar ST_DESC = "";
UvVar AMC = "";
UvVar TRANS_NO = "";
UvVar DET_ID = "";
UvVar DET_POS = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar NAME = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar COURSE_CODE = "";
UvVar DETAILS_ID = "";
UvVar DAY = "";
UvVar COURSE_LINE = "";
UvVar CONV_DATE = "";
UvVar WAIT_IDS = "";
UvVar WAIT_COUNT = "";
UvVar VAC_STRING = "";
UvVar THIS_BALANCE = "";
UvVar CODE_JUST = "";
UvVar DESC_JUST = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar DATE_COUNT = "";
UvVar DEAD_COURSE_REACHED = "";
UvVar SELECT_COURSE = "";
UvVar OK_TO_PROCEED = "";
UvVar LEVELS_ALLOWED = "";
UvVar LEVEL = "";
UvVar NO_LEVELS = "";
UvVar LEVEL_TEXT = "";
UvVar NO_LEVELS_ALLOWED = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL717(ref UvVar DISPLAY_MODE, ref UvVar STUDENT_ID, ref UvVar COURSE_ID, ref UvVar COURSE_DATE, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.DISPLAY_MODE = DISPLAY_MODE;
this.STUDENT_ID = STUDENT_ID;
this.COURSE_ID = COURSE_ID;
this.COURSE_DATE = COURSE_DATE;
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
/*     COURSE SCANNING */
WINDOW_BACKGROUND_COLOR = DIM_VID;
PROGRAM = "FL717";
INTERACT = INVALID_DATA;
COMMON.CLR = "\\";
COURSE_ID = "";
PRINTER_OUTPUT = FALSE;
/*  DISPLAY.MODE = 1     Course Maintenance */
/*  DISPLAY.MODE = 2     Course Enrolment */
/*  DISPLAY.MODE = 3     Course Payments */
/*  DISPLAY.MODE = 4     Course Refunds */
/*  DISPLAY.MODE = 5     Activity Day Maintenance */
/*  DISPLAY.MODE = 6     Activity Day Enrolment */
/*  DISPLAY.MODE = 7     Members List (all types) */
MAT(ref ANALYSIS_REC, "");
/* !*  EQU ABILITY.LEVEL    TO ANALYSIS.REC(2) */
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

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
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

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
#region INCLUDE FL.FILES FL.MASTER.CENTRES
#region INCLUDE FL.FILES FL.MASTER.CENTRES.EQU
if (!OPEN("FL.MASTER.CENTRES", out FL_MASTER_CENTRES)) { STOP("201", "FL.MASTER.CENTRES"); }

#endregion

#region INCLUDE FL.FILES FL.MASTER.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.MASTER.CENTRES.VAR

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
REDISPLAY = TOP_WINDOW;
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
// BEGIN CASE
// CASE
if (DISPLAY_MODE == 1 || DISPLAY_MODE == 5) {
HEADING_TEXT2 = WINDOW[6];
}// CASE
else if (DISPLAY_MODE == 3 || DISPLAY_MODE == 4) {
HEADING_TEXT2 = WINDOW[8];
}// CASE
else if (OTHERWISE) {
HEADING_TEXT2 = WINDOW[7];
}
// END CASE
if (!READV(ref HIDE_CLOSED, FL_COURSE_PARAMS, "COURSE.PARAMS", 14)) { HIDE_CLOSED = "N"; }
if (!READV(ref SORT_CRITERIA, FL_COURSE_PARAMS, "COURSE.PARAMS", 16)) { SORT_CRITERIA = ""; }
if (SORT_CRITERIA == "") {
SORT_CRITERIA = "BY 1";
} else {
SORT_CRITERIA = SORT_CRITERIA[1, 1];
}
if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
/*  DJA 17.4.03 Cater for unique SCSUM configuration at Ipswich */
if (!READV(ref CENTRE_SCAN, FL_COURSE_PARAMS, "FL717.CENTRE.SCAN", 1)) { CENTRE_SCAN = ""; }
if (!READV(ref BLOCK_FUTURE_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 27)) { BLOCK_FUTURE_COURSES = "N"; }
if (!READV(ref DISPLAY_COURSE_CODES, FL_COURSE_PARAMS, "COURSE.PARAMS", 45)) { DISPLAY_COURSE_CODES = "N"; }
if (!READV(ref COURSE_CODE_LENGTH, FL_COURSE_PARAMS, "COURSE.PARAMS", 46)) { COURSE_CODE_LENGTH = 11; }
if (NOT(MATCH(COURSE_CODE_LENGTH,"1N") || MATCH(COURSE_CODE_LENGTH,"2N"))) {
COURSE_CODE_LENGTH = 11;
}
if (!READV(ref COLOUR_CODING, FL_COURSE_PARAMS, "COURSE.PARAMS", 50)) { COLOUR_CODING = "N"; }
if (!READV(ref EXACT_DATE, FL_COURSE_PARAMS, "COURSE.PARAMS", 52)) { EXACT_DATE = "N"; }
if (!MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "COURSE.BOOKING.LEVELS")) { MAT(ref COURSE_PARAM_REC, ""); }
IGNORE_VACANCIES = FALSE;
ALL_CENTRES = FALSE;
SELECTED_CENTRE = "";
CODE_LIST = "";
DATE_LIST = "";
DET_ID_LIST = "";
BALANCE_LIST = "";
OVERALL_BALANCE = 0;
FIRST_WINDOW_DISPLAY = TRUE;
// BEGIN CASE
// CASE
if (DISPLAY_MODE == 2) {
FOOTER = " No, centre code, 'A'll centres, 'I'gnore vacs, 'P'rint or <Return> ";
}// CASE
else if (DISPLAY_MODE == 3 || DISPLAY_MODE == 4) {
/*  When display.mode is '3', only select courses the student is enrolled on */
/*  When its '4', only select courses they've EVER been enrolled on */
/*  Always show courses for all centres */
ALL_CENTRES = TRUE;
if (STUDENT_ID != "") {
if (DISPLAY_MODE == 3) {
if (!(READV(ref COURSE_IDS, FL_STUDENTS, STUDENT_ID, 22))) {
COURSE_IDS = "";
}
} else {
if (!(READV(ref COURSE_IDS, FL_STUDENTS, STUDENT_ID, 24))) {
COURSE_IDS = "";
}
}
} else {
COURSE_IDS = "";
}
FOOTER = " Course No, 'P'rint or <Return> to scroll ";
CODE_LIST = "";
DATE_LIST = "";
COURSE_LIST = "";
COURSE_CNT = 1;
do {
COURSE_ID = COURSE_IDS[1, COURSE_CNT];
if (COURSE_ID == "") break;
if (!(LOCATE(COURSE_ID, COURSE_LIST, 1, 0, 1, ref POS, "AL"))) {
COURSE_LIST = INSERT(COURSE_LIST, 1, 1, 0, COURSE_ID);
ID = FIELD(COURSE_ID, "*", 2);
COURSE_DATE = FIELD(COURSE_ID, "*", 1);
/*  Insert most recent courses at front of list, and therefore nearer the */
/*  top of the window */
CODE_LIST = INSERT(CODE_LIST, 1, 1, 0, ID);
DATE_LIST = INSERT(DATE_LIST, 1, 1, 0, COURSE_DATE);
}
COURSE_CNT = COURSE_CNT + 1;
} while (true);
CC = DCOUNT(COURSE_LIST, VM);
// BEGIN CASE
// CASE
if (CC == 0) {
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
}// CASE
else if (CC == 1) {
/*  Default to this course */
COURSE_ID = CODE_LIST[1, 1];
COURSE_DATE = DATE_LIST[1, 1];
INTERACT = FINISH;
REDISPLAY = "";
}
// END CASE
}// CASE
else if (OTHERWISE) {
/*  Modes 1, 5, 6 or 7 */
FOOTER = " No, Centre code, 'A'll centres, 'P'rint or <Return> to scroll ";
}
// END CASE
if (INTERACT != EXIT && INTERACT != FINISH) {
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM))) {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
SC_POS = "";
}
/*  Box heading */
/*  Display header one line lower when there are no input prompts */
if (DISPLAY_MODE < 3 || DISPLAY_MODE >= 5) {
HEAD_ROW = TOP_WINDOW;
} else {
HEAD_ROW = TOP_WINDOW + 1;
}
PRINT(AT(79, HEAD_ROW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, HEAD_ROW) + UND_VID);
PRINT(AT(LEFT_WINDOW, HEAD_ROW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
if (DISPLAY_MODE < 3 || DISPLAY_MODE >= 5) {
L2400();
/*  Display input prompts */
}
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 2) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
PRINTER_OUTPUT = FALSE;
L3000();
/*  Display data portion of window */
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
CODES_FOUND = FALSE;
do {
if (INTERACT == EXIT || CODES_FOUND) break;
if (DISPLAY_MODE < 3 || DISPLAY_MODE >= 5) {
SELECTION_CRITERIA = "";
L2000();
/*  Get selection criteria */
if (SELECTION_CRITERIA == "") {
INSTRUCTION = "SSELECT FL.COURSE.MASTER " + SORT_CRITERIA;
} else {
INSTRUCTION = "SSELECT FL.COURSE.MASTER" + SELECTION_CRITERIA + " " + SORT_CRITERIA;
}
/*  The lists have already been built if DISPLAY.MODE = 3 or 4 */
L4000();
/*  Select data for (possible) display */
if (CC == 0 && ALL_CENTRES == FALSE && (CENTRALISED_COURSES == "Y" || CENTRE_SCAN == "Y")) {
/*  Try all centres */
ALL_CENTRES = TRUE;
SELECTED_CENTRE = "";
L4000();
}
if (IGNORE_VACANCIES == FALSE && DISPLAY_MODE == 2 && DATE_LIST == "") {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
IGNORE_VACANCIES = TRUE;
L4000();
}
}
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (CC == 0) {
/*  No courses meet the criteria */
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
if (DISPLAY_MODE < 3 || DISPLAY_MODE >= 5) {
L2400();
/*  Redisplay input prompts */
}
}// CASE
else if (OTHERWISE) {
CODES_FOUND = TRUE;
}
// END CASE
} while (true);
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
if (INTERACT != EXIT && INTERACT != FINISH) {
PRINTER_OUTPUT = FALSE;
L3000();
/*  Display data portion of window */
}
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
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
WAIT = OCONV(WAIT, "MCU");
// BEGIN CASE
// CASE
if (WAIT == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if ((CENTRALISED_COURSES == "Y" || CENTRE_SCAN == "Y") && MATCH(WAIT,"2A") && (DISPLAY_MODE < 3 || DISPLAY_MODE > 4)) {
if (READ(ref TEST_REC, FL_MASTER_CENTRES, WAIT)) {
SELECTED_CENTRE = WAIT;
ALL_CENTRES = FALSE;
INTERACT = LIMIT;
CODE_LIST = "";
DATE_LIST = "";
L4000();
COURSE_NO = 1;
/* !*IF CC = 0 THEN */
/* !* INTERACT = INVALID.DATA */
/* !*END */
} else {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (WAIT == "A" && (DISPLAY_MODE < 3 || DISPLAY_MODE >= 5)) {
/*  All centres */
ALL_CENTRES = TRUE;
INTERACT = LIMIT;
CODE_LIST = "";
DATE_LIST = "";
L4000();
COURSE_NO = 1;
}// CASE
else if (WAIT == "I" && DISPLAY_MODE == 2) {
/*  Ignore vacancies, so display will show fully booked courses too */
IGNORE_VACANCIES = TRUE;
INTERACT = LIMIT;
CODE_LIST = "";
DATE_LIST = "";
L4000();
/*  Reselect (possible) data for display */
COURSE_NO = 1;
}// CASE
else if (WAIT == "0") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(WAIT,"0N") && WAIT != "") {
COURSE_ID = CODE_LIST[1, WAIT];
COURSE_DATE = DATE_LIST[1, WAIT];
if (COURSE_ID == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = FINISH;
}
}// CASE
else if (WAIT == "P") {
/*  Print the contents of the window, in full */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "STANDARD";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
PRINTER_OUTPUT = TRUE;
PRINTER_ON();
L3000();
PRINT(PRINT_END_COMMAND);
PRINTER_CLOSE();
PRINTER_OFF();
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
MAT(ref ANALYSIS_REC, "");
do {
FIELD_DATA = SC_POS[FIELD_NO];
if (!(FIELD_DATA != "" && INTERACT != EXIT)) break;
L2200();
do {
PRINT(AT(1, ST_ROW) + WINDOW_BACKGROUND_COLOR);
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH) + AT(ST_COL, ST_ROW));
VALUE = ANALYSIS_REC[ST_ATT];
INPUT(out ANS, ST_LENGTH);
/*  DJA 16.8.02 */
if (ST_ATT == 1 && ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
if (INTERACT != EXIT) {
ANS = RETURNED_ANS;
}
CNT = 0;
do {
CNT = CNT + 1;
if (CNT >= DISPLAY_LIMIT) break;
PRINT(AT(LEFT_WINDOW - 1, CNT + 5) + WINDOW_BACKGROUND_COLOR);
PRINT(AT(LEFT_WINDOW, CNT + 5) + FORMAT("", WINDOW_JUST));
} while (true);
/* !*PRINT @(79,2+BOTTOM.WINDOW):NRM.VID: */
PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(1, ST_ROW) + WINDOW_BACKGROUND_COLOR);
}
if (!(ANS == COMMON.HELP)) break;
} while (true);
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
ANALYSIS_REC[ST_ATT] = "";
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
// BEGIN CASE
// CASE
if (ST_ATT == 1) {
if (!(READV(ref ACTIVITY_DESC, FL_ACTIVITY_CODES, ANS, 1))) {
INTERACT = INVALID_DATA;
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/* **         CASE ST.ATT = 2 */
/* **           READV ABILITY.DESC FROM FL.ABILITY.CODES, ANS, 1 ELSE */
/* **             INTERACT = INVALID.DATA */
/* **             CALL FL006(PROGRAM,6,INIT) */
/* **           END */
}
// END CASE
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
ANALYSIS_REC[ST_ATT] = VALUE;
}
} while (true);
if (INTERACT != EXIT) {
/*  DJA 25.10.00 */
// BEGIN CASE
// CASE
if (DISPLAY_MODE == 7) {
/*  Include standard AND activity day courses */
SELECTION_CRITERIA = "";
PREFIX = " WITH";
}// CASE
else if (DISPLAY_MODE >= 5) {
SELECTION_CRITERIA = " WITH TYPE = \"A\"";
PREFIX = " AND WITH";
}// CASE
else if (OTHERWISE) {
SELECTION_CRITERIA = " WITH TYPE = \"\"";
PREFIX = " AND WITH";
}
// END CASE
if (ANALYSIS_REC[ACTIVITY_CODE] != "") {
SELECTION_CRITERIA = SELECTION_CRITERIA + PREFIX + " ACTIVITY.CODE = \"" + ANALYSIS_REC[ACTIVITY_CODE] + "\"";
PREFIX = " AND WITH";
}
if (ANALYSIS_REC[START_DATE] != "") {
if (EXACT_DATE == "Y") {
SELECTION_CRITERIA = SELECTION_CRITERIA + PREFIX + " START.DATE = \"" + OCONV(ANALYSIS_REC[START_DATE], "D") + "\"";
} else {
SELECTION_CRITERIA = SELECTION_CRITERIA + PREFIX + " START.DATE >= \"" + OCONV(ANALYSIS_REC[START_DATE], "D") + "\"";
}
PREFIX = " AND WITH";
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
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + WINDOW_BACKGROUND_COLOR);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT("", WINDOW_JUST));
AMC = 1;
do {
FIELD_DATA = SC_POS[AMC];
if (FIELD_DATA == "") break;
L2200();
/*  Get field parameters */
PRINT(AT(1, TOP_WINDOW + 1) + WINDOW_BACKGROUND_COLOR);
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
if ((DISPLAY_MODE == 3 || DISPLAY_MODE == 4) && NOT(PRINTER_OUTPUT)) {
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO];
if (!(LOCATE(DET_ID, DET_ID_LIST, 1, 0, 1, ref DET_POS, "AL"))) {
DET_ID_LIST[1, -1] = DET_ID;
BALANCE_LIST[1, -1] = 0;
DET_POS = DCOUNT(DET_ID_LIST, VM);
}
BALANCE_LIST[1, DET_POS] = BALANCE_LIST[1, DET_POS] + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
OVERALL_BALANCE = OVERALL_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
TRANS_NO = TRANS_NO + 1;
} while (true);
}
if (PRINTER_OUTPUT == TRUE) {
if (MACHINE_TYPE == "UNIVERSE") {
PAGE();
} else {
PRINT(FF);
}
PRINTCR(SPACE(10) + "Course Details");
PRINTCR(SPACE(10) + "==============");
PRINT();
if (DISPLAY_MODE == 3 || DISPLAY_MODE == 4) {
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
NAME = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
} else {
NAME = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
}
PRINTCR(SPACE(5) + "(" + STUDENT_ID + ")" + SPACE(5) + NAME);
}
PRINT();
PRINTCR(HEADING_TEXT2);
}
COURSE_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
COURSE_CODE = CODE_LIST[1, COURSE_NO];
COURSE_DATE = DATE_LIST[1, COURSE_NO];
/* **      UNTIL CNT >= WINDOW.DEPTH DO */
if (PRINTER_OUTPUT == TRUE) {
DISPLAY_LIMIT = 999;
} else {
DISPLAY_LIMIT = WINDOW_DEPTH;
}
if (CNT >= DISPLAY_LIMIT) break;
if (PRINTER_OUTPUT == FALSE) { PRINT(AT(79, CNT + 5) + NRM_VID); }
if (COURSE_CODE == "") {
if (PRINTER_OUTPUT == FALSE) {
PRINT(AT(LEFT_WINDOW - 1, CNT + 5) + WINDOW_BACKGROUND_COLOR);
PRINT(AT(LEFT_WINDOW, CNT + 5) + FORMAT("", WINDOW_JUST));
}
} else {
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) { MAT(ref COURSE_DET_REC, ""); }
// BEGIN CASE
// CASE
if (MOD(COURSE_DATE, 7) == 0) {
DAY = "Sun";
}// CASE
else if (MOD(COURSE_DATE, 7) == 1) {
DAY = "Mon";
}// CASE
else if (MOD(COURSE_DATE, 7) == 2) {
DAY = "Tues";
}// CASE
else if (MOD(COURSE_DATE, 7) == 3) {
DAY = "Wed";
}// CASE
else if (MOD(COURSE_DATE, 7) == 4) {
DAY = "Thur";
}// CASE
else if (MOD(COURSE_DATE, 7) == 5) {
DAY = "Fri";
}// CASE
else if (OTHERWISE) {
DAY = "Sat";
}
// END CASE
if (DISPLAY_MODE == 1 || DISPLAY_MODE == 5) {
COURSE_LINE = FORMAT(COURSE_NO, "R#4") + SPACE(2) + FORMAT(COURSE_CODE, "L#11") + SPACE(1) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], "L#28") + SPACE(1) + FORMAT(OCONV(COURSE_DATE, "D"), "L#11") + SPACE(2) + FORMAT(DAY, "L#4") + SPACE(2) + FORMAT(COURSE_DET_REC[COURSE_DET_FREQUENCY], "L#4") + SPACE(2) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_CENTRE], "R#2");
} else {
CONV_DATE = OCONV(COURSE_DATE, "D0/");
// BEGIN CASE
// CASE
if (CONV_DATE.Substring(4, 2) + 0 == 1) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Jan";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 2) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Feb";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 3) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Mar";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 4) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Apr";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 5) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " May";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 6) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Jun";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 7) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Jul";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 8) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Aug";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 9) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Sep";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 10) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Oct";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 11) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Nov";
}// CASE
else if (CONV_DATE.Substring(4, 2) + 0 == 12) {
CONV_DATE = CONV_DATE.Substring(1, 2) + " Dec";
}
// END CASE
if (!READV(ref WAIT_IDS, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_IDS = ""; }
WAIT_COUNT = DCOUNT(WAIT_IDS, VM);
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A") {
VAC_STRING = "";
} else {
VAC_STRING = COURSE_DET_REC[COURSE_DET_VACANCIES];
}
if (DISPLAY_MODE == 3 || DISPLAY_MODE == 4) {
if (LOCATE(DETAILS_ID, DET_ID_LIST, 1, 0, 1, ref POS, "AL")) {
THIS_BALANCE = BALANCE_LIST[1, POS];
} else {
THIS_BALANCE = 0;
}
if (DISPLAY_COURSE_CODES == "Y") {
CODE_JUST = "L#" + COURSE_CODE_LENGTH;
DESC_JUST = "L#" + (32 - COURSE_CODE_LENGTH - 1);
COURSE_LINE = FORMAT(COURSE_NO, "R#4") + SPACE(2) + FORMAT(COURSE_CODE, CODE_JUST) + " " + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], DESC_JUST) + FORMAT(OCONV(THIS_BALANCE, "MD2"), "R#8") + SPACE(1) + FORMAT(CONV_DATE, "R#7") + SPACE(2) + FORMAT(DAY, "L#4") + SPACE(2) + FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT"), "R#5") + SPACE(2) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_CENTRE], "R#2");
} else {
COURSE_LINE = FORMAT(COURSE_NO, "R#4") + SPACE(2) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], "L#32") + FORMAT(OCONV(THIS_BALANCE, "MD2"), "R#8") + SPACE(1) + FORMAT(CONV_DATE, "R#7") + SPACE(2) + FORMAT(DAY, "L#4") + SPACE(2) + FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT"), "R#5") + SPACE(2) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_CENTRE], "R#2");
}
} else {
if (DISPLAY_COURSE_CODES == "Y") {
CODE_JUST = "L#" + COURSE_CODE_LENGTH;
DESC_JUST = "L#" + (32 - COURSE_CODE_LENGTH - 1);
COURSE_LINE = FORMAT(COURSE_NO, "R#4") + SPACE(2) + FORMAT(COURSE_CODE, CODE_JUST) + " " + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], DESC_JUST) + FORMAT(CONV_DATE, "R#7") + SPACE(2) + FORMAT(DAY, "L#4") + SPACE(2) + FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT"), "R#5") + SPACE(2) + FORMAT(COURSE_DET_REC[COURSE_DET_FREQUENCY], "L#2") + SPACE(1) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_CENTRE], "R#2") + SPACE(1) + FORMAT(VAC_STRING, "R#3") + FORMAT(WAIT_COUNT, "R#6");
} else {
COURSE_LINE = FORMAT(COURSE_NO, "R#4") + SPACE(2) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], "L#32") + FORMAT(CONV_DATE, "R#7") + SPACE(2) + FORMAT(DAY, "L#4") + SPACE(2) + FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT"), "R#5") + SPACE(2) + FORMAT(COURSE_DET_REC[COURSE_DET_FREQUENCY], "L#2") + SPACE(1) + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_CENTRE], "R#2") + SPACE(1) + FORMAT(VAC_STRING, "R#3") + FORMAT(WAIT_COUNT, "R#6");
}
}
}
if (PRINTER_OUTPUT == FALSE) {
/*  DJA 14.2.04 */
/* !DJA 14.4.05!!IF COURSE.DATE < TODAYS.DATE AND COLOUR.CODING = "Y" THEN */
if (COURSE_DATE != COURSE_MSTR_REC[COURSE_MSTR_DATES][1, 1] && COLOUR_CODING == "Y") {
PRINT(AT(LEFT_WINDOW - 1, CNT + 5) + DIM_UND_VID);
} else {
PRINT(AT(LEFT_WINDOW - 1, CNT + 5) + WINDOW_BACKGROUND_COLOR);
}
PRINT(AT(LEFT_WINDOW, CNT + 5) + FORMAT(COURSE_LINE, WINDOW_JUST));
} else {
PRINTCR(COURSE_LINE);
}
}
COURSE_NO = COURSE_NO + 1;
} while (true);
/*  Don't prompt for course no. if this is the initial call to display a */
/*  'blank' window */
/* !*     IF CODE.LIST # "" AND PRINTER.OUTPUT = FALSE THEN GOSUB 1000 ELSE BLANK.DISPLAY.COMPLETE = TRUE */
// BEGIN CASE
// CASE
if (CODE_LIST != "" && PRINTER_OUTPUT == FALSE) {
L1000();
}// CASE
else if (CODE_LIST == "" && PRINTER_OUTPUT == FALSE && NOT(FIRST_WINDOW_DISPLAY)) {
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
/*  Loop one more time in order to clear the display */
L1000();
}// CASE
else if (OTHERWISE) {
BLANK_DISPLAY_COMPLETE = TRUE;
}
// END CASE
FIRST_WINDOW_DISPLAY = FALSE;
/*  Restart display from first date when end of list is reached */
if (COURSE_CODE == "") {
COURSE_NO = 1;
}
CNT = 0;
} while (true);
return;
/* ********************************************************* */
}
void L4000() {
/*   Select data for (possible) display                * */
/* ********************************************************* */
/* !*  DONE = FALSE */
/* !*  LOOP */
/* !*     UNTIL DONE DO */
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_DATES], FL_COURSE_MASTER, ID, 2)) { COURSE_MSTR_REC[COURSE_MSTR_DATES] = ""; }
DATE_COUNT = 1;
DEAD_COURSE_REACHED = FALSE;
do {
COURSE_DATE = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, DATE_COUNT];
if (COURSE_DATE == "" || DEAD_COURSE_REACHED == TRUE) break;
DETAILS_ID = COURSE_DATE + "*" + ID;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) { MAT(ref COURSE_DET_REC, ""); }
/*  DJA 26.2.01  Allow access to ended courses in maintenance screens */
if (COURSE_DET_REC[COURSE_DET_END] < TODAYS_DATE && DISPLAY_MODE != "1" && DISPLAY_MODE != "5") {
DEAD_COURSE_REACHED = TRUE;
} else {
/*  Course is 'current' */
/*  Now check it shouldn't be excluded due to selection by course date */
SELECT_COURSE = TRUE;
if ((ANALYSIS_REC[START_DATE] == "" || ANALYSIS_REC[START_DATE] <= COURSE_DATE) && SELECT_COURSE == TRUE) {
/*  Check the course has vacancies (if display.mode >= 2) */
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, ID)) { MAT(ref COURSE_MSTR_REC, ""); }
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A") {
/*  Closed course may need to be accessed for activity days */
/*  to amend session attendance details */
/*  Also COURSE.DET.VACANCIES will NND for activity days */
/*  DJA 26.2.01  Allow access to ended courses in maintenance screens */
if (COURSE_DET_REC[COURSE_DET_END] >= TODAYS_DATE || DISPLAY_MODE == "5") {
if (CENTRE_SCAN == "Y" || CENTRALISED_COURSES != "Y" || ALL_CENTRES || COURSE_MSTR_REC[COURSE_MSTR_CENTRE] == COMMON.CENTRE || COURSE_MSTR_REC[COURSE_MSTR_CENTRE] == "" || (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] == SELECTED_CENTRE && SELECTED_CENTRE != "")) {
CC = CC + 1;
CODE_LIST[1, CC] = ID;
DATE_LIST[1, CC] = COURSE_DATE;
}
}
} else {
if (COURSE_DET_REC[COURSE_DET_VACANCIES] > "0" || IGNORE_VACANCIES == TRUE || DISPLAY_MODE != 2) {
if (DISPLAY_MODE != 2 || COURSE_DET_REC[COURSE_DET_CLOSE_DATE] >= TODAYS_DATE || HIDE_CLOSED != "Y") {
OK_TO_PROCEED = FALSE;
// BEGIN CASE
// CASE
if (CENTRALISED_COURSES != "Y" && CENTRE_SCAN != "Y") {
OK_TO_PROCEED = TRUE;
/* !*                          CASE COURSE.MSTR.CENTRE = "" */
/* !*                             OK.TO.PROCEED = TRUE */
}// CASE
else if (ALL_CENTRES) {
OK_TO_PROCEED = TRUE;
}// CASE
else if (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] == COMMON.CENTRE && SELECTED_CENTRE == "") {
OK_TO_PROCEED = TRUE;
}// CASE
else if (SELECTED_CENTRE == COURSE_MSTR_REC[COURSE_MSTR_CENTRE] && SELECTED_CENTRE != "") {
OK_TO_PROCEED = TRUE;
}
// END CASE
/* !*                          IF CENTRALISED.COURSES # "Y" OR COURSE.MSTR.CENTRE = "" OR ALL.CENTRES OR COURSE.MSTR.CENTRE = CENTRE OR (SELECTED.CENTRE = COURSE.MSTR.CENTRE AND SELECTED.CENTRE # "") THEN */
if (OK_TO_PROCEED) {
/*  Finally, check if we're supposed to be booking for this course yet */
LEVELS_ALLOWED = "";
LEVEL = 1;
NO_LEVELS = 0;
do {
LEVEL_TEXT = COURSE_PARAM_REC[LEVEL];
if (LEVEL_TEXT == "") break;
NO_LEVELS = NO_LEVELS + 1;
if (TODAYS_DATE >= COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, LEVEL]) {
LEVELS_ALLOWED[LEVEL] = TRUE;
}
LEVEL = LEVEL + 1;
} while (true);
NO_LEVELS_ALLOWED = COUNT(LEVELS_ALLOWED, TRUE);
if ((NO_LEVELS < 1 || NO_LEVELS_ALLOWED >= 1) || DISPLAY_MODE != 2 || BLOCK_FUTURE_COURSES != "Y") {
CC = CC + 1;
CODE_LIST[1, CC] = ID;
DATE_LIST[1, CC] = COURSE_DATE;
}
}
}
}
}
}
}
DATE_COUNT = DATE_COUNT + 1;
} while (true);
} while (true);
/*  DJA 26.7.00 For Ipswich */
/* !*     IF IGNORE.VACANCIES = FALSE AND DISPLAY.MODE = 2 AND DATE.LIST = "" AND SELECTED.CENTRE = "" THEN */
/* !*        IGNORE.VACANCIES = TRUE */
/* !*        CALL FL006(PROGRAM,8,"") */
/* !*     END ELSE */
/* !*IF DISPLAY.MODE < 3 AND DISPLAY.MODE > 4 AND DATE.LIST = "" THEN */
/* !* CALL FL006(PROGRAM,11,"") */
/* !*END */
/* !*        DONE = TRUE */
/* !*     END */
/* !*  REPEAT */
return;
}
}
}
