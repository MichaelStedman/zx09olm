//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL758 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CONTROL = 10;
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
      readonly UvVar ENROL_REP_TYPE = 1;
      readonly UvVar ENROL_REP_STUDENT_ID = 2;
      readonly UvVar ENROL_REP_OLD_COURSE_DETAIL_ID = 3;
      readonly UvVar ENROL_REP_NEW_COURSE_DETAIL_ID = 4;
      readonly UvVar ENROL_REP_WAITING_LIST_JOINED = 5;
      readonly UvVar ENROL_REP_COMMENT = 6;
      readonly UvVar ENROL_REP_PREFERENCE_NO = 7;
      readonly UvVar ENROL_REP_COURSE_FEE = 8;
      readonly UvVar ENROL_REP_WAITING_LIST_POSITION = 9;
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
      readonly UvVar HEADIN = 1;
      readonly UvVar FOOTIN = 2;
      readonly UvVar USER_RESPONSE = 3;
      readonly UvVar LINE_COUNT = 4;
      readonly UvVar MAX_LINES = 5;
      readonly UvVar PAGE_NO = 6;
      readonly UvVar FOOT_LINES = 7;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] ENROL_REP_REC = new UvVar[15];
      UvVar[] WAIT_MAST_REC = new UvVar[5];
      UvVar[] WAIT_STUDENT_REC = new UvVar[35];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] QQQ_VARS = new UvVar[7];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar TILL_NUMBER = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar FL_ENROLMENT = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_ENROLMENT_REPORT = "";
      UvVar FL_WAIT_MASTER = "";
      UvVar FL_WAIT_STUDENTS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_MULTIPAY = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FEE_TODAY = "";
      UvVar MULTIPAY_REC = "";
      UvVar BASKET_COUNT = "";
      FL006 FL006;
      UvVar FIRST_PAGE = "";
      UvVar PREFIX = "";
      UvVar FZ045 = "";
      CallAt_FZ045 CallAt_FZ045;
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar PROCESS_EXECUTE = "";
      UvVar CONTROL_REC = "";
      UvVar NO_REPORTS = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar START_TIME = "";
      UvVar EOF = "";
      UvVar SET_COUNT = "";
      UvVar REPORT_SEQ = "";
      UvVar ENROL_ID = "";
      UvVar STUDENT_ID = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar OLD_COURSE_CODE = "";
      UvVar OLD_COURSE_DETAIL_ID = "";
      UvVar PREF_COUNT = "";
      UvVar ENROLLED = "";
      UvVar OUT_OF_PREFS = "";
      UvVar COURSE_ID = "";
      UvVar COURSE_DATE = "";
      UvVar GROUP_MULTIVALUE = "";
      UvVar EQUIVALENT_CONCESSION = "";
      UvVar GROUP_VACANCY = "";
      UvVar ALREADY_ENROLLED = "";
      UvVar TEST_POS = "";
      UvVar TICKET_CONCESS = "";
      UvVar TICKET_CODE = "";
      UvVar TICKET_TYPE = "";
      UvVar SALE_DATE = "";
      UvVar SALE_TIME = "";
      UvVar PERIOD = "";
      FL355 FL355;
      UvVar PRICE = "";
      UvVar RESPONSE = "";
      UvVar TICKET_PRICE = "";
      UvVar CONCESS_POS = "";
      UvVar GROUP_NAME = "";
      UvVar COURSE_CODE = "";
      UvVar ACTIVITY_CODE = "";
      UvVar POS = "";
      UvVar ACT_POS = "";
      UvVar REPORT_COPY = "";
      UvVar FEE_TOTAL = "";
      UvVar REPORT_COUNT = "";
      UvVar REPORT_ID = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar NAME = "";
      UvVar ADDRESS_LINE1 = "";
      UvVar HOME_TEL = "";
      UvVar WORK_TEL = "";
      UvVar NEW_COURSE_CODE = "";
      UvVar NEW_COURSE_DATE = "";
      UvVar INST_PLAN_TOTAL = "";
      UvVar NO_WEEKS = "";
      UvVar INST_NUMBER = "";
      UvVar INST_VALUE = "";
      UvVar INST_FREQUENCY = "";
      UvVar INST_DATES = "";
      UvVar INST_AMOUNTS = "";
      UvVar INST_FIRST_DUE = "";
      UvVar RECALC = "";
      UvVar UNPAID_FEE = "";
      UvVar DISPLAY_PLAN = "";
      FL749 FL749;
      UvVar INTERACT = "";
      UvVar REDISPLAY = "";
      UvVar NEW_ENROL_ID = "";
      UvVar TRANS_MVC = "";
      UvVar NO_MVS = "";
      UvVar PRIORITY_POS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL758()
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
         /*     AUTOMATIC RE-ENROLMENT PROCESS */
         PROGRAM = "FL758";
         /* ************************ */
         /*     DEFINE FILES USED  * */
         /* ************************ */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

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
         #region INCLUDE FL.FILES FL.ENROLMENT.REPORT
         if (!OPEN("FL.ENROLMENT.REPORT", out FL_ENROLMENT_REPORT)) { STOP("201", "FL.ENROLMENT.REPORT"); }

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.MASTER
         if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.STUDENTS
         if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

         /*  Important - keep Wait.Stud.Dates (21) in tandem */

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
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

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
         #region INCLUDE FL.FILES FL.MULTIPAY
         if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

         #endregion
         #region INCLUDE FL.FILES FL.COURSE.PARAMS
         #region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
         if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

         #endregion

         #region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

         #endregion

         #endregion
         if (!READV(ref FEE_TODAY, FL_COURSE_PARAMS, "COURSE.PARAMS", 49)) { FEE_TODAY = "N"; }
         if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
         BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
         if (BASKET_COUNT > 0)
         {
            nrf0 = 85;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         FIRST_PAGE = TRUE;
         #region INCLUDE FZ.LIBRARY HEADING.FOOTING
         /*     INCLUDE HEADING.FOOTING */

         /*     CHECK LINE COUNT AND PRINT HEADINGS/FOOTINGS WHEN NECESSARY */
         /*     This INCLUDE code provides */
         /*     an alternative HEADING/FOOTING facility. */
         /*     This code should be INCLUDEd near the start of your program where */
         /*     it will automatically initialise itself. */
         /*     See HEADING.FOOTING.EXAMPLE on FZ.LIBRARY for instructions on usage. */
         PREFIX = PROGRAM.Substring(1, 2);
         FZ045 = PREFIX + "045";
         MAT(ref QQQ_VARS, "");
         goto L3;

      L2: ;
         CallAt_FZ045 = new CallAt_FZ045(ref FZ045, ref QQQ_VARS, ref FIRST_PAGE);
         return;
      L3: ;

         #endregion
         /* * Routine to set printer parameters  (condensed print) */
         PRINT_START_COMMAND = "";
         PRINT_END_COMMAND = "";
         PRINT_COMMANDS = "";
         nrf0 = "STANDARD";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         PRINT(AT(0, 10) + COMMON.EOS);
         /*  Clear on-screen warnings */
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (!READ(ref CONTROL_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { CONTROL_REC = ""; }
         if (MATCH(CONTROL_REC[5], "1N") || MATCH(CONTROL_REC[5], "2N"))
         {
            NO_REPORTS = CONTROL_REC[5];
         }
         else
         {
            NO_REPORTS = 1;
         }
         PRINT(AT(10, 10) + "Now clearing old report information...");
         CLEARFILE(FL_ENROLMENT_REPORT);
         PRINT(AT(10, 10) + "Now selecting sets of preferences for processing...");
         INSTRUCTION = "SSELECT FL.ENROLMENT WITH PREF1.STATUS = \"\" AND WITH PREF1.CODE # \"\" BY PREF.DATE BY PREF.TIME";
         nrf0 = "SOC";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         PRINT("Done.");
         START_TIME = TIME();
         PRINT(AT(10, 12) + "Time processing started        = " + OCONV(START_TIME, "MT"));
         PRINT(AT(10, 13) + "Number of sets to be processed = " + LIST_AVAILABLE);
         PRINT(AT(10, 14) + "Number of sets processed       = ");
         PRINT(AT(10, 16) + "Selected student's current enrolment details :-");
         PRINT(AT(15, 17) + "Student/member number    =");
         PRINT(AT(15, 18) + "Course code              =");
         PRINT(AT(15, 19) + "Course date              =");
         EOF = FALSE;
         SET_COUNT = 0;
         REPORT_SEQ = 0;
         do
         {
            if (!READNEXT(ref ENROL_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            if (!MATREADU(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
            SET_COUNT = SET_COUNT + 1;
            PRINT(AT(43, 14) + FORMAT((SET_COUNT + "  (" + INT(SET_COUNT / LIST_AVAILABLE) * 100 + "%" + ")"), "L#20"));
            STUDENT_ID = FIELD(ENROL_ID, "*", 3);
            OLD_COURSE_DATE = FIELD(ENROL_ID, "*", 1);
            OLD_COURSE_CODE = FIELD(ENROL_ID, "*", 2);
            OLD_COURSE_DETAIL_ID = OLD_COURSE_DATE + "*" + OLD_COURSE_CODE;
            PRINT(AT(43, 17) + FORMAT(STUDENT_ID, "L#20"));
            PRINT(AT(43, 18) + FORMAT(OLD_COURSE_CODE, "L#20"));
            PRINT(AT(43, 19) + FORMAT(OCONV(OLD_COURSE_DATE, "D"), "L#20"));
            PREF_COUNT = 1;
            ENROLLED = FALSE;
            OUT_OF_PREFS = FALSE;
            do
            {
               if (PREF_COUNT > 3 || ENROLLED || OUT_OF_PREFS) break;
               if (ENROL_REC[PREF_COUNT + 15][1, 1] == "")
               {
                  OUT_OF_PREFS = TRUE;
               }
               else
               {
                  COURSE_ID = ENROL_REC[PREF_COUNT + 15][1, 1];
                  COURSE_DATE = FIELD(COURSE_ID, "*", 1);
                  if (!MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_ID)) { MAT(ref COURSE_DET_REC, ""); }
                  /*  Validate whether enrolment is possible */
                  GROUP_MULTIVALUE = "";
                  EQUIVALENT_CONCESSION = TRUE;
                  GROUP_VACANCY = TRUE;
                  ALREADY_ENROLLED = FALSE;
                  if (LOCATE(STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref TEST_POS, "AL"))
                  {
                     ALREADY_ENROLLED = TRUE;
                  }
                  if (ENROL_REC[PREF_COUNT + 15][1, 3] != "")
                  {
                     /*  Defined by user entering preferences */
                     TICKET_CONCESS = ENROL_REC[PREF_COUNT + 15][1, 3];
                  }
                  else
                  {
                     TICKET_CONCESS = ENROL_REC[ENROL_CONCESSION][1, 1];
                     /*  from old course */
                  }
                  TICKET_CONCESS = TRIM(TICKET_CONCESS);
                  TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
                  TICKET_TYPE = "C";
                  /*  DJA 26.1.05 */
                  /* !IF FEE.TODAY = "Y" THEN */
                  /* ! SALE.DATE = TODAYS.DATE */
                  /* !END ELSE */
                  SALE_DATE = COURSE_DATE;
                  /* !END */
                  SALE_TIME = TIME();
                  PERIOD = "";
                  FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
                  /* !*           ENROL.CONCESSION = TRIM(ENROL.CONCESSION) */
                  TICKET_PRICE = 0;
                  if (LOCATE(TICKET_CONCESS, TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL"))
                  {
                     TICKET_PRICE = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESS_POS];
                     GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESS_POS];
                     if (GROUP_NAME != "")
                     {
                        if (LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP_MULTIVALUE, "AL"))
                        {
                           if (COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] <= 0)
                           {
                              GROUP_VACANCY = FALSE;
                           }
                        }
                     }
                  }
                  else
                  {
                     EQUIVALENT_CONCESSION = FALSE;
                  }
                  if (COURSE_DET_REC[COURSE_DET_VACANCIES] > 0 && GROUP_VACANCY && EQUIVALENT_CONCESSION && NOT(ALREADY_ENROLLED))
                  {
                     L0100();
                     /*  Perform enrolment */
                     ENROLLED = TRUE;
                     ENROL_REC[PREF_COUNT + 15][1, 2] = "S";
                     /*  Successful */
                     // BEGIN CASE
                     // CASE
                     if (PREF_COUNT == 1)
                     {
                        if (ENROL_REC[17][1, 1] != "") { ENROL_REC[17][1, 2] = "N"; /*  Not required */ }
                        if (ENROL_REC[18][1, 1] != "") { ENROL_REC[18][1, 2] = "N"; /*  Not required */ }
                     }// CASE
                     else if (PREF_COUNT == 2)
                     {
                        if (ENROL_REC[18][1, 1] != "") { ENROL_REC[18][1, 2] = "N"; /*  Not required */ }
                     }
                     // END CASE
                  }
                  else
                  {
                     ENROL_REC[PREF_COUNT + 15][1, 2] = "U";
                     /*  Unsuccessful */
                  }
                  PREF_COUNT = PREF_COUNT + 1;
               }
            } while (true);
            if (NOT(ENROLLED))
            {
               /*  Put them on the waiting list associated with their first preference */
               ENROL_REC[ENROL_PREFERRED_COURSE1][1, 2] = "P";
               COURSE_CODE = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1], "*", 2);
               if (!READV(ref ACTIVITY_CODE, FL_COURSE_MASTER, COURSE_CODE, 3)) { ACTIVITY_CODE = ""; }
               MAT(ref ENROL_REP_REC, "");
               ENROL_REP_REC[ENROL_REP_TYPE] = "P";
               ENROL_REP_REC[ENROL_REP_STUDENT_ID] = STUDENT_ID;
               ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID] = OLD_COURSE_DETAIL_ID;
               if (!MATREAD(ref WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE)) { MAT(ref WAIT_MAST_REC, ""); }
               ENROL_REP_REC[ENROL_REP_WAITING_LIST_JOINED] = ACTIVITY_CODE;
               if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL"))
               {
                  /*  Already on waiting list */
                  if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, POS] != "P")
                  {
                     ENROL_REP_REC[ENROL_REP_COMMENT] = "Made a priority";
                     WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, POS, 0);
                     WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, POS, 0);
                     L0200();
                     MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
                  }
                  else
                  {
                     ENROL_REP_REC[ENROL_REP_COMMENT] = "Already a priority";
                     ENROL_REP_REC[ENROL_REP_WAITING_LIST_POSITION] = POS;
                  }
               }
               else
               {
                  /*  Create a waiting list student record IF NECESSARY */
                  if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID))
                  {
                     if (!(LOCATE(ACTIVITY_CODE, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref ACT_POS, "AL")))
                     {
                        WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, -1] = ACTIVITY_CODE;
                        WAIT_STUDENT_REC[WAIT_STUD_DATES][1, -1] = TODAYS_DATE;
                        MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
                     }
                  }
                  else
                  {
                     MAT(ref WAIT_STUDENT_REC, "");
                     if (!MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
                     /*  DJA 31.07.00  If student is a member then most of these fields */
                     /*                will be null */
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
                     WAIT_STUDENT_REC[WAIT_STUD_DATES] = TODAYS_DATE;
                     WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = ACTIVITY_CODE;
                     MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
                  }
                  L0200();
                  MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
               }
               REPORT_SEQ = REPORT_SEQ + 1;
               MATWRITE(ENROL_REP_REC, FL_ENROLMENT_REPORT, REPORT_SEQ);
            }
            MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
            RELEASE();
         } while (true);
         REPORT_COPY = 0;
         do
         {
            if (REPORT_COPY >= NO_REPORTS) break;
            PRINT(AT(10, 20) + "Producing report of successful enrolments.....");
            /*  Produce the report of successful enrolments */
            QQQ_VARS[HEADIN] = "(FL758.1)" + SPACE(20) + "Successful Automatic Re-Enrolments" + SPACE(20) + "'DL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(29) + "----------------------------------'LL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Student/Member Name & Address           Home Tel        Work Tel       Old Course                New Course                Pref  Fee Due" + "'LL'";
            QQQ_VARS[LINE_COUNT] = 0;
            PRINTER_ON();
            PRINT(PRINT_START_COMMAND);
            L1();
            INSTRUCTION = "SSELECT FL.ENROLMENT.REPORT WITH TYPE = \"S\" BY STUDENT.SURNAME";
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            EOF = FALSE;
            FEE_TOTAL = 0;
            REPORT_COUNT = 0;
            do
            {
               if (!READNEXT(ref REPORT_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
               if (EOF) break;
               REPORT_COUNT = REPORT_COUNT + 1;
               if (!MATREAD(ref ENROL_REP_REC, FL_ENROLMENT_REPORT, REPORT_ID)) { MAT(ref ENROL_REP_REC, ""); }
               FEE_TOTAL = FEE_TOTAL + ENROL_REP_REC[ENROL_REP_COURSE_FEE];
               PRINT(FORMAT(ENROL_REP_REC[ENROL_REP_STUDENT_ID], "L#15"));
               if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, ENROL_REP_REC[ENROL_REP_STUDENT_ID])) { MAT(ref STUDENT_REC, ""); }
               STUDENT_IS_MEMBER = FALSE;
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ENROL_REP_REC[ENROL_REP_STUDENT_ID]))
               {
                  STUDENT_IS_MEMBER = TRUE;
                  NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
                  ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  HOME_TEL = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
                  WORK_TEL = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
               }
               else
               {
                  NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
                  ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
                  HOME_TEL = STUDENT_REC[STUDENT_HOME_TEL];
                  WORK_TEL = STUDENT_REC[STUDENT_WORK_TEL];
               }
               PRINT(FORMAT(NAME, "L#24") + SPACE(1));
               PRINT(FORMAT(HOME_TEL, "L#15") + FORMAT(WORK_TEL, "L#15") + SPACE(1));
               OLD_COURSE_CODE = FIELD(ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID], "*", 2);
               OLD_COURSE_DATE = FIELD(ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID], "*", 1);
               PRINT(FORMAT(OLD_COURSE_CODE, "L#15") + SPACE(1) + FORMAT(OCONV(OLD_COURSE_DATE, "D2/"), "L#8") + SPACE(2));
               NEW_COURSE_CODE = FIELD(ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID], "*", 2);
               NEW_COURSE_DATE = FIELD(ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID], "*", 1);
               PRINT(FORMAT(NEW_COURSE_CODE, "L#15") + SPACE(1) + FORMAT(OCONV(NEW_COURSE_DATE, "D2/"), "L#8") + SPACE(2));
               PRINT(SPACE(2) + FORMAT(ENROL_REP_REC[ENROL_REP_PREFERENCE_NO], "L#1") + SPACE(3));
               PRINT(FORMAT(OCONV(ENROL_REP_REC[ENROL_REP_COURSE_FEE], "MD2"), "R#7"));
               L1();
               PRINT(SPACE(15) + FORMAT(ADDRESS_LINE1, "L#24"));
               L1();
            } while (true);
            /*  Print totals */
            L1();
            PRINT(FORMAT(("Total Fees Due = " + OCONV(FEE_TOTAL, "MD2")), "R#131"));
            L1();
            PRINT(PRINT_END_COMMAND);
            PRINTER_CLOSE();
            PRINTER_OFF();
            PRINT(AT(56, 20) + "Done.");
            /*  Produce the report of waiting list additions */
            PRINT(AT(10, 21) + "Producing report of unsuccessful enrolments...");
            INSTRUCTION = "SSELECT FL.ENROLMENT.REPORT WITH TYPE = \"P\" BY STUDENT.SURNAME";
            QQQ_VARS[HEADIN] = "(FL758.2)" + SPACE(20) + "Unsuccessful Re-Enrolments Added to Waiting Lists" + SPACE(20) + "'DL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(29) + "-------------------------------------------------'LL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Student/Member   Name & Address             Home & Work Tel            Old Course                Waiting List  Comments" + "'LL'";
            QQQ_VARS[LINE_COUNT] = 0;
            PRINTER_ON();
            PRINT(PRINT_START_COMMAND);
            L1();
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            EOF = FALSE;
            REPORT_COUNT = 0;
            do
            {
               if (!READNEXT(ref REPORT_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
               if (EOF) break;
               REPORT_COUNT = REPORT_COUNT + 1;
               if (!MATREAD(ref ENROL_REP_REC, FL_ENROLMENT_REPORT, REPORT_ID)) { MAT(ref ENROL_REP_REC, ""); }
               PRINT(FORMAT(ENROL_REP_REC[ENROL_REP_STUDENT_ID], "L#15") + SPACE(2));
               if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, ENROL_REP_REC[ENROL_REP_STUDENT_ID])) { MAT(ref STUDENT_REC, ""); }
               STUDENT_IS_MEMBER = FALSE;
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ENROL_REP_REC[ENROL_REP_STUDENT_ID]))
               {
                  STUDENT_IS_MEMBER = TRUE;
                  NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
                  ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  HOME_TEL = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
                  WORK_TEL = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
               }
               else
               {
                  NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
                  ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
                  HOME_TEL = STUDENT_REC[STUDENT_HOME_TEL];
                  WORK_TEL = STUDENT_REC[STUDENT_WORK_TEL];
               }
               PRINT(FORMAT(NAME, "L#25") + SPACE(2));
               PRINT(FORMAT(HOME_TEL, "L#27"));
               OLD_COURSE_CODE = FIELD(ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID], "*", 2);
               OLD_COURSE_DATE = FIELD(ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID], "*", 1);
               PRINT(FORMAT(OLD_COURSE_CODE, "L#15") + SPACE(1) + FORMAT(OCONV(OLD_COURSE_DATE, "D2/"), "L#8") + SPACE(2));
               PRINT(FORMAT(ENROL_REP_REC[ENROL_REP_WAITING_LIST_JOINED], "L#12") + SPACE(2));
               PRINT(ENROL_REP_REC[ENROL_REP_COMMENT]);
               L1();
               PRINT(SPACE(17) + FORMAT(ADDRESS_LINE1, "L#25") + SPACE(2) + WORK_TEL);
               L1();
            } while (true);
            PRINT(PRINT_END_COMMAND);
            PRINTER_CLOSE();
            PRINTER_OFF();
            REPORT_COPY = REPORT_COPY + 1;
         } while (true);
         PRINT(AT(56, 21) + "Done.");
         /* ************************************* */
         /*   Return to calling program         * */
         /* ************************************* */
         return;
         /* ******************************************************** */
      }
      void L0100()
      {
         /*   Perform an enrolment after validation has been   * */
         /*       successfully performed                           * */
         /* ******************************************************** */
         if (GROUP_MULTIVALUE != "")
         {
            COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP_MULTIVALUE] - 1;
         }
         COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_VACANCIES] - 1;
         COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, -1] = STUDENT_ID;
         /*  Need to write a new enrolment record, but there are still updates */
         /*  to the original one to write (preference status) */
         MAT(ref COPY_ENROL_REC, ENROL_REC);
         ENROL_REC[ENROL_PRICE] = TICKET_PRICE;
         ENROL_REC[ENROL_AWARD] = "";
         /*  redundant field from 18.5.00 */
         /*  Next 3 fields are redundant */
         ENROL_REC[ENROL_ODD_INSTALMENT] = "";
         ENROL_REC[ENROL_OTHER_INSTALMENT] = "";
         ENROL_REC[ENROL_NO_INSTALMENTS] = "";
         ENROL_REC[ENROL_CONCESSION] = TICKET_CONCESS;
         if (ENROL_REC[ENROL_INST_DATES] != "")
         {
            INST_PLAN_TOTAL = ENROL_REC[ENROL_PRICE];
            NO_WEEKS = INT(((COURSE_DET_REC[COURSE_DET_END] - COURSE_DATE) / 7)) + 1;
            INST_NUMBER = NO_WEEKS;
            INST_VALUE = "";
            INST_FREQUENCY = "W";
            INST_DATES = "";
            INST_AMOUNTS = "";
            INST_FIRST_DUE = COURSE_DATE;
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
         ENROL_REC[ENROL_FULL_PRICE] = "";
         ENROL_REC[ENROL_FEE_OVERRIDE_USER] = "";
         ENROL_REC[ENROL_PREFERRED_COURSE1] = "";
         ENROL_REC[ENROL_PREFERRED_COURSE2] = "";
         ENROL_REC[ENROL_PREFERRED_COURSE3] = "";
         ENROL_REC[ENROL_PREFERENCES_DATE] = "";
         ENROL_REC[ENROL_PREFERENCES_TIME] = "";
         NEW_ENROL_ID = COURSE_ID + "*" + STUDENT_ID;
         MATWRITE(ENROL_REC, FL_ENROLMENT, NEW_ENROL_ID);
         MAT(ref ENROL_REC, COPY_ENROL_REC);
         /*  Update student file - one transaction for course fee */
         if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
         if (!(LOCATE(COURSE_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref TEST_POS, "AL")))
         {
            STUDENT_REC[STUDENT_DETAIL_IDS][1, -1] = COURSE_ID;
         }
         TRANS_MVC = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM) + 1;
         STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_MVC] = COURSE_ID;
         STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC] = TODAYS_DATE;
         STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] = "O";
         /*  Original debit */
         STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_MVC] = TICKET_PRICE;
         STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, TRANS_MVC] = "";
         STUDENT_REC[STUDENT_TRANS_MOPS][1, TRANS_MVC] = "";
         STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + TICKET_PRICE;
         MAT(ref ENROL_REP_REC, "");
         ENROL_REP_REC[ENROL_REP_TYPE] = "S";
         /*  Successful */
         ENROL_REP_REC[ENROL_REP_STUDENT_ID] = STUDENT_ID;
         ENROL_REP_REC[ENROL_REP_OLD_COURSE_DETAIL_ID] = OLD_COURSE_DETAIL_ID;
         ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID] = COURSE_ID;
         ENROL_REP_REC[ENROL_REP_PREFERENCE_NO] = PREF_COUNT;
         ENROL_REP_REC[ENROL_REP_COURSE_FEE] = TICKET_PRICE;
         REPORT_SEQ = REPORT_SEQ + 1;
         MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
         MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_ID);
         MATWRITE(ENROL_REP_REC, FL_ENROLMENT_REPORT, REPORT_SEQ);
         return;
         /* ******************************************************* */
      }
      void L0200()
      {
         /*   Insert a priority entry on the waiting list     * */
         /*       master file                                     * */
         /* ******************************************************* */
         NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
         PRIORITY_POS = 1;
         do
         {
            if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, PRIORITY_POS] != "P" || PRIORITY_POS > NO_MVS) break;
            PRIORITY_POS = PRIORITY_POS + 1;
         } while (true);
         WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, PRIORITY_POS, 0, STUDENT_ID);
         WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, PRIORITY_POS, 0, "P");
         ENROL_REP_REC[ENROL_REP_WAITING_LIST_POSITION] = PRIORITY_POS;
         return;
      }
      void L1()
      {
         if (QQQ_VARS[LINE_COUNT] < 1)
         {
            CallAt_FZ045 = new CallAt_FZ045(ref FZ045, ref QQQ_VARS, ref FIRST_PAGE);
         }
         else
         {
            QQQ_VARS[LINE_COUNT] = QQQ_VARS[LINE_COUNT] - 1;
            PRINT();
         }
         return;
         /* ************************************ */
         /*   End of program                   * */
         /* ************************************ */
      }
   }
}
