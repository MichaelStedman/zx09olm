//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL735 : UvBase
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
      readonly UvVar PREF = 1;
      readonly UvVar TEL = 2;
      readonly UvVar COM = 3;
      readonly UvVar JOIN = 4;
      readonly UvVar FL_CONTROL = 10;
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
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] WAIT_MAST_REC = new UvVar[5];
      UvVar[] WAIT_STUDENT_REC = new UvVar[35];
      UvVar[] MEMBERS_REC = new UvVar[45];
      #endregion
      #region Variables
      UvVar ACTIVITY = "";
      UvVar ORIGINAL_STUDENT_LIST = "";
      UvVar ORIGINAL_STATUS_LIST = "";
      UvVar NEW_STUDENT = "";
      UvVar CREATION_ALLOWED = "";
      UvVar STUDENT_ID = "";
      UvVar INTERACT = "";
      UvVar REDISPLAY = "";
      UvVar TODAYS_DATE = "";
      UvVar USER_STATUS = "";
      UvVar REV_VID = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar PROG_MESS = "";
      UvVar COLOR_C = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar COURSE_CODE = "";
      UvVar PREF_TEL_COM_JOIN = "";
      UvVar SEL_CENTRE = "";
      UvVar DD_MM_YYYY = "";
      UvVar NOW_YYYY = "";
      UvVar NOW_MM = "";
      UvVar NOW_DD = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FL_WAIT_MASTER = "";
      UvVar FL_WAIT_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar MAX_PLACES = "";
      UvVar CENTRALISED_COURSES = "";
      UvVar WINDOW_ID = "";
      UvVar WINDOW = "";
      UvVar TOP_WINDOW = "";
      UvVar BOTTOM_WINDOW = "";
      UvVar LEFT_WINDOW = "";
      UvVar RIGHT_WINDOW = "";
      UvVar WINDOW_JUST = "";
      UvVar WINDOW_DEPTH = "";
      UvVar HEADING_TEXT = "";
      UvVar HEADING_TEXT2 = "";
      UvVar HEADING_TEXT3 = "";
      UvVar HEADING_TEXT4 = "";
      UvVar HEADING_TEXT5 = "";
      UvVar HEADING_TEXT6 = "";
      UvVar HEADING_TEXT7 = "";
      UvVar HEADING_TEXT8 = "";
      UvVar STUDENT_LIST = "";
      UvVar STATUS_LIST = "";
      UvVar STUDENT_COUNT = "";
      UvVar CNT = "";
      UvVar STUDENT = "";
      UvVar ZZZ_STATUS = "";
      UvVar ATT = "";
      UvVar POS = "";
      UvVar STUDENT_IS_MEMBER = "";
      UvVar STUDENT_NAME = "";
      UvVar COURSE_LINE = "";
      UvVar COMMIT_TEXT = "";
      UvVar TEL_HOME = "";
      UvVar TEL_WORK = "";
      UvVar DATE_OF_BIRTH = "";
      UvVar AGE = "";
      UvVar EXTERNAL_DOB = "";
      UvVar DOB_MM = "";
      UvVar DOB_DD = "";
      UvVar DOB_YYYY = "";
      UvVar TEST_POS = "";
      UvVar DATE_JOINED = "";
      UvVar FOOTER = "";
      UvVar WAIT = "";
      FL006 FL006;
      UvVar WARNING = "";
      UvVar WARN = "";
      UvVar FULL_STUDENT_LIST = "";
      UvVar NO_STUDENTS = "";
      UvVar SNO = "";
      UvVar SID = "";
      UvVar CONFIRMATION = "";
      UvVar CONF = "";
      UvVar MODE_TEXT = "";
      UvVar SURNAME = "";
      UvVar MVC = "";
      UvVar TEMP_ID = "";
      UvVar TEMP_SURNAME = "";
      UvVar LENGTH_OF_INPUT = "";
      UvVar SUB_NAME = "";
      UvVar TEMP_CNT = "";
      UvVar CENTRE1 = "";
      UvVar CENTRE2 = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL735(ref UvVar ACTIVITY, ref UvVar ORIGINAL_STUDENT_LIST, ref UvVar ORIGINAL_STATUS_LIST, ref UvVar NEW_STUDENT, ref UvVar CREATION_ALLOWED, ref UvVar STUDENT_ID, ref UvVar INTERACT, ref UvVar REDISPLAY)
      {
         this.ACTIVITY = ACTIVITY;
         this.ORIGINAL_STUDENT_LIST = ORIGINAL_STUDENT_LIST;
         this.ORIGINAL_STATUS_LIST = ORIGINAL_STATUS_LIST;
         this.NEW_STUDENT = NEW_STUDENT;
         this.CREATION_ALLOWED = CREATION_ALLOWED;
         this.STUDENT_ID = STUDENT_ID;
         this.INTERACT = INTERACT;
         this.REDISPLAY = REDISPLAY;
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
         /*     WAITING LIST DISPLAY AND SELECTION */
         PROGRAM = "FL735";
         INTERACT = INVALID_DATA;
         REDISPLAY = "";
         STUDENT_ID = "";
         COURSE_CODE = PROG_MESS[2];
         PREF_TEL_COM_JOIN = PREF;
         SEL_CENTRE = COMMON.CENTRE;
         /*  DEFAULT TO CURRENT CENTRE */
         DD_MM_YYYY = OCONV(TODAYS_DATE, "D4/");
         NOW_YYYY = DD_MM_YYYY.Substring(7, 4);
         NOW_MM = DD_MM_YYYY.Substring(4, 2);
         NOW_DD = DD_MM_YYYY.Substring(1, 2);
         /*  Include relevant file info */
         #region INCLUDE FL.FILES FL.COURSE.PARAMS
         #region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
         if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

         #endregion

         #region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.MASTER
         if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.STUDENTS
         if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

         /*  Important - keep Wait.Stud.Dates (21) in tandem */

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
         if (!READV(ref MAX_PLACES, FL_COURSE_PARAMS, "COURSE.PARAMS", 10)) { MAX_PLACES = 999999; }
         if (!READV(ref CENTRALISED_COURSES, FL_COURSE_PARAMS, "COURSE.PARAMS", 24)) { CENTRALISED_COURSES = ""; }
         MAX_PLACES = MAX_PLACES[1, 1];
         if (MAX_PLACES == "") { MAX_PLACES = 999999; }
         WINDOW_ID = PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 5;
            WINDOW[2] = 18;
            WINDOW[3] = 2;
            WINDOW[4] = 77;
         }
         TOP_WINDOW = WINDOW[1];
         BOTTOM_WINDOW = WINDOW[2];
         LEFT_WINDOW = WINDOW[3];
         RIGHT_WINDOW = WINDOW[4];
         WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
         WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
         HEADING_TEXT = WINDOW[5];
         HEADING_TEXT2 = WINDOW[6];
         HEADING_TEXT3 = WINDOW[7];
         HEADING_TEXT4 = WINDOW[8];
         HEADING_TEXT5 = WINDOW[9];
         HEADING_TEXT6 = WINDOW[10];
         HEADING_TEXT7 = WINDOW[11];
         HEADING_TEXT8 = WINDOW[12];
         L1100();
         /*  Function is set to LIMIT if the user hits <Return> to scroll the display */
         if (CENTRALISED_COURSES != "Y")
         {
            STUDENT_LIST = ORIGINAL_STUDENT_LIST;
            STATUS_LIST = ORIGINAL_STATUS_LIST;
         }
         else
         {
            L2000();
            /*  Filter lists based on centre codes */
         }
         STUDENT_COUNT = 1;
         do
         {
            if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
               ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
               if (CNT >= WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + 6) + NRM_VID);
               if (STUDENT == "")
               {
                  PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + 6) + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  if (!MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT)) { MAT(ref WAIT_STUDENT_REC, ""); }
                  /*  Convert availability codes to lower case for clarity */
                  for (ATT = 12; ATT <= 18; ATT += 1)
                  {
                     for (POS = 1; POS <= 5; POS += 1)
                     {
                        // BEGIN CASE
                        // CASE
                        if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == " ")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "V")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "v" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "O")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "o" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "L")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "l" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "M")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "m" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "E" && POS > 1 && WAIT_STUDENT_REC[ATT].Substring(POS - 1, 1) == "n")
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "e" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }// CASE
                        else if (WAIT_STUDENT_REC[ATT].Substring(POS, 1) == "N" && POS == 3)
                        {
                           WAIT_STUDENT_REC[ATT] = WAIT_STUDENT_REC[ATT].Substring(1, POS - 1) + "n" + WAIT_STUDENT_REC[ATT].Substring(POS + 1, 5);
                        }
                        // END CASE
                     }
                  }
                  /*  DJA 31.07.00 */
                  if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT))
                  {
                     STUDENT_IS_MEMBER = TRUE;
                  }
                  else
                  {
                     STUDENT_IS_MEMBER = FALSE;
                  }
                  if (STUDENT_IS_MEMBER)
                  {
                     STUDENT_NAME = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
                  }
                  else
                  {
                     STUDENT_NAME = TRIM(WAIT_STUDENT_REC[WAIT_STUD_TITLE] + " " + WAIT_STUDENT_REC[WAIT_STUD_FORENAME] + " " + WAIT_STUDENT_REC[WAIT_STUD_SURNAME]);
                  }
                  COURSE_LINE = FORMAT(STUDENT_COUNT, "R#3") + SPACE(1);
                  // BEGIN CASE
                  // CASE
                  if (PREF_TEL_COM_JOIN == PREF)
                  {
                     COURSE_LINE = COURSE_LINE + FORMAT(STUDENT_NAME, "L#25") + SPACE(1) + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_MONDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_TUESDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_WEDNESDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_THURSDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_FRIDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SATURDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SUNDAY], "L#5");
                     COURSE_LINE = COURSE_LINE + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_CONCESSION], "L#8");
                  }// CASE
                  else if (PREF_TEL_COM_JOIN == TEL)
                  {
                     if (WAIT_STUDENT_REC[WAIT_STUD_COURSE] == "")
                     {
                        COMMIT_TEXT = WAIT_STUDENT_REC[WAIT_STUD_CONTACTED];
                     }
                     else
                     {
                        COMMIT_TEXT = WAIT_STUDENT_REC[WAIT_STUD_COURSE];
                     }
                     /*  DJA 31.07.00 */
                     if (STUDENT_IS_MEMBER)
                     {
                        TEL_HOME = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
                        TEL_WORK = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
                     }
                     else
                     {
                        TEL_HOME = WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME];
                        TEL_WORK = WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK];
                     }
                     COURSE_LINE = COURSE_LINE + FORMAT(STUDENT, "L#12") + SPACE(1) + FORMAT(STUDENT_NAME, "L#25") + SPACE(1) + FORMAT(TEL_HOME, "L#12") + SPACE(1) + FORMAT(TEL_WORK, "L#12") + SPACE(1) + FORMAT(COMMIT_TEXT, "L#7");
                  }// CASE
                  else if (PREF_TEL_COM_JOIN == COM)
                  {
                     /*  DJA 24.7.00 */
                     if (STUDENT_IS_MEMBER)
                     {
                        DATE_OF_BIRTH = MEMBERS_REC[MEMBER_DOBS][1, 1];
                     }
                     else
                     {
                        DATE_OF_BIRTH = WAIT_STUDENT_REC[WAIT_STUD_DOB];
                     }
                     AGE = "";
                     if (DATE_OF_BIRTH != "")
                     {
                        EXTERNAL_DOB = OCONV(DATE_OF_BIRTH, "D4/");
                        DOB_MM = FIELD(EXTERNAL_DOB, "/", 2);
                        DOB_DD = FIELD(EXTERNAL_DOB, "/", 1);
                        DOB_YYYY = FIELD(EXTERNAL_DOB, "/", 3);
                        AGE = NOW_YYYY - DOB_YYYY;
                        if (DOB_MM > NOW_MM)
                        {
                           AGE = AGE - 1;
                        }
                        else
                        {
                           if (DOB_MM == NOW_MM)
                           {
                              if (DOB_DD > NOW_DD) { AGE = AGE - 1; }
                           }
                        }
                     }
                     COURSE_LINE = COURSE_LINE + FORMAT(STUDENT, "L#12") + SPACE(1) + FORMAT(STUDENT_NAME, "L#25") + SPACE(1) + FORMAT(WAIT_STUDENT_REC[WAIT_STUD_COMMENT], "L#25") + FORMAT(AGE, "R#2") + " " + FORMAT((WAIT_STUDENT_REC[WAIT_STUD_CENTRE] + " " + WAIT_STUDENT_REC[WAIT_STUD_CENTRE2]), "R#5");
                  }// CASE
                  else if (OTHERWISE)
                  {
                     if (LOCATE(ACTIVITY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref TEST_POS, "AL"))
                     {
                        DATE_JOINED = WAIT_STUDENT_REC[WAIT_STUD_DATES][1, TEST_POS];
                        COURSE_LINE = COURSE_LINE + FORMAT(STUDENT, "L#12") + SPACE(1) + FORMAT(STUDENT_NAME, "L#25") + SPACE(1) + FORMAT(OCONV(DATE_JOINED, "D"), "L#11");
                     }
                     else
                     {
                        COURSE_LINE = COURSE_LINE + FORMAT(STUDENT, "L#12") + SPACE(1) + FORMAT(STUDENT_NAME, "L#25") + SPACE(1) + FORMAT("", "L#11");
                     }
                  }
                  // END CASE
                  //if (STATUS() != "P")
                  //{
                  //   PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + COLOR_C);
                  //}
                  //else
                  //{
                  //   PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + REV_VID);
                  //}
                  PRINT(AT(LEFT_WINDOW, CNT + 6) + FORMAT(COURSE_LINE, WINDOW_JUST));
               }
               STUDENT_COUNT = STUDENT_COUNT + 1;
            } while (true);
            L1000();
            /*  Restart display from first date when end of list is reached */
            if (STUDENT == "")
            {
               STUDENT_COUNT = 1;
            }
            CNT = 0;
         } while (true);
         /*  Return to calling program */
         if (INTERACT == FINISH)
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L1000()
      {
         /*  Display last line message */
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(AT(79, CNT + 6) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + UND_VID);
            PRINT(AT(LEFT_WINDOW, CNT + 6) + FORMAT(FOOTER, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + LEN(FOOTER), CNT + 6));
            INPUT(out WAIT, 6);
            // BEGIN CASE
            // CASE
            if (WAIT == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               REDISPLAY = TOP_WINDOW;
            }// CASE
            else if (WAIT == "P" && PREF_TEL_COM_JOIN == PREF)
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if (WAIT == "T" && PREF_TEL_COM_JOIN == TEL)
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if (WAIT == "C" && PREF_TEL_COM_JOIN == COM)
            {
               INTERACT = INVALID_DATA;
            }// CASE
            else if (WAIT == "A" && CENTRALISED_COURSES == "Y")
            {
               /*  All centres */
               SEL_CENTRE = "";
               L2000();
               INTERACT = LIMIT;
            }// CASE
            else if (WAIT == "S")
            {
               /*  Search by surname */
               L1500();
               // BEGIN CASE
               // CASE
               if (INTERACT == EXIT)
               {
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (INTERACT == LIMIT)
               {
                  STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
                  if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
                  STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
                  ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
               }
               // END CASE
            }// CASE
            else if (WAIT == "P")
            {
               PREF_TEL_COM_JOIN = PREF;
               L1100();
               /*  Change window headers */
               INTERACT = LIMIT;
               STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
               ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
            }// CASE
            else if (WAIT == "T")
            {
               PREF_TEL_COM_JOIN = TEL;
               L1100();
               /*  Change window headers */
               INTERACT = LIMIT;
               STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
               ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
            }// CASE
            else if (WAIT == "C")
            {
               PREF_TEL_COM_JOIN = COM;
               L1100();
               /*  Change window headers */
               INTERACT = LIMIT;
               STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
               ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
            }// CASE
            else if (WAIT == "J")
            {
               PREF_TEL_COM_JOIN = JOIN;
               L1100();
               /*  Change window headers */
               INTERACT = LIMIT;
               STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
               if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
               STUDENT = STUDENT_LIST[1, STUDENT_COUNT];
               ZZZ_STATUS = STATUS_LIST[1, STUDENT_COUNT];
            }// CASE
            else if (WAIT == "N" && CREATION_ALLOWED == TRUE)
            {
               if (DCOUNT(ORIGINAL_STUDENT_LIST, VM) >= MAX_PLACES)
               {
                  nrf0 = 3;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  NEW_STUDENT = TRUE;
                  STUDENT_ID = "";
                  INTERACT = FINISH;
                  REDISPLAY = TOP_WINDOW;
               }
            }// CASE
            else if (WAIT == "RESET" && CREATION_ALLOWED == TRUE)
            {
               if (USER_STATUS == "M" || USER_STATUS == "S")
               {
                  PRINT(AT(79, CNT + 6) + NRM_VID);
                  PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + UND_VID);
                  WARNING = "This will delete all waiting list entries. Are you sure? (YES/N) ";
                  PRINT(AT(LEFT_WINDOW, CNT + 6) + FORMAT(WARNING, WINDOW_JUST));
                  PRINT(AT(LEFT_WINDOW + LEN(WARNING), CNT + 6));
                  INPUT(out WARN, 4);
                  if (WARN == "YES")
                  {
                     if (!READVU(ref FULL_STUDENT_LIST, FL_WAIT_MASTER, ACTIVITY, 1)) { FULL_STUDENT_LIST = ""; }
                     NO_STUDENTS = DCOUNT(FULL_STUDENT_LIST, VM);
                     for (SNO = 1; SNO <= NO_STUDENTS; SNO += 1)
                     {
                        SID = FULL_STUDENT_LIST[1, SNO];
                        if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, SID))
                        {
                           if (LOCATE(ACTIVITY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL"))
                           {
                              WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, POS, 0);
                              WAIT_STUDENT_REC[WAIT_STUD_DATES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_DATES], 1, POS, 0);
                           }
                           if (WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] == "")
                           {
                              DELETE(FL_WAIT_STUDENTS, SID);
                           }
                           else
                           {
                              MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, SID);
                           }
                        }
                     }
                     DELETE(FL_WAIT_MASTER, ACTIVITY);
                     PRINT(AT(79, CNT + 6) + NRM_VID);
                     PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + UND_VID);
                     CONFIRMATION = "THE WAITING LIST HAS BEEN CLEARED. PRESS <RETURN> ";
                     PRINT(AT(LEFT_WINDOW, CNT + 6) + FORMAT(CONFIRMATION, WINDOW_JUST));
                     PRINT(AT(LEFT_WINDOW + LEN(WARNING), CNT + 6));
                     INPUT(out CONF, 1);
                     INTERACT = EXIT;
                  }
                  else
                  {
                     INTERACT = INVALID_DATA;
                  }
               }
               else
               {
                  nrf0 = 4;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
            }// CASE
            else if (WAIT == "0")
            {
               nrf0 = 1;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (MATCH(WAIT, "0N") && WAIT != "")
            {
               STUDENT_ID = STUDENT_LIST[1, WAIT];
               if (STUDENT_ID == "")
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  INTERACT = FINISH;
                  NEW_STUDENT = FALSE;
                  REDISPLAY = TOP_WINDOW;
               }
            }// CASE
            else if (OTHERWISE)
            {
               INTERACT = LIMIT;
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* ********************************************************* */
      }
      void L1100()
      {
         /*   Display window headers                            * */
         /* ********************************************************* */
         // BEGIN CASE
         // CASE
         if (PREF_TEL_COM_JOIN == PREF)
         {
            PRINT(AT(77, TOP_WINDOW) + UND_VID + " ");
            PRINT(AT(79, TOP_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
            PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
            MODE_TEXT = "'T'el, 'C'omments, 'J'oined";
         }// CASE
         else if (PREF_TEL_COM_JOIN == TEL)
         {
            PRINT(AT(79, TOP_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT3, WINDOW_JUST));
            PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT4, WINDOW_JUST));
            MODE_TEXT = "'P'ref, 'C'omments, 'J'oined";
         }// CASE
         else if (PREF_TEL_COM_JOIN == COM)
         {
            PRINT(AT(79, TOP_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT5, WINDOW_JUST));
            PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT6, WINDOW_JUST));
            MODE_TEXT = "'P'ref, 'T'el, 'J'oined";
         }// CASE
         else if (OTHERWISE)
         {
            PRINT(AT(79, TOP_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT7, WINDOW_JUST));
            PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
            PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT8, WINDOW_JUST));
            MODE_TEXT = "'P'ref, 'T'el, 'C'omments";
         }
         // END CASE
         if (CENTRALISED_COURSES == "Y")
         {
            if (CREATION_ALLOWED)
            {
               FOOTER = " 'A'll centres, " + MODE_TEXT + ", 'N'ew, , 'S'earch or RESET ";
            }
            else
            {
               FOOTER = " 'A'll centres, " + MODE_TEXT + ", <RET> to scroll or 'S'earch ";
            }
         }
         else
         {
            if (CREATION_ALLOWED)
            {
               FOOTER = " # no, " + MODE_TEXT + ", 'N'ew, , 'S'earch or RESET ";
            }
            else
            {
               FOOTER = " # no, " + MODE_TEXT + ", <RET> to scroll or 'S'earch ";
            }
         }
         return;
         /* ****************************************************************** */
      }
      void L1500()
      {
         /*  Search for surname (or part of one)                         * */
         /* ****************************************************************** */
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(AT(79, CNT + 6) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, CNT + 6) + UND_VID);
            PRINT(AT(LEFT_WINDOW, CNT + 6) + " Enter surname (whole or first part)                                      ");
            PRINT(AT(LEFT_WINDOW + 38, CNT + 6));
            INPUT(out SURNAME, 25);
            // BEGIN CASE
            // CASE
            if (SURNAME == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (SURNAME == "")
            {
               INTERACT = LIMIT;
               STUDENT_LIST = ORIGINAL_STUDENT_LIST;
               STATUS_LIST = ORIGINAL_STATUS_LIST;
            }// CASE
            else if (OTHERWISE)
            {
               STUDENT_LIST = "";
               STATUS_LIST = "";
               MVC = 1;
               do
               {
                  TEMP_ID = ORIGINAL_STUDENT_LIST[1, MVC];
                  if (TEMP_ID == "") break;
                  if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], TEMP_ID))
                  {
                     TEMP_SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
                  }
                  else
                  {
                     if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, TEMP_ID))
                     {
                        TEMP_SURNAME = WAIT_STUDENT_REC[WAIT_STUD_SURNAME];
                     }
                  }
                  if (TEMP_SURNAME != "")
                  {
                     LENGTH_OF_INPUT = LEN(SURNAME);
                     SUB_NAME = TEMP_SURNAME.Substring(1, LENGTH_OF_INPUT);
                     if (TEMP_SURNAME == SURNAME || SUB_NAME == SURNAME)
                     {
                        STUDENT_LIST[1, -1] = TEMP_ID;
                        TEMP_CNT = DCOUNT(STUDENT_LIST, VM);
                        STATUS_LIST[1, TEMP_CNT] = ORIGINAL_STATUS_LIST[1, MVC];
                     }
                  }
                  MVC = MVC + 1;
               } while (true);
               if (STUDENT_LIST == "")
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 2;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  INTERACT = LIMIT;
               }
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* ************************************************ */
      }
      void L2000()
      {
         /*  Filter waiting list by centre             * */
         /* ************************************************ */
         if (SEL_CENTRE == "")
         {
            STUDENT_LIST = ORIGINAL_STUDENT_LIST;
            STATUS_LIST = ORIGINAL_STATUS_LIST;
         }
         else
         {
            STUDENT_LIST = "";
            STATUS_LIST = "";
            MVC = 1;
            do
            {
               TEMP_ID = ORIGINAL_STUDENT_LIST[1, MVC];
               if (TEMP_ID == "") break;
               if (!READV(ref CENTRE1, FL_WAIT_STUDENTS, TEMP_ID, 24)) { CENTRE1 = ""; }
               if (!READV(ref CENTRE2, FL_WAIT_STUDENTS, TEMP_ID, 27)) { CENTRE2 = ""; }
               if (CENTRE1 == SEL_CENTRE || CENTRE2 == SEL_CENTRE || (CENTRE1 == "" && CENTRE2 == ""))
               {
                  STUDENT_LIST[1, -1] = TEMP_ID;
                  TEMP_CNT = DCOUNT(STUDENT_LIST, VM);
                  STATUS_LIST[1, TEMP_CNT] = ORIGINAL_STATUS_LIST[1, MVC];
               }
               MVC = MVC + 1;
            } while (true);
         }
         return;
      }
   }
}
