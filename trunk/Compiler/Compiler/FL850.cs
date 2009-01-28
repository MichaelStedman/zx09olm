//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL850 : UvBase
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
      readonly UvVar BST = 1;
      readonly UvVar GMT = 2;
      readonly UvVar FL_SCREENS = 8;
      readonly UvVar BLKBK_CATEGORY = 1;
      readonly UvVar BLKBK_DESC = 2;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] BLKBK_REC = new UvVar[40];
      UvVar[] TEMP_REC = new UvVar[40];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar DIM_REV_VID = "";
      UvVar NRM_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SCREEN_WIDTH = "";
      UvVar GO_BACK = "";
      UvVar TILL_NUMBER = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar CATEGORY = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar WINDOW_COL_START = "";
      UvVar WINDOW_ROW_START = "";
      UvVar WINDOW_LINES_PER_PAGE = "";
      UvVar WINDOW_COL_WIDTH = "";
      UvVar PAGE_CURRENT = "";
      UvVar PAGE_NBR_ITEMS = "";
      UvVar LIST_NEW = "";
      UvVar LIST_ORIGINAL = "";
      UvVar HELP_BOX_HEAD = "";
      UvVar OPRIONS = "";
      UvVar DESCRIPTIONS = "";
      UvVar FL_BLKBK_DAYS = "";
      UvVar CAL_TYPE = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar LINE = "";
      UvVar MAIN_KEY = "";
      UvVar CALENDAR_ID = "";
      UvVar YEAR_START = "";
      UvVar YEAR_END = "";
      UvVar REQUESTED_LINE_NO = "";
      UvVar START_LINE = "";
      UvVar AMENDING = "";
      UvVar FIELD_NO = "";
      UvVar INPUT_LINE = "";
      FL019 FL019;
      UvVar ANS = "";
      UvVar REDISPLAY_NECESSARY = "";
      FL870 FL870;
      UvVar OPTIONS = "";
      FL871 FL871;
      UvVar OK_TO_FILE = "";
      UvVar VALID_DATE = "";
      UvVar PAGE_MAX = "";
      UvVar FIELD_DATA = "";
      UvVar ST_STATUS_MESSAGE = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar OLD_VALUE = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_LENGTH = "";
      UvVar MDISL = "";
      FL006 FL006;
      UvVar ST_MANDATORY = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
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
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar ID = "";
      UvVar LIST_PTR = "";
      UvVar COL_POS = "";
      UvVar ROW_POS = "";
      UvVar START_POS = "";
      UvVar END_POS = "";
      UvVar MAX_DATES = "";
      UvVar LINE_CNT = "";
      UvVar LINE_PTR = "";
      UvVar DATE_PTR = "";
      UvVar DIS_DATE = "";
      UvVar FROM_DATE = "";
      UvVar TO_DATE = "";
      UvVar DATE_POS = "";
      UvVar NBR_ORIG = "";
      UvVar ORIG_PTR = "";
      UvVar CAT_LIST = "";
      UvVar CAT_PTR = "";
      UvVar NBR_NEW = "";
      UvVar NEW_PTR = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL850()
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
         /*      BLOCK BOOKING CALENDAR CATEGORY DATE */
         PROMPT("");
         PROGRAM = "FL850";
         SCREEN_CODE = PROGRAM;
         DOTS_ONLY = 0;
         COMMON.CLR = "\\";
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         WINDOW_COL_START = 5;
         WINDOW_ROW_START = 5;
         WINDOW_LINES_PER_PAGE = 14;
         WINDOW_COL_WIDTH = 15;
         PAGE_CURRENT = 1;
         PAGE_NBR_ITEMS = WINDOW_LINES_PER_PAGE * 5;
         LIST_NEW = "";
         LIST_ORIGINAL = "";
         HELP_BOX_HEAD = SPACE(24) + "O P T I O N S   H E L P ";
         OPRIONS = "A" + VM + "R" + VM + "N" + VM + "P" + VM + "F" + VM + COMMON.ABANDON;
         DESCRIPTIONS = "Add days";
         DESCRIPTIONS[1, 2] = "Remove days";
         DESCRIPTIONS[1, 3] = "Scroll to Next Page";
         DESCRIPTIONS[1, 4] = "Scroll to Previous Page";
         DESCRIPTIONS[1, 5] = "File";
         DESCRIPTIONS[1, 6] = "Abandon this help box";
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.BLKBK.DAYS

         if (!OPEN("FL.BLKBK.DAYS", out FL_BLKBK_DAYS)) { STOP("201", "FL.BLKBK.DAYS"); }

         #endregion
         MAT(ref TEMP_REC, "");
         CAL_TYPE = "";
         /* ************************************ */
         /*   GET SCREEN DEFINITION ITEM       * */
         /* ************************************ */
         if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE)))
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
         /* ************************************ */
         /*   MAIN PROCESSING SECTION          * */
         /* ************************************ */
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         do
         {
            MAIN_KEY = "";
            CALENDAR_ID = "";
            YEAR_START = "";
            YEAR_END = "";
            MAT(ref TEMP_REC, "");
            REQUESTED_LINE_NO = "";
            START_LINE = 1;
            INTERACT = VALID_DATA;
            AMENDING = FALSE;
            // BEGIN CASE
            // CASE
            if (MAIN_KEY != "")
            {
               L0100();
               MAIN_KEY = CALENDAR_ID;
               AMENDING = TRUE;
               L0300();
               /*  Display data */
               L0050();
            }// CASE
            else if (OTHERWISE)
            {
               L0100();
               MAIN_KEY = "";
               MAT(ref TEMP_REC, "");
               FIELD_NO = 1;
            }
            // END CASE
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     L0060();
                     if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
                     FIELD_NO = FIELD_NO + 1;
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
                  else if (INTERACT == BACKUP && FIELD_NO > 1)
                  {
                     FIELD_NO = FIELD_NO - 1;
                  }// CASE
                  else if (FIELD_NO == MAX_FIELDS)
                  {
                     if (TEMP_REC[1] == "")
                     {
                     }
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
                  /*  Transfer data out of TEMP.REC and perform updates */
                  L9000();
               }
            }
            if (INTERACT == EXIT) break;
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
            INPUT_LINE = "   'F'ile, 'A'dd Dates, 'R'emove Dates, 'N'ext/'P'revious Page ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + SPACE(75));
            PRINT(AT(2, 21) + INPUT_LINE);
            nrf0 = 3;
            FL019 = new FL019(ref nrf0, ref ANS);
            PRINT(AT(2, 21) + SPACE(75) + NRM_VID);
            REDISPLAY_NECESSARY = FALSE;
            if (ANS == COMMON.HELP)
            {
               FL870 = new FL870(ref HELP_BOX_HEAD, ref OPTIONS, ref DESCRIPTIONS, ref ANS, ref INTERACT);
               if (INTERACT == EXIT) { INTERACT = VALID_DATA; } else { INTERACT = INVALID_DATA; }
               REDISPLAY_NECESSARY = TRUE;
            }
            // BEGIN CASE
            // CASE
            if (INTERACT == VALID_DATA)
            {
               /*  Help box abandoned */
               INTERACT = INVALID_DATA;
               if (REDISPLAY_NECESSARY) { L0055(); }
            }// CASE
            else if (ANS == COMMON.ABANDON)
            {
               FL871 = new FL871(ref INTERACT);
               if (INTERACT == EXIT) { PROG_MESS[1] = COMMON.ABANDON; }
            }// CASE
            else if (ANS == "")
            {
               if (REDISPLAY_NECESSARY)
               {
                  L0055();
               }
               INTERACT = INVALID_DATA;
            }// CASE
            else if (ANS == "F")
            {
               /*  Validate that key fields are present before allowing the user to file */
               OK_TO_FILE = TRUE;
               if (OK_TO_FILE)
               {
                  PROG_MESS[1] = "";
                  INTERACT = FINISH;
               }
            }// CASE
            else if (ANS == "A")
            {
               L3000();
               if (VALID_DATE != COMMON.ABANDON)
               {
                  L4000();
               }
            }// CASE
            else if (ANS == "R")
            {
               L3000();
               if (VALID_DATE != COMMON.ABANDON)
               {
                  L5000();
               }
            }// CASE
            else if (ANS == "N")
            {
               if (PAGE_CURRENT < PAGE_MAX)
               {
                  PAGE_CURRENT = PAGE_CURRENT + 1;
                  L2000();
               }
            }// CASE
            else if (ANS == "P")
            {
               if (PAGE_CURRENT > 1)
               {
                  PAGE_CURRENT = PAGE_CURRENT - 1;
                  L2000();
               }
            }// CASE
            else if (OTHERWISE)
            {
               if (REDISPLAY_NECESSARY) { L0055(); }
            }
            // END CASE
            if (!(INTERACT == INVALID_DATA)) break;
         } while (true);
         return;
         /* **************************************************** */
      }
      void L0055()
      {
         /*   Redisplay after help box used                * */
         /* **************************************************** */
         L0100();
         L0300();
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
         PRINT(AT(1, 21) + DIM_REV_VID);
         PRINT(AT(5, 21) + FORMAT(ST_STATUS_MESSAGE, "L#72"));
         if (ST_ATT == 0)
         {
            VALUE = MAIN_KEY;
         }
         else
         {
            VALUE = TEMP_REC[ST_ATT][1, ST_MV];
         }
         OLD_VALUE = VALUE;
         PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(ST_COL, ST_ROW));
         PRINT(STR(".", ST_LENGTH));
         PRINT(AT(ST_COL, ST_ROW));
         MDISL = ST_LENGTH + 1;
         FL019 = new FL019(ref ST_LENGTH, ref ANS);
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.ABANDON)
         {
            FL871 = new FL871(ref INTERACT);
            if (INTERACT == EXIT) { PROG_MESS[1] = COMMON.ABANDON; }
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_ATT == 0)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }// CASE
         else if (ANS == GO_BACK)
         {
            INTERACT = BACKUP;
         }// CASE
         else if (ANS == COMMON.CLR && ST_ATT == 0)
         {
            nrf0 = 3;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
               case 4: L1200(); break;
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
            if (OLD_VALUE != VALUE && PROG_MESS[2] == 1) { PROG_MESS[2] = 2; }
            TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
         }
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
         #region INCLUDE FL.PROCESSING HEADER.INFO
         PRINT(AT(0, 0) + DIM_REV_VID);

         PRINT(AT(67, 0) + OCONV(DATE(), "D"));
         PRINT(AT(3, 2) + "User : " + TILL_NUMBER + " " + U_INITS);
         PRINT(AT(73, 2) + OCONV(TIME(), "MT"));

         #endregion
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         for (PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1)
         {
            PRINT(AT(79, PRINT_LINE) + NRM_VID);
            PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
         }
         PRINT(AT(0, 3) + NRM_VID);
         /*  Display the page 1 window */
         return;
         /* ********************************* */
      }
      void L0200()
      {
         /*   EXTRACT FIELD DATA      * */
         /* ********************************* */
         ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
         ST_ROW = FIELD_DATA[1, 2];
         ST_LENGTH = FIELD_DATA[1, 4];
         ST_ATT_MV = FIELD_DATA[1, 5];
         ST_ATT = FIELD(ST_ATT_MV, ",", 1);
         ST_MV = FIELD(ST_ATT_MV, ",", 2);
         ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
         ST_CONVERSION = FIELD_DATA[1, 9];
         ST_MANDATORY = FIELD_DATA[1, 10];
         ST_STATUS_MESSAGE = FIELD_DATA[1, 15];
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
         /*   YEAR Validation Routine */
         INTERACT = VALID_DATA;
         // BEGIN CASE
         // CASE
         if (INTERACT == EXIT)
         {
            ANS = "";
            INTERACT = INVALID_DATA;
         }// CASE
         else if (NOT(MATCH(ANS, "4N")) && NOT(MATCH(ANS, "2N")))
         {
            nrf0 = 1;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (MATCH(ANS, "4N") && (ANS < 2003 || ANS > 2020))
         {
            nrf0 = 2;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (MATCH(ANS, "2N") && ((ANS > 20 && ANS < 95) || ANS > 99))
         {
            nrf0 = 2;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }// CASE
         else if (ANS != "" && INTERACT == VALID_DATA)
         {
            ANS = OCONV(ICONV("01/01/" + ANS, "D"), "DY");
            /*             AMENDING = TRUE */
            VALUE = ANS;
            MAIN_KEY = VALUE;
            PROG_MESS[2] = 1;
            MAT(ref TEMP_REC, "");
            /*  Read/sort any relevant records in the calendar file */
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = EXIT;
            PROG_MESS[1] = COMMON.ABANDON;
         }
         // END CASE
         return;
      }
      void L1100()
      {
         /*  SPARE */
         INTERACT = VALID_DATA;
         FIELD_NO = MAX_FIELDS;
         CATEGORY = ANS;
         YEAR_START = ICONV("01.01." + MAIN_KEY, "D");
         YEAR_END = ICONV("31.12." + MAIN_KEY, "D");
         INSTRUCTION = "SELECT FL.BLKBK.DAYS WITH @ID >= \"" + YEAR_START + "\" AND WITH @ID <= \"" + YEAR_END + "\" AND WITH 1 = \"" + ANS + "\"";
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            if (!LOCATE(ID, LIST_NEW, 1, 0, 1, ref LIST_PTR, "AR")) { NULL(); }
            LIST_NEW = INS(ID, LIST_NEW[1, LIST_PTR]);
         } while (true);
         LIST_ORIGINAL = LIST_NEW;
         L2000();
         return;
      }
      void L1200()
      {
         /*  SPARE */
         INTERACT = VALID_DATA;
         return;
      }
      void L2000()
      {
         /*  Display page of category dates. */
         PAGE_MAX = INT(DCOUNT(LIST_NEW[1], VM) / PAGE_NBR_ITEMS) + 1;
         if (PAGE_CURRENT > PAGE_MAX)
         {
            PAGE_CURRENT = PAGE_MAX;
         }
         COL_POS = WINDOW_COL_START;
         ROW_POS = WINDOW_ROW_START;
         START_POS = ((PAGE_CURRENT - 1) * PAGE_NBR_ITEMS) + 1;
         END_POS = START_POS + PAGE_NBR_ITEMS - 1;
         MAX_DATES = DCOUNT(LIST_NEW[1], VM);
         LINE_CNT = 1;
         /*  Clear Previous window details */
         for (LINE_PTR = 1; LINE_PTR <= WINDOW_LINES_PER_PAGE; LINE_PTR += 1)
         {
            CRTCR(AT(0, ROW_POS + LINE_PTR - 1) + COMMON.EOL);
         }
         /*  Display page x of y. */
         CRTCR(AT(63, 4) + SPACE(12) + AT(63) + "Page " + PAGE_CURRENT + " of " + PAGE_MAX);
         /*  Display page details */
         for (DATE_PTR = START_POS; DATE_PTR <= END_POS && NOT(DATE_PTR > MAX_DATES); DATE_PTR += 1)
         {
            DIS_DATE = OCONV(LIST_NEW[1, DATE_PTR], "D2DMA").Substring(1, 6) + " " + OCONV(LIST_NEW[1, DATE_PTR], "DWA").Substring(1, 3);
            CRTCR(AT(COL_POS, ROW_POS) + NRM_VID + DIS_DATE);
            if (NOT(MOD(LINE_CNT, WINDOW_LINES_PER_PAGE)))
            {
               ROW_POS = WINDOW_ROW_START;
               COL_POS = COL_POS + WINDOW_COL_WIDTH;
            }
            else
            {
               ROW_POS = ROW_POS + 1;
            }
            LINE_CNT = LINE_CNT + 1;
         }
         return;
      }
      void L3000()
      {
         /*  Get Dates */
         VALID_DATE = FALSE;
         do
         {
            if (VALID_DATE || VALID_DATE == COMMON.ABANDON) break;
            FROM_DATE = "";
            CRT(AT(19, 19) + STR(".", 11) + AT(19));
            INPUT(out FROM_DATE);
            if (FROM_DATE == ".")
            {
               VALID_DATE = COMMON.ABANDON;
            }
            else
            {
               FROM_DATE = ICONV(FROM_DATE, "D");
               // BEGIN CASE
               // CASE
               if (FROM_DATE >= YEAR_START && FROM_DATE <= YEAR_END)
               {
                  VALID_DATE = TRUE;
                  CRT(AT(19, 19) + OCONV(FROM_DATE, "D"));
               }// CASE DEFAULT
               else
               {
                  nrf0 = 10;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               // END CASE
            }
         } while (true);
         if (VALID_DATE != COMMON.ABANDON)
         {
            VALID_DATE = FALSE;
            do
            {
               if (VALID_DATE || VALID_DATE == COMMON.ABANDON) break;
               TO_DATE = "";
               CRT(AT(53, 19) + STR(".", 11) + AT(53) + OCONV(FROM_DATE, "D") + AT(53));
               INPUT(out TO_DATE);
               // BEGIN CASE
               // CASE
               if (TO_DATE == "")
               {
                  TO_DATE = FROM_DATE;
               }// CASE
               else if (TO_DATE == ".")
               {
                  VALID_DATE = COMMON.ABANDON;
               }// CASE DEFAULT
               else
               {
                  TO_DATE = ICONV(TO_DATE, "D");
                  // BEGIN CASE
                  // CASE
                  if (TO_DATE < FROM_DATE)
                  {
                     nrf0 = 11;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }// CASE
                  else if (TO_DATE >= YEAR_START && TO_DATE <= YEAR_END)
                  {
                     VALID_DATE = TRUE;
                     CRT(AT(53, 19) + OCONV(FROM_DATE, "D") + AT(53));
                  }// CASE
                  else if (TO_DATE == ".")
                  {
                     VALID_DATE = COMMON.ABANDON;
                  }// CASE DEFAULT
                  else
                  {
                     nrf0 = 10;
                     nrf1 = INIT;
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  }
                  // END CASE
               }
               // END CASE
            } while (true);
         }
         return;
      }
      void L4000()
      {
         /*  Add dates */
         for (DATE_PTR = FROM_DATE; DATE_PTR <= TO_DATE; DATE_PTR += 1)
         {
            if (!(LOCATE(DATE_PTR, LIST_NEW, 1, 0, 1, ref DATE_POS, "AR")))
            {
               LIST_NEW = INS(DATE_PTR, LIST_NEW[1, DATE_POS]);
            }
         }
         L2000();
         return;
      }
      void L5000()
      {
         /*  Remove Dates */
         for (DATE_PTR = FROM_DATE; DATE_PTR <= TO_DATE; DATE_PTR += 1)
         {
            if (LOCATE(DATE_PTR, LIST_NEW, 1, 0, 1, ref DATE_POS, "AR"))
            {
               LIST_NEW = DEL(LIST_NEW[1, DATE_POS]);
            }
         }
         L2000();
         return;
         /* ******************************************* */
      }
      void L9000()
      {
         /*  Update the file and clear out temp. */
         /* ******************************************* */
         MAT(ref TEMP_REC, "");
         /*  Remove all the original dates from the file */
         NBR_ORIG = DCOUNT(LIST_ORIGINAL[1], VM);
         for (ORIG_PTR = 1; ORIG_PTR <= NBR_ORIG; ORIG_PTR += 1)
         {
            if (!READ(ref CAT_LIST, FL_BLKBK_DAYS, LIST_ORIGINAL[1, ORIG_PTR])) { CAT_LIST = ""; }
            if (LOCATE(CATEGORY, CAT_LIST, 1, 0, 1, ref CAT_PTR, "AL"))
            {
               CAT_LIST = DEL(CAT_LIST[1, CAT_PTR]);
            }
            if (CAT_LIST == "")
            {
               DELETE(FL_BLKBK_DAYS, LIST_ORIGINAL[1, ORIG_PTR]);
            }
            else
            {
               WRITE(CAT_LIST, FL_BLKBK_DAYS, LIST_ORIGINAL[1, ORIG_PTR]);
            }
         }
         /*  Add all the new dates from to the file */
         NBR_NEW = DCOUNT(LIST_NEW[1], VM);
         for (NEW_PTR = 1; NEW_PTR <= NBR_NEW; NEW_PTR += 1)
         {
            if (!READ(ref CAT_LIST, FL_BLKBK_DAYS, LIST_NEW[1, NEW_PTR])) { CAT_LIST = ""; }
            CAT_LIST[1, -1] = CATEGORY;
            WRITE(CAT_LIST, FL_BLKBK_DAYS, LIST_NEW[1, NEW_PTR]);
         }
         LIST_ORIGINAL = "";
         LIST_NEW = "";
         return;
         /* ****************** */
         /*   END OF PROGRAM * */
         /* ****************** */
      }
   }
}
