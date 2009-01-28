//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL00019 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar EPURSE_APACS_NO = 1;
      readonly UvVar EPURSE_MEM_NO = 2;
      readonly UvVar EPURSE_DATE = 3;
      readonly UvVar EPURSE_TIME = 4;
      readonly UvVar EPURSE_USER = 5;
      readonly UvVar EPURSE_AMOUNT = 6;
      readonly UvVar EPURSE_CRED_OR_DEB = 7;
      readonly UvVar FL_CENTRES = 3;
      readonly UvVar CENTRE_NAME = 1;
      readonly UvVar CENTRE_FLOORS = 2;
      readonly UvVar CENTRE_ACTIVITIES = 3;
      readonly UvVar CENTRE_FACILITY_NUM = 4;
      readonly UvVar FL_TICKET_CONTROL = 19;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] EPURSE_REC;
      UvVar[] CENTRES_REC = new UvVar[4];
      UvVar[] TICK_CONTROL_REC = new UvVar[20];
      UvVar[] PRT_TYPE = new UvVar[15];
      #endregion
      #region Variables
      UvVar EPURSE_TRANS_ID = "";
      UvVar EPURSE_BALANCE = "";
      UvVar CALLING_PROGRAM = "";
      UvVar SLAVE_ON = "";
      UvVar SLAVE_OFF = "";
      UvVar AM = "";
      UvVar FL_EPURSE_LOG = "";
      UvVar POUND_SIGN = "";
      UvVar TICKET_HEAD = "";
      UvVar EPURSE_TX_TYPE = "";
      UvVar EPURSE_OLD_BALANCE = "";
      UvVar EPURSE_NEW_BALANCE = "";
      UvVar ESC = "";
      UvVar NORMAL = "";
      UvVar RECEIPT_TYPE = "";
      UvVar EPURSE_PRT_REC = "";
      UvVar F_FEED = "";
      UvVar CUT_MARK = "";
      UvVar PLOOP = "";
      #endregion
      public FL00019(ref UvVar[] EPURSE_REC, ref UvVar EPURSE_TRANS_ID, ref UvVar EPURSE_BALANCE, ref UvVar CALLING_PROGRAM)
      {
         this.EPURSE_REC = EPURSE_REC;
         this.EPURSE_TRANS_ID = EPURSE_TRANS_ID;
         this.EPURSE_BALANCE = EPURSE_BALANCE;
         this.CALLING_PROGRAM = CALLING_PROGRAM;
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
         /*  Print confirmation Epurse slip */
         /* *********************************************************************** */
         #region INCLUDE FL.FILES FL.EPURSE.LOG
         if (!OPEN("FL.EPURSE.LOG", out FL_EPURSE_LOG)) { STOP(201, "UNABLE TO OPEN FL.EPURSE.LOG"); }

         /*  <7> Contains (D)ebit or (C)redit */

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES
         #region INCLUDE FL.FILES FL.CENTRES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CENTRES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CENTRES.VAR

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.CONTROL

         #endregion
         /*   Initialise Variables */
         POUND_SIGN = CHAR(156);
         if (!(READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)))
         {
            CENTRES_REC[CENTRE_NAME] = "UNKNOWN";
         }
         if (!READ(ref TICKET_HEAD, COMMON.FILES[FL_TICKET_CONTROL], COMMON.CENTRE + "*TICKET.HEAD")) { TICKET_HEAD = ""; }
         if (EPURSE_REC[EPURSE_AMOUNT] < 0)
         {
            EPURSE_TX_TYPE = "CREDIT";
         }
         else
         {
            EPURSE_TX_TYPE = "DEBIT";
         }
         EPURSE_OLD_BALANCE = EPURSE_BALANCE;
         EPURSE_NEW_BALANCE = EPURSE_OLD_BALANCE - EPURSE_REC[EPURSE_AMOUNT];
         EPURSE_OLD_BALANCE = POUND_SIGN + OCONV(EPURSE_OLD_BALANCE, COMMON.MD2);
         EPURSE_NEW_BALANCE = POUND_SIGN + OCONV(EPURSE_NEW_BALANCE, COMMON.MD2);
         ESC = CHAR(27);
         NORMAL = ESC + CHAR(33) + CHAR(64);
         PRT_TYPE[1] = NORMAL;
         PRT_TYPE[2] = ESC + CHAR(33) + CHAR(1);
         PRT_TYPE[3] = ESC + CHAR(33) + CHAR(17);
         PRT_TYPE[4] = ESC + CHAR(33) + CHAR(33);
         PRT_TYPE[5] = ESC + CHAR(33) + CHAR(49);
         PRT_TYPE[6] = ESC + CHAR(33) + CHAR(2);
         PRT_TYPE[7] = ESC + CHAR(33) + CHAR(16);
         PRT_TYPE[8] = ESC + CHAR(33) + CHAR(32);
         PRT_TYPE[9] = ESC + CHAR(33) + CHAR(48);
         /*  Main Processing */
         L0100();
         /*  Build Retailer PRT.REC.REC */
         /* GOSUB 0400 */
         L0300();
         /*  Print Slip */
         L0200();
         /*  Build Cardholder PRT.REC */
         L0400();
         L0300();
         /*  Print Slip */
         PRINTCR(SLAVE_OFF);
         return;
      }
      void L0100()
      {
         /*  Build PRT.REC (Retailer) */
         RECEIPT_TYPE = "RETAILER";
         if (INDEX(CALLING_PROGRAM, "TOPUP", 1))
         {
            EPURSE_PRT_REC = "EPURSE TOP-UP";
            EPURSE_REC[EPURSE_AMOUNT] = 0 - EPURSE_REC[EPURSE_AMOUNT];
         }
         else
         {
            EPURSE_PRT_REC = "EPURSE PAYMENT";
         }
         EPURSE_PRT_REC[2] = "RETAILER'S COPY";
         EPURSE_PRT_REC[3] = "   APACS Card No : " + EPURSE_REC[EPURSE_APACS_NO];
         if (EPURSE_REC[EPURSE_MEM_NO] != "")
         {
            EPURSE_PRT_REC[4] = "   Member No     : " + EPURSE_REC[EPURSE_MEM_NO];
         }
         if (INDEX(CALLING_PROGRAM, "TOPUP", 1))
         {
            EPURSE_PRT_REC[5] = "Old Balance   :  " + EPURSE_OLD_BALANCE;
            EPURSE_PRT_REC[6] = "Top-Up Amount :  " + POUND_SIGN + OCONV(EPURSE_REC[EPURSE_AMOUNT], COMMON.MD2);
            EPURSE_PRT_REC[7] = "New Balance   :  " + EPURSE_NEW_BALANCE;
         }
         else
         {
            EPURSE_PRT_REC[5] = "AMOUNT                       " + POUND_SIGN + " " + OCONV(EPURSE_REC[EPURSE_AMOUNT], COMMON.MD2);
            EPURSE_PRT_REC[6] = "PLEASE " + EPURSE_TX_TYPE + " MY ACCOUNT AS SHOWN";
         }
         EPURSE_PRT_REC[8] = "";
         EPURSE_PRT_REC[9] = OCONV(EPURSE_REC[EPURSE_DATE], "D4/") + " " + OCONV(EPURSE_REC[EPURSE_TIME], "MT");
         EPURSE_PRT_REC[10] = "Operator      : " + EPURSE_REC[EPURSE_USER];
         EPURSE_PRT_REC[11] = "Trans Id      : " + EPURSE_TRANS_ID;
         return;
      }
      void L0200()
      {
         /*  Build PRT.REC (Cardholder) */
         RECEIPT_TYPE = "CARDHOLDER";
         if (INDEX(CALLING_PROGRAM, "TOPUP", 1))
         {
            EPURSE_PRT_REC = "EPURSE TOP-UP";
         }
         else
         {
            EPURSE_PRT_REC = "EPURSE PAYMENT";
         }
         EPURSE_PRT_REC[2] = "CARDHOLDER'S COPY";
         EPURSE_PRT_REC[3] = "   APACS Card No : " + EPURSE_REC[EPURSE_APACS_NO];
         if (EPURSE_REC[EPURSE_MEM_NO] != "")
         {
            EPURSE_PRT_REC[4] = "   Member No     : " + EPURSE_REC[EPURSE_MEM_NO];
         }
         if (INDEX(CALLING_PROGRAM, "TOPUP", 1))
         {
            EPURSE_PRT_REC[5] = "Old Balance   :  " + EPURSE_OLD_BALANCE;
            EPURSE_PRT_REC[6] = "Top-Up Amount :  " + POUND_SIGN + OCONV(EPURSE_REC[EPURSE_AMOUNT], COMMON.MD2);
            EPURSE_PRT_REC[7] = "New Balance   :  " + EPURSE_NEW_BALANCE;
         }
         else
         {
            EPURSE_PRT_REC[5] = "AMOUNT                       " + POUND_SIGN + " " + OCONV(EPURSE_REC[EPURSE_AMOUNT], COMMON.MD2);
            EPURSE_PRT_REC[6] = "Old Balance : " + EPURSE_OLD_BALANCE;
            EPURSE_PRT_REC[7] = "New Balance : " + EPURSE_NEW_BALANCE;
         }
         EPURSE_PRT_REC[8] = "PLEASE KEEP THIS RECEIPT FOR YOUR RECORDS";
         EPURSE_PRT_REC[9] = OCONV(EPURSE_REC[EPURSE_DATE], "D4/") + " " + OCONV(EPURSE_REC[EPURSE_TIME], "MT");
         EPURSE_PRT_REC[10] = "Operator      : " + EPURSE_REC[EPURSE_USER];
         EPURSE_PRT_REC[11] = "Trans Id      : " + EPURSE_TRANS_ID;
         return;
      }
      void L0300()
      {
         /*  Print Slip */
         PRINTCR(SLAVE_ON);
         PRINTCR(PRT_TYPE[2] + " ");
         PRINTCR(PRT_TYPE[7] + SPACE(14) + EPURSE_PRT_REC[1]);
         PRINTCR(PRT_TYPE[2] + " ");
         PRINTCR(PRT_TYPE[1] + EPURSE_PRT_REC[2]);
         PRINTCR(PRT_TYPE[2] + " ");
         PRINTCR(PRT_TYPE[2] + EPURSE_PRT_REC[3]);
         PRINTCR(PRT_TYPE[2] + EPURSE_PRT_REC[4]);
         PRINTCR(PRT_TYPE[2] + " ");
         if (INDEX(CALLING_PROGRAM, "TOPUP", 1))
         {
            PRINTCR(PRT_TYPE[7] + EPURSE_PRT_REC[5]);
            PRINTCR(EPURSE_PRT_REC[6]);
            PRINTCR(EPURSE_PRT_REC[7]);
            PRINTCR(PRT_TYPE[2] + " ");
         }
         else
         {
            PRINTCR(PRT_TYPE[7] + EPURSE_PRT_REC[5]);
            PRINTCR(PRT_TYPE[2] + " ");
            PRINTCR(PRT_TYPE[2] + EPURSE_PRT_REC[6]);
            PRINTCR(PRT_TYPE[2] + EPURSE_PRT_REC[7]);
         }
         PRINTCR(PRT_TYPE[2] + EPURSE_PRT_REC[8]);
         PRINTCR(PRT_TYPE[2] + " ");
         PRINTCR(PRT_TYPE[1] + EPURSE_PRT_REC[9]);
         PRINTCR(PRT_TYPE[1] + EPURSE_PRT_REC[10]);
         PRINTCR(PRT_TYPE[1] + EPURSE_PRT_REC[11]);
         for (F_FEED = 1; F_FEED <= 4; F_FEED += 1)
         {
            PRINT();
         }
         CUT_MARK = ESC + "i";
         PRINT();
         PRINTCR(CUT_MARK);
         return;
      }
      void L0400()
      {
         /*  Print Header for next ticket */
         PRINTCR(SLAVE_ON);
         for (PLOOP = 1; PLOOP <= DCOUNT(TICKET_HEAD, AM); PLOOP += 1)
         {
            if (TICKET_HEAD[PLOOP, 1] > 0 && TICKET_HEAD[PLOOP, 1] < 10)
            {
               PRINTCR(PRT_TYPE[TICKET_HEAD[PLOOP, 1]] + TICKET_HEAD[PLOOP, 2]);
            }
         }
         return;
         /*   END OF PROGRAM */
      }
   }
}
