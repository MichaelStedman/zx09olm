//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL292 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_MEMBERS = 2;
      readonly UvVar MEMBER_CENTRE = 1;
      readonly UvVar MEMBER_TYPE = 2;
      readonly UvVar MEMBER_ORIG_PRICE = 3;
      readonly UvVar MEMBER_SURNAMES = 4;
      readonly UvVar MEMBER_INITIALS = 5;
      readonly UvVar MEMBER_TITLES = 6;
      readonly UvVar MEMBER_SEXES = 7;
      readonly UvVar MEMBER_AGES = 8;
      readonly UvVar MEMBER_RENEW_LETTER = 9;
      readonly UvVar MEMBER_SALUTATION = 9;
      readonly UvVar MEMBER_ADDRESS = 10;
      readonly UvVar MEMBER_HOME_PHONE = 11;
      readonly UvVar MEMBER_BUS_PHONE = 12;
      readonly UvVar MEMBER_EXPIRY_DATE = 13;
      readonly UvVar MEMBER_DATE_JOINED = 14;
      readonly UvVar MEMBER_ISSUING_OPER = 15;
      readonly UvVar MEMBER_ANALYSIS_CODES = 16;
      readonly UvVar MEMBER_USED_CODES = 17;
      readonly UvVar MEMBER_MAIN = 18;
      readonly UvVar MEMBER_SUB = 19;
      readonly UvVar MEMBER_RECEIPT = 20;
      readonly UvVar MEMBER_DOBS = 21;
      readonly UvVar MEMBER_LAST_CHANGED = 22;
      readonly UvVar MEMBER_HF_CARD_DATE = 23;
      readonly UvVar MEMBER_INSTALMENTS = 24;
      readonly UvVar MEMBER_FULL_EXPIRY = 25;
      readonly UvVar MEMBER_REMINDER_DATES = 26;
      readonly UvVar MEMBER_RESTRICTIONS = 27;
      readonly UvVar MEMBER_DIRECT_DEBIT = 28;
      readonly UvVar MEMBER_FORENAMES = 29;
      readonly UvVar MEMBER_COMMENTS = 30;
      readonly UvVar MEMBER_PART_COMPLETE = 31;
      readonly UvVar MEMBER_START_DATE = 32;
      readonly UvVar MEMBER_RENEWAL_DATE = 33;
      readonly UvVar MEMBER_DD_DAY = 34;
      readonly UvVar MEMBER_PRICES = 35;
      readonly UvVar MEMBER_WEB_BARRED = 36;
      readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
      readonly UvVar MEMBER_EMAIL_SALES = 38;
      readonly UvVar MEMBER_DDFLAGS = 39;
      readonly UvVar MEMBER_OLDNOS = 40;
      readonly UvVar MEMBER_PROSPECT_NO = 41;
      readonly UvVar MEMBER_APACS_NO = 42;
      readonly UvVar MEMBER_MOBILE_PHONE = 43;
      readonly UvVar MEMBER_JOB_TITLE = 44;
      readonly UvVar MEMBER_DEPARTMENT = 45;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] MEMBERS_REC;
      UvVar[] SCROLL_TAB = new UvVar[13];
      UvVar[] SCROLL_POS = new UvVar[13];
      #endregion
      #region Variables
      UvVar DEADLINE = "";
      UvVar COL = "";
      UvVar ROW = "";
      UvVar RESULT = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_MEMBER_PARAMS = "";
      UvVar EXPIRY_LEEWAY = "";
      UvVar LESS_THAN = "";
      UvVar SCROLL_COUNT = "";
      UvVar NAME_HIT = "";
      UvVar MEM_COUNT = "";
      UvVar EXPIRY_HIT = "";
      UvVar MEMS = "";
      UvVar INIT_SPACE = "";
      UvVar WARN_MESS = "";
      UvVar OK = "";
      UvVar JUST = "";
      UvVar SCROLL_ACT = "";
      UvVar WARN_SCREEN = "";
      UvVar SCROLL_BUG = "";
      UvVar SCROLL_SIZE = "";
      UvVar SCROLL_COL = "";
      UvVar SCROLL_ROW = "";
      UvVar YES_NO = "";
      UvVar TICKET_REC = "";
      UvVar PASTE = "";
      UvVar ANS = "";
      UvVar SCROLL_LEN = "";
      UvVar POSS = "";
      UvVar CUT = "";
      #endregion
      public FL292(ref UvVar[] MEMBERS_REC, ref UvVar DEADLINE, ref UvVar COL, ref UvVar ROW, ref UvVar RESULT)
      {
         this.MEMBERS_REC = MEMBERS_REC;
         this.DEADLINE = DEADLINE;
         this.COL = COL;
         this.ROW = ROW;
         this.RESULT = RESULT;
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
         /* Displays a window of warning messages, gets a reply and refreshes */
         /*  Last updated by lfsw (MONTE_CARLO\lfsw) at 11:36:07 on 07/09/1999. */
         #region INCLUDE FL.FILES FL.MEMBERS

         /*  DJA 14.8.01 Separate file includes for web bookings */
         /*              (see FL.MEMBERS.VAR for field names) */
         #region INCLUDE FL.FILES FL.MEMBERS.EQU

         #endregion
         #region INCLUDE FL.FILES FL.MEMBERS.DIM

         SIZE_OF_MEMBERS_REC = 45;
         /*  Must keep in tandem */

         #endregion
         #region INCLUDE FL.FILES FL.MEMBERS.VAR

         /*  Hammersmith & Fulham - Membership Card production systems */
         /*  Two tier reminder system */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.MEMBER.PARAMS

         if (!OPEN("FL.MEMBER.PARAMS", out FL_MEMBER_PARAMS)) { STOP("201", "FL.MEMBER.PARAMS"); }

         #endregion
         if (!(READV(ref EXPIRY_LEEWAY, FL_MEMBER_PARAMS, "EXPIRY.LEEWAY", 1)))
         {
            EXPIRY_LEEWAY = 31;
         }
         EXPIRY_LEEWAY = EXPIRY_LEEWAY[1, 1];
         L2000();
      /*  Initialise */
      L1000: ;
         /*  Check expiry dates with magic cut & paste */
         LESS_THAN = FALSE;
         SCROLL_COUNT = 1;
         NAME_HIT = FALSE;
         MEM_COUNT = DCOUNT(MEMBERS_REC[MEMBER_EXPIRY_DATE], VM);
         EXPIRY_HIT = FALSE;
         for (MEMS = 1; MEMS <= MEM_COUNT; MEMS += 1)
         {
            if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS] < TODAYS_DATE || MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS] < DEADLINE)
            {
               if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS] < TODAYS_DATE)
               {
                  if (TODAYS_DATE - MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS] < EXPIRY_LEEWAY)
                  {
                     EXPIRY_HIT = TRUE;
                     INIT_SPACE = STR(".", LEN(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + " ") - 1) + " ";
                     if (MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS] < TODAYS_DATE)
                     {
                        LESS_THAN = TRUE;
                        if (NAME_HIT == FALSE)
                        {
                           NAME_HIT = TRUE;
                           WARN_MESS = MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + " " + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, MEMS], "L#6") + " expired " + OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS], "D");
                        }
                        else
                        {
                           WARN_MESS = INIT_SPACE + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, MEMS], "L#6") + " expired " + OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS], "D");
                        }
                        L1100();
                     }
                  }
               }
               else
               {
                  if (NAME_HIT == FALSE)
                  {
                     NAME_HIT = TRUE;
                     WARN_MESS = MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + " " + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, MEMS], "L#6") + " Due to expire " + OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS], "D");
                     L1100();
                  }
                  else
                  {
                     WARN_MESS = INIT_SPACE + FORMAT(MEMBERS_REC[MEMBER_TYPE][1, MEMS], "L#6") + " Due to expire " + OCONV(MEMBERS_REC[MEMBER_EXPIRY_DATE][1, MEMS], "D");
                     L1100();
                  }
               }
            }
         }
         if (EXPIRY_HIT == FALSE && NAME_HIT == FALSE)
         {
            return;
         }
         OK = FALSE;
         do
         {
            if (LESS_THAN == TRUE)
            {
               SCROLL_TAB[SCROLL_COUNT] = FORMAT("Continue? Y/N ", JUST);
            }
            else
            {
               SCROLL_TAB[SCROLL_COUNT] = FORMAT("Press <RETURN> ", JUST);
            }
            SCROLL_ACT = SCROLL_COUNT - 1;
            WARN_SCREEN = INIT;
            for (SCROLL_BUG = 1; SCROLL_BUG <= SCROLL_SIZE; SCROLL_BUG += 1)
            {
               WARN_SCREEN = WARN_SCREEN + SCROLL_POS[SCROLL_BUG] + SCROLL_TAB[SCROLL_BUG];
            }
            PRINT(WARN_SCREEN);
            PRINT(AT(SCROLL_COL + 20, SCROLL_ROW + SCROLL_ACT));
            INPUT(out YES_NO, 1);
            YES_NO = OCONV(YES_NO, "MCU");
            if (EXPIRY_HIT == TRUE)
            {
               // BEGIN CASE
               // CASE
               if (YES_NO == "N")
               {
                  TICKET_REC = "";
                  RESULT = COMMON.ABANDON;
                  OK = TRUE;
                  PRINT(PASTE);
                  return;
               }// CASE
               else if (YES_NO == "Y")
               {
                  OK = TRUE;
               }// CASE
               else if (OTHERWISE)
               {
                  NULL();
               }
               // END CASE
            }
            else
            {
               OK = TRUE;
            }
            if (OK == TRUE) break;
         } while (true);
         /*  Paste back what was cut at the start */
         PRINT(PASTE);
         return;
      }
      void L1100()
      {
         /*  compose/display warnings */
         /*         WARN.MESS = TRIM(WARN.MESS)JUST */
         SCROLL_TAB[SCROLL_COUNT] = FORMAT(WARN_MESS, JUST);
         SCROLL_COUNT = SCROLL_COUNT + 1;
         if (SCROLL_COUNT < SCROLL_SIZE)
         {
            return;
         }
         SCROLL_TAB[SCROLL_SIZE] = FORMAT("Press <ENTER> ", JUST);
         WARN_SCREEN = INIT;
         for (SCROLL_COUNT = 1; SCROLL_COUNT <= SCROLL_SIZE; SCROLL_COUNT += 1)
         {
            WARN_SCREEN = WARN_SCREEN + SCROLL_POS[SCROLL_COUNT] + SCROLL_TAB[SCROLL_COUNT];
         }
         PRINT(WARN_SCREEN);
         PRINT(AT(SCROLL_COL + 20, SCROLL_ROW + SCROLL_SIZE - 1));
         INPUTCR(out ANS, 1);
         MAT(ref SCROLL_TAB, SPACE(SCROLL_LEN));
         SCROLL_COUNT = 1;
         NAME_HIT = FALSE;
         /*      PRINT PASTE: */
         return;
      }
      void L2000()
      {
         /*  Setup window cut & paste */
         INIT_SPACE = "";
         SCROLL_COUNT = 0;
         SCROLL_SIZE = 13;
         SCROLL_LEN = 60;
         SCROLL_COL = COL;
         if (SCROLL_COL == INIT)
         {
            SCROLL_COL = 10;
         }
         SCROLL_ROW = ROW;
         if (SCROLL_ROW == INIT)
         {
            SCROLL_ROW = 10;
         }
         MAT(ref SCROLL_TAB, INIT);
         for (POSS = 1; POSS <= SCROLL_SIZE; POSS += 1)
         {
            SCROLL_POS[POSS] = AT(SCROLL_COL, SCROLL_ROW + POSS - 1);
         }
         JUST = "L#" + SCROLL_LEN;
         CUT = CHAR(28) + "36," + SCROLL_COL + "," + SCROLL_ROW + "," + (SCROLL_COL + SCROLL_LEN) + "," + (SCROLL_ROW + SCROLL_SIZE) + CHAR(20);
         PASTE = CHAR(28) + "37," + SCROLL_COL + "," + SCROLL_ROW + CHAR(20);
         /*  Cut out the area of the warning window */
         PRINT(CUT);
         return;
      }
   }
}
