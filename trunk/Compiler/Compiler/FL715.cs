//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL715 : UvBase
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
      readonly UvVar FL_DEBTORS = 43;
      readonly UvVar DD_DEBTORS_DATES = 1;
      readonly UvVar DD_DEBTORS_OWED = 2;
      readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
      readonly UvVar DD_DEBTORS_REASON = 4;
      readonly UvVar FL_DIRECT_DEBITS = 117;
      readonly UvVar DIRECT_DEBIT_INST_AMOUNT = 1;
      readonly UvVar DIRECT_DEBIT_ANNUAL_FEE = 2;
      readonly UvVar DIRECT_DEBIT_LETTER = 3;
      readonly UvVar DIRECT_DEBIT_ORIGINAL_DATE = 4;
      readonly UvVar DIRECT_DEBIT_NUMBER = 5;
      readonly UvVar DIRECT_DEBIT_AMOUNTS = 6;
      readonly UvVar DIRECT_DEBIT_DATES = 7;
      readonly UvVar DIRECT_DEBIT_OPERATOR = 8;
      readonly UvVar DIRECT_DEBIT_ADJ = 9;
      readonly UvVar DIRECT_DEBIT_PAID = 10;
      readonly UvVar DIRECT_DEBIT_TRANS_CNT = 11;
      readonly UvVar DIRECT_DEBIT_LAST_REQ_AMOUNT = 12;
      readonly UvVar DIRECT_DEBIT_LAST_DATE = 13;
      readonly UvVar DIRECT_DEBIT_LAST_RECD_AMOUNT = 14;
      readonly UvVar DIRECT_DEBIT_CANCELLED_DATE = 15;
      readonly UvVar DIRECT_DEBIT_DEPOSIT = 16;
      readonly UvVar DIRECT_DEBIT_REJECTIONS = 17;
      readonly UvVar DIRECT_DEBIT_ADJ_TYPE = 18;
      readonly UvVar DIRECT_DEBIT_FREEZE_DATE = 19;
      readonly UvVar DIRECT_DEBIT_CANCEL_REASON = 20;
      readonly UvVar MDATA_CODE = 1;
      readonly UvVar MDATA_ENROLMENT_DATE = 2;
      readonly UvVar MDATA_STUDENT_ID = 3;
      readonly UvVar CAL_TEXT = 1;
      readonly UvVar CAL_TYPE = 2;
      readonly UvVar APACS_MEMBER = 1;
      readonly UvVar EPURSE_APACS_NO = 1;
      readonly UvVar EPURSE_MEM_NO = 2;
      readonly UvVar EPURSE_DATE = 3;
      readonly UvVar EPURSE_TIME = 4;
      readonly UvVar EPURSE_USER = 5;
      readonly UvVar EPURSE_AMOUNT = 6;
      readonly UvVar EPURSE_CRED_OR_DEB = 7;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] INSTRUCTOR_REC = new UvVar[30];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] TICKET_REC = new UvVar[40];
      UvVar[] WAIT_MAST_REC = new UvVar[5];
      UvVar[] WAIT_STUDENT_REC = new UvVar[35];
      UvVar[] DEBTORS_REC = new UvVar[100];
      UvVar[] DD_DEBTORS_REC = new UvVar[10];
      UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
      UvVar[] MDATA_REC = new UvVar[5];
      UvVar[] CALENDAR_REC = new UvVar[10];
      UvVar[] APACS_REC = new UvVar[10];
      UvVar[] EPURSE_REC = new UvVar[15];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar STUDENT_AND_APACS_NOS = "";
      UvVar RECEIPT_REQUIRED = "";
      UvVar NEW_COURSE = "";
      UvVar COURSE_BALANCE = "";
      UvVar PAYMENT_MVC = "";
      UvVar GROUP_MULTIVALUE = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar WAITING_LIST_ENROLMENT = "";
      UvVar BONUS_REDEEM_REC = "";
      UvVar PROMOTION = "";
      UvVar MOP = "";
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar USER_STATUS = "";
      UvVar REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar ERR_MESS_BACK = "";
      UvVar ERR_MESS_FORE = "";
      UvVar SCREEN_WIDTH = "";
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
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_INSTRUCTORS = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_ENROLMENT = "";
      UvVar N = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_WAIT_MASTER = "";
      UvVar FL_WAIT_STUDENTS = "";
      UvVar FL_MULTIPAY = "";
      UvVar FL_DD_DEBTORS = "";
      UvVar FL_MARKETING_DATA = "";
      UvVar FL_COURSE_CALENDAR = "";
      UvVar FL_APACS_NUMBERS = "";
      UvVar FL_EPURSE_LOG = "";
      UvVar LABEL_PRINT = "";
      UvVar PROMOTIONS_CONTROL = "";
      UvVar CURRENT_PROMOTIONS = "";
      UvVar BONUS_REDEEM_PROG = "";
      UvVar MOP_TYPES = "";
      UvVar SMART_CARD = "";
      UvVar EPURSE_ROUTINE = "";
      UvVar TICKET_CONCESS = "";
      UvVar MANUAL_RECEIPTS = "";
      UvVar COURSE_PARAMS = "";
      UvVar VALID_PRIVILEGES = "";
      UvVar GET_CARD_NO = "";
      UvVar PREVENT_PP_AND_INSTALMENTS = "";
      UvVar PREVENT_ZERO_PAYMENTS = "";
      UvVar PRO_RATA_FEE = "";
      UvVar PERMIT_BALANCE_TRANSFERS = "";
      UvVar ALLOW_MULTIPAY = "";
      UvVar CHEQUE_PROMPT = "";
      UvVar FEE_TODAY = "";
      UvVar SHOW_MEMBERSHIPS = "";
      UvVar CENTRALISED_COURSES = "";
      UvVar NAME_INDEX_REQUEST = "";
      UvVar SOUND_INDEX_REQUEST = "";
      UvVar ADDRESS_INDEX_REQUEST = "";
      UvVar BLOCK_FUTURE_COURSES = "";
      UvVar FULL_PAYMENT_DEFAULT = "";
      UvVar MARKETING_PROMPT = "";
      UvVar USE_MEMBER_COMMENTS = "";
      UvVar EFT_SITE = "";
      UvVar PHOTO_CODES = "";
      UvVar DISPLAY_PHOTO = "";
      UvVar TEST_POS = "";
      UvVar MAX_FIELDS = "";
      UvVar DATA_FIELDS = "";
      UvVar DISPLAY_ONLY_FIELDS = "";
      UvVar ENTRY_FIELDS = "";
      UvVar FIELD_COUNT = "";
      UvVar BALANCE = "";
      UvVar FEE_OVERRIDE = "";
      UvVar BALANCE_TRANSFER = "";
      UvVar COURSE_DATE = "";
      UvVar LINE = "";
      UvVar POS = "";
      UvVar PAYMENT_FIELD_NO = "";
      UvVar INSTALMENTS_FIELD_NO = "";
      UvVar RECEIPT_FIELD_NO = "";
      UvVar AMENDING = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar SNAPSHOT_PAYMENT_AMOUNT = "";
      UvVar KEEP_GOING = "";
      FL_HIDE_PHOTO FL_HIDE_PHOTO;
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      UvVar LABEL_TITLE = "";
      UvVar LABEL_FORENAMES = "";
      UvVar LABEL_SURNAME = "";
      UvVar LABEL_ADDRESS1 = "";
      UvVar LABEL_ADDRESS2 = "";
      UvVar LABEL_ADDRESS3 = "";
      UvVar LABEL_ADDRESS4 = "";
      UvVar LABEL_POSTCODE = "";
      CallAt_LABEL_PRINT CallAt_LABEL_PRINT;
      FL006 FL006;
      FL859 FL859;
      UvVar MARKETING_ID = "";
      UvVar REDISPLAY = "";
      UvVar MARKETING_SEQ = "";
      UvVar MVC = "";
      UvVar OK_TO_FILE = "";
      UvVar FIELD_DATA = "";
      UvVar ST_DISPLAY = "";
      UvVar ADJUSTED_FEE = "";
      UvVar FOOT_WARN = "";
      UvVar ORIGINAL_TICKET_TOTAL = "";
      UvVar REMAINING_SESSIONS = "";
      UvVar TOTAL_SESSIONS = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_LENGTH = "";
      UvVar MEMBER_PROGRAM = "";
      UvVar SMARTCARD_READ = "";
      CallAt_MEMBER_PROGRAM CallAt_MEMBER_PROGRAM;
      UvVar ST_MANDATORY = "";
      UvVar INST_PLAN_TOTAL = "";
      UvVar INST_FIRST_DUE = "";
      UvVar INST_NUMBER = "";
      UvVar INST_VALUE = "";
      UvVar INST_FREQUENCY = "";
      UvVar INST_DATES = "";
      UvVar INST_AMOUNTS = "";
      UvVar UNPAID_FEE = "";
      UvVar RECALC = "";
      FL749 FL749;
      UvVar DETAILS_ID = "";
      UvVar DISPLAY_PLAN = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar IFACE_TYPE = "";
      UvVar SMART_MEMBER_NO = "";
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
      UvVar NO_INSTRUCTORS = "";
      UvVar FULL_INSTRUCTOR_NAME = "";
      UvVar INSTRUCTOR_SURNAME1 = "";
      UvVar INSTRUCTOR_SURNAME2 = "";
      UvVar REPLY = "";
      UvVar DISPLAY_MODE = "";
      UvVar STUDENT_SCAN_ID = "";
      FL717 FL717;
      UvVar COURSE_ID = "";
      UvVar STATUS = "";
      CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
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
      UvVar OFFER_DECLINED = "";
      UvVar ANS2 = "";
      UvVar ACTIVITY_CODE = "";
      UvVar CONCESSION = "";
      UvVar MAX_PLACES = "";
      UvVar MASTER_LIST = "";
      UvVar PLACES_TAKEN = "";
      UvVar WAIT_DISPLAY_MODE = "";
      FL734 FL734;
      UvVar PASSED_STUDENT_ID = "";
      UvVar MATCH_LIST = "";
      FL723 FL723;
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      UvVar WAIT_LIST = "";
      UvVar WAIT_LIST_COUNT = "";
      UvVar TICKET_CODE = "";
      UvVar TICKET_TYPE = "";
      UvVar SALE_DATE = "";
      UvVar SALE_TIME = "";
      UvVar PERIOD = "";
      FL355 FL355;
      UvVar PRICE = "";
      UvVar RESPONSE = "";
      UvVar HELP_TEXT = "";
      FL_LIST FL_LIST;
      UvVar NEW_STUDENT = "";
      FL710 FL710;
      UvVar MEMBER_NUMBER = "";
      UvVar STUDENT_LIST = "";
      UvVar STATUS_LIST = "";
      UvVar ACTIVITY = "";
      FL735 FL735;
      UvVar WAIT_LIST_ENROLMENT = "";
      UvVar SEARCH_ROUTE = "";
      FL000_20 FL000_20;
      FL_PHOTO FL_PHOTO;
      UvVar MTYPES = "";
      UvVar CROSS_REFERENCED = "";
      UvVar TEST_MEMBER_NO = "";
      UvVar PADDED_ANS = "";
      FL000_40 FL000_40;
      UvVar STUDENT_EXISTS = "";
      UvVar STUDENT_POS = "";
      UvVar ENROL_ID = "";
      UvVar TEST_REC = "";
      UvVar FOUND_ON_MEMBERS = "";
      UvVar NEW_STUDENT_NO = "";
      CallAt_GET_CARD_NO CallAt_GET_CARD_NO;
      UvVar STORED_PROG_MESS = "";
      UvVar CONV_ANS = "";
      UvVar TOTAL_REDEMPTION = "";
      UvVar TOTAL_POINTS = "";
      CallAt_BONUS_REDEEM_PROG CallAt_BONUS_REDEEM_PROG;
      UvVar NEW_PRICE = "";
      UvVar TICKET_PRICE = "";
      UvVar NO_WEEKS = "";
      UvVar DAY_COURSE_STARTS = "";
      UvVar DAY_PLAN_STARTS = "";
      UvVar OFFSET = "";
      UvVar RECEIPT_NO = "";
      UvVar FOOT_MESS = "";
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
      UvVar PASSED_MEMBER_NO = "";
      FL00019 FL00019;
      UvVar AMC = "";
      UvVar NO_MOPS = "";
      UvVar MOP_FOUND = "";
      UvVar NO_EXPIRY_DATES = "";
      UvVar TYPE_STRING = "";
      UvVar DEBTOR_ID = "";
      FL535 FL535;
      UvVar DD_ID = "";
      UvVar CONTINUE = "";
      UvVar YES_NO = "";
      UvVar DD_DEBTOR_ID = "";
      UvVar MEMSHP_START = "";
      UvVar CONCESS_POS = "";
      UvVar GROUP_NAME = "";
      UvVar NO_TRANS = "";
      UvVar NO_WAITING = "";
      UvVar TOTAL_POINTS_REDEEMED = "";
      UvVar STORED_MEMBER_NUMBER = "";
      UvVar DONE = "";
      FL048 FL048;
      UvVar EX_DATE = "";
      FL873 FL873;
      UvVar DATE_QUALIFIES = "";
      UvVar CALENDAR_ID = "";
      UvVar CAL_REC = "";
      UvVar FOOT_DONE = "";
      UvVar FOOT_QUESTION = "";
      UvVar FOOT_ANS = "";
      UvVar PRO_RATA_PRICE = "";
      UvVar DET_ID_LIST = "";
      UvVar OLD_DESC_LIST = "";
      UvVar BALANCE_LIST = "";
      UvVar OLD_INSTALMENT_PLANS = "";
      UvVar OVERALL_BALANCE = "";
      UvVar TRANS_NO = "";
      UvVar DET_ID = "";
      UvVar DET_POS = "";
      UvVar OLD_DESC = "";
      UvVar PLAN_TOTAL = "";
      UvVar OLD_COURSE_COUNT = "";
      UvVar ROW = "";
      UvVar DET_MVC = "";
      UvVar FOOT_OPTION = "";
      FL019 FL019;
      UvVar ADJ_AMOUNT = "";
      UvVar TRANS_MVC = "";
      UvVar NO_DATES = "";
      UvVar NEXT_DATE = "";
      UvVar NEXT_VALUE = "";
      UvVar LAST_DATE = "";
      UvVar LAST_VALUE = "";
      UvVar TEXT_STRING = "";
      UvVar NO_TEMP_DATES = "";
      UvVar NO_TEMP_AMOUNTS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL715(ref UvVar STUDENT_AND_APACS_NOS, ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar[] ENROL_REC, ref UvVar[] STUDENT_REC, ref UvVar[] TICKET_REC, ref UvVar RECEIPT_REQUIRED, ref UvVar NEW_COURSE, ref UvVar COURSE_BALANCE, ref UvVar PAYMENT_MVC, ref UvVar GROUP_MULTIVALUE, ref UvVar OLD_COURSE_DATE, ref UvVar WAITING_LIST_ENROLMENT, ref UvVar[] WAIT_MAST_REC, ref UvVar BONUS_REDEEM_REC, ref UvVar PROMOTION, ref UvVar MOP)
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
         this.WAITING_LIST_ENROLMENT = WAITING_LIST_ENROLMENT;
         this.WAIT_MAST_REC = WAIT_MAST_REC;
         this.BONUS_REDEEM_REC = BONUS_REDEEM_REC;
         this.PROMOTION = PROMOTION;
         this.MOP = MOP;
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
         /*     COURSE ENROLMENT (NEW MODULE) */
         STUDENT_ID = STUDENT_AND_APACS_NOS[1];
         APACS_NO = STUDENT_AND_APACS_NOS[2];
         PROMPT("");
         /*  the next two lines inserted for the smart card interface */
         /* !*     EQU INSUFFICIENT.FUNDS TO 11, EXCEEDS.LIMIT TO 12 */
         PROGRAM = "FL715";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
         JUST = "";
         /*  DJA 7.4.00 */
         MOP = "";
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
         #region INCLUDE FL.FILES FL.DEBTORS

         #endregion
         #region INCLUDE FL.FILES FL.MULTIPAY
         if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

         #endregion
         #region INCLUDE FL.FILES FL.DD.DEBTORS

         if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

         #endregion
         #region INCLUDE FL.FILES FL.DIRECT.DEBITS

         #endregion
         #region INCLUDE FL.FILES FL.MARKETING.DATA
         if (!OPEN("FL.MARKETING.DATA", out FL_MARKETING_DATA)) { STOP("201", "FL.MARKETING.DATA"); }

         #endregion
         #region INCLUDE FL.FILES FL.COURSE.CALENDAR
         if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

         /*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

         #endregion
         #region INCLUDE FL.FILES FL.APACS.NUMBERS
         if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

         #endregion
         #region INCLUDE FL.FILES FL.EPURSE.LOG
         if (!OPEN("FL.EPURSE.LOG", out FL_EPURSE_LOG)) { STOP(201, "UNABLE TO OPEN FL.EPURSE.LOG"); }

         /*  <7> Contains (D)ebit or (C)redit */

         #endregion
         /* !*INCLUDE FL.FILES FL.EXPIRED.MEMBERSHIPS */
         if (!READV(ref LABEL_PRINT, COMMON.FILES[FL_CONTROL], "ADDRESS.LABEL.ROUTINE", 1)) { LABEL_PRINT = ""; }
         if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL")))
         {
            PROMOTIONS_CONTROL = "";
         }
         CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
         BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
         if (!READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")) { MOP_TYPES = ""; }
         /* !*  READV PCL.SMART.CARD FROM FL.CONTROL, 'PCL.SMART.CARD', 1 ELSE */
         /* !*     PCL.SMART.CARD = FALSE */
         /* !*  END */
         if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1)))
         {
            SMART_CARD = FALSE;
         }
         if (!(READV(ref EPURSE_ROUTINE, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 4)))
         {
            EPURSE_ROUTINE = "";
         }
         MAT(ref TEMP_REC, "");
         TICKET_CONCESS = "";
         if (!READV(ref MANUAL_RECEIPTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 2)) { MANUAL_RECEIPTS = "N"; }
         MANUAL_RECEIPTS = MANUAL_RECEIPTS[1, 1];
         if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
         VALID_PRIVILEGES = COURSE_PARAMS[3, 1];
         GET_CARD_NO = COURSE_PARAMS[11, 1];
         PREVENT_PP_AND_INSTALMENTS = COURSE_PARAMS[15, 1];
         PREVENT_ZERO_PAYMENTS = COURSE_PARAMS[25, 1];
         PRO_RATA_FEE = COURSE_PARAMS[31, 1];
         PERMIT_BALANCE_TRANSFERS = COURSE_PARAMS[32, 1];
         ALLOW_MULTIPAY = COURSE_PARAMS[41, 1];
         CHEQUE_PROMPT = COURSE_PARAMS[48, 1];
         if (CHEQUE_PROMPT == "") { CHEQUE_PROMPT = "Y"; }
         FEE_TODAY = COURSE_PARAMS[49, 1];
         if (FEE_TODAY == "") { FEE_TODAY = "N"; }
         SHOW_MEMBERSHIPS = COURSE_PARAMS[51, 1];
         if (SHOW_MEMBERSHIPS == "") { SHOW_MEMBERSHIPS = "N"; }
         if (PERMIT_BALANCE_TRANSFERS == "") { PERMIT_BALANCE_TRANSFERS = "Y"; }
         if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
         if (!(READV(ref NAME_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "NAME.INDEX.REQUEST", 1)))
         {
            NAME_INDEX_REQUEST = "I";
         }
         if (!(READV(ref SOUND_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "SOUND.INDEX.REQUEST", 1)))
         {
            SOUND_INDEX_REQUEST = "S";
         }
         if (!READV(ref ADDRESS_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "ADDRESS.INDEX.REQUEST", 1)) { ADDRESS_INDEX_REQUEST = "A"; }
         if (!READV(ref BLOCK_FUTURE_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 27)) { BLOCK_FUTURE_COURSES = "N"; }
         /*  DJA 18.3.03 */
         if (!READV(ref FULL_PAYMENT_DEFAULT, FL_COURSE_PARAMS, "COURSE.PARAMS", 34)) { FULL_PAYMENT_DEFAULT = "N"; }
         if (!READV(ref MARKETING_PROMPT, FL_COURSE_PARAMS, "COURSE.PARAMS", 42)) { MARKETING_PROMPT = "N"; }
         if (!READV(ref USE_MEMBER_COMMENTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 47)) { USE_MEMBER_COMMENTS = "N"; }
         USE_MEMBER_COMMENTS = USE_MEMBER_COMMENTS[1, 1];
         if (!MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "COURSE.BOOKING.LEVELS")) { MAT(ref COURSE_PARAM_REC, ""); }
         /* <EFT */
         if (!(READV(ref EFT_SITE, COMMON.FILES[FL_CONTROL], "EFT.SITE", 1)))
         {
            EFT_SITE = FALSE;
         }
         /* EFT> */
         /*  DJA 28.4.00 */
         if (!READ(ref PHOTO_CODES, COMMON.FILES[FL_CONTROL], "TEMP.PHOTO.CODES")) { PHOTO_CODES = ""; }
         if (PHOTO_CODES[1, 1] == "ALL")
         {
            DISPLAY_PHOTO = TRUE;
         }
         else
         {
            if (LOCATE(SCREEN_CODE, PHOTO_CODES, 1, 0, 1, ref TEST_POS, "AL"))
            {
               DISPLAY_PHOTO = TRUE;
            }
            else
            {
               DISPLAY_PHOTO = FALSE;
            }
         }
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
         /*  DJA 12.2.03 */
         BALANCE_TRANSFER = FALSE;
         COURSE_DATE = PROG_MESS[3];
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
         /*  DJA 31.07.00 */
         PAYMENT_FIELD_NO = 19;
         INSTALMENTS_FIELD_NO = 20;
         RECEIPT_FIELD_NO = 21;
         if (PREVENT_PP_AND_INSTALMENTS == "Y")
         {
            DATA_FIELDS[INSTALMENTS_FIELD_NO, 11] = "D";
            /*  View only */
         }
         /* ************************************ */
         /*   MAIN PROCESSING SECTION          * */
         /* ************************************ */
         do
         {
            INTERACT = VALID_DATA;
            L0100();
            AMENDING = FALSE;
            STUDENT_IS_MEMBER = FALSE;
            if (PROG_MESS[2] != "")
            {
               MAIN_KEY = PROG_MESS[2];
               AMENDING = TRUE;
               L8000();
               /*  Build temp.rec */
               L0300();
               /*  Display data */
            }
            else
            {
               MAIN_KEY = "";
               MAT(ref TEMP_REC, "");
            }
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     SNAPSHOT_PAYMENT_AMOUNT = TEMP_REC[29][1, 2] + 0;
                     if (INTERACT != LIMIT) { L0060(); }
                     KEEP_GOING = TRUE;
                     // BEGIN CASE
                     // CASE
                     if (INTERACT)
                     {
                        KEEP_GOING = FALSE;
                     }// CASE
                     else if (AMENDING && FIELD_NO == PAYMENT_FIELD_NO && TEMP_REC[29][1, 2] != 0 && SNAPSHOT_PAYMENT_AMOUNT == 0)
                     {
                        /*  User amended payment amount, possibly from 0.00 */
                        /*  Make sure a MOP is established by prompting for */
                        /*  Receipt field and clearing it first to stop */
                        /*  0060 intervening */
                        FIELD_NO = RECEIPT_FIELD_NO - 1;
                        TEMP_REC[20] = "";
                     }// CASE
                     else if (AMENDING)
                     {
                        KEEP_GOING = FALSE;
                     }// CASE
                     else if (FIELD_NO == MAX_FIELDS)
                     {
                        KEEP_GOING = FALSE;
                     }
                     // END CASE
                     /* !*              UNTIL ERROR OR AMENDING OR FIELD.NO = MAX.FIELDS DO */
                     if (NOT(KEEP_GOING)) break;
                     FIELD_NO = FIELD_NO + 1;
                  } while (true);
                  // BEGIN CASE
                  // CASE
                  if (INTERACT == EXIT)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == INVALID_DATA)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == BACKUP && AMENDING)
                  {
                     L0050();
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
            /*  DJA 28.4.00 */
            if (DISPLAY_PHOTO)
            {
               FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
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
            if (LABEL_PRINT == "")
            {
               INPUT_LINE = "      Enter Field no or 'F' to finish ";
            }
            else
            {
               INPUT_LINE = "      Enter Field no, 'F' to finish or '+' for label ";
            }
            PRINT(AT(0, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 20) + FORMAT("", "L#75"));
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + FORMAT(INPUT_LINE, "L#75"));
            PRINT(AT(2 + LEN(INPUT_LINE), 21));
            INPUT(out ANS, 4);
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS == "+" && LABEL_PRINT != "")
            {
               /*  NORFOLK SKI CLUB LABEL PRINT */
               if (STUDENT_IS_MEMBER)
               {
                  LABEL_TITLE = MEMBERS_REC[MEMBER_TITLES][1, 1];
                  LABEL_FORENAMES = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
                  LABEL_SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
                  LABEL_ADDRESS1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  LABEL_ADDRESS2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
                  LABEL_ADDRESS3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
                  LABEL_ADDRESS4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
                  LABEL_POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
               }
               else
               {
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
            else if (ANS == "H")
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
            else if ((ANS != "F" && ANS != "f") && EPURSE_ROUTINE != "" && MOP == "EP")
            {
               nrf0 = 345;
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
               /*  Next page */
               /* *         GOSUB 0055 */
               /* *         IF INTERACT = FINISH THEN PROG.MESS<1> = 2 */
            }// CASE
            else if (ANS == "F")
            {
               L0055();
               /* DJA 1.10.03*IF INTERACT = FINISH THEN PROG.MESS<1> = "" */
               if (INTERACT == FINISH)
               {
                  /*  Prompt for marketing code */
                  if (MARKETING_PROMPT == "Y")
                  {
                     INTERACT = INVALID_DATA;
                     do
                     {
                        if (INTERACT == VALID_DATA) break;
                        FL859 = new FL859(ref MARKETING_ID, ref INTERACT, ref REDISPLAY);
                     } while (true);
                     if (!READU(ref MARKETING_SEQ, FL_COURSE_PARAMS, "MARKETING.SEQ")) { MARKETING_SEQ = 0; }
                     MARKETING_SEQ = MARKETING_SEQ + 1;
                     MDATA_REC[MDATA_CODE] = MARKETING_ID;
                     MDATA_REC[MDATA_ENROLMENT_DATE] = TODAYS_DATE;
                     MDATA_REC[MDATA_STUDENT_ID] = STUDENT_ID;
                     MATWRITE(MDATA_REC, FL_MARKETING_DATA, MARKETING_SEQ);
                     WRITE(MARKETING_SEQ, FL_COURSE_PARAMS, "MARKETING.SEQ");
                     INTERACT = FINISH;
                  }
                  PROG_MESS[1] = "";
               }
            }// CASE
            else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p")
            {
               /* *       GOSUB 0055 */
               /* *       IF INTERACT = FINISH THEN PROG.MESS<1> = ANS[2,1] */
            }// CASE
            else if (MATCH(ANS, "0N") && ANS >= 1 && ANS <= 5)
            {
               // BEGIN CASE
               // CASE
               if (ANS == 2 && FEE_OVERRIDE == FALSE)
               {
                  nrf0 = 35;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (ANS >= 1 && ANS <= 3 && BONUS_REDEEM_REC != "")
               {
                  nrf0 = 55;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (OTHERWISE)
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
               /*  If user is allowed to alter the course fee, remind them in the footer */
               COURSE_DATE = PROG_MESS[3];
               if (COURSE_DATE <= TODAYS_DATE)
               {
                  if (ADJUSTED_FEE)
                  {
                     /*  The following line has been moved to 5000* Otherwise users who cannot */
                     /*  amend the course fee don't see the pro-rata calculation */
                     /* !*                 FOOT.WARN = " PRO-RATA'D FEE: ":OCONV(ORIGINAL.TICKET.TOTAL,"MD2"):" x (":REMAINING.SESSIONS:" / ":TOTAL.SESSIONS:")" */
                  }
                  else
                  {
                     FOOT_WARN = " NOTE : The course HAS started so you may wish to amend the course fee.";
                     PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                     PRINT(AT(2, 21) + FOOT_WARN);
                  }
               }
               else
               {
                  FOOT_WARN = " NOTE : You may amend the fee, but the course has NOT started";
               }
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
            if (ST_ATT == 19 && TEMP_REC[23] == 0)
            {
               /*  Do not prompt for instalments if the course is paid in full */
               ANS = "N";
            }
            else
            {
               PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
               PRINT(AT(ST_COL, ST_ROW));
               if (ST_DISPLAY == "V")
               {
                  /*  Display full fee as a default */
                  PRINT(OCONV(VALUE, "MD2"));
               }
               else
               {
                  PRINT(STR(".", ST_LENGTH));
               }
               PRINT(AT(ST_COL, ST_ROW));
               if (FIELD_NO == 12)
               {
                  if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3)))
                  {
                     MEMBER_PROGRAM = "";
                  }
               }
               else
               {
                  MEMBER_PROGRAM = "";
               }
               /*  Smart card may already be positioned in the reader */
               SMARTCARD_READ = FALSE;
               if (SMART_CARD && FIELD_NO == 12)
               {
                  L0065();
               }
               if (NOT(SMARTCARD_READ))
               {
                  if (MEMBER_PROGRAM != "")
                  {
                     CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
                  }
                  else
                  {
                     INPUT(out ANS, ST_LENGTH);
                  }
                  if (ANS == "" && VALUE == "" && FIELD_NO == 12 && SMART_CARD)
                  {
                     SMARTCARD_READ = FALSE;
                     if (SMART_CARD && FIELD_NO == 12)
                     {
                        L0065();
                        /*  Re-try card read in case it was presented 'late' */
                     }
                  }
               }
            }
            if (ST_DISPLAY == "V")
            {
               /*  Clear footer warnings */
               PRINT(AT(0, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
               PRINT(AT(2, 20) + SPACE(74));
               PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
               PRINT(AT(2, 21) + SPACE(74));
            }
            /*  DJA 1.5.02  Course balance was not displayed when the user hit */
            /*              <return> to default to a 0.00 payment */
            /*  DJA 18.3.03 */
            if (ANS == "" && VALUE == "" && FIELD_NO == PAYMENT_FIELD_NO)
            {
               if (FULL_PAYMENT_DEFAULT == "Y")
               {
                  ANS = OCONV(TEMP_REC[17], "MD2");
                  /*  Full fee */
               }
               else
               {
                  ANS = 0;
               }
            }
            // BEGIN CASE
            /*  DJA 7.4.00 */
            // CASE
            if (ANS == COMMON.ABANDON && EFT_SITE && MOP == MOP_TYPES[3])
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
            else if (ANS == GO_BACK)
            {
               if (ANS == GO_BACK && BONUS_REDEEM_REC != "")
               {
                  if ((FIELD_NO == INSTALMENTS_FIELD_NO && PREVENT_PP_AND_INSTALMENTS != "Y") || (FIELD_NO == RECEIPT_FIELD_NO && PREVENT_PP_AND_INSTALMENTS == "Y"))
                  {
                     nrf0 = 55;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                     ANS = "";
                  }
                  else
                  {
                     INTERACT = BACKUP;
                  }
               }
               else
               {
                  INTERACT = BACKUP;
               }
            }// CASE
            else if (ANS == COMMON.CLR && FIELD_NO == PAYMENT_FIELD_NO && PREVENT_ZERO_PAYMENTS == "Y")
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == COMMON.CLR && ST_MANDATORY == "")
            {
               VALUE = "";
               ANS = "";
               INTERACT = VALID_DATA;
            }// CASE
            else if (VALUE == "" && ANS == "" && MANUAL_RECEIPTS == "N" && FIELD_NO == RECEIPT_FIELD_NO)
            {
               ANS = "Y";
               VALUE = "Y";
               L1700();
               /*  Additional processing in the validation field */
               /*  Allow default values for Instalments & Receipt */
               /*  but still make sure the user can't SKIP past them */
            }// CASE
            else if (ANS == "" && FIELD_NO == INSTALMENTS_FIELD_NO && VALUE == "")
            {
               ANS = "N";
               VALUE = "N";
               L1600();
               /*  Process validation routine */
            }// CASE
            else if (ANS == "" && VALUE == "" && FIELD_NO == PAYMENT_FIELD_NO && PREVENT_ZERO_PAYMENTS == "Y")
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "")
            {
               nrf0 = 5;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               /*  Recalculate instalments if <return> is pressed after using backup to */
               /*  change the student and therefore the fee code */
            }// CASE
            else if (AMENDING == FALSE && FIELD_NO == 20 && ANS == "")
            {
               // BEGIN CASE
               /*  TEMP.REC(39) = List of instalment dates IF previously calculated */
               // CASE
               if (TEMP_REC[39] != "")
               {
                  INST_PLAN_TOTAL = TEMP_REC[23];
                  INST_FIRST_DUE = TEMP_REC[35];
                  INST_NUMBER = TEMP_REC[36];
                  INST_VALUE = TEMP_REC[37];
                  INST_FREQUENCY = TEMP_REC[38];
                  INST_DATES = TEMP_REC[39];
                  INST_AMOUNTS = TEMP_REC[40];
                  UNPAID_FEE = TEMP_REC[23];
                  RECALC = FALSE;
                  L0400();
                  FL749 = new FL749(ref STUDENT_ID, ref DETAILS_ID, ref STUDENT_REC, ref RECALC, ref DISPLAY_PLAN, ref UNPAID_FEE, ref INST_PLAN_TOTAL, ref INST_FIRST_DUE, ref INST_NUMBER, ref INST_VALUE, ref INST_FREQUENCY, ref INST_DATES, ref INST_AMOUNTS, ref INTERACT, ref REDISPLAY);
                  if (INTERACT != EXIT)
                  {
                     INTERACT = VALID_DATA;
                     L8900();
                     /*  Load temp.rec with instalment variables */
                     VALUE = TEMP_REC[36];
                  }
                  else
                  {
                     INTERACT = INVALID_DATA;
                     /*  Reprompt */
                  }
                  if (REDISPLAY)
                  {
                     L0100();
                     START_FIELD = 1;
                     END_FIELD = 22;
                     L6000();
                     REDISPLAY = "";
                  }
                  L8950();
                  /*  Display instalment status */
               }
               // END CASE
               INTERACT = VALID_DATA;
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
                  case 12: L1300(); break;
                  case 13: L1200(); break;
                  case 14: L1200(); break;
                  case 15: L1200(); break;
                  case 16: L1200(); break;
                  case 17: L1200(); break;
                  case 18: L1400(); break;
                  case 19: L1500(); break;
                  case 20: L1600(); break;
                  case 21: L1700(); break;
                  case 22: L1200(); break;
                  case 23: L1200(); break;
                  case 24: L1200(); break;
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
         /* ************************************* */
      }
      void L0065()
      {
         /*   Read smartcard                * */
         /* ************************************* */
         IFACE_TYPE = 1;
         SMART_MEMBER_NO = "";
         APACS_NO = "";
         SMART_DISPLAY_MODE = FWTERM_MODE;
         FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref SMART_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
         // BEGIN CASE
         // CASE
         if (SMARTCARD_INTERACT == NOT_PRESENT)
         {
            NULL();
         }// CASE
         else if (SMARTCARD_INTERACT == INVALID_DATA)
         {
            NULL();
         }// CASE
         else if (SMART_MEMBER_NO == "NONMEM")
         {
            /*  Use unrecognised APACS numbers as non-member student Ids */
            if (APACS_NO != "")
            {
               ANS = APACS_NO;
               SMARTCARD_READ = TRUE;
            }
         }// CASE
         else if (OTHERWISE)
         {
            /*  If an APACS number has been returned, now process the lookup */
            /*  to convert it to a membership number. If this lookup fails, */
            /*  then proceed to display an input prompt in the normal way */
            if (APACS_NO != "" && SMART_MEMBER_NO == "")
            {
               if (!READV(ref SMART_MEMBER_NO, FL_APACS_NUMBERS, APACS_NO, 1)) { SMART_MEMBER_NO = ""; }
            }
            if (SMART_MEMBER_NO != "")
            {
               ANS = SMART_MEMBER_NO;
               SMARTCARD_READ = TRUE;
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
         L0150();
         return;
         /* *************************************************** */
      }
      void L0150()
      {
         /*  Update basket count                          * */
         /* *************************************************** */
         if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
         BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
         BASKET_TOTAL = 0;
         for (COMMON.X = 1; COMMON.X <= BASKET_COUNT; COMMON.X += 1)
         {
            BASKET_TOTAL = BASKET_TOTAL + MULTIPAY_REC[4, COMMON.X];
         }
         if (PROG_MESS[30] != "")
         {
            BASKET_COUNT = BASKET_COUNT + 1;
            BASKET_TOTAL = BASKET_TOTAL + PROG_MESS[33];
         }
         if (BASKET_COUNT > 0)
         {
            PRINT(AT(43, 2) + ERR_MESS_BACK + ERR_MESS_FORE + "Items in basket: " + FORMAT(BASKET_COUNT, "R#2") + "  Total: " + FORMAT(OCONV(BASKET_TOTAL, "MD2"), "R#7"));
            PRINT(AT(0, 3) + NRM_VID);
         }
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
         /* ********************************************************** */
      }
      void L0400()
      {
         /*   Ask user whether they want to view the instalments * */
         /* ********************************************************** */
         INPUT_LINE = "     Do you wish to view the instalment plan? (Y/<return>) ";
         PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
         PRINT(AT(2, 21) + INPUT_LINE);
         INPUT(out REPLY, 2);
         PRINT(AT(2, 21) + SPACE(75));
         // BEGIN CASE
         // CASE
         if (REPLY == "Y")
         {
            DISPLAY_PLAN = TRUE;
         }// CASE
         else if (OTHERWISE)
         {
            DISPLAY_PLAN = FALSE;
         }
         // END CASE
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
         #region INCLUDE FL.PROCESSING FL715.VALIDATION

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
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref STATUS);
               if (STATUS == TRUE)
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
                        START_FIELD = 23;
                        END_FIELD = 24;
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
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref STATUS);
               if (STATUS == TRUE)
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
                              START_FIELD = 23;
                              END_FIELD = 24;
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
            START_FIELD = 23;
            END_FIELD = 24;
            L6000();
            FIELD_NO = 1;
            FIELD_DATA = DATA_FIELDS[FIELD_NO];
            L0200();
         }
         // END CASE
         return;
         /* ********************************************************* */
      }
      void L1050()
      {
         /*  Link to waiting lists                              * */
         /* ********************************************************* */
         INTERACT = INVALID_DATA;
         OFFER_DECLINED = FALSE;
         do
         {
            if (!(INTERACT == INVALID_DATA)) break;
            PRINT(AT(2, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            if (DISPLAY_MODE == 3)
            {
               INPUT_LINE = "  No concession group vacancies. Add to waiting list? ";
            }
            else
            {
               INPUT_LINE = "  No vacancies.  Do you wish to put them on the waiting list? ";
            }
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS2, 3);
            if (LEN(ANS2) > 2) { PRINT(AT(-9) + " "); ANS2 = ANS2.Substring(1, 2); }
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS2 == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (ANS2 == "Y")
            {
               ACTIVITY_CODE = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
               CONCESSION = TICKET_CONCESS;
               /*  Check whether the waiting list is full */
               if (!READV(ref MAX_PLACES, FL_COURSE_PARAMS, "COURSE.PARAMS", 10)) { MAX_PLACES = 999999; }
               MAX_PLACES = MAX_PLACES[1, 1];
               if (MAX_PLACES == "") { MAX_PLACES = 999999; }
               if (!READV(ref MASTER_LIST, FL_WAIT_MASTER, ACTIVITY_CODE, 1)) { MASTER_LIST = ""; }
               PLACES_TAKEN = DCOUNT(MASTER_LIST, VM);
               if (PLACES_TAKEN >= MAX_PLACES)
               {
                  nrf0 = 43;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  WAIT_DISPLAY_MODE = 3;
                  FL734 = new FL734(ref ACTIVITY_CODE, ref WAIT_DISPLAY_MODE, ref PASSED_STUDENT_ID, ref STUDENT_REC, ref CONCESSION, ref INTERACT);
               }
               L0100();
               START_FIELD = 1;
               END_FIELD = 11;
               L6000();
               START_FIELD = 23;
               END_FIELD = 24;
               L6000();
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS2 == "N")
            {
               INTERACT = VALID_DATA;
               OFFER_DECLINED = TRUE;
            }// CASE
            else if (OTHERWISE)
            {
               NULL();
            }
            // END CASE
         } while (true);
         /*  If this routine has been called because of a concession */
         /*  group maximum then the user will be given the opportunity */
         /*  to select a different concession. In these circumstances */
         /*  do not reset the student/member details, as they may yet */
         /*  be successfully enrolled */
         if (OFFER_DECLINED && DISPLAY_MODE == 3)
         {
            NULL();
         }
         else
         {
            /*  Reprompt for key field, whatever the response was */
            MAT(ref STUDENT_REC, "");
            INTERACT = INVALID_DATA;
            ANS = "";
            VALUE = "";
         }
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
         MAT(ref STUDENT_REC, "");
         if (ANS == COMMON.HELP)
         {
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
            REDISPLAY = "";
         }
         ANS = OCONV(ANS, "MCU");
         if (!READV(ref WAIT_LIST, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_LIST = ""; }
         WAIT_LIST_COUNT = DCOUNT(WAIT_LIST, VM);
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.ABANDON || INTERACT == EXIT)
         {
            INTERACT = INVALID_DATA;
            ANS = "";
         }// CASE
         else if (ANS == "P")
         {
            /*  DJA 26.6.03 'P'rice list */
            TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
            TICKET_TYPE = "C";
            /*  DJA 26.1.05 */
            if (FEE_TODAY == "Y")
            {
               SALE_DATE = TODAYS_DATE;
            }
            else
            {
               SALE_DATE = PROG_MESS[3];
            }
            SALE_TIME = TIME();
            PERIOD = "";
            FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
            HELP_TEXT = "";
            for (N = 1; N <= DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM); N += 1)
            {
               HELP_TEXT[1, N] = SPACE(2) + FORMAT(TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, N], "L#8") + FORMAT(OCONV(TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, N], "MD2"), "R#6");
            }
            FL_LIST = new FL_LIST(ref HELP_TEXT);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1 && ANS == "N")
         {
            PASSED_STUDENT_ID = "";
            L1320();
            /*  No vacancies */
            /* !*IF ANS MATCHES '16N' THEN */
            /*  Unidentified smartcard - abandon, otherwise user will be stuck */
            /*  in a loop, when the smartcard is automatically re-read */
            /* !* INTERACT = EXIT */
            /* !* PROG.MESS<1> = ABANDON */
            /* !*END */
            /* !*CRT "ANS=":ANS:"  INTERACT=":INTERACT:;INPUT FLEX,2: */
         }// CASE
         else if (ANS == "N")
         {
            if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
            /*  Create a new student via the separate maintenance screen */
            MAT(ref STUDENT_REC, "");
            NEW_STUDENT = TRUE;
            /*  The current course code is secured in 'MAIN.KEY' at this point. */
            /*  Prog.mess<2> is used by Student Maintenance to hold/pass the student */
            /*  Id.  This program then stores the Student Id in a separate variable */
            /*  and puts the course code back into prog.mess<2> */
            PROG_MESS[2] = "N";
            FL710 = new FL710(ref STUDENT_REC, ref NEW_STUDENT);
            STUDENT_ID = PROG_MESS[2];
            PROG_MESS[2] = MAIN_KEY;
            // BEGIN CASE
            // CASE
            if (PROG_MESS[1] == COMMON.ABANDON)
            {
               /*  User aborted creation of student */
               PROG_MESS[1] = 1;
               /*  page no */
               INTERACT = INVALID_DATA;
            }// CASE
            else if (OTHERWISE)
            {
               ANS = STUDENT_ID;
               L8500();
               /*  Update temp.rec with student data */
               INTERACT = VALID_DATA;
            }
            // END CASE
            /*  Refresh screen */
            L0100();
            START_FIELD = 1;
            END_FIELD = 17;
            L6000();
            /*  Display selected field data */
            START_FIELD = 23;
            END_FIELD = 24;
            L6000();
            /*  Now establish the concession rate for this NEW student */
            if (INTERACT != INVALID_DATA)
            {
               AMENDING = FALSE;
               MEMBER_NUMBER = "";
               L5000();
            }
         }// CASE
         else if (ANS == "W")
         {
            /*  Select a student from the waiting list */
            CREATION_ALLOWED = FALSE;
            if (MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE]))
            {
               STUDENT_LIST = WAIT_MAST_REC[WAIT_MAST_IDS];
               STATUS_LIST = WAIT_MAST_REC[WAIT_MAST_STATUS];
               ACTIVITY = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
               FL735 = new FL735(ref ACTIVITY, ref STUDENT_LIST, ref STATUS_LIST, ref NEW_STUDENT, ref CREATION_ALLOWED, ref STUDENT_ID, ref INTERACT, ref REDISPLAY);
               L0100();
               START_FIELD = 1;
               END_FIELD = 11;
               L6000();
               /*  Display COURSE data */
               START_FIELD = 23;
               END_FIELD = 24;
               L6000();
               REDISPLAY = "";
               // BEGIN CASE
               // CASE
               if (INTERACT == EXIT)
               {
                  /*  User aborted waiting list box */
                  PROG_MESS[1] = 1;
                  /*  page no */
                  INTERACT = INVALID_DATA;
                  RELEASE();
               }// CASE
               else if (OTHERWISE)
               {
                  ANS = STUDENT_ID;
                  INTERACT = VALID_DATA;
               }
               // END CASE
               if (INTERACT == VALID_DATA)
               {
                  if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1)
                  {
                     INTERACT = INVALID_DATA;
                     nrf0 = 29;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }
                  else
                  {
                     WAIT_LIST_ENROLMENT = TRUE;
                     L1325();
                     /*  Locate student details and enrol them */
                     if (INTERACT == VALID_DATA) { WAITING_LIST_ENROLMENT = TRUE; }
                  }
               }
            }
            else
            {
               /*  Tell user there is no waiting list for this activity */
               nrf0 = 25;
               nrf1 = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
         }// CASE
         else if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1 && (ANS == NAME_INDEX_REQUEST || ANS == SOUND_INDEX_REQUEST || ANS == ADDRESS_INDEX_REQUEST))
         {
            if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
            PASSED_STUDENT_ID = "";
            L1320();
            /*  No Vacancies */
            /* !*CRT "AAA":;INPUT FLEX,2: */
         }// CASE
         else if (ANS == NAME_INDEX_REQUEST || ANS == SOUND_INDEX_REQUEST || ANS == ADDRESS_INDEX_REQUEST)
         {
            if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
            SEARCH_ROUTE = ANS;
            MEMBER_NUMBER = "";
            FL000_20 = new FL000_20(ref MEMBER_NUMBER, ref SEARCH_ROUTE);
            if (MEMBER_NUMBER == "")
            {
               INTERACT = INVALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER_NUMBER))
               {
                  AMENDING = FALSE;
                  STUDENT_IS_MEMBER = TRUE;
                  INTERACT = VALID_DATA;
                  ANS = MEMBER_NUMBER;
                  /*  DJA 6.11.00  Don't call 1350 if member is already a student */
                  /*               or course history will be blown away */
                  if (MATREADU(ref STUDENT_REC, FL_STUDENTS, MEMBER_NUMBER))
                  {
                     L1325();
                     /*  Will read student rec again - not ideal */
                  }
                  else
                  {
                     L2000();
                     /*  Check membership status */
                     if (INTERACT != EXIT)
                     {
                        L1350();
                        /*  Turn members details into a student record */
                        L1324();
                        L5000();
                     }
                  }
                  if (INTERACT == EXIT)
                  {
                     PROG_MESS[1] = 1;
                     /*  page no */
                     INTERACT = INVALID_DATA;
                     RELEASE();
                     VALUE = "";
                     ANS = "";
                  }
                  else
                  {
                     /*  DJA 28.4.00 */
                     if (DISPLAY_PHOTO)
                     {
                        nrf0 = 64;
                        nrf1 = 0;
                        FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
                     }
                     STUDENT_ID = MEMBER_NUMBER;
                  }
               }
            }
            PRINT(AT(0, 23) + NRM_VID + SPACE(80));
         }// CASE
         else if (OTHERWISE)
         {
            if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
            WAIT_LIST_ENROLMENT = FALSE;
            L1325();
         }
         // END CASE
         return;
      }
      void L1324()
      {
         /*  Display membership type(s) */
         if (INTERACT != EXIT && INTERACT != INVALID_DATA && STUDENT_IS_MEMBER && SHOW_MEMBERSHIPS == "Y")
         {
            N = 1;
            MTYPES = 0;
            do
            {
               if (N > DCOUNT(MEMBERS_REC[MEMBER_TYPE], VM) || MTYPES >= 3) break;
               MTYPES = MTYPES + 1;
               if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N] < COURSE_DATE && MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N] != "")
               {
                  PRINT(AT(20, 11 + MTYPES) + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, N], "L#7") + REV_VID + " " + FORMAT(OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N], "D2/"), "R#8") + NRM_VID);
               }
               else
               {
                  PRINT(AT(20, 11 + MTYPES) + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, N], "L#8") + FORMAT(OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N], "D2/"), "R#8"));
               }
               N = N + 1;
            } while (true);
         }
         return;
         /* ********************************************************************* */
      }
      void L1325()
      {
         /*   Read in student info and enrol them on the course             * */
         /* ********************************************************************* */
         /*  See if student already exists */
         CROSS_REFERENCED = FALSE;
         if (SMART_CARD)
         {
            if (READV(ref TEST_MEMBER_NO, FL_APACS_NUMBERS, ANS, 1))
            {
               CROSS_REFERENCED = TRUE;
               APACS_NO = ANS;
               ANS = TEST_MEMBER_NO;
            }
         }
         PADDED_ANS = ANS;
         if (NOT(CROSS_REFERENCED))
         {
            /*  Treat unrecognised APACS numbers as non-member students */
            if (SMART_CARD && MATCH(ANS, "16N"))
            {
               NULL();
               /*  No action required */
            }
            else
            {
               /*  DJA 19.04.06 Don't pass any alpha-prefixed numbers to FL000.40 */
               /*               as it is too crude, and strips leading alphas */
               /*               at fixed number length sites, causing waiting list */
               /*               students to be converted to (clashing) membership */
               /*               numbers. */
               if (NOT(MATCH(ANS.Substring(1, 1), "1A")))
               {
                  FL000_40 = new FL000_40(ref PADDED_ANS);
               }
            }
         }
         STUDENT_IS_MEMBER = FALSE;
         STUDENT_EXISTS = FALSE;
         if (MATREADU(ref STUDENT_REC, FL_STUDENTS, ANS))
         {
            STUDENT_EXISTS = TRUE;
         }
         else
         {
            if (MATREADU(ref STUDENT_REC, FL_STUDENTS, PADDED_ANS))
            {
               STUDENT_EXISTS = TRUE;
               ANS = PADDED_ANS;
               VALUE = ANS;
            }
         }
         if (STUDENT_EXISTS)
         {
            /*  Validate student isn't already enrolled on this course. */
            if (LOCATE(ANS, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref STUDENT_POS, "AL"))
            {
               STUDENT_ID = ANS;
               ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
               if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
               L8500();
               /*  Update temp.rec with student data */
               START_FIELD = 12;
               END_FIELD = 17;
               L6000();
               /*  Display selected field data */
               START_FIELD = 23;
               END_FIELD = 24;
               L6000();
               INTERACT = INVALID_DATA;
               STUDENT_ID = ANS;
               do
               {
                  if (!(INTERACT == INVALID_DATA)) break;
                  PRINT(AT(78, 23) + NRM_VID);
                  PRINT(AT(0, 23) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 23) + SPACE(76));
                  PRINT(AT(2, 23) + " This student is already enrolled.  Remove them from the course? ");
                  INPUT(out REPLY, 2);
                  PRINT(AT(2, 23) + SPACE(74));
                  // BEGIN CASE
                  // CASE
                  if (REPLY == COMMON.ABANDON)
                  {
                     INTERACT = EXIT;
                  }// CASE
                  else if (REPLY == "N")
                  {
                     INTERACT = FINISH;
                  }// CASE
                  else if (REPLY == "Y" && BASKET_COUNT > 0)
                  {
                     INTERACT = INVALID_DATA;
                     nrf0 = 85;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }// CASE
                  else if (REPLY == "Y")
                  {
                     INTERACT = VALID_DATA;
                     L4000();
                     /*  Disenrolment updates */
                  }// CASE
                  else if (OTHERWISE)
                  {
                     NULL();
                  }
                  // END CASE
               } while (true);
               PROG_MESS[1] = COMMON.ABANDON;
               INTERACT = EXIT;
               /*  NB: If reselection of enrolled students is permitted in the future */
               /*      for entry of additional payments, then temp.rec must cater for */
               /*      more than two multivalues (currently Orig.Debit + 1st Payment) */
            }
            else
            {
               if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1)
               {
                  /*  DJA 28.11.01 */
                  PASSED_STUDENT_ID = ANS;
                  L1320();
                  /*  No vacancies */
                  /* !*CRT "BBB":"  PASSED.STUDENT.ID=":PASSED.STUDENT.ID:;INPUT FLEX,2:;IF FLEX = "." THEN STOP */
                  if (MATCH(PASSED_STUDENT_ID, "16N"))
                  {
                     /*  Unidentified smartcard - abandon, otherwise user will be stuck */
                     /*  in a loop, when the smartcard is automatically re-read */
                     INTERACT = EXIT;
                     PROG_MESS[1] = COMMON.ABANDON;
                  }
               }
               else
               {
                  /*  Existing student, but new enrolment as far as this course is concerned */
                  /*  If student is also a member the member no. may help ascertain the */
                  /*  concession. */
                  if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ANS))
                  {
                     MEMBER_NUMBER = ANS;
                     L2000();
                     /*  Check membership status */
                  }
                  else
                  {
                     MEMBER_NUMBER = "";
                  }
                  /* !!CRT "  ANS=":ANS:"  MEMBER.NUMBER=":MEMBER.NUMBER:"  INTERACT=":INTERACT:;INPUT FLEX,2: */
                  if (INTERACT == EXIT)
                  {
                     PROG_MESS[1] = 1;
                     /*  page no */
                     INTERACT = INVALID_DATA;
                     RELEASE();
                     VALUE = "";
                     ANS = "";
                  }
                  else
                  {
                     STUDENT_ID = ANS;
                     INTERACT = VALID_DATA;
                     L8500();
                     /*  Update temp rec with student info. */
                     START_FIELD = 12;
                     END_FIELD = 17;
                     L6000();
                     START_FIELD = 23;
                     END_FIELD = 24;
                     L6000();
                     /*  DJA 28.4.00 */
                     if (DISPLAY_PHOTO)
                     {
                        if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], MEMBER_NUMBER))
                        {
                           nrf0 = 64;
                           nrf1 = 0;
                           FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
                        }
                     }
                     L1324();
                     L5000();
                     /*  Get concession info update temp.rec */
                     AMENDING = FALSE;
                  }
               }
            }
         }
         else
         {
            FOUND_ON_MEMBERS = FALSE;
            if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ANS))
            {
               FOUND_ON_MEMBERS = TRUE;
            }
            else
            {
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], PADDED_ANS))
               {
                  ANS = PADDED_ANS;
                  FOUND_ON_MEMBERS = TRUE;
               }
            }
            if (FOUND_ON_MEMBERS)
            {
               if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1)
               {
                  /* !!           ANS = PADDED.ANS */
                  PASSED_STUDENT_ID = ANS;
                  L1320();
                  /* !*CRT "CCC":;INPUT FLEX,2: */
               }
               else
               {
                  MEMBER_NUMBER = ANS;
                  STUDENT_IS_MEMBER = TRUE;
                  L1350();
                  /*  Create a student record from a member record */
                  L2000();
                  /*  Check membership status */
                  if (INTERACT == EXIT)
                  {
                     PROG_MESS[1] = 1;
                     /*  page no */
                     INTERACT = INVALID_DATA;
                     RELEASE();
                     VALUE = "";
                     ANS = "";
                  }
                  else
                  {
                     INTERACT = VALID_DATA;
                     L1324();
                     L5000();
                     /*  Get concess. data and update temp.rec */
                     AMENDING = FALSE;
                     STUDENT_ID = ANS;
                  }
               }
            }
            else
            {
               if (WAIT_LIST_ENROLMENT == TRUE)
               {
                  /*  Retrieve details from the waiting list */
                  if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, ANS))
                  {
                     MAT(ref STUDENT_REC, "");
                     NEW_STUDENT = TRUE;
                     /*  DJA 31.07.00. If the waiting list student is a member, */
                     /*                then most of the following fields are */
                     /*                null on FL.WAIT.STUDENTS anyway */
                     /*  DJA 2.5.01 */
                     if (GET_CARD_NO != "")
                     {
                        nrf0 = "N";
                        CallAt_GET_CARD_NO = new CallAt_GET_CARD_NO(ref GET_CARD_NO, ref nrf0, ref NEW_STUDENT_NO);
                        if (NEW_STUDENT_NO == "")
                        {
                           INTERACT = INVALID_DATA;
                        }
                        else
                        {
                           PROG_MESS[16] = ANS;
                           /*  Pass waiting list student id to the controller */
                           ANS = NEW_STUDENT_NO;
                           STUDENT_ID = ANS;
                        }
                     }
                     if (INTERACT != INVALID_DATA)
                     {
                        STUDENT_REC[STUDENT_TITLE] = WAIT_STUDENT_REC[WAIT_STUD_TITLE];
                        STUDENT_REC[STUDENT_FORENAME] = WAIT_STUDENT_REC[WAIT_STUD_FORENAME];
                        STUDENT_REC[STUDENT_SURNAME] = WAIT_STUDENT_REC[WAIT_STUD_SURNAME];
                        STUDENT_REC[STUDENT_ADDRESS1] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1];
                        STUDENT_REC[STUDENT_ADDRESS2] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2];
                        STUDENT_REC[STUDENT_ADDRESS3] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3];
                        STUDENT_REC[STUDENT_ADDRESS4] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4];
                        STUDENT_REC[STUDENT_POST_CODE] = WAIT_STUDENT_REC[WAIT_STUD_POST_CODE];
                        STUDENT_REC[STUDENT_HOME_TEL] = WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME];
                        STUDENT_REC[STUDENT_WORK_TEL] = WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK];
                        STUDENT_REC[STUDENT_COMMENT1] = WAIT_STUDENT_REC[WAIT_STUD_COMMENT];
                        STUDENT_REC[STUDENT_DOB] = WAIT_STUDENT_REC[WAIT_STUD_DOB];
                        STUDENT_REC[STUDENT_MEDICAL1] = WAIT_STUDENT_REC[WAIT_STUD_MEDICAL];
                        L8500();
                        /*  Update temp.rec with student data */
                        START_FIELD = 12;
                        END_FIELD = 17;
                        L6000();
                        /*  Display selected field data */
                        START_FIELD = 23;
                        END_FIELD = 24;
                        L6000();
                        AMENDING = FALSE;
                        MEMBER_NUMBER = "";
                        L5000();
                        /*  Establish concession rate for the new student */
                     }
                  }
                  else
                  {
                     nrf0 = 26;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }
               }
               else
               {
                  /* !*READ TEST.REC FROM FL.EXPIRED.MEMBERSHIPS, PADDED.ANS THEN */
                  /* !* CALL FL006(PROGRAM,101,INIT) */
                  /* !*END ELSE */
                  /*  Unrecognised APACS numbers will land here. Treat them as */
                  /*  a student Id for a new non-member student. Go to Student */
                  /*  Maintenance to gather personal details */
                  if (MATCH(ANS, "16N"))
                  {
                     // BEGIN CASE
                     // CASE
                     if (COURSE_DET_REC[COURSE_DET_VACANCIES] < 1)
                     {
                        PASSED_STUDENT_ID = ANS;
                        L1320();
                        /* !*CRT "DDD":;INPUT FLEX,2: */
                        INTERACT = EXIT;
                        /*  Jump right out or auto-smartcard read will loop */
                        PROG_MESS[1] = COMMON.ABANDON;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        if (WAIT_LIST_COUNT > 0) { nrf0 = 70; FL006 = new FL006(ref PROGRAM, ref nrf0, ref WAIT_LIST_COUNT); }
                        MAT(ref STUDENT_REC, "");
                        NEW_STUDENT = TRUE;
                        STORED_PROG_MESS = PROG_MESS[2];
                        PROG_MESS[2] = ANS;
                        FL710 = new FL710(ref STUDENT_REC, ref NEW_STUDENT);
                        STUDENT_ID = PROG_MESS[2];
                        /*  May have changed if duplicate details detected */
                        PROG_MESS[2] = STORED_PROG_MESS;
                        ANS = STUDENT_ID;
                        /*  Now establish the concession rate for this NEW student */
                        if (PROG_MESS[1] == COMMON.ABANDON)
                        {
                           /*  Full abandon, otherwise smartcard number will be re-read */
                           /*  and user will land straight back in Student Maintenance, */
                           /*  which they've just tried to abandon */
                           INTERACT = EXIT;
                        }
                        else
                        {
                           INTERACT = VALID_DATA;
                           L8500();
                           /*  Refresh screen */
                           L0100();
                           START_FIELD = 1;
                           END_FIELD = 17;
                           L6000();
                           /*  Display selected field data */
                           START_FIELD = 23;
                           END_FIELD = 24;
                           L6000();
                           AMENDING = FALSE;
                           MEMBER_NUMBER = "";
                           L1324();
                           L5000();
                        }
                     }
                     // END CASE
                  }
                  else
                  {
                     nrf0 = 1;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }
               }
            }
         }
         return;
         /* ******************************************************** */
      }
      void L1320()
      {
         /*   No vacancies - give option of adding to wait.list* */
         /* ******************************************************** */
         DISPLAY_MODE = 2;
         L1050();
         return;
         /* ******************************************************* */
      }
      void L1350()
      {
         /*   CREATE A STUDENT RECORD FROM A MEMBERS ONE      * */
         /* ******************************************************* */
         MAT(ref STUDENT_REC, "");
         STUDENT_ID = MEMBER_NUMBER;
         L8500();
         /*  Update temp.rec with student data */
         START_FIELD = 12;
         END_FIELD = 17;
         L6000();
         /*  Display selected field data */
         START_FIELD = 23;
         END_FIELD = 24;
         L6000();
         /*  DJA 17.1.01 */
         if (DISPLAY_PHOTO)
         {
            nrf0 = 64;
            nrf1 = 0;
            FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
         }
         return;
      }
      void L1400()
      {
         /*  COURSE FEE */
         CONV_ANS = ICONV(ANS, "MD2");
         // BEGIN CASE
         // CASE
         if (CONV_ANS == "" && ANS != "" || NOT(NUM(CONV_ANS)))
         {
            INTERACT = INVALID_DATA;
            nrf0 = 31;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (OTHERWISE)
         {
            /*  DJA 12.2.03 */
            /*  Warn if user overrides course fee having done a balance transfer */
            if (BALANCE_TRANSFER == TRUE)
            {
               nrf0 = 96;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            INTERACT = VALID_DATA;
            /*  Overwrite ticket details generated in 5000* */
            TEMP_REC[32] = TEMP_REC[17];
            /*  Store full price */
            TEMP_REC[33] = U_INITS;
            /*  Store user who overrode the course fee */
            TEMP_REC[17] = CONV_ANS;
            if (TEMP_REC[18] + 0 != 0)
            {
               /*  Amending or 'backed up' to course fee. Adjust balance */
               /*  taking the existing payment into account */
               TEMP_REC[23] = CONV_ANS - TEMP_REC[18];
               TEMP_REC[29][1, 1] = CONV_ANS;
               /*  Don't overwrite payment */
               START_FIELD = 22;
               END_FIELD = 22;
               L6000();
            }
            else
            {
               TEMP_REC[23] = CONV_ANS;
               TEMP_REC[29] = CONV_ANS;
            }
         }
         // END CASE
         return;
      }
      void L1500()
      {
         /*   PAYMENT */
         CONV_ANS = ICONV(ANS, ST_CONVERSION);
         // BEGIN CASE
         // CASE
         if (NOT(NUM(ANS)) || (ANS != "" && CONV_ANS == ""))
         {
            nrf0 = 8;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS < 0)
         {
            nrf0 = 8;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (CONV_ANS > TEMP_REC[17] && CONV_ANS > 0)
         {
            /*  Payment exceeds course fee */
            nrf0 = 11;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
            /*  DJA 4.8.00 */
         }// CASE
         else if (PREVENT_PP_AND_INSTALMENTS == "Y" && CONV_ANS > 0 && CONV_ANS < TEMP_REC[17])
         {
            nrf0 = 47;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (PREVENT_ZERO_PAYMENTS == "Y" && CONV_ANS == 0 && TEMP_REC[17] > 0)
         {
            nrf0 = 48;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = VALID_DATA;
            /*  Establish method of payment, generate transaction & update temp.rec */
         }
         // END CASE
         /*  Adjust balance, allowing for the fact that they may have 'backed-up' */
         /*  to this field */
         if (INTERACT == VALID_DATA)
         {
            /*  If user is amending, the next two lines will correct the FL.TICKETS */
            /*  record, otherwise 1700* will re-assign the whole record anyway */
            /*  The amount in TEMP.REC is (re-)assigned as per 8800* to */
            /*  ensure payment amendments are updated correctly */
            TICKET_REC[TICK_TOTAL] = CONV_ANS;
            TICKET_REC[TICK_UNIT_PRICE] = CONV_ANS;
            /*  If amending the amount having already updated the multipay basket */
            /*  then amend the basket entry */
            if (PROG_MESS[30] != "")
            {
               PROG_MESS[33] = CONV_ANS;
               L0150();
            }
            /*  Redeem bonus points */
            if (CONV_ANS > 0 && STUDENT_IS_MEMBER && CURRENT_PROMOTIONS != "")
            {
               BONUS_REDEEM_REC = "";
               nrf0 = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
               nrf1 = "CO";
               nrf2 = 1;
               CallAt_BONUS_REDEEM_PROG = new CallAt_BONUS_REDEEM_PROG(ref BONUS_REDEEM_PROG, ref STUDENT_ID, ref nrf0, ref nrf1, ref CONV_ANS, ref nrf2, ref BONUS_REDEEM_REC, ref CURRENT_PROMOTIONS, ref TOTAL_REDEMPTION, ref TOTAL_POINTS, ref PROMOTION);
               if (TOTAL_REDEMPTION > 0)
               {
                  NEW_PRICE = TICKET_PRICE - TOTAL_REDEMPTION;
                  TEMP_REC[17] = NEW_PRICE;
                  TEMP_REC[23] = NEW_PRICE;
                  /*  Revised again below */
                  TEMP_REC[29] = NEW_PRICE;
                  TEMP_REC[41] = TOTAL_REDEMPTION;
                  TEMP_REC[42] = TOTAL_POINTS;
                  /*  Adjust payment amount */
                  CONV_ANS = CONV_ANS - TOTAL_REDEMPTION;
                  ANS = OCONV(CONV_ANS, "MD2");
                  TICKET_REC[TICK_TOTAL] = CONV_ANS;
                  TICKET_REC[TICK_UNIT_PRICE] = CONV_ANS;
                  START_FIELD = 18;
                  END_FIELD = 19;
                  L6000();
               }
            }
            TEMP_REC[29][1, 2] = -CONV_ANS;
            TEMP_REC[23] = TEMP_REC[17] - CONV_ANS;
            if (AMENDING && TEMP_REC[39] != "")
            {
               /*  An instalment plan exists if temp.rec(39) contains date(s) */
               INST_PLAN_TOTAL = TEMP_REC[23];
               INST_FIRST_DUE = TEMP_REC[35];
               INST_NUMBER = TEMP_REC[36];
               INST_VALUE = "";
               INST_FREQUENCY = TEMP_REC[38];
               INST_DATES = "";
               INST_AMOUNTS = "";
               RECALC = TRUE;
               UNPAID_FEE = TEMP_REC[23];
               L0400();
               FL749 = new FL749(ref STUDENT_ID, ref DETAILS_ID, ref STUDENT_REC, ref RECALC, ref DISPLAY_PLAN, ref UNPAID_FEE, ref INST_PLAN_TOTAL, ref INST_FIRST_DUE, ref INST_NUMBER, ref INST_VALUE, ref INST_FREQUENCY, ref INST_DATES, ref INST_AMOUNTS, ref INTERACT, ref REDISPLAY);
               if (INTERACT != EXIT)
               {
                  INTERACT = VALID_DATA;
                  L8900();
                  /*  Load temp.rec with instalment variables */
               }
               else
               {
                  INTERACT = INVALID_DATA;
                  /*  Reprompt for this field */
               }
               if (REDISPLAY)
               {
                  L0100();
                  START_FIELD = 1;
                  END_FIELD = 22;
                  L6000();
                  REDISPLAY = "";
               }
               L8950();
               /*  Display instalment status */
            }
            /*  Redisplay balance */
            if (INTERACT == VALID_DATA)
            {
               START_FIELD = 22;
               END_FIELD = 22;
               L6000();
            }
         }
         return;
      }
      void L1600()
      {
         /*  INSTALMENTS */
         NO_WEEKS = "";
         if (ANS == "0") { ANS = "N"; }
         // BEGIN CASE
         // CASE
         if (ANS == "N")
         {
            INTERACT = VALID_DATA;
            for (N = 34; N <= 39; N += 1)
            {
               TEMP_REC[N] = "";
            }
            PRINT(AT(24, 17) + NRM_VID + SPACE(53));
         }// CASE
         else if (ANS == "Y" || MATCH(ANS, "0N"))
         {
            INTERACT = VALID_DATA;
            COURSE_DATE = PROG_MESS[3];
            if (TODAYS_DATE > COURSE_DATE)
            {
               DAY_COURSE_STARTS = MOD(COURSE_DATE, 7);
               DAY_PLAN_STARTS = MOD(TODAYS_DATE, 7);
               OFFSET = 0;
               do
               {
                  if (DAY_COURSE_STARTS == DAY_PLAN_STARTS) break;
                  OFFSET = OFFSET + 1;
                  DAY_PLAN_STARTS = DAY_PLAN_STARTS + 1;
                  if (DAY_PLAN_STARTS > 6) { DAY_PLAN_STARTS = 0; }
               } while (true);
               INST_FIRST_DUE = TODAYS_DATE + OFFSET;
            }
            else
            {
               INST_FIRST_DUE = COURSE_DATE;
            }
            // BEGIN CASE
            // CASE
            if (MATCH(ANS, "0N"))
            {
               if (ANS > 42)
               {
                  ANS = 42;
                  nrf0 = 36;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               NO_WEEKS = ANS;
            }// CASE
            else if (OTHERWISE)
            {
               NO_WEEKS = INT(((COURSE_DET_REC[COURSE_DET_END] - INST_FIRST_DUE) / 7)) + 1;
            }
            // END CASE
            INST_PLAN_TOTAL = TEMP_REC[23];
            INST_NUMBER = NO_WEEKS;
            INST_VALUE = "";
            INST_FREQUENCY = "W";
            INST_DATES = "";
            INST_AMOUNTS = "";
            RECALC = TRUE;
            UNPAID_FEE = TEMP_REC[23];
            L0400();
            FL749 = new FL749(ref STUDENT_ID, ref DETAILS_ID, ref STUDENT_REC, ref RECALC, ref DISPLAY_PLAN, ref UNPAID_FEE, ref INST_PLAN_TOTAL, ref INST_FIRST_DUE, ref INST_NUMBER, ref INST_VALUE, ref INST_FREQUENCY, ref INST_DATES, ref INST_AMOUNTS, ref INTERACT, ref REDISPLAY);
            if (REDISPLAY)
            {
               L0100();
               START_FIELD = 1;
               END_FIELD = 19;
               L6000();
               if (AMENDING)
               {
                  START_FIELD = 21;
               }
               else
               {
                  START_FIELD = 22;
               }
               END_FIELD = 22;
               L6000();
               REDISPLAY = "";
            }
            if (INTERACT != EXIT)
            {
               L8900();
               /*  Load temp.rec with instalment variables */
               INTERACT = VALID_DATA;
               ANS = INST_NUMBER;
            }
            else
            {
               INTERACT = INVALID_DATA;
               /*  Reprompt */
            }
            L8950();
            /*  Display instalment status */
         }// CASE
         else if (OTHERWISE)
         {
            nrf0 = 9;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         // END CASE
         return;
      }
      void L1700()
      {
         /*  RECEIPT */
         /*  If no payment amount, no need for a receipt */
         RECEIPT_REQUIRED = TRUE;
         RECEIPT_NO = "";
         // BEGIN CASE
         // CASE
         if (ANS == "Y")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (TEMP_REC[18] > 0 && ANS == "N")
         {
            INTERACT = INVALID_DATA;
            nrf0 = 27;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (ANS == "N")
         {
            INTERACT = VALID_DATA;
            RECEIPT_REQUIRED = FALSE;
         }// CASE
         else if (MANUAL_RECEIPTS == "Y")
         {
            /*  Entering 'existing' receipt nos. is not valid if no amount has been */
            /*  entered */
            if (TEMP_REC[18] == 0)
            {
               INTERACT = INVALID_DATA;
               nrf0 = 28;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            else
            {
               INTERACT = VALID_DATA;
               RECEIPT_REQUIRED = FALSE;
               RECEIPT_NO = ANS;
            }
         }// CASE
         else if (OTHERWISE)
         {
            nrf0 = 37;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         // END CASE
         /*  Last field, therefore carry out post-processing.  It is not possible to */
         /*  do this earlier in case the user 'backs-up' and changes student or */
         /*  payment fields */
         if (INTERACT == VALID_DATA)
         {
            /*  Downdate number of vacancies */
            if (AMENDING == FALSE)
            {
               TEMP_REC[3] = TEMP_REC[3] - 1;
            }
            START_FIELD = 4;
            END_FIELD = 4;
            L6000();
            /*  Dealing with payment and receipt if necessary */
            MAT(ref TICKET_REC, "");
            /*  Initialises TICK.MOP automatically */
            TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
            TICKET_REC[TICK_UNIT] = 1;
            TICKET_REC[TICK_UNIT_PRICE] = TEMP_REC[18];
            TICKET_REC[TICK_DATE] = TODAYS_DATE;
            TICKET_REC[TICK_TIME] = TIME();
            TICKET_REC[TICK_TOTAL] = TEMP_REC[18] + 0;
            TICKET_REC[TICK_CLERK] = U_INITS;
            TICKET_REC[TICK_TILL] = TILL_NUMBER;
            TICKET_REC[TICK_CONCESS] = TEMP_REC[24];
            /*  DJA 12.8.02 */
            /* !*     IF COURSE.MSTR.CENTRE # CENTRE THEN */
            /* !*        TICK.HOME.CENTRE = COURSE.MSTR.CENTRE */
            /* !*     END */
            TICKET_REC[TICK_HOME_CENTRE] = COMMON.CENTRE;
            /*  DJA 26.10.00 */
            if (STUDENT_IS_MEMBER)
            {
               TICKET_REC[TICK_MEMBER] = MEMBER_NUMBER;
               TICKET_REC[TICK_APACS_NO] = MEMBERS_REC[MEMBER_APACS_NO];
            }
            TICKET_REC[TICK_STUDENT_ID] = STUDENT_ID;
            TICKET_REC[TICK_COURSE_DETAILS_ID] = PROG_MESS[3] + "*" + PROG_MESS[2];
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
               do
               {
                  if (!(INTERACT == INVALID_DATA)) break;
                  PRINT(AT(78, 23) + NRM_VID);
                  PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                  PRINT(AT(2, 23) + SPACE(76));
                  if (ALLOW_MULTIPAY != "N")
                  {
                     if (EPURSE_ROUTINE == "")
                     {
                        FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay or other mop" + SPACE(1);
                     }
                     else
                     {
                        FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay, 'EP'urse" + SPACE(1);
                     }
                  }
                  else
                  {
                     if (EPURSE_ROUTINE == "")
                     {
                        FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque or other mop" + SPACE(1);
                     }
                     else
                     {
                        FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'EP' for ePurse, other" + SPACE(1);
                     }
                  }
                  PRINT(AT(2, 23) + FOOT_MESS);
                  PRINT(AT(LEN(FOOT_MESS) + 2, 23));
                  INPUT(out MOP, 5);
                  // BEGIN CASE
                  // CASE
                  if (MOP == COMMON.ABANDON)
                  {
                     INTERACT = EXIT;
                     PROG_MESS[1] = COMMON.ABANDON;
                  }// CASE
                  else if (MOP == "M" && ALLOW_MULTIPAY == "N")
                  {
                     INTERACT = INVALID_DATA;
                  }// CASE
                  else if (MOP == "M" && BASKET_COUNT >= 16)
                  {
                     nrf0 = 81;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }// CASE
                  else if (MOP == "M")
                  {
                     /*  Multi-pay. File no payment. */
                     INTERACT = VALID_DATA;
                     PROG_MESS[30] = MAIN_KEY;
                     PROG_MESS[31] = PROG_MESS[3];
                     PROG_MESS[32] = STUDENT_ID;
                     PROG_MESS[33] = TICKET_REC[TICK_TOTAL] + 0;
                     TICKET_REC[TICK_TOTAL] = 0;
                     TICKET_REC[TICK_UNIT_PRICE] = 0;
                     TEMP_REC[23] = TEMP_REC[17];
                     L0150();
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
                     if (CHEQUE_PROMPT == "Y")
                     {
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
                     }
                     else
                     {
                        INTERACT = VALID_DATA;
                     }
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
                     /*  EPurse */
                  }// CASE
                  else if (MOP == "EP" && SMART_CARD)
                  {
                     IFACE_TYPE = 2;
                     TRANS_ID = "";
                     TRANS_TYPE = "E";
                     TRANS_AMOUNT = TICKET_REC[TICK_TOTAL];
                     if (MATCH(STUDENT_ID, "16N"))
                     {
                        /*  Unrecognised APACS number */
                        PASSED_MEMBER_NO = "";
                     }
                     else
                     {
                        PASSED_MEMBER_NO = STUDENT_ID;
                     }
                     SMART_DISPLAY_MODE = FWTERM_MODE;
                     CARD_ERROR_TYPE = 34;
                     FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref PASSED_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
                     if (SMARTCARD_INTERACT != VALID_DATA)
                     {
                        nrf0 = 301;
                        nrf1 = CARD_ERROR_TYPE + " (" + CARD_ERROR_MESS + ")";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     }
                     else
                     {
                        MAT(ref EPURSE_REC, "");
                        EPURSE_REC[EPURSE_APACS_NO] = APACS_NO;
                        EPURSE_REC[EPURSE_MEM_NO] = PASSED_MEMBER_NO;
                        EPURSE_REC[EPURSE_AMOUNT] = TRANS_AMOUNT;
                        FL00019 = new FL00019(ref EPURSE_REC, ref TRANS_ID, ref EPURSE_BALANCE, ref PROGRAM);
                        INTERACT = VALID_DATA;
                        TICKET_REC[TICK_MOP] = "EP";
                        TICKET_REC[TICK_APACS_NO] = APACS_NO;
                     }
                     IFACE_TYPE = "99";
                     /*  Remove card */
                     SMART_DISPLAY_MODE = FWTERM_MODE;
                     CARD_ERROR_TYPE = "";
                     FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref PASSED_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
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
            if (INTERACT == VALID_DATA && (RECEIPT_REQUIRED || TICKET_REC[TICK_TOTAL] != 0) && MOP != "M")
            {
               L8800();
               /*  Update temp.rec transaction whether or not a receipt is required */
            }
         }
         return;
         /* ***************************************** */
      }
      void L2000()
      {
         /*  Check membership type             * */
         /* ***************************************** */
         NO_EXPIRY_DATES = DCOUNT(MEMBERS_REC[MEMBER_EXPIRY_DATE], VM);
         // BEGIN CASE
         // CASE
         if (MEMBERS_REC[MEMBER_EXPIRY_DATE] == "")
         {
            NULL();
         }// CASE
         else if (NO_EXPIRY_DATES == 1)
         {
            if (MEMBERS_REC[MEMBER_EXPIRY_DATE] <= TODAYS_DATE)
            {
               nrf0 = 40;
               nrf1 = OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE], "D");
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }// CASE
         else if (OTHERWISE)
         {
            TYPE_STRING = "";
            for (N = 1; N <= NO_EXPIRY_DATES; N += 1)
            {
               if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N] <= TODAYS_DATE)
               {
                  if (TYPE_STRING == "")
                  {
                     TYPE_STRING = MEMBERS_REC[MEMBER_TYPE][1, N];
                  }
                  else
                  {
                     TYPE_STRING = TYPE_STRING + "," + MEMBERS_REC[MEMBER_TYPE][1, N];
                  }
               }
            }
            if (TYPE_STRING != "")
            {
               nrf0 = 46;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref TYPE_STRING);
            }
         }
         // END CASE
         DEBTOR_ID = COMMON.CENTRE + "*" + MEMBER_NUMBER;
         if (READ(ref TEST_REC, COMMON.FILES[FL_DEBTORS], DEBTOR_ID))
         {
            nrf0 = 41;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         /*  DJA 24.06.03 Member messages, Frozen DDs and membership start date */
         FL535 = new FL535(ref MEMBER_NUMBER, ref PROGRAM);
         /*  Check for Frozen direct debits */
         DD_ID = "1*" + MEMBER_NUMBER + "*1";
         if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID))
         {
            if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] <= TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] >= TODAYS_DATE)
            {
               CONTINUE = FALSE;
               do
               {
                  PRINT(AT(1, 23) + REV_VID);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(2, 23) + "Member's DD frozen from ");
                  PRINT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1], "D2/"));
                  PRINT(" - ");
                  PRINT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2], "D2/"));
                  PRINT(" Continue ? (Y/N) ");
                  INPUT(out YES_NO, 2);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_TEXT);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_DATA);
                  // BEGIN CASE
                  // CASE
                  if (YES_NO == "N" || YES_NO == "n")
                  {
                     INTERACT = EXIT;
                     CONTINUE = TRUE;
                  }// CASE
                  else if (YES_NO == "Y" || YES_NO == "y")
                  {
                     CONTINUE = TRUE;
                  }
                  // END CASE
                  if (CONTINUE == TRUE) break;
               } while (true);
            }
         }
         if (INTERACT != EXIT)
         {
            /*  Check for Direct Debit debts */
            DD_DEBTOR_ID = "1*" + MEMBER_NUMBER;
            if (MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID))
            {
               CONTINUE = FALSE;
               do
               {
                  PRINT(AT(1, 23) + REV_VID);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(2, 23) + "Member " + MEMBER_NUMBER + " is a current DD debtor. Continue ? (Y/N) ");
                  INPUT(out YES_NO, 2);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_TEXT);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_DATA);
                  // BEGIN CASE
                  // CASE
                  if (YES_NO == "N" || YES_NO == "n")
                  {
                     CONTINUE = TRUE;
                     INTERACT = EXIT;
                  }// CASE
                  else if (YES_NO == "Y" || YES_NO == "y")
                  {
                     CONTINUE = TRUE;
                  }
                  // END CASE
                  if (CONTINUE == TRUE) break;
               } while (true);
            }
            if (INTERACT != EXIT)
            {
               /*  Check membership start date */
               if (MEMBERS_REC[MEMBER_START_DATE] == "")
               {
                  MEMSHP_START = MEMBERS_REC[MEMBER_DATE_JOINED];
               }
               else
               {
                  MEMSHP_START = MEMBERS_REC[MEMBER_START_DATE];
               }
               if (MEMSHP_START > TODAYS_DATE)
               {
                  CONTINUE = FALSE;
                  do
                  {
                     PRINT(AT(1, 23) + REV_VID);
                     PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                     PRINT(AT(1, 23) + REV_VID + AT(2, 23) + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + "'s membership starts on " + OCONV(MEMSHP_START, "D") + ", Continue ? ");
                     INPUT(out YES_NO, 2);
                     PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                     PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_TEXT);
                     PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                     PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_DATA);
                     // BEGIN CASE
                     // CASE
                     if (YES_NO == "N" || YES_NO == "n")
                     {
                        CONTINUE = TRUE;
                        INTERACT = EXIT;
                     }// CASE
                     else if (YES_NO == "Y" || YES_NO == "y")
                     {
                        CONTINUE = TRUE;
                     }
                     // END CASE
                     if (CONTINUE == TRUE) break;
                  } while (true);
               }
            }
         }
         /*  THERE IS AN END MISSING SOMEWHERE IN THE ABOVE CODE */
         return;

         #endregion
         /* ********************************************************** */
      }
      void L4000()
      {
         /*   Disenrolment updates                               * */
         /* ********************************************************** */
         /*  student.pos = multivalue position on course.details */
         COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = DELETE(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, STUDENT_POS, 0);
         COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_VACANCIES] + 1;
         TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
         TICKET_TYPE = "C";
         /*  DJA 26.1.05 */
         if (FEE_TODAY == "Y")
         {
            /* !!Pointless - the original fee is held on enrolment file! */
            /* !!* Find what they paid originally */
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
         }
         else
         {
            SALE_DATE = PROG_MESS[3];
         }
         SALE_TIME = TIME();
         PERIOD = "";
         FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
         GROUP_MULTIVALUE = "";
         if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL"))
         {
            GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESS_POS];
            if (GROUP_NAME != "")
            {
               if (LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP_MULTIVALUE, "AL"))
               {
                  COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] + 1;
               }
            }
         }
         if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL"))
         {
            STUDENT_REC[STUDENT_DETAIL_IDS] = DELETE(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0);
         }
         /*  Currently this code just reverses the course fee.  Refunds will be required */
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
         /*  DJA 17.7.06 */
         /*  Don't delete data which may be required for bonus rollback */
         /*  upon refund */
         if (ENROL_REC[ENROL_BONUS_AWARD] == "")
         {
            DELETE(FL_ENROLMENT, ENROL_ID);
         }
         /*  Recall any bonus points which were awarded on enrolment */
         /*  (and after payment in full) */
         /* DJA 14.7.06!     CONTRA.TICKET.REQUIRED = FALSE */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!* Reconstruct ticket record to support the call to FL165 */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!     TICK.REC = "" */
         /* DJA 14.7.06!     TICK.REC<1> = "C*":COURSE.DET.FEE.CODE<1,1> */
         /* DJA 14.7.06!     TICK.REC<2> = 1 ; * Units */
         /* DJA 14.7.06!* DJA 12.11.04 */
         /* DJA 14.7.06!!!!  TICK.REC<3> = -ENROL.PRICE<1,1> ; * Fee */
         /* DJA 14.7.06!     TICK.REC<3> = ENROL.PRICE<1,1> */
         /* DJA 14.7.06!     TICK.REC<4> = TODAYS.DATE */
         /* DJA 14.7.06!     TICK.REC<5> = TIME() */
         /* DJA 14.7.06!     TICK.REC<6> = ENROL.PRICE<1,1> + 0 ; * Total */
         /* DJA 14.7.06!     TICK.REC<8> = U.INITS ; * Clerk */
         /* DJA 14.7.06!     TICK.REC<9> = TILL.NUMBER */
         /* DJA 14.7.06!     TICK.REC<10> = STUDENT.ID ; * Membership number */
         /* DJA 14.7.06!     TICK.REC<36> = APACS.NO */
         /* DJA 14.7.06!     PERIOD = 1 ; * Peak */
         /* DJA 14.7.06!     TICK.REC<11> = PERIOD */
         /* DJA 14.7.06!     TICK.REC<13> = ENROL.CONCESSION<1,1> */
         /* DJA 14.7.06!     TICK.REC<34> = CENTRE */
         /* DJA 14.7.06!     IF STUDENT.IS.MEMBER AND ENROL.BONUS.AWARD > 0 THEN */
         /* DJA 14.7.06!        CONTRA.TICKET.REQUIRED = TRUE */
         /* DJA 14.7.06!        TODAYZ.DATE = TODAYS.DATE */
         /* DJA 14.7.06!        CALL.REF = "MCOURSES" */
         /* DJA 14.7.06!* FL165 updates tick.rec <24> and <25> */
         /* DJA 14.7.06!        CALL FL165(TICK.REC, TODAYZ.DATE, PERIOD, CALL.REF) */
         /* DJA 14.7.06!     END */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!* DJA 12.11.04 */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!     TICK.REC<3> = -TICK.REC<3> */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!* Reverse any bonus redemptions */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!     IF STUDENT.IS.MEMBER AND ENROL.TOTAL.REDEMPTION > 0 THEN */
         /* DJA 14.7.06!        CONTRA.TICKET.REQUIRED = TRUE */
         /* DJA 14.7.06!        TICK.REC<25> = ENROL.PROMOTION */
         /* DJA 14.7.06!        TICK.REC<27> = -ENROL.TOTAL.REDEMPTION */
         /* DJA 14.7.06!        TICK.REC<28> = -ENROL.TOTAL.POINTS */
         /* DJA 14.7.06!        CALL FL795(STUDENT.ID, ENROL.TOTAL.POINTS, ENROL.TOTAL.REDEMPTION, ENROL.PROMOTION) */
         /* DJA 14.7.06!     END */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!     IF CONTRA.TICKET.REQUIRED THEN */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!* Write the ticket record for bonus point reconciliation */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!        TICK.ID = "" ; SESSION.NO = "" */
         /* DJA 14.7.06!* DJA 12.8.02 */
         /* DJA 14.7.06!        IF COURSE.MSTR.CENTRE # "" AND COURSE.MSTR.CENTRE # CENTRE AND CENTRALISED.COURSES = "Y" THEN */
         /* DJA 14.7.06!           PROG.MESS<24> = COURSE.MSTR.CENTRE */
         /* DJA 14.7.06!        END */
         /* DJA 14.7.06!        CALL FL000.12(PROGRAM,TICK.ID,"",SESSION.NO) */
         /* DJA 14.7.06!        PROG.MESS<24> = "" */
         /* DJA 14.7.06!        TICK.REC<16> = SESSION.NO */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!* Zeroise ticket amounts */
         /* DJA 14.7.06!* */
         /* DJA 14.7.06!        TICK.REC<3> = 0 */
         /* DJA 14.7.06!        TICK.REC<6> = 0 */
         /* DJA 14.7.06!        WRITE TICK.REC ON FL.TICKETS, TICK.ID */
         /* DJA 14.7.06!     END */
         /*  Warn if there is a waiting list for this activity */
         /* **  IF COURSE.DET.VACANCIES = 1 THEN */
         if (!READV(ref WAIT_MAST_REC[WAIT_MAST_IDS], FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_MAST_REC[WAIT_MAST_IDS] = ""; }
         NO_WAITING = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
         if (NO_WAITING > 0)
         {
            nrf0 = 30;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         /* **  END */
         return;
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
         /*  DJA 26.1.05 */
         if (FEE_TODAY == "Y")
         {
            SALE_DATE = TODAYS_DATE;
         }
         else
         {
            SALE_DATE = PROG_MESS[3];
         }
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
                     if (COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] < 1)
                     {
                        DISPLAY_MODE = 3;
                        /*  Student details known & passed */
                        PASSED_STUDENT_ID = STUDENT_ID;
                        L1050();
                        /*  Add student to waiting list? */
                        if (OFFER_DECLINED)
                        {
                           /*  User declined to add student to waiting list */
                           /*  Give user the opportunity to select a higher fee */
                           DONE = FALSE;
                           MEMBER_NUMBER = "";
                        }
                        START_FIELD = 1;
                        END_FIELD = 11;
                        L6000();
                        START_FIELD = 23;
                        END_FIELD = 24;
                        L6000();
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
            /* !*     IF STUDENT.IS.MEMBER AND CURRENT.PROMOTIONS # "" THEN */
            /* !*        CALL @BONUS.REDEEM.PROG(STUDENT.ID,COURSE.DET.FEE.CODE<1,1>,"CO",TICKET.PRICE,1,BONUS.REDEEM.REC,CURRENT.PROMOTIONS,TOTAL.REDEMPTION,TOTAL.POINTS) */
            /* !*        TICKET.PRICE = TICKET.PRICE - TOTAL.REDEMPTION */
            /* !*     END */
            /*  DJA 30.4.02 */
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
                        /*  DJA 14.9.04 */
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
            /*  Is there a nett balance for this student which should be transferred */
            /*  forwards and used to reduce the course fee? */
            PRO_RATA_PRICE = TICKET_PRICE;
            DET_ID_LIST = "";
            OLD_DESC_LIST = "";
            BALANCE_LIST = "";
            OLD_INSTALMENT_PLANS = FALSE;
            OVERALL_BALANCE = 0;
            TRANS_NO = 1;
            do
            {
               if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
               DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO];
               if (!(LOCATE(DET_ID, DET_ID_LIST, 1, 0, 1, ref DET_POS, "AL")))
               {
                  DET_ID_LIST[1, -1] = DET_ID;
                  if (!READV(ref OLD_DESC, FL_COURSE_MASTER, FIELD(DET_ID, "*", 2), 1)) { OLD_DESC = ""; }
                  OLD_DESC_LIST[1, -1] = OLD_DESC;
                  BALANCE_LIST[1, -1] = 0;
                  if (!READV(ref PLAN_TOTAL, FL_ENROLMENT, DET_ID + "*" + STUDENT_ID, 9)) { PLAN_TOTAL = ""; }
                  if (PLAN_TOTAL != "") { OLD_INSTALMENT_PLANS = TRUE; }
                  DET_POS = DCOUNT(DET_ID_LIST, VM);
               }
               BALANCE_LIST[1, DET_POS] = BALANCE_LIST[1, DET_POS] + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
               OVERALL_BALANCE = OVERALL_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
               TRANS_NO = TRANS_NO + 1;
            } while (true);
            /*  REMOVED: THIS SCENARIO NOW GENERATES UNNECESSARY TRANSACTIONS, BUT */
            /*           AT LEAST THE ON-SCREEN BALANCE IS CORRECT AND THE USER */
            /*           CAN'T OVER-PAY THE COURSE */
            /*  If the only course code with an associated balance is the currently */
            /*  selected one, then the student must be re-enrolling having un-enrolled */
            /*  in the past. Unlikely but possible. No balance transfers are necessary */
            /*  in this instance. */
            OLD_COURSE_COUNT = DCOUNT(DET_ID_LIST, VM);
            /* !IF OLD.COURSE.COUNT = 1 AND DET.ID.LIST<1,1> = COURSE.DATE:"*":MAIN.KEY THEN */
            /* ! OVERALL.BALANCE = 0 */
            /* !END */
            if (OVERALL_BALANCE != 0 && PERMIT_BALANCE_TRANSFERS == "Y")
            {
               /*  Display the old course details with balances */
               PRINT(CHAR(28) + "36,5,11,72,19" + CHAR(20));
               PRINT(AT(70, 11) + NRM_VID);
               PRINT(AT(5, 11) + UND_VID + FORMAT(" Existing course balances for transfer:", "L#66"));
               for (N = 1; N <= 8; N += 1)
               {
                  ROW = 11 + N;
                  PRINT(AT(70, ROW) + NRM_VID);
                  PRINT(AT(5, ROW) + DIM_VID);
                  PRINT(AT(5, ROW));
                  PRINT(SPACE(66));
               }
               DET_MVC = 1;
               ROW = 12;
               do
               {
                  if (DET_MVC > OLD_COURSE_COUNT || ROW > 19) break;
                  if (BALANCE_LIST[1, DET_MVC] != 0)
                  {
                     PRINT(AT(5, ROW) + DIM_VID);
                     PRINT(SPACE(1));
                     PRINT(FORMAT(FIELD(DET_ID_LIST[1, DET_MVC], "*", 2), "L#12"));
                     PRINT(SPACE(1));
                     PRINT(FORMAT(OLD_DESC_LIST[1, DET_MVC], "L#30"));
                     PRINT(SPACE(1));
                     PRINT(FORMAT(OCONV(FIELD(DET_ID_LIST[1, DET_MVC], "*", 1), "D"), "L#11"));
                     PRINT(SPACE(1));
                     PRINT(FORMAT(OCONV(BALANCE_LIST[1, DET_MVC], "MD2"), "R#8"));
                     PRINT(SPACE(1));
                     ROW = ROW + 1;
                  }
                  DET_MVC = DET_MVC + 1;
               } while (true);
               // BEGIN CASE
               // CASE
               if (OVERALL_BALANCE < 0)
               {
                  /*  Nett credit */
                  FOOT_OPTION = " O/s CREDIT of " + OCONV(ABS(OVERALL_BALANCE), "MD2") + ". Transfer to this course? ";
               }// CASE
               else if (OVERALL_BALANCE > 0)
               {
                  FOOT_OPTION = " O/s DEBT of " + OCONV(ABS(OVERALL_BALANCE), "MD2") + ". Transfer to this course? ";
               }
               // END CASE
               if (OLD_INSTALMENT_PLANS == TRUE)
               {
                  FOOT_OPTION = FOOT_OPTION + "(instalment plans exist) ";
               }
               do
               {
                  PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                  PRINT(AT(2, 21) + FORMAT(FOOT_OPTION, "L#75"));
                  PRINT(AT(2 + LEN(FOOT_OPTION), 21));
                  nrf0 = 2;
                  FL019 = new FL019(ref nrf0, ref REPLY);
                  REPLY = OCONV(REPLY, "MCU");
                  // BEGIN CASE
                  // CASE
                  if (REPLY == "")
                  {
                     REPLY = "Y";
                  }// CASE
                  else if (REPLY == COMMON.ABANDON)
                  {
                     REPLY = "N";
                  }
                  // END CASE
                  if (REPLY == "Y" && BASKET_COUNT > 0)
                  {
                     nrf0 = 95;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     REPLY = "";
                  }
                  if (REPLY == "Y" || REPLY == "N") break;
               } while (true);
               /*  Restore display */
               PRINT(CHAR(28) + "37,5,11,72,19" + CHAR(20));
               if (REPLY == "Y")
               {
                  TICKET_PRICE = TICKET_PRICE + OVERALL_BALANCE;
                  // BEGIN CASE
                  // CASE
                  if (OVERALL_BALANCE < 0)
                  {
                     /*  Nett credit */
                     FOOT_WARN = " Balance calculation: �" + OCONV(PRO_RATA_PRICE, "MD2") + " less �" + OCONV(ABS(OVERALL_BALANCE), "MD2") + " = �" + OCONV(TICKET_PRICE, "MD2");
                  }// CASE
                  else if (OVERALL_BALANCE > 0)
                  {
                     FOOT_WARN = " Balance calculation: �" + OCONV(PRO_RATA_PRICE, "MD2") + " plus �" + OCONV(ABS(OVERALL_BALANCE), "MD2") + " = �" + OCONV(TICKET_PRICE, "MD2");
                  }
                  // END CASE
                  PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                  PRINT(AT(2, 21) + FORMAT(FOOT_WARN, "L#75"));
                  /*  Put adjustments onto the student transaction list, one */
                  /*  to balance each old course back to zero */
                  DET_MVC = 1;
                  do
                  {
                     if (DET_MVC > OLD_COURSE_COUNT) break;
                     ADJ_AMOUNT = BALANCE_LIST[1, DET_MVC];
                     if (ADJ_AMOUNT != 0)
                     {
                        TRANS_MVC = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM) + 1;
                        STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_MVC] = DET_ID_LIST[1, DET_MVC];
                        STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC] = TODAYS_DATE;
                        STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] = "A";
                        STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_MVC] = -(ADJ_AMOUNT);
                        STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, TRANS_MVC] = "";
                        STUDENT_REC[STUDENT_TRANS_MOPS][1, TRANS_MVC] = "";
                        STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, TRANS_MVC] = "";
                        STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, TRANS_MVC] = "C/Fwd to " + MAIN_KEY + " (" + OCONV(COURSE_DATE, "D2/") + ")";
                        STUDENT_REC[STUDENT_TRANS_USER][1, TRANS_MVC] = U_INITS;
                        STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - ADJ_AMOUNT;
                     }
                     DET_MVC = DET_MVC + 1;
                  } while (true);
                  /*  DJA 12.2.03 */
                  BALANCE_TRANSFER = TRUE;
               }
            }
            L8700();
            /*  Build student ORIGINAL DEBIT details into temp.rec */
            /*  Display ticket price */
            START_FIELD = 18;
            END_FIELD = 18;
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
         /*  DJA 31.07.00 */
         if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID))
         {
            STUDENT_IS_MEMBER = TRUE;
            TEMP_REC[12] = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
            TEMP_REC[13] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
         }
         else
         {
            TEMP_REC[12] = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
            TEMP_REC[13] = STUDENT_REC[STUDENT_ADDRESS1];
         }
         if (USE_MEMBER_COMMENTS == "Y" && STUDENT_IS_MEMBER)
         {
            TEMP_REC[14] = MEMBERS_REC[MEMBER_COMMENTS].Substring(1, 20);
            TEMP_REC[15] = MEMBERS_REC[MEMBER_COMMENTS].Substring(21, 20);
            TEMP_REC[16] = MEMBERS_REC[MEMBER_COMMENTS].Substring(41, 20);
         }
         else
         {
            TEMP_REC[14] = STUDENT_REC[STUDENT_MEDICAL1];
            TEMP_REC[15] = STUDENT_REC[STUDENT_MEDICAL2];
            TEMP_REC[16] = STUDENT_REC[STUDENT_MEDICAL3];
         }
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
         TEMP_REC[29][1, 2] = -(TEMP_REC[18]);
         /*  Credit Amount */
         TEMP_REC[30][1, 2] = RECEIPT_NO;
         /*  Receipt No. */
         TEMP_REC[31][1, 2] = TICKET_REC[TICK_MOP];
         /*  MOP */
         return;
         /* ******************************************** */
      }
      void L8900()
      {
         /*  Load instalment details into temp.rec * */
         /* ******************************************** */
         TEMP_REC[19] = INST_NUMBER;
         /*  On-screen 'Instalments' field */
         TEMP_REC[34] = INST_PLAN_TOTAL;
         TEMP_REC[35] = INST_FIRST_DUE;
         TEMP_REC[36] = INST_NUMBER;
         TEMP_REC[37] = INST_VALUE;
         TEMP_REC[38] = INST_FREQUENCY;
         TEMP_REC[39] = INST_DATES;
         TEMP_REC[40] = INST_AMOUNTS;
         return;
         /* ********************************************* */
      }
      void L8950()
      {
         /*  Display instalment status              * */
         /* ********************************************* */
         NO_DATES = DCOUNT(INST_DATES, VM);
         if (!LOCATE(TODAYS_DATE, INST_DATES, 1, 0, 1, ref POS, "AR")) { NULL(); }
         NEXT_DATE = INST_DATES[1, POS];
         if (NEXT_DATE == "" || POS == NO_DATES)
         {
            NEXT_DATE = "- - - - ";
            NEXT_VALUE = "- - -";
         }
         else
         {
            NEXT_DATE = OCONV(NEXT_DATE, "D2/");
            NEXT_VALUE = OCONV(INST_AMOUNTS[1, POS], "MD2");
         }
         LAST_DATE = INST_DATES[1, NO_DATES];
         if (LAST_DATE == "")
         {
            LAST_DATE = "- - - - ";
            LAST_VALUE = "- - -";
         }
         else
         {
            LAST_DATE = OCONV(LAST_DATE, "D2/");
            LAST_VALUE = OCONV(INST_AMOUNTS[1, NO_DATES], "MD2");
         }
         TEXT_STRING = "Freq: " + INST_FREQUENCY + "  Next: " + NEXT_DATE + " " + NEXT_VALUE + "  Ends: " + LAST_DATE + " " + LAST_VALUE;
         PRINT(AT(24, 17) + NRM_VID + TEXT_STRING);
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
         ENROL_REC[ENROL_INST_PLAN_TOTAL] = TEMP_REC[34];
         ENROL_REC[ENROL_INST_FIRST_DUE] = TEMP_REC[35];
         ENROL_REC[ENROL_INST_NUMBER] = TEMP_REC[36];
         ENROL_REC[ENROL_INST_VALUE] = TEMP_REC[37];
         ENROL_REC[ENROL_INST_FREQUENCY] = TEMP_REC[38];
         ENROL_REC[ENROL_INST_DATES] = TEMP_REC[39];
         ENROL_REC[ENROL_INST_AMOUNTS] = TEMP_REC[40];
         ENROL_REC[ENROL_TOTAL_REDEMPTION] = TEMP_REC[41];
         ENROL_REC[ENROL_TOTAL_POINTS] = TEMP_REC[42];
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
            /*  DJA 14.9.04 */
            if (TEMP_REC[41] > 0)
            {
               /*  Bonus redemption - record original fee in the transaction 'reason' */
               STUDENT_REC[STUDENT_TRANS_ADJ_REASON] = "Original fee: �" + OCONV(STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, 1] + TEMP_REC[41], "MD2") + VM;
            }
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
            /*  DJA 14.9.04 */
            if (TEMP_REC[41] > 0)
            {
               /* ! NO.OF.TRANS = DCOUNT(STUDENT.TRANS.DATES,VM) */
               /*  Bonus redemption - record original fee in the transaction 'reason' */
               STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "Original fee: �" + OCONV(STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] + TEMP_REC[41], "MD2");
               STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, PAYMENT_MVC] = "";
            }
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
