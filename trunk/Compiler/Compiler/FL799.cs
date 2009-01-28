//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL799 : UvBase
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
      readonly UvVar FL_CONTROL = 10;
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar[] ENROL_REC = new UvVar[30];
      UvVar[] COPY_ENROL_REC = new UvVar[30];
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] MEMBERS_REC = new UvVar[45];
      #endregion
      #region Variables
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar FL_COURSE_DETAILS = "";
      UvVar FL_ENROLMENT = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar RUN_PARAMS = "";
      UvVar ARCHIVE_DATE = "";
      UvVar INTERACT = "";
      FL006 FL006;
      UvVar STUDENTS_DELETED = "";
      UvVar EOF = "";
      UvVar STUDENT_NO = "";
      UvVar TEST_REC = "";
      UvVar LATEST_DATE = "";
      UvVar NUMBER_OF_COURSES = "";
      UvVar COURSE_MVC = "";
      UvVar STUDENTS_DONE = "";
      UvVar THIS_DATE = "";
      UvVar COURSE_DET_ID = "";
      UvVar ENROL_ID = "";
      UvVar POS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL799()
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
         /*  Student Archiving */
         PROGRAM = "FL799";
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /* !*  INCLUDE FL.FILES FL.COURSE.MASTER */
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
         /* !*  INCLUDE FL.FILES FL.WAIT.MASTER */
         /* !*  INCLUDE FL.FILES FL.WAIT.STUDENTS */
         if (!READ(ref RUN_PARAMS, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { RUN_PARAMS = ""; }
         ARCHIVE_DATE = RUN_PARAMS[5];
         INTERACT = INVALID_DATA;
         // BEGIN CASE
         // CASE
         if (ARCHIVE_DATE == "")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (ARCHIVE_DATE > TODAYS_DATE - 365)
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = VALID_DATA;
         }
         // END CASE
         if (INTERACT == VALID_DATA) { L0100(); }
         /*  Return to calling program */
         return;
         /* *********************************************** */
      }
      void L0100()
      {
         /*  Main processing section                  * */
         /* *********************************************** */
         PRINT(AT(0, 4) + COMMON.EOS);
         PRINT(AT(10, 4) + "Deleting students...");
         L0200();
         /*  Students */
         PRINTCR(AT(10, 4) + COMMON.EOL + STUDENTS_DELETED + " student(s) deleted.");
         /* **************************************************** */
         /*  THE COMMENTED CODE TO REMOVE OLD COURSES HAS A    * */
         /*  WEAKNESS - ANY STUDENT WHO IS STILL ATTENDING     * */
         /*  COURSES WILL BE RETAINED ON FILE IN 0100* AND     * */
         /*  ALL THEIR ENROLMENT DETAILS WILL STAY TOO. AS A   * */
         /*  RESULT 0300 WILL NOT DELETE THEIR OLDEST COURSES  * */
         /*  BECAUSE COURSE.DET.STUDENT.IDS IS NOT NULL. THE   * */
         /*  ALTERNATIVE IS TO CHECK THE BALANCE FOR EACH      * */
         /*  INDIVIDUAL COURSE FOR EACH STUDENT, AND UNENROL   * */
         /*  THEM FROM OLD, 'PAID IN FULL' COURSES. THEN       * */
         /*  DOWNDATE (RATHER THAN DELETE) STUDENT.REC, AND    * */
         /*  ONLY DELETE STUDENT.REC IF STUDENT.DETAIL.IDS     * */
         /*  IS NULL AT THE END OF THE PROCESS.                * */
         /*  IT IS QUESTIONABLE WHETHER THIS IS DESIRABLE AS   * */
         /*  AN INCOMPLETE HISTORY WILL REMAIN FOR SOME        * */
         /*  INDIVIDUALS                                       * */
         /* **************************************************** */
         /* !*  PRINT @(10,6):"Deleting courses...": */
         /* !*  GOSUB 0300 ; * Courses */
         /* !*  PRINT @(10,6):EOL:COURSES.DELETED:" course(s) deleted." */
         /* ************************************************* */
         /*  WAITING LIST ARCHIVING IS LOW PRIORITY. ONLY   * */
         /*  STOCKPORT MAKE EXTENSIVE USE OF THEM AND EVEN  * */
         /*  THEY ONLY REALLY OPERATE THREE DIFFERENT LISTS * */
         /* ************************************************* */
         /* !*  PRINT @(10,8):"Deleting waiting list entries...": */
         /* !*  GOSUB 0400 ; * Waiting Lists */
         /* !*  PRINT @(10,8):EOL:WAITING.LIST.STUDENTS.DELETED:" waiting list student(s) deleted." */
         return;
         /* *********************************************** */
      }
      void L0200()
      {
         /*  Students and enrolment details           * */
         /* *********************************************** */
         STUDENTS_DELETED = 0;
         SELECT(FL_STUDENTS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref STUDENT_NO, 0, 0, "")) { EOF = TRUE; }
            if (EOF) break;
            if (!(READ(ref TEST_REC, COMMON.FILES[FL_MEMBERS], STUDENT_NO)))
            {
               /*  Only 'standalone' students are archive candidates */
               /*  Now establish the most recent course start date */
               /*  for this student */
               if (MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_NO))
               {
                  /*  Archive candidate - now just make sure they don't have an */
                  /*                      outstanding debt or credit */
                  /*                      This is a bit crude, as the student balance */
                  /*                      can mask a credit against one course which */
                  /*                      exactly negates a debit on another. However, */
                  /*                      in reality students 'old' enough to be archived */
                  /*                      only have machine 'balances' from confused users! */
                  if (STUDENT_REC[STUDENT_BALANCE] == 0)
                  {
                     LATEST_DATE = "";
                     NUMBER_OF_COURSES = DCOUNT(STUDENT_REC[STUDENT_DETAIL_IDS], VM);
                     COURSE_MVC = 1;
                     STUDENTS_DONE = FALSE;
                     do
                     {
                        if (STUDENTS_DONE || COURSE_MVC > NUMBER_OF_COURSES) break;
                        THIS_DATE = FIELD(STUDENT_REC[STUDENT_DETAIL_IDS][1, COURSE_MVC], "*", 1);
                        if (THIS_DATE > LATEST_DATE)
                        {
                           LATEST_DATE = THIS_DATE;
                           if (LATEST_DATE > ARCHIVE_DATE) { STUDENTS_DONE = TRUE; }
                        }
                        COURSE_MVC = COURSE_MVC + 1;
                     } while (true);
                     if (LATEST_DATE == "" || LATEST_DATE < ARCHIVE_DATE)
                     {
                        /*  Delete them, along with enrolment details */
                        for (COURSE_MVC = 1; COURSE_MVC <= NUMBER_OF_COURSES; COURSE_MVC += 1)
                        {
                           COURSE_DET_ID = STUDENT_REC[STUDENT_DETAIL_IDS][1, COURSE_MVC];
                           ENROL_ID = COURSE_DET_ID + "*" + STUDENT_NO;
                           if (MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID))
                           {
                              if (LOCATE(STUDENT_NO, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL"))
                              {
                                 COURSE_DET_REC[COURSE_DET_STUDENT_IDS] = DELETE(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, POS, 0);
                                 COURSE_DET_REC[COURSE_DET_VACANCIES] = COURSE_DET_REC[COURSE_DET_VACANCIES] + 1;
                                 /*  Don't bother about concession group vacancies 'cos these */
                                 /*  are 'dead' courses and only Aquaterra use concession groups */
                                 MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID);
                              }
                           }
                           DELETE(FL_ENROLMENT, ENROL_ID);
                        }
                        DELETE(FL_STUDENTS, STUDENT_NO);
                        STUDENTS_DELETED = STUDENTS_DELETED + 1;
                     }
                  }
               }
            }
            RELEASE();
         } while (true);
         return;
         /* !** */
         /* !************************************************* */
         /* !*0300* Course master and detail records         * */
         /* !************************************************* */
         /* !** */
         /* !*     COURSES.DELETED = 0 */
         /* !** */
         /* !*     SELECT FL.COURSE.MASTER */
         /* !*     EOF = FALSE */
         /* !*     LOOP */
         /* !*        READNEXT COURSE.CODE ELSE EOF = TRUE */
         /* !*        UNTIL EOF DO */
         /* !** */
         /* !*        MATREADU COURSE.MSTR.REC FROM FL.COURSE.MASTER, COURSE.CODE THEN */
         /* !*           NUMBER.OF.COURSES = DCOUNT(COURSE.MSTR.DATES,VM) */
         /* !*           COURSE.MVC = 1 */
         /* !*           LOOP */
         /* !*              UNTIL COURSE.MVC > NUMBER.OF.COURSES DO */
         /* !** */
         /* !*              COURSE.DATE = COURSE.MSTR.DATES<1,COURSE.MVC> */
         /* !*              IF COURSE.DATE < ARCHIVE.DATE THEN */
         /* !** */
         /* !*                 COURSE.DET.ID = COURSE.DATE:"*":COURSE.CODE */
         /* !*                 READVU COURSE.DET.STUDENT.IDS FROM FL.COURSE.DETAILS, COURSE.DET.ID, 21 ELSE COURSE.DET.STUDENT.IDS = "" */
         /* !*                 IF COURSE.DET.STUDENT.IDS = "" THEN */
         /* !** */
         /* !** No enrolled students - course can be deleted */
         /* !** */
         /* !*                    DELETE FL.COURSE.DETAILS, COURSE.DET.ID */
         /* !*                    COURSE.MSTR.DATES = DELETE(COURSE.MSTR.DATES,1,COURSE.MVC,0) */
         /* !*                    NUMBER.OF.COURSES = NUMBER.OF.COURSES - 1 */
         /* !*                 END ELSE */
         /* !*                    COURSE.MVC = COURSE.MVC + 1 */
         /* !** */
         /* !*                 END */
         /* !*              END ELSE */
         /* !*                 COURSE.MVC = COURSE.MVC + 1 */
         /* !*              END */
         /* !** */
         /* !*           REPEAT */
         /* !** */
         /* !*        END */
         /* !** */
         /* !*     REPEAT */
         /* !*     RETURN */
         /* !** */
         /* !************************************************* */
         /* !*0400* Waiting list master and student files    * */
         /* !************************************************* */
         /* !** */
         /* !*  WAITING.LIST.STUDENTS.DELETED = 0 */
         /* !*  RETURN */
         /*  End of program */
      }
   }
}
