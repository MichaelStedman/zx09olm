//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL031 : UvBase
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
      readonly UvVar FL_MONITOR = 54;
      readonly UvVar MON_MENU = 1;
      readonly UvVar MON_DESC = 2;
      readonly UvVar MON_PROG = 3;
      readonly UvVar MON_OPT = 4;
      readonly UvVar FL_MENUS = 51;
      readonly UvVar MENU_DESC = 1;
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
      readonly UvVar FL_AD_HOC_ENQUIRIES = 101;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] MON_REC = new UvVar[4];
      UvVar[] MENUS_REC = new UvVar[50];
      UvVar[] PASS_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar PROCKEY = "";
      UvVar ACTIONREC = "";
      UvVar INTERACT = "";
      UvVar MAIN_USER_MENU = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar REV_VID = "";
      UvVar DIM_REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar MENU_HEAD_BACK = "";
      UvVar MENU_NOS = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_WIDTH = "";
      UvVar TILL_NUMBER = "";
      UvVar AM = "";
      UvVar PROGRAM = "";
      UvVar SPACE_VALUE = "";
      FL006 FL006;
      UvVar ACTION = "";
      UvVar MENUOPT = "";
      UvVar MENUKEY = "";
      UvVar WAIT = "";
      UvVar MENUREC = "";
      UvVar AUTHREC = "";
      UvVar MENU_POS = "";
      UvVar START_LINE = "";
      UvVar LAST_OPTION = "";
      UvVar SPC = "";
      UvVar DSSC = "";
      UvVar DSDC = "";
      UvVar LAST_LINE = "";
      UvVar SROW = "";
      UvVar TEXT_TO_DISPLAY = "";
      UvVar COL_NUMBER = "";
      UvVar SELECTION = "";
      UvVar TEXT = "";
      UvVar PSEL = "";
      UvVar COL = "";
      UvVar ROW = "";
      UvVar INTRACT = "";
      UvVar OPT = "";
      UvVar YESNO = "";
      UvVar MENU_REC = "";
      UvVar AUTH_REC = "";
      UvVar AL = "";
      UvVar AUTH_LEVEL = "";
      //FL019 FL019;
      UvVar ANS = "";
      UvVar MENUPTR = "";
      UvVar MENUSFULL = "";
      UvVar USER_MENU = "";
      UvVar MLOOP = "";
      UvVar FIRST_HALF = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL031(ref UvVar PROCKEY, ref UvVar ACTIONREC, ref UvVar INTERACT, ref UvVar MAIN_USER_MENU)
      {
         this.PROCKEY = PROCKEY;
         this.ACTIONREC = ACTIONREC;
         this.INTERACT = INTERACT;
         this.MAIN_USER_MENU = MAIN_USER_MENU;
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
         // This routine allows a user to place or remove a user report from menu
         // Richard Turner (Oct 1997)
         // In conjunciton with my revised menu driver & report generator
         PROGRAM = "FL031";
         SPACE_VALUE = " ";
         #region INCLUDE FL.FILES FL.MONITOR

         #endregion
         #region INCLUDE FL.FILES FL.MENUS

         #endregion
         #region INCLUDE FL.FILES FL.AUTHORISED

         // each attributes contains an authorised user

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         #region INCLUDE FL.FILES FL.AD.HOC.ENQUIRIES

         #endregion
         if (PROCKEY == "" || PROCKEY == 0)
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         //***
         // Main control block
         //***
         ACTION = PROCKEY.Substring(1, 2);
         if (ACTION != "A*" && ACTION != "D*")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         PROCKEY = PROCKEY.Substring(3, 99);
         // BEGIN CASE
         if (ACTION == "A*")
         {
            L0100();
            //Add a report
         }
         else if (ACTION == "D*")
         {
            L0200();
            // Remove option
         }
         PROCKEY = "";
         return;
         //*
      }
      void L0100()
      {
         //*
         MENUOPT = 0;
         L0150();
         // Display menu choices
         L0160();
         // Get the position
         if (INTERACT == COMMON.ABANDON || INTERACT == INVALID_DATA) { return; }
         MAIN_USER_MENU = MENUKEY;
         L0150();
         // Display where option is located
         PRINT(AT(1, 22) + NRM_VID + SPACE_VALUE + COMMON.EOL + AT(70, 22) + NRM_VID + SPACE_VALUE + AT(10, 22) + DIM_VID + SPACE_VALUE + "Your report will be stored here, press <Return>" + NRM_VID + SPACE_VALUE);
         INPUTCR(out WAIT, 3);
         MENUREC[MENUOPT, 1] = ACTIONREC[1];
         MENUREC[MENUOPT, 2] = "Q";
         MENUREC[MENUOPT, 3] = "FL.AD.HOC.ENQUIRIES " + PROCKEY;
         if (ACTIONREC[2] == "Y")
         {
            if (!(READ(ref AUTHREC, COMMON.FILES[FL_AUTHORISED], "Q*" + MENUREC[MENUOPT, 3])))
            {
               if (READ(ref AUTHREC, COMMON.FILES[FL_AUTHORISED], "P*FL999"))
               {
                  WRITE(AUTHREC, COMMON.FILES[FL_AUTHORISED], "Q*" + MENUREC[MENUOPT, 3]);
               }
               else
               {
                  if (READ(ref AUTHREC, COMMON.FILES[FL_AUTHORISED], "P*FT999"))
                  {
                     WRITE(AUTHREC, COMMON.FILES[FL_AUTHORISED], "Q*" + MENUREC[MENUOPT, 3]);
                  }
               }
            }
         }
         else
         {
            WRITE(U_INITS, COMMON.FILES[FL_AUTHORISED], "Q*" + MENUREC[MENUOPT, 3]);
         }
         WRITE(MENUREC, COMMON.FILES[FL_MENUS], MENUKEY);
         return;
         //*
      }
      void L0150()
      {
         //*
         if (!(READ(ref MENU_POS, COMMON.FILES[FL_MENUS], MAIN_USER_MENU)))
         {
            nrf0 = 2; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            // Serious error, no user index menu
            INTERACT = COMMON.ABANDON;
            return;
         }
         START_LINE = 4;
         LAST_OPTION = DCOUNT(MENU_POS, AM) - 1;
         // BEGIN CASE
         if (LAST_OPTION < 10)
         {
            SPC = 2;
            DSSC = 1;
            DSDC = 0;
            LAST_LINE = (LAST_OPTION * 2) + 2;
         }
         else if (LAST_OPTION < 19)
         {
            SPC = 2;
            DSSC = 0;
            DSDC = 1;
            LAST_LINE = ((LAST_OPTION - 9) * 2) + 2;
         }
         else if (OTHERWISE)
         {
            // LAST.OPTION > 18
            SPC = 1;
            DSSC = 0;
            DSDC = 0;
            LAST_LINE = (LAST_OPTION - 17) + START_LINE;
         }
         //**
         // Display Screen Format  *
         //**
         PRINT(AT(0, 0) + SCREEN_BACK + COMMON.WASH);
         //*
         // Print Normal Video at end of screen (Pick Terminals need this)
         //*
         for (SROW = 0; SROW <= 2; SROW += 1)
         {
            PRINTCR(AT(0, SROW) + NRM_VID + SPACE_VALUE + AT(SCREEN_WIDTH - 2, SROW) + NRM_VID + SPACE_VALUE);
            PRINTCR(AT(1, SROW) + MENU_HEAD_BACK + SPACE(SCREEN_WIDTH - 2) + NRM_VID + SPACE_VALUE);
         }
         PRINT(AT(1, 0) + MENU_HEAD_BACK + "(" + MAIN_USER_MENU + ")");
         PRINTCR(" Choose the option required ");
         PRINT(AT(67, 0) + OCONV(TODAYS_DATE, "D"));
         //*
         //* Print Row 1
         //*
         TEXT_TO_DISPLAY = MENU_POS[1];
         COL_NUMBER = INT((SCREEN_WIDTH - LEN(TEXT_TO_DISPLAY)) / 2 / COMMON.DIVISOR);
         PRINTCR(AT(COL_NUMBER, 1) + TEXT_TO_DISPLAY);
         //*
         //* Print Row 2
         //*
         PRINT(AT(3, 2) + "User : " + TILL_NUMBER + " " + U_INITS + AT(73, 2) + OCONV(TIME(), "MT"));
         PRINT(AT(0, 3) + NRM_VID + SPACE_VALUE);
         for (SELECTION = 1; SELECTION <= LAST_OPTION; SELECTION += 1)
         {
            TEXT = MENU_POS[SELECTION + 1, 1];
            PSEL = (100 + (SELECTION)).Substring(2, 2);
            L0400();
            // GET POSITION ON SCREEN
            PRINT(AT(COL - 4, ROW) + MENU_NOS);
            PRINT(AT(COL - 3, ROW) + PSEL);
            if (MENUOPT - 1 == SELECTION)
            {
               PRINTCR(AT(COL - 1, ROW) + REV_VID + SPACE_VALUE + TEXT + NRM_VID + SPACE_VALUE);
            }
            else
            {
               PRINT(AT(COL - 1, ROW) + NRM_VID + SPACE_VALUE + TEXT);
            }
         }
         return;
         //**
      }
      void L0160()
      {
         //**
         do
         {
            INTRACT = INVALID_DATA;
            PRINT(AT(43, 22) + NRM_VID + SPACE_VALUE);
            PRINT(AT(5, 22) + NRM_VID + SPACE_VALUE + COMMON.EOL + AT(5, 22) + DIM_VID + SPACE_VALUE + "Select the menu on which to store your report or \"A\" for any" + NRM_VID + SPACE_VALUE);
            INPUTCR(out OPT, 3);
            // BEGIN CASE
            if (OPT == "A")
            {
               INTERACT = VALID_DATA;
               L0300();
               // Find next available
            }
            else if (OPT == COMMON.ABANDON)
            {
               PRINT(AT(1, 22) + COMMON.EOL + AT(5, 22) + "You have not saved your report on a menu is this ok (YES/NO) ");
               INPUTCR(out YESNO, 5);
               if (YESNO == "YES")
               {
                  INTERACT = COMMON.ABANDON;
               }
               else
               {
                  INTERACT = INVALID_DATA;
               }
            }
            else if (MATCH(OPT, "0A"))
            {
               nrf0 = 11;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
            else if (MENU_POS[OPT + 1, 3] == MAIN_USER_MENU || MENU_POS[OPT + 1, 3] == MAIN_USER_MENU + ".1")
            {
               MAIN_USER_MENU = MENU_POS[OPT + 1, 3];
               INTERACT = BACKUP;
            }
            else if (OPT > 0 && OPT <= LAST_OPTION)
            {
               MENUKEY = MENU_POS[OPT + 1, 3];
               if (READ(ref MENUREC, COMMON.FILES[FL_MENUS], MENUKEY))
               {
                  L0350();
                  // ADD TO MENU
               }
            }
            else if (OPT < 1 || OPT > LAST_OPTION)
            {
               nrf0 = 11;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            else if (OTHERWISE)
            {
               nrf0 = 12;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
            if (!(INTERACT == INVALID_DATA)) break;
            if (INTERACT == BACKUP)
            {
               L0150();
            }
         } while (true);
         return;
         //**
      }
      void L0200()
      {
         //**
         if (READ(ref MENU_REC, COMMON.FILES[FL_MENUS], ACTIONREC[1]))
         {
            if (READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], MENU_REC < ACTIONREC[4]))
            {
               if (LOCATE(U_INITS, AUTH_REC, 0, 0, 1, ref AL, "AL"))
               {
                  if (READV(ref AUTH_LEVEL, COMMON.FILES[FL_PASSWORDS], U_INITS, 4))
                  {
                     if (AUTH_LEVEL == "M")
                     {
                        PRINTCR(AT(0, 4) + COMMON.EOS);
                        PRINTCR(AT(20, 10) + "* * * W A R N I N G * * *");
                        PRINTCR(AT(20, 11) + "You are just about to delete : ");
                        PRINTCR(AT(20, 12) + FORMAT(ACTIONREC[4] - 1, "L#4") + MENU_REC < ACTIONREC[4]);
                        PRINTCR(AT(24, 13) + "(" + MENU_REC < ACTIONREC[4]);
                        do
                        {
                           PRINT(AT(78, 23) + NRM_VID + SPACE_VALUE + AT(0, 23) + DIM_REV_VID + SPACE_VALUE + FORMAT("Are you sure that you want to delete this menu option (YES/NO) ", "L#76") + AT(70, 23));
                           nrf0 = 4;
                           //FL019 = new FL019(ref nrf0, ref ANS);
                           if (ANS == "YES" || ANS == "NO") break;
                           nrf0 = 3;
                           nrf1 = "";
                           FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        } while (true);
                        if (ANS == "YES")
                        {
                           MENU_REC = DELETE(MENU_REC, ACTIONREC[4]);
                        }
                     }
                     else
                     {
                        nrf0 = 4; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        // Not a manager
                     }
                  }
               }
               else
               {
                  nrf0 = 5; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  // No access to do so
               }
            }
         }
         WRITE(MENU_REC, COMMON.FILES[FL_MENUS], ACTIONREC[1]);
         return;
         //*
      }
      void L0300()
      {
         //*
         MENUPTR = 1;
         MENUOPT = 0;
         MENUSFULL = FALSE;
         USER_MENU = MAIN_USER_MENU.Substring(1, LEN(MAIN_USER_MENU) - 1);
         do
         {
            MENUKEY = USER_MENU + MENUPTR;
            if (!(READ(ref MENUREC, COMMON.FILES[FL_MENUS], MENUKEY)))
            {
               MENUSFULL = TRUE;
            }
            L0350();
            if (MENUOPT > 0 || MENUSFULL) break;
            MENUPTR = MENUPTR + 1;
         } while (true);
         return;
         //**
      }
      void L0350()
      {
         //**
         MENUOPT = 0;
         for (MLOOP = 2; MLOOP <= DCOUNT(MENUREC, AM) && NOT(MENUOPT > 0); MLOOP += 1)
         {
            if (MENUREC[MLOOP, 1] == "Unused")
            {
               INTERACT = VALID_DATA;
               MENUOPT = MLOOP;
            }
         }
         return;
         //**
      }
      void L0400()
      {
         //**
         // BEGIN CASE
         if (DSSC)
         {
            // DOUBLE SPACING , SINGLE COLUMN
            COL = 25;
            ROW = (SELECTION * 2) + (START_LINE - 2);
         }
         else if (DSDC)
         {
            // DOUBLE SPACING , DOUBLE COLUMN
            FIRST_HALF = INT((LAST_OPTION / 2) + .5M);
            // BEGIN CASE
            if (SELECTION >= 1 && SELECTION <= FIRST_HALF)
            {
               COL = 5;
               ROW = (SELECTION * 2) + (START_LINE - 2);
            }
            else if (OTHERWISE)
            {
               // SECOND SIDE
               COL = 45;
               ROW = ((SELECTION - FIRST_HALF) * 2) + (START_LINE - 2);
            }
         }
         else if (OTHERWISE)
         {
            // SINGLE SPACING , DOUBLE SIDED
            FIRST_HALF = INT((LAST_OPTION / 2) + .5M);
            // BEGIN CASE
            if (SELECTION >= 1 && SELECTION <= FIRST_HALF)
            {
               COL = 5;
               ROW = SELECTION + (START_LINE - 1);
            }
            else if (OTHERWISE)
            {
               // OVER FIRST HALF
               COL = 45;
               ROW = (SELECTION - FIRST_HALF) + (START_LINE - 1);
            }
         }
         return;
      }
   }
}
