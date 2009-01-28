//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL718 : UvBase
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
      readonly UvVar QUALIFICATION1 = 1;
      readonly UvVar QUALIFICATION2 = 2;
      readonly UvVar QUALIFICATION3 = 3;
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_SCREENS = 8;
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] INSTRUCTOR_REC = new UvVar[30];
      UvVar[] REQUIRED_QUALS_REC = new UvVar[5];
      #endregion
      #region Variables
      UvVar INSTRUCTOR_ID = "";
      UvVar COURSE_DATE = "";
      UvVar COURSE_DET_START_TIME = "";
      UvVar INTERACT = "";
      UvVar REDISPLAY = "";
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar GO_BACK = "";
      UvVar SC_POS = "";
      UvVar COLOR_C = "";
      UvVar PROGRAM = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar FL_INSTRUCTORS = "";
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
      UvVar FOOTER = "";
      FL006 FL006;
      UvVar INSTRUCTOR_LIST = "";
      UvVar CODES_FOUND = "";
      UvVar SELECTION_CRITERIA = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar CC = "";
      UvVar ID = "";
      UvVar WAIT = "";
      UvVar FIELD_NO = "";
      UvVar ST_ROW = "";
      UvVar FIELD_DATA = "";
      UvVar ST_COL = "";
      UvVar ST_LENGTH = "";
      UvVar VALUE = "";
      UvVar ST_ATT = "";
      UvVar ANS = "";
      UvVar ST_CONVERSION = "";
      UvVar CONV_ANS = "";
      UvVar ST_JUST = "";
      UvVar DAY_OF_WEEK = "";
      UvVar TIME_SELECTION = "";
      UvVar PREFIX = "";
      UvVar DESC_COL = "";
      UvVar ST_DESC = "";
      UvVar AMC = "";
      UvVar INSTRUCTOR_NO = "";
      UvVar BLANK_DISPLAY_COMPLETE = "";
      UvVar CNT = "";
      UvVar AVAILABLE_TIMES = "";
      UvVar QUALIFICATIONS = "";
      UvVar COURSE_LINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL718(ref UvVar INSTRUCTOR_ID, ref UvVar COURSE_DATE, ref UvVar COURSE_DET_START_TIME, ref UvVar INTERACT, ref UvVar REDISPLAY)
      {
         this.INSTRUCTOR_ID = INSTRUCTOR_ID;
         this.COURSE_DATE = COURSE_DATE;
         this.COURSE_DET_START_TIME = COURSE_DET_START_TIME;
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
         /*     INSTRUCTOR AVAILABILITY SEARCH */
         PROGRAM = "FL718";
         INTERACT = INVALID_DATA;
         REDISPLAY = "";
         COMMON.CLR = "\\";
         INSTRUCTOR_ID = "";
         MAT(ref REQUIRED_QUALS_REC, "");
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         /*  Include relevant file info */
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.INSTRUCTORS
         if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

         #endregion
         WINDOW_ID = PROGRAM + ".WINDOW";
         if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID)))
         {
            WINDOW = 9;
            WINDOW[2] = 18;
            WINDOW[3] = 1;
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
         FOOTER = " Select Instructor No. or <Return> to scroll ";
         if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], PROGRAM)))
         {
            nrf0 = 3;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            SC_POS = "";
         }
         INSTRUCTOR_LIST = "";
         /*  Box heading */
         PRINT(AT(79, TOP_WINDOW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
         L2400();
         /*  Display input prompts */
         /*  Box Sub-Heading */
         PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 2) + UND_VID);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
         L3000();
         /*  Display data portion of window */
         /*  Display blank box footing */
         PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
         PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(INIT, WINDOW_JUST));
         PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
         CODES_FOUND = FALSE;
         do
         {
            if (INTERACT == EXIT || CODES_FOUND) break;
            SELECTION_CRITERIA = "";
            L2000();
            /*  Get selection criteria */
            if (SELECTION_CRITERIA == "")
            {
               INSTRUCTION = "SSELECT FL.INSTRUCTORS BY 3";
            }
            else
            {
               INSTRUCTION = "SSELECT FL.INSTRUCTORS BY 3" + SELECTION_CRITERIA;
            }
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            EOF = FALSE;
            CC = 0;
            do
            {
               if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
               if (EOF) break;
               CC = CC + 1;
               INSTRUCTOR_LIST[1, CC] = ID;
            } while (true);
            if (CC == 0)
            {
               /*  No courses meet the criteria */
               nrf0 = 2;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               L2400();
               /*  Redisplay input prompts */
            }
            else
            {
               CODES_FOUND = TRUE;
            }
         } while (true);
         /*  Function is set to LIMIT if the user hits <Return> to scroll the display */
         if (INTERACT != EXIT)
         {
            L3000();
            /*  Display data portion of window */
         }
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
         /* DJA 3.11.04*     INSTRUCTOR.ID = '' */
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
            PRINT(AT(LEFT_WINDOW - 1, 2 + BOTTOM_WINDOW) + UND_VID);
            PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + FORMAT(FOOTER, WINDOW_JUST));
            PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
            INPUT(out WAIT, 4);
            // BEGIN CASE
            // CASE
            if (WAIT == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               REDISPLAY = TOP_WINDOW;
            }// CASE
            else if (WAIT == "0")
            {
               nrf0 = 1;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (MATCH(WAIT, "0N") && WAIT != "")
            {
               INSTRUCTOR_ID = INSTRUCTOR_LIST[1, WAIT];
               if (INSTRUCTOR_ID == "")
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  INTERACT = FINISH;
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
         /* *************************************************** */
      }
      void L2000()
      {
         /*   ASCERTAIN SELECTION CRITERIA                * */
         /* *************************************************** */
         FIELD_NO = 1;
         ST_ROW = TOP_WINDOW + 1;
         MAT(ref REQUIRED_QUALS_REC, "");
         do
         {
            FIELD_DATA = SC_POS[FIELD_NO];
            if (!(FIELD_DATA != "" && INTERACT != EXIT)) break;
            L2200();
            /* *PRINT @(ST.COL-2,ST.ROW):COLOR.C: */
            PRINT(AT(1, ST_ROW) + COLOR_C);
            PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
            PRINT(AT(ST_COL, ST_ROW));
            VALUE = REQUIRED_QUALS_REC[ST_ATT];
            INPUT(out ANS, ST_LENGTH);
            if (ST_CONVERSION != "")
            {
               CONV_ANS = ICONV(ANS, ST_CONVERSION);
            }
            else
            {
               CONV_ANS = "";
            }
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (ANS == COMMON.CLR)
            {
               ANS = "";
               VALUE = "";
               REQUIRED_QUALS_REC[ST_ATT] = "";
               INTERACT = VALID_DATA;
               FIELD_NO = FIELD_NO + 1;
            }// CASE
            else if (ANS == GO_BACK)
            {
               if (VALUE == "")
               {
                  PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
               }
               else
               {
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
               }
               FIELD_NO = FIELD_NO - 1;
               if (FIELD_NO < 1) { FIELD_NO = 1; }
               INTERACT = BACKUP;
            }// CASE
            else if (ST_CONVERSION != "" && ANS != "" && CONV_ANS == "")
            {
               nrf0 = 4;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == "" && VALUE != "")
            {
               INTERACT = VALID_DATA;
               if (ST_CONVERSION != "")
               {
                  ANS = OCONV(VALUE, ST_CONVERSION);
               }
               else
               {
                  ANS = VALUE;
               }
               FIELD_NO = FIELD_NO + 1;
            }// CASE
            else if (ANS == "")
            {
               INTERACT = VALID_DATA;
               FIELD_NO = FIELD_NO + 1;
            }// CASE
            else if (OTHERWISE)
            {
               /*  Further validation for 'code' fields */
               INTERACT = VALID_DATA;
               if (INTERACT == VALID_DATA)
               {
                  FIELD_NO = FIELD_NO + 1;
               }
            }
            // END CASE
            if (INTERACT == VALID_DATA)
            {
               if (ST_CONVERSION != "")
               {
                  VALUE = ICONV(ANS, ST_CONVERSION);
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
               }
               else
               {
                  VALUE = ANS;
                  PRINT(AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
               }
               REQUIRED_QUALS_REC[ST_ATT] = VALUE;
            }
         } while (true);
         if (INTERACT != EXIT)
         {
            DAY_OF_WEEK = OCONV(COURSE_DATE, "DWA");
            // BEGIN CASE
            // CASE
            if (COURSE_DET_START_TIME[1, 1] < ICONV("12:00", "MTS"))
            {
               TIME_SELECTION = "\"\" \"ALL\" \"[AM]\"";
            }// CASE
            else if (COURSE_DET_START_TIME[1, 1] < ICONV("18:00", "MTS"))
            {
               TIME_SELECTION = "\"\" \"ALL\" \"[PM]\"";
            }// CASE
            else if (OTHERWISE)
            {
               TIME_SELECTION = "\"\" \"ALL\" \"[EV]\"";
            }
            // END CASE
            SELECTION_CRITERIA = " WITH " + DAY_OF_WEEK + " = " + TIME_SELECTION;
            PREFIX = " AND WITH QUALIFICATIONS = ";
            if (REQUIRED_QUALS_REC[QUALIFICATION1] != "")
            {
               SELECTION_CRITERIA = SELECTION_CRITERIA + " " + PREFIX + " \"[" + REQUIRED_QUALS_REC[QUALIFICATION1] + "]\"";
               PREFIX = "";
            }
            if (REQUIRED_QUALS_REC[QUALIFICATION2] != "")
            {
               SELECTION_CRITERIA = SELECTION_CRITERIA + PREFIX + " \"[" + REQUIRED_QUALS_REC[QUALIFICATION2] + "]\"";
               PREFIX = "";
            }
            if (REQUIRED_QUALS_REC[QUALIFICATION3] != "")
            {
               SELECTION_CRITERIA = SELECTION_CRITERIA + PREFIX + " \"[" + REQUIRED_QUALS_REC[QUALIFICATION3] + "]\"";
               PREFIX = "";
            }
         }
         return;
         /* ************************************* */
      }
      void L2200()
      {
         /*   Get field parameters          * */
         /* ************************************* */
         DESC_COL = FIELD_DATA[1, 1];
         ST_DESC = FIELD_DATA[1, 3];
         ST_COL = FIELD_DATA[1, 1] + 2 + LEN(ST_DESC);
         ST_LENGTH = FIELD_DATA[1, 4];
         ST_ATT = FIELD_DATA[1, 5];
         ST_JUST = "L#" + ST_LENGTH;
         ST_CONVERSION = FIELD_DATA[1, 9];
         return;
         /* ***************************************************** */
      }
      void L2400()
      {
         /*   Display selection criteria prompts            * */
         /* ***************************************************** */
         /*  Input fields line:- */
         PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
         PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + COLOR_C);
         PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT("", WINDOW_JUST));
         AMC = 1;
         do
         {
            FIELD_DATA = SC_POS[AMC];
            if (FIELD_DATA == "") break;
            L2200();
            /*  Get field parameters */
            PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + COLOR_C);
            PRINT(AT(DESC_COL, TOP_WINDOW + 1) + ST_DESC);
            PRINT(AT(ST_COL, TOP_WINDOW + 1) + STR(".", ST_LENGTH));
            AMC = AMC + 1;
         } while (true);
         return;
         /* *************************************************** */
      }
      void L3000()
      {
         /*   Display data section of window              * */
         /* *************************************************** */
         INSTRUCTOR_NO = 1;
         INTERACT = INVALID_DATA;
         BLANK_DISPLAY_COMPLETE = FALSE;
         do
         {
            if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               INSTRUCTOR_ID = INSTRUCTOR_LIST[1, INSTRUCTOR_NO];
               if (CNT >= WINDOW_DEPTH) break;
               PRINT(AT(79, CNT + 10) + NRM_VID);
               if (INSTRUCTOR_ID == "")
               {
                  PRINT(AT(LEFT_WINDOW - 1, CNT + 10) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + 10) + FORMAT("", WINDOW_JUST));
               }
               else
               {
                  if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, INSTRUCTOR_ID)) { MAT(ref INSTRUCTOR_REC, ""); }
                  AVAILABLE_TIMES = "";
                  // BEGIN CASE
                  // CASE
                  if (DAY_OF_WEEK == "MONDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_MONDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "TUESDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_TUESDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "WEDNESDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_WEDNESDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "THURSDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_THURSDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "FRIDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_FRIDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "SATURDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SATURDAY];
                  }// CASE
                  else if (DAY_OF_WEEK == "SUNDAY")
                  {
                     AVAILABLE_TIMES = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SUNDAY];
                  }
                  // END CASE
                  QUALIFICATIONS = INSTRUCTOR_REC[INSTRUCTOR_QUAL1];
                  if (INSTRUCTOR_REC[INSTRUCTOR_QUAL2] != "")
                  {
                     if (QUALIFICATIONS != "") { QUALIFICATIONS = QUALIFICATIONS + ", "; }
                     QUALIFICATIONS = QUALIFICATIONS + INSTRUCTOR_REC[INSTRUCTOR_QUAL2];
                  }
                  if (INSTRUCTOR_REC[INSTRUCTOR_QUAL3] != "")
                  {
                     if (QUALIFICATIONS != "") { QUALIFICATIONS = QUALIFICATIONS + ", "; }
                     QUALIFICATIONS = QUALIFICATIONS + INSTRUCTOR_REC[INSTRUCTOR_QUAL3];
                  }
                  COURSE_LINE = FORMAT(INSTRUCTOR_NO, "R#4") + "  " + FORMAT(TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]), "L#23") + "  " + FORMAT(QUALIFICATIONS, "L#37") + "  " + FORMAT(AVAILABLE_TIMES, "L#6");
                  PRINT(AT(LEFT_WINDOW - 1, CNT + 10) + COLOR_C);
                  PRINT(AT(LEFT_WINDOW, CNT + 10) + FORMAT(COURSE_LINE, WINDOW_JUST));
               }
               INSTRUCTOR_NO = INSTRUCTOR_NO + 1;
            } while (true);
            /*  Don't prompt for course no. if this is the initial call to display a */
            /*  'blank' window */
            if (INSTRUCTOR_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
            /*  Restart display from first date when end of list is reached */
            if (INSTRUCTOR_ID == "")
            {
               INSTRUCTOR_NO = 1;
            }
            CNT = 0;
         } while (true);
         return;
      }
   }
}
