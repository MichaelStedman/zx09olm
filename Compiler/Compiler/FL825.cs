//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL825 : UvBase
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
      readonly UvVar INVALID_DATA = 5;
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
      readonly UvVar WAIT_MAST_IDS = 1;
      readonly UvVar WAIT_MAST_STATUS = 2;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      UvVar[] WAIT_STUDENT_REC = new UvVar[35];
      UvVar[] WAIT_MAST_REC = new UvVar[5];
      UvVar[] OLD_STUDENT_REC = new UvVar[40];
      UvVar[] OLD_WAIT_STUDENT_REC = new UvVar[35];
      #endregion
      #region Variables
      UvVar OLD_STUDENT_ID = "";
      UvVar NEW_STUDENT_ID = "";
      UvVar INTERACT = "";
      UvVar ERROR_MESSAGE = "";
      UvVar VM = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_ENROLMENT = "";
      UvVar N = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar FL_WAIT_STUDENTS = "";
      UvVar FL_WAIT_MASTER = "";
      UvVar NO_OF_COURSES = "";
      UvVar COURSE_NO = "";
      UvVar COURSE_DET_ID = "";
      UvVar OLD_ENROL_ID = "";
      UvVar NEW_ENROL_ID = "";
      UvVar TEST_REC = "";
      UvVar POS = "";
      UvVar OLD_POS = "";
      UvVar NO_SESSION_DATES = "";
      UvVar DATE_MVC = "";
      UvVar SESSION_NO = "";
      UvVar NEW_DET_COUNT = "";
      UvVar COURSE_DATE = "";
      UvVar POSITION_FOUND = "";
      UvVar NO_OF_ACTIVITIES = "";
      UvVar ACTIVITY_COUNT = "";
      UvVar ACTIVITY_CODE = "";
      UvVar OLD_CODE_COUNT = "";
      UvVar OLD_CODE = "";
      UvVar OLD_DATE = "";
      UvVar CODE_POS = "";
      UvVar OLD_TRANS_COUNT = "";
      UvVar OLD_TRANS_MVC = "";
      UvVar NEW_TRANS_COUNT = "";
      UvVar TRANS_DATE = "";
      #endregion
      public FL825(ref UvVar OLD_STUDENT_ID, ref UvVar NEW_STUDENT_ID, ref UvVar[] OLD_STUDENT_REC, ref UvVar[] STUDENT_REC, ref UvVar INTERACT, ref UvVar ERROR_MESSAGE)
      {
         this.OLD_STUDENT_ID = OLD_STUDENT_ID;
         this.NEW_STUDENT_ID = NEW_STUDENT_ID;
         this.OLD_STUDENT_REC = OLD_STUDENT_REC;
         this.STUDENT_REC = STUDENT_REC;
         this.INTERACT = INTERACT;
         this.ERROR_MESSAGE = ERROR_MESSAGE;
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
         /*     UPDATES TO MERGE TWO STUDENT RECORDS */
         /*  Include relevant file information */
         /* !*  INCLUDE FL.FILES FL.COURSE.PARAMS */
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
         #region INCLUDE FL.FILES FL.COURSE.MASTER

         if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
         /*  A = Activity Day or Null for standard course :- */
         /*  Optional code corresponding to FL.COURSE.TYPES :- */

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.STUDENTS
         if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

         /*  Important - keep Wait.Stud.Dates (21) in tandem */

         #endregion
         #region INCLUDE FL.FILES FL.WAIT.MASTER
         if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

         #endregion
         /* !*  READ COURSE.PARAMS FROM FL.COURSE.PARAMS, "COURSE.PARAMS" ELSE COURSE.PARAMS = "" */
         /*  Main processing section */
         INTERACT = VALID_DATA;
         ERROR_MESSAGE = "";
         NO_OF_COURSES = DCOUNT(OLD_STUDENT_REC[22], VM);
         for (COURSE_NO = 1; COURSE_NO <= NO_OF_COURSES; COURSE_NO += 1)
         {
            COURSE_DET_ID = OLD_STUDENT_REC[22][1, COURSE_NO];
            OLD_ENROL_ID = COURSE_DET_ID + "*" + OLD_STUDENT_ID;
            NEW_ENROL_ID = COURSE_DET_ID + "*" + NEW_STUDENT_ID;
            if (!MATREADU(ref ENROL_REC, FL_ENROLMENT, OLD_ENROL_ID)) { MAT(ref ENROL_REC, ""); }
            if (READ(ref TEST_REC, FL_ENROLMENT, NEW_ENROL_ID))
            {
               /*  Student is already on the course under their new number, i.e. */
               /*  they've been double-enrolled */
               /*  NB: Data on the old enrolment record will be lost. Possible impact */
               /*      on the bonus scheme, not addressed at this time. */
            }
            else
            {
               MATWRITE(ENROL_REC, FL_ENROLMENT, NEW_ENROL_ID);
            }
            DELETE(FL_ENROLMENT, OLD_ENROL_ID);
            if (!MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID)) { MAT(ref COURSE_DET_REC, ""); }
            /*  Are they already on the course under their new ID, i.e. double- */
            /*  enrolled? */
            if (LOCATE(NEW_STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
            {
               /*  Just remove their old number and adjust the course vacancies */
               /*  accordingly. */
               if (LOCATE(OLD_STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref OLD_POS, "AL"))
               {
                  COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = DELETE(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, OLD_POS, 0);
               }
               if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_TYPE], FL_COURSE_MASTER, FIELD(COURSE_DET_ID, "*", 2), 11)) { COURSE_MSTR_REC[COURSE_MSTR_TYPE] = ""; }
               if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "")
               {
                  COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_VACANCIES] + 1;
               }
               else
               {
                  /*  Activity days. Increment individual session vacancies. */
                  NO_SESSION_DATES = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
                  for (DATE_MVC = 1; DATE_MVC <= NO_SESSION_DATES; DATE_MVC += 1)
                  {
                     for (SESSION_NO = 1; SESSION_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; SESSION_NO += 1)
                     {
                        if (ENROL_REC[ENROL_SESSIONS][1, DATE_MVC, SESSION_NO] == "Y")
                        {
                           COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_MVC, SESSION_NO] = COURSE_DET_REC[COURSE_DET_VACANCIES][1, DATE_MVC, SESSION_NO] + 1;
                        }
                     }
                  }
               }
               MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID);
               /*  No need to update STUDENT.DETAIL.IDS - they're already on it. */
            }
            else
            {
               if (LOCATE(OLD_STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
               {
                  COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, POS] = NEW_STUDENT_ID;
                  MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID);
                  /* !*        END ELSE */
                  /* !*           RELEASE FL.COURSE.DETAILS, COURSE.DET.ID */
               }
               /*  Add this course id into the complete list on the new student record */
               if (LOCATE(COURSE_DET_ID, STUDENT_REC[STUDENT_DETAIL_IDS], 1, 0, 1, ref POS, "AL"))
               {
                  /*  This should not happen */
               }
               else
               {
                  /*  Loop through the course detail id's which already exist on the new */
                  /*  student record, and try to insert this one in a logical place */
                  NEW_DET_COUNT = DCOUNT(STUDENT_REC[STUDENT_DETAIL_IDS], VM);
                  COURSE_DATE = FIELD(COURSE_DET_ID, "*", 1);
                  POSITION_FOUND = FALSE;
                  N = 1;
                  do
                  {
                     if (POSITION_FOUND || N > NEW_DET_COUNT) break;
                     if (FIELD(STUDENT_REC[STUDENT_DETAIL_IDS][1, N], "*", 1) > COURSE_DATE)
                     {
                        POSITION_FOUND = TRUE;
                     }
                     else
                     {
                        N = N + 1;
                     }
                  } while (true);
                  STUDENT_REC[STUDENT_DETAIL_IDS] = INSERT(STUDENT_REC[STUDENT_DETAIL_IDS], 1, N, 0, COURSE_DET_ID);
               }
            }
         }
         if (MATREADU(ref OLD_WAIT_STUDENT_REC, FL_WAIT_STUDENTS, OLD_STUDENT_ID))
         {
            NO_OF_ACTIVITIES = DCOUNT(OLD_WAIT_STUDENT_REC[19], VM);
            for (ACTIVITY_COUNT = 1; ACTIVITY_COUNT <= NO_OF_ACTIVITIES; ACTIVITY_COUNT += 1)
            {
               ACTIVITY_CODE = OLD_WAIT_STUDENT_REC[19][1, ACTIVITY_COUNT];
               if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE)) { MAT(ref WAIT_MAST_REC, ""); }
               if (LOCATE(NEW_STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL"))
               {
                  /*  They're already on the waiting list under the second (new) id */
                  if (LOCATE(OLD_STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL"))
                  {
                     WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, POS, 0);
                     WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, POS, 0);
                     MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
                  }
               }
               else
               {
                  if (LOCATE(OLD_STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL"))
                  {
                     WAIT_MAST_REC[WAIT_MAST_IDS][1, POS] = NEW_STUDENT_ID;
                     MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
                  }
               }
            }
            if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, NEW_STUDENT_ID))
            {
               /*  Merge waiting list records */
               OLD_CODE_COUNT = DCOUNT(OLD_WAIT_STUDENT_REC[19], VM);
               for (N = 1; N <= OLD_CODE_COUNT; N += 1)
               {
                  OLD_CODE = OLD_WAIT_STUDENT_REC[19][1, N];
                  OLD_DATE = OLD_WAIT_STUDENT_REC[21][1, N];
                  if (!(LOCATE(OLD_CODE, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref CODE_POS, "AL")))
                  {
                     WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, -1] = OLD_CODE;
                     WAIT_STUDENT_REC[WAIT_STUD_DATES][1, -1] = OLD_DATE;
                  }
               }
            }
            else
            {
               MAT(ref WAIT_STUDENT_REC, OLD_WAIT_STUDENT_REC);
            }
            MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, NEW_STUDENT_ID);
            DELETE(FL_WAIT_STUDENTS, OLD_STUDENT_ID);
         }
         /*  Now merge transaction histories */
         OLD_TRANS_COUNT = DCOUNT(OLD_STUDENT_REC[25], VM);
         OLD_TRANS_MVC = 1;
         do
         {
            if (OLD_TRANS_MVC > OLD_TRANS_COUNT) break;
            NEW_TRANS_COUNT = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
            TRANS_DATE = OLD_STUDENT_REC[25][1, OLD_TRANS_MVC];
            POSITION_FOUND = FALSE;
            N = 1;
            do
            {
               if (POSITION_FOUND || N > NEW_TRANS_COUNT) break;
               if (STUDENT_REC[STUDENT_TRANS_DATES][1, N] > TRANS_DATE)
               {
                  POSITION_FOUND = TRUE;
               }
               else
               {
                  N = N + 1;
               }
            } while (true);
            STUDENT_REC[STUDENT_TRANS_DETAILS_IDS] = INSERT(STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, N, 0, OLD_STUDENT_REC[24][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_DATES] = INSERT(STUDENT_REC[STUDENT_TRANS_DATES], 1, N, 0, OLD_STUDENT_REC[25][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_TYPES] = INSERT(STUDENT_REC[STUDENT_TRANS_TYPES], 1, N, 0, OLD_STUDENT_REC[26][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_AMOUNTS] = INSERT(STUDENT_REC[STUDENT_TRANS_AMOUNTS], 1, N, 0, OLD_STUDENT_REC[27][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS] = INSERT(STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS], 1, N, 0, OLD_STUDENT_REC[28][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_MOPS] = INSERT(STUDENT_REC[STUDENT_TRANS_MOPS], 1, N, 0, OLD_STUDENT_REC[29][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT] = INSERT(STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT], 1, N, 0, OLD_STUDENT_REC[30][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_ADJ_REASON] = INSERT(STUDENT_REC[STUDENT_TRANS_ADJ_REASON], 1, N, 0, OLD_STUDENT_REC[31][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_TRANS_USER] = INSERT(STUDENT_REC[STUDENT_TRANS_USER], 1, N, 0, OLD_STUDENT_REC[32][1, OLD_TRANS_MVC]);
            STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + OLD_STUDENT_REC[27][1, OLD_TRANS_MVC];
            OLD_TRANS_MVC = OLD_TRANS_MVC + 1;
         } while (true);
         /*  Record previous student number for audit trail (via English) */
         STUDENT_REC[STUDENT_OLD_NUMBERS][1, -1] = OLD_STUDENT_ID;
         MATWRITE(STUDENT_REC, FL_STUDENTS, NEW_STUDENT_ID);
         DELETE(FL_STUDENTS, OLD_STUDENT_ID);
         /*  Release all locks */
         RELEASE();
         /*  Return to calling program */
         return;
         /*  End of program */
      }
   }
}
