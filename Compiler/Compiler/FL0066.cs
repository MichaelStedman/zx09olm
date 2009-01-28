//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL0066 : UvBase
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
      const string INIT = "";
      #endregion
      #region Variables
      UvVar ERR_MSG = "";
      UvVar FILES = "";
      UvVar DATA_REC = "";
      UvVar ITEM_ID = "";
      UvVar USER_FILES = "";
      UvVar SP = "";
      UvVar TICKET_CODES = "";
      UvVar TICKET_CODES_POSITIONS = "";
      UvVar TICKET_CODES_USED = "";
      UvVar FLP = "";
      UvVar PROGRAM_REC = "";
      UvVar ERR_MESS = "";
      UvVar PROG_LINES = "";
      UvVar PROG_LINE = "";
      UvVar DISPLAY_LINE = "";
      UvVar THIS_PROG_LINE = "";
      UvVar EMESS_LINE = "";
      UvVar EMESS_NUMB = "";
      UvVar WAIT = "";
      UvVar START_LINE = "";
      UvVar FIN_LINE = "";
      UvVar DLINE = "";
      UvVar LINE = "";
      #endregion
      public FL0066(ref UvVar PROGRAM, ref UvVar ERR_MSG)
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
         // Displays the source code surrounding an error message
         if (!(OPEN("LFLEX.PROGS", out FLP)))
         {
            STOP(201, "LFLEX.PROGS");
         }
         if (!(READ(ref PROGRAM_REC, FLP, PROGRAM)))
         {
            ERR_MESS = "NO PROG";
            L0100();
            return;
         }
         PROG_LINES = DCOUNT(PROGRAM_REC, CHAR(254));
         PROG_LINE = 0;
         DISPLAY_LINE = 0;
         do
         {
            PROG_LINE = PROG_LINE + 1;
            if (PROGRAM_REC[PROG_LINE] == "" || DISPLAY_LINE) break;
            THIS_PROG_LINE = PROGRAM_REC[PROG_LINE];
            EMESS_LINE = INDEX(THIS_PROG_LINE, "CALL FL006", 1);
            EMESS_NUMB = INDEX(THIS_PROG_LINE, ERR_MSG, 1);
            if (EMESS_LINE && EMESS_NUMB)
            {
               DISPLAY_LINE = PROG_LINE;
            }
         } while (true);
         if (NOT(DISPLAY_LINE))
         {
            ERR_MESS = "CAN'T FIND ERROR MESSAGE NUMBER [" + ERR_MSG + "] IN " + PROGRAM + " SOURCE CODE";
            L0100();
         }
         else
         {
            L0200();
         }
         return;
      }
      void L0100()
      {
         L0300();
         PRINT(AT(10, 10) + ERR_MESS);
         INPUT(out WAIT, 1);
         return;
      }
      void L0200()
      {
         START_LINE = DISPLAY_LINE - 7;
         FIN_LINE = DISPLAY_LINE + 7;
         L0300();
         DLINE = 3;
         for (PROG_LINE = START_LINE; PROG_LINE <= FIN_LINE; PROG_LINE += 1)
         {
            DLINE = DLINE + 1;
            if (PROG_LINE != DISPLAY_LINE)
            {
               PRINT(AT(0, DLINE) + FORMAT(PROG_LINE, "R#5") + "   " + PROGRAM_REC[PROG_LINE]);
            }
            else
            {
               PRINT(AT(0, DLINE) + FORMAT(PROG_LINE, "R#5") + ">>>" + PROGRAM_REC[PROG_LINE]);
            }
         }
         PRINT(COMMON.ERR_LINE + "Finished, press <RETURN> ");
         INPUT(out WAIT, 1);
         return;
      }
      void L0300()
      {
         for (LINE = 1; LINE <= 15; LINE += 1)
         {
            PRINT(AT(0, LINE + 3) + COMMON.EOL);
         }
         return;
      }
   }
}
