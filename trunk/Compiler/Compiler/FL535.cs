//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL535 : UvBase
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
      readonly UvVar MSGCTRL_LAST_REF = 1;
      readonly UvVar MSGCTRL_START_DATE = 2;
      readonly UvVar MSGCTRL_END_DATE = 3;
      readonly UvVar MSGCTRL_REF = 4;
      readonly UvVar MSGCTRL_DESC = 5;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] MEM_MSGCTRL_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar MEMBER = "";
      UvVar CALLING_PROGRAM = "";
      UvVar TODAYS_DATE = "";
      UvVar AM = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_MEM_MSGCTRL = "";
      UvVar FL_MEM_MSGS = "";
      UvVar MEMO_HEAD = "";
      UvVar REQD_MSG = "";
      UvVar MSG_POS = "";
      UvVar MSG_ID = "";
      UvVar MEM_MSG = "";
      UvVar ADDRESS = "";
      UvVar MSG_HEAD = "";
      FL_MEMO_DISPLAY FL_MEMO_DISPLAY;
      UvVar RESPONSE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      UvVar nrf3 = "";
      #endregion
      public FL535(ref UvVar MEMBER, ref UvVar CALLING_PROGRAM)
      {
         this.MEMBER = MEMBER;
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
         /*  Builds and Displays Message Details for member -  No updates allowed */
         /*  Used by Touchscreens */
         /*  FILES */
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
         #region INCLUDE FL.FILES FL.MEM.MSGCTRL
         if (!OPEN("FL.MEM.MSGCTRL", out FL_MEM_MSGCTRL)) { STOP("201", "FL.MEM.MSGCTRL"); }

         #endregion
         #region INCLUDE FL.FILES FL.MEM.MSGS
         if (!OPEN("FL.MEM.MSGS", out FL_MEM_MSGS)) { STOP("201", "FL.MEM.MSGS"); }

         #endregion
         MEMO_HEAD = "";
         /*  check for messages */
         if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER)))
         {
            MAT(ref MEMBERS_REC, "");
         }
         if (MATREAD(ref MEM_MSGCTRL_REC, FL_MEM_MSGCTRL, MEMBER))
         {
            REQD_MSG = "";
            MSG_POS = 1;
            do
            {
               if (MEM_MSGCTRL_REC[MSGCTRL_START_DATE][1, MSG_POS] == "") break;
               /*  Check for current messages */
               if (TODAYS_DATE >= MEM_MSGCTRL_REC[MSGCTRL_START_DATE][1, MSG_POS] && TODAYS_DATE <= MEM_MSGCTRL_REC[MSGCTRL_END_DATE][1, MSG_POS])
               {
                  MSG_ID = MEMBER + "*" + MEM_MSGCTRL_REC[MSGCTRL_REF][1, MSG_POS];
                  if (!(READ(ref MEM_MSG, FL_MEM_MSGS, MSG_ID)))
                  {
                     MEM_MSG = "";
                  }
                  if (REQD_MSG != "")
                  {
                     REQD_MSG = REQD_MSG + AM + AM + MEM_MSG;
                  }
                  else
                  {
                     REQD_MSG = MEM_MSG;
                  }
               }
               MSG_POS = MSG_POS + 1;
            } while (true);
            if (REQD_MSG != "")
            {
               ADDRESS = "(" + MEMBERS_REC[MEMBER_ADDRESS][1, 1] + " " + MEMBERS_REC[MEMBER_ADDRESS][1, 2] + " " + MEMBERS_REC[MEMBER_ADDRESS][1, 3] + " " + MEMBERS_REC[MEMBER_ADDRESS][1, 4] + " " + MEMBERS_REC[MEMBER_ADDRESS][1, 5] + ")";
               MSG_HEAD = MEMBER + " " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_INITIALS][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + " " + ADDRESS;
               REQD_MSG = MSG_HEAD + AM + AM + REQD_MSG;
               nrf0 = "C5";
               nrf1 = "C5";
               nrf2 = "C70";
               nrf3 = "C18";
               FL_MEMO_DISPLAY = new FL_MEMO_DISPLAY(ref REQD_MSG, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref MEMO_HEAD);
            }
         }
         else
         {
            if (CALLING_PROGRAM == "FL533")
            {
               PRINT(AT(10, 21) + "No messages for member ");
               INPUTCR(out RESPONSE, 1);
            }
         }
         return;
         /* * The End */
      }
   }
}
