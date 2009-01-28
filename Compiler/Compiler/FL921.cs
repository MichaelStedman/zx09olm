//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL921 : UvBase
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
      readonly UvVar DISPLAY_WINDOW = 0;
      readonly UvVar INPUT_ALL = 1;
      readonly UvVar INPUT_SINGLE = 2;
      readonly UvVar LOAD_CODES = 3;
      readonly UvVar REDISPLAY = 4;
      readonly UvVar INSERT_SINGLE = 5;
      readonly UvVar DELETE_SINGLE = 6;
      readonly UvVar SCROLL = 7;
      readonly UvVar SCREENS = 8;
      readonly UvVar FL_SPORTS = 23;
      readonly UvVar SPORTS_DESC = 1;
      readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
      readonly UvVar SPORTS_CODE1 = 3;
      readonly UvVar SPORTS_CODE2 = 4;
      readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
      readonly UvVar SPORTS_TYPE = 6;
      readonly UvVar SPORTS_BOOK_OR_CAS = 7;
      readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
      readonly UvVar SPORTS_RESTRICTION_CODE = 9;
      readonly UvVar SPORTS_PERSON_BOOKING = 10;
      readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
      readonly UvVar SPORTS_SETUP_TIME = 12;
      readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
      readonly UvVar SPORTS_PLAYERS = 14;
      readonly UvVar SPORTS_ADMINISTRATOR = 15;
      readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
      readonly UvVar SPORTS_VISIBILITY = 17;
      readonly UvVar SPORTS_SUB_LIST = 18;
      readonly UvVar SPORTS_TOP_LEVEL = 19;
      readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
      readonly UvVar FL_TICKET_CONTROL = 19;
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
      readonly UvVar CAT_LEVEL_SUB_LIST = 1;
      readonly UvVar CAT_LEVEL_CAT_OR_RESOURCE_LIST = 2;
      readonly UvVar CAT_LEVEL_TOP_LEVEL = 3;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] SPORTS_REC;
      UvVar[] TICK_CONTROL_REC;
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] PASS_REC = new UvVar[15];
      UvVar[] CAT_LEVEL_REC = new UvVar[5];
      UvVar[] TEMP_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar ZZZ_STATUS = "";
      UvVar NEW_RESOURCE = "";
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SCREEN_WIDTH = "";
      UvVar GO_BACK = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar INTERACT = "";
      UvVar START_FIELD = "";
      UvVar END_FIELD = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar PROCESS_LOCKED = "";
      UvVar JUST = "";
      UvVar FL_CATEGORY_LEVELS = "";
      UvVar FL_USER_PROGS = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar LINE = "";
      UvVar RESPONSIBLE_USER_FIELD_NO = "";
      UvVar TOP_LEVEL_FIELD_NO = "";
      UvVar FIRST_RESOURCE_FIELD_NO = "";
      UvVar SUBSIDIARY1_FIELD_NO = "";
      UvVar SUBSIDIARY2_FIELD_NO = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar ST_ATT = "";
      UvVar FIELD_DATA = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_JUST = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      UvVar RESOURCE_ID = "";
      UvVar TC_ID = "";
      FLTX2 FLTX2;
      UvVar ACTION = "";
      UvVar OLD_SUB_LIST = "";
      UvVar UV_CALL = "";
      FL932 FL932;
      UvVar REDISPLAY_LINE = "";
      UvVar CENTRE_CODE = "";
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      FL006 FL006;
      UvVar OK_TO_FILE = "";
      UvVar ST_DESC = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_LENGTH = "";
      UvVar ST_MANDATORY = "";
      UvVar ST_CONVERSION = "";
      UvVar PROMPT_NO = "";
      FL000_10 FL000_10;
      UvVar PRINT_LINE = "";
      UvVar ST_ATT_MV = "";
      UvVar I = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar SUB_REC = "";
      UvVar SP_CODES = "";
      UvVar RESOURCES_ONLY = "";
      FL930 FL930;
      CallAt_PROCESS_LOCKED CallAt_PROCESS_LOCKED;
      UvVar TEXT_ID = "";
      UvVar SPORT_VISIBILITY = "";
      FL156_HELP FL156_HELP;
      UvVar RETURNED_ANS = "";
      UvVar SPARE1 = "";
      UvVar OLD_FIELD_NO = "";
      UvVar OLD_FIELD_DATA = "";
      FL931 FL931;
      UvVar TEST_REC = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL921(ref UvVar[] SPORTS_REC, ref UvVar NEW_RESOURCE, ref UvVar[] TICK_CONTROL_REC)
      {
         this.SPORTS_REC = SPORTS_REC;
         this.NEW_RESOURCE = NEW_RESOURCE;
         this.TICK_CONTROL_REC = TICK_CONTROL_REC;
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
         /*     RESOURCE & CATEGORY MAINTENANCE PAGE 1 */
         PROMPT("");
         START_FIELD = "";
         END_FIELD = "";
         PROGRAM = "FL921";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
         JUST = "";
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SPORTS
         #region INCLUDE FL.FILES FL.SPORTS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.SPORTS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS.VAR

         /*  Introduced for Warrington: */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.CONTROL

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.PASSWORDS

         #endregion
         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS
         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.EQU
         if (!OPEN("FL.CATEGORY.LEVELS", out FL_CATEGORY_LEVELS)) { STOP("201", "FL.CATEGORY.LEVELS"); }

         #endregion

         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.VAR

         #endregion

         #endregion
         if (!OPEN("FL.USER.PROGS", out FL_USER_PROGS)) { STOP("201", "FL.USER.PROGS"); }
         MAT(ref TEMP_REC, "");
         /* ************************************ */
         /*   GET SCREEN DEFINITION ITEM       * */
         /* ************************************ */
         if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE)))
         {
            PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
            STOP();
         }
         /* ********************************** */
         /*   EXTRACT DATA INPUT FIELDS      * */
         /* ********************************** */
         MAX_FIELDS = 0;
         SCREEN_LINES = 0;
         FIRST_FIELD = 0;
         DATA_FIELDS = "";
         do
         {
            LINE = SC_POS[SCREEN_LINES + 1];
            if (LINE == "") break;
            if (LINE[1, 4] != "")
            {
               MAX_FIELDS = MAX_FIELDS + 1;
               if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0)
               {
                  FIRST_FIELD = MAX_FIELDS;
               }
               DATA_FIELDS[MAX_FIELDS] = LINE;
            }
            SCREEN_LINES = SCREEN_LINES + 1;
         } while (true);
         RESPONSIBLE_USER_FIELD_NO = 6;
         TOP_LEVEL_FIELD_NO = 4;
         FIRST_RESOURCE_FIELD_NO = 6;
         SUBSIDIARY1_FIELD_NO = 14;
         SUBSIDIARY2_FIELD_NO = 15;
         /* ************************************ */
         /*   MAIN PROCESSING SECTION          * */
         /* ************************************ */
         do
         {
            INTERACT = VALID_DATA;
            L0100();
            AMENDING = FALSE;
            if (PROG_MESS[2] != "")
            {
               MAIN_KEY = PROG_MESS[2];
               AMENDING = TRUE;
               L8000();
               /*  Build temp.rec */
               L0300();
               /*  Display data */
            }
            else
            {
               MAIN_KEY = "";
               MAT(ref TEMP_REC, "");
            }
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     if (INTERACT != LIMIT) { L0060(); }
                     if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
                     // BEGIN CASE
                     // CASE
                     if (ST_ATT == 0)
                     {
                        FIELD_NO = FIELD_NO + 1;
                     }// CASE
                     else if (FIELD_NO >= FIRST_RESOURCE_FIELD_NO - 1 && TEMP_REC[2] == "C")
                     {
                        START_FIELD = FIRST_RESOURCE_FIELD_NO;
                        END_FIELD = MAX_FIELDS;
                        L6000();
                        /*  Remove dots */
                        FIELD_NO = MAX_FIELDS;
                        INTERACT = LIMIT;
                     }// CASE
                     else if (FIELD_NO == TOP_LEVEL_FIELD_NO - 1 && TEMP_REC[2] == "R" && AMENDING == FALSE)
                     {
                        /*  Skip top level indicator for resources */
                        FIELD_NO = FIELD_NO + 1;
                        FIELD_DATA = DATA_FIELDS[FIELD_NO];
                        L0200();
                        PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
                        FIELD_NO = FIELD_NO + 1;
                        /* !                 CASE AMENDING = FALSE AND INTERACT = VALID.DATA AND TEMP.REC(ST.ATT) = "" AND (ST.ATT >= 22 AND ST.ATT <= 24) */
                        /* !* */
                        /* !* Last comment entered.  Skip forward to Analysis section */
                        /* !* */
                        /* !                    START.FIELD.NO = FIELD.NO + 1 */
                        /* !                    FOR FIELD.NO = START.FIELD.NO TO 28 */
                        /* !                       FIELD.DATA = DATA.FIELDS<FIELD.NO> */
                        /* !                       GOSUB 0200 */
                        /* !                       PRINT @(ST.COL,ST.ROW): "" ST.JUST : */
                        /* !                    NEXT FIELD.NO */
                        /* !                    FIELD.NO = 29 */
                     }// CASE
                     else if (OTHERWISE)
                     {
                        FIELD_NO = FIELD_NO + 1;
                     }
                     // END CASE
                  } while (true);
                  // BEGIN CASE
                  // CASE
                  if (INTERACT == EXIT)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == INVALID_DATA)
                  {
                     NULL();
                  }// CASE
                  else if (INTERACT == BACKUP && FIELD_NO == TOP_LEVEL_FIELD_NO + 1 && TEMP_REC[2] == "R")
                  {
                     FIELD_NO = FIELD_NO - 2;
                  }// CASE
                  else if (INTERACT == BACKUP && FIELD_NO > 1)
                  {
                     FIELD_NO = FIELD_NO - 1;
                  }// CASE
                  else if (FIELD_NO == MAX_FIELDS)
                  {
                     L0050();
                  }// CASE
                  else if (INTERACT == LIMIT || AMENDING)
                  {
                     L0050();
                  }// CASE
                  else if (INTERACT != INVALID_DATA)
                  {
                     FIELD_NO = FIELD_NO + 1;
                  }
                  // END CASE
                  if (INTERACT == EXIT || INTERACT == FINISH) break;
               } while (true);
               if (MAIN_KEY != "" && INTERACT != EXIT)
               {
                  /*  Transfer data out of TEMP.REC */
                  L9000();
               }
            }
            if (INTERACT == EXIT || INTERACT == FINISH) break;
         } while (true);
         return;
         /* ************************************* */
      }
      void L0050()
      {
         /*   ENTER AMENDMENT FIELD NUMBER  * */
         /* ************************************* */
         AMENDING = TRUE;
         INTERACT = INVALID_DATA;
         do
         {
            INPUT_LINE = "   Enter Field no, Page no, 'D'elete or 'F' to finish ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 3);
            if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
            PRINT(AT(2, 21) + SPACE(70));
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               PROG_MESS[1] = COMMON.ABANDON;
            }// CASE
            else if (ANS == "")
            {
               /*  Next page */
               L0055();
               if (INTERACT == FINISH)
               {
                  if ((TEMP_REC[2] == "R" && TEMP_REC[15] != "N") || TEMP_REC[2] == "")
                  {
                     PROG_MESS[1] = 3;
                  }
                  else
                  {
                     PROG_MESS[1] = 2;
                  }
               }
            }// CASE
            else if (ANS == "D")
            {
               INTERACT = INVALID_DATA;
               do
               {
                  INPUT_LINE = "    Are you sure you wish to delete this entry? (Y/N) ";
                  PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
                  PRINT(AT(2, 21) + INPUT_LINE);
                  INPUT(out ANS, 4);
                  PRINT(AT(2, 21) + SPACE(74));
                  // BEGIN CASE
                  // CASE
                  if (ANS == COMMON.ABANDON)
                  {
                     INTERACT = EXIT;
                  }// CASE
                  else if (ANS == "N")
                  {
                     INTERACT = VALID_DATA;
                  }// CASE
                  else if (ANS == "Y")
                  {
                     RESOURCE_ID = PROG_MESS[2];
                     DELETE(COMMON.FILES[FL_SPORTS], RESOURCE_ID);
                     TC_ID = "B*" + RESOURCE_ID + ".TEXT";
                     DELETE(COMMON.FILES[FL_TICKET_CONTROL], TC_ID);
                     nrf0 = "D";
                     nrf1 = "FL.SPORTS";
                     FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref RESOURCE_ID);
                     nrf0 = "D";
                     nrf1 = "FL.TICKET.CONTROL";
                     FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TC_ID);
                     ACTION = DELETE_SINGLE;
                     /*  SPORTS.REC not used for deletions - contents don't matter */
                     OLD_SUB_LIST = "";
                     /*  Not used for deletions */
                     UV_CALL = TRUE;
                     FL932 = new FL932(ref ACTION, ref RESOURCE_ID, ref SPORTS_REC, ref OLD_SUB_LIST, ref REDISPLAY_LINE, ref UV_CALL, ref CENTRE_CODE, ref ERROR_STATUS, ref MESSAGE);
                     INTERACT = FINISH;
                     PROG_MESS[1] = COMMON.ABANDON;
                  }// CASE
                  else if (OTHERWISE)
                  {
                     INTERACT = INVALID_DATA;
                  }
                  // END CASE
                  if (!(INTERACT == INVALID_DATA)) break;
               } while (true);
               if (INTERACT == FINISH)
               {
                  /*  Deletion done */
                  INTERACT = EXIT;
               }
               else
               {
                  /*  Reprompt for action */
                  INTERACT = INVALID_DATA;
               }
            }// CASE
            else if (ANS == "F")
            {
               L0055();
               if (INTERACT == FINISH) { PROG_MESS[1] = ""; }
            }// CASE
            else if (ANS == "P2" && (TEMP_REC[2] == "R" || TEMP_REC[2] == "") && TEMP_REC[15] != "N")
            {
               nrf0 = 50;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == "P3" && TEMP_REC[2] == "C")
            {
               nrf0 = 51;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p")
            {
               L0055();
               if (INTERACT == FINISH) { PROG_MESS[1] = ANS.Substring(2, 1); }
            }// CASE
            else if (MATCH(ANS, "0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1)
            {
               FIELD_NO = ANS + FIRST_FIELD - 1;
               // BEGIN CASE
               // CASE
               if (FIELD_NO >= FIRST_RESOURCE_FIELD_NO && TEMP_REC[2] == "C")
               {
                  nrf0 = 60;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (FIELD_NO == TOP_LEVEL_FIELD_NO && TEMP_REC[2] != "C")
               {
                  nrf0 = 61;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }// CASE
               else if (OTHERWISE)
               {
                  INTERACT = VALID_DATA;
               }
               // END CASE
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* ******************************************** */
      }
      void L0055()
      {
         /*  Validate user can leave page 1        * */
         /* ******************************************** */
         /*  Validate that key fields are present before allowing the user to file */
         OK_TO_FILE = TRUE;
         /* !     BEGIN CASE */
         /* !* Start date */
         /* !     CASE TEMP.REC(2) = "" */
         /* !        OK.TO.FILE = FALSE */
         /* !        CALL FL006(PROGRAM,XXX,INIT) */
         /* !     END CASE */
         if (OK_TO_FILE)
         {
            INTERACT = FINISH;
         }
         return;
         /* ******************************** */
      }
      void L0060()
      {
         /*   DATA ENTRY ROUTINE       * */
         /* ******************************** */
         INTERACT = INVALID_DATA;
         FIELD_DATA = DATA_FIELDS[FIELD_NO];
         L0200();
         /* !!* */
         /* !!* Bypass blank booking levels */
         /* !!* */
         /* !!     IF FIELD.NO >= 8 AND FIELD.NO <= 15 AND TRIM(ST.DESC) = "" THEN */
         /* !!        PRINT @(ST.COL,ST.ROW):"" ST.JUST: */
         /* !!        INTERACT = VALID.DATA */
         /* !!     END ELSE */
         if (ST_ATT == 0)
         {
            VALUE = MAIN_KEY;
         }
         else
         {
            VALUE = TEMP_REC[ST_ATT][1, ST_MV];
         }
         PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(ST_COL, ST_ROW));
         PRINT(STR(".", ST_LENGTH));
         PRINT(AT(ST_COL, ST_ROW));
         INPUT(out ANS, ST_LENGTH);
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.ABANDON)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }// CASE
         else if (ANS == GO_BACK)
         {
            INTERACT = BACKUP;
            /*  Deal with default values for certain fields here */
            /* !!        CASE AMENDING = FALSE AND ST.ATT = 13 AND ANS = "" AND VALUE = "" */
            /* !!           VALUE = TEMP.REC(3) */
            /* !!           INTERACT = VALID.DATA */
            /* !!        CASE ST.ATT = 27 AND ANS = "" AND VALUE = "" */
            /* !!           VALUE = CENTRE ; * From COMMON */
            /* !!           INTERACT = VALID.DATA */
         }// CASE
         else if (ANS == COMMON.CLR && ST_MANDATORY == "")
         {
            VALUE = "";
            ANS = "";
            INTERACT = VALID_DATA;
         }// CASE
         else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "")
         {
            nrf0 = 5;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }// CASE
         else if (ANS == "" && VALUE != "")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1)
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            #region ON FIELD_NO GOSUB ...
            switch ((int)FIELD_NO)
            {
               case 1: L1000(); break;
               case 2: L1100(); break;
               case 3: L1200(); break;
               case 4: L1250(); break;
               case 5: L1300(); break;
               case 6: L1400(); break;
               case 7: L1500(); break;
               case 8: L1600(); break;
               case 9: L1700(); break;
               case 10: L1800(); break;
               case 11: L1900(); break;
               case 12: L2000(); break;
               case 13: L2100(); break;
               case 14: L2200(); break;
               case 15: L2200(); break;
               case 16: L2300(); break;
            }
            #endregion
            if (INTERACT == VALID_DATA)
            {
               if (ST_CONVERSION != "")
               {
                  VALUE = ICONV(ANS, ST_CONVERSION);
               }
               else
               {
                  VALUE = ANS;
               }
            }
         }
         // END CASE
         PRINT(AT(ST_COL - 1, ST_ROW));
         if (ST_CONVERSION != "")
         {
            PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
         }
         else
         {
            PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
         }
         if (ST_ATT == 0)
         {
            MAIN_KEY = VALUE;
         }
         else
         {
            TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
         }
         /* !!     END */
         return;
         /* ******************************* */
      }
      void L0100()
      {
         /*   DISPLAY SCREEN FORMAT  * */
         /* ******************************** */
         PROMPT_NO = 1;
         DOTS_ONLY = 0;
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         for (PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1)
         {
            PRINT(AT(79, PRINT_LINE) + NRM_VID);
            PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
         }
         return;
         /* ********************************* */
      }
      void L0200()
      {
         /*   EXTRACT FIELD DATA      * */
         /* ********************************* */
         ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
         ST_ROW = FIELD_DATA[1, 2];
         ST_DESC = FIELD_DATA[1, 3];
         ST_LENGTH = FIELD_DATA[1, 4];
         ST_ATT_MV = FIELD_DATA[1, 5];
         ST_ATT = FIELD(ST_ATT_MV, ",", 1);
         ST_MV = FIELD(ST_ATT_MV, ",", 2);
         ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
         ST_CONVERSION = FIELD_DATA[1, 9];
         ST_MANDATORY = FIELD_DATA[1, 10];
         return;
         /* ********************************* */
      }
      void L0300()
      {
         /*   DISPLAY ITEM CONTENTS */
         /* ********************************* */
         for (I = 1; I <= MAX_FIELDS; I += 1)
         {
            FIELD_DATA = DATA_FIELDS[I];
            DISP_ATT_MV = FIELD_DATA[1, 5];
            DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
            DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
            DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
            DISP_ROW = FIELD_DATA[1, 2];
            PRINT(AT(DISP_COL - 2, DISP_ROW) + SCREEN_BACK + SCREEN_DATA);
            PRINT(AT(DISP_COL, DISP_ROW));
            DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4] + 1;
            DISP_CONVERSION = FIELD_DATA[1, 9];
            // BEGIN CASE
            // CASE
            if (DISP_ATT == 0)
            {
               PRINT(FORMAT(MAIN_KEY, DISP_JUST));
            }// CASE
            else if (DISP_CONVERSION != "")
            {
               PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
               /*  Show administrators name */
               if (I == RESPONSIBLE_USER_FIELD_NO)
               {
                  if (MATREAD(ref PASS_REC, COMMON.FILES[FL_PASSWORDS], TEMP_REC[DISP_ATT]))
                  {
                     PRINT(AT(DISP_COL + 10, DISP_ROW) + FORMAT(PASS_REC[PASS_NAME], "L#20"));
                  }
               }
               if (I == SUBSIDIARY1_FIELD_NO || I == SUBSIDIARY2_FIELD_NO)
               {
                  if (!READ(ref SUB_REC, COMMON.FILES[FL_SPORTS], TEMP_REC[DISP_ATT][1, DISP_MV])) { SUB_REC = ""; }
                  PRINT(AT(DISP_COL + 10, DISP_ROW) + FORMAT(SUB_REC[1], "L#30"));
               }
            }// CASE
            else if (OTHERWISE)
            {
               PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
            }
            // END CASE
         }
         return;
         /* ************************ */
         /*   VALIDATION ROUTINES  * */
         /* ************************ */
      }
      void L1000()
      {
         /*   Resource Code Validation Routine */
         INTERACT = VALID_DATA;
         ANS = TRIM(ANS);
         /*  DJA 30.4.02 Prevent trailing/leading spaces */
         // BEGIN CASE
         // CASE
         if (INDEX(ANS, "*", 1))
         {
            nrf0 = 24;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
            /*  Scan for required course if the 'help' key is entered */
         }// CASE
         else if (ANS == COMMON.HELP && AMENDING == FALSE)
         {
            SP_CODES = "";
            RESOURCES_ONLY = FALSE;
            nrf0 = REDISPLAY;
            FL930 = new FL930(ref RESOURCE_ID, ref INTERACT, ref nrf0, ref SP_CODES, ref RESOURCES_ONLY);
            /*  Refresh screen */
            L0100();
            if (INTERACT != EXIT)
            {
               ANS = RESOURCE_ID;
               MAIN_KEY = ANS;
               nrf0 = COMMON.FILES[FL_SPORTS];
               nrf1 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref nrf0, ref MAIN_KEY, ref nrf1);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 28;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  VALUE = "";
                  MAIN_KEY = "";
               }
               else
               {
                  PROG_MESS[2] = RESOURCE_ID;
                  if (MATREADU(ref SPORTS_REC, COMMON.FILES[FL_SPORTS], MAIN_KEY))
                  {
                     if (SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] == "") { SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] = "N"; }
                     NEW_RESOURCE = FALSE;
                     /*  DJA 02.01.01 */
                     L8000();
                     /*  Build Temp.Rec */
                     AMENDING = TRUE;
                     L0300();
                  }
                  else
                  {
                     MAT(ref TEMP_REC, "");
                     MAT(ref SPORTS_REC, "");
                     SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] = "N";
                     NEW_RESOURCE = TRUE;
                     AMENDING = FALSE;
                  }
               }
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
         }// CASE
         else if (ANS != "" && LEN(ANS) != 3)
         {
            nrf0 = 65;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
            AMENDING = TRUE;
            if (ST_CONVERSION != "")
            {
               VALUE = ICONV(ANS, ST_CONVERSION);
            }
            else
            {
               VALUE = ANS;
            }
            if (VALUE != "")
            {
               MAIN_KEY = VALUE;
               nrf0 = COMMON.FILES[FL_SPORTS];
               nrf1 = ZZZ_STATUS;
               CallAt_PROCESS_LOCKED = new CallAt_PROCESS_LOCKED(ref PROCESS_LOCKED, ref nrf0, ref MAIN_KEY, ref nrf1);
               if (ZZZ_STATUS == TRUE)
               {
                  nrf0 = 28;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
                  ANS = "";
                  VALUE = "";
                  MAIN_KEY = "";
               }
               else
               {
                  PROG_MESS[2] = MAIN_KEY;
                  if (MATREADU(ref SPORTS_REC, COMMON.FILES[FL_SPORTS], MAIN_KEY))
                  {
                     if (SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] == "") { SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] = "N"; }
                     L8000();
                     /*  Build Temp.Rec */
                     AMENDING = TRUE;
                  }
                  else
                  {
                     MAT(ref SPORTS_REC, "");
                     SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] = "N";
                     AMENDING = FALSE;
                     MAT(ref TEMP_REC, "");
                     NEW_RESOURCE = TRUE;
                  }
                  if (INTERACT != INVALID_DATA)
                  {
                     if (AMENDING) { L0300(); }
                     INTERACT = VALID_DATA;
                  }
                  /*  Resource was locked */
               }
            }
            else
            {
               nrf0 = 7;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               PRINT(SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
               PRINT(AT(0, 23) + FORMAT("", JUST));
            }
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }
         // END CASE
         if (INTERACT == VALID_DATA)
         {
            TEXT_ID = "B*" + MAIN_KEY + ".TEXT";
            if (!(MATREADU(ref TICK_CONTROL_REC, COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID)))
            {
               MAT(ref TICK_CONTROL_REC, "");
            }
            /*  Assign default values for new attributes */
            if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "")
            {
               SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R";
            }
            if (SPORTS_REC[SPORTS_VISIBILITY] == "")
            {
               SPORT_VISIBILITY = "B";
            }
         }
         return;
      }
      void L1100()
      {
         /*   DESCRIPTION Validation Routine */
         INTERACT = VALID_DATA;
         return;
      }
      void L1200()
      {
         /*  CATEGORY OR RESOURCE */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "" || ANS == "C" || ANS == "R")
         {
            if (VALUE == "R" && ANS == "C" && SPORTS_REC[SPORTS_SUB_LIST] != "")
            {
               /*  Warn user that dependant codes nested below this code when it was */
               /*  a resource will be removed, now it's being changed to a category */
               nrf0 = 56;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            if (VALUE == "C" && ANS == "R")
            {
               /*  Warn user that categories and/or non-dep resources nested below this */
               /*  code will be removed */
               nrf0 = 57;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 20;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1250()
      {
         /*  Top Level Category? */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "" || ANS == "Y" || ANS == "N")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 44;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1300()
      {
         /*  INTERNAL, EXTERNAL OR BOTH */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "" || ANS == "I" || ANS == "E" || ANS == "B")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 31;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1400()
      {
         /*  RESPONSIBLE ADMINISTRATOR */
         ANS = OCONV(ANS, "MCU");
         if (ANS == COMMON.HELP)
         {
            nrf0 = REDISPLAY;
            FL156_HELP = new FL156_HELP(ref RETURNED_ANS, ref INTERACT, ref nrf0, ref SPARE1);
            if (INTERACT != EXIT)
            {
               ANS = RETURNED_ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
         }
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.HELP)
         {
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS == "")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            ANS = OCONV(ANS, "MCU");
            if (MATREAD(ref PASS_REC, COMMON.FILES[FL_PASSWORDS], ANS))
            {
               PRINT(AT(ST_COL + 10, ST_ROW) + FORMAT(PASS_REC[PASS_NAME], "L#20"));
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 32;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         // END CASE
         return;
      }
      void L1500()
      {
         /*  BOOK AHEAD CONTROL */
         ANS = OCONV(ANS, "MCU");
         if (ANS == COMMON.HELP)
         {
            nrf0 = REDISPLAY;
            FL931 = new FL931(ref RETURNED_ANS, ref INTERACT, ref nrf0, ref SPARE1);
            if (INTERACT != EXIT)
            {
               ANS = RETURNED_ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
         }
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.HELP)
         {
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS == "")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            ANS = OCONV(ANS, "MCU");
            if (READ(ref TEST_REC, COMMON.FILES[FL_CONTROL], "BOOK.AHEAD*" + ANS))
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 36;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         // END CASE
         return;
      }
      void L1600()
      {
         /*  BOOK AHEAD DAYS */
         if (MATCH(ANS, "1N") || MATCH(ANS, "2N") || MATCH(ANS, "3N") || ANS == "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 40;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L1700()
      {
         /*  RESTRICTION CODE */
         ANS = OCONV(ANS, "MCU");
         INTERACT = VALID_DATA;
         return;
      }
      void L1800()
      {
         /*  PAID PER PERSON */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "" || ANS == "Y" || ANS == "N" || ANS == "G")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 33;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1900()
      {
         /*  NUMBER OF PLAYERS */
         if (ANS == "" || MATCH(ANS, "1N") || MATCH(ANS, "2N"))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 34;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L2000()
      {
         /*  SPECIAL ROUTINE */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            ANS = OCONV(ANS, "MCU");
            if (READ(ref TEST_REC, FL_USER_PROGS, ANS))
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 35;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         return;
      }
      void L2100()
      {
         /*  BOOKING LEEWAY (MINS) */
         if (MATCH(ANS, "1N") || MATCH(ANS, "2N") || ANS == "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 52;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L2200()
      {
         /*  SUBSIDIARY CODE */
         ANS = OCONV(ANS, "MCU");
         if (ANS == COMMON.HELP)
         {
            SP_CODES = "";
            RESOURCES_ONLY = FALSE;
            nrf0 = REDISPLAY;
            FL930 = new FL930(ref RETURNED_ANS, ref INTERACT, ref nrf0, ref SP_CODES, ref RESOURCES_ONLY);
            if (INTERACT != EXIT)
            {
               ANS = RETURNED_ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
            OLD_FIELD_NO = FIELD_NO;
            OLD_FIELD_DATA = FIELD_DATA;
            L0100();
            L0300();
            FIELD_NO = OLD_FIELD_NO;
            FIELD_DATA = OLD_FIELD_DATA;
            L0200();
         }
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.HELP)
         {
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS == "")
         {
            INTERACT = VALID_DATA;
         }// CASE
         else if (OTHERWISE)
         {
            ANS = OCONV(ANS, "MCU");
            if (READ(ref SUB_REC, COMMON.FILES[FL_SPORTS], ANS))
            {
               PRINT(AT(ST_COL + 10, ST_ROW) + FORMAT(SUB_REC[1], "L#30"));
               INTERACT = VALID_DATA;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 53;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         // END CASE
         return;
      }
      void L2300()
      {
         /*  Dependant Resource (can't be sold separately) */
         ANS = OCONV(ANS, "MCU");
         if (ANS == "" || ANS == "Y" || ANS == "N")
         {
            INTERACT = VALID_DATA;
            if (SPORTS_REC[SPORTS_SUB_LIST] != "" && ANS == "Y" && VALUE != "Y")
            {
               /*  Warn user that any nested dependant resources will be lost (from P2) */
               nrf0 = 55;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         else
         {
            nrf0 = 54;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
         /* ***************************************** */
      }
      void L6000()
      {
         /*   Display data for selected fields  * */
         /* ***************************************** */
         OLD_FIELD_NO = FIELD_NO;
         OLD_FIELD_DATA = FIELD_DATA;
         for (FIELD_NO = START_FIELD; FIELD_NO <= END_FIELD; FIELD_NO += 1)
         {
            FIELD_DATA = DATA_FIELDS[FIELD_NO];
            L0200();
            // BEGIN CASE
            // CASE
            if (ST_ATT == 0)
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
            }// CASE
            else if (ST_CONVERSION != "")
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
            }// CASE
            else if (OTHERWISE)
            {
               PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
               /*  Show administrators name */
               if (FIELD_NO == RESPONSIBLE_USER_FIELD_NO)
               {
                  PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
                  if (MATREAD(ref PASS_REC, COMMON.FILES[FL_PASSWORDS], TEMP_REC[ST_ATT]))
                  {
                     PRINT(AT(ST_COL + 10, ST_ROW) + FORMAT(PASS_REC[PASS_NAME], "L#20"));
                  }
               }
            }
            // END CASE
         }
         FIELD_NO = OLD_FIELD_NO;
         FIELD_DATA = OLD_FIELD_DATA;
         L0200();
         return;
         /* ******************************** */
      }
      void L8000()
      {
         /*   Build temp.rec           * */
         /* ******************************** */
         TEMP_REC[1] = SPORTS_REC[SPORTS_DESC];
         TEMP_REC[2] = SPORTS_REC[SPORTS_CAT_OR_RESOURCE];
         TEMP_REC[3] = SPORTS_REC[SPORTS_VISIBILITY];
         TEMP_REC[4] = SPORTS_REC[SPORTS_ADMINISTRATOR];
         TEMP_REC[5] = SPORTS_REC[SPORTS_PERSON_BOOKING];
         TEMP_REC[6] = SPORTS_REC[SPORTS_PLAYERS];
         TEMP_REC[7] = SPORTS_REC[SPORTS_SPECIAL_ROUTINE];
         TEMP_REC[8] = SPORTS_REC[SPORTS_BOOK_AHEAD_CONTROL];
         TEMP_REC[9] = SPORTS_REC[SPORTS_BOOK_AHEAD_DAYS];
         TEMP_REC[10] = SPORTS_REC[SPORTS_RESTRICTION_CODE];
         TEMP_REC[11] = SPORTS_REC[SPORTS_TOP_LEVEL];
         TEMP_REC[12] = SPORTS_REC[SPORTS_BOOKING_LEEWAY];
         TEMP_REC[13] = SPORTS_REC[SPORTS_CODE1];
         TEMP_REC[14] = SPORTS_REC[SPORTS_CODE2];
         TEMP_REC[15] = SPORTS_REC[SPORTS_DEPENDANT_RESOURCE];
         if (SPORTS_REC[SPORTS_TYPE] == "") { SPORTS_REC[SPORTS_TYPE] = "F"; /*  Fixed */ }
         if (SPORTS_REC[SPORTS_BOOK_OR_CAS] == "") { SPORTS_REC[SPORTS_BOOK_OR_CAS] = "N"; }
         return;
         /* ******************************************* */
      }
      void L9000()
      {
         /*   Transfer data out of temp.rec       * */
         /* ******************************************* */
         SPORTS_REC[SPORTS_DESC] = TEMP_REC[1];
         SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = TEMP_REC[2];
         SPORTS_REC[SPORTS_VISIBILITY] = TEMP_REC[3];
         SPORTS_REC[SPORTS_ADMINISTRATOR] = TEMP_REC[4];
         SPORTS_REC[SPORTS_PERSON_BOOKING] = TEMP_REC[5];
         SPORTS_REC[SPORTS_PLAYERS] = TEMP_REC[6];
         SPORTS_REC[SPORTS_SPECIAL_ROUTINE] = TEMP_REC[7];
         SPORTS_REC[SPORTS_BOOK_AHEAD_CONTROL] = TEMP_REC[8];
         SPORTS_REC[SPORTS_BOOK_AHEAD_DAYS] = TEMP_REC[9];
         SPORTS_REC[SPORTS_RESTRICTION_CODE] = TEMP_REC[10];
         SPORTS_REC[SPORTS_TOP_LEVEL] = TEMP_REC[11];
         SPORTS_REC[SPORTS_BOOKING_LEEWAY] = TEMP_REC[12];
         SPORTS_REC[SPORTS_CODE1] = TEMP_REC[13];
         SPORTS_REC[SPORTS_CODE2] = TEMP_REC[14];
         SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] = TEMP_REC[15];
         if (SPORTS_REC[SPORTS_TYPE] == "") { SPORTS_REC[SPORTS_TYPE] = "F"; /*  Fixed */ }
         if (SPORTS_REC[SPORTS_BOOK_OR_CAS] == "") { SPORTS_REC[SPORTS_BOOK_OR_CAS] = "N"; }
         if (SPORTS_REC[SPORTS_TOP_LEVEL] == "" && SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "C") { SPORTS_REC[SPORTS_TOP_LEVEL] = "N"; }
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
