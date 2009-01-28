//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL913 : UvBase
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
      readonly UvVar NOT_PRESENT = 9;
      readonly UvVar ALREADY_PRESENT = 10;
      readonly UvVar FWTERM_MODE = 0;
      readonly UvVar TOUCHSCREEN_MODE = 1;
      readonly UvVar SILENT_MODE = 2;
      readonly UvVar SCREENS = 8;
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
      readonly UvVar CAL_TEXT = 1;
      readonly UvVar CAL_TYPE = 2;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] COURSE_MSTR_REC;
      UvVar[] COURSE_DET_REC;
      UvVar[] ENROL_REC;
      UvVar[] STUDENT_REC;
      UvVar[] TICKET_REC;
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] INSTRUCTOR_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] WAIT_MAST_REC = new UvVar[5];
      UvVar[] WAIT_STUDENT_REC = new UvVar[35];
      UvVar[] CALENDAR_REC = new UvVar[10];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar ZZZ_STATUS = "";
      UvVar STUDENT_AND_APACS_NOS = "";
      UvVar RECEIPT_REQUIRED = "";
      UvVar NEW_COURSE = "";
      UvVar COURSE_BALANCE = "";
      UvVar PAYMENT_MVC = "";
      UvVar GROUP_MULTIVALUE = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar BONUS_REDEEM_REC = "";
      UvVar PROMOTION = "";
      UvVar MOP = "";
      UvVar NO_OF_STUDENTS = "";
      UvVar PAYMENT_RECEIVED = "";
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar USER_STATUS = "";
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
      UvVar AM = "";
      UvVar VM = "";
      UvVar STUDENT_ID = "";
      UvVar APACS_NO = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar PROCESS_LOCKED = "";
      UvVar JUST = "";
      UvVar TOTAL_FIELD_NO = "";
      UvVar CENTRE_FIELD_NO = "";
      UvVar TIMES_FIELD_NO = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_INSTRUCTORS = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_ENROLMENT = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_WAIT_MASTER = "";
      UvVar FL_WAIT_STUDENTS = "";
      UvVar FL_MULTIPAY = "";
      UvVar FL_COURSE_CALENDAR = "";
      UvVar LABEL_PRINT = "";
      UvVar PROMOTIONS_CONTROL = "";
      UvVar CURRENT_PROMOTIONS = "";
      UvVar BONUS_REDEEM_PROG = "";
      UvVar MOP_TYPES = "";
      UvVar SMART_CARD = "";
      UvVar TICKET_CONCESS = "";
      UvVar MANUAL_RECEIPTS = "";
      UvVar COURSE_PARAMS = "";
      UvVar GET_STUDENT_ID = "";
      UvVar VALID_PRIVILEGES = "";
      UvVar GET_CARD_NO = "";
      UvVar PREVENT_PP_AND_INSTALMENTS = "";
      UvVar PREVENT_ZERO_PAYMENTS = "";
      UvVar PRO_RATA_FEE = "";
      UvVar PERMIT_BALANCE_TRANSFERS = "";
      UvVar ALLOW_MULTIPAY = "";
      UvVar CENTRALISED_COURSES = "";
      UvVar BLOCK_FUTURE_COURSES = "";
      UvVar FULL_PAYMENT_DEFAULT = "";
      UvVar USE_MEMBER_COMMENTS = "";
      UvVar EFT_SITE = "";
      UvVar DISPLAY_PHOTO = "";
      UvVar MAX_FIELDS = "";
      UvVar DATA_FIELDS = "";
      UvVar DISPLAY_ONLY_FIELDS = "";
      UvVar ENTRY_FIELDS = "";
      UvVar FIELD_COUNT = "";
      UvVar BALANCE = "";
      UvVar FEE_OVERRIDE = "";
      UvVar BALANCE_TRANSFER = "";
      UvVar COURSE_DATE = "";
      UvVar MULTIPAY_REC = "";
      UvVar BASKET_COUNT = "";
      FL006 FL006;
      UvVar LINE = "";
      UvVar POS = "";
      UvVar AMENDING = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      FL_HIDE_PHOTO FL_HIDE_PHOTO;
      UvVar MVC = "";
      UvVar OK_TO_FILE = "";
      UvVar FIELD_DATA = "";
      UvVar ST_DISPLAY = "";
      UvVar FOOT_WARN = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar MEMBER_PROGRAM = "";
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
      UvVar NO_INSTRUCTORS = "";
      UvVar FULL_INSTRUCTOR_NAME = "";
      UvVar INSTRUCTOR_SURNAME1 = "";
      UvVar INSTRUCTOR_SURNAME2 = "";
      UvVar DISPLAY_MODE = "";
      UvVar STUDENT_SCAN_ID = "";
      FL717 FL717;
      UvVar COURSE_ID = "";
      UvVar REDISPLAY = "";
      CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
      UvVar DETAILS_ID = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar DATE_LIST = "";
      UvVar CREATION_ALLOWED = "";
      UvVar SELECT_DATE = "";
      FL704 FL704;
      UvVar LEVELS_ALLOWED = "";
      UvVar LEVEL = "";
      UvVar NO_LEVELS = "";
      UvVar LEVEL_TEXT = "";
      UvVar NO_LEVELS_ALLOWED = "";
      FL738 FL738;
      UvVar WAIT_LIST = "";
      UvVar WAIT_LIST_COUNT = "";
      UvVar NEW_STUDENT = "";
      CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
      UvVar MEMBER_NUMBER = "";
      UvVar CONV_ANS = "";
      UvVar TICKET_PRICE = "";
      UvVar RECEIPT_NO = "";
      UvVar PAYMENT_ESTABLISHED = "";
      UvVar FOOT_MESS = "";
      UvVar PAY_ANS = "";
      UvVar CHQ_NO = "";
      UvVar CC_REF = "";
      UvVar CC_EXP = "";
      UvVar EFT_CONF = "";
      UvVar CC_ISSUE = "";
      UvVar CC_START = "";
      UvVar EFT_AMOUNT = "";
      UvVar RET_FUNC = "";
      UvVar CC_AUTH = "";
      UvVar SWIPE_DETAILS = "";
      FL361_EFT FL361_EFT;
      UvVar CARD_CVS = "";
      FL_EFT FL_EFT;
      FL361_1 FL361_1;
      UvVar AMC = "";
      UvVar NO_MOPS = "";
      UvVar MOP_FOUND = "";
      UvVar ADJUSTED_FEE = "";
      UvVar TICKET_CODE = "";
      UvVar TICKET_TYPE = "";
      UvVar SALE_DATE = "";
      UvVar SALE_TIME = "";
      UvVar PERIOD = "";
      UvVar TOTAL_REDEMPTION = "";
      UvVar TOTAL_POINTS = "";
      UvVar TOTAL_POINTS_REDEEMED = "";
      FL355 FL355;
      UvVar PRICE = "";
      UvVar RESPONSE = "";
      UvVar STORED_MEMBER_NUMBER = "";
      UvVar DONE = "";
      FL048 FL048;
      UvVar CONCESS_POS = "";
      UvVar GROUP_NAME = "";
      UvVar ORIGINAL_TICKET_TOTAL = "";
      UvVar REMAINING_SESSIONS = "";
      UvVar TOTAL_SESSIONS = "";
      UvVar EX_DATE = "";
      FL873 FL873;
      UvVar DATE_QUALIFIES = "";
      UvVar CALENDAR_ID = "";
      UvVar CAL_REC = "";
      UvVar FOOT_DONE = "";
      UvVar FOOT_QUESTION = "";
      UvVar FOOT_ANS = "";
      UvVar PRO_RATA_PRICE = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      UvVar NO_TEMP_DATES = "";
      UvVar NO_TEMP_AMOUNTS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL913(ref UvVar STUDENT_AND_APACS_NOS, ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar[] ENROL_REC, ref UvVar[] STUDENT_REC, ref UvVar[] TICKET_REC, ref UvVar RECEIPT_REQUIRED, ref UvVar NEW_COURSE, ref UvVar COURSE_BALANCE, ref UvVar PAYMENT_MVC, ref UvVar GROUP_MULTIVALUE, ref UvVar OLD_COURSE_DATE, ref UvVar BONUS_REDEEM_REC, ref UvVar PROMOTION, ref UvVar MOP, ref UvVar NO_OF_STUDENTS, ref UvVar PAYMENT_RECEIVED)
      {
         this.STUDENT_AND_APACS_NOS = STUDENT_AND_APACS_NOS;
         this.COURSE_MSTR_REC = COURSE_MSTR_REC;
         this.COURSE_DET_REC = COURSE_DET_REC;
         this.ENROL_REC = ENROL_REC;
         this.STUDENT_REC = STUDENT_REC;
         this.TICKET_REC = TICKET_REC;
         this.RECEIPT_REQUIRED = RECEIPT_REQUIRED;
         this.NEW_COURSE = NEW_COURSE;
         this.COURSE_BALANCE = COURSE_BALANCE;
         this.PAYMENT_MVC = PAYMENT_MVC;
         this.GROUP_MULTIVALUE = GROUP_MULTIVALUE;
         this.OLD_COURSE_DATE = OLD_COURSE_DATE;
         this.BONUS_REDEEM_REC = BONUS_REDEEM_REC;
         this.PROMOTION = PROMOTION;
         this.MOP = MOP;
         this.NO_OF_STUDENTS = NO_OF_STUDENTS;
         this.PAYMENT_RECEIVED = PAYMENT_RECEIVED;
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
         /*     GROUP (NON-MEMBER) COURSE RE-ENROLMENT */
         STUDENT_ID = STUDENT_AND_APACS_NOS[1];
         APACS_NO = STUDENT_AND_APACS_NOS[2];
         PROMPT("");
         /*  the next two lines inserted for the smart card interface */
         PROGRAM = "FL913";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
         JUST = "";
         MOP = "";
         TOTAL_FIELD_NO = 18;
         CENTRE_FIELD_NO = 19;
         TIMES_FIELD_NO = 20;
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
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
         #region INCLUDE FL.FILES FL.INSTRUCTORS
         if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

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
         #region INCLUDE FL.FILES FL.DICT.TICKETS

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.MASTER
         if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.STUDENTS
         if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

         /*  Important - keep Wait.Stud.Dates (21) in tandem */

         #endregion
         #region INCLUDE FL.FILES FL.MULTIPAY
         if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

         #endregion
         #region INCLUDE FL.FILES FL.COURSE.CALENDAR
         if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

         /*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

         #endregion
         if (!READV(ref LABEL_PRINT, COMMON.FILES[FL_CONTROL], "ADDRESS.LABEL.ROUTINE", 1)) { LABEL_PRINT = ""; }
         if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL")))
         {
            PROMOTIONS_CONTROL = "";
         }
         CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
         BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
         if (!READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")) { MOP_TYPES = ""; }
         SMART_CARD = FALSE;
         MAT(ref TEMP_REC, "");
         TICKET_CONCESS = "";
         if (!READV(ref MANUAL_RECEIPTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 2)) { MANUAL_RECEIPTS = "N"; }
         MANUAL_RECEIPTS = MANUAL_RECEIPTS[1, 1];
         if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
         GET_STUDENT_ID = COURSE_PARAMS[1, 1];
         VALID_PRIVILEGES = COURSE_PARAMS[3, 1];
         GET_CARD_NO = COURSE_PARAMS[11, 1];
         PREVENT_PP_AND_INSTALMENTS = "Y";
         /*  Must pay in full */
         PREVENT_ZERO_PAYMENTS = "Y";
         /*  Must pay in full */
         PRO_RATA_FEE = COURSE_PARAMS[31, 1];
         PERMIT_BALANCE_TRANSFERS = COURSE_PARAMS[32, 1];
         ALLOW_MULTIPAY = "N";
         /*  Not supported */
         if (PERMIT_BALANCE_TRANSFERS == "") { PERMIT_BALANCE_TRANSFERS = "Y"; }
         if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
         if (!READV(ref BLOCK_FUTURE_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 27)) { BLOCK_FUTURE_COURSES = "N"; }
         if (!READV(ref FULL_PAYMENT_DEFAULT, FL_COURSE_PARAMS, "COURSE.PARAMS", 34)) { FULL_PAYMENT_DEFAULT = "N"; }
         if (!READV(ref USE_MEMBER_COMMENTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 47)) { USE_MEMBER_COMMENTS = "N"; }
         USE_MEMBER_COMMENTS = USE_MEMBER_COMMENTS[1, 1];
         if (!MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "COURSE.BOOKING.LEVELS")) { MAT(ref COURSE_PARAM_REC, ""); }
         /* <EFT */
         if (!(READV(ref EFT_SITE, COMMON.FILES[FL_CONTROL], "EFT.SITE", 1)))
         {
            EFT_SITE = FALSE;
         }
         /* EFT> */
         DISPLAY_PHOTO = FALSE;
         /*  All non-members */
         /* ************************************ */
         /*   GET SCREEN DEFINITION ITEM       * */
         /* ************************************ */
         if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE)))
         {
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
         FEE_OVERRIDE = FALSE;
         BALANCE_TRANSFER = FALSE;
         COURSE_DATE = PROG_MESS[3];
         if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
         BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
         if (BASKET_COUNT > 0)
         {
            nrf0 = 500;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            PROG_MESS[1] = COMMON.ABANDON;
            PROG_MESS[2] = "";
            INTERACT = EXIT;
            return;
         }
         PRINT(AT(0, 3) + NRM_VID);
         if (COURSE_DATE <= TODAYS_DATE)
         {
            /*  Course has started already */
            if (INDEX(VALID_PRIVILEGES, USER_STATUS, 1)) { FEE_OVERRIDE = TRUE; }
         }
         do
         {
            LINE = SC_POS[SCREEN_LINES + 1];
            if (LINE == "") break;
            if (LINE[1, 4] != "")
            {
               FIELD_COUNT = FIELD_COUNT + 1;
               if (LINE[1, 11] == "D")
               {
                  MAX_FIELDS = MAX_FIELDS + 1;
                  if (!(LOCATE(FIELD_COUNT, DISPLAY_ONLY_FIELDS, 1, 0, 1, ref POS, "AR")))
                  {
                     DISPLAY_ONLY_FIELDS = INSERT(DISPLAY_ONLY_FIELDS, 1, POS, 0, FIELD_COUNT);
                  }
               }
               else
               {
                  MAX_FIELDS = MAX_FIELDS + 1;
                  if (!(LOCATE(FIELD_COUNT, ENTRY_FIELDS, 1, 0, 1, ref POS, "AR")))
                  {
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
         AMENDING = FALSE;
         do
         {
            INTERACT = VALID_DATA;
            L0100();
            STUDENT_IS_MEMBER = FALSE;
            MAIN_KEY = "";
            MAT(ref TEMP_REC, "");
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     L0060();
                     if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
                     FIELD_NO = FIELD_NO + 1;
                  } while (true);
                  // BEGIN CASE
                  // CASE
                  if (INTERACT == BACKUP && AMENDING)
                  {
                     L0050();
                  }// CASE
                  else if (INTERACT == EXIT)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == INVALID_DATA)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == BACKUP && FIELD_NO > 1)
                  {
                     FIELD_NO = FIELD_NO - 1;
                  }// CASE
                  else if (FIELD_NO >= MAX_FIELDS)
                  {
                     L0050();
                  }// CASE
                  else if (INTERACT == LIMIT || AMENDING)
                  {
                     L0050();
                  }// CASE
                  else if (INTERACT != INVALID_DATA)
                  {
                     FIELD_NO = FIELD_NO + 1;
                  }
                  // END CASE
                  if (INTERACT == EXIT || INTERACT == FINISH) break;
               } while (true);
               if (MAIN_KEY != "" && INTERACT != EXIT)
               {
                  /*  Transfer data out of TEMP.REC */
                  L9000();
               }
            }
            if (INTERACT == EXIT || INTERACT == FINISH) break;
         } while (true);
         STUDENT_AND_APACS_NOS[1] = STUDENT_ID;
         STUDENT_AND_APACS_NOS[2] = APACS_NO;
         return;
         /* ************************************* */
      }
      void L0050()
      {
         /*   ENTER AMENDMENT FIELD NUMBER  * */
         /* ************************************* */
         AMENDING = TRUE;
         INTERACT = INVALID_DATA;
         do
         {
            /* !*        IF LABEL.PRINT = "" THEN */
            INPUT_LINE = "      Enter Field no or 'F' to finish ";
            /* !*        END ELSE */
            /* !*           INPUT.LINE ="      Enter Field no, 'F' to finish or '+' for label " */
            /* !*        END */
            PRINT(AT(0, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 20) + FORMAT("", "L#75"));
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + FORMAT(INPUT_LINE, "L#75"));
            PRINT(AT(2 + LEN(INPUT_LINE), 21));
            INPUT(out ANS, 4);
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            /* !!        CASE ANS = "+" AND LABEL.PRINT <> "" */
            /* !!* NORFOLK SKI CLUB LABEL PRINT */
            /* !!              LABEL.TITLE = STUDENT.TITLE */
            /* !!              LABEL.FORENAMES = STUDENT.FORENAME */
            /* !!              LABEL.SURNAME   = STUDENT.SURNAME */
            /* !!              LABEL.ADDRESS1  = STUDENT.ADDRESS1 */
            /* !!              LABEL.ADDRESS2  = STUDENT.ADDRESS2 */
            /* !!              LABEL.ADDRESS3  = STUDENT.ADDRESS3 */
            /* !!              LABEL.ADDRESS4  = STUDENT.ADDRESS4 */
            /* !!              LABEL.POSTCODE  = STUDENT.POST.CODE */
            /* !!           CALL @LABEL.PRINT(LABEL.TITLE, LABEL.FORENAMES, LABEL.SURNAME, LABEL.ADDRESS1, LABEL.ADDRESS2, LABEL.ADDRESS3, LABEL.ADDRESS4, LABEL.POSTCODE) */
            // CASE
            if (ANS == "H")
            {
               if (DISPLAY_PHOTO)
               {
                  FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
               }
               /*  DJA 7.4.00 */
            }// CASE
            else if ((ANS != "F" && ANS != "f") && EFT_SITE && MOP == MOP_TYPES[3])
            {
               nrf0 = 45;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (ANS == "")
            {
            }// CASE
            else if (ANS == "F")
            {
               /*  Populate NO.OF.STUDENTS and deal with concession/price/MOP */
               NO_OF_STUDENTS = TEMP_REC[34];
               L1300();
               /*  Generate new student */
               if (INTERACT == VALID_DATA)
               {
                  L1500();
                  /*  Establish Fee */
                  L1700();
                  /*  MOP/EFT etc */
               }
               if (INTERACT == VALID_DATA)
               {
                  L0055();
                  if (INTERACT == FINISH)
                  {
                     PROG_MESS[1] = "";
                  }
               }
            }// CASE
            else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p")
            {
            }// CASE
            else if (MATCH(ANS, "0N") && ANS >= 1 && ANS <= 6)
            {
               // BEGIN CASE
               // CASE
               if (OTHERWISE)
               {
                  MVC = ANS + 1;
                  FIELD_NO = ENTRY_FIELDS[1, MVC];
                  if (FIELD_NO == "")
                  {
                     INTERACT = INVALID_DATA;
                  }
                  else
                  {
                     INTERACT = VALID_DATA;
                  }
               }
               // END CASE
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* ******************************************** */
      }
      void L0055()
      {
         /*  Validate user can leave page 1        * */
         /* ******************************************** */
         /*  Validate that key fields are present before allowing the user to file */
         OK_TO_FILE = TRUE;
         if (TEMP_REC[23] < 0 && PERMIT_BALANCE_TRANSFERS != "Y")
         {
            /*  Negative balance - payment exceeds fee. This can occur if fee */
            /*  is amended */
            nrf0 = 90;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            OK_TO_FILE = FALSE;
         }
         if (OK_TO_FILE)
         {
            INTERACT = FINISH;
         }
         return;
         /* ******************************** */
      }
      void L0060()
      {
         /*   DATA ENTRY ROUTINE       * */
         /* ******************************** */
         FIELD_DATA = DATA_FIELDS[FIELD_NO];
         L0200();
         /*  Ensure no input prompts for display-only fields */
         // BEGIN CASE
         // CASE
         if (ST_DISPLAY == "D")
         {
            NULL();
         }// CASE
         else if (ST_DISPLAY == "V" && FEE_OVERRIDE == FALSE)
         {
         }// CASE
         else if (OTHERWISE)
         {
            if (ST_DISPLAY == "V")
            {
               COURSE_DATE = PROG_MESS[3];
               FOOT_WARN = "";
            }
            INTERACT = INVALID_DATA;
            if (ST_ATT == 0)
            {
               VALUE = MAIN_KEY;
            }
            else
            {
               VALUE = TEMP_REC[ST_ATT][1, ST_MV];
            }
            PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
            PRINT(AT(ST_COL, ST_ROW));
            PRINT(AT(ST_COL, ST_ROW));
            MEMBER_PROGRAM = "";
            INPUT(out ANS, ST_LENGTH);
            /* !!        IF ST.DISPLAY = "V" THEN */
            /* !!* Clear footer warnings */
            /* !!           PRINT @(0,20):SCREEN.FOOT.BACK:SCREEN.FOOT.FORE: */
            /* !!           PRINT @(2,20):SPACE(74): */
            /* !!           PRINT @(0,21):SCREEN.FOOT.BACK:SCREEN.FOOT.FORE: */
            /* !!           PRINT @(2,21):SPACE(74): */
            /* !!        END */
            // BEGIN CASE
            // CASE
            if (ANS == GO_BACK)
            {
               INTERACT = BACKUP;
            }// CASE
            else if (ANS == COMMON.ABANDON && EFT_SITE && MOP == MOP_TYPES[3])
            {
               nrf0 = 45;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (ANS == GO_BACK && FIELD_NO == 1)
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == COMMON.CLR && ST_MANDATORY == "")
            {
               VALUE = "";
               ANS = "";
               INTERACT = VALID_DATA;
            }// CASE
            else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "")
            {
               nrf0 = 5;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               /*  Recalculate instalments if <return> is pressed after using backup to */
               /*  change the student and therefore the fee code */
            }// CASE
            else if (ANS == "" && VALUE != "" && FIELD_NO > 1)
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS == "" && VALUE == "" && ST_CONVERSION == "MD2")
            {
               ANS = 0;
               VALUE = 0;
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1)
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (OTHERWISE)
            {
               #region ON FIELD_NO GOSUB ...
               switch ((int)FIELD_NO)
               {
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
                  case 12: L2100(); break;
                  case 13: L2200(); break;
                  case 14: L2300(); break;
                  case 15: L2400(); break;
                  case 16: L2500(); break;
                  case 17: L2600(); break;
                  case 18: L1200(); break;
                  case 19: L1200(); break;
                  case 20: L1200(); break;
                  case 21: L1200(); break;
               }
               #endregion
               if (INTERACT == VALID_DATA)
               {
                  if (ST_CONVERSION != "")
                  {
                     VALUE = ICONV(ANS, ST_CONVERSION);
                  }
                  else
                  {
                     VALUE = ANS;
                  }
               }
            }
            // END CASE
            PRINT(AT(ST_COL - 1, ST_ROW));
            if (ST_CONVERSION != "")
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
            }
            else
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
            }
            if (ST_ATT == 0)
            {
               MAIN_KEY = VALUE;
            }
            else
            {
               TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
            }
         }
         // END CASE
         return;
         /* ******************************* */
      }
      void L0100()
      {
         /*   DISPLAY SCREEN FORMAT  * */
         /* ******************************** */
         PROMPT_NO = 1;
         DOTS_ONLY = 0;
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         for (PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1)
         {
            PRINT(AT(79, PRINT_LINE) + NRM_VID);
            PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, PRINT_LINE) + SPACE(76));
         }
         /*  Position cursor to prevent Wyse taking a chunk out of footing bar */
         PRINTCR(AT(0, 3) + NRM_VID);
         return;
         /* ********************************* */
      }
      void L0200()
      {
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
         /*  'D'isplay or 'V'alidated */
         return;
         /* ********************************* */
      }
      void L0300()
      {
         /*   DISPLAY ITEM CONTENTS */
         /* ********************************* */
         for (I = 1; I <= MAX_FIELDS; I += 1)
         {
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
            if (DISP_ATT == 0)
            {
               PRINT(FORMAT(MAIN_KEY, DISP_JUST));
            }// CASE
            else if (DISP_CONVERSION != "")
            {
               PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
            }// CASE
            else if (OTHERWISE)
            {
               if (DISP_ATT != 6)
               {
                  PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
               }
               /*  Show instructors full name */
               if (DISP_ATT == 6)
               {
                  NO_INSTRUCTORS = DCOUNT(TEMP_REC[DISP_ATT], VM);
                  if (NO_INSTRUCTORS <= 1)
                  {
                     if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, TEMP_REC[DISP_ATT])) { MAT(ref INSTRUCTOR_REC, ""); }
                     FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
                     PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
                     PRINT(AT(DISP_COL + 7, DISP_ROW) + FORMAT(FULL_INSTRUCTOR_NAME, "L#24"));
                  }
                  else
                  {
                     if (!READV(ref INSTRUCTOR_SURNAME1, FL_INSTRUCTORS, TEMP_REC[DISP_ATT][1, 1], 3)) { INSTRUCTOR_SURNAME1 = ""; }
                     if (!READV(ref INSTRUCTOR_SURNAME2, FL_INSTRUCTORS, TEMP_REC[DISP_ATT][1, 2], 3)) { INSTRUCTOR_SURNAME2 = ""; }
                     /* !*              PRINT @(DISP.COL+7,DISP.ROW) : (INSTRUCTOR.SURNAME1 :"/": INSTRUCTOR.SURNAME2) "L#24" : */
                     PRINT(AT(DISP_COL, DISP_ROW) + FORMAT((INSTRUCTOR_SURNAME1 + "/" + INSTRUCTOR_SURNAME2), "L#30"));
                  }
               }
            }
            // END CASE
         }
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
         #region INCLUDE FL.PROCESSING FL913.VALIDATION

      }
      void L1000()
      {
         /*   Course Code Validation Routine */
         INTERACT = VALID_DATA;
         // BEGIN CASE
         /*  Scan for required course if the 'help' key is entered */
         // CASE
         if (ANS == COMMON.HELP && AMENDING == FALSE)
         {
            DISPLAY_MODE = 2;
            STUDENT_SCAN_ID = "";
            FL717 = new FL717(ref DISPLAY_MODE, ref STUDENT_SCAN_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
            /*  Refresh screen */
            L0100();
            REDISPLAY = "";
            if (INTERACT != EXIT)
            {
               PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
               ANS = COURSE_ID;
               MAIN_KEY = ANS;
               /*  DJA 17/7/95 */
               nrf0 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 32;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  MAIN_KEY = "";
                  VALUE = "";
               }
               else
               {
                  PROG_MESS[2] = COURSE_ID;
                  PROG_MESS[3] = COURSE_DATE;
                  DETAILS_ID = COURSE_DATE + "*" + MAIN_KEY;
                  if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) { MAT(ref COURSE_MSTR_REC, ""); }
                  if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
                  {
                     if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                     {
                        L8000();
                        /*  Build Temp.Rec */
                        /*  Deal with display-only fields */
                        START_FIELD = 2;
                        END_FIELD = 11;
                        L6000();
                        /*  Display selected field data */
                        START_FIELD = CENTRE_FIELD_NO;
                        END_FIELD = TIMES_FIELD_NO;
                        L6000();
                        // BEGIN CASE
                        // CASE
                        if (COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE)
                        {
                           nrf0 = 13;
                           nrf1 = INIT;
                           FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                           INTERACT = INVALID_DATA;
                        }// CASE
                        else if (OTHERWISE)
                        {
                           OLD_COURSE_DATE = COURSE_DATE;
                           L0300();
                           L1025();
                           /*  Check/display booking levels */
                        }
                        // END CASE
                        if (INTERACT == INVALID_DATA)
                        {
                           ANS = "";
                           MAIN_KEY = "";
                           VALUE = "";
                           PROG_MESS[2] = "";
                        }
                     }
                     else
                     {
                        INTERACT = INVALID_DATA;
                        nrf0 = 3;
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
                     }
                  }
                  else
                  {
                     nrf0 = 50;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }
                  /*  DJA 17/7/95 - Course was locked */
               }
            }
            else
            {
               ANS = "";
               MAIN_KEY = "";
               VALUE = "";
               PROG_MESS[2] = "";
               INTERACT = INVALID_DATA;
            }
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
            AMENDING = TRUE;
            if (ST_CONVERSION != "")
            {
               VALUE = ICONV(ANS, ST_CONVERSION);
            }
            else
            {
               VALUE = ANS;
            }
            if (VALUE != "")
            {
               MAIN_KEY = VALUE;
               /*  DJA 17/7/95 */
               nrf0 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 32;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  MAIN_KEY = "";
                  VALUE = "";
               }
               else
               {
                  PROG_MESS[2] = MAIN_KEY;
                  if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY))
                  {
                     if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
                     {
                        /*  Call date selection window */
                        DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
                        CREATION_ALLOWED = FALSE;
                        if (DCOUNT(DATE_LIST, VM) == 1)
                        {
                           SELECT_DATE = DATE_LIST;
                           INTERACT = VALID_DATA;
                           REDISPLAY = "";
                        }
                        else
                        {
                           FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref SELECT_DATE, ref INTERACT, ref REDISPLAY);
                        }
                        /*  If box is abandoned, reprompt for course code */
                        if (INTERACT == EXIT)
                        {
                           INTERACT = INVALID_DATA;
                           MAIN_KEY = "";
                           ANS = "";
                           VALUE = "";
                           PROG_MESS[2] = "";
                           AMENDING = FALSE;
                        }
                        else
                        {
                           INTERACT = VALID_DATA;
                        }
                        if (REDISPLAY)
                        {
                           L0100();
                           PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(MAIN_KEY, ST_JUST));
                           REDISPLAY = "";
                        }
                        if (INTERACT == VALID_DATA)
                        {
                           /*  Existing course */
                           PROG_MESS[3] = SELECT_DATE;
                           DETAILS_ID = SELECT_DATE + "*" + MAIN_KEY;
                           if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                           {
                              L8000();
                              /*  Build Temp.Rec */
                              /*  Deal with display-only fields */
                              START_FIELD = 2;
                              END_FIELD = 11;
                              L6000();
                              /*  Display selected field data */
                              START_FIELD = CENTRE_FIELD_NO;
                              END_FIELD = TIMES_FIELD_NO;
                              L6000();
                              // BEGIN CASE
                              // CASE
                              if (COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE)
                              {
                                 nrf0 = 13;
                                 nrf1 = INIT;
                                 FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                                 INTERACT = INVALID_DATA;
                              }// CASE
                              else if (OTHERWISE)
                              {
                                 AMENDING = FALSE;
                                 OLD_COURSE_DATE = SELECT_DATE;
                                 L1025();
                                 /*  Check/display booking levels */
                              }
                              // END CASE
                              if (INTERACT == INVALID_DATA)
                              {
                                 ANS = "";
                                 MAIN_KEY = "";
                                 VALUE = "";
                                 PROG_MESS[2] = "";
                              }
                           }
                           else
                           {
                              INTERACT = INVALID_DATA;
                              nrf0 = 3;
                              nrf1 = INIT;
                              FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                           }
                        }
                     }
                     else
                     {
                        nrf0 = 50;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                        PROG_MESS[2] = "";
                        MAIN_KEY = "";
                        VALUE = "";
                        ANS = "";
                     }
                  }
                  else
                  {
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
                  /*  DJA 17/7/95 - Course was locked */
               }
               if (INTERACT != INVALID_DATA)
               {
                  if (AMENDING) { L0300(); }
                  INTERACT = VALID_DATA;
               }
            }
            else
            {
               nrf0 = 7;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               PRINT(SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
               PRINT(AT(0, 23) + FORMAT("", JUST));
            }
         }// CASE
         else if (ANS == "" && MAIN_KEY != "")
         {
            /*  User has pressed return after using 'backup' to get to the key field */
            INTERACT = VALID_DATA;
            ANS = MAIN_KEY;
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }
         // END CASE
         return;
         /* *************************************************************** */
      }
      void L1025()
      {
         /*   Check booking levels against todays date and warn the   * */
         /*       user if there are any that aren't bookable yet          * */
         /* *************************************************************** */
         LEVELS_ALLOWED = "";
         LEVEL = 1;
         NO_LEVELS = 0;
         do
         {
            LEVEL_TEXT = COURSE_PARAM_REC[LEVEL];
            if (LEVEL_TEXT == "") break;
            NO_LEVELS = NO_LEVELS + 1;
            if (TODAYS_DATE >= COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, LEVEL])
            {
               LEVELS_ALLOWED[LEVEL] = TRUE;
            }
            LEVEL = LEVEL + 1;
         } while (true);
         NO_LEVELS_ALLOWED = COUNT(LEVELS_ALLOWED, TRUE);
         // BEGIN CASE
         // CASE
         if (NO_LEVELS >= 1 && NO_LEVELS_ALLOWED < 1 && BLOCK_FUTURE_COURSES == "Y")
         {
            nrf0 = 60;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (NO_LEVELS_ALLOWED < NO_LEVELS)
         {
            /*  There must be some levels which are not yet bookable - warn user */
            nrf0 = COURSE_DET_REC[COURSE_DET_BOOKING_DATES];
            FL738 = new FL738(ref COURSE_PARAM_REC, ref LEVELS_ALLOWED, ref nrf0, ref NO_LEVELS);
            L0100();
            START_FIELD = 1;
            END_FIELD = 11;
            L6000();
            START_FIELD = CENTRE_FIELD_NO;
            END_FIELD = TIMES_FIELD_NO;
            L6000();
            FIELD_NO = 1;
            FIELD_DATA = DATA_FIELDS[FIELD_NO];
            L0200();
         }
         // END CASE
         return;
      }
      void L1200()
      {
         /*   DUMMY Validation Routine (Display only fields) */
         INTERACT = VALID_DATA;
         return;
      }
      void L1300()
      {
         /*   STUDENT OR MEMBER NO Validation Routine */
         STUDENT_IS_MEMBER = FALSE;
         ANS = "N";
         if (!READV(ref WAIT_LIST, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_LIST = ""; }
         WAIT_LIST_COUNT = DCOUNT(WAIT_LIST, VM);
         // BEGIN CASE
         // CASE
         if (COURSE_DET_REC[COURSE_DET_VACANCIES] < NO_OF_STUDENTS && ANS == "N")
         {
            nrf0 = 501;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS == "N")
         {
            if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
            /*  Create a new student via the separate maintenance screen */
            MAT(ref STUDENT_REC, "");
            NEW_STUDENT = TRUE;
            nrf0 = "N";
            CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref STUDENT_ID);
            ANS = STUDENT_ID;
            STUDENT_REC[STUDENT_SURNAME] = TEMP_REC[38];
            STUDENT_REC[STUDENT_FORENAME] = TEMP_REC[37];
            STUDENT_REC[STUDENT_TITLE] = TEMP_REC[36];
            STUDENT_REC[STUDENT_WORK_TEL] = TEMP_REC[39];
            STUDENT_REC[STUDENT_ADDRESS1] = TEMP_REC[35];
            L8500();
            /*  Update temp.rec with student data */
            INTERACT = VALID_DATA;
            /*  Now establish the concession rate for this NEW student */
            if (INTERACT != INVALID_DATA)
            {
               AMENDING = FALSE;
               MEMBER_NUMBER = "";
               L5000();
            }
         }
         // END CASE
         return;
      }
      void L1500()
      {
         /*   PAYMENT */
         INTERACT = VALID_DATA;
         CONV_ANS = TICKET_PRICE;
         ANS = OCONV(CONV_ANS, "MD2");
         TICKET_REC[TICK_TOTAL] = CONV_ANS;
         /*  Initially set to value for a single student */
         TICKET_REC[TICK_UNIT_PRICE] = CONV_ANS;
         TEMP_REC[29][1, 2] = -CONV_ANS;
         TEMP_REC[23] = TEMP_REC[17] - CONV_ANS;
         return;
      }
      void L1700()
      {
         /*  RECEIPT */
         RECEIPT_REQUIRED = TRUE;
         RECEIPT_NO = "";
         ANS = "Y";
         INTERACT = VALID_DATA;
         /*  Downdate number of vacancies */
         TEMP_REC[3] = TEMP_REC[3] - NO_OF_STUDENTS;
         /*  Dealing with payment and receipt if necessary */
         MAT(ref TICKET_REC, "");
         /*  Initialises TICK.MOP automatically */
         TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
         TICKET_REC[TICK_UNIT] = NO_OF_STUDENTS;
         TICKET_REC[TICK_UNIT_PRICE] = TICKET_PRICE;
         TICKET_REC[TICK_DATE] = TODAYS_DATE;
         TICKET_REC[TICK_TIME] = TIME();
         TICKET_REC[TICK_TOTAL] = TICKET_PRICE * NO_OF_STUDENTS;
         TICKET_REC[TICK_CLERK] = U_INITS;
         TICKET_REC[TICK_TILL] = TILL_NUMBER;
         TICKET_REC[TICK_CONCESS] = TEMP_REC[24];
         TICKET_REC[TICK_HOME_CENTRE] = COMMON.CENTRE;
         if (TICKET_REC[TICK_TOTAL] == 0)
         {
            /*  MOP Irrelevant */
            INTERACT = VALID_DATA;
            MOP = "C";
            TICKET_REC[TICK_MOP] = "C";
            /*  Default to cash */
         }
         else
         {
            INTERACT = INVALID_DATA;
            /*  Ask if payment is being made now or later */
            PAYMENT_RECEIVED = FALSE;
            PAYMENT_ESTABLISHED = FALSE;
            do
            {
               PRINT(AT(78, 21) + NRM_VID);
               PRINT(AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
               PRINT(AT(5, 21) + SPACE(73));
               FOOT_MESS = "Do you wish to take full payment now?";
               PRINT(AT(5, 21) + FOOT_MESS);
               PRINT(AT(LEN(FOOT_MESS) + 6, 21));
               INPUT(out PAY_ANS, 2);
               PAY_ANS = OCONV(PAY_ANS, "MCU");
               // BEGIN CASE
               // CASE
               if (PAY_ANS == COMMON.ABANDON)
               {
                  INTERACT = EXIT;
                  PROG_MESS[1] = COMMON.ABANDON;
                  nrf0 = 504;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }// CASE
               else if (PAY_ANS == "Y")
               {
                  PAYMENT_RECEIVED = TRUE;
                  PAYMENT_ESTABLISHED = TRUE;
               }// CASE
               else if (PAY_ANS == "N")
               {
                  PAYMENT_RECEIVED = FALSE;
                  PAYMENT_ESTABLISHED = TRUE;
               }
               // END CASE
               if (PAYMENT_ESTABLISHED || INTERACT == EXIT) break;
            } while (true);
            if (PAYMENT_RECEIVED == TRUE)
            {
               do
               {
                  if (!(INTERACT == INVALID_DATA)) break;
                  PRINT(AT(78, 23) + NRM_VID);
                  PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                  PRINT(AT(2, 23) + SPACE(76));
                  FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque or other mop" + SPACE(1);
                  PRINT(AT(2, 23) + FOOT_MESS);
                  PRINT(AT(LEN(FOOT_MESS) + 2, 23));
                  INPUT(out MOP, 5);
                  // BEGIN CASE
                  // CASE
                  if (MOP == COMMON.ABANDON)
                  {
                     INTERACT = EXIT;
                     PROG_MESS[1] = COMMON.ABANDON;
                     nrf0 = 504;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }// CASE
                  else if (MOP == "M" && ALLOW_MULTIPAY == "N")
                  {
                     INTERACT = INVALID_DATA;
                  }// CASE
                  else if (BASKET_COUNT > 0)
                  {
                     nrf0 = 82;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }// CASE
                  else if (MOP == "")
                  {
                     /*  Cash */
                     INTERACT = VALID_DATA;
                     TICKET_REC[TICK_MOP] = "C";
                  }// CASE
                  else if (MOP == MOP_TYPES[2])
                  {
                     /*  Cheque */
                     TICKET_REC[TICK_MOP] = MOP;
                     INTERACT = INVALID_DATA;
                     do
                     {
                        if (!(INTERACT == INVALID_DATA)) break;
                        /*  Cheque */
                        /*  DJA 5.12.03 */
                        PRINT(AT(79, 23) + NRM_VID);
                        PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                        PRINT(AT(2, 23) + SPACE(76));
                        PRINT(AT(2, 23) + " Cheque Number: ");
                        PRINT(AT(18, 23));
                        INPUT(out CHQ_NO, 7);
                        // BEGIN CASE
                        // CASE
                        if (MATCH(CHQ_NO, "6N"))
                        {
                           INTERACT = VALID_DATA;
                           CC_REF = CHQ_NO;
                           /*  OK, its a lazy cheat */
                           TICKET_REC[TICK_CC_REF] = CC_REF;
                        }// CASE
                        else if (CHQ_NO == COMMON.ABANDON)
                        {
                           INTERACT = EXIT;
                        }// CASE
                        else if (OTHERWISE)
                        {
                           INTERACT = INVALID_DATA;
                        }
                        // END CASE
                     } while (true);
                     if (INTERACT == EXIT) { INTERACT = INVALID_DATA; /*  Reprompt for MOP */ }
                  }// CASE
                  else if (MOP == MOP_TYPES[3])
                  {
                     INTERACT = VALID_DATA;
                     CC_REF = "";
                     CC_EXP = "";
                     /* <EFT */
                     EFT_CONF = "";
                     CC_ISSUE = "";
                     CC_START = "";
                     EFT_AMOUNT = 0;
                     /* EFT> */
                     RET_FUNC = "";
                     PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                     /*                  CALL FL361(CC.REF,CC.EXP,RET.FUNC) */
                     /* <EFT */
                     if (EFT_SITE)
                     {
                        CC_AUTH = INIT;
                        CC_EXP = INIT;
                        CC_ISSUE = INIT;
                        CC_REF = INIT;
                        CC_START = INIT;
                        SWIPE_DETAILS = INIT;
                        PRINTCR(AT(2, 22) + SPACE(76) + AT(2, 22) + "Enter CC Reference & Expiry");
                        nrf0 = 65;
                        nrf1 = 21;
                        nrf2 = 45;
                        FL361_EFT = new FL361_EFT(ref nrf0, ref nrf1, ref CC_REF, ref CC_EXP, ref CC_AUTH, ref nrf2, ref EFT_SITE, ref SWIPE_DETAILS, ref CC_START, ref CC_ISSUE, ref CARD_CVS);
                        if (CC_REF == COMMON.ABANDON)
                        {
                           RET_FUNC = COMMON.ABANDON;
                        }
                        else
                        {
                           PRINT(AT(2, 22) + SPACE(76) + NRM_VID);
                           EFT_CONF = "Student : " + MAIN_KEY;
                           EFT_AMOUNT = TICKET_REC[TICK_TOTAL] + 0;
                           FL_EFT = new FL_EFT(ref SWIPE_DETAILS, ref CC_REF, ref CC_EXP, ref CC_ISSUE, ref CC_START, ref EFT_AMOUNT, ref EFT_CONF, ref RET_FUNC, ref PROGRAM, ref CARD_CVS);
                           if (RET_FUNC != VALID_DATA)
                           {
                              RET_FUNC = COMMON.ABANDON;
                           }
                           else
                           {
                           }
                        }
                        /* EFT! */
                     }
                     else
                     {
                        FL361_1 = new FL361_1(ref CC_REF, ref CC_EXP, ref RET_FUNC);
                     }
                     /* EFT > */
                     if (RET_FUNC == COMMON.ABANDON)
                     {
                        INTERACT = INVALID_DATA;
                        /*  Clear credit card prompt */
                        PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SPACE(70));
                     }
                     else
                     {
                        INTERACT = VALID_DATA;
                        TICKET_REC[TICK_MOP] = MOP;
                        TICKET_REC[TICK_CC_REF] = CC_REF;
                        TICKET_REC[TICK_CC_EXP] = CC_EXP;
                        /* <EFT */
                        if (EFT_SITE)
                        {
                           TICKET_REC[TICK_EFT_SEQNO] = EFT_CONF[1] + VM + EFT_CONF[2] + VM + EFT_CONF[3];
                           TICKET_REC[TICK_EFT_SWIPE] = SWIPE_DETAILS + VM + CC_START + VM + CC_ISSUE;
                        }
                        /* EFT> */
                     }
                  }// CASE
                  else if (OTHERWISE)
                  {
                     AMC = 4;
                     NO_MOPS = DCOUNT(MOP_TYPES, AM);
                     MOP_FOUND = FALSE;
                     do
                     {
                        if (MOP_FOUND || AMC > NO_MOPS) break;
                        if (MOP == MOP_TYPES[AMC])
                        {
                           TICKET_REC[TICK_MOP] = MOP;
                           MOP_FOUND = TRUE;
                        }
                        AMC = AMC + 1;
                     } while (true);
                     if (NOT(MOP_FOUND))
                     {
                        nrf0 = 10;
                        nrf1 = INIT;
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                     }
                     else
                     {
                        INTERACT = VALID_DATA;
                     }
                  }
                  // END CASE
               } while (true);
               PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
               PRINT(AT(0, 23) + SPACE(78));
            }
            else
            {
               MOP = "C";
               TICKET_REC[TICK_MOP] = "C";
               /*  Default to cash */
               TICKET_REC[TICK_TOTAL] = 0;
               TICKET_REC[TICK_UNIT_PRICE] = 0;
               TEMP_REC[23] = TEMP_REC[17];
               /*  Balance = fee */
               if (INTERACT != EXIT) { INTERACT = VALID_DATA; }
            }
         }
         if (INTERACT == VALID_DATA && (RECEIPT_REQUIRED || TICKET_REC[TICK_TOTAL] != 0) && MOP != "M")
         {
            L8800();
            /*  Update temp.rec transaction whether or not a receipt is required */
         }
         return;
      }
      void L2100()
      {
         /*  Number of places */
         if (MATCH(ANS, "1N") || MATCH(ANS, "2N"))
         {
            if (ANS > 0)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               nrf0 = 502;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         else
         {
            nrf0 = 503;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L2200()
      {
         /*  Group Name */
         INTERACT = VALID_DATA;
         return;
      }
      void L2300()
      {
         /*  Leader Title */
         INTERACT = VALID_DATA;
         return;
      }
      void L2400()
      {
         /*  Leader Forename */
         INTERACT = VALID_DATA;
         return;
      }
      void L2500()
      {
         /*  Leader Surname */
         INTERACT = VALID_DATA;
         return;
      }
      void L2600()
      {
         /*  Contact Phone */
         INTERACT = VALID_DATA;
         /*  Clear dots from Total Due display field */
         START_FIELD = TOTAL_FIELD_NO;
         END_FIELD = TOTAL_FIELD_NO;
         L6000();
         return;

         #endregion
         /* ******************************************************** */
      }
      void L5000()
      {
         /*  Establish concession data for a newly enrolled    * */
         /*      student                                           * */
         /* ******************************************************** */
         ADJUSTED_FEE = FALSE;
         TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
         TICKET_TYPE = "C";
         SALE_DATE = PROG_MESS[3];
         SALE_TIME = TIME();
         TICKET_CONCESS = "";
         PERIOD = "";
         TICKET_PRICE = "";
         BONUS_REDEEM_REC = "";
         TOTAL_REDEMPTION = 0;
         TOTAL_POINTS = 0;
         TOTAL_POINTS_REDEEMED = 0;
         FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
         STORED_MEMBER_NUMBER = MEMBER_NUMBER;
         do
         {
            DONE = TRUE;
            FL048 = new FL048(ref TICK_FEES_REC, ref TICKET_PRICE, ref PERIOD, ref MEMBER_NUMBER, ref TICKET_CONCESS);
            if (TICKET_CONCESS == "")
            {
               TICKET_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, 1];
               TICKET_PRICE = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, 1];
            }
            /*  Validate that this concession doesn't exceed a group maximum as defined */
            /*  in page 2 of Course Maintenance */
            GROUP_MULTIVALUE = "";
            /*  This variable must be retained so that the group vacancies can be downdated later */
            if (LOCATE(TICKET_CONCESS, TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL"))
            {
               GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESS_POS];
               if (GROUP_NAME != "")
               {
                  if (LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP_MULTIVALUE, "AL"))
                  {
                     if (COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] < NO_OF_STUDENTS)
                     {
                        INTERACT = INVALID_DATA;
                        DONE = TRUE;
                        nrf0 = 505;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     }
                  }
               }
            }
            if (DONE) break;
         } while (true);
         MEMBER_NUMBER = STORED_MEMBER_NUMBER;
         if (INTERACT == VALID_DATA)
         {
            if (TICKET_PRICE == "") { TICKET_PRICE = 0; }
            /*  PRO-RATA COURSE FEE IF COURSE HAS STARTED */
            ORIGINAL_TICKET_TOTAL = TICKET_PRICE;
            COURSE_DATE = PROG_MESS[3];
            if (COURSE_DATE <= TODAYS_DATE && PRO_RATA_FEE == "Y")
            {
               REMAINING_SESSIONS = 0;
               TOTAL_SESSIONS = 0;
               EX_DATE = COURSE_DATE;
               do
               {
                  if (EX_DATE > COURSE_DET_REC[COURSE_DET_END]) break;
                  FL873 = new FL873(ref EX_DATE, ref COURSE_DATE, ref COURSE_DET_REC, ref DATE_QUALIFIES);
                  if (DATE_QUALIFIES)
                  {
                     if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] != "N")
                     {
                        if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] == "Y")
                        {
                           CALENDAR_ID = EX_DATE;
                        }
                        else
                        {
                           CALENDAR_ID = COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] + "*" + EX_DATE;
                        }
                        if (READ(ref CAL_REC, FL_COURSE_CALENDAR, CALENDAR_ID))
                        {
                           if (CAL_REC[2] == "C")
                           {
                              /*  Courses do not run on this day */
                              DATE_QUALIFIES = FALSE;
                           }
                        }
                     }
                     if (DATE_QUALIFIES)
                     {
                        TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
                        if (EX_DATE == TODAYS_DATE && COURSE_DET_REC[COURSE_DET_START_TIME] != "" && COURSE_DET_REC[COURSE_DET_START_TIME] < TIME())
                        {
                           /*  Ask user whether today's session should be included */
                           FOOT_DONE = FALSE;
                           do
                           {
                              FOOT_QUESTION = " Do you wish to charge for today's session? ";
                              PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 21) + FOOT_QUESTION + SPACE(3) + AT(46, 21));
                              INPUT(out FOOT_ANS, 2);
                              // BEGIN CASE
                              // CASE
                              if (OCONV(FOOT_ANS, "MCU") == "Y")
                              {
                                 REMAINING_SESSIONS = REMAINING_SESSIONS + 1;
                                 FOOT_DONE = TRUE;
                              }// CASE
                              else if (OCONV(FOOT_ANS, "MCU") == "N")
                              {
                                 FOOT_DONE = TRUE;
                              }
                              // END CASE
                              if (!(FOOT_DONE == FALSE)) break;
                           } while (true);
                        }
                        else
                        {
                           if (EX_DATE > TODAYS_DATE || (EX_DATE == TODAYS_DATE && (COURSE_DET_REC[COURSE_DET_START_TIME] == "" || COURSE_DET_REC[COURSE_DET_START_TIME] > TIME())))
                           {
                              REMAINING_SESSIONS = REMAINING_SESSIONS + 1;
                           }
                        }
                     }
                  }
                  EX_DATE = EX_DATE + 1;
               } while (true);
               if (REMAINING_SESSIONS < TOTAL_SESSIONS)
               {
                  TICKET_PRICE = INT(TICKET_PRICE * (REMAINING_SESSIONS / TOTAL_SESSIONS) + .5M);
                  ADJUSTED_FEE = TRUE;
                  FOOT_WARN = " PRO-RATA'D FEE: �" + OCONV(ORIGINAL_TICKET_TOTAL, "MD2") + " x (" + REMAINING_SESSIONS + " / " + TOTAL_SESSIONS + ") = �" + OCONV(TICKET_PRICE, "MD2");
                  PRINT(AT(0, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                  PRINT(AT(2, 20) + FORMAT(FOOT_WARN, "L#75"));
               }
            }
            PRO_RATA_PRICE = TICKET_PRICE;
            L8700();
            /*  Build student ORIGINAL DEBIT details into temp.rec */
            /*  Display ticket price */
            TEMP_REC[40] = NO_OF_STUDENTS * TICKET_PRICE;
            START_FIELD = TOTAL_FIELD_NO;
            END_FIELD = TOTAL_FIELD_NO;
            L6000();
         }
         return;
         /* ***************************************** */
      }
      void L6000()
      {
         /*   Display data for selected fields  * */
         /* ***************************************** */
         OLD_FIELD_NO = FIELD_NO;
         OLD_FIELD_DATA = FIELD_DATA;
         for (FIELD_NO = START_FIELD; FIELD_NO <= END_FIELD; FIELD_NO += 1)
         {
            FIELD_DATA = DATA_FIELDS[FIELD_NO];
            L0200();
            // BEGIN CASE
            // CASE
            if (ST_ATT == 0)
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
            }// CASE
            else if (ST_CONVERSION != "")
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
            }// CASE
            else if (OTHERWISE)
            {
               if (ST_ATT != 6)
               {
                  PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
               }
               /*  Show instructors full name */
               if (ST_ATT == 6)
               {
                  NO_INSTRUCTORS = DCOUNT(TEMP_REC[ST_ATT], VM);
                  if (NO_INSTRUCTORS <= 1)
                  {
                     if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, TEMP_REC[ST_ATT])) { MAT(ref INSTRUCTOR_REC, ""); }
                     FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
                     PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
                     PRINT(AT(ST_COL + 7, ST_ROW) + FORMAT(FULL_INSTRUCTOR_NAME, ST_JUST));
                  }
                  else
                  {
                     if (!READV(ref INSTRUCTOR_SURNAME1, FL_INSTRUCTORS, TEMP_REC[ST_ATT][1, 1], 3)) { INSTRUCTOR_SURNAME1 = ""; }
                     if (!READV(ref INSTRUCTOR_SURNAME2, FL_INSTRUCTORS, TEMP_REC[ST_ATT][1, 2], 3)) { INSTRUCTOR_SURNAME2 = ""; }
                     PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT((INSTRUCTOR_SURNAME1 + "/" + INSTRUCTOR_SURNAME2), "L#30"));
                  }
               }
            }
            // END CASE
         }
         FIELD_NO = OLD_FIELD_NO;
         FIELD_DATA = OLD_FIELD_DATA;
         L0200();
         return;
         /* ******************************** */
      }
      void L8000()
      {
         /*   Build temp.rec           * */
         /* ******************************** */
         TEMP_REC[1] = COURSE_MSTR_REC[COURSE_MSTR_DESC];
         TEMP_REC[2] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
         TEMP_REC[3] = COURSE_DET_REC[COURSE_DET_VACANCIES];
         TEMP_REC[4] = PROG_MESS[3];
         TEMP_REC[5] = COURSE_DET_REC[COURSE_DET_END];
         TEMP_REC[6] = COURSE_DET_REC[COURSE_DET_INSTRUCTOR];
         /*  DJA 18.7.01 */
         if (COURSE_DET_REC[COURSE_DET_INSTRUCTOR2] != "") { TEMP_REC[6][1, 2] = COURSE_DET_REC[COURSE_DET_INSTRUCTOR2]; }
         TEMP_REC[7] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
         TEMP_REC[8] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
         TEMP_REC[9] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
         TEMP_REC[10] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
         TEMP_REC[43] = COURSE_MSTR_REC[COURSE_MSTR_CENTRE];
         if (COURSE_DET_REC[COURSE_DET_START_TIME] != "" && COURSE_DET_REC[COURSE_DET_END_TIME] != "")
         {
            TEMP_REC[44] = OCONV(COURSE_DET_REC[COURSE_DET_START_TIME], "MT") + " - " + OCONV(COURSE_DET_REC[COURSE_DET_END_TIME], "MT");
         }
         return;
         /* ************************************************ */
      }
      void L8500()
      {
         /*  Build student related temp.rec attributes * */
         /* ************************************************ */
         TEMP_REC[11] = STUDENT_ID;
         TEMP_REC[12] = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
         TEMP_REC[13] = STUDENT_REC[STUDENT_ADDRESS1];
         TEMP_REC[14] = STUDENT_REC[STUDENT_MEDICAL1];
         TEMP_REC[15] = STUDENT_REC[STUDENT_MEDICAL2];
         TEMP_REC[16] = STUDENT_REC[STUDENT_MEDICAL3];
         return;
         /* ***************************************************** */
      }
      void L8700()
      {
         /*   Put enrolment/student details into temp.rec */
         /*       (ORIGINAL DEBIT) */
         /* ***************************************************** */
         TEMP_REC[24] = TICKET_CONCESS;
         TEMP_REC[17] = TICKET_PRICE;
         TEMP_REC[23] = TICKET_PRICE;
         /*  Balance */
         /*  Temp.rec attributes relating to the student transaction fields */
         /*  have two multivalues. <n,1> = Original Debit.  <n,2> = 1st Payment */
         TEMP_REC[26] = DETAILS_ID;
         TEMP_REC[27] = TODAYS_DATE;
         TEMP_REC[28] = "O";
         /*  Original debit */
         TEMP_REC[29] = TICKET_PRICE;
         return;
         /* *********************************************************** */
      }
      void L8800()
      {
         /*   Put details of initial payment into temp.rec        * */
         /* *********************************************************** */
         TEMP_REC[26][1, 2] = DETAILS_ID;
         TEMP_REC[27][1, 2] = TODAYS_DATE;
         TEMP_REC[28][1, 2] = "P";
         /*  Payment */
         if (PAYMENT_RECEIVED == TRUE)
         {
            TEMP_REC[29][1, 2] = -(TICKET_PRICE);
            /*  Credit Amount */
         }
         else
         {
            TEMP_REC[29][1, 2] = 0;
         }
         TEMP_REC[30][1, 2] = RECEIPT_NO;
         /*  Receipt No. */
         TEMP_REC[31][1, 2] = TICKET_REC[TICK_MOP];
         /*  MOP */
         return;
         /* ******************************************* */
      }
      void L9000()
      {
         /*   Transfer data out of temp.rec       * */
         /* ******************************************* */
         COURSE_DET_REC[COURSE_DET_VACANCIES] = TEMP_REC[3];
         ENROL_REC[ENROL_CONCESSION] = TEMP_REC[24];
         ENROL_REC[ENROL_PRICE] = TEMP_REC[17];
         /*  TEMP.REC(21), (22) and (25) are now spare */
         ENROL_REC[ENROL_FULL_PRICE] = TEMP_REC[32];
         ENROL_REC[ENROL_FEE_OVERRIDE_USER] = TEMP_REC[33];
         /*  Append transactions if necessary */
         MVC = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM) + 1;
         PAYMENT_MVC = MVC + 1;
         /*  Passed back to controlling routine */
         /*  DJA 1.5.97 Remove duff 0.00 payments. Otherwise, if no receipt was */
         /*             requested, the transaction amounts attribute gets out of */
         /*             step with the dates, mops etc. */
         NO_TEMP_DATES = DCOUNT(TEMP_REC[27], VM);
         NO_TEMP_AMOUNTS = DCOUNT(TEMP_REC[29], VM);
         if (NO_TEMP_DATES == 1 && NO_TEMP_AMOUNTS > 1)
         {
            TEMP_REC[29] = TEMP_REC[29][1, 1];
         }
         if (MVC == 1)
         {
            /*  First transactions for this student */
            STUDENT_REC[STUDENT_TRANS_DETAILS_IDS] = TEMP_REC[26];
            STUDENT_REC[STUDENT_TRANS_DATES] = TEMP_REC[27];
            STUDENT_REC[STUDENT_TRANS_TYPES] = TEMP_REC[28];
            STUDENT_REC[STUDENT_TRANS_AMOUNTS] = TEMP_REC[29];
            STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS] = TEMP_REC[30];
            STUDENT_REC[STUDENT_TRANS_MOPS] = TEMP_REC[31];
         }
         else
         {
            /*  Transactions already exist */
            STUDENT_REC[STUDENT_TRANS_DETAILS_IDS] = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS] + VM + TEMP_REC[26];
            STUDENT_REC[STUDENT_TRANS_DATES] = STUDENT_REC[STUDENT_TRANS_DATES] + VM + TEMP_REC[27];
            STUDENT_REC[STUDENT_TRANS_TYPES] = STUDENT_REC[STUDENT_TRANS_TYPES] + VM + TEMP_REC[28];
            STUDENT_REC[STUDENT_TRANS_AMOUNTS] = STUDENT_REC[STUDENT_TRANS_AMOUNTS] + VM + TEMP_REC[29];
            STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS] = STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS] + VM + TEMP_REC[30];
            STUDENT_REC[STUDENT_TRANS_MOPS] = STUDENT_REC[STUDENT_TRANS_MOPS] + VM + TEMP_REC[31];
         }
         COURSE_BALANCE = TEMP_REC[23];
         /*  Passed back to controlling routine */
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
