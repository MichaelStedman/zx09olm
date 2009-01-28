//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL004_1 : UvBase
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
      #region Arrays
      UvVar[] LINES = new UvVar[30];
      #endregion
      #region Variables
      UvVar PORT_NUMBER = "";
      UvVar FL_TILL_NUMBERS = "";
      UvVar ERROR = "";
      UvVar NODE_REC = "";
      UvVar STATUS = "";
      //PIX_DOS_PICK PIX_DOS_PICK;
      UvVar I = "";
      UvVar XX = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL004_1()
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
         if (!OPEN("FL.TILL.NUMBERS", out FL_TILL_NUMBERS)) { STOP(); }
         ERROR = "";
         NODE_REC = "";
         STATUS = "";
         nrf0 = "A:\\FXNODE.TXT";
         nrf1 = "Z";
         nrf2 = "DESCRIPTION";
         //PIX_DOS_PICK = new PIX_DOS_PICK(ref nrf0, ref NODE_REC, ref nrf1, ref nrf2, ref STATUS, ref ERROR);
         if (NODE_REC == "")
         {
            nrf0 = "C:\\FXNODE.TXT";
            nrf1 = "Z";
            nrf2 = "DESCRIPTION";
            //PIX_DOS_PICK = new PIX_DOS_PICK(ref nrf0, ref NODE_REC, ref nrf1, ref nrf2, ref STATUS, ref ERROR);
         }
         PORT_NUMBER = NODE_REC[2];
         return;
         PROMPT("");
         MAT(ref LINES, "");
         PRINT(AT(-1));
         //PRINT CHAR(27):"_2;0PC:\FXTERM.EXE":CHAR(27):"\":
         EXECUTE("DOS TYPE C:\\FXNODE.TXT>MIKE.ASC", string.Empty, string.Empty, string.Empty, string.Empty);
         PRINT(CHAR(27) + "[=2;9i");
         ECHO(0);
         for (I = 1; I <= 25; I += 1)
         {
            INPUT(out LINES[I]);
         }
         ECHO(1);
         PRINT(COMMON.WASH);
         for (I = 1; I <= 30 && NOT(LINES[I].Substring(1, 6) == "FXNODE"); I += 1)
         {
            PRINTCR("[" + LINES[I] + "]");
            INPUTCR(out XX);
         }
      L777:
         if (!(READ(ref PORT_NUMBER, FL_TILL_NUMBERS, NODE_REC[1])))
         {
            PORT_NUMBER = 99;
         }
         return;
      }
   }
}
