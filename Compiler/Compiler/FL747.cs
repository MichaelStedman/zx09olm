//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL747 : UvBase
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
readonly UvVar SCROLL = 1;
readonly UvVar NOT_PRESENT = 9;
readonly UvVar ALREADY_PRESENT = 10;
readonly UvVar FWTERM_MODE = 0;
readonly UvVar TOUCHSCREEN_MODE = 1;
readonly UvVar SILENT_MODE = 2;
readonly UvVar FL_CONTROL = 10;
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
readonly UvVar CAL_TEXT = 1;
readonly UvVar CAL_TYPE = 2;
readonly UvVar APACS_MEMBER = 1;
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
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] TICKET_REC = new UvVar[40];
UvVar[] CALENDAR_REC = new UvVar[10];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar SCREEN_CODE = "";
UvVar SCR_POS = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar GO_BACK = "";
UvVar TILL_NUMBER = "";
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar DOTS_ONLY = "";
UvVar JUST = "";
UvVar COURSE_DATE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_MULTIPAY = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar FL_APACS_NUMBERS = "";
UvVar FL_INSTRUCTORS = "";
UvVar TICKET_PRINT_ROUTINE = "";
UvVar LABEL_PRINT = "";
UvVar BATCH_HEADCOUNTS = "";
UvVar SMART_CARD = "";
UvVar COURSE_PARAMS = "";
UvVar COMMENTS_PRINTED = "";
UvVar PREVENT_PP_AND_INSTALMENTS = "";
UvVar COURSE_COMMENT_TAGS = "";
UvVar MAX_FIELDS = "";
UvVar DATA_FIELDS = "";
UvVar DISPLAY_ONLY_FIELDS = "";
UvVar ENTRY_FIELDS = "";
UvVar FIELD_COUNT = "";
UvVar BALANCE = "";
UvVar ACTION = "";
UvVar LINE = "";
UvVar POS = "";
UvVar ENROL_ID = "";
UvVar ORIGINAL_ENROL_DATES = "";
UvVar ORIGINAL_ENROL_AMOUNTS = "";
UvVar DISPLAY_ALL_TRANSACTIONS = "";
UvVar PAYMENT_TOTAL = "";
UvVar TRANS_CNT = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar ENROL_DATA_READ = "";
UvVar TRANS_LIST = "";
UvVar FIELD_NO = "";
UvVar DISPLAY_MODE = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar LABEL_TITLE = "";
UvVar LABEL_FORENAMES = "";
UvVar LABEL_SURNAME = "";
UvVar LABEL_ADDRESS1 = "";
UvVar LABEL_ADDRESS2 = "";
UvVar LABEL_ADDRESS3 = "";
UvVar LABEL_ADDRESS4 = "";
UvVar LABEL_POSTCODE = "";
CallAt_LABEL_PRINT CallAt_LABEL_PRINT;
FL731 FL731;
UvVar STUDENT_ID = "";
UvVar DETAILS_ID = "";
UvVar REDISPLAY = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
FL748 FL748;
UvVar RECALC = "";
UvVar DISPLAY_PLAN = "";
UvVar INST_PLAN_TOTAL = "";
UvVar INST_FIRST_DUE = "";
UvVar INST_NUMBER = "";
UvVar INST_VALUE = "";
UvVar INST_FREQUENCY = "";
UvVar INST_DATES = "";
UvVar INST_AMOUNTS = "";
UvVar DAY_COURSE_STARTS = "";
UvVar DAY_PLAN_STARTS = "";
UvVar OFFSET = "";
UvVar UNPAID_FEE = "";
FL749 FL749;
UvVar ENROL_FIRST_DUE = "";
FL006 FL006;
UvVar TEST_POS = "";
UvVar COURSE_FEE = "";
UvVar TEST_REC = "";
UvVar COURSE_CODE = "";
UvVar COURSE_ID = "";
UvVar COURSE_BALANCE = "";
UvVar STUDENT_NAME = "";
UvVar NARRATIVE = "";
UvVar NARR_MV = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar FULL_INSTRUCTOR_NAME = "";
UvVar TICK_REC = "";
UvVar TICK_ID = "";
UvVar PRINT_TICKET_NO = "";
UvVar SESSION_NO = "";
FL000_12 FL000_12;
UvVar ATT = "";
CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
FL000_15 FL000_15;
UvVar FIELD_DATA = "";
UvVar ST_DISPLAY = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar SMARTCARD_READ = "";
UvVar MEMBER_PROGRAM = "";
CallAt_MEMBER_PROGRAM CallAt_MEMBER_PROGRAM;
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar IFACE_TYPE = "";
UvVar SMART_MEMBER_NO = "";
UvVar APACS_NO = "";
UvVar SMART_DISPLAY_MODE = "";
FL_SMARTCARD FL_SMARTCARD;
UvVar TRANS_AMOUNT = "";
UvVar TRANS_TYPE = "";
UvVar TRANS_ID = "";
UvVar SMARTCARD_INTERACT = "";
UvVar CARD_ERROR_TYPE = "";
UvVar CARD_ERROR_MESS = "";
UvVar EPURSE_BALANCE = "";
UvVar LOYALTY_BALANCE = "";
UvVar PROMPT_NO = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar MULTIPAY_REC = "";
UvVar BASKET_COUNT = "";
UvVar BASKET_TOTAL = "";
UvVar ST_ATT_MV = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar MATCH_LIST = "";
FL723 FL723;
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar PADDED_MAIN_KEY = "";
FL000_40 FL000_40;
UvVar STUDENT_EXISTS = "";
UvVar NEW_STUDENT = "";
UvVar SCAN_STUDENT_ID = "";
FL717 FL717;
UvVar ACCESS_ALLOWED = "";
UvVar DATE_LIST = "";
UvVar CREATION_ALLOWED = "";
FL704 FL704;
UvVar NEW_COURSE = "";
UvVar COURSE_TEXT = "";
UvVar COURSE_TEXT2 = "";
UvVar TEXT_COL = "";
UvVar TEXT_JUST = "";
UvVar TRANS_NO = "";
UvVar NO_DATES = "";
UvVar NEXT_DATE = "";
UvVar NEXT_VALUE = "";
UvVar LAST_DATE = "";
UvVar LAST_VALUE = "";
UvVar TEXT_STRING1 = "";
UvVar TEXT_STRING2 = "";
UvVar INST_COL = "";
UvVar INST_JUST = "";
UvVar STUDENT_COUNT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
UvVar nrf4 = "";
UvVar nrf5 = "";
#endregion
public FL747(ref UvVar SCREEN_CODE, ref UvVar SCR_POS) {
this.SCREEN_CODE = SCREEN_CODE;
this.SCR_POS = SCR_POS;
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
/*     TRANSACTION ENQUIRIES AND INSTALMENT CHANGES */
PROMPT("");
PROGRAM = "FL747";
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
COURSE_DATE = "";
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
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.CALENDAR
if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

/*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

#endregion
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

#endregion
if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
if (!READV(ref LABEL_PRINT, COMMON.FILES[FL_CONTROL], "ADDRESS.LABEL.ROUTINE", 1)) { LABEL_PRINT = ""; }
if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
MAT(ref TEMP_REC, "");
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
COMMENTS_PRINTED = COURSE_PARAMS[5, 1];
PREVENT_PP_AND_INSTALMENTS = COURSE_PARAMS[15, 1];
if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
/* ********************************** */
/*   EXTRACT DATA INPUT FIELDS      * */
/* ********************************** */
MAX_FIELDS = 0;
SCREEN_LINES = 0;
DATA_FIELDS = "";
DISPLAY_ONLY_FIELDS = "";
ENTRY_FIELDS = "";
FIELD_COUNT = 0;
BALANCE = 0;
ACTION = "";
do {
LINE = SCR_POS[SCREEN_LINES + 1];
if (LINE == "") break;
if (LINE[1, 4] != "") {
FIELD_COUNT = FIELD_COUNT + 1;
if (LINE[1, 11] == "D") {
MAX_FIELDS = MAX_FIELDS + 1;
if (!(LOCATE(FIELD_COUNT, DISPLAY_ONLY_FIELDS, 1, 0, 1, ref POS, "AR"))) {
DISPLAY_ONLY_FIELDS = INSERT(DISPLAY_ONLY_FIELDS, 1, POS, 0, FIELD_COUNT);
}
} else {
MAX_FIELDS = MAX_FIELDS + 1;
if (!(LOCATE(FIELD_COUNT, ENTRY_FIELDS, 1, 0, 1, ref POS, "AR"))) {
ENTRY_FIELDS = INSERT(ENTRY_FIELDS, 1, POS, 0, FIELD_COUNT);
}
}
DATA_FIELDS[FIELD_COUNT] = LINE;
}
SCREEN_LINES = SCREEN_LINES + 1;
} while (true);
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
ENROL_ID = "";
ORIGINAL_ENROL_DATES = "";
ORIGINAL_ENROL_AMOUNTS = "";
MAT(ref ENROL_REC, "");
DISPLAY_ALL_TRANSACTIONS = FALSE;
PAYMENT_TOTAL = 0;
do {
INTERACT = VALID_DATA;
TRANS_CNT = 1;
L0100();
AMENDING = FALSE;
MAIN_KEY = "";
ENROL_DATA_READ = FALSE;
MAT(ref TEMP_REC, "");
TRANS_LIST = "";
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
if (INTERACT != LIMIT) { L0060(); }
if (INTERACT || AMENDING || FIELD_NO >= MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (INTERACT == BACKUP && AMENDING) {
L0050();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (FIELD_NO >= MAX_FIELDS) {
L0050();
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
if (ENROL_ID != "" && INTERACT != EXIT && (ORIGINAL_ENROL_DATES != ENROL_REC[ENROL_INST_DATES] || ORIGINAL_ENROL_AMOUNTS != ENROL_REC[ENROL_INST_AMOUNTS])) {
/*  Update instalment details on enrolment record */
MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
}
}
if (INTERACT == EXIT) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
/* *     IF NOT(DISPLAY.ALL.TRANSACTIONS) THEN */
// BEGIN CASE
// CASE
if (DISPLAY_MODE == 1) {
if (LABEL_PRINT == "") {
INPUT_LINE = "  <RET> to scroll, 'T'icket, 'P'rint, 'I'nstalments, 'A'll, 'F'inish ";
} else {
INPUT_LINE = "  <Return>, 'T'icket, 'P'rint, 'I'nstalments, 'A'll, 'F'inish, '+' label ";
}
}// CASE
else if (OTHERWISE) {
if (LABEL_PRINT == "") {
INPUT_LINE = "  <RET> to scroll, 'T'icket, 'P'rint, 'I'nstalments, 'N'ormal, 'F'inish ";
} else {
INPUT_LINE = "  <Ret>, 'T'icket, 'P'rint, 'I'nstalments, 'N'ormal, 'F'inish, '+' label ";
}
}
// END CASE
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
PRINT(AT(2, 21) + SPACE(72));
// BEGIN CASE
// CASE
if (ANS == "+" && LABEL_PRINT != "") {
/*  NORFOLK SKI CLUB LABEL PRINT */
if (STUDENT_IS_MEMBER) {
LABEL_TITLE = MEMBERS_REC[MEMBER_TITLES][1, 1];
LABEL_FORENAMES = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
LABEL_SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
LABEL_ADDRESS1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
LABEL_ADDRESS2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
LABEL_ADDRESS3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
LABEL_ADDRESS4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
LABEL_POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
} else {
LABEL_TITLE = STUDENT_REC[STUDENT_TITLE];
LABEL_FORENAMES = STUDENT_REC[STUDENT_FORENAME];
LABEL_SURNAME = STUDENT_REC[STUDENT_SURNAME];
LABEL_ADDRESS1 = STUDENT_REC[STUDENT_ADDRESS1];
LABEL_ADDRESS2 = STUDENT_REC[STUDENT_ADDRESS2];
LABEL_ADDRESS3 = STUDENT_REC[STUDENT_ADDRESS3];
LABEL_ADDRESS4 = STUDENT_REC[STUDENT_ADDRESS4];
LABEL_POSTCODE = STUDENT_REC[STUDENT_POST_CODE];
}
CallAt_LABEL_PRINT = new CallAt_LABEL_PRINT(ref LABEL_PRINT, ref LABEL_TITLE, ref LABEL_FORENAMES, ref LABEL_SURNAME, ref LABEL_ADDRESS1, ref LABEL_ADDRESS2, ref LABEL_ADDRESS3, ref LABEL_ADDRESS4, ref LABEL_POSTCODE);
}// CASE
else if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == "F") {
INTERACT = FINISH;
}// CASE
else if (ANS == "A" && NOT(DISPLAY_ALL_TRANSACTIONS)) {
/*  Display all transactions, irrespective of the course they relate to */
DISPLAY_ALL_TRANSACTIONS = TRUE;
TRANS_CNT = 1;
DISPLAY_MODE = 2;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
}// CASE
else if (ANS == "N" && DISPLAY_MODE > 1) {
/*  Revert to normal transaction display */
L0100();
/* !*      GOSUB 0300 */
START_FIELD = 1;
END_FIELD = 5;
L6000();
DISPLAY_ALL_TRANSACTIONS = FALSE;
TRANS_CNT = 1;
DISPLAY_MODE = 1;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
}// CASE
else if (ANS == "" && DISPLAY_MODE != 3) {
/*  Scroll transaction window */
ACTION = SCROLL;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
ACTION = "";
}// CASE
else if (ANS == "P" && DISPLAY_MODE < 3) {
/*  Print transaction list for one/all courses dependant on display.mode */
STUDENT_ID = MAIN_KEY;
FL748 = new FL748(ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE);
}// CASE
else if (ANS == "I" && DISPLAY_MODE != 3 && PREVENT_PP_AND_INSTALMENTS != "Y" && NOT(COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")) {
RECALC = FALSE;
DISPLAY_PLAN = TRUE;
INST_PLAN_TOTAL = ENROL_REC[ENROL_INST_PLAN_TOTAL];
INST_FIRST_DUE = ENROL_REC[ENROL_INST_FIRST_DUE];
INST_NUMBER = ENROL_REC[ENROL_INST_NUMBER];
INST_VALUE = ENROL_REC[ENROL_INST_VALUE];
INST_FREQUENCY = ENROL_REC[ENROL_INST_FREQUENCY];
INST_DATES = ENROL_REC[ENROL_INST_DATES];
INST_AMOUNTS = ENROL_REC[ENROL_INST_AMOUNTS];
STUDENT_ID = MAIN_KEY;
if (INST_PLAN_TOTAL + 0 == 0) {
/*  Set it to balance o/s in case they wish to generate a new plan */
INST_PLAN_TOTAL = TEMP_REC[4];
}
if (INST_FREQUENCY == "") { INST_FREQUENCY = "W"; }
if (INST_FIRST_DUE == "") {
if (TODAYS_DATE > COURSE_DATE) {
DAY_COURSE_STARTS = MOD(COURSE_DATE, 7);
DAY_PLAN_STARTS = MOD(TODAYS_DATE, 7);
OFFSET = 0;
do {
if (DAY_COURSE_STARTS == DAY_PLAN_STARTS) break;
OFFSET = OFFSET + 1;
DAY_PLAN_STARTS = DAY_PLAN_STARTS + 1;
if (DAY_PLAN_STARTS > 6) { DAY_PLAN_STARTS = 0; }
} while (true);
INST_FIRST_DUE = TODAYS_DATE + OFFSET;
} else {
INST_FIRST_DUE = COURSE_DATE;
}
}
UNPAID_FEE = TEMP_REC[4];
FL749 = new FL749(ref STUDENT_ID, ref DETAILS_ID, ref STUDENT_REC, ref RECALC, ref DISPLAY_PLAN, ref UNPAID_FEE, ref INST_PLAN_TOTAL, ref INST_FIRST_DUE, ref INST_NUMBER, ref INST_VALUE, ref INST_FREQUENCY, ref INST_DATES, ref INST_AMOUNTS, ref INTERACT, ref REDISPLAY);
/* !*      PRINT @(0,0):EOL:"INST.DATES=":INST.DATES:"ENROL.DATA.READ=":ENROL.DATA.READ:;INPUT FLEX,1: */
if (INTERACT != EXIT) {
ENROL_REC[ENROL_INST_PLAN_TOTAL] = INST_PLAN_TOTAL;
ENROL_REC[ENROL_INST_FIRST_DUE] = INST_FIRST_DUE;
ENROL_REC[ENROL_INST_NUMBER] = INST_NUMBER;
ENROL_REC[ENROL_INST_VALUE] = INST_VALUE;
ENROL_REC[ENROL_INST_FREQUENCY] = INST_FREQUENCY;
ENROL_REC[ENROL_INST_DATES] = INST_DATES;
ENROL_REC[ENROL_INST_AMOUNTS] = INST_AMOUNTS;
}
/*  If plan has been 'initialised', clear out all reference to it */
if (ENROL_REC[ENROL_INST_DATES] == "") {
ENROL_REC[ENROL_INST_PLAN_TOTAL] = "";
ENROL_FIRST_DUE = "";
ENROL_REC[ENROL_INST_NUMBER] = "";
ENROL_REC[ENROL_INST_VALUE] = "";
ENROL_REC[ENROL_INST_FREQUENCY] = "";
}
if (REDISPLAY) {
L0100();
START_FIELD = 1;
END_FIELD = 5;
L6000();
DISPLAY_ALL_TRANSACTIONS = FALSE;
TRANS_CNT = 1;
DISPLAY_MODE = 1;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
}
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "T") {
/*  Print a duplicate ticket, showing course details */
/* *           IF ENROL.CONCESSION = "" AND ENROL.PRICE = "" THEN */
/* ** Warn that ticket will be incomplete as student is no longer enrolled */
/* *              CALL FL006(PROGRAM,30,"") */
/* *           END */
if (ENROL_REC[ENROL_PRICE] == "") {
/*  Student no longer enrolled.  Get fee from first transaction */
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
COURSE_FEE = STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TEST_POS];
} else {
COURSE_FEE = 0;
}
} else {
COURSE_FEE = ENROL_REC[ENROL_PRICE];
}
MAT(ref TICKET_REC, "");
TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICKET_REC[TICK_UNIT] = 1;
TICKET_REC[TICK_UNIT_PRICE] = 0;
TICKET_REC[TICK_DATE] = TODAYS_DATE;
TICKET_REC[TICK_TIME] = TIME();
TICKET_REC[TICK_TOTAL] = 0;
TICKET_REC[TICK_MOP] = "";
TICKET_REC[TICK_CLERK] = U_INITS;
TICKET_REC[TICK_TILL] = TILL_NUMBER;
if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], MAIN_KEY)) {
TICKET_REC[TICK_MEMBER] = MAIN_KEY;
} else {
TICKET_REC[TICK_MEMBER] = "";
}
TICKET_REC[TICK_STUDENT_ID] = MAIN_KEY;
TICKET_REC[TICK_COURSE_DETAILS_ID] = DETAILS_ID;
TICKET_REC[TICK_CONCESS] = ENROL_REC[ENROL_CONCESSION][1, 1];
TICKET_REC[TICK_CC_REF] = "";
TICKET_REC[TICK_CC_EXP] = "";
STUDENT_ID = MAIN_KEY;
COURSE_CODE = COURSE_ID;
COURSE_BALANCE = TEMP_REC[4];
/* !*        STUDENT.NAME = TRIM(STUDENT.TITLE:" ":STUDENT.FORENAME:" ":STUDENT.SURNAME) */
STUDENT_NAME = TEMP_REC[1];
NARRATIVE = "Cust: " + STUDENT_ID + " " + STUDENT_NAME;
NARRATIVE[1, 2] = "Course: " + COURSE_CODE + " " + COURSE_MSTR_REC[COURSE_MSTR_DESC];
NARRATIVE[1, 3] = "Runs from " + OCONV(COURSE_DATE, "D") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D");
NARR_MV = 3;
if (COURSE_DET_REC[COURSE_DET_START_TIME][1, 1] != "" && COURSE_DET_REC[COURSE_DET_END_TIME][1, 1] != "") {
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
NARRATIVE[1, NARR_MV] = "Fee = " + OCONV(COURSE_FEE, "MD2") + " Paid " + OCONV(PAYMENT_TOTAL, "MD2") + " o/s " + OCONV(COURSE_BALANCE, "MD2");
TICK_REC = "";
/*  Dynamic equivalent */
TICK_ID = "";
PRINT_TICKET_NO = "";
/*  TEMPORARILY * */
SESSION_NO = "";
nrf0 = "";
FL000_12 = new FL000_12(ref PROGRAM, ref TICK_ID, ref nrf0, ref SESSION_NO);
PRINT_TICKET_NO = TICK_ID;
/*  Position cursor for entry no. */
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
TICKET_REC[TICK_SESSION_NO] = SESSION_NO;
for(ATT = 1; ATT <= 40; ATT += 1) {
TICK_REC[ATT] = TICKET_REC[ATT];
}
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
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ******************************** */
}
void L0060() {
/*   DATA ENTRY ROUTINE       * */
/* ******************************** */
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
/*  Ensure no input prompts for display-only fields */
if (ST_DISPLAY != "D") {
INTERACT = INVALID_DATA;
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = TEMP_REC[ST_ATT][1, ST_MV];
}
/*  Go straight to scanning window after student id is established */
if (FIELD_NO == 4) {
ANS = COMMON.HELP;
} else {
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
PRINT(STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
/* !*         INPUT ANS,ST.LENGTH: */
/*  Smart card may already be positioned in the reader */
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 1) {
L0065();
}
if (NOT(SMARTCARD_READ)) {
if (FIELD_NO == 1) {
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
} else {
MEMBER_PROGRAM = "";
}
if (MEMBER_PROGRAM != "") {
CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
} else {
INPUT(out ANS, ST_LENGTH);
}
if (ANS == "" && VALUE == "" && FIELD_NO == 1 && SMART_CARD) {
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 1) {
L0065();
/*  Re-try card read in case it was presented 'late' */
}
}
}
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == GO_BACK && FIELD_NO == 1) {
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == GO_BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
/*  NB Payment field is mandatory but the valid'n routine handles defaults */
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY != "") {
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1100(); break;
case 3: L1100(); break;
case 4: L1200(); break;
case 5: L1100(); break;
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
}
return;
/* ************************************* */
}
void L0065() {
/*   Read smartcard                * */
/* ************************************* */
IFACE_TYPE = 1;
SMART_MEMBER_NO = "";
APACS_NO = "";
SMART_DISPLAY_MODE = FWTERM_MODE;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref SMART_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
// BEGIN CASE
// CASE
if (SMARTCARD_INTERACT == NOT_PRESENT) {
NULL();
}// CASE
else if (SMARTCARD_INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (SMART_MEMBER_NO == "NONMEM") {
/*  Use unrecognised APACS numbers as non-member student Ids */
if (APACS_NO != "") {
ANS = APACS_NO;
SMARTCARD_READ = TRUE;
}
}// CASE
else if (OTHERWISE) {
/*  If an APACS number has been returned, now process the lookup */
/*  to convert it to a membership number. If this lookup fails, */
/*  then proceed to display an input prompt in the normal way */
if (APACS_NO != "" && SMART_MEMBER_NO == "") {
if (!READV(ref SMART_MEMBER_NO, FL_APACS_NUMBERS, APACS_NO, 1)) { SMART_MEMBER_NO = ""; }
}
if (SMART_MEMBER_NO != "") {
ANS = SMART_MEMBER_NO;
SMARTCARD_READ = TRUE;
}
}
// END CASE
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
PRINT(AT(1, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(76));
}
L0150();
return;
/* *************************************************** */
}
void L0150() {
/*  Update basket count                          * */
/* *************************************************** */
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
BASKET_TOTAL = 0;
COMMON.X = 1;
do {
if (COMMON.X > BASKET_COUNT) break;
BASKET_TOTAL = BASKET_TOTAL + MULTIPAY_REC[4, COMMON.X];
COMMON.X = COMMON.X + 1;
} while (true);
if (BASKET_COUNT > 0) {
PRINT(AT(43, 2) + ERR_MESS_BACK + ERR_MESS_FORE + "Items in basket: " + FORMAT(BASKET_COUNT, "R#2") + "  Total: " + FORMAT(OCONV(BASKET_TOTAL, "MD2"), "R#7"));
PRINT(AT(0, 3) + NRM_VID);
}
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
ST_DISPLAY = FIELD_DATA[1, 11];
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
}
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1000() {
/*  Validate Student/Member No */
if (ANS == COMMON.HELP) {
MATCH_LIST = "";
FL723 = new FL723(ref ANS, ref INTERACT, ref REDISPLAY, ref MATCH_LIST);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(ANS, ST_JUST));
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (INTERACT != EXIT) {
INTERACT = VALID_DATA;
}
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
ANS = "";
INTERACT = INVALID_DATA;
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
PROG_MESS[2] = MAIN_KEY;
PADDED_MAIN_KEY = MAIN_KEY;
FL000_40 = new FL000_40(ref PADDED_MAIN_KEY);
STUDENT_IS_MEMBER = FALSE;
STUDENT_EXISTS = FALSE;
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, MAIN_KEY)) {
STUDENT_EXISTS = TRUE;
} else {
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, PADDED_MAIN_KEY)) {
STUDENT_EXISTS = TRUE;
MAIN_KEY = PADDED_MAIN_KEY;
ANS = MAIN_KEY;
VALUE = MAIN_KEY;
}
}
if (STUDENT_EXISTS) {
/*  If this student is also a member, then MAIN.KEY will already */
/*  have been assigned as the 'padded' number above, where necesary */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MAIN_KEY)) {
STUDENT_IS_MEMBER = TRUE;
TEMP_REC[1] = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
TEMP_REC[2] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
} else {
TEMP_REC[1] = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
TEMP_REC[2] = STUDENT_REC[STUDENT_ADDRESS1];
}
START_FIELD = 2;
END_FIELD = 3;
L6000();
/*  Display selected fields */
NEW_STUDENT = FALSE;
} else {
if (SMART_CARD) {
INTERACT = EXIT;
} else {
INTERACT = INVALID_DATA;
}
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
MAIN_KEY = "";
VALUE = "";
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
void L1100() {
/*   DUMMY Validation Routine (Display only fields) */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*   Course Code Validation Routine */
INTERACT = VALID_DATA;
// BEGIN CASE
/*  Scan for required course if the 'help' key is entered */
// CASE
if (ANS == COMMON.HELP && AMENDING == FALSE) {
DISPLAY_MODE = 4;
SCAN_STUDENT_ID = MAIN_KEY;
FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
if (INTERACT == FINISH) { INTERACT = VALID_DATA; }
/*  Refresh screen */
if (REDISPLAY) {
L0100();
START_FIELD = 1;
END_FIELD = 4;
L6000();
/*  Display selected fields */
}
if (INTERACT != EXIT) {
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
ANS = COURSE_ID;
DETAILS_ID = COURSE_DATE + "*" + COURSE_ID;
if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
/*  Check student is or was enrolled in this course */
ACCESS_ALLOWED = FALSE;
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
if (ACCESS_ALLOWED == TRUE) {
L1220();
/*  display course data */
} else {
nrf0 = 17;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
VALUE = "";
ANS = "";
AMENDING = FALSE;
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
}
} else {
/*  Abandoned window */
NULL();
}
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
COURSE_ID = VALUE;
if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, VALUE)) {
/*  Call date selection window */
DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
CREATION_ALLOWED = FALSE;
PROG_MESS[2] = COURSE_ID;
if (DCOUNT(DATE_LIST, VM) == 1) {
COURSE_DATE = DATE_LIST;
INTERACT = VALID_DATA;
REDISPLAY = "";
} else {
FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
}
/*  If box is abandoned, reprompt for course code */
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
ANS = "";
VALUE = "";
AMENDING = FALSE;
} else {
INTERACT = VALID_DATA;
}
if (REDISPLAY) {
L0100();
START_FIELD = 1;
END_FIELD = 4;
L6000();
/*  Display selected fields */
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(VALUE, ST_JUST));
REDISPLAY = "";
}
if (INTERACT == VALID_DATA) {
/*  Existing course */
DETAILS_ID = COURSE_DATE + "*" + VALUE;
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
/*  Check student is enrolled on this course */
ACCESS_ALLOWED = FALSE;
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
if (ACCESS_ALLOWED == TRUE) {
L1220();
/*  display course data */
AMENDING = FALSE;
} else {
nrf0 = 17;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
VALUE = "";
ANS = "";
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 22;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
AMENDING = FALSE;
VALUE = "";
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
else if (ANS == "" && VALUE != "") {
/*  User has pressed return after using 'backup' to get to the key field */
INTERACT = VALID_DATA;
ANS = MAIN_KEY;
}// CASE
else if (OTHERWISE) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}
// END CASE
return;
}
void L1220() {
/*  Processing after course & date are established */
ENROL_ID = DETAILS_ID + "*" + MAIN_KEY;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
ENROL_DATA_READ = TRUE;
ORIGINAL_ENROL_DATES = ENROL_REC[ENROL_INST_DATES];
ORIGINAL_ENROL_AMOUNTS = ENROL_REC[ENROL_INST_AMOUNTS];
/*  Display description and start/end dates */
COURSE_TEXT = COURSE_MSTR_REC[COURSE_MSTR_DESC];
COURSE_TEXT2 = "Runs from " + OCONV(COURSE_DATE, "D2/") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D2/");
/* *     TEXT.COL    = ST.COL + ST.LENGTH + 2 */
TEXT_COL = 3;
/* *     TEXT.JUST   = "L#":78-TEXT.COL */
TEXT_JUST = "L#35";
PRINT(AT(TEXT_COL, ST_ROW + 1) + FORMAT(COURSE_TEXT, TEXT_JUST));
PRINT(AT(TEXT_COL, ST_ROW + 2) + FORMAT(COURSE_TEXT2, TEXT_JUST));
/*  Extract course balance for display */
TRANS_LIST = "";
COURSE_BALANCE = 0;
PAYMENT_TOTAL = 0;
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == DETAILS_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P") {
PAYMENT_TOTAL = PAYMENT_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
TRANS_LIST[1, -1] = TRANS_NO;
}
TRANS_NO = TRANS_NO + 1;
} while (true);
TEMP_REC[4] = COURSE_BALANCE;
START_FIELD = 5;
END_FIELD = 5;
L6000();
/*  Display selected field data */
/*  Display transactions */
DISPLAY_MODE = 1;
/*  Transactions for this course only */
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
return;
/* ***************************************** */
}
void L6000() {
/*   Display data for selected fields  * */
/* ***************************************** */
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
for(FIELD_NO = START_FIELD; FIELD_NO <= END_FIELD; FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
// BEGIN CASE
// CASE
if (ST_ATT == 0) {
PRINT(AT(ST_COL - 1, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
}// CASE
else if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
// END CASE
if (ST_ATT == 3) {
DETAILS_ID = COURSE_DATE + "*" + COURSE_ID;
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) { MAT(ref COURSE_DET_REC, ""); }
if (NOT(ENROL_DATA_READ)) {
ENROL_ID = DETAILS_ID + "*" + MAIN_KEY;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
ENROL_DATA_READ = TRUE;
}
/*  Display description and start/end dates */
COURSE_TEXT = COURSE_MSTR_REC[COURSE_MSTR_DESC];
COURSE_TEXT2 = "Runs from " + OCONV(COURSE_DATE, "D2/") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D2/");
TEXT_COL = 3;
TEXT_JUST = "L#35";
PRINT(AT(TEXT_COL, ST_ROW + 1) + FORMAT(COURSE_TEXT, TEXT_JUST));
PRINT(AT(TEXT_COL, ST_ROW + 2) + FORMAT(COURSE_TEXT2, TEXT_JUST));
/*  Follow course code with instalment details where relevant */
}
if (ST_ATT == 4 && ENROL_REC[ENROL_INST_DATES] != "") {
NO_DATES = DCOUNT(ENROL_REC[ENROL_INST_DATES], VM);
if (!LOCATE(TODAYS_DATE, ENROL_REC[ENROL_INST_DATES], 1, 0, 1, ref POS, "AR")) { NULL(); }
NEXT_DATE = ENROL_REC[ENROL_INST_DATES][1, POS];
if (NEXT_DATE == "" || POS == NO_DATES) {
NEXT_DATE = "- - - - ";
NEXT_VALUE = "- - -";
} else {
NEXT_DATE = OCONV(NEXT_DATE, "D2/");
NEXT_VALUE = OCONV(ENROL_REC[ENROL_INST_AMOUNTS][1, POS], "MD2");
}
LAST_DATE = ENROL_REC[ENROL_INST_DATES][1, NO_DATES];
if (LAST_DATE == "") {
LAST_DATE = "- - - - ";
LAST_VALUE = "- - -";
} else {
LAST_DATE = OCONV(LAST_DATE, "D2/");
LAST_VALUE = OCONV(ENROL_REC[ENROL_INST_AMOUNTS][1, NO_DATES], "MD2");
}
TEXT_STRING1 = "Freq: " + ENROL_REC[ENROL_INST_FREQUENCY] + "  Next: " + NEXT_DATE + " " + FORMAT(NEXT_VALUE, "R#6");
TEXT_STRING2 = "No:   " + FORMAT(ENROL_REC[ENROL_INST_NUMBER], "L#3") + "Ends: " + LAST_DATE + " " + FORMAT(LAST_VALUE, "R#6");
INST_COL = 3;
INST_JUST = "L#39";
PRINT(AT(INST_COL, ST_ROW - 3) + FORMAT(TEXT_STRING1, INST_JUST));
PRINT(AT(INST_COL, ST_ROW - 2) + FORMAT(TEXT_STRING2, INST_JUST));
}
}
FIELD_DATA = OLD_FIELD_DATA;
FIELD_NO = OLD_FIELD_NO;
L0200();
STUDENT_COUNT = 1;
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
