//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL919 : UvBase
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar EXTENSION = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar JUST = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar BACKUP_FL_MEMBERS = "";
      FL006 FL006;
      UvVar PROCESS_EXECUTE = "";
      UvVar THIS_RUN_DATE = "";
      UvVar THIS_RUN_TIME = "";
      UvVar REQUESTED_CENTRE = "";
      UvVar CURRENT_START_DATE = "";
      UvVar CURRENT_END_DATE = "";
      UvVar COURSE_TYPE = "";
      UvVar MEMBERSHIP_TYPE = "";
      UvVar TEST_ID = "";
      UvVar TEST_REC = "";
      UvVar TWO_MONTHS_AGO = "";
      UvVar COURSE_PARAMS = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar ID = "";
      UvVar COURSES_PROCESSED = "";
      UvVar STUDENTS_PROCESSED = "";
      UvVar MASTER_ID = "";
      UvVar DATE_POS = "";
      UvVar THIS_DATE = "";
      UvVar COURSE_DET_ID = "";
      UvVar NUMBER_OF_STUDENTS = "";
      UvVar STUDENT_MVC = "";
      UvVar THIS_STUDENT = "";
      UvVar UPDATE_REQUIRED = "";
      UvVar MEMBER_REC = "";
      UvVar OLD_MEMBER_REC = "";
      UvVar TYPE_POS = "";
      UvVar ENTITLED_EXPIRY = "";
      UvVar BACKUP_STUDENT_ID = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL919()
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
         /*     BATCH EXTENSION OF MEMBERSHIP TYPES BASED ON COURSE ATTENDANCE */
         PROMPT("");
         PROGRAM = "FL919";
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
         if (!(OPEN("BACKUP.FL.MEMBERS", out BACKUP_FL_MEMBERS)))
         {
            nrf0 = 3;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         THIS_RUN_DATE = TODAYS_DATE;
         THIS_RUN_TIME = INT(TIME());
         REQUESTED_CENTRE = CONTROLS_REC[5];
         CURRENT_START_DATE = CONTROLS_REC[6];
         CURRENT_END_DATE = CONTROLS_REC[7];
         EXTENSION = CONTROLS_REC[8];
         COURSE_TYPE = CONTROLS_REC[10];
         MEMBERSHIP_TYPE = CONTROLS_REC[11];
         TEST_ID = "CONTROL*" + COMMON.CENTRE + "*M*" + MEMBERSHIP_TYPE;
         if (!(READ(ref TEST_REC, COMMON.FILES[FL_TICKET_FEES], TEST_ID)))
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         if (NOT(MATCH(EXTENSION, "1N") || MATCH(EXTENSION, "2N") || MATCH(EXTENSION, "3N")))
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         TWO_MONTHS_AGO = TODAYS_DATE - 60;
         TWO_MONTHS_AGO = OCONV(TWO_MONTHS_AGO, "D");
         THIS_RUN_DATE = TODAYS_DATE;
         THIS_RUN_TIME = INT(TIME());
         PRINT(AT(0, 20) + COMMON.EOS);
         if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
         /* *********************************************** */
         /*   Main processing section                     * */
         /* *********************************************** */
         INSTRUCTION = "SELECT BACKUP.FL.MEMBERS WITH RUN.DATE < \"" + TWO_MONTHS_AGO + "\" OR WITH RUN.DATE = \"\" OR WITH RUN.DATE = \"OLD\"";
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            DELETE(BACKUP_FL_MEMBERS, ID);
         } while (true);
         /* * Routine to set printer parameters  (condensed print) */
         /* !!     PRINT.START.COMMAND = "" */
         /* !!     PRINT.END.COMMAND = "" */
         /* !!     PRINT.COMMANDS = "" */
         /* !!     CALL FL235("COURSES.LANDSCAPE",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
         /* !!     PRINTER ON */
         /* !!     IF PRINT.START.COMMAND <> "" THEN */
         /* !!        PRINT PRINT.START.COMMAND */
         /* !!     END */
         /* !!     PRINT "(":PROGRAM:")     Batch membership extension. Exceptions Report     ":OCONV(TODAYS.DATE,"D"):"  ":OCONV(TIME(),"MTS") */
         /* !!     PRINT */
         COURSES_PROCESSED = 0;
         STUDENTS_PROCESSED = 0;
         SELECT(FL_COURSE_MASTER);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref MASTER_ID, 0, 0, "")) { EOF = TRUE; }
            if (EOF) break;
            if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MASTER_ID)) { MAT(ref COURSE_MSTR_REC, ""); }
            /*  Find relevant courses */
            DATE_POS = 1;
            do
            {
               THIS_DATE = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, DATE_POS];
               if (THIS_DATE == "") break;
               if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
               {
                  if (REQUESTED_CENTRE == "" || (REQUESTED_CENTRE != "" && COURSE_MSTR_REC[COURSE_MSTR_CENTRE] == REQUESTED_CENTRE))
                  {
                     if (COURSE_TYPE == "" || COURSE_TYPE == COURSE_MSTR_REC[COURSE_MSTR_WEB_TYPE])
                     {
                        if (THIS_DATE >= CURRENT_START_DATE && THIS_DATE <= CURRENT_END_DATE)
                        {
                           COURSES_PROCESSED = COURSES_PROCESSED + 1;
                           /*  Extend the end dates */
                           COURSE_DET_ID = THIS_DATE + "*" + MASTER_ID;
                           if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID)) { MAT(ref COURSE_DET_REC, ""); }
                           NUMBER_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
                           for (STUDENT_MVC = 1; STUDENT_MVC <= NUMBER_OF_STUDENTS; STUDENT_MVC += 1)
                           {
                              THIS_STUDENT = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_MVC];
                              UPDATE_REQUIRED = FALSE;
                              if (READU(ref MEMBER_REC, COMMON.FILES[FL_MEMBERS], THIS_STUDENT))
                              {
                                 OLD_MEMBER_REC = MEMBER_REC;
                                 if (!(LOCATE(MEMBERSHIP_TYPE, MEMBER_REC[2], 1, 0, 1, ref TYPE_POS, "AL")))
                                 {
                                    MEMBER_REC = INSERT(MEMBER_REC, 2, TYPE_POS, 0, MEMBERSHIP_TYPE);
                                    MEMBER_REC = INSERT(MEMBER_REC, 13, TYPE_POS, 0, "");
                                    MEMBER_REC = INSERT(MEMBER_REC, 35, TYPE_POS, 0, "0");
                                    MEMBER_REC = INSERT(MEMBER_REC, 39, TYPE_POS, 0, "N");
                                    UPDATE_REQUIRED = TRUE;
                                 }
                                 ENTITLED_EXPIRY = (EXTENSION * 7) + THIS_DATE;
                                 if (ENTITLED_EXPIRY > MEMBER_REC[13, TYPE_POS])
                                 {
                                    MEMBER_REC[13, TYPE_POS] = ENTITLED_EXPIRY;
                                    UPDATE_REQUIRED = TRUE;
                                 }
                                 if (UPDATE_REQUIRED)
                                 {
                                    BACKUP_STUDENT_ID = THIS_STUDENT + "~" + THIS_RUN_DATE + "~" + THIS_RUN_TIME;
                                    WRITE(OLD_MEMBER_REC, BACKUP_FL_MEMBERS, BACKUP_STUDENT_ID);
                                    WRITE(MEMBER_REC, COMMON.FILES[FL_MEMBERS], THIS_STUDENT);
                                    STUDENTS_PROCESSED = STUDENTS_PROCESSED + 1;
                                 }
                              }
                              RELEASE();
                           }
                        }
                     }
                  }
               }
               DATE_POS = DATE_POS + 1;
            } while (true);
         } while (true);
         /* !!     IF PRINT.END.COMMAND <> "" THEN */
         /* !!        PRINT PRINT.END.COMMAND */
         /* !!     END */
         /* !!     PRINTER CLOSE */
         /* !!     PRINTER OFF */
         PRINTCR(AT(10, 22) + "Courses processed = " + COURSES_PROCESSED + "   Students processed = " + STUDENTS_PROCESSED + COMMON.EOL);
         return;
         /*  End of program */
      }
   }
}
