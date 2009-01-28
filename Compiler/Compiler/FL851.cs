//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL851 : UvBase
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
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_TICKET_FEES = 12;
      readonly UvVar TICK_FEES_DESC = 1;
      readonly UvVar TICK_FEES_PRICE = 2;
      readonly UvVar TICK_FEES_GLCODE = 3;
      readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
      readonly UvVar TICK_FEES_OFF_PRICES = 5;
      readonly UvVar TICK_FEES_OFF_START_MON = 6;
      readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
      readonly UvVar TICK_FEES_OFF_START_SAT = 8;
      readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
      readonly UvVar TICK_FEES_OFF_START_SUN = 10;
      readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
      readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
      readonly UvVar TICK_FEES_NEW_PRICE = 13;
      readonly UvVar TICK_FEES_OPEN_RANGE = 14;
      readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
      readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
      readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
      readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
      readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
      readonly UvVar TICK_FEES_VAT_QUESTION = 20;
      readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
      readonly UvVar TICK_FEES_GROUP_CODE = 22;
      readonly UvVar TICK_FEES_HEADCOUNT = 23;
      readonly UvVar TICK_FEES_CONCESSIONS = 24;
      readonly UvVar TICK_FEES_PEAK_PRICES = 25;
      readonly UvVar TICK_FEES_OFF1_PRICES = 26;
      readonly UvVar TICK_FEES_OFF2_PRICES = 27;
      readonly UvVar TICK_FEES_OFF3_PRICES = 28;
      readonly UvVar TICK_FEES_OFF4_PRICES = 29;
      readonly UvVar TICK_FEES_SPLIT_OWED = 30;
      readonly UvVar TICK_FEES_SPLIT_PAID = 31;
      readonly UvVar TICK_FEES_SPORTS = 32;
      readonly UvVar TICK_FEES_RESALE_RATE = 33;
      readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
      readonly UvVar TICK_FEES_TEXT = 35;
      readonly UvVar TICK_FEES_MEMBER_REQ = 36;
      readonly UvVar TICK_FEES_STYLE = 37;
      readonly UvVar TICK_FEES_GROUPED = 38;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] TEMP_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar NRM_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar VM = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar LINE = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar TEST_REC = "";
      UvVar FIELD_NO = "";
      UvVar INPUT_LINE = "";
      UvVar ANS = "";
      UvVar FIELD_DATA = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar ST_LENGTH = "";
      UvVar MDISL = "";
      UvVar ANS2 = "";
      UvVar I = "";
      UvVar CHARACTER = "";
      UvVar ST_MANDATORY = "";
      FL006 FL006;
      UvVar ST_ICONVERSION = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar PROMPT_NO = "";
      UvVar DOTS_ONLY = "";
      FL000_10 FL000_10;
      UvVar PRINT_LINE = "";
      UvVar ST_ATT_MV = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar CONV_ANS = "";
      UvVar RANGE = "";
      UvVar FW_WEB_CONTROL = "";
      UvVar PREFIX_COUNT = "";
      UvVar N = "";
      UvVar NO_PORTS = "";
      UvVar EFT_ECOM_MERCHANT = "";
      UvVar START_OF_RANGE = "";
      UvVar END_OF_RANGE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL851()
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
         /*     MAINTAIN GENERAL WEB PARAMETERS */
         PROMPT("");
         PROGRAM = "FL851";
         SCREEN_CODE = PROGRAM;
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         /* ******************************** */
         /*   Define Files Used            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         MAT(ref TEMP_REC, "");
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
         SCREEN_LINES = 0;
         FIRST_FIELD = 0;
         DATA_FIELDS = INIT;
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
         /*   Main Processing Section          * */
         /* ************************************ */
         do
         {
            PRINT(SCREEN_BACK + SCREEN_DATA);
            INTERACT = VALID_DATA;
            L0100();
            AMENDING = FALSE;
            MAIN_KEY = INIT;
            L8000();
            /*  LOAD TEMP.REC */
            if (READ(ref TEST_REC, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL"))
            {
               AMENDING = TRUE;
               L0300();
            }
            else
            {
               MAT(ref TEMP_REC, INIT);
            }
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
                  else if (INTERACT == BACKUP && FIELD_NO > 1)
                  {
                     FIELD_NO = FIELD_NO - 1;
                  }// CASE
                  else if (FIELD_NO >= MAX_FIELDS)
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
               if (INTERACT != EXIT)
               {
                  L9000();
                  /*  UNLOAD TEMP.REC AND WRITE DATA */
               }
            }
            if (INTERACT == EXIT || INTERACT == FINISH) break;
         } while (true);
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
            INPUT_LINE = "  Enter Field no. or <RETURN> to finish ";
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + INPUT_LINE);
            INPUT(out ANS, 4);
            PRINT(AT(79, 21) + NRM_VID);
            PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 21) + SPACE(76));
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
         FIELD_DATA = DATA_FIELDS[FIELD_NO];
         L0200();
         if (ST_ATT == 0)
         {
            VALUE = MAIN_KEY;
         }
         else
         {
            VALUE = TEMP_REC[ST_ATT][1, ST_MV];
         }
         PRINT(AT(ST_COL - 1, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
         PRINT(AT(ST_COL, ST_ROW));
         MDISL = ST_LENGTH + 1;
         INPUT(out ANS, MDISL);
         if (LEN(ANS) > ST_LENGTH) { PRINTCR(AT(-9)); ANS = ANS.Substring(1, ST_LENGTH); }
         ANS2 = "";
         for (I = 1; I <= ST_LENGTH; I += 1)
         {
            CHARACTER = ANS.Substring(I, 1);
            if (SEQ(CHARACTER) > 31) { ANS2 = ANS2 + CHARACTER; }
         }
         ANS = ANS2;
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
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_MANDATORY != "")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
               case 6: L1500(); break;
               case 7: L1600(); break;
               case 8: L1700(); break;
               case 9: L1800(); break;
               case 10: L1900(); break;
               case 11: L2000(); break;
               case 12: L2100(); break;
               case 13: L2200(); break;
               case 14: L2300(); break;
               case 15: L2400(); break;
               case 16: L2500(); break;
               case 17: L2600(); break;
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
         if (ST_ATT == 0)
         {
            MAIN_KEY = VALUE;
         }
         else
         {
            TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
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
         DOTS_ONLY = 0;
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         for (PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1)
         {
            PRINT(AT(79, PRINT_LINE) + NRM_VID);
            PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, PRINT_LINE) + SPACE(76));
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
         if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
         return;
         /* ********************************* */
      }
      void L0300()
      {
         /*   Display Item Contents */
         /* ********************************* */
         for (I = 1; I <= MAX_FIELDS; I += 1)
         {
            FIELD_DATA = DATA_FIELDS[I];
            DISP_ATT_MV = FIELD_DATA[1, 5];
            DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
            if (DISP_ATT != 0)
            {
               DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
               DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
               DISP_ROW = FIELD_DATA[1, 2];
               PRINT(AT(DISP_COL - 1, DISP_ROW) + NRM_VID);
               PRINT(AT(DISP_COL, DISP_ROW));
               DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
               DISP_CONVERSION = FIELD_DATA[1, 9];
               if (DISP_CONVERSION != "")
               {
                  PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
               }
               else
               {
                  PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
               }
            }
         }
         return;
         /* ************************ */
         /*   Validation Routines  * */
         /* ************************ */
      }
      void L1000()
      {
         /*  BACKUP FINISH TIME */
         CONV_ANS = ICONV(ANS, "MT");
         if (CONV_ANS == "")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         else
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L1100()
      {
         /*  BACKUP FINISH TIME */
         CONV_ANS = ICONV(ANS, "MT");
         if (CONV_ANS == "")
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         else
         {
            INTERACT = VALID_DATA;
         }
         return;
      }
      void L1200()
      {
         /*  MAX BOOKINGS PER MEMBER PER CENTRE PER DAY */
         if (MATCH(ANS, "1N") || MATCH(ANS, "2N"))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1300()
      {
         /*  ALL INTERNET BOOKINGS SUSPENDED */
         if (ANS == "" || ANS == "N" || ANS == "Y")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 3;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1400()
      {
         /*  ROUTINE TO VALIDATE AND FILTER BY MEMBERSHIP TYPE */
         INTERACT = VALID_DATA;
         return;
      }
      void L1500()
      {
         /*  PREFIXES TO REMOVE FROM MEMBERSHIP NUMBERS */
         INTERACT = VALID_DATA;
         return;
      }
      void L1600()
      {
         /*  VIRTUAL TILL NUMBER */
         if (MATCH(ANS, "1N") || MATCH(ANS, "2N") || MATCH(ANS, "3N"))
         {
            if (ANS > 0 && ANS < 255)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               nrf0 = 4;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
         }
         else
         {
            nrf0 = 5;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1700()
      {
         /*  START OF EFT PORT NUMBER RANGE */
         if (MATCH(ANS, "4N"))
         {
            if (ANS > 999)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               nrf0 = 6;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
         }
         else
         {
            nrf0 = 6;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L1800()
      {
         /*  END OF EFT PORT NUMBER RANGE */
         if (MATCH(ANS, "4N"))
         {
            if (ANS > 999)
            {
               INTERACT = VALID_DATA;
            }
            else
            {
               nrf0 = 7;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               INTERACT = INVALID_DATA;
            }
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 7;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L1900()
      {
         /*  MEMBERSHIP EXCLUSIONS ROUTINE */
         INTERACT = VALID_DATA;
         return;
      }
      void L2000()
      {
         /*  ECOMMERCE MERCHANT NUMBER */
         if (NUM(ANS))
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 8;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L2100()
      {
         /*  LOG UNSUCCESSFUL LOGIN ATTEMPTS */
         if (ANS == "Y" || ANS == "N" || ANS == "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            INTERACT = INVALID_DATA;
            nrf0 = 21;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         return;
      }
      void L2200()
      {
         /*  VARY RESTRICTION TIME */
         INTERACT = VALID_DATA;
         return;
      }
      void L2300()
      {
         /*  MINIMUM CHARGE FOR NON-MEMBERS */
         CONV_ANS = ICONV(ANS, "MD2");
         if (CONV_ANS != "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 9;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L2400()
      {
         /*  Casual Ticket Fee for Credit Card Surcharge */
         INTERACT = VALID_DATA;
         return;
      }
      void L2500()
      {
         /*  Surcharge Percentage for Credit Card Payment */
         CONV_ANS = ICONV(ANS, "MD2");
         if (CONV_ANS != "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 9;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
      }
      void L2600()
      {
         /*  Surcharge rounding unit for Credit Card Payment */
         CONV_ANS = ICONV(ANS, "MD2");
         if (CONV_ANS != "")
         {
            INTERACT = VALID_DATA;
         }
         else
         {
            nrf0 = 9;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INTERACT = INVALID_DATA;
         }
         return;
         /* **************************************** */
      }
      void L8000()
      {
         /*  LOAD TEMP.REC                     * */
         /* **************************************** */
         if (!READ(ref FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL")) { FW_WEB_CONTROL = ""; }
         TEMP_REC[1] = ICONV(FW_WEB_CONTROL[4, 1], "MT");
         TEMP_REC[2] = ICONV(FW_WEB_CONTROL[4, 2], "MT");
         TEMP_REC[3] = FW_WEB_CONTROL[5];
         TEMP_REC[4] = FW_WEB_CONTROL[6];
         TEMP_REC[5] = FW_WEB_CONTROL[7];
         PREFIX_COUNT = DCOUNT(FW_WEB_CONTROL[8], VM);
         TEMP_REC[6] = "";
         for (N = 1; N <= PREFIX_COUNT; N += 1)
         {
            TEMP_REC[6] = TEMP_REC[6] + FW_WEB_CONTROL[8, N];
         }
         TEMP_REC[7] = FW_WEB_CONTROL[9];
         NO_PORTS = DCOUNT(FW_WEB_CONTROL[11], VM);
         TEMP_REC[8] = FORMAT(FW_WEB_CONTROL[11, 1], "R%4");
         TEMP_REC[9] = FORMAT(FW_WEB_CONTROL[11, NO_PORTS], "R%4");
         TEMP_REC[10] = FW_WEB_CONTROL[12];
         if (!READ(ref EFT_ECOM_MERCHANT, COMMON.FILES[FL_CONTROL], "EFT.ECOM.MERCHANT")) { EFT_ECOM_MERCHANT = ""; }
         TEMP_REC[11] = EFT_ECOM_MERCHANT;
         TEMP_REC[12] = FW_WEB_CONTROL[13];
         if (TEMP_REC[12] != "Y" && TEMP_REC[12] != "N" && TEMP_REC[12] != "")
         {
            TEMP_REC[12] = "N";
         }
         TEMP_REC[13] = FW_WEB_CONTROL[14];
         if (TEMP_REC[13].Substring(1, 1) == "*") { TEMP_REC[13] = ""; }
         TEMP_REC[14] = FW_WEB_CONTROL[15];
         if (TEMP_REC[14].Substring(1, 1) == "*") { TEMP_REC[14] = ""; }
         TEMP_REC[15] = FW_WEB_CONTROL[16];
         if (TEMP_REC[15].Substring(1, 1) == "*") { TEMP_REC[15] = ""; }
         TEMP_REC[16] = FW_WEB_CONTROL[17];
         if (TEMP_REC[16].Substring(1, 1) == "*") { TEMP_REC[16] = ""; }
         TEMP_REC[17] = FW_WEB_CONTROL[18];
         if (TEMP_REC[17].Substring(1, 1) == "*") { TEMP_REC[17] = ""; }
         return;
         /* **************************************** */
      }
      void L9000()
      {
         /*  UNLOAD TEMP.REC AND WRITE DATA    * */
         /* **************************************** */
         FW_WEB_CONTROL[4, 1] = OCONV(TEMP_REC[1], "MT");
         FW_WEB_CONTROL[4, 2] = OCONV(TEMP_REC[2], "MT");
         FW_WEB_CONTROL[5] = TEMP_REC[3];
         FW_WEB_CONTROL[6] = TEMP_REC[4];
         FW_WEB_CONTROL[7] = TEMP_REC[5];
         PREFIX_COUNT = LEN(TEMP_REC[6]);
         FW_WEB_CONTROL[8] = "";
         for (N = 1; N <= PREFIX_COUNT; N += 1)
         {
            FW_WEB_CONTROL[8, N] = TEMP_REC[6].Substring(N, 1);
         }
         FW_WEB_CONTROL[9] = TEMP_REC[7];
         FW_WEB_CONTROL[11] = "";
         START_OF_RANGE = TEMP_REC[8];
         END_OF_RANGE = TEMP_REC[9];
         RANGE = END_OF_RANGE - START_OF_RANGE + 1;
         if (END_OF_RANGE < START_OF_RANGE)
         {
            END_OF_RANGE = START_OF_RANGE;
            nrf0 = 10;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         for (N = 1; N <= RANGE; N += 1)
         {
            FW_WEB_CONTROL[11, N] = FORMAT((START_OF_RANGE + N - 1), "R%4");
         }
         FW_WEB_CONTROL[12] = TEMP_REC[10];
         FW_WEB_CONTROL[13] = TEMP_REC[12];
         FW_WEB_CONTROL[14] = TEMP_REC[13];
         FW_WEB_CONTROL[15] = TEMP_REC[14];
         FW_WEB_CONTROL[16] = TEMP_REC[15];
         FW_WEB_CONTROL[17] = TEMP_REC[16];
         FW_WEB_CONTROL[18] = TEMP_REC[17];
         WRITE(FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL");
         WRITE(TEMP_REC[11], COMMON.FILES[FL_CONTROL], "EFT.ECOM.MERCHANT");
         return;
         /* ****************** */
         /*   End of Program * */
         /* ****************** */
      }
   }
}
