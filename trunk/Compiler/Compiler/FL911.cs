//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL911 : UvBase
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
readonly UvVar REMOVEIT = 1;
readonly UvVar SCREENS = 8;
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
readonly UvVar FL_TICKET_FEES = 12;
readonly UvVar TICK_FEES_DESC = 1;
readonly UvVar TICK_FEES_PRICE = 2;
readonly UvVar TICK_FEES_GLCODE = 3;
readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
readonly UvVar TICK_FEES_OFF_PRICES = 5;
readonly UvVar TICK_FEES_OFF_START_MON = 6;
readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
readonly UvVar TICK_FEES_OFF_START_SAT = 8;
readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
readonly UvVar TICK_FEES_OFF_START_SUN = 10;
readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
readonly UvVar TICK_FEES_NEW_PRICE = 13;
readonly UvVar TICK_FEES_OPEN_RANGE = 14;
readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
readonly UvVar TICK_FEES_VAT_QUESTION = 20;
readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
readonly UvVar TICK_FEES_GROUP_CODE = 22;
readonly UvVar TICK_FEES_HEADCOUNT = 23;
readonly UvVar TICK_FEES_CONCESSIONS = 24;
readonly UvVar TICK_FEES_PEAK_PRICES = 25;
readonly UvVar TICK_FEES_OFF1_PRICES = 26;
readonly UvVar TICK_FEES_OFF2_PRICES = 27;
readonly UvVar TICK_FEES_OFF3_PRICES = 28;
readonly UvVar TICK_FEES_OFF4_PRICES = 29;
readonly UvVar TICK_FEES_SPLIT_OWED = 30;
readonly UvVar TICK_FEES_SPLIT_PAID = 31;
readonly UvVar TICK_FEES_SPORTS = 32;
readonly UvVar TICK_FEES_RESALE_RATE = 33;
readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
readonly UvVar TICK_FEES_TEXT = 35;
readonly UvVar TICK_FEES_MEMBER_REQ = 36;
readonly UvVar TICK_FEES_STYLE = 37;
readonly UvVar TICK_FEES_GROUPED = 38;
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar CTYPE_DESCRIPTION = 1;
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
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] TICKET_REC = new UvVar[40];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CTYPE_REC = new UvVar[5];
UvVar[] MASTER_CENTRE_REC = new UvVar[15];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar GO_BACK = "";
UvVar TILL_NUMBER = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar JUST = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_TYPES = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar N = "";
UvVar FL_MULTIPAY = "";
UvVar FL_MASTER_CENTRES = "";
UvVar COURSE_COMMENT_TAGS = "";
UvVar MULTIPAY_REC = "";
UvVar BASKET_COUNT = "";
FL006 FL006;
UvVar TICKET_PRINT_ROUTINE = "";
UvVar COURSE_PARAMS = "";
UvVar COMMENTS_PRINTED = "";
UvVar GET_INSTALMENT_VALUES = "";
UvVar FL911_PARAMS = "";
UvVar CROSS_CENTRE_XFERS = "";
UvVar ACTION = "";
UvVar SELECTION_DATE = "";
UvVar STUDENT_LIST = "";
UvVar MAX_FIELDS = "";
UvVar DATA_FIELDS = "";
UvVar DISPLAY_ONLY_FIELDS = "";
UvVar ENTRY_FIELDS = "";
UvVar FIELD_COUNT = "";
UvVar BALANCE = "";
UvVar TOGGLE_POS = "";
UvVar WINDOW_DEPTH = "";
UvVar LINE = "";
UvVar POS = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar STUDENT_SELECT_LIST = "";
UvVar SELECTED_CENTRE = "";
UvVar FIELD_NO = "";
UvVar UPDATE_INTERACT = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar SELECT_COUNT = "";
UvVar ERROR_LIST = "";
UvVar STUDENT_COUNT = "";
UvVar FIELD_DATA = "";
UvVar ST_DISPLAY = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
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
FL864 FL864;
UvVar COURSE_TYPE_ID = "";
UvVar REDISPLAY = "";
FL722 FL722;
UvVar RETURNED_ANS = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar SURNAME_LIST = "";
UvVar FULL_NAME_LIST = "";
UvVar COURSE_CODE_LIST = "";
UvVar COURSE_DESC_LIST = "";
UvVar COURSE_DATE_LIST = "";
UvVar CONV_ANS = "";
UvVar REPLY = "";
UvVar NO_STUDENTS = "";
UvVar STUDENT_MVC = "";
UvVar STUDENT_ID = "";
UvVar ENROL_ID = "";
UvVar DETAILS_ID = "";
UvVar TEST_POS = "";
UvVar CODE_LIST = "";
UvVar TICKET_CODE = "";
UvVar TICKET_TYPE = "";
UvVar SALE_DATE = "";
UvVar SALE_TIME = "";
UvVar PERIOD = "";
FL355 FL355;
UvVar PRICE = "";
UvVar RESPONSE = "";
UvVar GROUP_MULTIVALUE = "";
UvVar CONCESS_POS = "";
UvVar GROUP_NAME = "";
UvVar NO_TRANS = "";
UvVar MVC = "";
UvVar NO_WAITING = "";
FL862 FL862;
UvVar SPARE1 = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar COURSE_CODE = "";
UvVar NO_OF_COURSES = "";
UvVar OLD_COURSE_FOUND = "";
UvVar DATE_POS = "";
UvVar COURSE_DATE = "";
UvVar COURSE_DET_ID = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_POS = "";
UvVar COURSE_BALANCE = "";
UvVar PAYMENTS_AND_REFUNDS = "";
UvVar COURSE_FEE = "";
UvVar TRANS_NO = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar SURNAME = "";
UvVar NAME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL911() {
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
/*     Un-enrol non-payers */
PROMPT("");
PROGRAM = "FL911";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
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
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

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
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.TYPES
if (!OPEN("FL.COURSE.TYPES", out FL_COURSE_TYPES)) { STOP("201", "FL.COURSE.TYPES"); }

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
if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
if (BASKET_COUNT > 0) {
nrf0 = 85;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
COMMENTS_PRINTED = COURSE_PARAMS[5, 1];
GET_INSTALMENT_VALUES = COURSE_PARAMS[2, 1];
if (!READ(ref FL911_PARAMS, FL_COURSE_PARAMS, "FL911.PARAMS")) { FL911_PARAMS = ""; }
CROSS_CENTRE_XFERS = FL911_PARAMS[1, 1];
MAT(ref TEMP_REC, "");
/* ************************************ */
/*   GET SCREEN DEFINITION ITEM       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
/* ********************************** */
/*   EXTRACT DATA INPUT FIELDS      * */
/* ********************************** */
ACTION = FIRST_CALL;
SELECTION_DATE = "";
STUDENT_LIST = "";
MAX_FIELDS = 0;
SCREEN_LINES = 0;
DATA_FIELDS = "";
DISPLAY_ONLY_FIELDS = "";
ENTRY_FIELDS = "";
FIELD_COUNT = 0;
BALANCE = 0;
TOGGLE_POS = "";
WINDOW_DEPTH = "";
do {
LINE = SC_POS[SCREEN_LINES + 1];
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
do {
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = "";
STUDENT_SELECT_LIST = "";
MAT(ref TEMP_REC, "");
SELECTED_CENTRE = "";
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
if (INTERACT != LIMIT) { L0060(); }
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
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
if (MAIN_KEY != "" && INTERACT != EXIT) {
/*  Non-updating program */
NULL();
}
}
/* *        UNTIL INTERACT = EXIT OR INTERACT = FINISH DO */
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
UPDATE_INTERACT = "";
do {
INPUT_LINE = " Select student, 'ALL', 'NONE', <RET> to scroll, 'R'emove ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 5);
PRINT(AT(2, 21) + SPACE(75));
SELECT_COUNT = COUNT(STUDENT_SELECT_LIST, TRUE);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (SELECT_COUNT == 0 && ANS == "R") {
nrf0 = 46;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "R") {
UPDATE_INTERACT = REMOVEIT;
L4000();
/*  Remove students */
INTERACT = INVALID_DATA;
}// CASE
else if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N") || MATCH(ANS,"4N")) {
/*  Validate, then high/lowlight a particular student */
if (ANS > DCOUNT(STUDENT_LIST, VM) || ANS == 0) {
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
if (STUDENT_SELECT_LIST[1, ANS] == TRUE) {
STUDENT_SELECT_LIST[1, ANS] = INIT;
ERROR_LIST[1, ANS] = INIT;
} else {
STUDENT_SELECT_LIST[1, ANS] = TRUE;
}
TOGGLE_POS = ANS;
ACTION = TOGGLE;
L7000();
INTERACT = INVALID_DATA;
/*  Force it back round */
}
}// CASE
else if (ANS == "ALL") {
for(N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1) {
STUDENT_SELECT_LIST[1, N] = TRUE;
}
STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
ACTION = SCROLL;
L7000();
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "NONE") {
for(N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1) {
STUDENT_SELECT_LIST[1, N] = "";
}
STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
ACTION = SCROLL;
L7000();
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "") {
ACTION = SCROLL;
L7000();
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ******************************************** */
L0055:;
/*  Validate user can leave page 1        * */
/* ******************************************** */
/*  Validate that key fields are present before allowing the user to file */
INTERACT = FINISH;
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
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
PRINT(STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
INPUT(out ANS, ST_LENGTH);
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
TEMP_REC[1] = "";
if (FIELD_NO == 1) {
START_FIELD = 2;
END_FIELD = 2;
L6000();
}
}// CASE
else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "") {
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && ST_CONVERSION == "MD2") {
ANS = 0;
VALUE = 0;
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
case 3: L1100(); break;
case 4: L1300(); break;
case 5: L1200(); break;
case 6: L1200(); break;
case 7: L1200(); break;
case 8: L1200(); break;
case 9: L1200(); break;
case 10: L1200(); break;
case 11: L1200(); break;
case 12: L1200(); break;
case 13: L1200(); break;
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
PRINT(AT(2, PRINT_LINE) + SPACE(76));
}
PRINT(AT(0, 3) + NRM_VID);
/*  Stop wyse taking chunk out of footer */
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
/*   Course Type Validation Routine */
INTERACT = VALID_DATA;
// BEGIN CASE
/*  Scan for required activity code if the 'help' key is entered */
// CASE
if (ANS == COMMON.HELP && AMENDING == FALSE) {
FL864 = new FL864(ref COURSE_TYPE_ID, ref INTERACT, ref REDISPLAY);
/*  Refresh screen */
L0100();
if (INTERACT != EXIT) {
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_TYPE_ID, ST_JUST));
ANS = COURSE_TYPE_ID;
MAIN_KEY = ANS;
PROG_MESS[2] = COURSE_TYPE_ID;
if (!MATREAD(ref CTYPE_REC, FL_COURSE_TYPES, ANS)) { MAT(ref CTYPE_REC, ""); }
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 2;
ACTION = FIRST_CALL;
L6000();
/*  Display selected field data */
} else {
INTERACT = INVALID_DATA;
}
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
/* !*     AMENDING = TRUE */
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
PROG_MESS[2] = MAIN_KEY;
if (MATREAD(ref CTYPE_REC, FL_COURSE_TYPES, MAIN_KEY)) {
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 2;
ACTION = FIRST_CALL;
L6000();
/*  Display selected field data */
AMENDING = FALSE;
} else {
INTERACT = INVALID_DATA;
ANS = "";
VALUE = "";
MAIN_KEY = "";
nrf0 = 96;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (ANS == "" && MAIN_KEY != "") {
/*  User has pressed return after using 'backup' to get to the key field */
INTERACT = VALID_DATA;
ANS = MAIN_KEY;
}// CASE
else if (OTHERWISE) {
/* !!     INTERACT = EXIT */
/* !!     PROG.MESS<1> = ABANDON */
INTERACT = VALID_DATA;
/*  Course type is optional */
START_FIELD = 2;
END_FIELD = 2;
L6000();
}
// END CASE
return;
/* ********************************************* */
}
void L1100() {
/*  Centre Code (optional)                 * */
/* ********************************************* */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
FL722 = new FL722(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
if (INTERACT != EXIT) {
ANS = RETURNED_ANS;
} else {
INTERACT = INVALID_DATA;
}
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (INTERACT != INVALID_DATA) {
if (ANS == COMMON.CENTRE) {
INTERACT = VALID_DATA;
} else {
if (MATREAD(ref MASTER_CENTRE_REC, FL_MASTER_CENTRES, ANS)) {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 19;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
if (INTERACT == VALID_DATA) {
SELECTED_CENTRE = ANS;
}
return;
}
void L1200() {
/*   DUMMY Validation Routine (Display only fields) */
INTERACT = VALID_DATA;
return;
/* ********************************************* */
}
void L1300() {
/*  Enter earliest course start date       * */
/* ********************************************* */
STUDENT_SELECT_LIST = "";
STUDENT_LIST = "";
SURNAME_LIST = "";
ERROR_LIST = "";
FULL_NAME_LIST = "";
COURSE_CODE_LIST = "";
COURSE_DESC_LIST = "";
COURSE_DATE_LIST = "";
CONV_ANS = ICONV(ANS, "D");
// BEGIN CASE
// CASE
if (ANS == "" || ANS == COMMON.CLR) {
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (CONV_ANS == "") {
INTERACT = INVALID_DATA;
nrf0 = 90;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
SELECTION_DATE = CONV_ANS;
L9000();
/*  Select non-payers */
if (INTERACT != INVALID_DATA) {
L7000();
/*  Display window */
}
}
// END CASE
return;
/* ********************************************* */
}
void L4000() {
/*   Batch updates.                        * */
/* ********************************************* */
INTERACT = INVALID_DATA;
/*  Remove student(s) from course */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + " Do you wish to remove the selected individuals from their courses? ");
INPUT(out REPLY, 2);
PRINT(AT(2, 21) + SPACE(75));
// BEGIN CASE
// CASE
if (REPLY == "Y") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
NULL();
}
// END CASE
if (INTERACT == VALID_DATA) {
NO_STUDENTS = DCOUNT(STUDENT_LIST, VM);
STUDENT_MVC = 1;
do {
if (STUDENT_MVC > NO_STUDENTS) break;
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
if (!MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
ENROL_ID = COURSE_DATE_LIST[1, STUDENT_MVC] + "*" + COURSE_CODE_LIST[1, STUDENT_MVC] + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
/*  DJA 10.3.04. Corrects data corruptions to course.details (Grundy) */
DETAILS_ID = COURSE_DATE_LIST[1, STUDENT_MVC] + "*" + COURSE_CODE_LIST[1, STUDENT_MVC];
if (!MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) { MAT(ref COURSE_DET_REC, ""); }
if (LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = DELETE(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, TEST_POS, 0);
COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_VACANCIES] + 1;
}
/*  DJA 3.7.03 For BCC: Warn if student is on a waiting list */
if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID)) {
if (WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] != "") {
CODE_LIST = "";
N = 1;
do {
if (WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, N] == "") break;
if (N == 1) {
CODE_LIST = WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, 1];
} else {
CODE_LIST = CODE_LIST + "," + WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, N];
}
N = N + 1;
} while (true);
nrf0 = 1000;
nrf1 = STUDENT_ID + " (" + CODE_LIST + ")";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICKET_TYPE = "C";
SALE_DATE = COURSE_DATE_LIST[1, STUDENT_MVC];
SALE_TIME = TIME();
PERIOD = "";
FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
GROUP_MULTIVALUE = "";
if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL")) {
GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESS_POS];
if (GROUP_NAME != "") {
if (LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP_MULTIVALUE, "AL")) {
COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] + 1;
}
}
}
/*  Note : for transfers the new concession group vacancies have already */
/*         been reduced as part of the validation */
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL")) {
STUDENT_REC[STUDENT_DETAIL_IDS] = DELETE(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0);
}
/*  For removals the course fee is reversed.  Auto-refunds of payments MAY */
/*  need to be added.  For transfers between courses, all payments and */
/*  refunds are contra'd on the old course and re-applied to the new one. */
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "D";
/*  Disenrolment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -ENROL_REC[ENROL_PRICE];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - ENROL_REC[ENROL_PRICE];
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
DELETE(FL_ENROLMENT, ENROL_ID);
STUDENT_SELECT_LIST = DELETE(STUDENT_SELECT_LIST, 1, STUDENT_MVC, 0);
STUDENT_LIST = DELETE(STUDENT_LIST, 1, STUDENT_MVC, 0);
SURNAME_LIST = DELETE(SURNAME_LIST, 1, STUDENT_MVC, 0);
FULL_NAME_LIST = DELETE(FULL_NAME_LIST, 1, STUDENT_MVC, 0);
COURSE_CODE_LIST = DELETE(COURSE_CODE_LIST, 1, STUDENT_MVC, 0);
COURSE_DESC_LIST = DELETE(COURSE_DESC_LIST, 1, STUDENT_MVC, 0);
COURSE_DATE_LIST = DELETE(COURSE_DATE_LIST, 1, STUDENT_MVC, 0);
NO_STUDENTS = NO_STUDENTS - 1;
STUDENT_COUNT = 1;
ACTION = SCROLL;
L7000();
} else {
STUDENT_MVC = STUDENT_MVC + 1;
}
RELEASE();
} while (true);
/*  DJA 28.3.02 */
if (!READV(ref WAIT_MAST_REC[WAIT_MAST_IDS], FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_MAST_REC[WAIT_MAST_IDS] = ""; }
NO_WAITING = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
if (NO_WAITING > 0) {
nrf0 = 30;
nrf1 = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
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
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
}// CASE
else if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
// END CASE
}
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
STUDENT_COUNT = 1;
/* *   GOSUB 7000 */
return;
}
void L7000() {
/*   DISPLAY ONE SCREENFUL OF STUDENTS */
FL862 = new FL862(ref ACTION, ref TOGGLE_POS, ref STUDENT_SELECT_LIST, ref SPARE1, ref REDISPLAY, ref STUDENT_COUNT, ref STUDENT_LIST, ref SURNAME_LIST, ref FULL_NAME_LIST, ref COURSE_CODE_LIST, ref COURSE_DESC_LIST, ref COURSE_DATE_LIST, ref ERROR_LIST, ref WINDOW_DEPTH);
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = CTYPE_REC[CTYPE_DESCRIPTION];
return;
/* ********************************************* */
}
void L9000() {
/*  Select non-payers on courses starting  * */
/*      on or after a given date, and          * */
/*      associated with the selected course    * */
/*      type and centre                        * */
/* ********************************************* */
if (MAIN_KEY != "") {
INSTRUCTION = "SSELECT FL.COURSE.MASTER WITH TYPE # \"A\" AND WITH 12 = \"" + MAIN_KEY + "\"";
if (SELECTED_CENTRE != "") {
INSTRUCTION = INSTRUCTION + " AND WITH 4 = \"" + SELECTED_CENTRE + "\"";
}
} else {
if (SELECTED_CENTRE != "") {
INSTRUCTION = "SSELECT FL.COURSE.MASTER WITH TYPE # \"A\" AND WITH 4 = \"" + SELECTED_CENTRE + "\"";
} else {
INSTRUCTION = "SSELECTED FL.COURSE.MASTER WITH TYPE # \"A\"";
}
}
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
do {
if (!READNEXT(ref COURSE_CODE, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
/*  Loop for each course starting on or after the date specified */
NO_OF_COURSES = DCOUNT(COURSE_MSTR_REC[COURSE_MSTR_DATES], VM);
OLD_COURSE_FOUND = FALSE;
DATE_POS = 1;
do {
if (DATE_POS > NO_OF_COURSES || OLD_COURSE_FOUND) break;
COURSE_DATE = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, DATE_POS];
if (COURSE_DATE < SELECTION_DATE) {
OLD_COURSE_FOUND = TRUE;
} else {
/*  Check each student to see if they've paid */
COURSE_DET_ID = COURSE_DATE + "*" + COURSE_CODE;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID)) { MAT(ref COURSE_DET_REC, ""); }
NO_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
for(STUDENT_POS = 1; STUDENT_POS <= NO_OF_STUDENTS; STUDENT_POS += 1) {
STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_POS];
if (MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) {
COURSE_BALANCE = 0;
PAYMENTS_AND_REFUNDS = 0;
COURSE_FEE = "";
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == COURSE_DET_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P" || STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "R") {
PAYMENTS_AND_REFUNDS = PAYMENTS_AND_REFUNDS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "O") {
COURSE_FEE = STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
}
TRANS_NO = TRANS_NO + 1;
} while (true);
/* DJA 10.01.05*      IF PAYMENTS.AND.REFUNDS = 0 THEN */
/* DJA 13.01.05*       IF COURSE.BALANCE > 0 THEN */
if (COURSE_BALANCE == COURSE_FEE && COURSE_FEE + 0 != 0) {
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
} else {
SURNAME = STUDENT_REC[STUDENT_SURNAME];
NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_FORENAME].Substring(1, 1));
}
if (!LOCATE(SURNAME, SURNAME_LIST, 0, 0, 1, ref POS, "AL")) { NULL(); }
SURNAME_LIST = INSERT(SURNAME_LIST, POS, 0, 0, SURNAME);
STUDENT_LIST = INSERT(STUDENT_LIST, 1, POS, 0, STUDENT_ID);
COURSE_CODE_LIST = INSERT(COURSE_CODE_LIST, 1, POS, 0, COURSE_CODE);
COURSE_DATE_LIST = INSERT(COURSE_DATE_LIST, 1, POS, 0, COURSE_DATE);
COURSE_DESC_LIST = INSERT(COURSE_DESC_LIST, 1, POS, 0, COURSE_MSTR_REC[COURSE_MSTR_DESC]);
ERROR_LIST = INSERT(ERROR_LIST, 1, POS, 0, "");
FULL_NAME_LIST = INSERT(FULL_NAME_LIST, 1, POS, 0, NAME);
}
}
}
DATE_POS = DATE_POS + 1;
}
} while (true);
} while (true);
if (STUDENT_LIST == "") {
/*  Tell user there's no no-payers for this selection criteria */
nrf0 = 95;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
