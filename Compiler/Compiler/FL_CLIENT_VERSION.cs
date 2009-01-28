//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_CLIENT_VERSION : UvBase
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
      UvVar CLIENT_APP_VERSION = "";
      UvVar PROGRAM = "";
      #endregion
      public FL_CLIENT_VERSION(ref UvVar CLIENT_APP_VERSION)
      {
         this.CLIENT_APP_VERSION = CLIENT_APP_VERSION;
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
         // Establish Client Software
         PROGRAM = "FL.CLIENT.VERSION";
         PRINT(CHAR(28) + 54 + CHAR(20));
         ECHO_OFF();
         INPUTCR(out CLIENT_APP_VERSION);
         ECHO_ON();
         return;
         //* End Of Program
      }
   }
}
