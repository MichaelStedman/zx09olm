//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL802 : UvBase
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
      readonly UvVar FL_BLOCK_HEADER = 87;
      readonly UvVar BLOCK_SDESC = 1;
      readonly UvVar BLOCK_STIME = 2;
      readonly UvVar BLOCK_ETIME = 3;
      readonly UvVar BLOCK_SPORT = 4;
      readonly UvVar BLOCK_FLOORS1 = 5;
      readonly UvVar BLOCK_FLOORS2 = 6;
      readonly UvVar BLOCK_FLOORS3 = 7;
      readonly UvVar BLOCK_DATES1 = 8;
      readonly UvVar BLOCK_DATES2 = 9;
      readonly UvVar BLOCK_DATES3 = 10;
      readonly UvVar BLOCK_PRICE_REF = 11;
      readonly UvVar BLOCK_LETTER = 12;
      readonly UvVar BLOCK_INSTALL = 13;
      readonly UvVar BLOCK_START = 14;
      readonly UvVar BLOCK_FREQUENCY = 15;
      readonly UvVar BLOCK_NO_INSTALLS = 16;
      readonly UvVar BLOCK_NOTES = 17;
      readonly UvVar BLOCK_DATE_MADE = 18;
      readonly UvVar BLOCK_USER = 19;
      readonly UvVar BLOCK_DEALER = 20;
      readonly UvVar BLOCK_FLOORS4 = 21;
      readonly UvVar BLOCK_FLOORS5 = 22;
      readonly UvVar BLOCK_FLOORS6 = 23;
      readonly UvVar BLOCK_FLOORS7 = 24;
      readonly UvVar BLOCK_DATES4 = 25;
      readonly UvVar BLOCK_DATES5 = 26;
      readonly UvVar BLOCK_DATES6 = 27;
      readonly UvVar BLOCK_DATES7 = 28;
      readonly UvVar FL_BLOCK_DATES = 89;
      readonly UvVar BLOCK_DATE_ACCOUNTS = 1;
      readonly UvVar BLOCK_START_TIME = 2;
      readonly UvVar FL_CUSTOMERS = 85;
      readonly UvVar CUST_NAME = 1;
      readonly UvVar CUST_INITS = 2;
      readonly UvVar CUST_TITLE = 3;
      readonly UvVar CUST_ADDRESS1 = 4;
      readonly UvVar CUST_ADDRESS2 = 5;
      readonly UvVar CUST_ADDRESS3 = 6;
      readonly UvVar CUST_ADDRESS4 = 7;
      readonly UvVar CUST_POST = 8;
      readonly UvVar CUST_HTEL = 9;
      readonly UvVar CUST_WTEL = 10;
      readonly UvVar CUST_COMMENTS = 11;
      readonly UvVar CUST_ACCOUNTS = 12;
      readonly UvVar CUST_LAST_ACC = 13;
      readonly UvVar CUST_MEMBER_NO = 14;
      readonly UvVar CUST_DUE = 15;
      readonly UvVar CUST_ORGANISATION = 16;
      readonly UvVar CUST_EMAIL_ADDRESS = 17;
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
      readonly UvVar FL_FLOOR_AREAS = 24;
      readonly UvVar FLOOR_DESC = 1;
      readonly UvVar FLOOR_FACILITIES = 2;
      readonly UvVar FLOOR_PRICE = 3;
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
      UvVar[] BLOCK_REC = new UvVar[30];
      UvVar[] BLOCK_DATE_REC = new UvVar[2];
      UvVar[] CUST_REC = new UvVar[20];
      UvVar[] SPORTS_REC = new UvVar[25];
      UvVar[] FLOORS_REC = new UvVar[10];
      UvVar[] CENTRES_REC = new UvVar[4];
      #endregion
      #region Variables
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
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
      UvVar START_DATE = "";
      UvVar END_DATE = "";
      UvVar ACTIVITY = "";
      UvVar PRINT_TYPE = "";
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar PAGE_DEPTH = "";
      UvVar FORM = "";
      UvVar LINE_NO = "";
      UvVar PAGE_NO = "";
      UvVar HEADER = "";
      UvVar ZZZ_DATE = "";
      UvVar ACCOUNT_LIST = "";
      UvVar NO_OF_ACCOUNTS = "";
      UvVar ACC_NO = "";
      UvVar BOOKING_KEY = "";
      UvVar PTR = "";
      UvVar POS = "";
      UvVar CUST_FULL_NAME = "";
      UvVar DATE_FIELDS = "";
      UvVar PAGE_POS = "";
      UvVar FLOOR_POS = "";
      UvVar PNTR = "";
      UvVar START = "";
      UvVar ENDT = "";
      UvVar SPORT = "";
      UvVar SPORT_DESC = "";
      UvVar FLOORS = "";
      UvVar NO_OF_FLOORS = "";
      UvVar FLOOR_NO = "";
      UvVar FLOOR1 = "";
      UvVar FLOOR1_DESC = "";
      UvVar FLOOR2 = "";
      UvVar FLOOR2_DESC = "";
      UvVar NO_OF_COMMENTS = "";
      UvVar COMM_LINE = "";
      UvVar CONTINUE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL802()
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
         /*  Block Booking Report */
         PROMPT("");
         PROGRAM = "FL802";
         SCREEN_CODE = PROGRAM;
         /* ******************************** */
         /*   Define Files Used            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.BLOCK.HEADER

         #endregion
         #region INCLUDE FL.FILES FL.BLOCK.DATES

         #endregion
         #region INCLUDE FL.FILES FL.CUSTOMERS

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
         #region INCLUDE FL.FILES FL.FLOOR.AREAS

         /* REMOVED THIS TO PREVENT CONFUSION, MUST BE SENT WITH MASTER HALL MAINT PROGRAM!     EQU HALL.DESC                         TO FLOORS.REC(2) */
         /*  This entry has been corrected as at 9/3/01 for Release 6.4 */
         /*  Floor price was wrongly equated to floor.rec */
         /*  Hall desc was only used by master hall maint so this prog was amended */

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES
         #region INCLUDE FL.FILES FL.CENTRES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CENTRES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES.VAR

         #endregion

         #endregion
         if (!READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRES_REC[CENTRE_NAME] = ""; }
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
               L5000();
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
            PRINT(AT(ST_COL - 1, ST_ROW));
            FL019 = new FL019(ref ST_LENGTH, ref ANS);
            if (!(ANS == COMMON.HELP)) break;
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
               case 3: L1200(); break;
               case 4: L1300(); break;
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
         PRINT(AT(ST_COL - 1, ST_ROW));
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
         PRINT(AT(2, 0) + "(" + SCREEN_CODE + ")");
         PRINT(AT(24, 0) + SC_POS[1]);
         PRINT(AT(24, 1) + STR("=", LEN(SC_POS[1])));
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
         /*   Start Date Validation Routine */
         INTERACT = VALID_DATA;
         if (ANS == "")
         {
            INTERACT = EXIT;
            AMENDING = TRUE;
         }
         else
         {
            ANS = ICONV(ANS, "D");
            if (ANS == "" || ANS == 0)
            {
               nrf0 = 3;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
            else
            {
               START_DATE = ANS;
               ANS = OCONV(ANS, "D");
            }
         }
         return;
      }
      void L1100()
      {
         /*   End Date Validation Routine */
         INTERACT = VALID_DATA;
         if (ANS == "")
         {
            ANS = OCONV(START_DATE, "D");
            END_DATE = START_DATE;
         }
         else
         {
            ANS = ICONV(ANS, "D");
            if (ANS == "" || ANS == 0)
            {
               nrf0 = 3;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
            else
            {
               if (ANS < START_DATE)
               {
                  nrf0 = 4;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  INTERACT = INVALID_DATA;
               }
               else
               {
                  END_DATE = ANS;
                  ANS = OCONV(ANS, "D");
               }
            }
         }
         return;
      }
      void L1200()
      {
         /*  Activity */
         INTERACT = VALID_DATA;
         ACTIVITY = ANS;
         return;
      }
      void L1300()
      {
         /*  Screen or Printer */
         INTERACT = VALID_DATA;
         if (ANS != "S" && ANS != "P")
         {
            nrf0 = 11;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         PRINT_TYPE = ANS;
         return;
      }
      void L5000()
      {
         /*  Produce Report */
         if (PRINT_TYPE == "P")
         {
            /* * Routine to set printer parameters  (condensed print) */
            PRINT_START_COMMAND = "";
            PRINT_END_COMMAND = "";
            PRINT_COMMANDS = "";
            nrf0 = "STANDARD";
            FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
            PRINTER_ON();
            PRINT(PRINT_START_COMMAND);
            PAGE_DEPTH = 60;
            FORM = CHAR(12);
         }
         else
         {
            PAGE_DEPTH = 20;
         }
         LINE_NO = 66;
         PAGE_NO = 0;
         HEADER = "";
         HEADER[1] = SPACE(25) + "BLOCK BOOKING REPORT" + SPACE(25) + "Page ";
         HEADER[2] = FORMAT(CENTRES_REC[CENTRE_NAME], "L#25") + STR("=", 20);
         HEADER[3] = "";
         HEADER[4] = SPACE(25) + "Date ";
         HEADER[5] = "";
         for (ZZZ_DATE = START_DATE; ZZZ_DATE <= END_DATE; ZZZ_DATE += 1)
         {
            if (!(MATREAD(ref BLOCK_DATE_REC, COMMON.FILES[FL_BLOCK_DATES], ZZZ_DATE)))
            {
               MAT(ref BLOCK_DATE_REC, "");
            }
            ACCOUNT_LIST = "";
            NO_OF_ACCOUNTS = DCOUNT(BLOCK_DATE_REC[BLOCK_DATE_ACCOUNTS][1], VM);
            for (ACC_NO = 1; ACC_NO <= NO_OF_ACCOUNTS; ACC_NO += 1)
            {
               BOOKING_KEY = BLOCK_DATE_REC[BLOCK_DATE_ACCOUNTS][1, ACC_NO];
               if (LOCATE(BOOKING_KEY, ACCOUNT_LIST, 1, 0, 1, ref PTR, "AL"))
               {
                  ACCOUNT_LIST[1, -1] = BOOKING_KEY;
                  if (MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], BOOKING_KEY))
                  {
                     if (ACTIVITY != "")
                     {
                        if (!(LOCATE(ACTIVITY, BLOCK_REC[BLOCK_SPORT], 1, 0, 1, ref POS, "AL")))
                        {
                           goto L5888;
                        }
                     }
                     if (!(MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], FIELD(BOOKING_KEY, "/", 1))))
                     {
                        MAT(ref CUST_REC, "");
                     }
                     CUST_FULL_NAME = "";
                     CUST_FULL_NAME = CUST_REC[CUST_TITLE];
                     if (CUST_FULL_NAME == "")
                     {
                        CUST_FULL_NAME = CUST_REC[CUST_INITS];
                     }
                     else
                     {
                        CUST_FULL_NAME = CUST_FULL_NAME + " " + CUST_REC[CUST_INITS];
                     }
                     CUST_FULL_NAME = TRIM(CUST_FULL_NAME);
                     CUST_FULL_NAME = CUST_FULL_NAME + " " + CUST_REC[CUST_NAME];
                     CUST_FULL_NAME = TRIM(CUST_FULL_NAME);
                     for (DATE_FIELDS = 8; DATE_FIELDS <= 28; DATE_FIELDS += 1)
                     {
                        if (DATE_FIELDS == 11) { DATE_FIELDS = 25; }
                        if (DATE_FIELDS < 11)
                        {
                           PAGE_POS = DATE_FIELDS - 7;
                           FLOOR_POS = DATE_FIELDS - 3;
                        }
                        else
                        {
                           PAGE_POS = DATE_FIELDS - 21;
                           FLOOR_POS = DATE_FIELDS - 4;
                        }
                        if (LOCATE(ZZZ_DATE, BLOCK_REC[DATE_FIELDS], 1, 0, 1, ref PNTR, "AR"))
                        {
                           START = BLOCK_REC[BLOCK_STIME][1, PAGE_POS];
                           ENDT = BLOCK_REC[BLOCK_ETIME][1, PAGE_POS];
                           SPORT = BLOCK_REC[BLOCK_SPORT][1, PAGE_POS];
                           if (!READV(ref SPORT_DESC, COMMON.FILES[FL_SPORTS], SPORT, 1)) { SPORT_DESC = SPORT; }
                           FLOORS = BLOCK_REC[FLOOR_POS][1];
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINTCR(SPACE(2) + OCONV(START, "MT") + " to " + OCONV(ENDT, "MT") + SPACE(4) + FORMAT(SPORT_DESC, "L#20") + SPACE(5) + FORMAT(BLOCK_REC[BLOCK_SDESC], "L#20"));
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINT();
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINTCR(SPACE(2) + "Account No. " + FORMAT(BOOKING_KEY, "L#12") + SPACE(5) + CUST_FULL_NAME);
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINT();
                           NO_OF_FLOORS = DCOUNT(FLOORS, VM);
                           for (FLOOR_NO = 1; FLOOR_NO <= NO_OF_FLOORS; FLOOR_NO += 2)
                           {
                              FLOOR1 = FLOORS[1, FLOOR_NO];
                              if (!READV(ref FLOOR1_DESC, COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + FLOOR1, 1)) { FLOOR1_DESC = ""; }
                              FLOOR2 = FLOORS[1, FLOOR_NO + 1];
                              if (!READV(ref FLOOR2_DESC, COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + FLOOR2, 1)) { FLOOR2_DESC = ""; }
                              LINE_NO = LINE_NO + 1;
                              if (LINE_NO > PAGE_DEPTH) { L6000(); }
                              if (INTERACT == EXIT) { goto L5999; }
                              PRINTCR(SPACE(2) + FORMAT(FLOOR1, "L#4") + SPACE(2) + FORMAT(FLOOR1_DESC, "L#20") + FORMAT(FLOOR2, "L#4") + SPACE(2) + FORMAT(FLOOR2_DESC, "L#20"));
                           }
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINT();
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINTCR(SPACE(2) + "Notes");
                           NO_OF_COMMENTS = DCOUNT(BLOCK_REC[BLOCK_NOTES][1], VM);
                           for (COMM_LINE = 1; COMM_LINE <= NO_OF_COMMENTS; COMM_LINE += 1)
                           {
                              LINE_NO = LINE_NO + 1;
                              if (LINE_NO > PAGE_DEPTH) { L6000(); }
                              if (INTERACT == EXIT) { goto L5999; }
                              PRINTCR(SPACE(2) + BLOCK_REC[BLOCK_NOTES][1, COMM_LINE]);
                           }
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINT();
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINTCR(SPACE(2) + "*********");
                           LINE_NO = LINE_NO + 1;
                           if (LINE_NO > PAGE_DEPTH) { L6000(); }
                           if (INTERACT == EXIT) { goto L5999; }
                           PRINT();
                        }
                     }
                  L5888: ;
                  }
               }
            }
            LINE_NO = 66;
         }
      L5999: ;
         if (PRINT_TYPE == "S")
         {
            PRINT(AT(1, 22) + COMMON.EOL);
            PRINT(AT(60, 22) + "<RETURN> TO FINISH");
            INPUTCR(out CONTINUE);
         }
         else
         {
            PRINT(PRINT_END_COMMAND);
            PRINTER_CLOSE();
            PRINTER_OFF();
         }
         return;
      }
      void L6000()
      {
         /*  Print Header */
         if (PRINT_TYPE == "S")
         {
            if (PAGE_NO != 0)
            {
               PRINT(AT(1, 22) + COMMON.EOL);
               PRINT(AT(50, 22) + "<RETURN> TO CONTINUE");
               INPUTCR(out CONTINUE);
               if (CONTINUE == COMMON.ABANDON) { INTERACT = EXIT; goto L6999; }
            }
            PRINT(COMMON.WASH);
         }
         else
         {
            PRINTCR(FORM);
         }
         PAGE_NO = PAGE_NO + 1;
         PRINTCR(HEADER[1] + FORMAT(PAGE_NO, "R#4"));
         PRINTCR(HEADER[2]);
         PRINTCR(HEADER[3]);
         PRINTCR(HEADER[4] + OCONV(ZZZ_DATE, "D2/"));
         PRINTCR(HEADER[5]);
         LINE_NO = 5;
      L6999: ;
         return;
         /* ************************************** */
         /*  END OF PROGRAM */
         /* ************************************** */
      }
   }
}
