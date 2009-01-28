//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL000_10_1 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar SCREENS = 8;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      UvVar ALL_CLEAR = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar AMD_KEY = "";
      UvVar AMD_REC = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar AM = "";
      UvVar DOTS = "";
      UvVar DIMMED = "";
      UvVar SCREEN_LINE = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar DOT_LINE = "";
      UvVar START_POS = "";
      UvVar PROMPT_LEN = "";
      UvVar REC_LINE = "";
      UvVar REC_COL = "";
      UvVar REC_ROW = "";
      UvVar ATT_MV = "";
      UvVar ATTR = "";
      UvVar MULT = "";
      UvVar DETAIL = "";
      UvVar AMD_NO = "";
      UvVar AMD_COL = "";
      UvVar AMD_ROW = "";
      UvVar INPUT_NO = "";
      FL006 FL006;
      UvVar PROGRAM = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL000_10_1(ref UvVar SCREEN_CODE, ref UvVar DOTS_ONLY)
      {
         this.SCREEN_CODE = SCREEN_CODE;
         this.DOTS_ONLY = DOTS_ONLY;
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
         // STANDARD UTILITY (BOOKINGS)
         // PRINTS SCREEN AND RELEVANT DOTS READY FOR INPUT
         // BUT LOOKS TO SEE IF LINE TO BE DIMMED OR REVERSE VIDEOED
         //****************
         //   FILE USED   *
         //****************
         DIMMED = DIM_VID;
         if (!READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE)) { goto L80; }
         // BEGIN CASE
         // CASE
         if (DOTS_ONLY == 1)
         {
            // PRINT DOTS
            goto L30;
         }// CASE
         else if (DOTS_ONLY == 2)
         {
            // PRINT RECORD
            goto L50;
         }// CASE
         else if (OTHERWISE)
         {
            // PRINT SCREEN ONLY
            goto L10;
         }
      // END CASE
      L10:
         //*****************
         //   PRINT SCREEN   *
         //*******************
         PRINTCR(COMMON.WASH);
         SCREEN_LINES = COUNT(SC_POS, AM) + 1;
         for (SCREEN_LINE = 1; SCREEN_LINE <= SCREEN_LINES; SCREEN_LINE += 1)
         {
            ST_COL = SC_POS[SCREEN_LINE, 1];
            ST_ROW = SC_POS[SCREEN_LINE, 2];
            if (SC_POS[SCREEN_LINE, 7] != "D")
            {
               PRINTCR(AT(ST_COL, ST_ROW) + SC_POS[SCREEN_LINE, 3]);
            }
            else
            {
               PRINT(AT(ST_COL - 1, ST_ROW) + DIMMED + SC_POS[SCREEN_LINE, 3] + NRM_VID);
            }
         }
      L30:
         //***************
         //   PRINT DOTS   *
         //*****************
         SCREEN_LINES = COUNT(SC_POS, AM) + 1;
         for (DOT_LINE = 1; DOT_LINE <= SCREEN_LINES; DOT_LINE += 1)
         {
            if (SC_POS[DOT_LINE, 4])
            {
               START_POS = LEN(SC_POS[DOT_LINE, 3]) + 2;
               PROMPT_LEN = SC_POS[DOT_LINE, 4];
               DOTS = STR(".", PROMPT_LEN);
               ST_COL = SC_POS[DOT_LINE, 1] + START_POS;
               ST_ROW = SC_POS[DOT_LINE, 2];
               PRINT(AT(ST_COL, ST_ROW) + DOTS + AT(ST_COL, ST_ROW));
            }
         }
         ALL_CLEAR = 1;
         goto L90;
      L50:
         //*****************
         //   PRINT RECORD   *
         //*******************
         for (REC_LINE = 1; REC_LINE <= SCREEN_LINES; REC_LINE += 1)
         {
            if (SC_POS[REC_LINE, 4])
            {
               START_POS = LEN(SC_POS[REC_LINE, 3]) + 2;
               REC_COL = SC_POS[REC_LINE, 1] + START_POS;
               REC_ROW = SC_POS[REC_LINE, 2];
               ATT_MV = SC_POS[REC_LINE, 5];
               ATTR = FIELD(ATT_MV, ",", 1);
               MULT = FIELD(ATT_MV, ",", 2);
               if (ATTR == 0) { DETAIL = AMD_KEY; } else { DETAIL = AMD_REC[ATTR, MULT]; }
               AMD_NO = SC_POS[REC_LINE, 6];
               if (AMD_NO != "")
               {
                  if (AMD_NO < 10) { AMD_NO = COMMON.SP[1] + AMD_NO; }
                  AMD_NO = AMD_NO + ")";
               }
               AMD_COL = SC_POS[REC_LINE, 1] - 4;
               AMD_ROW = REC_ROW;
               PRINT(AT(AMD_COL, AMD_ROW) + AMD_NO + AT(REC_COL, REC_ROW) + DETAIL);
            }
         }
         ALL_CLEAR = 1;
         goto L90;
      L80:
         //***************************
         //   ERROR PRINT SUBROUTINE   *
         //*****************************
         INPUT_NO = 1;
         nrf0 = INIT; FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
         // PRINT ERROR
         ALL_CLEAR = 0;
         goto L90;
      L90:
         // THE END
         return;
      }
   }
}
