//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_BB_EXPIRY_REP : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar FL_BLOCK_HEADER = 87;
      readonly UvVar BLOCK_SDESC = 1;
      readonly UvVar BLOCK_STIME = 2;
      readonly UvVar BLOCK_ETIME = 3;
      readonly UvVar BLOCK_SPORT = 4;
      readonly UvVar BLOCK_FLOORS1 = 5;
      readonly UvVar BLOCK_FLOORS2 = 6;
      readonly UvVar BLOCK_FLOORS3 = 7;
      readonly UvVar BLOCK_DATES1 = 8;
      readonly UvVar BLOCK_DATES2 = 9;
      readonly UvVar BLOCK_DATES3 = 10;
      readonly UvVar BLOCK_PRICE_REF = 11;
      readonly UvVar BLOCK_LETTER = 12;
      readonly UvVar BLOCK_INSTALL = 13;
      readonly UvVar BLOCK_START = 14;
      readonly UvVar BLOCK_FREQUENCY = 15;
      readonly UvVar BLOCK_NO_INSTALLS = 16;
      readonly UvVar BLOCK_NOTES = 17;
      readonly UvVar BLOCK_DATE_MADE = 18;
      readonly UvVar BLOCK_USER = 19;
      readonly UvVar BLOCK_DEALER = 20;
      readonly UvVar BLOCK_FLOORS4 = 21;
      readonly UvVar BLOCK_FLOORS5 = 22;
      readonly UvVar BLOCK_FLOORS6 = 23;
      readonly UvVar BLOCK_FLOORS7 = 24;
      readonly UvVar BLOCK_DATES4 = 25;
      readonly UvVar BLOCK_DATES5 = 26;
      readonly UvVar BLOCK_DATES6 = 27;
      readonly UvVar BLOCK_DATES7 = 28;
      readonly UvVar FL_CUSTOMERS = 85;
      readonly UvVar CUST_NAME = 1;
      readonly UvVar CUST_INITS = 2;
      readonly UvVar CUST_TITLE = 3;
      readonly UvVar CUST_ADDRESS1 = 4;
      readonly UvVar CUST_ADDRESS2 = 5;
      readonly UvVar CUST_ADDRESS3 = 6;
      readonly UvVar CUST_ADDRESS4 = 7;
      readonly UvVar CUST_POST = 8;
      readonly UvVar CUST_HTEL = 9;
      readonly UvVar CUST_WTEL = 10;
      readonly UvVar CUST_COMMENTS = 11;
      readonly UvVar CUST_ACCOUNTS = 12;
      readonly UvVar CUST_LAST_ACC = 13;
      readonly UvVar CUST_MEMBER_NO = 14;
      readonly UvVar CUST_DUE = 15;
      readonly UvVar CUST_ORGANISATION = 16;
      readonly UvVar CUST_EMAIL_ADDRESS = 17;
      readonly UvVar FL_BLOCK_PAY = 88;
      readonly UvVar BLOCK_PAY_DUE = 1;
      readonly UvVar BLOCK_PAY_OWES = 2;
      readonly UvVar BLOCK_PAY_PAID = 3;
      readonly UvVar BLOCK_PAY_OUTSTAND = 4;
      readonly UvVar BLOCK_PAY_TOTAL_OWED = 5;
      readonly UvVar BLOCK_PAY_TOTAL_PAID = 6;
      readonly UvVar BLOCK_PAY_DATES_PAID = 7;
      readonly UvVar BLOCK_PAY_AMOUNTS_PAID = 8;
      readonly UvVar BLOCK_PAY_ADJ = 9;
      readonly UvVar BLOCK_PAY_ADJ_TYPE = 10;
      readonly UvVar BLOCK_PAY_ADJ_DATE = 11;
      readonly UvVar BLOCK_PAY_ADJ_INST = 12;
      readonly UvVar BLOCK_PAY_SPORTS1 = 13;
      readonly UvVar BLOCK_PAY_HEADCOUNTS1 = 14;
      readonly UvVar BLOCK_PAY_SPORTS2 = 15;
      readonly UvVar BLOCK_PAY_HEADCOUNTS2 = 16;
      readonly UvVar BLOCK_PAY_SPORTS3 = 17;
      readonly UvVar BLOCK_PAY_HEADCOUNTS3 = 18;
      readonly UvVar BLOCK_PAY_SPORTS4 = 19;
      readonly UvVar BLOCK_PAY_HEADCOUNTS4 = 20;
      readonly UvVar BLOCK_PAY_SPORTS5 = 21;
      readonly UvVar BLOCK_PAY_HEADCOUNTS5 = 22;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] BLOCK_REC = new UvVar[30];
      UvVar[] CUST_REC = new UvVar[20];
      UvVar[] BLOCK_PAY_REC = new UvVar[50];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar EXECUTE_PROG = "";
      UvVar EXPIRIES = "";
      UvVar INSTR = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar OTHERS = "";
      UvVar MESSAGES = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar BB_EXP_REC = "";
      UvVar LOOK_BACK = "";
      UvVar LOOK_FORWARD = "";
      UvVar HISTORY = "";
      UvVar FUTURE = "";
      UvVar EOF = "";
      UvVar BLOCK_REF = "";
      UvVar REC = "";
      UvVar BPAGE = "";
      UvVar PAGE_POS = "";
      UvVar LAST_MV = "";
      UvVar LAST_DATE = "";
      UvVar CUST_REF = "";
      UvVar CUSTOMER_NAME = "";
      UvVar NEW_REC = "";
      UvVar TO_PRINTER = "";
      UvVar WAIT = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL_BB_EXPIRY_REP()
      {
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
         // PRODUCES A WORK FILE OF LAST DATES SHOWN IN THE FL.BLOCK.HEADER FILE
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.BLOCK.HEADER

         #endregion
         #region INCLUDE FL.FILES FL.CUSTOMERS

         #endregion
         #region INCLUDE FL.FILES FL.BLOCK.PAY

         #endregion
         if (!(OPEN("FL.BB.EXPIRY.WORK", out EXPIRIES)))
         {
            INSTR = "CREATE-FILE FL.BB.EXPIRY.WORK 1 11";
            nrf0 = "OS";
            CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
            if (!(OPEN("FL.BB.EXPIRY.WORK", out EXPIRIES)))
            {
               STOP(201, "FL.BB.EXPIRY.WORK");
            }
         }
         INSTR = "CLEAR-FILE FL.BB.EXPIRY.WORK";
         nrf0 = "OS";
         CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
         if (!(READ(ref BB_EXP_REC, COMMON.FILES[FL_CONTROL], "BB.EXPIRY.PARAMS")))
         {
            BB_EXP_REC = 7;
            BB_EXP_REC[2] = 56;
         }
         LOOK_BACK = BB_EXP_REC[1];
         LOOK_FORWARD = BB_EXP_REC[2];
         HISTORY = TODAYS_DATE - LOOK_BACK;
         FUTURE = TODAYS_DATE + LOOK_FORWARD;
         SELECT(COMMON.FILES[FL_BLOCK_HEADER]);
         PRINT(COMMON.WASH);
         PRINT(AT(10, 10) + "Checking for Expiries, please be patient.");
         PRINT(AT(10, 12) + "Processing Customer ");
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref BLOCK_REF, 0, 0, "")) { EOF = TRUE; }
            if (EOF) break;
            if (!(READ(ref REC, COMMON.FILES[FL_BLOCK_HEADER], BLOCK_REF)))
            {
               REC = "";
            }
            PRINT(AT(30, 12) + COMMON.EOL + BLOCK_REF);
            for (BPAGE = 1; BPAGE <= 7; BPAGE += 1)
            {
               if (BPAGE < 4)
               {
                  PAGE_POS = BPAGE + 7;
               }
               else
               {
                  PAGE_POS = BPAGE + 21;
               }
               if (REC[PAGE_POS] != "")
               {
                  LAST_MV = DCOUNT(REC[PAGE_POS], VM);
                  LAST_DATE = REC[PAGE_POS, LAST_MV];
                  CUST_REF = FIELD(BLOCK_REF, "/", 1);
                  if (!(READV(ref CUSTOMER_NAME, COMMON.FILES[FL_CUSTOMERS], CUST_REF, 1)))
                  {
                     CUSTOMER_NAME = "UNKNOWN";
                  }
                  NEW_REC = "";
                  NEW_REC[1] = LAST_DATE;
                  NEW_REC[2] = TODAYS_DATE;
                  if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], BLOCK_REF)))
                  {
                     MAT(ref BLOCK_PAY_REC, "");
                  }
                  NEW_REC[3] = BLOCK_PAY_REC[BLOCK_PAY_TOTAL_OWED] - BLOCK_PAY_REC[BLOCK_PAY_TOTAL_PAID];
                  //              PRINT BLOCK.REF 'L#7':CUSTOMER.NAME 'L#25':' EXPIRES ':OCONV(LAST.DATE,'D')
                  WRITE(NEW_REC, EXPIRIES, BLOCK_REF + "/" + BPAGE);
               }
            }
         } while (true);
         PRINT(AT(10, 14) + "Report to (P)rinter or (S)creen ");
         INPUT(out TO_PRINTER, 2);
         if (TO_PRINTER == COMMON.ABANDON) { return; }
         INSTR = "SORT FL.BB.EXPIRY.WORK WITH 1 GE \"" + OCONV(HISTORY, "D") + "\" AND WITH 1 LE \"" + OCONV(FUTURE, "D") + "\" BY 1 BREAK-ON 1 3 TOTAL OUTSTANDING";
         if (TO_PRINTER == "P")
         {
            INSTR = INSTR + " (P)";
         }
         EXECUTE(INSTR, string.Empty, string.Empty, string.Empty, string.Empty);
         PRINT("Print Finished, press <RETURN> ");
         INPUT(out WAIT, 1);
         return;
      }
   }
}
