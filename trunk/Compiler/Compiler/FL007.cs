//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL007 : UvBase
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
      UvVar PROGRAM = "";
      FL000_10 FL000_10;
      UvVar ANS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL007()
      {
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
         // RETURNS STANDARD 'NOT YET' MESSAGE
         PROGRAM = "FL007";
         //     PRINT WASH:
         nrf0 = 0;
         FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
         //     PRINT @(0,0):"(":PROGRAM:")":
         PRINT(AT(10, 10) + "This process has not yet been installed");
         PRINT(AT(10, 12) + "Press <RETURN> please ");
         INPUT(out ANS, 1);
         return;
      }
   }
}
