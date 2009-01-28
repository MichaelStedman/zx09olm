//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL121 : UvBase
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
readonly UvVar BACS_NAME = 1;
readonly UvVar BACS_SORT = 2;
readonly UvVar BACS_BANK_ACC = 3;
readonly UvVar BACS_USER = 4;
readonly UvVar BACS_BUREAU = 5;
readonly UvVar BACS_INIT_CODE = 7;
readonly UvVar BACS_INTER_CODE = 8;
readonly UvVar BACS_FILE_SUFFIX = 9;
readonly UvVar BACS_CENTRE_CODES = 10;
readonly UvVar FL_CONTROL = 10;
readonly UvVar AUDDIS_LOG_SORTCODE = 1;
readonly UvVar AUDDIS_LOG_ACCNO = 2;
readonly UvVar AUDDIS_LOG_BANKNAME = 3;
readonly UvVar AUDDIS_LOG_ACCNAME = 4;
readonly UvVar AUDDIS_LOG_TRANS_CODE = 5;
readonly UvVar BACS_LODGEMENTS_SORTCODE = 1;
readonly UvVar BACS_LODGEMENTS_ACCNO = 2;
readonly UvVar BACS_LODGEMENTS_BANKNAME = 3;
readonly UvVar BACS_LODGEMENTS_ACCNAME = 4;
readonly UvVar BACS_LODGEMENTS_TRANS_CODE = 5;
readonly UvVar ADT_RECORD_ID = 1;
readonly UvVar ADT_DATE = 2;
readonly UvVar ADT_USER = 3;
readonly UvVar ADT_ORIG_VALUE = 4;
readonly UvVar ADT_NEW_VALUE = 5;
readonly UvVar ADT_REASON = 6;
readonly UvVar ADT_TIME = 7;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] BANK_REC = new UvVar[10];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] BACS_PARAM = new UvVar[15];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] AUDDIS_LOG_REC = new UvVar[20];
UvVar[] BACS_LODGEMENTS_REC = new UvVar[10];
UvVar[] ADT_REC = new UvVar[30];
UvVar[] ORIG_BANK_REC = new UvVar[10];
#endregion
#region Variables
UvVar SOURCE = "";
UvVar IDENTIFIER = "";
UvVar INTERACT = "";
UvVar CALLING_PROGRAM = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar CLR_ERR = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar TX_ATT = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar SCREEN_CODE = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_MEMBER_PARAMS = "";
UvVar FL_AUDDIS_LOG = "";
UvVar MESSAGE = "";
FL006 FL006;
UvVar FL_BACS_LODGEMENTS = "";
UvVar FL_ADT_LOG = "";
UvVar DICT_ADT_LOG = "";
UvVar VALUE = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar FL_BACS_REF = "";
UvVar NEW_REC = "";
UvVar NEW_AUDDIS = "";
UvVar PASSWORD_ENTERED = "";
UvVar LOG_AUDDIS = "";
UvVar AUDDIS_CONTROL = "";
UvVar PASS_REC = "";
UvVar MAX_FIELDS = "";
UvVar ALL_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar DISP_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar INCOMPLETE_REC = "";
UvVar RCHECK = "";
UvVar BANK_ID = "";
UvVar DETAILS_CHANGED = "";
UvVar MEMNO = "";
UvVar REASON_ARRAY = "";
UvVar BANK_REC_FIELD = "";
FLTX2 FLTX2;
UvVar NEW_BANK_REC = "";
UvVar DD_ID = "";
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar ANS = "";
UvVar CONTINUE = "";
UvVar WAIT = "";
UvVar KNOWN_PASS = "";
UvVar PASS_REQD = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar MEMBER_REQD = "";
UvVar TICKET_REC = "";
UvVar RUN_CHECKS = "";
FL103 FL103;
UvVar ST_MV = "";
FLQAS FLQAS;
UvVar ADDRESS = "";
UvVar ST_LENGTH = "";
UvVar REDISPLAY = "";
UvVar ST_MANDATORY = "";
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar PROMPT_NO = "";
UvVar I = "";
UvVar TEXT_COL = "";
UvVar TEXT_VIDEO = "";
UvVar AMD_NO = "";
UvVar TEXT_LEN = "";
UvVar VIDEO_OFF = "";
UvVar ST_ATT_MV = "";
UvVar ST_DISPLAY = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar PASSWD_GUESS = "";
UvVar AUDDIS_ID = "";
UvVar BACS_LODGE_REC = "";
UvVar LAST_LODGEMENT_DATE = "";
UvVar LAST_LODGEMENT_KEY = "";
UvVar SEQ_NO = "";
UvVar MEMBER_REC = "";
UvVar MEMBER_NAME = "";
FL_BANK_WIZARD FL_BANK_WIZARD;
UvVar CONFIRM = "";
UvVar BACS_TEST_REF = "";
UvVar BANK_REC_POS = "";
UvVar ADDRESS_POS = "";
UvVar ABBREVIATION = "";
FL000_16 FL000_16;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL121(ref UvVar SOURCE, ref UvVar IDENTIFIER, ref UvVar INTERACT, ref UvVar CALLING_PROGRAM) {
this.SOURCE = SOURCE;
this.IDENTIFIER = IDENTIFIER;
this.INTERACT = INTERACT;
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
/*  Routine to setup Bank Account Details for Members */
PROMPT("");
PROGRAM = "FL121";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
SCREEN_CODE = PROGRAM;
INTERACT = INVALID_DATA;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

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
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.BACS.PARAM.EQU

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
#region INCLUDE FL.FILES FL.ADT.LOG

if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
/*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

#endregion
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("NO ADT LOG"); }
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
if (!OPEN("FL.BACS.REF", out FL_BACS_REF)) { STOP("NO FL.BACS.REF FILE"); }
/* *************************** */
/*  Initialise Variables     * */
/* *************************** */
MAT(ref BANK_REC, "");
MAT(ref ORIG_BANK_REC, "");
NEW_REC = FALSE;
NEW_AUDDIS = FALSE;
PASSWORD_ENTERED = FALSE;
MAT(ref ADT_REC, "");
if (!(MATREAD(ref BACS_PARAM, COMMON.FILES[FL_CONTROL], "BACS.PARAM"))) {
BACS_PARAM[BACS_INIT_CODE] = 01;
BACS_PARAM[BACS_INTER_CODE] = 17;
}
LOG_AUDDIS = FALSE;
if (READ(ref AUDDIS_CONTROL, DFL_DIRECT_DEBITS, "AUDDIS.CONTROL")) {
LOG_AUDDIS = TRUE;
}
if (!(READ(ref PASS_REC, FL_MEMBER_PARAMS, "PASSWORD.CONTROL"))) {
PASS_REC = "";
}
/* ************************************ */
/*   Get Screen Definition Item       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
/* ********************************** */
/*   Extract Data Input Fields      * */
/* ********************************** */
MAX_FIELDS = 0;
ALL_FIELDS = 0;
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = INIT;
DISP_FIELDS = INIT;
do {
LINE = SC_POS[SCREEN_LINES + 1];
if (LINE == "") break;
if (LINE[1, 4] != "") {
ALL_FIELDS = ALL_FIELDS + 1;
DISP_FIELDS[ALL_FIELDS] = LINE;
if (LINE[1, 14] != "Y") {
MAX_FIELDS = MAX_FIELDS + 1;
if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0) {
FIRST_FIELD = MAX_FIELDS;
}
DATA_FIELDS[MAX_FIELDS] = LINE;
}
}
SCREEN_LINES = SCREEN_LINES + 1;
} while (true);
/* ************************************ */
/*   Main Processing Section          * */
/* ************************************ */
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO >= MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
/* --- */
/*  MAKE SURE THAT USER IS AWARE THAT ABANDONING IS TROUBLE */
/* --- */
INCOMPLETE_REC = FALSE;
for(RCHECK = 1; RCHECK <= 5; RCHECK += 1) {
if (BANK_REC[RCHECK] == "") { INCOMPLETE_REC = TRUE; }
}
if (INCOMPLETE_REC) {
if (IDENTIFIER != "") {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (FIELD_NO >= MAX_FIELDS) {
L0050();
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (INTERACT != EXIT) {
BANK_ID = SOURCE + "*" + MAIN_KEY;
if (BANK_REC[4] == "") { BANK_REC[4] = 1; }
DETAILS_CHANGED = FALSE;
if (BANK_REC[1] != ORIG_BANK_REC[1]) { DETAILS_CHANGED = TRUE; }
if (BANK_REC[2] != ORIG_BANK_REC[2]) { DETAILS_CHANGED = TRUE; }
if (BANK_REC[3] != ORIG_BANK_REC[3]) { DETAILS_CHANGED = TRUE; }
if (BANK_REC[5] != ORIG_BANK_REC[5]) { DETAILS_CHANGED = TRUE; }
if (BANK_REC[7] != ORIG_BANK_REC[7]) {
DELETE(FL_BACS_REF, ORIG_BANK_REC[7]);
DETAILS_CHANGED = TRUE;
}
if (BANK_REC[7] == ORIG_BANK_REC[7] && LEN(BANK_REC[7]) != LEN(ORIG_BANK_REC[7])) {
DELETE(FL_BACS_REF, ORIG_BANK_REC[7]);
DETAILS_CHANGED = TRUE;
}
if (DETAILS_CHANGED) {
BANK_REC[6] = "01";
}
if (BANK_REC[BANK_BACS_REF] != "") {
if (READVU(ref MEMNO, FL_BACS_REF, BANK_REC[BANK_BACS_REF], 1)) {
if (MEMNO != MAIN_KEY) {
nrf0 = 9;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
if (BANK_REC[BANK_BACS_REF] != MAIN_KEY) {
WRITEV(MAIN_KEY, FL_BACS_REF, BANK_REC[BANK_BACS_REF], 1);
}
if (BANK_REC[BANK_BACS_REF] == MAIN_KEY && LEN(BANK_REC[BANK_BACS_REF]) != LEN(MAIN_KEY)) {
WRITEV(MAIN_KEY, FL_BACS_REF, BANK_REC[BANK_BACS_REF], 1);
}
}
}
/*  Update ADT.LOG */
if (NOT(NEW_REC)) {
REASON_ARRAY = "";
REASON_ARRAY[1] = "BANK SORTCODE CHANGED";
REASON_ARRAY[2] = "BANK ACCOUNT NO CHANGED";
REASON_ARRAY[3] = "BANK NAME CHANGED";
REASON_ARRAY[5] = "BANK ACCOUNT HOLDER NAME CHANGED";
REASON_ARRAY[7] = "BACS REF CHANGED";
BANK_REC_FIELD = 1;
do {
if (BANK_REC_FIELD == 9) break;
if (BANK_REC[BANK_REC_FIELD] != ORIG_BANK_REC[BANK_REC_FIELD]) {
MAT(ref ADT_REC, "");
ADT_REC[ADT_REASON] = REASON_ARRAY[BANK_REC_FIELD];
L0600();
}
if (BANK_REC_FIELD == 3 || BANK_REC_FIELD == 5) {
BANK_REC_FIELD = BANK_REC_FIELD + 2;
} else {
BANK_REC_FIELD = BANK_REC_FIELD + 1;
}
} while (true);
}
if (BANK_REC[7] != ORIG_BANK_REC[7] && NEW_REC) {
ADT_REC[ADT_REASON] = "BACS REF CHANGED ON SETUP";
BANK_REC_FIELD = 7;
L0600();
}
/*  Update BANK.DETAILS file */
if (BANK_REC[7] == MAIN_KEY && LEN(BANK_REC[7]) == LEN(MAIN_KEY)) {
BANK_REC[7] = "";
}
MATWRITE(BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID)) {
TX_ATT = "";
nrf0 = "W";nrf1 = "FL.BANK.DETAILS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BANK_ID);
}
/*  Check if AUDDIS.LOG needs updating */
if (LOG_AUDDIS) {
NEW_BANK_REC = FALSE;
if (ORIG_BANK_REC[1] == "") {
NEW_BANK_REC = TRUE;
}
DD_ID = BANK_ID + "*1";
if (!(MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID))) {
MAT(ref DIRECT_DEBIT_REC, "");
}
/*               IF DIRECT.DEBIT.CANCELLED.DATE = "" AND DETAILS.CHANGED = TRUE THEN GOSUB 0500 */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] == "" && DETAILS_CHANGED == TRUE) {
L0500();
}
}
INTERACT = VALID_DATA;
}
}
RELEASE();
RELEASE();
return;
/* ************************************* */
}
void L0050() {
/*   Enter Amendment Field Number  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
NEW_BANK_REC = FALSE;
if (ORIG_BANK_REC[1] == "") {
NEW_BANK_REC = TRUE;
}
do {
PRINT(AT(2, 23));
if (NEW_BANK_REC) {
PRINT("Enter Field no. or <RETURN> to file ");
} else {
PRINT("Enter Field No, 'A' to create Auddis instruction or <RETURN> to file ");
}
LENGTH_OF_INPUT = 3;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
PRINT(CLR_ERR);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
if (CALLING_PROGRAM != "FL531" && CALLING_PROGRAM != "FL0001.1.1") {
INTERACT = EXIT;
} else {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}// CASE
else if (NOT(NEW_BANK_REC) && ANS == "A") {
NEW_BANK_REC = FALSE;
NEW_AUDDIS = TRUE;
L0500();
PRINT(AT(2, 22) + DIM_REV_VID);
PRINT(AT(2, 22) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 22) + "Auddis instruction created - press <RETURN> to exit ");
INPUT(out CONTINUE, 1);
PRINT(AT(2, 22) + NRM_VID + SPACE(SCREEN_WIDTH - 2));
INTERACT = FINISH;
}// CASE
else if (ANS == "") {
if (BANK_REC[4] == "") { BANK_REC[4] = 1; }
INCOMPLETE_REC = FALSE;
for(RCHECK = 1; RCHECK <= 5; RCHECK += 1) {
if (BANK_REC[RCHECK] == "" && RCHECK != 3) { INCOMPLETE_REC = TRUE; }
}
if (INCOMPLETE_REC) {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Bank Details incomplete !");
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + NRM_VID + SPACE(SCREEN_WIDTH - 2));
INTERACT = INVALID_DATA;
} else {
INTERACT = FINISH;
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
KNOWN_PASS = FALSE;
if (PASS_REC[10] != "") {
if (NOT(PASSWORD_ENTERED)) {
PASS_REQD = PASS_REC[10];
L0410();
} else {
KNOWN_PASS = TRUE;
}
} else {
KNOWN_PASS = TRUE;
}
if (KNOWN_PASS == TRUE) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
}
}
// END CASE
} while (INTERACT == INVALID_DATA);
return;
/* ******************************** */
}
void L0060() {
/*   Data Entry Routine       * */
/* ******************************** */
INTERACT = INVALID_DATA;
do {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
VALUE = "";
// BEGIN CASE
// CASE
if (ST_ATT == 0 && IDENTIFIER != "") {
ANS = IDENTIFIER;
PRINT(AT(ST_COL, ST_ROW) + IDENTIFIER);
}// CASE
else if (ST_ATT == 0 && IDENTIFIER == "") {
PRINT(AT(ST_COL, ST_ROW));
LENGTH_OF_INPUT = 15;
MEMBER_REQD = TRUE;
TICKET_REC = "";
RUN_CHECKS = FALSE;
FL103 = new FL103(ref TICKET_REC, ref MEMBER_REQD, ref RUN_CHECKS);
ANS = TICKET_REC[10];
}// CASE
else if (OTHERWISE) {
PRINT(AT(ST_COL, ST_ROW));
if (ST_ATT == 8 && ST_MV == 1) {
FLQAS = new FLQAS(ref ADDRESS);
if (ADDRESS == "") {
FL019 = new FL019(ref ST_LENGTH, ref ANS);
}
} else {
FL019 = new FL019(ref ST_LENGTH, ref ANS);
}
}
// END CASE
if (!(ANS == COMMON.HELP)) break;
REDISPLAY = FALSE;
if (REDISPLAY) {
L0100();
L0300();
}
} while (true);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.SKIP && ST_MANDATORY != "") {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == COMMON.SKIP && ST_ATT != 0) {
INTERACT = VALID_DATA;
do {
if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
}// CASE
else if (ANS == COMMON.CLR) {
if (ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
} else {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1100(); break;
case 3: L1200(); break;
case 4: L1300(); break;
case 5: L1400(); break;
case 6: L1500(); break;
case 7: L1600(); break;
case 8: L1700(); break;
case 9: L1800(); break;
case 10: L1900(); break;
case 11: L2000(); break;
}
#endregion
if (INTERACT == VALID_DATA) {
if (ST_ICONVERSION != "") {
VALUE = ICONV(ANS, ST_ICONVERSION);
} else {
VALUE = ANS;
}
}
}
// END CASE
PRINT(AT(ST_COL, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
BANK_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
PROMPT_NO = 1;
PRINT(NRM_VID);
PRINT(COMMON.WASH);
/* ************************ */
/*  Print Top Bar */
/* ************************ */
PRINT(AT(78, 0) + NRM_VID + AT(2, 0) + DIM_REV_VID + SPACE(75));
PRINT(AT(78, 1) + NRM_VID + AT(2, 1) + DIM_REV_VID + SPACE(75));
PRINT(AT(78, 2) + NRM_VID + AT(2, 2) + DIM_REV_VID + SPACE(75));
/* ************************ */
/*  Print Bottom Bar */
/* ************************ */
PRINT(AT(78, 21) + NRM_VID + AT(2, 21) + DIM_REV_VID + SPACE(76));
PRINT(AT(78, 22) + NRM_VID + AT(2, 22) + DIM_REV_VID + SPACE(76) + NRM_VID);
PRINT(AT(2, 0) + DIM_REV_VID + "(" + SCREEN_CODE + ")");
PRINT(AT(24, 1) + SC_POS[1]);
PRINT(AT(78, 2) + NRM_VID);
for(I = 2; I <= SCREEN_LINES; I += 1) {
FIELD_DATA = SC_POS[I];
L0200();
TEXT_COL = FIELD_DATA[1, 1];
TEXT_VIDEO = FIELD_DATA[1, 7];
if (ST_ATT + 0 > 0) {
AMD_NO = "  " + PROMPT_NO;
AMD_NO = AMD_NO.Substring(LEN(AMD_NO) - 1, 2) + ")";
PRINT(AT(TEXT_COL - 4, ST_ROW) + AMD_NO);
PROMPT_NO = PROMPT_NO + 1;
}
if (TEXT_VIDEO == "D") {
TEXT_LEN = LEN(FIELD_DATA[1, 3]);
VIDEO_OFF = TEXT_LEN + TEXT_COL;
PRINT(AT(VIDEO_OFF, ST_ROW) + NRM_VID);
PRINTCR(AT(TEXT_COL - 1, ST_ROW) + DIM_VID + " ");
}
PRINT(AT(TEXT_COL, ST_ROW));
PRINT(FIELD_DATA[1, 3] + NRM_VID + " ");
PRINT(STR(".", ST_LENGTH));
}
return;
/* ********************************* */
}
void L0200() {
/*   Extract Field Data      * */
/* ********************************* */
ST_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
ST_ROW = FIELD_DATA[1, 2];
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT_MV = FIELD_DATA[1, 5];
ST_ATT = FIELD(ST_ATT_MV, ",", 1);
ST_MV = FIELD(ST_ATT_MV, ",", 2);
ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
ST_MANDATORY = FIELD_DATA[1, 10];
ST_ICONVERSION = FIELD_DATA[1, 12];
ST_DISPLAY = FIELD_DATA[1, 14];
if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
return;
/* ********************************* */
}
void L0300() {
/*   Display Item Contents */
/* ********************************* */
for(I = 1; I <= ALL_FIELDS; I += 1) {
FIELD_DATA = DISP_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
if (DISP_ATT != 0) {
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(BANK_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(BANK_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
}
}
return;
/* ************************ */
}
void L0410() {
/*  Validate Password * */
/* ************************ */
KNOWN_PASS = FALSE;
if (PASS_REQD == "") {
KNOWN_PASS = TRUE;
return;
}
do {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "This is a restricted operation - enter password or <return> ");
ECHO_OFF();
INPUTCR(out PASSWD_GUESS, 25);
ECHO_ON();
if (PASSWD_GUESS == PASS_REQD || PASSWD_GUESS == "") break;
} while (true);
PRINT(AT(2, 23) + SCREEN_BACK + CLR_ERR);
if (PASSWD_GUESS == PASS_REQD) { KNOWN_PASS = TRUE; PASSWORD_ENTERED = TRUE; }
return;
/* ************************* */
}
void L0500() {
/*  Update AUDDIS file * */
/* ************************* */
AUDDIS_ID = MAIN_KEY;
/* **************************************************************** */
/*      This code was put in to resolve a problem at Telford but */
/*      was never tested or used. Therefore I have commented it */
/*      out to leave the AUDDIS processing unchanged */
/* MHS! READV OLD.BACS.REF FROM FL.BANK.DETAILS, BANK.ID, 7 THEN */
/* MHS!   IF OLD.BACS.REF <> "" THEN */
/* MHS!     AUDDIS.ID = OLD.BACS.REF */
/* MHS!   END */
/* MHS! END */
/* **************************************************************** */
// BEGIN CASE
// CASE
if (NEW_BANK_REC || NEW_AUDDIS) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}// CASE
else if (OTHERWISE) {
if (MATREAD(ref AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID)) {
// BEGIN CASE
// CASE
if (AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] == "0N") {
if (READ(ref BACS_LODGE_REC, FL_BACS_LODGEMENTS, MAIN_KEY)) {
if (BACS_LODGE_REC[1, 1] != "") { AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C/0N"; }
}
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}// CASE
else if (AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] == "0C") {
NULL();
}// CASE
else if (AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] == "0C/0N") {
if (READV(ref LAST_LODGEMENT_DATE, FL_BACS_LODGEMENTS, MAIN_KEY, 1)) {
LAST_LODGEMENT_KEY = MAIN_KEY + "*" + LAST_LODGEMENT_DATE;
if (MATREAD(ref BACS_LODGEMENTS_REC, FL_BACS_LODGEMENTS, LAST_LODGEMENT_KEY)) {
if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNO] == BANK_REC[BANK_ACCOUNT_NO] && BACS_LODGEMENTS_REC[BACS_LODGEMENTS_SORTCODE] == BANK_REC[BANK_SORT_CODE]) {
DELETE(FL_AUDDIS_LOG, AUDDIS_ID);
} else {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C/0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}
}
} else {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}
}
// END CASE
} else {
/*  no existing AUDDIS.WORK.REC */
if (READV(ref LAST_LODGEMENT_DATE, FL_BACS_LODGEMENTS, MAIN_KEY, 1)) {
LAST_LODGEMENT_KEY = MAIN_KEY + "*" + LAST_LODGEMENT_DATE;
if (MATREAD(ref BACS_LODGEMENTS_REC, FL_BACS_LODGEMENTS, LAST_LODGEMENT_KEY)) {
if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNO] != BANK_REC[BANK_ACCOUNT_NO] || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_SORTCODE] != BANK_REC[BANK_SORT_CODE] || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_BANKNAME] != BANK_REC[BANK_NAME] || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNAME] != BANK_REC[BANK_ACCOUNT_NAME]) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C/0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}
}
} else {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, AUDDIS_ID);
}
}
}
// END CASE
return;
/* ************************ */
}
void L0600() {
/*   Update ADT LOG */
/* ************************ */
ADT_REC[1] = "FL.BANK.DETAILS" + VM + MAIN_KEY;
ADT_REC[ADT_DATE] = TODAYS_DATE;
ADT_REC[ADT_USER] = U_INITS;
ADT_REC[ADT_ORIG_VALUE] = ORIG_BANK_REC[BANK_REC_FIELD];
ADT_REC[ADT_NEW_VALUE] = BANK_REC[BANK_REC_FIELD];
ADT_REC[ADT_TIME] = TIME();
if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
SEQ_NO = SEQ_NO + 1;
MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
return;
/* ************************ */
/*   Validation Routines  * */
/* ************************ */
}
void L1000() {
/*   Membership Number Validation Routine */
INTERACT = VALID_DATA;
if (ANS == "") {
if (READV(ref MEMNO, FL_BACS_REF, ANS, 1)) {
ANS = MEMNO;
if (!(READ(ref MEMBER_REC, COMMON.FILES[FL_MEMBERS], ANS))) {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
AMENDING = TRUE;
return;
}
} else {
INTERACT = EXIT;
AMENDING = TRUE;
return;
}
} else {
if (!(READ(ref MEMBER_REC, COMMON.FILES[FL_MEMBERS], ANS))) {
if (READV(ref MEMNO, FL_BACS_REF, ANS, 1)) {
ANS = MEMNO;
if (!(READ(ref MEMBER_REC, COMMON.FILES[FL_MEMBERS], ANS))) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
return;
}
} else {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
return;
}
}
}
MEMBER_NAME = MEMBER_REC[6, 1] + " " + MEMBER_REC[5, 1] + " " + MEMBER_REC[4, 1];
ADDRESS = MEMBER_REC[10, 1] + " " + MEMBER_REC[10, 2] + " " + MEMBER_REC[10, 3] + " " + MEMBER_REC[10, 4] + " " + MEMBER_REC[10, 5];
PRINT(AT(6, 3) + MEMBER_NAME + "   " + ADDRESS);
BANK_ID = SOURCE + "*" + ANS;
if (MATREADU(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID)) {
if (BANK_REC[7] == "") { BANK_REC[7] = ANS; }
MAT(ref ORIG_BANK_REC, BANK_REC);
AMENDING = TRUE;
if (BANK_REC[1] == "" && BANK_REC[2] == "" && BANK_REC[3] == "") { AMENDING = FALSE; }
L0300();
} else {
NEW_REC = TRUE;
}
if (ORIG_BANK_REC[1] == "") {
NEW_REC = TRUE;
if (BANK_REC[7] == "") {
BANK_REC[7] = ANS;
ORIG_BANK_REC[7] = ANS;
}
PRINTCR(AT(30, 11) + NRM_VID + BANK_REC[7]);
}
return;
}
void L1100() {
/*   Bank Sort Code Validation Routine */
if (ANS == "") {
ANS = BANK_REC[1];
INTERACT = VALID_DATA;
return;
}
if (MATCH(ANS,"6N")) {
INTERACT = VALID_DATA;
FL_BANK_WIZARD = new FL_BANK_WIZARD(ref ANS, ref BANK_REC[2], ref INTERACT);
if (INTERACT == INVALID_DATA) {
nrf0 = 14;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1200() {
/*  Account Number Validation Routine */
if (ANS == "") {
ANS = BANK_REC[2];
INTERACT = VALID_DATA;
return;
}
if (MATCH(ANS,"8N")) {
INTERACT = VALID_DATA;
FL_BANK_WIZARD = new FL_BANK_WIZARD(ref BANK_REC[1], ref ANS, ref INTERACT);
if (INTERACT == INVALID_DATA) {
nrf0 = 14;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1300() {
/*  Bank Name Validation Routine */
if (ANS == "") { ANS = BANK_REC[3]; }
INTERACT = VALID_DATA;
return;
}
void L1400() {
/*  Name of Account Holder Validation */
if (ANS == "") { ANS = BANK_REC[5]; }
INTERACT = VALID_DATA;
return;
}
void L1500() {
/*  BACS Ref No Validation */
// BEGIN CASE
// CASE
if (ANS == "" && BANK_REC[7] == "") {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Must enter BACS Ref No");
INPUT(out WAIT, 1);
PRINT(AT(2, 23) + NRM_VID + SPACE(SCREEN_WIDTH - 2));
}// CASE
else if (ANS == "") {
ANS = BANK_REC[7];
INTERACT = VALID_DATA;
PRINTCR(AT(30, 11) + ANS);
}// CASE
else if (ANS == BANK_REC[7]) {
INTERACT = VALID_DATA;
}// CASE
else if (NEW_REC && ANS != BANK_REC[7]) {
/*  new bank rec being created */
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Are you sure you want a different BACS Ref to the Mem No? (Y/N) ");
INPUT(out CONFIRM, 2);
PRINT(AT(2, 23) + NRM_VID + SPACE(SCREEN_WIDTH - 2));
if (CONFIRM == "Y" || CONFIRM == "y") {
if (READVU(ref BACS_TEST_REF, FL_BACS_REF, ANS, 1)) {
if (BACS_TEST_REF != MAIN_KEY) {
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
} else {
INTERACT = VALID_DATA;
}
} else {
ANS = BANK_REC[7];
INTERACT = VALID_DATA;
}
}// CASE
else if (ANS != BANK_REC[7] && NEW_REC == FALSE) {
PRINT(AT(2, 23) + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "WARNING! Cust'mr must sign new mandate if changing BACS Ref. Continue?(Y/N)");
INPUT(out CONTINUE, 2);
PRINT(AT(2, 23) + NRM_VID + SPACE(SCREEN_WIDTH - 2));
if (CONTINUE == "Y" || CONTINUE == "y") {
if (READV(ref BACS_TEST_REF, FL_BACS_REF, ANS, 1)) {
if (BACS_TEST_REF != MAIN_KEY) { nrf0 = 13;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1); }
} else {
INTERACT = VALID_DATA;
}
} else {
ANS = BANK_REC[7];
INTERACT = VALID_DATA;
}
}
// END CASE
return;
}
void L1600() {
/*  Address Line 1 */
// BEGIN CASE
// CASE
if (ADDRESS != "") {
BANK_REC_POS = 1;
ADDRESS_POS = 1;
BANK_REC[8] = "";
do {
if (ADDRESS_POS == 5) break;
if (ADDRESS[ADDRESS_POS] != "") {
BANK_REC[8][1, BANK_REC_POS] = ADDRESS[ADDRESS_POS];
BANK_REC_POS = BANK_REC_POS + 1;
}
ADDRESS_POS = ADDRESS_POS + 1;
} while (true);
BANK_REC[8][1, 5] = ADDRESS[5];
PRINTCR(AT(ST_COL, ST_ROW) + FORMAT(BANK_REC[8][1, 1], "L#25"));
PRINTCR(AT(ST_COL, ST_ROW + 1) + FORMAT(BANK_REC[8][1, 2], "L#25"));
PRINTCR(AT(ST_COL, ST_ROW + 2) + FORMAT(BANK_REC[8][1, 3], "L#25"));
PRINTCR(AT(ST_COL, ST_ROW + 3) + FORMAT(BANK_REC[8][1, 4], "L#25"));
PRINTCR(AT(ST_COL, ST_ROW + 4) + FORMAT(BANK_REC[8][1, 5], "L#15"));
ANS = ADDRESS[1];
INTERACT = VALID_DATA;
FIELD_NO = FIELD_NO + 4;
/* * */
}// CASE
else if (ANS == "") {
ANS = TRIM(ANS);
ANS = BANK_REC[8][1, 1];
INTERACT = VALID_DATA;
}// CASE
else if (ANS != "") {
ANS = TRIM(ANS);
L0400();
INTERACT = VALID_DATA;
}
// END CASE
return;
}
void L1700() {
/*  Address Line 2 */
ANS = TRIM(ANS);
if (ANS == "") {
ANS = BANK_REC[8][1, 2];
INTERACT = VALID_DATA;
} else {
L0400();
INTERACT = VALID_DATA;
}
return;
}
void L1800() {
/*  Address Line 3 */
ANS = TRIM(ANS);
if (ANS == "") {
ANS = BANK_REC[8][1, 3];
INTERACT = VALID_DATA;
} else {
L0400();
INTERACT = VALID_DATA;
}
return;
}
void L1900() {
/*  Address Line 4 */
ANS = TRIM(ANS);
if (ANS == "") {
ANS = BANK_REC[8][1, 4];
INTERACT = VALID_DATA;
} else {
L0400();
INTERACT = VALID_DATA;
}
return;
}
void L2000() {
/*  Post Code */
if (ANS == "") {
ANS = BANK_REC[8][1, 5];
INTERACT = VALID_DATA;
} else {
INTERACT = VALID_DATA;
}
return;
}
void L0400() {
/*  Check Abbreviations */
ABBREVIATION = ANS;
FL000_16 = new FL000_16(ref ABBREVIATION, ref ANS);
PRINT(AT(ST_COL, ST_ROW) + COMMON.SP[ST_LENGTH] + AT(ST_COL, ST_ROW) + ANS);
return;
/*   END OF ROUTINE */
/* ************************************** */
}
}
}
