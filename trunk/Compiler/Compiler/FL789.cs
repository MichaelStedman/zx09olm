//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL789 : UvBase
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
readonly UvVar MDATA_CODE = 1;
readonly UvVar MDATA_ENROLMENT_DATE = 2;
readonly UvVar MDATA_STUDENT_ID = 3;
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
UvVar[] MDATA_REC = new UvVar[5];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] EPURSE_REC = new UvVar[15];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar ZZZ_STATUS = "";
UvVar STUDENT_ID = "";
UvVar TOTAL_FEE_PAYABLE = "";
UvVar NEW_COURSE = "";
UvVar COURSE_BALANCE = "";
UvVar PAYMENT_MVC = "";
UvVar FEE_ADJUSTMENT = "";
UvVar OLD_COURSE_DATE = "";
UvVar WAITING_LIST_ENROLMENT = "";
UvVar EXISTING_ADJUST_TOTAL = "";
UvVar EXISTING_PAYMENT_TOTAL = "";
UvVar EXISTING_REFUND_TOTAL = "";
UvVar ORIGINAL_SESSIONS = "";
UvVar TOTAL_SESSIONS = "";
UvVar FEE_LIST = "";
UvVar CONC_LIST = "";
UvVar SESSION_COUNTS = "";
UvVar BONUS_REDEEM_REC = "";
UvVar PROMOTION = "";
UvVar TOTAL_REDEMPTION = "";
UvVar TOTAL_POINTS = "";
UvVar MOP = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar USER_STATUS = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
UvVar REV_UND_VID = "";
UvVar UND_VID = "";
UvVar MENU_HEAD_BACK = "";
UvVar MENU_HEAD_FORE = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar GO_BACK = "";
UvVar TILL_NUMBER = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar COLOR_C = "";
UvVar AM = "";
UvVar VM = "";
UvVar ACTIVITY = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar PROCESS_LOCKED = "";
UvVar JUST = "";
UvVar ORIG_SUB_HEAD = "";
UvVar DATES_PER_COL = "";
UvVar COLS = "";
UvVar FLAG_LENGTH = "";
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
UvVar FL_MARKETING_DATA = "";
UvVar FL_APACS_NUMBERS = "";
UvVar FL_EPURSE_LOG = "";
UvVar MOP_TYPES = "";
UvVar SMART_CARD = "";
UvVar EPURSE_ROUTINE = "";
UvVar TICKET_CONCESS = "";
UvVar VACANCY_THRESHOLD = "";
UvVar MANUAL_RECEIPTS = "";
UvVar DEDUCE_CONCESSIONS = "";
UvVar COURSE_PARAMS = "";
UvVar VALID_PRIVILEGES = "";
UvVar PREVENT_PP_AND_INSTALMENTS = "";
UvVar PREVENT_ZERO_PAYMENTS = "";
UvVar DEFAULT_PAYMENT = "";
UvVar ALLOW_MULTIPAY = "";
UvVar CHEQUE_PROMPT = "";
UvVar MARKETING_PROMPT = "";
UvVar FEE_TODAY = "";
UvVar NAME_INDEX_REQUEST = "";
UvVar SOUND_INDEX_REQUEST = "";
UvVar ADDRESS_INDEX_REQUEST = "";
UvVar CENTRALISED_COURSES = "";
UvVar EFT_SITE = "";
UvVar PHOTO_CODES = "";
UvVar DISPLAY_PHOTO = "";
UvVar TEST_POS = "";
UvVar PROMOTIONS_CONTROL = "";
UvVar CURRENT_PROMOTIONS = "";
UvVar BONUS_REDEEM_PROG = "";
UvVar MAX_FIELDS = "";
UvVar DATA_FIELDS = "";
UvVar DISPLAY_ONLY_FIELDS = "";
UvVar ENTRY_FIELDS = "";
UvVar MEMBER_NUMBER = "";
UvVar FIELD_COUNT = "";
UvVar BALANCE = "";
UvVar FEE_OVERRIDE = "";
UvVar COURSE_DATE = "";
UvVar LINE = "";
UvVar POS = "";
UvVar AMENDING = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar FIELD_NO = "";
UvVar MAIN_KEY = "";
UvVar DETAILS_ID = "";
UvVar FIELD_DATA = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
FL_HIDE_PHOTO FL_HIDE_PHOTO;
UvVar INPUT_LINE = "";
UvVar ANS = "";
FL791 FL791;
UvVar REDISPLAY = "";
UvVar ROW = "";
UvVar ORIGINAL_VALUE = "";
UvVar TEMP_VACS = "";
UvVar COMMENT_MODE = "";
FL793 FL793;
UvVar REDISPLAY_START_ROW = "";
UvVar REDISPLAY_END_ROW = "";
UvVar SESSION_DATE_COUNT = "";
UvVar DATE_NO = "";
UvVar FLAG_NO = "";
UvVar COL = "";
UvVar FLAG_COL = "";
FL006 FL006;
UvVar SESSION_START = "";
UvVar SESSION_END = "";
UvVar START_OF_RANGE = "";
UvVar END_OF_RANGE = "";
UvVar DAY_OF_WEEK = "";
UvVar THIS_FEE_CODE = "";
UvVar TICKET_PRICE = "";
UvVar FEE_KNOWN = "";
UvVar FPOS = "";
UvVar CONTROL_ID = "";
UvVar CONTROL_REC = "";
UvVar TICKET_FEE_ID = "";
UvVar TICKET_FEE_REC = "";
UvVar PREVIOUS_FLAG_NO = "";
UvVar EXISTING_TRANSACTIONS = "";
UvVar EXISTING_FEE_TOTAL = "";
UvVar DISPLAY_LINE = "";
UvVar REPLY = "";
UvVar DONE = "";
FL859 FL859;
UvVar MARKETING_ID = "";
UvVar MARKETING_SEQ = "";
UvVar TRANS_COUNT = "";
UvVar TRANS_NO = "";
UvVar ST_DISPLAY = "";
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
UvVar MATCH_FOUND = "";
UvVar COLS_REQUIRED = "";
UvVar SUB_HEAD = "";
UvVar SUB_HEAD_LENGTH = "";
UvVar SESSION_NO = "";
UvVar SUB_HEAD_DONE = "";
UvVar DAY_TEXT = "";
UvVar LEFTOVER = "";
UvVar COL_AMC = "";
UvVar ST_ATT_MV = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar ANS2 = "";
UvVar DISPLAY_MODE = "";
UvVar STUDENT_SCAN_ID = "";
FL717 FL717;
UvVar COURSE_ID = "";
CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
UvVar DATE_LIST = "";
UvVar CREATION_ALLOWED = "";
UvVar SELECT_DATE = "";
FL704 FL704;
UvVar ACTIVITY_CODE = "";
UvVar CONCESSION = "";
UvVar MAX_PLACES = "";
UvVar MASTER_LIST = "";
UvVar PLACES_TAKEN = "";
FL734 FL734;
UvVar PASSED_STUDENT_ID = "";
UvVar INITIAL_ENROL_SESSIONS = "";
UvVar MATCH_LIST = "";
FL723 FL723;
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar NEW_STUDENT = "";
FL710 FL710;
UvVar STUDENT_LIST = "";
UvVar STATUS_LIST = "";
FL735 FL735;
UvVar WAIT_LIST_ENROLMENT = "";
UvVar SEARCH_ROUTE = "";
FL000_20 FL000_20;
UvVar STUDENT_POS = "";
FL_PHOTO FL_PHOTO;
FL535 FL535;
UvVar CROSS_REFERENCED = "";
UvVar TEST_MEMBER_NO = "";
UvVar PADDED_ANS = "";
FL000_40 FL000_40;
UvVar STUDENT_EXISTS = "";
UvVar ENROL_ID = "";
UvVar RESPONSE = "";
UvVar CONV_COURSE_BALANCE = "";
UvVar COMMENTS = "";
UvVar COURSE_DEBT = "";
UvVar TC = "";
UvVar TEST_REC = "";
UvVar PROTECTED_PROG_MESS = "";
UvVar FL710_FEEDBACK = "";
UvVar CONV_ANS = "";
CallAt_BONUS_REDEEM_PROG CallAt_BONUS_REDEEM_PROG;
UvVar NEW_PRICE = "";
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
UvVar NO_TRANS = "";
UvVar MVC = "";
UvVar CONTRA_TICKET_REQUIRED = "";
FL165 FL165;
UvVar TICK_REC = "";
UvVar PERIOD = "";
UvVar TODAYZ_DATE = "";
UvVar CALL_REF = "";
FL795 FL795;
UvVar TICK_ID = "";
FL000_12 FL000_12;
UvVar NO_WAITING = "";
UvVar INITIAL_VALUE = "";
UvVar TICKET_CODE = "";
UvVar TICKET_TYPE = "";
UvVar SALE_DATE = "";
UvVar SALE_TIME = "";
FL355 FL355;
UvVar PRICE = "";
FL048 FL048;
UvVar NEW_ENROLMENT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL789(ref UvVar STUDENT_ID, ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar[] ENROL_REC, ref UvVar[] STUDENT_REC, ref UvVar[] TICKET_REC, ref UvVar TOTAL_FEE_PAYABLE, ref UvVar NEW_COURSE, ref UvVar COURSE_BALANCE, ref UvVar PAYMENT_MVC, ref UvVar FEE_ADJUSTMENT, ref UvVar OLD_COURSE_DATE, ref UvVar WAITING_LIST_ENROLMENT, ref UvVar[] WAIT_MAST_REC, ref UvVar EXISTING_ADJUST_TOTAL, ref UvVar EXISTING_PAYMENT_TOTAL, ref UvVar EXISTING_REFUND_TOTAL, ref UvVar ORIGINAL_SESSIONS, ref UvVar TOTAL_SESSIONS, ref UvVar FEE_LIST, ref UvVar CONC_LIST, ref UvVar SESSION_COUNTS, ref UvVar BONUS_REDEEM_REC, ref UvVar PROMOTION, ref UvVar TOTAL_REDEMPTION, ref UvVar TOTAL_POINTS, ref UvVar MOP) {
this.STUDENT_ID = STUDENT_ID;
this.COURSE_MSTR_REC = COURSE_MSTR_REC;
this.COURSE_DET_REC = COURSE_DET_REC;
this.ENROL_REC = ENROL_REC;
this.STUDENT_REC = STUDENT_REC;
this.TICKET_REC = TICKET_REC;
this.TOTAL_FEE_PAYABLE = TOTAL_FEE_PAYABLE;
this.NEW_COURSE = NEW_COURSE;
this.COURSE_BALANCE = COURSE_BALANCE;
this.PAYMENT_MVC = PAYMENT_MVC;
this.FEE_ADJUSTMENT = FEE_ADJUSTMENT;
this.OLD_COURSE_DATE = OLD_COURSE_DATE;
this.WAITING_LIST_ENROLMENT = WAITING_LIST_ENROLMENT;
this.WAIT_MAST_REC = WAIT_MAST_REC;
this.EXISTING_ADJUST_TOTAL = EXISTING_ADJUST_TOTAL;
this.EXISTING_PAYMENT_TOTAL = EXISTING_PAYMENT_TOTAL;
this.EXISTING_REFUND_TOTAL = EXISTING_REFUND_TOTAL;
this.ORIGINAL_SESSIONS = ORIGINAL_SESSIONS;
this.TOTAL_SESSIONS = TOTAL_SESSIONS;
this.FEE_LIST = FEE_LIST;
this.CONC_LIST = CONC_LIST;
this.SESSION_COUNTS = SESSION_COUNTS;
this.BONUS_REDEEM_REC = BONUS_REDEEM_REC;
this.PROMOTION = PROMOTION;
this.TOTAL_REDEMPTION = TOTAL_REDEMPTION;
this.TOTAL_POINTS = TOTAL_POINTS;
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
/*     ACTIVITY DAY ENROLMENT */
PROMPT("");
PROGRAM = "FL789";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
JUST = "";
ORIG_SUB_HEAD = "Date  Session 1 2 3 4 5 Date  Session 1 2 3 4 5 Date  Session 1 2 3 4 5   ";
MOP = "";
DATES_PER_COL = 14;
COLS = 2;
COLS[2] = 26;
COLS[3] = 50;
FLAG_LENGTH = 2;
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
#region INCLUDE FL.FILES FL.MARKETING.DATA
if (!OPEN("FL.MARKETING.DATA", out FL_MARKETING_DATA)) { STOP("201", "FL.MARKETING.DATA"); }

#endregion
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
#region INCLUDE FL.FILES FL.EPURSE.LOG
if (!OPEN("FL.EPURSE.LOG", out FL_EPURSE_LOG)) { STOP(201, "UNABLE TO OPEN FL.EPURSE.LOG"); }

/*  <7> Contains (D)ebit or (C)redit */

#endregion
if (!READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")) { MOP_TYPES = ""; }
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!(READV(ref EPURSE_ROUTINE, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 4))) {
EPURSE_ROUTINE = "";
}
MAT(ref TEMP_REC, "");
TICKET_CONCESS = "";
VACANCY_THRESHOLD = 1;
if (!READV(ref MANUAL_RECEIPTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 2)) { MANUAL_RECEIPTS = "N"; }
MANUAL_RECEIPTS = MANUAL_RECEIPTS[1, 1];
if (!READV(ref DEDUCE_CONCESSIONS, FL_COURSE_PARAMS, "COURSE.PARAMS", 17)) { DEDUCE_CONCESSIONS = ""; }
if (DEDUCE_CONCESSIONS == "") { DEDUCE_CONCESSIONS = "Y"; }
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
VALID_PRIVILEGES = COURSE_PARAMS[3, 1];
PREVENT_PP_AND_INSTALMENTS = COURSE_PARAMS[15, 1];
PREVENT_ZERO_PAYMENTS = COURSE_PARAMS[25, 1];
DEFAULT_PAYMENT = COURSE_PARAMS[29, 1];
ALLOW_MULTIPAY = COURSE_PARAMS[41, 1];
CHEQUE_PROMPT = COURSE_PARAMS[48, 1];
if (CHEQUE_PROMPT == "") { CHEQUE_PROMPT = "Y"; }
MARKETING_PROMPT = COURSE_PARAMS[42, 1];
FEE_TODAY = COURSE_PARAMS[49, 1];
if (!(READV(ref NAME_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "NAME.INDEX.REQUEST", 1))) {
NAME_INDEX_REQUEST = "I";
}
if (!(READV(ref SOUND_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "SOUND.INDEX.REQUEST", 1))) {
SOUND_INDEX_REQUEST = "S";
}
if (!READV(ref ADDRESS_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "ADDRESS.INDEX.REQUEST", 1)) { ADDRESS_INDEX_REQUEST = "A"; }
if (!MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "COURSE.BOOKING.LEVELS")) { MAT(ref COURSE_PARAM_REC, ""); }
if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
/* <EFT */
if (!(READV(ref EFT_SITE, COMMON.FILES[FL_CONTROL], "EFT.SITE", 1))) {
EFT_SITE = FALSE;
}
/* EFT> */
/*  DJA 28.4.00 */
if (!READ(ref PHOTO_CODES, COMMON.FILES[FL_CONTROL], "TEMP.PHOTO.CODES")) { PHOTO_CODES = ""; }
if (PHOTO_CODES[1, 1] == "ALL") {
DISPLAY_PHOTO = TRUE;
} else {
if (LOCATE(SCREEN_CODE, PHOTO_CODES, 1, 0, 1, ref TEST_POS, "AL")) {
DISPLAY_PHOTO = TRUE;
} else {
DISPLAY_PHOTO = FALSE;
}
}
if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL"))) {
PROMOTIONS_CONTROL = "";
}
CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
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
MEMBER_NUMBER = "";
FIELD_COUNT = 0;
BALANCE = 0;
FEE_OVERRIDE = FALSE;
if (PROG_MESS[35] != "" && PROG_MESS[36] != "") {
/*  Called from Activity Day Place Enquiry */
COURSE_DATE = PROG_MESS[36];
PROG_MESS[2] = PROG_MESS[35];
PROG_MESS[3] = PROG_MESS[36];
} else {
COURSE_DATE = PROG_MESS[3];
}
if (COURSE_DATE <= TODAYS_DATE) {
/*  Course has started already */
if (INDEX(VALID_PRIVILEGES, USER_STATUS, 1)) { FEE_OVERRIDE = TRUE; }
}
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
/*  DJA 31.07.00 */
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
STUDENT_IS_MEMBER = FALSE;
FIELD_NO = 1;
if (PROG_MESS[2] != "") {
MAIN_KEY = PROG_MESS[2];
if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) {
DETAILS_ID = PROG_MESS[3] + "*" + MAIN_KEY;
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
L8000();
/*  Build temp.rec */
FIELD_NO = 4;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
START_FIELD = 1;
END_FIELD = 3;
L6000();
L0150();
} else {
INTERACT = EXIT;
PROG_MESS = COMMON.ABANDON;
}
} else {
INTERACT = EXIT;
PROG_MESS = COMMON.ABANDON;
}
} else {
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
}
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
/*  Transfer data out of TEMP.REC */
L9000();
}
}
/*  DJA 28.4.00 */
if (DISPLAY_PHOTO) {
FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
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
INPUT_LINE = " Make selections (? for help) or 'F'inish ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 21) + SPACE(76));
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 5);
if (ANS == COMMON.HELP) {
FL791 = new FL791(ref ANS, ref INTERACT, ref REDISPLAY);
for(ROW = 6; ROW <= 19; ROW += 1) {
PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
}
L0150();
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
}
PRINT(AT(2, 21) + SPACE(73));
ANS = OCONV(ANS, "MCU");
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (MATCH(ANS,"\"V\"1N") || MATCH(ANS,"\"V\"2N") || ANS == "V") {
ORIGINAL_VALUE = VACANCY_THRESHOLD;
if (ANS == "V") {
VACANCY_THRESHOLD = 1;
} else {
TEMP_VACS = TRIM(ANS.Substring(2, 2));
if (TEMP_VACS > 0) { VACANCY_THRESHOLD = TEMP_VACS; }
}
if (VACANCY_THRESHOLD != ORIGINAL_VALUE) {
L0350();
/*  Refresh screen showing vacancies */
if (VACANCY_THRESHOLD == 1) {
PRINT(AT(56, 4) + NRM_VID + COMMON.EOL);
} else {
PRINT(AT(56, 4) + REV_VID + "VACANCY THRESHOLD: " + VACANCY_THRESHOLD + NRM_VID);
}
}
}// CASE
else if (ANS == "H") {
if (DISPLAY_PHOTO) {
FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
}
}// CASE
else if (ANS == "C") {
COMMENT_MODE = 1;
/*  Course comments */
nrf0 = COURSE_DET_REC[COURSE_DET_COMMENTS];
FL793 = new FL793(ref COMMENT_MODE, ref nrf0, ref REDISPLAY_START_ROW, ref REDISPLAY_END_ROW);
for(ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1) {
PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
}
L0150();
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
}// CASE
else if (ANS == "") {
/*  Next page */
}// CASE
else if (ANS == "F") {
/*  (Re-)Calculate and process fee */
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = ""; }
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
}// CASE
else if (ANS == "NONE") {
TEMP_REC[5] = "";
L0350();
/*  Display session flag data */
}// CASE
else if (ANS == "ALL") {
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
/*  Slot not available */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD && TEMP_REC[5][1, DATE_NO, FLAG_NO] == "") {
/*  No vacancies for this session on this day, and this */
/*  student doesn't already have a booking for it */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] == "Y") {
/*  Session is available and there's a free place */
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "Y";
L0175();
/*  Set column and row */
PRINT(AT(COL + 15, ROW) + NRM_VID);
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}
// END CASE
}
}
}// CASE
else if (MATCH(ANS,"\"S\"1N")) {
FLAG_NO = ANS.Substring(2, 1);
if (FLAG_NO < 1 || FLAG_NO > COURSE_DET_REC[COURSE_DET_SESSIONS]) {
nrf0 = 48;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
/*  Slot not available */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD && TEMP_REC[5][1, DATE_NO, FLAG_NO] == "") {
/*  No vacancies for this session on this day, and this */
/*  student doesn't already have a booking for it */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] == "Y") {
/*  Session is available and there's a free place */
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "Y";
L0175();
/*  Set column and row */
PRINT(AT(COL + 15, ROW) + NRM_VID);
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}
// END CASE
}
}
}// CASE
else if (ANS == "R" || MATCH(ANS,"\"R\"1N")) {
/*  Set session flags for a range of dates */
if (ANS == "R") {
SESSION_START = 1;
SESSION_END = COURSE_DET_REC[COURSE_DET_SESSIONS];
} else {
SESSION_START = ANS.Substring(2, 1);
SESSION_END = ANS.Substring(2, 1);
}
if (SESSION_END < 1 || SESSION_END > COURSE_DET_REC[COURSE_DET_SESSIONS]) {
nrf0 = 54;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = INVALID_DATA;
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
START_OF_RANGE = "";
END_OF_RANGE = "";
do {
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "   Enter the field number for the FIRST date ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(74));
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
if (ANS >= 1 && ANS <= SESSION_DATE_COUNT) {
START_OF_RANGE = ANS;
do {
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "   Enter the field number for the LAST date ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(74));
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
// BEGIN CASE
// CASE
if (ANS < 1 || ANS > SESSION_DATE_COUNT) {
nrf0 = 51;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS < START_OF_RANGE) {
nrf0 = 50;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
END_OF_RANGE = ANS;
}
// END CASE
}
// END CASE
} while (true);
} else {
nrf0 = 49;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
// END CASE
} while (true);
if (INTERACT == VALID_DATA) {
for(DATE_NO = START_OF_RANGE; DATE_NO <= END_OF_RANGE; DATE_NO += 1) {
L0175();
/*  Set column and row */
for(FLAG_NO = SESSION_START; FLAG_NO <= SESSION_END; FLAG_NO += 1) {
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
/*  Slot not available */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD && TEMP_REC[5][1, DATE_NO, FLAG_NO] == "") {
/*  No vacancies for this session on this day, and this */
/*  student doesn't already have a booking for it */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] == "Y") {
/*  Session is available and there's a free place */
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "Y";
PRINT(AT(COL + 15, ROW) + NRM_VID);
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}
// END CASE
}
}
}
}
INTERACT = INVALID_DATA;
}// CASE
else if (MATCH(ANS,"2A1N")) {
DAY_OF_WEEK = ANS.Substring(1, 2);
if (DAY_OF_WEEK != "MO" && DAY_OF_WEEK != "TU" && DAY_OF_WEEK != "WE" && DAY_OF_WEEK != "TH" && DAY_OF_WEEK != "FR" && DAY_OF_WEEK != "SA" && DAY_OF_WEEK != "SU") {
nrf0 = 52;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
FLAG_NO = ANS.Substring(3, 1);
if (FLAG_NO < 1 || FLAG_NO > COURSE_DET_REC[COURSE_DET_SESSIONS]) {
nrf0 = 53;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
/*  Slot not available */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD && TEMP_REC[5][1, DATE_NO, FLAG_NO] == "") {
/*  No vacancies for this session on this day, and this */
/*  student doesn't already have a booking for it */
NULL();
}// CASE
else if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] == "Y") {
/*  Session is available and there's a free place */
if (OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "DWA").Substring(1, 2) == DAY_OF_WEEK) {
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "Y";
L0175();
/*  Set column and row */
PRINT(AT(COL + 15, ROW) + NRM_VID);
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}
}
// END CASE
}
}
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM)) {
/*  Calculate column and row and call data entry routine */
DATE_NO = ANS;
L0175();
/*  Get column and row */
L0500();
/*  Input session flags */
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ******************************************** */
}
void L0055() {
/*  Calculate and process fee             * */
/* ******************************************** */
/*  Validate that key fields are present before allowing the user to file */
INTERACT = VALID_DATA;
FEE_LIST = "";
/*  Attributed by session (up to 4) */
CONC_LIST = "";
/*  Attributed by session (up to 4) */
TOTAL_FEE_PAYABLE = 0;
ORIGINAL_SESSIONS = COUNT(ENROL_REC[ENROL_SESSIONS], "Y");
TOTAL_SESSIONS = 0;
SESSION_COUNTS = "";
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
FLAG_NO = 1;
do {
if (FLAG_NO > COURSE_DET_REC[COURSE_DET_SESSIONS] || INTERACT == INVALID_DATA) break;
DATE_NO = 1;
do {
if (DATE_NO > SESSION_DATE_COUNT || INTERACT == INVALID_DATA) break;
if (TEMP_REC[5][1, DATE_NO, FLAG_NO] == "Y") {
TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
SESSION_COUNTS[FLAG_NO] = SESSION_COUNTS[FLAG_NO] + 1;
if (FEE_LIST[FLAG_NO] != "") {
/*  Fee is already known for this session */
TOTAL_FEE_PAYABLE = TOTAL_FEE_PAYABLE + FEE_LIST[FLAG_NO];
} else {
if (COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FLAG_NO] == "") {
/*  No fee specified. Default to fee code for session 1 */
if (FEE_LIST[1] == "") {
/*  Establish fee for session 1 */
THIS_FEE_CODE = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
L5000();
/*  Returns TICKET.PRICE */
FEE_LIST[1] = TICKET_PRICE;
CONC_LIST[1] = TICKET_CONCESS;
/*  DJA 25.4.01 *        FEE.LIST<FLAG.NO> = TICKET.PRICE */
/*  DJA 25.4.01 *        CONC.LIST<FLAG.NO> = TICKET.CONCESS */
}
TOTAL_FEE_PAYABLE = TOTAL_FEE_PAYABLE + FEE_LIST[1];
/*  DJA 25.4.01 */
FEE_LIST[FLAG_NO] = FEE_LIST[1];
CONC_LIST[FLAG_NO] = CONC_LIST[1];
} else {
if (FEE_LIST[FLAG_NO] == "") {
/*  Establish fee for this session */
THIS_FEE_CODE = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FLAG_NO];
/*  If we've already established the fee for this code */
/*  then don't do it again! */
FEE_KNOWN = FALSE;
if (FLAG_NO > 1) {
FPOS = 1;
do {
if (FEE_KNOWN || FPOS == FLAG_NO) break;
if (COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FPOS] == THIS_FEE_CODE && FEE_LIST[FPOS] != "") {
FEE_KNOWN = TRUE;
FEE_LIST[FLAG_NO] = FEE_LIST[FPOS];
CONC_LIST[FLAG_NO] = CONC_LIST[FPOS];
} else {
FPOS = FPOS + 1;
}
} while (true);
}
if (NOT(FEE_KNOWN)) {
/*  May still be able to establish the price by using */
/*  the concession description selected for the first */
/*  fee code */
if (FLAG_NO > 1 && DEDUCE_CONCESSIONS == "Y") {
CONTROL_ID = "CONTROL*" + COMMON.CENTRE + "*C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FLAG_NO];
if (READ(ref CONTROL_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_ID)) {
if (!LOCATE(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], CONTROL_REC, 0, 0, 1, ref POS, "AR")) { POS = POS - 1; }
if (POS < 1) { POS = 1; }
TICKET_FEE_ID = COMMON.CENTRE + "*C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FLAG_NO] + "*" + CONTROL_REC[POS];
if (READ(ref TICKET_FEE_REC, COMMON.FILES[FL_TICKET_FEES], TICKET_FEE_ID)) {
PREVIOUS_FLAG_NO = 1;
do {
if (PREVIOUS_FLAG_NO == FLAG_NO || FEE_KNOWN) break;
/*  DJA 2/7/01  Spurious MV marks may be filed on the */
/*              end of ticket fee attributes 24 & 25. */
/*              A search for a 'null' value will find */
/*              these and return an incorrect 0.00 price */
if (CONC_LIST[PREVIOUS_FLAG_NO] != "") {
if (LOCATE(CONC_LIST[PREVIOUS_FLAG_NO], TICKET_FEE_REC[24], 1, 0, 1, ref POS, "AL")) {
FEE_KNOWN = TRUE;
FEE_LIST[FLAG_NO] = TICKET_FEE_REC[25, POS];
CONC_LIST[FLAG_NO] = CONC_LIST[PREVIOUS_FLAG_NO];
} else {
PREVIOUS_FLAG_NO = PREVIOUS_FLAG_NO + 1;
}
} else {
PREVIOUS_FLAG_NO = PREVIOUS_FLAG_NO + 1;
}
} while (true);
}
}
}
}
if (NOT(FEE_KNOWN)) {
L5000();
/*  Returns TICKET.PRICE */
FEE_LIST[FLAG_NO] = TICKET_PRICE;
CONC_LIST[FLAG_NO] = TICKET_CONCESS;
}
}
/*  FEE.LIST can contain the abandon character */
if (NOT(NUM(FEE_LIST[FLAG_NO]))) { FEE_LIST[FLAG_NO] = ""; }
TOTAL_FEE_PAYABLE = TOTAL_FEE_PAYABLE + FEE_LIST[FLAG_NO];
}
}
}
DATE_NO = DATE_NO + 1;
} while (true);
FLAG_NO = FLAG_NO + 1;
} while (true);
/*  DJA 27.3.01 */
if (TOTAL_SESSIONS == 0) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
if (INTERACT == VALID_DATA) {
/*  No problems encountered */
/*  What payments and fee adjustments already exist for this course */
L0057();
INTERACT = FINISH;
if (EXISTING_TRANSACTIONS) {
/*  Calculate an adjustment - student was already enrolled */
FEE_ADJUSTMENT = TOTAL_FEE_PAYABLE - EXISTING_FEE_TOTAL;
DISPLAY_LINE = "  Total Sessions: " + TOTAL_SESSIONS + ". Fee Adjustment: " + OCONV(FEE_ADJUSTMENT, "MD2") + ". Press <return>";
} else {
FEE_ADJUSTMENT = TOTAL_FEE_PAYABLE;
DISPLAY_LINE = "  Total Sessions: " + TOTAL_SESSIONS + ". Fee Total: " + OCONV(FEE_ADJUSTMENT, "MD2") + ". Press <return>";
}
L8700();
/*  Populate temp.rec with fee details */
TEMP_REC[6] = TOTAL_FEE_PAYABLE;
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + DISPLAY_LINE);
INPUT(out REPLY, 2);
PRINT(AT(2, 21) + SPACE(75));
if (REPLY == COMMON.ABANDON) {
INTERACT = EXIT;
} else {
/*  Calculate course balance */
COURSE_BALANCE = TOTAL_FEE_PAYABLE + EXISTING_PAYMENT_TOTAL + EXISTING_REFUND_TOTAL + EXISTING_ADJUST_TOTAL;
// BEGIN CASE
// CASE
if (COURSE_BALANCE == 0) {
DISPLAY_LINE = "  The balance payable for this course is now 0.00. Press <return>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + DISPLAY_LINE);
INPUT(out REPLY, 2);
if (REPLY == COMMON.ABANDON) { INTERACT = EXIT; }
}// CASE
else if (COURSE_BALANCE < 0) {
DISPLAY_LINE = "  Credit balance of " + OCONV(COURSE_BALANCE, "MD2") + ". Now use Refunds or Fee Adjustments";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + DISPLAY_LINE);
INPUT(out REPLY, 2);
if (REPLY == COMMON.ABANDON) { INTERACT = EXIT; }
}// CASE
else if (COURSE_BALANCE > 0) {
/*  Get details of payment (unless student is in credit or */
/*  has a zero balance) */
DISPLAY_LINE = "  Enter payment amount (o/s balance = " + OCONV(COURSE_BALANCE, "MD2") + ") ";
DONE = FALSE;
INTERACT = INVALID_DATA;
do {
if (DONE || INTERACT == EXIT) break;
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(75));
PRINT(AT(2, 21) + DISPLAY_LINE);
INPUT(out ANS, 7);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (OTHERWISE) {
L1500();
/*  Validate & process payment */
if (INTERACT == VALID_DATA) {
L1700();
/*  Final processing */
if (INTERACT != EXIT) {
INTERACT = VALID_DATA;
DONE = TRUE;
COURSE_BALANCE = TEMP_REC[23];
/*  Passed back to controlling routine */
}
}
}
// END CASE
} while (true);
}
// END CASE
}
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
/*  Abandon updates */
} else {
/*  Revise vacancies */
L4500();
/*  Prompt for marketing code */
if (MARKETING_PROMPT == "Y") {
INTERACT = INVALID_DATA;
do {
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
}
INTERACT = FINISH;
/*  Proceed with updates */
}
}
return;
/* ********************************** */
}
void L0057() {
/*  Total existing transactions * */
/*      for this course             * */
/* ********************************** */
/*  What payments and fee adjustments already exist for this course */
EXISTING_FEE_TOTAL = 0;
EXISTING_PAYMENT_TOTAL = 0;
EXISTING_REFUND_TOTAL = 0;
EXISTING_ADJUST_TOTAL = 0;
EXISTING_TRANSACTIONS = FALSE;
TRANS_COUNT = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
TRANS_NO = 1;
do {
if (TRANS_NO > TRANS_COUNT) break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == DETAILS_ID) {
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "O") {
EXISTING_FEE_TOTAL = EXISTING_FEE_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
EXISTING_TRANSACTIONS = TRUE;
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "D") {
EXISTING_FEE_TOTAL = EXISTING_FEE_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
EXISTING_TRANSACTIONS = TRUE;
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P") {
EXISTING_PAYMENT_TOTAL = EXISTING_PAYMENT_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
EXISTING_TRANSACTIONS = TRUE;
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "R") {
EXISTING_REFUND_TOTAL = EXISTING_REFUND_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
EXISTING_TRANSACTIONS = TRUE;
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "A") {
EXISTING_ADJUST_TOTAL = EXISTING_ADJUST_TOTAL + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
EXISTING_TRANSACTIONS = TRUE;
}
// END CASE
}
TRANS_NO = TRANS_NO + 1;
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
// BEGIN CASE
// CASE
if (ST_DISPLAY == "D") {
NULL();
}// CASE
else if (OTHERWISE) {
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
if (FIELD_NO == 4) {
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
} else {
MEMBER_PROGRAM = "";
}
/*  Smart card may already be positioned in the reader */
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 4) {
L0065();
}
if (NOT(SMARTCARD_READ)) {
if (MEMBER_PROGRAM != "") {
CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
} else {
INPUT(out ANS, ST_LENGTH);
}
if (ANS == "" && VALUE == "" && FIELD_NO == 4 && SMART_CARD) {
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 4) {
L0065();
/*  Re-try card read in case it was presented 'late' */
}
}
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON && EPURSE_ROUTINE != "" && MOP == "EP") {
nrf0 = 345;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.ABANDON && EFT_SITE && MOP == MOP_TYPES[3]) {
nrf0 = 45;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.ABANDON) {
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
case 4: L1300(); break;
case 5: L1200(); break;
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
// END CASE
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
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(76));
}
PRINTCR(AT(2, 5) + MENU_HEAD_BACK + MENU_HEAD_FORE + ORIG_SUB_HEAD + NRM_VID);
/*  Position cursor to prevent Wyse taking a chunk out of footing bar */
PRINTCR(AT(0, 3) + NRM_VID);
L0120();
return;
/* *************************************************** */
}
void L0120() {
/*  Update basket count                          * */
/* *************************************************** */
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
BASKET_TOTAL = 0;
/*  This entry may be a replacement to an existing entry */
MATCH_FOUND = FALSE;
COMMON.X = 1;
do {
if (COMMON.X > BASKET_COUNT) break;
BASKET_TOTAL = BASKET_TOTAL + MULTIPAY_REC[4, COMMON.X];
if (MULTIPAY_REC[1, COMMON.X] == PROG_MESS[30] && MULTIPAY_REC[2, COMMON.X] == PROG_MESS[31] && MULTIPAY_REC[3, COMMON.X] == PROG_MESS[32]) {
MATCH_FOUND = TRUE;
TRANS_NO = COMMON.X;
}
COMMON.X = COMMON.X + 1;
} while (true);
if (PROG_MESS[30] != "") {
if (MATCH_FOUND) {
BASKET_TOTAL = BASKET_TOTAL + PROG_MESS[33] - MULTIPAY_REC[4, TRANS_NO];
} else {
BASKET_COUNT = BASKET_COUNT + 1;
BASKET_TOTAL = BASKET_TOTAL + PROG_MESS[33];
}
}
if (BASKET_COUNT > 0) {
PRINT(AT(43, 2) + ERR_MESS_BACK + ERR_MESS_FORE + "Items in basket: " + FORMAT(BASKET_COUNT, "R#2") + "  Total: " + FORMAT(OCONV(BASKET_TOTAL, "MD2"), "R#7"));
PRINT(AT(0, 3) + NRM_VID);
}
return;
/* *********************************************** */
}
void L0150() {
/*  Display session dates                    * */
/* *********************************************** */
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
COLS_REQUIRED = INT((SESSION_DATE_COUNT - 1) / DATES_PER_COL) + 1;
SUB_HEAD = ORIG_SUB_HEAD;
SUB_HEAD_LENGTH = LEN(ORIG_SUB_HEAD);
/*  Remove unnecessary session numbers from the 3 columns */
if (COURSE_DET_REC[COURSE_DET_SESSIONS] < 5) {
SESSION_NO = COURSE_DET_REC[COURSE_DET_SESSIONS] + 1;
do {
if (SESSION_NO > 5) break;
COL = 1;
do {
if (COL > 3) break;
POS = INDEX(SUB_HEAD, SESSION_NO, 1);
SUB_HEAD = SUB_HEAD.Substring(1, POS - 1) + " " + SUB_HEAD.Substring(POS + 1, 99);
COL = COL + 1;
} while (true);
SESSION_NO = SESSION_NO + 1;
} while (true);
}
/*  Completely remove unnecessary column headings */
SUB_HEAD_DONE = FALSE;
COL = 1;
do {
if (COL > 3 || SUB_HEAD_DONE) break;
if (COLS_REQUIRED < COL) {
/*  Locate 'D' for 'Date' */
POS = INDEX(SUB_HEAD, "D", COL);
SUB_HEAD = SUB_HEAD.Substring(1, POS - 1);
SUB_HEAD = SUB_HEAD + SPACE(SUB_HEAD_LENGTH - LEN(SUB_HEAD));
SUB_HEAD_DONE = TRUE;
}
COL = COL + 1;
} while (true);
PRINT(AT(2, 5) + MENU_HEAD_BACK + MENU_HEAD_FORE + SUB_HEAD + NRM_VID);
if (SESSION_DATE_COUNT > 42) {
nrf0 = 60;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
SESSION_DATE_COUNT = 42;
}
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
L0175();
/*  Set column and row */
PRINT(AT(COL + 15, ROW) + NRM_VID);
DAY_TEXT = OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "DWA").Substring(1, 2);
if (DAY_TEXT == "MO") {
PRINT(AT(COL - 1, ROW) + SCREEN_BACK + UND_VID);
} else {
PRINT(AT(COL - 1, ROW) + SCREEN_BACK + REV_UND_VID);
}
PRINT(AT(COL, ROW) + DAY_TEXT + " ");
PRINT(AT(COL + 3, ROW) + OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "D").Substring(1, 6));
PRINT(AT(COL + 9, ROW) + COLOR_C + FORMAT(DATE_NO, "R#3") + " ");
}
/*  Display session flags */
L0350();
return;
/* ******************************************** */
}
void L0175() {
/*   Calculate column and row for session * */
/*       flag display and/or data entry       * */
/* ******************************************** */
LEFTOVER = MOD(DATE_NO, DATES_PER_COL);
if (LEFTOVER == 0) {
COL_AMC = INT(DATE_NO / DATES_PER_COL);
} else {
COL_AMC = INT(DATE_NO / DATES_PER_COL) + 1;
}
COL = COLS[COL_AMC];
ROW = 5 + DATE_NO - (DATES_PER_COL * (COL_AMC - 1));
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
/*  'D'isplay or 'V'alidated */
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
/* *********************************************** */
}
void L0350() {
/*  Display session flags                    * */
/* *********************************************** */
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
if (SESSION_DATE_COUNT > 42) {
SESSION_DATE_COUNT = 42;
}
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
L0175();
/*  Set column and row */
PRINT(AT(COL + 15, ROW) + NRM_VID);
/*  Check for unavailable sessions and block them out */
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
// BEGIN CASE
// CASE
if (TEMP_REC[5][1, DATE_NO, FLAG_NO] == "Y") {
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}// CASE
else if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
PRINT(AT(FLAG_COL, ROW) + REV_VID + "X" + NRM_VID);
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD) {
PRINT(AT(FLAG_COL, ROW) + REV_VID + "B" + NRM_VID);
}// CASE
else if (OTHERWISE) {
PRINT(AT(FLAG_COL, ROW) + SPACE(2));
}
// END CASE
}
}
return;
}
void L0500() {
/*   SESSIONS Validation Routine */
DONE = FALSE;
FLAG_NO = 1;
do {
if (FLAG_NO > COURSE_DET_REC[COURSE_DET_SESSIONS] || DONE) break;
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y") {
FLAG_NO = FLAG_NO + 1;
}// CASE
else if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] < VACANCY_THRESHOLD && TEMP_REC[5][1, DATE_NO, FLAG_NO] == "") {
/*  No vacancies for this session on this day, and this */
/*  student doesn't already have a booking for it */
FLAG_NO = FLAG_NO + 1;
}// CASE
else if (OTHERWISE) {
FLAG_COL = COL + FLAG_LENGTH + (2 * FLAG_NO) + 10;
PRINT(AT(FLAG_COL, ROW) + NRM_VID);
INPUT(out ANS2, 2);
if (LEN(ANS2) > 1) { PRINT(AT(-9) + " "); ANS2 = ANS2.Substring(1, 1); }
ANS2 = OCONV(ANS2, "MCU");
// BEGIN CASE
// CASE
if (ANS2 == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
DONE = TRUE;
}// CASE
else if (ANS2 == "") {
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
INTERACT = VALID_DATA;
FLAG_NO = FLAG_NO + 1;
}// CASE
else if (ANS2 == COMMON.BACK && FLAG_NO == 1) {
INTERACT = INVALID_DATA;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
DONE = TRUE;
}// CASE
else if (ANS2 == COMMON.BACK && FLAG_NO > 1) {
INTERACT = VALID_DATA;
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
FLAG_NO = FLAG_NO - 1;
}// CASE
else if (ANS2 == "Y") {
INTERACT = VALID_DATA;
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "Y";
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
FLAG_NO = FLAG_NO + 1;
}// CASE
else if (ANS2 == COMMON.CLR || ANS2 == "N") {
INTERACT = VALID_DATA;
TEMP_REC[5][1, DATE_NO, FLAG_NO] = "";
ANS2 = "";
/*  The + 1 in the following line represents the place we just */
/*  released. Without refreshing the field here based on the */
/*  vacancy threshold you can get a situation where the field */
/*  is blank on-screen, but is inaccessible due to 0500* checking */
/*  the vacancy threshold before allowing access */
if (COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO] + 1 < VACANCY_THRESHOLD) {
PRINT(AT(FLAG_COL, ROW) + REV_VID + "B" + NRM_VID);
} else {
PRINT(AT(FLAG_COL, ROW) + FORMAT(TEMP_REC[5][1, DATE_NO, FLAG_NO], "L#2"));
}
FLAG_NO = FLAG_NO + 1;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
}
// END CASE
} while (true);
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
#region INCLUDE FL.PROCESSING FL789.VALIDATION

}
void L1000() {
/*   Course Code Validation Routine */
INTERACT = VALID_DATA;
// BEGIN CASE
/*  Scan for required course if the 'help' key is entered */
// CASE
if (ANS == COMMON.HELP && AMENDING == FALSE) {
DISPLAY_MODE = 6;
STUDENT_SCAN_ID = "";
FL717 = new FL717(ref DISPLAY_MODE, ref STUDENT_SCAN_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
/*  Refresh screen */
L0100();
REDISPLAY = "";
if (INTERACT != EXIT) {
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
ANS = COURSE_ID;
MAIN_KEY = ANS;
/*  DJA 17/7/95 */
nrf0 = ZZZ_STATUS;
CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
if (ZZZ_STATUS == TRUE) {
nrf0 = 32;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
ANS = "";
MAIN_KEY = "";
VALUE = "";
} else {
PROG_MESS[2] = COURSE_ID;
PROG_MESS[3] = COURSE_DATE;
DETAILS_ID = COURSE_DATE + "*" + MAIN_KEY;
if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) { MAT(ref COURSE_MSTR_REC, ""); }
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "A") {
/*  Not an activity day course */
INTERACT = INVALID_DATA;
PROG_MESS[2] = "";
VALUE = "";
nrf0 = 54;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
} else {
if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 3;
L6000();
/*  Display selected field data */
COMMENT_MODE = 1;
nrf0 = COURSE_DET_REC[COURSE_DET_COMMENTS];
FL793 = new FL793(ref COMMENT_MODE, ref nrf0, ref REDISPLAY_START_ROW, ref REDISPLAY_END_ROW);
for(ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1) {
PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
}
L0150();
/*  Display session dates */
OLD_COURSE_DATE = COURSE_DATE;
L0300();
if (INTERACT == INVALID_DATA) {
ANS = "";
MAIN_KEY = "";
VALUE = "";
PROG_MESS[2] = "";
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
}
}
/*  DJA 17/7/95 - Course was locked */
}
} else {
ANS = "";
MAIN_KEY = "";
VALUE = "";
PROG_MESS[2] = "";
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
/*  DJA 17/7/95 */
nrf0 = ZZZ_STATUS;
CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
if (ZZZ_STATUS == TRUE) {
nrf0 = 32;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
ANS = "";
MAIN_KEY = "";
VALUE = "";
} else {
PROG_MESS[2] = MAIN_KEY;
if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) {
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
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "A") {
/*  Not an activity day course */
INTERACT = INVALID_DATA;
nrf0 = 54;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PROG_MESS[2] = "";
MAIN_KEY = "";
AMENDING = FALSE;
VALUE = "";
} else {
L8000();
/*  Build Temp.Rec */
/*  Deal with display-only fields */
START_FIELD = 2;
END_FIELD = 3;
L6000();
/*  Display selected field data */
COMMENT_MODE = 1;
nrf0 = COURSE_DET_REC[COURSE_DET_COMMENTS];
FL793 = new FL793(ref COMMENT_MODE, ref nrf0, ref REDISPLAY_START_ROW, ref REDISPLAY_END_ROW);
for(ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1) {
PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
}
L0150();
/*  Display session dates */
AMENDING = FALSE;
OLD_COURSE_DATE = SELECT_DATE;
if (INTERACT == INVALID_DATA) {
ANS = "";
MAIN_KEY = "";
VALUE = "";
PROG_MESS[2] = "";
}
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 3;
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
MAIN_KEY = "";
PROG_MESS[2] = "";
AMENDING = FALSE;
VALUE = "";
}
/*  DJA 17/7/95 - Course was locked */
}
if (INTERACT != INVALID_DATA) {
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
}
} else {
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
/* *         PRINT SCREEN.FOOT.BACK:SCREEN.FOOT.FORE: */
PRINT(AT(0, 23) + NRM_VID + SPACE(78));
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
/* ********************************************************* */
L1050:;
/*  Link to waiting lists                              * */
/* ********************************************************* */
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
PRINT(AT(2, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
INPUT_LINE = "  No vacancies.  Do you wish to put them on the waiting list? ";
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "Y") {
ACTIVITY_CODE = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
CONCESSION = TICKET_CONCESS;
/*  Check whether the waiting list is full */
if (!READV(ref MAX_PLACES, FL_COURSE_PARAMS, "COURSE.PARAMS", 10)) { MAX_PLACES = 999999; }
MAX_PLACES = MAX_PLACES[1, 1];
if (MAX_PLACES == "") { MAX_PLACES = 999999; }
if (!READV(ref MASTER_LIST, FL_WAIT_MASTER, ACTIVITY_CODE, 1)) { MASTER_LIST = ""; }
PLACES_TAKEN = DCOUNT(MASTER_LIST, VM);
if (PLACES_TAKEN >= MAX_PLACES) {
nrf0 = 43;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
FL734 = new FL734(ref ACTIVITY_CODE, ref DISPLAY_MODE, ref PASSED_STUDENT_ID, ref STUDENT_REC, ref CONCESSION, ref INTERACT);
}
L0100();
START_FIELD = 1;
END_FIELD = 11;
L6000();
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "N") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
NULL();
}
// END CASE
} while (true);
/*  Reprompt for key field, whatever the response was */
INTERACT = INVALID_DATA;
ANS = "";
VALUE = "";
return;
}
void L1200() {
/*   DUMMY Validation Routine (Display only fields) */
INTERACT = VALID_DATA;
return;
}
void L1300() {
/*   STUDENT OR MEMBER NO Validation Routine */
STUDENT_IS_MEMBER = FALSE;
INITIAL_ENROL_SESSIONS = "";
MAT(ref ENROL_REC, "");
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
L0150();
/*  Display session dates */
REDISPLAY = "";
}
ANS = OCONV(ANS, "MCU");
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT) {
INTERACT = INVALID_DATA;
ANS = "";
}// CASE
else if ((ANS == "N" || ANS == "W") && COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE) {
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "N") {
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
if (PROG_MESS[1] == COMMON.ABANDON) {
/*  User aborted creation of student */
PROG_MESS[1] = 1;
/*  page no */
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
ANS = STUDENT_ID;
L8500();
/*  Update temp.rec with student data */
INTERACT = VALID_DATA;
}
// END CASE
/*  Refresh screen */
L0100();
START_FIELD = 1;
END_FIELD = 5;
L6000();
/*  Display selected field data */
L0150();
/*  Display session dates */
}// CASE
else if (ANS == "W") {
/*  Select a student from the waiting list */
CREATION_ALLOWED = FALSE;
if (MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE])) {
STUDENT_LIST = WAIT_MAST_REC[WAIT_MAST_IDS];
STATUS_LIST = WAIT_MAST_REC[WAIT_MAST_STATUS];
ACTIVITY = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
FL735 = new FL735(ref ACTIVITY, ref STUDENT_LIST, ref STATUS_LIST, ref NEW_STUDENT, ref CREATION_ALLOWED, ref STUDENT_ID, ref INTERACT, ref REDISPLAY);
L0100();
START_FIELD = 1;
END_FIELD = 3;
L6000();
/*  Display COURSE data */
L0150();
/*  Display session dates */
REDISPLAY = "";
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
/*  User aborted waiting list box */
PROG_MESS[1] = 1;
/*  page no */
INTERACT = INVALID_DATA;
RELEASE();
}// CASE
else if (OTHERWISE) {
ANS = STUDENT_ID;
INTERACT = VALID_DATA;
}
// END CASE
if (INTERACT == VALID_DATA) {
WAIT_LIST_ENROLMENT = TRUE;
L1325();
/*  Locate student details and enrol them */
if (INTERACT == VALID_DATA) { WAITING_LIST_ENROLMENT = TRUE; }
}
} else {
/*  Tell user there is no waiting list for this activity */
nrf0 = 25;
nrf1 = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}// CASE
else if (ANS == NAME_INDEX_REQUEST || ANS == SOUND_INDEX_REQUEST || ANS == ADDRESS_INDEX_REQUEST) {
SEARCH_ROUTE = ANS;
MEMBER_NUMBER = "";
FL000_20 = new FL000_20(ref MEMBER_NUMBER, ref SEARCH_ROUTE);
if (MEMBER_NUMBER == "") {
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
if (!(LOCATE(MEMBER_NUMBER, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref STUDENT_POS, "AL"))) {
if (COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE) {
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
if (INTERACT == VALID_DATA) {
INTERACT = INVALID_DATA;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER_NUMBER)) {
AMENDING = FALSE;
STUDENT_IS_MEMBER = TRUE;
INTERACT = VALID_DATA;
ANS = MEMBER_NUMBER;
/*  DJA 6.11.00  Don't call 1350 if member is already a student */
/*               or course history will be blown away */
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, MEMBER_NUMBER)) {
L1325();
/*  Will read student rec again - not ideal */
} else {
L2000();
/*  Check membership status */
L1350();
/*  Turn members details into a student record IF NEW STUDENT */
}
/*  DJA 28.4.00 */
if (DISPLAY_PHOTO) {
nrf0 = 64;
nrf1 = 10;
FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
}
/*  DJA 10.6.04 */
FL535 = new FL535(ref MEMBER_NUMBER, ref PROGRAM);
STUDENT_ID = MEMBER_NUMBER;
}
}
}
PRINT(AT(0, 23) + NRM_VID + SPACE(78));
}// CASE
else if (OTHERWISE) {
WAIT_LIST_ENROLMENT = FALSE;
L1325();
}
// END CASE
return;
/* ********************************************************************* */
}
void L1325() {
/*   Read in student info and enrol them on the course             * */
/* ********************************************************************* */
/*  See if student already exists */
CROSS_REFERENCED = FALSE;
if (SMART_CARD) {
if (READV(ref TEST_MEMBER_NO, FL_APACS_NUMBERS, ANS, 1)) {
CROSS_REFERENCED = TRUE;
APACS_NO = ANS;
ANS = TEST_MEMBER_NO;
}
}
PADDED_ANS = ANS;
if (NOT(CROSS_REFERENCED)) {
/*  Treat unrecognised APACS numbers as non-member students */
if (SMART_CARD && MATCH(ANS,"16N")) {
NULL();
/*  No action required */
} else {
if (NOT(MATCH(ANS.Substring(1, 1),"1A"))) {
FL000_40 = new FL000_40(ref PADDED_ANS);
}
}
}
STUDENT_IS_MEMBER = FALSE;
STUDENT_EXISTS = FALSE;
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, ANS)) {
STUDENT_EXISTS = TRUE;
} else {
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, PADDED_ANS)) {
STUDENT_EXISTS = TRUE;
ANS = PADDED_ANS;
VALUE = ANS;
}
}
if (STUDENT_EXISTS) {
/*  Validate student isn't already enrolled on this course. */
if (LOCATE(ANS, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref STUDENT_POS, "AL")) {
STUDENT_ID = ANS;
ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
INITIAL_ENROL_SESSIONS = ENROL_REC[ENROL_SESSIONS];
/*  Critical for vacancy updates */
L8500();
/*  Update temp.rec with student data */
START_FIELD = 5;
END_FIELD = 5;
L6000();
/*  Display selected field data */
INTERACT = INVALID_DATA;
STUDENT_ID = ANS;
do {
if (!(INTERACT == INVALID_DATA)) break;
PRINT(AT(78, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 21) + SPACE(76));
PRINT(AT(2, 21) + " Student is already enrolled.  'R'emove or 'A'mend? ");
INPUT(out REPLY, 2);
REPLY = OCONV(REPLY, "MCU");
PRINT(AT(2, 21) + SPACE(74));
// BEGIN CASE
// CASE
if (REPLY == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (REPLY == "A") {
L0150();
INTERACT = VALID_DATA;
}// CASE
else if (REPLY == "R" && BASKET_COUNT > 0) {
nrf0 = 85;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (REPLY == "R") {
PRINT(AT(2, 21) + " Are you sure you wish to un-enrol this student? (YES/return) ");
INPUT(out RESPONSE, 4);
if (RESPONSE == "YES" || RESPONSE == "yes") {
L0057();
/*  What transactions already exist for this course */
L4000();
/*  Disenrolment updates */
COURSE_BALANCE = EXISTING_PAYMENT_TOTAL + EXISTING_REFUND_TOTAL + EXISTING_ADJUST_TOTAL;
CONV_COURSE_BALANCE = OCONV(COURSE_BALANCE, "MD2");
if (COURSE_BALANCE != 0) {
nrf0 = 70;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref CONV_COURSE_BALANCE);
}
COMMENTS = STUDENT_REC[STUDENT_COMMENT1] + VM + STUDENT_REC[STUDENT_COMMENT2] + VM + STUDENT_REC[STUDENT_COMMENT3] + VM + STUDENT_REC[STUDENT_COMMENT4];
COMMENT_MODE = 2;
/*  Student comments */
FL793 = new FL793(ref COMMENT_MODE, ref COMMENTS, ref REDISPLAY_START_ROW, ref REDISPLAY_END_ROW);
if (REDISPLAY_START_ROW > 1) {
for(ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1) {
PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
}
L0150();
}
START_FIELD = 3;
END_FIELD = 3;
L6000();
START_FIELD = 5;
END_FIELD = 5;
TEMP_REC[12] = "";
/*  Name */
L6000();
if (SMART_CARD) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
} else {
INTERACT = FINISH;
}
}
PRINT(AT(78, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 21) + SPACE(76));
}// CASE
else if (OTHERWISE) {
NULL();
}
// END CASE
} while (true);
} else {
INTERACT = VALID_DATA;
if (COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE) {
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
if (INTERACT != VALID_DATA) {
/*  Go round again & get next student if */
/*  you have just unenrolled one */
if (INTERACT == FINISH) {
INTERACT = INVALID_DATA;
} else {
PROG_MESS[1] = COMMON.ABANDON;
INTERACT = EXIT;
}
} else {
/*  Existing student, but new enrolment as far as this course is concerned */
/*  If student is also a member the member no. may help ascertain the */
/*  concession. */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ANS)) {
MEMBER_NUMBER = ANS;
L2000();
/*  Check membership status */
} else {
MEMBER_NUMBER = "";
}
STUDENT_ID = ANS;
/*  If brand new enrolment, check the balance on other courses */
if (!(LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref STUDENT_POS, "AL"))) {
COURSE_DEBT = 0;
TRANS_COUNT = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
for(TC = 1; TC <= TRANS_COUNT; TC += 1) {
COURSE_DEBT = COURSE_DEBT + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TC];
}
// BEGIN CASE
// CASE
if (COURSE_DEBT > 0) {
nrf0 = 42;
nrf1 = OCONV(COURSE_DEBT, "MD2");
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (COURSE_DEBT < 0) {
nrf0 = 44;
nrf1 = OCONV(COURSE_DEBT, "MD2");
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
}
INTERACT = VALID_DATA;
L8500();
/*  Update temp rec with student info. */
START_FIELD = 5;
END_FIELD = 5;
L6000();
/*  DJA 28.4.00 */
if (DISPLAY_PHOTO) {
if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], MEMBER_NUMBER)) {
nrf0 = 64;
nrf1 = 10;
FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
}
}
/*  DJA 10.6.04 */
FL535 = new FL535(ref MEMBER_NUMBER, ref PROGRAM);
AMENDING = FALSE;
}
} else {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], PADDED_ANS)) {
/*  DJA 25.7.01 */
if (COURSE_DET_REC[COURSE_DET_CLOSE_DATE] < TODAYS_DATE) {
INTERACT = INVALID_DATA;
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
ANS = PADDED_ANS;
MEMBER_NUMBER = ANS;
STUDENT_IS_MEMBER = TRUE;
L1350();
/*  Create a student record from a member record */
L2000();
/*  Check membership status */
INTERACT = VALID_DATA;
AMENDING = FALSE;
STUDENT_ID = ANS;
}
} else {
if (WAIT_LIST_ENROLMENT == TRUE) {
/*  Retrieve details from the waiting list */
if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, ANS)) {
MAT(ref STUDENT_REC, "");
NEW_STUDENT = TRUE;
/*  DJA 31.07.00. If the waiting list student is a member, */
/*                then most of the following fields are */
/*                null on FL.WAIT.STUDENTS anyway */
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
START_FIELD = 5;
END_FIELD = 5;
L6000();
/*  Display selected field data */
AMENDING = FALSE;
MEMBER_NUMBER = "";
} else {
nrf0 = 26;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
} else {
/* ------------------ */
/*  Unrecognised APACS numbers will land here. Treat them as */
/*  a student Id for a new non-member student. Go to Student */
/*  Maintenance to gather personal details */
if (MATCH(ANS,"16N")) {
MAT(ref STUDENT_REC, "");
NEW_STUDENT = TRUE;
PROTECTED_PROG_MESS = PROG_MESS;
PROG_MESS[2] = ANS;
FL710 = new FL710(ref STUDENT_REC, ref NEW_STUDENT);
STUDENT_ID = PROG_MESS[2];
/*  May have changed if duplicate details detected */
FL710_FEEDBACK = PROG_MESS[1];
PROG_MESS = PROTECTED_PROG_MESS;
ANS = STUDENT_ID;
/*  Now establish the concession rate for this NEW student */
if (FL710_FEEDBACK == COMMON.ABANDON) {
/*  Full abandon, otherwise smartcard number will be re-read */
/*  and user will land straight back in Student Maintenance, */
/*  which they've just tried to abandon */
INTERACT = EXIT;
} else {
INTERACT = VALID_DATA;
L8500();
/*  Refresh screen */
L0100();
START_FIELD = 1;
END_FIELD = 5;
L6000();
/*  Display selected field data */
L0150();
}
} else {
/* ------------------ */
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
/* ------- */
}
/* ------- */
}
}
}
return;
/* ******************************************************* */
}
void L1350() {
/*   CREATE A STUDENT RECORD FROM A MEMBERS ONE      * */
/* ******************************************************* */
STUDENT_ID = MEMBER_NUMBER;
MAT(ref STUDENT_REC, "");
L8500();
/*  Update temp.rec with student data */
START_FIELD = 5;
END_FIELD = 5;
L6000();
/*  Display selected field data */
if (DISPLAY_PHOTO) {
nrf0 = 64;
nrf1 = 10;
FL_PHOTO = new FL_PHOTO(ref MEMBER_NUMBER, ref nrf0, ref nrf1);
}
/*  DJA 10.6.04 */
FL535 = new FL535(ref MEMBER_NUMBER, ref PROGRAM);
return;
}
void L1500() {
/*   PAYMENT */
ST_CONVERSION = "MD2";
/* !*CRT "<<<":DEFAULT.PAYMENT:"  COURSE.BALANCE=":COURSE.BALANCE:">>>":;INPUT FLEX,2: */
if (ANS == "" && DEFAULT_PAYMENT == "Y") { ANS = OCONV(COURSE_BALANCE, "MD2"); }
CONV_ANS = ICONV(ANS, ST_CONVERSION);
// BEGIN CASE
// CASE
if (NOT(NUM(ANS)) || (ANS != "" && CONV_ANS == "")) {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS < 0) {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS > COURSE_BALANCE) {
/*  Payment exceeds course fee */
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (PREVENT_PP_AND_INSTALMENTS == "Y" && CONV_ANS > 0 && CONV_ANS < COURSE_BALANCE) {
nrf0 = 47;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (PREVENT_ZERO_PAYMENTS == "Y" && CONV_ANS == 0) {
nrf0 = 58;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
/*  Establish method of payment, generate transaction & update temp.rec */
}
// END CASE
if (INTERACT == VALID_DATA) {
TICKET_REC[TICK_TOTAL] = CONV_ANS;
TICKET_REC[TICK_UNIT_PRICE] = CONV_ANS;
/* ********************** */
/*  BONUS REDEMPTION    * */
/* ********************** */
if (CONV_ANS > 0 && STUDENT_IS_MEMBER && CURRENT_PROMOTIONS != "") {
BONUS_REDEEM_REC = "";
nrf0 = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
nrf1 = "CO";
nrf2 = 1;
CallAt_BONUS_REDEEM_PROG = new CallAt_BONUS_REDEEM_PROG(ref BONUS_REDEEM_PROG, ref STUDENT_ID, ref nrf0, ref nrf1, ref CONV_ANS, ref nrf2, ref BONUS_REDEEM_REC, ref CURRENT_PROMOTIONS, ref TOTAL_REDEMPTION, ref TOTAL_POINTS, ref PROMOTION);
if (TOTAL_REDEMPTION > 0) {
NEW_PRICE = TICKET_PRICE - TOTAL_REDEMPTION;
/* !*           TEMP.REC(17) = NEW.PRICE */
TEMP_REC[23] = NEW_PRICE;
/*  Revised again below */
/* !*           TEMP.REC(29) = NEW.PRICE */
TEMP_REC[41] = TOTAL_REDEMPTION;
TEMP_REC[42] = TOTAL_POINTS;
/*  Adjust payment amount */
CONV_ANS = CONV_ANS - TOTAL_REDEMPTION;
ANS = OCONV(CONV_ANS, "MD2");
TICKET_REC[TICK_TOTAL] = CONV_ANS;
TICKET_REC[TICK_UNIT_PRICE] = CONV_ANS;
}
}
/* ********************** */
/*  BONUS REDEMPTION    * */
/* ********************** */
TEMP_REC[18] = CONV_ANS;
TEMP_REC[29][1, 2] = -CONV_ANS;
TEMP_REC[23] = COURSE_BALANCE - CONV_ANS;
}
return;
}
void L1700() {
/*  Post Processing */
RECEIPT_NO = "";
/*  Dealing with payment and receipt if necessary */
MAT(ref TICKET_REC, "");
/*  Initialises TICK.MOP automatically */
TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
/*  Ticket record does not cater for multiple fees contributing to one transaction */
TICKET_REC[TICK_UNIT] = 1;
TICKET_REC[TICK_UNIT_PRICE] = TEMP_REC[18];
TICKET_REC[TICK_DATE] = TODAYS_DATE;
TICKET_REC[TICK_TIME] = TIME();
TICKET_REC[TICK_TOTAL] = TEMP_REC[18] + 0;
TICKET_REC[TICK_CLERK] = U_INITS;
TICKET_REC[TICK_TILL] = TILL_NUMBER;
TICKET_REC[TICK_CONCESS] = TEMP_REC[24];
/*  DJA 12.8.02 */
/* !*  IF COURSE.MSTR.CENTRE # CENTRE THEN */
/* !*     TICK.HOME.CENTRE = COURSE.MSTR.CENTRE */
/* !*  END */
TICKET_REC[TICK_HOME_CENTRE] = COMMON.CENTRE;
if (STUDENT_IS_MEMBER) {
TICKET_REC[TICK_MEMBER] = STUDENT_ID;
}
TICKET_REC[TICK_STUDENT_ID] = STUDENT_ID;
TICKET_REC[TICK_COURSE_DETAILS_ID] = PROG_MESS[3] + "*" + PROG_MESS[2];
if (TICKET_REC[TICK_TOTAL] == 0) {
/*  MOP Irrelevant */
INTERACT = VALID_DATA;
MOP = "";
} else {
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
/* *         PRINT @(78,23):NRM.VID: */
PRINT(AT(2, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 21) + SPACE(76));
if (ALLOW_MULTIPAY != "N") {
if (EPURSE_ROUTINE == "") {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay or other mop" + SPACE(1);
} else {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay, 'EP'urse" + SPACE(1);
}
} else {
if (EPURSE_ROUTINE == "") {
/*                  PRINT FOOT.MESS = " <RETURN> for cash, ":MOP.TYPES<2>:" for cheque or other mop":SPACE(1) */
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque or other mop" + SPACE(1);
} else {
/*                  PRINT FOOT.MESS = " <RETURN> for cash, ":MOP.TYPES<2>:" for cheque, 'EP'urse":SPACE(1) */
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'EP'urse" + SPACE(1);
}
}
PRINT(AT(2, 21) + FOOT_MESS);
PRINT(AT(LEN(FOOT_MESS) + 2, 21));
INPUT(out MOP, 5);
// BEGIN CASE
// CASE
if (MOP == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (MOP == "M" && ALLOW_MULTIPAY == "N") {
INTERACT = INVALID_DATA;
}// CASE
else if (MOP == "M" && BASKET_COUNT >= 16) {
nrf0 = 81;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (MOP == "M") {
/*  Multi-pay. File no payment. */
INTERACT = VALID_DATA;
PROG_MESS[30] = MAIN_KEY;
PROG_MESS[31] = PROG_MESS[3];
PROG_MESS[32] = STUDENT_ID;
PROG_MESS[33] = TICKET_REC[TICK_TOTAL] + 0;
TICKET_REC[TICK_TOTAL] = 0;
TICKET_REC[TICK_UNIT_PRICE] = 0;
TEMP_REC[23] = TEMP_REC[17];
L0120();
}// CASE
else if (BASKET_COUNT > 0) {
nrf0 = 82;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (MOP == "") {
/*  Cash */
INTERACT = VALID_DATA;
TICKET_REC[TICK_MOP] = "C";
}// CASE
else if (MOP == MOP_TYPES[2]) {
/*  Cheque */
TICKET_REC[TICK_MOP] = MOP;
INTERACT = INVALID_DATA;
if (CHEQUE_PROMPT == "Y") {
do {
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
if (MATCH(CHQ_NO,"6N")) {
INTERACT = VALID_DATA;
CC_REF = CHQ_NO;
/*  OK, its a lazy cheat */
TICKET_REC[TICK_CC_REF] = CC_REF;
}// CASE
else if (CHQ_NO == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
} while (true);
} else {
INTERACT = VALID_DATA;
}
if (INTERACT == EXIT) { INTERACT = INVALID_DATA; /*  Reprompt for MOP */ }
PRINT(AT(79, 23) + NRM_VID + AT(0, 23) + NRM_VID + SPACE(78));
}// CASE
else if (MOP == MOP_TYPES[3]) {
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
/* <EFT */
if (EFT_SITE) {
CC_AUTH = INIT;
CC_EXP = INIT;
CC_ISSUE = INIT;
CC_REF = INIT;
CC_START = INIT;
SWIPE_DETAILS = INIT;
PRINT(AT(2, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINTCR(AT(2, 21) + SPACE(76) + AT(2, 21) + "Enter CC Reference & Expiry");
nrf0 = 55;
nrf1 = 20;
nrf2 = 35;
FL361_EFT = new FL361_EFT(ref nrf0, ref nrf1, ref CC_REF, ref CC_EXP, ref CC_AUTH, ref nrf2, ref EFT_SITE, ref SWIPE_DETAILS, ref CC_START, ref CC_ISSUE, ref CARD_CVS);
/*  Restore the footer which RT has probably cut chunks out of */
for(ROW = 20; ROW <= 21; ROW += 1) {
PRINT(AT(0, ROW) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, ROW) + SPACE(76));
}
if (CC_REF == COMMON.ABANDON) {
RET_FUNC = COMMON.ABANDON;
} else {
EFT_CONF = "Student : " + MAIN_KEY;
EFT_AMOUNT = TICKET_REC[TICK_TOTAL] + 0;
FL_EFT = new FL_EFT(ref SWIPE_DETAILS, ref CC_REF, ref CC_EXP, ref CC_ISSUE, ref CC_START, ref EFT_AMOUNT, ref EFT_CONF, ref RET_FUNC, ref PROGRAM, ref CARD_CVS);
if (RET_FUNC != VALID_DATA) {
RET_FUNC = COMMON.ABANDON;
}
}
/* EFT! */
} else {
FL361_1 = new FL361_1(ref CC_REF, ref CC_EXP, ref RET_FUNC);
}
/* EFT > */
if (RET_FUNC == COMMON.ABANDON) {
INTERACT = INVALID_DATA;
/*  Clear credit card prompt */
/* *               PRINT @(2,21):SCREEN.FOOT.FORE:SCREEN.FOOT.BACK:SPACE(76): */
} else {
INTERACT = VALID_DATA;
TICKET_REC[TICK_MOP] = MOP;
TICKET_REC[TICK_CC_REF] = CC_REF;
TICKET_REC[TICK_CC_EXP] = CC_EXP;
/* <EFT */
if (EFT_SITE) {
TICKET_REC[TICK_EFT_SEQNO] = EFT_CONF[1] + VM + EFT_CONF[2] + VM + EFT_CONF[3];
TICKET_REC[TICK_EFT_SWIPE] = SWIPE_DETAILS + VM + CC_START + VM + CC_ISSUE;
}
/* EFT> */
}
/*  EPurse */
}// CASE
else if (MOP == "EP" && SMART_CARD) {
IFACE_TYPE = 2;
TRANS_ID = "";
TRANS_TYPE = "E";
TRANS_AMOUNT = TICKET_REC[TICK_TOTAL];
if (MATCH(STUDENT_ID,"16N")) {
/*  Unrecognised APACS number */
PASSED_MEMBER_NO = "";
} else {
PASSED_MEMBER_NO = STUDENT_ID;
}
SMART_DISPLAY_MODE = FWTERM_MODE;
CARD_ERROR_TYPE = 34;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref PASSED_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
if (SMARTCARD_INTERACT != VALID_DATA) {
nrf0 = 301;
nrf1 = CARD_ERROR_TYPE + " (" + CARD_ERROR_MESS + ")";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
MAT(ref EPURSE_REC, "");
EPURSE_REC[EPURSE_APACS_NO] = APACS_NO;
EPURSE_REC[EPURSE_MEM_NO] = PASSED_MEMBER_NO;
EPURSE_REC[EPURSE_AMOUNT] = TRANS_AMOUNT;
/* FL00019 = new FL00019(ref EPURSE_REC, ref TRANS_ID); */
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
else if (OTHERWISE) {
AMC = 4;
NO_MOPS = DCOUNT(MOP_TYPES, AM);
MOP_FOUND = FALSE;
do {
if (MOP_FOUND || AMC > NO_MOPS) break;
if (MOP == MOP_TYPES[AMC]) {
TICKET_REC[TICK_MOP] = MOP;
MOP_FOUND = TRUE;
}
AMC = AMC + 1;
} while (true);
if (NOT(MOP_FOUND)) {
nrf0 = 10;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
}
}
// END CASE
} while (true);
/* *      PRINT @(0,23):NRM.VID:SPACE(78): */
}
if (INTERACT == VALID_DATA && MOP != "M") {
L8800();
/*  Update temp.rec transaction whether or not a receipt is required */
}
return;
/* ***************************************** */
}
void L2000() {
/*  Check membership type             * */
/* ***************************************** */
NO_EXPIRY_DATES = DCOUNT(MEMBERS_REC[MEMBER_EXPIRY_DATE], VM);
// BEGIN CASE
// CASE
if (MEMBERS_REC[MEMBER_EXPIRY_DATE] == "") {
NULL();
}// CASE
else if (NO_EXPIRY_DATES == 1) {
if (MEMBERS_REC[MEMBER_EXPIRY_DATE] <= TODAYS_DATE) {
nrf0 = 40;
nrf1 = OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE], "D");
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (OTHERWISE) {
TYPE_STRING = "";
for(N = 1; N <= NO_EXPIRY_DATES; N += 1) {
if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, N] <= TODAYS_DATE) {
if (TYPE_STRING == "") {
TYPE_STRING = MEMBERS_REC[MEMBER_TYPE][1, N];
} else {
TYPE_STRING = TYPE_STRING + "," + MEMBERS_REC[MEMBER_TYPE][1, N];
}
}
}
if (TYPE_STRING != "") {
nrf0 = 46;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref TYPE_STRING);
}
}
// END CASE
DEBTOR_ID = COMMON.CENTRE + "*" + MEMBER_NUMBER;
if (READ(ref TEST_REC, COMMON.FILES[FL_DEBTORS], DEBTOR_ID)) {
nrf0 = 41;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;

#endregion
/* ********************************************************** */
}
void L4000() {
/*   Disenrolment updates                               * */
/* ********************************************************** */
/*  student.pos = multivalue position on course.details */
COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = DELETE(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, STUDENT_POS, 0);
TEMP_REC[5] = "";
L4500();
/*  Update vacancies in temp.rec(3) */
COURSE_DET_REC[COURSE_DET_VACANCIES] = TEMP_REC[3];
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL")) {
STUDENT_REC[STUDENT_DETAIL_IDS] = DELETE(STUDENT_REC[STUDENT_DETAIL_IDS], 1, POS, 0);
}
/*  Currently this code just reverses the course fee.  Refunds will be required */
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "D";
/*  Disenrolment */
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -EXISTING_FEE_TOTAL;
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - EXISTING_FEE_TOTAL;
/*  Recall any bonus points which were awarded on enrolment */
CONTRA_TICKET_REQUIRED = FALSE;
/*  Reconstruct ticket record to support the call to FL165 */
TICK_REC = "";
/*  Ticket structure does not support multiple fee codes */
TICK_REC[1] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICK_REC[2] = 1;
/*  Units */
TICK_REC[3] = -ENROL_REC[ENROL_PRICE][1, 1];
/*  Fee */
TICK_REC[4] = TODAYS_DATE;
TICK_REC[5] = TIME();
TICK_REC[6] = ENROL_REC[ENROL_PRICE][1, 1] + 0;
/*  Total */
TICK_REC[8] = U_INITS;
/*  Clerk */
TICK_REC[9] = TILL_NUMBER;
TICK_REC[10] = STUDENT_ID;
/*  Membership number */
PERIOD = 1;
/*  Peak */
TICK_REC[11] = PERIOD;
TICK_REC[13] = ENROL_REC[ENROL_CONCESSION][1, 1];
/*  DJA 12.8.02 */
/* !*  IF COURSE.MSTR.CENTRE # CENTRE THEN */
/* !*    TICK.REC<34> = COURSE.MSTR.CENTRE */
/* !*  END */
TICK_REC[34] = COMMON.CENTRE;
if (STUDENT_IS_MEMBER && ENROL_REC[ENROL_BONUS_AWARD] > 0) {
CONTRA_TICKET_REQUIRED = TRUE;
TODAYZ_DATE = TODAYS_DATE;
CALL_REF = "MCOURSES";
/*  FL165 updates tick.rec <24> and <25> */
/*  FL165 takes the ticket fee, and therefore the bonus, from */
/*  tick.rec which currently cannot deal with multiple fee */
/*  codes (i.e. up to 5 in activity days) */
FL165 = new FL165(ref TICK_REC, ref TODAYZ_DATE, ref PERIOD, ref CALL_REF);
}
/*  Reverse any bonus redemptions */
if (STUDENT_IS_MEMBER && ENROL_REC[ENROL_TOTAL_REDEMPTION] > 0) {
CONTRA_TICKET_REQUIRED = TRUE;
TICK_REC[25] = ENROL_REC[ENROL_PROMOTION];
TICK_REC[27] = -ENROL_REC[ENROL_TOTAL_REDEMPTION];
TICK_REC[28] = -ENROL_REC[ENROL_TOTAL_POINTS];
nrf0 = ENROL_REC[ENROL_TOTAL_POINTS];
nrf1 = ENROL_REC[ENROL_TOTAL_REDEMPTION];
nrf2 = ENROL_REC[ENROL_PROMOTION];
FL795 = new FL795(ref STUDENT_ID, ref nrf0, ref nrf1, ref nrf2);
}
if (CONTRA_TICKET_REQUIRED) {
/*  Write the ticket record for bonus point reconciliation */
TICK_ID = "";
SESSION_NO = "";
/*  DJA 12.8.02 */
if (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != "" && COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != COMMON.CENTRE && CENTRALISED_COURSES == "Y") {
PROG_MESS[24] = COURSE_MSTR_REC[COURSE_MSTR_CENTRE];
}
nrf0 = "";
FL000_12 = new FL000_12(ref PROGRAM, ref TICK_ID, ref nrf0, ref SESSION_NO);
PROG_MESS[24] = "";
TICK_REC[16] = SESSION_NO;
/*  Zeroise ticket amounts */
TICK_REC[3] = 0;
TICK_REC[6] = 0;
WRITE(TICK_REC, COMMON.FILES[FL_TICKETS], TICK_ID);
}
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
DELETE(FL_ENROLMENT, ENROL_ID);
MAT(ref ENROL_REC, "");
L0350();
/*  Redisplay session dates in case slots have become bookable */
/*  Warn if there is a waiting list for this activity */
if (!READV(ref WAIT_MAST_REC[WAIT_MAST_IDS], FL_WAIT_MASTER, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], 1)) { WAIT_MAST_REC[WAIT_MAST_IDS] = ""; }
NO_WAITING = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
if (NO_WAITING > 0) {
nrf0 = 30;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
/* ************************************** */
}
void L4500() {
/*  Update vacancy details          * */
/* ************************************** */
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
for(DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1) {
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
INITIAL_VALUE = INITIAL_ENROL_SESSIONS[1, DATE_NO, FLAG_NO];
VALUE = TEMP_REC[5][1, DATE_NO, FLAG_NO];
// BEGIN CASE
// CASE
if (INITIAL_VALUE == "Y" && VALUE == "") {
/*  Free up one place */
TEMP_REC[3][1, DATE_NO, FLAG_NO] = TEMP_REC[3][1, DATE_NO, FLAG_NO] + 1;
}// CASE
else if (INITIAL_VALUE == "" && VALUE == "Y") {
/*  Remove one place */
TEMP_REC[3][1, DATE_NO, FLAG_NO] = TEMP_REC[3][1, DATE_NO, FLAG_NO] - 1;
}
// END CASE
}
}
return;
/* ******************************************************** */
}
void L5000() {
/*  Establish concession data for a newly enrolled    * */
/*      student                                           * */
/* ******************************************************** */
TICKET_CODE = "C*" + THIS_FEE_CODE;
TICKET_TYPE = "C";
/*  DJA 26.1.05 */
if (FEE_TODAY == "Y") {
SALE_DATE = TODAYS_DATE;
} else {
SALE_DATE = PROG_MESS[3];
}
SALE_TIME = TIME();
TICKET_CONCESS = "";
PERIOD = "";
TICKET_PRICE = "";
DISPLAY_LINE = "  Selecting fee for session " + FLAG_NO + "...";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + DISPLAY_LINE);
FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
FL048 = new FL048(ref TICK_FEES_REC, ref TICKET_PRICE, ref PERIOD, ref MEMBER_NUMBER, ref TICKET_CONCESS);
if (TICKET_CONCESS == "" || TICKET_PRICE == "") {
/*  Problem encountered or user abandoned */
INTERACT = INVALID_DATA;
}
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(35));
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
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = COURSE_MSTR_REC[COURSE_MSTR_DESC];
TEMP_REC[2] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
TEMP_REC[3] = COURSE_DET_REC[COURSE_DET_VACANCIES];
TEMP_REC[4] = PROG_MESS[3];
TEMP_REC[7] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
TEMP_REC[8] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
TEMP_REC[9] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
TEMP_REC[10] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
return;
/* ************************************************ */
}
void L8500() {
/*  Build student related temp.rec attributes * */
/* ************************************************ */
TEMP_REC[5] = ENROL_REC[ENROL_SESSIONS];
TEMP_REC[6] = ENROL_REC[ENROL_PRICE];
TEMP_REC[11] = STUDENT_ID;
/*  DJA 31.07.00 */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
MEMBER_NUMBER = STUDENT_ID;
STUDENT_IS_MEMBER = TRUE;
TEMP_REC[12] = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
TEMP_REC[13] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
} else {
TEMP_REC[12] = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
TEMP_REC[13] = STUDENT_REC[STUDENT_ADDRESS1];
}
return;
/* ***************************************************** */
}
void L8700() {
/*   Put enrolment/student details into temp.rec */
/*       (ORIGINAL DEBIT) */
/* ***************************************************** */
TEMP_REC[24] = TICKET_CONCESS;
/*  Concession description */
TEMP_REC[17] = TOTAL_FEE_PAYABLE;
/*  Enrolment price */
TEMP_REC[23] = COURSE_BALANCE;
/*  Balance */
/*  Temp.rec attributes relating to the student transaction fields */
/*  have two multivalues. <n,1> = Fee or Adjustment.  <n,2> = Payment */
TEMP_REC[26] = DETAILS_ID;
TEMP_REC[27] = TODAYS_DATE;
TEMP_REC[28] = "O";
/*  Original debit */
TEMP_REC[29] = FEE_ADJUSTMENT;
TEMP_REC[33] = U_INITS;
return;
/* *********************************************************** */
}
void L8800() {
/*   Put details of payment into temp.rec */
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
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
COURSE_DET_REC[COURSE_DET_VACANCIES] = TEMP_REC[3];
ENROL_REC[ENROL_CONCESSION] = CONC_LIST[1];
for(N = 2; N <= COURSE_DET_REC[COURSE_DET_SESSIONS]; N += 1) {
ENROL_REC[ENROL_CONCESSION][1, N] = CONC_LIST[N];
}
ENROL_REC[ENROL_SESSION_FEES] = FEE_LIST[1];
for(N = 2; N <= COURSE_DET_REC[COURSE_DET_SESSIONS]; N += 1) {
ENROL_REC[ENROL_SESSION_FEES][1, N] = FEE_LIST[N];
}
ENROL_REC[ENROL_SESSIONS] = TEMP_REC[5];
ENROL_REC[ENROL_PRICE] = TEMP_REC[6];
/*  Unlike standard courses, we need to cater for multiple */
/*  redemptions here, i.e. add them up! */
/*  Do these enrolment updates in the controller so we don't */
/*  lose the detail of the current redemption before we need */
/*  to write it on the ticket record */
MVC = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM) + 1;
NEW_ENROLMENT = FALSE;
if (!LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref STUDENT_POS, "AL")) { NEW_ENROLMENT = TRUE; }
PAYMENT_MVC = MVC;
/*  will be incremented if fee is inserted */
if (NEW_ENROLMENT || TEMP_REC[29][1, 1] != 0) {
if (TEMP_REC[26][1, 1] != "" && TEMP_REC[27][1, 1] != "" && TEMP_REC[28][1, 1] != "") {
/*  Mandatory fields are present */
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = TEMP_REC[26][1, 1];
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TEMP_REC[27][1, 1];
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = TEMP_REC[28][1, 1];
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = TEMP_REC[29][1, 1];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = TEMP_REC[30][1, 1];
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = TEMP_REC[31][1, 1];
PAYMENT_MVC = PAYMENT_MVC + 1;
}
}
/*  Is there any payment? */
if (TEMP_REC[29][1, 2] != 0) {
if (TEMP_REC[26][1, 2] != "" && TEMP_REC[27][1, 2] != "" && TEMP_REC[28][1, 2] != "") {
/*  Mandatory fields are present */
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, PAYMENT_MVC] = TEMP_REC[26][1, 2];
STUDENT_REC[STUDENT_TRANS_DATES][1, PAYMENT_MVC] = TEMP_REC[27][1, 2];
STUDENT_REC[STUDENT_TRANS_TYPES][1, PAYMENT_MVC] = TEMP_REC[28][1, 2];
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, PAYMENT_MVC] = TEMP_REC[29][1, 2];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, PAYMENT_MVC] = TEMP_REC[30][1, 2];
STUDENT_REC[STUDENT_TRANS_MOPS][1, PAYMENT_MVC] = TEMP_REC[31][1, 2];
}
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
