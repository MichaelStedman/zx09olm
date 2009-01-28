//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL873 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar THIS_DATE = "";
      UvVar COURSE_START_DATE = "";
      UvVar[] COURSE_DET_REC = new UvVar[25];
      UvVar DATE_QUALIFIES = "";
      UvVar COURSE_DAYS = "";
      UvVar DAY_LEFTOVER = "";
      UvVar DAY_ABBREV1 = "";
      UvVar DAY_ABBREV2 = "";
      #endregion
      public FL873(ref UvVar THIS_DATE, ref UvVar COURSE_START_DATE, ref UvVar[] COURSE_DET_REC, ref UvVar DATE_QUALIFIES)
      {
         this.THIS_DATE = THIS_DATE;
         this.COURSE_START_DATE = COURSE_START_DATE;
         this.COURSE_DET_REC = COURSE_DET_REC;
         this.DATE_QUALIFIES = DATE_QUALIFIES;
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
         /*  Does a supplied course take place on a supplied date */
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
         DATE_QUALIFIES = FALSE;
         COURSE_DAYS = OCONV(COURSE_DET_REC[COURSE_DET_DAYS], "MCU");
         if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "") { COURSE_DET_REC[COURSE_DET_FREQUENCY] = "W"; }
         /*  If DAYS is null, use the day of the week the course start date falls */
         /*  on. There are precedents for this elsewhere in the courses module */
         if (COURSE_DAYS == "THUR") { COURSE_DAYS = "THU"; }
         if (COURSE_DAYS == "TUES") { COURSE_DAYS = "TUE"; }
         if (COURSE_DAYS == "MO" || COURSE_DAYS == "MONDAY") { COURSE_DAYS = "MON"; }
         if (COURSE_DAYS == "TU" || COURSE_DAYS == "TUESDAY") { COURSE_DAYS = "TUE"; }
         if (COURSE_DAYS == "WE" || COURSE_DAYS == "WEDNESDAY") { COURSE_DAYS = "WED"; }
         if (COURSE_DAYS == "TH" || COURSE_DAYS == "THURSDAY") { COURSE_DAYS = "THU"; }
         if (COURSE_DAYS == "FR" || COURSE_DAYS == "FRIDAY") { COURSE_DAYS = "FRI"; }
         if (COURSE_DAYS == "SA" || COURSE_DAYS == "SATURDAY") { COURSE_DAYS = "SAT"; }
         if (COURSE_DAYS == "SU" || COURSE_DAYS == "SUNDAY") { COURSE_DAYS = "SUN"; }
         if (COURSE_DAYS == "" || (NOT(INDEX("*MON*TUE*WED*THU*FRI*SAT*SUN*", "*" + COURSE_DAYS + "*", 1)) && NOT(MATCH(COURSE_DET_REC[COURSE_DET_FREQUENCY], "\"W\"1N"))))
         {
            DAY_LEFTOVER = MOD(COURSE_START_DATE, 7);
            // BEGIN CASE
            // CASE
            if (DAY_LEFTOVER == 0)
            {
               COURSE_DAYS = "SUN";
            }// CASE
            else if (DAY_LEFTOVER == 1)
            {
               COURSE_DAYS = "MON";
            }// CASE
            else if (DAY_LEFTOVER == 2)
            {
               COURSE_DAYS = "TUE";
            }// CASE
            else if (DAY_LEFTOVER == 3)
            {
               COURSE_DAYS = "WED";
            }// CASE
            else if (DAY_LEFTOVER == 4)
            {
               COURSE_DAYS = "THU";
            }// CASE
            else if (DAY_LEFTOVER == 5)
            {
               COURSE_DAYS = "FRI";
            }// CASE
            else if (DAY_LEFTOVER == 6)
            {
               COURSE_DAYS = "SAT";
            }
            // END CASE
         }
         // BEGIN CASE
         // CASE
         if (COURSE_DET_REC[COURSE_DET_FREQUENCY] != "W" && COURSE_DET_REC[COURSE_DET_FREQUENCY] != "F" && NOT(MATCH(COURSE_DET_REC[COURSE_DET_FREQUENCY], "\"W\"1N")))
         {
            DATE_QUALIFIES = FALSE;
         }// CASE
         else if ((COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W" || COURSE_DET_REC[COURSE_DET_FREQUENCY] == "F") && NOT(INDEX("*MON*TUE*WED*THU*FRI*SAT*SUN*", "*" + COURSE_DAYS + "*", 1)))
         {
            DATE_QUALIFIES = FALSE;
         }// CASE
         else if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "F" && MOD((THIS_DATE - COURSE_START_DATE), 14) != 0)
         {
            DATE_QUALIFIES = FALSE;
         }// CASE
         else if (OTHERWISE)
         {
            /*  We now know we have a current course with :- */
            /*    - a start time and an end time */
            /*    - a frequency of 'W', 'F' or 'W1' through 'W7' */
            /*    - for frequency 'W' or 'F', a valid day of MON, TUE, WED etc */
            /*     (for 'Wn' case we have not tested the contents of DAYS. It */
            /*      should hold a sub-set of MoTuWeThFrSaSu) */
            /*  Does the course run on this day of the week? */
            DAY_LEFTOVER = MOD(THIS_DATE, 7);
            // BEGIN CASE
            // CASE
            if (DAY_LEFTOVER == 0)
            {
               DAY_ABBREV1 = "SUN";
               DAY_ABBREV2 = "SU";
            }// CASE
            else if (DAY_LEFTOVER == 1)
            {
               DAY_ABBREV1 = "MON";
               DAY_ABBREV2 = "MO";
            }// CASE
            else if (DAY_LEFTOVER == 2)
            {
               DAY_ABBREV1 = "TUE";
               DAY_ABBREV2 = "TU";
            }// CASE
            else if (DAY_LEFTOVER == 3)
            {
               DAY_ABBREV1 = "WED";
               DAY_ABBREV2 = "WE";
            }// CASE
            else if (DAY_LEFTOVER == 4)
            {
               DAY_ABBREV1 = "THU";
               DAY_ABBREV2 = "TH";
            }// CASE
            else if (DAY_LEFTOVER == 5)
            {
               DAY_ABBREV1 = "FRI";
               DAY_ABBREV2 = "FR";
            }// CASE
            else if (DAY_LEFTOVER == 6)
            {
               DAY_ABBREV1 = "SAT";
               DAY_ABBREV2 = "SA";
            }
            // END CASE
            // BEGIN CASE
            /*  Weekly courses :- */
            // CASE
            if ((COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W" || COURSE_DET_REC[COURSE_DET_FREQUENCY] == "F") && NOT(COURSE_DAYS == DAY_ABBREV1))
            {
               DATE_QUALIFIES = FALSE;
            }// CASE
            else if (MATCH(COURSE_DET_REC[COURSE_DET_FREQUENCY], "\"W\"1N"))
            {
               if (INDEX(COURSE_DAYS, DAY_ABBREV2, 1))
               {
                  DATE_QUALIFIES = TRUE;
               }
               else
               {
                  DATE_QUALIFIES = FALSE;
               }
            }// CASE
            else if (OTHERWISE)
            {
               DATE_QUALIFIES = TRUE;
               /*  Bottom of case statement which tests whether entry is allowed */
               /*  once its established that the details are recognisable :- */
            }
            // END CASE
            /*  Bottom of case statement to validate data on fl.course.details */
            /*  is recognisable :- */
         }
         // END CASE
         /*  Return to calling program */
         return;
      }
   }
}
