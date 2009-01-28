//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL011 : UvBase
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
      readonly UvVar FL_CENTRES = 3;
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_MONITOR = 54;
      readonly UvVar MON_MENU = 1;
      readonly UvVar MON_DESC = 2;
      readonly UvVar MON_PROG = 3;
      readonly UvVar MON_OPT = 4;
      readonly UvVar FL_MENUS = 51;
      readonly UvVar MENU_DESC = 1;
      readonly UvVar FL_MENU_SELECTIONS = 50;
      readonly UvVar MENU_SELECT_OPTION = 1;
      readonly UvVar FL_REPORTS = 71;
      readonly UvVar REPORT_VERB = 1;
      readonly UvVar REPORT_FILE = 2;
      readonly UvVar REPORT_SELECT_1 = 3;
      readonly UvVar REPORT_SELECT_2 = 4;
      readonly UvVar REPORT_SELECT_3 = 5;
      readonly UvVar REPORT_SELECT_4 = 6;
      readonly UvVar REPORT_SELECT_5 = 7;
      readonly UvVar REPORT_SORT = 8;
      readonly UvVar REPORT_ASC_DSC = 9;
      readonly UvVar REPORT_SHOW = 10;
      readonly UvVar REPORT_BREAK = 11;
      readonly UvVar REPORT_TOTAL = 12;
      readonly UvVar REPORT_ID = 13;
      readonly UvVar REPORT_PRINT = 14;
      readonly UvVar REPORT_DETAIL = 15;
      readonly UvVar REPORT_STATEMENT = 20;
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] MON_REC = new UvVar[4];
      UvVar[] MENUS_REC = new UvVar[50];
      UvVar[] MENU_SELECT_REC = new UvVar[1];
      UvVar[] REPORTS_REC = new UvVar[20];
      UvVar[] PASS_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar MENU = "";
      UvVar START_LINE = "";
      UvVar PROCESS = "";
      UvVar PROCESS_TYPE = "";
      UvVar PORT_NUMBER = "";
      UvVar TERMINAL_TYPE = "";
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar ALL_CLEAR = "";
      UvVar REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar MENU_HEAD_BACK = "";
      UvVar MENU_NOS = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar DBL_WID_ON = "";
      UvVar SCREEN_WIDTH = "";
      UvVar AUTH_ID = "";
      UvVar TILL_NUMBER = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar DISP_LINE = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_ATT = "";
      UvVar INTERACT = "";
      UvVar FIRST_MENU = "";
      UvVar PROGRAM = "";
      UvVar SPACE_VALUE = "";
      UvVar SHOW_ALL = "";
      UvVar SELECTION = "";
      UvVar IDENT = "";
      UvVar QUICK_CALLS = "";
      UvVar AUTO_HIDE_MODE = "";
      UvVar AUTO_HIDE = "";
      UvVar USER_SHOW = "";
      UvVar AUTO_DOT = "";
      UvVar RESET_BACK = "";
      UvVar GO_FOR_IT = "";
      UvVar TWINKLE = "";
      UvVar PMENU = "";
      UvVar MULTIPLIER = "";
      UvVar CENTRE_DESC = "";
      FL011_1 FL011_1;
      UvVar SCREEN_CODE = "";
      FL0001_110 FL0001_110;
      UvVar FUNCTION_KEY_CONVERT = "";
      UvVar MENU_POS = "";
      UvVar ERROR_NUM = "";
      UvVar ORIG_LINES = "";
      FL011_2 FL011_2;
      UvVar MENU_LINE = "";
      UvVar AUTH = "";
      UvVar LAST_OPTION = "";
      UvVar DSSC = "";
      UvVar DSDC = "";
      UvVar SPC = "";
      UvVar LAST_LINE = "";
      UvVar HITINDEX = "";
      UvVar TEXT = "";
      UvVar PSEL = "";
      UvVar COL = "";
      UvVar ROW = "";
      UvVar PM_KEY = "";
      UvVar OPTION1 = "";
      UvVar OPTION = "";
      UvVar OPTION2 = "";
      UvVar USERS_WHO_CAN = "";
      FLTX2 FLTX2;
      FL024 FL024;
      UvVar AUTHORISED = "";
      UvVar PROCHIST = "";
      FL020 FL020;
      UvVar INPUT_COMPLETE = "";
      UvVar OPTION_LENGTH = "";
      UvVar FNUM = "";
      UvVar QPROCESS = "";
      //CallAt_QPROCESS CallAt_QPROCESS;
      UvVar USR_LEVL = "";
      FL027 FL027;
      UvVar QUICKABLE = "";
      UvVar OPTION_LIST = "";
      UvVar WINDOW_REC = "";
      UvVar OPT_SEL = "";
      FL_XTD_WINDOW FL_XTD_WINDOW;
      FL032 FL032;
      UvVar IPLUS = "";
      UvVar FIRST_HALF = "";
      CallAt_PROCESS CallAt_PROCESS;
      FL100_ALL FL100_ALL;
      UvVar TLEN = "";
      FL006 FL006;
      UvVar TEXXT = "";
      UvVar WAIT = "";
      UvVar SROW = "";
      UvVar TEXT_TO_DISPLAY = "";
      UvVar COL_NUMBER = "";
      UvVar DELOPT = "";
      UvVar PROCKEY = "";
      UvVar ACTIONREC = "";
      FL031 FL031;
      UvVar REPORT_NAME = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL011(ref UvVar MENU, ref UvVar START_LINE, ref UvVar PROCESS, ref UvVar PROCESS_TYPE)
      {
         this.MENU = MENU;
         this.START_LINE = START_LINE;
         this.PROCESS = PROCESS;
         this.PROCESS_TYPE = PROCESS_TYPE;
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
         // MENU DRIVER
         // Last updated : 16:50 10/01/92�* Compiled : 11:39 10/01/92
         // Auto Hide Mode - 1 = hide as default
         // Auto Hide Mode - 2 = dim as default
         // if the user collapses the menu they will be reminded that +
         // views all only in mode 2
         FIRST_MENU = MENU;
         PROGRAM = "FL011";
         //   Files used   *
         #region INCLUDE FL.FILES FL.MONITOR

         #endregion
         #region INCLUDE FL.FILES FL.MENUS

         #endregion
         #region INCLUDE FL.FILES FL.MENU.SELECTIONS

         #endregion
         #region INCLUDE FL.FILES FL.REPORTS

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         SPACE_VALUE = " ";
         SHOW_ALL = TRUE;
         // Quick Calls
         SELECTION = 0;
         if (TERMINAL_TYPE != "I" && TERMINAL_TYPE != "M" && TERMINAL_TYPE != "S")
         {
            IDENT = "QUICK.CALLS";
         }
         else
         {
            IDENT = "QUICK.CALLS*I";
         }
         if (!(READ(ref QUICK_CALLS, COMMON.FILES[FL_CONTROL], IDENT)))
         {
            QUICK_CALLS = "";
         }
         if (!(READV(ref AUTO_HIDE_MODE, COMMON.FILES[FL_CONTROL], "AUTO.HIDE.MENUS", 1)))
         {
            AUTO_HIDE_MODE = 2;
         }
         AUTO_HIDE = AUTO_HIDE_MODE;
         if (AUTO_HIDE_MODE == 2)
         {
            SHOW_ALL = TRUE;
            AUTO_HIDE = TRUE;
         }
         if (AUTO_HIDE)
         {
            if (READV(ref USER_SHOW, COMMON.FILES[FL_PASSWORDS], U_INITS, 5))
            {
               if (USER_SHOW == FALSE)
               {
                  SHOW_ALL = FALSE;
               }
            }
         }
         // RT REMOVED THIS BIT- THINK ITS POINTLESS - IF IT NEEDS TO GO BACK FEEL FREE
         if (!(READ(ref AUTO_DOT, COMMON.FILES[FL_CONTROL], "FL011.AUTO.DOT")))
         {
            //        READV TIMEOUT FROM FL.CONTROL,"FL011.AUTO.TIMEOUT",1 ELSE
            //           READV MAXTIME FROM FL.CONTROL,"FL011.AUTO.MAXTIME",1 ELSE
            //              MAXTIME = 30
            //           END
            //           TIMEOUT = DATE() + MAXTIME
            //           WRITE TIMEOUT ON FL.CONTROL,"FL011.AUTO.TIMEOUT"
            //        END
            //        IF TIMEOUT > TODAYS.DATE THEN
            //           READ AUTO.DOT FROM FL.CONTROL, "FL011.AUTO.DOT*":U.INITS ELSE
            //              PRINT WASH:
            //              PRINT @(5,10) : "We have changed the menus so that the 'dot' works in line"
            //              PRINT @(5,11) : "with the rest of the system, this means that to exit a menu"
            //              PRINT @(5,12) : "you will need to press '.' then <RETURN> "
            //              PRINT @(5,13) : "The system will automatically use the new menus on " : OCONV(TIMEOUT,"D")
            //012           PRINT @(5,15) :"Do you want to take advantage of this Y/N or <return> to try it first : ":
            //              CALL FL019(2,ANS)
            //              IF ANS = "" THEN
            //                 AUTO.DOT = FALSE
            //              END ELSE
            //                 IF ANS = "N" THEN
            //                    AUTO.DOT = TRUE
            //                 END ELSE
            //                    AUTO.DOT = FALSE
            //                 END
            //                 WRITE AUTO.DOT ON FL.CONTROL,"FL011.AUTO.DOT*": U.INITS
            //              END
            //           END
            //        END ELSE
            AUTO_DOT = FALSE;
            WRITE(AUTO_DOT, COMMON.FILES[FL_CONTROL], "FL011.AUTO.DOT");
         }
         //     END
         if (!READV(ref AUTH_ID, COMMON.FILES[FL_CONTROL], "AUTH.ID", 1)) { AUTH_ID = ""; }
         if (START_LINE == "M") { START_LINE = 4; }
         RESET_BACK = SCREEN_BACK;
         ALL_CLEAR = 1;
         GO_FOR_IT = "";
         TWINKLE = "*";
         PMENU = "";
         PMENU[1] = MENU;
         MAT(ref MON_REC, "");
         if (DBL_WID_ON != "")
         {
            MULTIPLIER = 2;
         }
         else
         {
            MULTIPLIER = 1;
         }
         if (!(READV(ref CENTRE_DESC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)))
         {
            CENTRE_DESC = "UNKnown";
         }
      L10:
         // Check system authorised
         if (MACHINE_TYPE == "UNIVERSE")
         {
            FL011_1 = new FL011_1();
         }
         SCREEN_CODE = MENU;
         FL0001_110 = new FL0001_110(ref PROGRAM, ref FUNCTION_KEY_CONVERT);
         if (!(READ(ref MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE)))
         {
            ERROR_NUM = 1;
            L70();
            ALL_CLEAR = 0;
            L0900();
            return;
         }
         ORIG_LINES = COUNT(MENU_POS, AM) + 1;
         if (AUTO_HIDE)
         {
            FL011_2 = new FL011_2(ref MENU_POS, ref SHOW_ALL);
         }
         PRINT(AT(0, 4) + SCREEN_BACK + SCREEN_TEXT);
         PRINT(AT(0, 23) + DISP_LINE + "@");
         MON_REC[MON_MENU] = MENU;
         MON_REC[MON_DESC] = MENU_POS[1];
         MON_REC[MON_PROG] = "";
         MON_REC[MON_OPT] = "";
         L85();
         SCREEN_LINES = COUNT(MENU_POS, AM) + 1;
         for (MENU_LINE = 1; MENU_LINE <= SCREEN_LINES; MENU_LINE += 1)
         {
            if (MENU_POS[MENU_LINE, 2] == "P" || MENU_POS[MENU_LINE, 2] == "Q")
            {
               PROCESS = MENU_POS[MENU_LINE, 3];
               AUTH = 0;
               //         IF AUTH THEN
               //           LOCATE(PRV.CODE,AUTH.LEVELS,2;AUTH) ELSE AUTH = 0
               //         END
               MENU_POS[MENU_LINE, 10] = AUTH;
            }
         }
         LAST_OPTION = SCREEN_LINES - 1;
         if (LAST_OPTION > 36)
         {
            ERROR_NUM = 3;
            L70();
            ALL_CLEAR = 0;
            L0900();
            return;
         }
         //                                                 *
         //   DECIDE ON WHAT SPACING AND HOW MANY COLUMNS   *
         //   DSSC = DOUBLE SPACING, SINGLE COLUMN          *
         //   DSDC = DOUBLE SPACING, DOUBLE COLUMN          *
         //   ELSE = SINGLE SPACING, DOUBLE COLUMN          *
         //                                                 *
         // BEGIN CASE
         // CASE
         if (LAST_OPTION < 10)
         {
            SPC = 2;
            DSSC = 1;
            DSDC = 0;
            LAST_LINE = (LAST_OPTION * 2) + 2;
         }// CASE
         else if (LAST_OPTION < 19)
         {
            SPC = 2;
            DSSC = 0;
            DSDC = 1;
            LAST_LINE = ((LAST_OPTION - 9) * 2) + 2;
         }// CASE
         else if (OTHERWISE)
         {
            SPC = 1;
            DSSC = 0;
            DSDC = 0;
            LAST_LINE = (LAST_OPTION - 17) + START_LINE;
         }
         // END CASE
         // Display screen
         L0100();
         // Print rest of lines
         //MHS **************************
         //MHS!INCLUDE FZ.LIBRARY FW.INCLUDE
         //MHS!IF TILL.NUMBER = 108 THEN
         //MHS!PRINT SOC:"65":EOC:
         //MHS!PRINT SOC:"67,,,.":CHAR(13):EOC:
         //MHS!END
         HITINDEX = 0;
         //MHS **************************
         //     PRINT @(8,22): MENU.BACK: MENU.NOS:
         for (SELECTION = 1; SELECTION <= LAST_OPTION; SELECTION += 1)
         {
            TEXT = MENU_POS[SELECTION + 1, 1];
            PSEL = (100 + (SELECTION)).Substring(2, 2);
            L40();
            PRINT(AT(COL - 4, ROW) + MENU_NOS);
            PRINT(AT(COL - 3, ROW) + PSEL);
            PRINT(AT(COL - 1, ROW) + NRM_VID + SPACE_VALUE + TEXT);
            //MHS **************************
            //MHS!IF TILL.NUMBER = 108 THEN
            //MHS!PRINT SOC:"66,":HITINDEX:",":COL-4:",":ROW:",":LEN(SPACE.VALUE:TEXT):",":SELECTION:CHAR(13):EOC:
            //MHS!END
            HITINDEX += 1;
            //MHS **************************
         }
         //     PRINT @(8,22): MENU.BACK: MENU.NOS:
         PRINT(AT(43, 22) + NRM_VID + SPACE_VALUE);
         if (SHOW_ALL == FALSE && AUTO_HIDE_MODE == 2 && SCREEN_LINES != ORIG_LINES)
         {
            PRINTCR(AT(10, 23) + NRM_VID + SPACE_VALUE + "(Enter + to show hidden options)");
         }
         PRINT(AT(10, 22) + DIM_VID + SPACE_VALUE + "Select option and press <RETURN>" + AT(45, 22) + "..");
         PM_KEY = PORT_NUMBER + TWINKLE + MENU;
         if (!(READV(ref SELECTION, COMMON.FILES[FL_MENU_SELECTIONS], PM_KEY, 1)))
         {
            SELECTION = 1;
         }
         if (SELECTION > DCOUNT(MENU_POS, AM)) { SELECTION = 1; }
         L40();
         L60();
      L20:
         //   Get inputs   *
         OPTION1 = "";
         // SPLIT OPTION TO CATER FOR ONE CHARACTER
         OPTION2 = "";
         // SPECIALS
         PRINT(AT(44, 22) + MENU_NOS);
         PRINT(AT(45, 22) + ".." + AT(45, 22));
         PRINT(AT(1, 0) + MENU_HEAD_BACK);
         if (AUTH_ID == "PBC")
         {
            PRINT(AT(73, 3) + OCONV(TIME(), "MT"));
         }
         else
         {
            PRINT(AT(73, 2) + OCONV(TIME(), "MT"));
         }
         PRINT(AT(0, 4) + NRM_VID + SPACE_VALUE);
         //RT*ECHO ON
         //RT     IF OPTION1 = UP OR OPTION1 = DOWN THEN
         //RT        GO 30
         //RT     END
         //RT     IF OPTION1 = RIGHT OR OPTION1 = LEFT THEN
         //RT        GO 30
         //RT     END
         //RT     IF OPTION1 = SKIP AND AUTO.DOT THEN
         //RT******* EXIT FROM CURRENT MENU *
         //RT        PROCESS = SKIP
         //RT        PROCESS.TYPE = SKIP
         //RT        PMENU = DELETE(PMENU,1,0,0)
         //RT        MENU = PMENU<1>
         //RT        IF PMENU = '' THEN
         //RT********** SEE IF PREVIOUS MENUS SET *
         //RT           GOSUB 0900 ; RETURN
         //RT        END ELSE
         //RT           GO 10
         //RT        END
         //RT     END
         //RT     IF OPTION1 = SKIP AND NOT(AUTO.DOT) THEN
         //RT        PRINT @(45,22):OPTION1:" ":" <-' or <--" : @(46,22):
         //RT     END ELSE
         //RT        PRINT @(47,22):SPACE(10):@(45,22):OPTION1:
         //RT     END
         //RT     IF OPTION1 = BELL THEN
         //RT        ALL.CLEAR = BELL
         //RT        GOSUB 0900 ; RETURN
         //RT     END
         //RT     IF OPTION1 = GO.FOR.IT THEN
         //RT        PM.KEY = PORT.NUMBER : TWINKLE : MENU
         //RT        PROCESS = MENU.POS<SELECTION+1,3>
         //RT        USERS.WHO.CAN = MENU.POS<SELECTION+1,2>
         //RT        IF PROCESS # 'FL999' AND PROCESS # 'FT099' THEN
         //RT*
         //RT*** Dont remember the selection if this is the LOGOFF ***
         //RT*
         //RT           TRANS.LOG.REC = SELECTION+0; TX.ATT = 1; CALL FLTX2('WV','FL.MENU.SELECTIONS', PM.KEY );          WRITEV SELECTION+0 ON FL.MENU.SELECTIONS , PM.KEY , 1
         //RT           CALL FL024 (PROCESS,USERS.WHO.CAN,AUTHORISED);* CHECK AUTHORITY
         //RT           IF NOT(AUTHORISED) THEN
         //RT              GO 20
         //RT           END
         //RT        END
         //RT        PROCESS.TYPE = MENU.POS<SELECTION+1,2>
         //RT        PROCHIST = U.INITS
         //RT        PROCHIST<2> = TODAYS.DATE
         //RT        TRANS.LOG.REC = PROCHIST ; CALL FLTX2('W','FL.MENU.SELECTIONS',PM.KEY)
         //RT        WRITE PROCHIST ON FL.MENU.SELECTIONS,PROCESS.TYPE:"*":PROCESS
         //RT        IF PROCESS.TYPE = 'M' THEN
         //RT********** IF ITS A 'MENU' GO THROUGH THE LOOP *
         //RT           MENU = PROCESS
         //RT           PMENU = INSERT(PMENU,1,0,0,MENU)
         //RT           GO 10
         //RT        END
         //RT        GO 80
         //RT     END
         //RT     IF OPTION1 = '_' THEN
         //RT!       INPUT OPTION2,1:;IF LEN(OPTION2) > 1 THEN PRINT @(-9):' ':;OPTION2=OPTION2[1,1]
         //RT        CALL FL020(1,2,OPTION1,".",INPUT.COMPLETE)
         //RT     END ELSE
         //RT!RT       INPUT OPTION2,2:;IF LEN(OPTION2) > 1 THEN PRINT @(-9):' ':;OPTION2=OPTION2[1,1]
         //RT        CALL FL020(2,3,OPTION1,".",INPUT.COMPLETE)
         //RT        IF LEN(OPTION1) > 2 THEN
         //RT           PRINT @(-9):" "
         //RT           OPTION1 = OPTION1[1,2]
         //RT        END
         //RT     END
         //RT*
         //RT30*
         //RT*
         //RT!RT!     OPTION = OPTION1 : OPTION2
         //RT     OPTION = OPTION1
         //RT     IF OPTION = SKIP THEN
         //RT******* EXIT FROM CURRENT MENU *
         //RT        PROCESS = SKIP
         //RT        PROCESS.TYPE = SKIP
         //RT        PMENU = DELETE(PMENU,1,0,0)
         //RT        MENU = PMENU<1>
         //RT        IF PMENU = '' THEN
         //RT********** SEE IF PREVIOUS MENUS SET *
         //RT           GOSUB 0900 ; RETURN
         //RT        END ELSE
         //RT           GO 10
         //RT        END
         //RT     END
         // Replaced last 120 lines with:
         OPTION = "";
         INPUT_COMPLETE = FALSE;
         PRINT(AT(45, 22) + ".." + AT(45, 22));
         do
         {
            if (INPUT_COMPLETE) break;
            // DJA 27.8.02 Auto-select Touchscreen Tickets if in multiuser mode
            if (U_INITS == "MULTIUSER")
            {
               OPTION = "1";
               INPUT_COMPLETE = TRUE;
            }
            else
            {
               nrf0 = 1;
               nrf1 = 3;
               nrf2 = ".";
               FL020 = new FL020(ref nrf0, ref nrf1, ref OPTION, ref nrf2, ref INPUT_COMPLETE);
            }
         L0050:
            OPTION1 = OPTION.Substring(1, 1);
            OPTION_LENGTH = LEN(OPTION);
            // BEGIN CASE
            // CASE
            if (OPTION_LENGTH == 2 && OPTION1 == "_")
            {
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (OPTION1 == COMMON.UP || OPTION1 == COMMON.DOWN)
            {
               INPUT_COMPLETE = TRUE;
            }// CASE
            else if (OPTION1 == COMMON.LEFT || OPTION1 == COMMON.RIGHT)
            {
               INPUT_COMPLETE = TRUE;
               //           CASE OPTION1 = SKIP AND AUTO.DOT
               //              INPUT.COMPLETE = TRUE
            }// CASE
            else if (OPTION1 == COMMON.BELL)
            {
               INPUT_COMPLETE = TRUE;
               ALL_CLEAR = COMMON.BELL;
               L0900();
               return;
            }// CASE
            else if (OPTION1 == GO_FOR_IT)
            {
               PM_KEY = PORT_NUMBER + TWINKLE + MENU;
               PROCESS = MENU_POS[SELECTION + 1, 3];
               USERS_WHO_CAN = MENU_POS[SELECTION + 1, 2];
               if (PROCESS != "FL999" && PROCESS != "FT099")
               {
                  //** Dont remember the selection if this is the LOGOFF ***
                  TRANS_LOG_REC = SELECTION + 0;
                  TX_ATT = 1;
                  nrf0 = "WV"; nrf1 = "FL.MENU.SELECTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PM_KEY);
                  WRITEV(SELECTION + 0, COMMON.FILES[FL_MENU_SELECTIONS], PM_KEY, 1);
                  FL024 = new FL024(ref PROCESS, ref USERS_WHO_CAN, ref AUTHORISED);
                  // CHECK AUTHORITY
                  if (NOT(AUTHORISED))
                  {
                     goto L20;
                  }
               }
               PROCESS_TYPE = MENU_POS[SELECTION + 1, 2];
               PROCHIST = U_INITS;
               PROCHIST[2] = TODAYS_DATE;
               TRANS_LOG_REC = PROCHIST;
               nrf0 = "W"; nrf1 = "FL.MENU.SELECTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PM_KEY);
               WRITE(PROCHIST, COMMON.FILES[FL_MENU_SELECTIONS], PROCESS_TYPE + "*" + PROCESS);
               if (PROCESS_TYPE == "M")
               {
                  //********* IF ITS A 'MENU' GO THROUGH THE LOOP *
                  MENU = PROCESS;
                  PMENU = INSERT(PMENU, 1, 0, 0, MENU);
                  goto L10;
               }
               goto L80;
            }// CASE
            else if (OPTION1 == COMMON.SKIP)
            {
               if (AUTO_DOT) { INPUT_COMPLETE = TRUE; }
               if (OPTION1 == COMMON.SKIP && AUTO_DOT || INPUT_COMPLETE)
               {
                  //****** EXIT FROM CURRENT MENU *
                  PROCESS = COMMON.SKIP;
                  PROCESS_TYPE = COMMON.SKIP;
                  PMENU = DELETE(PMENU, 1, 0, 0);
                  MENU = PMENU[1];
                  if (PMENU == "")
                  {
                     //********* SEE IF PREVIOUS MENUS SET *
                     L0900();
                     return;
                  }
                  else
                  {
                     goto L10;
                  }
               }
            }
            // END CASE
         } while (true);
         if (!LOCATE(OPTION, QUICK_CALLS, 1, 0, 1, ref FNUM, "AL")) { FNUM = 0; }
         if (FNUM)
         {
            PRINT(AT(45, 22) + "..");
            QPROCESS = QUICK_CALLS[2, FNUM];
            nrf0 = "P";
            FL024 = new FL024(ref QPROCESS, ref nrf0, ref AUTH);
            if (AUTH)
            {
               CallAt_PROCESS = new CallAt_PROCESS(ref QPROCESS);
               RELEASE();
            }
            goto L10;
         }
         //   Validate the input   *
         // BEGIN CASE
         // CASE
         if (OPTION == "?P" || OPTION == "??")
         {
            if (!(READV(ref USR_LEVL, COMMON.FILES[FL_PASSWORDS], U_INITS, 4)))
            {
               USR_LEVL = "C";
            }
            if (OPTION == "?P" && USR_LEVL == "M")
            {
               if (!(READ(ref MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE)))
               {
                  ERROR_NUM = 1;
                  L70();
                  // ERROR
                  ALL_CLEAR = 0;
                  L0900();
                  return;
               }
               nrf0 = "";
               nrf1 = SELECTION + 1;
               FL027 = new FL027(ref nrf0, ref MENU_POS, ref nrf1);
               WRITE(MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE);
            }
            else
            {
               L88();
            }
            goto L10;
         }// CASE
         else if (OPTION == "?F")
         {
            if (!READV(ref QUICKABLE, COMMON.FILES[FL_CONTROL], "FL011.QUICK", 1)) { QUICKABLE = FALSE; }
            if (QUICKABLE)
            {
               PRINT(AT(10, 23) + "Enter Process ");
               INPUTCR(out QPROCESS, 20);
               if (!(QPROCESS == COMMON.ABANDON || QPROCESS == ""))
               {
                  nrf0 = "P";
                  FL024 = new FL024(ref QPROCESS, ref nrf0, ref AUTH);
                  if (AUTH)
                  {
                     CallAt_PROCESS = new CallAt_PROCESS(ref QPROCESS);
                     RELEASE();
                  }
               }
            }
            goto L10;
         }// CASE
         else if (OPTION == "?")
         {
            OPTION_LIST = "";
            OPTION_LIST[-1] = "+" + VM + "Show Hidden Options";
            OPTION_LIST[-1] = "-" + VM + "Hide* Greyed-out Options";
            OPTION_LIST[-1] = "?A" + VM + "Access List - Show/Modify*";
            OPTION_LIST[-1] = "?D" + VM + "Date Option Last Accessed";
            OPTION_LIST[-1] = "?i" + VM + "Insert New Menu Option Before*";
            OPTION_LIST[-1] = "?I" + VM + "Insert New Menu Option After*";
            OPTION_LIST[-1] = "?P" + VM + "Option Information - Show/Modify*";
            OPTION_LIST[-1] = "??" + VM + "Option Information- Show/Delete*";
            WINDOW_REC = 14 + AM + 40 + AM + 19 + AM + 4 + AM + "* Subject to access level";
            OPT_SEL = 1;
            nrf0 = "";
            nrf1 = "L#5";
            nrf2 = 1;
            FL_XTD_WINDOW = new FL_XTD_WINDOW(ref WINDOW_REC, ref OPTION_LIST, ref OPT_SEL, ref nrf0, ref nrf1, ref INTERACT, ref nrf2);
            OPTION = OPTION_LIST[OPT_SEL, 1];
            if (INTERACT != INVALID_DATA)
            {
               //goto L0050;
            }
         }// CASE
         else if (OPTION == "?H" || OPTION == "+")
         {
            L90();
            goto L10;
         }// CASE
         else if (OPTION == "-")
         {
            SHOW_ALL = FALSE;
            WRITEV(SHOW_ALL, COMMON.FILES[FL_PASSWORDS], U_INITS, 5);
            goto L10;
         }// CASE
         else if (OPTION == "?L" || OPTION == "?D")
         {
            L89();
            goto L10;
         }// CASE
         else if (OPTION == "?A" || OPTION == "?X")
         {
            nrf0 = MENU_POS[SELECTION + 1, 2];
            nrf1 = MENU_POS[SELECTION + 1, 3];
            nrf2 = MENU_POS[SELECTION + 1, 1];
            FL032 = new FL032(ref nrf0, ref nrf1, ref nrf2);
            goto L10;
         }// CASE
         else if (OPTION == "?i" || OPTION == "?I")
         {
            if (!(READV(ref USR_LEVL, COMMON.FILES[FL_PASSWORDS], U_INITS, 4)))
            {
               USR_LEVL = "C";
            }
            if (USR_LEVL == "M")
            {
               if (OPTION.Substring(2, 1) == "I") { IPLUS = 2; } else { IPLUS = 1; }
               if (READ(ref MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE))
               {
                  MENU_POS = INSERT(MENU_POS, SELECTION + IPLUS, 0, 0, "");
                  nrf0 = "";
                  nrf1 = SELECTION + IPLUS;
                  FL027 = new FL027(ref nrf0, ref MENU_POS, ref nrf1);
                  WRITE(MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE);
               }
            }
            goto L10;
         }// CASE
         else if (OPTION == "?R" || OPTION == "?Q")
         {
            L200();
            goto L10;
         }// CASE
         else if (OPTION == COMMON.DOWN)
         {
            L50();
            // LOWLIGHT
            SELECTION = SELECTION + 1;
            if (SELECTION > LAST_OPTION) { SELECTION = 1; }
            L40();
            // GET POSITION ON SCREEN
            L60();
            // HIGHLIGHT
            goto L20;
         }// CASE
         else if (OPTION == COMMON.UP)
         {
            L50();
            // LOWLIGHT
            SELECTION = SELECTION - 1;
            if (SELECTION < 1) { SELECTION = LAST_OPTION; }
            L40();
            // GET POSITION ON SCREEN
            L60();
            // HIGHLIGHT
            goto L20;
         }// CASE
         else if (OPTION == COMMON.RIGHT)
         {
            L50();
            // LOWLIGHT
            // BEGIN CASE
            // CASE
            if (LAST_OPTION < 10)
            {
               SELECTION = SELECTION;
            }// CASE
            else if (OTHERWISE)
            {
               // BEGIN CASE
               // CASE
               if (SPC == 2)
               {
                  SELECTION = SELECTION + FIRST_HALF;
                  if (SELECTION > LAST_OPTION)
                  {
                     SELECTION = LAST_OPTION;
                  }
               }// CASE
               else if (OTHERWISE)
               {
                  SELECTION = SELECTION + FIRST_HALF;
                  if (SELECTION > LAST_OPTION)
                  {
                     SELECTION = LAST_OPTION;
                  }
               }
               // END CASE
            }
            // END CASE
            L40();
            // GET POSITION ON SCREEN
            L60();
            // HIGHLIGHT
            goto L20;
         }// CASE
         else if (OPTION == COMMON.LEFT)
         {
            L50();
            // LOWLIGHT
            // BEGIN CASE
            // CASE
            if (LAST_OPTION < 10)
            {
               SELECTION = SELECTION;
            }// CASE
            else if (OTHERWISE)
            {
               // BEGIN CASE
               // CASE
               if (SPC == 2)
               {
                  SELECTION = SELECTION - FIRST_HALF;
                  if (SELECTION < 1)
                  {
                     SELECTION = 1;
                  }
               }// CASE
               else if (OTHERWISE)
               {
                  SELECTION = SELECTION - FIRST_HALF;
                  if (SELECTION < 1)
                  {
                     SELECTION = 1;
                  }
               }
               // END CASE
            }
            // END CASE
            L40();
            // GET POSITION ON SCREEN
            L60();
            // HIGHLIGHT
            goto L20;
         }// CASE
         else if (NOT(NUM(OPTION)))
         {
            ERROR_NUM = 2;
            L70();
            goto L20;
         }// CASE
         else if (OPTION >= 1 && OPTION <= LAST_OPTION)
         {
            PM_KEY = PORT_NUMBER + TWINKLE + MENU;
            PROCESS = MENU_POS[OPTION + 1, 3];
            USERS_WHO_CAN = MENU_POS[OPTION + 1, 2];
            if (PROCESS != "FL999")
            {
               //** Dont remember the selection if this is the LOGOFF ***
               TRANS_LOG_REC = OPTION + 0;
               TX_ATT = 1;
               nrf0 = "WV"; nrf1 = "FL.MENU.SELECTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PM_KEY);
               WRITEV(OPTION + 0, COMMON.FILES[FL_MENU_SELECTIONS], PM_KEY, 1);
               FL024 = new FL024(ref PROCESS, ref USERS_WHO_CAN, ref AUTHORISED);
               // CHECK AUTHORITY
               if (NOT(AUTHORISED))
               {
                  goto L20;
               }
               SELECTION = OPTION;
            }
            PROCESS_TYPE = MENU_POS[OPTION + 1, 2];
            PROCHIST = U_INITS;
            PROCHIST[2] = TODAYS_DATE;
            TRANS_LOG_REC = PROCHIST;
            nrf0 = "W"; nrf1 = "FL.MENU.SELECTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PM_KEY);
            WRITE(PROCHIST, COMMON.FILES[FL_MENU_SELECTIONS], PROCESS_TYPE + "*" + PROCESS);
            if (PROCESS_TYPE == "M")
            {
               MENU = PROCESS;
               PMENU = INSERT(PMENU, 1, 0, 0, MENU);
               goto L10;
            }
         }// CASE
         else if (OTHERWISE)
         {
            ERROR_NUM = 99;
            L70();
            // ERROR
            goto L20;
         }
         // END CASE
         goto L80;
      L80:
         //*********************
         //** Call the routine ***
         MON_REC[MON_MENU] = MENU;
         MON_REC[MON_DESC] = MENU_POS[SELECTION + 1, 1];
         MON_REC[MON_PROG] = PROCESS;
         MON_REC[MON_OPT] = FORMAT(SELECTION, "R%2");
         L85();
         //* PRINT SELECTION MADE    **
         if (PROCESS != "FL999")
         {
            PRINT(AT(8, 22) + SCREEN_BACK + SCREEN_TEXT + MON_REC[MON_DESC] + " Selected             ");
         }
         PROG_MESS = MENU_POS[SELECTION + 1, 4];
         if (PROCESS_TYPE == "P")
         {
            CallAt_PROCESS = new CallAt_PROCESS(ref PROCESS);
            //     CALL FL0001.110(PROGRAM,FUNCTION.KEY.CONVERT)
         }
         else
         {
            FL100_ALL = new FL100_ALL(ref PROCESS);
         }
         // RELEASE ANY LOCKS IN CASES OF ABANDONED PROCESSES
         RELEASE();
         PRINTER_CLOSE();
         goto L10;
      }
      void L40()
      {
         //  Get line number to print please  *
         // BEGIN CASE
         // CASE
         if (DSSC)
         {
            COL = 25;
            ROW = (SELECTION * 2) + (START_LINE - 2);
         }// CASE
         else if (DSDC)
         {
            FIRST_HALF = INT((LAST_OPTION / 2) + .5M);
            // BEGIN CASE
            // CASE
            if (SELECTION >= 1 && SELECTION <= FIRST_HALF)
            {
               COL = 5;
               ROW = (SELECTION * 2) + (START_LINE - 2);
            }// CASE
            else if (OTHERWISE)
            {
               // SECOND SIDE
               COL = 45;
               ROW = ((SELECTION - FIRST_HALF) * 2) + (START_LINE - 2);
            }
            // END CASE
         }// CASE
         else if (OTHERWISE)
         {
            FIRST_HALF = INT((LAST_OPTION / 2) + .5M);
            // BEGIN CASE
            // CASE
            if (SELECTION >= 1 && SELECTION <= FIRST_HALF)
            {
               COL = 5;
               ROW = SELECTION + (START_LINE - 1);
            }// CASE
            else if (OTHERWISE)
            {
               COL = 45;
               ROW = (SELECTION - FIRST_HALF) + (START_LINE - 1);
            }
            // END CASE
         }
         // END CASE
         return;
      }
      void L50()
      {
         //  Lowlight   *
         //!**!!     PRINT@(COL-4,ROW):MENU.NOS:
         PRINT(AT(COL - 4, ROW) + NRM_VID + SPACE_VALUE + MENU_NOS);
         SELECTION = "0" + SELECTION;
         //     PRINT @(COL-3,ROW):SELECTION'R#2':MENU.TEXT:
         PRINT(AT(COL - 3, ROW) + FORMAT(SELECTION, "R#2") + NRM_VID + SPACE_VALUE);
         //!**!!     PRINT @(COL,ROW):MENU.POS<SELECTION+1,1>: '   ': NRM.VID : SPACE.VALUE
         PRINTCR(AT(COL, ROW) + MENU_POS[SELECTION + 1, 1] + NRM_VID + SPACE_VALUE + " ");
         return;
      }
      void L60()
      {
         //*************
         //  Highlight   *
         TLEN = LEN(MENU_POS[SELECTION + 1, 1]);
         //!**!!     PRINT@(COL+TLEN+1,ROW):NRM.VID : SPACE.VALUE:
         PRINT(AT(COL + TLEN, ROW) + NRM_VID + SPACE_VALUE);
         PRINT(AT(COL - 4, ROW) + REV_VID + SPACE_VALUE + " ");
         SELECTION = "0" + SELECTION;
         //!**!!     PRINT @(COL-3,ROW):SELECTION'R#2':' ':MENU.POS<SELECTION+1,1>:' ':NRM.VID : SPACE.VALUE:
         PRINT(AT(COL - 3, ROW) + FORMAT(SELECTION, "R#2") + " " + MENU_POS[SELECTION + 1, 1] + NRM_VID + SPACE_VALUE);
         return;
      }
      void L70()
      {
         //***************************
         //   Error print subroutine   *
         nrf0 = INIT; FL006 = new FL006(ref PROGRAM, ref ERROR_NUM, ref nrf0);
         // PRINT ERROR
         return;
      }
      void L85()
      {
         //*********************
         //** Update Monitor   ***
         MATWRITE(MON_REC, COMMON.FILES[FL_MONITOR], PORT_NUMBER);
         if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_MONITOR], PORT_NUMBER)) { TRANS_LOG_REC = ""; nrf0 = "W"; nrf1 = "FL.MONITOR"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PORT_NUMBER); }
         return;
      }
      void L88()
      {
         // PRINT PROGRAM NAMES
         for (SELECTION = 1; SELECTION <= LAST_OPTION; SELECTION += 1)
         {
            //       READV LAST.DATE  FROM FL.MENU.SELECTIONS,MENU:SELECTION,2 ELSE LAST.DATE = ""
            TEXXT = MENU_POS[SELECTION + 1, 2] + " - " + MENU_POS[SELECTION + 1, 3];
            PSEL = (100 + (SELECTION)).Substring(2, 2);
            L40();
            // GET POSITION ON SCREEN
            if (LAST_OPTION > 18)
            {
               PRINT(AT(COL + 10, ROW) + NRM_VID + SPACE_VALUE + FORMAT(TEXXT, "R#19"));
            }
            else
            {
               PRINT(AT(COL - 1, ROW + 1) + NRM_VID + SPACE_VALUE + TEXXT);
            }
         }
         PRINT(AT(10, 22) + COMMON.EOL);
         PRINT(AT(40, 22) + NRM_VID + SPACE_VALUE);
         PRINT(AT(10, 22) + DIM_VID + SPACE_VALUE + "Enter D# to delete or Press Return " + NRM_VID + SPACE_VALUE);
         INPUTCR(out WAIT, 4);
         if (MATCH(WAIT, "'D'0N"))
         {
            L110();
         }
         return;
      }
      void L89()
      {
         // PRINT LAST USED DETAILS
         for (SELECTION = 1; SELECTION <= LAST_OPTION; SELECTION += 1)
         {
            //READ PROCHIST FROM FL.MENU.SELECTIONS,MENU:SELECTION ELSE PROCHIST = ""
            PROCESS_TYPE = MENU_POS[SELECTION + 1, 2];
            PROCESS = MENU_POS[SELECTION + 1, 3];
            if (!READ(ref PROCHIST, COMMON.FILES[FL_MENU_SELECTIONS], PROCESS_TYPE + "*" + PROCESS)) { PROCHIST = ""; }
            TEXXT = "Last used on " + OCONV(PROCHIST[2], COMMON.D2) + " by " + PROCHIST[1];
            PSEL = (100 + (SELECTION)).Substring(2, 2);
            L40();
            // GET POSITION ON SCREEN
            if (PROCHIST != "")
            {
               if (LAST_OPTION > 18)
               {
                  PRINTCR(AT(COL + 10, ROW) + NRM_VID + SPACE_VALUE + FORMAT(TEXXT, "R#17"));
               }
               else
               {
                  PRINT(AT(COL - 1, ROW + 1) + NRM_VID + SPACE_VALUE + TEXXT);
               }
            }
         }
         PRINT(AT(10, 22) + COMMON.EOL);
         PRINT(AT(30, 22) + NRM_VID + SPACE_VALUE);
         PRINT(AT(10, 22) + DIM_VID + SPACE_VALUE + "Press <RETURN> ");
         INPUTCR(out WAIT, 1);
         return;
      }
      void L90()
      {
         // display hidden
         if (!(READ(ref MENU_POS, COMMON.FILES[FL_MENUS], SCREEN_CODE)))
         {
            ERROR_NUM = 1;
            L70();
            // ERROR
            ALL_CLEAR = 0;
            L0900();
            return;
         }
         SHOW_ALL = TRUE;
         WRITEV(SHOW_ALL, COMMON.FILES[FL_PASSWORDS], U_INITS, 5);
         FL011_2 = new FL011_2(ref MENU_POS, ref SHOW_ALL);
         LAST_OPTION = DCOUNT(MENU_POS, AM);
         return;
         //****
      }
      void L0100()
      {
         // DISPLAY MENU SCREEN
         //****
         PRINT(AT(0, 0) + SCREEN_BACK + COMMON.WASH + "menu");
         //*
         // Print Normal Video at end of screen (Pick Terminals need this)
         //*
         for (SROW = 0; SROW <= 2; SROW += 1)
         {
            PRINTCR(AT(0, SROW) + NRM_VID + SPACE_VALUE + AT(SCREEN_WIDTH - 1, SROW) + NRM_VID + SPACE_VALUE);
            PRINTCR(AT(1, SROW) + MENU_HEAD_BACK + SPACE(SCREEN_WIDTH - 1) + NRM_VID + SPACE_VALUE);
         }
         PRINT(AT(1, 0) + MENU_HEAD_BACK + "(" + PMENU[1] + ")");
         //     PRINT @(2/DIVISOR+1,0):MENU.HEAD.BACK: '(': PMENU<1>: ')':
         PRINT(" " + CENTRE_DESC);
         PRINT(AT(67, 0) + OCONV(TODAYS_DATE, "D"));
         //*
         //* Print Row 1
         //*
         TEXT_TO_DISPLAY = MENU_POS[1];
         //     COL.NUMBER = INT((SCREEN.WIDTH - LEN(TEXT.TO.DISPLAY)*MULTIPLIER) / 2 / DIVISOR)
         COL_NUMBER = INT((SCREEN_WIDTH - LEN(TEXT_TO_DISPLAY)) / 2);
         PRINTCR(AT(COL_NUMBER, 1) + TEXT_TO_DISPLAY);
         //*
         //* Print Row 2
         //*
         PRINT(AT(3, 2) + "User : " + TILL_NUMBER + " " + U_INITS + AT(73, 2) + OCONV(TIME(), "MT"));
         PRINT(AT(0, 3) + NRM_VID + SPACE_VALUE);
         //*****
         return;
      }
      void L0900()
      {
         //************
         //** Select Nothing ***
         MON_REC[MON_MENU] = "None";
         MON_REC[MON_DESC] = "Process at TCL";
         MON_REC[MON_PROG] = "";
         MON_REC[MON_OPT] = FORMAT(SELECTION, "R%2");
         L85();
         return;
         //**
      }
      void L110()
      {
         // Remove the option
         DELOPT = WAIT.Substring(2, 2) + 1;
         if (DELOPT - 1 < 1 || DELOPT > DCOUNT(MENU_POS, AM))
         {
            ERROR_NUM = 4;
            L70();
            // ERROR
         }
         else
         {
            PROCKEY = "D*" + MENU_POS[DELOPT, 3];
            ACTIONREC = MENU;
            ACTIONREC[4] = DELOPT;
            nrf0 = "";
            FL031 = new FL031(ref PROCKEY, ref ACTIONREC, ref INTERACT, ref nrf0);
         }
         return;
      }
      void L200()
      {
         // DISPLAY REPORT LINE
         for (SELECTION = 1; SELECTION <= LAST_OPTION; SELECTION += 1)
         {
            if (MENU_POS[SELECTION + 1, 2] == "Q")
            {
               REPORT_NAME = FIELD(MENU_POS[SELECTION + 1, 3], " ", 2);
               if (!(MATREAD(ref REPORTS_REC, COMMON.FILES[FL_REPORTS], REPORT_NAME)))
               {
                  MAT(ref REPORTS_REC, INIT);
                  REPORTS_REC[REPORT_STATEMENT] = "Proc";
               }
               TEXXT = FORMAT(REPORTS_REC[REPORT_STATEMENT], "L#25");
            }
            else
            {
               if (MENU_POS[SELECTION + 1, 2] == "P")
               {
                  TEXXT = "Program";
               }
               else
               {
                  TEXXT = "Menu";
               }
            }
            PSEL = (100 + (SELECTION)).Substring(2, 2);
            L40();
            // GET POSITION ON SCREEN
            if (LAST_OPTION > 18)
            {
               PRINT(AT(COL + 10, ROW) + NRM_VID + SPACE_VALUE + FORMAT(TEXXT, "R#19"));
            }
            else
            {
               PRINT(AT(COL - 1, ROW + 1) + NRM_VID + SPACE_VALUE + TEXXT);
            }
         }
         PRINT(AT(10, 22) + COMMON.EOL);
         PRINT(AT(40, 22) + NRM_VID + SPACE_VALUE);
         PRINT(AT(10, 22) + DIM_VID + SPACE_VALUE + "Press Return " + NRM_VID + SPACE_VALUE);
         INPUTCR(out WAIT, 4);
         return;
      }
   }
}
