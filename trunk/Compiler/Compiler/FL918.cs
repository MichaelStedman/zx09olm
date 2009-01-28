//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL918 : UvBase
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
      readonly UvVar APACS_MEMBER = 1;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] COURSE_MSTR_REC;
      UvVar[] COURSE_DET_REC;
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] INSTRUCTOR_REC = new UvVar[30];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] APACS_REC = new UvVar[10];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar ZZZ_STATUS = "";
      UvVar MACHINE_TYPE = "";
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
      UvVar GO_BACK = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar PROCESS_LOCKED = "";
      UvVar JUST = "";
      UvVar ORIG_SUB_HEAD = "";
      UvVar MOP = "";
      UvVar DATES_PER_COL = "";
      UvVar COLS = "";
      UvVar FLAG_LENGTH = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_INSTRUCTORS = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_ENROLMENT = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_APACS_NUMBERS = "";
      UvVar SMART_CARD = "";
      UvVar TICKET_CONCESS = "";
      UvVar VACANCY_THRESHOLD = "";
      UvVar COURSE_PARAMS = "";
      UvVar MAX_FIELDS = "";
      UvVar DATA_FIELDS = "";
      UvVar DISPLAY_ONLY_FIELDS = "";
      UvVar ENTRY_FIELDS = "";
      UvVar FIELD_COUNT = "";
      UvVar COURSE_DATE = "";
      UvVar LINE = "";
      UvVar POS = "";
      UvVar AMENDING = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar FIELD_NO = "";
      UvVar MAIN_KEY = "";
      UvVar DETAILS_ID = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      FL788 FL788;
      UvVar FIELD_DATA = "";
      UvVar ST_DISPLAY = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_LENGTH = "";
      UvVar ST_MANDATORY = "";
      FL006 FL006;
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar PROMPT_NO = "";
      FL000_10 FL000_10;
      UvVar PRINT_LINE = "";
      UvVar SESSION_DATE_COUNT = "";
      UvVar COLS_REQUIRED = "";
      UvVar SUB_HEAD = "";
      UvVar SUB_HEAD_LENGTH = "";
      UvVar SESSION_NO = "";
      UvVar COL = "";
      UvVar SUB_HEAD_DONE = "";
      UvVar DATE_NO = "";
      UvVar ROW = "";
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
      UvVar FLAG_NO = "";
      UvVar FLAG_COL = "";
      UvVar DISPLAY_MODE = "";
      UvVar STUDENT_SCAN_ID = "";
      FL717 FL717;
      UvVar COURSE_ID = "";
      UvVar REDISPLAY = "";
      CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
      UvVar COMMENT_MODE = "";
      FL793 FL793;
      UvVar REDISPLAY_START_ROW = "";
      UvVar REDISPLAY_END_ROW = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar DATE_LIST = "";
      UvVar CREATION_ALLOWED = "";
      UvVar SELECT_DATE = "";
      FL704 FL704;
      UvVar NEW_COURSE = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL918(ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC)
      {
         this.COURSE_MSTR_REC = COURSE_MSTR_REC;
         this.COURSE_DET_REC = COURSE_DET_REC;
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
         /*     ACTIVITY DAY TAKE-UP ENQUIRY */
         PROMPT("");
         PROGRAM = "FL918";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
         JUST = "";
         ORIG_SUB_HEAD = "Date       1  2  3  4  5  Date       1  2  3  4  5  Date       1  2  3  4  5";
         MOP = "";
         DATES_PER_COL = 14;
         COLS = 2;
         COLS[2] = 28;
         COLS[3] = 54;
         FLAG_LENGTH = 3;
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
         #region INCLUDE FL.FILES FL.APACS.NUMBERS
         if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

         #endregion
         if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1)))
         {
            SMART_CARD = FALSE;
         }
         MAT(ref TEMP_REC, "");
         TICKET_CONCESS = "";
         VACANCY_THRESHOLD = 1;
         if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
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
         COURSE_DATE = PROG_MESS[3];
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
            STUDENT_IS_MEMBER = FALSE;
            FIELD_NO = 1;
            if (PROG_MESS[2] != "")
            {
               MAIN_KEY = PROG_MESS[2];
               if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY))
               {
                  DETAILS_ID = PROG_MESS[3] + "*" + MAIN_KEY;
                  if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                  {
                     L8000();
                     /*  Build temp.rec */
                     START_FIELD = 1;
                     END_FIELD = 3;
                     L6000();
                     L0150();
                     L0350();
                     /*  Display take-up */
                  }
                  else
                  {
                     INTERACT = EXIT;
                     PROG_MESS = COMMON.ABANDON;
                  }
               }
               else
               {
                  INTERACT = EXIT;
                  PROG_MESS = COMMON.ABANDON;
               }
            }
            else
            {
               MAIN_KEY = "";
               MAT(ref TEMP_REC, "");
            }
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
               /* !!        IF MAIN.KEY # "" AND INTERACT # EXIT THEN */
               /* !!        END */
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
         do
         {
            INPUT_LINE = "  'E'nrol, 'F'inish or " + COMMON.ABANDON + " to exit ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + AT(2, 21) + SPACE(76));
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 2);
            PRINT(AT(2, 21) + SPACE(73));
            ANS = OCONV(ANS, "MCU");
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
               PROG_MESS[2] = "";
            }// CASE
            else if (ANS == "F")
            {
               INTERACT = FINISH;
               PROG_MESS[1] = "";
               PROG_MESS[2] = "";
            }// CASE
            else if (ANS == "E")
            {
               PROG_MESS[35] = MAIN_KEY;
               PROG_MESS[36] = PROG_MESS[3];
               FL788 = new FL788();
               PROG_MESS[35] = "";
               PROG_MESS[36] = "";
               INTERACT = FINISH;
               PROG_MESS[1] = "";
               PROG_MESS[2] = "";
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
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
         else if (OTHERWISE)
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
            else if (ANS == COMMON.CLR && FIELD_NO == 1)
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
         PRINTCR(AT(2, 5) + MENU_HEAD_BACK + MENU_HEAD_FORE + ORIG_SUB_HEAD + NRM_VID);
         /*  Position cursor to prevent Wyse taking a chunk out of footing bar */
         PRINTCR(AT(0, 3) + NRM_VID);
         return;
         /* *********************************************** */
      }
      void L0150()
      {
         /*  Display session dates                    * */
         /* *********************************************** */
         SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
         COLS_REQUIRED = INT((SESSION_DATE_COUNT - 1) / DATES_PER_COL) + 1;
         SUB_HEAD = ORIG_SUB_HEAD;
         SUB_HEAD_LENGTH = LEN(ORIG_SUB_HEAD);
         /*  Remove unnecessary session numbers from the 3 columns */
         if (COURSE_DET_REC[COURSE_DET_SESSIONS] < 5)
         {
            SESSION_NO = COURSE_DET_REC[COURSE_DET_SESSIONS] + 1;
            do
            {
               if (SESSION_NO > 5) break;
               COL = 1;
               do
               {
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
         do
         {
            if (COL > 3 || SUB_HEAD_DONE) break;
            if (COLS_REQUIRED < COL)
            {
               /*  Locate 'D' for 'Date' */
               POS = INDEX(SUB_HEAD, "D", COL);
               SUB_HEAD = SUB_HEAD.Substring(1, POS - 1);
               SUB_HEAD = SUB_HEAD + SPACE(SUB_HEAD_LENGTH - LEN(SUB_HEAD));
               SUB_HEAD_DONE = TRUE;
            }
            COL = COL + 1;
         } while (true);
         PRINT(AT(2, 5) + MENU_HEAD_BACK + MENU_HEAD_FORE + SUB_HEAD + NRM_VID);
         if (SESSION_DATE_COUNT > 42)
         {
            nrf0 = 60;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            SESSION_DATE_COUNT = 42;
         }
         for (DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1)
         {
            L0175();
            /*  Set column and row */
            PRINT(AT(COL + 15, ROW) + NRM_VID);
            DAY_TEXT = OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "DWA").Substring(1, 2);
            if (DAY_TEXT == "MO")
            {
               PRINT(AT(COL - 1, ROW) + SCREEN_BACK + UND_VID);
            }
            else
            {
               PRINT(AT(COL - 1, ROW) + SCREEN_BACK + REV_UND_VID);
            }
            PRINT(AT(COL, ROW) + DAY_TEXT + " ");
            PRINT(AT(COL + 3, ROW) + OCONV(COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO], "D").Substring(1, 6));
            /* !!     PRINT @(COL+9,ROW):COLOR.C:DATE.NO "R#3":" ": */
         }
         /*  Display session flags */
         L0350();
         return;
         /* ******************************************** */
      }
      void L0175()
      {
         /*   Calculate column and row for session * */
         /*       flag display and/or data entry       * */
         /* ******************************************** */
         LEFTOVER = MOD(DATE_NO, DATES_PER_COL);
         if (LEFTOVER == 0)
         {
            COL_AMC = INT(DATE_NO / DATES_PER_COL);
         }
         else
         {
            COL_AMC = INT(DATE_NO / DATES_PER_COL) + 1;
         }
         COL = COLS[COL_AMC];
         ROW = 5 + DATE_NO - (DATES_PER_COL * (COL_AMC - 1));
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
               PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
            }
            // END CASE
         }
         return;
         /* *********************************************** */
      }
      void L0350()
      {
         /*  Display session flags                    * */
         /* *********************************************** */
         SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
         if (SESSION_DATE_COUNT > 42)
         {
            SESSION_DATE_COUNT = 42;
         }
         for (DATE_NO = 1; DATE_NO <= SESSION_DATE_COUNT; DATE_NO += 1)
         {
            L0175();
            /*  Set column and row */
            PRINT(AT(COL + 21, ROW) + NRM_VID);
            /*  Check for unavailable sessions and block them out */
            for (FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1)
            {
               FLAG_COL = COL + FLAG_LENGTH + (3 * FLAG_NO) + 3;
               // BEGIN CASE
               // CASE
               if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, DATE_NO, FLAG_NO] != "Y")
               {
                  PRINT(AT(FLAG_COL, ROW) + REV_VID + "X" + NRM_VID);
               }// CASE
               else if (OTHERWISE)
               {
                  /* !!           PRINT @(FLAG.COL,ROW):(COURSE.DET.MAXIMUM.PLACES-COURSE.DET.VACANCIES<1,DATE.NO,FLAG.NO>) "R#3": */
                  PRINT(AT(FLAG_COL, ROW) + FORMAT(COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_NO, FLAG_NO], "R#3"));
               }
               // END CASE
            }
         }
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
         #region INCLUDE FL.PROCESSING FL918.VALIDATION

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
            DISPLAY_MODE = 6;
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
                  if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) { MAT(ref COURSE_MSTR_REC, ""); }
                  if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "A")
                  {
                     /*  Not an activity day course */
                     INTERACT = INVALID_DATA;
                     PROG_MESS[2] = "";
                     VALUE = "";
                     nrf0 = 54;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     ANS = "";
                  }
                  else
                  {
                     if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                     {
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
                        for (ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1)
                        {
                           PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
                        }
                        L0150();
                        /*  Display session dates */
                        OLD_COURSE_DATE = COURSE_DATE;
                        L0300();
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
                  if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY))
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
                        if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                        {
                           if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != "A")
                           {
                              /*  Not an activity day course */
                              INTERACT = INVALID_DATA;
                              nrf0 = 54;
                              nrf1 = INIT;
                              FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                              PROG_MESS[2] = "";
                              MAIN_KEY = "";
                              AMENDING = FALSE;
                              VALUE = "";
                           }
                           else
                           {
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
                              for (ROW = REDISPLAY_START_ROW; ROW <= REDISPLAY_END_ROW; ROW += 1)
                              {
                                 PRINT(AT(0, ROW) + NRM_VID + COMMON.EOL);
                              }
                              L0150();
                              /*  Display session dates */
                              AMENDING = FALSE;
                              OLD_COURSE_DATE = SELECT_DATE;
                              if (INTERACT == INVALID_DATA)
                              {
                                 ANS = "";
                                 MAIN_KEY = "";
                                 VALUE = "";
                                 PROG_MESS[2] = "";
                              }
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
               /* *         PRINT SCREEN.FOOT.BACK:SCREEN.FOOT.FORE: */
               PRINT(AT(0, 23) + NRM_VID + SPACE(78));
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
         if (INTERACT == VALID_DATA)
         {
            L0350();
            /*  Display take-up */
         }
         return;
      }
      void L1200()
      {
         /*   DUMMY Validation Routine (Display only fields) */
         INTERACT = VALID_DATA;
         return;

         #endregion
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
         TEMP_REC[7] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
         TEMP_REC[8] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
         TEMP_REC[9] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
         TEMP_REC[10] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 4];
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
