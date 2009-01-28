//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_CLIENT_TYPE : UvBase
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
      UvVar CLIENT_APP_TYPE = "";
      UvVar PROGRAM = "";
      #endregion
      public FL_CLIENT_TYPE()
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
         PROGRAM = "FL.CLIENT.TYPE";
         // Establish Client Software
         PRINT(CHAR(28) + 54 + CHAR(20));
         ECHO_OFF();
         INPUTCR(out CLIENT_APP_TYPE);
         ECHO_ON();
         return;
         //* End Of Program
      }
   }
}
