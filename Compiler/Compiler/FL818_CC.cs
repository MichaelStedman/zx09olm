//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL818_CC : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar ADT_RECORD_ID = 1;
      readonly UvVar ADT_DATE = 2;
      readonly UvVar ADT_USER = 3;
      readonly UvVar ADT_ORIG_VALUE = 4;
      readonly UvVar ADT_NEW_VALUE = 5;
      readonly UvVar ADT_REASON = 6;
      readonly UvVar ADT_TIME = 7;
      readonly UvVar FL_TICKET_FEES = 12;
      readonly UvVar TICK_FEES_DESC = 1;
      readonly UvVar TICK_FEES_PRICE = 2;
      readonly UvVar TICK_FEES_GLCODE = 3;
      readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
      readonly UvVar TICK_FEES_OFF_PRICES = 5;
      readonly UvVar TICK_FEES_OFF_START_MON = 6;
      readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
      readonly UvVar TICK_FEES_OFF_START_SAT = 8;
      readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
      readonly UvVar TICK_FEES_OFF_START_SUN = 10;
      readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
      readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
      readonly UvVar TICK_FEES_NEW_PRICE = 13;
      readonly UvVar TICK_FEES_OPEN_RANGE = 14;
      readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
      readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
      readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
      readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
      readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
      readonly UvVar TICK_FEES_VAT_QUESTION = 20;
      readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
      readonly UvVar TICK_FEES_GROUP_CODE = 22;
      readonly UvVar TICK_FEES_HEADCOUNT = 23;
      readonly UvVar TICK_FEES_CONCESSIONS = 24;
      readonly UvVar TICK_FEES_PEAK_PRICES = 25;
      readonly UvVar TICK_FEES_OFF1_PRICES = 26;
      readonly UvVar TICK_FEES_OFF2_PRICES = 27;
      readonly UvVar TICK_FEES_OFF3_PRICES = 28;
      readonly UvVar TICK_FEES_OFF4_PRICES = 29;
      readonly UvVar TICK_FEES_SPLIT_OWED = 30;
      readonly UvVar TICK_FEES_SPLIT_PAID = 31;
      readonly UvVar TICK_FEES_SPORTS = 32;
      readonly UvVar TICK_FEES_RESALE_RATE = 33;
      readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
      readonly UvVar TICK_FEES_TEXT = 35;
      readonly UvVar TICK_FEES_MEMBER_REQ = 36;
      readonly UvVar TICK_FEES_STYLE = 37;
      readonly UvVar TICK_FEES_GROUPED = 38;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] ADT_REC = new UvVar[30];
      UvVar[] TICK_FEES_REC = new UvVar[40];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar EXECUTE_PROG = "";
      UvVar FL_ADT_LOG = "";
      UvVar DICT_ADT_LOG = "";
      UvVar FL_EXPIRED_MEMBERSHIPS = "";
      UvVar DOTS_ONLY = "";
      UvVar MEM_COUNT = "";
      UvVar EXP_MEMBERS_REC = "";
      FL000_10 FL000_10;
      UvVar DELETION_DAYS = "";
      UvVar WAIT = "";
      UvVar MEMBER_TYPES = "";
      UvVar INSTRUCTION = "";
      UvVar MESSAGE = "";
      UvVar TYPE_COUNT = "";
      UvVar THIS_TYPE = "";
      UvVar TICKET_CODE = "";
      FL355 FL355;
      UvVar PRICE = "";
      UvVar PERIOD = "";
      UvVar RESPONSE = "";
      FL006 FL006;
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar OTHER = "";
      UvVar MESSAGES = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar EOF = "";
      UvVar MEMBERS_ID = "";
      UvVar EXP_MEMBERS_ID = "";
      FL000_45 FL000_45;
      UvVar ADT_MEMBER_ID = "";
      FLTX2 FLTX2;
      UvVar SEQ_NO = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL818_CC()
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
         /*  Written by MR (30.4.03) */
         /* **************************************************************** */
         PROGRAM = "FL818.CC";
         SCREEN_CODE = PROGRAM;
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         /*  Files */
         #region INCLUDE FL.FILES FL.ADT.LOG

         if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
         if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
         /*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         if (!OPEN("FL.EXPIRED.MEMBERSHIPS", out FL_EXPIRED_MEMBERSHIPS)) { STOP(201, "NO EXP MEMS"); }
         /*  Initialise Variables */
         DOTS_ONLY = 0;
         MEM_COUNT = 0;
         EXP_MEMBERS_REC = "";
         /*  Display screen */
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINTCR(AT(3, 8) + "WARNING !! This option will DELETE expired memberships");
         do
         {
            PRINT(AT(3, 10) + "Enter number of days : " + COMMON.EOL + AT(26, 10));
            INPUT(out DELETION_DAYS, 5);
            if (NUM(DELETION_DAYS) && DELETION_DAYS > 0 && DELETION_DAYS < 10000) break;
         } while (true);
         PRINT(AT(3, 12) + "Press 'C' to Remove Expired Members who expired more than " + DELETION_DAYS + " days ago ");
         INPUT(out WAIT, 2);
         if (WAIT != "C" && WAIT != "c")
         {
            return;
         }
         /*  Select types to be deleted */
         PRINT(AT(3, 14) + "Member Types or ALL [");
         PRINT(SPACE(50) + "]");
         PRINT(AT(24, 14));
         INPUT(out MEMBER_TYPES, 51);
         // BEGIN CASE
         // CASE
         if (MEMBER_TYPES == COMMON.ABANDON)
         {
            return;
         }// CASE
         else if (MEMBER_TYPES == "")
         {
            INSTRUCTION = "SELECT FL.EXPIRED.MEMBERSHIPS";
            MESSAGE = "Please wait - selecting all Expired Members ...";
         }// CASE
         else if (MEMBER_TYPES == "ALL")
         {
            INSTRUCTION = "SELECT FL.EXPIRED.MEMBERSHIPS";
            MESSAGE = "Please wait - selecting all Expired Members ...";
         }// CASE
         else if (OTHERWISE)
         {
            TYPE_COUNT = 0;
            INSTRUCTION = "SELECT FL.EXPIRED.MEMBERSHIPS WITH TYPE =";
            do
            {
               THIS_TYPE = FIELD(MEMBER_TYPES, " ", TYPE_COUNT);
               if (THIS_TYPE == "") break;
               TICKET_CODE = "M*" + THIS_TYPE;
               nrf0 = "Z";
               nrf1 = TIME();
               FL355 = new FL355(ref TICKET_CODE, ref nrf0, ref TODAYS_DATE, ref nrf1, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
               if (RESPONSE == FALSE)
               {
                  nrf0 = 10;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  goto L80;
               }
               INSTRUCTION = INSTRUCTION + " \"" + THIS_TYPE + "\"";
               TYPE_COUNT = TYPE_COUNT + 1;
            } while (true);
            MESSAGE = "Please wait - selecting Expired Members with these types ... ";
         }
         // END CASE
         /*  Read Members file */
         CRT(AT(3, 16) + COMMON.EOL + AT(3, 16) + MESSAGE);
         nrf0 = "OS";
         CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHER, ref MESSAGES);
         if (NOT(LIST_AVAILABLE))
         {
            PRINT(AT(3, 18) + "No members found matching this criteria ");
            INPUT(out WAIT, 1);
            goto L80;
         }
         CRT(AT(3, 18) + COMMON.EOL + AT(3, 18) + "Expired Members Processed - ");
         EOF = FALSE;
         do
         {
         L10:
            ;
            if (!(READNEXT(ref MEMBERS_ID, 0, 0, RTN_LIST)))
            {
               EOF = TRUE;
            }
            if (EOF) break;
            MEM_COUNT = MEM_COUNT + 1;
            CRTCR(AT(31, 18) + MEM_COUNT);
            if (!(READ(ref EXP_MEMBERS_REC, FL_EXPIRED_MEMBERSHIPS, MEMBERS_ID)))
            {
               goto L10;
            }
            if (TODAYS_DATE > EXP_MEMBERS_REC[13] + DELETION_DAYS)
            {
               EXP_MEMBERS_ID = MEMBERS_ID.Substring(10, 99);
               FL000_45 = new FL000_45(ref EXP_MEMBERS_ID, ref EXP_MEMBERS_REC);
               DELETE(FL_EXPIRED_MEMBERSHIPS, MEMBERS_ID);
               ADT_MEMBER_ID = MEMBERS_ID;
               L0600();
               /*  Update ADT.LOG */
               nrf0 = "D";
               nrf1 = "FL.EXPIRED.MEMBERSHIPS";
               FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBERS_ID);
            }
         } while (true);
         PRINT(AT(18, 22) + "Process Finished - Press <RETURN>");
         INPUTCR(out WAIT, 1);
         goto L80;
      }
      void L0600()
      {
         /*  Update ADT.LOG */
         MAT(ref ADT_REC, "");
         ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + ADT_MEMBER_ID;
         ADT_REC[ADT_DATE] = TODAYS_DATE;
         ADT_REC[ADT_USER] = U_INITS;
         ADT_REC[ADT_REASON] = "MEMBERSHIP DELETED - " + PROGRAM;
         ADT_REC[ADT_TIME] = TIME();
         if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
         SEQ_NO = SEQ_NO + 1;
         MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
         WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
         return;
      L80: ;
         RELEASE();
         return;
      }
   }
}
