//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL902 : UvBase
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar PROGRAM = "";
      UvVar INTERACT = "";
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
      FL484 FL484;
      UvVar START_DATE = "";
      UvVar END_DATE = "";
      UvVar TYPE = "";
      UvVar DETAILED = "";
      UvVar PRINT_FLAG = "";
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
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL902()
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
         /*  FINANCE REPORT - SETUP PROGRAM (ACTIVITY WITHIN GROUP) */
         PROMPT("");
         PROGRAM = "FL483";
         SCREEN_CODE = PROGRAM;
         /* ******************************** */
         /*   Define Files Used            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SCREENS

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
               FL484 = new FL484(ref START_DATE, ref END_DATE, ref TYPE, ref DETAILED, ref PRINT_FLAG);
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
               case 5: L1400(); break;
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
         }
         ANS = OCONV(ANS, "D");
         START_DATE = ANS;
         return;
      }
      void L1100()
      {
         /*   End Date Validation Routine */
         INTERACT = VALID_DATA;
         ANS = ICONV(ANS, "D");
         if (ANS == "")
         {
            ANS = OCONV(TODAYS_DATE, "D");
            END_DATE = ANS;
         }
         else
         {
            ANS = OCONV(ANS, "D");
            END_DATE = ANS;
         }
         return;
      }
      void L1200()
      {
         /*  Type Required */
         INTERACT = VALID_DATA;
         if (ANS != "D" && ANS != "W" && ANS != "P" && ANS != "Y")
         {
            INTERACT = INVALID_DATA;
            nrf0 = 12;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         TYPE = ANS;
         return;
      }
      void L1300()
      {
         /*  Detailed ? */
         INTERACT = VALID_DATA;
         if (ANS != "S" && ANS != "D" && ANS != "T")
         {
            INTERACT = INVALID_DATA;
            nrf0 = 13;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         DETAILED = ANS;
         return;
      }
      void L1400()
      {
         /*  Print Flag */
         INTERACT = VALID_DATA;
         if (ANS == "")
         {
            ANS = "S";
         }
         else
         {
            if (ANS != "S" && ANS != "P")
            {
               INTERACT = INVALID_DATA;
               nrf0 = 11;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }
         PRINT_FLAG = ANS;
         return;
         /* ************************************** */
         /*  END OF PROGRAM */
         /* ************************************** */
      }
   }
}
