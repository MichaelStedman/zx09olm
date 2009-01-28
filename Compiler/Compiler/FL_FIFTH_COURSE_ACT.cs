//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_FIFTH_COURSE_ACT : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
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
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar KEY = "";
      UvVar CONTENT = "";
      UvVar TEMPLATE = "";
      UvVar TEMPLATE_FIELD_NO = "";
      UvVar VM = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar LAST_MV = "";
      UvVar MSTR_ID = "";
      #endregion
      public FL_FIFTH_COURSE_ACT(ref UvVar KEY, ref UvVar CONTENT, ref UvVar TEMPLATE, ref UvVar TEMPLATE_FIELD_NO)
      {
         this.KEY = KEY;
         this.CONTENT = CONTENT;
         this.TEMPLATE = TEMPLATE;
         this.TEMPLATE_FIELD_NO = TEMPLATE_FIELD_NO;
         #region INCLUDE FL.COMMON FL.COMMON

         // FILES
         //    Standard
         //    Screen Control
         //    Slave Printer Control
         //    Special Video
         //    User input control
         //    Application Specific
         //COMMON SC.POS
         //    Theatre
         //    Standard EQUates
         //    Client app control
         //\
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion

         #endregion
         // Return the activity code of a students most recent course to the data
         // transfer process
         #region INCLUDE FL.FILES FL.COURSE.MASTER

         if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
         // A = Activity Day or Null for standard course :-
         // Optional code corresponding to FL.COURSE.TYPES :-

         #endregion
         LAST_MV = DCOUNT(CONTENT[1], VM);
         MSTR_ID = FIELD(CONTENT[1, LAST_MV - 4], "*", 2);
         if (!READV(ref CONTENT, FL_COURSE_MASTER, MSTR_ID, 3)) { CONTENT = ""; }
         return;
      }
   }
}
