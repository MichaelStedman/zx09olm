//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL111 : UvBase
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
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar ANS_PASSED = "";
      UvVar FILE_VARIABLE = "";
      UvVar FILENAME = "";
      UvVar NEW_ALLOWED = "";
      UvVar MACHINE_TYPE = "";
      UvVar ERR_LINE = "";
      UvVar REV_VID = "";
      UvVar NRM_VID = "";
      UvVar PRECISION = "";
      UvVar PROGRAM = "";
      UvVar EXECUTE_PROG = "";
      UvVar INTERACT = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar ZZZ_COUNT = "";
      UvVar CODE_LIST = "";
      UvVar ID = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar REC = "";
      UvVar REPLY = "";
      UvVar POS = "";
      FL006 FL006;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL111(ref UvVar ANS_PASSED, ref UvVar FILE_VARIABLE, ref UvVar FILENAME, ref UvVar NEW_ALLOWED)
      {
         this.ANS_PASSED = ANS_PASSED;
         this.FILE_VARIABLE = FILE_VARIABLE;
         this.FILENAME = FILENAME;
         this.NEW_ALLOWED = NEW_ALLOWED;
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
         /*  GENERAL ENQUIRIES ON CODE & NARRATIVE TYPE FILES */
         PROGRAM = "FL111";
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         /* ****************************************** */
         /*   SSELECT ALL THE ITEMS ON THE FILE      * */
         /* ****************************************** */
         INSTRUCTION = "SSELECT " + FILENAME;
         nrf0 = "O";
         CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         ZZZ_COUNT = 0;
         CODE_LIST = "";
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { ID = ""; }
            if (!(ID != "")) break;
            ZZZ_COUNT = ZZZ_COUNT + 1;
            CODE_LIST[ZZZ_COUNT] = ID;
            if (ZZZ_COUNT == 1)
            {
               PRINT(AT(0, 3) + COMMON.EOS);
               PRINT(AT(3, 3) + REV_VID + " CODE  TEXT                       " + NRM_VID + "     " + REV_VID + " CODE  TEXT                       " + NRM_VID);
               DISP_COL = 1;
               DISP_ROW = 5;
            }
            if (!READ(ref REC, FILE_VARIABLE, ID)) { NULL(); }
            PRINT(AT(DISP_COL, DISP_ROW) + FORMAT(ZZZ_COUNT, "R#2") + " " + FORMAT(ID, "L#6") + REC[1]);
            DISP_ROW = DISP_ROW + 1;
            if (DISP_ROW > 21)
            {
               if (DISP_COL == 40)
               {
                  PRINT(ERR_LINE + "Press <RETURN> for next page ");
                  INPUT(out REPLY, 2);
                  if (LEN(REPLY) > 1) { PRINTCR(AT(-9) + " "); REPLY = REPLY.Substring(1, 1); }
                  DISP_ROW = 5;
                  DISP_COL = 1;
                  PRINT(AT(0, 4) + COMMON.EOS);
               }
               else
               {
                  DISP_COL = 40;
                  DISP_ROW = 5;
               }
            }
         } while (true);
         if (ZZZ_COUNT == 0)
         {
            PRINT(ERR_LINE + "There are no others set up. Press <RETURN> ");
            INPUT(out REPLY, 2);
            if (LEN(REPLY) > 1) { PRINTCR(AT(-9) + " "); REPLY = REPLY.Substring(1, 1); }
            REPLY = "";
         }
         else
         {
            do
            {
               INTERACT = VALID_DATA;
               if (NEW_ALLOWED == TRUE)
               {
                  PRINT(ERR_LINE + "Select one of the above or a new one ");
               }
               else
               {
                  PRINT(ERR_LINE + "Select one of the above ");
               }
               INPUT(out REPLY, 5);
               if (LEN(REPLY) > 4) { PRINTCR(AT(-9) + " "); REPLY = REPLY.Substring(1, 4); }
               if (MATCH(REPLY, "0N") && REPLY != "")
               {
                  REPLY = CODE_LIST[REPLY];
               }
               if (NEW_ALLOWED == FALSE && REPLY != "")
               {
                  if (!(LOCATE(REPLY, CODE_LIST, 0, 0, 1, ref POS, "AL")))
                  {
                     nrf0 = 1;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf0);
                     INTERACT = INVALID_DATA;
                  }
               }
            } while (INTERACT == INVALID_DATA);
         }
         ANS_PASSED = REPLY;
         /* **************************************** */
         /*   RETURN TO CALLING PROGRAM            * */
         /* **************************************** */
         return;
      }
   }
}
