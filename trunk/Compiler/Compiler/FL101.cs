//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL101 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_TICKET_CONTROL = 19;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] TICK_CONTROL_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar ALL_CLEAR = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar SCREEN_WIDTH = "";
      UvVar TRANS_LOG_REC = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar DOTS_ONLY = "";
      FL000_10 FL000_10;
      UvVar JUST = "";
      UvVar SP_CODE = "";
      UvVar TEXT_ID = "";
      UvVar TEXT = "";
      UvVar AMEND = "";
      UvVar LINE_POS = "";
      UvVar ANS = "";
      UvVar AMD_NUM = "";
      FLTX2 FLTX2;
      UvVar INPUT_NO = "";
      FL006 FL006;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL101()
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
         /*  CASUAL ACTIVITY TICKET MAINTENANCE */
         /* FILE NAMES */
         #region INCLUDE FL.FILES FL.TICKET.CONTROL

         #endregion
         PROGRAM = "FL101";
      L10: ;
         SCREEN_CODE = "FL101";
         DOTS_ONLY = FALSE;
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINT(AT(0, 4) + SCREEN_BACK + SCREEN_TEXT);
         PRINT(AT(2, 4) + "Activity code... [   ]");
         /*      PRINT @(30,4):'Activity Name.. 1. [                    ]': */
         PRINTCR(AT(23, 10) + "....+....1....+....2....+....3....+....4....+....5..");
         PRINTCR(AT(2, 11) + "Text for tickets 1. [                                                    ]");
         PRINTCR(AT(2, 12) + "                 2. [                                                    ]");
         PRINTCR(AT(2, 13) + "                 3. [                                                    ]");
         PRINTCR(AT(2, 14) + "                 4. [                                                    ]");
         PRINTCR(AT(2, 15) + "                 5. [                                                    ]");
         PRINTCR(AT(2, 16) + "                 6. [                                                    ]");
         PRINTCR(AT(2, 17) + "                 7. [                                                    ]");
         PRINTCR(AT(2, 18) + "                 8. [                                                    ]");
         PRINTCR(AT(2, 19) + "                 9. [                                                    ]");
         PRINTCR(AT(2, 20) + "                10. [                                                    ]");
         JUST = "L#" + SCREEN_WIDTH;
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
         PRINT(AT(0, 22) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
         PRINT(AT(2, 22) + SPACE(SCREEN_WIDTH - 2));
      L30: ;
         PRINT(AT(0, 4) + SCREEN_BACK + SCREEN_TEXT);
         PRINT(AT(20, 4) + COMMON.SP[3] + AT(20, 4));
         INPUT(out SP_CODE, 4);
         if (LEN(SP_CODE) > 3) { PRINT(AT(-9) + "]"); SP_CODE = SP_CODE.Substring(1, 3); }
         if (SP_CODE == "" || SP_CODE == COMMON.ABANDON)
         {
            return;
         }
         TEXT_ID = SP_CODE + ".TEXT";
         if (!(READ(ref TEXT, COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID)))
         {
            AMEND = FALSE;
            TEXT = "";
            goto L40;
         }
         if (TEXT != "")
         {
            for (LINE_POS = 1; LINE_POS <= 10; LINE_POS += 1)
            {
               PRINTCR(AT(23, LINE_POS + 10) + TEXT[LINE_POS]);
            }
         }
         goto L50;
      /* ********************************* */
      L40: ;
         /*  TEXT FOR TICKETS */
         LINE_POS = 1;
         TEXT = "";
      L499: ;
         do
         {
            if (LINE_POS == 11) break;
            PRINT(AT(23, LINE_POS + 10) + SPACE(50) + AT(23, LINE_POS + 10));
            INPUTCR(out ANS, 50);
            if (ANS == "")
            {
               PRINT(AT(23, LINE_POS + 10) + TEXT[LINE_POS]);
               goto L50;
            }
            if (ANS != "")
            {
               TEXT[LINE_POS] = ANS;
            }
            if (ANS == COMMON.CLR)
            {
               ANS = "";
               TEXT[LINE_POS] = ANS;
               PRINT(AT(23, LINE_POS + 10) + SPACE(50));
            }
            if (AMEND)
            {
               goto L50;
            }
            LINE_POS = LINE_POS + 1;
         } while (true);
      L50: ;
         /*  Amend Fields */
         AMEND = TRUE;
         AMD_NUM = "";
         PRINT(AT(0, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
         PRINT(AT(2, 22) + " Enter line No., DEL or press <RETURN> to file record [   ]" + AT(57, 22));
         INPUT(out AMD_NUM, 4);
         if (LEN(AMD_NUM) > 3) { PRINT(AT(-9) + "]"); AMD_NUM = AMD_NUM.Substring(1, 3); }
         PRINT(AT(0, 22) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
         PRINT(AT(2, 22) + SPACE(SCREEN_WIDTH - 2) + SCREEN_TEXT + SCREEN_BACK);
         if (AMD_NUM == COMMON.ABANDON)
         {
            goto L10;
         }
         if (AMD_NUM.Substring(1, 1) == "D" && AMD_NUM.Substring(2, 2) > 0 && AMD_NUM.Substring(2, 2) < 12)
         {
            LINE_POS = AMD_NUM.Substring(2, 2);
            PRINT(AT(23, LINE_POS + 10) + SPACE(50));
            TEXT[LINE_POS] = "";
            goto L50;
         }
         if (AMD_NUM > 0 && AMD_NUM < 12)
         {
            LINE_POS = AMD_NUM;
            goto L499;
         }
         if (AMD_NUM == "DEL")
         {
            nrf0 = "D";
            nrf1 = "FL.TICKET.CONTROL";
            FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TEXT_ID);
            DELETE(COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID);
            goto L10;
         }
         if (AMD_NUM != "")
         {
            INPUT_NO = 2;
            L100();
            goto L50;
         }
         /*     IF AMD.NUM = '' THEN */
         TRANS_LOG_REC = TEXT;
         nrf0 = "W";
         nrf1 = "FL.TICKET.CONTROL";
         FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TEXT_ID);
         WRITE(TEXT, COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID);
         goto L10;
         /*     END */
      }
      void L100()
      {
         /*  Error print routine for fatal errors */
         nrf0 = INIT;
         FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
         ALL_CLEAR = FALSE;
         return;
         /*  End of Program */
      }
   }
}
