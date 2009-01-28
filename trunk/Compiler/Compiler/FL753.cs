//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL753 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar DEBIT = 1;
      readonly UvVar CREDIT = 2;
      readonly UvVar FL_CONTROL = 10;
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
      readonly UvVar UL = "_";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] QQQ_VARS = new UvVar[7];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar PROGRAM = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_ENROLMENT = "";
      UvVar FIRST_PAGE = "";
      UvVar PREFIX = "";
      UvVar FZ045 = "";
      CallAt_FZ045 CallAt_FZ045;
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar MINIMUM_DAYS = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar SELECT_COUNT = "";
      UvVar UNPAID_COUNT = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar DISPLAY_ROW = "";
      UvVar EOF = "";
      UvVar ID = "";
      UvVar COURSE_LIST = "";
      UvVar DET_ID_LIST = "";
      UvVar BALANCE_LIST = "";
      UvVar ENROLLED_DATE_LIST = "";
      UvVar ORIGINAL_FEE_LIST = "";
      UvVar START_DATE_LIST = "";
      UvVar END_DATE_LIST = "";
      UvVar TRANS_NO = "";
      UvVar DET_ID = "";
      UvVar DET_POS = "";
      UvVar END_DATE = "";
      UvVar COURSE_NO = "";
      UvVar COURSE_CODE = "";
      UvVar COURSE_BALANCE = "";
      UvVar ULINE_PRINTED = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar NAME = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL753()
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
         /*     ENROLLED STUDENTS WHO HAVE PAID NOTHING */
         PROGRAM = "FL753";
         /* ************************ */
         /*     DEFINE FILES USED  * */
         /* ************************ */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

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
         nrf0 = "COURSES.LANDSCAPE";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         MINIMUM_DAYS = CONTROLS_REC[5];
         if (NOT(NUM(MINIMUM_DAYS))) { MINIMUM_DAYS = 0; }
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         PRINT(AT(10, 14) + "Selecting students... ");
         SELECT_COUNT = 0;
         UNPAID_COUNT = 0;
         /*  Debits */
         QQQ_VARS[HEADIN] = "(" + PROGRAM + ")" + SPACE(22) + "LeisureFlex Courses - Students Who Have Paid Nothing" + SPACE(37) + "'DL'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(29) + STR("=", 52) + "'LL'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(45) + "Minimum Days = " + MINIMUM_DAYS + SPACE(5) + "'LL'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Student/" + SPACE(60) + "Telephone: Home" + SPACE(12) + "Course   Course    Course Enrolled'L'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Member No" + SPACE(7) + "Name" + SPACE(22) + "Address" + SPACE(19) + "           Work Course(s)  Starts   End Date Balance       On'L'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + STR("-", 131);
         INSTRUCTION = "SSELECT FL.STUDENTS WITH BALANCE > \"0.00\" BY SURNAME";
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         PRINT(AT(10, 15) + "Number of students processed = " + FORMAT(0, "R#6"));
         PRINT(AT(10, 16) + "Number of students reported  = " + FORMAT(0, "R#6"));
         DISPLAY_ROW = 15;
         PRINT(AT(0, 22));
         PRINTER_ON();
         PRINT(PRINT_START_COMMAND);
         L0100();
         /* !*  CALL FL235("STANDARD",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
         /* DJA!PRINT PRINT.END.COMMAND: */
         PRINTER_CLOSE();
         PRINTER_OFF();
         return;
         /* ********************************** */
      }
      void L0100()
      {
         /*   MAIN PRINT SECTION         * */
         /* ********************************** */
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            SELECT_COUNT = SELECT_COUNT + 1;
            if (SELECT_COUNT == 1)
            {
               L1();
               /*  Print page header */
            }
            PRINTER_OFF();
            PRINT(AT(41, DISPLAY_ROW) + FORMAT(SELECT_COUNT, "R#6"));
            PRINTER_ON();
            if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, ID)) { MAT(ref STUDENT_REC, ""); }
            COURSE_LIST = "";
            DET_ID_LIST = "";
            BALANCE_LIST = "";
            ENROLLED_DATE_LIST = "";
            ORIGINAL_FEE_LIST = "";
            START_DATE_LIST = "";
            END_DATE_LIST = "";
            TRANS_NO = 1;
            do
            {
               DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO];
               if (DET_ID == "") break;
               if (LOCATE(DET_ID, DET_ID_LIST, 1, 0, 1, ref DET_POS, "AL"))
               {
                  BALANCE_LIST[1, DET_POS] = BALANCE_LIST[1, DET_POS] + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
               }
               else
               {
                  if (!READV(ref END_DATE, FL_COURSE_DETAILS, DET_ID, 2)) { END_DATE = ""; }
                  COURSE_LIST = INSERT(COURSE_LIST, 1, DET_POS, 0, FIELD(DET_ID, "*", 2));
                  DET_ID_LIST = INSERT(DET_ID_LIST, 1, DET_POS, 0, DET_ID);
                  BALANCE_LIST = INSERT(BALANCE_LIST, 1, DET_POS, 0, STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO]);
                  START_DATE_LIST = INSERT(START_DATE_LIST, 1, DET_POS, 0, FIELD(DET_ID, "*", 1));
                  END_DATE_LIST = INSERT(END_DATE_LIST, 1, DET_POS, 0, END_DATE);
                  ENROLLED_DATE_LIST = INSERT(ENROLLED_DATE_LIST, 1, DET_POS, 0, STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO]);
                  ORIGINAL_FEE_LIST = INSERT(ORIGINAL_FEE_LIST, 1, DET_POS, 0, STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO]);
               }
               TRANS_NO = TRANS_NO + 1;
            } while (true);
            /*  Strip courses where enrolment date is below the minimum delay or where */
            /*  the original fee is not outstanding */
            COURSE_NO = 1;
            do
            {
               COURSE_CODE = COURSE_LIST[1, COURSE_NO];
               if (COURSE_CODE == "") break;
               COURSE_BALANCE = BALANCE_LIST[1, COURSE_NO];
               if ((COURSE_BALANCE != ORIGINAL_FEE_LIST[1, COURSE_NO]) || (TODAYS_DATE - ENROLLED_DATE_LIST[1, COURSE_NO] < MINIMUM_DAYS))
               {
                  COURSE_LIST = DELETE(COURSE_LIST, 1, COURSE_NO, 0);
                  DET_ID_LIST = DELETE(DET_ID_LIST, 1, COURSE_NO, 0);
                  BALANCE_LIST = DELETE(BALANCE_LIST, 1, COURSE_NO, 0);
                  START_DATE_LIST = DELETE(START_DATE_LIST, 1, COURSE_NO, 0);
                  END_DATE_LIST = DELETE(END_DATE_LIST, 1, COURSE_NO, 0);
                  ENROLLED_DATE_LIST = DELETE(ENROLLED_DATE_LIST, 1, COURSE_NO, 0);
                  ORIGINAL_FEE_LIST = DELETE(ORIGINAL_FEE_LIST, 1, COURSE_NO, 0);
               }
               else
               {
                  COURSE_NO = COURSE_NO + 1;
               }
            } while (true);
            if (COURSE_LIST != "")
            {
               UNPAID_COUNT = UNPAID_COUNT + 1;
               PRINTER_OFF();
               PRINT(AT(41, DISPLAY_ROW + 1) + FORMAT(UNPAID_COUNT, "R#6"));
               PRINTER_ON();
               ULINE_PRINTED = FALSE;
               STUDENT_IS_MEMBER = FALSE;
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ID))
               {
                  STUDENT_IS_MEMBER = TRUE;
                  STUDENT_REC[STUDENT_ADDRESS1] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  STUDENT_REC[STUDENT_ADDRESS2] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
                  STUDENT_REC[STUDENT_ADDRESS3] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
                  STUDENT_REC[STUDENT_ADDRESS4] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
                  STUDENT_REC[STUDENT_POST_CODE] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
                  STUDENT_REC[STUDENT_HOME_TEL] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
                  STUDENT_REC[STUDENT_WORK_TEL] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
                  NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
               }
               else
               {
                  NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
               }
               PRINT(FORMAT(ID, "L#15"));
               PRINT(SPACE(1));
               PRINT(FORMAT(NAME, "L#25"));
               PRINT(SPACE(1));
               PRINT(FORMAT(STUDENT_REC[STUDENT_ADDRESS1], "L#25"));
               PRINT(SPACE(1));
               PRINT(FORMAT(STUDENT_REC[STUDENT_HOME_TEL], "L#15"));
               PRINT(SPACE(1));
               PRINT(FORMAT(COURSE_LIST[1, 1], "L#11"));
               /* !         PRINT SPACE(1): */
               PRINT(FORMAT(OCONV(START_DATE_LIST[1, 1], "D2/"), "R#8"));
               PRINT(SPACE(1));
               PRINT(FORMAT(OCONV(END_DATE_LIST[1, 1], "D2/"), "R#8"));
               PRINT(SPACE(1));
               PRINT(FORMAT(OCONV(BALANCE_LIST[1, 1], "MD2"), "R#7"));
               PRINT(FORMAT(OCONV(ENROLLED_DATE_LIST[1, 1], "D2/"), "R#10"));
               L1();
               PRINT(SPACE(42));
               PRINT(FORMAT(STUDENT_REC[STUDENT_ADDRESS2], "L#25"));
               PRINT(SPACE(1));
               PRINT(FORMAT(STUDENT_REC[STUDENT_WORK_TEL], "L#15"));
               PRINT(SPACE(1));
               if (COURSE_LIST[1, 2] != "")
               {
                  COURSE_NO = 2;
                  L0200();
               }
               COURSE_NO = 3;
               do
               {
                  if (COURSE_LIST[1, COURSE_NO] == "") break;
                  PRINT(SPACE(84));
                  L0200();
                  COURSE_NO = COURSE_NO + 1;
               } while (true);
               L1();
               /*  Leave a line */
            }
         } while (true);
         return;
         /* *********************************************** */
      }
      void L0200()
      {
         /*   Print details for a course              * */
         /* *********************************************** */
         PRINT(FORMAT(COURSE_LIST[1, COURSE_NO], "L#10"));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(START_DATE_LIST[1, COURSE_NO], "D2/"), "R#8"));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(END_DATE_LIST[1, COURSE_NO], "D2/"), "R#8"));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(BALANCE_LIST[1, COURSE_NO], "MD2"), "R#7"));
         PRINT(FORMAT(OCONV(ENROLLED_DATE_LIST[1, COURSE_NO], "D2/"), "R#10"));
         L1();
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
      }
      /* ********************* */
      /*     END OF PROGRAM  * */
      /* ********************* */
   }
}
