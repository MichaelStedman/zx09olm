//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL730 : UvBase
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
readonly UvVar INSUFFICIENT_FUNDS = 11;
readonly UvVar EXCEEDS_LIMIT = 12;
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
readonly UvVar FL_DEBTORS = 43;
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
readonly UvVar DD_DEBTORS_DATES = 1;
readonly UvVar DD_DEBTORS_OWED = 2;
readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
readonly UvVar DD_DEBTORS_REASON = 4;
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
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] TICKET_REC = new UvVar[40];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] DEBTORS_REC = new UvVar[100];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] DD_DEBTORS_REC = new UvVar[10];
UvVar[] CALENDAR_REC = new UvVar[10];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar REFUND_SCREEN = "";
UvVar SCREEN_CODE = "";
UvVar SCR_POS = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
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
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar AM = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar DOTS_ONLY = "";
UvVar JUST = "";
UvVar PROCESS_LOCKED = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_ENROLMENT = "";
UvVar N = "";
UvVar FL_MULTIPAY = "";
UvVar FL_DD_DEBTORS = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar FL_APACS_NUMBERS = "";
UvVar FL_INSTRUCTORS = "";
UvVar SMART_CARD = "";
UvVar EPURSE_ROUTINE = "";
UvVar TICKET_PRINT_ROUTINE = "";
UvVar MOP_TYPES = "";
UvVar MANUAL_RECEIPTS = "";
UvVar COMMENTS_PRINTED = "";
UvVar AUTO_FEE_REDUCTION = "";
UvVar CONCESS_MEMBER_CHANGE = "";
UvVar PREVENT_PP_AND_INSTALMENTS = "";
UvVar PREVENT_ZERO_PAYMENTS = "";
UvVar CENTRALISED_COURSES = "";
UvVar BATCH_HEADCOUNTS = "";
UvVar ALLOW_MULTIPAY = "";
UvVar CHEQUE_PROMPT = "";
UvVar FEE_TODAY = "";
UvVar PHOTO_CODES = "";
UvVar DISPLAY_PHOTO = "";
UvVar TEST_POS = "";
UvVar EFT_SITE = "";
UvVar PROMOTIONS_CONTROL = "";
UvVar CURRENT_PROMOTIONS = "";
UvVar BONUS_REDEEM_PROG = "";
UvVar COURSE_COMMENT_TAGS = "";
UvVar MAX_FIELDS = "";
UvVar DATA_FIELDS = "";
UvVar DISPLAY_ONLY_FIELDS = "";
UvVar ENTRY_FIELDS = "";
UvVar FIELD_COUNT = "";
UvVar BALANCE = "";
UvVar SWIPE_DETAILS = "";
UvVar ACTION = "";
UvVar MOP = "";
UvVar LINE = "";
UvVar POS = "";
UvVar DISPLAY_ALL_TRANSACTIONS = "";
UvVar PAYMENT_TOTAL = "";
UvVar TRANS_CNT = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar RECEIPT_REQUIRED = "";
UvVar CC_REF = "";
UvVar CHQ_NO = "";
UvVar EFT_CONF = "";
UvVar CC_ISSUE = "";
UvVar CC_START = "";
UvVar EFT_AMOUNT = "";
UvVar CC_EXP = "";
UvVar OLD_MAIN_KEY = "";
UvVar TRANS_LIST = "";
UvVar TOTAL_REDEMPTION = "";
UvVar TOTAL_POINTS = "";
UvVar BONUS_REDEEM_REC = "";
UvVar APACS_NO = "";
UvVar EPURSE_APACS_NO = "";
UvVar FIELD_NO = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
FL_HIDE_PHOTO FL_HIDE_PHOTO;
UvVar MULTIPAY_REC = "";
UvVar TRANS_COUNT = "";
UvVar MATCH_FOUND = "";
UvVar TRANS_NO = "";
FL006 FL006;
UvVar SUPP_ID = "";
UvVar NEW_SUPP_REC = "";
UvVar SUPP_REC = "";
UvVar COURSE_BALANCE = "";
UvVar TICK_ID = "";
UvVar STUDENT_NAME = "";
UvVar NARRATIVE = "";
UvVar COURSE_DATE = "";
UvVar NARR_MV = "";
UvVar FLAG_NO = "";
UvVar START_TIME = "";
UvVar END_TIME = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar FULL_INSTRUCTOR_NAME = "";
UvVar TICK_REC = "";
UvVar TEST_REC = "";
UvVar PERIOD = "";
UvVar DETAILS_ID = "";
UvVar PRINT_TICKET_NO = "";
UvVar SESSION_NO = "";
FL000_12 FL000_12;
UvVar STUDENT_IS_MEMBER = "";
FL165 FL165;
UvVar TODAYZ_DATE = "";
UvVar CALL_REF = "";
UvVar TOTAL_POINTS_REDEEMED = "";
FL277 FL277;
UvVar ENROL_ID = "";
FL102 FL102;
CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
FL000_15 FL000_15;
FL114 FL114;
UvVar NO_TRANS = "";
UvVar MVC = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar DISPLAY_MODE = "";
FL731 FL731;
UvVar STUDENT_ID = "";
UvVar REDISPLAY = "";
UvVar FIELD_DATA = "";
UvVar ST_DISPLAY = "";
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
FL_PHOTO FL_PHOTO;
UvVar NO_EXPIRY_DATES = "";
UvVar TYPE_STRING = "";
UvVar DEBTOR_ID = "";
FL535 FL535;
UvVar DD_ID = "";
UvVar CONTINUE = "";
UvVar YES_NO = "";
UvVar DD_DEBTOR_ID = "";
UvVar MEMSHP_START = "";
UvVar NEW_STUDENT = "";
UvVar SCAN_STUDENT_ID = "";
FL717 FL717;
UvVar COURSE_ID = "";
UvVar ACCESS_ALLOWED = "";
UvVar DATE_LIST = "";
UvVar CREATION_ALLOWED = "";
FL704 FL704;
UvVar NEW_COURSE = "";
UvVar COURSE_TEXT = "";
UvVar COURSE_TEXT2 = "";
UvVar TEXT_COL = "";
UvVar TEXT_JUST = "";
UvVar NO_DATES = "";
UvVar NEXT_DATE = "";
UvVar CONV_ANS = "";
UvVar PROMOTION = "";
CallAt_BONUS_REDEEM_PROG CallAt_BONUS_REDEEM_PROG;
UvVar ANS2 = "";
UvVar DISPLAY_LINE = "";
UvVar TICKET_CODE = "";
UvVar TICKET_TYPE = "";
UvVar SALE_DATE = "";
UvVar SALE_TIME = "";
UvVar TICKET_CONCESS = "";
UvVar TICKET_PRICE = "";
FL048 FL048;
UvVar MEMBER_NUMBER = "";
FL355 FL355;
UvVar PRICE = "";
UvVar RESPONSE = "";
UvVar ANS3 = "";
UvVar NEW_STUDENT_ID = "";
UvVar READ_AND_WRITE = "";
UvVar OLD_STUDENT_ID = "";
UvVar SUCCESS = "";
FL766 FL766;
UvVar ERROR_MESSAGE = "";
UvVar RECEIPT_NO = "";
UvVar FOOT_MESS = "";
UvVar RET_FUNC = "";
UvVar CC_AUTH = "";
FL361_EFT FL361_EFT;
UvVar CARD_CVS = "";
FL_EFT FL_EFT;
FL361_1 FL361_1;
UvVar EP_AMOUNT = "";
UvVar PASSED_MEMBER_NO = "";
UvVar EPURSE_MEM_NO = "";
UvVar EPURSE_AMOUNT = "";
UvVar AMC = "";
UvVar NO_MOPS = "";
UvVar MOP_FOUND = "";
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
public FL730(ref UvVar REFUND_SCREEN, ref UvVar SCREEN_CODE, ref UvVar SCR_POS) {
this.REFUND_SCREEN = REFUND_SCREEN;
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
/*     COURSE PAYMENTS AND REFUNDS - DUAL USE PROGRAM */
PROMPT("");
/*  the next two lines inserted for the smart card interface */
PROGRAM = "FL730";
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
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
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
#region INCLUDE FL.FILES FL.DEBTORS

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.DD.DEBTORS

if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

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
/*      INCLUDE FL.FILES FL.EPURSE.LOG */
/* !*     READV PCL.SMART.CARD FROM FL.CONTROL, 'PCL.SMART.CARD', 1 ELSE */
/* !*        PCL.SMART.CARD = FALSE */
/* !*     END */
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!(READV(ref EPURSE_ROUTINE, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 4))) {
EPURSE_ROUTINE = "";
}
MAT(ref MEMBERS_REC, "");
if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
if (!READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")) { MOP_TYPES = ""; }
if (!READV(ref MANUAL_RECEIPTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 2)) { MANUAL_RECEIPTS = "N"; }
MANUAL_RECEIPTS = MANUAL_RECEIPTS[1, 1];
if (!READV(ref COMMENTS_PRINTED, FL_COURSE_PARAMS, "COURSE.PARAMS", 5)) { COMMENTS_PRINTED = "N"; }
COMMENTS_PRINTED = COMMENTS_PRINTED[1, 1];
if (!READV(ref AUTO_FEE_REDUCTION, FL_COURSE_PARAMS, "COURSE.PARAMS", 6)) { AUTO_FEE_REDUCTION = "Y"; }
AUTO_FEE_REDUCTION = AUTO_FEE_REDUCTION[1, 1];
if (!READV(ref CONCESS_MEMBER_CHANGE, FL_COURSE_PARAMS, "COURSE.PARAMS", 7)) { CONCESS_MEMBER_CHANGE = "Y"; }
CONCESS_MEMBER_CHANGE = CONCESS_MEMBER_CHANGE[1, 1];
if (!READV(ref PREVENT_PP_AND_INSTALMENTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 15)) { PREVENT_PP_AND_INSTALMENTS = "N"; }
PREVENT_PP_AND_INSTALMENTS = PREVENT_PP_AND_INSTALMENTS[1, 1];
if (!READV(ref PREVENT_ZERO_PAYMENTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 25)) { PREVENT_ZERO_PAYMENTS = "N"; }
PREVENT_ZERO_PAYMENTS = PREVENT_ZERO_PAYMENTS[1, 1];
if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
if (!READV(ref ALLOW_MULTIPAY, FL_COURSE_PARAMS, "COURSE.PARAMS", 41)) { ALLOW_MULTIPAY = "Y"; }
if (!READV(ref CHEQUE_PROMPT, FL_COURSE_PARAMS, "COURSE.PARAMS", 48)) { CHEQUE_PROMPT = "Y"; }
if (!READV(ref FEE_TODAY, FL_COURSE_PARAMS, "COURSE.PARAMS", 49)) { FEE_TODAY = "N"; }
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
/* <EFT */
if (!(READV(ref EFT_SITE, COMMON.FILES[FL_CONTROL], "EFT.SITE", 1))) {
EFT_SITE = FALSE;
}
/* EFT> */
if (!(READ(ref PROMOTIONS_CONTROL, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL"))) {
PROMOTIONS_CONTROL = "";
}
CURRENT_PROMOTIONS = PROMOTIONS_CONTROL[1];
BONUS_REDEEM_PROG = PROMOTIONS_CONTROL[2];
if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
MAT(ref TEMP_REC, "");
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
SWIPE_DETAILS = "";
ACTION = "";
MOP = "";
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
DISPLAY_ALL_TRANSACTIONS = FALSE;
PAYMENT_TOTAL = 0;
do {
INTERACT = VALID_DATA;
TRANS_CNT = 1;
L0100();
AMENDING = FALSE;
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
RECEIPT_REQUIRED = FALSE;
MOP = "";
CC_REF = "";
CHQ_NO = "";
/* <EFT */
EFT_CONF = "";
CC_ISSUE = "";
CC_START = "";
EFT_AMOUNT = 0;
/* EFT> */
CC_EXP = "";
OLD_MAIN_KEY = "";
TRANS_LIST = "";
TOTAL_REDEMPTION = "";
TOTAL_POINTS = "";
BONUS_REDEEM_REC = "";
APACS_NO = "";
EPURSE_APACS_NO = "";
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
if (INTERACT != LIMIT) { L0060(); }
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
/*  Jump receipt field if value = 0.00 */
/* !*              IF ST.ATT = 5 AND VALUE = 0 THEN */
/* !*                 INTERACT = LIMIT */
/* !*                 START.FIELD = 9 */
/* !*                 END.FIELD   = 9 */
/* !*                 GOSUB 6000 */
/* !*              END */
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
/*  File automatically if a payment has been made */
/* *               IF TEMP.REC(5) # 0 THEN */
INTERACT = FINISH;
/* *               END */
/*  Force entry of receipt no if value changed from 0.00 */
}// CASE
else if (ST_ATT == 5 && TEMP_REC[ST_ATT] > 0 && TEMP_REC[7] == "") {
FIELD_NO = MAX_FIELDS - 1;
AMENDING = FALSE;
INTERACT = VALID_DATA;
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
/*  DJA 28.4.00 */
if (DISPLAY_PHOTO) {
FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (MAIN_KEY != "" && INTERACT != EXIT) {
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
SUPP_ID = TILL_NUMBER + "*" + PROG_MESS[30] + "*" + PROG_MESS[31] + "*" + PROG_MESS[32];
NEW_SUPP_REC = TRUE;
if (MATCH_FOUND) {
/*  Read supplementary record to see if this is a payment replacing */
/*  an enrolment-payment. If so, leave the existing supplementary */
/*  record's type flag intact. This will prevent activity day enrolment */
/*  details being blown away, for example. */
if (!READ(ref SUPP_REC, FL_MULTIPAY, SUPP_ID)) { SUPP_REC = ""; }
if (SUPP_REC[1] == "A" || SUPP_REC[1] == "E") {
NEW_SUPP_REC = FALSE;
}
} else {
SUPP_REC = "";
TRANS_NO = TRANS_COUNT + 1;
}
MULTIPAY_REC[1, TRANS_NO] = PROG_MESS[30];
MULTIPAY_REC[2, TRANS_NO] = PROG_MESS[31];
MULTIPAY_REC[3, TRANS_NO] = PROG_MESS[32];
if (REFUND_SCREEN) {
MULTIPAY_REC[4, TRANS_NO] = -PROG_MESS[33];
if (NEW_SUPP_REC == TRUE) {
SUPP_REC[1] = "R";
}
} else {
MULTIPAY_REC[4, TRANS_NO] = PROG_MESS[33];
if (NEW_SUPP_REC == TRUE) {
SUPP_REC[1] = "P";
}
}
WRITE(MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER);
SUPP_REC[9] = COURSE_BALANCE;
WRITE(SUPP_REC, FL_MULTIPAY, SUPP_ID);
PROG_MESS[30] = "";
PROG_MESS[31] = "";
PROG_MESS[32] = "";
PROG_MESS[33] = "";
} else {
/*  Process bonus updates *      IF TEMP.REC(5) # 0 THEN */
/*  Apply payment file-updates at this point */
TICK_ID = "";
/* !*MATREAD MEMBERS.REC FROM FL.MEMBERS, MAIN.KEY THEN */
/* !* STUDENT.NAME = TRIM(MEMBER.TITLES<1,1>:" ":MEMBER.FORENAMES<1,1>:" ":MEMBER.SURNAMES<1,1>) */
/* !*END ELSE */
/* !*                 STUDENT.NAME = TRIM(STUDENT.TITLE:" ":STUDENT.FORENAME:" ":STUDENT.SURNAME) */
/* !*END */
STUDENT_NAME = TEMP_REC[1];
NARRATIVE = "Cust: " + MAIN_KEY + " " + STUDENT_NAME;
NARRATIVE[1, 2] = "Course: " + TEMP_REC[3] + " " + COURSE_MSTR_REC[COURSE_MSTR_DESC];
NARRATIVE[1, 3] = "Runs from " + OCONV(COURSE_DATE, "D") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D");
NARR_MV = 3;
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A") {
/*  Activity day - multiple times */
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
} else {
if (COURSE_DET_REC[COURSE_DET_START_TIME] != "" && COURSE_DET_REC[COURSE_DET_END_TIME] != "") {
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Times: Starts " + OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT") + " Ends " + OCONV(COURSE_DET_REC[COURSE_DET_END_TIME][1, 1], "MT");
}
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
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "") {
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
}
/*  DJA 17.5.05 */
if (COURSE_DET_REC[COURSE_DET_INSTRUCTOR] != "") {
if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, COURSE_DET_REC[COURSE_DET_INSTRUCTOR])) { MAT(ref INSTRUCTOR_REC, ""); }
FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
NARR_MV = NARR_MV + 1;
NARRATIVE[1, NARR_MV] = "Instructor: " + FULL_INSTRUCTOR_NAME;
}
NARR_MV = NARR_MV + 1;
if (REFUND_SCREEN == FALSE) {
NARRATIVE[1, NARR_MV] = "Paid " + OCONV(TEMP_REC[5], "MD2") + SPACE(2) + "New Balance = " + OCONV(TEMP_REC[6], "MD2");
} else {
NARRATIVE[1, NARR_MV] = "REFUND " + OCONV(TEMP_REC[5], "MD2") + SPACE(2) + "New Balance = " + OCONV(TEMP_REC[6], "MD2");
}
TICK_REC = "";
/*  Process bonus updates *         IF RECEIPT.REQUIRED THEN */
TICK_REC[1] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICK_REC[2] = 1;
TICK_REC[4] = TODAYS_DATE;
TICK_REC[5] = TIME();
TICK_REC[6] = TICK_REC[3];
TICK_REC[7] = MOP;
TICK_REC[8] = U_INITS;
TICK_REC[9] = TILL_NUMBER;
/*  Is student a centre member? */
if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], MAIN_KEY)) {
TICK_REC[10] = MAIN_KEY;
}
PERIOD = 1;
TICK_REC[11] = PERIOD;
TICK_REC[37] = MAIN_KEY;
TICK_REC[38] = DETAILS_ID;
TICK_REC[13] = ENROL_REC[ENROL_CONCESSION][1, 1];
/*  DJA 5.12.03 */
if (CHQ_NO != "") {
TICK_REC[14] = CHQ_NO;
} else {
TICK_REC[14] = CC_REF;
}
TICK_REC[15] = CC_EXP;
/*  DJA 12.8.02 */
/* !*              IF COURSE.MSTR.CENTRE # CENTRE THEN */
/* !*                 TICK.REC<34> = COURSE.MSTR.CENTRE */
/* !*              END */
TICK_REC[34] = COMMON.CENTRE;
/* <EFT */
if (EFT_SITE) {
TICK_REC[30] = EFT_CONF[1] + VM + EFT_CONF[2] + VM + EFT_CONF[3];
TICK_REC[31] = "SWIPED" + VM + CC_START + VM + CC_ISSUE;
}
/* EFT> */
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
/*  DJA 10.6.97 */
PRINT_TICKET_NO = TICK_ID;
TICK_REC[16] = SESSION_NO;
if (MOP == "EP") {
/*                     TICK.REC<36> = APACS.NO */
if (EPURSE_APACS_NO != "") { TICK_REC[36] = EPURSE_APACS_NO; } else { TICK_REC[36] = APACS_NO; }
}
/*  Position cursor for entry no. */
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
/*  Only award points when the full balance has been settled */
/*  and make sure you don't award them again if its already been */
/*  done and we've only got here by processing a zero payment! */
if (REFUND_SCREEN == FALSE && TEMP_REC[6] == 0 && CURRENT_PROMOTIONS != "" && STUDENT_IS_MEMBER && COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "" && ENROL_REC[ENROL_BONUS_AWARD] <= 0) {
PERIOD = 1;
/*  Courses only use peak pricing */
TICK_REC[11] = PERIOD;
/* ASK ANNE*       CALL FL285(TICK.REC, BONUS.REDEEM.REC, COURSE.DET.FEE.CODE<1,1>, ENROL.PRICE, 1, ENROL.CONCESSION<1,1>, PERIOD, MAIN.KEY) */
/*  Although customer may only be making a part-payment, we */
/*  want the bonus record to reflect the total spend, i.e. */
/*  the course fee rather than this payment amount */
/*  FL165 derives the spend from tick.rec<3> so we TEMPORARILY */
/*  set this value to the course fee */
TICK_REC[3] = ENROL_REC[ENROL_PRICE];
TODAYZ_DATE = TODAYS_DATE;
CALL_REF = "COURSES";
FL165 = new FL165(ref TICK_REC, ref TODAYZ_DATE, ref PERIOD, ref CALL_REF);
TICKET_REC[TICK_BONUS_POINTS] = TICK_REC[24];
TICKET_REC[TICK_PROMOTION] = TICK_REC[25];
ENROL_REC[ENROL_BONUS_AWARD] = TICKET_REC[TICK_BONUS_POINTS];
ENROL_REC[ENROL_PROMOTION] = TICKET_REC[TICK_PROMOTION];
}
/*  Redemption updates */
if (REFUND_SCREEN == FALSE && BONUS_REDEEM_REC != "" && CURRENT_PROMOTIONS != "" && STUDENT_IS_MEMBER) {
/*  Enrolments uses the ENROL.xxx variables, but if we did */
/*  that here the total redemption against this course would */
/*  keep being written out to the ticket file, so we must rely */
/*  on the variables returned by the call to the redemption */
/*  program within this program */
TICK_REC[27] = TOTAL_REDEMPTION;
TICK_REC[28] = TOTAL_POINTS;
TICK_REC[25] = ENROL_REC[ENROL_PROMOTION];
TOTAL_REDEMPTION = 0;
TOTAL_POINTS_REDEEMED = 0;
FL277 = new FL277(ref BONUS_REDEEM_REC, ref TOTAL_REDEMPTION, ref TOTAL_POINTS_REDEEMED);
/*  Ensure redemption details are written to the ticket record */
}
/* *********************************************************** */
/*  DJA 17.7.06 If we're refunding the full payment received against */
/*              a course, and bonus points were awarded when it was */
/*              originally paid in full, then we must now reverse */
/*              the award. */
/*              Formerly there was code in FL741 Enrolment Changes */
/*              and FL715 4000* to achieve this, but this has now */
/*              been relocated to here since BCC found that students */
/*              who changed course place got an inflated bonus points */
/*              total */
/*              NB: There's a weakness here: if two or more refunds are */
/*                  processed which total the full amount paid against */
/*                  the course, then this code won't be executed and the */
/*                  customer will retain points to which they're not */
/*                  entitled */
/* !!CRT "REFUND.SCREEN=":REFUND.SCREEN:"  STUDENT.IS.MEMBER=":STUDENT.IS.MEMBER:"  CURRENT.PROMOTIONS=":CURRENT.PROMOTIONS:"  PAYMENT.TOTAL=":PAYMENT.TOTAL:"  TEMP.REC(5)=":TEMP.REC(5):"  ENROL.BONUS.AWARD=":ENROL.BONUS.AWARD:;INPUT FLEX,2: */
/* !!              IF REFUND.SCREEN = TRUE AND STUDENT.IS.MEMBER AND CURRENT.PROMOTIONS # "" AND PAYMENT.TOTAL = -TEMP.REC(5) AND ENROL.BONUS.AWARD > 0 THEN */
if (REFUND_SCREEN == TRUE && STUDENT_IS_MEMBER && CURRENT_PROMOTIONS != "" && ENROL_REC[ENROL_BONUS_AWARD] > 0) {
/*  Secure TICK.REC so we don't affect anything outside of this */
/*  refund condition */
/* !!                 SECURED.TICK.REC = TICK.REC */
TODAYZ_DATE = TODAYS_DATE;
CALL_REF = "MCOURSES";
/*  FL165 updates tick.rec <24> and <25> */
FL165 = new FL165(ref TICK_REC, ref TODAYZ_DATE, ref PERIOD, ref CALL_REF);
/*  Protect against repeat refund in the future: */
WRITEV(0, FL_ENROLMENT, ENROL_ID, 25);
/* !!                 TICK.REC<3> = -TICK.REC<3> */
/*  Write the ticket record for bonus point reconciliation */
/* !!                 TICK.ID = "" ; SESSION.NO = "" */
/* !!                 CALL FL000.12(PROGRAM,TICK.ID,"",SESSION.NO) */
/* !!                 TICK.REC<16> = SESSION.NO */
/*  Zeroise ticket amounts */
/* !!                 TICK.REC<3> = 0 */
/* !!                 TICK.REC<6> = 0 */
/* !!                 WRITE TICK.REC ON FL.TICKETS, TICK.ID */
/* !!                 TICK.REC = SECURED.TICK.REC */
}
/* *********************************************************** */
/*  Now set TICK.UNIT.PRICE as required on the written ticket record */
if (REFUND_SCREEN == TRUE) {
TICK_REC[3] = -TEMP_REC[5] + 0;
} else {
TICK_REC[3] = TEMP_REC[5] + 0;
}
TICK_REC[6] = TICK_REC[3];
/*  First release of bonus was filing null ticket totals (DJA 27.3.01) */
/*  DJA 23.4.03 */
if (BATCH_HEADCOUNTS[1, 1] == "Y") {
TICK_REC[21] = 0;
TICKET_REC[TICK_HCOUNT] = 0;
}
FL102 = new FL102();
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
if (REFUND_SCREEN == TRUE) {
nrf0 = "COURSES";
nrf1 = "Refund";
nrf2 = "";
nrf3 = TICK_REC[3, 1];
nrf4 = TEMP_REC[4] - TICK_REC[3, 1];
nrf5 = "Balance";
FL114 = new FL114(ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4, ref nrf5);
} else {
nrf0 = "COURSES";
nrf1 = "Payment";
nrf2 = "";
nrf3 = TICK_REC[3, 1];
nrf4 = TEMP_REC[4] - TICK_REC[3, 1];
nrf5 = "Balance";
FL114 = new FL114(ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4, ref nrf5);
}
WRITE(TICK_REC, COMMON.FILES[FL_TICKETS], TICK_ID);
/*  Process bonus updates *         END */
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
if (REFUND_SCREEN == TRUE) {
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "R";
} else {
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "P";
}
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -TICK_REC[3, 1];
if (TICK_ID != "") {
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = TICK_ID;
} else {
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = TEMP_REC[7];
STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, MVC] = TRUE;
}
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = MOP;
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
/*  Take the payment/refund amount of the student's overall balance */
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - TICK_REC[3, 1];
/*  Process bonus updates *      END */
/*  Now append any automatic fee write-off/bonus redemption */
if (TEMP_REC[8] > 0 && NOT(REFUND_SCREEN) && (AUTO_FEE_REDUCTION == "Y" || TOTAL_REDEMPTION > 0)) {
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DETAILS_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = -TEMP_REC[8];
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
if (TOTAL_REDEMPTION > 0) {
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "Bonus redemption";
} else {
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = "Auto. write-off";
}
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - TEMP_REC[8];
}
/*  In the case of auto-adjustments, the next line may be writing */
/*  the student record under a revised id for the first time */
MATWRITE(STUDENT_REC, FL_STUDENTS, MAIN_KEY);
/*  Multipay drops to here */
}
if (REFUND_SCREEN == FALSE) {
/*  Concession may have been modified as part of auto-write-off */
/*  Also, bonus redemption details may have been updated */
MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
}
}
/*  Updates have already occurred if the student id has been changed, */
/*  so processing of the payment can be abandoned, but the Id switch */
/*  cannot.  Give a warning in this instance. */
if (OLD_MAIN_KEY != "" && OLD_MAIN_KEY != MAIN_KEY && REFUND_SCREEN == FALSE) {
if (INTERACT == EXIT) {
/*  NB: Student record hasn't been written in these circumstances */
MATWRITE(STUDENT_REC, FL_STUDENTS, MAIN_KEY);
nrf0 = 34;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
DELETE(FL_STUDENTS, OLD_MAIN_KEY);
}
}
if (INTERACT == EXIT || (INTERACT == FINISH && REFUND_SCREEN == TRUE)) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
/*  IMPORTANT NOTE! (26/11/96) */
/*  It is no longer possible for the user to reach the footer prompt */
/*  as, for speed of processing, payments and refunds are now filed */
/*  as soon as the 'receipt' input has been received.  This was done */
/*  when implementing the automatic write-off enhancement for Wrekin */
/*  & Basingstoke.  The ability to view transactions across all */
/*  courses is still available in 'Transactions and Instalments' */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
if (NOT(DISPLAY_ALL_TRANSACTIONS)) {
INPUT_LINE = "  Field no, <RETURN> to scroll or 'A'll transactions ";
} else {
INPUT_LINE = "  <RETURN> to scroll or 'N'ormal display ";
}
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == "A" && NOT(DISPLAY_ALL_TRANSACTIONS)) {
/*  Display all transactions, irrespective of the course they relate to */
DISPLAY_ALL_TRANSACTIONS = TRUE;
TRANS_CNT = 1;
DISPLAY_MODE = 2;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
}// CASE
else if (ANS == "N" && DISPLAY_ALL_TRANSACTIONS) {
/*  Revert to normal transaction display */
L0100();
L0300();
DISPLAY_ALL_TRANSACTIONS = FALSE;
TRANS_CNT = 1;
DISPLAY_MODE = 1;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
}// CASE
else if (ANS == "") {
/*  Scroll transaction window */
ACTION = SCROLL;
FL731 = new FL731(ref ACTION, ref STUDENT_ID, ref DETAILS_ID, ref TRANS_LIST, ref STUDENT_REC, ref DISPLAY_MODE, ref REDISPLAY, ref TRANS_CNT);
ACTION = "";
}// CASE
else if (ANS == 1 && NOT(DISPLAY_ALL_TRANSACTIONS)) {
FIELD_NO = 6;
INTERACT = VALID_DATA;
}// CASE
else if (ANS == 2 && NOT(DISPLAY_ALL_TRANSACTIONS)) {
if (TEMP_REC[5] != 0) {
FIELD_NO = 9;
INTERACT = VALID_DATA;
} else {
nrf0 = 23;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
/* *       CASE ANS = "F" */
/* *         GOSUB 0055 */
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
if (TEMP_REC[5] > 0) {
INTERACT = FINISH;
} else {
/* **       INTERACT = INVALID.DATA */
/* **       CALL FL006(PROGRAM,14,INIT) */
INTERACT = EXIT;
}
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
if (FIELD_NO == 1) {
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
} else {
MEMBER_PROGRAM = "";
}
/*  Smart card may already be positioned in the reader */
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 1) {
L0065();
}
if (NOT(SMARTCARD_READ)) {
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
else if (ANS == "" && VALUE == "" && MANUAL_RECEIPTS == "N" && FIELD_NO == 8 && TEMP_REC[5] != 0) {
ANS = "Y";
L1400();
/*  Additional processing in validation routine */
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "" && FIELD_NO != 6 && FIELD_NO != 9) {
/*  NB Payment & receipt fields are mandatory but the valid'n routine handles defaults */
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY != "" && FIELD_NO != 6 && FIELD_NO != 9) {
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
case 6: L1300(); break;
case 7: L1100(); break;
case 8: L1100(); break;
case 9: L1400(); break;
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
if (REFUND_SCREEN) {
BASKET_TOTAL = BASKET_TOTAL - PROG_MESS[33] - MULTIPAY_REC[4, TRANS_NO];
} else {
BASKET_TOTAL = BASKET_TOTAL + PROG_MESS[33] - MULTIPAY_REC[4, TRANS_NO];
}
} else {
BASKET_COUNT = BASKET_COUNT + 1;
if (REFUND_SCREEN) {
BASKET_TOTAL = BASKET_TOTAL - PROG_MESS[33];
} else {
BASKET_TOTAL = BASKET_TOTAL + PROG_MESS[33];
}
}
}
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
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
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
/*  Validate Student/Memeber No */
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
ANS = OCONV(ANS, "MCU");
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
if (NOT(MATCH(PADDED_MAIN_KEY.Substring(1, 1),"1A"))) {
FL000_40 = new FL000_40(ref PADDED_MAIN_KEY);
}
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
/*  DJA 28.4.00 */
if (DISPLAY_PHOTO) {
/* !*              READ TEST.REC FROM FL.MEMBERS, MAIN.KEY THEN */
if (STUDENT_IS_MEMBER) {
nrf0 = 64;
nrf1 = 8;
FL_PHOTO = new FL_PHOTO(ref MAIN_KEY, ref nrf0, ref nrf1);
}
}
/*  DJA 24.06.03 */
if (STUDENT_IS_MEMBER) {
/*  DJA 15.04.02 Check membership expiry/debtor details */
NO_EXPIRY_DATES = DCOUNT(MEMBERS_REC[MEMBER_EXPIRY_DATE], VM);
// BEGIN CASE
// CASE
if (MEMBERS_REC[MEMBER_EXPIRY_DATE] == "") {
NULL();
}// CASE
else if (NO_EXPIRY_DATES == 1) {
if (MEMBERS_REC[MEMBER_EXPIRY_DATE] <= TODAYS_DATE) {
/*  Warning */
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
/*  Warning */
nrf0 = 46;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref TYPE_STRING);
}
}
// END CASE
DEBTOR_ID = COMMON.CENTRE + "*" + MAIN_KEY;
/*  Warning */
if (READ(ref TEST_REC, COMMON.FILES[FL_DEBTORS], DEBTOR_ID)) {
nrf0 = 41;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/*  DJA 24.06.03 Member messages, Frozen DDs and membership start date */
FL535 = new FL535(ref MAIN_KEY, ref PROGRAM);
/*  Check for Frozen direct debits */
DD_ID = "1*" + MAIN_KEY + "*1";
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID)) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] <= TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] >= TODAYS_DATE) {
CONTINUE = FALSE;
do {
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
if (YES_NO == "N" || YES_NO == "n") {
INTERACT = INVALID_DATA;
CONTINUE = TRUE;
}// CASE
else if (YES_NO == "Y" || YES_NO == "y") {
CONTINUE = TRUE;
}
// END CASE
if (CONTINUE == TRUE) break;
} while (true);
}
}
if (INTERACT == VALID_DATA) {
/*  Check for Direct Debit debts */
DD_DEBTOR_ID = "1*" + MAIN_KEY;
if (MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID)) {
CONTINUE = FALSE;
do {
PRINT(AT(1, 23) + REV_VID);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Member " + MAIN_KEY + " is a current DD debtor. Continue ? (Y/N) ");
INPUT(out YES_NO, 2);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(1, 23) + SCREEN_BACK + SCREEN_DATA);
// BEGIN CASE
// CASE
if (YES_NO == "N" || YES_NO == "n") {
CONTINUE = TRUE;
INTERACT = INVALID_DATA;
}// CASE
else if (YES_NO == "Y" || YES_NO == "y") {
CONTINUE = TRUE;
}
// END CASE
if (CONTINUE == TRUE) break;
} while (true);
}
if (INTERACT == VALID_DATA) {
/*  Check membership start date */
if (MEMBERS_REC[MEMBER_START_DATE] == "") {
MEMSHP_START = MEMBERS_REC[MEMBER_DATE_JOINED];
} else {
MEMSHP_START = MEMBERS_REC[MEMBER_START_DATE];
}
if (MEMSHP_START > TODAYS_DATE) {
CONTINUE = FALSE;
do {
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
if (YES_NO == "N" || YES_NO == "n") {
CONTINUE = TRUE;
INTERACT = INVALID_DATA;
}// CASE
else if (YES_NO == "Y" || YES_NO == "y") {
CONTINUE = TRUE;
}
// END CASE
if (CONTINUE == TRUE) break;
} while (true);
}
}
}
/*  Clear name/address of student from screen if we're not proceeding */
if (INTERACT == INVALID_DATA) {
MAT(ref TEMP_REC, "");
START_FIELD = 2;
END_FIELD = 3;
L6000();
}
}
NEW_STUDENT = FALSE;
} else {
INTERACT = INVALID_DATA;
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
if (REFUND_SCREEN == FALSE) {
DISPLAY_MODE = 3;
} else {
DISPLAY_MODE = 4;
}
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
/* **CALL @PROCESS.LOCKED(FL.COURSE.MASTER,COURSE.ID,STATUS) */
/* **IF STATUS = TRUE THEN */
/* ** CALL FL006(PROGRAM,30,INIT) */
/* ** INTERACT = INVALID.DATA */
/* ** ANS = "" */
/* ** VALUE = "" */
/* **END ELSE */
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
ANS = COURSE_ID;
DETAILS_ID = COURSE_DATE + "*" + COURSE_ID;
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
/*  Check student is enrolled in this course */
ACCESS_ALLOWED = FALSE;
if (REFUND_SCREEN == TRUE) {
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
} else {
if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
}
if (ACCESS_ALLOWED == TRUE) {
L1220();
/*  display course data */
} else {
if (REFUND_SCREEN == FALSE) {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
nrf0 = 17;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/* *               INTERACT = INVALID.DATA */
INTERACT = EXIT;
VALUE = "";
ANS = "";
AMENDING = FALSE;
}
} else {
INTERACT = EXIT;
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
}
/* **END */
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
/* **CALL @PROCESS.LOCKED(FL.COURSE.MASTER,COURSE.ID,STATUS) */
/* **IF STATUS = TRUE THEN */
/* ** CALL FL006(PROGRAM,30,INIT) */
/* ** INTERACT = INVALID.DATA */
/* ** ANS = '' */
/* ** VALUE = '' */
/* **END ELSE */
if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, VALUE)) {
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
if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID)) {
/*  Check student is enrolled on this course */
ACCESS_ALLOWED = FALSE;
if (REFUND_SCREEN == TRUE) {
if (LOCATE(DETAILS_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
} else {
if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL")) {
ACCESS_ALLOWED = TRUE;
}
}
if (ACCESS_ALLOWED == TRUE) {
L1220();
/*  display course data */
AMENDING = FALSE;
} else {
if (REFUND_SCREEN == FALSE) {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
nrf0 = 17;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/* *                     INTERACT = INVALID.DATA */
INTERACT = EXIT;
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
/* **END */
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
OLD_MAIN_KEY = MAIN_KEY;
/*  Needed in case an id-switch is processed */
return;
}
void L1300() {
/*  Payment Validation */
/*  Deal with default values first */
/*  Default for refunds is amount paid to date unless this exceeds the */
/*  original course fee */
if (ANS == COMMON.CLR) { ANS = 0; }
if (ANS == "" && VALUE == "") {
if (REFUND_SCREEN == FALSE) {
NO_DATES = DCOUNT(ENROL_REC[ENROL_INST_DATES], VM);
// BEGIN CASE
// CASE
if (NO_DATES < 1) {
ANS = OCONV(TEMP_REC[4], "MD2");
/*  o/s balance */
}// CASE
else if (OTHERWISE) {
if (!LOCATE(TODAYS_DATE, ENROL_REC[ENROL_INST_DATES], 1, 0, 1, ref POS, "AR")) { NULL(); }
NEXT_DATE = ENROL_REC[ENROL_INST_DATES][1, POS];
if (NEXT_DATE == "") {
ANS = OCONV(ENROL_REC[ENROL_INST_AMOUNTS][1, NO_DATES], "MD2");
/*  Take last value */
} else {
ANS = OCONV(ENROL_REC[ENROL_INST_AMOUNTS][1, POS], "MD2");
}
}
// END CASE
if (ICONV(ANS, "MD2") > TEMP_REC[4]) { ANS = OCONV(TEMP_REC[4], "MD2"); }
} else {
CONV_ANS = -PAYMENT_TOTAL;
if (TEMP_REC[4] + CONV_ANS > ENROL_REC[ENROL_PRICE]) {
CONV_ANS = ENROL_REC[ENROL_PRICE] - TEMP_REC[4];
}
ANS = OCONV(CONV_ANS, "MD2");
}
}
CONV_ANS = ICONV(ANS, "MD2");
// BEGIN CASE
// CASE
if (ANS == "" || NOT(MATCH(CONV_ANS,"0N"))) {
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS < 0) {
nrf0 = 10;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS > TEMP_REC[4] && REFUND_SCREEN == FALSE) {
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
/*  The following clause was removed because if they've been dis-enrolled */
/*  the read of the enrolment record fails, so enrol.price = ''. */
/* *     CASE TEMP.REC(4) + CONV.ANS > ENROL.PRICE AND REFUND.SCREEN = TRUE */
/* *       CALL FL006(PROGRAM,16,INIT) */
/* *       INTERACT = INVALID.DATA */
/*  DJA 4.8.00 */
}// CASE
else if (CONV_ANS > 0 && CONV_ANS < TEMP_REC[4] && REFUND_SCREEN == FALSE && PREVENT_PP_AND_INSTALMENTS == "Y") {
INTERACT = INVALID_DATA;
nrf0 = 47;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
/*  There's no point in anyone processing a 0.00 refund or instalment! */
/* !*  CASE CONV.ANS = 0 AND REFUND.SCREEN = FALSE AND PREVENT.ZERO.PAYMENTS = "Y" */
}// CASE
else if (CONV_ANS == 0) {
INTERACT = INVALID_DATA;
nrf0 = 48;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
if (INTERACT == VALID_DATA) {
TOTAL_REDEMPTION = 0;
TOTAL_POINTS = 0;
BONUS_REDEEM_REC = "";
if (CONV_ANS > 0 && STUDENT_IS_MEMBER && CURRENT_PROMOTIONS != "") {
if (REFUND_SCREEN == FALSE) {
nrf0 = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
nrf1 = "CO";
nrf2 = 1;
CallAt_BONUS_REDEEM_PROG = new CallAt_BONUS_REDEEM_PROG(ref BONUS_REDEEM_PROG, ref MAIN_KEY, ref nrf0, ref nrf1, ref CONV_ANS, ref nrf2, ref BONUS_REDEEM_REC, ref CURRENT_PROMOTIONS, ref TOTAL_REDEMPTION, ref TOTAL_POINTS, ref PROMOTION);
if (TOTAL_REDEMPTION > 0) {
/* !*              IF TOTAL.REDEMPTION + CONV.ANS > TEMP.REC(4) THEN */
/* !** Redemption plus payment exceeds balance outstanding */
/* !*                    CONV.ANS = TEMP.REC(4) - TOTAL.REDEMPTION */
CONV_ANS = CONV_ANS - TOTAL_REDEMPTION;
ANS = OCONV(CONV_ANS, "MD2");
/* !*              END */
TEMP_REC[8] = TOTAL_REDEMPTION;
L1325();
ENROL_REC[ENROL_TOTAL_REDEMPTION] = ENROL_REC[ENROL_TOTAL_REDEMPTION] + TOTAL_REDEMPTION;
ENROL_REC[ENROL_TOTAL_POINTS] = ENROL_REC[ENROL_TOTAL_POINTS] + TOTAL_POINTS;
ENROL_REC[ENROL_PROMOTION] = PROMOTION;
}
}
}
/*  Display the revised balance */
if (REFUND_SCREEN == FALSE) {
TEMP_REC[6] = TEMP_REC[4] - CONV_ANS - TOTAL_REDEMPTION;
} else {
TEMP_REC[6] = TEMP_REC[4] + CONV_ANS;
}
START_FIELD = 8;
END_FIELD = 8;
L6000();
/*  Display selected field */
if (TOTAL_REDEMPTION <= 0 && AUTO_FEE_REDUCTION == "Y" && REFUND_SCREEN == FALSE && BASKET_COUNT <= 0) {
if (TEMP_REC[6] > 0 && ENROL_REC[ENROL_INST_DATES] == "" && COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "") {
/*  o/s balance & not an instalment payer.  Ask if they want */
/*  to automatically reduce the fee due, e.g. has the person */
/*  become a member since enrolling. */
/*  Display converted payment amount */
PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(CONV_ANS, "MD2"), ST_JUST));
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "  Write off outstanding balance? (Y/<return>) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS2, 2);
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS2 == "Y") {
/*  Course fee adjustment equals outstanding balance */
TEMP_REC[8] = TEMP_REC[6];
TEMP_REC[6] = 0;
if (CONCESS_MEMBER_CHANGE != "N") {
L1327();
/*  Re-assign concession for future enrolments */
L1330();
/*  Offer student to member conversion */
}
INTERACT = VALID_DATA;
}// CASE
else if (ANS2 == "N" || ANS2 == "" || ANS2 == COMMON.ABANDON) {
TEMP_REC[8] = 0;
INTERACT = VALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
}
}
L1325();
}
return;
}
void L1325() {
/*  Redisplay adjustment and new balance fields */
START_FIELD = 7;
END_FIELD = 8;
L6000();
/*  display adjustment & total fields */
return;
}
void L1327() {
/*  Re-select concession for future enrolments */
DISPLAY_LINE = "  Re-select concession for future enrolment(s): ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + DISPLAY_LINE);
TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
TICKET_TYPE = "C";
/*  DJA 26.1.05 */
if (FEE_TODAY == "Y") {
SALE_DATE = TODAYS_DATE;
} else {
SALE_DATE = COURSE_DATE;
}
SALE_TIME = TIME();
TICKET_CONCESS = "";
PERIOD = "";
TICKET_PRICE = "";
/*  Always show concession bar; their membership may have expired in */
/*  which case it is wrong to assume a members fee (FL048 will do this */
/*  if a member no. is passed to it). Over the top to develop this */
/*  area further as this code is only used in quite rare situations. */
MEMBER_NUMBER = "";
FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
PROG_MESS[4] = "S";
/*  Suppress auto-concession mappings */
FL048 = new FL048(ref TICK_FEES_REC, ref TICKET_PRICE, ref PERIOD, ref MEMBER_NUMBER, ref TICKET_CONCESS);
PROG_MESS[4] = "";
/* *   IF TICKET.CONCESS = "" THEN TICKET.CONCESS = TICK.FEES.CONCESSIONS<1,1> */
if (TICKET_CONCESS == "") {
TICKET_CONCESS = TRIM(ENROL_REC[ENROL_CONCESSION][1, 1]);
} else {
ENROL_REC[ENROL_CONCESSION] = TRIM(TICKET_CONCESS);
}
return;
}
void L1330() {
/*  Offer student to member conversion */
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "  If this is due to new membership, enter the member no: ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS3, 13);
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS3 == "" || ANS3 == COMMON.ABANDON) {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
if (READ(ref TEST_REC, FL_STUDENTS, ANS3)) {
nrf0 = 32;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
if (READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], ANS3)) {
NEW_STUDENT_ID = ANS3;
L1335();
/*  Process an Id change */
INTERACT = VALID_DATA;
} else {
nrf0 = 33;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
}
void L1335() {
/*  Process an id change if course student becomes member */
READ_AND_WRITE = FALSE;
OLD_STUDENT_ID = MAIN_KEY;
/*  SUCCESS is effectively INTERACT but we don't want the value changed */
FL766 = new FL766(ref OLD_STUDENT_ID, ref NEW_STUDENT_ID, ref STUDENT_REC, ref READ_AND_WRITE, ref SUCCESS, ref ERROR_MESSAGE);
/* DJA 2.4.97* OLD.MAIN.KEY = MAIN.KEY */
/*  DJA 02.08.2000  Now remove duplicated name, address */
/*                  telephone and DOB info from the student */
/*                  record */
for(N = 1; N <= 12; N += 1) {
STUDENT_REC[N] = "";
}
MAIN_KEY = NEW_STUDENT_ID;
ENROL_ID = DETAILS_ID + "*" + NEW_STUDENT_ID;
START_FIELD = 1;
END_FIELD = 1;
L6000();
return;
}
void L1400() {
/*  Receipt Validation */
RECEIPT_REQUIRED = TRUE;
RECEIPT_NO = "";
/*  If manual receipts aren't permitted, and an amount has been */
/*  entered, default to 'Y' for receipt */
/*  The exception is 0.00 payments for which the default is 'N'o */
/*  and 'Y' is an invalid selection */
// BEGIN CASE
// CASE
if (ANS == "" && VALUE == "") {
// BEGIN CASE
// CASE
if (TEMP_REC[5] == 0) {
/*  Default to 'No' for zero payments */
ANS = "N";
RECEIPT_REQUIRED = FALSE;
INTERACT = VALID_DATA;
}// CASE
else if (MANUAL_RECEIPTS == "N") {
ANS = "Y";
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
// END CASE
}// CASE
else if (ANS == "Y" && TEMP_REC[5] == 0) {
nrf0 = 35;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "Y") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "N" && TEMP_REC[5] == 0) {
INTERACT = VALID_DATA;
RECEIPT_REQUIRED = FALSE;
}// CASE
else if (ANS == "N" && TEMP_REC[5] != 0) {
INTERACT = INVALID_DATA;
RECEIPT_REQUIRED = FALSE;
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MANUAL_RECEIPTS == "Y") {
INTERACT = VALID_DATA;
RECEIPT_REQUIRED = FALSE;
RECEIPT_NO = ANS;
}// CASE
else if (OTHERWISE) {
nrf0 = 31;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
// END CASE
if (INTERACT == VALID_DATA) {
if (RECEIPT_REQUIRED) {
/*  Dealing with payment and receipt if necessary */
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
PRINT(AT(79, 23) + NRM_VID);
PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 23) + SPACE(76));
if (ALLOW_MULTIPAY != "N") {
if (EPURSE_ROUTINE == "") {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay or other mop" + SPACE(1);
} else {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'M'ultipay, 'EP'urse" + SPACE(1);
}
} else {
if (EPURSE_ROUTINE == "") {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque or other mop" + SPACE(1);
} else {
FOOT_MESS = " <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, 'EP'urse or other mop" + SPACE(1);
}
}
PRINT(AT(2, 23) + FOOT_MESS);
PRINT(AT(LEN(FOOT_MESS) + 2, 23));
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
else if (MOP == "M" && TEMP_REC[8] > 0) {
/*  Auto-fee adjustments not permitted when using multipayment basket */
nrf0 = 84;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
PROG_MESS[30] = COURSE_ID;
PROG_MESS[31] = COURSE_DATE;
PROG_MESS[32] = MAIN_KEY;
PROG_MESS[33] = TEMP_REC[5];
L0150();
/* !* TICK.TOTAL = 0 */
/* !* TICK.UNIT.PRICE = 0 */
/* !* TEMP.REC(23) = TEMP.REC(17) */
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
MOP = "C";
}// CASE
else if (MOP == MOP_TYPES[2]) {
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
}// CASE
else if (MOP == MOP_TYPES[3]) {
INTERACT = VALID_DATA;
CC_REF = "";
CC_EXP = "";
RET_FUNC = "";
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
/* <EFT */
if (EFT_SITE) {
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
if (CC_REF == COMMON.ABANDON) {
RET_FUNC = COMMON.ABANDON;
} else {
PRINT(AT(2, 22) + SPACE(76) + NRM_VID);
EFT_CONF = "Student : " + MAIN_KEY;
if (REFUND_SCREEN == TRUE) {
EFT_AMOUNT = -TEMP_REC[5] + 0;
} else {
EFT_AMOUNT = TEMP_REC[5] + 0;
}
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
PRINT(AT(2, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SPACE(70));
} else {
INTERACT = VALID_DATA;
}
}// CASE
else if (MOP == "EP" && SMART_CARD) {
IFACE_TYPE = 2;
TRANS_ID = "";
TRANS_TYPE = "E";
if (REFUND_SCREEN == TRUE) {
EP_AMOUNT = -TEMP_REC[5] + 0;
} else {
EP_AMOUNT = TEMP_REC[5] + 0;
}
TRANS_AMOUNT = EP_AMOUNT;
if (MATCH(MAIN_KEY,"16N")) {
/*  Unrecognised APACS number */
PASSED_MEMBER_NO = "";
} else {
PASSED_MEMBER_NO = MAIN_KEY;
}
SMART_DISPLAY_MODE = FWTERM_MODE;
CARD_ERROR_TYPE = 34;
/* MAT EPURSE.REC = "" */
EPURSE_APACS_NO = APACS_NO;
EPURSE_MEM_NO = PASSED_MEMBER_NO;
EPURSE_AMOUNT = TRANS_AMOUNT;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref EPURSE_MEM_NO, ref EPURSE_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref EPURSE_APACS_NO);
if (SMARTCARD_INTERACT != VALID_DATA) {
nrf0 = 301;
nrf1 = CARD_ERROR_TYPE + " (" + CARD_ERROR_MESS + ")";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
/* MAT EPURSE.REC = "" */
/* EPURSE.APACS.NO = APACS.NO */
/* EPURSE.MEM.NO = PASSED.MEMBER.NO */
/* EPURSE.AMOUNT = TRANS.AMOUNT */
/* CALL FL00019(MAT EPURSE.REC,TRANS.ID); * PRINT EPURSE SLIP AND UPDATE AUDIT LOG */
INTERACT = VALID_DATA;
/* !*                 TICK.MOP = "EP" */
/* !*                 TICK.APACS.NO = APACS.NO */
}
IFACE_TYPE = "99";
/*  Remove card */
SMART_DISPLAY_MODE = FWTERM_MODE;
CARD_ERROR_TYPE = "";
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref EPURSE_MEM_NO, ref EPURSE_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref EPURSE_APACS_NO);
}// CASE
else if (OTHERWISE) {
AMC = 4;
NO_MOPS = DCOUNT(MOP_TYPES, AM);
MOP_FOUND = FALSE;
do {
if (MOP_FOUND || AMC > NO_MOPS) break;
if (MOP == MOP_TYPES[AMC]) {
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
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(0, 23) + SPACE(79));
} else {
MOP = "";
CC_REF = "";
CC_EXP = "";
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
PRINT(AT(ST_COL - 1, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
}// CASE
else if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
/*  Follow balance with instalment details where relevant */
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
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
