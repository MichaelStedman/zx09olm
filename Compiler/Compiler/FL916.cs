//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL916 : UvBase
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
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] TICKET_REC = new UvVar[40];
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
      UvVar AM = "";
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
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar MOP_TYPES = "";
      UvVar MULTIPAY_REC = "";
      UvVar COURSE_PARAMS = "";
      UvVar COMMENTS_PRINTED = "";
      UvVar COURSE_COMMENT_TAGS = "";
      UvVar BATCH_HEADCOUNTS = "";
      UvVar BASKET_COUNT = "";
      FL006 FL006;
      UvVar CENTRALISED_COURSES = "";
      UvVar TICKET_PRINT_ROUTINE = "";
      UvVar CHEQUE_PROMPT = "";
      UvVar CHEQU_PROMPT = "";
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
      UvVar GRAND_TICK_TOTAL = "";
      UvVar NO_STUDENTS = "";
      UvVar STUDENT_LIST = "";
      UvVar STUDENT_MVC = "";
      UvVar FIRST_STUDENT = "";
      UvVar STUDENT_ID = "";
      UvVar STUDENT_NAME = "";
      UvVar COURSE_DATE = "";
      UvVar NO_OF_STUDENTS = "";
      UvVar BALANCE_LIST = "";
      UvVar ENROL_ID = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar MOP = "";
      UvVar CHQ_NO = "";
      UvVar CC_DONE = "";
      UvVar CC_REF = "";
      UvVar CC_EXP = "";
      UvVar EFT_CONF = "";
      UvVar CC_ISSUE = "";
      UvVar CC_START = "";
      UvVar EFT_AMOUNT = "";
      UvVar RET_FUNC = "";
      UvVar EFT_SITE = "";
      UvVar CC_AUTH = "";
      UvVar SWIPE_DETAILS = "";
      FL361_EFT FL361_EFT;
      UvVar CARD_CVS = "";
      FL_EFT FL_EFT;
      FL361_1 FL361_1;
      UvVar AMC = "";
      UvVar NO_MOPS = "";
      UvVar MOP_FOUND = "";
      UvVar NARRATIVE = "";
      UvVar NARR_MV = "";
      UvVar TICK_REC = "";
      UvVar TICK_ID = "";
      UvVar PRINT_TICKET_NO = "";
      UvVar SESSION_NO = "";
      FL000_12 FL000_12;
      UvVar ATT = "";
      FL102 FL102;
      CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
      FL000_15 FL000_15;
      UvVar COURSE_CODE = "";
      UvVar AMOUNT = "";
      UvVar COURSE_BALANCE = "";
      UvVar DETAILS_ID = "";
      UvVar NO_TRANS = "";
      UvVar PAYMENT_MVC = "";
      FL114 FL114;
      UvVar XFER_LIST = "";
      UvVar ERROR_LIST = "";
      UvVar ACTION = "";
      UvVar BALANCE_WARNING = "";
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
      UvVar DISPLAY_MODE = "";
      UvVar SCAN_STUDENT_ID = "";
      FL717 FL717;
      UvVar COURSE_ID = "";
      UvVar REDISPLAY = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar DATE_LIST = "";
      UvVar CREATION_ALLOWED = "";
      UvVar SELECT_DATE = "";
      FL704 FL704;
      UvVar NEW_COURSE = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      FL755 FL755;
      UvVar SURNAME_LIST = "";
      UvVar FULL_NAME_LIST = "";
      UvVar CONCESS_LIST = "";
      UvVar ADJUSTMENT_LIST = "";
      UvVar INSTALMENT_LIST = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      UvVar nrf3 = "";
      UvVar nrf4 = "";
      UvVar nrf5 = "";
      #endregion
      public FL916()
      {
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
         /*  Group Payments */
         /* ************************************************************** */
         /*   IMPORTANT: This option is specifically for use at NSC      * */
         /*              It is for paying off group bookings where all   * */
         /*              customers are non-member students paying the    * */
         /*              same rate. It doesn't deal with bonus, has not  * */
         /*              been tested for EFT, prints a simplistic ticket * */
         /*              etc.                                            * */
         /* ************************************************************** */
         PROMPT("");
         PROGRAM = "FL916";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         JUST = "L#10";
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
         #region INCLUDE FL.FILES FL.MULTIPAY
         if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

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
         if (!READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")) { MOP_TYPES = ""; }
         if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
         if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
         COMMENTS_PRINTED = COURSE_PARAMS[5, 1];
         if (!READ(ref COURSE_COMMENT_TAGS, FL_COURSE_PARAMS, "COURSE.COMMENT.TAGS")) { COURSE_COMMENT_TAGS = ""; }
         if (!READV(ref BATCH_HEADCOUNTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 35)) { BATCH_HEADCOUNTS = ""; }
         BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
         if (BASKET_COUNT > 0)
         {
            nrf0 = 85;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         CENTRALISED_COURSES = COURSE_PARAMS[24, 1];
         if (!READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "TICKET.PRINT.ROUTINE")) { TICKET_PRINT_ROUTINE = ""; }
         if (!READV(ref CHEQUE_PROMPT, FL_COURSE_PARAMS, "COURSE.PARAMS", 48)) { CHEQU_PROMPT = "Y"; }
         CHEQUE_PROMPT = CHEQUE_PROMPT[1, 1];
         if (CHEQUE_PROMPT == "") { CHEQUE_PROMPT = "Y"; }
         MAT(ref TEMP_REC, "");
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
         TOGGLE_POS = "";
         WINDOW_DEPTH = "";
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
         do
         {
            INTERACT = VALID_DATA;
            L0100();
            AMENDING = FALSE;
            MAIN_KEY = "";
            MAT(ref TEMP_REC, "");
            STUDENT_SELECT_LIST = "";
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     if (INTERACT != LIMIT) { L0060(); }
                     if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
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
            }
            if (INTERACT == EXIT || INTERACT == FINISH) break;
         } while (true);
         return;
         /* ************************************* */
      }
      void L0050()
      {
         /*   ENTER AMENDMENT FIELD NUMBER  * */
         /* ************************************* */
         AMENDING = TRUE;
         INTERACT = INVALID_DATA;
         SELECT_COUNT = COUNT(STUDENT_SELECT_LIST, TRUE);
         UPDATE_INTERACT = "";
         do
         {
            INPUT_LINE = " # no, 'ALL', 'NONE', <RET> to scroll or 'P'ay ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 5);
            PRINT(AT(2, 21) + SPACE(75));
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (SELECT_COUNT == 0 && ANS == "P")
            {
               nrf0 = 46;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == "P")
            {
               GRAND_TICK_TOTAL = 0;
               NO_STUDENTS = DCOUNT(STUDENT_LIST, VM);
               STUDENT_MVC = 1;
               MAT(ref STUDENT_REC, "");
               MAT(ref ENROL_REC, "");
               FIRST_STUDENT = FALSE;
               STUDENT_ID = "";
               STUDENT_NAME = "";
               COURSE_DATE = PROG_MESS[3];
               NO_OF_STUDENTS = 0;
               do
               {
                  if (STUDENT_MVC > NO_STUDENTS) break;
                  if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE)
                  {
                     if (BALANCE_LIST[1, STUDENT_MVC] > 0)
                     {
                        GRAND_TICK_TOTAL = GRAND_TICK_TOTAL + BALANCE_LIST[1, STUDENT_MVC];
                        NO_OF_STUDENTS = NO_OF_STUDENTS + 1;
                     }
                     if (FIRST_STUDENT == FALSE)
                     {
                        /*  Get details to support ticket print */
                        STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
                        if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_LIST[1, STUDENT_MVC])) { MAT(ref STUDENT_REC, ""); }
                        ENROL_ID = PROG_MESS[3] + "*" + MAIN_KEY + "*" + STUDENT_LIST[1, STUDENT_MVC];
                        if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
                        if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID))
                        {
                           STUDENT_IS_MEMBER = TRUE;
                           STUDENT_NAME = TRIM(MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
                        }
                        else
                        {
                           STUDENT_IS_MEMBER = FALSE;
                           STUDENT_NAME = TRIM(STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
                        }
                     }
                  }
                  STUDENT_MVC = STUDENT_MVC + 1;
               } while (true);
               INTERACT = INVALID_DATA;
               MAT(ref TICKET_REC, "");
               do
               {
                  if (!(INTERACT == INVALID_DATA)) break;
                  PRINT(AT(78, 23) + NRM_VID);
                  PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                  PRINT(AT(2, 23) + SPACE(76));
                  PRINT(AT(2, 23) + " Press <RETURN> for cash, " + MOP_TYPES[2] + " for cheque, or other mop" + SPACE(6));
                  PRINT(AT(55, 23));
                  INPUT(out MOP, 5);
                  // BEGIN CASE
                  // CASE
                  if (MOP == COMMON.ABANDON)
                  {
                     INTERACT = EXIT;
                     PROG_MESS[1] = COMMON.ABANDON;
                     /*  Cash */
                  }// CASE
                  else if (MOP == "")
                  {
                     INTERACT = VALID_DATA;
                  }// CASE
                  else if (MOP == MOP_TYPES[2])
                  {
                     /*  Cheque */
                     TICKET_REC[TICK_MOP] = MOP;
                     if (CHEQUE_PROMPT == "Y")
                     {
                        do
                        {
                           if (!(INTERACT == INVALID_DATA)) break;
                           /*  Cheque */
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
                              /* MR!                       TICK.MOP = "C" */
                              TICKET_REC[TICK_CC_REF] = CHQ_NO;
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
                     if (INTERACT == EXIT) { INTERACT = INVALID_DATA; }
                  }// CASE
                  else if (MOP == MOP_TYPES[3])
                  {
                     CC_DONE = FALSE;
                     INTERACT = VALID_DATA;
                     /*  CC.DONE indicates either that we've successfully authenticated */
                     /*  or that the user abandoned, e.g. to select a different MOP. */
                     /*  Formerly it was too easy to <return> for cash after an EFT rejection */
                     do
                     {
                        if (CC_DONE) break;
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
                              CC_DONE = TRUE;
                              RET_FUNC = COMMON.ABANDON;
                           }
                           else
                           {
                              PRINT(AT(2, 22) + SPACE(76) + NRM_VID);
                              EFT_CONF = "Group course payment";
                              EFT_AMOUNT = GRAND_TICK_TOTAL;
                              FL_EFT = new FL_EFT(ref SWIPE_DETAILS, ref CC_REF, ref CC_EXP, ref CC_ISSUE, ref CC_START, ref EFT_AMOUNT, ref EFT_CONF, ref RET_FUNC, ref PROGRAM, ref CARD_CVS);
                              /* !*                    IF RET.FUNC # VALID.DATA THEN */
                              /* !*                       RET.FUNC = ABANDON */
                              /* !*                    END */
                              if (RET_FUNC == VALID_DATA)
                              {
                                 CC_DONE = TRUE;
                              }
                              else
                              {
                                 RET_FUNC = COMMON.ABANDON;
                              }
                           }
                           /* EFT! */
                        }
                        else
                        {
                           FL361_1 = new FL361_1(ref CC_REF, ref CC_EXP, ref RET_FUNC);
                           if (RET_FUNC == VALID_DATA)
                           {
                              CC_DONE = TRUE;
                           }
                           else
                           {
                              if (RET_FUNC == COMMON.ABANDON)
                              {
                                 CC_DONE = TRUE;
                              }
                           }
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
                              TICKET_REC[TICK_EFT_SWIPE] = "SWIPED" + VM + CC_START + VM + CC_ISSUE;
                           }
                           /* EFT> */
                        }
                     } while (true);
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
               if (INTERACT == VALID_DATA)
               {
                  /* ****************************** */
                  TICKET_REC[TICK_CODE] = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
                  TICKET_REC[TICK_UNIT] = 1;
                  TICKET_REC[TICK_UNIT_PRICE] = GRAND_TICK_TOTAL;
                  TICKET_REC[TICK_DATE] = TODAYS_DATE;
                  TICKET_REC[TICK_TIME] = TIME();
                  TICKET_REC[TICK_TOTAL] = GRAND_TICK_TOTAL;
                  TICKET_REC[TICK_CLERK] = U_INITS;
                  TICKET_REC[TICK_TILL] = TILL_NUMBER;
                  TICKET_REC[TICK_CONCESS] = ENROL_REC[ENROL_CONCESSION][1, 1];
                  TICKET_REC[TICK_PEAK_INDICATOR] = 1;
                  TICKET_REC[TICK_HOME_CENTRE] = COMMON.CENTRE;
                  /*  Payment or Refund (i.e. from FL730) */
                  NARRATIVE = "Cust: " + STUDENT_ID + " " + STUDENT_NAME;
                  NARRATIVE[1, 2] = "Course: " + MAIN_KEY + " " + COURSE_MSTR_REC[COURSE_MSTR_DESC];
                  NARRATIVE[1, 3] = "Runs from " + OCONV(COURSE_DATE, "D") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D");
                  NARR_MV = 3;
                  if (COURSE_DET_REC[COURSE_DET_START_TIME] != "" && COURSE_DET_REC[COURSE_DET_END_TIME] != "")
                  {
                     NARR_MV = NARR_MV + 1;
                     NARRATIVE[1, NARR_MV] = "Times: Starts " + OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT") + " Ends " + OCONV(COURSE_DET_REC[COURSE_DET_END_TIME][1, 1], "MT");
                  }
                  NARR_MV = NARR_MV + 1;
                  NARRATIVE[1, NARR_MV] = "No. of students: " + NO_OF_STUDENTS;
                  if (COMMENTS_PRINTED == "Y")
                  {
                     if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1] != "")
                     {
                        NARR_MV = NARR_MV + 1;
                        NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[1] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
                     }
                     if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2] != "")
                     {
                        NARR_MV = NARR_MV + 1;
                        NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[2] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
                     }
                     if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3] != "")
                     {
                        NARR_MV = NARR_MV + 1;
                        NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[3] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
                     }
                     if (COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4] != "")
                     {
                        NARR_MV = NARR_MV + 1;
                        NARRATIVE[1, NARR_MV] = COURSE_COMMENT_TAGS[4] + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
                     }
                  }
                  NARR_MV = NARR_MV + 1;
                  NARRATIVE[1, NARR_MV] = "Paid " + OCONV(GRAND_TICK_TOTAL, "MD2");
                  TICKET_REC[TICK_TOTAL] = TICKET_REC[TICK_UNIT_PRICE];
                  TICK_REC = "";
                  /*  Dynamic equivalent */
                  TICK_ID = "";
                  PRINT_TICKET_NO = "";
                  /*  TEMPORARILY * */
                  SESSION_NO = "";
                  if (COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != "" && COURSE_MSTR_REC[COURSE_MSTR_CENTRE] != COMMON.CENTRE && CENTRALISED_COURSES == "Y")
                  {
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
                  for (ATT = 1; ATT <= 40; ATT += 1)
                  {
                     TICK_REC[ATT] = TICKET_REC[ATT];
                  }
                  if (BATCH_HEADCOUNTS[1, 1] == "Y")
                  {
                     TICK_REC[21] = 0;
                     TICKET_REC[TICK_HCOUNT] = 0;
                  }
                  FL102 = new FL102();
                  if (TICKET_PRINT_ROUTINE != "")
                  {
                     nrf0 = TICK_REC[4];
                     nrf1 = TICK_REC[5];
                     nrf2 = "";
                     nrf3 = "";
                     nrf4 = "";
                     nrf5 = "COURSE";
                     CallAt_TICKET_PRINT_ROUTINE = new CallAt_TICKET_PRINT_ROUTINE(ref TICKET_PRINT_ROUTINE, ref PRINT_TICKET_NO, ref TICK_REC, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4, ref NARRATIVE, ref nrf5);
                  }
                  else
                  {
                     nrf0 = "";
                     FL000_15 = new FL000_15(ref PRINT_TICKET_NO, ref TICK_REC, ref NARRATIVE, ref nrf0);
                  }
                  MATWRITE(TICKET_REC, COMMON.FILES[FL_TICKETS], TICK_ID);
                  /* ****************************** */
                  NO_STUDENTS = DCOUNT(STUDENT_LIST, VM);
                  STUDENT_MVC = 1;
                  do
                  {
                     if (STUDENT_MVC > NO_STUDENTS) break;
                     if (STUDENT_SELECT_LIST[1, STUDENT_MVC] == TRUE && BALANCE_LIST[1, STUDENT_MVC] > 0)
                     {
                        COURSE_CODE = MAIN_KEY;
                        COURSE_DATE = PROG_MESS[3];
                        STUDENT_ID = STUDENT_LIST[1, STUDENT_MVC];
                        AMOUNT = BALANCE_LIST[1, STUDENT_MVC];
                        COURSE_BALANCE = AMOUNT;
                        ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
                        if (!MATREADU(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
                        if (!MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
                        if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID))
                        {
                           STUDENT_IS_MEMBER = TRUE;
                           STUDENT_NAME = TRIM(MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
                        }
                        else
                        {
                           STUDENT_IS_MEMBER = FALSE;
                           STUDENT_NAME = TRIM(STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
                        }
                        NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
                        PAYMENT_MVC = NO_TRANS + 1;
                        STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, PAYMENT_MVC] = DETAILS_ID;
                        STUDENT_REC[STUDENT_TRANS_DATES][1, PAYMENT_MVC] = TODAYS_DATE;
                        STUDENT_REC[STUDENT_TRANS_TYPES][1, PAYMENT_MVC] = "P";
                        STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, PAYMENT_MVC] = -BALANCE_LIST[1, STUDENT_MVC];
                        STUDENT_REC[STUDENT_TRANS_MOPS][1, PAYMENT_MVC] = MOP;
                        STUDENT_REC[STUDENT_TRANS_USER][1, PAYMENT_MVC] = U_INITS;
                        /*  Put automatically generated receipt no on enrolment record */
                        STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, PAYMENT_MVC] = TICK_ID;
                        STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] - BALANCE_LIST[1, STUDENT_MVC];
                        MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
                        RELEASE();
                     }
                     STUDENT_MVC = STUDENT_MVC + 1;
                  } while (true);
                  nrf0 = "COURSES";
                  nrf1 = "Group payment";
                  nrf2 = "";
                  nrf3 = "";
                  nrf4 = "Total";
                  FL114 = new FL114(ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref GRAND_TICK_TOTAL, ref nrf4);
                  INTERACT = FINISH;
               }
            }// CASE
            else if (MATCH(ANS, "1N") || MATCH(ANS, "2N") || MATCH(ANS, "3N"))
            {
               /*  Validate, then high/lowlight a particular student */
               // BEGIN CASE
               // CASE
               if (ANS > DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM) || ANS == 0)
               {
                  nrf0 = 9;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (XFER_LIST[1, ANS] == TRUE)
               {
                  nrf0 = 29;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (OTHERWISE)
               {
                  if (STUDENT_SELECT_LIST[1, ANS] == TRUE)
                  {
                     STUDENT_SELECT_LIST[1, ANS] = INIT;
                     ERROR_LIST[1, ANS] = INIT;
                  }
                  else
                  {
                     STUDENT_SELECT_LIST[1, ANS] = TRUE;
                  }
                  TOGGLE_POS = ANS;
                  ACTION = TOGGLE;
                  L7000();
                  INTERACT = VALID_DATA;
               }
               // END CASE
            }// CASE
            else if (ANS == "ALL")
            {
               BALANCE_WARNING = FALSE;
               for (N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1)
               {
                  if (XFER_LIST[1, N] != TRUE)
                  {
                     STUDENT_SELECT_LIST[1, N] = TRUE;
                  }
               }
               /* !*           IF BALANCE.WARNING = TRUE THEN */
               /* !*              CALL FL006(PROGRAM,51,INIT) */
               /* !*           END */
               STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               ACTION = SCROLL;
               L7000();
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS == "NONE")
            {
               for (N = 1; N <= DCOUNT(STUDENT_LIST, VM); N += 1)
               {
                  STUDENT_SELECT_LIST[1, N] = "";
               }
               STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               ACTION = SCROLL;
               L7000();
               INTERACT = VALID_DATA;
            }// CASE
            else if (ANS == "")
            {
               ACTION = SCROLL;
               L7000();
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
      /* ******************************************** */
      L0055: ;
         /*  Validate user can leave page 1        * */
         /* ******************************************** */
         /*  Validate that key fields are present before allowing the user to file */
         INTERACT = FINISH;
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
         if (ST_DISPLAY != "D")
         {
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
            PRINT(STR(".", ST_LENGTH));
            PRINT(AT(ST_COL, ST_ROW));
            INPUT(out ANS, ST_LENGTH);
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
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
               INTERACT = BACKUP;
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
         PRINT(AT(0, 3) + NRM_VID);
         /*  Stop wyse taking chunk out of footer */
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
               PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
            }
            // END CASE
         }
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
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
            SCAN_STUDENT_ID = "";
            FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
            /*  Refresh screen */
            L0100();
            if (INTERACT != EXIT)
            {
               PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
               ANS = COURSE_ID;
               MAIN_KEY = ANS;
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
                     END_FIELD = 4;
                     ACTION = FIRST_CALL;
                     L6000();
                     /*  Display selected field data */
                     L7000();
                     /*  Display window */
                     /*            AMENDING = TRUE */
                     OLD_COURSE_DATE = COURSE_DATE;
                     L0300();
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
                  nrf0 = 55;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  VALUE = "";
                  MAIN_KEY = "";
               }
            }
            else
            {
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
               PROG_MESS[2] = MAIN_KEY;
               if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY))
               {
                  if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")
                  {
                     nrf0 = 55;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                     ANS = "";
                     VALUE = "";
                     MAIN_KEY = "";
                  }
                  else
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
                           END_FIELD = 4;
                           ACTION = FIRST_CALL;
                           L6000();
                           /*  Display selected field data */
                           L7000();
                           /*  Display window */
                           AMENDING = FALSE;
                           OLD_COURSE_DATE = SELECT_DATE;
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
      }
      void L1200()
      {
         /*   DUMMY Validation Routine (Display only fields) */
         INTERACT = VALID_DATA;
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
      void L7000()
      {
         /*   DISPLAY ONE SCREENFUL OF STUDENTS */
         nrf0 = COURSE_DET_REC[COURSE_DET_STUDENT_IDS];
         FL755 = new FL755(ref ACTION, ref TOGGLE_POS, ref STUDENT_SELECT_LIST, ref nrf0, ref REDISPLAY, ref STUDENT_COUNT, ref STUDENT_LIST, ref SURNAME_LIST, ref FULL_NAME_LIST, ref CONCESS_LIST, ref BALANCE_LIST, ref ADJUSTMENT_LIST, ref INSTALMENT_LIST, ref ERROR_LIST, ref XFER_LIST, ref WINDOW_DEPTH);
         return;
         /* ******************************** */
      }
      void L8000()
      {
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
