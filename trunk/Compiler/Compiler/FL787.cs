//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL787 : UvBase
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
      readonly UvVar SCREENS = 8;
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
      readonly UvVar FL_BLOCK_HEADER = 87;
      readonly UvVar BLOCK_SDESC = 1;
      readonly UvVar BLOCK_STIME = 2;
      readonly UvVar BLOCK_ETIME = 3;
      readonly UvVar BLOCK_SPORT = 4;
      readonly UvVar BLOCK_FLOORS1 = 5;
      readonly UvVar BLOCK_FLOORS2 = 6;
      readonly UvVar BLOCK_FLOORS3 = 7;
      readonly UvVar BLOCK_DATES1 = 8;
      readonly UvVar BLOCK_DATES2 = 9;
      readonly UvVar BLOCK_DATES3 = 10;
      readonly UvVar BLOCK_PRICE_REF = 11;
      readonly UvVar BLOCK_LETTER = 12;
      readonly UvVar BLOCK_INSTALL = 13;
      readonly UvVar BLOCK_START = 14;
      readonly UvVar BLOCK_FREQUENCY = 15;
      readonly UvVar BLOCK_NO_INSTALLS = 16;
      readonly UvVar BLOCK_NOTES = 17;
      readonly UvVar BLOCK_DATE_MADE = 18;
      readonly UvVar BLOCK_USER = 19;
      readonly UvVar BLOCK_DEALER = 20;
      readonly UvVar BLOCK_FLOORS4 = 21;
      readonly UvVar BLOCK_FLOORS5 = 22;
      readonly UvVar BLOCK_FLOORS6 = 23;
      readonly UvVar BLOCK_FLOORS7 = 24;
      readonly UvVar BLOCK_DATES4 = 25;
      readonly UvVar BLOCK_DATES5 = 26;
      readonly UvVar BLOCK_DATES6 = 27;
      readonly UvVar BLOCK_DATES7 = 28;
      readonly UvVar STOCK_DESC = 1;
      readonly UvVar STOCK_QTY = 2;
      readonly UvVar STOCK_UNIT = 3;
      readonly UvVar STOCK_REORDER_LEVEL = 4;
      readonly UvVar STOCK_REORDER_QTY = 5;
      readonly UvVar STOCK_QTY_ON_ORDER = 6;
      readonly UvVar STOCK_NOTES = 7;
      readonly UvVar STOCK_ORDER_SEQ = 8;
      readonly UvVar STOCK_REFERENCE = 18;
      readonly UvVar ACT_CODE_DESCRIPTION = 1;
      readonly UvVar ACT_CODE_WEB_LEVEL = 2;
      readonly UvVar ACT_CODE_WAIT_LIST = 3;
      readonly UvVar MC_NAME = 1;
      readonly UvVar MC_ACCOUNT = 2;
      readonly UvVar MC_TELEPHONE = 3;
      readonly UvVar MC_ADDRESS1 = 4;
      readonly UvVar MC_ADDRESS2 = 5;
      readonly UvVar MC_ADDRESS3 = 6;
      readonly UvVar MC_ADDRESS4 = 7;
      readonly UvVar MC_ADDRESS5 = 8;
      readonly UvVar MC_VAT_NUMBER = 9;
      readonly UvVar MC_NOTE1 = 10;
      readonly UvVar MC_NOTE2 = 11;
      readonly UvVar MC_NOTE3 = 12;
      readonly UvVar MC_SHORT_NAME = 13;
      readonly UvVar MC_WEB_BOOKABLE = 14;
      readonly UvVar MC_WEB_ENROLMENT = 15;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] INSTRUCTOR_REC = new UvVar[30];
      UvVar[] BLOCK_REC = new UvVar[30];
      UvVar[] STOCK_REC = new UvVar[20];
      UvVar[] ACT_CODE_REC = new UvVar[5];
      UvVar[] MASTER_CENTRE_REC = new UvVar[15];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar ZZZ_STATUS = "";
      UvVar NEW_COURSE = "";
      UvVar OLD_COURSE_DATE = "";
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SCREEN_WIDTH = "";
      UvVar GO_BACK = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar FULL_WEEK = "";
      UvVar PROCESS_LOCKED = "";
      UvVar JUST = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_INSTRUCTORS = "";
      UvVar FL_STOCK = "";
      UvVar FL_ACTIVITY_CODES = "";
      UvVar FL_MASTER_CENTRES = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar LINE = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar ST_ATT = "";
      UvVar START_FIELD_NO = "";
      UvVar FIELD_DATA = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_JUST = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      FL006 FL006;
      UvVar COURSE_ID = "";
      UvVar COURSE_DATE = "";
      UvVar TEST_POS = "";
      UvVar OK_TO_FILE = "";
      UvVar DAYS_TEXT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_LENGTH = "";
      UvVar N = "";
      UvVar FLAG_COL = "";
      UvVar EXTRA_COL = "";
      UvVar ST_MANDATORY = "";
      UvVar ST_CONVERSION = "";
      UvVar PROMPT_NO = "";
      FL000_10 FL000_10;
      UvVar PRINT_LINE = "";
      UvVar ST_DESC = "";
      UvVar ST_ATT_MV = "";
      UvVar I = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_LENGTH = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar FULL_INSTRUCTOR_NAME = "";
      UvVar DISPLAY_MODE = "";
      UvVar SCAN_STUDENT_ID = "";
      FL717 FL717;
      UvVar REDISPLAY = "";
      CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
      UvVar DETAILS_ID = "";
      UvVar DATE_LIST = "";
      UvVar CREATION_ALLOWED = "";
      FL704 FL704;
      UvVar SELECT_DATE = "";
      UvVar EXIST_COURSE = "";
      UvVar CONV_ANS = "";
      UvVar POS = "";
      UvVar STORED_FIELD_DATA = "";
      UvVar FNO = "";
      UvVar DONE = "";
      UvVar FLAG_NO = "";
      UvVar ANS2 = "";
      FL822 FL822;
      UvVar RETURNED_ANS = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      UvVar TICKET_CODE = "";
      UvVar CONTROL_TICKET_CODE = "";
      UvVar CONTROL_FEE_REC = "";
      UvVar EXTRA_NO = "";
      UvVar SESSIONS_PER_WEEK = "";
      UvVar LAST_POS = "";
      UvVar NEW_POS = "";
      FL718 FL718;
      UvVar INSTRUCTOR_ID = "";
      FL721 FL721;
      FL722 FL722;
      UvVar SESSION_DATE_COUNT = "";
      UvVar THIS_DATE = "";
      UvVar DAY_OF_WEEK = "";
      UvVar DATE_POS = "";
      UvVar UNAVAILABLE_SESSIONS = "";
      UvVar SNO = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL787(ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar NEW_COURSE, ref UvVar OLD_COURSE_DATE)
      {
         this.COURSE_MSTR_REC = COURSE_MSTR_REC;
         this.COURSE_DET_REC = COURSE_DET_REC;
         this.NEW_COURSE = NEW_COURSE;
         this.OLD_COURSE_DATE = OLD_COURSE_DATE;
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
         /*     ACTIVITY DAY MAINTENANCE */
         PROMPT("");
         PROGRAM = "FL787";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         FULL_WEEK = "MOTUWETHFRSASU";
         PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
         JUST = "";
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
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
         #region INCLUDE FL.FILES FL.INSTRUCTORS
         if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

         #endregion
         #region INCLUDE FL.FILES FL.BLOCK.HEADER

         #endregion
         #region INCLUDE FL.FILES FL.STOCK
         if (!OPEN("FL.STOCK", out FL_STOCK)) { STOP("201", "FL.STOCK"); }

         /* !!** */
         /* !!*EQU STOCK.DELIVERED     TO STOCK.REC(8) */
         /* !!*EQU STOCK.TRAN.TYPE     TO STOCK.REC(15) */
         /* !!*EQU STOCK.TRAN.DATE     TO STOCK.REC(16) */
         /* !!*EQU STOCK.TRAN.VALUE    TO STOCK.REC(17) */

         #endregion
         #region INCLUDE FL.FILES FL.ACTIVITY.CODES
         if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

         #endregion
         #region INCLUDE FL.FILES FL.MASTER.CENTRES
         #region INCLUDE FL.FILES FL.MASTER.CENTRES.EQU
         if (!OPEN("FL.MASTER.CENTRES", out FL_MASTER_CENTRES)) { STOP("201", "FL.MASTER.CENTRES"); }

         #endregion

         #region INCLUDE FL.FILES FL.MASTER.CENTRES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.MASTER.CENTRES.VAR

         #endregion

         #endregion
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
         FIRST_FIELD = 0;
         DATA_FIELDS = "";
         do
         {
            LINE = SC_POS[SCREEN_LINES + 1];
            if (LINE == "") break;
            if (LINE[1, 4] != "")
            {
               MAX_FIELDS = MAX_FIELDS + 1;
               if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0)
               {
                  FIRST_FIELD = MAX_FIELDS;
               }
               DATA_FIELDS[MAX_FIELDS] = LINE;
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
            if (PROG_MESS[2] != "")
            {
               MAIN_KEY = PROG_MESS[2];
               AMENDING = TRUE;
               L8000();
               /*  Build temp.rec */
               L0300();
               /*  Display data */
            }
            else
            {
               MAIN_KEY = "";
               MAT(ref TEMP_REC, "");
            }
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     L0060();
                     if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
                     // BEGIN CASE
                     // CASE
                     if (ST_ATT == 0)
                     {
                        FIELD_NO = FIELD_NO + 1;
                     }// CASE
                     else if (AMENDING == FALSE && INTERACT == VALID_DATA && TEMP_REC[ST_ATT] == "" && (ST_ATT >= 5 && ST_ATT <= 11))
                     {
                        /*  Skip to closing date */
                        START_FIELD_NO = FIELD_NO + 1;
                        for (FIELD_NO = START_FIELD_NO; FIELD_NO <= 13; FIELD_NO += 1)
                        {
                           FIELD_DATA = DATA_FIELDS[FIELD_NO];
                           L0200();
                           PRINT(AT(ST_COL, ST_ROW) + SPACE(20));
                        }
                        FIELD_NO = 14;
                     }// CASE
                     else if (AMENDING == FALSE && INTERACT == VALID_DATA && TEMP_REC[ST_ATT] == "" && (ST_ATT >= 22 && ST_ATT <= 24))
                     {
                        /*  Last comment entered.  Skip forward to Analysis section */
                        START_FIELD_NO = FIELD_NO + 1;
                        for (FIELD_NO = START_FIELD_NO; FIELD_NO <= 27; FIELD_NO += 1)
                        {
                           FIELD_DATA = DATA_FIELDS[FIELD_NO];
                           L0200();
                           PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
                        }
                        FIELD_NO = 28;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        FIELD_NO = FIELD_NO + 1;
                     }
                     // END CASE
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
                  else if (INTERACT == BACKUP && FIELD_NO > 1)
                  {
                     FIELD_NO = FIELD_NO - 1;
                  }// CASE
                  else if (FIELD_NO == MAX_FIELDS)
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
               if (MAIN_KEY != "" && INTERACT != EXIT)
               {
                  /*  Transfer data out of TEMP.REC */
                  L9000();
               }
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
            INPUT_LINE = "   Enter Field no, Page no, 'D'elete or 'F' to finish ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 3);
            if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (ANS == "")
            {
               /*  Next page */
               /* *         GOSUB 0055 */
               /* *         IF INTERACT = FINISH THEN PROG.MESS<1> = 2 */
            }// CASE
            else if (ANS == "D")
            {
               /*  Validate that enrolment has not commenced */
               // BEGIN CASE
               // CASE
               if (COURSE_DET_REC[COURSE_DET_STUDENT_IDS] != "")
               {
                  nrf0 = 32;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (OTHERWISE)
               {
                  INTERACT = INVALID_DATA;
                  do
                  {
                     INPUT_LINE = "    Are you sure you wish to delete this course? (Y/N) ";
                     PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                     PRINT(AT(2, 21) + INPUT_LINE);
                     INPUT(out ANS, 4);
                     PRINT(AT(2, 21) + SPACE(74));
                     // BEGIN CASE
                     // CASE
                     if (ANS == COMMON.ABANDON)
                     {
                        INTERACT = EXIT;
                     }// CASE
                     else if (ANS == "N")
                     {
                        INTERACT = VALID_DATA;
                     }// CASE
                     else if (ANS == "Y")
                     {
                        COURSE_ID = PROG_MESS[2];
                        COURSE_DATE = PROG_MESS[3];
                        DELETE(FL_COURSE_DETAILS, COURSE_DATE + "*" + COURSE_ID);
                        if (LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref TEST_POS, "AL"))
                        {
                           COURSE_MSTR_REC[COURSE_MSTR_DATES] = DELETE(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, TEST_POS, 0);
                        }
                        if (COURSE_MSTR_REC[COURSE_MSTR_DATES] == "")
                        {
                           DELETE(FL_COURSE_MASTER, COURSE_ID);
                        }
                        else
                        {
                           MATWRITE(COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_ID);
                        }
                        INTERACT = FINISH;
                        PROG_MESS[1] = COMMON.ABANDON;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        INTERACT = INVALID_DATA;
                     }
                     // END CASE
                     if (!(INTERACT == INVALID_DATA)) break;
                  } while (true);
                  if (INTERACT == FINISH)
                  {
                     /*  Deletion done */
                     INTERACT = EXIT;
                  }
                  else
                  {
                     /*  Reprompt for action */
                     INTERACT = INVALID_DATA;
                  }
               }
               // END CASE
            }// CASE
            else if (ANS == "F")
            {
               L0055();
               if (INTERACT == FINISH) { PROG_MESS[1] = ""; }
               /* *      CASE ANS[1,1] = "P" OR ANS[1,1] = "p" */
               /* *         GOSUB 0055 */
               /* *         IF INTERACT = FINISH THEN PROG.MESS<1> = ANS[2,1] */
            }// CASE
            else if (MATCH(ANS, "0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1)
            {
               FIELD_NO = ANS + FIRST_FIELD - 1;
               if (((ANS >= 2 && ANS <= 12) || ANS == 14 || ANS == 17 || ANS == 20 || ANS == 21) && COURSE_DET_REC[COURSE_DET_STUDENT_IDS] != "")
               {
                  nrf0 = 27;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
               else
               {
                  INTERACT = VALID_DATA;
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
         /*  Validate user can leave page 1        * */
         /* ******************************************** */
         /*  Validate that key fields are present before allowing the user to file */
         OK_TO_FILE = TRUE;
         // BEGIN CASE
         /*  Start date */
         // CASE
         if (TEMP_REC[2] == "")
         {
            OK_TO_FILE = FALSE;
            nrf0 = 9;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            /*  End date */
         }// CASE
         else if (TEMP_REC[3] == "")
         {
            OK_TO_FILE = FALSE;
            nrf0 = 10;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            /*  Closing Date */
         }// CASE
         else if (TEMP_REC[13] == "")
         {
            OK_TO_FILE = FALSE;
            nrf0 = 12;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (TEMP_REC[3] < TEMP_REC[2])
         {
            /*  End date precedes start date */
            nrf0 = 22;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            OK_TO_FILE = FALSE;
         }
         // END CASE
         DAYS_TEXT = TEMP_REC[20];
         L3050();
         /*  Validate days in case frequency changed */
         if (INTERACT == INVALID_DATA)
         {
            OK_TO_FILE = FALSE;
         }
         if (OK_TO_FILE)
         {
            INTERACT = FINISH;
         }
         return;
         /* ******************************** */
      }
      void L0060()
      {
         /*   DATA ENTRY ROUTINE       * */
         /* ******************************** */
         INTERACT = INVALID_DATA;
         FIELD_DATA = DATA_FIELDS[FIELD_NO];
         L0200();
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
         // BEGIN CASE
         // CASE
         if (ST_ATT >= 5 && ST_ATT <= 12)
         {
            /*  Unavailable sessions - additional session prompts */
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               FLAG_COL = ST_COL + ST_LENGTH + (2 * N) - 1;
               PRINT(AT(FLAG_COL, ST_ROW) + ".");
            }
         }// CASE
         else if (ST_ATT >= 16 && ST_ATT <= 18)
         {
            /*  Multiple prompts for fees and start/end times */
            for (N = 2; N <= TEMP_REC[25]; N += 1)
            {
               EXTRA_COL = ST_COL + ((N - 1) * (ST_LENGTH + 1));
               PRINT(AT(EXTRA_COL, ST_ROW) + STR(".", ST_LENGTH));
            }
         }
         // END CASE
         PRINT(AT(ST_COL, ST_ROW));
         INPUT(out ANS, ST_LENGTH);
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.ABANDON)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }// CASE
         else if (ANS == GO_BACK && AMENDING)
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (ANS == GO_BACK)
         {
            INTERACT = BACKUP;
            /*  Deal with default values for certain fields here */
         }// CASE
         else if (AMENDING == FALSE && ST_ATT == 13 && ANS == "" && VALUE == "")
         {
            VALUE = TEMP_REC[3];
            INTERACT = VALID_DATA;
         }// CASE
         else if (AMENDING == FALSE && ST_ATT == 27 && ANS == "" && VALUE == "")
         {
            VALUE = COMMON.CENTRE;
            /*  From COMMON */
            INTERACT = VALID_DATA;
         }// CASE
         else if (ANS == COMMON.CLR && ST_MANDATORY == "" && NOT(ST_ATT >= 5 && ST_ATT <= 12) && NOT(ST_ATT >= 16 && ST_ATT <= 18))
         {
            if (ST_ATT == 19 || ST_ATT == 20)
            {
               nrf0 = 5;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            else
            {
               VALUE = "";
               ANS = "";
               INTERACT = VALID_DATA;
            }
         }// CASE
         else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "")
         {
            nrf0 = 5;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (ANS == "" && VALUE != "" && NOT(ST_ATT >= 5 && ST_ATT <= 12) && NOT(ST_ATT >= 16 && ST_ATT <= 18))
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1 && NOT(ST_ATT >= 5 && ST_ATT <= 12) && NOT(ST_ATT >= 16 && ST_ATT <= 18))
         {
            INTERACT = VALID_DATA;
            // BEGIN CASE
            // CASE
            if (ST_ATT == 19)
            {
               /*  Frequency */
               VALUE = "W5";
            }// CASE
            else if (ST_ATT == 20)
            {
               /*  Days */
               if (TEMP_REC[19] != "W5")
               {
                  INTERACT = INVALID_DATA;
                  /*  No sensible default */
               }
               else
               {
                  VALUE = "MOTUWETHFR";
               }
            }
            // END CASE
         }// CASE
         else if (OTHERWISE)
         {
            #region ON FIELD_NO GOSUB ...
            switch ((int)FIELD_NO)
            {
               case 1: L1000(); break;
               case 2: L1100(); break;
               case 3: L1200(); break;
               case 4: L1300(); break;
               case 5: L1400(); break;
               case 6: L1500(); break;
               case 7: L1500(); break;
               case 8: L1500(); break;
               case 9: L1500(); break;
               case 10: L1500(); break;
               case 11: L1500(); break;
               case 12: L1500(); break;
               case 13: L1500(); break;
               case 14: L2300(); break;
               case 15: L2400(); break;
               case 16: L2500(); break;
               case 17: L2550(); break;
               case 18: L2600(); break;
               case 19: L2700(); break;
               case 20: L2700(); break;
               case 21: L2900(); break;
               case 22: L3000(); break;
               case 23: L3100(); break;
               case 24: L3100(); break;
               case 25: L3200(); break;
               case 26: L3300(); break;
               case 27: L3400(); break;
               case 28: L3600(); break;
               case 29: L3700(); break;
               case 30: L3900(); break;
            }
            #endregion
            if (INTERACT == VALID_DATA)
            {
               if (ST_CONVERSION != "")
               {
                  VALUE = ICONV(ANS, ST_CONVERSION);
                  if (ST_CONVERSION == "MT" && VALUE == 0) { VALUE = ""; }
               }
               else
               {
                  VALUE = ANS;
               }
            }
         }
         // END CASE
         PRINT(AT(ST_COL - 1, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
         // BEGIN CASE
         // CASE
         if (ST_ATT >= 5 && ST_ATT <= 12)
         {
            /*  Unavailable sessions - additional session prompts */
            PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               FLAG_COL = ST_COL + ST_LENGTH + (2 * N) - 1;
               PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, N + 1], "L#2"));
            }
         }// CASE
         else if (ST_ATT >= 16 && ST_ATT <= 18)
         {
            /*  Multiple prompts for fees and start/end times */
            if (ST_CONVERSION != "")
            {
               if (VALUE == "")
               {
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
               }
               else
               {
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
               }
            }
            else
            {
               PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
            }
            for (N = 2; N <= TEMP_REC[25]; N += 1)
            {
               EXTRA_COL = ST_COL + ((N - 1) * (ST_LENGTH + 1));
               if (ST_CONVERSION != "")
               {
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, N], ST_CONVERSION), ST_JUST));
               }
               else
               {
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, N], ST_JUST));
               }
            }
         }// CASE
         else if (ST_CONVERSION != "")
         {
            PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
         }// CASE
         else if (OTHERWISE)
         {
            PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
         }
         // END CASE
         if (ST_ATT == 0)
         {
            MAIN_KEY = VALUE;
         }
         else
         {
            TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
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
            PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
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
         ST_DESC = FIELD_DATA[1, 3];
         ST_LENGTH = FIELD_DATA[1, 4];
         ST_ATT_MV = FIELD_DATA[1, 5];
         ST_ATT = FIELD(ST_ATT_MV, ",", 1);
         ST_MV = FIELD(ST_ATT_MV, ",", 2);
         ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
         ST_CONVERSION = FIELD_DATA[1, 9];
         ST_MANDATORY = FIELD_DATA[1, 10];
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
            DISP_LENGTH = FIELD_DATA[1, 4];
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
               /*  Show instructors full name */
               if (DISP_ATT == 21 || DISP_ATT == 32)
               {
                  if (MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, TEMP_REC[DISP_ATT]))
                  {
                     FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
                     PRINT(AT(DISP_COL + 7, DISP_ROW) + FORMAT(FULL_INSTRUCTOR_NAME, "L#24"));
                  }
               }
            }
            // END CASE
            // BEGIN CASE
            // CASE
            if (DISP_ATT >= 5 && DISP_ATT <= 12)
            {
               /*  Unavailable sessions - additional session prompts */
               for (N = 1; N <= TEMP_REC[25]; N += 1)
               {
                  FLAG_COL = DISP_COL + DISP_LENGTH + (2 * N) - 1;
                  PRINT(AT(FLAG_COL, DISP_ROW) + TEMP_REC[DISP_ATT][1, N + 1]);
               }
            }// CASE
            else if (DISP_ATT >= 16 && DISP_ATT <= 18)
            {
               /*  Multiple prompts for fees and start/end times */
               for (N = 2; N <= TEMP_REC[25]; N += 1)
               {
                  EXTRA_COL = DISP_COL + ((N - 1) * (DISP_LENGTH + 1));
                  if (DISP_ATT == 16)
                  {
                     PRINT(AT(EXTRA_COL, DISP_ROW) + TEMP_REC[DISP_ATT][1, N]);
                  }
                  else
                  {
                     if (TEMP_REC[DISP_ATT][1, N] == "")
                     {
                        PRINT(AT(EXTRA_COL, DISP_ROW) + FORMAT("", DISP_JUST));
                     }
                     else
                     {
                        PRINT(AT(EXTRA_COL, DISP_ROW) + OCONV(TEMP_REC[DISP_ATT][1, N], "MT"));
                     }
                  }
               }
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
         // CASE
         if (INDEX(ANS, "*", 1))
         {
            nrf0 = 24;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
            /*  Scan for required course if the 'help' key is entered */
         }// CASE
         else if (ANS == COMMON.HELP && AMENDING == FALSE)
         {
            DISPLAY_MODE = 5;
            SCAN_STUDENT_ID = "";
            FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
            /*  Refresh screen */
            L0100();
            if (INTERACT != EXIT)
            {
               ANS = COURSE_ID;
               MAIN_KEY = ANS;
               /*  DJA 17/7/95 */
               nrf0 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 28;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  VALUE = "";
                  MAIN_KEY = "";
               }
               else
               {
                  PROG_MESS[2] = COURSE_ID;
                  PROG_MESS[3] = COURSE_DATE;
                  DETAILS_ID = COURSE_DATE + "*" + MAIN_KEY;
                  if (!MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY)) { MAT(ref COURSE_MSTR_REC, ""); }
                  if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A")
                  {
                     if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                     {
                        L8000();
                        /*  Build Temp.Rec */
                        AMENDING = TRUE;
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
                     INTERACT = INVALID_DATA;
                     nrf0 = 40;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }
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
               /*  DJA 17/7/95 */
               nrf0 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref FL_COURSE_MASTER, ref MAIN_KEY, ref nrf0);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 28;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  VALUE = "";
                  MAIN_KEY = "";
               }
               else
               {
                  PROG_MESS[2] = MAIN_KEY;
                  if (MATREADU(ref COURSE_MSTR_REC, FL_COURSE_MASTER, MAIN_KEY))
                  {
                     if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A")
                     {
                        /*  Call date selection window */
                        DATE_LIST = COURSE_MSTR_REC[COURSE_MSTR_DATES];
                        CREATION_ALLOWED = TRUE;
                        FL704 = new FL704(ref DATE_LIST, ref NEW_COURSE, ref CREATION_ALLOWED, ref SELECT_DATE, ref INTERACT, ref REDISPLAY);
                        /*  If box is abandoned, reprompt for course code */
                        if (INTERACT == EXIT)
                        {
                           INTERACT = INVALID_DATA;
                           MAIN_KEY = "";
                           MAT(ref COURSE_MSTR_REC, INIT);
                           ANS = "";
                           VALUE = "";
                           PROG_MESS[2] = "";
                           AMENDING = FALSE;
                           RELEASE();
                        }
                        else
                        {
                           INTERACT = VALID_DATA;
                        }
                        if (REDISPLAY)
                        {
                           L0100();
                           REDISPLAY = "";
                        }
                        if (INTERACT == VALID_DATA)
                        {
                           if (NEW_COURSE == TRUE)
                           {
                              /*  New course - select date is the last course ; data is copied */
                              /*  forward as a basis for the new course.  The start date will be put */
                              /*  into prog.mess<3>, so select.date is NOT. */
                              AMENDING = FALSE;
                              DETAILS_ID = SELECT_DATE + "*" + MAIN_KEY;
                              OLD_COURSE_DATE = "";
                              if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                              {
                                 /*  Set vacancies to same as maximums */
                                 /* !*                          COURSE.DET.VACANCIES = COURSE.DET.MAXIMUM.PLACES */
                                 COURSE_DET_REC[COURSE_DET_BOOKING_DATES] = INIT;
                                 COURSE_DET_REC[COURSE_DET_END] = INIT;
                                 COURSE_DET_REC[COURSE_DET_CLOSE_DATE] = INIT;
                                 COURSE_DET_REC[COURSE_DET_SCHEDULE_CODE] = INIT;
                                 COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = INIT;
                                 COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS] = "";
                                 COURSE_DET_REC[COURSE_DET_SESSION_DATES] = "";
                                 COURSE_DET_REC[COURSE_DET_SESSION_FLAGS] = "";
                                 L8000();
                                 /*  Set up temporary array */
                                 AMENDING = TRUE;
                              }
                              else
                              {
                                 MAT(ref TEMP_REC, "");
                                 /*  Warn that det.rec is missing.  This should not occur! */
                                 nrf0 = 8;
                                 nrf1 = INIT;
                                 FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                              }
                           }
                           else
                           {
                              /*  Existing course */
                              PROG_MESS[3] = SELECT_DATE;
                              DETAILS_ID = SELECT_DATE + "*" + MAIN_KEY;
                              if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID))
                              {
                                 L8000();
                                 /*  Build Temp.Rec */
                                 AMENDING = TRUE;
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
                        ANS = "";
                        VALUE = "";
                        MAIN_KEY = "";
                        PROG_MESS[2] = "";
                        PROG_MESS[3] = "";
                        nrf0 = 40;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     }
                  }
                  else
                  {
                     AMENDING = FALSE;
                     MAT(ref TEMP_REC, "");
                     NEW_COURSE = TRUE;
                     /* ********************** */
                     INTERACT = INVALID_DATA;
                     do
                     {
                        if (!(INTERACT == INVALID_DATA)) break;
                        INPUT_LINE = "  Enter an existing course code to use as a basis or <RETURN> ";
                        PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                        PRINT(AT(2, 21) + INPUT_LINE);
                        INPUT(out EXIST_COURSE, 12);
                        if (LEN(EXIST_COURSE) > 11) { PRINT(AT(-9) + " "); EXIST_COURSE = EXIST_COURSE.Substring(1, 11); }
                        PRINT(AT(2, 21) + SPACE(74));
                        if (EXIST_COURSE == COMMON.HELP)
                        {
                           DISPLAY_MODE = 5;
                           FL717 = new FL717(ref DISPLAY_MODE, ref SCAN_STUDENT_ID, ref COURSE_ID, ref COURSE_DATE, ref INTERACT, ref REDISPLAY);
                           EXIST_COURSE = COURSE_ID;
                           L0100();
                        }
                        // BEGIN CASE
                        // CASE
                        if (INTERACT == EXIT || EXIST_COURSE == COMMON.ABANDON)
                        {
                           INTERACT = EXIT;
                        }// CASE
                        else if (EXIST_COURSE == "")
                        {
                           INTERACT = VALID_DATA;
                        }// CASE
                        else if (OTHERWISE)
                        {
                           INTERACT = VALID_DATA;
                           if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, EXIST_COURSE))
                           {
                              if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A")
                              {
                                 if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_MSTR_REC[COURSE_MSTR_DATES][1, 1] + "*" + EXIST_COURSE)) { MAT(ref COURSE_DET_REC, ""); }
                                 /* !*                          COURSE.DET.VACANCIES = COURSE.DET.MAXIMUM.PLACES */
                                 COURSE_DET_REC[COURSE_DET_SCHEDULE_CODE] = "";
                                 COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = "";
                                 /* !*                          FOR MVC = 1 TO 8 */
                                 /* !*                             COURSE.DET.GROUP.VACANCIES<1,MVC> = COURSE.DET.GROUP.MAXIMUMS<1,MVC> */
                                 /* !*                          NEXT MVC */
                                 L8000();
                                 TEMP_REC[2] = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, 1];
                                 COURSE_MSTR_REC[COURSE_MSTR_DATES] = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, 1];
                                 PROG_MESS[3] = TEMP_REC[2];
                                 L0300();
                                 AMENDING = TRUE;
                                 /*  DJA 17/7/95 */
                                 NEW_COURSE = FALSE;
                                 OLD_COURSE_DATE = TEMP_REC[2];
                              }
                              else
                              {
                                 nrf0 = 41;
                                 nrf1 = "";
                                 FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                                 INTERACT = INVALID_DATA;
                              }
                           }
                           else
                           {
                              nrf0 = 30;
                              nrf1 = INIT;
                              FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                              INTERACT = INVALID_DATA;
                           }
                        }
                        // END CASE
                     } while (true);
                     /* ********************** */
                  }
                  if (INTERACT != INVALID_DATA)
                  {
                     if (AMENDING) { L0300(); }
                     INTERACT = VALID_DATA;
                  }
                  /*  DJA 17/7/95 */
                  /*  Course was locked */
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
         /*   DESCRIPTION Validation Routine */
         INTERACT = VALID_DATA;
         return;
      }
      void L1200()
      {
         /*   PERIOD START Validation Routine */
         if (ICONV(ANS, "D") == "")
         {
            /*  Invalid.date */
            INTERACT = INVALID_DATA;
            nrf0 = 1;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         else
         {
            INTERACT = VALID_DATA;
            /*  Ensure it isn't the same date as an existing course.  This */
            /*  would cause a clash of id's */
            CONV_ANS = ICONV(ANS, "D");
            if (NEW_COURSE || (NEW_COURSE == FALSE && OLD_COURSE_DATE != CONV_ANS))
            {
               if (LOCATE(CONV_ANS, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref POS, "AL"))
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 21;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
            /*  IMPORTANT : Prog.mess<3> must hold the course date in order for */
            /*              the controlling routine to file the records correctly. */
            if (INTERACT == VALID_DATA)
            {
               PROG_MESS[3] = ICONV(ANS, "D");
            }
         }
         return;
      }
      void L1300()
      {
         /*   PERIOD END Validation Routine */
         // BEGIN CASE
         // CASE
         if (ICONV(ANS, "D") == "")
         {
            /*  Invalid.date */
            INTERACT = INVALID_DATA;
            nrf0 = 1;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (ICONV(ANS, "D") < TEMP_REC[2])
         {
            /*  Course end date must preceed the end date */
            INTERACT = INVALID_DATA;
            nrf0 = 15;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = VALID_DATA;
         }
         // END CASE
         return;
      }
      void L1400()
      {
         /*   SESSIONS Validation Routine */
         if (ANS == "1" || ANS == "2" || ANS == "3" || ANS == "4" || ANS == "5")
         {
            INTERACT = VALID_DATA;
            /*  If no. sessions reduced, remove superfluous */
            /*  multi-session field data */
            if (ANS < 5)
            {
               STORED_FIELD_DATA = FIELD_DATA;
               for (N = (ANS + 1); N <= 5; N += 1)
               {
                  TEMP_REC[5][1, N + 1] = "";
                  TEMP_REC[6][1, N + 1] = "";
                  TEMP_REC[7][1, N + 1] = "";
                  TEMP_REC[8][1, N + 1] = "";
                  TEMP_REC[9][1, N + 1] = "";
                  TEMP_REC[10][1, N + 1] = "";
                  TEMP_REC[11][1, N + 1] = "";
                  TEMP_REC[12][1, N + 1] = "";
                  for (FNO = 6; FNO <= 13; FNO += 1)
                  {
                     FIELD_DATA = DATA_FIELDS[FNO];
                     L0200();
                     FLAG_COL = ST_COL + ST_LENGTH + (2 * N) - 1;
                     PRINT(AT(FLAG_COL, ST_ROW) + "  ");
                  }
                  TEMP_REC[16][1, N] = "";
                  TEMP_REC[17][1, N] = "";
                  TEMP_REC[18][1, N] = "";
                  for (FNO = 18; FNO <= 20; FNO += 1)
                  {
                     FIELD_DATA = DATA_FIELDS[FNO];
                     L0200();
                     EXTRA_COL = ST_COL + ((N - 1) * (ST_LENGTH + 1));
                     PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT("", ST_JUST));
                  }
               }
               FIELD_DATA = STORED_FIELD_DATA;
               L0200();
            }
         }
         else
         {
            nrf0 = 42;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L1500()
      {
         /*   UNAVAILABLE SESSIONS Validation Routine */
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.CLR)
         {
            ANS = "";
            VALUE = "";
            TEMP_REC[ST_ATT] = "";
            PRINT(AT(ST_COL, ST_ROW) + SPACE(20));
            INTERACT = VALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            if (ANS != "" && ICONV(ANS, "D") == "")
            {
               /*  Invalid date */
               INTERACT = INVALID_DATA;
               nrf0 = 1;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            else
            {
               if (ANS == "" && VALUE != "")
               {
                  ANS = OCONV(VALUE, "D");
               }
               else
               {
                  VALUE = ICONV(ANS, "D");
               }
               if (ANS != "" && ST_ATT > 5 && VALUE <= TEMP_REC[ST_ATT - 1][1, 1])
               {
                  /*  Exception dates must be entered in ascending, numerical */
                  /*  order to avoid entry of duplicate dates */
                  nrf0 = 48;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  ANS = "";
                  VALUE = "";
               }
               else
               {
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, "D"), ST_JUST));
                  INTERACT = VALID_DATA;
               }
               if (ANS != "")
               {
                  /*  There is a restriction date */
                  /*  Now capture the extra session flags */
                  DONE = FALSE;
                  FLAG_NO = 1;
                  do
                  {
                     if (FLAG_NO > TEMP_REC[25] || DONE) break;
                     FLAG_COL = ST_COL + ST_LENGTH + (2 * FLAG_NO) - 1;
                     PRINT(AT(FLAG_COL, ST_ROW));
                     INPUT(out ANS2, 2);
                     if (LEN(ANS2) > 1) { PRINT(AT(-9) + " "); ANS2 = ANS2.Substring(1, 1); }
                     ANS2 = OCONV(ANS2, "MCU");
                     // BEGIN CASE
                     // CASE
                     if (ANS2 == COMMON.ABANDON)
                     {
                        INTERACT = EXIT;
                        PROG_MESS[1] = COMMON.ABANDON;
                        DONE = TRUE;
                     }// CASE
                     else if (ANS2 == "")
                     {
                        PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, FLAG_NO + 1], "L#2"));
                        INTERACT = VALID_DATA;
                        FLAG_NO = FLAG_NO + 1;
                     }// CASE
                     else if (ANS2 == COMMON.BACK && FLAG_NO == 1)
                     {
                        INTERACT = INVALID_DATA;
                        PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, FLAG_NO + 1], "L#2"));
                        DONE = TRUE;
                     }// CASE
                     else if (ANS2 == COMMON.BACK && FLAG_NO > 1)
                     {
                        INTERACT = VALID_DATA;
                        PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, FLAG_NO + 1], "L#2"));
                        FLAG_NO = FLAG_NO - 1;
                     }// CASE
                     else if (ANS2 == "Y")
                     {
                        INTERACT = VALID_DATA;
                        TEMP_REC[ST_ATT][1, FLAG_NO + 1] = "Y";
                        PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, FLAG_NO + 1], "L#2"));
                        FLAG_NO = FLAG_NO + 1;
                     }// CASE
                     else if (ANS2 == COMMON.CLR || ANS2 == "N")
                     {
                        INTERACT = VALID_DATA;
                        TEMP_REC[ST_ATT][1, FLAG_NO + 1] = "";
                        ANS2 = "";
                        PRINT(AT(FLAG_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, FLAG_NO + 1], "L#2"));
                        FLAG_NO = FLAG_NO + 1;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        INTERACT = INVALID_DATA;
                     }
                     // END CASE
                  } while (true);
               }
            }
         }
         // END CASE
         return;
      }
      void L2300()
      {
         /*   BOOKING CLOSING DATE */
         if (ANS == "")
         {
            VALUE = TEMP_REC[2];
            /*  Course Start Date */
            ANS = OCONV(VALUE, "D");
         }
         if (ICONV(ANS, "D") == "")
         {
            /*  Invalid.date */
            INTERACT = INVALID_DATA;
            nrf0 = 1;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         else
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L2400()
      {
         /*   MAX PLACES */
         if (MATCH(ANS, "0N"))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 20;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L2500()
      {
         /*   MIN PLACES */
         if (MATCH(ANS, "0N"))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 20;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L2550()
      {
         /*  Schedule code */
         if (MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], ANS))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 16;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L2600()
      {
         /*   FEE CODE */
         INTERACT = VALID_DATA;
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.CLR)
         {
            INTERACT = INVALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            /* *************** */
            if (ANS == COMMON.HELP)
            {
               nrf0 = "CO";
               FL822 = new FL822(ref nrf0, ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
               if (INTERACT != EXIT)
               {
                  ANS = RETURNED_ANS;
               }
               else
               {
                  INTERACT = INVALID_DATA;
               }
               OLD_FIELD_NO = FIELD_NO;
               OLD_FIELD_DATA = FIELD_DATA;
               L0100();
               L0300();
               FIELD_NO = OLD_FIELD_NO;
               FIELD_DATA = OLD_FIELD_DATA;
               L0200();
            }
            /* *************** */
            if (ANS == "" && VALUE != "")
            {
               ANS = VALUE;
               PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
            }
            if (ANS == "")
            {
               nrf0 = 44;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
               ANS = "";
            }
            else
            {
               TICKET_CODE = ANS;
               CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*C*" + TICKET_CODE;
               if (READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE))
               {
                  VALUE = ANS;
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
               }
               else
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 13;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  ANS = "";
               }
            }
         }
         // END CASE
         if (INTERACT == VALID_DATA)
         {
            DONE = FALSE;
            EXTRA_NO = 2;
            do
            {
               if (EXTRA_NO > TEMP_REC[25] || DONE) break;
               EXTRA_COL = ST_COL + ((EXTRA_NO - 1) * (ST_LENGTH + 1));
               PRINT(AT(EXTRA_COL, ST_ROW));
               INPUT(out ANS2, 6);
               if (LEN(ANS2) > 5) { PRINT(AT(-9) + " "); ANS2 = ANS2.Substring(1, 5); }
               // BEGIN CASE
               // CASE
               if (ANS2 == COMMON.ABANDON)
               {
                  INTERACT = EXIT;
                  PROG_MESS[1] = COMMON.ABANDON;
                  DONE = TRUE;
               }// CASE
               else if (ANS2 == "")
               {
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, EXTRA_NO], ST_JUST));
                  INTERACT = VALID_DATA;
                  EXTRA_NO = EXTRA_NO + 1;
               }// CASE
               else if (ANS2 == COMMON.BACK && EXTRA_NO == 2)
               {
                  INTERACT = INVALID_DATA;
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, EXTRA_NO], ST_JUST));
                  DONE = TRUE;
               }// CASE
               else if (ANS2 == COMMON.BACK && EXTRA_NO > 2)
               {
                  INTERACT = VALID_DATA;
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, EXTRA_NO], ST_JUST));
                  EXTRA_NO = EXTRA_NO - 1;
               }// CASE
               else if (ANS2 == COMMON.CLR)
               {
                  INTERACT = VALID_DATA;
                  TEMP_REC[ST_ATT][1, EXTRA_NO] = "";
                  ANS2 = "";
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, EXTRA_NO], ST_JUST));
                  EXTRA_NO = EXTRA_NO + 1;
               }// CASE
               else if (ANS2 != "")
               {
                  /* *************** */
                  if (ANS2 == COMMON.HELP)
                  {
                     nrf0 = "CO";
                     FL822 = new FL822(ref nrf0, ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
                     if (INTERACT != EXIT)
                     {
                        ANS2 = RETURNED_ANS;
                     }
                     else
                     {
                        INTERACT = INVALID_DATA;
                     }
                     OLD_FIELD_NO = FIELD_NO;
                     OLD_FIELD_DATA = FIELD_DATA;
                     L0100();
                     L0300();
                     FIELD_NO = OLD_FIELD_NO;
                     FIELD_DATA = OLD_FIELD_DATA;
                     L0200();
                     if (INTERACT != EXIT)
                     {
                        EXTRA_COL = ST_COL + ((EXTRA_NO - 1) * (ST_LENGTH + 1));
                        PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(ANS2, ST_JUST));
                     }
                  }
                  /* *************** */
                  TICKET_CODE = ANS2;
                  INTERACT = VALID_DATA;
                  CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*C*" + TICKET_CODE;
                  if (READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE))
                  {
                     TEMP_REC[ST_ATT][1, EXTRA_NO] = ANS2;
                     PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT][1, EXTRA_NO], ST_JUST));
                     EXTRA_NO = EXTRA_NO + 1;
                  }
                  else
                  {
                     INTERACT = INVALID_DATA;
                     nrf0 = 13;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }
               }// CASE
               else if (OTHERWISE)
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 44;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               // END CASE
            } while (true);
         }
         return;
      }
      void L2700()
      {
         /*   SESSION START AND END TIMES */
         /*  Assume whole numbers are HOURS, not minutes past midnight. */
         INTERACT = VALID_DATA;
         if (ANS == COMMON.CLR)
         {
            ANS = "";
            VALUE = "";
            TEMP_REC[ST_ATT][1, 1] = "";
            PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
         }
         else
         {
            if (ANS == "" && VALUE != "")
            {
               ANS = OCONV(VALUE, "MT");
               PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, "MT"), ST_JUST));
            }
            else
            {
               if (MATCH(ANS, "1N") || MATCH(ANS, "2N"))
               {
                  ANS = ANS + ":";
               }
               VALUE = ICONV(ANS, "MT");
               if (VALUE == "" || VALUE == 0)
               {
                  if (ANS == "")
                  {
                     /*  Times are optional fields */
                     INTERACT = VALID_DATA;
                     VALUE = "";
                     PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
                  }
                  else
                  {
                     nrf0 = 43;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     INTERACT = INVALID_DATA;
                     VALUE = "";
                     ANS = "";
                  }
               }
               else
               {
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, "MT"), ST_JUST));
               }
            }
         }
         if (INTERACT == VALID_DATA)
         {
            DONE = FALSE;
            EXTRA_NO = 2;
            do
            {
               if (EXTRA_NO > TEMP_REC[25] || DONE) break;
               EXTRA_COL = ST_COL + ((EXTRA_NO - 1) * (ST_LENGTH + 1));
               PRINT(AT(EXTRA_COL, ST_ROW));
               INPUT(out ANS2, 6);
               if (LEN(ANS2) > 5) { PRINT(AT(-9) + " "); ANS2 = ANS2.Substring(1, 5); }
               // BEGIN CASE
               // CASE
               if (ANS2 == COMMON.ABANDON)
               {
                  INTERACT = EXIT;
                  PROG_MESS[1] = COMMON.ABANDON;
                  DONE = TRUE;
               }// CASE
               else if (ANS2 == "")
               {
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, EXTRA_NO], "MT"), ST_JUST));
                  INTERACT = VALID_DATA;
                  EXTRA_NO = EXTRA_NO + 1;
               }// CASE
               else if (ANS2 == COMMON.BACK && EXTRA_NO == 2)
               {
                  INTERACT = INVALID_DATA;
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, EXTRA_NO], "MT"), ST_JUST));
                  DONE = TRUE;
               }// CASE
               else if (ANS2 == COMMON.BACK && EXTRA_NO > 2)
               {
                  INTERACT = VALID_DATA;
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, EXTRA_NO], "MT"), ST_JUST));
                  EXTRA_NO = EXTRA_NO - 1;
               }// CASE
               else if (ANS2 == COMMON.CLR)
               {
                  INTERACT = VALID_DATA;
                  TEMP_REC[ST_ATT][1, EXTRA_NO] = "";
                  ANS2 = "";
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, EXTRA_NO], "MT"), ST_JUST));
                  EXTRA_NO = EXTRA_NO + 1;
               }// CASE
               else if (ANS2 != "" && ICONV(ANS2, "MT") != "" && ICONV(ANS2, "MT") != 0)
               {
                  INTERACT = VALID_DATA;
                  if (MATCH(ANS2, "1N") || MATCH(ANS2, "2N"))
                  {
                     ANS2 = ANS2 + ":";
                  }
                  CONV_ANS = ICONV(ANS2, "MT");
                  TEMP_REC[ST_ATT][1, EXTRA_NO] = CONV_ANS;
                  PRINT(AT(EXTRA_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT][1, EXTRA_NO], "MT"), ST_JUST));
                  EXTRA_NO = EXTRA_NO + 1;
               }// CASE
               else if (OTHERWISE)
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 43;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               // END CASE
            } while (true);
         }
         return;
      }
      void L2900()
      {
         /*   FREQUENCY OF SESSIONS */
         INTERACT = VALID_DATA;
         ANS = ICONV(ANS, "MCU");
         // BEGIN CASE
         // CASE
         if (ANS == "W")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (MATCH(ANS, "'W'1N"))
         {
            SESSIONS_PER_WEEK = ANS.Substring(2, 1);
            if (SESSIONS_PER_WEEK >= 1 && SESSIONS_PER_WEEK <= 7)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 34;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = INVALID_DATA;
            nrf0 = 33;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         // END CASE
         return;
      }
      void L3000()
      {
         /*   DAYS */
         /*  Break string into 2 character day codes and */
         /*  validate both the codes and their order */
         ANS = OCONV(ANS, "MCU");
         DAYS_TEXT = ANS;
         L3050();
         return;
      }
      void L3050()
      {
         /*  Validate days - this routine can also be */
         /*                      called before filing */
         INTERACT = INVALID_DATA;
         // BEGIN CASE
         // CASE
         if (TEMP_REC[19] == "W" && LEN(DAYS_TEXT) != 2)
         {
            /*  Course is weekly - a single day (2 chars) must be specified */
            nrf0 = 47;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (LEN(TEMP_REC[19]) > 1 && LEN(DAYS_TEXT) != (2 * TEMP_REC[19]).Substring(2, 99))
         {
            /*  Course runs on more than one day per week - Check the right number */
            /*  of days have been defined */
            nrf0 = 46;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if ((LEN(DAYS_TEXT) / 2) != INT(LEN(DAYS_TEXT) / 2))
         {
            nrf0 = 45;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (LEN(DAYS_TEXT) > 14)
         {
            nrf0 = 45;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = VALID_DATA;
            LAST_POS = 0;
            POS = 1;
            do
            {
               if (POS > LEN(DAYS_TEXT) || INTERACT == INVALID_DATA) break;
               NEW_POS = INDEX(FULL_WEEK, DAYS_TEXT.Substring(POS, 2), 1);
               if (NEW_POS <= LAST_POS || NEW_POS == "")
               {
                  nrf0 = 45;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
               else
               {
                  LAST_POS = NEW_POS;
               }
               POS = POS + 2;
            } while (true);
         }
         // END CASE
         return;
      }
      void L3100()
      {
         /*   INSTRUCTORS */
         if (ANS == COMMON.HELP)
         {
            COURSE_DATE = PROG_MESS[3];
            nrf0 = COURSE_DET_REC[COURSE_DET_START_TIME];
            FL718 = new FL718(ref INSTRUCTOR_ID, ref COURSE_DATE, ref nrf0, ref INTERACT, ref REDISPLAY);
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
            if (INTERACT != EXIT)
            {
               ANS = INSTRUCTOR_ID;
               if (ANS == "") { ANS = VALUE; }
            }
         }
         if (INTERACT == EXIT)
         {
            INTERACT = INVALID_DATA;
         }
         else
         {
            if (MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, ANS))
            {
               INTERACT = VALID_DATA;
               FULL_INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
               PRINT(AT(ST_COL + 7, ST_ROW) + FORMAT(FULL_INSTRUCTOR_NAME, "L#24"));
            }
            else
            {
               nrf0 = 14;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
         }
         return;
      }
      void L3200()
      {
         /*   COMMENTS LINE 1 */
         INTERACT = VALID_DATA;
         return;
      }
      void L3300()
      {
         /*  COMMENTS LINE 2 */
         INTERACT = VALID_DATA;
         return;
      }
      void L3400()
      {
         /*  COMMENTS LINE 3 */
         INTERACT = VALID_DATA;
         return;
      }
      void L3600()
      {
         /*  ACTIVITY */
         INTERACT = VALID_DATA;
         if (ANS == COMMON.HELP)
         {
            nrf0 = "";
            FL721 = new FL721(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
            if (INTERACT != EXIT)
            {
               ANS = RETURNED_ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
         }
         if (INTERACT != INVALID_DATA)
         {
            if (MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, ANS))
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 18;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         return;
      }
      void L3700()
      {
         /*   CENTRE */
         INTERACT = VALID_DATA;
         if (ANS == COMMON.HELP)
         {
            FL722 = new FL722(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
            if (INTERACT != EXIT)
            {
               ANS = RETURNED_ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
         }
         if (INTERACT != INVALID_DATA)
         {
            if (ANS == COMMON.CENTRE)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               if (MATREAD(ref MASTER_CENTRE_REC, FL_MASTER_CENTRES, ANS))
               {
                  INTERACT = VALID_DATA;
               }
               else
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 19;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
         }
         return;
      }
      void L3900()
      {
         /*  SPARE */
         INTERACT = VALID_DATA;
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
         TEMP_REC[4] = COURSE_DET_REC[COURSE_DET_SCHEDULE_CODE];
         /*  Always null */
         TEMP_REC[5] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 1];
         TEMP_REC[5][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, 1];
         TEMP_REC[5][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, 2];
         TEMP_REC[5][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, 3];
         TEMP_REC[5][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, 4];
         TEMP_REC[5][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, 5];
         TEMP_REC[6] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 2];
         TEMP_REC[6][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, 1];
         TEMP_REC[6][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, 2];
         TEMP_REC[6][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, 3];
         TEMP_REC[6][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, 4];
         TEMP_REC[6][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, 5];
         TEMP_REC[7] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 3];
         TEMP_REC[7][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, 1];
         TEMP_REC[7][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, 2];
         TEMP_REC[7][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, 3];
         TEMP_REC[7][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, 4];
         TEMP_REC[7][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, 5];
         TEMP_REC[8] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 4];
         TEMP_REC[8][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, 1];
         TEMP_REC[8][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, 2];
         TEMP_REC[8][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, 3];
         TEMP_REC[8][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, 4];
         TEMP_REC[8][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, 5];
         TEMP_REC[9] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 5];
         TEMP_REC[9][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, 1];
         TEMP_REC[9][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, 2];
         TEMP_REC[9][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, 3];
         TEMP_REC[9][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, 4];
         TEMP_REC[9][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, 5];
         TEMP_REC[10] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 6];
         TEMP_REC[10][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, 1];
         TEMP_REC[10][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, 2];
         TEMP_REC[10][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, 3];
         TEMP_REC[10][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, 4];
         TEMP_REC[10][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, 5];
         TEMP_REC[11] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 7];
         TEMP_REC[11][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, 1];
         TEMP_REC[11][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, 2];
         TEMP_REC[11][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, 3];
         TEMP_REC[11][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, 4];
         TEMP_REC[11][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, 5];
         TEMP_REC[12] = COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 8];
         TEMP_REC[12][1, 2] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, 1];
         TEMP_REC[12][1, 3] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, 2];
         TEMP_REC[12][1, 4] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, 3];
         TEMP_REC[12][1, 5] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, 4];
         TEMP_REC[12][1, 6] = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, 5];
         TEMP_REC[13] = COURSE_DET_REC[COURSE_DET_CLOSE_DATE];
         TEMP_REC[14] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
         TEMP_REC[15] = COURSE_DET_REC[COURSE_DET_MINIMUM_PLACES];
         TEMP_REC[16] = COURSE_DET_REC[COURSE_DET_FEE_CODE];
         TEMP_REC[17] = COURSE_DET_REC[COURSE_DET_START_TIME];
         TEMP_REC[18] = COURSE_DET_REC[COURSE_DET_END_TIME];
         TEMP_REC[19] = COURSE_DET_REC[COURSE_DET_FREQUENCY];
         TEMP_REC[20] = COURSE_DET_REC[COURSE_DET_DAYS];
         TEMP_REC[21] = COURSE_DET_REC[COURSE_DET_INSTRUCTOR];
         TEMP_REC[22] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1];
         TEMP_REC[23] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2];
         TEMP_REC[24] = COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3];
         TEMP_REC[25] = COURSE_DET_REC[COURSE_DET_SESSIONS];
         TEMP_REC[26] = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
         TEMP_REC[27] = COURSE_MSTR_REC[COURSE_MSTR_CENTRE];
         TEMP_REC[29] = COURSE_DET_REC[COURSE_DET_BLOCK_REF];
         TEMP_REC[35] = COURSE_DET_REC[COURSE_DET_INSTRUCTOR2];
         return;
         /* ******************************************* */
      }
      void L9000()
      {
         /*   Transfer data out of temp.rec       * */
         /* ******************************************* */
         COURSE_MSTR_REC[COURSE_MSTR_DESC] = TEMP_REC[1];
         COURSE_DET_REC[COURSE_DET_END] = TEMP_REC[3];
         COURSE_DET_REC[COURSE_DET_SCHEDULE_CODE] = TEMP_REC[4];
         /*  Always null */
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 1] = TEMP_REC[5][1, 1];
         COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS] = "";
         /*  Avoid leftover indicators where no. sessions is reduced */
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 1] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 1, N] = TEMP_REC[5][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 2] = TEMP_REC[6][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 2] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 2, N] = TEMP_REC[6][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 3] = TEMP_REC[7][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 3] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 3, N] = TEMP_REC[7][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 4] = TEMP_REC[8][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 4] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 4, N] = TEMP_REC[8][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 5] = TEMP_REC[9][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 5] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 5, N] = TEMP_REC[9][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 6] = TEMP_REC[10][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 6] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 6, N] = TEMP_REC[10][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 7] = TEMP_REC[11][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 7] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 7, N] = TEMP_REC[11][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 8] = TEMP_REC[12][1, 1];
         if (COURSE_DET_REC[COURSE_DET_BOOKING_DATES][1, 8] == "")
         {
            COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8] = "";
         }
         else
         {
            for (N = 1; N <= TEMP_REC[25]; N += 1)
            {
               COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, 8, N] = TEMP_REC[12][1, N + 1];
            }
         }
         COURSE_DET_REC[COURSE_DET_CLOSE_DATE] = TEMP_REC[13];
         COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES] = TEMP_REC[14];
         COURSE_DET_REC[COURSE_DET_MINIMUM_PLACES] = TEMP_REC[15];
         COURSE_DET_REC[COURSE_DET_FEE_CODE] = TEMP_REC[16];
         COURSE_DET_REC[COURSE_DET_START_TIME] = TEMP_REC[17];
         COURSE_DET_REC[COURSE_DET_END_TIME] = TEMP_REC[18];
         COURSE_DET_REC[COURSE_DET_FREQUENCY] = TEMP_REC[19];
         COURSE_DET_REC[COURSE_DET_DAYS] = TEMP_REC[20];
         COURSE_DET_REC[COURSE_DET_INSTRUCTOR] = TEMP_REC[21];
         COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1] = TEMP_REC[22];
         COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2] = TEMP_REC[23];
         COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3] = TEMP_REC[24];
         COURSE_DET_REC[COURSE_DET_SESSIONS] = TEMP_REC[25];
         COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE] = TEMP_REC[26];
         COURSE_MSTR_REC[COURSE_MSTR_CENTRE] = TEMP_REC[27];
         COURSE_DET_REC[COURSE_DET_BLOCK_REF] = TEMP_REC[29];
         COURSE_DET_REC[COURSE_DET_INSTRUCTOR2] = TEMP_REC[35];
         COURSE_MSTR_REC[COURSE_MSTR_TYPE] = "A";
         /*  Activity Day */
         /*  Additional fields */
         if (COURSE_DET_REC[COURSE_DET_STUDENT_IDS] == "")
         {
            L9500();
            /*  (Re-)Build Session Dates */
         }
         return;
         /* ********************************************* */
      }
      void L9500()
      {
         /*  Build a list of session dates based on * */
         /*      the Frequency, Days, Start Date and    * */
         /*      End Date fields                        * */
         /* ********************************************* */
         COURSE_DET_REC[COURSE_DET_SESSION_DATES] = "";
         COURSE_DET_REC[COURSE_DET_SESSION_FLAGS] = "";
         COURSE_DET_REC[COURSE_DET_VACANCIES] = "";
         SESSION_DATE_COUNT = 0;
         THIS_DATE = TEMP_REC[2];
         do
         {
            if (THIS_DATE > COURSE_DET_REC[COURSE_DET_END]) break;
            DAY_OF_WEEK = OCONV(OCONV(THIS_DATE, "DWA"), "MCU").Substring(1, 2);
            POS = INDEX(COURSE_DET_REC[COURSE_DET_DAYS], DAY_OF_WEEK, 1);
            if (POS > 0)
            {
               /*  Course runs on this day - now check for exceptions */
               /*  down to session level */
               if (LOCATE(THIS_DATE, COURSE_DET_REC[COURSE_DET_BOOKING_DATES], 1, 0, 1, ref DATE_POS, "AL"))
               {
                  UNAVAILABLE_SESSIONS = COURSE_DET_REC[COURSE_DET_UNAVAILABLE_SESSIONS][1, DATE_POS];
               }
               else
               {
                  UNAVAILABLE_SESSIONS = "";
               }
               /* !*CRT @(0,0):"CDS=":COURSE.DET.SESSIONS:"  CNT=":COUNT(UNAVAILABLE.SESSIONS,"Y"):"  US=":UNAVAILABLE.SESSIONS:;INPUT FLEX,2: */
               if (COUNT(UNAVAILABLE_SESSIONS, "Y") == COURSE_DET_REC[COURSE_DET_SESSIONS])
               {
                  /*  All sessions for this day are unavailable - suppress this date */
                  NULL();
               }
               else
               {
                  SESSION_DATE_COUNT = SESSION_DATE_COUNT + 1;
                  COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, SESSION_DATE_COUNT] = THIS_DATE;
                  for (SNO = 1; SNO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; SNO += 1)
                  {
                     if (UNAVAILABLE_SESSIONS[1, 1, SNO] != "Y")
                     {
                        COURSE_DET_REC[COURSE_DET_SESSION_FLAGS][1, SESSION_DATE_COUNT, SNO] = "Y";
                        COURSE_DET_REC[COURSE_DET_VACANCIES][1, SESSION_DATE_COUNT, SNO] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
                     }
                  }
               }
            }
            if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W")
            {
               THIS_DATE = THIS_DATE + 7;
            }
            else
            {
               /*  Course runs on more than one day per week */
               THIS_DATE = THIS_DATE + 1;
            }
         } while (true);
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
