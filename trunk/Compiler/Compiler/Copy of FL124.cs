//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL124 : UvBase
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
readonly UvVar FL_SCREENS = 8;
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
readonly UvVar TRANS_DATE = 1;
readonly UvVar TRANS_USER = 2;
readonly UvVar TRANS_ADJ = 3;
readonly UvVar TRANS_DATES = 4;
readonly UvVar TRANS_TYPE = 5;
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
readonly UvVar FL_BANK_DETAILS = 108;
readonly UvVar BANK_SORT_CODE = 1;
readonly UvVar BANK_ACCOUNT_NO = 2;
readonly UvVar BANK_NAME = 3;
readonly UvVar BANK_INSTALL_RECORDS = 4;
readonly UvVar BANK_ACCOUNT_NAME = 5;
readonly UvVar BANK_TRANS_CODE = 6;
readonly UvVar BANK_BACS_REF = 7;
readonly UvVar BANK_HOLDERS_ADDRESS = 8;
readonly UvVar FL_CONTROL = 10;
readonly UvVar DELETED_SORT_CODE = 1;
readonly UvVar DELETED_ACCOUNT_NO = 2;
readonly UvVar DELETED_NAME = 3;
readonly UvVar DELETED_INSTALL_RECORDS = 4;
readonly UvVar DELETED_ACCOUNT_NAME = 5;
readonly UvVar DELETED_TRANS_CODE = 6;
readonly UvVar DELETED_BACS_REF = 7;
readonly UvVar DELETED_HOLDERS_ADDRESS = 8;
readonly UvVar DELETED_INST_AMOUNT = 11;
readonly UvVar DELETED_ANNUAL_FEE = 12;
readonly UvVar DELETED_LETTER = 13;
readonly UvVar DELETED_ORIGINAL_DATE = 14;
readonly UvVar DELETED_NUMBER = 15;
readonly UvVar DELETED_AMOUNTS = 16;
readonly UvVar DELETED_DATES = 17;
readonly UvVar DELETED_OPERATOR = 18;
readonly UvVar DELETED_ADJ = 19;
readonly UvVar DELETED_PAID = 20;
readonly UvVar DELETED_TRANS_CNT = 21;
readonly UvVar DELETED_LAST_REQ_AMOUNT = 22;
readonly UvVar DELETED_LAST_DATE = 23;
readonly UvVar DELETED_LAST_RECD_AMOUNT = 24;
readonly UvVar DELETED_CANCELLED_DATE = 25;
readonly UvVar DELETED_DEPOSIT = 26;
readonly UvVar DELETED_REJECTIONS = 27;
readonly UvVar DELETED_ADJ_TYPE = 28;
readonly UvVar DELETED_FREEZE_DATE = 29;
readonly UvVar DELETED_DEBTOR_DATES = 31;
readonly UvVar DELETED_DEBTOR_OWED = 32;
readonly UvVar DD_DEBTORS_DATES = 1;
readonly UvVar DD_DEBTORS_OWED = 2;
readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
readonly UvVar DD_DEBTORS_REASON = 4;
readonly UvVar BACS_LODGEMENTS_SORTCODE = 1;
readonly UvVar BACS_LODGEMENTS_ACCNO = 2;
readonly UvVar BACS_LODGEMENTS_BANKNAME = 3;
readonly UvVar BACS_LODGEMENTS_ACCNAME = 4;
readonly UvVar BACS_LODGEMENTS_TRANS_CODE = 5;
readonly UvVar AUDDIS_LOG_SORTCODE = 1;
readonly UvVar AUDDIS_LOG_ACCNO = 2;
readonly UvVar AUDDIS_LOG_BANKNAME = 3;
readonly UvVar AUDDIS_LOG_ACCNAME = 4;
readonly UvVar AUDDIS_LOG_TRANS_CODE = 5;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] TRANS_REC = new UvVar[10];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] BANK_REC = new UvVar[10];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] DELETED_DEBITS_REC = new UvVar[50];
UvVar[] DD_DEBTORS_REC = new UvVar[10];
UvVar[] BACS_LODGEMENTS_REC = new UvVar[10];
UvVar[] AUDDIS_LOG_REC = new UvVar[20];
#endregion
#region Variables
UvVar TYPE = "";
UvVar REFERENCE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar DEBIT_SETS = "";
UvVar DEBIT_NUMBER = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_DDS_TRANS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_DELETED_DEBITS = "";
UvVar FL_DD_DEBTORS = "";
UvVar FL_BACS_LODGEMENTS = "";
UvVar MESSAGE = "";
FL006 FL006;
UvVar FL_AUDDIS_LOG = "";
UvVar FL_MEMBER_PARAMS = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar TRANS_TYPE_LIST = "";
UvVar TRANS_ADJ_AMOUNTS = "";
UvVar TRANS_ADJ_DATES = "";
UvVar DATES_CHANGED = "";
UvVar UPDATE_DEBTORS = "";
UvVar UNCANCELLATION = "";
UvVar CANCELLATION_DONE = "";
UvVar CONTROL_DETS = "";
UvVar DD_DAY_PARAM = "";
UvVar DAY1_OF_MONTH = "";
UvVar DAY2_OF_MONTH = "";
UvVar DD_LEEWAY_PARAM = "";
UvVar DATE_LAST_RUN_PARAM = "";
UvVar DD_STAGE_PARAM = "";
UvVar DD_EXP_LEEWAY = "";
UvVar MEM_PARAMS_REC = "";
UvVar MEM_TYPE_LIST = "";
UvVar SUB_FEES_INCLUDE = "";
UvVar MULTIPLE_TYPES = "";
UvVar PASSWORD_CONTROL = "";
UvVar LOG_AUDDIS = "";
UvVar AUDDIS_CONTROL = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar ANS = "";
UvVar MEMBER_REQD = "";
UvVar TICKET_REC = "";
UvVar RUN_CHECKS = "";
FL103 FL103;
UvVar WAIT = "";
UvVar MEM_REC = "";
UvVar NAME = "";
UvVar DAY_OF_MONTH = "";
FL124_1 FL124_1;
UvVar DEBIT_LIST = "";
UvVar WNDO_DATA_POS = "";
UvVar REQUIRED_ID = "";
UvVar DEBTOR_ID = "";
UvVar ORIG_DD_STATUS = "";
UvVar OLD_DEBIT_DATES = "";
UvVar POS = "";
UvVar DD_DAY = "";
UvVar DD_LEEWAY = "";
UvVar DATE_LAST_RUN = "";
UvVar DD_STAGE = "";
UvVar BACS_REF = "";
UvVar WINDOW_TEXT_LIST = "";
UvVar WNDO_T = "";
UvVar WNDO_B = "";
UvVar WNDO_L = "";
UvVar WNDO_R = "";
UvVar REQD_ITM = "";
UvVar UPDATE_REQ = "";
UvVar TOTAL_AMOUNT = "";
UvVar TOTAL_ADJ = "";
UvVar TOTAL_BAL = "";
UvVar TOTAL_PAID = "";
UvVar LAST_DD_DATE = "";
UvVar LINE_POS = "";
UvVar REQD_ID = "";
UvVar EDITING = "";
UvVar AMEND_NO = "";
FL124_2 FL124_2;
UvVar DISPLAY = "";
UvVar ANSWER = "";
UvVar NEW_DATE = "";
UvVar VALID_DATE = "";
UvVar NEW_DEBIT_AMOUNT = "";
UvVar NEW_ORIGINAL_DATE = "";
UvVar CHOSEN_DD_DAY = "";
UvVar ALTERNATE_DAY = "";
UvVar CHANGE_DAY = "";
UvVar DAY_OF_PREMIUM = "";
UvVar PNTR = "";
UvVar STAGE_OF_PREMIUM = "";
UvVar LAST_RUN = "";
UvVar BALANCE = "";
UvVar REJECTION_ADJUSTMENT = "";
UvVar ADJ_AMOUNT = "";
UvVar ADJ_TYPE = "";
UvVar VALID_AMOUNT = "";
UvVar VALID_TYPE = "";
UvVar INPUT_LENGTH = "";
UvVar DONE = "";
UvVar DEBIT_BAL = "";
UvVar REMAINDER = "";
UvVar VALID_EXPIRY = "";
UvVar NEW_MEM_EXPIRY = "";
FLTX2 FLTX2;
UvVar TRANS_ID = "";
UvVar CARD_COUNT = "";
UvVar CARD = "";
UvVar WINDOW_TEXT_LINE = "";
UvVar LODGE_CONTROL_REC = "";
UvVar LAST_LODGE_DATE = "";
UvVar NEW_DD_DAY = "";
UvVar THIS_DAYS_LEEWAY = "";
UvVar THIS_DAYS_LAST_RUN = "";
UvVar THIS_DAYS_STAGE = "";
UvVar NEW_DD_MONTH = "";
UvVar NEW_DD_YEAR = "";
UvVar THIS_DAYS_NEXT_RUN = "";
UvVar TOTAL_DATES = "";
UvVar FIRST_DATE = "";
UvVar LAST_DATE = "";
UvVar MESS = "";
UvVar CONTINUE = "";
UvVar NEW_DEBIT_POS = "";
UvVar ADJUST_ALL = "";
UvVar NEXT_DATE = "";
UvVar NEXT_DATES_MONTH = "";
UvVar NEXT_DATES_YEAR = "";
UvVar NEXT_DEBIT_POS = "";
UvVar IDATE = "";
UvVar SP_PASS = "";
UvVar REASON = "";
UvVar NEW_EXPIRY_DATE = "";
UvVar EXPIRE_QUERY = "";
UvVar EXPIRE_MESSAGE = "";
UvVar MEM_EXP_DATE = "";
UvVar O_MEM_EXP_DATE = "";
UvVar TOTAL_TYPES = "";
UvVar EACH_TYPE = "";
UvVar DATES_TO_AMEND = "";
UvVar START_POS = "";
UvVar INVALID_PROCEDURE = "";
UvVar EACH_DATE = "";
UvVar MONTH = "";
UvVar NEW_DEBIT_DATE = "";
UvVar YEAR = "";
UvVar INST = "";
UvVar DEBIT_DATE = "";
UvVar DATE_POS = "";
UvVar NEW_DAY = "";
UvVar NEW_MONTH = "";
UvVar NEW_YEAR = "";
UvVar START_OF_REST = "";
UvVar THIS_DAY = "";
UvVar THIS_MONTH = "";
UvVar THIS_YEAR = "";
UvVar THIS_DATE = "";
UvVar START_DATE = "";
UvVar DAY = "";
UvVar TRANSFER_DATE = "";
UvVar DAY_POS = "";
UvVar STAGE_IND = "";
UvVar MTH = "";
UvVar YR = "";
UvVar DATE_NEXT_RUN = "";
UvVar POS_INCR = "";
UvVar START_DATE_TO_USE = "";
UvVar END_POS = "";
UvVar SDATE = "";
UvVar EDATE = "";
UvVar FRZ_AMOUNT = "";
UvVar TOTAL_INSTS = "";
UvVar START_FREEZE = "";
UvVar END_FREEZE = "";
UvVar ZZZ_COUNT = "";
UvVar CHECK_DATE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL124(ref UvVar TYPE, ref UvVar REFERENCE) {
this.TYPE = TYPE;
this.REFERENCE = REFERENCE;
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
/*  Routine to maintain Bacs Figures - Debit Adjustment */
/*  Started by AB, finished by RT, with alot of dabbling done by HS ! */
/*  Note that I refer to DEBIT.SETS which are the total number of valid */
/*  sets contained in DEBIT.LISTS and the DEBIT.NUMBER is the one */
/*  currently being amended */
/* ********************************************************************* */
PROMPT("");
PROGRAM = "FL124";
SCREEN_CODE = PROGRAM;
INTERACT = INVALID_DATA;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.DDS.TRANS

if (!OPEN("FL.DDS.TRANS", out FL_DDS_TRANS)) { STOP("201", "FL.DDS.TRANS"); }

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
#region INCLUDE FL.FILES FL.BANK.DETAILS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.DELETED.DEBITS

if (!(OPEN("FL.DELETED.DEBITS", out FL_DELETED_DEBITS))) {
STOP(201, "FL.DELETED.DEBITS");
}
/*  Bank Details lines 1 - 10 */
/*  Direct Debits lines 11 - 30 */
/*  DD Debtors lines 31 - 40 */

#endregion
#region INCLUDE FL.FILES FL.DD.DEBTORS

if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

#endregion
#region INCLUDE FL.FILES FL.BACS.LODGEMENTS
if (!(OPEN("FL.BACS.LODGEMENTS", out FL_BACS_LODGEMENTS))) {

EXECUTE("CREATE-FILE FL.BACS.LODGEMENTS 1 101", MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN("FL.BACS.LODGEMENTS", out FL_BACS_LODGEMENTS))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}

#endregion
#region INCLUDE FL.FILES FL.AUDDIS.LOG
if (!(OPEN("FL.AUDDIS.LOG", out FL_AUDDIS_LOG))) {

EXECUTE("CREATE-FILE FL.AUDDIS.LOG 1 101", MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN("FL.AUDDIS.LOG", out FL_AUDDIS_LOG))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}

#endregion
#region INCLUDE FL.FILES FL.MEMBER.PARAMS

if (!OPEN("FL.MEMBER.PARAMS", out FL_MEMBER_PARAMS)) { STOP("201", "FL.MEMBER.PARAMS"); }

#endregion
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
/* **************************** */
/*  Check for authorised user * */
/* **************************** */
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
/* ************ */
/*  Variables * */
/* ************ */
MAT(ref DIRECT_DEBIT_REC, "");
MAT(ref DELETED_DEBITS_REC, "");
TRANS_TYPE_LIST = "";
TRANS_ADJ_AMOUNTS = "";
TRANS_ADJ_DATES = "";
DATES_CHANGED = FALSE;
UPDATE_DEBTORS = FALSE;
UNCANCELLATION = FALSE;
CANCELLATION_DONE = FALSE;
/*  Read in BACS Control file */
if (!(READ(ref CONTROL_DETS, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
DD_DAY_PARAM = CONTROL_DETS[1];
DAY1_OF_MONTH = DD_DAY_PARAM[1, 1];
DAY2_OF_MONTH = DD_DAY_PARAM[1, 2];
DD_LEEWAY_PARAM = CONTROL_DETS[2];
DATE_LAST_RUN_PARAM = CONTROL_DETS[3];
DD_STAGE_PARAM = CONTROL_DETS[4];
DD_EXP_LEEWAY = CONTROL_DETS[13];
/*  Read in multi-type/sub-fees include params */
if (!(READ(ref MEM_PARAMS_REC, COMMON.FILES[FL_CONTROL], "AUTOMATIC.CONCESS"))) {
MEM_PARAMS_REC = "";
}
MEM_TYPE_LIST = FALSE;
SUB_FEES_INCLUDE = FALSE;
if (MEM_PARAMS_REC[11, 1] == "Y") {
MULTIPLE_TYPES = TRUE;
MEM_TYPE_LIST = TRUE;
SUB_FEES_INCLUDE = TRUE;
} else {
MULTIPLE_TYPES = FALSE;
if (MEM_PARAMS_REC[11, 2] == "Y") {
MEM_TYPE_LIST = TRUE;
}
if (MEM_PARAMS_REC[11, 2] == "S") {
MEM_TYPE_LIST = TRUE;
SUB_FEES_INCLUDE = TRUE;
}
}
if (!(READ(ref PASSWORD_CONTROL, FL_MEMBER_PARAMS, "PASSWORD.CONTROL"))) {
PASSWORD_CONTROL = "";
}
/*  Auddis Logging */
LOG_AUDDIS = FALSE;
if (READ(ref AUDDIS_CONTROL, DFL_DIRECT_DEBITS, "AUDDIS.CONTROL")) {
LOG_AUDDIS = TRUE;
}
/* ************************************ */
/*   Controlling Routine              * */
/* ************************************ */
do {
if (TYPE == COMMON.ABANDON || REFERENCE == COMMON.ABANDON) break;
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref PROGRAM, ref DOTS_ONLY);
L0100();
/*  Get Identifier */
if (TYPE != COMMON.ABANDON && REFERENCE != COMMON.ABANDON) {
L0200();
/*  Display Existing Details */
L0300();
/*  Amend Direct Debit Amounts */
}
} while (true);
return;
/* ************************************************************ */
/*                S U B R O U T I N E S                       * */
/* ************************************************************ */
/* ********************************************** */
}
void L0100() {
/*  Routine to input and validate reference * */
/* ********************************************** */
/*      TYPE = "" */
do {
if (TYPE != "") break;
PRINT(AT(18, 3) + SPACE(2) + AT(18, 3));
LENGTH_OF_INPUT = 2;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
// BEGIN CASE
// CASE
if (ANS == "M") {
/*  Memberships */
TYPE = 1;
}// CASE
else if (ANS == "B") {
/*  Block Bookings */
TYPE = 2;
}// CASE
else if (ANS == "C") {
/*  Courses */
TYPE = 3;
}// CASE
else if (ANS == COMMON.ABANDON) {
TYPE = ANS;
return;
}// CASE
else if (ANS == "") {
TYPE = COMMON.ABANDON;
return;
}// CASE
else if (OTHERWISE) {
TYPE = "";
}
// END CASE
} while (true);
// BEGIN CASE
// CASE
if (TYPE == 1) {
PRINT(AT(18, 3) + "M");
}// CASE
else if (TYPE == 2) {
PRINT(AT(18, 3) + "B");
}// CASE
else if (TYPE == 3) {
PRINT(AT(18, 3) + "C");
}// CASE
else if (OTHERWISE) {
}
// END CASE
/*      REFERENCE = "" */
do {
if (REFERENCE != "") break;
PRINT(AT(36, 3) + SPACE(15) + AT(36, 3));
LENGTH_OF_INPUT = 15;
// BEGIN CASE
// CASE
if (TYPE == 1) {
/*  Members */
MEMBER_REQD = TRUE;
TICKET_REC = "";
RUN_CHECKS = TRUE;
FL103 = new FL103(ref TICKET_REC, ref MEMBER_REQD, ref RUN_CHECKS);
REFERENCE = TICKET_REC[10];
PRINTCR(AT(36, 3) + SPACE(20) + AT(36, 3) + REFERENCE);
if (REFERENCE == "") {
REFERENCE = COMMON.ABANDON;
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "No membership record found ! ");
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
}
}// CASE
else if (TYPE == 2) {
/*  BLOCK BOOKINGS */
FL019 = new FL019(ref LENGTH_OF_INPUT, ref REFERENCE);
}// CASE
else if (TYPE == 3) {
/*  COURSES */
FL019 = new FL019(ref LENGTH_OF_INPUT, ref REFERENCE);
}// CASE
else if (OTHERWISE) {
REFERENCE = COMMON.ABANDON;
}
// END CASE
if (REFERENCE == COMMON.ABANDON) {
return;
}
} while (true);
PRINT(AT(36, 3) + FORMAT(REFERENCE, "L#15"));
// BEGIN CASE
// CASE
if (TYPE == 1) {
if (!(READ(ref MEM_REC, COMMON.FILES[FL_MEMBERS], REFERENCE))) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
REFERENCE = COMMON.ABANDON;
return;
}
NAME = MEM_REC[6, 1] + " " + MEM_REC[5, 1] + " " + MEM_REC[4, 1];
DAY_OF_MONTH = MEM_REC[34];
}// CASE
else if (OTHERWISE) {
NAME = "";
}
// END CASE
/*  Call debit validation and selection box */
FL124_1 = new FL124_1(ref REFERENCE, ref TYPE, ref DEBIT_NUMBER, ref DEBIT_LIST);
if (DEBIT_NUMBER == COMMON.ABANDON) {
TYPE = COMMON.ABANDON;
return;
}
DEBIT_SETS = DCOUNT(DEBIT_LIST, VM);
PRINTCR(AT(0, 10) + NRM_VID + COMMON.EOS);
if (DEBIT_NUMBER == COMMON.ABANDON) { return; }
if (DEBIT_NUMBER == 0) {
DEBIT_NUMBER = 1;
/*  Assume new debit record required */
}
PRINT(AT(78, 22) + NRM_VID + AT(2, 22) + DIM_REV_VID + SPACE(76) + NRM_VID);
/*  Get debit details [called by (N)ext (P)revious] */
WNDO_DATA_POS = 1;
REQUIRED_ID = TYPE + "*" + REFERENCE + "*" + DEBIT_LIST[1, DEBIT_NUMBER];
MATREADU(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], REQUIRED_ID)
nrf0 = 78;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
REFERENCE = COMMON.ABANDON;
return;
} else {
nrf0 = 1;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
REFERENCE = COMMON.ABANDON;
return;
}
/*  Read in any debtors record */
DEBTOR_ID = TYPE + "*" + REFERENCE;
if (!(MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DEBTOR_ID))) {
MAT(ref DD_DEBTORS_REC, "");
}
/*  Status of member */
// BEGIN CASE
// CASE
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
ORIG_DD_STATUS = "CANCELLED";
}// CASE
else if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] <= TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] >= TODAYS_DATE) {
ORIG_DD_STATUS = "FROZEN";
}// CASE
else if (OTHERWISE) {
ORIG_DD_STATUS = "LIVE";
}
// END CASE
/*  Check stage indicator for this record */
OLD_DEBIT_DATES = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES];
if (!(LOCATE(TODAYS_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref POS, "AR"))) {
POS = POS - 1;
}
if (POS == 0) { POS = 1; }
DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS], "D2/").Substring(1, 2);
if (!(LOCATE(DD_DAY, DD_DAY_PARAM, 1, 0, 1, ref POS, "AL"))) {
nrf0 = 50;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
DD_LEEWAY = DD_LEEWAY_PARAM[1, POS];
if (DD_LEEWAY == "") { DD_LEEWAY = 0; }
DATE_LAST_RUN = DATE_LAST_RUN_PARAM[1, POS];
DD_STAGE = DD_STAGE_PARAM[1, POS];
if (DD_STAGE != 1 && DD_STAGE != 3) {
nrf0 = 36;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
/* *********************************************************************** */
}
void L0200() {
/*  Routine to compile display details and set up top part of screen * */
/* *********************************************************************** */
PRINT(AT(52, 3) + NAME);
if (MEM_REC[34] != "") {
PRINT(AT(74, 3) + "(" + MEM_REC[34] + ")");
}
if (!(READV(ref BACS_REF, COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE, 7))) {
BACS_REF = "";
}
if (BACS_REF != "") {
PRINT(AT(36, 4) + BACS_REF);
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "N";
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 2] != "") {
PRINTCR(AT(62, 4) + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 2], "MD2"));
}
/*      PRINT @(15,5):OCONV(DIRECT.DEBIT.ANNUAL.FEE,'MD2'):@(36,5):OCONV(DIRECT.DEBIT.ORIGINAL.DATE,'D2'):@(56,5) : DIRECT.DEBIT.LETTER :@(69,5):OCONV(DIRECT.DEBIT.DEPOSIT<1,1>,'MD2'): */
PRINT(AT(15, 5) + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ANNUAL_FEE], "MD2") + AT(36, 5) + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE], "D2") + AT(36, 6) + DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] + AT(62, 5) + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 1], "MD2"));
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 3] != "N") {
PRINTCR(AT(62, 6) + DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 3]);
}
/* MR!     IF DIRECT.DEBIT.FREEZE.DATE # "" AND DIRECT.DEBIT.FREEZE.DATE<1,1> > DIRECT.DEBIT.DATES<1,DCOUNT(DIRECT.DEBIT.DATES,VM)> THEN */
/* MR!        PRINT @(15,7):DIM.REV.VID:@(15,7):"*****   Frozen from ":OCONV(DIRECT.DEBIT.FREEZE.DATE<1,1>,"D2"):" to ":OCONV(DIRECT.DEBIT.FREEZE.DATE<1,2>,"D2"):"  *****":NRM.VID: */
/* MR!     END */
WINDOW_TEXT_LIST = "";
WNDO_T = 8;
/* TOP COORD */
WNDO_B = 19;
/* BOTTM COORD */
WNDO_L = 1;
/* LEFT COORD */
WNDO_R = 79;
/* RIGHT COORD */
REQD_ITM = 0;
/* USERS REQUIRED ITEM */
UPDATE_REQ = FALSE;
}
void L0250() {
/*  Recompile Display */
TOTAL_AMOUNT = 0;
TOTAL_ADJ = 0;
TOTAL_BAL = 0;
TOTAL_PAID = 0;
POS = 1;
do {
L0500();
POS = POS + 1;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS] == "") break;
} while (true);
/* * display cancellation date if it is outside the range of */
/* * dates displayed */
LAST_DD_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM)];
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] > LAST_DD_DATE) {
PRINT(AT(20, 7) + DIM_REV_VID + AT(20, 7));
PRINT(AT(20, 7) + "** Cancelled from " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE], "D2"));
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] != "") {
PRINTCR(" (" + DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] + ") **");
} else {
PRINTCR(" **");
}
} else {
PRINT(AT(2, 7) + DIM_REV_VID + SPACE(SCREEN_WIDTH - 2));
}
/* * */
LINE_POS = 0;
REQD_ID = 0;
return;
/* ***************** */
}
void L0300() {
/*  Amendments * */
/* ***************** */
EDITING = FALSE;
AMEND_NO = "";
do {
if (AMEND_NO == COMMON.ABANDON || INTERACT == EXIT) break;
FL124_2 = new FL124_2(ref WINDOW_TEXT_LIST, ref WNDO_DATA_POS, ref AMEND_NO, ref PROGRAM);
// BEGIN CASE
// CASE
if (AMEND_NO == "END") {
/*  UPDATE RECORD */
if (UPDATE_REQ) {
if (LOCATE("RE.INSTATE", TRANS_TYPE_LIST, 0, 0, 1, ref POS, "AL")) {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(78) + AT(2, 23));
PRINT(FORMAT("WARNING ! Check membership record to ensure all DD details are correct ", "L#74"));
INPUT(out ANSWER, 1);
PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
}
L2222();
/*  Update Records */
} else {
RELEASE();
}
TYPE = COMMON.ABANDON;
return;
}// CASE
else if (MATCH(AMEND_NO,"0N") && AMEND_NO != "") {
/*  AMEND DEBIT */
EDITING = TRUE;
L0400();
/*  Input and validate adjustment */
}// CASE
else if (AMEND_NO == "I") {
/*  INSERT DEBIT */
EDITING = TRUE;
L0700();
/*  GET AND VALIDATE DATE */
if (NEW_DATE == COMMON.ABANDON || NEW_DATE == "" || VALID_DATE == FALSE) {
goto L0310;
} else {
if (NEW_DATE != "") {
L0800();
/*  GET AMOUNT */
if (NEW_DEBIT_AMOUNT == COMMON.ABANDON || NEW_DEBIT_AMOUNT == "") { goto L0310; }
UPDATE_REQ = TRUE;
}
}
}// CASE
else if (AMEND_NO == "F") {
/*  FREEZE SCHEDULE */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
nrf0 = 30;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
L1200();
/*  Process Freezing of account */
L0250();
/*  Redisplay screen */
}
}// CASE
else if (AMEND_NO == COMMON.ABANDON) {
TYPE = COMMON.ABANDON;
RELEASE();
}// CASE
else if (AMEND_NO == "L") {
PRINT(AT(36, 6) + NRM_VID + "." + AT(36, 6));
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref ANS);
if (ANS == "Y" || ANS == "N" || ANS == "C" || ANS == "F" || ANS == "UF") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = ANS;
UPDATE_REQ = TRUE;
} else {
nrf0 = 9;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINTCR(AT(36, 6) + FORMAT(DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER], "L#2"));
}
}// CASE
else if (AMEND_NO == "S") {
NEW_ORIGINAL_DATE = "";
do {
if (NEW_ORIGINAL_DATE != "") break;
PRINT(AT(36, 5) + NRM_VID + "........." + AT(36, 5));
nrf0 = 11;
FL019 = new FL019(ref nrf0, ref ANS);
if (ANS == COMMON.ABANDON || ANS == "") {
NEW_ORIGINAL_DATE = COMMON.ABANDON;
} else {
NEW_ORIGINAL_DATE = ICONV(ANS, "D");
if (NEW_ORIGINAL_DATE == 0) {
NEW_ORIGINAL_DATE = "";
}
}
} while (true);
if (NEW_ORIGINAL_DATE != COMMON.ABANDON) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE] = NEW_ORIGINAL_DATE;
UPDATE_REQ = TRUE;
}
PRINTCR(AT(36, 5) + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE], "D2"));
}// CASE
else if (AMEND_NO == "C") {
/*  Deal with Cancellations */
/*            IF DIRECT.DEBIT.FREEZE.DATE # "" THEN */
/*               CALL FL006(PROGRAM,31,"") ; * Cant cancel a frozen schedule */
/*            END ELSE */
L0900();
/*  Cancellations */
L0250();
/*  Display it */
/*            END */
}// CASE
else if (AMEND_NO == "D") {
/*  Change Member's chosen DD day */
if (DD_DAY_PARAM[1, 2] == "") {
nrf0 = 37;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
if (MEM_REC[34] == "") {
CHOSEN_DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1], "DD");
} else {
CHOSEN_DD_DAY = MEM_REC[34];
}
if (CHOSEN_DD_DAY == DAY1_OF_MONTH) {
ALTERNATE_DAY = DAY2_OF_MONTH;
} else {
ALTERNATE_DAY = DAY1_OF_MONTH;
}
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "DD Day is currently set to " + CHOSEN_DD_DAY);
PRINT(" - change to " + ALTERNATE_DAY + " ? (Y/N) ");
INPUT(out CHANGE_DAY, 2);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
if (CHANGE_DAY == "Y") {
MEM_REC[34] = ALTERNATE_DAY;
UPDATE_REQ = TRUE;
PRINT(AT(74, 3) + "(" + MEM_REC[34] + ")");
TRANS_TYPE_LIST[1, -1] = "CHOSEN DAY NOW " + ALTERNATE_DAY;
}
}
}// CASE
else if (AMEND_NO.Substring(1, 1) == "D") {
if (DD_DAY_PARAM[1, 2] == "") {
nrf0 = 6;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
if (LEN(AMEND_NO) > 1) {
AMEND_NO = AMEND_NO.Substring(2, 99);
if (AMEND_NO == COMMON.ABANDON) { AMEND_NO = ""; }
if (AMEND_NO < 1 && AMEND_NO != "*") {
nrf0 = 17;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
goto L0310;
}
} else {
PRINT(AT(20, 20) + "Enter Line No ");
INPUTCR(out AMEND_NO);
if (AMEND_NO == COMMON.ABANDON) { AMEND_NO = ""; }
if (AMEND_NO < 1 && AMEND_NO != "*") {
nrf0 = 46;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
goto L0310;
}
}
L1000();
/*  Change date */
UPDATE_REQ = TRUE;
}
}// CASE
else if (OTHERWISE) {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
L0310:;
if (AMEND_NO != "L") { L1600(); /*  display letter status */ }
} while (true);
return;
/* ************************** */
}
void L0400() {
/*  Process Adjustments * */
/* ************************** */
/*  Cannot adjust past date unless its rejected */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] <= TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != 0 && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != "") {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust premium that has been requested from BACS */
DAY_OF_PREMIUM = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO], "DD");
if (!(LOCATE(DAY_OF_PREMIUM, DD_DAY_PARAM, 1, 0, 1, ref PNTR, "AL"))) {
nrf0 = 41;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
STAGE_OF_PREMIUM = DD_STAGE_PARAM[1, PNTR];
LAST_RUN = DATE_LAST_RUN_PARAM[1, PNTR];
if (STAGE_OF_PREMIUM == 2 && DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] == LAST_RUN) {
nrf0 = 42;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust rejected premium thats been written off/paid manually */
BALANCE = DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, AMEND_NO] + DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, AMEND_NO];
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] == 0 && BALANCE == 0) {
nrf0 = 34;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust a paid premium (unless its rejected) */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != 0) {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust non-existent request */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] == "") {
nrf0 = 16;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust a cancelled schedule */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] <= DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO]) {
nrf0 = 28;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  Cannot adjust a frozen schedule */
/* MR!     IF DIRECT.DEBIT.FREEZE.DATE NE "" AND DIRECT.DEBIT.FREEZE.DATE<1,1> <= DIRECT.DEBIT.DATES<1,AMEND.NO> AND DIRECT.DEBIT.FREEZE.DATE<1,2> >= DIRECT.DEBIT.DATES<1,AMEND.NO> THEN */
/* MR!        CALL FL006(PROGRAM,29,"") */
/* MR!        RETURN */
/* MR!      END */
REJECTION_ADJUSTMENT = FALSE;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] == 0) {
REJECTION_ADJUSTMENT = TRUE;
}
LINE_POS = 9 + (AMEND_NO - WNDO_DATA_POS);
POS = AMEND_NO;
ADJ_AMOUNT = "";
ADJ_TYPE = "";
VALID_AMOUNT = FALSE;
VALID_TYPE = FALSE;
do {
PRINT(AT(63, LINE_POS) + DIM_REV_UND_VID + SPACE(8) + AT(63, LINE_POS));
INPUT_LENGTH = 8;
FL019 = new FL019(ref INPUT_LENGTH, ref ADJ_AMOUNT);
// BEGIN CASE
// CASE
if (ADJ_AMOUNT == COMMON.ABANDON) {
DONE = TRUE;
return;
}// CASE
else if (NUM(ADJ_AMOUNT) == FALSE) {
nrf0 = 15;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ADJ_AMOUNT == "") {
VALID_AMOUNT = TRUE;
}// CASE
else if (ADJ_AMOUNT >= 0 && REJECTION_ADJUSTMENT) {
nrf0 = 35;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ADJ_AMOUNT <= 1000 && ADJ_AMOUNT >= -1000) {
VALID_AMOUNT = TRUE;
}// CASE
else if (OTHERWISE) {
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
if (VALID_AMOUNT) break;
} while (true);
if (ADJ_AMOUNT == "") { return; }
UPDATE_REQ = TRUE;
ADJ_AMOUNT = INT(ADJ_AMOUNT * 100);
do {
PRINT(AT(73, LINE_POS) + DIM_REV_UND_VID + SPACE(4) + AT(73, LINE_POS));
INPUT_LENGTH = 3;
FL019 = new FL019(ref INPUT_LENGTH, ref ADJ_TYPE);
// BEGIN CASE
// CASE
if (ADJ_TYPE == COMMON.ABANDON) {
DONE = TRUE;
return;
}// CASE
else if (ADJ_TYPE == "FZ") {
nrf0 = 26;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ADJ_TYPE == "WO" || ADJ_TYPE == "PM") {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != 0) {
nrf0 = 32;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
VALID_TYPE = TRUE;
}
}// CASE
else if (ADJ_TYPE != "WO" && ADJ_TYPE != "PM") {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] == 0) {
nrf0 = 33;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
VALID_TYPE = TRUE;
}
}// CASE
else if (OTHERWISE) {
VALID_TYPE = TRUE;
}
// END CASE
if (VALID_TYPE) break;
} while (true);
DEBIT_BAL = DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, AMEND_NO] + DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, AMEND_NO];
if (DEBIT_BAL + ADJ_AMOUNT >= 0) {
if (ADJ_TYPE == "WO" || ADJ_TYPE == "PM" && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] == 0) {
UPDATE_DEBTORS = TRUE;
if (LOCATE(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO], DD_DEBTORS_REC[DD_DEBTORS_DATES], 1, 0, 1, ref PNTR, "AR")) {
DD_DEBTORS_REC[DD_DEBTORS_TOTAL_OWED] = DD_DEBTORS_REC[DD_DEBTORS_TOTAL_OWED] + ADJ_AMOUNT;
REMAINDER = DD_DEBTORS_REC[DD_DEBTORS_OWED][1, PNTR] + ADJ_AMOUNT;
if (REMAINDER == 0) {
DD_DEBTORS_REC[DD_DEBTORS_DATES] = DELETE(DD_DEBTORS_REC[DD_DEBTORS_DATES], 1, PNTR);
DD_DEBTORS_REC[DD_DEBTORS_OWED] = DELETE(DD_DEBTORS_REC[DD_DEBTORS_OWED], 1, PNTR);
} else {
DD_DEBTORS_REC[DD_DEBTORS_OWED][1, PNTR] = REMAINDER;
}
}
VALID_EXPIRY = FALSE;
do {
if (VALID_EXPIRY) break;
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Member's current Expiry Date " + OCONV(MEM_REC[13], "D"));
PRINT(AT(31, 23));
INPUT(out NEW_MEM_EXPIRY, 12);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
// BEGIN CASE
// CASE
if (NEW_MEM_EXPIRY == "") {
NEW_MEM_EXPIRY = MEM_REC[13];
VALID_EXPIRY = TRUE;
}// CASE
else if (NEW_MEM_EXPIRY == COMMON.ABANDON) {
NEW_MEM_EXPIRY = MEM_REC[13];
VALID_EXPIRY = TRUE;
}// CASE
else if (OTHERWISE) {
NEW_MEM_EXPIRY = ICONV(NEW_MEM_EXPIRY, "D");
if (NEW_MEM_EXPIRY == "") {
VALID_EXPIRY = FALSE;
} else {
VALID_EXPIRY = TRUE;
}
}
// END CASE
} while (true);
MEM_REC[13] = NEW_MEM_EXPIRY;
}
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, AMEND_NO] = DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, AMEND_NO] + ADJ_AMOUNT;
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, AMEND_NO] = ADJ_TYPE;
TOTAL_ADJ = TOTAL_ADJ + ADJ_AMOUNT;
TOTAL_BAL = TOTAL_BAL + ADJ_AMOUNT;
PRINT(AT(63, LINE_POS) + FORMAT(OCONV(ADJ_AMOUNT, "MD2"), "R#8") + NRM_VID);
L0500();
/*   DISPLAY LINE DETAILS */
TRANS_ADJ_AMOUNTS[1, -1] = ADJ_AMOUNT;
TRANS_ADJ_DATES[1, -1] = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO];
TRANS_TYPE_LIST[1, -1] = "ADJ - " + ADJ_TYPE;
} else {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
/* ******************* */
}
void L2222() {
/*  Update Files * */
/* ******************* */
/* GOSUB 1600 */
DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] = DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] + 1;
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], REQUIRED_ID);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], REQUIRED_ID)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REQUIRED_ID);
}
TRANS_ID = REQUIRED_ID + "*" + DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT];
MAT(ref TRANS_REC, "");
TRANS_REC[TRANS_DATE] = TODAYS_DATE;
TRANS_REC[TRANS_USER] = U_INITS;
/*  CHANGED TRANS LOG TO TAKE INDIVIDUAL ADJUSTMENT AMOUNT AND AFFECTED DATE */
/*      TRANS.ADJ = DIRECT.DEBIT.ADJ */
TRANS_REC[TRANS_ADJ] = TRANS_ADJ_AMOUNTS;
TRANS_REC[TRANS_DATES] = TRANS_ADJ_DATES;
TRANS_REC[TRANS_TYPE] = TRANS_TYPE_LIST;
MATWRITE(TRANS_REC, FL_DDS_TRANS, TRANS_ID);
if (READ(ref TRANS_LOG_REC, FL_DDS_TRANS, TRANS_ID)) {
nrf0 = "W";
nrf1 = "FL.DDS.TRANS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TRANS_ID);
}
if (LOG_AUDDIS) { L0600(); /*  Update AUDDIS files */ }
if (UPDATE_DEBTORS) {
if (DD_EXP_LEEWAY != "" && DD_EXP_LEEWAY[1, 1] == "*" && NUM(DD_EXP_LEEWAY)) {
CARD_COUNT = DCOUNT(MEM_REC[2], VM);
for(CARD = 1; CARD <= CARD_COUNT; CARD += 1) {
/*               IF MEM.REC<39,CARD> = "Y" THEN */
if (MEM_REC[39, CARD] == "Y" || MEM_REC[39] == "") {
MEM_REC[13, CARD] = TODAYS_DATE + DD_EXP_LEEWAY;
}
}
}
}
WRITE(MEM_REC, COMMON.FILES[FL_MEMBERS], REFERENCE);
TRANS_LOG_REC = MEM_REC;
nrf0 = "W";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REFERENCE);
if (DD_DEBTORS_REC[DD_DEBTORS_DATES] == "" && UPDATE_DEBTORS == TRUE) {
DELETE(FL_DD_DEBTORS, DEBTOR_ID);
nrf0 = "D";
nrf1 = "FL.DD.DEBTORS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DEBTOR_ID);
}
if (DD_DEBTORS_REC[DD_DEBTORS_DATES] != "" && UPDATE_DEBTORS == TRUE) {
MATWRITE(DD_DEBTORS_REC, FL_DD_DEBTORS, DEBTOR_ID);
if (READ(ref TRANS_LOG_REC, FL_DD_DEBTORS, DEBTOR_ID)) {
nrf0 = "W";
nrf1 = "FL.DD.DEBTORS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DEBTOR_ID);
}
}
return;
/* ************************* */
}
void L0500() {
/*  Print Details Line * */
/* ************************* */
// BEGIN CASE
// CASE
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] <= DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS]) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] != "") {
WINDOW_TEXT_LIST[1, POS] = FORMAT(POS, "L#3") + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS], "D2") + " ** Cancelled from " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE], "D2") + " (" + DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] + ") **";
} else {
WINDOW_TEXT_LIST[1, POS] = FORMAT(POS, "L#3") + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS], "D2") + " ** Cancelled from " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE], "D2") + " **";
}
/* MR!     CASE DIRECT.DEBIT.FREEZE.DATE # "" AND DIRECT.DEBIT.FREEZE.DATE<1,1> <= DIRECT.DEBIT.DATES<1,POS> AND DIRECT.DEBIT.FREEZE.DATE<1,2> >= DIRECT.DEBIT.DATES<1,POS> */
/* MR!        WINDOW.TEXT.LIST<1,POS> = POS "L#3" : OCONV(DIRECT.DEBIT.DATES<1,POS>,"D2") : " ** Frozen ** from " :OCONV(DIRECT.DEBIT.FREEZE.DATE<1,1>,"D2"):" to ":OCONV(DIRECT.DEBIT.FREEZE.DATE<1,2>,"D2") */
}// CASE
else if (OTHERWISE) {
DEBIT_BAL = DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, POS] + DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, POS];
WINDOW_TEXT_LINE = FORMAT(POS, "L#3") + FORMAT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, POS], "D2"), "L#10");
WINDOW_TEXT_LINE = WINDOW_TEXT_LINE + FORMAT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, POS], "MD2"), "R#8") + FORMAT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, POS], "MD2"), "R#12") + SPACE(2) + FORMAT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, POS], "L#4") + SPACE(2) + FORMAT(OCONV(DEBIT_BAL, "MD2"), "R#8");
WINDOW_TEXT_LINE = WINDOW_TEXT_LINE + FORMAT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, POS], "MD2"), "R#8");
WINDOW_TEXT_LIST[1, POS] = WINDOW_TEXT_LINE;
TOTAL_AMOUNT = TOTAL_AMOUNT + DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, POS];
TOTAL_ADJ = TOTAL_ADJ + DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, POS];
TOTAL_BAL = TOTAL_BAL + DEBIT_BAL;
TOTAL_PAID = TOTAL_PAID + DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, POS];
}
// END CASE
return;
/* ************************** */
}
void L0600() {
/*  Update AUDDIS files * */
/* ************************** */
if (CANCELLATION_DONE) {
if (MATREAD(ref AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE)) {
if (READ(ref LODGE_CONTROL_REC, FL_BACS_LODGEMENTS, REFERENCE)) {
LAST_LODGE_DATE = LODGE_CONTROL_REC[1];
if (MATREAD(ref BACS_LODGEMENTS_REC, FL_BACS_LODGEMENTS, REFERENCE + "*" + LAST_LODGE_DATE)) {
if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] != "0C") {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BACS_LODGEMENTS_REC[BACS_LODGEMENTS_SORTCODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BACS_LODGEMENTS_REC[BACS_LODGEMENTS_BANKNAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE);
}
}
} else {
/*  (no entry in BACS LODGEMENTS) */
DELETE(FL_AUDDIS_LOG, REFERENCE);
/*  (remove entry from AUDDIS LOG if cancel'tn done - still unlodged DD) */
}
} else {
/*  (no entry in AUDDIS LOG) */
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE)) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE);
}
}
}
if (UNCANCELLATION == TRUE) {
if (READ(ref LODGE_CONTROL_REC, FL_BACS_LODGEMENTS, REFERENCE)) {
LAST_LODGE_DATE = LODGE_CONTROL_REC[1];
if (MATREAD(ref BACS_LODGEMENTS_REC, FL_BACS_LODGEMENTS, REFERENCE + "*" + LAST_LODGE_DATE)) {
// BEGIN CASE
// CASE
if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0C") {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE)) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE);
WRITEV("01", COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE, 6);
}
}// CASE
else if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0N" || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0C/0N") {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE)) {
if (BANK_REC[BANK_SORT_CODE] != BACS_LODGEMENTS_REC[BACS_LODGEMENTS_SORTCODE] || BANK_REC[BANK_ACCOUNT_NO] != BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNO]) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C/0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE);
}
}
}
// END CASE
}
} else {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE)) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, REFERENCE);
WRITEV("01", COMMON.FILES[FL_BANK_DETAILS], "1*" + REFERENCE, 6);
}
}
}
return;
/* **************************************** */
}
void L0700() {
/*  Routine to insert instalment date * */
/* **************************************** */
VALID_DATE = FALSE;
do {
if (VALID_DATE) break;
PRINT(AT(55, 18) + DIM_REV_VID + "Date : ");
INPUT_LENGTH = 12;
FL019 = new FL019(ref INPUT_LENGTH, ref NEW_DATE);
if (NEW_DATE == COMMON.ABANDON || NEW_DATE == "") { return; }
NEW_DATE = ICONV(NEW_DATE, "D2");
if (NEW_DATE == "") {
nrf0 = 25;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
VALID_DATE = FALSE;
goto L0750;
}
NEW_DD_DAY = OCONV(NEW_DATE, "DD");
if (LOCATE(NEW_DD_DAY, DD_DAY_PARAM, 1, 0, 1, ref POS, "AL")) {
VALID_DATE = TRUE;
THIS_DAYS_LEEWAY = DD_LEEWAY_PARAM[1, POS];
THIS_DAYS_LAST_RUN = DATE_LAST_RUN_PARAM[1, POS];
THIS_DAYS_STAGE = DD_STAGE_PARAM[1, POS];
NEW_DD_MONTH = OCONV(NEW_DATE, "DM");
NEW_DD_YEAR = OCONV(NEW_DATE, "DY");
NEW_DD_MONTH = NEW_DD_MONTH + 1;
if (NEW_DD_MONTH > 12) {
NEW_DD_MONTH = 1;
NEW_DD_YEAR = NEW_DD_YEAR + 1;
}
THIS_DAYS_NEXT_RUN = NEW_DD_DAY + "/" + NEW_DD_MONTH + "/" + NEW_DD_YEAR;
THIS_DAYS_NEXT_RUN = ICONV(THIS_DAYS_NEXT_RUN, "D2");
TOTAL_DATES = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
FIRST_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1];
LAST_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, TOTAL_DATES];
// BEGIN CASE
// CASE
if (NEW_DATE <= TODAYS_DATE) {
VALID_DATE = FALSE;
nrf0 = 21;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
/*            CASE NEW.DATE >= FIRST.DATE AND NEW.DATE <= LAST.DATE */
/*               VALID.DATE = FALSE */
/*               CALL FL006(PROGRAM,22,''); * Must insert at beginning or end */
}// CASE
else if (NEW_DATE < THIS_DAYS_LAST_RUN) {
VALID_DATE = FALSE;
nrf0 = 23;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (NEW_DATE == THIS_DAYS_LAST_RUN) {
if (THIS_DAYS_STAGE != 1) {
VALID_DATE = FALSE;
nrf0 = 24;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
MESS = "DD List has already been prepared for ";
MESS = MESS + OCONV(THIS_DAYS_LAST_RUN, "D2");
MESS = MESS + " Continue ? (Y/N) ";
PRINT(FORMAT(MESS, "L#74"));
INPUT(out CONTINUE, 2);
PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
if (CONTINUE != "Y") {
VALID_DATE = FALSE;
} else {
VALID_DATE = TRUE;
}
}
}// CASE
else if (NEW_DATE > THIS_DAYS_LAST_RUN) {
if (NEW_DATE - TODAYS_DATE < THIS_DAYS_LEEWAY) {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(FORMAT("New date is within the leeway for the next run Continue ? (Y/N) ", "L#74"));
INPUT(out CONTINUE, 2);
PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
if (CONTINUE != "Y") {
VALID_DATE = FALSE;
} else {
VALID_DATE = TRUE;
}
} else {
VALID_DATE = TRUE;
}
}// CASE
else if (OTHERWISE) {
}
// END CASE
} else {
VALID_DATE = FALSE;
}
if (VALID_DATE) {
if (LOCATE(NEW_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref NEW_DEBIT_POS, "AR")) {
VALID_DATE = FALSE;
NEW_DATE = "";
}
}
L0750:;
} while (true);
return;
/* *************************************** */
}
void L0800() {
/*  Get debit amount for added input * */
/* *************************************** */
NEW_DEBIT_AMOUNT = 0;
PRINTCR(AT(55, 18) + DIM_REV_VID + "On         : " + FORMAT(OCONV(NEW_DATE, "D4/"), "R#10"));
PRINT(AT(55, 19) + DIM_REV_VID + "Take (Amt) : ");
NEW_DEBIT_AMOUNT = DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT];
PRINTCR(AT(68, 19) + OCONV(NEW_DEBIT_AMOUNT, "MD2"));
PRINT(AT(68, 19));
INPUT_LENGTH = 9;
FL019 = new FL019(ref INPUT_LENGTH, ref NEW_DEBIT_AMOUNT);
// BEGIN CASE
// CASE
if (NEW_DEBIT_AMOUNT == "") {
NEW_DEBIT_AMOUNT = DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT];
}// CASE
else if (NEW_DEBIT_AMOUNT > 1000000) {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}// CASE
else if (NEW_DEBIT_AMOUNT == COMMON.ABANDON) {
AMEND_NO = COMMON.ABANDON;
return;
}// CASE
else if (OTHERWISE) {
NEW_DEBIT_AMOUNT = ICONV(NEW_DEBIT_AMOUNT, "MD2");
}
// END CASE
if (NEW_DEBIT_AMOUNT != DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT]) {
PRINT(AT(55, 20) + DIM_REV_VID + "Adjust all (Y/N) ? ");
INPUT_LENGTH = 2;
FL019 = new FL019(ref INPUT_LENGTH, ref ADJUST_ALL);
if (ADJUST_ALL == "Y" || ADJUST_ALL == "y") {
ADJUST_ALL = TRUE;
} else {
ADJUST_ALL = FALSE;
}
} else {
ADJUST_ALL = TRUE;
}
PRINT(NRM_VID);
if (NEW_DATE > LAST_DATE) {
NEXT_DATE = LAST_DATE;
do {
NEXT_DATES_MONTH = OCONV(NEXT_DATE, "DM");
NEXT_DATES_YEAR = OCONV(NEXT_DATE, "DY");
NEXT_DATES_MONTH = NEXT_DATES_MONTH + 1;
if (NEXT_DATES_MONTH > 12) {
NEXT_DATES_MONTH = 1;
NEXT_DATES_YEAR = NEXT_DATES_YEAR + 1;
}
NEXT_DATE = NEW_DD_DAY + "/" + NEXT_DATES_MONTH + "/" + NEXT_DATES_YEAR;
NEXT_DATE = ICONV(NEXT_DATE, "D2");
if (!(LOCATE(NEXT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref NEXT_DEBIT_POS, "AR"))) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, NEXT_DEBIT_POS, 0, NEXT_DATE);
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID], 1, NEXT_DEBIT_POS, 0, "");
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ], 1, NEXT_DEBIT_POS, 0, "");
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE], 1, NEXT_DEBIT_POS, 0, "");
if (NEXT_DATE != NEW_DATE && NOT(ADJUST_ALL)) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS], 1, NEXT_DEBIT_POS, 0, DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT]);
} else {
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS], 1, NEXT_DEBIT_POS, 0, NEW_DEBIT_AMOUNT);
}
}
if (NEXT_DATE == NEW_DATE) break;
} while (true);
} else {
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS], 1, NEW_DEBIT_POS, 0, NEW_DEBIT_AMOUNT);
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, NEW_DEBIT_POS, 0, NEW_DATE);
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID], 1, NEW_DEBIT_POS, 0, "");
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ], 1, NEW_DEBIT_POS, 0, "");
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE] = INSERT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE], 1, NEW_DEBIT_POS, 0, "");
}
TRANS_ADJ_DATES[1, -1] = NEW_DATE;
TRANS_ADJ_AMOUNTS[1, -1] = NEW_DEBIT_AMOUNT;
TRANS_TYPE_LIST[1, -1] = "INSERTION";
L0200();
DISPLAY
return;
/* ************************************* */
}
void L0900() {
/*  Direct Debit Cancellation Date * */
/* ************************************* */
VALID_DATE = FALSE;
do {
if (VALID_DATE == TRUE) break;
PRINT(AT(2, 21) + UND_VID + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(5, 21) + "Please enter cancellation date : ");
nrf0 = 11;
FL019 = new FL019(ref nrf0, ref ANS);
PRINT(NRM_VID);
// BEGIN CASE
// CASE
if (ANS == "" || ANS == COMMON.ABANDON) {
VALID_DATE = TRUE;
return;
}// CASE
else if (ANS == COMMON.CLR) {
/*  Uncancel direct debit */
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] = "";
VALID_DATE = TRUE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] = "";
UPDATE_REQ = TRUE;
TRANS_TYPE_LIST[1, -1] = "UNCANCEL";
CANCELLATION_DONE = FALSE;
UNCANCELLATION = TRUE;
MEM_REC[28] = "Y";
MEM_REC[24] = DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER];
MEM_REC[34] = DD_DAY;
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE + SPACE(SCREEN_WIDTH - 2));
PRINTCR(AT(2, 23) + "You MUST renew the Membership to calculate the Debits");
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
return;
}// CASE
else if (OTHERWISE) {
/*  Cancel direct debit */
IDATE = ICONV(ANS, "D2");
/*  deal with frozen schedule */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] != "" && IDATE <= DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2]) {
nrf0 = 52;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ANS = "";
return;
}
if (IDATE < TODAYS_DATE) {
// BEGIN CASE
// CASE
if (PASSWORD_CONTROL[13, 1] != "*" && PASSWORD_CONTROL[13] != "" && PASSWORD_CONTROL[13] != "Y" && PASSWORD_CONTROL[13] != "N") {
PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Enter Password for back-dated cancellation date ");
ECHO_OFF();
INPUT(out SP_PASS, 20);
ECHO_ON();
/*               PRINT @(2,23):SCREEN.FOOT.FORE:SCREEN.FOOT.BACK: */
PRINT(AT(2, 23) + NRM_VID);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
if (SP_PASS != PASSWORD_CONTROL[13]) {
PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Invalid password ");
INPUT(out WAIT, 1);
PRINT(SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
VALID_DATE = FALSE;
} else {
VALID_DATE = TRUE;
}
}// CASE
else if (PASSWORD_CONTROL[13] == "" || PASSWORD_CONTROL[13] == "N") {
PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Cannot enter back-dated cancellation date ! ");
INPUT(out WAIT, 1);
PRINT(SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
VALID_DATE = FALSE;
}// CASE
else if (PASSWORD_CONTROL[13] == "Y") {
VALID_DATE = TRUE;
}
// END CASE
} else {
VALID_DATE = TRUE;
}
}
// END CASE
} while (true);
PRINT(AT(5, 21) + UND_VID + SPACE(70));
PRINT(AT(5, 21) + "Enter cancellation reason : ");
nrf0 = 20;
FL019 = new FL019(ref nrf0, ref REASON);
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] = IDATE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] = REASON;
UPDATE_REQ = TRUE;
TRANS_TYPE_LIST[1, -1] = "CANCEL";
MEM_REC[28] = "N";
MEM_REC[24] = "";
CANCELLATION_DONE = TRUE;
UNCANCELLATION = FALSE;
/*  expire membership */
NEW_EXPIRY_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE];
EXPIRE_QUERY = "Do you also want to expire the membership ? (Y/N) ";
EXPIRE_MESSAGE = "Membership Expiry set to Cancellation Date ";
L1500();
/*  deal with membership expiry */
/* * turn following code into subroutine 1500 */
/* * PRINT @(2,23):ERR.MESS.BACK:ERR.MESS.FORE: */
/* * PRINT SPACE(SCREEN.WIDTH - 2):@(2,23): */
/* * PRINT "Do you also want to expire the membership ? (Y/N) ": */
/* * INPUT ANSWER,2: */
/* * PRINT @(2,23):SCREEN.BACK:SCREEN.TEXT:CLR.ERR: */
/* * IF ANSWER = "Y" OR ANSWER = "y" THEN */
/* *   VALID.EXPIRY = FALSE */
/* *   LOOP */
/* *      UNTIL VALID.EXPIRY DO */
/* *      PRINT @(2,23):ERR.MESS.BACK:ERR.MESS.FORE: */
/* *      PRINT SPACE(SCREEN.WIDTH - 2):@(2,23): */
/* *      PRINT @(2,23):'Enter Expiry Date : ':OCONV(DIRECT.DEBIT.CANCELLED.DATE,'D'): */
/* *      PRINT @(22,23): */
/* *      INPUT MEM.EXP.DATE,12: */
/* *      PRINT @(2,23):SCREEN.BACK:CLR.ERR: */
/* *      BEGIN CASE */
/* *      CASE MEM.EXP.DATE = ABANDON */
/* *         PRINT @(2,23):ERR.MESS.BACK:ERR.MESS.FORE: */
/* *         PRINT SPACE(SCREEN.WIDTH - 2):@(2,23): */
/* *         PRINT @(2,23):'Membership Expiry set to Cancellation Date ':OCONV(DIRECT.DEBIT.CANCELLED.DATE,'D'): */
/* *         INPUT WAIT,1: */
/* *         PRINT @(2,23):SCREEN.BACK:CLR.ERR: */
/* *         VALID.EXPIRY = TRUE */
/* *         MEM.EXP.DATE = DIRECT.DEBIT.CANCELLED.DATE */
/* *      CASE MEM.EXP.DATE = "" */
/* *         MEM.EXP.DATE = DIRECT.DEBIT.CANCELLED.DATE */
/* *         VALID.EXPIRY = TRUE */
/* *      CASE OTHERWISE */
/* *         MEM.EXP.DATE = ICONV(MEM.EXP.DATE,'D') */
/* *         IF MEM.EXP.DATE = "" THEN */
/* *            PRINT @(2,23):ERR.MESS.BACK:ERR.MESS.FORE: */
/* *            PRINT SPACE(SCREEN.WIDTH - 2):@(2,23): */
/* *            PRINT @(2,23):'Invalid Expiry Date ! ': */
/* *            INPUT WAIT,1: */
/* *            PRINT @(2,23):SCREEN.BACK:CLR.ERR: */
/* *            VALID.EXPIRY = FALSE */
/* *         END ELSE */
/* *            O.MEM.EXP.DATE = OCONV(MEM.EXP.DATE,'D') */
/* *            VALID.EXPIRY = TRUE */
/* *         END */
/* *      END CASE */
/* *   REPEAT */
/* *   IF NOT(MULTIPLE.TYPES) THEN */
/* *      MEM.REC<13> = MEM.EXP.DATE */
/* *   END ELSE */
/* *      TOTAL.TYPES = DCOUNT(MEM.REC<2>,VM) */
/* *      FOR EACH.TYPE = 1 TO TOTAL.TYPES */
/* * !           IF MEM.REC<39,EACH.TYPE> = "Y" THEN */
/* *         IF MEM.REC<39,EACH.TYPE> = "Y" OR MEM.REC<39> = "" THEN */
/* *            MEM.REC<13,EACH.TYPE> = MEM.EXP.DATE */
/* *         END */
/* *      NEXT TOTAL.TYPES */
/* *   END */
/* * END */
/* END CASE */
return;
/* *************************** */
}
void L1000() {
/*   Process Date change * */
/* *************************** */
TOTAL_DATES = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
// BEGIN CASE
// CASE
if (AMEND_NO.Substring(1, 1) == "*") {
DATES_TO_AMEND = "ALL";
/*  Check all dates can be legitimately changed */
if (!LOCATE(TODAYS_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref START_POS, "AR")) { NULL(); }
if (START_POS == 0) { START_POS = 1; }
if (START_POS > TOTAL_DATES) {
nrf0 = 18;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
DONE = FALSE;
INVALID_PROCEDURE = FALSE;
EACH_DATE = START_POS;
do {
if (DONE) break;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE] <= TODAYS_DATE) {
INVALID_PROCEDURE = TRUE;
DONE = TRUE;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE] <= DATE_LAST_RUN_PARAM[1, 1]) {
INVALID_PROCEDURE = TRUE;
DONE = TRUE;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE] <= DATE_LAST_RUN_PARAM[1, 2]) {
INVALID_PROCEDURE = TRUE;
DONE = TRUE;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, EACH_DATE] != "") {
INVALID_PROCEDURE = TRUE;
DONE = TRUE;
}
EACH_DATE = EACH_DATE + 1;
if (EACH_DATE == TOTAL_DATES + 1) { DONE = TRUE; }
} while (true);
if (INVALID_PROCEDURE) {
nrf0 = 38;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
L1100();
MONTH = OCONV(NEW_DEBIT_DATE, "DM");
YEAR = OCONV(NEW_DEBIT_DATE, "DY");
for(INST = START_POS; INST <= TOTAL_DATES; INST += 1) {
if (INST != START_POS) {
DAY_OF_MONTH = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, INST], "DD");
if (DAY_OF_MONTH == DAY1_OF_MONTH) {
DAY_OF_MONTH = DAY2_OF_MONTH;
} else {
DAY_OF_MONTH = DAY1_OF_MONTH;
}
}
DEBIT_DATE = DAY_OF_MONTH + "/" + MONTH + "/" + YEAR;
DEBIT_DATE = ICONV(DEBIT_DATE, "D2/");
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, INST] = DEBIT_DATE;
TRANS_ADJ_DATES[1, -1] = DEBIT_DATE;
TRANS_TYPE_LIST[1, -1] = "ALL.DATE.CHG";
LINE_POS = 9 + (INST - WNDO_DATA_POS);
POS = INST;
L0500();
MONTH = MONTH + 12 / DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER];
if (MONTH > 12) {
MONTH = MOD(MONTH, 12);
YEAR = YEAR + 1;
}
}
}// CASE
else if (NUM(AMEND_NO)) {
DATES_TO_AMEND = "ONE.DATE";
DATE_POS = "AMEND.NO";
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] <= TODAYS_DATE) {
nrf0 = 47;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, AMEND_NO] != "") {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] == "") {
nrf0 = 16;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] <= DATE_LAST_RUN_PARAM[1, 1]) {
nrf0 = 39;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] <= DATE_LAST_RUN_PARAM[1, 2]) {
nrf0 = 40;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
START_POS = AMEND_NO;
L1100();
/*  Check if new date already exists */
NEW_DAY = OCONV(NEW_DEBIT_DATE, "DD");
NEW_MONTH = OCONV(NEW_DEBIT_DATE, "DM");
NEW_YEAR = OCONV(NEW_DEBIT_DATE, "DY");
START_OF_REST = START_POS + 1;
for(EACH_DATE = START_OF_REST; EACH_DATE <= TOTAL_DATES; EACH_DATE += 1) {
THIS_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE], "DD");
THIS_MONTH = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE], "DM");
THIS_YEAR = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE], "DY");
if (NEW_MONTH == THIS_MONTH) {
THIS_MONTH = THIS_MONTH + 1;
if (THIS_MONTH > 12) {
THIS_MONTH = 1;
THIS_YEAR = THIS_YEAR + 1;
}
THIS_DATE = THIS_DAY + "/" + THIS_MONTH + "/" + THIS_YEAR;
THIS_DATE = ICONV(THIS_DATE, "D");
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, EACH_DATE] = THIS_DATE;
LINE_POS = 9 + (EACH_DATE - WNDO_DATA_POS);
POS = EACH_DATE;
L0500();
NEW_MONTH = THIS_MONTH;
}
}
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, AMEND_NO] = NEW_DEBIT_DATE;
LINE_POS = 9 + (AMEND_NO - WNDO_DATA_POS);
POS = AMEND_NO;
L0500();
TRANS_ADJ_DATES[1, -1] = NEW_DEBIT_DATE;
TRANS_TYPE_LIST[1, -1] = "SGL.DATE.CHG";
}// CASE
else if (OTHERWISE) {
nrf0 = 20;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
return;
/* *************************************************** */
}
void L1100() {
/*  Calculate start date for Date Change routine * */
/* *************************************************** */
START_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, START_POS];
DAY = OCONV(START_DATE, "DD");
MONTH = OCONV(START_DATE, "DM");
/*      IF DATES.TO.AMEND = "ALL" THEN MONTH = MONTH - 1 */
YEAR = OCONV(START_DATE, "DY");
if (DAY == DAY1_OF_MONTH) {
DAY = DAY2_OF_MONTH;
} else {
DAY = DAY1_OF_MONTH;
}
TRANSFER_DATE = DAY + "/" + MONTH + "/" + YEAR;
TRANSFER_DATE = ICONV(TRANSFER_DATE, "D4/");
if (TRANSFER_DATE - TODAYS_DATE >= DD_LEEWAY_PARAM) {
NEW_DEBIT_DATE = TRANSFER_DATE;
} else {
MONTH = MONTH + 1;
if (MONTH == 13) {
MONTH = 1;
YEAR = YEAR + 1;
}
TRANSFER_DATE = DAY + "/" + MONTH + "/" + YEAR;
TRANSFER_DATE = ICONV(TRANSFER_DATE, "D4/");
NEW_DEBIT_DATE = TRANSFER_DATE;
}
DAY_OF_MONTH = OCONV(NEW_DEBIT_DATE, "DD");
if (!(LOCATE(DAY_OF_MONTH, DD_DAY_PARAM, 1, 0, 1, ref DAY_POS, "AL"))) {
nrf0 = 19;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
DATE_LAST_RUN = DATE_LAST_RUN_PARAM[1, DAY_POS];
STAGE_IND = DD_STAGE_PARAM[1, DAY_POS];
MTH = OCONV(DATE_LAST_RUN, "DM");
YR = OCONV(DATE_LAST_RUN, "DY");
MTH = MTH + 1;
if (MTH > 12) {
MTH = 1;
YR = YR + 1;
}
DATE_NEXT_RUN = DAY_OF_MONTH + "/" + MTH + "/" + YR;
DATE_NEXT_RUN = ICONV(DATE_NEXT_RUN, "D2/");
if (NEW_DEBIT_DATE <= DATE_LAST_RUN) {
NEW_DEBIT_DATE = DATE_NEXT_RUN;
}
return;
/* ************************** */
}
void L1200() {
/*  Freeze Direct Debit * */
/* ************************** */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] > DATE_LAST_RUN) {
/*  already frozen - reinstate */
PRINT(AT(5, 21) + "Account Frozen " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1], "D2/") + " to " + OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2], "D2/") + "       Reinstate (Y/N)");
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref ANS);
if (ANS == "Y") {
POS_INCR = 0;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] > DATE_LAST_RUN) {
START_DATE_TO_USE = DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1];
} else {
START_DATE_TO_USE = DATE_LAST_RUN;
/*  Un-Freeze from month after the last DD run if freeze was in place prior to run */
POS_INCR = 1;
}
if (!LOCATE(START_DATE_TO_USE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref START_POS, "AR")) { NULL(); }
if (!LOCATE(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2], DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref END_POS, "AR")) { NULL(); }
for(POS = START_POS + POS_INCR; POS <= END_POS; POS += 1) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, POS] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, POS] = "";
}
DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] = "";
UPDATE_REQ = TRUE;
}
NEW_EXPIRY_DATE = TODAYS_DATE + 3650;
EXPIRE_QUERY = "Do you also want to reset the member's expiry date ? (Y/N) ";
EXPIRE_MESSAGE = "Membership expiry reset ";
L1500();
/*  deal with membership expiry */
} else {
/*  not frozen */
/*  Enter start date for freeze */
SDATE = "";
do {
if (SDATE != "") break;
PRINT(AT(5, 21) + UND_VID + SPACE(SCREEN_WIDTH - 7));
PRINT(AT(5, 21) + "Please enter start date from which account will be frozen ");
nrf0 = 11;
FL019 = new FL019(ref nrf0, ref ANS);
SDATE = ICONV(ANS, "D2");
// BEGIN CASE
// CASE
if (ANS == "" || ANS == COMMON.ABANDON) {
return;
}// CASE
else if (SDATE < TODAYS_DATE || (SDATE == DATE_LAST_RUN && DD_STAGE != 1)) {
nrf0 = 49;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
SDATE = "";
}// CASE
else if (SDATE < TODAYS_DATE || SDATE < DATE_LAST_RUN) {
nrf0 = 27;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
SDATE = "";
}// CASE
else if (OTHERWISE) {
}
// END CASE
} while (true);
L1250:;
/*  Enter end date for freeze */
EDATE = "";
do {
if (EDATE != "") break;
PRINT(AT(5, 21) + UND_VID + SPACE(SCREEN_WIDTH - 7));
PRINT(AT(5, 21) + "Please enter end date of freeze ");
nrf0 = 11;
FL019 = new FL019(ref nrf0, ref ANS);
EDATE = ICONV(ANS, "D2");
// BEGIN CASE
// CASE
if (ANS == "" || ANS == COMMON.ABANDON) {
return;
}// CASE
else if (EDATE < TODAYS_DATE || (EDATE == DATE_LAST_RUN && DD_STAGE != 1)) {
nrf0 = 51;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
EDATE = "";
}// CASE
else if (EDATE < TODAYS_DATE || EDATE < DATE_LAST_RUN) {
nrf0 = 48;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
EDATE = "";
}// CASE
else if (EDATE < SDATE) {
nrf0 = 45;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
EDATE = "";
}// CASE
else if (OTHERWISE) {
}
// END CASE
} while (true);
L1300:;
/*  Enter Frozen Amount */
FRZ_AMOUNT = "";
do {
if (FRZ_AMOUNT != "") break;
PRINT(AT(5, 21) + UND_VID + SPACE(SCREEN_WIDTH - 7));
PRINT(AT(5, 21) + "Please enter amount to freeze to ");
nrf0 = 11;
FL019 = new FL019(ref nrf0, ref FRZ_AMOUNT);
// BEGIN CASE
// CASE
if (FRZ_AMOUNT == COMMON.ABANDON) {
return;
}// CASE
else if (FRZ_AMOUNT < 0) {
nrf0 = 40;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
FRZ_AMOUNT = "";
}// CASE
else if (NUM(FRZ_AMOUNT) == FALSE) {
nrf0 = 42;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
FRZ_AMOUNT = "";
}// CASE
else if (OTHERWISE) {
}
// END CASE
} while (true);
FRZ_AMOUNT = INT(FRZ_AMOUNT * 100);
/*  update */
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(SCREEN_WIDTH - 2) + AT(2, 23));
PRINT("Adjustments within the freeze period will be removed - continue (Y/N)? ");
INPUT(out ANSWER, 2);
PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] = SDATE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] = EDATE;
UPDATE_REQ = TRUE;
TRANS_TYPE_LIST[1, -1] = "FREEZE";
TOTAL_INSTS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
if (!LOCATE(SDATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref START_FREEZE, "AR")) { NULL(); }
if (!(LOCATE(EDATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref END_FREEZE, "AR"))) {
L1400();
}
for(ZZZ_COUNT = START_FREEZE; ZZZ_COUNT <= END_FREEZE; ZZZ_COUNT += 1) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, ZZZ_COUNT] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, ZZZ_COUNT] = FRZ_AMOUNT - (DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT]);
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, ZZZ_COUNT] = DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT];
} else {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, ZZZ_COUNT] = FRZ_AMOUNT - (DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, ZZZ_COUNT]);
}
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, ZZZ_COUNT] = "FZ";
}
PRINT(AT(2, 7) + DIM_REV_VID + SPACE(SCREEN_WIDTH - 2) + NRM_VID);
NEW_EXPIRY_DATE = SDATE;
EXPIRE_QUERY = "Do you also want to expire the membership ? (Y/N) ";
EXPIRE_MESSAGE = "Membersip to expire from Freeze Start ";
L1500();
/*  deal with membership expiry */
return;
/* ************** */
}
void L1400() {
/* ************** */
if (END_FREEZE > TOTAL_INSTS) {
MONTH = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, END_FREEZE - 1], "DM");
YEAR = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, END_FREEZE - 1], "DY");
CHECK_DATE = "";
do {
if (CHECK_DATE > EDATE) break;
TRANSFER_DATE = DD_DAY + "." + MONTH + "." + YEAR;
CHECK_DATE = ICONV(TRANSFER_DATE, "D4/");
if (CHECK_DATE <= EDATE) {
END_FREEZE = END_FREEZE + 1;
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, END_FREEZE - 2] = CHECK_DATE;
}
MONTH = MONTH + 1;
if (MONTH > 12) {
MONTH = 1;
YEAR = YEAR + 1;
}
} while (true);
END_FREEZE = END_FREEZE - 2;
} else {
END_FREEZE = END_FREEZE - 1;
}
return;
/* *********************************************************************** */
}
void L1500() {
/*  Expire memshp for Freeze/Cancellation or unexpire for Reinstate * */
/* *********************************************************************** */
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(SCREEN_WIDTH - 2) + AT(2, 23));
PRINT(EXPIRE_QUERY);
INPUT(out ANSWER, 2);
PRINT(AT(2, 23) + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
if (ANSWER == "Y" || ANSWER == "y") {
VALID_EXPIRY = FALSE;
do {
if (VALID_EXPIRY) break;
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(SCREEN_WIDTH - 2) + AT(2, 23));
/*      PRINT @(2,23):'Enter Expiry Date : ':OCONV(DIRECT.DEBIT.CANCELLED.DATE,'D'): */
PRINT(AT(2, 23) + "Enter Expiry Date : " + OCONV(NEW_EXPIRY_DATE, "D"));
PRINT(AT(22, 23));
INPUT(out MEM_EXP_DATE, 12);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
// BEGIN CASE
// CASE
if (MEM_EXP_DATE == COMMON.ABANDON) {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(SCREEN_WIDTH - 2) + AT(2, 23));
/*         PRINT @(2,23):'Membership Expiry set to Cancellation Date ':OCONV(DIRECT.DEBIT.CANCELLED.DATE,'D'): */
PRINT(AT(2, 23) + EXPIRE_MESSAGE + OCONV(NEW_EXPIRY_DATE, "D"));
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
VALID_EXPIRY = TRUE;
/*         MEM.EXP.DATE = DIRECT.DEBIT.CANCELLED.DATE */
MEM_EXP_DATE = NEW_EXPIRY_DATE;
}// CASE
else if (MEM_EXP_DATE == "") {
/*         MEM.EXP.DATE = DIRECT.DEBIT.CANCELLED.DATE */
MEM_EXP_DATE = NEW_EXPIRY_DATE;
VALID_EXPIRY = TRUE;
}// CASE
else if (OTHERWISE) {
MEM_EXP_DATE = ICONV(MEM_EXP_DATE, "D");
if (MEM_EXP_DATE == "") {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(SPACE(SCREEN_WIDTH - 2) + AT(2, 23));
PRINT(AT(2, 23) + "Invalid Expiry Date ! ");
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
VALID_EXPIRY = FALSE;
} else {
O_MEM_EXP_DATE = OCONV(MEM_EXP_DATE, "D");
VALID_EXPIRY = TRUE;
}
}
// END CASE
} while (true);
if (NOT(MULTIPLE_TYPES)) {
MEM_REC[13] = MEM_EXP_DATE;
} else {
TOTAL_TYPES = DCOUNT(MEM_REC[2], VM);
for(EACH_TYPE = 1; EACH_TYPE <= TOTAL_TYPES; EACH_TYPE += 1) {
/*            IF MEM.REC<39,EACH.TYPE> = "Y" THEN */
if (MEM_REC[39, EACH_TYPE] == "Y" || MEM_REC[39] == "") {
MEM_REC[13, EACH_TYPE] = MEM_EXP_DATE;
}
}
}
}
return;
/* ***************************** */
}
void L1600() {
/*  Display Letter Status  * */
/* ***************************** */
// BEGIN CASE
// CASE
if (ORIG_DD_STATUS == "CANCELLED" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] == "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "Y";
/*  new/rejoin */
}// CASE
else if (ORIG_DD_STATUS == "CANCELLED" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] == "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "F";
/*  frozen */
}// CASE
else if (ORIG_DD_STATUS == "FROZEN" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "C";
/*  cancelled */
}// CASE
else if (ORIG_DD_STATUS == "FROZEN" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] == "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "UF";
/*  unfrozen */
}// CASE
else if (ORIG_DD_STATUS == "LIVE" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "C";
/*  cancelled */
}// CASE
else if (ORIG_DD_STATUS == "LIVE" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "F";
/*  frozen */
}// CASE
else if (OTHERWISE) {
/* DIRECT.DEBIT.LETTER = "N" */
NULL();
}
// END CASE
PRINT(AT(36, 6) + NRM_VID + "." + AT(36, 6));
PRINTCR(AT(36, 6) + FORMAT(DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER], "L#2"));
return;
/* ********************************************************************* */
/*                   E N D   O F   P R O G R A M                       * */
/* ********************************************************************* */
}
}
}
