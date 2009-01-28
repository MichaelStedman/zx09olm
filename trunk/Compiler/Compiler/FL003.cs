//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL003 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_PASSWORDS = 1;
      readonly UvVar PASS_PASS = 1;
      readonly UvVar PASS_NAME = 2;
      readonly UvVar PASS_STATUS = 3;
      readonly UvVar PASS_PRIVILEGE = 4;
      readonly UvVar PASS_SPECIAL = 5;
      readonly UvVar PASS_DEPT = 6;
      readonly UvVar PASS_DATE = 7;
      readonly UvVar PASS_USER_CHANGED = 8;
      readonly UvVar PASS_DATE_CHANGED = 9;
      readonly UvVar PASS_TIME_CHANGED = 10;
      readonly UvVar PASS_EMAIL_ADDRESS = 11;
      readonly UvVar FL_UNAUTHORISED = 40;
      readonly UvVar UNAUTH_IDENTIFIER = 1;
      readonly UvVar UNAUTH_DATE = 2;
      readonly UvVar UNAUTH_TIME = 3;
      readonly UvVar UNAUTH_TILL = 4;
      readonly UvVar FL_MD = 58;
      readonly UvVar FL_TILL_NUMBERS = 14;
      readonly UvVar TILL_TILL_NUMBER = 1;
      readonly UvVar TILL_LOCATION = 2;
      readonly UvVar TILL_TICKET_PRINTER_TYPE = 3;
      readonly UvVar TILL_TERMINAL_TYPE = 4;
      readonly UvVar TILL_AUDITORIUM_CODE = 5;
      readonly UvVar TILL_CASH_DRAWER = 6;
      readonly UvVar TILL_TRANS_TICK_PRINT = 7;
      readonly UvVar TILL_TICKET_PRINTER_QUE = 8;
      readonly UvVar TILL_ACTUAL_PORT = 9;
      readonly UvVar TILL_REC_SLIP_PRINT = 10;
      readonly UvVar TILL_AMT_TENDERED = 11;
      readonly UvVar TILL_POD = 12;
      readonly UvVar TILL_ENDORSE_CHEQUE = 13;
      readonly UvVar TILL_HOME_LOCATION = 14;
      readonly UvVar TILL_MULTIUSER_TOUCHSCREEN = 15;
      readonly UvVar TILL_TICKET_PRINTER_INTERFACE = 16;
      readonly UvVar TILL_TICKET_PRINTER_NAME = 17;
      readonly UvVar TILL_KITCHEN_PRINTER_INTERFACE = 18;
      readonly UvVar TILL_KITCHEN_PRINTER_NAME = 19;
      readonly UvVar TILL_LOCATION_DESC = 20;
      readonly UvVar TILL_THROW_LINES = 21;
      readonly UvVar TILL_TICKET_STUB = 22;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] PASS_REC = new UvVar[15];
      UvVar[] UNAUTH_REC = new UvVar[4];
      UvVar[] TILL_REC = new UvVar[25];
      #endregion
      #region Variables
      UvVar PORT_NUMBER = "";
      UvVar TERMINAL_TYPE = "";
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar PRV_CODE = "";
      UvVar USER_STATUS = "";
      UvVar ALL_CLEAR = "";
      UvVar TILL_NUMBER = "";
      UvVar TRANS_LOG_REC = "";
      UvVar EXECUTE_PROG = "";
      UvVar PROGRAM = "";
      UvVar ATTEMPTS_REC = "";
      UvVar I_ATTEMPTS_MAXIMUM = "";
      UvVar P_ATTEMPTS_MAXIMUM = "";
      UvVar PASS_DATA = "";
      UvVar NTPASS = "";
      UvVar USER_NAME = "";
      UvVar TICKET_PRINTER_TYPE = "";
      UvVar CLARITY_TILL = "";
      UvVar CLARITY_PATH = "";
      UvVar MD_ENTRY = "";
      FL006 FL006;
      UvVar START_REC = "";
      UvVar USER = "";
      UvVar PASS_ID = "";
      UvVar TMP_REC = "";
      UvVar THEATRE_PASS = "";
      FLTX2 FLTX2;
      UvVar VALID_IDENTIFIER = "";
      UvVar IDENTIFIER = "";
      UvVar P_ATTEMPTS = "";
      UvVar I_ATTEMPTS = "";
      UvVar MASTER_IDENTS = "";
      UvVar LFLEX_VERSION = "";
      //FL000_10 FL000_10;
      //FL999 FL999;
      UvVar DUMMY_ANS = "";
      UvVar ERR = "";
      UvVar WELCOME_MESSAGE = "";
      UvVar PAZZWORD = "";
      //FL054 FL054;
      UvVar PRODUCT = "";
      UvVar PASSWORD_CONTROL = "";
      UvVar MAX_DAYS = "";
      UvVar WARNING_DAYS = "";
      UvVar CHANGED_DATE = "";
      UvVar CONTINUE = "";
      UvVar POS = "";
      //FL250 FL250;
      UvVar EXPIRE = "";
      UvVar U_PRIV = "";
      UvVar PROG_MESS2 = "";
      UvVar DEPARTMENT = "";
      //FL_UNAUTHORISED_ACCESS FL_UNAUTHORISED_ACCESS;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL003()
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
         // INPUT PASSWORD AND VALIDATE
         //EXEC.FIX 07.08.92 - LBCH
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         PROGRAM = "FL003";
         //*********************************
         //   File  used in this process   *
         //*********************************
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         #region INCLUDE FL.FILES FL.UNAUTHORISED

         #endregion
         #region INCLUDE FL.FILES FL.MD

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

         #endregion

         #endregion
         if (!(MATREAD(ref TILL_REC, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER)))
         {
            MAT(ref TILL_REC, INIT);
         }
         // get maximum no of attempts to allow
         if (!(READ(ref ATTEMPTS_REC, COMMON.FILES[FL_CONTROL], "PASSWORD.ATTEMPTS")))
         {
            ATTEMPTS_REC = 3;
            ATTEMPTS_REC[2] = 3;
         }
         I_ATTEMPTS_MAXIMUM = ATTEMPTS_REC[1] - 1;
         P_ATTEMPTS_MAXIMUM = ATTEMPTS_REC[2] - 1;
         //********************************************
         //  CHECK MD ENTRY TO DETERMINE WHETHER OR   *
         //  NOT TO BYPASS THE PASSWORD CHECK.        *
         //********************************************
         if (!READ(ref PASS_DATA, COMMON.FILES[FL_MD], "FLEX.BYPASS")) { PASS_DATA = ""; }
         if (PASS_DATA[1] == "Y")
         {
            DATA(PASS_DATA[2], PASS_DATA[3]);
         }
         NTPASS = FALSE;
         if (PASS_DATA[1] == "NT")
         {
            USER_NAME = FIELD(SYSTEM(19), "\\", 2);
            DATA(USER_NAME, "");
            NTPASS = TRUE;
         }
         if (!(READV(ref TICKET_PRINTER_TYPE, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER, 3)))
         {
            TICKET_PRINTER_TYPE = "";
         }
         if (TICKET_PRINTER_TYPE == "CLARITY" && PASS_DATA[1] != "Y")
         {
            if (!(READ(ref CLARITY_TILL, COMMON.FILES[FL_CONTROL], "CLARITY.TILL.PATH")))
            {
               CLARITY_TILL = "";
            }
            CLARITY_PATH = CLARITY_TILL[1, 1];
            MD_ENTRY = "F";
            MD_ENTRY[2] = CLARITY_PATH;
            MD_ENTRY[3] = "D_VOC";
            WRITE(MD_ENTRY, COMMON.FILES[FL_MD], "CLARITY.TILL");
            if (!(OPEN("CLARITY.TILL", out CLARITY_TILL)))
            {
               nrf0 = 10;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
            if (!READ(ref START_REC, CLARITY_TILL, "FlexRun_" + TILL_NUMBER)) { START_REC = ""; }
            //        DELETE CLARITY.TILL,'FlexStart_':TILL.NUMBER
            USER = TRIM(START_REC.Substring(3, 10));
            COMMON.PASSWORD = TRIM(START_REC.Substring(13, 10));
            DATA(USER, COMMON.PASSWORD);
         }
         if (PASS_DATA[1] == "NTMULTISITE")
         {
            PASS_ID = "PASS*" + PORT_NUMBER;
            if (READ(ref TMP_REC, COMMON.FILES[FL_PASSWORDS], PASS_ID))
            {
               if (TMP_REC[3] == TODAYS_DATE)
               {
                  DATA(TMP_REC[1], TMP_REC[2]);
               }
               DELETE(COMMON.FILES[FL_PASSWORDS], PASS_ID);
            }
         }
         if (!READ(ref THEATRE_PASS, COMMON.FILES[FL_MD], "THEATRE.BYPASS")) { THEATRE_PASS = ""; }
         nrf0 = "D"; nrf1 = "FL.MD"; nrf2 = "THEATRE.BYPASS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
         DELETE(COMMON.FILES[FL_MD], "THEATRE.BYPASS");
         if (PORT_NUMBER == THEATRE_PASS[1])
         {
            if (READ(ref VALID_IDENTIFIER, COMMON.FILES[FL_PASSWORDS], THEATRE_PASS[2]))
            {
               if (VALID_IDENTIFIER[1, 1] == THEATRE_PASS[3])
               {
                  IDENTIFIER = THEATRE_PASS[2];
                  goto L18;
               }
            }
         }
         P_ATTEMPTS = 0;
         I_ATTEMPTS = 0;
         COMMON.PASSWORD = INIT;
         // print the current system information
         if (!(READV(ref MASTER_IDENTS, COMMON.FILES[FL_PASSWORDS], "MASTER.IDENTS", 1)))
         {
            MASTER_IDENTS = "";
         }
         if (!(READV(ref LFLEX_VERSION, COMMON.FILES[FL_CONTROL], "VERSION.NO", 1)))
         {
            LFLEX_VERSION = "FX.222";
         }
         PRINT(COMMON.WASH);
         nrf0 = 0;
         //FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
         PRINT(AT(39, 6) + LFLEX_VERSION);
         PRINT(AT(39, 7) + MACHINE_TYPE);
         PRINT(AT(39, 8) + TERMINAL_TYPE);
         PRINT(AT(39, 9) + TILL_REC[TILL_TICKET_PRINTER_TYPE]);
      L10:
         PRINT(AT(10, 16) + "Type in your identification please " + COMMON.EOL);
         PRINT(AT(47, 16));
         INPUT(out IDENTIFIER, 11);
         if (LEN(IDENTIFIER) > 10) { PRINT(AT(-9) + " "); IDENTIFIER = IDENTIFIER.Substring(1, 10); }
         //***********************************
         //    Check if user wants to LOGOFF *
         //***********************************
         if (IDENTIFIER == "OFF")
         {
            //       EXECUTE "SP-ASSIGN"
            //!*       INSTRUCTION = "SP-ASSIGN"
            //!*       CALL @EXECUTE.PROG(INSTRUCTION,"",RTN.LIST,LIST.AVAILABLE,MESSAGES,OTHERS)
            //FL999 = new FL999();
         }
         //*************************************
         //   Check that Identifier is valid   *
         //*************************************
         if (!(READ(ref VALID_IDENTIFIER, COMMON.FILES[FL_PASSWORDS], IDENTIFIER)))
         {
            I_ATTEMPTS = I_ATTEMPTS + 1;
            // DO NOT LOG ON AS FLEX DOES NOT KNOW OF USER
            if (NTPASS)
            {
               PRINTCR(USER_NAME + " - Not Registered");
               INPUTCR(out DUMMY_ANS);
               nrf0 = 18;
               nrf1 = "NT User has not been set up on FLEX";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            NTPASS = FALSE;
            if (I_ATTEMPTS > I_ATTEMPTS_MAXIMUM)
            {
               ERR = 1;
               goto L20;
            }
            goto L10;
         }
         WELCOME_MESSAGE = "The system recognises " + VALID_IDENTIFIER[2];
         PRINT(AT(10, 17) + WELCOME_MESSAGE);
      L15:
         PRINT(AT(10, 18) + "Your Password please ");
         ECHO_OFF();
         PRINT(AT(35, 18));
         INPUT(out COMMON.PASSWORD, 11);
         if (LEN(COMMON.PASSWORD) > 10) { PRINT(AT(-9) + " "); COMMON.PASSWORD = COMMON.PASSWORD.Substring(1, 10); }
         ECHO_ON();
         //***********************************
         //   Check that Password is valid   *
         //***********************************
         PAZZWORD = COMMON.PASSWORD;
         //FL054 = new FL054(ref IDENTIFIER, ref PAZZWORD, ref PRODUCT);
         if (PRODUCT != VALID_IDENTIFIER[1, 1] && NTPASS == FALSE)
         {
            P_ATTEMPTS = P_ATTEMPTS + 1;
            PRINT(AT(10 + LEN(WELCOME_MESSAGE) + 2 + P_ATTEMPTS, 17) + "?");
            if (P_ATTEMPTS > P_ATTEMPTS_MAXIMUM)
            {
               ERR = 2;
               goto L20;
            }
            goto L15;
         }
      L18:
         if (!(READ(ref PASSWORD_CONTROL, COMMON.FILES[FL_CONTROL], "PASSWORD.CONTROL")))
         {
            PASSWORD_CONTROL = 60;
            PASSWORD_CONTROL[2] = 53;
         }
         MAX_DAYS = PASSWORD_CONTROL[1];
         WARNING_DAYS = PASSWORD_CONTROL[2];
         CHANGED_DATE = VALID_IDENTIFIER[7];
         // BEGIN CASE
         // CASE
         if (TODAYS_DATE > CHANGED_DATE + MAX_DAYS)
         {
            PRINT(AT(10, 19) + "YOUR PASSWORD HAS EXPIRED - PLEASE CONTACT YOUR SUPERVISOR");
            INPUTCR(out CONTINUE, 1);
            U_INITS = IDENTIFIER;
            if (LOCATE(U_INITS, MASTER_IDENTS, 1, 0, 1, ref POS, "AL"))
            {
               //FL250 = new FL250();
            }
            //        CHAIN "GO"
            CHAIN("OFF");
         }// CASE
         else if (TODAYS_DATE > CHANGED_DATE + WARNING_DAYS)
         {
            EXPIRE = CHANGED_DATE + MAX_DAYS - TODAYS_DATE;
            PRINT(AT(10, 19) + "YOUR PASSWORD EXPIRES IN " + EXPIRE + " DAYS");
            PRINT(AT(10, 20) + "PLEASE REMEMBER TO CHANGE YOUR PASSWORD");
            INPUTCR(out CONTINUE, 1);
         }
         // END CASE
         U_INITS = IDENTIFIER;
         PRV_CODE = VALID_IDENTIFIER[3];
         USER_STATUS = VALID_IDENTIFIER[4];
         U_PRIV = VALID_IDENTIFIER[4];
         PROG_MESS2 = VALID_IDENTIFIER[5];
         DEPARTMENT = VALID_IDENTIFIER[6];
         ALL_CLEAR = TRUE;
         goto L30;
      L20:
         //***************************
         //   Error print Subroutine   *
         //*****************************
         if (!(MATREAD(ref UNAUTH_REC, COMMON.FILES[FL_UNAUTHORISED], PORT_NUMBER)))
         {
            MAT(ref UNAUTH_REC, INIT);
         }
         UNAUTH_REC[UNAUTH_IDENTIFIER][1, -1] = IDENTIFIER;
         UNAUTH_REC[UNAUTH_DATE][1, -1] = TODAYS_DATE;
         UNAUTH_REC[UNAUTH_TIME][1, -1] = ICONV(TIMEDATE().Substring(1, 8), COMMON.MTS);
         UNAUTH_REC[UNAUTH_TILL][4, -1] = TILL_NUMBER;
         MATWRITE(UNAUTH_REC, COMMON.FILES[FL_UNAUTHORISED], PORT_NUMBER);
         if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_UNAUTHORISED], PORT_NUMBER)) { TRANS_LOG_REC = ""; }
         nrf0 = "W";
         nrf1 = "FL.UNAUTHORISED";
         FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PORT_NUMBER);
         nrf0 = INIT; FL006 = new FL006(ref PROGRAM, ref ERR, ref nrf0);
         // PRINT ERROR
         ALL_CLEAR = FALSE;
         //FL_UNAUTHORISED_ACCESS = new FL_UNAUTHORISED_ACCESS(ref ERR);
      L30:
         //************
         //** The End ***
         //**************
         return;
      }
   }
}
