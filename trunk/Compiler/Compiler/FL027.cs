//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL027 : UvBase
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
      readonly UvVar FL_MENUS = 51;
      readonly UvVar MENU_DESC = 1;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] MENUS_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar MENU_NAME = "";
      UvVar MENU_REC = "";
      UvVar LINE_NUMBER = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar LINE = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar MD = "";
      UvVar FIELD_REC = "";
      UvVar TYPE = "";
      UvVar MAX_FIELDS = "";
      UvVar FIRST_FIELD = "";
      UvVar DATA_FIELDS = "";
      UvVar AMENDING = "";
      UvVar MAIN_KEY = "";
      UvVar FIELD_NO = "";
      UvVar ANS = "";
      UvVar FIELD_DATA = "";
      UvVar ST_ATT = "";
      UvVar VALUE = "";
      UvVar ST_MV = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar MDISL = "";
      UvVar ST_LENGTH = "";
      UvVar ST_MANDATORY = "";
      UvVar ST_CONVERSION = "";
      UvVar ST_JUST = "";
      UvVar PROMPT_NO = "";
      UvVar I = "";
      UvVar TEXT_COL = "";
      UvVar TEXT_VIDEO = "";
      UvVar AMD_NO = "";
      UvVar ST_ATT_MV = "";
      UvVar DISP_ATT_MV = "";
      UvVar DISP_ATT = "";
      UvVar DISP_MV = "";
      UvVar DISP_COL = "";
      UvVar DISP_ROW = "";
      UvVar DISP_JUST = "";
      UvVar DISP_CONVERSION = "";
      FL006 FL006;
      UvVar TEST_REC = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL027(ref UvVar MENU_NAME, ref UvVar MENU_REC, ref UvVar LINE_NUMBER)
      {
         this.MENU_NAME = MENU_NAME;
         this.MENU_REC = MENU_REC;
         this.LINE_NUMBER = LINE_NUMBER;
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
         // AMEND SCREEN DATA LINE
         PROMPT("");
         PROGRAM = "FL027";
         SCREEN_CODE = PROGRAM;
         //  DEFINE FILES USED            *
         #region INCLUDE FL.FILES FL.SCREENS

         #endregion
         #region INCLUDE FL.FILES FL.MENUS

         #endregion
         if (!OPEN("MD", out MD)) { STOP("201", "MD"); }
         //  DEFINE ITEMS USED            *
         SC_POS = INIT;
         //  GET SCREEN DEFINITION ITEM       *
         if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE)))
         {
            PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
            STOP();
         }
         FIELD_REC = MENU_REC[LINE_NUMBER];
         //  EXTRACT DATA INPUT FIELDS      *
         TYPE = "";
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
         //  MAIN PROCESSING SECTION          *
         do
         {
            AMENDING = FALSE;
            L0100();
            if (FIELD_REC != "")
            {
               L0300();
               AMENDING = TRUE;
               TYPE = FIELD_REC[1, 2];
            }
            if (LINE_NUMBER == 1) { AMENDING = TRUE; }
            MAIN_KEY = INIT;
            INTERACT = VALID_DATA;
            if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
            if (INTERACT == VALID_DATA)
            {
               do
               {
                  do
                  {
                     L0060();
                     if (INTERACT || (AMENDING && FIELD_NO != 2) || FIELD_NO == MAX_FIELDS) break;
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
                  else if (FIELD_NO == MAX_FIELDS)
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
               if (INTERACT == EXIT)
               {
                  LINE_NUMBER = "";
               }
               else
               {
                  MENU_REC[LINE_NUMBER] = FIELD_REC;
               }
            }
            if (INTERACT == EXIT || INTERACT == FINISH) break;
         } while (true);
         return;
      }
      void L0050()
      {
         //  ENTER AMENDMENT FIELD NUMBER  *
         AMENDING = TRUE;
         INTERACT = INVALID_DATA;
         do
         {
            PRINT(ERR_LINE);
            PRINT("Enter Field no. or <RETURN> to finish ");
            INPUT(out ANS, 3);
            if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
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
      }
      void L0060()
      {
         //  DATA ENTRY ROUTINE       *
         INTERACT = INVALID_DATA;
         FIELD_DATA = DATA_FIELDS[FIELD_NO];
         L0200();
         if (ST_ATT == 0)
         {
            VALUE = MAIN_KEY;
         }
         else
         {
            VALUE = FIELD_REC[ST_ATT, ST_MV];
         }
         PRINT(AT(ST_COL, ST_ROW));
         MDISL = ST_LENGTH + 1;
         INPUT(out ANS, MDISL);
         if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
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
         else if (ANS == COMMON.SKIP)
         {
            do
            {
               if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
               FIELD_NO = FIELD_NO + 1;
            } while (true);
         }// CASE
         else if (ANS == COMMON.CLR && ST_MANDATORY == "")
         {
            VALUE = "";
            PRINT(AT(ST_COL, ST_ROW) + STR(" ", ST_LENGTH));
            INTERACT = VALID_DATA;
         }// CASE
         else if (ANS == "" && VALUE == "" && ST_MANDATORY != "")
         {
            PRINT(ERR_LINE);
            PRINT("This Field is Mandatory ");
            INPUT(out ANS, 3);
            if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
            PRINT(CLR_ERR);
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
               PRINT(AT(ST_COL, ST_ROW));
               if (ST_CONVERSION != "")
               {
                  VALUE = ICONV(ANS, ST_CONVERSION);
                  PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
               }
               else
               {
                  VALUE = ANS;
                  PRINT(FORMAT(VALUE, ST_JUST));
               }
            }
         }
         // END CASE
         if (ST_ATT == 0)
         {
            MAIN_KEY = VALUE;
         }
         else
         {
            FIELD_REC[ST_ATT, ST_MV] = VALUE;
         }
         return;
      }
      void L0100()
      {
         // DISPLAY SCREEN FORMAT  *
         PROMPT_NO = 1;
         PRINT(COMMON.WASH);
         PRINT(AT(0, 0) + "(" + SCREEN_CODE + ")");
         PRINT(AT(25, 0) + SC_POS[1]);
         PRINT(AT(25, 1) + STR("=", LEN(SC_POS[1])));
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
               PRINT(AT(TEXT_COL - 1, ST_ROW) + DIM_VID + " ");
            }
            PRINT(AT(TEXT_COL, ST_ROW));
            PRINT(FIELD_DATA[1, 3] + NRM_VID + " ");
            PRINT(STR(".", ST_LENGTH));
         }
         return;
      }
      void L0200()
      {
         //  EXTRACT FIELD DATA      *
         ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
         ST_ROW = FIELD_DATA[1, 2];
         ST_LENGTH = FIELD_DATA[1, 4];
         ST_ATT_MV = FIELD_DATA[1, 5];
         ST_ATT = FIELD(ST_ATT_MV, ",", 1);
         ST_MV = FIELD(ST_ATT_MV, ",", 2);
         ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
         ST_CONVERSION = FIELD_DATA[1, 9];
         ST_MANDATORY = FIELD_DATA[1, 10];
         return;
      }
      void L0300()
      {
         //  DISPLAY ITEM CONTENTS
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
               if (DISP_MV == 1)
               {
                  DISP_CONVERSION = "MCP";
               }
               if (DISP_CONVERSION != "")
               {
                  PRINT(FORMAT(OCONV(FIELD_REC[DISP_ATT, DISP_MV], DISP_CONVERSION), DISP_JUST));
               }
               else
               {
                  PRINT(FORMAT(FIELD_REC[DISP_ATT, DISP_MV], DISP_JUST));
               }
               if (DISP_MV == 1)
               {
                  PRINT(AT(DISP_COL, DISP_ROW + 1) + "^");
                  PRINT(AT(DISP_COL - 1 + LEN(FIELD_REC[DISP_ATT, DISP_MV]), DISP_ROW + 1) + "^");
               }
            }
         }
         return;
         //  VALIDATION ROUTINES  *
      }
      void L1000()
      {
         //  TEXT Validation Routine
         INTERACT = VALID_DATA;
         PRINT(AT(ST_COL, ST_ROW + 1) + "^" + COMMON.EOL);
         PRINT(AT(ST_COL - 1 + LEN(ANS), ST_ROW + 1) + "^");
         return;
      }
      void L1100()
      {
         //  TYPE Validation Routine
         // BEGIN CASE
         // CASE
         if (ANS == "M")
         {
            INTERACT = VALID_DATA;
            TYPE = ANS;
         }// CASE
         else if (ANS == "P")
         {
            INTERACT = VALID_DATA;
            TYPE = ANS;
         }// CASE
         else if (ANS == "Q")
         {
            INTERACT = VALID_DATA;
            TYPE = ANS;
         }// CASE
         else if (OTHERWISE)
         {
            INTERACT = INVALID_DATA;
            nrf0 = 1;
            nrf1 = INIT;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         // END CASE
         return;
      }
      void L1200()
      {
         //  ROUTINE NAME Validation Routine
         INTERACT = VALID_DATA;
         // BEGIN CASE
         // CASE
         if (TYPE == "M")
         {
            if (!(READ(ref TEST_REC, COMMON.FILES[FL_MENUS], ANS)))
            {
               INTERACT = INVALID_DATA;
               nrf0 = 2;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
         }// CASE
         else if (TYPE == "P")
         {
            if (!(READ(ref TEST_REC, MD, ANS)))
            {
               INTERACT = INVALID_DATA;
               TEST_REC = "";
               nrf0 = 3;
               nrf1 = INIT;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }
            if (TEST_REC != "" && TEST_REC[1] != "P")
            {
               if (TEST_REC[1] != "VR" && TEST_REC[1] != "V")
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 4;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
         }
         // END CASE
         return;
      }
      void L1300()
      {
         INTERACT = VALID_DATA;
         return;
         //  END OF PROGRAM *
      }
   }
}
