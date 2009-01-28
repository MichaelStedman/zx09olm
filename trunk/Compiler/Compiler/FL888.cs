//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL888 : UvBase
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
      UvVar PORT_NUMBER = "";
      UvVar MACHINE_TYPE = "";
      UvVar ALL_CLEAR = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_ATT = "";
      UvVar PROGRAM = "";
      UvVar FL_CONTROL = "";
      UvVar FL_TILL_NUMBERS = "";
      UvVar PORT_ID = "";
      UvVar EXECUTE_PROG = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGES = "";
      UvVar OTHERS = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar CCI = "";
      UvVar SER_NO = "";
      UvVar LOCATION = "";
      UvVar PORT_IDENT = "";
      UvVar PORT_NUMBER_AND_ACCOUNT = "";
      UvVar PORT_NUMB = "";
      FLTX2 FLTX2;
      FL006 FL006;
      UvVar INPUT_NO = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL888()
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
         /*  GET THE PORT NUMBER */
         /*  Last updated : 17:48 13/11/92�* Compiled : 10:17 10/11/92 */
         PROGRAM = "FL004";
         /* ********************************* */
         /*    FILES USED IN THIS PROCESS   * */
         /* ********************************* */
         if (!OPEN("FL.CONTROL", out FL_CONTROL)) { STOP(); }
         if (!OPEN("FL.TILL.NUMBERS", out FL_TILL_NUMBERS)) { STOP(); }
         if (!(READV(ref PORT_ID, FL_CONTROL, "UNIQUE.PORT", 1)))
         {
            PORT_ID = "";
         }
         if (!(READ(ref MACHINE_TYPE, FL_CONTROL, "MACHINE.TYPE")))
         {
            MACHINE_TYPE = "M9000";
         }
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         // BEGIN CASE
         // CASE
         if (MACHINE_TYPE == "M9000" && PORT_ID == "TYPE1")
         {
            INSTRUCTION = "PLID";
            nrf0 = "O";
            CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
            if (MESSAGES.Substring(1, 4) == "TSRV")
            {
               PORT_NUMBER = MESSAGES.Substring(33, 4);
            }
            else
            {
               PORT_NUMBER = MESSAGES.Substring(27, 4);
            }
         }// CASE
         else if (MACHINE_TYPE == "M9000" && PORT_ID == "TYPE2")
         {
            CCI = SYSTEM(48);
            if (CCI == 0)
            {
               PORT_NUMBER = SYSTEM(18);
            }
            else
            {
               PORT_NUMBER = CCI;
            }
         }// CASE
         else if (MACHINE_TYPE == "PCPICK" && PORT_ID == "TYPE3")
         {
            PRINT();
            PRINT();
            PRINT();
            PRINT();
            PRINT();
            PRINT(SPACE(10) + "Please enter your serial number  ");
            INPUTCR(out SER_NO, 10);
            PRINT();
            PRINT(SPACE(10) + "Please enter your location       ");
            INPUTCR(out LOCATION);
            PORT_IDENT = SER_NO + LOCATION;
            if (PORT_IDENT == "")
            {
               CHAIN("OFF");
            }
            if (!(READV(ref PORT_NUMBER, FL_TILL_NUMBERS, PORT_IDENT, 1)))
            {
               CHAIN("OFF");
            }
            PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
            PORT_NUMB = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
            TRANS_LOG_REC = PORT_NUMB;
            TX_ATT = 2;
            nrf0 = "WV"; nrf1 = "FL.TILL.NUMBERS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PORT_IDENT);
            ALL_CLEAR = 1;
         }// CASE
         else if (OTHERWISE)
         {
            PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
            PORT_NUMBER = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
            ALL_CLEAR = 1;
         }
         // END CASE
         goto L9999;
      L2000: ;
         /* *********************** */
         /*    ERROR PRINT SUBROUTINE   * */
         /* ***************************** */
         nrf0 = INIT; FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
         ALL_CLEAR = 0;
         goto L9999;
      L9999: ;
         /*  THE END */
         return;
      }
   }
}
