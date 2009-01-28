//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL743 : UvBase
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
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] QQQ_VARS = new UvVar[7];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_ENROLMENT = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar PREFIX = "";
      UvVar FZ045 = "";
      UvVar FIRST_PAGE = "";
      CallAt_FZ045 CallAt_FZ045;
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar MINIMUM_ARREARS = "";
      UvVar CENTRE_CODE = "";
      UvVar RUN_TYPE = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar SELECT_COUNT = "";
      UvVar CREDIT_COUNT = "";
      UvVar DEBIT_COUNT = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar PASS = "";
      UvVar DISPLAY_ROW = "";
      UvVar GRAND_TOTAL_BALANCE = "";
      UvVar GRAND_TOTAL_INST_BALANCE = "";
      UvVar EOF = "";
      UvVar ID = "";
      UvVar COURSE_LIST = "";
      UvVar DET_ID_LIST = "";
      UvVar BALANCE_LIST = "";
      UvVar INST_BALANCE_LIST = "";
      UvVar START_DATE_LIST = "";
      UvVar END_DATE_LIST = "";
      UvVar BALANCE_TOTAL = "";
      UvVar TRANS_NO = "";
      UvVar DET_ID = "";
      UvVar THIS_CODE = "";
      UvVar THIS_CENTRE = "";
      UvVar DET_POS = "";
      UvVar END_DATE = "";
      UvVar NO_COURSES = "";
      UvVar INST_BALANCE_TOTAL = "";
      UvVar COURSE_NO = "";
      UvVar ENROL_ID = "";
      UvVar TOTAL_NOT_DUE = "";
      UvVar MVC = "";
      UvVar INST_DATE = "";
      UvVar COURSE_CODE = "";
      UvVar COURSE_BALANCE = "";
      UvVar EXCLUDE_COURSE = "";
      UvVar ULINE_PRINTED = "";
      UvVar TOTAL_PRINTED = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar NAME = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL743()
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
         /*     REPORT OF COURSE STUDENTS WITH DEBIT/CREDIT BALANCES */
         PROGRAM = "FL743";
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
         #region INCLUDE FL.FILES FL.COURSE.MASTER

         if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
         /*  A = Activity Day or Null for standard course :- */
         /*  Optional code corresponding to FL.COURSE.TYPES :- */

         #endregion
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
         FIRST_PAGE = TRUE;
         PRINT_START_COMMAND = "";
         PRINT_END_COMMAND = "";
         PRINT_COMMANDS = "";
         nrf0 = "COURSES.LANDSCAPE";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         MINIMUM_ARREARS = CONTROLS_REC[5];
         CENTRE_CODE = CONTROLS_REC[6];
         RUN_TYPE = OCONV(CONTROLS_REC[7], "MCU");
         if (RUN_TYPE != "B" && RUN_TYPE != "C" && RUN_TYPE != "D") { RUN_TYPE = "B"; }
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         PRINT(AT(10, 14) + "Selecting students with o/s balances");
         SELECT_COUNT = 0;
         CREDIT_COUNT = 0;
         DEBIT_COUNT = 0;
         /*  Debits */
         if (RUN_TYPE == "D" || RUN_TYPE == "B")
         {
            QQQ_VARS[HEADIN] = "(" + PROGRAM + ")" + SPACE(22) + "LeisureFlex Courses - Students With Debit Balances" + SPACE(40) + "'DL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(29) + STR("=", 50) + "'LL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(20) + "Minimum Arrears = " + OCONV(MINIMUM_ARREARS, "MD2") + SPACE(5) + "'LL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Student/" + SPACE(60) + "Telephone: Home" + SPACE(12) + "Course   Course    Course Less Inst.'L'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Member No" + SPACE(7) + "Name" + SPACE(22) + "Address" + SPACE(19) + "           Work Course(s)  Starts   End Date Balance   Not Due'L'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + STR("-", 131);
            INSTRUCTION = "SSELECT FL.STUDENTS BY SURNAME";
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            PRINT(AT(10, 15) + "Number of students processed = " + FORMAT(0, "R#6"));
            PRINT(AT(10, 16) + "Number of students reported  = " + FORMAT(0, "R#6"));
            PASS = DEBIT;
            DISPLAY_ROW = 15;
            PRINT(AT(0, 22));
            PRINTER_ON();
            PRINT(PRINT_START_COMMAND);
            L0100();
         }
         /*  Credits */
         if (RUN_TYPE == "C" || RUN_TYPE == "B")
         {
            QQQ_VARS[HEADIN] = "(" + PROGRAM + ")" + SPACE(22) + "LeisureFlex Courses - Students With Credit Balances" + SPACE(38) + "'DL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(29) + STR("=", 51) + "'LL'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Student/" + SPACE(60) + "Telephone: Home" + SPACE(12) + "Course   Course    Course Less Inst.'L'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + "Member No" + SPACE(7) + "Name" + SPACE(22) + "Address" + SPACE(19) + "           Work Course(s)  Starts   End Date Balance   Not Due'L'";
            QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + STR("-", 131);
            QQQ_VARS[LINE_COUNT] = 0;
            SELECT_COUNT = 0;
            INSTRUCTION = "SSELECT FL.STUDENTS BY SURNAME";
            if (RUN_TYPE == "B")
            {
               /*  Debit run has already opened the print job, so */
               /*  turn the printer off to direct output to screen */
               PRINTER_OFF();
            }
            PRINT(AT(10, 18) + "Selecting students in credit");
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            PRINT(AT(10, 19) + "Number of students processed = " + FORMAT(0, "R#6"));
            PRINT(AT(10, 20) + "Number of students reported  = " + FORMAT(0, "R#6"));
            if (RUN_TYPE == "B")
            {
               /*  Print job was started by debit pass, so just redirect */
               /*  output to the printer */
               PRINTER_ON();
            }
            PASS = CREDIT;
            DISPLAY_ROW = 19;
            if (RUN_TYPE == "C")
            {
               /*  First time print job has been started */
               PRINT(AT(0, 22));
               PRINTER_ON();
               PRINT(PRINT_START_COMMAND);
            }
            L0100();
         }
         /* !*  CALL FL235("STANDARD",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
         /* DJA 13.03.06!PRINT PRINT.END.COMMAND: */
         PRINTER_CLOSE();
         PRINTER_OFF();
         return;
         /* ********************************** */
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
      void L0100()
      {
         /*   MAIN PRINT SECTION         * */
         /* ********************************** */
         GRAND_TOTAL_BALANCE = 0;
         GRAND_TOTAL_INST_BALANCE = 0;
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
            /*  Check whether minimum arrears are exceeded and take into account */
            /*  instalments not yet due. */
            COURSE_LIST = "";
            DET_ID_LIST = "";
            BALANCE_LIST = "";
            INST_BALANCE_LIST = "";
            START_DATE_LIST = "";
            END_DATE_LIST = "";
            /* !        BALANCE.TOTAL = 0 */
            TRANS_NO = 1;
            do
            {
               DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO];
               if (DET_ID == "") break;
               /*  DJA 17.9.04 */
               THIS_CODE = FIELD(DET_ID, "*", 2);
               THIS_CENTRE = "";
               if (CENTRE_CODE != "")
               {
                  if (!READV(ref THIS_CENTRE, FL_COURSE_MASTER, THIS_CODE, 4)) { THIS_CENTRE = ""; }
               }
               if (CENTRE_CODE == "" || CENTRE_CODE == THIS_CENTRE)
               {
                  if (LOCATE(DET_ID, DET_ID_LIST, 1, 0, 1, ref DET_POS, "AL"))
                  {
                     BALANCE_LIST[1, DET_POS] = BALANCE_LIST[1, DET_POS] + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     /* !*                 BALANCE.TOTAL = BALANCE.TOTAL + STUDENT.TRANS.AMOUNTS<1,TRANS.NO> */
                  }
                  else
                  {
                     if (!READV(ref END_DATE, FL_COURSE_DETAILS, DET_ID, 2)) { END_DATE = ""; }
                     COURSE_LIST = INSERT(COURSE_LIST, 1, DET_POS, 0, FIELD(DET_ID, "*", 2));
                     DET_ID_LIST = INSERT(DET_ID_LIST, 1, DET_POS, 0, DET_ID);
                     BALANCE_LIST = INSERT(BALANCE_LIST, 1, DET_POS, 0, STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO]);
                     /* !*                 BALANCE.TOTAL = BALANCE.TOTAL + STUDENT.TRANS.AMOUNTS<1,TRANS.NO> */
                     START_DATE_LIST = INSERT(START_DATE_LIST, 1, DET_POS, 0, FIELD(DET_ID, "*", 1));
                     END_DATE_LIST = INSERT(END_DATE_LIST, 1, DET_POS, 0, END_DATE);
                  }
                  /*  DJA 17.9.04 */
               }
               TRANS_NO = TRANS_NO + 1;
            } while (true);
            /*  Calculate instalment total not yet due */
            NO_COURSES = DCOUNT(COURSE_LIST, VM);
            BALANCE_TOTAL = 0;
            INST_BALANCE_TOTAL = 0;
            for (COURSE_NO = 1; COURSE_NO <= NO_COURSES; COURSE_NO += 1)
            {
               DET_ID = DET_ID_LIST[1, COURSE_NO];
               ENROL_ID = DET_ID + "*" + ID;
               if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
               TOTAL_NOT_DUE = 0;
               MVC = 1;
               do
               {
                  INST_DATE = ENROL_REC[ENROL_INST_DATES][1, MVC];
                  if (INST_DATE == "") break;
                  if (INST_DATE > TODAYS_DATE)
                  {
                     TOTAL_NOT_DUE = TOTAL_NOT_DUE + ENROL_REC[ENROL_INST_AMOUNTS][1, MVC];
                  }
                  MVC = MVC + 1;
               } while (true);
               INST_BALANCE_LIST[1, COURSE_NO] = BALANCE_LIST[1, COURSE_NO] - TOTAL_NOT_DUE;
               /* !*        INST.BALANCE.TOTAL = INST.BALANCE.TOTAL + INST.BALANCE.LIST<1,COURSE.NO> */
            }
            /*  Strip courses with a zero balance */
            /*  or irrelevant balance, i.e. debit balance on a */
            /*  credit pass or vice versa */
            COURSE_NO = 1;
            do
            {
               COURSE_CODE = COURSE_LIST[1, COURSE_NO];
               if (COURSE_CODE == "") break;
               COURSE_BALANCE = BALANCE_LIST[1, COURSE_NO];
               EXCLUDE_COURSE = FALSE;
               // BEGIN CASE
               // CASE
               if (BALANCE_LIST[1, COURSE_NO] == 0 && INST_BALANCE_LIST[1, COURSE_NO] == 0)
               {
                  EXCLUDE_COURSE = TRUE;
               }// CASE
               else if (PASS == DEBIT && COURSE_BALANCE < 0)
               {
                  EXCLUDE_COURSE = TRUE;
               }// CASE
               else if (PASS == CREDIT && COURSE_BALANCE > 0)
               {
                  EXCLUDE_COURSE = TRUE;
               }
               // END CASE
               if (EXCLUDE_COURSE)
               {
                  COURSE_LIST = DELETE(COURSE_LIST, 1, COURSE_NO, 0);
                  DET_ID_LIST = DELETE(DET_ID_LIST, 1, COURSE_NO, 0);
                  BALANCE_LIST = DELETE(BALANCE_LIST, 1, COURSE_NO, 0);
                  INST_BALANCE_LIST = DELETE(INST_BALANCE_LIST, 1, COURSE_NO, 0);
                  START_DATE_LIST = DELETE(START_DATE_LIST, 1, COURSE_NO, 0);
                  END_DATE_LIST = DELETE(END_DATE_LIST, 1, COURSE_NO, 0);
               }
               else
               {
                  COURSE_NO = COURSE_NO + 1;
               }
            } while (true);
            if (COURSE_LIST != "")
            {
               if (PASS == DEBIT)
               {
                  DEBIT_COUNT = DEBIT_COUNT + 1;
                  PRINTER_OFF();
                  PRINT(AT(41, DISPLAY_ROW + 1) + FORMAT(DEBIT_COUNT, "R#6"));
                  PRINTER_ON();
               }
               else
               {
                  CREDIT_COUNT = CREDIT_COUNT + 1;
                  PRINTER_OFF();
                  PRINT(AT(41, DISPLAY_ROW + 1) + FORMAT(CREDIT_COUNT, "R#6"));
                  PRINTER_ON();
               }
               ULINE_PRINTED = FALSE;
               TOTAL_PRINTED = FALSE;
               if (INST_BALANCE_TOTAL >= MINIMUM_ARREARS || PASS == CREDIT)
               {
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
                  PRINT(FORMAT(OCONV(INST_BALANCE_LIST[1, 1], "MD2"), "R#10"));
                  INST_BALANCE_TOTAL = INST_BALANCE_TOTAL + INST_BALANCE_LIST[1, 1];
                  BALANCE_TOTAL = BALANCE_TOTAL + BALANCE_LIST[1, 1];
                  L1();
                  PRINT(SPACE(42));
                  PRINT(FORMAT(STUDENT_REC[STUDENT_ADDRESS2], "L#25"));
                  PRINT(SPACE(1));
                  PRINT(FORMAT(STUDENT_REC[STUDENT_WORK_TEL], "L#15"));
                  PRINT(SPACE(1));
                  if (COURSE_LIST[1, 2] == "")
                  {
                     L0150();
                  }
                  else
                  {
                     COURSE_NO = 2;
                     L0200();
                  }
                  COURSE_NO = 3;
                  do
                  {
                     if (TOTAL_PRINTED) break;
                     // BEGIN CASE
                     // CASE
                     if (COURSE_LIST[1, COURSE_NO] != "")
                     {
                        PRINT(SPACE(84));
                        L0200();
                        COURSE_NO = COURSE_NO + 1;
                     }// CASE
                     else if (ULINE_PRINTED == FALSE)
                     {
                        PRINT(SPACE(84));
                        L0150();
                     }// CASE
                     else if (TOTAL_PRINTED == FALSE)
                     {
                        PRINT(SPACE(112));
                        L0175();
                     }
                     // END CASE
                  } while (true);
                  L1();
                  /*  Leave a line */
               }
               /*  DJA 17.9.04 */
            }
         } while (true);
         /*  Print grand totals */
         if (GRAND_TOTAL_BALANCE != 0 || GRAND_TOTAL_INST_BALANCE != 0)
         {
            PRINT(SPACE(111));
            PRINT(STR("=", 9));
            PRINT(SPACE(1));
            PRINT(STR("=", 9));
            L1();
            PRINT(SPACE(111));
            PRINT(FORMAT(OCONV(GRAND_TOTAL_BALANCE, "MD2"), "R#9"));
            PRINT(FORMAT(OCONV(GRAND_TOTAL_INST_BALANCE, "MD2"), "R#10"));
            L1();
         }
         return;
         /* ********************************************** */
      }
      void L0150()
      {
         /*  Print total underlines                  * */
         /* ********************************************** */
         PRINT(SPACE(29));
         PRINT(STR("-", 7));
         PRINT(SPACE(3));
         PRINT(STR("-", 7));
         L1();
         ULINE_PRINTED = TRUE;
         return;
         /* *********************************************** */
      }
      void L0175()
      {
         /*  Print totals                             * */
         /* *********************************************** */
         PRINT(FORMAT(OCONV(BALANCE_TOTAL, "MD2"), "R#8"));
         PRINT(FORMAT(OCONV(INST_BALANCE_TOTAL, "MD2"), "R#10"));
         L1();
         TOTAL_PRINTED = TRUE;
         GRAND_TOTAL_BALANCE = GRAND_TOTAL_BALANCE + BALANCE_TOTAL;
         GRAND_TOTAL_INST_BALANCE = GRAND_TOTAL_INST_BALANCE + INST_BALANCE_TOTAL;
         return;
         /* *********************************************** */
      }
      void L0200()
      {
         /*   Print details for a course              * */
         /* *********************************************** */
         PRINT(FORMAT(COURSE_LIST[1, COURSE_NO], "L#11"));
         /* !   PRINT SPACE(1): */
         PRINT(FORMAT(OCONV(START_DATE_LIST[1, COURSE_NO], "D2/"), "R#8"));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(END_DATE_LIST[1, COURSE_NO], "D2/"), "R#8"));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(BALANCE_LIST[1, COURSE_NO], "MD2"), "R#7"));
         PRINT(FORMAT(OCONV(INST_BALANCE_LIST[1, COURSE_NO], "MD2"), "R#10"));
         INST_BALANCE_TOTAL = INST_BALANCE_TOTAL + INST_BALANCE_LIST[1, COURSE_NO];
         BALANCE_TOTAL = BALANCE_TOTAL + BALANCE_LIST[1, COURSE_NO];
         L1();
         return;
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
