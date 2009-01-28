//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL757 : UvBase
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
      readonly UvVar APACS_MEMBER = 1;
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
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] APACS_REC = new UvVar[10];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar SCREEN_CODE = "";
      UvVar SCR_POS = "";
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar NRM_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar GO_BACK = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar DOTS_ONLY = "";
      UvVar JUST = "";
      UvVar PROCESS_LOCKED = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_ENROLMENT = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_APACS_NUMBERS = "";
      UvVar SMART_CARD = "";
      UvVar MEMBER_CONCESSIONS = "";
      UvVar FEE_TODAY = "";
      UvVar ENROL_ID = "";
      UvVar MAX_FIELDS = "";
      UvVar DATA_FIELDS = "";
      UvVar DISPLAY_ONLY_FIELDS = "";
      UvVar ENTRY_FIELDS = "";
      UvVar FIELD_COUNT = "";
      UvVar BALANCE = "";
      UvVar ACTION = "";
      UvVar LINE = "";
      UvVar POS = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar COURSE_ATT = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      FL006 FL006;
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
      UvVar ST_VALIDATION_CODE = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar CODE_FOR_DISPLAY = "";
      UvVar DISPLAY_STRING = "";
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
      UvVar ST_ATT_MV = "";
      UvVar I = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar DISP_VALIDATION_CODE = "";
      UvVar MATCH_LIST = "";
      FL723 FL723;
      UvVar REDISPLAY = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      UvVar PADDED_MAIN_KEY = "";
      FL000_40 FL000_40;
      UvVar STUDENT_IS_MEMBER = "";
      UvVar STUDENT_EXISTS = "";
      UvVar SCAN_STUDENT_ID = "";
      UvVar DISPLAY_MODE = "";
      FL717 FL717;
      UvVar COURSE_ID = "";
      UvVar COURSE_DATE = "";
      UvVar DETAILS_ID = "";
      UvVar ACCESS_ALLOWED = "";
      UvVar DATE_LIST = "";
      UvVar CREATION_ALLOWED = "";
      FL704 FL704;
      UvVar NEW_COURSE = "";
      UvVar COURSE_TEXT = "";
      UvVar COURSE_TEXT2 = "";
      UvVar TEXT_COL = "";
      UvVar TEXT_JUST = "";
      UvVar TEMP_COURSE_ID = "";
      UvVar TEMP_COURSE_DATE = "";
      UvVar TEMP_DETAILS_ID = "";
      UvVar TICKET_CONCESS = "";
      UvVar PERIOD = "";
      UvVar TICKET_PRICE = "";
      UvVar SALE_DATE = "";
      UvVar SALE_TIME = "";
      UvVar TICKET_CODE = "";
      UvVar TICKET_TYPE = "";
      UvVar MEMBER_NUMBER = "";
      FL355 FL355;
      UvVar PRICE = "";
      UvVar RESPONSE = "";
      FL048 FL048;
      UvVar EQUIVALENT_CONCESSION = "";
      UvVar TEST_CONCESSION = "";
      UvVar CONCESS_POS = "";
      UvVar OLD_INTERACT = "";
      UvVar ANS2 = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL757(ref UvVar SCREEN_CODE, ref UvVar SCR_POS)
      {
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
         /*     RE-ENROLMENT PREFERENCES */
         PROMPT("");
         PROGRAM = "FL757";
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
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.APACS.NUMBERS
         if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

         #endregion
         if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1)))
         {
            SMART_CARD = FALSE;
         }
         MAT(ref TEMP_REC, "");
         if (!READV(ref MEMBER_CONCESSIONS, FL_COURSE_PARAMS, "COURSE.PARAMS", 21)) { MEMBER_CONCESSIONS = ""; }
         if (!READV(ref FEE_TODAY, FL_COURSE_PARAMS, "COURSE.PARAMS", 49)) { FEE_TODAY = "N"; }
         MEMBER_CONCESSIONS = MEMBER_CONCESSIONS[1, 1];
         /* ********************************** */
         /*   EXTRACT DATA INPUT FIELDS      * */
         /* ********************************** */
         ENROL_ID = "";
         MAX_FIELDS = 0;
         SCREEN_LINES = 0;
         DATA_FIELDS = "";
         DISPLAY_ONLY_FIELDS = "";
         ENTRY_FIELDS = "";
         FIELD_COUNT = 0;
         BALANCE = 0;
         ACTION = "";
         do
         {
            LINE = SCR_POS[SCREEN_LINES + 1];
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
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     if (INTERACT != LIMIT) { L0060(); }
                     if (INTERACT || AMENDING || FIELD_NO == 13) break;
                     /*  Drop to foot of screen once a preferred course code is clr'd or left */
                     /*  blank by the user pressing <return> */
                     if (FIELD_NO == 5 || FIELD_NO == 8 || FIELD_NO == 11)
                     {
                        // BEGIN CASE
                        // CASE
                        if (FIELD_NO == 5)
                        {
                           COURSE_ATT = 4;
                        }// CASE
                        else if (FIELD_NO == 8)
                        {
                           COURSE_ATT = 8;
                        }// CASE
                        else if (FIELD_NO == 11)
                        {
                           COURSE_ATT = 12;
                        }// CASE
                        else if (OTHERWISE)
                        {
                           COURSE_ATT = 5;
                        }
                        // END CASE
                        /* ***                IF TEMP.REC(FIELD.NO-1) = "" THEN */
                        if (TEMP_REC[COURSE_ATT] == "")
                        {
                           AMENDING = TRUE;
                           FIELD_NO = MAX_FIELDS;
                           INTERACT = LIMIT;
                           /*  Clear dots from fields to be 'skipped' */
                           START_FIELD = 5;
                           END_FIELD = 13;
                           L6000();
                        }
                        else
                        {
                           FIELD_NO = FIELD_NO + 1;
                        }
                     }
                     else
                     {
                        FIELD_NO = FIELD_NO + 1;
                     }
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
                  else if (FIELD_NO >= 13)
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
               /* **        IF MAIN.KEY # "" AND INTERACT # EXIT AND TEMP.REC(5) # 0 THEN */
               if (MAIN_KEY != "" && ENROL_ID != "" && INTERACT != EXIT)
               {
                  /*  Apply file updates at this point */
                  L9000();
                  MATWRITE(ENROL_REC, FL_ENROLMENT, ENROL_ID);
               }
            }
            if (INTERACT == EXIT || (SMART_CARD && INTERACT == FINISH)) break;
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
         do
         {
            INPUT_LINE = "  Field no. to amend, 'C'lear notes or 'F'inish ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 4);
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (ANS == "F")
            {
               L0055();
            }// CASE
            else if (ANS == "C")
            {
               /*  Clear indicators from previous batch run */
               if (TEMP_REC[6] == "")
               {
                  nrf0 = 50;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  L5000();
               }
            }// CASE
            else if (MATCH(ANS, "1N"))
            {
               if (ANS >= 1 && ANS <= 5)
               {
                  INTERACT = VALID_DATA;
                  // BEGIN CASE
                  // CASE
                  if (ANS >= 1 && ANS <= 3 && TEMP_REC[6] != "")
                  {
                     /*  Indicator(s) from previous batch run must be cleared before */
                     /*  amendments to course preferences can be carried out */
                     nrf0 = 49;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }// CASE
                  else if (ANS == 1)
                  {
                     FIELD_NO = 5;
                  }// CASE
                  else if (ANS == 2)
                  {
                     if (TEMP_REC[4] == "")
                     {
                        /*  Previous preferred course code must exist */
                        nrf0 = 45;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                     }
                     else
                     {
                        FIELD_NO = 8;
                     }
                  }// CASE
                  else if (ANS == 3)
                  {
                     if (TEMP_REC[8] == "")
                     {
                        /*  Previous preferred course code must exist */
                        nrf0 = 45;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                     }
                     else
                     {
                        FIELD_NO = 11;
                     }
                  }// CASE
                  else if (ANS == 4)
                  {
                     FIELD_NO = 14;
                  }// CASE
                  else if (ANS == 5)
                  {
                     FIELD_NO = 15;
                  }
                  // END CASE
               }
               else
               {
                  nrf0 = 10;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* ******************************************** */
      }
      void L0055()
      {
         /*  Validate user can file these details */
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
            /*  Go straight to scanning window after student id is established */
            if (FIELD_NO == 4)
            {
               ANS = COMMON.HELP;
            }
            else
            {
               PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
               PRINT(AT(ST_COL, ST_ROW));
               PRINT(STR(".", ST_LENGTH));
               PRINT(AT(ST_COL, ST_ROW));
               /*  Smart card may already be positioned in the reader */
               SMARTCARD_READ = FALSE;
               if (SMART_CARD && FIELD_NO == 1)
               {
                  L0062();
               }
               if (NOT(SMARTCARD_READ))
               {
                  if (FIELD_NO == 1)
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
                  if (MEMBER_PROGRAM != "")
                  {
                     CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
                  }
                  else
                  {
                     INPUT(out ANS, ST_LENGTH);
                  }
                  if (ANS == "" && VALUE == "" && FIELD_NO == 1 && SMART_CARD)
                  {
                     SMARTCARD_READ = FALSE;
                     if (SMART_CARD && FIELD_NO == 1)
                     {
                        L0062();
                        /*  Re-try card read in case it was presented 'late' */
                     }
                  }
               }
            }
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
               if (ST_VALIDATION_CODE.Substring(1, 1) == "P")
               {
                  /*  This is a Preferred course code field.  May need to 'shuffle up' */
                  /*  the other details, and clear the two fields associated with this one */
                  L0065();
               }
            }// CASE
            else if (ANS == "" && VALUE == "" && ST_MANDATORY != "")
            {
               nrf0 = 5;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (ANS == COMMON.CLR && ST_MANDATORY != "")
            {
               nrf0 = 5;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (ANS == "" && VALUE != "" && FIELD_NO > 1)
            {
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
                  case 2: L1100(); break;
                  case 3: L1100(); break;
                  case 4: L1200(); break;
                  case 5: L1300(); break;
                  case 6: L1100(); break;
                  case 7: L1100(); break;
                  case 8: L1300(); break;
                  case 9: L1100(); break;
                  case 10: L1100(); break;
                  case 11: L1300(); break;
                  case 12: L1100(); break;
                  case 13: L1100(); break;
                  case 14: L1600(); break;
                  case 15: L1700(); break;
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
               if (ST_VALIDATION_CODE == "C")
               {
                  CODE_FOR_DISPLAY = VALUE;
                  L7000();
               }
               else
               {
                  DISPLAY_STRING = VALUE;
               }
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(DISPLAY_STRING, ST_JUST));
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
         /* ************************************* */
      }
      void L0062()
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
         /* ********************************************************* */
      }
      void L0065()
      {
         /*   Extra processing when a course code is cleared    * */
         /* ********************************************************* */
         TEMP_REC[ST_ATT] = "";
         TEMP_REC[ST_ATT + 1] = "";
         TEMP_REC[ST_ATT + 2] = "";
         TEMP_REC[ST_ATT + 3] = "";
         // BEGIN CASE
         // CASE
         if (ST_VALIDATION_CODE == "P1")
         {
            /*  First preferred course was cleared */
            TEMP_REC[ST_ATT] = TEMP_REC[ST_ATT + 4];
            TEMP_REC[ST_ATT + 1] = TEMP_REC[ST_ATT + 5];
            TEMP_REC[ST_ATT + 2] = TEMP_REC[ST_ATT + 6];
            TEMP_REC[ST_ATT + 3] = TEMP_REC[ST_ATT + 7];
            TEMP_REC[ST_ATT + 4] = TEMP_REC[ST_ATT + 8];
            TEMP_REC[ST_ATT + 5] = TEMP_REC[ST_ATT + 9];
            TEMP_REC[ST_ATT + 6] = TEMP_REC[ST_ATT + 10];
            TEMP_REC[ST_ATT + 7] = TEMP_REC[ST_ATT + 11];
            TEMP_REC[ST_ATT + 8] = "";
            TEMP_REC[ST_ATT + 9] = "";
            TEMP_REC[ST_ATT + 10] = "";
            TEMP_REC[ST_ATT + 11] = "";
            START_FIELD = 5;
            END_FIELD = 13;
            L6000();
         }// CASE
         else if (ST_VALIDATION_CODE == "P2")
         {
            /*  Second preferred course was cleared */
            TEMP_REC[ST_ATT] = TEMP_REC[ST_ATT + 4];
            TEMP_REC[ST_ATT + 1] = TEMP_REC[ST_ATT + 5];
            TEMP_REC[ST_ATT + 2] = TEMP_REC[ST_ATT + 6];
            TEMP_REC[ST_ATT + 3] = TEMP_REC[ST_ATT + 7];
            TEMP_REC[ST_ATT + 4] = "";
            TEMP_REC[ST_ATT + 5] = "";
            TEMP_REC[ST_ATT + 6] = "";
            TEMP_REC[ST_ATT + 7] = "";
            START_FIELD = 8;
            END_FIELD = 13;
            L6000();
         }// CASE
         else if (ST_VALIDATION_CODE == "P3")
         {
            /*  Third preferred course was cleared */
            TEMP_REC[ST_ATT] = "";
            TEMP_REC[ST_ATT + 1] = "";
            TEMP_REC[ST_ATT + 2] = "";
            TEMP_REC[ST_ATT + 3] = "";
            START_FIELD = 11;
            END_FIELD = 13;
            L6000();
         }
         // END CASE
         VALUE = TEMP_REC[ST_ATT];
         /*  0060 will redisplay current field */
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
            PRINT(AT(1, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, PRINT_LINE) + SPACE(76));
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
         ST_VALIDATION_CODE = FIELD_DATA[1, 12];
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
            DISP_VALIDATION_CODE = FIELD_DATA[1, 12];
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
               if (DISP_VALIDATION_CODE == "C")
               {
                  /*  Code for translation to text */
                  CODE_FOR_DISPLAY = TEMP_REC[DISP_ATT][1, DISP_MV];
                  L7000();
               }
               else
               {
                  DISPLAY_STRING = FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST);
               }
               PRINT(FORMAT(DISPLAY_STRING, DISP_JUST));
            }
            // END CASE
         }
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
         #region INCLUDE FL.PROCESSING FL757.VALIDATION

      }
      void L1000()
      {
         /*  Validate Student/Member No */
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
         }
         if (INTERACT != EXIT)
         {
            INTERACT = VALID_DATA;
         }
         // BEGIN CASE
         // CASE
         if (INTERACT == EXIT)
         {
            ANS = "";
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
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
               PADDED_MAIN_KEY = MAIN_KEY;
               FL000_40 = new FL000_40(ref PADDED_MAIN_KEY);
               STUDENT_IS_MEMBER = FALSE;
               STUDENT_EXISTS = FALSE;
               if (MATREADU(ref STUDENT_REC, FL_STUDENTS, MAIN_KEY))
               {
                  STUDENT_EXISTS = TRUE;
               }
               else
               {
                  if (MATREADU(ref STUDENT_REC, FL_STUDENTS, PADDED_MAIN_KEY))
                  {
                     STUDENT_EXISTS = TRUE;
                     MAIN_KEY = PADDED_MAIN_KEY;
                     ANS = MAIN_KEY;
                     VALUE = MAIN_KEY;
                  }
               }
               if (STUDENT_EXISTS)
               {
                  /*  If this student is also a member, then MAIN.KEY will already */
                  /*  have been assigned as the 'padded' number above, where necesary */
                  if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MAIN_KEY))
                  {
                     STUDENT_IS_MEMBER = TRUE;
                     TEMP_REC[1] = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
                     TEMP_REC[2] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  }
                  else
                  {
                     TEMP_REC[1] = TRIM(STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
                     TEMP_REC[2] = STUDENT_REC[STUDENT_ADDRESS1];
                  }
                  START_FIELD = 2;
                  END_FIELD = 3;
                  L6000();
                  /*  Display selected fields */
               }
               else
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  ANS = "";
                  MAIN_KEY = "";
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
         else if (OTHERWISE)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }
         // END CASE
         return;
      }
      void L1100()
      {
         /*   DUMMY Validation Routine (Display only fields) */
         INTERACT = VALID_DATA;
         return;
      }
      void L1200()
      {
         /*   Course Code Validation Routine */
         INTERACT = VALID_DATA;
         // BEGIN CASE
         /*  Scan for required course if the 'help' key is entered */
         // CASE
         if (ANS == COMMON.HELP && AMENDING == FALSE)
         {
            SCAN_STUDENT_ID = MAIN_KEY;
            DISPLAY_MODE = 3;
            FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
            if (INTERACT == FINISH) { INTERACT = VALID_DATA; }
            /*  Refresh screen */
            if (REDISPLAY)
            {
               L0100();
               START_FIELD = 1;
               END_FIELD = 4;
               L6000();
               /*  Display selected fields */
            }
            if (INTERACT != EXIT)
            {
               PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(COURSE_ID, ST_JUST));
               ANS = COURSE_ID;
               DETAILS_ID = COURSE_DATE + "*" + COURSE_ID;
               if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
               if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")
               {
                  nrf0 = 55;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  /*  Because FL717 auto-selects the course if there's only one, */
                  /*  if the following line assigns INVALID.DATA the user is */
                  /*  stuck in a loop! */
                  INTERACT = EXIT;
               }
               else
               {
                  if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                  {
                     /*  Check student is enrolled in this course */
                     ACCESS_ALLOWED = FALSE;
                     if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
                     {
                        ACCESS_ALLOWED = TRUE;
                     }
                     if (ACCESS_ALLOWED == TRUE)
                     {
                        L1220();
                        /*  display course data */
                        if (ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1] != "")
                        {
                           AMENDING = TRUE;
                           L8000();
                           L0300();
                           /*  Have these preferences been processed? If so, give option to clear. */
                           if (ENROL_REC[ENROL_PREFERRED_COURSE1][1, 2] != "")
                           {
                              L5000();
                              FIELD_DATA = DATA_FIELDS[FIELD_NO];
                              L0200();
                              VALUE = ANS;
                           }
                        }
                        else
                        {
                           L8000();
                           START_FIELD = 14;
                           END_FIELD = 15;
                           L6000();
                        }
                     }
                     else
                     {
                        nrf0 = 8;
                        nrf1 = INIT;
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                        VALUE = "";
                        ANS = "";
                        AMENDING = FALSE;
                     }
                  }
                  else
                  {
                     INTERACT = INVALID_DATA;
                     nrf0 = 3;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
                  }
               }
            }
            else
            {
               /*  Abandoned window */
               NULL();
            }
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
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
               COURSE_ID = VALUE;
               if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, VALUE))
               {
                  if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")
                  {
                     nrf0 = 55;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                  }
                  else
                  {
                     /*  Call date selection window */
                     DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
                     CREATION_ALLOWED = FALSE;
                     PROG_MESS[2] = COURSE_ID;
                     if (DCOUNT(DATE_LIST, VM) == 1)
                     {
                        COURSE_DATE = DATE_LIST;
                        INTERACT = VALID_DATA;
                        REDISPLAY = "";
                     }
                     else
                     {
                        FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
                     }
                     /*  If box is abandoned, reprompt for course code */
                     if (INTERACT == EXIT)
                     {
                        INTERACT = INVALID_DATA;
                        ANS = "";
                        VALUE = "";
                        AMENDING = FALSE;
                     }
                     else
                     {
                        INTERACT = VALID_DATA;
                     }
                     if (REDISPLAY)
                     {
                        L0100();
                        START_FIELD = 1;
                        END_FIELD = 4;
                        L6000();
                        /*  Display selected fields */
                        PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(VALUE, ST_JUST));
                        REDISPLAY = "";
                     }
                     if (INTERACT == VALID_DATA)
                     {
                        /*  Existing course */
                        DETAILS_ID = COURSE_DATE + "*" + VALUE;
                        if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                        {
                           /*  Check student is enrolled on this course */
                           ACCESS_ALLOWED = FALSE;
                           if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
                           {
                              ACCESS_ALLOWED = TRUE;
                           }
                           if (ACCESS_ALLOWED == TRUE)
                           {
                              L1220();
                              /*  display course data */
                              AMENDING = FALSE;
                           }
                           else
                           {
                              nrf0 = 8;
                              nrf1 = INIT;
                              FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                              INTERACT = INVALID_DATA;
                              VALUE = "";
                              ANS = "";
                           }
                        }
                        else
                        {
                           INTERACT = INVALID_DATA;
                           nrf0 = 4;
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
                  AMENDING = FALSE;
                  VALUE = "";
               }
               if (INTERACT != INVALID_DATA)
               {
                  if (AMENDING)
                  {
                     L8000();
                     L0300();
                     /*  Have these preferences been processed? If so, give option to clear. */
                     if (ENROL_REC[ENROL_PREFERRED_COURSE1][1, 2] != "")
                     {
                        L5000();
                        FIELD_DATA = DATA_FIELDS[FIELD_NO];
                        L0200();
                        VALUE = ANS;
                     }
                  }
                  else
                  {
                     L8000();
                     START_FIELD = 14;
                     END_FIELD = 15;
                     L6000();
                  }
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
         else if (ANS == "" && VALUE != "")
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
      void L1220()
      {
         /*  Processing after course & date are established */
         ENROL_ID = DETAILS_ID + "*" + MAIN_KEY;
         if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
         /*  Display description and start/end dates */
         COURSE_TEXT = COURSE_MSTR_REC[COURSE_MSTR_DESC];
         COURSE_TEXT2 = "Runs from " + OCONV(COURSE_DATE, "D2/") + " to " + OCONV(COURSE_DET_REC[COURSE_DET_END], "D2/");
         TEXT_COL = 3;
         TEXT_JUST = "L#35";
         PRINT(AT(32, ST_ROW) + FORMAT(COURSE_TEXT, TEXT_JUST));
         PRINT(AT(32, ST_ROW + 1) + FORMAT(COURSE_TEXT2, TEXT_JUST));
         if (ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1] != "")
         {
            /*  Preferences already exist */
            AMENDING = TRUE;
            START_FIELD = 5;
            END_FIELD = 15;
            L6000();
         }
         return;
      }
      void L1300()
      {
         /*  Preferred Course Validation */
         INTERACT = VALID_DATA;
         // BEGIN CASE
         /*  Scan for required course if the 'help' key is entered */
         // CASE
         if (ANS == COMMON.HELP)
         {
            SCAN_STUDENT_ID = "";
            DISPLAY_MODE = 2;
            FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref TEMP_COURSE_ID, ref TEMP_COURSE_DATE, ref INTERACT, ref REDISPLAY);
            // BEGIN CASE
            // CASE
            if (INTERACT == FINISH)
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (INTERACT == EXIT)
            {
               INTERACT = INVALID_DATA;
            }
            // END CASE
            /*  Refresh screen */
            if (REDISPLAY)
            {
               L0100();
               START_FIELD = 1;
               if (AMENDING)
               {
                  END_FIELD = MAX_FIELDS;
               }
               else
               {
                  END_FIELD = FIELD_NO - 1;
               }
               L6000();
               /*  Display selected fields */
               TEXT_JUST = "L#35";
               PRINT(AT(32, 6) + FORMAT(COURSE_TEXT, TEXT_JUST));
               PRINT(AT(32, 7) + FORMAT(COURSE_TEXT2, TEXT_JUST));
               if (NOT(AMENDING))
               {
                  /*  Redisplay date and time */
                  START_FIELD = 14;
                  END_FIELD = 15;
                  L6000();
               }
            }
            if (INTERACT == VALID_DATA)
            {
               PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(TEMP_COURSE_ID, ST_JUST));
               ANS = TEMP_COURSE_ID;
               TEMP_DETAILS_ID = TEMP_COURSE_DATE + "*" + TEMP_COURSE_ID;
               if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, TEMP_COURSE_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
               if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")
               {
                  nrf0 = 55;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
               else
               {
                  if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, TEMP_DETAILS_ID))
                  {
                     /*  Check student is not already enrolled in this course */
                     ACCESS_ALLOWED = TRUE;
                     if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
                     {
                        ACCESS_ALLOWED = FALSE;
                     }
                     if (ACCESS_ALLOWED == TRUE)
                     {
                        TICKET_CONCESS = "";
                        PERIOD = "";
                        TICKET_PRICE = "";
                        /*  DJA 26.1.05 */
                        if (FEE_TODAY == "Y")
                        {
                           SALE_DATE = TODAYS_DATE;
                        }
                        else
                        {
                           SALE_DATE = TEMP_COURSE_DATE;
                        }
                        SALE_TIME = TIME();
                        TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
                        TICKET_TYPE = "C";
                        /*  Don't allow FL048 to auto-select concessions for members as */
                        /*  they may have expired or be due to. Its over the top to */
                        /*  develop this area further. */
                        if (MEMBER_CONCESSIONS == "Y" && STUDENT_IS_MEMBER)
                        {
                           MEMBER_NUMBER = MAIN_KEY;
                        }
                        else
                        {
                           MEMBER_NUMBER = "";
                        }
                        FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
                        FL048 = new FL048(ref TICK_FEES_REC, ref TICKET_PRICE, ref PERIOD, ref MEMBER_NUMBER, ref TICKET_CONCESS);
                        if (TICKET_CONCESS == "")
                        {
                           TICKET_CONCESS = ENROL_REC[ENROL_CONCESSION];
                        }
                        TEMP_REC[ST_ATT + 1] = TEMP_COURSE_DATE;
                        TEMP_REC[ST_ATT + 3] = TRIM(TICKET_CONCESS);
                        START_FIELD = FIELD_NO + 1;
                        END_FIELD = FIELD_NO + 2;
                        L6000();
                        L1350();
                     }
                     else
                     {
                        nrf0 = 48;
                        nrf1 = INIT;
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                     }
                  }
                  else
                  {
                     INTERACT = INVALID_DATA;
                     nrf0 = 3;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref DETAILS_ID);
                  }
               }
            }
            else
            {
               /*  Abandoned window */
               NULL();
            }
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
            TEMP_COURSE_ID = ANS;
            if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, TEMP_COURSE_ID))
            {
               if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "")
               {
                  nrf0 = 55;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
               else
               {
                  /*  Call date selection window */
                  DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
                  CREATION_ALLOWED = FALSE;
                  PROG_MESS[2] = TEMP_COURSE_ID;
                  if (DCOUNT(DATE_LIST, VM) == 1)
                  {
                     TEMP_COURSE_DATE = DATE_LIST;
                     INTERACT = VALID_DATA;
                     REDISPLAY = "";
                  }
                  else
                  {
                     FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref TEMP_COURSE_DATE, ref INTERACT, ref REDISPLAY);
                  }
                  /*  If box is abandoned, reprompt for course code */
                  if (INTERACT == EXIT)
                  {
                     INTERACT = INVALID_DATA;
                  }
                  else
                  {
                     INTERACT = VALID_DATA;
                  }
                  if (REDISPLAY)
                  {
                     L0100();
                     START_FIELD = 1;
                     if (AMENDING)
                     {
                        END_FIELD = MAX_FIELDS;
                     }
                     else
                     {
                        END_FIELD = FIELD_NO - 1;
                     }
                     L6000();
                     /*  Display selected fields */
                     TEXT_JUST = "L#35";
                     PRINT(AT(32, 6) + FORMAT(COURSE_TEXT, TEXT_JUST));
                     PRINT(AT(32, 7) + FORMAT(COURSE_TEXT2, TEXT_JUST));
                     if (NOT(AMENDING))
                     {
                        /*  Redisplay date and time */
                        START_FIELD = 14;
                        END_FIELD = 15;
                        L6000();
                     }
                     PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(ANS, ST_JUST));
                     REDISPLAY = "";
                  }
                  if (INTERACT == VALID_DATA)
                  {
                     /*  Existing course */
                     TEMP_DETAILS_ID = TEMP_COURSE_DATE + "*" + ANS;
                     if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, TEMP_DETAILS_ID))
                     {
                        /*  Check student is enrolled on this course */
                        ACCESS_ALLOWED = TRUE;
                        if (LOCATE(MAIN_KEY, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
                        {
                           ACCESS_ALLOWED = FALSE;
                        }
                        if (ACCESS_ALLOWED == TRUE)
                        {
                           TICKET_CONCESS = "";
                           PERIOD = "";
                           TICKET_PRICE = "";
                           SALE_TIME = TIME();
                           TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
                           /*  DJA 26.1.05 */
                           if (FEE_TODAY == "Y")
                           {
                              SALE_DATE = TODAYS_DATE;
                           }
                           else
                           {
                              SALE_DATE = TEMP_COURSE_DATE;
                           }
                           TICKET_TYPE = "C";
                           /*  Don't allow FL048 to auto-select concessions for members as */
                           /*  they may have expired or be due to. Its over the top to */
                           /*  develop this area further. */
                           if (MEMBER_CONCESSIONS == "Y" && STUDENT_IS_MEMBER)
                           {
                              MEMBER_NUMBER = MAIN_KEY;
                           }
                           else
                           {
                              MEMBER_NUMBER = "";
                           }
                           FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
                           FL048 = new FL048(ref TICK_FEES_REC, ref TICKET_PRICE, ref PERIOD, ref MEMBER_NUMBER, ref TICKET_CONCESS);
                           if (TICKET_CONCESS == "")
                           {
                              TICKET_CONCESS = ENROL_REC[ENROL_CONCESSION];
                           }
                           TEMP_REC[ST_ATT + 1] = TEMP_COURSE_DATE;
                           TEMP_REC[ST_ATT + 3] = TRIM(TICKET_CONCESS);
                           L1350();
                        }
                        else
                        {
                           nrf0 = 48;
                           nrf1 = INIT;
                           FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                           INTERACT = INVALID_DATA;
                        }
                     }
                     else
                     {
                        INTERACT = INVALID_DATA;
                        nrf0 = 4;
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
            }
            if (INTERACT != INVALID_DATA)
            {
               START_FIELD = FIELD_NO + 1;
               END_FIELD = FIELD_NO + 2;
               L6000();
               INTERACT = VALID_DATA;
            }
         }
         // END CASE
         return;
      }
      void L1350()
      {
         /*  Warn if no equivalent concession etc... */
         if (COURSE_DET_REC[COURSE_DET_VACANCIES] <= 0)
         {
            nrf0 = 53;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         else
         {
            /*  Now the user is prompted for a concession the error checked for */
            /*  below should only occur in obscure circumstances, where the */
            /*  nominated course has no equivalent concession to the old one */
            /*  and they abandon from the concession bar. In these cicumstances */
            /*  the old concession from the enrolment record is used. */
            TICKET_CODE = "C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1];
            TICKET_TYPE = "C";
            /*  DJA 26.1.05 */
            if (FEE_TODAY == "Y")
            {
               SALE_DATE = TODAYS_DATE;
            }
            else
            {
               SALE_DATE = TEMP_COURSE_DATE;
            }
            SALE_TIME = TIME();
            PERIOD = "";
            FL355 = new FL355(ref TICKET_CODE, ref TICKET_TYPE, ref SALE_DATE, ref SALE_TIME, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
            EQUIVALENT_CONCESSION = TRUE;
            /* !*     ENROL.CONCESSION = TRIM(ENROL.CONCESSION) */
            TEST_CONCESSION = TEMP_REC[ST_ATT + 3];
            TICKET_PRICE = 0;
            if (!(LOCATE(TEST_CONCESSION, TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONCESS_POS, "AL")))
            {
               EQUIVALENT_CONCESSION = FALSE;
               nrf0 = 52;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         return;
      }
      void L1600()
      {
         /*  Date preferences assigned */
         if (ICONV(ANS, "D") == "")
         {
            INTERACT = INVALID_DATA;
            nrf0 = 44;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         else
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L1700()
      {
         /*  Time preferences assigned */
         if (ICONV(ANS, "MT") == "")
         {
            INTERACT = INVALID_DATA;
            nrf0 = 43;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         else
         {
            if (ICONV(ANS, "MT") > 86400)
            {
               nrf0 = 51;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            else
            {
               INTERACT = VALID_DATA;
            }
         }
         return;

         #endregion
         /* ************************************************** */
      }
      void L5000()
      {
         /*  Ask users if they want to clear the notes   * */
         /*      so the person will be re-processed          * */
         /* ************************************************** */
         OLD_INTERACT = INTERACT;
         /*  Don't muck up calling code */
         INTERACT = INVALID_DATA;
         do
         {
            INPUT_LINE = "  Clear the notes so this person will be re-processed? ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS2, 2);
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS2 == "Y")
            {
               INTERACT = VALID_DATA;
               TEMP_REC[6] = "";
               TEMP_REC[10] = "";
               TEMP_REC[14] = "";
               START_FIELD = 7;
               END_FIELD = 7;
               L6000();
               START_FIELD = 10;
               END_FIELD = 10;
               L6000();
               START_FIELD = 13;
               END_FIELD = 13;
               L6000();
               nrf0 = 47;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (ANS2 == "N")
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (OTHERWISE)
            {
               nrf0 = 46;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         INTERACT = OLD_INTERACT;
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
               PRINT(AT(ST_COL - 1, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
               PRINT(AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
            }// CASE
            else if (ST_CONVERSION != "")
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
            }// CASE
            else if (OTHERWISE)
            {
               if (ST_VALIDATION_CODE == "C")
               {
                  CODE_FOR_DISPLAY = TEMP_REC[ST_ATT];
                  L7000();
               }
               else
               {
                  DISPLAY_STRING = TEMP_REC[ST_ATT];
               }
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(DISPLAY_STRING, ST_JUST));
            }
            // END CASE
         }
         FIELD_NO = OLD_FIELD_NO;
         FIELD_DATA = OLD_FIELD_DATA;
         L0200();
         return;
         /* ********************************************************** */
      }
      void L7000()
      {
         /*   Convert code to string for display                 * */
         /* ********************************************************** */
         // BEGIN CASE
         // CASE
         if (CODE_FOR_DISPLAY == "S")
         {
            DISPLAY_STRING = "Successfully Enrolled";
         }// CASE
         else if (CODE_FOR_DISPLAY == "U")
         {
            DISPLAY_STRING = "Unsuccessful";
         }// CASE
         else if (CODE_FOR_DISPLAY == "P")
         {
            DISPLAY_STRING = "Added to waiting list as a priority";
         }// CASE
         else if (CODE_FOR_DISPLAY == "N")
         {
            DISPLAY_STRING = "Not required";
         }// CASE
         else if (OTHERWISE)
         {
            DISPLAY_STRING = "";
         }
         // END CASE
         return;
         /* ******************************************************** */
      }
      void L8000()
      {
         /*   Load temp.rec                                    * */
         /* ******************************************************** */
         /* *  TEMP.REC(1) will contain the Student's name */
         /* *  TEMP.REC(2) will contain the Student's Address */
         TEMP_REC[3] = COURSE_ID;
         TEMP_REC[4] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1], "*", 2);
         TEMP_REC[5] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1], "*", 1);
         TEMP_REC[6] = ENROL_REC[ENROL_PREFERRED_COURSE1][1, 2];
         TEMP_REC[7] = ENROL_REC[ENROL_PREFERRED_COURSE1][1, 3];
         TEMP_REC[8] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE2][1, 1], "*", 2);
         TEMP_REC[9] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE2][1, 1], "*", 1);
         TEMP_REC[10] = ENROL_REC[ENROL_PREFERRED_COURSE2][1, 2];
         TEMP_REC[11] = ENROL_REC[ENROL_PREFERRED_COURSE2][1, 3];
         TEMP_REC[12] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE3][1, 1], "*", 2);
         TEMP_REC[13] = FIELD(ENROL_REC[ENROL_PREFERRED_COURSE3][1, 1], "*", 1);
         TEMP_REC[14] = ENROL_REC[ENROL_PREFERRED_COURSE3][1, 2];
         TEMP_REC[15] = ENROL_REC[ENROL_PREFERRED_COURSE3][1, 3];
         if (ENROL_REC[ENROL_PREFERENCES_DATE] == "")
         {
            TEMP_REC[16] = TODAYS_DATE;
         }
         else
         {
            TEMP_REC[16] = ENROL_REC[ENROL_PREFERENCES_DATE];
         }
         if (ENROL_REC[ENROL_PREFERENCES_TIME] == "")
         {
            TEMP_REC[17] = TIME();
         }
         else
         {
            TEMP_REC[17] = ENROL_REC[ENROL_PREFERENCES_TIME];
         }
         return;
         /* ******************************************************* */
      }
      void L9000()
      {
         /*   Unload temp.rec                                 * */
         /* ******************************************************* */
         /* *  TEMP.REC(1) will contain the Student's name */
         /* *  TEMP.REC(2) will contain the Student's Address */
         if (TEMP_REC[5] != "" && TEMP_REC[4] != "")
         {
            ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1] = TEMP_REC[5] + "*" + TEMP_REC[4];
         }
         else
         {
            ENROL_REC[ENROL_PREFERRED_COURSE1][1, 1] = "";
         }
         ENROL_REC[ENROL_PREFERRED_COURSE1][1, 2] = TEMP_REC[6];
         ENROL_REC[ENROL_PREFERRED_COURSE1][1, 3] = TEMP_REC[7];
         if (TEMP_REC[9] != "" && TEMP_REC[8] != "")
         {
            ENROL_REC[ENROL_PREFERRED_COURSE2][1, 1] = TEMP_REC[9] + "*" + TEMP_REC[8];
         }
         else
         {
            ENROL_REC[ENROL_PREFERRED_COURSE2][1, 1] = "";
         }
         ENROL_REC[ENROL_PREFERRED_COURSE2][1, 2] = TEMP_REC[10];
         ENROL_REC[ENROL_PREFERRED_COURSE2][1, 3] = TEMP_REC[11];
         if (TEMP_REC[13] != "" && TEMP_REC[12] != "")
         {
            ENROL_REC[ENROL_PREFERRED_COURSE3][1, 1] = TEMP_REC[13] + "*" + TEMP_REC[12];
         }
         else
         {
            ENROL_REC[ENROL_PREFERRED_COURSE3][1, 1] = "";
         }
         ENROL_REC[ENROL_PREFERRED_COURSE3][1, 2] = TEMP_REC[14];
         ENROL_REC[ENROL_PREFERRED_COURSE3][1, 3] = TEMP_REC[15];
         ENROL_REC[ENROL_PREFERENCES_DATE] = TEMP_REC[16];
         ENROL_REC[ENROL_PREFERENCES_TIME] = TEMP_REC[17];
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
