//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL006 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_ERROR_MSGS = 59;
      readonly UvVar ERR_DESC = 1;
      readonly UvVar FL_HELP_MSGS = 69;
      readonly UvVar HELP_MESSAGE = 1;
      #endregion
      #region String Constants
      const string INIT = "";
      #endregion
      #region Arrays
      UvVar[] ERROR_REC = new UvVar[1];
      UvVar[] HELP_REC = new UvVar[100];
      #endregion
      #region Variables
      UvVar FILES = "";
      UvVar DATA_REC = "";
      UvVar ITEM_ID = "";
      UvVar USER_FILES = "";
      UvVar SP = "";
      UvVar TICKET_CODES = "";
      UvVar TICKET_CODES_POSITIONS = "";
      UvVar TICKET_CODES_USED = "";
      UvVar ERR_ID = "";
      UvVar INVALID = "";
      UvVar TEXT = "";
      //UvVar FLTX2 = "";
      UvVar TEXT_COUNTER = "";
      UvVar PARAM_COUNTER = "";
      UvVar ERR_MESSAGE = "";
      UvVar PARAM_PART = "";
      UvVar TEXT_PART = "";
      UvVar REPLY = "";
      UvVar DUMMY_ANS = "";
      UvVar ERR_MESS = "";
      FL0066 FL0066;
      UvVar LINE = "";
      UvVar HELP_MSG = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      //FLTX2 FLTX2;
      public FL006(ref UvVar PROGRAM, ref UvVar ERRNO, ref UvVar PARAMS)
      {
         ERR_ID = PROGRAM + "*" + ERRNO;
         INVALID = "INVALID INPUT, PRESS <RETURN>";
         if (!(READ(ref TEXT, FILES[FL_ERROR_MSGS], ERR_ID)))
         {
            TEXT = INVALID;
            TXLOG.TRANS_LOG_REC = " " + TEXT;
            TXLOG.TX_ATT = 1;
            nrf0 = "WV";
            nrf1 = "FL.ERROR.MSGS";
            //FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ERR_ID);
            WRITEV(" " + TEXT, FILES[FL_ERROR_MSGS], ERR_ID, 1);
         }
         TEXT_COUNTER = 1;
         PARAM_COUNTER = 1;
         ERR_MESSAGE = INIT;
         do
         {
            PARAM_PART = PARAMS[PARAM_COUNTER];
            TEXT_PART = TEXT[TEXT_COUNTER];
            if (PARAM_PART == "" && TEXT_PART == "") break;
            if (TEXT_PART == "")
            {
               ERR_MESSAGE = ERR_MESSAGE + PARAM_PART + " ";
               PARAM_COUNTER = PARAM_COUNTER + 1;
            }
            else
            {
               ERR_MESSAGE = ERR_MESSAGE + TEXT_PART + " ";
            }
            TEXT_COUNTER = TEXT_COUNTER + 1;
         } while (true);
         PRINT(AT(0, 23));
         PRINT(COMMON.ERR_MESS_BACK + COMMON.ERR_MESS_FORE);
         PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
         PRINT(AT(2, 23) + ERR_MESSAGE + AT(LEN(ERR_MESSAGE) + 1 + COMMON.DIVISOR, 23));
         INPUT(out REPLY, 1);
         PRINT(AT(0, 23) + COMMON.SCREEN_BACK + COMMON.SCREEN_TEXT);
         PRINT(AT(0, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
         DUMMY_ANS = REPLY;
         if (DUMMY_ANS == COMMON.HELP)
         {
            PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
            PRINT(AT(2, 23));
            PRINT("Error Message Number " + ERR_ID + " ");
            INPUT(out DUMMY_ANS, 1);
            if (DUMMY_ANS == COMMON.HELP)
            {
               PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
               PRINT(AT(2, 23));
               PRINT("Mess ");
               INPUT(out ERR_MESS, 60);
               if (ERR_MESS != "")
               {
                  TXLOG.TRANS_LOG_REC = ERR_MESS;
                  TXLOG.TX_ATT = 1;
                  nrf0 = "WV";
                  nrf1 = "FL.ERROR.MSGS";
                  //FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ERR_ID);
                  WRITEV(ERR_MESS, FILES[FL_ERROR_MSGS], ERR_ID, 1);
               }
            }
            else
            {
               if (DUMMY_ANS == "!")
               {
                  FL0066 = new FL0066(ref PROGRAM, ref ERRNO);
               }
            }
         }
         LINE = 0;
         if (DUMMY_ANS == "H" || DUMMY_ANS == "h")
         {
         L111:
            PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
            LINE = LINE + 1;
            TEXT = "No Help Installed " + LINE;
            if (!(READV(ref TEXT, FILES[FL_HELP_MSGS], ERR_ID, LINE)))
            {
               TXLOG.TRANS_LOG_REC = " " + TEXT;
               TXLOG.TX_ATT = LINE;
               nrf0 = "WV";
               nrf1 = "FL.HELP.MSGS";
               //FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ERR_ID);
               WRITEV(" " + TEXT, FILES[FL_HELP_MSGS], ERR_ID, LINE);
            }
            if (TEXT == "")
            {
               TEXT = "No Help Installed " + LINE;
            }
            PRINT(AT(0, 23));
            PRINT(COMMON.ERR_MESS_BACK + COMMON.ERR_MESS_FORE);
            PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
            PRINT(AT(2, 23) + TEXT + AT(LEN(TEXT) + 1 + COMMON.DIVISOR, 23));
            INPUT(out REPLY, 1);
            PRINT(AT(0, 23) + COMMON.SCREEN_BACK + COMMON.SCREEN_TEXT);
            if (REPLY == "H" || REPLY == "h")
            {
               PRINT(AT(0, 23));
               PRINT(COMMON.ERR_MESS_BACK + COMMON.ERR_MESS_FORE);
            L112:
               PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
               PRINT(AT(2, 23));
               PRINT("Help " + LINE + " ");
               INPUT(out HELP_MSG, 60);
               if (HELP_MSG != "")
               {
                  TXLOG.TRANS_LOG_REC = " " + HELP_MSG;
                  TXLOG.TX_ATT = LINE;
                  nrf0 = "WV";
                  nrf1 = "FL.HELP.MSGS";
                  //FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ERR_ID);
                  WRITEV(" " + HELP_MSG, FILES[FL_HELP_MSGS], ERR_ID, LINE);
               }
               else
               {
                  goto L113;
               }
               LINE = LINE + 1;
               goto L112;
            }
            if (REPLY == " ")
            {
               goto L111;
            }
         }
      L113:
         PRINT(AT(0, 23) + COMMON.SCREEN_BACK + COMMON.SCREEN_TEXT);
         PRINT(AT(2, 23) + SPACE(COMMON.SCREEN_WIDTH - 2));
         return;
      }
   }
}
