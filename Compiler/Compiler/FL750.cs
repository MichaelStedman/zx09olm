//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL750 : UvBase
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
      readonly UvVar HEADIN = 1;
      readonly UvVar FOOTIN = 2;
      readonly UvVar USER_RESPONSE = 3;
      readonly UvVar LINE_COUNT = 4;
      readonly UvVar MAX_LINES = 5;
      readonly UvVar PAGE_NO = 6;
      readonly UvVar FOOT_LINES = 7;
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] QQQ_VARS = new UvVar[7];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar STUDENT_ID = "";
      UvVar DETAILS_ID = "";
      UvVar INST_DATES = "";
      UvVar INST_AMOUNTS = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar PROGRAM = "";
      UvVar INTERACT = "";
      UvVar FIRST_PAGE = "";
      UvVar PREFIX = "";
      UvVar FZ045 = "";
      CallAt_FZ045 CallAt_FZ045;
      UvVar REDISPLAY = "";
      UvVar TOTAL_AMOUNT = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar NAME = "";
      UvVar COURSE_ID = "";
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar INST_MVC = "";
      UvVar INST_DATE = "";
      UvVar INST_LINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL750(ref UvVar STUDENT_ID, ref UvVar DETAILS_ID, ref UvVar[] STUDENT_REC, ref UvVar INST_DATES, ref UvVar INST_AMOUNTS)
      {
         this.STUDENT_ID = STUDENT_ID;
         this.DETAILS_ID = DETAILS_ID;
         this.STUDENT_REC = STUDENT_REC;
         this.INST_DATES = INST_DATES;
         this.INST_AMOUNTS = INST_AMOUNTS;
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
         /*     PRINT INSTALMENT PROFILE FOR ONE STUDENT FOR ONE COURSE */
         PROGRAM = "FL750";
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
         INTERACT = INVALID_DATA;
         REDISPLAY = "";
         TOTAL_AMOUNT = 0;
         /*  Include relevant file info */
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
         #region INCLUDE FL.FILES FL.COURSE.MASTER

         if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
         /*  A = Activity Day or Null for standard course :- */
         /*  Optional code corresponding to FL.COURSE.TYPES :- */

         #endregion
         QQQ_VARS[HEADIN] = SPACE(10) + "Instalment Plan as at 'TL'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(10) + "==========================================='LL'";
         STUDENT_IS_MEMBER = FALSE;
         if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID))
         {
            STUDENT_IS_MEMBER = TRUE;
            NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
         }
         else
         {
            NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
         }
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(10) + "(" + STUDENT_ID + ")" + SPACE(3) + NAME + "'LL'";
         COURSE_ID = FIELD(DETAILS_ID, "*", 2);
         if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_DESC], FL_COURSE_MASTER, COURSE_ID, 1)) { COURSE_MSTR_REC[COURSE_MSTR_DESC] = ""; }
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(10) + "Course: " + COURSE_ID + SPACE(3) + COURSE_MSTR_REC[COURSE_MSTR_DESC] + "'LL'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(10) + "  #    Date         Amount 'L'";
         QQQ_VARS[HEADIN] = QQQ_VARS[HEADIN] + SPACE(10) + "--------------------------'L'";
         PRINT(AT(2, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
         /* * Routine to set printer parameters  (condensed print) */
         PRINT_START_COMMAND = "";
         PRINT_END_COMMAND = "";
         PRINT_COMMANDS = "";
         nrf0 = "STANDARD";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         PRINTER_ON();
         PRINT(PRINT_START_COMMAND);
         QQQ_VARS[LINE_COUNT] = 0;
         L1();
         /*  Print Headings */
         INST_MVC = 1;
         do
         {
            INST_DATE = INST_DATES[1, INST_MVC];
            if (!(INST_DATE != "")) break;
            INST_LINE = "";
            INST_LINE = INST_LINE + SPACE(10) + FORMAT(INST_MVC, "R#3") + SPACE(3);
            INST_LINE = INST_LINE + FORMAT(OCONV(INST_DATES[1, INST_MVC], "D2/"), "R#8") + SPACE(1);
            INST_LINE = INST_LINE + FORMAT(OCONV(INST_AMOUNTS[1, INST_MVC], "MD2"), "R#11") + SPACE(1);
            TOTAL_AMOUNT = TOTAL_AMOUNT + INST_AMOUNTS[1, INST_MVC];
            PRINT(INST_LINE);
            L1();
            INST_MVC = INST_MVC + 1;
         } while (true);
         PRINT(SPACE(29) + "-------");
         L1();
         PRINT(SPACE(23) + FORMAT(OCONV(TOTAL_AMOUNT, "MD2"), "R#13"));
         L1();
         /*  Return to calling program */
         INTERACT = VALID_DATA;
         PRINT(PRINT_END_COMMAND);
         PRINTER_CLOSE();
         PRINTER_OFF();
         PRINT(AT(2, 20) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE + SPACE(10));
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
   }
}