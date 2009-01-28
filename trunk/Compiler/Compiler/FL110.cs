//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL110 : UvBase
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
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] TILL_REC = new UvVar[10];
      #endregion
      #region Variables
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar TRANS_LOG_REC = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar REDISPLAY = "";
      UvVar PRINT_REC = "";
      UvVar TILLS = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar LINE = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar NEW_PORT = "";
      UvVar POS = "";
      FLTX2 FLTX2;
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
      UvVar ST_ATT_MV = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      UvVar ASSIGN_CMD = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL110()
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
         /*  Set Up Printer Assignments */
         PROMPT("");
         PROGRAM = "FL110";
         SCREEN_CODE = PROGRAM;
         /* ******************************** */
         /*   Define Files Used            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         REDISPLAY = "";
         if (!READ(ref PRINT_REC, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS")) { PRINT_REC = ""; }
         TILLS = PRINT_REC[1];
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
            MAT(ref TILL_REC, INIT);
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
               if (MAIN_KEY != "" && INTERACT != EXIT)
               {
                  if (NEW_PORT == TRUE)
                  {
                     PRINT_REC = INSERT(PRINT_REC, 1, POS, 0, MAIN_KEY);
                     PRINT_REC = INSERT(PRINT_REC, 3, POS, 0, TILL_REC[1]);
                  }
                  else
                  {
                     PRINT_REC[3, POS] = TILL_REC[1];
                  }
                  WRITE(PRINT_REC, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS");
                  if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS")) { TRANS_LOG_REC = ""; }
                  nrf0 = "W";
                  nrf1 = "FL.CONTROL";
                  nrf2 = "PRINTER.ASSIGNMENTS";
                  FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
               }
            }
            if (INTERACT == EXIT) break;
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
            PRINT(AT(2, 22));
            PRINT("Enter Field no. or <RETURN> to finish ");
            INPUT(out ANS, 3);
            if (LEN(ANS) > 2) { PRINTCR(AT(-9)); ANS = ANS.Substring(1, 2); }
            PRINT(AT(2, 22) + SPACE(50));
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
            if (ST_ATT == 0)
            {
               VALUE = MAIN_KEY;
            }
            else
            {
               VALUE = TILL_REC[ST_ATT][1, ST_MV];
            }
            PRINT(SCREEN_BACK + SCREEN_DATA);
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
            if (!(ANS == COMMON.HELP)) break;
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
            TILL_REC[ST_ATT][1, ST_MV] = VALUE;
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
         PRINT(AT(79, 20) + SCREEN_TEXT + AT(79, 21) + SCREEN_TEXT + AT(79, 22) + SCREEN_TEXT);
         PRINT(AT(1, 20) + SCREEN_FOOT_BACK + AT(1, 21) + SCREEN_FOOT_BACK + AT(1, 22) + SCREEN_FOOT_BACK);
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
               PRINT(AT(DISP_COL, DISP_ROW));
               DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
               DISP_CONVERSION = FIELD_DATA[1, 9];
               if (DISP_CONVERSION != "")
               {
                  PRINT(FORMAT(OCONV(TILL_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
               }
               else
               {
                  PRINT(FORMAT(TILL_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
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
         /*   Port number Validation Routine */
         if (ANS > 0 && ANS < 999)
         {
            INTERACT = VALID_DATA;
            MAIN_KEY = ANS;
            ASSIGN_CMD = "";
            NEW_PORT = TRUE;
            if (LOCATE(ANS, TILLS, 1, 0, 1, ref POS, "AL"))
            {
               NEW_PORT = FALSE;
               ASSIGN_CMD = PRINT_REC[3, POS];
               if (ASSIGN_CMD != "")
               {
                  AMENDING = TRUE;
                  TILL_REC[1] = ASSIGN_CMD;
               }
               if (AMENDING) { L0300(); }
               INTERACT = VALID_DATA;
            }
         }
         return;
      }
      void L1100()
      {
         /*  Printer Assignment Validation */
         INTERACT = VALID_DATA;
         return;
         /* ****************** */
         /*   End of Program * */
         /* ****************** */
      }
   }
}
