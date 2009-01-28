//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL994 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_OLD_TICKETS = 38;
      readonly UvVar OLD_TICK_CODE = 1;
      readonly UvVar OLD_TICK_UNIT = 2;
      readonly UvVar OLD_TICK_UNIT_PRICE = 3;
      readonly UvVar OLD_TICK_DATE = 4;
      readonly UvVar OLD_TICK_TIME = 5;
      readonly UvVar OLD_TICK_TOTAL = 6;
      readonly UvVar OLD_TICK_MOP = 7;
      readonly UvVar OLD_TICK_CLERK = 8;
      readonly UvVar OLD_TICK_TILL = 9;
      readonly UvVar OLD_TICK_MEMBER = 10;
      readonly UvVar OLD_TICK_PERIOD = 11;
      readonly UvVar OLD_VAT_PART = 12;
      readonly UvVar OLD_TICK_CONCESS = 13;
      readonly UvVar OLD_TICK_CC_REF = 14;
      readonly UvVar OLD_TICK_CC_EXP = 15;
      readonly UvVar OLD_TICK_SESSION = 16;
      readonly UvVar OLD_TICK_LEDGER = 17;
      readonly UvVar OLD_TICK_LEDGER_CODE = 18;
      readonly UvVar OLD_TICK_GROUP = 19;
      readonly UvVar OLD_TICK_BB_REF = 20;
      readonly UvVar OLD_TICK_HCOUNT = 21;
      readonly UvVar OLD_TICK_ACT_DATE = 22;
      readonly UvVar OLD_TICK_CUST_NAME = 23;
      readonly UvVar OLD_TICK_BONUS_PTS = 24;
      readonly UvVar OLD_TICK_PROMOTION = 25;
      readonly UvVar OLD_TICK_CANCEL = 26;
      readonly UvVar OLD_TICK_REDEEMED = 27;
      readonly UvVar OLD_TICK_POINTS_REDEEMED = 28;
      readonly UvVar OLD_EFT_SEQNO = 30;
      readonly UvVar OLD_EFT_SWIPE = 31;
      readonly UvVar OLD_TICK_ORIGINAL_NO = 32;
      readonly UvVar OLD_TICK_VAT_IND = 33;
      readonly UvVar OLD_TICK_HOME_CENTRE = 34;
      readonly UvVar OLD_HH_TICK_NO = 35;
      readonly UvVar OLD_APACS_NO = 36;
      readonly UvVar OLD_STUDENT_ID = 37;
      readonly UvVar OLD_COURSE_DETAILS_ID = 38;
      readonly UvVar FL_FINANCE_DESCRIPTIONS = 103;
      readonly UvVar FIN_DESCRIPTION = 1;
      readonly UvVar FIN_DAY_TARGET = 2;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] OLD_TICKET_REC = new UvVar[40];
      UvVar[] FIN_DESC_REC = new UvVar[3];
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar PORT_NUMBER = "";
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERROR = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar EXECUTE_PROG = "";
      UvVar PROGRAM = "";
      FL000_10 FL000_10;
      UvVar REPORT_TITLE = "";
      UvVar REPORT_STYLE = "";
      UvVar SCREEN_STYLE = "";
      UvVar SCREEN_HEAD = "";
      UvVar FDATE = "";
      UvVar TEST_FDATE = "";
      UvVar FIRST_DATE = "";
      UvVar LDATE = "";
      UvVar TEST_LDATE = "";
      UvVar LAST_DATE = "";
      UvVar DATES = "";
      UvVar CONFIRMATION = "";
      UvVar REPORT = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGES = "";
      UvVar OTHERS = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar LCNT = "";
      UvVar PAGE_NO = "";
      FL_GET_EXPORT FL_GET_EXPORT;
      UvVar HTM_FOLDER = "";
      UvVar HTM_SHARE = "";
      UvVar SEQFILENAME = "";
      UvVar SEQFILE = "";
      FL006 FL006;
      UvVar LINECOUNT = "";
      UvVar SPECIAL = "";
      FL_HTM FL_HTM;
      UvVar TEXTOUT = "";
      UvVar GROUP_DESC = "";
      UvVar LAST_GROUP_CODE = "";
      UvVar GROUP_TOTAL = "";
      UvVar DATE_TOTAL = "";
      UvVar GRAND_TOTAL = "";
      UvVar EOF = "";
      UvVar ID = "";
      UvVar GROUP_ID = "";
      UvVar GROUP_CODE = "";
      UvVar THIS_DATE = "";
      UvVar PAY_REF = "";
      UvVar AMOUNT = "";
      UvVar APPCOM = "";
      UvVar WAIT = "";
      UvVar OUTPUT_LINE = "";
      UvVar OUTPUT_STYLE = "";
      UvVar OUTPUT_COLOUR = "";
      UvVar ACTIVITY_DESC = "";
      UvVar SPORT_CODE = "";
      UvVar CODE_ID = "";
      UvVar ZZZ_LN = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL994()
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
         /*  Launch HTML reconciliation by group code */
         /*  Written for Warrington's Civica Paylink XML Interface */
         /*  Assumes all activities are bookings when retrieving activity desc. */
         /*  from FL.FINANCE.DETAILS and that tickets are NOT multivalued, i.e. */
         /*  one detail line per ticket */
         /*  (Based upon FL386 & FL482.HTM) */
         #region INCLUDE FL.FILES FL.OLD.TICKETS

         #endregion
         #region INCLUDE FL.FILES FL.FINANCE.DESCRIPTIONS

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         PROGRAM = "FL994";
         nrf0 = 0;
         FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
         REPORT_TITLE = "Payments by Group - " + TIMEDATE();
         REPORT_STYLE = "8R";
         /*     SCREEN.STYLE = "BCb" */
         SCREEN_STYLE = "BLb";
         /* !!  SCREEN.HEAD = "Transaction Date        ":VM:"Reference      ":VM:"Group":VM:"Description":VM:"Amount" */
         SCREEN_HEAD = FORMAT("Transaction Date", "L#25") + VM + FORMAT("Reference", "L#20") + VM + FORMAT("Group", "L#40") + VM + FORMAT("Description", "L#20") + VM + FORMAT("Amount", "R#12");
         /*  prompt for dates */
         do
         {
            PRINT(AT(0, 4) + COMMON.EOS);
            PRINTCR(AT(10, 5) + "This process displays its results in a browser.");
            PRINT(AT(10, 10) + "Input First Date of Range " + COMMON.EOL);
            PRINT(AT(10, 12) + "Input Last  Date of Range " + COMMON.EOL);
            do
            {
               PRINT(AT(45, 10) + COMMON.EOL);
               PRINT(AT(45, 10));
               INPUT(out FDATE, 12);
               if (FDATE == "")
               {
                  FDATE = OCONV(TODAYS_DATE - 1, COMMON.D2);
               }
               TEST_FDATE = ICONV(FDATE, COMMON.D2);
               if (TEST_FDATE != "" || FDATE == COMMON.ABANDON || FDATE == "") break;
            } while (true);
            if (FDATE == COMMON.ABANDON || FDATE == "")
            {
               return;
            }
            FIRST_DATE = OCONV(TEST_FDATE, "D");
            PRINTCR(AT(45, 10) + FIRST_DATE);
            do
            {
               PRINT(AT(45, 12) + COMMON.EOL);
               PRINT(AT(45, 12));
               INPUT(out LDATE, 12);
               if (LDATE == "")
               {
                  LDATE = OCONV(TODAYS_DATE - 1, COMMON.D2);
               }
               TEST_LDATE = ICONV(LDATE, COMMON.D2);
               if (TEST_LDATE < TEST_FDATE)
               {
                  TEST_LDATE = "";
               }
               if (TEST_LDATE != "" || LDATE == COMMON.ABANDON) break;
            } while (true);
            if (LDATE == COMMON.ABANDON)
            {
               return;
            }
            LAST_DATE = OCONV(TEST_LDATE, "D");
            PRINT(AT(45, 12) + LAST_DATE);
            if (LDATE != FDATE)
            {
               DATES = "WITH DATE GE \"" + FIRST_DATE + "\" AND WITH DATE LE \"" + LAST_DATE + "\"";
            }
            else
            {
               DATES = "DATE WITH DATE EQ \"" + FIRST_DATE + "\"";
            }
            PRINT(AT(10, 18) + "Please type \"Y\" to proceed  ");
            INPUT(out CONFIRMATION, 2);
            CONFIRMATION = OCONV(CONFIRMATION, "MCU");
            if (CONFIRMATION == "Y" || CONFIRMATION == "N" || CONFIRMATION == ".") break;
         } while (true);
         if (CONFIRMATION == "N" || CONFIRMATION == ".") { return; }
         REPORT = "SSELECT FL.OLD.TICKETS BY GROUP.CODE BY DATE BY 1 " + DATES;
         nrf0 = "SO";
         CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref REPORT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
         LCNT = 0;
         PAGE_NO = 1;
         if (LIST_AVAILABLE)
         {
            /* ****************** */
            nrf0 = "HTM";
            FL_GET_EXPORT = new FL_GET_EXPORT(ref nrf0, ref HTM_FOLDER, ref HTM_SHARE);
            SEQFILENAME = HTM_FOLDER + PROGRAM + ".HTM";
            if (!(OPENSEQ(SEQFILENAME, out SEQFILE)))
            {
               if (!(CREATE(SEQFILE)))
               {
                  nrf0 = 51; nrf1 = ""; FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  return;
               }
            }
            if (!(READV(ref LINECOUNT, COMMON.FILES[FL_CONTROL], "HTM.PARAMS*" + PORT_NUMBER, 1)))
            {
               if (!(READV(ref LINECOUNT, COMMON.FILES[FL_CONTROL], "HTM.PARAMS", 1)))
               {
                  LINECOUNT = 60;
               }
            }
            SPECIAL = -2;
            nrf0 = "";
            FL_HTM = new FL_HTM(ref REPORT_TITLE, ref nrf0, ref REPORT_STYLE, ref TEXTOUT, ref SPECIAL);
            L8900();
            L0400();
            /*  Sub headings */
            LCNT = 0;
            GROUP_DESC = "";
            LAST_GROUP_CODE = "";
            LAST_DATE = "";
            GROUP_TOTAL = 0;
            DATE_TOTAL = 0;
            GRAND_TOTAL = 0;
            EOF = FALSE;
            do
            {
               if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
               if (EOF) break;
               if (!MATREAD(ref OLD_TICKET_REC, COMMON.FILES[FL_OLD_TICKETS], ID)) { MAT(ref OLD_TICKET_REC, ""); }
               /*  Filter out non-bookings for easier testing */
               if (FIELD(OLD_TICKET_REC[OLD_TICK_CODE][1, 1], "*", 1) == "B")
               {
                  GROUP_ID = OLD_TICKET_REC[19][1, 1];
                  /* !!           READV GROUP.DESC FROM FL.FINANCE.DESCRIPTIONS,("2*":GROUP.ID),1 ELSE GROUP.DESC = "" */
                  GROUP_DESC = FORMAT(GROUP_ID, "L#20");
                  L510();
                  /*  Retrieve activity description */
                  GROUP_CODE = OLD_TICKET_REC[OLD_TICK_GROUP];
                  THIS_DATE = OLD_TICKET_REC[OLD_TICK_DATE][1, 1];
                  if (GROUP_CODE != LAST_GROUP_CODE && LAST_GROUP_CODE != "")
                  {
                     /*  Output total for previous group */
                     L0040();
                     /*  Date sub total */
                     L0050();
                     /*  Group Sub-total */
                     GROUP_TOTAL = 0;
                     DATE_TOTAL = 0;
                     LAST_DATE = "";
                  }
                  else
                  {
                     if (THIS_DATE != LAST_DATE && LAST_DATE != "")
                     {
                        L0040();
                        /*  Date sub total */
                        DATE_TOTAL = 0;
                     }
                  }
                  LAST_DATE = THIS_DATE;
                  LAST_GROUP_CODE = GROUP_CODE;
                  PAY_REF = OLD_TICKET_REC[OLD_EFT_SEQNO][1, 2];
                  AMOUNT = OCONV(OLD_TICKET_REC[OLD_TICK_TOTAL][1, 1], "MD2");
                  L0100();
                  /*  Render detail line */
                  DATE_TOTAL = DATE_TOTAL + OLD_TICKET_REC[OLD_TICK_TOTAL][1, 1];
                  GROUP_TOTAL = GROUP_TOTAL + OLD_TICKET_REC[OLD_TICK_TOTAL][1, 1];
                  GRAND_TOTAL = GRAND_TOTAL + OLD_TICKET_REC[OLD_TICK_TOTAL][1, 1];
               }
            } while (true);
            L0040();
            /*  Date sub-total */
            L0050();
            /*  Print final group total */
            L0200();
            /*  Print grand total */
            SPECIAL = -9;
            nrf0 = "";
            nrf1 = "";
            FL_HTM = new FL_HTM(ref REPORT_TITLE, ref nrf0, ref nrf1, ref TEXTOUT, ref SPECIAL);
            L8900();
            WEOFSEQ(SEQFILE);
            CLOSESEQ(SEQFILE);
            APPCOM = HTM_SHARE + PROGRAM + ".HTM";
            PRINTCR(APPCOM);
            PRINTCR(CHAR(28) + "4,IEXPLORE," + APPCOM + CHAR(20));
            CRT(3);
            /* ****************** */
         }
         else
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         }
         PRINT(ERR_LINE);
         PRINT("Press <RETURN> ");
         INPUT(out WAIT, 1);
         PRINT(CLR_ERROR);
         return;
      }
      void L0040()
      {
         /*  Print date sub-total */
         if (LCNT >= LINECOUNT)
         {
            L0400();
         }
         OUTPUT_LINE = "Sub Total for " + FORMAT(OCONV(LAST_DATE, "D"), "L#25") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT(OCONV(DATE_TOTAL, "MD2"), "R#12");
         OUTPUT_STYLE = "BLb" + VM + "Lb" + VM + "Lb" + VM + "Lb" + VM + "BRb";
         nrf0 = "";
         nrf1 = 0;
         FL_HTM = new FL_HTM(ref OUTPUT_LINE, ref nrf0, ref OUTPUT_STYLE, ref TEXTOUT, ref nrf1);
         L8900();
         return;
      }
      void L0050()
      {
         /*  Print group sub-total */
         if (LCNT >= LINECOUNT)
         {
            L0400();
         }
         OUTPUT_LINE = "Sub Total for " + FORMAT(LAST_GROUP_CODE, "L#25") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT(OCONV(GROUP_TOTAL, "MD2"), "R#12");
         OUTPUT_STYLE = "BLb" + VM + "Lb" + VM + "Lb" + VM + "Lb" + VM + "BRb";
         OUTPUT_COLOUR = "BLUE";
         nrf0 = 0;
         FL_HTM = new FL_HTM(ref OUTPUT_LINE, ref OUTPUT_COLOUR, ref OUTPUT_STYLE, ref TEXTOUT, ref nrf0);
         L8900();
         return;
      }
      void L0100()
      {
         /*  Render detail line */
         if (LCNT + 3 > LINECOUNT)
         {
            L0400();
         }
         OUTPUT_LINE = FORMAT(OCONV(THIS_DATE, "D"), "L#25") + VM + FORMAT(PAY_REF, "L#20") + VM + FORMAT(GROUP_DESC, "L#20") + VM + FORMAT(ACTIVITY_DESC, "L#20") + VM + FORMAT(AMOUNT, "R#12");
         OUTPUT_STYLE = "L" + VM + "L" + VM + "L" + VM + "L" + VM + "R";
         OUTPUT_COLOUR = "";
         nrf0 = 0;
         FL_HTM = new FL_HTM(ref OUTPUT_LINE, ref OUTPUT_COLOUR, ref OUTPUT_STYLE, ref TEXTOUT, ref nrf0);
         L8900();
         return;
      }
      void L0200()
      {
         /*  Grand Total */
         if (LCNT > LINECOUNT)
         {
            L0400();
         }
         OUTPUT_LINE = FORMAT("GRAND TOTAL", "L#25") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT("", "L#20") + VM + FORMAT(OCONV(GRAND_TOTAL, "MD2"), "R#12");
         OUTPUT_STYLE = "bBL" + VM + "Lb" + VM + "Lb" + VM + "Lb" + VM + "BRb";
         OUTPUT_COLOUR = "BLUE";
         nrf0 = 0;
         FL_HTM = new FL_HTM(ref OUTPUT_LINE, ref OUTPUT_COLOUR, ref OUTPUT_STYLE, ref TEXTOUT, ref nrf0);
         L8900();
         return;
      }
      void L0400()
      {
         /*  NEW PAGE */
         LCNT = 0;
         if (PAGE_NO == 1)
         {
            nrf0 = "";
            nrf1 = 0;
            FL_HTM = new FL_HTM(ref SCREEN_HEAD, ref nrf0, ref SCREEN_STYLE, ref TEXTOUT, ref nrf1);
         }
         else
         {
            nrf0 = "";
            nrf1 = 2;
            FL_HTM = new FL_HTM(ref SCREEN_HEAD, ref nrf0, ref SCREEN_STYLE, ref TEXTOUT, ref nrf1);
         }
         L8900();
         PAGE_NO = PAGE_NO + 1;
         LCNT = 5;
         return;
      }
      void L510()
      {
         /*  GET ACTIVITY DESC */
         SPORT_CODE = FIELD(OLD_TICKET_REC[OLD_TICK_CODE][1, 1], "*", 2);
         CODE_ID = "2*" + SPORT_CODE;
         if (!READV(ref ACTIVITY_DESC, COMMON.FILES[FL_FINANCE_DESCRIPTIONS], CODE_ID, 1)) { ACTIVITY_DESC = ""; }
         if (ACTIVITY_DESC == "")
         {
            ACTIVITY_DESC = SPORT_CODE;
         }
         else
         {
            ACTIVITY_DESC = "(" + SPORT_CODE + ") " + ACTIVITY_DESC;
         }
         ACTIVITY_DESC = FORMAT(ACTIVITY_DESC, "L#20");
         return;
      }
      void L8900()
      {
         for (ZZZ_LN = 1; ZZZ_LN <= DCOUNT(TEXTOUT, AM); ZZZ_LN += 1)
         {
            if (!(WRITESEQ(TEXTOUT[ZZZ_LN], SEQFILE)))
            {
               nrf0 = 2;
               nrf1 = "CANNOT WRITE TO FILE";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
         }
         LCNT = LCNT + 1;
         TEXTOUT = "";
         return;
      }
   }
}
