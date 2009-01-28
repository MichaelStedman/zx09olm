//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_FIRST_DD_DATE_HULL : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar KEY = "";
      UvVar CONTENT = "";
      UvVar TEMPLATE = "";
      UvVar TEMPLATE_FIELD_NO = "";
      UvVar FL_DIRECT_DEBITS = "";
      UvVar POS = "";
      UvVar AMT = "";
      UvVar ADJ = "";
      UvVar ADJUSTMENTS = "";
      UvVar DATES = "";
      #endregion
      public FL_FIRST_DD_DATE_HULL(ref UvVar KEY, ref UvVar CONTENT, ref UvVar TEMPLATE, ref UvVar TEMPLATE_FIELD_NO)
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
         // Return first date where DD instalment has not been adjusted
         // down to zero
         if (!OPEN("FL.DIRECT.DEBITS", out FL_DIRECT_DEBITS)) { STOP(); }
         POS = 0;
         AMT = 0;
         ADJ = 0;
         if (CONTENT[1, 1] != "")
         {
            do
            {
               if (AMT > 0) break;
               POS = POS + 1;
               if (!READV(ref ADJUSTMENTS, FL_DIRECT_DEBITS, KEY, 9)) { STOP(); }
               AMT = CONTENT[1, POS] + ADJUSTMENTS[1, POS];
            } while (true);
            if (!READV(ref DATES, FL_DIRECT_DEBITS, KEY, 7)) { STOP(); }
            CONTENT = OCONV(DATES[1, POS], "D2DMAY");
            CONTENT = OCONV(CONTENT, "MCT");
         }
         else
         {
            CONTENT = "ERROR";
         }
         return;
      }
   }
}
