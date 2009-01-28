//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL936 : UvBase
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
      readonly UvVar FL_SCREENS = 8;
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
      readonly UvVar FL_OPTIONS = 25;
      readonly UvVar OPTION_PRIORITY = 1;
      readonly UvVar OPTION_FLOORS = 2;
      readonly UvVar OPTION_DESC = 3;
      readonly UvVar OPTION_LOCATION = 4;
      readonly UvVar OPTION_WEB_BOOKABLE = 5;
      readonly UvVar OPTION_RELATIVE_START_TIME = 6;
      readonly UvVar OPTION_BOOK_FLOOR_STATUS = 7;
      readonly UvVar FL_CENTRES = 3;
      readonly UvVar CENTRE_NAME = 1;
      readonly UvVar CENTRE_FLOORS = 2;
      readonly UvVar CENTRE_ACTIVITIES = 3;
      readonly UvVar CENTRE_FACILITY_NUM = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] SPORTS_REC = new UvVar[25];
      UvVar[] OPTIONS_REC = new UvVar[10];
      UvVar[] CENTRES_REC = new UvVar[4];
      #endregion
      #region Variables
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar DIM_REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar MAX_FIELDS = "";
      UvVar ALL_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar DISP_FIELDS = "";
      UvVar LINE = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar PARENT_CODE = "";
      UvVar FLOOR_IDENT = "";
      UvVar FA_CODES = "";
      UvVar START_TIME = "";
      FL433 FL433;
      UvVar START_DATE = "";
      UvVar LENGTH_OF_INPUT = "";
      FL019 FL019;
      UvVar ANS = "";
      UvVar FIELD_DATA = "";
      UvVar VALUE = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_LENGTH = "";
      UvVar REDISPLAY = "";
      UvVar ST_MANDATORY = "";
      FL006 FL006;
      UvVar ST_ATT = "";
      UvVar ST_ICONVERSION = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar PROMPT_NO = "";
      FL306 FL306;
      UvVar I = "";
      UvVar TEXT_COL = "";
      UvVar TEXT_VIDEO = "";
      UvVar AMD_NO = "";
      UvVar TEXT_LEN = "";
      UvVar VIDEO_OFF = "";
      UvVar ST_ATT_MV = "";
      UvVar ST_MV = "";
      UvVar ST_DISPLAY = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar SP_CODES = "";
      UvVar RESOURCES_ONLY = "";
      FL930 FL930;
      UvVar RESOURCE_ID = "";
      UvVar STORED_FIELD_DATA = "";
      UvVar TEST_REC = "";
      UvVar CONV_ANS = "";
      UvVar CENTRE_REC = "";
      UvVar CATEGORIES_ONLY = "";
      FWCATEGORYTREE FWCATEGORYTREE;
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      UvVar MODE = "";
      UvVar TREE_ARRAY = "";
      UvVar SPARE2 = "";
      UvVar SPARE3 = "";
      UvVar SPARE4 = "";
      UvVar SPARE5 = "";
      UvVar RESOURCE_LIST = "";
      UvVar NO_MVS = "";
      UvVar RESOURCE_MVC = "";
      UvVar THIS_RESOURCE_CODE = "";
      UvVar CENTRE_POS = "";
      UvVar NO_OPTIONS = "";
      UvVar OPTION_MVC = "";
      UvVar OPTION_ID = "";
      UvVar FLOOR_LIST = "";
      UvVar FLOOR_MVC = "";
      UvVar THIS_FLOOR = "";
      UvVar FA_POS = "";
      UvVar CENTRE_CODE = "";
      UvVar TREE_MVC = "";
      UvVar NO_TREE_MVS = "";
      UvVar PARENT_LEVEL = "";
      UvVar NEW_LEVEL = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL936()
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
         /*  Routine To start Booking Sheet Display */
         PROMPT("");
         PROGRAM = "FL936";
         SCREEN_CODE = PROGRAM;
         /* ******************************** */
         /*   Define Files Used            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS
         #region INCLUDE FL.FILES FL.SPORTS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.SPORTS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS.VAR

         /*  Introduced for Warrington: */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.OPTIONS
         #region INCLUDE FL.FILES FL.OPTIONS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.OPTIONS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.OPTIONS.VAR

         /* *  Relative start time is the time + or - the actual start time ** */
         /* *  to book the floor area out.                                  ** */
         /* *                                                               ** */
         /* *  Floor status is:- */
         /* *      Blank - Book all occurrences of floor area in all sports ** */
         /* *      N     - Do not book out chosen sport for floor area       ** */
         /* *      C     - Book only chosen sport for floor area            ** */
         /* * */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES
         #region INCLUDE FL.FILES FL.CENTRES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CENTRES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES.VAR

         #endregion

         #endregion
         /* ************************************ */
         /*   Get Screen Definition Item       * */
         /* ************************************ */
         if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE)))
         {
            PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
            STOP();
         }
         /* ********************************** */
         /*   Extract Data Input Fields      * */
         /* ********************************** */
         MAX_FIELDS = 0;
         ALL_FIELDS = 0;
         SCREEN_LINES = 0;
         FIRST_FIELD = 0;
         DATA_FIELDS = INIT;
         DISP_FIELDS = INIT;
         do
         {
            LINE = SC_POS[SCREEN_LINES + 1];
            if (LINE == "") break;
            if (LINE[1, 4] != "")
            {
               ALL_FIELDS = ALL_FIELDS + 1;
               DISP_FIELDS[ALL_FIELDS] = LINE;
               if (LINE[1, 14] != "Y")
               {
                  MAX_FIELDS = MAX_FIELDS + 1;
                  if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0)
                  {
                     FIRST_FIELD = MAX_FIELDS;
                  }
                  DATA_FIELDS[MAX_FIELDS] = LINE;
               }
            }
            SCREEN_LINES = SCREEN_LINES + 1;
         } while (true);
         /* ************************************ */
         /*   Main Processing Section          * */
         /* ************************************ */
         INTERACT = VALID_DATA;
         L0100();
         AMENDING = FALSE;
         MAIN_KEY = INIT;
         if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
         if (INTERACT == VALID_DATA)
         {
            do
            {
               do
               {
                  L0060();
                  if (INTERACT || AMENDING || FIELD_NO >= MAX_FIELDS) break;
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
               else if (FIELD_NO >= MAX_FIELDS)
               {
                  L0050();
               }// CASE
               else if (INTERACT == LIMIT || AMENDING)
               {
                  L0050();
               }// CASE
               else if (INTERACT == BACKUP && FIELD_NO > 1)
               {
                  FIELD_NO = FIELD_NO - 1;
               }// CASE
               else if (INTERACT != INVALID_DATA)
               {
                  FIELD_NO = FIELD_NO + 1;
               }
               // END CASE
               if (INTERACT == EXIT || INTERACT == FINISH) break;
            } while (true);
            if (INTERACT != EXIT)
            {
               PARENT_CODE = FLOOR_IDENT;
               L2000();
               /*  Deduce floor areas (FA.CODES, multivalued) */
               PROG_MESS[37] = FA_CODES;
               START_TIME = "";
               FL433 = new FL433(ref FLOOR_IDENT, ref START_DATE, ref START_TIME);
               PROG_MESS[37] = "";
            }
         }
         return;
         /* ************************************* */
      }
      void L0050()
      {
         /*   Enter Amendment Field Number  * */
         /* ************************************* */
         AMENDING = TRUE;
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(ERR_LINE);
            PRINT("Enter Field no. or <RETURN> to finish ");
            LENGTH_OF_INPUT = 2;
            FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
            PRINT(CLR_ERR);
            // BEGIN CASE
            // CASE
            if (ANS == COMMON.ABANDON)
            {
               INTERACT = EXIT;
            }// CASE
            else if (ANS == "")
            {
               INTERACT = FINISH;
            }// CASE
            else if (MATCH(ANS, "0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1)
            {
               FIELD_NO = ANS + FIRST_FIELD - 1;
               INTERACT = VALID_DATA;
            }
            // END CASE
         } while (INTERACT == INVALID_DATA);
         return;
         /* ******************************** */
      }
      void L0060()
      {
         /*   Data Entry Routine       * */
         /* ******************************** */
         INTERACT = INVALID_DATA;
         do
         {
            FIELD_DATA = DATA_FIELDS[FIELD_NO];
            L0200();
            VALUE = "";
            PRINT(AT(ST_COL, ST_ROW));
            FL019 = new FL019(ref ST_LENGTH, ref ANS);
            /* !!     WHILE ANS = HELP DO */
            if (true) break;
            REDISPLAY = FALSE;
            if (REDISPLAY)
            {
               L0100();
               L0300();
            }
         } while (true);
         // BEGIN CASE
         // CASE
         if (ANS == COMMON.ABANDON)
         {
            INTERACT = EXIT;
         }// CASE
         else if (ANS == COMMON.BACK)
         {
            INTERACT = BACKUP;
         }// CASE
         else if (ANS == COMMON.SKIP && ST_MANDATORY != "")
         {
            nrf0 = "STANDARD";
            nrf1 = 1;
            nrf2 = "";
            FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
         }// CASE
         else if (ANS == COMMON.SKIP && ST_ATT != 0)
         {
            INTERACT = VALID_DATA;
            do
            {
               if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
               FIELD_NO = FIELD_NO + 1;
            } while (true);
         }// CASE
         else if (ANS == COMMON.CLR)
         {
            if (ST_MANDATORY == "")
            {
               VALUE = "";
               ANS = "";
               INTERACT = VALID_DATA;
            }
            else
            {
               nrf0 = "STANDARD";
               nrf1 = 1;
               nrf2 = "";
               FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
            }
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_MANDATORY != "")
         {
            nrf0 = "STANDARD";
            nrf1 = 1;
            nrf2 = "";
            FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
         }// CASE
         else if (ANS == "" && VALUE != "")
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
            }
            #endregion
            if (INTERACT == VALID_DATA)
            {
               if (ST_ICONVERSION != "")
               {
                  VALUE = ICONV(ANS, ST_ICONVERSION);
               }
               else
               {
                  VALUE = ANS;
               }
            }
         }
         // END CASE
         PRINT(AT(ST_COL, ST_ROW));
         if (ST_CONVERSION != "")
         {
            PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
         }
         else
         {
            PRINT(FORMAT(VALUE, ST_JUST));
         }
         return;
         /* ******************************* */
      }
      void L0100()
      {
         /*  Display Screen Format  * */
         /* ******************************* */
         PROMPT_NO = 1;
         PRINT(COMMON.WASH);
         FL306 = new FL306();
         PRINT(AT(1, 1) + DIM_REV_VID);
         PRINT(AT(2, 0) + "(" + SCREEN_CODE + ")");
         PRINT(AT(65, 0) + OCONV(TODAYS_DATE, "D"));
         PRINT(AT(24, 1) + SC_POS[1]);
         /*         PRINT @(24,1):STR("=",LEN(SC.POS<1>)): */
         PRINT(AT(78, 1) + NRM_VID);
         for (I = 2; I <= SCREEN_LINES; I += 1)
         {
            FIELD_DATA = SC_POS[I];
            L0200();
            TEXT_COL = FIELD_DATA[1, 1];
            TEXT_VIDEO = FIELD_DATA[1, 7];
            if (ST_ATT + 0 > 0)
            {
               AMD_NO = "  " + PROMPT_NO;
               AMD_NO = AMD_NO.Substring(LEN(AMD_NO) - 1, 2) + ")";
               PRINT(AT(TEXT_COL - 4, ST_ROW) + AMD_NO);
               PROMPT_NO = PROMPT_NO + 1;
            }
            if (TEXT_VIDEO == "D")
            {
               TEXT_LEN = LEN(FIELD_DATA[1, 3]);
               VIDEO_OFF = TEXT_LEN + TEXT_COL;
               PRINT(AT(VIDEO_OFF, ST_ROW) + NRM_VID);
               PRINTCR(AT(TEXT_COL - 1, ST_ROW) + DIM_VID + " ");
            }
            PRINT(AT(TEXT_COL, ST_ROW));
            PRINT(FIELD_DATA[1, 3] + NRM_VID + " ");
            PRINT(AT(TEXT_COL + 2 + LEN(FIELD_DATA[1, 3]), ST_ROW));
            PRINT(STR(".", ST_LENGTH));
         }
         return;
         /* ********************************* */
      }
      void L0200()
      {
         /*   Extract Field Data      * */
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
         ST_ICONVERSION = FIELD_DATA[1, 12];
         ST_DISPLAY = FIELD_DATA[1, 14];
         if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
         return;
         /* ********************************* */
      }
      void L0300()
      {
         /*   Display Item Contents */
         /* ********************************* */
         for (I = 1; I <= ALL_FIELDS; I += 1)
         {
            FIELD_DATA = DISP_FIELDS[I];
            DISP_ATT_MV = FIELD_DATA[1, 5];
            DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
            if (DISP_ATT != 0)
            {
               DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
               DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
               DISP_ROW = FIELD_DATA[1, 2];
               PRINT(AT(DISP_COL, DISP_ROW));
               DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
               DISP_CONVERSION = FIELD_DATA[1, 9];
            }
         }
         return;
         /* ************************ */
         /*   Validation Routines  * */
         /* ************************ */
      }
      void L1000()
      {
         /*  Category/Resource Id */
         INTERACT = VALID_DATA;
         FLOOR_IDENT = "";
         ANS = OCONV(ANS, "MCU");
         if (ANS == COMMON.HELP)
         {
            SP_CODES = "";
            RESOURCES_ONLY = FALSE;
            FL930 = new FL930(ref RESOURCE_ID, ref INTERACT, ref REDISPLAY, ref SP_CODES, ref RESOURCES_ONLY);
            STORED_FIELD_DATA = FIELD_DATA;
            PRINT(AT(0, 3) + NRM_VID);
            L0100();
            L0300();
            FIELD_DATA = STORED_FIELD_DATA;
            L0200();
            if (INTERACT != EXIT)
            {
               ANS = RESOURCE_ID;
            }
            else
            {
               ANS = COMMON.ABANDON;
            }
         }
         if (INTERACT == VALID_DATA)
         {
            if (READ(ref TEST_REC, COMMON.FILES[FL_SPORTS], ANS))
            {
               FLOOR_IDENT = ANS;
            }
            else
            {
               INTERACT = INVALID_DATA;
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         return;
      }
      void L1100()
      {
         /*    Booking Date */
         INTERACT = VALID_DATA;
         CONV_ANS = ICONV(ANS, "D");
         if (CONV_ANS == "")
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         else
         {
            INTERACT = VALID_DATA;
         }
         if (INTERACT == VALID_DATA)
         {
            START_DATE = ANS;
         }
         return;
         /* !!1200*  Start Time Validation Routine */
         /* !!     INTERACT = VALID.DATA */
         /* !!     IF ANS = "" THEN */
         /* !!        INTERACT = VALID.DATA */
         /* !!        CONV.ANS = "" */
         /* !!        VALUE = "" */
         /* !!     END ELSE */
         /* !!        CONV.ANS = ICONV(ANS,"MT") */
         /* !!        IF CONV.ANS = "" THEN */
         /* !!           CALL FL006(PROGRAM,3,"") */
         /* !!           INTERACT = INVALID.DATA */
         /* !!        END ELSE */
         /* !!           INTERACT = VALID.DATA */
         /* !!        END */
         /* !!     END */
         /* !!     ANS = OCONV(CONV.ANS,"MT") */
         /* !!     IF INTERACT = VALID.DATA THEN */
         /* !!        START.TIME = ANS */
         /* !!     END */
         /* !!     RETURN */
         /* ************************************** */
      }
      void L2000()
      {
         /*  Deduce floor areas (FA.CODES)   * */
         /*      Multivalued array               * */
         /* ************************************** */
         FA_CODES = "";
         if (!READ(ref CENTRE_REC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE)) { CENTRE_REC = ""; }
         CATEGORIES_ONLY = FALSE;
         FWCATEGORYTREE = new FWCATEGORYTREE(ref ERROR_STATUS, ref MESSAGE, ref MODE, ref TREE_ARRAY, ref CATEGORIES_ONLY, ref SPARE2, ref SPARE3, ref SPARE4, ref SPARE5);
         L2900();
         /*  Get list of resource codes (RESOURCE.LIST) */
         NO_MVS = DCOUNT(RESOURCE_LIST, VM);
         RESOURCE_MVC = 1;
         do
         {
            if (RESOURCE_MVC > NO_MVS) break;
            THIS_RESOURCE_CODE = RESOURCE_LIST[1, RESOURCE_MVC];
            /*  Ignore resources on other web-bookable accounts. These could be returned */
            /*  by FWCATEGORYTREE. */
            if (LOCATE(THIS_RESOURCE_CODE, CENTRE_REC[3], 1, 0, 1, ref CENTRE_POS, "AL"))
            {
               NO_OPTIONS = CENTRE_REC[4, CENTRE_POS];
               OPTION_MVC = 1;
               do
               {
                  if (OPTION_MVC > NO_OPTIONS) break;
                  OPTION_ID = COMMON.CENTRE + "*" + THIS_RESOURCE_CODE + "*" + OPTION_MVC;
                  if (!READV(ref FLOOR_LIST, COMMON.FILES[FL_OPTIONS], OPTION_ID, 2)) { FLOOR_LIST = ""; }
                  FLOOR_MVC = 1;
                  do
                  {
                     THIS_FLOOR = FLOOR_LIST[1, FLOOR_MVC];
                     if (THIS_FLOOR == "") break;
                     if (!(LOCATE(THIS_FLOOR, FA_CODES, 1, 0, 1, ref FA_POS, "AL")))
                     {
                        FA_CODES[1, -1] = THIS_FLOOR;
                     }
                     FLOOR_MVC = FLOOR_MVC + 1;
                  } while (true);
                  OPTION_MVC = OPTION_MVC + 1;
               } while (true);
            }
            RESOURCE_MVC = RESOURCE_MVC + 1;
         } while (true);
         return;
         /* ************************************************** */
      }
      void L2900()
      {
         /*  Get list of resource codes for a supplied   * */
         /*      parent code                                 * */
         /* ************************************************** */
         CENTRE_CODE = COMMON.CENTRE;
         /*  Only interested in this account */
         RESOURCE_LIST = "";
         if (!READV(ref SPORTS_REC[SPORTS_CAT_OR_RESOURCE], COMMON.FILES[FL_SPORTS], PARENT_CODE, 16)) { SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R"; }
         if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "R")
         {
            RESOURCE_LIST = PARENT_CODE;
         }
         else
         {
            TREE_MVC = 1;
            NO_TREE_MVS = DCOUNT(TREE_ARRAY[5], VM);
            do
            {
               if (TREE_MVC > NO_TREE_MVS) break;
               if (TREE_ARRAY[5, TREE_MVC] == CENTRE_CODE + "*" + PARENT_CODE)
               {
                  /*  Parent found */
                  /*  Continue along, using a separate, nested loop, looking for */
                  /*  all resource codes at lower levels */
                  PARENT_LEVEL = TREE_ARRAY[3, TREE_MVC];
                  NEW_LEVEL = FALSE;
                  TREE_MVC = TREE_MVC + 1;
                  do
                  {
                     if (NEW_LEVEL || TREE_MVC > NO_TREE_MVS) break;
                     // BEGIN CASE
                     // CASE
                     if (TREE_ARRAY[3, TREE_MVC] <= PARENT_LEVEL)
                     {
                        /*  Hit a new branch */
                        NEW_LEVEL = TRUE;
                        TREE_MVC = TREE_MVC + 1;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        if (TREE_ARRAY[6, TREE_MVC] == 2)
                        {
                           /*  It's a resource code */
                           RESOURCE_LIST[1, -1] = FIELD(TREE_ARRAY[5, TREE_MVC], "*", 2);
                        }
                        TREE_MVC = TREE_MVC + 1;
                        /* !!                 END */
                     }
                     // END CASE
                  } while (true);
               }
               else
               {
                  TREE_MVC = TREE_MVC + 1;
               }
            } while (true);
         }
         return;
         /* ************************************** */
         /*  END OF PROGRAM */
         /* ************************************** */
      }
   }
}
