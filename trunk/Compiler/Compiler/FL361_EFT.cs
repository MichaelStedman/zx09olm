//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL361_EFT : UvBase
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
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar CREDIT_CARD_REFERENCE = "";
      UvVar CREDIT_CARD_EXPIRY = "";
      UvVar CREDIT_CARD_AUTH_CODE = "";
      UvVar INPUT_COL = "";
      UvVar EFT_SITE = "";
      UvVar SWIPE_DETAILS = "";
      UvVar CREDIT_CARD_START = "";
      UvVar CREDIT_CARD_ISSUE = "";
      UvVar CARD_CVS = "";
      UvVar PORT_NUMBER = "";
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar REV_VID = "";
      UvVar DIM_REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar CLIENT_APP_TYPE = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar FL_EFT_SHARE = "";
      UvVar CHIPANDPIN = "";
      UvVar CHIPANDPINREC = "";
      UvVar POS = "";
      UvVar ANS2 = "";
      UvVar ANS3 = "";
      UvVar ANS4 = "";
      UvVar ANS5 = "";
      UvVar ANS6 = "";
      UvVar RESPONSE = "";
      UvVar PROMPT_FOR_CVS = "";
      UvVar CUTOFF = "";
      UvVar LENGTH = "";
      UvVar LRC_DIGIT = "";
      UvVar AUTO_EXP = "";
      UvVar AUTO_YY = "";
      UvVar AUTO_MM = "";
      UvVar EFT_ANS = "";
      FL362 FL362;
      FL006 FL006;
      UvVar VALUE1 = "";
      FL019 FL019;
      UvVar EXP_MONTH = "";
      UvVar EXP_YEAR = "";
      UvVar CURRENT_DATE = "";
      UvVar CURRENT_YEAR = "";
      UvVar ANS1 = "";
      UvVar PROMPT_FOR_ISSUE = "";
      FL_EFT_CARD FL_EFT_CARD;
      UvVar PROMPT_FOR_START = "";
      UvVar ISSUE_LEN = "";
      UvVar EFT_EXP = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL361_EFT(ref UvVar ST_COL, ref UvVar ST_ROW, ref UvVar CREDIT_CARD_REFERENCE, ref UvVar CREDIT_CARD_EXPIRY, ref UvVar CREDIT_CARD_AUTH_CODE, ref UvVar INPUT_COL, ref UvVar EFT_SITE, ref UvVar SWIPE_DETAILS, ref UvVar CREDIT_CARD_START, ref UvVar CREDIT_CARD_ISSUE, ref UvVar CARD_CVS)
      {
         this.ST_COL = ST_COL;
         this.ST_ROW = ST_ROW;
         this.CREDIT_CARD_REFERENCE = CREDIT_CARD_REFERENCE;
         this.CREDIT_CARD_EXPIRY = CREDIT_CARD_EXPIRY;
         this.CREDIT_CARD_AUTH_CODE = CREDIT_CARD_AUTH_CODE;
         this.INPUT_COL = INPUT_COL;
         this.EFT_SITE = EFT_SITE;
         this.SWIPE_DETAILS = SWIPE_DETAILS;
         this.CREDIT_CARD_START = CREDIT_CARD_START;
         this.CREDIT_CARD_ISSUE = CREDIT_CARD_ISSUE;
         this.CARD_CVS = CARD_CVS;
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
         /*  Credit Card Reference & Expiry Date */
         PROMPT("");
         /*      PROGRAM = "FT320.2" ; ! Left this string in place to allow searches on error message number */
         PROGRAM = "FL361.EFT";
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.EFT.SHARE

         if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE))
         {
         }
         else
         {
            if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
         }

         #endregion
         /*   Initialize Variables         * */
         /*  if this till has a chip and pin device - allow blank card no */
         CHIPANDPIN = FALSE;
         if (!READ(ref CHIPANDPINREC, FL_EFT_SHARE, "CHIPANDPIN.PORTS")) { CHIPANDPINREC = FALSE; }
         if (CHIPANDPINREC[1] == TRUE)
         {
            if (CHIPANDPINREC[2] == "ALL")
            {
               CHIPANDPIN = TRUE;
            }
            if (LOCATE(PORT_NUMBER, CHIPANDPINREC, 2, 0, 1, ref POS, "AL"))
            {
               CHIPANDPIN = TRUE;
            }
         }
         /* ! REMOVE NEXT LINE AFTER TEST */
         /*      OPEN 'FL.TEST.CARDS' TO FL.TEST.CARDS ELSE STOP 201 , 'FL.TEST.CARDS' */
         ANS2 = INIT;
         ANS3 = INIT;
         ANS4 = INIT;
         ANS5 = INIT;
         ANS6 = INIT;
         RESPONSE = INIT;
         CREDIT_CARD_START = INIT;
         CREDIT_CARD_ISSUE = INIT;
         SWIPE_DETAILS = INIT;
         /* !*     CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
         if (!(READV(ref CARD_CVS, COMMON.FILES[FL_CONTROL], "EFT.CARD.CVS", 1)))
         {
            CARD_CVS = FALSE;
         }
         if (CARD_CVS == TRUE)
         {
            PROMPT_FOR_CVS = TRUE;
         }
         else
         {
            PROMPT_FOR_CVS = FALSE;
         }
         /*  Main Process                  * */
         do
         {
            if (RESPONSE == VALID_DATA || ANS2 == COMMON.ABANDON) break;
            if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
            {
               PRINT(CHAR(28) + "404");
               PRINT("Enter CC Reference");
               PRINTCR(".............");
               PRINT(CHAR(20));
               PRINT(CHAR(28) + "404");
               PRINT("Exp Date");
               PRINTCR("....");
               PRINT(CHAR(20));
            }
            PRINT(AT(INPUT_COL - 3, ST_ROW + 1) + DIM_REV_VID + STR(".", 22));
            if (CHIPANDPIN)
            {
               PRINT(" " + REV_VID + "Enter for C&P" + DIM_REV_VID);
            }
            PRINT(AT(INPUT_COL - 3, ST_ROW + 1));
            INPUT(out ANS2, 22);
            /* ** */
            /*  IF CHIP AND PIN READER AND OPERATOR DOES NOT TYPE NUMBER THEN CONTINUE AS CHIP AND PIN TX */
            /* * */
            if (ANS2 == "" && CHIPANDPIN == TRUE)
            {
               PRINT(AT(0, 0) + NRM_VID);
               return;
            }
            if (CHIPANDPIN == TRUE)
            {
               PRINT(AT(INPUT_COL + 19, ST_ROW + 1) + STR(" ", 14));
            }
            /* *! REMOVE THIS AFTER TEST */
            /*        FULLANS = '' */
            /*        IF ANS2[1,1] = 'T' OR ANS2[1,1] = 'K' THEN */
            /*          READ FULLANS FROM FL.TEST.CARDS , ANS2 ELSE FULLANS = '' */
            /*        END */
            /*        IF FULLANS # '' THEN */
            /*          ANS2 = FULLANS<1> */
            /*        END */
            /*  REMOVE ENDS */
            if (INDEX(ANS2, "=", 1) > 0 || ANS2.Substring(1, 1) == "%")
            {
               ECHO_OFF();
               if (EFT_SITE)
               {
                  INPUT(out ANS3, 99);
               }
               else
               {
                  INPUT(out ANS3, 18);
               }
               ECHO_ON();
               ANS2 = ANS2 + ANS3;
               if (ANS2.Substring(1, 1) == "%")
               {
                  ANS2 = FIELD(ANS2, "?", 2) + "?";
               }
               CUTOFF = INDEX(ANS2, "�", 1);
               if (CUTOFF > 2)
               {
                  ANS2 = ANS2.Substring(1, CUTOFF - 1);
               }
               if (LEN(ANS2) > 80)
               {
                  CUTOFF = INDEX(ANS2, "?", 1);
                  if (CUTOFF > 2) { ANS2 = ANS2.Substring(1, CUTOFF); }
               }
               LENGTH = LEN(ANS2);
               LRC_DIGIT = ANS2.Substring(LENGTH - 1, 1);
               if (ANS2.Substring(1, 1) == ";" && LRC_DIGIT != "?")
               {
                  ANS2 = ANS2 + "0";
               }
               if (INDEX(ANS2, ";", 1) == 0)
               {
                  ANS2 = ";" + ANS2 + "?0";
               }
               AUTO_EXP = FIELD(ANS2, "=", 2).Substring(1, 4);
               if (AUTO_EXP == "0000") { AUTO_EXP = ""; /* Dont Except Tesco Cards */ }
               AUTO_YY = AUTO_EXP.Substring(1, 2);
               AUTO_MM = AUTO_EXP.Substring(3, 2);
               /*            SWIPE.DETAILS = ANS2: ANS3 */
               SWIPE_DETAILS = ANS2;
               ANS2 = FIELD(ANS2, "=", 1).Substring(2, 21);
               PROMPT_FOR_CVS = FALSE;
            }
            else
            {
               AUTO_EXP = "";
            }
            if (ANS2 == INIT && AUTO_EXP == INIT) { ANS2 = CREDIT_CARD_REFERENCE; }
            if (!(ANS2 == COMMON.ABANDON))
            {
               EFT_ANS = ANS2;
               FL362 = new FL362(ref ANS2, ref RESPONSE);
               if (EFT_SITE) { ANS2 = EFT_ANS; /*  DONT PUT THE LEADING ZEROS */ }
               if (RESPONSE == INVALID_DATA)
               {
                  nrf0 = 8;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
         } while (true);
         if (INDEX(SWIPE_DETAILS, "??", 1) > 0)
         {
            SWIPE_DETAILS = CHANGE(SWIPE_DETAILS, "??");
         }
         if (ANS2 == COMMON.ABANDON) { goto L999; }
         VALUE1 = ANS2;
         PRINT(AT(INPUT_COL - 3, ST_ROW + 1) + FORMAT(VALUE1, "L#22"));
         /*  Expiry Date */
         INTERACT = INVALID_DATA;
         ANS3 = INIT;
         do
         {
            if (INTERACT == VALID_DATA || ANS3 == COMMON.ABANDON) break;
            PRINT(AT(ST_COL + 2, ST_ROW + 1) + STR(".", 4));
            PRINT(AT(ST_COL + 2, ST_ROW + 1));
            if (AUTO_EXP == "")
            {
               nrf0 = 5;
               FL019 = new FL019(ref nrf0, ref ANS3);
            }
            else
            {
               ANS3 = AUTO_MM + AUTO_YY;
            }
            if (ANS3 == INIT) { ANS3 = CREDIT_CARD_EXPIRY; }
            if (ANS3 == COMMON.ABANDON)
            {
               INTERACT = INVALID_DATA;
               ANS2 = COMMON.ABANDON;
            }
            else
            {
               if (NOT(MATCH(ANS3, "4N")) || ANS3 > "1299")
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 9;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
               else
               {
                  EXP_MONTH = ANS3.Substring(1, 2);
                  EXP_YEAR = ANS3.Substring(3, 2);
                  if (EXP_YEAR < 30)
                  {
                     EXP_YEAR = 20 + EXP_YEAR;
                  }
                  else
                  {
                     EXP_YEAR = 19 + EXP_YEAR;
                  }
                  CURRENT_DATE = OCONV(TODAYS_DATE, "D4/");
                  CURRENT_YEAR = CURRENT_DATE.Substring(7, 4) + CURRENT_DATE.Substring(4, 2);
                  if (EXP_YEAR + EXP_MONTH < CURRENT_YEAR)
                  {
                     if (AUTO_EXP != "")
                     {
                        ANS3 = COMMON.ABANDON;
                        nrf0 = 78;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        ANS2 = COMMON.ABANDON;
                        ANS1 = COMMON.ABANDON;
                        INTERACT = INVALID_DATA;
                     }
                     else
                     {
                        nrf0 = 77;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                        INTERACT = INVALID_DATA;
                     }
                  }
                  else
                  {
                     INTERACT = VALID_DATA;
                     PRINTCR(AT(ST_COL + 2, ST_ROW + 1) + ANS3);
                  }
               }
            }
            /*  abort if swipe has problem */
         } while (true);
         /*  Authorisation Code (Unless otherwise set in FT.CONTROL) */
         ANS4 = "";
         /* DJA 17.4.00*  PROMPT.FOR.ISSUE = FALSE */
         /* DJA 17.4.00*  READ CARD.CONTROL FROM FL.CONTROL, "EFT.CARD.CONTROL" ELSE */
         /* DJA 17.4.00*    CALL FL006(PROGRAM,99,"") ; * MISSING EFT.CARD.CONTROL */
         /* DJA 17.4.00*    CARD.CONTROL = "" */
         /* DJA 17.4.00*  END */
         /* DJA 17.4.00* */
         FL_EFT_CARD = new FL_EFT_CARD(ref PROGRAM, ref ANS2, ref PROMPT_FOR_START, ref PROMPT_FOR_ISSUE, ref ISSUE_LEN);
         /* DJA 17.4.00*  CRD.CHK = ANS2[1,6] */
         /* DJA 17.4.00*  CRD.MAX = DCOUNT(CARD.CONTROL,AM) */
         /* DJA 17.4.00*  CRD.CNT = 0 */
         /* DJA 17.4.00*  DONE = FALSE */
         /* DJA 17.4.00*  PROMPT.FOR.START = FALSE */
         /* DJA 17.4.00*  PROMPT.FOR.ISSUE = FALSE */
         /* DJA 17.4.00*  LOOP */
         /* DJA 17.4.00*    CRD.CNT = CRD.CNT + 1 */
         /* DJA 17.4.00*    UNTIL CRD.CNT > CRD.MAX OR DONE DO */
         /* DJA 17.4.00*    IF CRD.CHK GE CARD.CONTROL<CRD.CNT,1> AND CRD.CHK LE CARD.CONTROL<CRD.CNT,2> THEN */
         /* DJA 17.4.00*      IF CARD.CONTROL<CRD.CNT,4> = TRUE THEN PROMPT.FOR.START = TRUE */
         /* DJA 17.4.00*      IF CARD.CONTROL<CRD.CNT,5> > 0 THEN */
         /* DJA 17.4.00*        PROMPT.FOR.ISSUE = TRUE */
         /* DJA 17.4.00*        ISSUE.LEN = CARD.CONTROL<CRD.CNT,5> */
         /* DJA 17.4.00*      END */
         /* DJA 17.4.00*      DONE = TRUE */
         /* DJA 17.4.00*    END */
         /* DJA 17.4.00*  REPEAT */
         /*  GET Switch Issue */
         /* ** */
         if (PROMPT_FOR_ISSUE && AUTO_EXP == "")
         {
            do
            {
               PRINT(ERR_LINE + COMMON.EOL + ERR_LINE + DIM_VID + "Enter " + ISSUE_LEN + " Digit  Switch Issue Number " + NRM_VID);
               INPUT(out ANS5, ISSUE_LEN + 1);
               PRINTCR(AT(INPUT_COL - 3, ST_ROW + 1) + ANS2 + "(" + ANS5 + ")");
               /*          UNTIL ANS5 = ABANDON OR (NUM(ANS5) AND LEN(ANS5)<=ISSUE.LEN) DO */
               if (ANS5 == COMMON.ABANDON || (NUM(ANS5) && LEN(ANS5) == ISSUE_LEN)) break;
               nrf0 = 10; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            } while (true);
            PRINT(ERR_LINE + COMMON.EOL);
         }
         if (PROMPT_FOR_CVS == TRUE)
         {
            do
            {
               PRINT(ERR_LINE + NRM_VID + COMMON.EOL + ERR_LINE + DIM_VID + "Enter Signature Strip 3/4 digit number " + NRM_VID);
               INPUTCR(out CARD_CVS, 5);
               if (CARD_CVS == COMMON.ABANDON || (NUM(CARD_CVS) && LEN(CARD_CVS) >= 3)) break;
               nrf0 = 19; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            } while (true);
            PRINTCR(ERR_LINE + COMMON.EOL);
         }
         if (CARD_CVS == COMMON.ABANDON) { CARD_CVS = ""; }
         /* ** */
         /*  Get Start Date */
         /* * */
         if (PROMPT_FOR_START && AUTO_EXP == "")
         {
            do
            {
               PRINT(ERR_LINE + COMMON.EOL + ERR_LINE + DIM_VID + "Enter Start Date " + NRM_VID);
               INPUT(out ANS6, 5);
               PRINTCR(AT(INPUT_COL - 3, ST_ROW + 1) + ANS2 + "(" + ANS5 + ANS6 + ")");
               INTERACT = INVALID_DATA;
               // BEGIN CASE
               // CASE
               if (ANS6 == "")
               {
                  INTERACT = VALID_DATA;
               }// CASE
               else if (ANS6 == COMMON.ABANDON)
               {
                  INTERACT = VALID_DATA;
               }// CASE
               else if (ANS6 < 1300)
               {
                  EFT_EXP = ANS6 + 10000;
                  ANS6 = EFT_EXP.Substring(4, 2) + EFT_EXP.Substring(2, 2);
                  INTERACT = VALID_DATA;
               }
               // END CASE
               if (INTERACT == VALID_DATA) break;
            } while (true);
            PRINT(ERR_LINE + COMMON.EOL);
         }
         if (ANS5 == COMMON.ABANDON || ANS6 == COMMON.ABANDON) { ANS2 = COMMON.ABANDON; /*  ABORT PROPERLY */ }
      L999: ;
         CREDIT_CARD_REFERENCE = ANS2;
         CREDIT_CARD_EXPIRY = ANS3;
         CREDIT_CARD_AUTH_CODE = ANS4;
         CREDIT_CARD_ISSUE = ANS5;
         CREDIT_CARD_START = ANS6;
         PRINT(AT(0, ST_ROW + 1) + NRM_VID + COMMON.EOL);
         if (CREDIT_CARD_REFERENCE == COMMON.ABANDON || CREDIT_CARD_EXPIRY == COMMON.ABANDON || CREDIT_CARD_AUTH_CODE == COMMON.ABANDON || CREDIT_CARD_ISSUE == COMMON.ABANDON)
         {
            PRINT(AT(INPUT_COL - 3, ST_ROW + 1) + SPACE(22));
            PRINT(AT(ST_COL, ST_ROW) + SPACE(7));
            PRINT(AT(ST_COL + 2, ST_ROW + 1) + SPACE(4));
            PRINT(AT(ST_COL + 6, ST_ROW + 1) + SPACE(2));
            INTERACT = COMMON.ABANDON;
         }
         return;
      }
   }
}
