//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL0001_1_1 : UvBase
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
      readonly UvVar MEMBERS = 2;
      readonly UvVar CENTRE_FILE = 3;
      readonly UvVar CONTROL = 10;
      readonly UvVar TICKETS = 11;
      readonly UvVar FL_DICT_TICKETS = 63;
      readonly UvVar FL_MEMBER_PARAMS = 64;
      readonly UvVar MEMBERSHIP_NUMBERS = 65;
      readonly UvVar FL_RECONCILED_TICKETS = 36;
      readonly UvVar FL_OLD_TICKETS = 38;
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
      readonly UvVar FL_TILL_NUMBERS = 14;
      readonly UvVar TILL_TILL_NUMBER = 1;
      readonly UvVar TILL_LOCATION = 2;
      readonly UvVar TILL_TICKET_PRINTER_TYPE = 3;
      readonly UvVar TILL_TERMINAL_TYPE = 4;
      readonly UvVar TILL_AUDITORIUM_CODE = 5;
      readonly UvVar TILL_CASH_DRAWER = 6;
      readonly UvVar TILL_TRANS_TICK_PRINT = 7;
      readonly UvVar TILL_TICKET_PRINTER_QUE = 8;
      readonly UvVar TILL_ACTUAL_PORT = 9;
      readonly UvVar TILL_REC_SLIP_PRINT = 10;
      readonly UvVar TILL_AMT_TENDERED = 11;
      readonly UvVar TILL_POD = 12;
      readonly UvVar TILL_ENDORSE_CHEQUE = 13;
      readonly UvVar TILL_HOME_LOCATION = 14;
      readonly UvVar TILL_MULTIUSER_TOUCHSCREEN = 15;
      readonly UvVar TILL_TICKET_PRINTER_INTERFACE = 16;
      readonly UvVar TILL_TICKET_PRINTER_NAME = 17;
      readonly UvVar TILL_KITCHEN_PRINTER_INTERFACE = 18;
      readonly UvVar TILL_KITCHEN_PRINTER_NAME = 19;
      readonly UvVar TILL_LOCATION_DESC = 20;
      readonly UvVar TILL_THROW_LINES = 21;
      readonly UvVar TILL_TICKET_STUB = 22;
      readonly UvVar FL_MEMBER_STAGE_PAYMENTS = 100;
      readonly UvVar MEM_SP_ORIGINAL_FEE = 1;
      readonly UvVar MEM_SP_NO_OF_INSTALMENTS = 2;
      readonly UvVar MEM_SP_BALANCE = 3;
      readonly UvVar MEM_SP_PAYMENTS = 4;
      readonly UvVar MEM_SP_DATES = 5;
      readonly UvVar MEM_SP_TICKETS = 6;
      readonly UvVar MEM_SP_NEXT_DUE_DATE = 7;
      readonly UvVar ADT_RECORD_ID = 1;
      readonly UvVar ADT_DATE = 2;
      readonly UvVar ADT_USER = 3;
      readonly UvVar ADT_ORIG_VALUE = 4;
      readonly UvVar ADT_NEW_VALUE = 5;
      readonly UvVar ADT_REASON = 6;
      readonly UvVar ADT_TIME = 7;
      readonly UvVar FL_DIRECT_DEBITS = 117;
      readonly UvVar DIRECT_DEBIT_INST_AMOUNT = 1;
      readonly UvVar DIRECT_DEBIT_ANNUAL_FEE = 2;
      readonly UvVar DIRECT_DEBIT_LETTER = 3;
      readonly UvVar DIRECT_DEBIT_ORIGINAL_DATE = 4;
      readonly UvVar DIRECT_DEBIT_NUMBER = 5;
      readonly UvVar DIRECT_DEBIT_AMOUNTS = 6;
      readonly UvVar DIRECT_DEBIT_DATES = 7;
      readonly UvVar DIRECT_DEBIT_OPERATOR = 8;
      readonly UvVar DIRECT_DEBIT_ADJ = 9;
      readonly UvVar DIRECT_DEBIT_PAID = 10;
      readonly UvVar DIRECT_DEBIT_TRANS_CNT = 11;
      readonly UvVar DIRECT_DEBIT_LAST_REQ_AMOUNT = 12;
      readonly UvVar DIRECT_DEBIT_LAST_DATE = 13;
      readonly UvVar DIRECT_DEBIT_LAST_RECD_AMOUNT = 14;
      readonly UvVar DIRECT_DEBIT_CANCELLED_DATE = 15;
      readonly UvVar DIRECT_DEBIT_DEPOSIT = 16;
      readonly UvVar DIRECT_DEBIT_REJECTIONS = 17;
      readonly UvVar DIRECT_DEBIT_ADJ_TYPE = 18;
      readonly UvVar DIRECT_DEBIT_FREEZE_DATE = 19;
      readonly UvVar DIRECT_DEBIT_CANCEL_REASON = 20;
      readonly UvVar FL_BANK_DETAILS = 108;
      readonly UvVar BANK_SORT_CODE = 1;
      readonly UvVar BANK_ACCOUNT_NO = 2;
      readonly UvVar BANK_NAME = 3;
      readonly UvVar BANK_INSTALL_RECORDS = 4;
      readonly UvVar BANK_ACCOUNT_NAME = 5;
      readonly UvVar BANK_TRANS_CODE = 6;
      readonly UvVar BANK_BACS_REF = 7;
      readonly UvVar BANK_HOLDERS_ADDRESS = 8;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] TICK_FEES_REC = new UvVar[40];
      UvVar[] TILL_REC = new UvVar[25];
      UvVar[] MEM_SP_REC = new UvVar[10];
      UvVar[] ADT_REC = new UvVar[30];
      UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
      UvVar[] BANK_REC = new UvVar[10];
      UvVar[] SUB_TYPES = new UvVar[6];
      UvVar[] SUB_EXPIRY = new UvVar[6];
      UvVar[] SUB_PRICES = new UvVar[6];
      UvVar[] SUB_DDFLAGS = new UvVar[6];
      #endregion
      #region Variables
      UvVar DATA_REC = "";
      UvVar PORT_NUMBER = "";
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar ALL_CLEAR = "";
      UvVar REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar REV_UND_VID = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar SCREEN_DATA = "";
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar ERR_MESS_BACK = "";
      UvVar ERR_MESS_FORE = "";
      UvVar SCREEN_WIDTH = "";
      UvVar GO_BACK = "";
      UvVar TILL_NUMBER = "";
      UvVar AMD_KEY = "";
      UvVar AMD_REC = "";
      UvVar SC_POS = "";
      UvVar SCREEN_LINES = "";
      UvVar TICKET_SWITCH = "";
      UvVar COLOR_C = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar CLIENT_APP_TYPE = "";
      UvVar TRANS_LOG_REC = "";
      UvVar PROGRAM = "";
      UvVar SUBR = "";
      UvVar INTERACT = "";
      UvVar ESCG = "";
      UvVar COLOUR1 = "";
      UvVar COLOUR2 = "";
      UvVar COLOUR3 = "";
      UvVar COLOUR4 = "";
      UvVar COLOUR5 = "";
      UvVar COLOUR6 = "";
      UvVar COLOUR7 = "";
      UvVar COLOUR8 = "";
      UvVar FL_ADT_LOG = "";
      UvVar DICT_ADT_LOG = "";
      UvVar DFL_DIRECT_DEBITS = "";
      UvVar FL_BACS_REF = "";
      UvVar EFT_SITE = "";
      UvVar TICKET_PRINT_ROUTINE = "";
      UvVar MEM_PARAMS_REC = "";
      UvVar LEN_PREFIX = "";
      UvVar FIXED_LEN = "";
      UvVar CENTRE_PREFIX = "";
      UvVar NUMBER_LENGTH = "";
      UvVar ANAL_VAL_PROG = "";
      UvVar MEMSHP_START_PROMPT = "";
      UvVar MEM_TYPE_LIST = "";
      UvVar SUB_FEES_INCLUDE = "";
      UvVar MULTIPLE_TYPES = "";
      UvVar DOB_ONLY = "";
      UvVar SUPPRESS_BANKDETS = "";
      UvVar MEMBER_TYPES_DEPOSITS = "";
      UvVar MEMBER_PARAM = "";
      UvVar GENERATED_NUMBER = "";
      UvVar MEMBER_NO_ALLOCATION = "";
      UvVar MEMBER_NO_READ = "";
      UvVar NEW_MEMBER = "";
      UvVar MAIN_MIN_FIELDS = "";
      UvVar SUB_MIN_FIELDS = "";
      UvVar MUST_TAKE_MONEY = "";
      UvVar MUST_COMPLETE = "";
      UvVar GET_PICT = "";
      UvVar SKIP_FIELDS = "";
      UvVar PHOTO_PATH = "";
      UvVar CAMERA_OR_SCAN = "";
      UvVar SMART_CARD = "";
      UvVar SUB_KEY = "";
      UvVar TOTAL_DD_FEE = "";
      UvVar TOTAL_NONDD_FEE = "";
      UvVar TOTAL_DD_JOINING = "";
      UvVar TOTAL_DD_UPFRONT = "";
      UvVar NO_DDTYPES = "";
      UvVar NEW_EXPIRY = "";
      UvVar EXPIRY_DATE = "";
      UvVar NEW_NUMBERS_ISSUED = "";
      UvVar STATUS = "";
      UvVar UPDATE_TICKET_NUMBER = "";
      UvVar NO_OF_INSTALMENTS = "";
      UvVar VALID_PAYMENT = "";
      UvVar VALID_INPUT = "";
      UvVar INVALID_INPUT = "";
      UvVar DD_MMM_YY = "";
      UvVar YY = "";
      UvVar MOP_TYPES = "";
      UvVar CHEQUE_NO_REQUIRED = "";
      UvVar PR_RET = "";
      UvVar PR_RET2 = "";
      UvVar SURNAME_REPEAT = "";
      UvVar OPTION = "";
      UvVar TICKET_REC = "";
      UvVar SET_PREFIX = "";
      UvVar PRICE_TO_PRINT = "";
      UvVar CENTRE_CODE = "";
      UvVar SPEC = "";
      UvVar SPECIAL_PRICE = "";
      UvVar PRICE_OVERRIDE = "";
      UvVar CHILD_MINIMUM = "";
      UvVar CHILD_MAXIMUM = "";
      UvVar FEMALE_SENIOR = "";
      UvVar MALE_SENIOR = "";
      UvVar INDEXING_ROUTINE = "";
      UvVar LAST_NUMBER = "";
      UvVar DOTS_ONLY = "";
      UvVar SCREEN_CODE = "";
      UvVar ADDING_FAMILY = "";
      UvVar TOTAL_SUBS = "";
      UvVar ADDRESS = "";
      //FL000_10 FL000_10;
      UvVar CODE_NUM = "";
      UvVar LENGTH = "";
      UvVar JUSTIF = "";
      UvVar PASSWORD_CONTROL = "";
      //FL000_42 FL000_42;
      UvVar PREVIOUS_RECEIPT = "";
      UvVar FIRST_INPUT = "";
      UvVar INPUT_NO = "";
      UvVar MANUAL_NUMBER = "";
      UvVar MEM_REC = "";
      UvVar FAMILY_MEMBER = "";
      UvVar UPDATE_MEMBERSHIP_NUMBER = "";
      UvVar NO_MORE_FAMILY = "";
      UvVar ERROR_SET = "";
      UvVar CC_REF = "";
      UvVar EFT_CONF = "";
      UvVar CC_ISSUE = "";
      UvVar CC_START = "";
      UvVar EFT_AMOUNT = "";
      UvVar CC_EXP = "";
      UvVar PICT_REQ = "";
      UvVar PART_REC = "";
      UvVar COMPLETING_REC = "";
      UvVar ASK_FOR_MOP = "";
      UvVar SKIP_OVER = "";
      UvVar PRICE = "";
      UvVar TOTAL_JOINING = "";
      UvVar TOTAL_UPFRONT = "";
      UvVar CARD_TYPES = "";
      UvVar CARD_EXPIRY = "";
      UvVar CARD_PRICES = "";
      UvVar CARD_JOINING = "";
      UvVar CARD_UPFRONT = "";
      UvVar CARD_DDFLAGS = "";
      UvVar TYPE_FEE = "";
      UvVar STAGE_PAYMENT1 = "";
      UvVar FIRST_DIRECT_DEBIT = "";
      UvVar INPUT_LINES = "";
      UvVar PLACE = "";
      UvVar START_POS = "";
      UvVar ATTRIBUTE = "";
      UvVar MULTIV = "";
      UvVar SUBMEMBER_NO = "";
      UvVar ANS = "";
      UvVar ANAL_FIELD = "";
      UvVar DISPLAY_ROW = "";
      UvVar ANAL_POS = "";
      UvVar DISPLAY_COL = "";
      UvVar CODE_LIST = "";
      UvVar CODE_SELECTED = "";
      //FL_WINDOW FL_WINDOW;
      UvVar MEMSHP_START_DATE = "";
      UvVar I_MEMSHP_START_DATE = "";
      UvVar PROMPT_LEN = "";
      UvVar ST_COL = "";
      UvVar ST_ROW = "";
      UvVar MDISL = "";
      UvVar MAINMEM = "";
      //FL523 FL523;
      UvVar MAINMEM_EXP = "";
      FL006 FL006;
      UvVar SUM = "";
      UvVar DAY = "";
      UvVar O_EXPIRY = "";
      UvVar I_EXPIRY = "";
      UvVar EACH_TYPE = "";
      //FLQAS FLQAS;
      //CallAt_MEMBER_NO_READ CallAt_MEMBER_NO_READ;
      FL019 FL019;
      UvVar MEM_REC_POS = "";
      UvVar ADDRESS_POS = "";
      UvVar LEN_ANS = "";
      //FL380_1 FL380_1;
      UvVar VALIDATION_ERRORS = "";
      UvVar BKEY = "";
      UvVar TEST_REC = "";
      UvVar BACS_REC = "";
      UvVar DISPLAY_LINES = "";
      UvVar FIELD_TO_DISPLAY = "";
      UvVar APPLICANTS_TITLE = "";
      UvVar FAMILY_SURNAME = "";
      UvVar INITS1 = "";
      UvVar INITS_COL = "";
      UvVar INITS_ROW = "";
      UvVar SUB_POS = "";
      UvVar SUB_NO = "";
      UvVar APPLICANTS_SEX = "";
      UvVar REPLY = "";
      //FL_HIDE_PHOTO FL_HIDE_PHOTO;
      UvVar COL_POS = "";
      UvVar ROW_POS = "";
      UvVar FILE_OR_NOT = "";
      UvVar CHEQUE_NO = "";
      UvVar RET_FUNC = "";
      UvVar CC_AUTH = "";
      UvVar SWIPE_DETAILS = "";
      //FL361_EFT FL361_EFT;
      UvVar CARD_CVS = "";
      //FL_EFT FL_EFT;
      //FL361_1 FL361_1;
      UvVar TYPE_NO = "";
      UvVar MEMBER_NUMBER = "";
      //FL000_12 FL000_12;
      UvVar NEXT_TICKET_NUMBER = "";
      UvVar CURRENT_SESSION = "";
      UvVar LINE_NO = "";
      UvVar NO_OF_SUBMEMS = "";
      UvVar SUBNO = "";
      UvVar SUB_REC = "";
      UvVar TOTAL_SUB_PRICE = "";
      UvVar SUB_PRICE_COUNT = "";
      UvVar ZZZ_COUNT = "";
      UvVar SUB_AC_POS = "";
      UvVar MAIN_AC_POS = "";
      UvVar SUB_RESTCNS_POS = "";
      UvVar MAIN_RESTCNS_POS = "";
      //FL348 FL348;
      UvVar ADT_LOG_KEY = "";
      UvVar ADT_LOG_REASON = "";
      FLTX2 FLTX2;
      //FL000_45 FL000_45;
      //FL000_44 FL000_44;
      UvVar WAIT = "";
      UvVar NO_OF_TYPES = "";
      UvVar NO_OF_ACS = "";
      UvVar NO_OF_RESTCNS = "";
      UvVar NO_OF_COMMENTS = "";
      UvVar SEQ_NO = "";
      UvVar DUMMY_ANS = "";
      UvVar LAST_NUMBER_ISSUED = "";
      UvVar PRINT_TICKET_NO = "";
      UvVar CALL_REF = "";
      UvVar TODAYZ_DATE = "";
      //FL165 FL165;
      UvVar PERIOD = "";
      UvVar NARRATIVE = "";
      //FL102 FL102;
      //CallAt_SUBR CallAt_SUBR;
      UvVar TRANS_DETAILS = "";
      UvVar ZZZ_CHANGE = "";
      //CallAt_TICKET_PRINT_ROUTINE CallAt_TICKET_PRINT_ROUTINE;
      UvVar DD_ID = "";
      UvVar BACS_CONTROL = "";
      UvVar DAY1_OF_MONTH = "";
      UvVar DAY2_OF_MONTH = "";
      UvVar DAY_OF_MONTH = "";
      UvVar DD_POS = "";
      UvVar LEEWAY = "";
      UvVar DATE_LAST_RUN = "";
      UvVar MONTHS_LEEWAY = "";
      UvVar CUT_OFF_DAY = "";
      UvVar MTH = "";
      UvVar YR = "";
      UvVar DATE_NEXT_RUN = "";
      UvVar MONTH = "";
      UvVar YEAR = "";
      UvVar FIRST_DEBIT_MONTH = "";
      UvVar FIRST_DEBIT_YEAR = "";
      UvVar CUT_OFF_DATE = "";
      UvVar CUT_OFF_MONTH = "";
      UvVar CUT_OFF_YEAR = "";
      UvVar DD_DATE_COL = "";
      UvVar DD_DATE_ROW = "";
      UvVar USER_START_DATE = "";
      UvVar TEST_DATE = "";
      UvVar START_DATE = "";
      UvVar TYPE_COUNT = "";
      UvVar SUB_COUNT = "";
      UvVar TEST_SUB_REC = "";
      UvVar SUB_DD_FEE = "";
      UvVar DEPOSIT = "";
      //FL122 FL122;
      UvVar BANK_ID = "";
      //FL121 FL121;
      //FL153 FL153;
      UvVar VALIDATION_NO = "";
      UvVar OK_TO_SKIP = "";
      UvVar PHOTO_KEY = "";
      //FL_GET_PHOTO FL_GET_PHOTO;
      UvVar CENTRE_VALID_DESC = "";
      UvVar TEST_ID = "";
      UvVar M_NUM = "";
      UvVar APP_NUM = "";
      UvVar ENUF_SUB_NOS = "";
      UvVar SUBMEM_NUMBERS = "";
      UvVar TEST_NUM = "";
      UvVar TESTREC = "";
      UvVar AMT_COL = "";
      UvVar AMT_ROW = "";
      UvVar CARD_POS = "";
      UvVar MEMBERSHIP_TYPE = "";
      UvVar TICKET_CODE = "";
      //FL355 FL355;
      UvVar RESPONSE = "";
      UvVar FAMILY_MEMBERSHIP_TYPE = "";
      UvVar EXPIRY_DATE_PARAM = "";
      UvVar EXPIRY_CALC = "";
      UvVar EXPIRY_FROM_START = "";
      //CallAt_EXPIRY_CALC CallAt_EXPIRY_CALC;
      UvVar EXP_DAY = "";
      UvVar EXP_MTH = "";
      UvVar EXP_YR = "";
      UvVar NO_OF_MONTHS = "";
      UvVar SP_PASS = "";
      UvVar SEXY_COL = "";
      UvVar SEXY_ROW = "";
      UvVar NAME_OK = "";
      UvVar YEARS_OLD = "";
      UvVar CURR_YEAR = "";
      UvVar TEST_YEAR = "";
      UvVar DOB = "";
      //CallAt_INDEXING_ROUTINE CallAt_INDEXING_ROUTINE;
      UvVar NO_POSSIBLE_ERRORS = "";
      UvVar MANDATORY = "";
      UvVar EXP_COL = "";
      UvVar EXP_ROW = "";
      UvVar CH_DATE = "";
      UvVar CH_DATE2 = "";
      UvVar RECEIPT_CONTROL_FLAG = "";
      UvVar TICKET_FOUND = "";
      UvVar CONTROL_PASSWORD = "";
      UvVar ANAL_FIELD_NO = "";
      //CallAt_ANAL_VAL_PROG CallAt_ANAL_VAL_PROG;
      UvVar SURNAME = "";
      UvVar INITS2 = "";
      UvVar HOLD_INPUT = "";
      UvVar ABBREVIATION = "";
      //FL000_16 FL000_16;
      UvVar CHAR_POS = "";
      UvVar ZZZ_CHAR = "";
      UvVar TRANSFER_DATE = "";
      UvVar RESTR_POS = "";
      UvVar SUB_KEY_ALLOCATED = "";
      //CallAt_MEMBER_NO_ALLOCATION CallAt_MEMBER_NO_ALLOCATION;
      UvVar SUB_KEY_OK = "";
      UvVar ITS_LOCKED_OR_EXISTS = "";
      UvVar POS = "";
      UvVar SUBNO_ALREADY_USED = "";
      UvVar BACS_REF = "";
      UvVar TOTAL_NEWNOS = "";
      UvVar EACH_NEWNO = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      UvVar nrf3 = "";
      UvVar nrf4 = "";
      #endregion
      public FL0001_1_1()
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
      /*  MEMBERSHIP INPUT */
      /* *********************************************************************** */
      /*  Amendment Log */
      /*  Date      Name        Description */
      /*  ----      ----        ----------- */
      /*  22-05-08  Owen        Re-position membership start date prompt. */
      /* *********************************************************************** */
      L10:
         ;
         PROGRAM = "FL0001.1.1";
         SUBR = "FL000.15";
         /*  Files used in this process */
         #region INCLUDE FL.FILES FL.TICKET.FEES
         #region INCLUDE FL.FILES FL.TICKET.FEES.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TICKET.FEES.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.FEES.VAR

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.MEMBER.STAGE.PAYMENTS

         #endregion
         #region INCLUDE FL.FILES COLOUR.PALETTE

         /*  Colour palette definitions */
         ESCG = CHAR(27) + "G";
         COLOUR1 = ESCG + "0";
         COLOUR2 = ESCG + "4";
         COLOUR3 = ESCG + "p";
         COLOUR4 = ESCG + "8";
         COLOUR5 = ESCG + "t";
         COLOUR6 = ESCG + "<";
         COLOUR7 = ESCG + "x";
         COLOUR8 = ESCG + "|";

         #endregion
         #region INCLUDE FL.FILES FL.ADT.LOG

         if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
         if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
         /*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

         #endregion
         #region INCLUDE FL.FILES FL.DIRECT.DEBITS

         #endregion
         #region INCLUDE FL.FILES FL.BANK.DETAILS

         #endregion
         /* ****** */
         /*  LOG * */
         /* ****** */
         /* * */
         /* * Establish cLIENT sOFTWARE */
         /* !*     CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
         CLIENT_APP_TYPE = "";
         if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
         if (!OPEN("FL.BACS.REF", out FL_BACS_REF)) { STOP("NO FL.BACS.REF FILE"); }
         /*  Read in Membership parameters */
         /* <EFT */
         if (!(READV(ref EFT_SITE, COMMON.FILES[CONTROL], "EFT.SITE", 1)))
         {
            EFT_SITE = FALSE;
         }
         /* EFT> */
         if (!(READ(ref TICKET_PRINT_ROUTINE, COMMON.FILES[CONTROL], "TICKET.PRINT.ROUTINE")))
         {
            TICKET_PRINT_ROUTINE = "";
         }
         if (!READ(ref MEM_PARAMS_REC, COMMON.FILES[CONTROL], "AUTOMATIC.CONCESS")) { MEM_PARAMS_REC = ""; }
         if (MEM_PARAMS_REC[2] != "") { LEN_PREFIX = MEM_PARAMS_REC[2]; } else { LEN_PREFIX = 1; }
         if (MEM_PARAMS_REC[4] != "") { FIXED_LEN = MEM_PARAMS_REC[4]; } else { FIXED_LEN = "F"; }
         if (MEM_PARAMS_REC[5] != "") { CENTRE_PREFIX = MEM_PARAMS_REC[5]; } else { CENTRE_PREFIX = COMMON.CENTRE; }
         if (MEM_PARAMS_REC[6] != "") { NUMBER_LENGTH = MEM_PARAMS_REC[6]; } else { NUMBER_LENGTH = 4; }
         if (MEM_PARAMS_REC[9] != "" && MEM_PARAMS_REC[9].Substring(1, 1) != "*")
         {
            ANAL_VAL_PROG = MEM_PARAMS_REC[9];
         }
         if (MEM_PARAMS_REC[10] != "Y")
         {
            MEMSHP_START_PROMPT = FALSE;
         }
         else
         {
            MEMSHP_START_PROMPT = TRUE;
         }
         MEM_TYPE_LIST = FALSE;
         SUB_FEES_INCLUDE = FALSE;
         if (MEM_PARAMS_REC[11, 1] == "Y")
         {
            MULTIPLE_TYPES = TRUE;
            MEM_TYPE_LIST = TRUE;
            SUB_FEES_INCLUDE = TRUE;
         }
         else
         {
            MULTIPLE_TYPES = FALSE;
            if (MEM_PARAMS_REC[11, 2] == "Y")
            {
               MEM_TYPE_LIST = TRUE;
            }
            if (MEM_PARAMS_REC[11, 2] == "S")
            {
               MEM_TYPE_LIST = TRUE;
               SUB_FEES_INCLUDE = TRUE;
            }
         }
         if (!READV(ref DOB_ONLY, COMMON.FILES[FL_MEMBER_PARAMS], "DOB.ONLY", 1)) { DOB_ONLY = "N"; }
         SUPPRESS_BANKDETS = FALSE;
         if (READV(ref SUPPRESS_BANKDETS, COMMON.FILES[FL_MEMBER_PARAMS], "SUPPRESS.BANKDETS", 1))
         {
            if (SUPPRESS_BANKDETS == "Y" || SUPPRESS_BANKDETS == 1) { SUPPRESS_BANKDETS = TRUE; } else { SUPPRESS_BANKDETS = FALSE; }
         }
         if (!(READ(ref MEMBER_TYPES_DEPOSITS, COMMON.FILES[FL_MEMBER_PARAMS], "MEMBER.TYPES.DEPOSITS")))
         {
            MEMBER_TYPES_DEPOSITS = "";
         }
         if (!(READ(ref MEMBER_PARAM, COMMON.FILES[CONTROL], "MEMBER.NO.ALLOCATION")))
         {
            MEMBER_PARAM = "";
         }
         GENERATED_NUMBER = MEMBER_PARAM[2];
         MEMBER_NO_ALLOCATION = MEMBER_PARAM[1];
         MEMBER_NO_READ = MEMBER_PARAM[3];
         if (!READ(ref NEW_MEMBER, COMMON.FILES[CONTROL], "NEW.MEMBER.CONTROL")) { NEW_MEMBER = ""; }
         MAIN_MIN_FIELDS = NEW_MEMBER[1, 1];
         SUB_MIN_FIELDS = NEW_MEMBER[1, 2];
         MUST_TAKE_MONEY = NEW_MEMBER[2];
         MUST_COMPLETE = NEW_MEMBER[3];
         GET_PICT = NEW_MEMBER[4];
         SKIP_FIELDS = NEW_MEMBER[5];
         if (!(READ(ref PHOTO_PATH, COMMON.FILES[CONTROL], "PHOTO.PATH*" + PORT_NUMBER)))
         {
            if (!(READ(ref PHOTO_PATH, COMMON.FILES[CONTROL], "PHOTO.PATH")))
            {
               PHOTO_PATH = "";
            }
         }
         CAMERA_OR_SCAN = PHOTO_PATH[2, 1];
         PHOTO_PATH = PHOTO_PATH[1, 1];
         if (!(READV(ref SMART_CARD, COMMON.FILES[CONTROL], "SMART.CARD.SITE", 1)))
         {
            SMART_CARD = FALSE;
         }
         /*  Identify barcode printer attached */
         if (!MATREAD(ref TILL_REC, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER)) { MAT(ref TILL_REC, ""); }
         /*  Program Constants */
         MAT(ref SUB_TYPES, "");
         MAT(ref SUB_EXPIRY, "");
         MAT(ref SUB_PRICES, "");
         MAT(ref SUB_DDFLAGS, "");
         SUB_KEY = "";
         TOTAL_DD_FEE = 0;
         TOTAL_NONDD_FEE = 0;
         TOTAL_DD_JOINING = 0;
         TOTAL_DD_UPFRONT = 0;
         NO_DDTYPES = TRUE;
         NEW_EXPIRY = "";
         EXPIRY_DATE = 365;
         NEW_NUMBERS_ISSUED = "";
         STATUS = "";
         UPDATE_TICKET_NUMBER = "";
         NO_OF_INSTALMENTS = "";
         VALID_PAYMENT = FALSE;
         VALID_INPUT = TRUE;
         INVALID_INPUT = FALSE;
         DD_MMM_YY = OCONV(TODAYS_DATE, "D");
         YY = DD_MMM_YY.Substring(10, 2);
         if (!(READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES")))
         {
            MOP_TYPES = "";
            MOP_TYPES[1] = "C";
            MOP_TYPES[2] = "X";
         }
         if (!(READV(ref CHEQUE_NO_REQUIRED, COMMON.FILES[CONTROL], "CHEQUE.NO.REQUIRED", 1)))
         {
            CHEQUE_NO_REQUIRED = FALSE;
         }
         PR_RET = " <RETURN> for cash, X for cheque or other MOP ";
         PR_RET2 = " Press <RETURN> to continue";
         SURNAME_REPEAT = "R";
         OPTION = "";
         TICKET_REC = "";
         SET_PREFIX = "";
         PRICE_TO_PRINT = "";
         if (CENTRE_PREFIX == "") { CENTRE_PREFIX = COMMON.CENTRE; }
         if (CENTRE_PREFIX == "NONE")
         {
            if (LEN_PREFIX == "") { LEN_PREFIX = 1; }
            SET_PREFIX = "NONE";
         }
         CENTRE_CODE = COMMON.CENTRE;
         SPEC = "SPECIALS.PASS";
         SPECIAL_PRICE = 0;
         PRICE_OVERRIDE = FALSE;
         if (!READV(ref CHILD_MINIMUM, COMMON.FILES[CONTROL], "CHILD.MINIMUM", 1)) { CHILD_MINIMUM = ""; }
         if (!READV(ref CHILD_MAXIMUM, COMMON.FILES[CONTROL], "CHILD.MAXIMUM", 1)) { CHILD_MAXIMUM = ""; }
         if (!READV(ref FEMALE_SENIOR, COMMON.FILES[CONTROL], "FEMALE.SENIOR", 1)) { FEMALE_SENIOR = ""; }
         if (!READV(ref MALE_SENIOR, COMMON.FILES[CONTROL], "MALE.SENIOR", 1)) { MALE_SENIOR = ""; }
         if (!READV(ref INDEXING_ROUTINE, COMMON.FILES[FL_MEMBER_PARAMS], "INDEX.CONTROL", 1)) { INDEXING_ROUTINE = ""; }
      L20: ;
         /*  Set up the ticket record constants */
         PRICE_OVERRIDE = FALSE;
         LAST_NUMBER = COMMON.CENTRE + "*LAST.NUMBER";
         DOTS_ONLY = 0;
         SCREEN_CODE = PROGRAM;
         ADDING_FAMILY = 0;
         TOTAL_SUBS = 0;
         ADDRESS = "";
         NEW_NUMBERS_ISSUED = "";
      L25: ;
         //FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         /*  Print screen or dots only */
         if (MEM_PARAMS_REC[7] != "" && MEM_PARAMS_REC[7].Substring(1, 1) != "*")
         {
            PRINT(AT(21, 17) + DIM_VID);
            for (CODE_NUM = 1; CODE_NUM <= 6; CODE_NUM += 1)
            {
               // BEGIN CASE
               // CASE
               if (CODE_NUM == 1 || CODE_NUM == 2)
               {
                  LENGTH = 8;
               }// CASE
               else if (CODE_NUM >= 3 && CODE_NUM <= 5)
               {
                  LENGTH = 7;
               }// CASE
               else if (CODE_NUM == 6)
               {
                  LENGTH = 10;
               }
               // END CASE
               JUSTIF = "L#" + LENGTH;
               PRINT(DIM_VID + FORMAT(MEM_PARAMS_REC[7, CODE_NUM], JUSTIF));
               if (CODE_NUM != 6) { PRINT(SPACE(2)); }
            }
         }
         if (!(READ(ref PASSWORD_CONTROL, COMMON.FILES[FL_MEMBER_PARAMS], "PASSWORD.CONTROL")))
         {
            PASSWORD_CONTROL = "";
         }
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(0, 23) + COMMON.EOL);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         //FL000_42 = new FL000_42(ref CENTRE_PREFIX);
         /*  Establish Centre Code */
         PREVIOUS_RECEIPT = 0;
         FIRST_INPUT = 1;
         INPUT_NO = 1;
         MANUAL_NUMBER = FALSE;
         MEM_REC = "";
         MEM_REC[1] = COMMON.CENTRE;
         FAMILY_MEMBER = 1;
         UPDATE_MEMBERSHIP_NUMBER = 0;
         NO_MORE_FAMILY = 0;
         ERROR_SET = FALSE;
         CC_REF = "";
         /* <EFT */
         EFT_CONF = "";
         CC_ISSUE = "";
         CC_START = "";
         EFT_AMOUNT = 0;
         /* EFT> */
         CC_EXP = "";
         PRINT(AT(13, 3) + COMMON.CENTRE);
         /*  Get inputs */
         PICT_REQ = "";
         PART_REC = "";
         COMPLETING_REC = "";
         ASK_FOR_MOP = "";
         SKIP_OVER = 0;
         PRICE = 0;
         TOTAL_JOINING = 0;
         TOTAL_UPFRONT = 0;
         CARD_TYPES = "";
         TICKET_REC = "";
         TICKET_REC[4] = TODAYS_DATE;
         TICKET_REC[8] = U_INITS;
         CARD_EXPIRY = "";
         CARD_PRICES = "";
         CARD_JOINING = "";
         CARD_UPFRONT = "";
         CARD_DDFLAGS = "";
         PRICE_TO_PRINT = "";
         TYPE_FEE = "";
         SPECIAL_PRICE = "";
         STAGE_PAYMENT1 = "";
         TOTAL_DD_FEE = 0;
         TOTAL_NONDD_FEE = 0;
         FIRST_DIRECT_DEBIT = "";
      L28: ;
         for (INPUT_LINES = 4; INPUT_LINES <= SCREEN_LINES; INPUT_LINES += 1)
         {
            if (SC_POS[INPUT_LINES, 4]) { NULL(); } else { goto L50; }
            INPUT_NO = INPUT_NO + 1;
            if (INPUT_NO != 2) { FIRST_INPUT = 0; }
            PLACE = SC_POS[INPUT_LINES, 5];
            START_POS = LEN(SC_POS[INPUT_LINES, 3]) + 2;
            ATTRIBUTE = FIELD(PLACE, ",", 1);
            if (ADDING_FAMILY)
            {
               // BEGIN CASE
               // CASE
               if (ATTRIBUTE == 16)
               {
                  MULTIV = (SUBMEMBER_NO * 6) - 6 + FIELD(PLACE, ",", 2);
               }// CASE
               else if (ATTRIBUTE == 27)
               {
                  MULTIV = (SUBMEMBER_NO * 3) - 3 + FIELD(PLACE, ",", 2);
               }// CASE
               else if (OTHERWISE)
               {
                  MULTIV = SUBMEMBER_NO;
               }
               // END CASE
            }
            else
            {
               MULTIV = FIELD(PLACE, ",", 2);
            }
            if (COMPLETING_REC && ATTRIBUTE == 2) { goto L50; }
            if (COMPLETING_REC && MEM_REC[ATTRIBUTE, MULTIV] != "") { goto L50; }
            if (ATTRIBUTE == 16)
            {
               if (PART_REC)
               {
                  ANS = SKIP_FIELDS;
               }
               else
               {
                  ANAL_FIELD = FIELD(PLACE, ",", 2);
                  DISPLAY_ROW = 18;
                  if (ADDING_FAMILY)
                  {
                     /* ANAL.POS = ((SUBMEMBER.NO - 1) * 6) + 1 */
                     ANAL_POS = MULTIV;
                  }
                  else
                  {
                     ANAL_POS = ANAL_FIELD;
                  }
                  // BEGIN CASE
                  // CASE
                  if (ANAL_FIELD == 1 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 21;
                  }// CASE
                  else if (ANAL_FIELD == 1 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 32;
                     DISPLAY_ROW = 16;
                  }// CASE
                  else if (ANAL_FIELD == 2 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 31;
                  }// CASE
                  else if (ANAL_FIELD == 2 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 47;
                     DISPLAY_ROW = 16;
                  }// CASE
                  else if (ANAL_FIELD == 3 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 41;
                  }// CASE
                  else if (ANAL_FIELD == 3 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 62;
                     DISPLAY_ROW = 16;
                  }// CASE
                  else if (ANAL_FIELD == 4 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 50;
                  }// CASE
                  else if (ANAL_FIELD == 4 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 32;
                  }// CASE
                  else if (ANAL_FIELD == 5 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 59;
                  }// CASE
                  else if (ANAL_FIELD == 5 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 47;
                  }// CASE
                  else if (ANAL_FIELD == 6 && NOT(ADDING_FAMILY))
                  {
                     DISPLAY_COL = 68;
                  }// CASE
                  else if (ANAL_FIELD == 6 && ADDING_FAMILY)
                  {
                     DISPLAY_COL = 62;
                  }
                  // END CASE
                  if (READ(ref CODE_LIST, COMMON.FILES[FL_MEMBER_PARAMS], "ANALYSIS.CODES*" + ANAL_FIELD))
                  {
                     CODE_SELECTED = 1;
                     nrf0 = "";
                     nrf1 = "L#10";
                     //FL_WINDOW = new FL_WINDOW(ref PROGRAM, ref CODE_LIST, ref CODE_SELECTED, ref nrf0, ref nrf1, ref INTERACT);
                     // BEGIN CASE
                     // CASE
                     if (INTERACT == GO_BACK)
                     {
                        CODE_SELECTED = "";
                        ANS = GO_BACK;
                        PRINT(NRM_VID);
                        L140();
                        goto L50;
                     }// CASE
                     else if (INTERACT == COMMON.ABANDON)
                     {
                        CODE_SELECTED = "";
                        MEM_REC[16, ANAL_POS] = CODE_SELECTED;
                        PRINTCR(AT(DISPLAY_COL, DISPLAY_ROW) + NRM_VID + CODE_SELECTED);
                        goto L50;
                     }// CASE
                     else if (OTHERWISE)
                     {
                        CODE_SELECTED = CODE_LIST[CODE_SELECTED, 1];
                        MEM_REC[16, ANAL_POS] = CODE_SELECTED;
                        PRINTCR(AT(DISPLAY_COL, DISPLAY_ROW) + NRM_VID + CODE_SELECTED);
                        goto L50;
                     }
                     // END CASE
                     /* MEM.REC<16,ANAL.POS> = CODE.SELECTED */
                     /* PRINT @(DISPLAY.COL,DISPLAY.ROW):NRM.VID:CODE.SELECTED */
                     /* GO 50 */
                  }
               }
            }
            /*  membership start prompt */
            if (INPUT_NO == 3)
            {
            L45:
               ;
               if (MEMSHP_START_PROMPT == TRUE && NOT(COMPLETING_REC))
               {
                  if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                  {
                     PRINT(CHAR(28) + "404");
                     PRINTCR("Membership start date will be ");
                     PRINTCR("..........");
                     PRINTCR(OCONV(TODAYS_DATE, "D2/"));
                     PRINT(CHAR(20));
                  }
                  else
                  {
                     PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
                     PRINT(SPACE(SCREEN_WIDTH - 2));
                     PRINT(AT(2, 23));
                     PRINT("Membership start date will be " + OCONV(TODAYS_DATE, "D2/"));
                     CRT(AT(32, 23));
                  }
                  INPUT(out MEMSHP_START_DATE, 11);
                  PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
                  if (MEMSHP_START_DATE == "")
                  {
                     MEM_REC[32] = TODAYS_DATE;
                  }
                  else
                  {
                     I_MEMSHP_START_DATE = ICONV(MEMSHP_START_DATE, "D");
                     if (I_MEMSHP_START_DATE != "" && I_MEMSHP_START_DATE >= DATE())
                     {
                        MEM_REC[32] = I_MEMSHP_START_DATE;
                     }
                     else
                     {
                        goto L45;
                     }
                  }
               }
               if (MEMSHP_START_PROMPT == FALSE && NOT(COMPLETING_REC))
               {
                  MEM_REC[32] = TODAYS_DATE;
               }
               PRINT(AT(5, 14) + DIM_VID + "Start Date");
               PRINTCR(AT(17, 14) + SCREEN_BACK + OCONV(MEM_REC[32], "D4"));
            }
            PROMPT_LEN = SC_POS[INPUT_LINES, 4];
            ST_COL = SC_POS[INPUT_LINES, 1] + START_POS;
            ST_ROW = SC_POS[INPUT_LINES, 2];
            MDISL = PROMPT_LEN + 1;
            PRINT(AT(ST_COL, ST_ROW));
            if (MEM_TYPE_LIST == TRUE)
            {
               if (INPUT_NO == 3 || INPUT_NO == 38 || INPUT_NO == 54 || INPUT_NO == 70 || INPUT_NO == 86 || INPUT_NO == 102)
               {
                  CARD_TYPES = "";
                  CARD_PRICES = "";
                  CARD_EXPIRY = "";
                  CARD_JOINING = "";
                  CARD_UPFRONT = "";
                  CARD_DDFLAGS = "";
                  if (INPUT_NO == 3)
                  {
                     MAINMEM = TRUE;
                  }
                  else
                  {
                     MAINMEM = FALSE;
                  }
                  AMD_REC = MEM_REC;
                  do
                  {
                     nrf0 = MEM_REC[32];
                     //FL523 = new FL523(ref CARD_TYPES, ref CARD_PRICES, ref CARD_EXPIRY, ref CARD_DDFLAGS, ref PRICE, ref CENTRE_PREFIX, ref MAINMEM, ref MAINMEM_EXP, ref CARD_JOINING, ref CARD_UPFRONT, ref TOTAL_JOINING, ref TOTAL_UPFRONT, ref FIRST_DIRECT_DEBIT, ref PROGRAM, ref nrf0);
                     if (CARD_TYPES == "")
                     {
                        if (INPUT_NO == 3)
                        {
                           CARD_TYPES = COMMON.ABANDON;
                        }
                        nrf0 = 500;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     }
                  } while (true);
                  /* * */
                  /* ** following line could be wrong ! */
                  TYPE_FEE = TYPE_FEE + SUM[CARD_PRICES];
                  /* ** */
                  if (FIRST_DIRECT_DEBIT != "")
                  {
                     DAY = FORMAT(OCONV(FIRST_DIRECT_DEBIT, "DD"), "R%2");
                     MEM_REC[34] = DAY;
                  }
                  if (CARD_TYPES[1, 2] == "")
                  { /*  not multi-types */
                     ANS = CARD_TYPES[1, 1];
                     O_EXPIRY = OCONV(CARD_EXPIRY[1, 1], "D4");
                     I_EXPIRY = CARD_EXPIRY[1, 1];
                     NEW_EXPIRY = I_EXPIRY;
                  }
                  else
                  {
                     /*  multi-types */
                     /*            MEM.REC<39> = CARD.DDFLAGS */
                     ANS = "MXD";
                     O_EXPIRY = "MXD";
                     I_EXPIRY = "MXD";
                  }
                  if (ANS == "") { ANS = "."; }
                  PRINTCR(AT(ST_COL, ST_ROW) + NRM_VID + ANS);
                  /* * */
                  /*  work out dd and non dd fees */
                  /* * */
                  for (EACH_TYPE = 1; EACH_TYPE <= DCOUNT(CARD_DDFLAGS, VM); EACH_TYPE += 1)
                  {
                     /*            IF CARD.DDFLAGS<1,EACH.TYPE> = "Y" THEN TOTAL.DD.FEE = TOTAL.DD.FEE + CARD.PRICES<1,EACH.TYPE>; NO.DDTYPES = FALSE */
                     if (CARD_DDFLAGS[1, EACH_TYPE] == "Y")
                     {
                        TOTAL_DD_FEE = TOTAL_DD_FEE + CARD_PRICES[1, EACH_TYPE];
                        TOTAL_DD_JOINING = TOTAL_DD_JOINING + CARD_JOINING[1, EACH_TYPE];
                        TOTAL_DD_UPFRONT = TOTAL_DD_UPFRONT + CARD_UPFRONT[1, EACH_TYPE];
                        NO_DDTYPES = FALSE;
                     }
                     if (CARD_DDFLAGS[1, EACH_TYPE] == "N") { TOTAL_NONDD_FEE = TOTAL_NONDD_FEE + CARD_PRICES[1, EACH_TYPE]; }
                  }
                  /* * */
                  /*  LOG */
                  /* * */
                  /* * */
               }
               else
               {
                  /*  no pop-up MemTypes List window */
                  if (INPUT_NO == 11)
                  {
                     ADDRESS = "";
                     //FLQAS = new FLQAS(ref ADDRESS);
                  }
                  else
                  {
                     if (INPUT_NO == 2 && MEMBER_NO_READ != "")
                     {
                        //CallAt_MEMBER_NO_READ = new CallAt_MEMBER_NO_READ(ref MEMBER_NO_READ, ref ANS);
                     }
                     else
                     {
                        if (DATA_REC[10] != "" && DATA_REC[10] != 0)
                        {
                           ANS = DATA_REC[10];
                           DATA_REC[10] = "";
                           PRINT(AT(ST_COL, ST_ROW) + ANS);
                        }
                        else
                        {
                           FL019 = new FL019(ref MDISL, ref ANS);
                        }
                     }
                  }
               }
            }
            else
            {
               if (INPUT_NO == 11)
               {
                  ADDRESS = "";
                  //FLQAS = new FLQAS(ref ADDRESS);
               }
               else
               {
                  FL019 = new FL019(ref MDISL, ref ANS);
               }
            }
            if (INPUT_NO == 11)
            {
               if (ADDRESS != "")
               {
                  MEM_REC_POS = 1;
                  ADDRESS_POS = 1;
                  do
                  {
                     if (ADDRESS_POS == 5) break;
                     if (ADDRESS[ADDRESS_POS] != "")
                     {
                        MEM_REC[10, MEM_REC_POS] = ADDRESS[ADDRESS_POS];
                        MEM_REC_POS = MEM_REC_POS + 1;
                     }
                     ADDRESS_POS = ADDRESS_POS + 1;
                  } while (true);
                  MEM_REC[10, 5] = ADDRESS[5];
                  PRINTCR(AT(ST_COL, ST_ROW) + MEM_REC[10, 1]);
                  PRINTCR(AT(ST_COL, ST_ROW + 1) + MEM_REC[10, 2]);
                  PRINTCR(AT(ST_COL, ST_ROW + 2) + MEM_REC[10, 3]);
                  PRINTCR(AT(ST_COL, ST_ROW + 3) + MEM_REC[10, 4]);
                  PRINTCR(AT(ST_COL, ST_ROW + 4) + MEM_REC[10, 5]);
                  INPUT_NO = 15;
                  INPUT_LINES = INPUT_LINES + 4;
                  ANS = ADDRESS[1];
               }
               else
               {
                  FL019 = new FL019(ref MDISL, ref ANS);
               }
            }
            if (INPUT_NO == 19)
            {
               PRINT(AT(ST_COL, ST_ROW) + O_EXPIRY + "<" + AT(ST_COL, ST_ROW));
            }
            if (ANS.Substring(1, 1) == ";" || ANS.Substring(1, 1) == "%")
            {
               ANS = ANS.Substring(2, 99);
            }
            LEN_ANS = LEN(ANS);
            if (ANS.Substring(LEN_ANS, 1) == "?")
            {
               ANS = ANS.Substring(1, LEN_ANS - 1);
            }
            /*  Check for ticket message */
            if (ANS == TICKET_SWITCH)
            {
               //FL380_1 = new FL380_1();
               goto L10;
            }
            if ((ANS == COMMON.ABANDON || ANS == "") && FIRST_INPUT)
            {
               L300();
               L500();
               return;
            }
            if (ANS == COMMON.ABANDON)
            {
               if (FAMILY_MEMBER) { DOTS_ONLY = 0; } else { DOTS_ONLY = 1; }
               RELEASE();
               L300();
               goto L10;
            }
            if (ANS == "" && INPUT_NO == 1) { ANS = COMMON.CENTRE; }
            if (ANS == GO_BACK && INPUT_NO == 4) { ANS = ""; }
            if (ANS == GO_BACK)
            {
               PRINT(AT(ST_COL, ST_ROW) + "..");
               if (INPUT_NO == 1) { L500(); return; }
               if (INPUT_NO == 34 || INPUT_NO == 50 || INPUT_NO == 66 || INPUT_NO == 82 || INPUT_NO == 98)
               {
                  PRINT(AT(ST_COL, ST_ROW) + "..");
                  INPUT_LINES = INPUT_LINES - 1;
                  INPUT_NO = INPUT_NO - 1;
                  goto L50;
               }
               L140();
               goto L50;
            }
            /*  Validate the input */
            L80();
            if (VALIDATION_ERRORS) { goto L50; }
            if (NO_MORE_FAMILY) { goto L55; }
            if (INPUT_NO == 1 && ERROR_SET) { return; }
            if (INPUT_NO == 2 && ERROR_SET) { return; }
            /*  Check to see if member already exists */
            if (SC_POS[INPUT_LINES, 5] == 0)
            {
               BKEY = ANS;
               PLACE = SC_POS[INPUT_LINES, 5];
            L30: ;
               readUResult = READU_LOCKED(ref TEST_REC, COMMON.FILES[MEMBERS], CENTRE_PREFIX + BKEY);
               if (readUResult == ReadUResult.Locked)
               {
                  nrf0 = 123;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  goto L25;
                  /*  Record locked by another user */
               }
               else
               {
                  /*  check for mem no already being used as BACS Ref */
                  if (READ(ref BACS_REC, FL_BACS_REF, CENTRE_PREFIX + BKEY))
                  {
                     nrf0 = 124;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     goto L25;
                  }
                  goto L50;
                  /*  Record does not exist */
               }
               if (TEST_REC[31] != "" && TEST_REC[18] == "")
               {
                  MEM_REC = TEST_REC;
                  for (DISPLAY_LINES = 5; DISPLAY_LINES <= SCREEN_LINES; DISPLAY_LINES += 1)
                  {
                     START_POS = LEN(SC_POS[DISPLAY_LINES, 3]) + 2;
                     PROMPT_LEN = SC_POS[DISPLAY_LINES, 4];
                     ST_COL = SC_POS[DISPLAY_LINES, 1] + START_POS;
                     ST_ROW = SC_POS[DISPLAY_LINES, 2];
                     PLACE = SC_POS[DISPLAY_LINES, 5];
                     ATTRIBUTE = FIELD(PLACE, ",", 1);
                     MULTIV = FIELD(PLACE, ",", 2);
                     FIELD_TO_DISPLAY = MEM_REC[ATTRIBUTE, MULTIV];
                     if (ATTRIBUTE == 2 && FIELD_TO_DISPLAY[1, 2] != "")
                     {
                        FIELD_TO_DISPLAY = "MXD";
                     }
                     if (ATTRIBUTE == 3)
                     {
                        FIELD_TO_DISPLAY = OCONV(FIELD_TO_DISPLAY, "MD2");
                     }
                     if (ATTRIBUTE == 13 || ATTRIBUTE == 14 || ATTRIBUTE == 21)
                     {
                        if (FIELD_TO_DISPLAY[1, 2] != "")
                        {
                           FIELD_TO_DISPLAY = "MXD";
                        }
                        else
                        {
                           FIELD_TO_DISPLAY = OCONV(FIELD_TO_DISPLAY, "D2");
                        }
                     }
                     PRINTCR(AT(ST_COL, ST_ROW) + FIELD_TO_DISPLAY);
                  }
                  APPLICANTS_TITLE = MEM_REC[6, 1];
                  FAMILY_SURNAME = MEM_REC[4, 1];
                  if (MEM_REC[5, 1] == "")
                  {
                     INITS1 = MEM_REC[29, 1].Substring(1, 1);
                     if (INITS1 != "")
                     {
                        INITS_COL = SC_POS[10, 1] + LEN(SC_POS[10, 3]) + 2;
                        INITS_ROW = SC_POS[10, 2];
                        PRINT(AT(INITS_COL, INITS_ROW) + INITS1);
                     }
                  }
                  else
                  {
                     INITS1 = MEM_REC[5, 1];
                  }
                  if (MEM_REC[13] != "")
                  {
                     if (MEM_REC[13, 2] != "")
                     {
                        O_EXPIRY = "MXD";
                     }
                     else
                     {
                        O_EXPIRY = OCONV(MEM_REC[13], "D4");
                     }
                  }
                  SUB_TYPES[1] = MEM_REC[2];
                  SUB_EXPIRY[1] = MEM_REC[13];
                  SUB_PRICES[1] = MEM_REC[3];
                  SUB_DDFLAGS[1] = MEM_REC[39];
                  SUB_POS = 1;
                  do
                  {
                     if (MEM_REC[19, SUB_POS] == "") break;
                     if (!READ(ref TEST_REC, COMMON.FILES[MEMBERS], MEM_REC[19, SUB_POS])) { TEST_REC = ""; }
                     SUB_NO = SUB_POS + 1;
                     if (NOT(MULTIPLE_TYPES))
                     {
                        MEM_REC[2, SUB_NO] = TEST_REC[2];
                     }
                     SUB_TYPES[SUB_NO] = TEST_REC[2];
                     SUB_EXPIRY[SUB_NO] = TEST_REC[13];
                     SUB_PRICES[SUB_NO] = TEST_REC[35];
                     SUB_DDFLAGS[SUB_NO] = TEST_REC[39];
                     MEM_REC[16, (SUB_NO * 6) - 6] = TEST_REC[16];
                     MEM_REC[27, (SUB_NO * 3) - 3] = TEST_REC[27];
                     MEM_REC[30, SUB_NO] = TEST_REC[30];
                     SUB_POS = SUB_POS + 1;
                  } while (true);
                  TOTAL_SUBS = SUB_NO;
                  COMPLETING_REC = TRUE;
                  TYPE_FEE = MEM_REC[3];
                  NO_OF_INSTALMENTS = MEM_REC[24];
                  APPLICANTS_SEX = MEM_REC[7, 1];
                  if (MEM_REC[20] != "") { PREVIOUS_RECEIPT = TRUE; }
                  NEW_EXPIRY = 0;
                  goto L50;
               }
               else
               {
                  L130();
                  goto L50;
                  DOTS_ONLY = 1;
                  goto L25;
               }
            }
            if (NOT(MULTIPLE_TYPES) || INPUT_NO != 2)
            {
               MEM_REC[ATTRIBUTE, MULTIV] = ANS;
            }
            /*  skip DD Flag if pop-up window used for Type selection */
            if (INPUT_NO == 21 && MEM_TYPE_LIST && NOT(COMPLETING_REC))
            {
               if (NO_DDTYPES) { MEM_REC[28] = "N"; } else { MEM_REC[28] = "Y"; }
               PRINTCR(AT(ST_COL, ST_ROW + 1) + MEM_REC[28]);
               INPUT_NO = INPUT_NO + 1;
               INPUT_LINES = INPUT_LINES + 1;
            }
         L50: ;
         }
         if (SUB_FEES_INCLUDE && NOT(COMPLETING_REC))
         {
            MEM_REC[2] = SUB_TYPES[1];
            MEM_REC[13] = SUB_EXPIRY[1];
            MEM_REC[35] = SUB_PRICES[1];
            MEM_REC[39] = SUB_DDFLAGS[1];
         }
         /*  Display family details screen if required */
         /* IF CLIENT.APP.TYPE[1,1] = 'W' THEN */
         /*   PRINT CHAR(28):"402": */
         /*   PRINT "Display Photo " */
         /*   PRINT "Y,Yes" */
         /*   PRINT "N,No" */
         /*   PRINT CHAR(20): */
         /* END ELSE */
         /*   PRINT @(2,23):'Display Photo (Y/N) ':'.':@(23,23): */
         /* END */
         /* INPUT ANS,2 */
         /* IF ANS = 'Y' THEN */
         /*   CALL FL.PHOTO(CENTRE.PREFIX:BKEY,5,10) */
         /* END */
         if (ADDING_FAMILY && NOT(NO_MORE_FAMILY))
         {
            SUBMEMBER_NO = SUBMEMBER_NO + 1;
            if (SUBMEMBER_NO == TOTAL_SUBS + 1) { NO_MORE_FAMILY = 1; }
            /* !*!!IF SUBMEMBER.NO = 7 THEN NO.MORE.FAMILY = 1 */
            /* *** THE ABOVE TWO LINES ARE INCORRECT AND IT DOE'SNT REALISE ITS AT THE END */
            //FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
            PRINT(AT(44, 3) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SUBMEMBER_NO - 1);
            PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
            PRINT(AT(0, 23) + COMMON.EOL);
            PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
            ERROR_SET = FALSE;
            if (COMPLETING_REC)
            {
               L179();
            }
            else
            {
               L200();
            }
            if (ERROR_SET) { goto L10; } else { goto L28; }
         }
         if (FAMILY_MEMBER && NOT(NO_MORE_FAMILY))
         {
            PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
            PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
            PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
            REPLY = "";
            if (COMPLETING_REC)
            {
               if (MEM_REC[19] != "")
               {
                  REPLY = "F";
               }
            }
            else
            {
               if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
               {
                  PRINT(CHAR(28) + "401");
                  PRINTCR("F,Family Details");
                  PRINT(CHAR(20));
               }
               else
               {
                  PRINT(AT(2, 23) + "Press F to enter Family Details or <RETURN> to File ");
               }
               INPUT(out REPLY, 2);
            }
            //FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
            if (REPLY != "F")
            {
               FAMILY_MEMBER = 0;
               goto L55;
            }
            else
            {
               ADDING_FAMILY = TRUE;
               SUBMEMBER_NO = 2;
               SCREEN_CODE = "FL0001.1.1A";
               //FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
               if (MEM_PARAMS_REC[7] != "" && MEM_PARAMS_REC[7].Substring(1, 1) != "*")
               {
                  for (CODE_NUM = 1; CODE_NUM <= 6; CODE_NUM += 1)
                  {
                     // BEGIN CASE
                     // CASE
                     if (CODE_NUM == 1)
                     {
                        COL_POS = 32;
                        ROW_POS = 15;
                        LENGTH = 8;
                     }// CASE
                     else if (CODE_NUM == 2)
                     {
                        COL_POS = 47;
                        ROW_POS = 15;
                        LENGTH = 8;
                     }// CASE
                     else if (CODE_NUM == 3)
                     {
                        COL_POS = 62;
                        ROW_POS = 15;
                        LENGTH = 7;
                     }// CASE
                     else if (CODE_NUM == 4)
                     {
                        COL_POS = 32;
                        ROW_POS = 17;
                        LENGTH = 7;
                     }// CASE
                     else if (CODE_NUM == 5)
                     {
                        COL_POS = 47;
                        ROW_POS = 17;
                        LENGTH = 7;
                     }// CASE
                     else if (CODE_NUM == 6)
                     {
                        COL_POS = 62;
                        ROW_POS = 17;
                        LENGTH = 10;
                     }
                     // END CASE
                     if (MEM_PARAMS_REC[7, CODE_NUM] != "")
                     {
                        JUSTIF = "L#" + LENGTH;
                        PRINT(AT(COL_POS, ROW_POS) + DIM_VID + FORMAT(MEM_PARAMS_REC[7, CODE_NUM], JUSTIF));
                     }
                  }
               }
               PRINT(AT(44, 3) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SUBMEMBER_NO - 1);
               PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
               PRINT(AT(0, 23) + COMMON.EOL);
               PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
               if (COMPLETING_REC)
               {
                  L179();
               }
               else
               {
                  L200();
               }
               goto L28;
            }
         }
      /*  Ask if all OK */
      L55: ;
         if (NOT(ASK_FOR_MOP)) { goto L60; }
         if (VALID_PAYMENT && NOT(PREVIOUS_RECEIPT))
         {
            PRICE_TO_PRINT = STAGE_PAYMENT1;
         }
         else
         {
            if (MEM_TYPE_LIST)
            {
               if ((TOTAL_JOINING != "" && TOTAL_JOINING != 0) || (TOTAL_UPFRONT != 0 && TOTAL_UPFRONT != "")) { PRICE_TO_PRINT = TOTAL_JOINING + TOTAL_UPFRONT; }
               PRICE_TO_PRINT = PRICE_TO_PRINT + TOTAL_NONDD_FEE;
               TICKET_REC[6] = PRICE_TO_PRINT;
            }
            else
            {
               if (PRICE_OVERRIDE)
               {
                  PRICE_TO_PRINT = SPECIAL_PRICE;
               }
               else
               {
                  PRICE_TO_PRINT = TYPE_FEE;
               }
            }
         }
      L57: ;
         /*  <EFT> EFT RETURNS TO HERE IF THE CC FAILS */
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
         PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
         PRINT(AT(2, 23));
         if (PREVIOUS_RECEIPT)
         {
            PRINT(PR_RET2);
         }
         else
         {
            if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
            {
               PRINT(CHAR(28) + "402");
               PRINTCR("Total Due " + OCONV(PRICE_TO_PRINT, COMMON.MD2) + "- Select method of pay");
               PRINTCR(",Cash");
               PRINTCR("X,Cheque");
               PRINTCR("CC,Credit Card");
               PRINTCR("V,voucher");
               PRINT(CHAR(20));
            }
            else
            {
               PRINT(PR_RET + SPACE(10) + "(Total Due " + OCONV(PRICE_TO_PRINT, COMMON.MD2) + ")" + AT(48, 23));
            }
         }
         INPUT(out FILE_OR_NOT, 3);
         if (LEN(FILE_OR_NOT) > 2) { PRINT(AT(-9) + " "); FILE_OR_NOT = FILE_OR_NOT.Substring(1, 2); }
         PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
         if (VALID_PAYMENT)
         {
            TICKET_REC[3] = STAGE_PAYMENT1;
            TICKET_REC[6] = STAGE_PAYMENT1;
         }
         // BEGIN CASE
         // CASE
         if (PREVIOUS_RECEIPT)
         {
            NULL();
         }// CASE
         else if (FILE_OR_NOT == "")
         {
            TICKET_REC[7] = "C";
         }// CASE
         else if (FILE_OR_NOT == MOP_TYPES[2])
         {
            TICKET_REC[7] = FILE_OR_NOT;
            FILE_OR_NOT = "";
            if (CHEQUE_NO_REQUIRED)
            {
               PRINT(AT(2, 22) + SPACE(76) + AT(2, 22) + "Enter Cheque Number ......" + AT(22, 22));
               INPUT(out CHEQUE_NO, 7);
               CC_REF = CHEQUE_NO;
               CC_EXP = "CH";
            }
         }// CASE
         else if (FILE_OR_NOT == MOP_TYPES[3])
         {
            TICKET_REC[7] = MOP_TYPES[3];
            RET_FUNC = "";
            /* <EFT */
            if (EFT_SITE)
            {
               CC_AUTH = INIT;
               CC_EXP = INIT;
               CC_ISSUE = INIT;
               CC_REF = INIT;
               CC_START = INIT;
               SWIPE_DETAILS = INIT;
               PRINTCR(AT(42, 22) + "Enter CC Reference & Expiry");
               nrf0 = 65;
               nrf1 = 22;
               nrf2 = 45;
               //FL361_EFT = new FL361_EFT(ref nrf0, ref nrf1, ref CC_REF, ref CC_EXP, ref CC_AUTH, ref nrf2, ref EFT_SITE, ref SWIPE_DETAILS, ref CC_START, ref CC_ISSUE, ref CARD_CVS);
               if (CC_REF == COMMON.ABANDON) { goto L57; }
               PRINT(AT(42, 22) + SPACE(30));
               EFT_CONF = "Member : " + BKEY;
               /*      IF PRICE.OVERRIDE THEN */
               /*         EFT.AMOUNT = SPECIAL.PRICE */
               /*      END ELSE */
               /*         EFT.AMOUNT = PRICE.TO.PRINT */
               /*      END */
               EFT_AMOUNT = TICKET_REC[6];
               //FL_EFT = new FL_EFT(ref SWIPE_DETAILS, ref CC_REF, ref CC_EXP, ref CC_ISSUE, ref CC_START, ref EFT_AMOUNT, ref EFT_CONF, ref RET_FUNC, ref PROGRAM, ref CARD_CVS);
               if (RET_FUNC != VALID_DATA)
               {
                  goto L57;
               }
               if (RET_FUNC == EXIT)
               {
                  RET_FUNC = COMMON.ABANDON;
               }
               else
               {
                  TICKET_REC[30] = EFT_CONF[1] + VM + EFT_CONF[2] + VM + EFT_CONF[3];
                  TICKET_REC[31] = "SWIPED" + VM + CC_START + VM + CC_ISSUE;
               }
               /* EFT! */
            }
            else
            {
               //FL361_1 = new FL361_1(ref CC_REF, ref CC_EXP, ref RET_FUNC);
            }
            /* EFT> */
            if (RET_FUNC == COMMON.ABANDON) { FILE_OR_NOT = "DONT"; }
         }// CASE
         else if (OTHERWISE)
         {
            for (TYPE_NO = 4; TYPE_NO <= DCOUNT(MOP_TYPES, AM); TYPE_NO += 1)
            {
               if (FILE_OR_NOT == MOP_TYPES[TYPE_NO]) { TICKET_REC[7] = MOP_TYPES[TYPE_NO]; goto L59; }
            }
            nrf0 = 555;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            goto L57;
         L59: ;
         }
         // END CASE
         if (FILE_OR_NOT == "DONT")
         {
            if (FAMILY_MEMBER) { DOTS_ONLY = 0; } else { DOTS_ONLY = 1; }
            goto L20;
         }
      L60: ;
         MEM_REC[15] = U_INITS;
         MEMBER_NUMBER = CENTRE_PREFIX + BKEY;
         /*  Check to see if expiry altered by input of instalments */
         /*  Get next ticket number */
         if (NOT(PREVIOUS_RECEIPT))
         {
            //FL000_12 = new FL000_12(ref PROGRAM, ref NEXT_TICKET_NUMBER, ref UPDATE_TICKET_NUMBER, ref CURRENT_SESSION);
            MEM_REC[20] = NEXT_TICKET_NUMBER;
         }
         /*  Deal with all Submembers */
         if (NOT(FAMILY_MEMBER)) { goto L65; }
         //FL_HIDE_PHOTO = new FL_HIDE_PHOTO();
         LINE_NO = 10;
         SKIP_OVER = 0;
         NO_OF_SUBMEMS = DCOUNT(MEM_REC[4], VM);
         /* *IF CLIENT.APP.TYPE[1,1] = "W" THEN */
         PRINT(CHAR(28) + "408,40,5,77,22" + CHAR(20));
         /* *PRINT CHAR(28):"405" */
         /* *PRINT CHAR(28):"406" */
         /* *PRINT @(37,8):"New Members" */
         /* *PRINT CHAR(28):"407" */
         /* *PRINT MEM.REC<6,1>:",": */
         /* *PRINT MEM.REC<5,1>:",": */
         /* *PRINT MEM.REC<4,1>:",": */
         /* *PRINT MEMBER.NUMBER */
         /* *END ELSE */
         PRINTCR(AT(12, 8) + REV_UND_VID + SPACE(25) + AT(37, 8) + "New Members" + SPACE(24) + NRM_VID);
         PRINTCR(AT(12, 9) + COLOR_C + SPACE(60) + AT(14, 9) + MEM_REC[6, 1] + " " + MEM_REC[5, 1] + " " + MEM_REC[4, 1] + AT(50, 9) + MEMBER_NUMBER + ".");
         /* *END */
         for (SUBNO = 2; SUBNO <= NO_OF_SUBMEMS; SUBNO += 1)
         {
            if (MEM_REC[4, SUBNO] != "")
            {
               SUB_REC = MEM_REC;
               SUB_REC[4] = MEM_REC[4, SUBNO];
               SUB_REC[5] = MEM_REC[5, SUBNO];
               SUB_REC[6] = MEM_REC[6, SUBNO];
               SUB_REC[7] = MEM_REC[7, SUBNO];
               SUB_REC[8] = MEM_REC[8, SUBNO];
               SUB_REC[29] = MEM_REC[29, SUBNO];
               SUB_REC[16] = "";
               SUB_REC[30] = MEM_REC[30, SUBNO];
               if (SUB_FEES_INCLUDE)
               {
                  SUB_REC[2] = SUB_TYPES[SUBNO];
                  SUB_REC[35] = SUB_PRICES[SUBNO];
                  SUB_REC[13] = SUB_EXPIRY[SUBNO];
                  SUB_REC[39] = SUB_DDFLAGS[SUBNO];
                  TOTAL_SUB_PRICE = 0;
                  for (EACH_TYPE = 1; EACH_TYPE <= DCOUNT(SUB_REC[2], VM); EACH_TYPE += 1)
                  {
                     TOTAL_SUB_PRICE = TOTAL_SUB_PRICE + SUB_REC[35, EACH_TYPE];
                  }
                  SUB_REC[3] = TOTAL_SUB_PRICE;
               }
               else
               {
                  SUB_REC[2] = MEM_REC[2, SUBNO];
               }
               if (NOT(COMPLETING_REC))
               {
                  if (SUB_FEES_INCLUDE)
                  {
                     TOTAL_SUB_PRICE = 0;
                     SUB_PRICE_COUNT = 1;
                     do
                     {
                        if (SUB_PRICES[SUBNO][1, SUB_PRICE_COUNT] == "") break;
                        TOTAL_SUB_PRICE = TOTAL_SUB_PRICE + SUB_PRICES[SUBNO][1, SUB_PRICE_COUNT];
                        SUB_PRICE_COUNT = SUB_PRICE_COUNT + 1;
                     } while (true);
                     SUB_REC[3] = TOTAL_SUB_PRICE;
                     SUB_REC[13] = SUB_EXPIRY[SUBNO];
                     SUB_REC[35] = SUB_PRICES[SUBNO];
                     SUB_REC[39] = SUB_DDFLAGS[SUBNO];
                  }
               }
               ZZZ_COUNT = 5;
               for (SUB_AC_POS = 1; SUB_AC_POS <= 6; SUB_AC_POS += 1)
               {
                  MAIN_AC_POS = (6 * SUBNO) - ZZZ_COUNT;
                  SUB_REC[16, SUB_AC_POS] = MEM_REC[16, MAIN_AC_POS];
                  ZZZ_COUNT = ZZZ_COUNT - 1;
               }
               SUB_REC[19] = "";
               SUB_REC[27] = "";
               ZZZ_COUNT = 2;
               for (SUB_RESTCNS_POS = 1; SUB_RESTCNS_POS <= 3; SUB_RESTCNS_POS += 1)
               {
                  MAIN_RESTCNS_POS = (3 * SUBNO) - ZZZ_COUNT;
                  SUB_REC[27, SUB_RESTCNS_POS] = MEM_REC[27, MAIN_RESTCNS_POS];
                  ZZZ_COUNT = ZZZ_COUNT - 1;
               }
               nrf0 = SUB_REC[2];
               nrf1 = SUB_REC[27];
               //FL348 = new FL348(ref nrf0, ref nrf1);
               SUB_REC[18] = MEMBER_NUMBER;
               SUB_REC[21] = MEM_REC[21, SUBNO];
               SUB_REC[22] = TODAYS_DATE;
               SUB_REC[14] = TODAYS_DATE;
               SUB_KEY = MEM_REC[19, SUBNO - 1];
               if (PART_REC == TRUE) { SUB_REC[31] = INPUT_NO; }
               if (COMPLETING_REC) { SUB_REC[31] = ""; }
               WRITE(SUB_REC, COMMON.FILES[MEMBERS], SUB_KEY);
               ADT_LOG_KEY = SUB_KEY;
               ADT_LOG_REASON = "NEW SUBMEMBER";
               L400();
               TRANS_LOG_REC = SUB_REC;
               nrf0 = "W"; nrf1 = "FL.MEMBERS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SUB_KEY);
               /* *IF CLIENT.APP.TYPE[1,1] = "W" THEN */
               /* *PRINT SUB.REC<6>:",": */
               /* *PRINT SUB.REC<5>:",": */
               /* *PRINT SUB.REC<4>:",": */
               /* *PRINT SUB.KEY */
               /* *END */
               PRINTCR(AT(12, LINE_NO) + COLOR_C + SPACE(60) + AT(14, LINE_NO) + SUB_REC[6] + " " + SUB_REC[5] + " " + SUB_REC[4] + AT(50, LINE_NO) + FORMAT(SUB_KEY, "L#10"));
               //if (COMPLETING_REC) { FL000_45 = new FL000_45(ref SUB_KEY, ref SUB_REC); }
               //FL000_44 = new FL000_44(ref SUB_KEY, ref SUB_REC);
            }
            LINE_NO = LINE_NO + 1;
         }
         /* *IF CLIENT.APP.TYPE[1,1] = "W" THEN PRINT CHAR(20) */
         if (CLIENT_APP_TYPE.Substring(1, 1) == "W") { PRINTCR(CHAR(28) + "409" + CHAR(20)); }
         PRINT(AT(12, LINE_NO) + REV_UND_VID + FORMAT((" This record has been filed - Press <RETURN> "), "L#60") + NRM_VID);
         PRINT(AT(60, LINE_NO));
         INPUTCR(out WAIT, 1);
         /*  Delete Submember types from Main Member record */
         if (NOT(MULTIPLE_TYPES))
         {
            for (NO_OF_TYPES = 1; NO_OF_TYPES <= 5; NO_OF_TYPES += 1)
            {
               MEM_REC = DELETE(MEM_REC, 2, 2);
            }
         }
         /*  Delete Submember Analysis Codes from Main Member record */
         for (NO_OF_ACS = 1; NO_OF_ACS <= 30; NO_OF_ACS += 1)
         {
            MEM_REC = DELETE(MEM_REC, 16, 7);
         }
         /*  Delete Submember Restrictions from Main Member record */
         for (NO_OF_RESTCNS = 1; NO_OF_RESTCNS <= 15; NO_OF_RESTCNS += 1)
         {
            MEM_REC = DELETE(MEM_REC, 27, 4);
         }
         /*  Delete Submember comments from Main Member record */
         for (NO_OF_COMMENTS = 1; NO_OF_COMMENTS <= 5; NO_OF_COMMENTS += 1)
         {
            MEM_REC = DELETE(MEM_REC, 30, 2);
         }
         /*  Now write the Main Member to file */
         MEM_REC[3] = TYPE_FEE;
      L65: ;
         if (PRICE_OVERRIDE)
         {
            MEM_REC[3] = SPECIAL_PRICE;
            MAT(ref ADT_REC, "");
            ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + MEMBER_NUMBER;
            ADT_REC[ADT_DATE] = TODAYS_DATE;
            ADT_REC[ADT_USER] = U_INITS;
            ADT_REC[ADT_ORIG_VALUE] = PRICE;
            ADT_REC[ADT_NEW_VALUE] = MEM_REC[3];
            ADT_REC[ADT_REASON] = "M'SHP FEE O/RIDE - NEW";
            ADT_REC[ADT_TIME] = TIME();
            if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
            SEQ_NO = SEQ_NO + 1;
            MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
            WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
         }
         nrf0 = MEM_REC[2];
         nrf1 = MEM_REC[27];
         //FL348 = new FL348(ref nrf0, ref nrf1);
         if (NOT(COMPLETING_REC))
         {
            if (MEM_REC[13] != I_EXPIRY && NOT(MULTIPLE_TYPES))
            {
               MAT(ref ADT_REC, "");
               ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + MEMBER_NUMBER;
               ADT_REC[ADT_DATE] = TODAYS_DATE;
               ADT_REC[ADT_USER] = U_INITS;
               ADT_REC[ADT_ORIG_VALUE] = I_EXPIRY;
               ADT_REC[ADT_NEW_VALUE] = MEM_REC[13];
               ADT_REC[ADT_REASON] = "EXP DATE CHGD - NEW";
               ADT_REC[ADT_TIME] = TIME();
               if (!READV(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
               SEQ_NO = SEQ_NO + 1;
               MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
               WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
            }
         }
         MEM_REC[22] = TODAYS_DATE;
         if (MEM_REC[14] == "")
         {
            MEM_REC[14] = TODAYS_DATE;
         }
         if (PART_REC == TRUE)
         {
            MEM_REC[31] = INPUT_NO;
            if (MEM_REC[13] == "") { MEM_REC[13] = I_EXPIRY; }
         }
         if (COMPLETING_REC) { MEM_REC[31] = ""; }
         ADT_LOG_KEY = MEMBER_NUMBER;
         ADT_LOG_REASON = "NEW MEMBER";
         L400();
         /* ****** */
         /*  LOG * */
         /* ****** */
         /* * */
         WRITE(MEM_REC, COMMON.FILES[MEMBERS], MEMBER_NUMBER);
         TRANS_LOG_REC = MEM_REC;
         nrf0 = "W"; nrf1 = "FL.MEMBERS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBER_NUMBER);
         //if (COMPLETING_REC) { FL000_45 = new FL000_45(ref MEMBER_NUMBER, ref MEM_REC); }
         //FL000_44 = new FL000_44(ref MEMBER_NUMBER, ref MEM_REC);
         if (NOT(FAMILY_MEMBER))
         {
            PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
            PRINT(AT(0, 23) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
            PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
            PRINT(AT(2, 23) + " This record has been filed - Press <RETURN>");
            INPUT(out DUMMY_ANS, 2);
            if (LEN(DUMMY_ANS) > 1) { PRINT(AT(-9) + " "); DUMMY_ANS = DUMMY_ANS.Substring(1, 1); }
            PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
            PRINT(NRM_VID);
         }
         TICKET_REC[5] = ICONV(TIMEDATE().Substring(1, 8), COMMON.MTS);
         TICKET_REC[9] = TILL_NUMBER;
         TICKET_REC[14] = CC_REF;
         TICKET_REC[15] = CC_EXP;
         /*  Update last membership number issued */
         if (COMPLETING_REC != TRUE)
         {
            /*   IF MANUAL.NUMBER = FALSE THEN */
            /*      WRITEV LAST.NUMBER.ISSUED ON MEMBERSHIP.NUMBERS , LAST.NUMBER , 1 */
            /*      TRANS.LOG.REC = LAST.NUMBER.ISSUED */
            /*      CALL FLTX2('W','DICT FL.MEMBERS',LAST.NUMBER) */
            /*      NEW.NUMBERS.ISSUED<-1> = LAST.NUMBER.ISSUED */
            /*   END */
            /*  Update the Receipt Numbers item */
            if (PREVIOUS_RECEIPT) { goto L70; }
            TICKET_REC[16] = CURRENT_SESSION;
            if (UPDATE_TICKET_NUMBER)
            {
               PRINT_TICKET_NO = NEXT_TICKET_NUMBER;
               /*      IF PRICE.OVERRIDE THEN */
               /*         TICKET.REC<3> = SPECIAL.PRICE */
               /*         TICKET.REC<6> = SPECIAL.PRICE */
               /*      END */
               if (VALID_PAYMENT)
               {
                  TICKET_REC[3] = STAGE_PAYMENT1;
                  TICKET_REC[6] = STAGE_PAYMENT1;
               }
               if (TICKET_REC[10] == "") { TICKET_REC[10] = MEMBER_NUMBER; }
               CALL_REF = "PNEWMEM";
               TODAYZ_DATE = TODAYS_DATE;
               //FL165 = new FL165(ref TICKET_REC, ref TODAYZ_DATE, ref PERIOD, ref CALL_REF);
               WRITE(TICKET_REC, COMMON.FILES[TICKETS], NEXT_TICKET_NUMBER);
               TRANS_LOG_REC = TICKET_REC;
               nrf0 = "W"; nrf1 = "FL.TICKETS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref NEXT_TICKET_NUMBER);
               NARRATIVE = INIT;
               /*  Open Cash Drawer then print ticket */
               //FL102 = new FL102();
               if (TICKET_PRINT_ROUTINE == "")
               {
                  nrf0 = "";
                  //CallAt_SUBR = new CallAt_SUBR(ref SUBR, ref PRINT_TICKET_NO, ref TICKET_REC, ref NARRATIVE, ref nrf0);
               }
               else
               {
                  TRANS_DETAILS = "";
                  ZZZ_CHANGE = "";
                  TICKET_REC[23] = MEM_REC[4];
                  nrf0 = TICKET_REC[4];
                  nrf1 = TICKET_REC[5];
                  nrf2 = "";
                  nrf3 = "";
                  nrf4 = "MEMBER";
                  //CallAt_TICKET_PRINT_ROUTINE = new CallAt_TICKET_PRINT_ROUTINE(ref TICKET_PRINT_ROUTINE, ref PRINT_TICKET_NO, ref TICKET_REC, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref TRANS_DETAILS, ref ZZZ_CHANGE, ref nrf4);
               }
            }
         }
      L70: ;
         if (FAMILY_MEMBER) { DOTS_ONLY = 0; } else { DOTS_ONLY = 1; }
         if (MEM_REC[28] == "Y")
         {
            /*  HS - TEMP FOR NOW 28.9.02 !     IF MEM.REC<28> = "Y" AND NOT(PART.REC) THEN */
            /* IF MEM.REC<28> = "Y" AND NOT(PART.REC) THEN */
            DD_ID = "1*" + MEMBER_NUMBER + "*1";
            if (!(READ(ref TEST_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID)))
            {
               TEST_REC = "";
            }
            if (COMPLETING_REC && TEST_REC == "" && FIRST_DIRECT_DEBIT == "")
            {
               if (!READ(ref BACS_CONTROL, DFL_DIRECT_DEBITS, "BACS.CONTROL")) { L130(); VALIDATION_ERRORS = TRUE; return ; }
               DAY1_OF_MONTH = BACS_CONTROL[1, 1];
               DAY2_OF_MONTH = BACS_CONTROL[1, 2];
               if (DAY2_OF_MONTH != "")
               {
                  DAY_OF_MONTH = "";
                  if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                  {
                     PRINT(CHAR(28) + "402");
                     PRINTCR("Select DD day ");
                     PRINTCR(DAY1_OF_MONTH + "," + DAY1_OF_MONTH);
                     PRINTCR(DAY2_OF_MONTH + "," + DAY2_OF_MONTH);
                     PRINT(CHAR(20));
                  }
                  else
                  {
                     do
                     {
                        if (DAY_OF_MONTH == DAY1_OF_MONTH || DAY_OF_MONTH == DAY2_OF_MONTH) break;
                        PRINT(AT(1, 23) + COMMON.EOL);
                        PRINT(AT(10, 23) + "Choose DD Day from " + DAY1_OF_MONTH + " OR " + DAY2_OF_MONTH + " " + AT(39, 23) + ".." + AT(39, 23));
                        INPUTCR(out DAY_OF_MONTH);
                     } while (true);
                  }
               }
               else
               {
                  DAY_OF_MONTH = DAY1_OF_MONTH;
               }
               MEM_REC[34] = FORMAT(DAY_OF_MONTH, "R%2");
               WRITEV(MEM_REC[34], COMMON.FILES[MEMBERS], MEMBER_NUMBER, 34);
               /*            TRANS.LOG.REC = MEM.REC<34> */
               TRANS_LOG_REC = MEM_REC;
               /*            TX.ATT = 34 */
               nrf0 = "W";
               nrf1 = "FL.MEMBERS";
               FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBER_NUMBER);
               if (LOCATE(DAY_OF_MONTH, BACS_CONTROL[1], 1, 0, 1, ref DD_POS, "AR"))
               {
                  LEEWAY = BACS_CONTROL[2, DD_POS];
                  if (LEEWAY == "") { LEEWAY = 0; }
               }
               /* * */
               /*  work out next run date */
               DATE_LAST_RUN = BACS_CONTROL[3, DD_POS];
               MONTHS_LEEWAY = BACS_CONTROL[17];
               CUT_OFF_DAY = BACS_CONTROL[18, DD_POS];
               MTH = OCONV(DATE_LAST_RUN, "DM");
               YR = OCONV(DATE_LAST_RUN, "DY");
               MTH = MTH + 1;
               if (MTH > 12)
               {
                  MTH = 1;
                  YR = YR + 1;
               }
               DATE_NEXT_RUN = DAY_OF_MONTH + "/" + MTH + "/" + YR;
               DATE_NEXT_RUN = ICONV(DATE_NEXT_RUN, "D2/");
               /* IF FIRST.DIRECT.DEBIT = "" THEN */
               FIRST_DIRECT_DEBIT = DATE_NEXT_RUN;
               if (MONTHS_LEEWAY != "" && NUM(MONTHS_LEEWAY))
               {
                  FIRST_DIRECT_DEBIT = TODAYS_DATE;
                  DAY = OCONV(FIRST_DIRECT_DEBIT, "DD");
                  MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                  YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                  MONTH = MONTH + MONTHS_LEEWAY;
                  if (MONTH > 12)
                  {
                     MONTH = MONTH - 12;
                     YEAR = YEAR + 1;
                  }
                  FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + MONTH + "/" + YEAR;
                  FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D2/");
               }
               if (FIRST_DIRECT_DEBIT <= TODAYS_DATE)
               {
                  DAY = OCONV(FIRST_DIRECT_DEBIT, "DD");
                  MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                  YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                  do
                  {
                     if (FIRST_DIRECT_DEBIT > TODAYS_DATE) break;
                     MONTH = MONTH + 1;
                     if (MONTH == 13)
                     {
                        MONTH = 1;
                        YEAR = YEAR + 1;
                     }
                     FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + MONTH + "/" + YEAR;
                     FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D2/");
                  } while (true);
               }
               if (FIRST_DIRECT_DEBIT < DATE_NEXT_RUN)
               {
                  FIRST_DIRECT_DEBIT = DATE_NEXT_RUN;
               }
               /*  allow for possible cut-off day */
               if (CUT_OFF_DAY != "" && NUM(CUT_OFF_DAY))
               {
                  if (MONTHS_LEEWAY == "" || NOT(NUM(MONTHS_LEEWAY)))
                  {
                     FIRST_DEBIT_MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                     FIRST_DEBIT_YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                     CUT_OFF_DATE = CUT_OFF_DAY + "/" + FIRST_DEBIT_MONTH + "/" + FIRST_DEBIT_YEAR;
                     CUT_OFF_DATE = ICONV(CUT_OFF_DATE, "D");
                     CUT_OFF_MONTH = FIRST_DEBIT_MONTH;
                     CUT_OFF_YEAR = FIRST_DEBIT_YEAR;
                     if (CUT_OFF_DATE >= FIRST_DIRECT_DEBIT)
                     {
                        CUT_OFF_MONTH = CUT_OFF_MONTH - 1;
                        if (CUT_OFF_MONTH < 1)
                        {
                           CUT_OFF_MONTH = 12;
                           CUT_OFF_YEAR = CUT_OFF_YEAR - 1;
                        }
                        CUT_OFF_DATE = CUT_OFF_DAY + "/" + CUT_OFF_MONTH + "/" + CUT_OFF_YEAR;
                        CUT_OFF_DATE = ICONV(CUT_OFF_DATE, "D");
                     }
                     if (TODAYS_DATE > CUT_OFF_DATE)
                     {
                        FIRST_DEBIT_MONTH = FIRST_DEBIT_MONTH + 1;
                        if (FIRST_DEBIT_MONTH > 12)
                        {
                           FIRST_DEBIT_MONTH = FIRST_DEBIT_MONTH - 12;
                           FIRST_DEBIT_YEAR = FIRST_DEBIT_YEAR + 1;
                        }
                        FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + FIRST_DEBIT_MONTH + "/" + FIRST_DEBIT_YEAR;
                        FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D");
                     }
                  }
               }
               if (COMPLETING_REC && ADDING_FAMILY)
               {
                  if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                  {
                     PRINT(CHAR(28) + "404");
                     PRINTCR("Direct Debit Start Date");
                     PRINTCR("..........");
                     PRINTCR(OCONV(FIRST_DIRECT_DEBIT, "D2/"));
                     PRINT(CHAR(20));
                  }
                  else
                  {
                     PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
                     PRINT(SPACE(SCREEN_WIDTH - 2));
                     PRINT(ERR_LINE);
                     PRINT("Confirm Direct Debit Start Date " + "..........." + AT(33, 23) + OCONV(FIRST_DIRECT_DEBIT, "D2/") + COMMON.EOL);
                     PRINT(AT(33, 23));
                  }
                  DD_DATE_COL = 33;
                  DD_DATE_ROW = 23;
               }
               else
               {
                  PRINT(AT(65, 14) + "...........");
                  PRINT(AT(65, 14) + NRM_VID + OCONV(FIRST_DIRECT_DEBIT, "D2/") + COMMON.EOL + AT(65, 14));
                  DD_DATE_COL = 65;
                  DD_DATE_ROW = 14;
               }
               INPUT(out USER_START_DATE, 11);
               if (USER_START_DATE != "")
               {
                  TEST_DATE = ICONV(USER_START_DATE, "D4/");
                  if (TEST_DATE == "")
                  {
                     PRINT(AT(DD_DATE_COL, DD_DATE_ROW) + COMMON.EOL);
                     L130();
                     VALIDATION_ERRORS=TRUE;
                     return;
                  }
                  START_DATE = TEST_DATE - LEEWAY;
                  L175();
                  if (FIRST_DIRECT_DEBIT < TODAYS_DATE)
                  {
                     PRINT(AT(DD_DATE_COL, DD_DATE_ROW) + COMMON.EOL);
                     L130();
                     VALIDATION_ERRORS = TRUE;
                     return;
                  }
               }
               PRINT(AT(DD_DATE_COL, DD_DATE_ROW) + OCONV(FIRST_DIRECT_DEBIT, "D2/") + COMMON.EOL + NRM_VID);
               /*      END */
            }
            if (TEST_REC == "")
            {
               AMD_REC = MEM_REC;
               AMD_KEY = MEMBER_NUMBER;
               if (MEM_TYPE_LIST)
               {
                  if (COMPLETING_REC)
                  {
                     TOTAL_DD_FEE = 0;
                     for (TYPE_COUNT = 1; TYPE_COUNT <= DCOUNT(MEM_REC[2], VM); TYPE_COUNT += 1)
                     {
                        // BEGIN CASE
                        // CASE
                        if (MEM_REC[39, TYPE_COUNT] == "Y")
                        {
                           TOTAL_DD_FEE = TOTAL_DD_FEE + MEM_REC[35, TYPE_COUNT];
                        }// CASE
                        else if (MEM_REC[39] == "" && MEM_REC[35] != "")
                        {
                           TOTAL_DD_FEE = TOTAL_DD_FEE + MEM_REC[35, TYPE_COUNT];
                        }// CASE
                        else if (MEM_REC[39] == "" && MEM_REC[35] == "")
                        {
                           TOTAL_DD_FEE = MEM_REC[3];
                        }// CASE
                        else if (MEM_REC[39] != "" && MEM_REC[35] == "")
                        {
                           TOTAL_DD_FEE = MEM_REC[3];
                        }
                        // END CASE
                     }
                     if (MEM_REC[19] != "")
                     {
                        for (SUB_COUNT = 1; SUB_COUNT <= DCOUNT(MEM_REC[19], VM); SUB_COUNT += 1)
                        {
                           if (READ(ref TEST_SUB_REC, COMMON.FILES[MEMBERS], MEM_REC[19, SUB_COUNT]))
                           {
                              SUB_DD_FEE = 0;
                              for (TYPE_COUNT = 1; TYPE_COUNT <= DCOUNT(TEST_SUB_REC[2], VM); TYPE_COUNT += 1)
                              {
                                 // BEGIN CASE
                                 // CASE
                                 if (TEST_SUB_REC[39, TYPE_COUNT] == "Y")
                                 {
                                    SUB_DD_FEE = SUB_DD_FEE + TEST_SUB_REC[35, TYPE_COUNT];
                                 }// CASE
                                 else if (TEST_SUB_REC[39] == "" && TEST_SUB_REC[35] != "")
                                 {
                                    SUB_DD_FEE = SUB_DD_FEE + TEST_SUB_REC[35, TYPE_COUNT];
                                 }// CASE
                                 else if (TEST_SUB_REC[39] == "" && TEST_SUB_REC[35] == "")
                                 {
                                    SUB_DD_FEE = TEST_SUB_REC[3];
                                 }// CASE
                                 else if (TEST_SUB_REC[39] != "" && TEST_SUB_REC[35] == "")
                                 {
                                    SUB_DD_FEE = TEST_SUB_REC[3];
                                 }
                                 // END CASE
                              }
                              TOTAL_DD_FEE = TOTAL_DD_FEE + SUB_DD_FEE;
                           }
                        }
                     }
                     DEPOSIT = "";
                  }
                  else
                  {
                     /*         DEPOSIT = TOTAL.UPFRONT:VM:TOTAL.JOINING */
                     DEPOSIT = TOTAL_DD_UPFRONT + VM + TOTAL_DD_JOINING;
                     if (NO_DDTYPES) { TOTAL_DD_FEE = TOTAL_NONDD_FEE; }
                  }
               }
               else
               {
                  TOTAL_DD_FEE = TYPE_FEE;
                  DEPOSIT = STAGE_PAYMENT1;
               }
               nrf0 = "1";
               nrf1 = MEM_REC[28];
               nrf2 = MEM_REC[20];
               //FL122 = new FL122(ref nrf0, ref nrf1, ref MEMBER_NUMBER, ref TOTAL_DD_FEE, ref DEPOSIT, ref nrf2, ref NO_OF_INSTALMENTS, ref NEW_EXPIRY, ref PROGRAM, ref FIRST_DIRECT_DEBIT, ref STATUS);
            }
            if (COMPLETING_REC && TEST_REC != "" && SUPPRESS_BANKDETS == FALSE)
            {
               BANK_ID = "1*" + MEMBER_NUMBER;
               if (!(MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID)))
               {
                  MAT(ref BANK_REC, "");
                  nrf0 = "1";
                  //FL121 = new FL121(ref nrf0, ref MEMBER_NUMBER, ref INTERACT, ref PROGRAM);
               }
            }
         }
         else
         {
            if (MEM_REC[24] != "" && MEM_REC[24] != 0 && MEM_REC[28] != "Y")
            {
               DEPOSIT = TOTAL_UPFRONT + VM + TOTAL_JOINING;
               if (NEW_EXPIRY == "" || NEW_EXPIRY == 0)
               {
                  NEW_EXPIRY = MEM_REC[13];
               }
               nrf0 = MEM_REC[20];
               nrf1 = MEM_REC[32];
               //FL153 = new FL153(ref MEMBER_NUMBER, ref TYPE_FEE, ref DEPOSIT, ref nrf0, ref NO_OF_INSTALMENTS, ref NEW_EXPIRY, ref nrf1, ref STATUS);
            }
         }
         return;
         /* ******************************************************************** */
      }
      void L80()
      {
         /*         V A L I D A T I O N   S U B R O U T I N E */
         /* ******************************************************************** */
         VALIDATION_ERRORS = FALSE;
         VALIDATION_NO = INPUT_NO;
         SUB_NO = 2;
         do
         {
            if (VALIDATION_NO < 50) break;
            VALIDATION_NO = VALIDATION_NO - 16;
            SUB_NO = SUB_NO + 1;
         } while (true);
         OK_TO_SKIP = FALSE;
         if (VALIDATION_NO < 34 && VALIDATION_NO > MAIN_MIN_FIELDS)
         {
            OK_TO_SKIP = TRUE;
         }
         if (VALIDATION_NO - 33 > SUB_MIN_FIELDS)
         {
            OK_TO_SKIP = TRUE;
         }
         // BEGIN CASE
         // CASE
         if (COMPLETING_REC && ANS == GET_PICT)
         {
            ANS = "";
            nrf0 = 101;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INPUT_LINES = INPUT_LINES - 1;
            INPUT_NO = INPUT_NO - 1;
            return;
         }// CASE
         else if (COMPLETING_REC && ANS == SKIP_FIELDS)
         {
            ANS = "";
            nrf0 = 102;
            nrf1 = 1;
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            INPUT_LINES = INPUT_LINES - 1;
            INPUT_NO = INPUT_NO - 1;
            return;
         }// CASE
         else if (ANS == GET_PICT && OK_TO_SKIP == TRUE && CAMERA_OR_SCAN != "")
         {
            PICT_REQ = TRUE;
            if (MUST_TAKE_MONEY == "Y" && ADDING_FAMILY != TRUE && INPUT_NO < 20)
            {
               INPUT_NO = 18;
               INPUT_LINES = 21;
               ANS = "";
               PART_REC = TRUE;
            }
            else
            {
               ANS = "";
               if (INPUT_NO > 33)
               {
                  PHOTO_KEY = SUB_KEY;
               }
               else
               {
                  PHOTO_KEY = CENTRE_PREFIX + BKEY;
               }
               nrf0 = "NEW";
               //FL_GET_PHOTO = new FL_GET_PHOTO(ref nrf0, ref PHOTO_KEY, ref MEM_REC);
               if (MUST_COMPLETE == "Y")
               {
                  INPUT_NO = INPUT_NO - 1;
                  INPUT_LINES = INPUT_LINES - 1;
               }
               else
               {
                  ANS = "";
                  PART_REC = TRUE;
                  INPUT_LINES = 37;
                  // BEGIN CASE
                  // CASE
                  if (INPUT_NO < 34)
                  {
                     INPUT_NO = 33;
                  }// CASE
                  else if (INPUT_NO < 50)
                  {
                     INPUT_NO = 49;
                  }// CASE
                  else if (INPUT_NO < 66)
                  {
                     INPUT_NO = 65;
                  }// CASE
                  else if (INPUT_NO < 82)
                  {
                     INPUT_NO = 81;
                  }// CASE
                  else if (INPUT_NO < 98)
                  {
                     INPUT_NO = 97;
                  }// CASE
                  else if (INPUT_NO < 114)
                  {
                     NO_MORE_FAMILY = TRUE;
                  }
                  // END CASE
               }
            }
         }// CASE
         else if (ANS == SKIP_FIELDS && OK_TO_SKIP == TRUE)
         {
            if (MUST_TAKE_MONEY == "Y" && ADDING_FAMILY != TRUE && INPUT_NO < 20)
            {
               INPUT_NO = 18;
               INPUT_LINES = 21;
               ANS = "";
               PART_REC = TRUE;
            }
            else
            {
               ANS = "";
               PART_REC = TRUE;
               INPUT_LINES = 37;
               // BEGIN CASE
               // CASE
               if (INPUT_NO < 34)
               {
                  INPUT_NO = 33;
               }// CASE
               else if (INPUT_NO < 50)
               {
                  INPUT_NO = 49;
               }// CASE
               else if (INPUT_NO < 66)
               {
                  INPUT_NO = 65;
               }// CASE
               else if (INPUT_NO < 82)
               {
                  INPUT_NO = 81;
               }// CASE
               else if (INPUT_NO < 98)
               {
                  INPUT_NO = 97;
               }// CASE
               else if (INPUT_NO < 114)
               {
                  NO_MORE_FAMILY = TRUE;
               }
               // END CASE
            }
         }// CASE
         else if (VALIDATION_NO == 1)
         {
            /*  Centre Code */
            if (!(READV(ref CENTRE_VALID_DESC, COMMON.FILES[CENTRE_FILE], ANS, 1)))
            {
               L130();
               VALIDATION_ERRORS = TRUE;
               return;
            }
            CENTRE_CODE = ANS;
            CENTRE_PREFIX = CENTRE_CODE;
            FL000_42 = new FL000_42(ref CENTRE_PREFIX);
            /*  Establish Centre Code */
            RELEASE();
            UPDATE_TICKET_NUMBER = "";
         }// CASE
         else if (VALIDATION_NO == 2)
         {
            /*  Membership No */
            TEST_ID = ANS;
            if (!(READ(ref TEST_REC, COMMON.FILES[MEMBERS], TEST_ID)))
            {
               TEST_ID = CENTRE_PREFIX + TEST_ID;
               if (!READ(ref TEST_REC, COMMON.FILES[MEMBERS], TEST_ID)) { TEST_REC = ""; }
            }
            if (TEST_REC[31] != "")
            {
               if (SET_PREFIX == "NONE") { CENTRE_PREFIX = ANS.Substring(1, LEN_PREFIX); }
               ANS = TEST_ID.Substring(LEN_PREFIX + 1, LEN(TEST_ID) - LEN_PREFIX);
               return;
            }
            // BEGIN CASE
            // CASE
            if (SET_PREFIX == "NONE")
            {
               M_NUM = ANS.Substring(LEN_PREFIX + 1, LEN(ANS) - LEN_PREFIX);
               if ((LEN(M_NUM) > NUMBER_LENGTH && NUMBER_LENGTH != "" && FIXED_LEN != "V") || ANS == "")
               {
                  L130();
                  VALIDATION_ERRORS = TRUE;
                  return;
               }
               CENTRE_PREFIX = ANS.Substring(1, LEN_PREFIX);
               LAST_NUMBER = CENTRE_PREFIX + "*LAST.NUMBER";
               readUResult = READU_LOCKED(ref LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
               if (readUResult == ReadUResult.Locked)
               {
                  nrf0 = 222;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  ERROR_SET = TRUE;
                  return;
               }
               else
               {
                  LAST_NUMBER_ISSUED = 0;
               }
               if (M_NUM == "N")
               {
                  M_NUM = LAST_NUMBER_ISSUED + 1;
                  LAST_NUMBER_ISSUED = M_NUM;
               }
               else
               {
                  if (GENERATED_NUMBER == "Y") { L130(); VALIDATION_ERRORS = TRUE; return; }
                  MANUAL_NUMBER = TRUE;
               }
               if (LEN(M_NUM) < NUMBER_LENGTH && FIXED_LEN != "V")
               {
                  JUSTIF = "R%" + NUMBER_LENGTH;
                  M_NUM = FORMAT(M_NUM, JUSTIF);
                  APP_NUM = M_NUM;
               }
               ANS = M_NUM;
               APP_NUM = ANS;
               PRINTCR(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + CENTRE_PREFIX + ANS);
               WRITE(LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
               NEW_NUMBERS_ISSUED[-1] = LAST_NUMBER_ISSUED;
            }// CASE
            else if (ANS == "N")
            {
               LAST_NUMBER = CENTRE_PREFIX + "*LAST.NUMBER";
               readUResult = READU_LOCKED(ref LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
               if (readUResult == ReadUResult.Locked)
               {
                  nrf0 = 333;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  ERROR_SET = TRUE;
                  return;
               }
               else
               {
                  LAST_NUMBER_ISSUED = 0;
               }
               ANS = LAST_NUMBER_ISSUED + 1;
               LAST_NUMBER_ISSUED = ANS;
               APP_NUM = ANS;
               WRITE(LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
               NEW_NUMBERS_ISSUED[-1] = LAST_NUMBER_ISSUED;
            }// CASE
            else if (OTHERWISE)
            {
               if (GENERATED_NUMBER == "Y") { L130(); VALIDATION_ERRORS = TRUE; return; }
               MANUAL_NUMBER = TRUE;
               /*      IF NOT(NUM(ANS)) OR ANS = '' THEN GOSUB 130; VALIDATION.ERRORS = TRUE;RETURN */
               if (LEN(ANS) > 15) { L130(); VALIDATION_ERRORS = TRUE; return; }
               APP_NUM = ANS;
            }
            // END CASE
            if (SET_PREFIX == "")
            {
               /*  remove centre code as it will be added on later */
               if (ANS.Substring(1, LEN_PREFIX) == COMMON.CENTRE)
               {
                  ANS = ANS.Substring(LEN_PREFIX + 1, LEN(ANS) - LEN_PREFIX);
               }
               if (LEN(ANS) < NUMBER_LENGTH && FIXED_LEN != "V")
               {
                  JUSTIF = "R%" + NUMBER_LENGTH;
                  ANS = FORMAT(ANS, JUSTIF);
               }
               PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            }
            if (NUM(APP_NUM))
            {
               ENUF_SUB_NOS = TRUE;
               for (SUBMEM_NUMBERS = 1; SUBMEM_NUMBERS <= 5; SUBMEM_NUMBERS += 1)
               {
                  TEST_NUM = (APP_NUM + SUBMEM_NUMBERS);
                  if (LEN(TEST_NUM) < NUMBER_LENGTH)
                  {
                     JUSTIF = "R%" + NUMBER_LENGTH;
                     TEST_NUM = FORMAT(TEST_NUM, JUSTIF);
                  }
                  if (READ(ref TESTREC, COMMON.FILES[MEMBERS], CENTRE_PREFIX + TEST_NUM))
                  {
                     ENUF_SUB_NOS = FALSE;
                  }
               }
            }
         }// CASE
         else if (VALIDATION_NO == 3)
         {
            /*  Type */
            // BEGIN CASE
            // CASE
            if (MEM_TYPE_LIST)
            {
               TYPE_FEE = PRICE;
               AMT_COL = SC_POS[INPUT_LINES + 1, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
               AMT_ROW = SC_POS[INPUT_LINES + 1, 2];
               PRINT(AT(AMT_COL, AMT_ROW) + OCONV(TYPE_FEE, COMMON.MD2));
               /* ** remove the following code and place in Amount Validation */
               /* ** its quite possible that the amount gets overridden so price */
               /* ** variables should not be updated until then */
               /*      CARD.POS = 1 */
               /*      LOOP */
               /*         UNTIL CARD.TYPES<1,CARD.POS> = "" DO */
               /*         IF (CARD.JOINING<1,CARD.POS> # "" AND CARD.JOINING<1,CARD.POS> # "0") OR (CARD.UPFRONT<1,CARD.POS> # "" AND CARD.UPFRONT<1,CARD.POS> # "0") THEN */
               /*            IF CARD.JOINING<1,CARD.POS> # "" AND CARD.JOINING<1,CARD.POS> # "0" THEN */
               /*               TICKET.REC<1,-1> = "M*":CARD.TYPES<1,CARD.POS>:"J" */
               /*               TICKET.REC<3,-1> = CARD.JOINING<1,CARD.POS> */
               /*               TICKET.REC<2,-1> = 1 */
               /*               TICKET.REC<10,-1> = CENTRE.PREFIX:BKEY */
               /*               TICKET.REC<11,-1> = 1 */
               /*               TICKET.REC<13,-1> = "STD" */
               /*            END */
               /*            IF CARD.UPFRONT<1,CARD.POS> # "" AND CARD.UPFRONT<1,CARD.POS> # "0" THEN */
               /*               TICKET.REC<1,-1> = "M*":CARD.TYPES<1,CARD.POS>:"U" */
               /*               TICKET.REC<3,-1> = CARD.UPFRONT<1,CARD.POS> */
               /*               TICKET.REC<2,-1> = 1 */
               /*               TICKET.REC<10,-1> = CENTRE.PREFIX:BKEY */
               /*               TICKET.REC<11,-1> = 1 */
               /*               TICKET.REC<13,-1> = "STD" */
               /*            END */
               /*            CARD.POS = CARD.POS + 1 */
               /*         END ELSE */
               /*            TICKET.REC<1,-1> = "M*":CARD.TYPES<1,CARD.POS> */
               /*            TICKET.REC<3,-1> = CARD.PRICES<1,CARD.POS> */
               /*            TICKET.REC<2,-1> = 1 */
               /*            TICKET.REC<10,-1> = CENTRE.PREFIX:BKEY */
               /*            TICKET.REC<11,-1> = 1 */
               /*            TICKET.REC<13,-1> = "STD" */
               /*            CARD.POS = CARD.POS + 1 */
               /*         END */
               /*      REPEAT */
               /* ** end of removal */
               SUB_TYPES[1] = CARD_TYPES;
               SUB_EXPIRY[1] = CARD_EXPIRY;
               SUB_DDFLAGS[1] = CARD_DDFLAGS;
               /* ** move following line to Amount Valid'n as price could be overridden */
               /*      SUB.PRICES(1) = CARD.PRICES */
               /* ** */
            }// CASE
            else if (OTHERWISE)
            {
               /*  not MEM.TYPE.LIST */
               APP_NUM = BKEY;
               MEMBERSHIP_TYPE = ANS;
               TICKET_CODE = "M*" + MEMBERSHIP_TYPE;
               TODAYZ_DATE = TODAYS_DATE;
               nrf0 = "Z";
               nrf1 = TIME();
               FL355 = new FL355(ref TICKET_CODE, ref nrf0, ref TODAYZ_DATE, ref nrf1, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
               if (RESPONSE == FALSE) { L130(); VALIDATION_ERRORS = TRUE; return; }
               TYPE_FEE = PRICE;
               AMT_COL = SC_POS[INPUT_LINES + 1, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
               AMT_ROW = SC_POS[INPUT_LINES + 1, 2];
               PRINT(AT(AMT_COL, AMT_ROW) + OCONV(TYPE_FEE, COMMON.MD2));
               /* ** remove the following code and place in Amount Validation */
               /* ** its quite possible that the amount gets overridden so price */
               /* ** variables should not be updated until then */
               /*      TICKET.REC<1> = 'M*':MEMBERSHIP.TYPE */
               /*      TICKET.REC<2> = 1 */
               /*      TICKET.REC<3> = TYPE.FEE */
               /*      TICKET.REC<6> = TYPE.FEE */
               /*      TICKET.REC<11> = 1 */
               /*      TICKET.REC<13> = "STD" */
               /* ** end of removal */
               FAMILY_MEMBERSHIP_TYPE = MEMBERSHIP_TYPE;
               /*  determine expiry date for this Type */
               if (!(READ(ref EXPIRY_DATE_PARAM, COMMON.FILES[FL_MEMBER_PARAMS], CENTRE_PREFIX + "*" + MEMBERSHIP_TYPE)))
               {
                  if (!(READ(ref EXPIRY_DATE_PARAM, COMMON.FILES[FL_MEMBER_PARAMS], "MEMBER.EXPIRY")))
                  {
                     EXPIRY_DATE_PARAM = 365;
                  }
               }
               EXPIRY_DATE = EXPIRY_DATE_PARAM[1];
               EXPIRY_CALC = EXPIRY_DATE_PARAM[2];
               EXPIRY_FROM_START = FALSE;
               if (READV(ref EXPIRY_FROM_START, COMMON.FILES[FL_MEMBER_PARAMS], "EXPIRY.FROM.START", 1))
               {
                  if (EXPIRY_FROM_START == "Y" || EXPIRY_FROM_START == "y") { EXPIRY_FROM_START = TRUE; }
               }
               else
               {
                  EXPIRY_FROM_START = FALSE;
               }
               // BEGIN CASE
               // CASE
               if (EXPIRY_DATE == "Y")
               {
                  if (EXPIRY_CALC != "")
                  {
                     nrf0 = "NEW";
                     CallAt_EXPIRY_CALC = new CallAt_EXPIRY_CALC(ref EXPIRY_CALC, ref nrf0, ref EXPIRY_DATE);
                  }
                  else
                  {
                     nrf0 = 90;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     return;
                  }
                  I_EXPIRY = EXPIRY_DATE;
                  O_EXPIRY = OCONV(EXPIRY_DATE, "D2/");
               }// CASE
               else if (EXPIRY_FROM_START)
               {
                  // BEGIN CASE
                  // CASE
                  if (EXPIRY_DATE.Substring(LEN(EXPIRY_DATE) - 2, LEN(EXPIRY_DATE)) == "MTH")
                  {
                     EXP_DAY = OCONV(MEM_REC[32], "DD");
                     EXP_MTH = OCONV(MEM_REC[32], "DM");
                     EXP_YR = OCONV(MEM_REC[32], "DY");
                     NO_OF_MONTHS = EXPIRY_DATE.Substring(1, LEN(EXPIRY_DATE) - 3);
                     if (NO_OF_MONTHS < 12)
                     {
                        EXP_MTH = EXP_MTH + NO_OF_MONTHS;
                        if (EXP_MTH > 12)
                        {
                           EXP_MTH = EXP_MTH - 12;
                           EXP_YR = EXP_YR + 1;
                        }
                     }
                     else
                     {
                        EXP_YR = EXP_YR + 1;
                     }
                     O_EXPIRY = EXP_DAY + "/" + EXP_MTH + "/" + EXP_YR;
                     I_EXPIRY = ICONV(O_EXPIRY, "D4/");
                     if (I_EXPIRY == "")
                     {
                        EXP_MTH = EXP_MTH + 1;
                        if (EXP_MTH > 12)
                        {
                           EXP_MTH = EXP_MTH - 12;
                           EXP_YR = EXP_YR + 1;
                        }
                        O_EXPIRY = "1/" + EXP_MTH + "/" + EXP_YR;
                        I_EXPIRY = ICONV(O_EXPIRY, "D");
                        I_EXPIRY = I_EXPIRY - 1;
                     }
                     if (EXPIRY_CALC != "")
                     {
                        I_EXPIRY = I_EXPIRY + EXPIRY_CALC;
                     }
                     O_EXPIRY = OCONV(I_EXPIRY, "D2/");
                  }// CASE
                  else if (LEN(EXPIRY_DATE) > 4)
                  {
                     if (NUM(EXPIRY_DATE))
                     {
                        I_EXPIRY = EXPIRY_DATE;
                        O_EXPIRY = OCONV(EXPIRY_DATE, "D2/");
                     }
                     else
                     {
                        I_EXPIRY = ICONV(EXPIRY_DATE, "D2");
                        O_EXPIRY = EXPIRY_DATE;
                     }
                  }// CASE
                  else if (LEN(EXPIRY_DATE) <= 4 && NUM(EXPIRY_DATE))
                  {
                     I_EXPIRY = MEM_REC[32] + EXPIRY_DATE;
                     O_EXPIRY = OCONV(I_EXPIRY, "D2/");
                  }
                  // END CASE
               }// CASE
               else if (EXPIRY_DATE.Substring(LEN(EXPIRY_DATE) - 2, LEN(EXPIRY_DATE)) == "MTH")
               {
                  EXP_DAY = OCONV(TODAYS_DATE, "DD");
                  EXP_MTH = OCONV(TODAYS_DATE, "DM");
                  EXP_YR = OCONV(TODAYS_DATE, "DY");
                  NO_OF_MONTHS = EXPIRY_DATE.Substring(1, LEN(EXPIRY_DATE) - 3);
                  if (NO_OF_MONTHS < 12)
                  {
                     EXP_MTH = EXP_MTH + NO_OF_MONTHS;
                     if (EXP_MTH > 12)
                     {
                        EXP_MTH = EXP_MTH - 12;
                        EXP_YR = EXP_YR + 1;
                     }
                  }
                  else
                  {
                     EXP_YR = EXP_YR + 1;
                  }
                  O_EXPIRY = OCONV(EXP_DAY + "/" + EXP_MTH + "/" + EXP_YR, "D2/");
                  I_EXPIRY = ICONV(O_EXPIRY, "D2/");
                  if (I_EXPIRY == "")
                  {
                     EXP_MTH = EXP_MTH + 1;
                     if (EXP_MTH > 12)
                     {
                        EXP_MTH = EXP_MTH - 12;
                        EXP_YR = EXP_YR + 1;
                     }
                     O_EXPIRY = "1/" + EXP_MTH + "/" + EXP_YR;
                     I_EXPIRY = ICONV(O_EXPIRY, "D");
                     I_EXPIRY = I_EXPIRY - 1;
                  }
                  if (EXPIRY_CALC != "")
                  {
                     I_EXPIRY = I_EXPIRY + EXPIRY_CALC;
                  }
                  O_EXPIRY = OCONV(I_EXPIRY, "D2/");
               }// CASE
               else if (LEN(EXPIRY_DATE) > 4)
               {
                  if (NUM(EXPIRY_DATE))
                  {
                     I_EXPIRY = EXPIRY_DATE;
                     O_EXPIRY = OCONV(EXPIRY_DATE, "D2/");
                  }
                  else
                  {
                     I_EXPIRY = ICONV(EXPIRY_DATE, "D2/");
                     O_EXPIRY = EXPIRY_DATE;
                  }
               }// CASE
               else if (LEN(EXPIRY_DATE) <= 4 && NUM(EXPIRY_DATE))
               {
                  I_EXPIRY = TODAYS_DATE + EXPIRY_DATE;
                  O_EXPIRY = OCONV(I_EXPIRY, "D2/");
               }
               // END CASE
               if (SUB_FEES_INCLUDE)
               {
                  SUB_TYPES[1] = MEMBERSHIP_TYPE;
                  SUB_EXPIRY[1] = I_EXPIRY;
               }
            }
            // END CASE
         }// CASE
         else if (VALIDATION_NO == 4)
         {
            /*  Amount */
            // BEGIN CASE
            // CASE
            if (ANS == TYPE_FEE)
            {
            }// CASE
            else if (ANS == "")
            {
               ANS = TYPE_FEE;
               PRINTCR(AT(ST_COL, ST_ROW) + OCONV(ANS, COMMON.MD2));
            }// CASE
            else if (ANS == OCONV(TYPE_FEE, COMMON.MD2))
            {
               ANS = TYPE_FEE;
               PRINTCR(AT(ST_COL, ST_ROW) + OCONV(ANS, COMMON.MD2));
            }// CASE
            else if (NUM(ANS))
            {
               if (MULTIPLE_TYPES)
               {
                  PRINT(AT(2, 23) + ERR_MESS_FORE + ERR_MESS_BACK);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  PRINT(AT(2, 23) + "Cannot override amount for multiple types ");
                  INPUT(out WAIT, 1);
                  PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  ANS = TYPE_FEE;
                  PRINTCR(AT(ST_COL, ST_ROW) + OCONV(ANS, COMMON.MD2));
               }
               else
               {
                  if (PASSWORD_CONTROL[2] != "")
                  {
                     PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                     PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                     if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                     {
                        PRINT(CHAR(28) + "403");
                        PRINT("Enter Password to override Membership Fee ");
                        PRINTCR("............");
                        PRINT(CHAR(20));
                     }
                     else
                     {
                        PRINT(AT(2, 23) + "Enter Password to override Membership Fee : ");
                     }
                     ECHO_OFF();
                     INPUT(out SP_PASS, 20);
                     ECHO_ON();
                     /*            PRINT @(2,23):SCREEN.FOOT.FORE:SCREEN.FOOT.BACK: */
                     /*            PRINT @(2,23):SPACE(SCREEN.WIDTH-2): */
                     PRINT(AT(2, 23) + NRM_VID);
                     PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                     if (SP_PASS != PASSWORD_CONTROL[2]) { L130(); VALIDATION_ERRORS = TRUE; return; }
                  }
                  /* * */
                  ANS = ICONV(ANS, COMMON.MD2);
                  PRINTCR(AT(ST_COL, ST_ROW) + OCONV(ANS, COMMON.MD2));
                  SPECIAL_PRICE = ANS;
                  TYPE_FEE = ANS;
                  PRICE_OVERRIDE = TRUE;
                  if (MEM_TYPE_LIST)
                  {
                     if (CARD_DDFLAGS == "Y") { TOTAL_DD_FEE = SPECIAL_PRICE; }
                     if (CARD_DDFLAGS == "N") { TOTAL_NONDD_FEE = SPECIAL_PRICE; }
                     CARD_PRICES = SPECIAL_PRICE;
                  }
                  SUB_PRICES[1] = ANS;
               }
            }// CASE
            else if (OTHERWISE)
            {
               L130();
               VALIDATION_ERRORS = TRUE;
               return;
            }
            // END CASE
            /* * insert code from Type Validation that has been commented out */
            /* * want to update ticket records and other amount variables here */
            /* * rather than in Type Validation in case Amount gets over-written */
            if (MEM_TYPE_LIST)
            {
               CARD_POS = 1;
               do
               {
                  if (CARD_TYPES[1, CARD_POS] == "") break;
                  if (CARD_JOINING[1, CARD_POS] != "")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS] + "J";
                     TICKET_REC[3, -1] = CARD_JOINING[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = CENTRE_PREFIX + BKEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  if (CARD_UPFRONT[1, CARD_POS] != "")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS] + "U";
                     TICKET_REC[3, -1] = CARD_UPFRONT[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = CENTRE_PREFIX + BKEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  if (CARD_DDFLAGS[1, CARD_POS] != "Y")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS];
                     TICKET_REC[3, -1] = CARD_PRICES[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = CENTRE_PREFIX + BKEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  CARD_POS = CARD_POS + 1;
               } while (true);
               SUB_PRICES[1] = CARD_PRICES;
            }
            else
            {
               TICKET_REC[1] = "M*" + MEMBERSHIP_TYPE;
               TICKET_REC[2] = 1;
               TICKET_REC[3] = TYPE_FEE;
               TICKET_REC[6] = TYPE_FEE;
               TICKET_REC[11] = 1;
               TICKET_REC[13] = "STD";
            }
            /* * */
         }// CASE
         else if (VALIDATION_NO == 5)
         {
            /*  Applicants Title */
            if (NOT(MATCH(ANS, "0A"))) { L130(); VALIDATION_ERRORS = TRUE; return; }
            APPLICANTS_TITLE = ANS;
            // BEGIN CASE
            // CASE
            if (ANS == "MR" || ANS == "MSTR")
            {
               APPLICANTS_SEX = "M";
            }// CASE
            else if (ANS == "MRS" || ANS == "MISS" || ANS == "MS")
            {
               APPLICANTS_SEX = "F";
            }// CASE
            else if (OTHERWISE)
            {
               APPLICANTS_SEX = "";
            }
            // END CASE
            SEXY_COL = SC_POS[INPUT_LINES + 4, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
            SEXY_ROW = SC_POS[INPUT_LINES + 4, 2];
            PRINT(AT(SEXY_COL, SEXY_ROW) + APPLICANTS_SEX);
         }// CASE
         else if (VALIDATION_NO == 6)
         {
            /*  Applicants Surname */
            L173();
            if (NOT(NAME_OK)) { L130(); VALIDATION_ERRORS = TRUE; return; }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            if (ANS == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
            FAMILY_SURNAME = ANS;
         }// CASE
         else if (VALIDATION_NO == 7)
         {
            /*  Applicants Forename */
            L173();
            if (NOT(NAME_OK)) { L130(); VALIDATION_ERRORS = TRUE; return; }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            INITS1 = ANS.Substring(1, 1);
            INITS_COL = SC_POS[INPUT_LINES + 1, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
            INITS_ROW = SC_POS[INPUT_LINES + 1, 2];
            PRINT(AT(INITS_COL, INITS_ROW) + INITS1);
         }// CASE
         else if (VALIDATION_NO == 8)
         {
            /*  Applicants Initials */
            if (ANS == "") { ANS = INITS1; }
            else
            {
               ANS = TRIM(ANS);
               if (NOT(MATCH(ANS, "0A") || MATCH(ANS, "0A\" \"0A"))) { L130(); VALIDATION_ERRORS = TRUE; return; }
            }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
         }// CASE
         else if (VALIDATION_NO == 9)
         {
            /*  Applicants Sex */
            if (ANS == "")
            {
               ANS = APPLICANTS_SEX;
               PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            }
            if (ANS != "M" && ANS != "F") { L130(); VALIDATION_ERRORS = TRUE; return; }
            APPLICANTS_SEX = ANS;
            if (APPLICANTS_TITLE == "MR" && APPLICANTS_SEX != "M") { L130(); VALIDATION_ERRORS = TRUE; return; }
            if (APPLICANTS_TITLE == "MRS" || APPLICANTS_TITLE == "MISS" || APPLICANTS_TITLE == "MS" && APPLICANTS_SEX != "F") { L130(); VALIDATION_ERRORS = TRUE; return; }
         }// CASE
         else if (VALIDATION_NO == 10)
         {
            /*  Applicants Age/Dob */
            // BEGIN CASE
            // CASE
            if (ANS == "")
            {
               /* User must enter NONE NOT "" for dob */
               L130();
               VALIDATION_ERRORS = TRUE;
               return;
            }// CASE
            else if (ANS == "NONE")
            {
               ANS = "";
            }// CASE
            else if (LEN(ANS) <= 3)
            {
               /*  age entered */
               if (DOB_ONLY == "Y")
               {
                  L130();
                  VALIDATION_ERRORS = TRUE;
                  return;
               }
               if (NOT(NUM(ANS))) { L131(); VALIDATION_ERRORS = TRUE; return; }
               ANS = ANS + 0;
               if (INT(ANS) != ANS) { L130(); VALIDATION_ERRORS = TRUE; return; }
               YEARS_OLD = ANS;
               if (YEARS_OLD > 150) { L130(); VALIDATION_ERRORS = TRUE; return; }
               if (YEARS_OLD < CHILD_MINIMUM) { L130(); VALIDATION_ERRORS = TRUE; return; }
               CURR_YEAR = OCONV(TODAYS_DATE, "DY");
               TEST_YEAR = CURR_YEAR - YEARS_OLD;
               TEST_DATE = "01/01/" + TEST_YEAR;
               PRINT(AT(ST_COL, ST_ROW) + FORMAT(ANS, "L#10"));
               if (ANS != 0)
               {
                  PRINT(AT(ST_COL + 4, ST_ROW) + "(" + TEST_DATE + ")");
               }
            }// CASE
            else if (LEN(ANS) > 3)
            {
               /*  date of birth entered */
               TEST_DATE = ICONV(ANS, "D4/");
               if (TEST_DATE > TODAYS_DATE) { L130(); VALIDATION_ERRORS = TRUE; return; }
               if (TEST_DATE == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
               YEARS_OLD = TODAYS_DATE - TEST_DATE;
               YEARS_OLD = INT(YEARS_OLD / 365);
               if (YEARS_OLD > 150) { L130(); VALIDATION_ERRORS = TRUE; return; }
               if (YEARS_OLD < CHILD_MINIMUM) { L130(); VALIDATION_ERRORS = TRUE; return; }
               TEST_DATE = OCONV(TEST_DATE, "D4/");
               PRINTCR(AT(ST_COL, ST_ROW) + FORMAT(TEST_DATE, "L#10"));
               PRINT(AT(ST_COL + 12, ST_ROW) + "(" + YEARS_OLD + ")");
            }
            // END CASE
            if (ANS != "")
            {
               DOB = ICONV(TEST_DATE, "D");
               if (INDEXING_ROUTINE != "")
               {
                  OPTION = "";
                  CallAt_INDEXING_ROUTINE = new CallAt_INDEXING_ROUTINE(ref INDEXING_ROUTINE, ref FAMILY_SURNAME, ref DOB, ref OPTION);
                  if (OPTION == "A" || OPTION == "C") { return; }
                  if (OPTION != "")
                  {
                     FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
                     PRINT(AT(13, 3) + COMMON.CENTRE);
                     /*  Centre Code */
                     PRINT(AT(30, 3) + CENTRE_PREFIX + BKEY);
                     /*  Mem No */
                     PRINT(AT(57, 3) + MEM_REC[2, 1]);
                     /*  Type */
                     PRINT(AT(71, 3) + OCONV(MEM_REC[3, 1], "MD2"));
                     /*  Type Fee */
                     PRINT(AT(13, 4) + MEM_REC[6, 1]);
                     /*  Title */
                     PRINT(AT(30, 4) + MEM_REC[4, 1]);
                     /*  Surname */
                     PRINT(AT(57, 4) + MEM_REC[29, 1]);
                     /*  Forename */
                     PRINT(AT(13, 5) + MEM_REC[5, 1]);
                     /*  Initials */
                     PRINT(AT(30, 5) + MEM_REC[7, 1]);
                     /*  Sex */
                     PRINT(AT(57, 5));
                     /*  Age */
                     if (LEN(ANS) <= 3) { PRINTCR(ANS); } else { PRINTCR(TEST_DATE); }
                     if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                     {
                        PRINT(CHAR(28) + "500");
                        PRINT(CHAR(20));
                     }
                  }
               }
               MEM_REC[21, 1] = ICONV(TEST_DATE, "D");
               ANS = MEM_REC[21];
               MEM_REC[8, 1] = YEARS_OLD;
            }
            else
            {
               MEM_REC[21, 1] = "";
               MEM_REC[8, 1] = "";
            }
         }// CASE
         else if (VALIDATION_NO == 11)
         {
            /*  Address Line 1 */
            ANS = TRIM(ANS);
            PART_REC = FALSE;
            if (ANS == "F")
            {
               INPUT_NO = 17;
               INPUT_LINES = INPUT_LINES + 6;
               PART_REC = TRUE;
               ANS = "";
            }
            else
            {
               if (ANS == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
            }
         }// CASE
         else if (VALIDATION_NO == 12)
         {
            /*  Address Line 2 */
            ANS = TRIM(ANS);
            /*   IF ANS = '' THEN GOSUB 130; VALIDATION.ERRORS = TRUE;RETURN */
            L170();
         }// CASE
         else if (VALIDATION_NO == 13)
         {
            /*  Address Line 3 */
            ANS = TRIM(ANS);
            L170();
         }// CASE
         else if (VALIDATION_NO == 14)
         {
            /*  Address Line 4 */
            NO_POSSIBLE_ERRORS = 1;
            L170();
         }// CASE
         else if (VALIDATION_NO == 15)
         {
            /*  Post Code */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 16)
         {
            /*  Email */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 17)
         {
            /*  Home Tel */
            MANDATORY = (SC_POS[INPUT_LINES, 10] == "M");
            if (MANDATORY && ANS == "")
            {
               L130();
               VALIDATION_ERRORS = TRUE;
               return;
               /*  Error. */
            }
            else
            {
               NO_POSSIBLE_ERRORS = 1;
            }
         }// CASE
         else if (VALIDATION_NO == 18)
         {
            /*  Work Tel */
            NO_POSSIBLE_ERRORS = 1;
            EXP_COL = SC_POS[INPUT_LINES + 1, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
            EXP_ROW = SC_POS[INPUT_LINES + 1, 2];
            PRINTCR(AT(EXP_COL, EXP_ROW) + O_EXPIRY);
         }// CASE
         else if (VALIDATION_NO == 19)
         {
            /*  Membership Expiry Date */
            // BEGIN CASE
            // CASE
            if (ANS == I_EXPIRY)
            {
            }// CASE
            else if (ANS == "")
            {
               ANS = I_EXPIRY;
               PRINT(AT(ST_COL, ST_ROW) + O_EXPIRY);
            }// CASE
            else if (I_EXPIRY == "MXD")
            {
               L130();
               VALIDATION_ERRORS = TRUE;
               return;
            }// CASE
            else if (OTHERWISE)
            {
               /*  Expiry Date Overridden */
               if (PASSWORD_CONTROL[3])
               {
                  PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                  {
                     PRINT(CHAR(28) + "403");
                     PRINT("Enter Password to override Expiry Date ");
                     PRINTCR("............");
                     PRINT(CHAR(20));
                  }
                  else
                  {
                     PRINT(AT(2, 23) + "Enter Password to override Expiry Date : ");
                  }
                  ECHO_OFF();
                  INPUT(out SP_PASS, 20);
                  ECHO_ON();
                  PRINT(AT(2, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
                  PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
                  if (SP_PASS != PASSWORD_CONTROL[3]) { L130(); VALIDATION_ERRORS = TRUE; return; }
               }
               CH_DATE = ICONV(ANS, "D");
               CH_DATE2 = OCONV(CH_DATE, "D");
               if (CH_DATE == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
               ANS = CH_DATE;
               NEW_EXPIRY = CH_DATE;
               PRINT(AT(ST_COL, ST_ROW) + CH_DATE2);
               SUB_EXPIRY[1] = CH_DATE;
            }
            // END CASE
         }// CASE
         else if (VALIDATION_NO == 20)
         {
            /*  Receipt Number */
            if (ANS == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
            ANS = TRIM(ANS);
            ASK_FOR_MOP = 1;
            if (ANS == "Y")
            {
               ANS = "TO BE ISSUED";
               PREVIOUS_RECEIPT = FALSE;
               PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            }
            else
            {
               if (!(READV(ref RECEIPT_CONTROL_FLAG, COMMON.FILES[FL_MEMBER_PARAMS], "RECEIPT.CONTROL", 1)))
               {
                  RECEIPT_CONTROL_FLAG = 0;
               }
               if (RECEIPT_CONTROL_FLAG == 1)
               {
                  if (READ(ref TEST_REC, COMMON.FILES[TICKETS], ANS))
                  {
                     TICKET_FOUND = TRUE;
                  }
                  else
                  {
                     if (READ(ref TEST_REC, COMMON.FILES[FL_RECONCILED_TICKETS], ANS))
                     {
                        TICKET_FOUND = TRUE;
                     }
                     else
                     {
                        if (READ(ref TEST_REC, COMMON.FILES[FL_OLD_TICKETS], ANS + "/1"))
                        {
                           TICKET_FOUND = TRUE;
                        }
                        else
                        {
                           TICKET_FOUND = FALSE;
                        }
                     }
                  }
                  if (TICKET_FOUND == FALSE)
                  {
                     L130();
                     VALIDATION_ERRORS = TRUE;
                     return;
                  }
               }
               if (RECEIPT_CONTROL_FLAG == 2)
               {
                  if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                  {
                     PRINT(CHAR(28) + "403");
                     PRINT("Enter Password to override Receipt ");
                     PRINTCR("............");
                     PRINT(CHAR(20));
                  }
                  else
                  {
                     PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
                     PRINT(ERR_LINE + "To override Receipt No. entry please enter Password : " + COMMON.EOL);
                  }
                  ECHO_OFF();
                  INPUT(out COMMON.PASSWORD, 8);
                  ECHO_ON();
                  if (!(READV(ref CONTROL_PASSWORD, COMMON.FILES[FL_MEMBER_PARAMS], "RECEIPT.CONTROL", 2)))
                  {
                     CONTROL_PASSWORD = "";
                  }
                  PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
                  if (COMMON.PASSWORD != CONTROL_PASSWORD) { L130(); VALIDATION_ERRORS = TRUE; return; }
               }
               PREVIOUS_RECEIPT = TRUE;
               CURRENT_SESSION = "";
            }
         }// CASE
         else if (VALIDATION_NO == 21)
         {
            /*  Instalment number */
            if (ANS != "" && ANS != 0)
            {
               if (NOT(NUM(ANS)) && ANS > 12)
               {
                  L130();
                  VALIDATION_ERRORS = TRUE;
                  return;
               }
               else
               {
                  NO_OF_INSTALMENTS = ANS;
                  if (NOT(MEM_TYPE_LIST))
                  {
                     /*            PRINT @(ST.COL+2,ST.ROW):REV.VID:'Taken':NRM.VID:'......': */
                     PRINT(AT(ST_COL + 2, ST_ROW) + REV_VID + "Taken" + NRM_VID);
                     PRINT(AT(ST_COL + 9, ST_ROW) + "......");
                     do
                     {
                        PRINT(AT(ST_COL + 9, ST_ROW) + COMMON.EOL + AT(ST_COL + 9, ST_ROW));
                        INPUT(out STAGE_PAYMENT1, 7);
                        // BEGIN CASE
                        // CASE
                        if (NOT(NUM(STAGE_PAYMENT1)))
                        {
                           VALID_PAYMENT = FALSE;
                        }// CASE
                        else if (STAGE_PAYMENT1 < 0)
                        {
                           VALID_PAYMENT = FALSE;
                        }// CASE
                        else if (OTHERWISE)
                        {
                           STAGE_PAYMENT1 = ICONV(STAGE_PAYMENT1, COMMON.MD2);
                           // BEGIN CASE
                           // CASE
                           if (STAGE_PAYMENT1 <= TYPE_FEE)
                           {
                              VALID_PAYMENT = TRUE;
                              PRINT(AT(ST_COL + 9, ST_ROW) + OCONV(STAGE_PAYMENT1, COMMON.MD2));
                           }// CASE
                           else if (OTHERWISE)
                           {
                              VALID_PAYMENT = FALSE;
                           }
                           // END CASE
                        }
                        // END CASE
                        if (VALID_PAYMENT) break;
                        nrf0 = 666;
                        nrf1 = "";
                        FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     } while (true);
                  }
               }
            }
            else
            {
               VALID_PAYMENT = FALSE;
               if (ANS == 0) { ANS = ""; }
            }
         }// CASE
         else if (VALIDATION_NO == 22)
         {
            /*  Direct Debit flag */
            if (ANS == "") { ANS = "N"; }
            if (ANS != "Y" && ANS != "N") { L130(); VALIDATION_ERRORS = TRUE; return; }
            if (COMPLETING_REC)
            {
               for (EACH_TYPE = 1; EACH_TYPE <= DCOUNT(MEM_REC[2], VM); EACH_TYPE += 1)
               {
                  MEM_REC[39, EACH_TYPE] = ANS;
               }
            }
            if (ANS == "Y")
            {
               if (NO_OF_INSTALMENTS == "" || NO_OF_INSTALMENTS == 0) { L130(); VALIDATION_ERRORS = TRUE; return; }
               if (FIRST_DIRECT_DEBIT == "")
               {
                  if (!READ(ref BACS_CONTROL, DFL_DIRECT_DEBITS, "BACS.CONTROL")) { L130(); VALIDATION_ERRORS = TRUE; return; }
                  DAY1_OF_MONTH = BACS_CONTROL[1, 1];
                  DAY2_OF_MONTH = BACS_CONTROL[1, 2];
                  if (DAY2_OF_MONTH != "")
                  {
                     DAY_OF_MONTH = "";
                     if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
                     {
                        PRINT(CHAR(28) + "402");
                        PRINTCR("Select DD day ");
                        PRINTCR(DAY1_OF_MONTH + "," + DAY1_OF_MONTH);
                        PRINTCR(DAY2_OF_MONTH + "," + DAY2_OF_MONTH);
                        PRINT(CHAR(20));
                        INPUTCR(out DAY_OF_MONTH);
                     }
                     else
                     {
                        do
                        {
                           if (DAY_OF_MONTH == DAY1_OF_MONTH || DAY_OF_MONTH == DAY2_OF_MONTH) break;
                           PRINT(AT(1, 23) + COMMON.EOL);
                           PRINT(AT(10, 23) + "Choose DD Day from " + DAY1_OF_MONTH + " OR " + DAY2_OF_MONTH + " " + AT(39, 23) + "." + AT(39, 23));
                           INPUTCR(out DAY_OF_MONTH);
                        } while (true);
                     }
                  }
                  else
                  {
                     DAY_OF_MONTH = DAY1_OF_MONTH;
                  }
                  MEM_REC[34] = FORMAT(DAY_OF_MONTH, "R%2");
                  if (LOCATE(DAY_OF_MONTH, BACS_CONTROL[1], 1, 0, 1, ref DD_POS, "AR"))
                  {
                     LEEWAY = BACS_CONTROL[2, DD_POS];
                     if (LEEWAY == "") { LEEWAY = 0; }
                  }
                  /*  work out next run date */
                  DATE_LAST_RUN = BACS_CONTROL[3, DD_POS];
                  MONTHS_LEEWAY = BACS_CONTROL[17];
                  CUT_OFF_DAY = BACS_CONTROL[18, DD_POS];
                  MTH = OCONV(DATE_LAST_RUN, "DM");
                  YR = OCONV(DATE_LAST_RUN, "DY");
                  MTH = MTH + 1;
                  if (MTH > 12)
                  {
                     MTH = 1;
                     YR = YR + 1;
                  }
                  DATE_NEXT_RUN = DAY_OF_MONTH + "/" + MTH + "/" + YR;
                  DATE_NEXT_RUN = ICONV(DATE_NEXT_RUN, "D2/");
                  FIRST_DIRECT_DEBIT = DATE_NEXT_RUN;
                  if (MONTHS_LEEWAY != "" && NUM(MONTHS_LEEWAY))
                  {
                     FIRST_DIRECT_DEBIT = TODAYS_DATE;
                     DAY = OCONV(FIRST_DIRECT_DEBIT, "DD");
                     MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                     YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                     MONTH = MONTH + MONTHS_LEEWAY;
                     if (MONTH > 12)
                     {
                        MONTH = MONTH - 12;
                        YEAR = YEAR + 1;
                     }
                     FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + MONTH + "/" + YEAR;
                     FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D2/");
                  }
                  if (FIRST_DIRECT_DEBIT <= TODAYS_DATE)
                  {
                     DAY = OCONV(FIRST_DIRECT_DEBIT, "DD");
                     MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                     YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                     do
                     {
                        if (FIRST_DIRECT_DEBIT > TODAYS_DATE) break;
                        MONTH = MONTH + 1;
                        if (MONTH == 13)
                        {
                           MONTH = 1;
                           YEAR = YEAR + 1;
                        }
                        FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + MONTH + "/" + YEAR;
                        FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D2/");
                     } while (true);
                  }
                  if (FIRST_DIRECT_DEBIT < DATE_NEXT_RUN)
                  {
                     FIRST_DIRECT_DEBIT = DATE_NEXT_RUN;
                  }
                  /*  allow for possible cut-off day */
                  if (CUT_OFF_DAY != "" && NUM(CUT_OFF_DAY))
                  {
                     if (MONTHS_LEEWAY == "" || NOT(NUM(MONTHS_LEEWAY)))
                     {
                        FIRST_DEBIT_MONTH = OCONV(FIRST_DIRECT_DEBIT, "DM");
                        FIRST_DEBIT_YEAR = OCONV(FIRST_DIRECT_DEBIT, "DY");
                        CUT_OFF_DATE = CUT_OFF_DAY + "/" + FIRST_DEBIT_MONTH + "/" + FIRST_DEBIT_YEAR;
                        CUT_OFF_DATE = ICONV(CUT_OFF_DATE, "D");
                        CUT_OFF_MONTH = FIRST_DEBIT_MONTH;
                        CUT_OFF_YEAR = FIRST_DEBIT_YEAR;
                        if (CUT_OFF_DATE >= FIRST_DIRECT_DEBIT)
                        {
                           CUT_OFF_MONTH = CUT_OFF_MONTH - 1;
                           if (CUT_OFF_MONTH < 1)
                           {
                              CUT_OFF_MONTH = 12;
                              CUT_OFF_YEAR = CUT_OFF_YEAR - 1;
                           }
                           CUT_OFF_DATE = CUT_OFF_DAY + "/" + CUT_OFF_MONTH + "/" + CUT_OFF_YEAR;
                           CUT_OFF_DATE = ICONV(CUT_OFF_DATE, "D");
                        }
                        if (TODAYS_DATE > CUT_OFF_DATE)
                        {
                           FIRST_DEBIT_MONTH = FIRST_DEBIT_MONTH + 1;
                           if (FIRST_DEBIT_MONTH > 12)
                           {
                              FIRST_DEBIT_MONTH = FIRST_DEBIT_MONTH - 12;
                              FIRST_DEBIT_YEAR = FIRST_DEBIT_YEAR + 1;
                           }
                           FIRST_DIRECT_DEBIT = DAY_OF_MONTH + "/" + FIRST_DEBIT_MONTH + "/" + FIRST_DEBIT_YEAR;
                           FIRST_DIRECT_DEBIT = ICONV(FIRST_DIRECT_DEBIT, "D");
                        }
                     }
                  }
                  PRINT(AT(ST_COL + 5, ST_ROW) + "........" + AT(ST_COL + 5, ST_ROW) + OCONV(FIRST_DIRECT_DEBIT, "D2/") + COMMON.EOL + AT(ST_COL + 5, ST_ROW));
                  INPUT(out USER_START_DATE, 11);
                  if (USER_START_DATE != "")
                  {
                     TEST_DATE = ICONV(USER_START_DATE, "D4/");
                     if (TEST_DATE == "")
                     {
                        PRINT(AT(ST_COL + 5, ST_ROW) + COMMON.EOL);
                        L130();
                        VALIDATION_ERRORS = TRUE;
                        return;
                     }
                     START_DATE = TEST_DATE - LEEWAY;
                     L175();
                     if (FIRST_DIRECT_DEBIT < TODAYS_DATE)
                     {
                        PRINT(AT(ST_COL + 5, ST_ROW) + COMMON.EOL);
                        L130();
                        VALIDATION_ERRORS = TRUE;
                        return;
                     }
                  }
                  PRINT(AT(ST_COL + 5, ST_ROW) + OCONV(FIRST_DIRECT_DEBIT, "D2/") + COMMON.EOL);
               }
            }
            else
            {
               FIRST_DIRECT_DEBIT = "";
               PRINT(AT(ST_COL + 5, ST_ROW) + COMMON.EOL);
            }
            // BEGIN CASE
            // CASE
            if (PICT_REQ)
            {
               if (MUST_TAKE_MONEY == "Y" && PICT_REQ)
               {
                  if (INPUT_NO > 32)
                  {
                     PHOTO_KEY = SUB_KEY;
                  }
                  else
                  {
                     PHOTO_KEY = CENTRE_PREFIX + BKEY;
                  }
                  if (CAMERA_OR_SCAN == "S")
                  {
                     nrf0 = "NEW";
                     FL_GET_PHOTO = new FL_GET_PHOTO(ref nrf0, ref PHOTO_KEY, ref MEM_REC);
                  }
                  else
                  {
                     if (INPUT_NO > 32)
                     {
                        PHOTO_KEY = SUB_KEY;
                     }
                     else
                     {
                        PHOTO_KEY = CENTRE_PREFIX + BKEY;
                     }
                     nrf0 = "NEW";
                     FL_GET_PHOTO = new FL_GET_PHOTO(ref nrf0, ref PHOTO_KEY, ref MEM_REC);
                  }
                  INPUT_NO = 32;
                  INPUT_LINES = 36;
                  PART_REC = TRUE;
               }
            }
            // END CASE
         }// CASE
         else if (VALIDATION_NO == 23 || VALIDATION_NO == 24 || VALIDATION_NO == 25 || VALIDATION_NO == 26 || VALIDATION_NO == 27 || VALIDATION_NO == 28)
         {
            /*  Analysis Codes */
            if (MEM_PARAMS_REC[9] != "" && MEM_PARAMS_REC[9].Substring(1, 1) != "*")
            {
               ANAL_FIELD_NO = VALIDATION_NO - 22;
               INTERACT = VALID_INPUT;
               CallAt_ANAL_VAL_PROG = new CallAt_ANAL_VAL_PROG(ref ANAL_VAL_PROG, ref ANAL_FIELD_NO, ref ANS, ref INTERACT);
               if (INTERACT == INVALID_INPUT) { L130(); VALIDATION_ERRORS = TRUE; return; }
            }
         }// CASE
         else if (VALIDATION_NO == 29 || VALIDATION_NO == 30 || VALIDATION_NO == 31)
         {
            /*  Restrictions */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 32)
         {
            /*  Comments */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 33)
         {
            /*  Letter Salutation */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 34)
         {
            /*  Spouses Title */
            if (ANS == "")
            {
               if (INPUT_NO == 34)
               {
                  L130();
                  VALIDATION_ERRORS = TRUE;
                  return;
               }
               else
               {
                  NO_MORE_FAMILY = 1;
                  if (NOT(COMPLETING_REC))
                  {
                     LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED - 1;
                     WRITE(LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
                  }
                  goto L90;
               }
            }
            if (NOT(MATCH(ANS, "0A"))) { L130(); VALIDATION_ERRORS = TRUE; return; }
            APPLICANTS_TITLE = ANS;
            MEM_REC[19, SUB_NO - 1] = SUB_KEY;
         }// CASE
         else if (VALIDATION_NO == 35)
         {
            /*  Spouses Surname */
            L173();
            if (NOT(NAME_OK)) { L130(); VALIDATION_ERRORS = TRUE; return; }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            if (ANS == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
            if (ANS == SURNAME_REPEAT)
            {
               ANS = FAMILY_SURNAME;
               PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            }
            SURNAME = ANS;
         }// CASE
         else if (VALIDATION_NO == 36)
         {
            /*  Spouses Forename */
            L173();
            if (NOT(NAME_OK)) { L130(); VALIDATION_ERRORS = TRUE; return; }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            INITS2 = ANS.Substring(1, 1);
            INITS_COL = SC_POS[INPUT_LINES + 1, 1] + LEN(SC_POS[INPUT_LINES + 1, 3]) + 2;
            INITS_ROW = SC_POS[INPUT_LINES + 1, 2];
            PRINT(AT(INITS_COL, INITS_ROW) + INITS2);
         }// CASE
         else if (VALIDATION_NO == 37)
         {
            /*  Spouses Initials */
            if (ANS == "") { ANS = INITS2; }
            else
            {
               ANS = TRIM(ANS);
               if (NOT(MATCH(ANS, "0A") || MATCH(ANS, "0A\" \"0A"))) { L130(); VALIDATION_ERRORS = TRUE; return; }
            }
            PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
         }// CASE
         else if (VALIDATION_NO == 38)
         {
            /*  Spouses Type */
            if (ANS == "")
            {
               ANS = FAMILY_MEMBERSHIP_TYPE;
               PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
            }
            if (MEM_TYPE_LIST)
            {
               CARD_POS = 1;
               do
               {
                  if (CARD_TYPES[1, CARD_POS] == "") break;
                  if (CARD_JOINING[1, CARD_POS] != "")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS] + "J";
                     TICKET_REC[3, -1] = CARD_JOINING[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = SUB_KEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  if (CARD_UPFRONT[1, CARD_POS] != "")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS] + "U";
                     TICKET_REC[3, -1] = CARD_UPFRONT[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = SUB_KEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  if (CARD_DDFLAGS[1, CARD_POS] != "Y")
                  {
                     TICKET_REC[1, -1] = "M*" + CARD_TYPES[1, CARD_POS];
                     TICKET_REC[3, -1] = CARD_PRICES[1, CARD_POS];
                     TICKET_REC[2, -1] = 1;
                     TICKET_REC[10, -1] = SUB_KEY;
                     TICKET_REC[11, -1] = 1;
                     TICKET_REC[13, -1] = "STD";
                  }
                  CARD_POS = CARD_POS + 1;
               } while (true);
               SUB_TYPES[SUBMEMBER_NO] = CARD_TYPES;
               SUB_EXPIRY[SUBMEMBER_NO] = CARD_EXPIRY;
               SUB_PRICES[SUBMEMBER_NO] = CARD_PRICES;
               SUB_DDFLAGS[SUBMEMBER_NO] = CARD_DDFLAGS;
               CARD_TYPES = "";
               CARD_EXPIRY = "";
               CARD_DDFLAGS = "";
            }
            else
            {
               /*  if not mem.type.list */
               MEMBERSHIP_TYPE = ANS;
               TICKET_CODE = "M*" + MEMBERSHIP_TYPE;
               TODAYZ_DATE = TODAYS_DATE;
               nrf0 = "Z";
               nrf1 = TIME();
               FL355 = new FL355(ref TICKET_CODE, ref nrf0, ref TODAYZ_DATE, ref nrf1, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
               if (RESPONSE == FALSE) { L130(); VALIDATION_ERRORS = TRUE; return; }
               /* * nothing should be getting written to ticket record */
               /* * for sites not using pop-up memtype list */
               /* * comment out following lines */
               /* *     TICKET.REC<1,-1> = "M*":MEMBERSHIP.TYPE */
               /* *     TICKET.REC<2,-1> = 1 */
               /* *     TICKET.REC<3,-1> = PRICE */
               /* *     TICKET.REC<10,-1> = SUB.KEY */
               /* *     TICKET.REC<11,-1> = 1 */
               /* *     TICKET.REC<13,-1> = "STD" */
               /* * */
               /* * end of fix */
               SUB_TYPES[SUBMEMBER_NO] = MEMBERSHIP_TYPE;
               SUB_EXPIRY[SUBMEMBER_NO] = CARD_EXPIRY;
               /* SUB.PRICES(SUBMEMBER.NO) = CARD.PRICES */
               SUB_PRICES[SUBMEMBER_NO] = PRICE;
               SUB_DDFLAGS[SUBMEMBER_NO] = CARD_DDFLAGS;
               CARD_TYPES = "";
               CARD_EXPIRY = "";
               CARD_DDFLAGS = "";
            }
         }// CASE
         else if (VALIDATION_NO == 39)
         {
            /*  Spouses Sex */
            if (ANS != "M" && ANS != "F") { L130(); VALIDATION_ERRORS = TRUE; return; }
            APPLICANTS_SEX = ANS;
            if (APPLICANTS_TITLE == "MR" && APPLICANTS_SEX != "M") { L130(); VALIDATION_ERRORS = TRUE; return; }
            if (APPLICANTS_TITLE == "MRS" || APPLICANTS_TITLE == "MISS" || APPLICANTS_TITLE == "MS" && APPLICANTS_SEX != "F") { L130(); VALIDATION_ERRORS = TRUE; return; }
         }// CASE
         else if (VALIDATION_NO == 40)
         {
            /*  Spouses Age */
            // BEGIN CASE
            // CASE
            if (ANS == "NONE")
            {
               ANS = "";
            }// CASE
            else if (LEN(ANS) <= 3)
            {
               if (DOB_ONLY == "Y") { L131(); VALIDATION_ERRORS = TRUE; return; }
               if (NOT(NUM(ANS))) { L131(); VALIDATION_ERRORS = TRUE; return; }
               ANS = ANS + 0;
               if (INT(ANS) != ANS) { L130(); VALIDATION_ERRORS = TRUE; return; }
               YEARS_OLD = ANS;
               CURR_YEAR = OCONV(TODAYS_DATE, "DY");
               TEST_YEAR = CURR_YEAR - YEARS_OLD;
               TEST_DATE = "01/01/" + TEST_YEAR;
            }// CASE
            else if (LEN(ANS) > 3)
            {
               TEST_DATE = ICONV(ANS, "D4/");
               if (TEST_DATE == "") { L130(); VALIDATION_ERRORS = TRUE; return; }
               YEARS_OLD = TODAYS_DATE - TEST_DATE;
               YEARS_OLD = INT(YEARS_OLD / 365);
               TEST_DATE = OCONV(TEST_DATE, "D4/");
               PRINTCR(AT(ST_COL, ST_ROW) + TEST_DATE);
            }
            // END CASE
            if (ANS != "")
            {
               DOB = ICONV(TEST_DATE, "D");
               if (YEARS_OLD < CHILD_MINIMUM) { L131(); VALIDATION_ERRORS = TRUE; return; }
               if (INPUT_NO != 40 && YEARS_OLD > CHILD_MAXIMUM) { L131(); VALIDATION_ERRORS = TRUE; return; }
               SURNAME = MEM_REC[4, SUB_NO];
               if (INDEXING_ROUTINE != "")
               {
                  OPTION = "";
                  CallAt_INDEXING_ROUTINE = new CallAt_INDEXING_ROUTINE(ref INDEXING_ROUTINE, ref SURNAME, ref DOB, ref OPTION);
                  if (OPTION == "A") { L176(); return; }
                  if (OPTION == "C") { return; }
                  if (OPTION != "") { L178(); }
               }
               MEM_REC[21, SUB_NO] = ICONV(TEST_DATE, "D");
               ANS = MEM_REC[21, SUB_NO];
               MEM_REC[8, SUB_NO] = YEARS_OLD;
            }
            else
            {
               MEM_REC[21, SUB_NO] = "";
               MEM_REC[8, SUB_NO] = "";
            }
         }// CASE
         else if (VALIDATION_NO == 41 || VALIDATION_NO == 42 || VALIDATION_NO == 43 || VALIDATION_NO == 44 || VALIDATION_NO == 45 || VALIDATION_NO == 46)
         {
            /*  Spouses Analysis Codes */
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (VALIDATION_NO == 47 || VALIDATION_NO == 48 || VALIDATION_NO == 49)
         {
            /*  Spouses Restrictions */
            if (INPUT_NO == 113) { NO_MORE_FAMILY = 1; }
            NO_POSSIBLE_ERRORS = 1;
         }// CASE
         else if (OTHERWISE)
         {
            PRINTCR(COMMON.WASH);
            PRINTCR("A SCREEN HANDLING ERROR HAS OCCURRED");
            PRINTCR("CONTACT THE COMPUTER SECTION WITH THIS");
            PRINTCR("MESSAGE:");
            PRINTCR("****************************************************");
            PRINTCR("ERROR IN 'CASE OTHERWISE' STATEMENT IN VALIDATION SUBROUTINE");
            PRINTCR("VALIDATION NO" + VALIDATION_NO);
            PRINTCR("****************************************************");
            INPUT(out HOLD_INPUT, 2);
            if (LEN(HOLD_INPUT) > 1) { PRINT(AT(-9) + " "); HOLD_INPUT = HOLD_INPUT.Substring(1, 1); }
            ALL_CLEAR = 0;
            STOP();
         L90: ;
         }
         // END CASE
         return;
         /* ******************************************************************** */
         /*              O T H E R   S U B R O U T I N E S */
         /* ******************************************************************** */
      }
      void L130()
      {
         nrf0 = INIT;
         FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(ST_COL, ST_ROW) + STR(".", PROMPT_LEN));
         INPUT_LINES = INPUT_LINES - 1;
         INPUT_NO = INPUT_NO - 1;
         return;
      }
      void L131()
      {
         nrf0 = 111;
         nrf1 = INIT;
         FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(ST_COL, ST_ROW) + STR(".", PROMPT_LEN));
         INPUT_LINES = INPUT_LINES - 1;
         INPUT_NO = INPUT_NO - 1;
         return;
      }
      void L140()
      {
         INPUT_LINES = INPUT_LINES - 2;
         INPUT_NO = INPUT_NO - 2;
      L150: ;
         if (NOT(SC_POS[INPUT_LINES + 1, 4]))
         {
            INPUT_LINES = INPUT_LINES - 1;
            goto L150;
         }
         return;
      }
      void L170()
      {
         ABBREVIATION = ANS;
         FL000_16 = new FL000_16(ref ABBREVIATION, ref ANS);
         /* *     PRINT @(ST.COL,ST.ROW):ANS: */
         PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[PROMPT_LEN] + AT(ST_COL, ST_ROW) + ANS);
         return;
      }
      void L173()
      {
         NAME_OK = TRUE;
         if (ANS != "" && NOT(MATCH(ANS, "0A")))
         {
            NAME_OK = FALSE;
            for (CHAR_POS = 1; CHAR_POS <= LEN(ANS); CHAR_POS += 1)
            {
               ZZZ_CHAR = ANS.Substring(CHAR_POS, 1);
               if (ZZZ_CHAR == "-" || ZZZ_CHAR == "'" || ZZZ_CHAR == " ") { NAME_OK = TRUE; }
               if (CHAR_POS == 1 && NOT(MATCH(ZZZ_CHAR, "0A"))) { NAME_OK = FALSE; }
            }
         }
         return;
      }
      void L175()
      {
         /*  Establish Start Date for Direct Debits */
         MONTH = OCONV(START_DATE, "DM");
         YEAR = OCONV(START_DATE, "DY");
         TRANSFER_DATE = DAY_OF_MONTH + "." + MONTH + "." + YEAR;
         TRANSFER_DATE = ICONV(TRANSFER_DATE, "D4/");
         if (TRANSFER_DATE - START_DATE >= LEEWAY)
         {
            FIRST_DIRECT_DEBIT = TRANSFER_DATE;
         }
         else
         {
            MONTH = MONTH + 1;
            if (MONTH == 13)
            {
               MONTH = 1;
               YEAR = YEAR + 1;
            }
            TRANSFER_DATE = DAY_OF_MONTH + "." + MONTH + "." + YEAR;
            TRANSFER_DATE = ICONV(TRANSFER_DATE, "D4/");
            FIRST_DIRECT_DEBIT = TRANSFER_DATE;
         }
         return;
      }
      void L176()
      {
         /*  Redisplay submember screen after abandoning from matches */
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINT(AT(44, 3) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SUBMEMBER_NO - 1);
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(0, 23) + COMMON.EOL);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         INPUT_NO = INPUT_NO - 6;
         INPUT_LINES = INPUT_LINES - 6;
         return;
      }
      void L178()
      {
         /*  Redisplay submember details after ignoring matches */
         FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
         PRINT(AT(44, 3) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + SUBMEMBER_NO - 1);
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(0, 23) + COMMON.EOL);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         PRINTCR(AT(20, 5) + MEM_REC[6, SUBMEMBER_NO]);
         PRINTCR(AT(20, 7) + MEM_REC[4, SUBMEMBER_NO]);
         PRINTCR(AT(20, 9) + MEM_REC[29, SUBMEMBER_NO]);
         PRINTCR(AT(20, 11) + MEM_REC[5, SUBMEMBER_NO]);
         PRINTCR(AT(50, 5) + MEM_REC[2, SUBMEMBER_NO]);
         PRINTCR(AT(50, 7) + MEM_REC[7, SUBMEMBER_NO]);
         PRINT(AT(50, 9));
         if (LEN(ANS) <= 3) { PRINTCR(ANS); } else { PRINTCR(TEST_DATE); }
         PRINT(AT(50, 9));
         if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
         {
            PRINT(CHAR(28) + "500");
            PRINT(CHAR(20));
         }
         return;
      }
      void L179()
      {
         PRINT(AT(19, 5) + MEM_REC[6, SUBMEMBER_NO]);
         /*  Title */
         PRINT(AT(19, 7) + MEM_REC[4, SUBMEMBER_NO]);
         /*  Surname */
         PRINT(AT(19, 9) + MEM_REC[29, SUBMEMBER_NO]);
         /*  Forename */
         PRINT(AT(19, 11) + MEM_REC[5, SUBMEMBER_NO]);
         /*  Initials */
         if (MULTIPLE_TYPES)
         {
            PRINT(AT(50, 5) + "MXD");
         }
         else
         {
            PRINT(AT(50, 5) + MEM_REC[2, SUBMEMBER_NO]);
            /*  Type */
         }
         PRINT(AT(50, 7) + MEM_REC[7, SUBMEMBER_NO]);
         /*  Sex */
         PRINT(AT(50, 9) + OCONV(MEM_REC[21, SUBMEMBER_NO], "D"));
         /*  Dob */
         ANAL_POS = ((SUBMEMBER_NO - 1) * 6) + 1;
         PRINT(AT(32, 16) + MEM_REC[16, ANAL_POS]);
         PRINT(AT(47, 16) + MEM_REC[16, ANAL_POS + 1]);
         PRINT(AT(62, 16) + MEM_REC[16, ANAL_POS + 2]);
         PRINT(AT(32, 18) + MEM_REC[16, ANAL_POS + 3]);
         PRINT(AT(47, 18) + MEM_REC[16, ANAL_POS + 4]);
         PRINT(AT(62, 18) + MEM_REC[16, ANAL_POS + 5]);
         RESTR_POS = ((SUBMEMBER_NO - 1) * 3) + 1;
         PRINT(AT(30, 19) + MEM_REC[27, RESTR_POS]);
         PRINT(AT(45, 19) + MEM_REC[27, RESTR_POS + 1]);
         PRINT(AT(60, 19) + MEM_REC[27, RESTR_POS + 2]);
         APPLICANTS_TITLE = MEM_REC[6, SUBMEMBER_NO];
         APPLICANTS_SEX = MEM_REC[7, SUBMEMBER_NO];
         MEM_REC[31] = "";
         return;
      }
      void L200()
      {
         /*  ASSIGN SUB MEMBER NOS */
         SUB_KEY_ALLOCATED = FALSE;
         if (MEMBER_NO_ALLOCATION != "")
         {
            MEMBER_NUMBER = CENTRE_PREFIX + BKEY;
            CallAt_MEMBER_NO_ALLOCATION = new CallAt_MEMBER_NO_ALLOCATION(ref MEMBER_NO_ALLOCATION, ref MEMBER_NUMBER, ref MEM_REC, ref SUBMEMBER_NO, ref SUB_KEY, ref LAST_NUMBER);
            if (SUB_KEY != "N" && SUB_KEY != "" && SUB_KEY != COMMON.ABANDON)
            {
               SUB_KEY_ALLOCATED = TRUE;
            }
         }
         if (NOT(SUB_KEY_ALLOCATED))
         {
            /*  Automatically calculate next no */
            readUResult = READU_LOCKED(ref LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
            if (readUResult == ReadUResult.Locked)
            {
               nrf0 = 444;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               ERROR_SET = TRUE;
               return;
            }
            else
            {
               LAST_NUMBER_ISSUED = 0;
            }
            LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED + 1;
            SUB_KEY_OK = FALSE;
            do
            {
               if (SUB_KEY_OK) break;
               SUB_KEY = LAST_NUMBER_ISSUED;
               if (LEN(SUB_KEY) < NUMBER_LENGTH)
               {
                  JUSTIF = "R%" + NUMBER_LENGTH;
                  SUB_KEY = FORMAT(SUB_KEY, JUSTIF);
               }
               SUB_KEY = CENTRE_PREFIX + SUB_KEY;
               ITS_LOCKED_OR_EXISTS = TRUE;
               readUResult = READU_LOCKED(ref TEST_REC, COMMON.FILES[MEMBERS], SUB_KEY);
               if (readUResult == ReadUResult.Locked)
               {
                  ITS_LOCKED_OR_EXISTS = TRUE;
               }
               else
               {
                  ITS_LOCKED_OR_EXISTS = FALSE;
               }
               if (LOCATE(SUB_KEY, MEM_REC[19], 1, 0, 1, ref POS, "AL"))
               {
                  SUBNO_ALREADY_USED = TRUE;
               }
               else
               {
                  SUBNO_ALREADY_USED = FALSE;
               }
               if (READ(ref BACS_REC, FL_BACS_REF, SUB_KEY))
               {
                  BACS_REF = TRUE;
               }
               else
               {
                  BACS_REF = FALSE;
               }
               // BEGIN CASE
               // CASE
               if (ITS_LOCKED_OR_EXISTS)
               {
                  LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED + 1;
               }// CASE
               else if (SUB_KEY == APP_NUM)
               {
                  LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED + 1;
               }// CASE
               else if (SUBNO_ALREADY_USED)
               {
                  LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED + 1;
               }// CASE
               else if (BACS_REF == TRUE)
               {
                  LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED + 1;
               }// CASE
               else if (ITS_LOCKED_OR_EXISTS == FALSE)
               {
                  SUB_KEY_OK = TRUE;
                  WRITE(LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
                  NEW_NUMBERS_ISSUED[-1] = LAST_NUMBER_ISSUED;
               }
               // END CASE
            } while (true);
         }
         PRINT(AT(47, 3) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + FORMAT(SUB_KEY, "L#15"));
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
         PRINT(AT(0, 23) + COMMON.EOL);
         PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
         return;
      }
      void L300()
      {
         /*  Reset last number if necessary */
         readUResult = READU_LOCKED(ref LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER);
         if (readUResult == ReadUResult.Locked)
         {
            return;
         }
         else
         {
            return;
         }
         TOTAL_NEWNOS = DCOUNT(NEW_NUMBERS_ISSUED, AM);
         for (EACH_NEWNO = TOTAL_NEWNOS; EACH_NEWNO <= 1; EACH_NEWNO += -1)
         {
            if (NEW_NUMBERS_ISSUED[EACH_NEWNO] == LAST_NUMBER_ISSUED)
            {
               LAST_NUMBER_ISSUED = LAST_NUMBER_ISSUED - 1;
               if (LAST_NUMBER_ISSUED < 0) { LAST_NUMBER_ISSUED = 0; }
            }
         }
         WRITEV(LAST_NUMBER_ISSUED, COMMON.FILES[MEMBERSHIP_NUMBERS], LAST_NUMBER, 1);
         TRANS_LOG_REC = LAST_NUMBER_ISSUED;
         nrf0 = "W";
         nrf1 = "DICT FL.MEMBERS";
         FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref LAST_NUMBER);
         return;
      }
      void L400()
      {
         /* ADT log */
         MAT(ref ADT_REC, "");
         ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + ADT_LOG_KEY;
         ADT_REC[ADT_DATE] = TODAYS_DATE;
         ADT_REC[ADT_USER] = U_INITS;
         ADT_REC[ADT_ORIG_VALUE] = I_EXPIRY;
         ADT_REC[ADT_NEW_VALUE] = MEM_REC[13];
         ADT_REC[ADT_REASON] = ADT_LOG_REASON;
         ADT_REC[ADT_TIME] = TIME();
         if (!READV(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
         SEQ_NO = SEQ_NO + 1;
         MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
         WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
         return;
      }
      void L500()
      {
         RELEASE();
         return;
      }
   }
}
