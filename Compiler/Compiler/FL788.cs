//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL788 : UvBase
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
readonly UvVar WAIT_MAST_IDS = 1;
readonly UvVar WAIT_MAST_STATUS = 2;
readonly UvVar WAIT_STUD_TITLE = 1;
readonly UvVar WAIT_STUD_FORENAME = 2;
readonly UvVar WAIT_STUD_SURNAME = 3;
readonly UvVar WAIT_STUD_ADDRESS1 = 4;
readonly UvVar WAIT_STUD_ADDRESS2 = 5;
readonly UvVar WAIT_STUD_ADDRESS3 = 6;
readonly UvVar WAIT_STUD_ADDRESS4 = 7;
readonly UvVar WAIT_STUD_POST_CODE = 8;
readonly UvVar WAIT_STUD_TEL_HOME = 9;
readonly UvVar WAIT_STUD_TEL_WORK = 10;
readonly UvVar WAIT_STUD_COMMENT = 11;
readonly UvVar WAIT_STUD_AVAILABLE_MONDAY = 12;
readonly UvVar WAIT_STUD_AVAILABLE_TUESDAY = 13;
readonly UvVar WAIT_STUD_AVAILABLE_WEDNESDAY = 14;
readonly UvVar WAIT_STUD_AVAILABLE_THURSDAY = 15;
readonly UvVar WAIT_STUD_AVAILABLE_FRIDAY = 16;
readonly UvVar WAIT_STUD_AVAILABLE_SATURDAY = 17;
readonly UvVar WAIT_STUD_AVAILABLE_SUNDAY = 18;
readonly UvVar WAIT_STUD_ACTIVITY_CODES = 19;
readonly UvVar WAIT_STUD_CONCESSION = 20;
readonly UvVar WAIT_STUD_DATES = 21;
readonly UvVar WAIT_STUD_DOB = 22;
readonly UvVar WAIT_STUD_CONTACTED = 23;
readonly UvVar WAIT_STUD_CENTRE = 24;
readonly UvVar WAIT_STUD_COURSE = 25;
readonly UvVar WAIT_STUD_MEDICAL = 26;
readonly UvVar WAIT_STUD_CENTRE2 = 27;
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
readonly UvVar BONUS_MEMBER = 1;
readonly UvVar BONUS_SCHEME = 2;
readonly UvVar BONUS_DATE_JOINED = 3;
readonly UvVar BONUS_MONTH = 4;
readonly UvVar BONUS_POINTS = 5;
readonly UvVar BONUS_SPEND = 6;
readonly UvVar BONUS_REDEEMED = 7;
readonly UvVar BONUS_VALUE_REDEEMED = 8;
readonly UvVar BONUS_NET_POINTS = 9;
readonly UvVar BONUS_LAST_ALLOCATION_DATE = 10;
readonly UvVar BONUS_LAST_ALLOCATION_TIME = 11;
readonly UvVar BONUS_DECLINED_REDEMPTIONS = 12;
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
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] BONUS_REC = new UvVar[40];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar TILL_NUMBER = "";
UvVar PROG_MESS = "";
UvVar AM = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_BONUS = "";
UvVar FL_MULTIPAY = "";
UvVar TICKET_PRINT_ROUTINE = "";
UvVar COURSE_PARAMS = "";
UvVar COMMENTS_PRINTED = "";
UvVar PROMOTIONS_CONTROL = "";
UvVar CURRENT_PROMOTIONS = "";
UvVar BONUS_REDEEM_PROG = "";
UvVar CENTRALISED_COURSES = "";
UvVar BATCH_HEADCOUNTS = "";
UvVar STORED_PM35 = "";
UvVar STORED_PM36 = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_COURSE = "";
UvVar BONUS_REDEEM_REC = "";
UvVar PROMOTION = "";
UvVar TOTAL_REDEMPTION = "";
UvVar TOTAL_POINTS = "";
UvVar OLD_COURSE_DATE = "";
UvVar STUDENT_ID = "";
UvVar FEE_ADJUSTMENT = "";
UvVar WAITING_LIST_ENROLMENT = "";
UvVar COURSE_BALANCE = "";
UvVar PAYMENT_MVC = "";
UvVar TOTAL_FEE_PAYABLE = "";
UvVar ORIGINAL_SESSIONS = "";
FL796 FL796;
UvVar RESPONSE = "";
UvVar PAGE_NO = "";
FL789 FL789;
UvVar EXISTING_ADJUST_TOTAL = "";
UvVar EXISTING_PAYMENT_TOTAL = "";
UvVar EXISTING_REFUND_TOTAL = "";
UvVar TOTAL_SESSIONS = "";
UvVar FEE_LIST = "";
UvVar CONC_LIST = "";
UvVar SESSION_COUNTS = "";
UvVar MOP = "";
FL006 FL006;
UvVar COURSE_CODE = "";
UvVar COURSE_DATE = "";
UvVar DETAILS_ID = "";
UvVar POS = "";
UvVar STUDENT_NAME = "";
UvVar NARRATIVE = "";
UvVar NARR_MV = "";
UvVar FLAG_NO = "";
UvVar SESSION_DATE_COUNT = "";
UvVar DATE_NO = "";
UvVar SHOW_DATE = "";
UvVar DAY_TEXT = "";
UvVar SESSION_ROWS_PRINTED = "";
UvVar START_TIME = "";
UvVar END_TIME = "";
UvVar PAYMENT_AMOUNT = "";
UvVar REVERSE_PAYMENT_AMOUNT = "";
UvVar TICK_REC = "";
UvVar TICK_ID = "";
UvVar PRINT_TICKET_NO = "";
UvVar SESSION_NO = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar ATT = "";
UvVar BONUS_ID = "";
UvVar PERIOD = "";
FL285 FL285;
UvVar TODAYZ_DATE = "";
UvVar CALL_REF = "";
FL165 FL165;
UvVar STORED_UNIT_PRICE = "";
UvVar TOTAL_POINTS_REDEEMED = "";
FL277 FL277;
UvVar ADJ_MVC = "";
FL102 FL102;
FL000_12 FL000_12;
CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
FL000_15 FL000_15;
FL114 FL114;
UvVar ENROL_ID = "";
UvVar MULTIPAY_REC = "";
UvVar TRANS_COUNT = "";
UvVar MATCH_FOUND = "";
UvVar TRANS_NO = "";
UvVar SUPP_REC = "";
UvVar NO_SESSIONS = "";
UvVar NO_FEES = "";
UvVar NO_CONCS = "";
UvVar SUPP_ID = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
UvVar nrf4 = "";
UvVar nrf5 = "";
#endregion
public FL788() {
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
/*     CONTROLLING ROUTINE FOR ACTIVITY DAY ENROLMENT */
PROMPT("");
PROGRAM = "FL788";
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
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

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
#region INCLUDE FL.FILES FL.BONUS
#region INCLUDE FL.FILES FL.BONUS.EQU
if (!OPEN("FL.BONUS", out FL_BONUS)) { STOP("201", "FL.BONUS"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
COMMENTS_PRINTED = COURSE_PARAMS[5, 1];
if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL"))) {
PROMOTIONS_CONTROL = "";
}
CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
/* ******************************** */
/*   DEFINE STANDARD VARIABLES    * */
/* ******************************** */
/*  Prog.mess<1> holds the page no.  If it is null this indicates */
/*  'finish' (i.e. update files).  It can also contain the 'abandon' */
/*  character */
/* ******************************* */
/*   MAIN PROCESSING SECTION     * */
/* ******************************* */
STORED_PM35 = PROG_MESS[35];
STORED_PM36 = PROG_MESS[36];
PROG_MESS = 1;
PROG_MESS[35] = STORED_PM35;
PROG_MESS[36] = STORED_PM36;
OLD_PAGE_NO = 1;
NEW_COURSE = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref COURSE_MSTR_REC, "");
MAT(ref COURSE_DET_REC, "");
MAT(ref ENROL_REC, "");
MAT(ref WAIT_MAST_REC, "");
MAT(ref WAIT_STUDENT_REC, "");
MAT(ref TICKET_REC, "");
BONUS_REDEEM_REC = "";
PROMOTION = "";
TOTAL_REDEMPTION = 0;
TOTAL_POINTS = 0;
OLD_COURSE_DATE = "";
STUDENT_ID = "";
FEE_ADJUSTMENT = "";
WAITING_LIST_ENROLMENT = FALSE;
COURSE_BALANCE = 0;
PAYMENT_MVC = "";
TOTAL_FEE_PAYABLE = FALSE;
ORIGINAL_SESSIONS = 0;
/* **    PROG.MESS = 1 */
FL796 = new FL796(ref RESPONSE);
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
FL789 = new FL789(ref STUDENT_ID, ref COURSE_MSTR_REC, ref COURSE_DET_REC, ref ENROL_REC, ref STUDENT_REC, ref TICKET_REC, ref TOTAL_FEE_PAYABLE, ref NEW_COURSE, ref COURSE_BALANCE, ref PAYMENT_MVC, ref FEE_ADJUSTMENT, ref OLD_COURSE_DATE, ref WAITING_LIST_ENROLMENT, ref WAIT_MAST_REC, ref EXISTING_ADJUST_TOTAL, ref EXISTING_PAYMENT_TOTAL, ref EXISTING_REFUND_TOTAL, ref ORIGINAL_SESSIONS, ref TOTAL_SESSIONS, ref FEE_LIST, ref CONC_LIST, ref SESSION_COUNTS, ref BONUS_REDEEM_REC, ref PROMOTION, ref TOTAL_REDEMPTION, ref TOTAL_POINTS, ref MOP);
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
if (!(LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL"))) {
STUDENT_REC[STUDENT_DETAIL_IDS] = INSERT(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0, DETAILS_ID);
}
if (!(LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))) {
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = INSERT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, POS, 0, STUDENT_ID);
}
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_NAME = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
} else {
STUDENT_NAME = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
}
NARRATIVE = "Cust:   " + STUDENT_ID + " " + STUDENT_NAME;
NARRATIVE[1, 2] = "Course: (" + COURSE_CODE + ") " + COURSE_MSTR_REC[COURSE_MSTR_DESC];
NARR_MV = 2;
if (TOTAL_SESSIONS > 0) {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = SPACE(14) + "S E S S I O N S";
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Day Date      ";
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
NARRATIVE[1, NARR_MV] = NARRATIVE[1, NARR_MV] + FLAG_NO + "  ";
}
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
SHOW_DATE = FALSE;
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
if (ENROL_REC[ENROL_SESSIONS][1, DATE_NO, FLAG_NO] == "Y") {
SHOW_DATE = TRUE;
}
}
if (SHOW_DATE) {
DAY_TEXT = OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "DWA").Substring(1, 2);
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = DAY_TEXT + "  " + OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "D2/") + "  " + FORMAT(ENROL_REC[ENROL_SESSIONS][1, DATE_NO, 1], "L#3") + FORMAT(ENROL_REC[ENROL_SESSIONS][1, DATE_NO, 2], "L#3") + FORMAT(ENROL_REC[ENROL_SESSIONS][1, DATE_NO, 3], "L#3") + FORMAT(ENROL_REC[ENROL_SESSIONS][1, DATE_NO, 4], "L#3") + FORMAT(ENROL_REC[ENROL_SESSIONS][1, DATE_NO, 5], "L#3");
}
}
/*  Breakdown of the calculation */
SESSION_ROWS_PRINTED = 0;
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
if (SESSION_COUNTS[FLAG_NO] > 0) {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Session " + FLAG_NO + ": " + FORMAT(SESSION_COUNTS[FLAG_NO], "R#2") + " x " + FORMAT(OCONV(FEE_LIST[FLAG_NO], "MD2"), "R#6") + " = " + FORMAT(OCONV(SESSION_COUNTS[FLAG_NO] * FEE_LIST[FLAG_NO], "MD2"), "R#7");
NARRATIVE[1, NARR_MV] = NARRATIVE[1, NARR_MV] + " (" + CONC_LIST[FLAG_NO] + ")";
SESSION_ROWS_PRINTED = SESSION_ROWS_PRINTED + 1;
}
}
if (SESSION_ROWS_PRINTED > 1) {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Totals:    " + FORMAT(TOTAL_SESSIONS, "R#2") + FORMAT(OCONV(TOTAL_FEE_PAYABLE, "MD2"), "R#19");
}
}
/*  Session times */
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
START_TIME = COURSE_DET_REC[COURSE_DET_START_TIME][1, FLAG_NO];
END_TIME = COURSE_DET_REC[COURSE_DET_END_TIME][1, FLAG_NO];
if (START_TIME != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Session " + FLAG_NO + " Starts: " + OCONV(START_TIME, "MT");
if (END_TIME != "") {
NARRATIVE[1, NARR_MV] = NARRATIVE[1, NARR_MV] + " Ends: " + OCONV(END_TIME, "MT");
}
}
}
/* !*        NARR.MV = NARR.MV + 1 */
/* !*        NARRATIVE<1,NARR.MV> = STR("-",24) */
NARR_MV = NARR_MV + 1;
if (COMMENTS_PRINTED == "Y") {
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
}
if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
}
}
if (TICKET_REC[TICK_TOTAL] == "") {
PAYMENT_AMOUNT = 0;
} else {
PAYMENT_AMOUNT = TICKET_REC[TICK_TOTAL];
}
if (FEE_ADJUSTMENT != TOTAL_FEE_PAYABLE) {
/*  We are processing an enrolment change, not a new enrolment */
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Total Fee:  " + FORMAT(OCONV(TOTAL_FEE_PAYABLE, "MD2"), "R#8") + " Diff:    " + FORMAT(OCONV(FEE_ADJUSTMENT, "MD2"), "R#8");
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Payments:   " + FORMAT(OCONV(-PAYMENT_AMOUNT + EXISTING_PAYMENT_TOTAL, "MD2"), "R#8") + " This one:" + FORMAT(OCONV(-PAYMENT_AMOUNT, "MD2"), "R#8");
if (EXISTING_ADJUST_TOTAL != 0) {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Adjustments:" + FORMAT(OCONV(EXISTING_ADJUST_TOTAL, "MD2"), "R#8");
}
if (EXISTING_REFUND_TOTAL != 0) {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Refunds:    " + FORMAT(OCONV(EXISTING_REFUND_TOTAL, "MD2"), "R#8");
}
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "BALANCE:    " + FORMAT(OCONV(COURSE_BALANCE, "MD2"), "R#8");
} else {
NARR_MV = NARR_MV + 1;
/*  New Enrolment */
if (PAYMENT_AMOUNT == 0) {
REVERSE_PAYMENT_AMOUNT = 0;
} else {
REVERSE_PAYMENT_AMOUNT = -PAYMENT_AMOUNT;
}
NARRATIVE[1, NARR_MV] = "Fee:" + FORMAT(OCONV(FEE_ADJUSTMENT, "MD2"), "R#8") + "  Paid:" + FORMAT(OCONV(REVERSE_PAYMENT_AMOUNT, "MD2"), "R#8") + "  Bal:" + FORMAT(OCONV(COURSE_BALANCE, "MD2"), "R#8");
}
/*  Update the overall balance for all this students courses. */
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + FEE_ADJUSTMENT - PAYMENT_AMOUNT;
TICK_REC = "";
/*  Dynamic equivalent */
TICK_ID = "";
PRINT_TICKET_NO = "";
/*  TEMPORARILY * */
SESSION_NO = "";
/*  Don't generate a number if ticket.rec has not been */
/*  constructed. This happens because the student is in */
/*  a credit/zero balance position */
/*  The exception is where the student is a member and a */
/*  bonus scheme is in operation. We may need a ticket */
/*  record (with zero amounts) to store award/redemption */
/*  information */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
} else {
STUDENT_IS_MEMBER = FALSE;
}
if (MOP != "M") {
/* DJA 1.6.01*      IF PAYMENT.AMOUNT > 0 OR (CURRENT.PROMOTIONS # "" AND STUDENT.IS.MEMBER) THEN */
/*  DJA 1.6.01 */
/*  I'm not entirely happy with the solution below, but needs must. */
/*  The user is not taken through the MOP sequence where no payment */
/*  is required, e.g. change of session details, credit balance etc. */
/*  This normally takes place in FL789.VALIDATION 1700* */
/*  We need to print a ticket to illustrate any change of session */
/*  information. But MAT TICKET.REC is empty when the payment */
/*  prompts have been bypassed. We must not use a ticket number */
/*  without filing a corresponding record on FL.TICKETS, so we */
/*  must now hastily construct a 'neutral' ticket record :- */
/*  (This has not been retested with bonus scheme) */
if (PAYMENT_AMOUNT == 0) {
TICKET_REC[TICK_TOTAL] = 0;
TICKET_REC[TICK_UNIT] = 0;
TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICKET_REC[TICK_UNIT_PRICE] = 0;
TICKET_REC[TICK_DATE] = TODAYS_DATE;
TICKET_REC[TICK_TIME] = TIME();
TICKET_REC[TICK_CLERK] = U_INITS;
TICKET_REC[TICK_TILL] = TILL_NUMBER;
TICKET_REC[TICK_CONCESS] = ENROL_REC[ENROL_CONCESSION][1, 1];
/* !*           TICK.MOP = "C" */
}
for(ATT = 1; ATT <= 40; ATT += 1) {
TICK_REC[ATT] = TICKET_REC[ATT];
}
/*  Unlike standard courses, the bonus award is granted */
/*  upon enrolment, even if the total fee is not paid in full */
/*  (upon first enrolment ONLY, otherwise every change in sessions */
/*   awards additional points) */
if (CURRENT_PROMOTIONS != "" && STUDENT_IS_MEMBER) {
if (ENROL_REC[ENROL_BONUS_AWARD] + 0 != 0) {
/*  Change to existing enrolment (i.e. an award already exists) */
/*  Just update the spend using local code */
BONUS_ID = STUDENT_ID + "*" + ENROL_REC[ENROL_PROMOTION];
if (MATREADU(ref BONUS_REC, FL_BONUS, BONUS_ID)) {
BONUS_REC[BONUS_SPEND] = BONUS_REC[BONUS_SPEND] + FEE_ADJUSTMENT;
MATWRITE(BONUS_REC, FL_BONUS, BONUS_ID);
} else {
RELEASE();
}
} else {
PERIOD = 1;
/*  Course only use peak pricing */
TICK_REC[11] = PERIOD;
/*  IMPORTANT: I THINK THE CALL TO FL285 MULTIVALUES CERTAIN */
/*             ATTRIBUTES IN THE DYNAMIC VERSION OF TICK.REC. */
/*             CURRENTLY THIS DOESN'T APPEAR TO MATTER */
/*             BECAUSE THE DIMENSIONED TICK.REC IS WRITTEN TO */
/*             DISK. */
/*             WHEN IT MV'S TICK.CODE IT DOESN'T PREFIX THE */
/*             TICKET FEE WITH 'C*' TO INDICATE 'COURSES' */
nrf0 = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
nrf1 = 1;
nrf2 = ENROL_REC[ENROL_CONCESSION][1, 1];
FL285 = new FL285(ref TICK_REC, ref BONUS_REDEEM_REC, ref nrf0, ref FEE_ADJUSTMENT, ref nrf1, ref nrf2, ref PERIOD, ref STUDENT_ID);
TODAYZ_DATE = TODAYS_DATE;
CALL_REF = "COURSES";
/*  Temporarily set tick.rec<3> to the fee adjustment so that */
/*  BONUS.SPEND is correctly updated by FL165 */
STORED_UNIT_PRICE = TICK_REC[3];
TICK_REC[3] = FEE_ADJUSTMENT;
FL165 = new FL165(ref TICK_REC, ref TODAYZ_DATE, ref PERIOD, ref CALL_REF);
TICK_REC[3] = STORED_UNIT_PRICE;
TICKET_REC[TICK_BONUS_POINTS] = TICK_REC[24];
TICKET_REC[TICK_PROMOTION] = TICK_REC[25];
ENROL_REC[ENROL_BONUS_AWARD] = TICKET_REC[TICK_BONUS_POINTS];
ENROL_REC[ENROL_PROMOTION] = TICKET_REC[TICK_PROMOTION];
}
}
/*  Bonus redemption updates */
if (BONUS_REDEEM_REC != "" && CURRENT_PROMOTIONS != "" && STUDENT_IS_MEMBER) {
TOTAL_REDEMPTION = 0;
TOTAL_POINTS_REDEEMED = 0;
FL277 = new FL277(ref BONUS_REDEEM_REC, ref TOTAL_REDEMPTION, ref TOTAL_POINTS_REDEEMED);
/*  Ensure ticket record reflects the redemption */
ENROL_REC[ENROL_TOTAL_REDEMPTION] = ENROL_REC[ENROL_TOTAL_REDEMPTION] + TOTAL_REDEMPTION;
ENROL_REC[ENROL_TOTAL_POINTS] = ENROL_REC[ENROL_TOTAL_POINTS] + TOTAL_POINTS;
TICKET_REC[TICK_REDEEMED] = TOTAL_REDEMPTION;
TICKET_REC[TICK_POINTS_REDEEMED] = TOTAL_POINTS;
/*  Enrolment record must store the promotion name so the redemption */
/*  can be reversed if the student is unenrolled */
TICKET_REC[TICK_PROMOTION] = PROMOTION;
ENROL_REC[ENROL_PROMOTION] = PROMOTION;
/*  Append a new adjustment transaction to reflect the redemption */
/*  without touching the payment (i.e. make sure the till */
/*  reconciliation doesn't expect to find the redemption in the */
/*  till as money). This will also ensure that the correct */
/*  balance is reported if the sessions are changed in the */
/*  future */
ADJ_MVC = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM) + 1;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - TOTAL_REDEMPTION;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, ADJ_MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, ADJ_MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, ADJ_MVC] = "A";
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, ADJ_MVC] = -TOTAL_REDEMPTION;
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, ADJ_MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, ADJ_MVC] = "";
STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, ADJ_MVC] = "";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, ADJ_MVC] = "Bonus redemption";
STUDENT_REC[STUDENT_TRANS_USER][1, ADJ_MVC] = U_INITS;
}
FL102 = new FL102();
/* DJA 1.6.01*      END ELSE */
/* DJA 1.6.01*         PRINT.TICKET.NO = "" */
/* DJA 1.6.01*      END */
/*  Don't perform the write if ticket.rec has not been */
/*  constructed. This happens because the student is in */
/*  a credit/zero balance position */
/* DJA 1.6.01*      IF PAYMENT.AMOUNT > 0 OR TICK.BONUS.POINTS + 0 <> 0 OR TICK.REDEEMED + 0 <> 0 THEN */
if (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != "" && COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != COMMON.CENTRE && CENTRALISED_COURSES == "Y") {
PROG_MESS[24] = COURSE_MSTR_REC[COURSE_MSTR_CENTRE];
}
nrf0 = "";
FL000_12 = new FL000_12(ref PROGRAM, ref TICK_ID, ref nrf0, ref SESSION_NO);
PROG_MESS[24] = "";
PRINT_TICKET_NO = TICK_ID;
/*  AMENDED 3/7 TO SOLVE TICKET NO */
TICKET_REC[TICK_SESSION_NO] = SESSION_NO;
/*  Position cursor for entry no. */
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
/*  DJA 23.4.03 */
if (BATCH_HEADCOUNTS[1, 1] == "Y") {
TICK_REC[21] = 0;
TICKET_REC[TICK_HCOUNT] = 0;
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
MATWRITE(TICKET_REC, COMMON.FILES[FL_TICKETS], TICK_ID);
/*  Put automatically generated receipt no on enrolment record */
/*  Note: we may only be here because there's a bonus scheme, */
/*        in which case its possible that there's no payment */
/*        transaction. Don't corrupt the student record! */
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, PAYMENT_MVC] == "P") {
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, PAYMENT_MVC] = TICK_ID;
}
/* DJA 1.6.01*      END */
/*  Update Pod */
nrf0 = "COURSES";
nrf1 = "Payment";
nrf2 = "";
nrf3 = "Balance";
FL114 = new FL114(ref nrf0, ref nrf1, ref nrf2, ref PAYMENT_AMOUNT, ref COURSE_BALANCE, ref nrf3);
/*  Drops to here if MOP = "M" */
}
MATWRITE(COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE);
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
if (MOP == "M") {
/*  Output suspended payment details to disk */
if (!READU(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
TRANS_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
/*  Check if this entry replaces an existing basket entry */
MATCH_FOUND = FALSE;
COMMON.X = 1;
do {
if (MATCH_FOUND || COMMON.X > TRANS_COUNT) break;
if (MULTIPAY_REC[1, COMMON.X] == PROG_MESS[30] && MULTIPAY_REC[2, COMMON.X] == PROG_MESS[31] && MULTIPAY_REC[3, COMMON.X] == PROG_MESS[32]) {
MATCH_FOUND = TRUE;
TRANS_NO = COMMON.X;
nrf0 = 80;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
COMMON.X = COMMON.X + 1;
} while (true);
if (NOT(MATCH_FOUND)) {
TRANS_NO = TRANS_COUNT + 1;
}
MULTIPAY_REC[1, TRANS_NO] = PROG_MESS[30];
MULTIPAY_REC[2, TRANS_NO] = PROG_MESS[31];
MULTIPAY_REC[3, TRANS_NO] = PROG_MESS[32];
MULTIPAY_REC[4, TRANS_NO] = PROG_MESS[33];
WRITE(MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER);
SUPP_REC = "";
SUPP_REC[1] = "A";
NO_SESSIONS = DCOUNT(SESSION_COUNTS, AM);
for(COMMON.X = 1; COMMON.X <= NO_SESSIONS; COMMON.X += 1) {
SUPP_REC[2, COMMON.X] = SESSION_COUNTS[COMMON.X];
}
SUPP_REC[3] = TOTAL_SESSIONS;
SUPP_REC[4] = TOTAL_FEE_PAYABLE;
SUPP_REC[5] = FEE_ADJUSTMENT;
SUPP_REC[6] = EXISTING_PAYMENT_TOTAL;
SUPP_REC[7] = EXISTING_ADJUST_TOTAL;
SUPP_REC[8] = EXISTING_REFUND_TOTAL;
SUPP_REC[9] = COURSE_BALANCE;
/* !*           SUPP.REC<10> = PAYMENT.MVC */
NO_FEES = DCOUNT(FEE_LIST, AM);
for(COMMON.X = 1; COMMON.X <= NO_FEES; COMMON.X += 1) {
SUPP_REC[11, COMMON.X] = FEE_LIST[COMMON.X];
}
NO_CONCS = DCOUNT(CONC_LIST, AM);
for(COMMON.X = 1; COMMON.X <= NO_FEES; COMMON.X += 1) {
SUPP_REC[12, COMMON.X] = CONC_LIST[COMMON.X];
}
SUPP_ID = TILL_NUMBER + "*" + PROG_MESS[30] + "*" + PROG_MESS[31] + "*" + PROG_MESS[32];
WRITE(SUPP_REC, FL_MULTIPAY, SUPP_ID);
PROG_MESS[30] = "";
PROG_MESS[31] = "";
PROG_MESS[32] = "";
PROG_MESS[33] = "";
}
/*  If student was taken from a waiting list, apply the appropriate updates */
if (WAITING_LIST_ENROLMENT == TRUE) {
/* !*MATREADU WAIT.MAST.REC FROM FL.WAIT.MASTER, COURSE.MSTR.ACTIVITY.CODE ELSE MAT WAIT.MAST.REC = "" */
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, POS, 0);
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, POS, 0);
if (WAIT_MAST_REC[WAIT_MAST_IDS] == "") {
DELETE(FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE]);
} else {
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE]);
}
/* !*END ELSE */
/* !* RELEASE FL.WAIT.MASTER, COURSE.MSTR.ACTIVITY.CODE */
}
if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID)) {
if (LOCATE(COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL")) {
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, POS, 0);
if (WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] == "") {
DELETE(FL_WAIT_STUDENTS, STUDENT_ID);
} else {
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
/*  DJA 29.8.01 */
} else {
RELEASE();
}
}
}
PROG_MESS[1] = 1;
/*  Return to page 1 */
} else {
PROG_MESS = 1;
}
RELEASE();
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
