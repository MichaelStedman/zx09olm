//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL808 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar EXIT = 2;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar FL_BOOKINGS = 6;
readonly UvVar BOOK_MEMBER = 1;
readonly UvVar BOOK_NAME = 2;
readonly UvVar BOOK_FLOOR_AREAS = 3;
readonly UvVar BOOK_PAYMENT_STAT = 4;
readonly UvVar BOOK_PRICE = 5;
readonly UvVar BOOK_CANCEL_DATE = 6;
readonly UvVar BOOK_CANCEL_REASON = 7;
readonly UvVar BOOK_MADE_USER = 8;
readonly UvVar BOOK_MADE_DATE = 9;
readonly UvVar BOOK_MADE_TIME = 10;
readonly UvVar BOOK_TICKET = 11;
readonly UvVar BOOK_CONCESS = 12;
readonly UvVar BOOK_WRITE_OFF_DATE = 13;
readonly UvVar BOOK_WRITE_OFF_USER = 14;
readonly UvVar BOOK_PER_PERSON_NOS = 15;
readonly UvVar BOOK_PERSON = 16;
readonly UvVar BOOK_PERSON_AMOUNT = 17;
readonly UvVar BOOK_PERSON_DATE = 18;
readonly UvVar BOOK_PERSON_TICKET = 19;
readonly UvVar BOOK_REDEEM_POINTS = 20;
readonly UvVar BOOK_REDEEM_VALUE = 21;
readonly UvVar BOOK_WEB = 22;
readonly UvVar BOOK_UNIT_QUANTITY = 23;
readonly UvVar BOOK_UNIT_PRICE = 24;
readonly UvVar BOOK_AUTH_CODE = 25;
readonly UvVar BOOK_BASKET_REF = 26;
readonly UvVar BOOK_BONUS_POINTS = 27;
readonly UvVar BOOK_PROMOTION = 28;
readonly UvVar FL_SPORTS = 23;
readonly UvVar SPORTS_DESC = 1;
readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
readonly UvVar SPORTS_CODE1 = 3;
readonly UvVar SPORTS_CODE2 = 4;
readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
readonly UvVar SPORTS_TYPE = 6;
readonly UvVar SPORTS_BOOK_OR_CAS = 7;
readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
readonly UvVar SPORTS_RESTRICTION_CODE = 9;
readonly UvVar SPORTS_PERSON_BOOKING = 10;
readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
readonly UvVar SPORTS_SETUP_TIME = 12;
readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
readonly UvVar SPORTS_PLAYERS = 14;
readonly UvVar SPORTS_ADMINISTRATOR = 15;
readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
readonly UvVar SPORTS_VISIBILITY = 17;
readonly UvVar SPORTS_SUB_LIST = 18;
readonly UvVar SPORTS_TOP_LEVEL = 19;
readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
readonly UvVar FL_OPTIONS = 25;
readonly UvVar OPTION_PRIORITY = 1;
readonly UvVar OPTION_FLOORS = 2;
readonly UvVar OPTION_DESC = 3;
readonly UvVar OPTION_LOCATION = 4;
readonly UvVar OPTION_WEB_BOOKABLE = 5;
readonly UvVar OPTION_RELATIVE_START_TIME = 6;
readonly UvVar OPTION_BOOK_FLOOR_STATUS = 7;
readonly UvVar FL_USED_AREAS = 29;
readonly UvVar USED_START_TIME = 1;
readonly UvVar USED_FINISH_TIME = 2;
readonly UvVar USED_BOOKINGS = 3;
readonly UvVar FL_NON_MEMBERS = 116;
readonly UvVar NON_MEM_NAME = 1;
readonly UvVar NON_MEM_ADDRESS = 2;
readonly UvVar NON_MEM_PHONE = 3;
readonly UvVar NON_MEM_EMAIL = 4;
readonly UvVar NON_MEM_EMAIL_SALES = 5;
readonly UvVar FL_FLOOR_AREAS = 24;
readonly UvVar FLOOR_DESC = 1;
readonly UvVar FLOOR_FACILITIES = 2;
readonly UvVar FLOOR_PRICE = 3;
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
readonly UvVar FL_BLOCK_BOOKS = 32;
readonly UvVar BLOCK_BOOK_ACTIVITY = 1;
readonly UvVar BLOCK_BOOK_START_TIME = 2;
readonly UvVar BLOCK_BOOK_END_TIME = 3;
readonly UvVar BLOCK_BOOK_DATES = 4;
readonly UvVar BLOCK_BOOK_FLOORS = 5;
readonly UvVar BLOCK_BOOK_PRICE = 6;
readonly UvVar BLOCK_BOOK_FEE_REF = 7;
readonly UvVar BLOCK_BOOK_WK_AMTS = 8;
readonly UvVar FL_MAINT_RECS = 33;
readonly UvVar MAINT_DESC = 1;
readonly UvVar MAINT_START_TIME = 2;
readonly UvVar MAINT_END_TIME = 3;
readonly UvVar MAINT_DATE = 4;
readonly UvVar MAINT_FLOORS = 5;
readonly UvVar MAINT_FEE_REF = 6;
readonly UvVar FL_ACTIVITY_TEXT = 105;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar STAR = "*";
readonly UvVar YES = "Y";
readonly UvVar NO = "N";
readonly UvVar ERRM1 = "ERRM1";
readonly UvVar ERRM2 = "ERRM2";
readonly UvVar BLANK = "";
readonly UvVar MT = "MT";
readonly UvVar DT = "D";
readonly UvVar ODT = "D2/";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] BOOKINGS_REC = new UvVar[30];
UvVar[] SPORTS_REC = new UvVar[25];
UvVar[] OPTIONS_REC = new UvVar[10];
UvVar[] USED_AREAS_REC = new UvVar[3];
UvVar[] NON_MEMBER_REC = new UvVar[5];
UvVar[] FLOORS_REC = new UvVar[10];
UvVar[] CUST_REC = new UvVar[20];
UvVar[] BLOCK_REC = new UvVar[30];
UvVar[] BLOCK_BOOKS_REC = new UvVar[10];
UvVar[] MAINT_RECS = new UvVar[10];
UvVar[] ACTIVITY_TEXT = new UvVar[10];
UvVar[] DAYS = new UvVar[7];
#endregion
#region Variables
UvVar TERMINAL_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar TICKET_SWITCH = "";
UvVar VM = "";
UvVar ERR_PARAMS = "";
UvVar PROGRAM = "";
UvVar STORED_SP_CODE = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar LINE = "";
UvVar SP_CODE = "";
UvVar INPUT_COMPLETE = "";
UvVar SP_CODE2 = "";
UvVar SP_CODE_LENGTH = "";
UvVar FUNCTION_KEY_CONVERT = "";
UvVar FKEY = "";
UvVar SP_CODES = "";
UvVar RESOURCES_ONLY = "";
FL930 FL930;
UvVar RESOURCE_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar SPORT_CODE = "";
UvVar SP_DESC = "";
UvVar ENQ_DATE = "";
UvVar TESTDATE = "";
UvVar ODATE = "";
UvVar PRINT_TYPE = "";
UvVar LASTPAGE = "";
UvVar IDS = "";
UvVar BOOK_ATTS = "";
UvVar ARRAY = "";
UvVar NO_SPORTS = "";
UvVar SP_NO = "";
UvVar VMC = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar ZZZ_LN = "";
UvVar LTIME = "";
UvVar BK_ID = "";
UvVar BREC = "";
UvVar MEM_ID = "";
UvVar BNAME = "";
UvVar OPTION_ID = "";
UvVar PAID = "";
UvVar NON_MEMBER_DETAILS = "";
UvVar AMD_NUM = "";
UvVar CENTRE_BBACTIVITIES = "";
UvVar OCDATE = "";
UvVar DAYDATE = "";
UvVar MONTH = "";
UvVar YEAR = "";
FL0001_110 FL0001_110;
UvVar SPOSS = "";
UvVar INPUT_NO = "";
FL006 FL006;
UvVar PNTR = "";
UvVar NO_FACS = "";
UvVar FAC_NO = "";
UvVar OPT_KEY = "";
UvVar NO_FLOORS = "";
UvVar FLR_NO = "";
UvVar FLOOR = "";
UvVar USED_KEY = "";
UvVar NO_BOOKINGS = "";
UvVar BOOK_NO = "";
UvVar BOOK_KEY = "";
UvVar BOOK_SP = "";
UvVar DATE_FIELD = "";
UvVar PAGE_POS = "";
UvVar FLOOR_POS = "";
UvVar VAR = "";
UvVar FOUND = "";
UvVar NO_ARRAY = "";
UvVar AR_NO = "";
UvVar PAGE_NO = "";
UvVar HEADER = "";
UvVar BOOKING_TEXT = "";
FL024 FL024;
UvVar AUTH = "";
FL380_1 FL380_1;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL808()
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
   /*  BOOKING ENQUIRY */
   /*  Last updated : 12:44 23/09/92 */
   ERR_PARAMS = INIT;
   /* *** FILE NAMES **** */
   #region INCLUDE FL.FILES FL.CENTRES
   #region INCLUDE FL.FILES FL.CENTRES.EQU

   #endregion

   #region INCLUDE FL.FILES FL.CENTRES.DIM

   #endregion
   #region INCLUDE FL.FILES FL.CENTRES.VAR

   #endregion

   #endregion
   #region INCLUDE FL.FILES FL.BOOKINGS

   #endregion
   #region INCLUDE FL.FILES FL.SPORTS
   #region INCLUDE FL.FILES FL.SPORTS.EQU

   #endregion

   #region INCLUDE FL.FILES FL.SPORTS.DIM

   #endregion
   #region INCLUDE FL.FILES FL.SPORTS.VAR

   /*  Introduced for Warrington: */

   #endregion

   #endregion
   #region INCLUDE FL.FILES FL.OPTIONS
   #region INCLUDE FL.FILES FL.OPTIONS.EQU

   #endregion

   #region INCLUDE FL.FILES FL.OPTIONS.DIM

   #endregion
   #region INCLUDE FL.FILES FL.OPTIONS.VAR

   /* *  Relative start time is the time + or - the actual start time ** */
   /* *  to book the floor area out.                                  ** */
   /* *                                                               ** */
   /* *  Floor status is:- */
   /* *      Blank - Book all occurrences of floor area in all sports ** */
   /* *      N     - Do not book out chosen sport for floor area       ** */
   /* *      C     - Book only chosen sport for floor area            ** */
   /* * */

   #endregion

   #endregion
   #region INCLUDE FL.FILES FL.USED.AREAS
   #region INCLUDE FL.FILES FL.USED.AREAS.EQU

   #endregion

   #region INCLUDE FL.FILES FL.USED.AREAS.DIM

   #endregion
   #region INCLUDE FL.FILES FL.USED.AREAS.VAR

   #endregion

   #endregion
   #region INCLUDE FL.FILES FL.NON.MEMBERS

   /*  This item separated into three components */
   /*  by DJA 6.8.01 in conjunction with eBookings */
   /*  upgrade */
   #region INCLUDE FL.FILES FL.NON.MEMBERS.EQU

   #endregion
   #region INCLUDE FL.FILES FL.NON.MEMBERS.DIM

   #endregion
   #region INCLUDE FL.FILES FL.NON.MEMBERS.VAR

   #endregion

   #endregion
   #region INCLUDE FL.FILES FL.FLOOR.AREAS

   /* REMOVED THIS TO PREVENT CONFUSION, MUST BE SENT WITH MASTER HALL MAINT PROGRAM!     EQU HALL.DESC                         TO FLOORS.REC(2) */
   /*  This entry has been corrected as at 9/3/01 for Release 6.4 */
   /*  Floor price was wrongly equated to floor.rec */
   /*  Hall desc was only used by master hall maint so this prog was amended */

   #endregion
   #region INCLUDE FL.FILES FL.CUSTOMERS

   #endregion
   #region INCLUDE FL.FILES FL.BLOCK.HEADER

   #endregion
   #region INCLUDE FL.FILES FL.BLOCK.BOOKS

   /*   WK.AMTS HOLDS WEEKLY AMTS DUE FOR EASE OF RE-CALC */

   #endregion
   #region INCLUDE FL.FILES FL.MAINT.RECS

   #endregion
   #region INCLUDE FL.FILES FL.ACTIVITY.TEXT

   #endregion
   L120();
   STORED_SP_CODE = "";
/*  DJA 14.12.05. Supports help pop-up */
L10: ;
   SCREEN_CODE = "FL808";
   DOTS_ONLY = FALSE;
   FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
L20: ;
   PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
   for (LINE = 22; LINE <= 20; LINE += -1)
   {
      PRINT(AT(0, LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
      PRINT(AT(2, LINE) + SPACE(SCREEN_WIDTH - 2));
   }
   PRINT(AT(0, 4) + SCREEN_BACK + SCREEN_TEXT);
   PRINT(AT(2, 4) + "Centre code...............  [" + FORMAT(COMMON.CENTRE, "L#3") + "] - " + CENTRES_REC[CENTRE_NAME] + COMMON.EOL);
   PRINT(AT(0, 5) + SCREEN_BACK + SCREEN_TEXT);
   PRINT(AT(2, 5) + "Sport/Resource Code.......  [   ]");
   PRINT(AT(0, 6) + SCREEN_BACK + SCREEN_TEXT);
   PRINT(AT(2, 6) + "Booking date..............  [        ]");
   PRINT(AT(0, 7) + SCREEN_BACK + SCREEN_TEXT);
   PRINT(AT(2, 7) + "Screen or Printer ........  [" + COMMON.SP[1] + "]");
L30: ;
   PRINT(AT(31, 5) + COMMON.SP[3] + AT(31, 5));
   // BEGIN CASE
   // CASE
   if (STORED_SP_CODE != "")
   {
      /*  Already established via the pop-up help window */
      SP_CODE = STORED_SP_CODE;
      PRINT(AT(31, 5) + FORMAT(SP_CODE, "L#3"));
   }// CASE
   else if (TERMINAL_TYPE == "I" || TERMINAL_TYPE == "M" || TERMINAL_TYPE == "S")
   {
      INPUT_COMPLETE = FALSE;
      INPUT(out SP_CODE, 1);
      if (SP_CODE != "")
      {
         do
         {
            if (INPUT_COMPLETE) break;
            INPUT(out SP_CODE2, 1);
            if (SEQ(SP_CODE2) == 255) { INPUT_COMPLETE = TRUE; }
            else
            {
               SP_CODE = SP_CODE + SP_CODE2;
               SP_CODE_LENGTH = LEN(SP_CODE);
               if (!LOCATE(SP_CODE.Substring(SP_CODE_LENGTH - 1, 2), FUNCTION_KEY_CONVERT, 1, 0, 1, ref FKEY, "AL")) { FKEY = 0; }
               if (FKEY)
               {
                  SP_CODE = SP_CODE.Substring(1, SP_CODE_LENGTH - 2) + FUNCTION_KEY_CONVERT[2, FKEY];
                  INPUT_COMPLETE = TRUE;
               }
               if (SP_CODE_LENGTH == 4)
               {
                  INPUT_COMPLETE = TRUE;
               }
            }
         } while (true);
      }
   }// CASE
   else if (OTHERWISE)
   {
      INPUT(out SP_CODE, 4);
      if (LEN(SP_CODE) > 3) { PRINT(AT(-9) + " "); SP_CODE = SP_CODE.Substring(1, 3); }
   }
   // END CASE
   SP_CODE = OCONV(SP_CODE, "MCU");
   if (SP_CODE == COMMON.HELP)
   {
      SP_CODES = "";
      RESOURCES_ONLY = TRUE;
      FL930 = new FL930(ref RESOURCE_ID, ref INTERACT, ref REDISPLAY, ref SP_CODES, ref RESOURCES_ONLY);
      /* !SP.CODE = RESOURCE.ID */
      if (INTERACT != EXIT)
      {
         STORED_SP_CODE = RESOURCE_ID;
      }
      goto L10;
   }
   if (SP_CODE == TICKET_SWITCH)
   {
      L4000();
      STORED_SP_CODE = "";
      goto L10;
   }
   SPORT_CODE = SP_CODE;
   if (SP_CODE == COMMON.ABANDON) { goto L240; }
   if (SP_CODE != BLANK)
   {
      if (!READV(ref SP_DESC, COMMON.FILES[FL_SPORTS], SP_CODE, 1)) { goto L140; }
      PRINT(AT(36, 5) + FORMAT(("- " + SP_DESC), "L#42"));
   }
L40: ;
   PRINT(AT(31, 6) + COMMON.SP[8] + AT(31, 6));
   INPUT(out ENQ_DATE, 9);
   if (LEN(ENQ_DATE) > 8) { PRINT(AT(-9) + " "); ENQ_DATE = ENQ_DATE.Substring(1, 8); }
   if (ENQ_DATE == BLANK) { ENQ_DATE = OCONV(TODAYS_DATE, "D2/"); }
   if (ENQ_DATE == COMMON.ABANDON) { goto L240; }
   TESTDATE = ICONV(ENQ_DATE, DT);
   ODATE = OCONV(TESTDATE, ODT);
   if (ODATE == "") { goto L170; }
   PRINT(AT(31, 6) + ODATE);
L50: ;
   PRINT(AT(31, 7) + COMMON.SP[1] + AT(31, 7));
   INPUT(out PRINT_TYPE, 2);
   if (LEN(PRINT_TYPE) > 1) { PRINT(AT(-9) + " "); PRINT_TYPE = PRINT_TYPE.Substring(1, 1); }
   if (PRINT_TYPE == "") { PRINT_TYPE = "S"; }
   if (PRINT_TYPE == COMMON.ABANDON) { goto L240; }
   if (PRINT_TYPE != "S" && PRINT_TYPE != "P") { goto L150; }
   PRINT(AT(31, 7) + PRINT_TYPE.Substring(1, 1));
   LASTPAGE = 0;
   IDS = BLANK;
   BOOK_ATTS = BLANK;
   ARRAY = "";
   if (SP_CODE == BLANK)
   {
      NO_SPORTS = DCOUNT(CENTRES_REC[CENTRE_ACTIVITIES], VM);
      for (SP_NO = 1; SP_NO <= NO_SPORTS; SP_NO += 1)
      {
         SP_CODE = CENTRES_REC[CENTRE_ACTIVITIES][1, SP_NO];
         L1000();
      }
   }
   else
   {
      L1000();
   }
   VMC = 0;
   if (PRINT_TYPE == "P")
   {
      /* * Routine to set printer parameters  (condensed print) */
      PRINT_START_COMMAND = "";
      PRINT_END_COMMAND = "";
      PRINT_COMMANDS = "";
      nrf0 = "STANDARD";
      FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
      L2000();
      return;
   }
   ZZZ_LN = 10;
   PRINT(AT(0, 9) + SCREEN_BACK + SCREEN_TEXT);
   if (SPORT_CODE == "")
   {
      PRINT(AT(2, 9) + " Start    End  Memb No.     Surname         Sport          Court          Paid");
   }
   else
   {
      PRINT(AT(2, 9) + " Start    End  Memb No.     Surname              Court or area      Paid");
   }
   do
   {
      VMC = VMC + 1;
      LINE = ARRAY[1, VMC];
      if (LINE == BLANK) break;
      LTIME = LINE;
      BK_ID = ARRAY[3, VMC];
      if (READ(ref BREC, COMMON.FILES[FL_BOOKINGS], BK_ID))
      {
         if (BREC[6] != "" && TESTDATE >= TODAYS_DATE) { goto L60; }
         MEM_ID = BREC[1];
         BNAME = BREC[2];
         OPTION_ID = FIELD(BK_ID, "*", 1) + STAR + FIELD(BK_ID, "*", 2) + STAR + FIELD(BK_ID, "*", 4);
         PAID = BREC[4];
         if (PAID == "Y")
         {
            PAID = OCONV(BREC[5], "MD2");
         }
         else
         {
            PAID = "Not Paid";
         }
         PRINT(AT(2, ZZZ_LN) + COMMON.SP[1] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7"));
         PRINT(FORMAT(MEM_ID, "L#13"));
         if (SPORT_CODE == "")
         {
            PRINT(FORMAT(BNAME, "L#16"));
            PRINT(FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#15"));
            PRINT(FORMAT(OCONV(OPTION_ID, "TFL.OPTIONS;X;1;3"), "L#11"));
            /*            PRINT SP(1):PAID 'R#8': */
            PRINT(FORMAT(PAID, "R#8"));
         }
         else
         {
            PRINT(FORMAT(BNAME, "L#21"));
            PRINTCR(FORMAT(OCONV(OPTION_ID, "TFL.OPTIONS;X;1;3"), "L#15") + FORMAT(PAID, "R#8"));
            /* !           IF PAID=YES THEN */
            /* !             PRINT 'PAID' */
            /* !           END ELSE */
            /* !             PRINT 'NOT PAID' */
            /* !           END */
         }
         ZZZ_LN = ZZZ_LN + 1;
         if (MEM_ID == "")
         {
            if (!(READ(ref NON_MEMBER_DETAILS, COMMON.FILES[FL_NON_MEMBERS], BK_ID)))
            {
               NON_MEMBER_DETAILS = INIT;
            }
            if (NON_MEMBER_DETAILS != "" && ZZZ_LN != 20)
            {
               PRINTCR(SPACE(10) + FORMAT(NON_MEMBER_DETAILS[2], "L#30") + " " + FORMAT(NON_MEMBER_DETAILS[3], "L#15"));
               ZZZ_LN = ZZZ_LN + 1;
            }
         }
      }
      else
      {
         if (READ(ref BREC, COMMON.FILES[FL_BLOCK_HEADER], BK_ID))
         {
            if (!READV(ref BNAME, COMMON.FILES[FL_CUSTOMERS], FIELD(BK_ID, "/", 1), 1)) { BNAME = BK_ID; }
            PRINT(AT(2, ZZZ_LN) + COMMON.SP[1] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7"));
            /*            PRINT SPACE(9): */
            PRINT(FORMAT(BK_ID, "L#13"));
            if (SPORT_CODE == "")
            {
               PRINT(FORMAT(BNAME, "L#16"));
               PRINT(FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#17"));
            }
            else
            {
               PRINT(FORMAT(BNAME, "L#21"));
            }
            PRINT(FORMAT(BREC[1], "L#21"));
            ZZZ_LN = ZZZ_LN + 1;
         }
         else
         {
            if (READ(ref BREC, COMMON.FILES[FL_BLOCK_BOOKS], BK_ID))
            {
               BNAME = "";
               PRINT(AT(2, ZZZ_LN) + COMMON.SP[1] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7"));
               PRINT(SPACE(9));
               if (SPORT_CODE == "")
               {
                  PRINT(FORMAT(BNAME, "L#16"));
                  PRINT(FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#17"));
               }
               else
               {
                  PRINT(FORMAT(BNAME, "L#21"));
               }
               PRINT(FORMAT(BK_ID, "L#21"));
               ZZZ_LN = ZZZ_LN + 1;
            }
            else
            {
               if (READ(ref BREC, COMMON.FILES[FL_MAINT_RECS], BK_ID))
               {
                  PRINT(AT(2, ZZZ_LN) + COMMON.SP[1] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7"));
                  PRINT(SPACE(9));
                  PRINT(FORMAT(BREC[1], "L#33"));
                  PRINT(FORMAT(BK_ID, "L#21"));
                  ZZZ_LN = ZZZ_LN + 1;
               }
            }
         }
      }
      if (ZZZ_LN >= 20) { L70(); }
   L60: ;
   } while (true);
   LASTPAGE = 1;
   L70();
   goto L10;
}
void L70(){
PRINT(AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2) + AT(2, 21) + " Press <RETURN> to continue " + AT(48, 21));
INPUT(out AMD_NUM, 3);
if (LEN(AMD_NUM) > 2) { PRINT(AT(-9) + " "); AMD_NUM = AMD_NUM.Substring(1, 2); }
if (AMD_NUM == TICKET_SWITCH) {
L4000();
return;
}
if (AMD_NUM == COMMON.ABANDON) { return; }
if (AMD_NUM != BLANK) { goto L200; }
if (LASTPAGE) { return; }
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
for(ZZZ_LN = 10; ZZZ_LN <= 19; ZZZ_LN += 1) {
PRINT(AT(2, ZZZ_LN) + COMMON.EOL);
}
ZZZ_LN = 10;
return;
}
void L120() {
/*  Initialise */
if (!MATREAD(ref CENTRES_REC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE)) { goto L130; }
if (!(READV(ref CENTRE_BBACTIVITIES, COMMON.FILES[FL_CENTRES], COMMON.CENTRE + "*BB", 1))) {
CENTRE_BBACTIVITIES = "";
}
/* CENTRE.ACTIVITIES = CENTRE.BBACTIVITIES:VM:CENTRE.ACTIVITIES */
CENTRES_REC[CENTRE_ACTIVITIES] = CENTRES_REC[CENTRE_ACTIVITIES] + VM + CENTRE_BBACTIVITIES;
OCDATE = OCONV(TODAYS_DATE, ODT);
DAYDATE = OCDATE.Substring(1, 2);
MONTH = OCDATE.Substring(4, 2);
YEAR = OCDATE.Substring(7, 2);
DAYS[1] = "Mon";
DAYS[2] = "Tue";
DAYS[3] = "Wed";
DAYS[4] = "Thu";
DAYS[5] = "Fri";
DAYS[6] = "Sat";
DAYS[7] = "Sun";
PROGRAM = "FL808";
FL0001_110 = new FL0001_110(ref PROGRAM, ref FUNCTION_KEY_CONVERT);
SPOSS = 0;
/*  END OF INSERT */
return;
/*  Errors */
L130:;
INPUT_NO = 1;
ERR_PARAMS = COMMON.CENTRE;
L220();
goto L240;
L140:;
INPUT_NO = 2;
L220();
goto L30;
L150:;
INPUT_NO = 3;
L220();
goto L10;
L160:;
INPUT_NO = 4;
L220();
goto L70;
L170:;
INPUT_NO = 5;
L220();
goto L40;
L180:;
INPUT_NO = 6;
L220();
L190:;
INPUT_NO = 7;
L220();
goto L10;
L200:;
INPUT_NO = 8;
L220();
goto L70;
}
void L220() {
/*  Error Print */
FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref ERR_PARAMS);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
ERR_PARAMS = INIT;
return;
L240:;
/* THE END */
return;
/* **************************************** */
/*  SUBROUTINES */
/* **************************************** */
}
void L1000() {
if (LOCATE(SP_CODE, CENTRES_REC[CENTRE_ACTIVITIES], 1, 0, 1, ref PNTR, "AL")) {
NO_FACS = CENTRES_REC[CENTRE_FACILITY_NUM][1, PNTR];
for(FAC_NO = 1; FAC_NO <= NO_FACS; FAC_NO += 1) {
OPT_KEY = COMMON.CENTRE + "*" + SP_CODE + "*" + FAC_NO;
L1010();
}
}
OPT_KEY = COMMON.CENTRE + "*" + SP_CODE + "*BB";
L1010();
return;
}
void L1010() {
if (!MATREAD(ref OPTIONS_REC, COMMON.FILES[FL_OPTIONS], OPT_KEY)) { MAT(ref OPTIONS_REC, ""); }
NO_FLOORS = DCOUNT(OPTIONS_REC[OPTION_FLOORS][1], VM);
for(FLR_NO = 1; FLR_NO <= NO_FLOORS; FLR_NO += 1) {
FLOOR = OPTIONS_REC[OPTION_FLOORS][1, FLR_NO];
USED_KEY = COMMON.CENTRE + "*" + FLOOR + "*" + TESTDATE;
if (!MATREAD(ref USED_AREAS_REC, COMMON.FILES[FL_USED_AREAS], USED_KEY)) { MAT(ref USED_AREAS_REC, ""); }
NO_BOOKINGS = DCOUNT(USED_AREAS_REC[USED_BOOKINGS][1], VM);
for(BOOK_NO = 1; BOOK_NO <= NO_BOOKINGS; BOOK_NO += 1) {
BOOK_KEY = USED_AREAS_REC[USED_BOOKINGS][1, BOOK_NO];
BOOK_SP = FIELD(BOOK_KEY, "*", 2);
if (BOOK_SP == "") {
if (!(MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], BOOK_KEY))) {
MAT(ref BLOCK_REC, "");
if (MATREAD(ref BLOCK_BOOKS_REC, COMMON.FILES[FL_BLOCK_BOOKS], BOOK_KEY)) {
BOOK_SP = BLOCK_BOOKS_REC[BLOCK_BOOK_ACTIVITY];
} else {
if (MATREAD(ref MAINT_RECS, COMMON.FILES[FL_MAINT_RECS], BOOK_KEY)) {
BOOK_SP = BOOK_KEY;
} else {
MAT(ref BLOCK_BOOKS_REC, "");
}
}
}
for(DATE_FIELD = 8; DATE_FIELD <= 28; DATE_FIELD += 1) {
if (DATE_FIELD == 11) { DATE_FIELD = 25; }
if (DATE_FIELD < 11) {
PAGE_POS = DATE_FIELD - 7;
FLOOR_POS = DATE_FIELD - 3;
} else {
PAGE_POS = DATE_FIELD - 21;
FLOOR_POS = DATE_FIELD - 4;
}
if (LOCATE(TESTDATE, BLOCK_REC[DATE_FIELD][1], 1, 0, 1, ref VAR, "AR")) {
if (BLOCK_REC[BLOCK_STIME][1, PAGE_POS] == USED_AREAS_REC[USED_START_TIME][1, BOOK_NO] && BLOCK_REC[BLOCK_ETIME][1, PAGE_POS] == USED_AREAS_REC[USED_FINISH_TIME][1, BOOK_NO]) {
if (LOCATE(FLOOR, BLOCK_REC[FLOOR_POS][1], 1, 0, 1, ref VAR, "AL")) {
BOOK_SP = BLOCK_REC[BLOCK_SPORT][1, PAGE_POS];
}
}
}
}
}
if (BOOK_SP == SPORT_CODE || SPORT_CODE == "") {
FOUND = FALSE;
if (FIELD(BOOK_KEY, "*", 2) != "") {
/*  Casual Booking */
if (LOCATE(BOOK_KEY, ARRAY, 3, 0, 1, ref PNTR, "AL")) { FOUND = TRUE; }
} else {
/*  Block Booking */
NO_ARRAY = DCOUNT(ARRAY[3], VM);
for(AR_NO = 1; AR_NO <= NO_ARRAY; AR_NO += 1) {
if (ARRAY[3, AR_NO] == BOOK_KEY && ARRAY[1, AR_NO] == USED_AREAS_REC[USED_START_TIME][1, BOOK_NO] && ARRAY[2, AR_NO] == USED_AREAS_REC[USED_FINISH_TIME][1, BOOK_NO] && ARRAY[4, AR_NO] == BOOK_SP) { FOUND = TRUE; }
}
}
if (FOUND == FALSE) {
if (!LOCATE(USED_AREAS_REC[USED_START_TIME][1, BOOK_NO], ARRAY, 1, 0, 1, ref PNTR, "AR")) { NULL(); }
ARRAY = INSERT(ARRAY, 1, PNTR, 0, USED_AREAS_REC[USED_START_TIME][1, BOOK_NO]);
ARRAY = INSERT(ARRAY, 2, PNTR, 0, USED_AREAS_REC[USED_FINISH_TIME][1, BOOK_NO]);
ARRAY = INSERT(ARRAY, 3, PNTR, 0, BOOK_KEY);
ARRAY = INSERT(ARRAY, 4, PNTR, 0, BOOK_SP);
}
}
}
}
return;
}
void L2000() {
PAGE_NO = 0;
HEADER = "";
HEADER[1] = " BOOKINGS ENQUIRY FOR " + OCONV(TESTDATE, "D2/") + SPACE(40) + "Page ";
HEADER[2] = "";
HEADER[3] = "  Start    End  Memb No. Surname              Sport                 Court                Paid";
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
L3000();
do {
VMC = VMC + 1;
LINE = ARRAY[1, VMC];
if (LINE == BLANK) break;
LTIME = LINE;
BK_ID = ARRAY[3, VMC];
if (READ(ref BREC, COMMON.FILES[FL_BOOKINGS], BK_ID)) {
if (BREC[6] != "" && TESTDATE >= TODAYS_DATE) { goto L2060; }
MEM_ID = BREC[1];
BNAME = BREC[2];
OPTION_ID = FIELD(BK_ID, "*", 1) + STAR + FIELD(BK_ID, "*", 2) + STAR + FIELD(BK_ID, "*", 4);
PAID = BREC[4];
if (PAID == YES) {
PAID = OCONV(BREC[5], "MD2");
} else {
PAID = "N";
}
if (!(READV(ref BOOKING_TEXT, COMMON.FILES[FL_ACTIVITY_TEXT], BK_ID, 1))) {
BOOKING_TEXT = "";
}
PRINTCR(COMMON.SP[2] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7") + FORMAT(MEM_ID, "L#9") + FORMAT(BNAME, "L#21") + FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#21") + COMMON.SP[1] + FORMAT(OCONV(OPTION_ID, "TFL.OPTIONS;X;1;3"), "L#15") + FORMAT(PAID, "R#6") + SPACE(3) + BOOKING_TEXT.Substring(1, 40));
if (TRIM(BOOKING_TEXT.Substring(41, 40)) != "") {
PRINTCR(SPACE(92) + BOOKING_TEXT.Substring(41, 40));
ZZZ_LN = ZZZ_LN + 1;
}
ZZZ_LN = ZZZ_LN + 1;
if (MEM_ID == "") {
if (!(READ(ref NON_MEMBER_DETAILS, COMMON.FILES[FL_NON_MEMBERS], BK_ID))) {
NON_MEMBER_DETAILS = INIT;
}
if (NON_MEMBER_DETAILS != "" && ZZZ_LN != 60) {
PRINTCR(SPACE(26) + FORMAT(NON_MEMBER_DETAILS[2], "L#30") + " " + FORMAT(NON_MEMBER_DETAILS[3], "L#15"));
ZZZ_LN = ZZZ_LN + 1;
}
}
} else {
if (READ(ref BREC, COMMON.FILES[FL_BLOCK_HEADER], BK_ID)) {
if (!READV(ref BNAME, COMMON.FILES[FL_CUSTOMERS], FIELD(BK_ID, "/", 1), 1)) { BNAME = BK_ID; }
PRINT(COMMON.SP[2] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7"));
/* MR! SPACE(9):BNAME'L#21':OCONV(ARRAY<4,VMC>,'TFL.SPORTS;X;1;1')'L#21':SP(1):BREC<1>'L#21' */
PRINT(FORMAT(BK_ID, "L#9"));
if (SPORT_CODE == "") {
PRINT(FORMAT(BNAME, "L#21"));
PRINT(FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#22"));
} else {
PRINT(FORMAT(BNAME, "L#21"));
}
PRINTCR(FORMAT(BREC[1], "L#21"));
ZZZ_LN = ZZZ_LN + 1;
} else {
if (READ(ref BREC, COMMON.FILES[FL_BLOCK_BOOKS], BK_ID)) {
PRINTCR(COMMON.SP[3] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7") + SPACE(9) + SPACE(21) + FORMAT(OCONV(ARRAY[4, VMC], "TFL.SPORTS;X;1;1"), "L#21") + COMMON.SP[1] + FORMAT(BK_ID, "L#21"));
ZZZ_LN = ZZZ_LN + 1;
} else {
if (READ(ref BREC, COMMON.FILES[FL_MAINT_RECS], BK_ID)) {
PRINTCR(COMMON.SP[3] + FORMAT(OCONV(LTIME, MT), "L#6") + COMMON.SP[1] + FORMAT(OCONV(ARRAY[2, VMC], "MT"), "L#7") + SPACE(9) + FORMAT(BREC[1], "L#42") + COMMON.SP[1] + FORMAT(BK_ID, "L#21"));
ZZZ_LN = ZZZ_LN + 1;
}
}
}
}
if (ZZZ_LN >= 60) { L3000(); }
L2060:;
} while (true);
PRINT(PRINT_END_COMMAND);
PRINTER_CLOSE();
PRINTER_OFF();
return;
}
void L3000() {
/*  Print Header */
PAGE_NO = PAGE_NO + 1;
PRINTCR(CHAR(12));
PRINTCR(HEADER[1] + FORMAT(PAGE_NO, "R#4"));
PRINTCR(HEADER[2]);
PRINTCR(HEADER[3]);
ZZZ_LN = 3;
return;
}
void L4000() {
/*  Check Authority */
nrf0 = "FL380.1";
nrf1 = "P";
FL024 = new FL024(ref nrf0, ref nrf1, ref AUTH);
if (AUTH) {
FL380_1 = new FL380_1();
}
return;
}
}
}
