//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL011_1 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_TICKETS = 11;
      readonly UvVar TICK_CODE = 1;
      readonly UvVar TICK_UNIT = 2;
      readonly UvVar TICK_UNIT_PRICE = 3;
      readonly UvVar TICK_DATE = 4;
      readonly UvVar TICK_TIME = 5;
      readonly UvVar TICK_TOTAL = 6;
      readonly UvVar TICK_MOP = 7;
      readonly UvVar TICK_CLERK = 8;
      readonly UvVar TICK_TILL = 9;
      readonly UvVar TICK_MEMBER = 10;
      readonly UvVar TICK_PEAK_INDICATOR = 11;
      readonly UvVar TICK_CONCESS = 13;
      readonly UvVar TICK_CC_REF = 14;
      readonly UvVar TICK_CC_EXP = 15;
      readonly UvVar TICK_SESSION_NO = 16;
      readonly UvVar TICK_BB_REF = 20;
      readonly UvVar TICK_HCOUNT = 21;
      readonly UvVar TICK_ACTIVITY_DATE = 22;
      readonly UvVar TICK_CUSTOMER_NAME = 23;
      readonly UvVar TICK_BONUS_POINTS = 24;
      readonly UvVar TICK_PROMOTION = 25;
      readonly UvVar TICK_CANCEL = 26;
      readonly UvVar TICK_REDEEMED = 27;
      readonly UvVar TICK_POINTS_REDEEMED = 28;
      readonly UvVar TICK_SOURCE_ID = 29;
      readonly UvVar TICK_EFT_SEQNO = 30;
      readonly UvVar TICK_EFT_SWIPE = 31;
      readonly UvVar TICK_ORIGINAL_NO = 32;
      readonly UvVar TICK_VAT_IND = 33;
      readonly UvVar TICK_HOME_CENTRE = 34;
      readonly UvVar TICK_APACS_NO = 36;
      readonly UvVar TICK_STUDENT_ID = 37;
      readonly UvVar TICK_COURSE_DETAILS_ID = 38;
      readonly UvVar TICK_BOOK_REF = 39;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] TICKET_REC = new UvVar[40];
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar TODAYS_DATE = "";
      UvVar SYSTEM_EXPIRY = "";
      UvVar OVER = "";
      #endregion
      public FL011_1()
      {
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion
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
         // Payment Control
         #region INCLUDE FL.FILES FL.TICKETS

         // (12) Used in OLD.TICKETS
         // (17-19) Used in OLD.TICKETS
         // DJA 7.2.01
         // Source id is prefixed W for Web or W for Handheld.
         // This may be followed by a numeric audit reference.
         // 5.9.02 Table type introduced using same scheme
         //        for use by touchscreens
         // 08.10.04 D for Door access introduced. First site: Ipswich
         // (35) USED IN OLD TICKETS

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         if (!(READV(ref SYSTEM_EXPIRY, COMMON.FILES[FL_CONTROL], "FL011.1", 1)))
         {
            SYSTEM_EXPIRY = 99999;
         }
         if (TODAYS_DATE > SYSTEM_EXPIRY)
         {
            OVER = TODAYS_DATE - SYSTEM_EXPIRY;
            if (OVER > 14) { OVER = 14; }
            FILELOCK(COMMON.FILES[FL_TICKETS]);
            CRT(RND(OVER));
            FILEUNLOCK(COMMON.FILES[FL_TICKETS]);
         }
         return;
      }
   }
}
