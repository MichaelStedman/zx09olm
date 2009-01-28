//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL048 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
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
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] NARRATIVES = new UvVar[999];
      UvVar[] TICKETFEE_PRICES = new UvVar[999];
      #endregion
      #region Variables
      UvVar TICKET_PRICE = "";
      UvVar PERIOD = "";
      UvVar MEMBER_NO = "";
      UvVar TICKET_CONCESS = "";
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar REV_VID = "";
      UvVar NRM_VID = "";
      UvVar DIM_REV_UND_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_DATA = "";
      UvVar AUTH_ID = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar CONCESSION = "";
      UvVar THIS = "";
      UvVar PROGRAM = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_MEMBER_PARAMS = "";
      UvVar EXPIRY_LEEWAY = "";
      UvVar AUTOMATIC_CONCESS = "";
      UvVar LEN_MEM_TYPE = "";
      UvVar NON_MEM_CONCESS = "";
      UvVar MEM_TYPE_CONCESS = "";
      UvVar REPLY = "";
      UvVar STAND = "";
      UvVar LJUST = "";
      UvVar RJUST = "";
      UvVar DEFAULT_COLOR = "";
      UvVar THIS_ONE = "";
      UvVar SECOND_NO = "";
      UvVar PAY_NOW = "";
      UvVar FIRST_NUMBER = "";
      UvVar NEXT_NUMBER = "";
      UvVar PRINT_NUMBER = "";
      UvVar CONCESS = "";
      UvVar PRICE = "";
      UvVar EXPIRY = "";
      UvVar BOOKING_SPORT = "";
      UvVar DISPLAY_TICKET_PRICE = "";
      UvVar MEMBER_PREFIX = "";
      UvVar MEMBERS = "";
      UvVar NO_OF_CONCS = "";
      UvVar CONC = "";
      UvVar CONCESS_KEY = "";
      UvVar CONTROL_REC = "";
      UvVar TYPE_POS = "";
      UvVar MEMBER_CONCESS = "";
      UvVar CONCESS_FOUND = "";
      UvVar VAR1 = "";
      UvVar PROG_TO_CALL = "";
      CallAt_PROG_TO_CALL CallAt_PROG_TO_CALL;
      UvVar THIS_PRICE = "";
      UvVar PRICE_POS = "";
      UvVar PRICE_ACCEPTED = "";
      UvVar THIS_EXPIRY = "";
      UvVar RESPONSE = "";
      UvVar NO_POSSIBLE = "";
      UvVar THIS_CONCESS = "";
      UvVar POS = "";
      UvVar LINE_NUMBER = "";
      UvVar CHOOSE = "";
      UvVar MULTIVALUE_NO = "";
      UvVar MAX_CONCESSION = "";
      UvVar TICKET_FEE_PRICE = "";
      UvVar COLOR_ON = "";
      UvVar END_NARR = "";
      UvVar BEG_NARR = "";
      UvVar DEF_POS = "";
      FL019 FL019;
      UvVar MEM_ID = "";
      FL006 FL006;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL048(ref UvVar[] TICK_FEES_REC, ref UvVar TICKET_PRICE, ref UvVar PERIOD, ref UvVar MEMBER_NO, ref UvVar TICKET_CONCESS)
      {
         this.TICK_FEES_REC = TICK_FEES_REC;
         this.TICKET_PRICE = TICKET_PRICE;
         this.PERIOD = PERIOD;
         this.MEMBER_NO = MEMBER_NO;
         this.TICKET_CONCESS = TICKET_CONCESS;
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
         /*  GET CONCESSION PRICES FOR TICKET.FEES */
         /*  IMPORTANT: THIS ROUTINE HAS BEEN COPIED FOR USE IN TOUCHSCREENS */
         /*             AND INTERNET BOOKINGS. THEREFORE DETAILS OF ANY */
         /*             AMENDMENTS MUST BE PASSED ONTO THE RELEVANT PEOPLE */
         /*             SO THAT ALL VERSIONS CAN BE KEPT UP TO DATE */
         /*  Last Updated : 11:00 18.05.95 */
         /* ******************************************************************* */
         PROGRAM = "FL048";
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
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
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.MEMBER.PARAMS

         if (!OPEN("FL.MEMBER.PARAMS", out FL_MEMBER_PARAMS)) { STOP("201", "FL.MEMBER.PARAMS"); }

         #endregion
         /*  DJA 23.4.97. Suppress auto-concessions if common variable has */
         /*               been set in Course Payments (FL730). This gives */
         /*               the user a chance to pick a concession for use */
         /*               when automatically re-enrolling a student in the */
         /*               future. */
         if (PROG_MESS[4] == "S")
         {
            MAT(ref CONTROLS_REC, "");
         }
         else
         {
            /* *  READ AUTOMATIC CONCESSIONS FOR MEMBERSHIP */
            if (!(MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], "AUTOMATIC.CONCESS")))
            {
               MAT(ref CONTROLS_REC, "");
            }
         }
         if (!READV(ref EXPIRY_LEEWAY, FL_MEMBER_PARAMS, "EXPIRY.LEEWAY", 2)) { EXPIRY_LEEWAY = 31; }
         EXPIRY_LEEWAY = EXPIRY_LEEWAY[1, 1];
         AUTOMATIC_CONCESS = CONTROLS_REC[1];
         LEN_MEM_TYPE = CONTROLS_REC[2];
         NON_MEM_CONCESS = CONTROLS_REC[3];
         MEM_TYPE_CONCESS = CONTROLS_REC[4];
         REPLY = "OK";
         STAND = 1;
         LJUST = "L#5";
         RJUST = "R2#5";
         MAT(ref NARRATIVES, "");
         MAT(ref TICKETFEE_PRICES, 0);
         DEFAULT_COLOR = DIM_REV_UND_VID;
         THIS_ONE = REV_VID;
         SECOND_NO = FALSE;
         PAY_NOW = 0;
         PROMPT("");
         FIRST_NUMBER = 1;
         NEXT_NUMBER = 5;
         PRINT_NUMBER = 0;
         CONCESS = "";
         PRICE = "";
         EXPIRY = "";
         if (TICKET_CONCESS == "B") { BOOKING_SPORT = TRUE; } else { BOOKING_SPORT = FALSE; }
         TICKET_CONCESS = "";
         DISPLAY_TICKET_PRICE = TICKET_PRICE / 100;
      /*  If Automatic Pricing then don't even ask which price */
      L0100: ;
         if (AUTOMATIC_CONCESS == "Y")
         {
            // BEGIN CASE
            // CASE
            if (MEMBER_NO != "")
            {
               if (NOT(MATCH(LEN_MEM_TYPE, "1N")))
               {
                  LEN_MEM_TYPE = 1;
               }
               MEMBER_PREFIX = MEMBER_NO.Substring(1, LEN_MEM_TYPE);
               if (READ(ref MEMBERS, COMMON.FILES[FL_MEMBERS], MEMBER_NO))
               {
                  NO_OF_CONCS = DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM);
                  for (CONC = 1; CONC <= NO_OF_CONCS; CONC += 1)
                  {
                     CONCESS_KEY = "CONCESS*" + TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC];
                     if (READ(ref CONTROL_REC, COMMON.FILES[FL_CONTROL], CONCESS_KEY))
                     {
                        TYPE_POS = 1;
                        do
                        {
                           MEMBER_CONCESS = MEMBERS[2, TYPE_POS];
                           CONCESS_FOUND = FALSE;
                           /* *Establish all possible prices according to the Members types (multiple) */
                           if (MEMBER_CONCESS == "") break;
                           if (LOCATE(MEMBER_CONCESS, CONTROL_REC, 1, 0, 1, ref VAR1, "AL"))
                           {
                              CONCESS_FOUND = TRUE;
                           }
                           else
                           {
                              MEMBER_CONCESS = MEMBER_PREFIX + "*" + MEMBERS[2].Substring(1, 1);
                              if (LOCATE(MEMBER_CONCESS, CONTROL_REC, 1, 0, 1, ref VAR1, "AL"))
                              {
                                 CONCESS_FOUND = TRUE;
                              }
                              else
                              {
                                 MEMBER_CONCESS = MEMBER_PREFIX;
                                 if (LOCATE(MEMBER_CONCESS, CONTROL_REC, 1, 0, 1, ref VAR1, "AL"))
                                 {
                                    CONCESS_FOUND = TRUE;
                                 }
                              }
                           }
                           if (CONCESS_FOUND && CONTROL_REC[2, VAR1] != "")
                           {
                              PROG_TO_CALL = CONTROL_REC[2, VAR1];
                              nrf0 = TICK_FEES_REC[TICK_FEES_CONCESSIONS];
                              CallAt_PROG_TO_CALL = new CallAt_PROG_TO_CALL(ref PROG_TO_CALL, ref MEMBER_NO, ref CONTROL_REC, ref nrf0, ref VAR1, ref CONC);
                           }
                           if (CONCESS_FOUND)
                           {
                              if (TICK_FEES_REC[24 + PERIOD][1, CONC] != "")
                              {
                                 if (AUTH_ID == "NCC" && MEMBER_PREFIX == "P" && TICK_FEES_REC[TICK_FEES_HEADCOUNT] > 1 && BOOKING_SPORT == TRUE && SECOND_NO == FALSE)
                                 {
                                    L1000();
                                    /*  Enter another member number for Newcastle */
                                    goto L0100;
                                 }
                                 THIS_PRICE = TICK_FEES_REC[24 + PERIOD][1, CONC];
                                 if (LOCATE(THIS_PRICE, PRICE, 1, 0, 1, ref PRICE_POS, "AR"))
                                 {
                                    PRICE_POS = PRICE_POS + 1;
                                 }
                                 CONCESS = INSERT(CONCESS, 1, PRICE_POS, 0, TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC]);
                                 PRICE = INSERT(PRICE, 1, PRICE_POS, 0, THIS_PRICE);
                                 EXPIRY = INSERT(EXPIRY, 1, PRICE_POS, 0, MEMBERS[13, TYPE_POS]);
                              }
                           }
                           TYPE_POS = TYPE_POS + 1;
                        } while (true);
                     }
                  }
               }
               // BEGIN CASE
               /*            CASE PRICE<1,2> = "" AND PRICE<1,1> # "" */
               /*               TICKET.CONCESS = CONCESS */
               /*               TICKET.PRICE = PRICE */
               /*               GO 9999 */
               /*            CASE PRICE<1,2> # "" */
               // CASE
               if (PRICE[1, 1] != "")
               {
                  /*  ESTABLISH LOWEST PRICE THAT HAS NOT EXPIRED */
                  PRICE_ACCEPTED = FALSE;
                  PRICE_POS = 0;
                  do
                  {
                     PRICE_POS = PRICE_POS + 1;
                     THIS_EXPIRY = EXPIRY[1, PRICE_POS];
                     if (PRICE_ACCEPTED || THIS_EXPIRY == "") break;
                     if (THIS_EXPIRY < TODAYS_DATE)
                     {
                        if (THIS_EXPIRY > TODAYS_DATE - EXPIRY_LEEWAY)
                        {
                           PRINT(ERR_LINE + "Entitlement to " + CONCESS[1, PRICE_POS] + "(" + OCONV(PRICE[1, PRICE_POS], COMMON.MD2) + ") Expired on " + OCONV(THIS_EXPIRY, "D2/") + " Still ALLOW (Y/N) ");
                           INPUTCR(out RESPONSE, 2);
                           if (RESPONSE == "Y")
                           {
                              PRICE_ACCEPTED = TRUE;
                           }
                        }
                     }
                     else
                     {
                        PRICE_ACCEPTED = TRUE;
                     }
                  } while (true);
                  if (PRICE_ACCEPTED)
                  {
                     PRICE_POS = PRICE_POS - 1;
                     TICKET_PRICE = PRICE[1, PRICE_POS];
                     TICKET_CONCESS = CONCESS[1, PRICE_POS];
                     goto L9999;
                  }
                  else
                  {
                     /* * Apply NON-MEMBER rate */
                     NO_OF_CONCS = DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM);
                     NO_POSSIBLE = 0;
                     for (CONC = 1; CONC <= NO_OF_CONCS; CONC += 1)
                     {
                        THIS_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC];
                        if (LOCATE(THIS_CONCESS, NON_MEM_CONCESS, 1, 0, 1, ref POS, "AL"))
                        {
                           NO_POSSIBLE = NO_POSSIBLE + 1;
                           if (TICK_FEES_REC[24 + PERIOD][1, CONC] != "")
                           {
                              TICKET_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC];
                              TICKET_PRICE = TICK_FEES_REC[24 + PERIOD][1, CONC];
                              /* !**!!                          GO 9999 */
                           }
                        }
                     }
                     if (NO_POSSIBLE == 1)
                     {
                        goto L9999;
                     }
                     TICKET_CONCESS = "";
                     TICKET_PRICE = "";
                  }
                  /*            END */
                  /*            GO 9999 */
                  /*               GO 9999 */
                  /* END */
               }
               // END CASE
            }// CASE
            else if (OTHERWISE)
            {
               NO_OF_CONCS = DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM);
               NO_POSSIBLE = 0;
               for (CONC = 1; CONC <= NO_OF_CONCS; CONC += 1)
               {
                  THIS_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC];
                  if (LOCATE(THIS_CONCESS, NON_MEM_CONCESS, 1, 0, 1, ref POS, "AL"))
                  {
                     NO_POSSIBLE = NO_POSSIBLE + 1;
                     if (TICK_FEES_REC[24 + PERIOD][1, CONC] != "")
                     {
                        TICKET_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CONC];
                        TICKET_PRICE = TICK_FEES_REC[24 + PERIOD][1, CONC];
                        /* !**!!                    GO 9999 */
                     }
                  }
               }
               if (NO_POSSIBLE == 1)
               {
                  goto L9999;
               }
               TICKET_CONCESS = "";
               TICKET_PRICE = "";
            }
            // END CASE
         }
         /*  ASK USER IF WANT TO USE STANDARD OR CONCESSION PRICES */
         LINE_NUMBER = 23;
         CHOOSE = " ";
         /*  FIND OUT HOW MANY CONCESSIONS THERE ARE, ADD 1 FOR STANDARD * */
         PRINT(AT(0, LINE_NUMBER) + SCREEN_BACK + SCREEN_DATA + COMMON.EOL);
         MULTIVALUE_NO = 0;
         MAX_CONCESSION = 0;
         do
         {
            MULTIVALUE_NO = MULTIVALUE_NO + 1;
            if (TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, MULTIVALUE_NO] == "") break;
            /* !**!!       IF MULTIVALUE.NO = 1 THEN */
            /* !**!!         NARRATIVES(MULTIVALUE.NO) = "STAND" "L#7": DISPLAY.TICKET.PRICE "R2#6" */
            /* !**!!         MAX.CONCESSION = MAX.CONCESSION + 1 */
            /* !**!!       END ELSE */
            if (TICK_FEES_REC[24 + PERIOD][1, MULTIVALUE_NO] != "")
            {
               TICKET_FEE_PRICE = TICK_FEES_REC[24 + PERIOD][1, MULTIVALUE_NO] / 100;
               MAX_CONCESSION = MAX_CONCESSION + 1;
               NARRATIVES[MAX_CONCESSION] = FORMAT(TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, MULTIVALUE_NO], "L#6") + FORMAT(TICKET_FEE_PRICE, "R2#7");
               TICKETFEE_PRICES[MAX_CONCESSION] = TICKET_FEE_PRICE;
            }
            /* !**!!       END */
         } while (true);
         if (MAX_CONCESSION == 1)
         {
            TICKET_CONCESS = TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, 1];
            TICKET_PRICE = TICK_FEES_REC[24 + PERIOD][1, 1];
            goto L9999;
         }
      L0200: ;
         /*  DISPLAY THE OPTIONS */
         PRINT(AT(0, LINE_NUMBER) + SCREEN_BACK + SCREEN_DATA + COMMON.EOL);
         if (PROG_MESS[25] == "FL394" && PROG_MESS[26] != "")
         {
            if (LOCATE(PROG_MESS[26], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref POS, "AL"))
            {
               TICKET_CONCESS = PROG_MESS[26];
               TICKET_PRICE = TICK_FEES_REC[24 + PERIOD][1, POS];
            }
            else
            {
               PROG_MESS[26] = "";
            }
         }
         if (PROG_MESS[26] == "")
         {
            for (CONCESSION = 1; CONCESSION <= 5; CONCESSION += 1)
            {
               PRINT_NUMBER = PRINT_NUMBER + 1;
               if (CONCESSION == 1)
               {
                  COLOR_ON = THIS_ONE;
               }
               else
               {
                  COLOR_ON = DEFAULT_COLOR;
               }
               if (NARRATIVES[PRINT_NUMBER] != "")
               {
                  END_NARR = (14 * CONCESSION) + 2;
                  BEG_NARR = (14 * (CONCESSION - 1)) + 2;
                  PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + NRM_VID);
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + COLOR_ON);
                  PRINT(AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[PRINT_NUMBER]);
               }
            }
            PRINT(AT(2, LINE_NUMBER));
            BEG_NARR = 2;
            THIS = 0;
            do
            {
               ECHO_OFF();
               INPUT(out CHOOSE, 1);
               ECHO_ON();
               if (CHOOSE == REPLY) break;
               /*  ABANDON DO */
               // BEGIN CASE
               // CASE
               if (CHOOSE == "")
               {
                  /*  YES PLEASE */
                  TICKET_CONCESS = NARRATIVES[FIRST_NUMBER + THIS][1].Substring(1, 7);
                  TICKET_CONCESS = TRIM(TICKET_CONCESS);
                  /* MHS!              TICKET.PRICE = NARRATIVES(FIRST.NUMBER+THIS)<1>[7,99] */
                  TICKET_PRICE = TICKETFEE_PRICES[FIRST_NUMBER + THIS];
                  TICKET_PRICE = TRIM(TICKET_PRICE);
                  /*          TICKET.PRICE = (TICKET.PRICE * 100)'R04' */
                  TICKET_PRICE = TICKET_PRICE * 100;
                  PRINT(AT(0, LINE_NUMBER) + COMMON.EOL);
                  if (PROG_MESS[25] == "FL394")
                  {
                     PROG_MESS[26] = TICKET_CONCESS;
                     PROG_MESS[27] = TICKET_PRICE;
                  }
                  goto L9999;
               }// CASE
               else if (CHOOSE == "6" || CHOOSE == "R")
               {
                  /*  NEXT PRICE BAND */
                  DEF_POS = THIS;
                  THIS = THIS + 1;
                  if (NARRATIVES[FIRST_NUMBER + THIS] == "" || THIS >= 5)
                  {
                     THIS = 0;
                  }
                  END_NARR = (14 * DEF_POS) + 2;
                  BEG_NARR = (14 * THIS) + 2;
                  PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
                  PRINT(AT(END_NARR, LINE_NUMBER) + DEFAULT_COLOR + AT(END_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + DEF_POS]);
                  /* DEFAULT.COLOR: */
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE + AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + THIS]);
                  /* THIS.ONE: */
                  PRINT(AT(BEG_NARR, LINE_NUMBER));
               }// CASE
               else if (CHOOSE == "4" || CHOOSE == "L")
               {
                  /*  NEXT PRICE BAND */
                  DEF_POS = THIS;
                  THIS = THIS - 1;
                  if (THIS < 0)
                  {
                     THIS = 4;
                     if (NARRATIVES[FIRST_NUMBER + THIS] == "")
                     {
                        do
                        {
                           THIS = THIS - 1;
                           if (NARRATIVES[FIRST_NUMBER + THIS] != "") break;
                        } while (true);
                     }
                  }
                  END_NARR = (14 * DEF_POS) + 2;
                  BEG_NARR = (14 * THIS) + 2;
                  PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
                  PRINT(AT(END_NARR, LINE_NUMBER) + DEFAULT_COLOR + AT(END_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + DEF_POS]);
                  /* DEFAULT.COLOR: */
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE + AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + THIS]);
                  /* THIS.ONE: */
                  PRINT(AT(BEG_NARR, LINE_NUMBER));
               }// CASE
               else if (CHOOSE == "N")
               {
                  /*  NEXT LINE */
                  DEF_POS = THIS;
                  if (NEXT_NUMBER + 1 <= MAX_CONCESSION)
                  {
                     NEXT_NUMBER = NEXT_NUMBER + 5;
                     FIRST_NUMBER = FIRST_NUMBER + 5;
                  }
                  else
                  {
                     NEXT_NUMBER = 5;
                     FIRST_NUMBER = 1;
                     PRINT_NUMBER = 0;
                  }
                  THIS = 0;
                  goto L0200;
               }// CASE
               else if (CHOOSE == COMMON.ABANDON)
               {
                  MEMBER_NO = COMMON.ABANDON;
                  TICKET_PRICE = COMMON.ABANDON;
                  goto L9999;
               }// CASE
               else if (OTHERWISE)
               {
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + " ");
                  PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE);
                  /* THIS.ONE: */
                  PRINT(AT(BEG_NARR, LINE_NUMBER));
               }
               // END CASE
            } while (true);
         }
      L9999: ;
         /* *** */
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA + COMMON.EOL);
         return;
      }
      /*  SUBROUTINES */
      void L1000()
      {
      /*  Enter another member number for Newcastle */
      L1001:
         ;
         PRINT(AT(2, 20) + "     Second No.[        ]" + SPACE(23));
         PRINT(AT(18, 20));
         nrf0 = 18;
         FL019 = new FL019(ref nrf0, ref MEM_ID);
         PRINT(AT(18, 20) + MEM_ID + "    ");
         if (LEN(MEM_ID) > 8) { PRINT(AT(-9) + " "); MEM_ID = MEM_ID.Substring(1, 8); }
         if (MEM_ID == MEMBER_NO)
         {
            nrf0 = 92;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            goto L1001;
         }
         SECOND_NO = TRUE;
         MEMBER_NO = MEM_ID;
         return;
      }
   }
}
