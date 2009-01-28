//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL741 : UvBase
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
readonly UvVar WAIT_MAST_IDS = 1;
readonly UvVar WAIT_MAST_STATUS = 2;
readonly UvVar CAL_TEXT = 1;
readonly UvVar CAL_TYPE = 2;
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
readonly UvVar FL_CONTROL = 10;
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
UvVar[] TICKET_REC = new UvVar[40];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] CALENDAR_REC = new UvVar[10];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] TEMP_REC = new UvVar[50];
UvVar[] NEW_COURSE_DETAILS_ARRAY = new UvVar[25];
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
UvVar FL_MULTIPAY = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar COURSE_COMMENT_TAGS = "";
UvVar MULTIPAY_REC = "";
UvVar BATCH_HEADCOUNTS = "";
UvVar BASKET_COUNT = "";
FL006 FL006;
UvVar TICKET_PRINT_ROUTINE = "";
UvVar COURSE_PARAMS = "";
UvVar COMMENTS_PRINTED = "";
UvVar GET_INSTALMENT_VALUES = "";
UvVar PRO_RATA_FEE = "";
UvVar PERMIT_BALANCE_TRANSFERS = "";
UvVar FEE_TODAY = "";
UvVar FL741_PARAMS = "";
UvVar CROSS_CENTRE_XFERS = "";
UvVar DIFFERENCE_ADJUSTMENTS = "";
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
UvVar REDEEMED_UPON_ENROLMENT = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar NEW_COURSE_MSTR_REC = "";
UvVar NEW_COURSE_DATE = "";
UvVar NEW_COURSE_ID = "";
UvVar DISPLAY_MODE = "";
FL717 FL717;
UvVar SCAN_STUDENT_ID = "";
UvVar REDISPLAY = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
UvVar ACTION = "";
UvVar NEW_COURSE_MSTR_CENTRE = "";
UvVar NEW_DATE_LIST = "";
UvVar NO_MVS = "";
UvVar MVC = "";
UvVar TEST_DET_ID = "";
UvVar TEST_DET_REC = "";
UvVar END_DATE = "";
UvVar NO_NEW_DATES = "";
UvVar DATE_LIST = "";
UvVar CREATION_ALLOWED = "";
UvVar OLD_COURSE_CODE = "";
UvVar OLD_COURSE_DATE = "";
FL704 FL704;
UvVar NEW_COURSE = "";
UvVar STUDENT_COUNT = "";
UvVar NEW_DETAILS_ID = "";
UvVar NEW_COURSE_DET_REC = "";
UvVar ERROR_LIST = "";
UvVar STUDENT_LIST = "";
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
UvVar REPLY = "";
UvVar TICKET_REPLY = "";
UvVar CONTINUE = "";
UvVar NO_STUDENTS = "";
UvVar STUDENT_MVC = "";
UvVar STUDENT_ID = "";
UvVar ENROL_ID = "";
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
UvVar ORIGINAL_STUDENT_BALANCE = "";
UvVar NO_TRANS = "";
UvVar PAYMENT_LIST = "";
UvVar ADJUSTMENT_LIST = "";
UvVar OLD_ENROL_PRICE = "";
UvVar NEW_TICK_FEES_CONCESSIONS = "";
UvVar FOUND_IT = "";
UvVar NEW_TICK_FEES_PEAK_PRICES = "";
UvVar ORIGINAL_TICKET_TOTAL = "";
UvVar REMAINING_SESSIONS = "";
UvVar TOTAL_SESSIONS = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar PRICE_DIFFERENCE = "";
UvVar MSG = "";
UvVar FIRST_TRANS_POS = "";
UvVar BALANCE_DIFFERENCE = "";
UvVar ADJ_REPLY = "";
UvVar COURSE_BALANCE = "";
UvVar TRANS_NO = "";
UvVar NO_WEEKS = "";
UvVar INST_PLAN_TOTAL = "";
UvVar INST_NUMBER = "";
UvVar INST_VALUE = "";
UvVar INST_FIRST_DUE = "";
UvVar INST_FREQUENCY = "";
UvVar INST_DATES = "";
UvVar INST_AMOUNTS = "";
UvVar RECALC = "";
UvVar UNPAID_FEE = "";
UvVar DISPLAY_PLAN = "";
FL749 FL749;
UvVar NEW_ENROL_ID = "";
UvVar COURSE_FEE = "";
UvVar TEST_REC = "";
UvVar COURSE_CODE = "";
UvVar STUDENT_NAME = "";
UvVar NARRATIVE = "";
UvVar NARR_MV = "";
UvVar NEW_COURSE_BALANCE = "";
UvVar TICK_REC = "";
UvVar TICK_ID = "";
UvVar PRINT_TICKET_NO = "";
UvVar SESSION_NO = "";
FL000_12 FL000_12;
UvVar ATT = "";
CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
FL000_15 FL000_15;
UvVar SURNAME_LIST = "";
UvVar FULL_NAME_LIST = "";
UvVar CONCESS_LIST = "";
UvVar BALANCE_LIST = "";
UvVar NO_WAITING = "";
UvVar THIS_DET_ID = "";
UvVar THIS_TYPE = "";
UvVar ERROR_COUNT = "";
UvVar NEW_VACANCIES = "";
UvVar NO_TO_XFER = "";
UvVar COUNTDOWN = "";
UvVar STORED_GROUP_VACANCIES = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
FL742 FL742;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
UvVar nrf4 = "";
UvVar nrf5 = "";
#endregion
public FL741() {
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
/*     ENROLMENT CHANGES */
PROMPT("");
PROGRAM = "FL741";
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
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.CALENDAR
if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

/*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

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
if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
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
PRO_RATA_FEE = COURSE_PARAMS[31, 1];
PERMIT_BALANCE_TRANSFERS = COURSE_PARAMS[32, 1];
FEE_TODAY = COURSE_PARAMS[49, 1];
if (!READ(ref FL741_PARAMS, FL_COURSE_PARAMS, "FL741.PARAMS")) { FL741_PARAMS = ""; }
CROSS_CENTRE_XFERS = FL741_PARAMS[1, 1];
DIFFERENCE_ADJUSTMENTS = FL741_PARAMS[2, 1];
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
SELECT_COUNT = COUNT(STUDENT_SELECT_LIST, TRUE);
UPDATE_INTERACT = "";
REDEEMED_UPON_ENROLMENT = FALSE;
/*  Prevents VNA for 'R'emovals */
do {
INPUT_LINE = " Select student,'ALL','NONE',<RET> to scroll,'T'ransfer or 'R'emove ";
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
else if (SELECT_COUNT == 0 && (ANS == "T" || ANS == "R")) {
nrf0 = 46;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "R") {
UPDATE_INTERACT = REMOVEIT;
L4000();
/*  Remove students */
}// CASE
else if (ANS == "T") {
/*  Transfer student(s) to another course */
INTERACT = INVALID_DATA;
/*  DJA 16.9.03 */
NEW_COURSE_MSTR_REC = "";
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
DISPLAY_MODE = 2;
/*  Changed by Des 11.12.02 (from '1') for Tenterden */
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
if (INTERACT != EXIT) {
if (!READV(ref NEW_COURSE_MSTR_CENTRE, FL_COURSE_MASTER, ANS, 4)) { NEW_COURSE_MSTR_CENTRE = ""; }
if (NEW_COURSE_MSTR_CENTRE != COURSE_MSTR_REC[COURSE_MSTR_CENTRE] && CROSS_CENTRE_XFERS != "Y") {
nrf0 = 50;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
}
}
/* !*              END */
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT || ANS == "") {
INTERACT = EXIT;
/* DJA 18.7.01*       CASE ANS = MAIN.KEY */
/* DJA 18.7.01*          INTERACT = INVALID.DATA */
/* DJA 18.7.01*          CALL FL006(PROGRAM,13,INIT) */
}// CASE
else if (OTHERWISE) {
/*  Perform the updates */
INTERACT = VALID_DATA;
NEW_COURSE_ID = ANS;
if (NEW_COURSE_DATE == "") {
if (READ(ref NEW_COURSE_MSTR_REC, FL_COURSE_MASTER, ANS)) {
// BEGIN CASE
// CASE
if (NEW_COURSE_MSTR_REC[11] != "") {
/*  Activity day course */
nrf0 = 70;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (NEW_COURSE_MSTR_REC[4] != COURSE_MSTR_REC[COURSE_MSTR_CENTRE] && CROSS_CENTRE_XFERS != "Y") {
nrf0 = 50;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
/*  Set automatically if only one date exists for this course, otherwise */
/*  call up the selection box */
NEW_DATE_LIST = NEW_COURSE_MSTR_REC[2];
NO_MVS = DCOUNT(NEW_DATE_LIST, VM);
MVC = 1;
do {
if (MVC > NO_MVS) break;
TEST_DET_ID = NEW_DATE_LIST[1, MVC] + "*" + NEW_COURSE_ID;
if (!READ(ref TEST_DET_REC, FL_COURSE_DETAILS, TEST_DET_ID)) { TEST_DET_REC = ""; }
/* DJA 21.01.04*               CLOSING.DATE = TEST.DET.REC<4> */
END_DATE = TEST_DET_REC[2];
/* DJA 21.01.04*               IF CLOSING.DATE < TODAYS.DATE THEN */
if (END_DATE < TODAYS_DATE) {
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
// END CASE
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
// BEGIN CASE
/* DJA 21.1.04*           CASE NEW.COURSE.DET.REC<4> < TODAYS.DATE */
// CASE
if (NEW_COURSE_DET_REC[2] < TODAYS_DATE) {
nrf0 = 37;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
UPDATE_INTERACT = TRANSFER;
L5000();
}
// END CASE
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
else if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N")) {
/*  Validate, then high/lowlight a particular student */
if (ANS > DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM) || ANS == 0) {
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
INTERACT = VALID_DATA;
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
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "") {
INTERACT = INVALID_DATA;
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
VALUE = "";
MAIN_KEY = "";
} else {
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
INTERACT = INVALID_DATA;
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
if (UPDATE_INTERACT == REMOVEIT) {
PRINT(AT(2, 21) + " Do you wish to remove the selected individuals from this course? ");
} else {
PRINT(AT(2, 21) + " Perform the transfer to course " + NEW_COURSE_ID + " ? ");
}
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
TICKET_REPLY = "N";
if (INTERACT == VALID_DATA) {
if (UPDATE_INTERACT == TRANSFER) {
CONTINUE = FALSE;
do {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + " Do you require printed tickets for moved students? ");
INPUT(out TICKET_REPLY, 2);
TICKET_REPLY = OCONV(TICKET_REPLY, "MCU");
// BEGIN CASE
// CASE
if (TICKET_REPLY == "Y") {
CONTINUE = TRUE;
}// CASE
else if (TICKET_REPLY == "N") {
CONTINUE = TRUE;
}// CASE
else if (OTHERWISE) {
NULL();
}
// END CASE
if (!(CONTINUE == FALSE)) break;
} while (true);
}
NO_STUDENTS = DCOUNT(STUDENT_LIST, VM);
STUDENT_MVC = 1;
do {
if (STUDENT_MVC > NO_STUDENTS) break;
if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE) {
STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
ENROL_ID = PROG_MESS[3] + "*" + PROG_MESS[2] + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
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
/*  DJA 26.1.05 */
if (FEE_TODAY == "Y") {
SALE_DATE = TODAYS_DATE;
} else {
SALE_DATE = PROG_MESS[3];
}
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
DETAILS_ID = PROG_MESS[3] + "*" + PROG_MESS[2];
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL")) {
STUDENT_REC[STUDENT_DETAIL_IDS] = DELETE(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0);
}
ORIGINAL_STUDENT_BALANCE = STUDENT_REC[STUDENT_BALANCE];
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
/*  DJA 2.6.06 */
if (UPDATE_INTERACT == REMOVEIT) {
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "";
} else {
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "MOVEMENT";
}
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - ENROL_REC[ENROL_PRICE];
if (UPDATE_INTERACT == TRANSFER) {
if (PAYMENT_LIST[1, STUDENT_MVC] != 0) {
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "R";
/*  Refund */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -PAYMENT_LIST[1, STUDENT_MVC];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "TRANSFER PAYMENT";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - PAYMENT_LIST[1, STUDENT_MVC];
}
if (ADJUSTMENT_LIST[1, STUDENT_MVC] != 0 && PERMIT_BALANCE_TRANSFERS == "Y") {
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
OLD_ENROL_PRICE = ENROL_REC[ENROL_PRICE];
/*  Apply fee for new course and, if necessary, apply payments from old one */
if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], NEW_TICK_FEES_CONCESSIONS, 1, 0, 1, ref CONCESS_POS, "AL")) {
/*  If the student joined the original course late */
/*  (after week 3 at Birmingham) then they were charged */
/*  a reduced fee based on a later effective date set. So */
/*  make sure the same effective date (i.e. the date they joined) */
/*  is used when transferring them to the new course */
if (FEE_TODAY == "Y") {
/*  Find date of original enrolment */
L4010();
if (FOUND_IT == FALSE) {
ENROL_REC[ENROL_PRICE] = NEW_TICK_FEES_PEAK_PRICES[1, CONCESS_POS];
} else {
/*  Re-call FL355 */
TICKET_CODE = "C*" + NEW_COURSE_DET_REC[8];
FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
ENROL_REC[ENROL_PRICE] = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESS_POS];
}
} else {
/*  Use the prices which were snap-shotted when checking */
/*  the concession group vacancies */
ENROL_REC[ENROL_PRICE] = NEW_TICK_FEES_PEAK_PRICES[1, CONCESS_POS];
/* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! */
/*  DJA 15.11.05 If fee would originally have */
/*               been pro-rata'd then do the same */
/*               now, using the original date of */
/*               enrolment */
/* !!                    CRT "PRO.RATA.FEE=":PRO.RATA.FEE:"  SALE.DATE=":SALE.DATE:"  PM<3>=":PROG.MESS<3>:;INPUT FLEX,2: */
/*  Find date of original enrolment */
L4010();
if (PRO_RATA_FEE == "Y" && SALE_DATE > PROG_MESS[3]) {
ORIGINAL_TICKET_TOTAL = ENROL_REC[ENROL_PRICE];
REMAINING_SESSIONS = 0;
TOTAL_SESSIONS = 0;
EX_DATE = PROG_MESS[3];
do {
if (EX_DATE > COURSE_DET_REC[COURSE_DET_END]) break;
COURSE_DATE = PROG_MESS[3];
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
DATE_QUALIFIES = FALSE;
}
}
}
if (DATE_QUALIFIES) {
TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
/*  We don't know the time of the original sale. Where there was a session */
/*  on the date of the sale, assume the customer enrolled in time to */
/*  attend that session, i.e. it is chargeable */
if (EX_DATE >= SALE_DATE) {
REMAINING_SESSIONS = REMAINING_SESSIONS + 1;
}
}
}
EX_DATE = EX_DATE + 1;
} while (true);
if (REMAINING_SESSIONS < TOTAL_SESSIONS) {
ENROL_REC[ENROL_PRICE] = INT(ENROL_REC[ENROL_PRICE] * (REMAINING_SESSIONS / TOTAL_SESSIONS) + .5M);
}
}
/* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! */
}
/*  DJA 21.06.06 */
PRICE_DIFFERENCE = ENROL_REC[ENROL_PRICE] - OLD_ENROL_PRICE;
/* DJA 21.06.06!      IF ENROL.PRICE # OLD.ENROL.PRICE THEN */
if (PRICE_DIFFERENCE != 0 && ABS(PRICE_DIFFERENCE) != ENROL_REC[ENROL_TOTAL_REDEMPTION]) {
/*  Warn user (NB: multiple transfer may generate multiple warnings) */
MSG = STUDENT_ID + ", " + OCONV(ENROL_REC[ENROL_PRICE] - OLD_ENROL_PRICE, "MD2");
nrf0 = 90;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref MSG);
}
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "O";
/*  Course Fee */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = ENROL_REC[ENROL_PRICE];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "MOVEMENT";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + ENROL_REC[ENROL_PRICE];
if (PAYMENT_LIST[1, STUDENT_MVC] != 0) {
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "P";
/*  Payment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = PAYMENT_LIST[1, STUDENT_MVC];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "T";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "TRANSFER PAYMENT";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + PAYMENT_LIST[1, STUDENT_MVC];
}
if (ADJUSTMENT_LIST[1, STUDENT_MVC] != 0 && PERMIT_BALANCE_TRANSFERS == "Y") {
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
/*  Reverse any bonus redemptions */
/*  DJA 21.06.06 BUT only if they enrolled and paid in a single action, */
/*               in which case the course fee was reduced. If they */
/*               were enrolled without payment (by whatever route) and */
/*               subsequently paid partly by points redemption, then a */
/*               separate course adjustment will appear in their trans- */
/*               actions and will consequently be transferred forward */
/*               to the new course. In the latter scenario, refunding the */
/*               bonus points will give them an opportunity to spend those */
/*               points again. A bad thing. */
REDEEMED_UPON_ENROLMENT = FALSE;
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref FIRST_TRANS_POS, "AL")) {
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, FIRST_TRANS_POS] == "O") {
/*  Found original debit for this course */
if (STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, FIRST_TRANS_POS].Substring(1, 13) == "Original fee:") {
/*  Bonus redemption took place at point of enrolment */
REDEEMED_UPON_ENROLMENT = TRUE;
}
}
}
/*  DJA 5.1.06 */
/*  Warn user if the student's balance will be different as a consequence */
/*  of the transfer, and give them the option of automatically writing */
/*  off the difference to leave the overall balance unchanged. */
BALANCE_DIFFERENCE = ORIGINAL_STUDENT_BALANCE - STUDENT_REC[STUDENT_BALANCE];
/* DJA 21.06.06!      IF ORIGINAL.STUDENT.BALANCE # STUDENT.BALANCE AND DIFFERENCE.ADJUSTMENTS # "N" THEN */
/*  There may be a difference which we will rectify later when the */
/*  original bonus redemption is transferred to the new course */
if (BALANCE_DIFFERENCE != 0 && ABS(BALANCE_DIFFERENCE) != ENROL_REC[ENROL_TOTAL_REDEMPTION]) {
CONTINUE = FALSE;
do {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + " Old balance=�" + OCONV(ORIGINAL_STUDENT_BALANCE, "MD2") + " New balance=�" + OCONV(STUDENT_REC[STUDENT_BALANCE], "MD2") + ". Auto-adjust to match? ");
INPUT(out ADJ_REPLY, 2);
ADJ_REPLY = OCONV(ADJ_REPLY, "MCU");
// BEGIN CASE
// CASE
if (ADJ_REPLY == "Y") {
CONTINUE = TRUE;
}// CASE
else if (ADJ_REPLY == "N") {
CONTINUE = TRUE;
}// CASE
else if (OTHERWISE) {
NULL();
}
// END CASE
if (!(CONTINUE == FALSE)) break;
} while (true);
if (ADJ_REPLY == "Y") {
MVC = MVC + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
/*  Adjustment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = ORIGINAL_STUDENT_BALANCE - STUDENT_REC[STUDENT_BALANCE];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_WEB][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "TRANSFER OVERRIDE";
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC];
}
}
/* ***************** */
}
if (ENROL_REC[ENROL_INST_DATES] != "") {
COURSE_BALANCE = 0;
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == NEW_DETAILS_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
TRANS_NO = TRANS_NO + 1;
} while (true);
/*  If existing instalment plan will exactly collect the */
/*  new course balance, and the plan commences on or */
/*  after the new course start date, then both courses */
/*  are from the same batch/term and the plan can simply */
/*  be copied over 'as is'. Introduced for Stockport. */
if (COURSE_BALANCE != ENROL_REC[ENROL_INST_PLAN_TOTAL] || ENROL_REC[ENROL_INST_FIRST_DUE] < NEW_COURSE_DATE) {
/*  Recalculate new balance for this course, and then the new inst. profile */
NO_WEEKS = INT(((COURSE_DET_REC[COURSE_DET_END] - TODAYS_DATE) / 7)) + 1;
/*  Next 3 fields are redundant */
ENROL_REC[ENROL_ODD_INSTALMENT] = "";
ENROL_REC[ENROL_OTHER_INSTALMENT] = "";
ENROL_REC[ENROL_NO_INSTALMENTS] = "";
INST_PLAN_TOTAL = COURSE_BALANCE;
INST_NUMBER = NO_WEEKS;
INST_VALUE = "";
INST_FIRST_DUE = TODAYS_DATE;
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
}
nrf0 = 47;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref STUDENT_ID);
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
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
/* ****************************************************** */
/*  DJA 3.7.03 Print ticket showing new course details */
if (TICKET_REPLY == "Y") {
COURSE_FEE = ENROL_REC[ENROL_PRICE];
MAT(ref TICKET_REC, "");
TICKET_REC[TICK_CODE] = "C*" + NEW_COURSE_DET_REC[8, 1];
TICKET_REC[TICK_UNIT] = 1;
TICKET_REC[TICK_UNIT_PRICE] = 0;
TICKET_REC[TICK_DATE] = TODAYS_DATE;
TICKET_REC[TICK_TIME] = TIME();
TICKET_REC[TICK_TOTAL] = 0;
TICKET_REC[TICK_MOP] = "C";
TICKET_REC[TICK_CLERK] = U_INITS;
TICKET_REC[TICK_TILL] = TILL_NUMBER;
if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
TICKET_REC[TICK_MEMBER] = STUDENT_ID;
} else {
TICKET_REC[TICK_MEMBER] = "";
}
TICKET_REC[TICK_STUDENT_ID] = STUDENT_ID;
TICKET_REC[TICK_COURSE_DETAILS_ID] = DETAILS_ID;
TICKET_REC[TICK_CONCESS] = ENROL_REC[ENROL_CONCESSION][1, 1];
TICKET_REC[TICK_CC_REF] = "";
TICKET_REC[TICK_CC_EXP] = "";
COURSE_CODE = NEW_COURSE_ID;
STUDENT_NAME = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
NARRATIVE = "Cust: " + STUDENT_ID + " " + STUDENT_NAME;
NARRATIVE[1, 2] = "Course: " + NEW_COURSE_ID + " " + NEW_COURSE_MSTR_REC[1];
NARRATIVE[1, 3] = "Runs from " + OCONV(NEW_COURSE_DATE, "D") + " to " + OCONV(NEW_COURSE_DET_REC[2], "D");
NARR_MV = 3;
if (NEW_COURSE_DET_REC[9, 1] != "" && NEW_COURSE_DET_REC[10, 1] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Times: Starts " + OCONV(NEW_COURSE_DET_REC[9, 1], "MT") + " Ends " + OCONV(NEW_COURSE_DET_REC[10, 1], "MT");
}
if (COMMENTS_PRINTED == "Y") {
if (NEW_COURSE_DET_REC[14, 1] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[1] + NEW_COURSE_DET_REC[14, 1];
}
if (NEW_COURSE_DET_REC[14, 2] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[2] + NEW_COURSE_DET_REC[14, 2];
}
if (NEW_COURSE_DET_REC[14, 3] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[3] + NEW_COURSE_DET_REC[14, 3];
}
if (NEW_COURSE_DET_REC[14, 4] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[4] + NEW_COURSE_DET_REC[14, 4];
}
}
/*  Any Exception dates during this course period? */
EX_DATE = NEW_COURSE_DATE;
do {
if (EX_DATE > NEW_COURSE_DET_REC[2]) break;
MAT(ref NEW_COURSE_DETAILS_ARRAY, "");
for(N = 1; N <= 25; N += 1) {
NEW_COURSE_DETAILS_ARRAY[N] = NEW_COURSE_DET_REC[N];
}
FL873 = new FL873(ref EX_DATE, ref NEW_COURSE_DATE, ref NEW_COURSE_DETAILS_ARRAY, ref DATE_QUALIFIES);
if (DATE_QUALIFIES) {
if (NEW_COURSE_MSTR_REC[14] != "N") {
if (READ(ref CAL_REC, FL_COURSE_CALENDAR, EX_DATE)) {
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
if (PERMIT_BALANCE_TRANSFERS == "Y") {
NEW_COURSE_BALANCE = ENROL_REC[ENROL_PRICE] + PAYMENT_LIST[1, STUDENT_MVC] + ADJUSTMENT_LIST[1, STUDENT_MVC];
} else {
NEW_COURSE_BALANCE = ENROL_REC[ENROL_PRICE] + PAYMENT_LIST[1, STUDENT_MVC];
}
if (ADJUSTMENT_LIST[1, STUDENT_MVC] + 0 != 0 && PERMIT_BALANCE_TRANSFERS == "Y") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Fee = " + OCONV(ENROL_REC[ENROL_PRICE], "MD2") + " Adjust = " + OCONV(ADJUSTMENT_LIST[1, STUDENT_MVC], "MD2");
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Paid " + OCONV(PAYMENT_LIST[1, STUDENT_MVC], "MD2") + "  o/s " + OCONV(NEW_COURSE_BALANCE, "MD2");
} else {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Fee = " + OCONV(ENROL_REC[ENROL_PRICE], "MD2") + " Paid " + OCONV(PAYMENT_LIST[1, STUDENT_MVC], "MD2") + " o/s " + OCONV(NEW_COURSE_BALANCE, "MD2");
}
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
/* ****************************************************** */
/*  Recall any bonus points which were awarded on enrolment */
/*  (and after payment in full) */
/* DJA 14.7.06!              CONTRA.TICKET.REQUIRED = FALSE */
/* DJA 14.7.06!* */
/* DJA 14.7.06!* Reconstruct ticket record to support the call to FL165 */
/* DJA 14.7.06!* */
/* DJA 14.7.06!              TICK.REC = "" */
/* DJA 14.7.06!              TICK.REC<1> = "C*":COURSE.DET.FEE.CODE<1,1> */
/* DJA 14.7.06!              TICK.REC<2> = 1 ; * Units */
/* DJA 14.7.06!*DJA 12.11.04              TICK.REC<3> = -ENROL.PRICE<1,1> ; * Fee */
/* DJA 14.7.06!              READV ORIGINAL.PRICE FROM FL.ENROLMENT, ENROL.ID, 2 ELSE ORIGINAL.PRICE = 0 */
/* DJA 14.7.06!              TICK.REC<3> = ORIGINAL.PRICE<1,1> */
/* DJA 14.7.06!              TICK.REC<4> = TODAYS.DATE */
/* DJA 14.7.06!              TICK.REC<5> = TIME() */
/* DJA 14.7.06!              TICK.REC<6> = ENROL.PRICE<1,1> + 0 ; * Total */
/* DJA 14.7.06!              TICK.REC<8> = U.INITS ; * Clerk */
/* DJA 14.7.06!              TICK.REC<9> = TILL.NUMBER */
/* DJA 14.7.06!              TICK.REC<10> = STUDENT.ID ; * Membership number */
/* DJA 14.7.06!              PERIOD = 1 ; * Peak */
/* DJA 14.7.06!              TICK.REC<11> = PERIOD */
/* DJA 14.7.06!              TICK.REC<13> = ENROL.CONCESSION<1,1> */
/* DJA 14.7.06!              IF ENROL.BONUS.AWARD > 0 THEN */
/* DJA 14.7.06!                 CONTRA.TICKET.REQUIRED = TRUE */
/* DJA 14.7.06!                 TODAYZ.DATE = TODAYS.DATE */
/* DJA 14.7.06!                 CALL.REF = "MCOURSES" */
/* DJA 14.7.06!* FL165 updates tick.rec <24> and <25> */
/* DJA 14.7.06!                 CALL FL165(TICK.REC, TODAYZ.DATE, PERIOD, CALL.REF) */
/* DJA 14.7.06!              END */
/* DJA 14.7.06!* DJA 12.11.04 */
/* DJA 14.7.06!              TICK.REC<3> = -TICK.REC<3> */
if (ENROL_REC[ENROL_TOTAL_REDEMPTION] > 0 && REDEEMED_UPON_ENROLMENT == TRUE && UPDATE_INTERACT == TRANSFER) {
/* !!              CONTRA.TICKET.REQUIRED = TRUE */
/* !!              TICK.REC<25> = ENROL.PROMOTION */
/* !!              TICK.REC<27> = -ENROL.TOTAL.REDEMPTION */
/* !!              TICK.REC<28> = -ENROL.TOTAL.POINTS */
/* !!              CALL FL795(STUDENT.ID, ENROL.TOTAL.POINTS, ENROL.TOTAL.REDEMPTION, ENROL.PROMOTION) */
/*  DJA 21.06.2006 Makes more sense to credit the redemption against */
/*                 destination course. Then, assuming the fees are the same, */
/*                 the before and after balances should match. */
/*                 Also, this would make the result the same as an enrolment */
/*                 change following a separate enrolment and payment. */
/* ********* */
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = NEW_DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
/*  Redemption transfer */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -ENROL_REC[ENROL_TOTAL_REDEMPTION];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "REDEMPTION TRANSFER";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - ENROL_REC[ENROL_TOTAL_REDEMPTION];
/*  RE-Write the student record with the new adjustment appended */
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
/* ********* */
}
/* DJA 14.7.06!              IF CONTRA.TICKET.REQUIRED = TRUE THEN */
/* DJA 14.7.06!* */
/* DJA 14.7.06!* Write the ticket record for bonus point reconciliation */
/* DJA 14.7.06!* */
/* DJA 14.7.06!                 TICK.ID = "" ; SESSION.NO = "" */
/* DJA 14.7.06!                 CALL FL000.12(PROGRAM,TICK.ID,"",SESSION.NO) */
/* DJA 14.7.06!                 TICK.REC<16> = SESSION.NO */
/* DJA 14.7.06!* */
/* DJA 14.7.06!* Zeroise ticket amounts */
/* DJA 14.7.06!* */
/* DJA 14.7.06!                 TICK.REC<3> = 0 */
/* DJA 14.7.06!                 TICK.REC<6> = 0 */
/* DJA 14.7.06!                 WRITE TICK.REC ON FL.TICKETS, TICK.ID */
/* DJA 14.7.06!              END */
/*  Don't delete data which may be required for bonus rollback */
/*  upon refund */
if (ENROL_REC[ENROL_BONUS_AWARD] == "" || UPDATE_INTERACT == TRANSFER) {
DELETE(FL_ENROLMENT, ENROL_ID);
}
STUDENT_SELECT_LIST = DELETE(STUDENT_SELECT_LIST, 1, STUDENT_MVC, 0);
STUDENT_LIST = DELETE(STUDENT_LIST, 1, STUDENT_MVC, 0);
SURNAME_LIST = DELETE(SURNAME_LIST, 1, STUDENT_MVC, 0);
FULL_NAME_LIST = DELETE(FULL_NAME_LIST, 1, STUDENT_MVC, 0);
CONCESS_LIST = DELETE(CONCESS_LIST, 1, STUDENT_MVC, 0);
BALANCE_LIST = DELETE(BALANCE_LIST, 1, STUDENT_MVC, 0);
PAYMENT_LIST = DELETE(PAYMENT_LIST, 1, STUDENT_MVC, 0);
ADJUSTMENT_LIST = DELETE(ADJUSTMENT_LIST, 1, STUDENT_MVC, 0);
NO_STUDENTS = NO_STUDENTS - 1;
STUDENT_COUNT = 1;
ACTION = SCROLL;
L7000();
} else {
STUDENT_MVC = STUDENT_MVC + 1;
}
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
/* ******************************************** */
}
void L4010() {
/*  Find date of original sale            * */
/* ******************************************** */
N = 1;
FOUND_IT = FALSE;
do {
THIS_DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, N];
THIS_TYPE = STUDENT_REC[STUDENT_TRANS_TYPES][1, N];
if (FOUND_IT || THIS_DET_ID == "") break;
if (THIS_DET_ID == DETAILS_ID && THIS_TYPE == "O") {
FOUND_IT = TRUE;
SALE_DATE = STUDENT_REC[STUDENT_TRANS_DATES][1, N];
} else {
N = N + 1;
}
} while (true);
return;
/* ******************************************** */
}
void L5000() {
/*   Tranfer(s) to another course         * */
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
L5600();
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
void L5600() {
/*   Check concession group vacancies                   * */
/* ********************************************************** */
TICKET_CODE = "C*" + NEW_COURSE_DET_REC[8];
TICKET_TYPE = "C";
/*  DJA 26.01.05 */
if (FEE_TODAY == "Y") {
/* POINTLESS - THIS CODE'S ONLY CHECKING CONCESSION VACANCIES */
/* !!IF FEE.TODAY = "Y" THEN */
/* !!* Find date of original enrolment */
/* !!N = 1 */
/* !!FOUND.IT = FALSE */
/* !!LOOP */
/* !!THIS.DET.ID = STUDENT.TRANS.DETAILS.IDS<1,N> */
/* !!THIS.TYPE   = STUDENT.TRANS.TYPES<1,N> */
/* !!UNTIL FOUND.IT OR THIS.DET.ID = "" DO */
/* !!IF THIS.DET.ID = DETAILS.ID AND THIS.TYPE = "O" THEN */
/* !! FOUND.IT = TRUE */
/* !! SALE.DATE = STUDENT.TRANS.DATES<1,N> */
/* !!END ELSE */
/* !!N = N + 1 */
/* !!END */
/* !!REPEAT */
/* !!IF FOUND.IT = FALSE THEN */
SALE_DATE = TODAYS_DATE;
/* !!END */
} else {
SALE_DATE = NEW_COURSE_DATE;
}
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
if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL")) {
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
/* *   GOSUB 7000 */
return;
}
void L7000() {
/*   DISPLAY ONE SCREENFUL OF STUDENTS */
nrf0 = COURSE_DET_REC[COURSE_DET_STUDENT_IDS];
FL742 = new FL742(ref ACTION, ref TOGGLE_POS, ref STUDENT_SELECT_LIST, ref nrf0, ref REDISPLAY, ref STUDENT_COUNT, ref STUDENT_LIST, ref SURNAME_LIST, ref FULL_NAME_LIST, ref CONCESS_LIST, ref BALANCE_LIST, ref PAYMENT_LIST, ref ADJUSTMENT_LIST, ref ERROR_LIST, ref WINDOW_DEPTH);
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
