//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL754 : UvBase
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
readonly UvVar TRANSFER = 2;
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
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
readonly UvVar MDATA_CODE = 1;
readonly UvVar MDATA_ENROLMENT_DATE = 2;
readonly UvVar MDATA_STUDENT_ID = 3;
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
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] MDATA_REC = new UvVar[5];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar U_INITS = "";
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
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar N = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_MULTIPAY = "";
UvVar FL_MARKETING_DATA = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar MULTIPAY_REC = "";
UvVar BASKET_COUNT = "";
FL006 FL006;
UvVar COURSE_PARAMS = "";
UvVar GET_INSTALMENT_VALUES = "";
UvVar MAX_PLACES = "";
UvVar PERMIT_BALANCE_TRANSFERS = "";
UvVar MARKETING_PROMPT = "";
UvVar FEE_TODAY = "";
UvVar DEFAULT_MARKETING_CODE = "";
UvVar CHECK_EXPIRY = "";
UvVar TRANSFER_ADJUSTMENTS = "";
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
UvVar FIELD_NO = "";
UvVar SELECT_COUNT = "";
UvVar UPDATE_INTERACT = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar NEW_COURSE_DATE = "";
UvVar NEW_COURSE_ID = "";
UvVar DISPLAY_MODE = "";
FL717 FL717;
UvVar SCAN_STUDENT_ID = "";
UvVar REDISPLAY = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
UvVar ACTION = "";
UvVar OLD_COURSE_DATE = "";
UvVar NEW_COURSE_MSTR_REC = "";
UvVar NEW_DATE_LIST = "";
UvVar NO_MVS = "";
UvVar MVC = "";
UvVar TEST_DET_ID = "";
UvVar TEST_DET_REC = "";
UvVar CLOSING_DATE = "";
UvVar NO_NEW_DATES = "";
UvVar DATE_LIST = "";
UvVar CREATION_ALLOWED = "";
UvVar OLD_COURSE_CODE = "";
FL704 FL704;
UvVar NEW_COURSE = "";
UvVar STUDENT_COUNT = "";
UvVar NEW_DETAILS_ID = "";
UvVar NEW_COURSE_DET_REC = "";
UvVar ACTIVITY_CODE = "";
FL721 FL721;
UvVar TEST_REC = "";
UvVar REPLY = "";
UvVar NO_STUDENTS = "";
UvVar STUDENT_LIST = "";
UvVar STUDENT_MVC = "";
UvVar STUDENT_ID = "";
UvVar ACT_POS = "";
UvVar PRIORITY_POS = "";
UvVar XFER_LIST = "";
UvVar ERROR_LIST = "";
UvVar BALANCE_LIST = "";
UvVar BALANCE_WARNING = "";
UvVar FIELD_DATA = "";
UvVar ST_DISPLAY = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
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
UvVar COURSE_ID = "";
UvVar COURSE_DATE = "";
UvVar DETAILS_ID = "";
UvVar SELECT_DATE = "";
UvVar NEW_DD = "";
UvVar NEW_MM = "";
UvVar NEW_DD_MM = "";
UvVar ENROL_ID = "";
UvVar ADJUSTMENT_LIST = "";
UvVar NO_TRANS = "";
UvVar NEW_TICK_FEES_CONCESSIONS = "";
UvVar CONCESS_POS = "";
UvVar NEW_TICK_FEES_PEAK_PRICES = "";
UvVar COURSE_BALANCE = "";
UvVar INST_PLAN_TOTAL = "";
UvVar NO_WEEKS = "";
UvVar INST_FIRST_DUE = "";
UvVar INST_NUMBER = "";
UvVar INST_VALUE = "";
UvVar INST_FREQUENCY = "";
UvVar INST_DATES = "";
UvVar INST_AMOUNTS = "";
UvVar RECALC = "";
UvVar UNPAID_FEE = "";
UvVar DISPLAY_PLAN = "";
FL749 FL749;
UvVar NEW_ENROL_ID = "";
UvVar MARKETING_SEQ = "";
UvVar SURNAME_LIST = "";
UvVar FULL_NAME_LIST = "";
UvVar CONCESS_LIST = "";
UvVar INSTALMENT_LIST = "";
UvVar ERROR_COUNT = "";
UvVar TEST_POS = "";
UvVar NEW_VACANCIES = "";
UvVar NO_TO_XFER = "";
UvVar COUNTDOWN = "";
UvVar INITIAL_ERROR_COUNT = "";
UvVar DUE_TO_EXPIRE = "";
UvVar MEM_REC = "";
UvVar MEMBERSHIP_FOUND = "";
UvVar NO_OF_MEM_TYPES = "";
UvVar MEM_MVC = "";
UvVar MEM_EXPIRY = "";
UvVar TICKET_CODE = "";
UvVar TICKET_TYPE = "";
UvVar SALE_DATE = "";
UvVar SALE_TIME = "";
UvVar PERIOD = "";
FL355 FL355;
UvVar PRICE = "";
UvVar RESPONSE = "";
UvVar STORED_GROUP_VACANCIES = "";
UvVar GROUP_MULTIVALUE = "";
UvVar GROUP_NAME = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
FL755 FL755;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL754() {
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
/*     MANUAL RE-ENROLMENT */
PROMPT("");
PROGRAM = "FL754";
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
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

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
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
#region INCLUDE FL.FILES FL.MARKETING.DATA
if (!OPEN("FL.MARKETING.DATA", out FL_MARKETING_DATA)) { STOP("201", "FL.MARKETING.DATA"); }

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
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
if (BASKET_COUNT > 0) {
nrf0 = 85;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_INSTALMENT_VALUES = COURSE_PARAMS[2, 1];
MAX_PLACES = COURSE_PARAMS[10, 1];
PERMIT_BALANCE_TRANSFERS = COURSE_PARAMS[32, 1];
MARKETING_PROMPT = COURSE_PARAMS[42, 1];
FEE_TODAY = COURSE_PARAMS[49, 1];
DEFAULT_MARKETING_CODE = COURSE_PARAMS[43, 1];
CHECK_EXPIRY = COURSE_PARAMS[53, 1];
if (CHECK_EXPIRY == "") { CHECK_EXPIRY = "Y"; }
TRANSFER_ADJUSTMENTS = COURSE_PARAMS[54, 1];
/*  If new parameter is not defined, work off the older one which relates */
/*  to ad-hoc transfers too */
if (TRANSFER_ADJUSTMENTS == "") { TRANSFER_ADJUSTMENTS = PERMIT_BALANCE_TRANSFERS; }
if (MAX_PLACES == "") { MAX_PLACES = 999999; }
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
MAT(ref TEMP_REC, "");
STUDENT_SELECT_LIST = "";
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
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
/*  Release locks set during transfers/waiting list additions */
RELEASE();
AMENDING = TRUE;
INTERACT = INVALID_DATA;
SELECT_COUNT = COUNT(STUDENT_SELECT_LIST, TRUE);
UPDATE_INTERACT = "";
do {
INPUT_LINE = " # no,'ALL','NONE',<RET> to scroll, 'W'ait list or 'T'ransfer ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 5);
PRINT(AT(2, 21) + SPACE(75));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (SELECT_COUNT == 0 && ANS == "T") {
nrf0 = 46;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "T") {
/*  Transfer student(s) to another course */
INTERACT = INVALID_DATA;
do {
NEW_COURSE_DATE = "";
NEW_COURSE_ID = "";
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "  Enter the course to transfer to ('?' to scan) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(74));
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 13);
if (LEN(ANS) > 12) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 12); }
PRINT(AT(2, 21) + SPACE(70));
if (ANS == COMMON.HELP) {
DISPLAY_MODE = 1;
FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref NEW_COURSE_ID, ref NEW_COURSE_DATE, ref INTERACT, ref REDISPLAY);
if (INTERACT != EXIT) {
ANS = NEW_COURSE_ID;
}
L0100();
START_FIELD = 1;
END_FIELD = 4;
ACTION = SCROLL;
L6000();
L7000();
/* !*              END */
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT || ANS == "") {
INTERACT = EXIT;
/* *         CASE ANS = MAIN.KEY AND NEW.COURSE.DATE = OLD.COURSE.DATE */
/* *           INTERACT = INVALID.DATA */
/* *           CALL FL006(PROGRAM,13,INIT) */
}// CASE
else if (OTHERWISE) {
/*  Perform the updates */
INTERACT = VALID_DATA;
NEW_COURSE_ID = ANS;
if (NEW_COURSE_DATE == "") {
if (READ(ref NEW_COURSE_MSTR_REC, FL_COURSE_MASTER, ANS)) {
if (NEW_COURSE_MSTR_REC[11] != "") {
/*  Activity day course */
nrf0 = 70;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
/*  Set automatically if only one date exists for this course, otherwise */
/*  call up the selection box */
NEW_DATE_LIST = NEW_COURSE_MSTR_REC[2];
NO_MVS = DCOUNT(NEW_DATE_LIST, VM);
MVC = 1;
do {
if (MVC > NO_MVS) break;
TEST_DET_ID = NEW_DATE_LIST[1, MVC] + "*" + NEW_COURSE_ID;
if (!READ(ref TEST_DET_REC, FL_COURSE_DETAILS, TEST_DET_ID)) { TEST_DET_REC = ""; }
CLOSING_DATE = TEST_DET_REC[4];
if (CLOSING_DATE < TODAYS_DATE) {
NEW_DATE_LIST = DELETE(NEW_DATE_LIST, 1, MVC, 0);
NO_MVS = NO_MVS - 1;
} else {
MVC = MVC + 1;
}
} while (true);
if (NEW_DATE_LIST == "") {
nrf0 = 45;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref NEW_COURSE_ID);
INTERACT = INVALID_DATA;
} else {
NO_NEW_DATES = DCOUNT(NEW_DATE_LIST, VM);
if (NO_NEW_DATES == 1) {
NEW_COURSE_DATE = NEW_DATE_LIST;
} else {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + "  Select the required date for course : " + NEW_COURSE_ID);
DATE_LIST = NEW_DATE_LIST;
CREATION_ALLOWED = FALSE;
OLD_COURSE_CODE = PROG_MESS[2];
OLD_COURSE_DATE = PROG_MESS[3];
PROG_MESS[2] = NEW_COURSE_ID;
FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref NEW_COURSE_DATE, ref INTERACT, ref REDISPLAY);
L0100();
L0300();
STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
ACTION = SCROLL;
L7000();
PROG_MESS[2] = OLD_COURSE_CODE;
PROG_MESS[3] = OLD_COURSE_DATE;
}
}
}
} else {
nrf0 = 39;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
if (INTERACT == VALID_DATA) {
NEW_DETAILS_ID = NEW_COURSE_DATE + "*" + NEW_COURSE_ID;
if (READ(ref NEW_COURSE_DET_REC, FL_COURSE_DETAILS, NEW_DETAILS_ID)) {
if (NEW_COURSE_DET_REC[4] < TODAYS_DATE) {
nrf0 = 37;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
UPDATE_INTERACT = TRANSFER;
L5000();
}
} else {
nrf0 = 38;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref NEW_DETAILS_ID);
INTERACT = INVALID_DATA;
}
}
}
// END CASE
} while (true);
if (INTERACT == EXIT) { INTERACT = INVALID_DATA; }
}// CASE
else if (ANS == "W") {
/*  Transfer student(s) to a waiting list */
INTERACT = INVALID_DATA;
do {
ACTIVITY_CODE = "";
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "  Enter the waiting list to transfer to ('?' to scan) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(74));
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 13);
if (LEN(ANS) > 12) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 12); }
PRINT(AT(2, 21) + SPACE(70));
if (ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
L0100();
START_FIELD = 1;
END_FIELD = 4;
ACTION = SCROLL;
L6000();
L7000();
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT || ANS == "") {
INTERACT = EXIT;
}// CASE
else if (OTHERWISE) {
ACTIVITY_CODE = ANS;
INTERACT = VALID_DATA;
if (READ(ref TEST_REC, FL_ACTIVITY_CODES, ACTIVITY_CODE)) {
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE)) { MAT(ref WAIT_MAST_REC, ""); }
if (DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM) >= MAX_PLACES) {
nrf0 = 47;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + " Perform the addition to waiting list " + ACTIVITY_CODE + " ? (Y/N) ");
INPUT(out REPLY, 2);
}
// BEGIN CASE
// CASE
if (INTERACT == INVALID_DATA) {
NULL();
/*  No room on the waiting list */
}// CASE
else if (REPLY == "Y") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
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
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
/*  Already on waiting list */
if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, POS] != "P") {
WAIT_MAST_REC[WAIT_MAST_STATUS][1, POS] = "P";
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
}
} else {
/*  Create a waiting list student record IF NECESSARY */
if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID)) {
if (!(LOCATE(ACTIVITY_CODE, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref ACT_POS, "AL"))) {
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, -1] = ACTIVITY_CODE;
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, -1] = TODAYS_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
} else {
MAT(ref WAIT_STUDENT_REC, "");
if (!MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
/*  DJA 31.07.00 Most of these fields will be null */
/*               if student is a member */
WAIT_STUDENT_REC[WAIT_STUD_TITLE] = STUDENT_REC[STUDENT_TITLE];
WAIT_STUDENT_REC[WAIT_STUD_FORENAME] = STUDENT_REC[STUDENT_FORENAME];
WAIT_STUDENT_REC[WAIT_STUD_SURNAME] = STUDENT_REC[STUDENT_SURNAME];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] = STUDENT_REC[STUDENT_ADDRESS1];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] = STUDENT_REC[STUDENT_ADDRESS2];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] = STUDENT_REC[STUDENT_ADDRESS3];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] = STUDENT_REC[STUDENT_ADDRESS4];
WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] = STUDENT_REC[STUDENT_POST_CODE];
WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME] = STUDENT_REC[STUDENT_HOME_TEL];
WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK] = STUDENT_REC[STUDENT_WORK_TEL];
WAIT_STUDENT_REC[WAIT_STUD_MEDICAL] = STUDENT_REC[STUDENT_MEDICAL1];
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, -1] = ACTIVITY_CODE;
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, -1] = TODAYS_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
PRIORITY_POS = 1;
do {
if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, PRIORITY_POS] != "P" || PRIORITY_POS > NO_MVS) break;
PRIORITY_POS = PRIORITY_POS + 1;
} while (true);
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, PRIORITY_POS, 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, PRIORITY_POS, 0, "P");
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
}
XFER_LIST[1, STUDENT_MVC] = TRUE;
STUDENT_SELECT_LIST[1, STUDENT_MVC] = "";
}
STUDENT_MVC = STUDENT_MVC + 1;
} while (true);
STUDENT_COUNT = 1;
ACTION = SCROLL;
L7000();
}
} else {
nrf0 = 30;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ACTIVITY_CODE);
INTERACT = INVALID_DATA;
}
}
// END CASE
} while (true);
if (INTERACT == EXIT) { INTERACT = INVALID_DATA; }
}// CASE
else if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N")) {
/*  Validate, then high/lowlight a particular student */
// BEGIN CASE
// CASE
if (ANS > DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM) || ANS == 0) {
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (XFER_LIST[1, ANS] == TRUE) {
nrf0 = 29;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
if (STUDENT_SELECT_LIST[1, ANS] == TRUE) {
STUDENT_SELECT_LIST[1, ANS] = INIT;
ERROR_LIST[1, ANS] = INIT;
} else {
// BEGIN CASE
// CASE
if (BALANCE_LIST[1, ANS] > "0") {
nrf0 = 51;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
/*  DJA 20.10.99 */
}// CASE
else if (BALANCE_LIST[1, ANS] < 0) {
nrf0 = 52;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
STUDENT_SELECT_LIST[1, ANS] = TRUE;
}
TOGGLE_POS = ANS;
ACTION = TOGGLE;
L7000();
INTERACT = VALID_DATA;
}
// END CASE
}// CASE
else if (ANS == "ALL") {
BALANCE_WARNING = FALSE;
for(N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1) {
if (XFER_LIST[1, N] != TRUE) {
STUDENT_SELECT_LIST[1, N] = TRUE;
// BEGIN CASE
// CASE
if (BALANCE_LIST[1, N] > 0) {
BALANCE_WARNING = TRUE;
/*  DJA 20.10.99 */
}// CASE
else if (BALANCE_LIST[1, N] < 0) {
nrf0 = 52;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
}
}
if (BALANCE_WARNING == TRUE) {
nrf0 = 51;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
ACTION = SCROLL;
L7000();
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "NONE") {
for(N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1) {
STUDENT_SELECT_LIST[1, N] = "";
}
STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
ACTION = SCROLL;
L7000();
INTERACT = VALID_DATA;
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
case 3: L1200(); break;
case 4: L1200(); break;
case 5: L1200(); break;
case 6: L1200(); break;
case 7: L1200(); break;
case 8: L1200(); break;
case 9: L1200(); break;
case 10: L1200(); break;
case 11: L1200(); break;
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
/*   Course Code Validation Routine */
INTERACT = VALID_DATA;
// BEGIN CASE
/*  Scan for required course if the 'help' key is entered */
// CASE
if (ANS == COMMON.HELP && AMENDING == FALSE) {
DISPLAY_MODE = 2;
SCAN_STUDENT_ID = "";
FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
/*  Refresh screen */
L0100();
if (INTERACT != EXIT) {
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
ANS = COURSE_ID;
MAIN_KEY = ANS;
PROG_MESS[2] = COURSE_ID;
PROG_MESS[3] = COURSE_DATE;
DETAILS_ID = COURSE_DATE + "*" + MAIN_KEY;
if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) { MAT(ref COURSE_MSTR_REC, ""); }
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "") {
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 4;
ACTION = FIRST_CALL;
L6000();
/*  Display selected field data */
L7000();
/*  Display window */
/*            AMENDING = TRUE */
OLD_COURSE_DATE = COURSE_DATE;
L0300();
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
}
} else {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
ANS = "";
VALUE = "";
MAIN_KEY = "";
}
} else {
INTERACT = INVALID_DATA;
}
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
if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) {
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "") {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
ANS = "";
VALUE = "";
MAIN_KEY = "";
} else {
/*  Call date selection window */
DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
CREATION_ALLOWED = FALSE;
if (DCOUNT(DATE_LIST, VM) == 1) {
SELECT_DATE = DATE_LIST;
INTERACT = VALID_DATA;
REDISPLAY = "";
} else {
FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref SELECT_DATE, ref INTERACT, ref REDISPLAY);
}
/*  If box is abandoned, reprompt for course code */
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
MAIN_KEY = "";
ANS = "";
VALUE = "";
PROG_MESS[2] = "";
AMENDING = FALSE;
} else {
INTERACT = VALID_DATA;
}
if (REDISPLAY) {
L0100();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(MAIN_KEY, ST_JUST));
REDISPLAY = "";
}
if (INTERACT == VALID_DATA) {
/*  Existing course */
PROG_MESS[3] = SELECT_DATE;
DETAILS_ID = SELECT_DATE + "*" + MAIN_KEY;
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 4;
ACTION = FIRST_CALL;
L6000();
/*  Display selected field data */
L7000();
/*  Display window */
AMENDING = FALSE;
OLD_COURSE_DATE = SELECT_DATE;
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 22;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
MAIN_KEY = "";
PROG_MESS[2] = "";
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
else if (ANS == "" && MAIN_KEY != "") {
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
void L1200() {
/*   DUMMY Validation Routine (Display only fields) */
INTERACT = VALID_DATA;
return;
/* ********************************************* */
}
void L4000() {
/*   Batch updates.                        * */
/* ********************************************* */
INTERACT = INVALID_DATA;
/*  Remove student(s) from course */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
/*  DJA 19.10.99 */
NEW_DD = OCONV(FIELD(NEW_DETAILS_ID, "*", 1), "D2.").Substring(1, 2);
NEW_MM = OCONV(FIELD(NEW_DETAILS_ID, "*", 1), "D2.").Substring(4, 2);
NEW_DD_MM = NEW_DD + "/" + NEW_MM;
PRINT(AT(2, 21) + " Perform the transfer to course " + NEW_COURSE_ID + " (" + NEW_DD_MM + ") ? ");
INPUT(out REPLY, 2);
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
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
ENROL_ID = PROG_MESS[3] + "*" + PROG_MESS[2] + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
ENROL_REC[ENROL_CONCESSION] = TRIM(ENROL_REC[ENROL_CONCESSION][1, 1]);
/*  Note : for transfers the new concession group vacancies have already */
/*         been reduced as part of the validation */
if (UPDATE_INTERACT == TRANSFER) {
/*  Apply fee for new course and, if necessary, apply payments from old one */
if (ADJUSTMENT_LIST[1, STUDENT_MVC] != 0 && TRANSFER_ADJUSTMENTS == "Y") {
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
/*  Contra Adjustment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -ADJUSTMENT_LIST[1, STUDENT_MVC];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "TRANSFER CREDIT/DEBT";
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - ADJUSTMENT_LIST[1, STUDENT_MVC];
}
if (LOCATE(ENROL_REC[ENROL_CONCESSION], NEW_TICK_FEES_CONCESSIONS, 1, 0, 1, ref CONCESS_POS, "AL")) {
ENROL_REC[ENROL_PRICE] = NEW_TICK_FEES_PEAK_PRICES[1, CONCESS_POS];
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
NEW_COURSE_DATE = FIELD(NEW_DETAILS_ID, "*", 1);
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "O";
/*  Course Fee */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = ENROL_REC[ENROL_PRICE];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + ENROL_REC[ENROL_PRICE];
}
if (ADJUSTMENT_LIST[1, STUDENT_MVC] != 0 && TRANSFER_ADJUSTMENTS == "Y") {
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
/*  Adjustment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = ADJUSTMENT_LIST[1, STUDENT_MVC];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "TRANSFER CREDIT/DEBT";
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + ADJUSTMENT_LIST[1, STUDENT_MVC];
}
if (ENROL_REC[ENROL_INST_DATES] != "") {
/*  Recalculate new balance for this course, and then the new inst. profile */
COURSE_BALANCE = ENROL_REC[ENROL_PRICE];
/*  Next 3 fields are redundant */
ENROL_REC[ENROL_ODD_INSTALMENT] = "";
ENROL_REC[ENROL_OTHER_INSTALMENT] = "";
ENROL_REC[ENROL_NO_INSTALMENTS] = "";
INST_PLAN_TOTAL = ENROL_REC[ENROL_PRICE];
NO_WEEKS = INT(((NEW_COURSE_DET_REC[2] - NEW_COURSE_DATE) / 7)) + 1;
INST_FIRST_DUE = NEW_COURSE_DATE;
INST_NUMBER = NO_WEEKS;
INST_VALUE = "";
INST_FREQUENCY = "W";
INST_DATES = "";
INST_AMOUNTS = "";
RECALC = TRUE;
UNPAID_FEE = ENROL_REC[ENROL_PRICE];
DISPLAY_PLAN = FALSE;
FL749 = new FL749(ref STUDENT_ID, ref COURSE_ID, ref STUDENT_REC, ref RECALC, ref DISPLAY_PLAN, ref UNPAID_FEE, ref INST_PLAN_TOTAL, ref INST_FIRST_DUE, ref INST_NUMBER, ref INST_VALUE, ref INST_FREQUENCY, ref INST_DATES, ref INST_AMOUNTS, ref INTERACT, ref REDISPLAY);
ENROL_REC[ENROL_INST_PLAN_TOTAL] = INST_PLAN_TOTAL;
ENROL_REC[ENROL_INST_FIRST_DUE] = INST_FIRST_DUE;
ENROL_REC[ENROL_INST_NUMBER] = INST_NUMBER;
ENROL_REC[ENROL_INST_VALUE] = INST_VALUE;
ENROL_REC[ENROL_INST_FREQUENCY] = INST_FREQUENCY;
ENROL_REC[ENROL_INST_DATES] = INST_DATES;
ENROL_REC[ENROL_INST_AMOUNTS] = INST_AMOUNTS;
INTERACT = VALID_DATA;
}
ENROL_REC[ENROL_FULL_PRICE] = "";
ENROL_REC[ENROL_FEE_OVERRIDE_USER] = "";
ENROL_REC[ENROL_PREFERRED_COURSE1] = "";
ENROL_REC[ENROL_PREFERRED_COURSE2] = "";
ENROL_REC[ENROL_PREFERRED_COURSE3] = "";
ENROL_REC[ENROL_PREFERENCES_DATE] = "";
ENROL_REC[ENROL_PREFERENCES_TIME] = "";
NEW_ENROL_ID = NEW_DETAILS_ID + "*" + STUDENT_ID;
NEW_COURSE_DET_REC[21, -1] = STUDENT_ID;
/*  Student Id's */
NEW_COURSE_DET_REC[16] = NEW_COURSE_DET_REC[16] - 1;
/*  Vacs */
MATWRITE(ENROL_REC, FL_ENROLMENT, NEW_ENROL_ID);
WRITE(NEW_COURSE_DET_REC, FL_COURSE_DETAILS, NEW_DETAILS_ID);
STUDENT_REC[STUDENT_DETAIL_IDS][1, -1] = NEW_DETAILS_ID;
}
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
/* ************************************************* */
if (MARKETING_PROMPT == "Y") {
if (!READU(ref MARKETING_SEQ, FL_COURSE_PARAMS, "MARKETING.SEQ")) { MARKETING_SEQ = 0; }
MARKETING_SEQ = MARKETING_SEQ + 1;
MDATA_REC[MDATA_CODE] = DEFAULT_MARKETING_CODE;
MDATA_REC[MDATA_ENROLMENT_DATE] = TODAYS_DATE;
MDATA_REC[MDATA_STUDENT_ID] = STUDENT_ID;
MATWRITE(MDATA_REC, FL_MARKETING_DATA, MARKETING_SEQ);
WRITE(MARKETING_SEQ, FL_COURSE_PARAMS, "MARKETING.SEQ");
}
/* ************************************************* */
/* !*        STUDENT.SELECT.LIST = DELETE(STUDENT.SELECT.LIST,1,STUDENT.MVC,0) */
/* !*        STUDENT.LIST        = DELETE(STUDENT.LIST,1,STUDENT.MVC,0) */
/* !*        SURNAME.LIST        = DELETE(SURNAME.LIST,1,STUDENT.MVC,0) */
/* !*        FULL.NAME.LIST      = DELETE(FULL.NAME.LIST,1,STUDENT.MVC,0) */
/* !*        CONCESS.LIST        = DELETE(CONCESS.LIST,1,STUDENT.MVC,0) */
/* !*        BALANCE.LIST        = DELETE(BALANCE.LIST,1,STUDENT.MVC,0) */
/* !*        INSTALMENT.LIST        = DELETE(INSTALMENT.LIST,1,STUDENT.MVC,0) */
/* !*        NO.STUDENTS   = NO.STUDENTS - 1 */
XFER_LIST[1, STUDENT_MVC] = TRUE;
STUDENT_SELECT_LIST[1, STUDENT_MVC] = "";
STUDENT_MVC = STUDENT_MVC + 1;
} else {
STUDENT_MVC = STUDENT_MVC + 1;
}
} while (true);
STUDENT_COUNT = 1;
ACTION = SCROLL;
L7000();
}
return;
/* ******************************************** */
}
void L5000() {
/*   Transfer(s) to another course         * */
/* ******************************************** */
/*  NEW.DETAILS.ID is made up from NEW.COURSE.ID and NEW.COURSE.DATE */
/*  NEW.COURSE.DET.REC is a dynamic equivalent of COURSE.DET.REC */
/*  Loop to check for overall & concession vacancies on new course */
/*  Check also the required concessions apply to the new course too and */
/*  that each individual is not already enrolled on the new course. */
/*  Flag invalid transfers and block the WHOLE transfer.  Remember to */
/*  un-flag transfers which BECOME valid.  (Flag = !) */
INTERACT = VALID_DATA;
ERROR_COUNT = 0;
NO_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
L5200();
/*  Check not already enrolled on new course */
if (INTERACT == VALID_DATA) {
L5400();
if (INTERACT == VALID_DATA) {
/*  DJA 28.11.05 */
if (CHECK_EXPIRY == "Y") { L5500(); }
if (INTERACT == VALID_DATA) {
L5600();
}
}
}
if (INTERACT == VALID_DATA) {
/*  Now update the new course and downdate the old one */
L4000();
}
return;
/* ********************************************************** */
}
void L5200() {
/*   Check for 'already enrolled on new course          * */
/* ********************************************************** */
STUDENT_MVC = 1;
do {
if (STUDENT_MVC > NO_STUDENTS) break;
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
if (LOCATE(STUDENT_ID, NEW_COURSE_DET_REC, 21, 0, 1, ref TEST_POS, "AL")) {
ERROR_COUNT = ERROR_COUNT + 1;
ERROR_LIST[1, STUDENT_MVC] = "!";
ACTION = TOGGLE;
TOGGLE_POS = STUDENT_MVC;
L7000();
} else {
/*  If previously 'in error', clear the flag now */
if (ERROR_LIST[1, STUDENT_MVC] != "") {
ERROR_LIST[1, STUDENT_MVC] = "";
ACTION = TOGGLE;
TOGGLE_POS = STUDENT_MVC;
L7000();
}
}
}
STUDENT_MVC = STUDENT_MVC + 1;
} while (true);
if (ERROR_COUNT > 0) {
nrf0 = 40;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ERROR_COUNT);
INTERACT = INVALID_DATA;
}
return;
/* ********************************************************** */
}
void L5400() {
/*   Check for overall vacancies on new course          * */
/* ********************************************************** */
NEW_VACANCIES = NEW_COURSE_DET_REC[16];
NO_TO_XFER = COUNT(STUDENT_SELECT_LIST, TRUE);
if (NO_TO_XFER <= NEW_VACANCIES) {
INTERACT = VALID_DATA;
} else {
STUDENT_MVC = NO_STUDENTS;
ERROR_COUNT = NO_TO_XFER - NEW_VACANCIES;
COUNTDOWN = ERROR_COUNT;
do {
if (COUNTDOWN <= 0 || STUDENT_MVC <= 0) break;
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
ERROR_LIST[1, STUDENT_MVC] = "!";
COUNTDOWN = COUNTDOWN - 1;
}
STUDENT_MVC = STUDENT_MVC - 1;
} while (true);
ACTION = SCROLL;
STUDENT_COUNT = 1;
L7000();
nrf0 = 42;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ERROR_COUNT);
INTERACT = INVALID_DATA;
}
return;
/* ********************************************************** */
}
void L5500() {
/*   Check membership(s) won't expire before new course * */
/*       starts                                             * */
/* ********************************************************** */
INITIAL_ERROR_COUNT = ERROR_COUNT;
STUDENT_MVC = 1;
do {
if (STUDENT_MVC > NO_STUDENTS) break;
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
DUE_TO_EXPIRE = FALSE;
if (READ(ref MEM_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
MEMBERSHIP_FOUND = FALSE;
NO_OF_MEM_TYPES = DCOUNT(MEM_REC[2], VM);
MEM_MVC = 1;
do {
if (MEMBERSHIP_FOUND || MEM_MVC > NO_OF_MEM_TYPES) break;
MEM_EXPIRY = MEM_REC[13, MEM_MVC];
if (MEM_EXPIRY >= NEW_COURSE_DATE) {
MEMBERSHIP_FOUND = TRUE;
}
MEM_MVC = MEM_MVC + 1;
} while (true);
if (NOT(MEMBERSHIP_FOUND)) { DUE_TO_EXPIRE = TRUE; }
}
if (DUE_TO_EXPIRE) {
ERROR_COUNT = ERROR_COUNT + 1;
ERROR_LIST[1, STUDENT_MVC] = "!";
ACTION = TOGGLE;
TOGGLE_POS = STUDENT_MVC;
L7000();
} else {
/*  If previously 'in error', clear the flag now */
if (ERROR_LIST[1, STUDENT_MVC] != "") {
ERROR_LIST[1, STUDENT_MVC] = "";
ACTION = TOGGLE;
TOGGLE_POS = STUDENT_MVC;
L7000();
}
}
}
STUDENT_MVC = STUDENT_MVC + 1;
} while (true);
if (ERROR_COUNT > INITIAL_ERROR_COUNT) {
nrf0 = 43;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ERROR_COUNT);
INTERACT = INVALID_DATA;
}
return;
/* ********************************************************** */
}
void L5600() {
/*   Check concession group vacancies                   * */
/* ********************************************************** */
TICKET_CODE = "C*" + NEW_COURSE_DET_REC[8];
TICKET_TYPE = "C";
/*  DJA 26.1.05 */
/* !IF FEE.TODAY = "Y" THEN */
/* !  SALE.DATE   = TODAYS.DATE */
/* !END ELSE */
SALE_DATE = NEW_COURSE_DATE;
/* !END */
SALE_TIME = TIME();
PERIOD = "";
FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
/*  Store new concession price details for updates */
NEW_TICK_FEES_CONCESSIONS = TICK_FEES_REC[TICK_FEES_CONCESSIONS];
NEW_TICK_FEES_PEAK_PRICES = TICK_FEES_REC[TICK_FEES_PEAK_PRICES];
STUDENT_MVC = 1;
STORED_GROUP_VACANCIES = NEW_COURSE_DET_REC[20];
do {
if (STUDENT_MVC > NO_STUDENTS) break;
STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
GROUP_MULTIVALUE = "";
ENROL_ID = PROG_MESS[3] + "*" + PROG_MESS[2] + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
ENROL_REC[ENROL_CONCESSION] = TRIM(ENROL_REC[ENROL_CONCESSION][1, 1]);
if (LOCATE(ENROL_REC[ENROL_CONCESSION], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL")) {
GROUP_NAME = NEW_COURSE_DET_REC[17, CONCESS_POS];
if (GROUP_NAME != "") {
if (LOCATE(GROUP_NAME, NEW_COURSE_DET_REC, 18, 0, 1, ref GROUP_MULTIVALUE, "AL")) {
if (NEW_COURSE_DET_REC[20, GROUP_MULTIVALUE] <= 0) {
ERROR_COUNT = ERROR_COUNT + 1;
ERROR_LIST[1, STUDENT_MVC] = "!";
} else {
NEW_COURSE_DET_REC[20, GROUP_MULTIVALUE] = NEW_COURSE_DET_REC[20, GROUP_MULTIVALUE] - 1;
}
}
}
} else {
ERROR_COUNT = ERROR_COUNT + 1;
ERROR_LIST[1, STUDENT_MVC] = "!";
}
}
STUDENT_MVC = STUDENT_MVC + 1;
} while (true);
if (ERROR_COUNT > 0) {
/*  Restore vacancies back to what they were ready for subsequent attempt */
NEW_COURSE_DET_REC[20] = STORED_GROUP_VACANCIES;
INTERACT = INVALID_DATA;
STUDENT_COUNT = 1;
ACTION = SCROLL;
L7000();
nrf0 = 41;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ERROR_COUNT);
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
return;
}
void L7000() {
/*   DISPLAY ONE SCREENFUL OF STUDENTS */
nrf0 = COURSE_DET_REC[COURSE_DET_STUDENT_IDS];
FL755 = new FL755(ref ACTION, ref TOGGLE_POS, ref STUDENT_SELECT_LIST, ref nrf0, ref REDISPLAY, ref STUDENT_COUNT, ref STUDENT_LIST, ref SURNAME_LIST, ref FULL_NAME_LIST, ref CONCESS_LIST, ref BALANCE_LIST, ref ADJUSTMENT_LIST, ref INSTALMENT_LIST, ref ERROR_LIST, ref XFER_LIST, ref WINDOW_DEPTH);
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = COURSE_MSTR_REC[COURSE_MSTR_DESC];
TEMP_REC[2] = PROG_MESS[3];
TEMP_REC[3] = COURSE_DET_REC[COURSE_DET_END];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
