//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL912 : UvBase
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
readonly UvVar COPY = 1;
readonly UvVar DUPLICATE = 2;
readonly UvVar GET = 3;
readonly UvVar PUT = 4;
readonly UvVar FLUSH = 6;
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
readonly UvVar ENROL_CONCESSION = 1;
readonly UvVar ENROL_PRICE = 2;
readonly UvVar ENROL_AWARD = 3;
readonly UvVar ENROL_ODD_INSTALMENT = 4;
readonly UvVar ENROL_OTHER_INSTALMENT = 5;
readonly UvVar ENROL_NO_INSTALMENTS = 6;
readonly UvVar ENROL_FULL_PRICE = 7;
readonly UvVar ENROL_FEE_OVERRIDE_USER = 8;
readonly UvVar ENROL_INST_PLAN_TOTAL = 9;
readonly UvVar ENROL_INST_FIRST_DUE = 10;
readonly UvVar ENROL_INST_NUMBER = 11;
readonly UvVar ENROL_INST_VALUE = 12;
readonly UvVar ENROL_INST_FREQUENCY = 13;
readonly UvVar ENROL_INST_DATES = 14;
readonly UvVar ENROL_INST_AMOUNTS = 15;
readonly UvVar ENROL_PREFERRED_COURSE1 = 16;
readonly UvVar ENROL_PREFERRED_COURSE2 = 17;
readonly UvVar ENROL_PREFERRED_COURSE3 = 18;
readonly UvVar ENROL_PREFERENCES_DATE = 19;
readonly UvVar ENROL_PREFERENCES_TIME = 20;
readonly UvVar ENROL_SESSIONS = 21;
readonly UvVar ENROL_SESSION_FEES = 22;
readonly UvVar ENROL_TOTAL_REDEMPTION = 23;
readonly UvVar ENROL_TOTAL_POINTS = 24;
readonly UvVar ENROL_BONUS_AWARD = 25;
readonly UvVar ENROL_PROMOTION = 26;
readonly UvVar ENROL_PERMITTED_LEVEL = 27;
readonly UvVar ENROL_MUST_PROGRESS = 28;
readonly UvVar ENROL_WEB = 29;
readonly UvVar FL_TICKETS = 11;
readonly UvVar TICK_CODE = 1;
readonly UvVar TICK_UNIT = 2;
readonly UvVar TICK_UNIT_PRICE = 3;
readonly UvVar TICK_DATE = 4;
readonly UvVar TICK_TIME = 5;
readonly UvVar TICK_TOTAL = 6;
readonly UvVar TICK_MOP = 7;
readonly UvVar TICK_CLERK = 8;
readonly UvVar TICK_TILL = 9;
readonly UvVar TICK_MEMBER = 10;
readonly UvVar TICK_PEAK_INDICATOR = 11;
readonly UvVar TICK_CONCESS = 13;
readonly UvVar TICK_CC_REF = 14;
readonly UvVar TICK_CC_EXP = 15;
readonly UvVar TICK_SESSION_NO = 16;
readonly UvVar TICK_BB_REF = 20;
readonly UvVar TICK_HCOUNT = 21;
readonly UvVar TICK_ACTIVITY_DATE = 22;
readonly UvVar TICK_CUSTOMER_NAME = 23;
readonly UvVar TICK_BONUS_POINTS = 24;
readonly UvVar TICK_PROMOTION = 25;
readonly UvVar TICK_CANCEL = 26;
readonly UvVar TICK_REDEEMED = 27;
readonly UvVar TICK_POINTS_REDEEMED = 28;
readonly UvVar TICK_SOURCE_ID = 29;
readonly UvVar TICK_EFT_SEQNO = 30;
readonly UvVar TICK_EFT_SWIPE = 31;
readonly UvVar TICK_ORIGINAL_NO = 32;
readonly UvVar TICK_VAT_IND = 33;
readonly UvVar TICK_HOME_CENTRE = 34;
readonly UvVar TICK_APACS_NO = 36;
readonly UvVar TICK_STUDENT_ID = 37;
readonly UvVar TICK_COURSE_DETAILS_ID = 38;
readonly UvVar TICK_BOOK_REF = 39;
readonly UvVar FL_DICT_TICKETS = 63;
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar CAL_TEXT = 1;
readonly UvVar CAL_TYPE = 2;
readonly UvVar INSTRUCTOR_TITLE = 1;
readonly UvVar INSTRUCTOR_FORENAME = 2;
readonly UvVar INSTRUCTOR_SURNAME = 3;
readonly UvVar INSTRUCTOR_ADDRESS1 = 4;
readonly UvVar INSTRUCTOR_ADDRESS2 = 5;
readonly UvVar INSTRUCTOR_ADDRESS3 = 6;
readonly UvVar INSTRUCTOR_ADDRESS4 = 7;
readonly UvVar INSTRUCTOR_POST_CODE = 8;
readonly UvVar INSTRUCTOR_QUAL1 = 9;
readonly UvVar INSTRUCTOR_QUAL2 = 10;
readonly UvVar INSTRUCTOR_QUAL3 = 11;
readonly UvVar INSTRUCTOR_HOME_TEL = 12;
readonly UvVar INSTRUCTOR_WORK_TEL = 13;
readonly UvVar INSTRUCTOR_SEX = 14;
readonly UvVar INSTRUCTOR_COMMENT1 = 15;
readonly UvVar INSTRUCTOR_COMMENT2 = 16;
readonly UvVar INSTRUCTOR_COMMENT3 = 17;
readonly UvVar INSTRUCTOR_COMMENT4 = 18;
readonly UvVar INSTRUCTOR_RATE_CODE = 19;
readonly UvVar INSTRUCTOR_RATE_PER_HOUR = 20;
readonly UvVar INSTRUCTOR_AVAILABLE_MONDAY = 21;
readonly UvVar INSTRUCTOR_AVAILABLE_TUESDAY = 22;
readonly UvVar INSTRUCTOR_AVAILABLE_WEDNESDAY = 23;
readonly UvVar INSTRUCTOR_AVAILABLE_THURSDAY = 24;
readonly UvVar INSTRUCTOR_AVAILABLE_FRIDAY = 25;
readonly UvVar INSTRUCTOR_AVAILABLE_SATURDAY = 26;
readonly UvVar INSTRUCTOR_AVAILABLE_SUNDAY = 27;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] TICKET_REC = new UvVar[40];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] CALENDAR_REC = new UvVar[10];
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar PROG_MESS = "";
UvVar AM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar FL_INSTRUCTORS = "";
UvVar TICKET_PRINT_ROUTINE = "";
UvVar COURSE_PARAMS = "";
UvVar COMMENTS_PRINTED = "";
UvVar PROMOTIONS_CONTROL = "";
UvVar CURRENT_PROMOTIONS = "";
UvVar BONUS_REDEEM_PROG = "";
UvVar COURSE_COMMENT_TAGS = "";
UvVar CENTRALISED_COURSES = "";
UvVar BATCH_HEADCOUNTS = "";
UvVar GET_STUDENT_ID = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_COURSE = "";
UvVar BONUS_REDEEM_REC = "";
UvVar PROMOTION = "";
UvVar OLD_COURSE_DATE = "";
UvVar STUDENT_ID = "";
UvVar APACS_NO = "";
UvVar GROUP_MULTIVALUE = "";
UvVar WAITING_LIST_ENROLMENT = "";
UvVar COURSE_BALANCE = "";
UvVar PAYMENT_MVC = "";
UvVar RECEIPT_REQUIRED = "";
UvVar NO_OF_STUDENTS = "";
UvVar PAYMENT_RECEIVED = "";
UvVar PAGE_NO = "";
UvVar STUDENT_AND_APACS_NOS = "";
FL913 FL913;
UvVar MOP = "";
FL006 FL006;
UvVar COURSE_CODE = "";
UvVar COURSE_DATE = "";
UvVar DETAILS_ID = "";
UvVar POS = "";
UvVar STUDENT_NAME = "";
UvVar NARRATIVE = "";
UvVar NARR_MV = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar FULL_INSTRUCTOR_NAME = "";
UvVar PAYMENT_AMOUNT = "";
UvVar TICK_REC = "";
UvVar TICK_ID = "";
UvVar PRINT_TICKET_NO = "";
UvVar SESSION_NO = "";
FL000_12 FL000_12;
UvVar ATT = "";
FL102 FL102;
UvVar STUDENT_IS_MEMBER = "";
CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
FL000_15 FL000_15;
FL114 FL114;
UvVar GROUP_MEMBER = "";
UvVar ENROL_ID = "";
UvVar GROUP_STUDENT_ID = "";
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
UvVar nrf4 = "";
UvVar nrf5 = "";
#endregion
public FL912() {
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
/*     CONTROLLING ROUTINE FOR GROUP COURSE ENROLMENT */
PROMPT("");
PROGRAM = "FL912";
SCREEN_CODE = PROGRAM;
INTERACT = "";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
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
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.ENROLMENT
if (!OPEN("FL.ENROLMENT", out FL_ENROLMENT)) { STOP("201", "FL.ENROLMENT"); }

/*  Keep in line with main record */
/*  DJA 9.11.00  Concession is MV'd for activity days */
/*  The following three variables become redundant after Version 1.1 */
/*  Instalment variables */
/*  The next three values may consist of two multivalues :- */
/*   mv1 = Course Date * Course Code */
/*   mv2 = Code showing status (if processed) : */
/*           S = Successful */
/*           U = Unsuccessful */
/*           P = transferred to Priority waiting list */
/*           N = Not required */
/*  The following attribute is multivalued per session date */
/*  and then subvalued per session (1-4). It maps directly */
/*  to COURSE.DET.SESSION.DATES on FL.COURSE.DETAILS */
/*  Loyalty Bonus Scheme - redemption */
/*  Loyalty Bonus Scheme - award */
/*  The promotion name is needed for reversing both */
/*  awards and redemptions */
/*  New fields to store permitted levels for web-re-enrolment */
/*  'P'ending or 'W'eb (completed) :- */

#endregion
#region INCLUDE FL.FILES FL.TICKETS

/*  (12) Used in OLD.TICKETS */
/*  (17-19) Used in OLD.TICKETS */
/*  DJA 7.2.01 */
/*  Source id is prefixed W for Web or W for Handheld. */
/*  This may be followed by a numeric audit reference. */
/*  5.9.02 Table type introduced using same scheme */
/*         for use by touchscreens */
/*  08.10.04 D for Door access introduced. First site: Ipswich */
/*  (35) USED IN OLD TICKETS */

#endregion
#region INCLUDE FL.FILES FL.DICT.TICKETS

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
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.CALENDAR
if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

/*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

#endregion
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

#endregion
if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
COMMENTS_PRINTED = COURSE_PARAMS[5, 1];
if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL"))) {
PROMOTIONS_CONTROL = "";
}
CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[1, 1];
/* ******************************** */
/*   DEFINE STANDARD VARIABLES    * */
/* ******************************** */
/*  Prog.mess<1> holds the page no.  If it is null this indicates */
/*  'finish' (i.e. update files).  It can also contain the 'abandon' */
/*  character */
/* ******************************* */
/*   MAIN PROCESSING SECTION     * */
/* ******************************* */
OLD_PAGE_NO = 1;
NEW_COURSE = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref COURSE_MSTR_REC, "");
MAT(ref COURSE_DET_REC, "");
MAT(ref ENROL_REC, "");
MAT(ref TICKET_REC, "");
BONUS_REDEEM_REC = "";
PROMOTION = "";
OLD_COURSE_DATE = "";
STUDENT_ID = "";
APACS_NO = "";
GROUP_MULTIVALUE = "";
WAITING_LIST_ENROLMENT = FALSE;
COURSE_BALANCE = 0;
PAYMENT_MVC = "";
RECEIPT_REQUIRED = FALSE;
PROG_MESS = 1;
NO_OF_STUDENTS = 0;
PAYMENT_RECEIVED = FALSE;
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
STUDENT_AND_APACS_NOS = STUDENT_ID + AM + APACS_NO;
FL913 = new FL913(ref STUDENT_AND_APACS_NOS, ref COURSE_MSTR_REC, ref COURSE_DET_REC, ref ENROL_REC, ref STUDENT_REC, ref TICKET_REC, ref RECEIPT_REQUIRED, ref NEW_COURSE, ref COURSE_BALANCE, ref PAYMENT_MVC, ref GROUP_MULTIVALUE, ref OLD_COURSE_DATE, ref BONUS_REDEEM_REC, ref PROMOTION, ref MOP, ref NO_OF_STUDENTS, ref PAYMENT_RECEIVED);
STUDENT_ID = STUDENT_AND_APACS_NOS[1];
APACS_NO = STUDENT_AND_APACS_NOS[2];
}// CASE
else if (OTHERWISE) {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PROG_MESS[1] = OLD_PAGE_NO;
}
// END CASE
OLD_PAGE_NO = PAGE_NO;
} while (true);
if (PROG_MESS[1] == "" && PROG_MESS[2] != "") {
/*  Apply File Updates */
COURSE_CODE = PROG_MESS[2];
COURSE_DATE = PROG_MESS[3];
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
/*  The student record will be duplicated later in this routine: */
if (!(LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL"))) {
STUDENT_REC[STUDENT_DETAIL_IDS] = INSERT(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0, DETAILS_ID);
}
/*  Update the overall balance for all this students courses. */
/*  There should never be an existing balance as all students */
/*  are newly created */
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + COURSE_BALANCE;
/*  Put the first student in place. Others will be appended shortly. */
if (!(LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))) {
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = INSERT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, POS, 0, STUDENT_ID);
}
// BEGIN CASE
// CASE
if (RECEIPT_REQUIRED) {
/*  Write a single ticket for the whole transaction, i.e. for the */
/*  group leader */
STUDENT_NAME = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
NARRATIVE = "Cust: " + STUDENT_ID + " " + STUDENT_NAME;
NARRATIVE[1, 2] = "Course: " + COURSE_CODE + " " + COURSE_MSTR_REC[COURSE_MSTR_DESC];
NARRATIVE[1, 3] = "Runs from " + OCONV(COURSE_DATE, "D") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D");
NARRATIVE[1, 4] = "No. of students: " + NO_OF_STUDENTS;
NARR_MV = 4;
if (COURSE_DET_REC[COURSE_DET_START_TIME] != "" && COURSE_DET_REC[COURSE_DET_END_TIME] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Times: Starts " + OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT") + " Ends " + OCONV(COURSE_DET_REC[COURSE_DET_END_TIME][1, 1], "MT");
}
if (COMMENTS_PRINTED == "Y") {
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[1] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[2] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[3] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[4] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
}
}
/*  Any Exception dates during this course period? */
EX_DATE = COURSE_DATE;
do {
if (EX_DATE > COURSE_DET_REC[COURSE_DET_END]) break;
FL873 = new FL873(ref EX_DATE, ref COURSE_DATE, ref COURSE_DET_REC, ref DATE_QUALIFIES);
if (DATE_QUALIFIES) {
if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] != "N") {
if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] == "Y") {
CALENDAR_ID = EX_DATE;
} else {
CALENDAR_ID = COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] + "*" + EX_DATE;
}
if (READ(ref CAL_REC, FL_COURSE_CALENDAR, CALENDAR_ID)) {
if (CAL_REC[2] == "C") {
/*  Courses do not run on this day */
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "*** No session on " + OCONV(EX_DATE, "D2/") + " ***";
}
}
}
}
EX_DATE = EX_DATE + 1;
} while (true);
/*  DJA 17.5.05 */
if (COURSE_DET_REC[COURSE_DET_INSTRUCTOR] != "") {
if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, COURSE_DET_REC[COURSE_DET_INSTRUCTOR])) { MAT(ref INSTRUCTOR_REC, ""); }
FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Instructor: " + FULL_INSTRUCTOR_NAME;
}
NARR_MV = NARR_MV + 1;
if (PAYMENT_MVC != "" && PAYMENT_RECEIVED) {
PAYMENT_AMOUNT = -STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, PAYMENT_MVC] * NO_OF_STUDENTS;
} else {
PAYMENT_AMOUNT = 0;
}
/*  PAYMENT.AMOUNT is already multiplied up to provide a grand total. */
/*  ENROL.PRICE is an individual course fee, i.e. NOT multiplied up */
NARRATIVE[1, NARR_MV] = "Fee = " + OCONV((ENROL_REC[ENROL_PRICE] * NO_OF_STUDENTS), "MD2") + " Paid " + OCONV(PAYMENT_AMOUNT, "MD2") + " o/s " + OCONV((COURSE_BALANCE * NO_OF_STUDENTS), "MD2");
TICK_REC = "";
/*  Dynamic equivalent */
TICK_ID = "";
PRINT_TICKET_NO = "";
/*  TEMPORARILY * */
SESSION_NO = "";
/*  DJA 12.8.02 */
if (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != "" && COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != COMMON.CENTRE && CENTRALISED_COURSES == "Y") {
PROG_MESS[24] = COURSE_MSTR_REC[COURSE_MSTR_CENTRE];
}
nrf0 = "";
FL000_12 = new FL000_12(ref PROGRAM, ref TICK_ID, ref nrf0, ref SESSION_NO);
PROG_MESS[24] = "";
PRINT_TICKET_NO = TICK_ID;
/*  AMENDED 3/7 TO SOLVE TICKET NO */
/*  Position cursor for entry no. */
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
TICKET_REC[TICK_SESSION_NO] = SESSION_NO;
for(ATT = 1; ATT <= 40; ATT += 1) {
TICK_REC[ATT] = TICKET_REC[ATT];
}
FL102 = new FL102();
STUDENT_IS_MEMBER = FALSE;
/*  DJA 23.4.03 */
if (BATCH_HEADCOUNTS[1, 1] == "Y") {
TICK_REC[21] = 0;
TICKET_REC[TICK_HCOUNT] = 0;
} else {
TICK_REC[21] = NO_OF_STUDENTS;
TICKET_REC[TICK_HCOUNT] = NO_OF_STUDENTS;
}
if (TICKET_PRINT_ROUTINE != "") {
nrf0 = TICK_REC[4];
nrf1 = TICK_REC[5];
nrf2 = "";
nrf3 = "";
nrf4 = "";
nrf5 = "COURSE";
CallAt_TICKET_PRINT_ROUTINE = new CallAt_TICKET_PRINT_ROUTINE(ref TICKET_PRINT_ROUTINE, ref PRINT_TICKET_NO, ref TICK_REC, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4, ref NARRATIVE, ref nrf5);
} else {
nrf0 = "";
FL000_15 = new FL000_15(ref PRINT_TICKET_NO, ref TICK_REC, ref NARRATIVE, ref nrf0);
}
nrf0 = "COURSES";
nrf1 = "Payment";
nrf2 = "";
nrf3 = "Balance";
FL114 = new FL114(ref nrf0, ref nrf1, ref nrf2, ref PAYMENT_AMOUNT, ref COURSE_BALANCE, ref nrf3);
MATWRITE(TICKET_REC, COMMON.FILES[FL_TICKETS], TICK_ID);
/*  Put automatically generated receipt no on enrolment record */
/*  Multiple student records will be written, sharing the same ticket id */
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, PAYMENT_MVC] = TICK_ID;
}// CASE
else if (OTHERWISE) {
/*  If payment > 0 they must have entered an 'existing' receipt no */
if (PAYMENT_MVC != "") {
if (STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, PAYMENT_MVC] + 0 != 0) {
STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, PAYMENT_MVC] = TRUE;
}
}
}
// END CASE
RELEASE();
/*  Downdate the no. vacancies for the relevant group if appropriate (i.e. */
/*  if the variable contains a value).  This is done here in case the */
/*  user changes the student in page 1 :- you don't have to worry about */
/*  up/downdating different multivalues if the concession group changes. */
if (GROUP_MULTIVALUE != "") {
COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] - NO_OF_STUDENTS;
}
STUDENT_REC[STUDENT_GROUP_ENROLLED] = "Y";
for(GROUP_MEMBER = 1; GROUP_MEMBER <= NO_OF_STUDENTS; GROUP_MEMBER += 1) {
if (GROUP_MEMBER == 1) {
/*  FL713 generates the first Id */
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
} else {
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref GROUP_STUDENT_ID);
if (!(LOCATE(GROUP_STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))) {
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = INSERT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, POS, 0, GROUP_STUDENT_ID);
}
MATWRITE(STUDENT_REC, FL_STUDENTS, GROUP_STUDENT_ID);
ENROL_ID = DETAILS_ID + "*" + GROUP_STUDENT_ID;
MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
}
}
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
}
RELEASE();
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
