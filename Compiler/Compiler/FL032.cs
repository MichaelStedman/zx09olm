//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL032 : UvBase
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
      readonly UvVar FL_AUTHORISED = 113;
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
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] PASS_REC = new UvVar[15];
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar PROCESS_TYPE = "";
      UvVar PROCESS_NAME = "";
      UvVar PROCESS_DESC = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar AM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar START_LINE = "";
      UvVar LAST_LINE = "";
      UvVar START_COL = "";
      UvVar LAST_COL = "";
      UvVar COL_WIDTH = "";
      UvVar THIS_LINE = "";
      UvVar THIS_COL = "";
      UvVar THIS_POS = "";
      UvVar ALLOW_CHANGES = "";
      UvVar AUTH_LEVEL = "";
      UvVar AUTH_REC = "";
      UvVar MAX_POS = "";
      UvVar OPTION = "";
      UvVar NEWINITS = "";
      UvVar POS = "";
      UvVar CHANGE_DATE = "";
      FL006 FL006;
      UvVar PASS_TO_LIVE = "";
      UvVar EXP_DATE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL032(ref UvVar PROCESS_TYPE, ref UvVar PROCESS_NAME, ref UvVar PROCESS_DESC)
      {
         this.PROCESS_TYPE = PROCESS_TYPE;
         this.PROCESS_NAME = PROCESS_NAME;
         this.PROCESS_DESC = PROCESS_DESC;
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
         // Display who has access to this menu option
         // Open files
         //*
         PROGRAM = "FL032";
         #region INCLUDE FL.FILES FL.AUTHORISED

         // each attributes contains an authorised user

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         //**
         // INITALISE LOCAL VARIABLES
         //**
         START_LINE = 6;
         LAST_LINE = 20;
         START_COL = 4;
         LAST_COL = 45;
         COL_WIDTH = 40;
         THIS_LINE = 6;
         THIS_COL = 5;
         THIS_POS = 1;
         ALLOW_CHANGES = FALSE;
         if (READV(ref AUTH_LEVEL, COMMON.FILES[FL_PASSWORDS], U_INITS, 4))
         {
            if (AUTH_LEVEL == "M")
            {
               ALLOW_CHANGES = TRUE;
            }
         }
         //*
         // Read in who's authorised
         //*
         if (!(READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], PROCESS_TYPE + "*" + PROCESS_NAME)))
         {
            AUTH_REC = "";
         }
         MAX_POS = DCOUNT(AUTH_REC, AM);
         //*
         // Control Block
         //*
         L100();
         // DISPLAY SCREEN
         do
         {
            if (INTERACT == FINISH || INTERACT == COMMON.ABANDON) break;
            L200();
            // GET OPTION
            // BEGIN CASE
            if (OPTION == "" && THIS_POS <= MAX_POS)
            {
               L100();
               // DISPLAY NEXT PAGE
            }
            else if (OPTION == "")
            {
               INTERACT = FINISH;
            }
            else if (OPTION == ".")
            {
               INTERACT = COMMON.ABANDON;
            }
            else if (OPTION == "?")
            {
               L300();
               // DISPLAY HELP
            }
            else if (ALLOW_CHANGES)
            {
               L400();
               // GIVE TAKE AUTHORITY
            }
         } while (true);
         if (INTERACT == FINISH)
         {
            WRITE(AUTH_REC, COMMON.FILES[FL_AUTHORISED], PROCESS_TYPE + "*" + PROCESS_NAME);
         }
         return;
         //**
         // SUBROUTINES
         //****
      }
      void L100()
      {
         //****
         PRINTCR(AT(0, 4) + COMMON.EOS + AT(4, 4) + "The following people can use " + PROCESS_DESC + " (" + PROCESS_NAME + ")");
         INTERACT = INVALID_DATA;
         do
         {
            if (!(INTERACT == INVALID_DATA)) break;
            PRINTCR(AT(THIS_COL, THIS_LINE) + AUTH_REC[THIS_POS]);
            THIS_POS = THIS_POS + 1;
            THIS_LINE = THIS_LINE + 1;
            // BEGIN CASE
            if (THIS_POS > MAX_POS)
            {
               INTERACT = VALID_DATA;
            }
            else if (THIS_LINE > LAST_LINE)
            {
               THIS_LINE = START_LINE;
               THIS_COL = THIS_COL + COL_WIDTH;
               if (THIS_COL > LAST_COL)
               {
                  THIS_COL = START_COL;
                  INTERACT = VALID_DATA;
               }
            }
         } while (true);
         return;
      }
      void L200()
      {
         if (ALLOW_CHANGES)
         {
            if (THIS_POS <= MAX_POS)
            {
               PRINT(AT(5, 22) + COMMON.EOL + AT(5, 22) + "Enter Initials to Add/Remove or <Return> for more ");
            }
            else
            {
               PRINT(AT(5, 22) + COMMON.EOL + AT(5, 22) + "Enter Initials to Add/Remove , ALL, NONE or <Return> to finish ");
            }
            INPUTCR(out OPTION);
         }
         else
         {
            PRINT(AT(5, 22) + COMMON.EOL + AT(5, 22) + "Press Return ");
            INPUTCR(out OPTION);
            OPTION = "";
         }
         return;
      }
      void L300()
      {
         return;
      }
      void L400()
      {
         NEWINITS = OPTION;
         // BEGIN CASE
         if (NEWINITS == "ALL")
         {
            // Reads who has access to fl099 (logoff)
            if (!(READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], "P*FL999")))
            {
               AUTH_REC = U_INITS;
            }
            THIS_POS = 1;
            THIS_LINE = START_LINE;
            THIS_COL = START_COL;
            MAX_POS = DCOUNT(AUTH_REC, AM);
            L100();
         }
         else if (NEWINITS == "NONE")
         {
            AUTH_REC = U_INITS;
            THIS_POS = 1;
            THIS_LINE = START_LINE;
            THIS_COL = START_COL;
            MAX_POS = 2;
            L100();
         }
         else if (OTHERWISE)
         {
            POS = "";
            if (LOCATE(NEWINITS, AUTH_REC, 0, 0, 1, ref POS, "AL"))
            {
               AUTH_REC = DELETE(AUTH_REC, POS);
               THIS_POS = 1;
               THIS_LINE = START_LINE;
               THIS_COL = START_COL;
               MAX_POS = MAX_POS - 1;
               L100();
            }
            else
            {
               if (!(READV(ref CHANGE_DATE, COMMON.FILES[FL_PASSWORDS], NEWINITS, 7)))
               {
                  nrf0 = 10; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  // No such user
                  return;
               }
               if (!(READV(ref PASS_TO_LIVE, COMMON.FILES[FL_CONTROL], "PASSWORD.CONTROL", 1)))
               {
                  PASS_TO_LIVE = 60;
               }
               EXP_DATE = PASS_TO_LIVE + CHANGE_DATE;
               if (EXP_DATE < TODAYS_DATE)
               {
                  nrf0 = 11; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  // User has expired
               }
               else
               {
                  AUTH_REC = INSERT(AUTH_REC, POS, 0, 0, NEWINITS);
                  THIS_POS = 1;
                  THIS_LINE = START_LINE;
                  THIS_COL = START_COL;
                  MAX_POS = MAX_POS + 1;
                  L100();
               }
            }
         }
         return;
      }
   }
}
