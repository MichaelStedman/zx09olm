//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL814 : UvBase
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
      readonly UvVar FL_CENTRES = 3;
      readonly UvVar CENTRE_NAME = 1;
      readonly UvVar CENTRE_FLOORS = 2;
      readonly UvVar CENTRE_ACTIVITIES = 3;
      readonly UvVar CENTRE_FACILITY_NUM = 4;
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
      readonly UvVar CODE = 1;
      readonly UvVar DESCRIPTION = 2;
      readonly UvVar CONCESSION = 3;
      readonly UvVar MIN_PLACES = 4;
      readonly UvVar MAX_PLACES = 5;
      readonly UvVar ACT_PLACES = 6;
      readonly UvVar LEFT_PLACES = 7;
      readonly UvVar PERC_PLACES = 8;
      readonly UvVar MAX_INCOME = 9;
      readonly UvVar EXP_INCOME = 10;
      readonly UvVar ACT_INCOME = 11;
      readonly UvVar OS_INCOME = 12;
      readonly UvVar COMMENT = 13;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] CENTRES_REC = new UvVar[4];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] JUSTS = new UvVar[13];
      UvVar[] CONVS = new UvVar[13];
      UvVar[] TOTALS = new UvVar[13];
      UvVar[] GRAND_TOTALS = new UvVar[13];
      UvVar[,] PRT_LINE = new UvVar[13, 8];
      UvVar[] MAX_FEES = new UvVar[8];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar COURSE = "";
      UvVar PROGRAM = "";
      UvVar FF = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_ENROLMENT = "";
      UvVar N = "";
      UvVar FIRST_PAGE = "";
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar DD_MM_YYYY = "";
      UvVar NOW_YYYY = "";
      UvVar NOW_MM = "";
      UvVar NOW_DD = "";
      UvVar START_DATE = "";
      UvVar END_DATE = "";
      UvVar REQUESTED_CENTRE = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar INSTRUCTION = "";
      UvVar TOTAL_COURSES = "";
      UvVar PAGE_DEPTH = "";
      UvVar PAGE_NUMBER = "";
      UvVar LINE_COUNT = "";
      UvVar LAST_TYPE = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar ID = "";
      UvVar COURSE_CODE = "";
      UvVar COURSE_DATE = "";
      UvVar WARNING = "";
      UvVar AVERAGE_PERC = "";
      UvVar TITLE = "";
      UvVar UNDERLINE = "";
      UvVar LOWEST_ADAY_PLACES = "";
      UvVar THIS_MAX = "";
      UvVar THIS_VAC = "";
      UvVar THIS_MIN = "";
      UvVar THIS_ACT = "";
      UvVar MAX_PER_SESSION = "";
      UvVar VAC_COUNT = "";
      UvVar VMC = "";
      UvVar SNO = "";
      UvVar NO_FEES = "";
      UvVar FEE_NO = "";
      UvVar THIS_FEE = "";
      UvVar CONTROL_TICKET_CODE = "";
      UvVar CONTROL_FEE_REC = "";
      UvVar PNTR = "";
      UvVar FEE_DATE = "";
      UvVar CENTRE_TICKET_CODE = "";
      UvVar NO_OF_CONCESSIONS = "";
      UvVar CONCESSION_NO = "";
      UvVar GROUP_NAME = "";
      UvVar POS = "";
      UvVar COURSE_DETAIL_ID = "";
      UvVar NO_OF_STUDENTS = "";
      UvVar STUDENT_NO = "";
      UvVar STUDENT_ID = "";
      UvVar ENROL_ID = "";
      UvVar FEE_ADJUSTMENTS = "";
      UvVar ORIGINAL_FEES = "";
      UvVar PAYMENTS = "";
      UvVar REFUNDS = "";
      UvVar UNENROLMENT = "";
      UvVar COURSE_BALANCE = "";
      UvVar TRANS_NO = "";
      UvVar GROUP = "";
      UvVar GROUPS_EXIST = "";
      UvVar NO_OF_GROUPS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL814()
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
         /*     COURSE REVENUE STATISTICS */
         PROGRAM = "FL814";
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
         #region INCLUDE FL.FILES FL.CENTRES
         #region INCLUDE FL.FILES FL.CENTRES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CENTRES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES.VAR

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
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         /* * Routine to set printer parameters  (condensed print) */
         FIRST_PAGE = TRUE;
         PRINT_START_COMMAND = "";
         PRINT_END_COMMAND = "";
         PRINT_COMMANDS = "";
         nrf0 = "COURSES.LANDSCAPE";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         DD_MM_YYYY = OCONV(TODAYS_DATE, "D4/");
         NOW_YYYY = DD_MM_YYYY.Substring(7, 4);
         NOW_MM = DD_MM_YYYY.Substring(4, 2);
         NOW_DD = DD_MM_YYYY.Substring(1, 2);
         /* ******************* */
         /*     DEFINE ARRAYS  * */
         /* ******************* */
         /*  One element per display Column */
         /*  One element per display Column */
         /*  One element per display Column */
         /*  One element per display Position */
         /*  One element per Group */
         JUSTS[CODE] = "L#11";
         JUSTS[DESCRIPTION] = "L#42";
         JUSTS[CONCESSION] = "L#14";
         JUSTS[MIN_PLACES] = "R#4";
         JUSTS[MAX_PLACES] = "R#5";
         JUSTS[ACT_PLACES] = "R#5";
         JUSTS[LEFT_PLACES] = "R#5";
         JUSTS[PERC_PLACES] = "R#4";
         JUSTS[MAX_INCOME] = "R#8";
         JUSTS[EXP_INCOME] = "R#8";
         JUSTS[ACT_INCOME] = "R#8";
         JUSTS[OS_INCOME] = "R#8";
         JUSTS[COMMENT] = "L#10";
         MAT(ref CONVS, "MD2");
         CONVS[MIN_PLACES] = "MD0";
         CONVS[MAX_PLACES] = "MD0";
         CONVS[ACT_PLACES] = "MD0";
         CONVS[LEFT_PLACES] = "MD0";
         CONVS[PERC_PLACES] = "MD0";
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         PRINT(AT(0, 20));
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         START_DATE = OCONV(CONTROLS_REC[5], "D");
         END_DATE = OCONV(CONTROLS_REC[6], "D");
         COURSE = CONTROLS_REC[7];
         REQUESTED_CENTRE = CONTROLS_REC[8];
         if (!(READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)))
         {
            CENTRES_REC[CENTRE_NAME] = "LeisureFlex";
         }
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (REQUESTED_CENTRE == "")
         {
            INSTRUCTION = "SSELECT FL.COURSE.DETAILS BY TYPE BY COURSE.CODE WITH START.DATE >= \"" + START_DATE + "\"";
         }
         else
         {
            INSTRUCTION = "SSELECT FL.COURSE.DETAILS BY TYPE BY COURSE.CODE WITH CENTRE.CODE = \"" + REQUESTED_CENTRE + "\" AND WITH START.DATE >= \"" + START_DATE + "\"";
         }
         if (END_DATE != "")
         {
            INSTRUCTION = INSTRUCTION + "AND WITH START.DATE <= \"" + END_DATE + "\"";
         }
         if (COURSE != "")
         {
            INSTRUCTION = INSTRUCTION + " AND WITH COURSE.CODE = \"" + COURSE + "\"";
         }
         MAT(ref GRAND_TOTALS, 0);
         TOTAL_COURSES = 0;
         PAGE_DEPTH = 38;
         PAGE_NUMBER = 0;
         LINE_COUNT = 0;
         PRINTER_ON();
         PRINT(PRINT_START_COMMAND);
         LAST_TYPE = "";
         /* !*  GOSUB 0200 ; * Print initial headings */
         nrf0 = "S";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, ID)) { STOP(); }
            COURSE_CODE = FIELD(ID, "*", 2);
            if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
            COURSE_DATE = FIELD(ID, "*", 1);
            if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] != LAST_TYPE)
            {
               /*  Last standard course printed. Show totals */
               if (TOTAL_COURSES > 0)
               {
                  L0170();
                  /*  Output totals */
               }
               PRINTER_CLOSE();
               TOTAL_COURSES = 0;
               PAGE_NUMBER = 0;
               LINE_COUNT = 0;
               LAST_TYPE = COURSE_MSTR_REC[COURSE_MSTR_TYPE];
               /* !*        GOSUB 0200 ; * Print headings */
            }
            /*  DJA 29.1.03 */
            PRINT(PRINT_START_COMMAND);
            MAT(ref TOTALS, 0);
            MAT(ref MAX_FEES, 0);
            MAT(ref PRT_LINE, "");
            TOTAL_COURSES = TOTAL_COURSES + 1;
            /*  Print the headings if this is the first course */
            if (TOTAL_COURSES == 1)
            {
               L0200();
            }
            L8000();
            /*  Build statistics for this course */
            L0150();
            /*  Print totals for one course */
         } while (true);
         L0170();
         /*  Print grand totals */
         /* DJA!PRINT PRINT.END.COMMAND: */
         PRINTER_CLOSE();
         PRINTER_OFF();
         return;
         /* ***************************************** */
      }
      void L0150()
      {
         /*  Print report line                  * */
         /* ***************************************** */
         LINE_COUNT = LINE_COUNT + 2;
         if (LINE_COUNT > PAGE_DEPTH)
         {
            L0200();
         }
         PRINT();
         PRINT();
         PRINT(FORMAT(COURSE_CODE, JUSTS[CODE]));
         PRINT(SPACE(1));
         PRINT(FORMAT((COURSE_MSTR_REC[COURSE_MSTR_DESC] + " (" + OCONV(COURSE_DATE, "D2/") + ")"), JUSTS[DESCRIPTION]));
         PRINT(SPACE(1));
         if (LAST_TYPE == "")
         {
            PRINT(FORMAT(TOTALS[MIN_PLACES], JUSTS[MIN_PLACES]));
         }
         else
         {
            PRINT(FORMAT("", JUSTS[MIN_PLACES]));
         }
         PRINT(SPACE(1));
         PRINT(FORMAT(TOTALS[MAX_PLACES], JUSTS[MAX_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(TOTALS[ACT_PLACES], JUSTS[ACT_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(TOTALS[LEFT_PLACES], JUSTS[LEFT_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(TOTALS[PERC_PLACES], CONVS[PERC_PLACES]), JUSTS[PERC_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(TOTALS[MAX_INCOME], CONVS[MAX_INCOME]), JUSTS[MAX_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(TOTALS[EXP_INCOME], CONVS[EXP_INCOME]), JUSTS[EXP_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(TOTALS[ACT_INCOME], CONVS[ACT_INCOME]), JUSTS[ACT_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(TOTALS[OS_INCOME], CONVS[OS_INCOME]), JUSTS[OS_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(WARNING, JUSTS[COMMENT]));
         return;
         /* ***************************************** */
      }
      void L0170()
      {
         /*  Print grand totals                 * */
         /* ***************************************** */
         LINE_COUNT = LINE_COUNT + 2;
         if (LINE_COUNT > PAGE_DEPTH)
         {
            L0200();
         }
         PRINT();
         PRINT();
         PRINT(FORMAT(SPACE(1), JUSTS[CODE]));
         PRINT(SPACE(1));
         if (LAST_TYPE == "")
         {
            PRINT(FORMAT(("GRAND TOTALS (" + TOTAL_COURSES + " courses)"), JUSTS[DESCRIPTION]));
         }
         else
         {
            PRINT(FORMAT(("GRAND TOTALS (" + TOTAL_COURSES + " act. days)"), JUSTS[DESCRIPTION]));
         }
         PRINT(SPACE(1));
         /* !*  PRINT GRAND.TOTALS(MIN.PLACES) JUSTS(MIN.PLACES): */
         PRINT(FORMAT(SPACE(1), JUSTS[MIN_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(GRAND_TOTALS[MAX_PLACES], JUSTS[MAX_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(GRAND_TOTALS[ACT_PLACES], JUSTS[ACT_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(GRAND_TOTALS[LEFT_PLACES], JUSTS[LEFT_PLACES]));
         PRINT(SPACE(1));
         if (TOTAL_COURSES == 0)
         {
            AVERAGE_PERC = 0;
         }
         else
         {
            AVERAGE_PERC = GRAND_TOTALS[PERC_PLACES] / TOTAL_COURSES;
         }
         PRINT(FORMAT(OCONV(AVERAGE_PERC, CONVS[PERC_PLACES]), JUSTS[PERC_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(GRAND_TOTALS[MAX_INCOME], CONVS[MAX_INCOME]), JUSTS[MAX_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(GRAND_TOTALS[EXP_INCOME], CONVS[EXP_INCOME]), JUSTS[EXP_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(GRAND_TOTALS[ACT_INCOME], CONVS[ACT_INCOME]), JUSTS[ACT_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT(OCONV(GRAND_TOTALS[OS_INCOME], CONVS[OS_INCOME]), JUSTS[OS_INCOME]));
         PRINT();
         return;
         /* ****************************** */
      }
      void L0200()
      {
         /*   PRINT REPORT HEADINGS  * */
         /* ****************************** */
         PAGE_NUMBER = PAGE_NUMBER + 1;
         LINE_COUNT = 0;
         if (LAST_TYPE == "")
         {
            TITLE = "Statistics for courses starting between " + START_DATE + " and " + END_DATE;
         }
         else
         {
            TITLE = "Statistics for activity days starting between " + START_DATE + " and " + END_DATE;
         }
         UNDERLINE = STR("=", LEN(TITLE));
         if (MACHINE_TYPE == "UNIVERSE")
         {
            if (FIRST_PAGE == TRUE)
            {
               FIRST_PAGE = FALSE;
            }
            else
            {
               PAGE();
            }
         }
         else
         {
            PRINT(FF);
         }
         PRINT("(" + PROGRAM + ")" + SPACE(4) + FORMAT(TITLE, "L#76"));
         PRINT(TIMEDATE());
         PRINT("  Page ");
         PRINTCR(PAGE_NUMBER);
         PRINTCR(SPACE(11) + UNDERLINE);
         PRINT();
         PRINT(FORMAT("Code", JUSTS[CODE]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Description", JUSTS[DESCRIPTION]));
         PRINT(SPACE(1));
         if (LAST_TYPE == "")
         {
            PRINT(FORMAT("Min", JUSTS[MIN_PLACES]));
         }
         else
         {
            PRINT(FORMAT("", JUSTS[MIN_PLACES]));
         }
         PRINT(SPACE(1));
         PRINT(FORMAT("Max", JUSTS[MAX_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Act", JUSTS[ACT_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Left", JUSTS[ACT_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT("  %", JUSTS[PERC_PLACES]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Maximum", JUSTS[MAX_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Expected", JUSTS[EXP_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT("Actual", JUSTS[ACT_INCOME]));
         PRINT(SPACE(1));
         PRINT(FORMAT("O/S", JUSTS[OS_INCOME]));
         return;
         /* ******************************** */
      }
      void L8000()
      {
         /*   Build statisics          * */
         /* ******************************** */
         LOWEST_ADAY_PLACES = 99999;
         THIS_MAX = 0;
         THIS_VAC = 0;
         THIS_MIN = 0;
         THIS_ACT = 0;
         MAX_PER_SESSION = "";
         if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
         {
            THIS_MAX = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
            THIS_VAC = COURSE_DET_REC[COURSE_DET_VACANCIES];
            THIS_MIN = COURSE_DET_REC[COURSE_DET_MINIMUM_PLACES];
            THIS_ACT = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
         }
         else
         {
            VAC_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_VACANCIES], VM);
            for (VMC = 1; VMC <= VAC_COUNT; VMC += 1)
            {
               for (SNO = 1; SNO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; SNO += 1)
               {
                  if (COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, VMC, SNO] == "Y")
                  {
                     /*  This session runs */
                     THIS_MAX = THIS_MAX + COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
                     MAX_PER_SESSION[1, SNO] = MAX_PER_SESSION[1, SNO] + COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
                     THIS_VAC = THIS_VAC + COURSE_DET_REC[COURSE_DET_VACANCIES][1, VMC, SNO];
                     THIS_MIN = THIS_MIN + COURSE_DET_REC[COURSE_DET_MINIMUM_PLACES];
                     THIS_ACT = THIS_MAX - THIS_VAC;
                     if (THIS_ACT < LOWEST_ADAY_PLACES)
                     {
                        LOWEST_ADAY_PLACES = THIS_ACT;
                     }
                  }
               }
            }
         }
         TOTALS[MAX_PLACES] = THIS_MAX;
         TOTALS[LEFT_PLACES] = THIS_VAC;
         TOTALS[MIN_PLACES] = THIS_MIN;
         /*  Get concession information */
         if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
         {
            NO_FEES = 1;
         }
         else
         {
            NO_FEES = COURSE_DET_REC[COURSE_DET_SESSIONS];
         }
         for (FEE_NO = 1; FEE_NO <= NO_FEES; FEE_NO += 1)
         {
            THIS_FEE = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, FEE_NO];
            if (THIS_FEE == "") { THIS_FEE = COURSE_DET_REC[COURSE_DET_FEE_CODE][1, 1]; }
            CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*C*" + THIS_FEE;
            if (READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE))
            {
               if (LOCATE(COURSE_DATE, CONTROL_FEE_REC, 0, 0, 1, ref PNTR, "AR"))
               {
                  FEE_DATE = COURSE_DATE;
               }
               else
               {
                  PNTR = PNTR - 1;
                  if (PNTR <= 0) { PNTR = 1; }
                  FEE_DATE = CONTROL_FEE_REC[PNTR];
               }
               CENTRE_TICKET_CODE = COMMON.CENTRE + "*C*" + THIS_FEE + "*" + FEE_DATE;
               if (!MATREAD(ref TICK_FEES_REC, COMMON.FILES[FL_TICKET_FEES], CENTRE_TICKET_CODE)) { MAT(ref TICK_FEES_REC, INIT); }
            }
            else
            {
               MAT(ref TICK_FEES_REC, INIT);
            }
            /*     Find the maximum fee for each group to calculate 'maximum' income */
            NO_OF_CONCESSIONS = DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM);
            for (CONCESSION_NO = 1; CONCESSION_NO <= NO_OF_CONCESSIONS; CONCESSION_NO += 1)
            {
               GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESSION_NO];
               if (!LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref POS, "AL")) { POS = 1; }
               if (TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESSION_NO] > MAX_FEES[POS][1, FEE_NO])
               {
                  MAX_FEES[POS][1, FEE_NO] = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESSION_NO];
               }
            }
         }
         /*     Get the Expected and Actual income from the students on this course */
         COURSE_DETAIL_ID = COURSE_DATE + "*" + COURSE_CODE;
         NO_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
         for (STUDENT_NO = 1; STUDENT_NO <= NO_OF_STUDENTS; STUDENT_NO += 1)
         {
            STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_NO];
            ENROL_ID = COURSE_DETAIL_ID + "*" + STUDENT_ID;
            if (MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID))
            {
               if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
               /*  Extract course balance */
               /*  Unenrolment fees are included here for completeness, but if */
               /*  unenrolled the student number won't be on course details so */
               /*  they won't be identified anyway */
               FEE_ADJUSTMENTS = 0;
               ORIGINAL_FEES = 0;
               PAYMENTS = 0;
               REFUNDS = 0;
               UNENROLMENT = 0;
               COURSE_BALANCE = 0;
               TRANS_NO = 1;
               do
               {
                  if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
                  if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == COURSE_DETAIL_ID)
                  {
                     COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     // BEGIN CASE
                     // CASE
                     if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "O")
                     {
                        ORIGINAL_FEES = ORIGINAL_FEES + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     }// CASE
                     else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "D")
                     {
                        UNENROLMENT = UNENROLMENT + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     }// CASE
                     else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P")
                     {
                        PAYMENTS = PAYMENTS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     }// CASE
                     else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "R")
                     {
                        REFUNDS = REFUNDS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     }// CASE
                     else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "A")
                     {
                        FEE_ADJUSTMENTS = FEE_ADJUSTMENTS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
                     }
                     // END CASE
                  }
                  TRANS_NO = TRANS_NO + 1;
               } while (true);
               if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref POS, "AL"))
               {
                  GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, POS];
                  if (!LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP, "AL")) { GROUP = 1; }
               }
               else
               {
                  GROUP = 1;
               }
               /* !*CRT "GROUP=":GROUP:;INPUT FLEX,1: */
               /* !*CRT "EXP.INCOME=":EXP.INCOME:;INPUT FLEX,1: */
               /* !*CRT "ORIGINAL.FEES=":ORIGINAL.FEES:;INPUT FLEX,1: */
               /* !*CRT "UNENROLMENT=":UNENROLMENT:;INPUT FLEX,1: */
               /* !*CRT "FEE.ADJUSTMENTS=":FEE.ADJUSTMENTS:;INPUT FLEX,1: */
               /* !*CRT "PAYMENTS=":PAYMENTS:;INPUT FLEX,1: */
               /* !*CRT "REFUNDS=":REFUNDS:;INPUT FLEX,1: */
               /* !*CRT "OS.INCOME=":OS.INCOME:;INPUT FLEX,1: */
               PRT_LINE[GROUP, EXP_INCOME] = PRT_LINE[GROUP, EXP_INCOME] + ORIGINAL_FEES + UNENROLMENT + FEE_ADJUSTMENTS;
               PRT_LINE[GROUP, ACT_INCOME] = PRT_LINE[GROUP, ACT_INCOME] - PAYMENTS - REFUNDS;
               PRT_LINE[GROUP, OS_INCOME] = PRT_LINE[GROUP, OS_INCOME] + ORIGINAL_FEES + UNENROLMENT + FEE_ADJUSTMENTS + PAYMENTS + REFUNDS;
            }
         }
         /*     Store the data for each group */
         GROUPS_EXIST = FALSE;
         NO_OF_GROUPS = DCOUNT(COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], VM);
         N = 1;
         do
         {
            if (GROUPS_EXIST || N > NO_OF_GROUPS) break;
            if (COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, N] != "") { GROUPS_EXIST = TRUE; }
            N = N + 1;
         } while (true);
         if (NOT(GROUPS_EXIST)) { NO_OF_GROUPS = 1; }
         for (GROUP = 1; GROUP <= NO_OF_GROUPS; GROUP += 1)
         {
            PRT_LINE[GROUP, CONCESSION] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, GROUP];
            if (GROUPS_EXIST)
            {
               /* !*        PRT.LINE(GROUP,MIN.PLACES) = COURSE.DET.MINIMUM.PLACES */
               PRT_LINE[GROUP, MAX_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, GROUP];
               PRT_LINE[GROUP, LEFT_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP];
               PRT_LINE[GROUP, ACT_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, GROUP] - COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP];
            }
            else
            {
               /*  Most courses, and ALL activity days will have no groups */
               /* !*        PRT.LINE(GROUP,MIN.PLACES) = THIS.MIN */
               PRT_LINE[1, MAX_PLACES] = THIS_MAX;
               PRT_LINE[1, LEFT_PLACES] = THIS_VAC;
               PRT_LINE[1, ACT_PLACES] = THIS_ACT;
            }
            if (PRT_LINE[GROUP, ACT_PLACES] + 0 != 0)
            {
               PRT_LINE[GROUP, PERC_PLACES] = PRT_LINE[GROUP, ACT_PLACES] / PRT_LINE[GROUP, MAX_PLACES] * 100;
            }
            else
            {
               PRT_LINE[GROUP, PERC_PLACES] = 0;
            }
            if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
            {
               PRT_LINE[GROUP, MAX_INCOME] = PRT_LINE[GROUP, MAX_PLACES] * MAX_FEES[GROUP];
            }
            else
            {
               for (N = 1; N <= COURSE_DET_REC[COURSE_DET_SESSIONS]; N += 1)
               {
                  PRT_LINE[GROUP, MAX_INCOME] = PRT_LINE[GROUP, MAX_INCOME] + (MAX_PER_SESSION[1, N] * MAX_FEES[GROUP][1, N]);
               }
            }
            /*     Create the column totals */
            /* !*     TOTALS(MIN.PLACES) = TOTALS(MIN.PLACES) + PRT.LINE(GROUP,MIN.PLACES) */
            TOTALS[ACT_PLACES] = TOTALS[ACT_PLACES] + PRT_LINE[GROUP, ACT_PLACES];
            TOTALS[EXP_INCOME] = TOTALS[EXP_INCOME] + PRT_LINE[GROUP, EXP_INCOME];
            /*  DJA 25.06.03 Max income is the max figure for the most expensive */
            /*  concessionary group */
            /* !*     TOTALS(MAX.INCOME) = TOTALS(MAX.INCOME) + PRT.LINE(GROUP,MAX.INCOME) */
            if (PRT_LINE[GROUP, MAX_INCOME] > TOTALS[MAX_INCOME])
            {
               TOTALS[MAX_INCOME] = PRT_LINE[GROUP, MAX_INCOME];
            }
            TOTALS[ACT_INCOME] = TOTALS[ACT_INCOME] + PRT_LINE[GROUP, ACT_INCOME];
            TOTALS[OS_INCOME] = TOTALS[OS_INCOME] + PRT_LINE[GROUP, OS_INCOME];
         }
         WARNING = "";
         if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
         {
            if (TOTALS[MIN_PLACES] > TOTALS[ACT_PLACES])
            {
               WARNING = "Below min!";
            }
         }
         else
         {
            /*  Decided to suppress this warning. It indicates that one or more */
            /*  sessions are under enrolled. Confusing, and unlikely to be */
            /*  useful */
            /* !* IF LOWEST.ADAY.PLACES < COURSE.DET.MINIMUM THEN */
            /* !*  WARNING = "Below min!" */
            /* !* END */
         }
         if (TOTALS[MAX_PLACES] + 0 != 0)
         {
            TOTALS[PERC_PLACES] = TOTALS[ACT_PLACES] / TOTALS[MAX_PLACES] * 100;
         }
         GRAND_TOTALS[MIN_PLACES] = GRAND_TOTALS[MIN_PLACES] + TOTALS[MIN_PLACES];
         GRAND_TOTALS[MAX_PLACES] = GRAND_TOTALS[MAX_PLACES] + TOTALS[MAX_PLACES];
         GRAND_TOTALS[LEFT_PLACES] = GRAND_TOTALS[LEFT_PLACES] + TOTALS[LEFT_PLACES];
         GRAND_TOTALS[ACT_PLACES] = GRAND_TOTALS[ACT_PLACES] + TOTALS[ACT_PLACES];
         GRAND_TOTALS[PERC_PLACES] = GRAND_TOTALS[PERC_PLACES] + TOTALS[PERC_PLACES];
         GRAND_TOTALS[MAX_INCOME] = GRAND_TOTALS[MAX_INCOME] + TOTALS[MAX_INCOME];
         GRAND_TOTALS[EXP_INCOME] = GRAND_TOTALS[EXP_INCOME] + TOTALS[EXP_INCOME];
         GRAND_TOTALS[ACT_INCOME] = GRAND_TOTALS[ACT_INCOME] + TOTALS[ACT_INCOME];
         GRAND_TOTALS[OS_INCOME] = GRAND_TOTALS[OS_INCOME] + TOTALS[OS_INCOME];
         /* !*  PRINT @(0,6):REV.UND.VID: */
         /* !*  IF NO.OF.GROUPS >= 1 THEN */
         /* !*     FOR GROUP = 1 TO 8 */
         /* !*        IF PRT.LINE(GROUP,CONCESSION) # "" THEN */
         /* !*           FOR I = 1 TO 9 */
         /* !*              COL = COLS(I) */
         /* !*              JUST = JUSTS(I) */
         /* !*              CONV = CONVS(I) */
         /* !*              PRINT @(COL, GROUP): */
         /* !*              IF CONV # "" THEN */
         /* !*                 PRINT OCONV( PRT.LINE(GROUP,I), CONV ) JUST: */
         /* !*              END ELSE */
         /* !*                 PRINT PRT.LINE(GROUP,I) JUST: */
         /* !*              END */
         /* !*           NEXT I */
         /* !*        END */
         /* !*     NEXT GROUP */
         /* !*  END */
         /* !*  PRINT @(0,17):DIM.VID: */
         /* !*  FOR I = 2 TO 9 */
         /* !*     COL = COLS(I) */
         /* !*     JUST = JUSTS(I) */
         /* !*     CONV = CONVS(I) */
         /* !*     PRINT @(COL, 17): */
         /* !*     IF CONV # "" THEN */
         /* !*        PRINT OCONV( TOTALS(I), CONV ) JUST: */
         /* !*     END ELSE */
         /* !*        PRINT TOTALS(I) JUST: */
         /* !*     END */
         /* !*  NEXT I */
         return;
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
