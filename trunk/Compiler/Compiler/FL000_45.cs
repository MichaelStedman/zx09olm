//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL000_45 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_FULL_NAME_INDEX = 110;
      readonly UvVar FNI_MEMBER_IDS = 1;
      readonly UvVar FNI_INITS = 2;
      readonly UvVar FNI_NAMES = 3;
      readonly UvVar FNI_ADDRESS_LINE1S = 4;
      readonly UvVar FNI_DOBS = 5;
      readonly UvVar FL_SOUNDSLIKE_NAME_INDEX = 111;
      readonly UvVar SNI_MEMBER_IDS = 1;
      readonly UvVar SNI_INITS = 2;
      readonly UvVar SNI_NAMES = 3;
      readonly UvVar SNI_ADDRESS_LINE1S = 4;
      readonly UvVar FL_ADDRESS_INDEX = 81;
      readonly UvVar ADD_INDEX_MEMBER_IDS = 1;
      readonly UvVar ADD_INDEX_INITS = 2;
      readonly UvVar ADD_INDEX_NAMES = 3;
      readonly UvVar ADD_INDEX_ADDRESS_LINE1S = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] FNI_REC = new UvVar[5];
      UvVar[] SNI_REC = new UvVar[5];
      UvVar[] ADD_INDEX_REC = new UvVar[5];
      #endregion
      #region Variables
      UvVar MEMBER_NO = "";
      UvVar MEMBER_REC = "";
      UvVar AM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar NAME = "";
      UvVar FL_QUICK_INDEX = "";
      FL_QUICK_REBUILD FL_QUICK_REBUILD;
      UvVar FL_NAME_THROWAWAY = "";
      UvVar THROWAWAY_CHARACTERS = "";
      UvVar INITS = "";
      UvVar ADDRESS_LINE1 = "";
      UvVar DOB = "";
      UvVar TITLE = "";
      UvVar FULL_INDEX_REC = "";
      UvVar PNTR = "";
      FLTX2 FLTX2;
      UvVar WORD_COUNT = "";
      UvVar REDUCED_WORD = "";
      UvVar WORD = "";
      UvVar TEST = "";
      UvVar LETTER_COUNT = "";
      UvVar LETTER = "";
      UvVar INDEX_RECORD = "";
      UvVar REDUCED_NAME = "";
      UvVar ADDRESS_LENGTH = "";
      UvVar INDEX_REC = "";
      UvVar INDEXREC = "";
      UvVar INDEXLEN = "";
      UvVar FOUND = "";
      UvVar ILINE = "";
      UvVar SURNAME_LIST = "";
      UvVar FND = "";
      UvVar SURNAME_LEN = "";
      UvVar SLINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL000_45(ref UvVar MEMBER_NO, ref UvVar MEMBER_REC)
      {
         this.MEMBER_NO = MEMBER_NO;
         this.MEMBER_REC = MEMBER_REC;
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
         /*  DELETE MEMBER FROM NAME INDICES */
         /* ************************************ */
         /*  Equate Files */
         /* ************************************ */
         #region INCLUDE FL.FILES FL.FULL.NAME.INDEX

         #endregion
         #region INCLUDE FL.FILES FL.SOUNDSLIKE.NAME.INDEX

         #endregion
         #region INCLUDE FL.FILES FL.ADDRESS.INDEX

         #endregion
         #region INCLUDE FL.FILES FL.QUICK.INDEX

         if (!(OPEN("FL.QUICK.INDEX", out FL_QUICK_INDEX)))
         {
            EXECUTE("CREATE-FILE FL.QUICK.INDEX 1 401", string.Empty, string.Empty, string.Empty, string.Empty);
            FL_QUICK_REBUILD = new FL_QUICK_REBUILD();
            if (!OPEN("FL.QUICK.INDEX", out FL_QUICK_INDEX)) { STOP(201, "FL.QUICK.INDEX"); }
         }

         #endregion
         if (!OPEN("FL.NAME.THROWAWAY", out FL_NAME_THROWAWAY)) { STOP(201, "FL.NAME.THROWAWAY"); }
         /* ************************************ */
         /*  Initialize Variables */
         /* ************************************ */
         THROWAWAY_CHARACTERS = "AEIOU-+&";
         /* ************************************************* */
         /*  Process */
         /* ************************************************* */
         NAME = TRIM(MEMBER_REC[4, 1]);
         NAME = OCONV(NAME, "MCU");
         INITS = MEMBER_REC[5, 1];
         INITS = OCONV(INITS, "MCU");
         ADDRESS_LINE1 = MEMBER_REC[10, 1];
         ADDRESS_LINE1 = OCONV(ADDRESS_LINE1, "MCU");
         DOB = MEMBER_REC[21, 1];
         TITLE = MEMBER_REC[6, 1];
         /*  Quick Index */
         L0100();
         /*  Full name Index */
         if (!(READ(ref FULL_INDEX_REC, COMMON.FILES[FL_FULL_NAME_INDEX], NAME)))
         {
            FULL_INDEX_REC = "";
         }
         if (LOCATE(MEMBER_NO, FULL_INDEX_REC, 1, 0, 1, ref PNTR, "AL"))
         {
            FULL_INDEX_REC = DELETE(FULL_INDEX_REC, 1, PNTR);
            FULL_INDEX_REC = DELETE(FULL_INDEX_REC, 2, PNTR);
            FULL_INDEX_REC = DELETE(FULL_INDEX_REC, 3, PNTR);
            FULL_INDEX_REC = DELETE(FULL_INDEX_REC, 4, PNTR);
            FULL_INDEX_REC = DELETE(FULL_INDEX_REC, 5, PNTR);
            if (FULL_INDEX_REC[1] == "")
            {
               nrf0 = "D"; nrf1 = "FL.FULL.NAME.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref NAME);
            }
            else
            {
               WRITE(FULL_INDEX_REC, COMMON.FILES[FL_FULL_NAME_INDEX], NAME);
               TRANS_LOG_REC = FULL_INDEX_REC;
               nrf0 = "W"; nrf1 = "FL.FULL.NAME.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref NAME);
            }
         }
         /*  Soundslike Index */
         WORD_COUNT = 1;
         do
         {
            REDUCED_WORD = "";
            WORD = FIELD(NAME, " ", WORD_COUNT);
            if (WORD == "") break;
            if (!(READ(ref TEST, FL_NAME_THROWAWAY, WORD)))
            {
               for (LETTER_COUNT = 1; LETTER_COUNT <= LEN(WORD); LETTER_COUNT += 1)
               {
                  LETTER = WORD.Substring(LETTER_COUNT, 1);
                  if (MATCH(LETTER, "1A") && NOT(INDEX(THROWAWAY_CHARACTERS, LETTER, 1)))
                  {
                     REDUCED_WORD = REDUCED_WORD + LETTER;
                  }
               }
               if (!(READ(ref INDEX_RECORD, COMMON.FILES[FL_SOUNDSLIKE_NAME_INDEX], REDUCED_WORD)))
               {
                  INDEX_RECORD = "";
               }
               if (LOCATE(MEMBER_NO, INDEX_RECORD, 1, 0, 1, ref PNTR, "AL"))
               {
                  /*               LOCATE(INITS,INDEX.RECORD,2;PNTR;'AL') ELSE NULL */
                  INDEX_RECORD = DELETE(INDEX_RECORD, 1, PNTR);
                  INDEX_RECORD = DELETE(INDEX_RECORD, 2, PNTR);
                  INDEX_RECORD = DELETE(INDEX_RECORD, 3, PNTR);
                  INDEX_RECORD = DELETE(INDEX_RECORD, 4, PNTR);
                  if (INDEX_RECORD[1] == "")
                  {
                     nrf0 = "D"; nrf1 = "FL.SOUNDSLIKE.NAME.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REDUCED_WORD);
                  }
                  else
                  {
                     WRITE(INDEX_RECORD, COMMON.FILES[FL_SOUNDSLIKE_NAME_INDEX], REDUCED_WORD);
                     TRANS_LOG_REC = INDEX_RECORD;
                     nrf0 = "W"; nrf1 = "FL.SOUNDSLIKE.NAME.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REDUCED_WORD);
                  }
               }
            }
            WORD_COUNT = WORD_COUNT + 1;
         } while (true);
         /*  Address Index */
         REDUCED_NAME = INIT;
         ADDRESS_LENGTH = LEN(ADDRESS_LINE1);
         for (LETTER_COUNT = 1; LETTER_COUNT <= ADDRESS_LENGTH; LETTER_COUNT += 1)
         {
            LETTER = ADDRESS_LINE1.Substring(LETTER_COUNT, 1);
            if (MATCH(LETTER, "1A") && NOT(INDEX(THROWAWAY_CHARACTERS, LETTER, 1)))
            {
               REDUCED_NAME = REDUCED_NAME + LETTER;
            }
         }
         if (!(REDUCED_NAME == ""))
         {
            if (!(READ(ref INDEX_REC, COMMON.FILES[FL_ADDRESS_INDEX], REDUCED_NAME)))
            {
               INDEX_REC = "";
            }
            if (LOCATE(MEMBER_NO, INDEX_REC, 1, 0, 1, ref PNTR, "AR"))
            {
               INDEX_REC = DELETE(INDEX_REC, 1, PNTR, 0);
               INDEX_REC = DELETE(INDEX_REC, 2, PNTR, 0);
               INDEX_REC = DELETE(INDEX_REC, 3, PNTR, 0);
               INDEX_REC = DELETE(INDEX_REC, 4, PNTR, 0);
            }
            if (INDEX_REC[1] == "")
            {
               nrf0 = "D"; nrf1 = "FL.ADDRESS.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REDUCED_NAME);
            }
            else
            {
               WRITE(INDEX_REC, COMMON.FILES[FL_ADDRESS_INDEX], REDUCED_NAME);
               TRANS_LOG_REC = INDEX_REC;
               nrf0 = "W"; nrf1 = "FL.ADDRESS.INDEX"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REDUCED_NAME);
            }
         }
      }
      void L0100()
      {
         /*  QUICK INDEX */
         if (READU(ref INDEXREC, FL_QUICK_INDEX, NAME))
         {
            INDEXLEN = DCOUNT(INDEXREC, AM);
            FOUND = FALSE;
            for (ILINE = 1; ILINE <= INDEXLEN && NOT(FOUND); ILINE += 1)
            {
               if (INDEXREC[ILINE, 1] == MEMBER_NO)
               {
                  INDEXREC = DEL(INDEXREC[ILINE]);
                  FOUND = TRUE;
               }
            }
            /*         IF NOT(FOUND) THEN */
            /*            PRINT "!WARNING! INDEX FILE NEEDS REGENERATING" */
            /*            SLEEP 5 */
            /*         END */
            if (INDEXREC == "")
            {
               DELETE(FL_QUICK_INDEX, NAME);
               if (READU(ref SURNAME_LIST, FL_QUICK_INDEX, "SURNAME.LIST"))
               {
                  FND = FALSE;
                  SURNAME_LEN = DCOUNT(SURNAME_LIST, AM);
                  for (SLINE = 1; SLINE <= SURNAME_LEN && NOT(FND); SLINE += 1)
                  {
                     if (SURNAME_LIST[SLINE, 2] == NAME)
                     {
                        SURNAME_LIST = DEL(SURNAME_LIST[SLINE]);
                        FND = TRUE;
                     }
                  }
                  if (SURNAME_LIST == "")
                  {
                     DELETE(FL_QUICK_INDEX, "SURNAME.LIST");
                  }
                  else
                  {
                     WRITEU(SURNAME_LIST, FL_QUICK_INDEX, "SURNAME.LIST");
                     RELEASE();
                  }
               }
            }
            else
            {
               WRITEU(INDEXREC, FL_QUICK_INDEX, NAME);
               RELEASE();
            }
         }
         return;
      }
   }
}
