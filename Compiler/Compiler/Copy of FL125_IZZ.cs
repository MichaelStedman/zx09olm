//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL125_IZZ : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_SCREENS = 8;
readonly UvVar DD_WORK_SORT_CODE = 1;
readonly UvVar DD_WORK_ACCT_NO = 2;
readonly UvVar DD_WORK_AMOUNT = 3;
readonly UvVar DD_WORK_NAME = 4;
readonly UvVar DD_WORK_ACCT_NAME = 5;
readonly UvVar DD_WORK_REJECTED = 6;
readonly UvVar DD_WORK_TRANS_CODE = 7;
readonly UvVar DD_WORK_REJECTED_REASON = 8;
readonly UvVar DD_WORK_DATE = 9;
readonly UvVar DD_WORK_BACS_REF = 10;
readonly UvVar DD_WORK_MEMBER_TYPE = 11;
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar BACS_NAME = 1;
readonly UvVar BACS_SORT = 2;
readonly UvVar BACS_BANK_ACC = 3;
readonly UvVar BACS_USER = 4;
readonly UvVar BACS_BUREAU = 5;
readonly UvVar BACS_INIT_CODE = 7;
readonly UvVar BACS_INTER_CODE = 8;
readonly UvVar BACS_FILE_SUFFIX = 9;
readonly UvVar BACS_CENTRE_CODES = 10;
readonly UvVar ADT_RECORD_ID = 1;
readonly UvVar ADT_DATE = 2;
readonly UvVar ADT_USER = 3;
readonly UvVar ADT_ORIG_VALUE = 4;
readonly UvVar ADT_NEW_VALUE = 5;
readonly UvVar ADT_REASON = 6;
readonly UvVar ADT_TIME = 7;
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
readonly UvVar TRANS_DATE = 1;
readonly UvVar TRANS_USER = 2;
readonly UvVar TRANS_ADJ = 3;
readonly UvVar TRANS_DATES = 4;
readonly UvVar TRANS_TYPE = 5;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] DD_WORK_REC = new UvVar[15];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] BANK_REC = new UvVar[10];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] BACS_PARAM = new UvVar[15];
UvVar[] ADT_REC = new UvVar[30];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] TRANS_REC = new UvVar[10];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar ERR_LINE = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar FL_DD_WORK = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar SCREEN_CODE = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar FL_ADT_LOG = "";
UvVar DICT_ADT_LOG = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_DDS_TRANS = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar EQUATE = "";
UvVar DD_DAY_PARAM = "";
UvVar DD_LEEWAY_PARAM = "";
UvVar DD_LAST_DATE_PARAM = "";
UvVar DD_STAGE_PARAM = "";
UvVar DD_PROCESS_DATE_PARAM = "";
UvVar DD_LAST_DISK_DATE_PARAM = "";
UvVar BACS_SPECIAL_ROUTINE = "";
UvVar BACS_OVERRIDE_PASSWORD = "";
UvVar FREEZE_REC = "";
UvVar FR_COUNT = "";
UvVar DATE_AND_TIME = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar DONE = "";
UvVar EDIT = "";
UvVar REPORT = "";
UvVar CURR_FIELD = "";
UvVar MAX_FIELD = "";
UvVar DOTS_ONLY = "";
UvVar PRINT_ERROR_HEADER = "";
UvVar ERROR_COUNT = "";
UvVar REPORT_POS = "";
FL000_10 FL000_10;
UvVar REPLY = "";
UvVar ZZZ_QUOTE = "";
UvVar OPTS = "";
UvVar INSTR = "";
UvVar FILE_NAME = "";
UvVar CENTRENAME = "";
UvVar DD_PAYMENT_DATE = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXEC_PROG CallAt_EXEC_PROG;
FL006 FL006;
UvVar CURR_MNTH = "";
UvVar CURR_YR = "";
UvVar CURR_DAY = "";
UvVar VALID_INPUT = "";
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar DATE_REPLY = "";
UvVar DD_PROCESS_DATE = "";
UvVar DD_DAY = "";
UvVar DAY_POS = "";
UvVar DD_STAGE = "";
UvVar WAIT = "";
UvVar PAZZ = "";
UvVar CONTROL_TOTAL = "";
UvVar CONTROL_COUNT = "";
UvVar INSTRUCTION = "";
UvVar MESSAGE = "";
UvVar DFL_DD_WORK = "";
UvVar DD_LIST = "";
UvVar STATEMENT = "";
UvVar EOF = "";
UvVar DD_KEY = "";
UvVar DIRECT_DEBIT_REQUEST = "";
UvVar WORK_REC = "";
FLTX2 FLTX2;
UvVar SEQ_NO = "";
UvVar CONTROL_REC = "";
UvVar DD_PAYMENT_POS = "";
UvVar DIRECT_DEBIT_AMOUNT = "";
UvVar DIRECT_DEB_ADJ = "";
UvVar OUR_REF = "";
UvVar BANK_KEY = "";
UvVar BACS_REF = "";
CallAt_BACS_SPECIAL_ROUTINE CallAt_BACS_SPECIAL_ROUTINE;
UvVar MEM_ID = "";
UvVar ERRMSG = "";
UvVar MEMPOS = "";
UvVar BANK_DETS = "";
UvVar TCCNT = "";
UvVar FIRST_DD_TYPE = "";
UvVar TYPE_POS = "";
UvVar PRINT_HEADER = "";
UvVar O_SFREEZE_DATE = "";
UvVar O_EFREEZE_DATE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL125() {
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
/*  Prepare Direct Debit List (Creates FL.DD.WORK) For IZZ */
/*  WRITTEN BY RICHARD T Amended by HS, RT, */
/* ******************************************************************* */
PROGRAM = "FL125.IZZ";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
SCREEN_CODE = PROGRAM;
/* **************************** */
/*  CHECK FOR AUTHORISED USER * */
/* **************************** */
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
/* * */
/*  Define Files Used */
/* * */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.DD.WORK

if (!OPEN("FL.DD.WORK", out FL_DD_WORK)) { STOP("201", "FL.DD.WORK"); }

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.BANK.DETAILS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BACS.PARAM.EQU

#endregion
#region INCLUDE FL.FILES FL.ADT.LOG

if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
/*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

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
#region INCLUDE FL.FILES FL.DDS.TRANS

if (!OPEN("FL.DDS.TRANS", out FL_DDS_TRANS)) { STOP("201", "FL.DDS.TRANS"); }

#endregion
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
EQUATE
DD_DAY_PARAM
EQUATE
DD_LEEWAY_PARAM
EQUATE
DD_LAST_DATE_PARAM
EQUATE
DD_STAGE_PARAM
EQUATE
DD_PROCESS_DATE_PARAM
EQUATE
DD_LAST_DISK_DATE_PARAM
EQUATE
BACS_SPECIAL_ROUTINE
if (!(READV(ref BACS_OVERRIDE_PASSWORD, COMMON.FILES[FL_CONTROL], "BACS.OVERRIDE.PASS", 1))) {
BACS_OVERRIDE_PASSWORD = "SYZYGY";
}
FREEZE_REC = "";
FR_COUNT = 1;
DATE_AND_TIME = OCONV(TODAYS_DATE, "D") + " " + OCONV(TIME(), "MT");
/* * Routine to set printer parameters  (condensed print) */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "ENGLISH";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
/* ************************************************************************* */
/*  CONTROL BLOCK */
/* * */
DONE = FALSE;
EDIT = FALSE;
REPORT = TRUE;
CURR_FIELD = 1;
MAX_FIELD = 2;
MAT(ref CONTROLS_REC, "");
DOTS_ONLY = FALSE;
PRINT_ERROR_HEADER = TRUE;
ERROR_COUNT = 0;
REPORT_POS = "";
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
L0800();
/*  Get control record and update screen */
do {
if (DONE) break;
REPLY = "";
#region ON CURR_FIELD GOSUB ...
switch ((int)CURR_FIELD) {
case 1: L1000(); break;
case 2: L2000(); break;
}
#endregion
// BEGIN CASE
// CASE
if (REPLY == COMMON.BACK) {
if (CURR_FIELD > 1) {
CURR_FIELD = CURR_FIELD - 1;
}
}// CASE
else if (REPLY == COMMON.ABANDON) {
DONE = TRUE;
REPORT = FALSE;
}// CASE
else if (OTHERWISE) {
CURR_FIELD = CURR_FIELD + 1;
if (CURR_FIELD > MAX_FIELD) {
EDIT = TRUE;
}
}
// END CASE
if (EDIT || DONE == TRUE) {
L4000();
/*  Display Options */
}
} while (true);
/* * */
/*  Print out debit report */
/* * */
if (ERROR_COUNT > 0) {
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PRINTCR(CHAR(12));
/*  FORM FEED AT END OF REPORT */
PRINTER_OFF();
}
if (REPORT == TRUE) {
ZZZ_QUOTE = "\"";
OPTS = "";
/*         INSTR = "SORT ":FILE.NAME:" # 'CONTROL.TOTALS' 0 1 2 4 5 TOTAL 3 ID-SUPP HEADING " */
INSTR = "SORT " + FILE_NAME + " # 'CONTROL.TOTALS' 0 1 2 4 5 ORIGINAL.DATE MEMBER.TYPE TOTAL 3 ID-SUPP HEADING ";
INSTR = INSTR + ZZZ_QUOTE + CENTRENAME[1] + " - BACS Direct Debit Submission Report for " + OCONV(DD_PAYMENT_DATE, COMMON.D2) + " 'LT'";
INSTR = INSTR + ZZZ_QUOTE + " GRAND-TOTAL " + ZZZ_QUOTE + "Total Debits Required'U'";
INSTR = INSTR + ZZZ_QUOTE + " LPTR";
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref INSTR, ref OPTS, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
if (FREEZE_REC != "") { L5400(); }
}
/* * */
/*  END OF CONTROL BLOCK */
/* ************************************************************************* */
return;
/* * */
}
void L0800() {
/*  Get control details and update screen */
/* * */
if (!(MATREAD(ref CONTROLS_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
}
PRINT(AT(10, 5) + "Last Bank Lists were Processed for  " + OCONV(DD_LAST_DATE_PARAM[1, 1], COMMON.D2));
if (DD_LAST_DATE_PARAM[1, 2] != "") {
PRINT("  and  " + OCONV(DD_LAST_DATE_PARAM[1, 2], COMMON.D2));
}
CURR_MNTH = OCONV(TODAYS_DATE, "DM");
CURR_YR = OCONV(TODAYS_DATE, "DY");
CURR_DAY = OCONV(TODAYS_DATE, "DD");
if (!READ(ref CENTRENAME, COMMON.FILES[FL_CENTRES], COMMON.CENTRE)) { CENTRENAME = "NOT KNOWN"; }
if (!(MATREAD(ref BACS_PARAM, COMMON.FILES[FL_CONTROL], "BACS.PARAM"))) {
BACS_PARAM[BACS_INIT_CODE] = 01;
BACS_PARAM[BACS_INTER_CODE] = 17;
}
return;
/* * */
}
void L1000() {
/* * */
VALID_INPUT = FALSE;
do {
if (VALID_INPUT || DONE) break;
PRINT(AT(40, 10) + NRM_VID + COMMON.EOL + AT(40, 10));
LENGTH_OF_INPUT = 10;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref DATE_REPLY);
DD_PROCESS_DATE = ICONV(DATE_REPLY, "D");
/* DAY = OCONV(DD.PROCESS.DATE,"DD") */
/* DAY = DAY "R%2" */
/* LOCATE(DAY,DD.DAY.PARAM,1;DD.POS;"AR") THEN */
/* LEEWAY = DD.LEEWAY.PARAM<1,DD.POS> */
/* IF LEEWAY = "" THEN LEEWAY = 0 */
/* END */
// BEGIN CASE
// CASE
if (DATE_REPLY == COMMON.ABANDON) {
DONE = TRUE;
REPORT = FALSE;
/*         CASE DD.PROCESS.DATE < (TODAYS.DATE + LEEWAY) */
/*            CALL FL006(PROGRAM,1,"") */
}// CASE
else if (DATE_REPLY == "") {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
VALID_INPUT = TRUE;
}
// END CASE
} while (true);
PRINTCR(AT(40, 10) + OCONV(DD_PROCESS_DATE, "D2"));
return;
/* * */
}
void L2000() {
/* * */
VALID_INPUT = FALSE;
do {
if (VALID_INPUT || DONE) break;
PRINT(AT(40, 12) + NRM_VID + COMMON.EOL + AT(40, 12));
LENGTH_OF_INPUT = 10;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref DATE_REPLY);
if (DATE_REPLY == COMMON.ABANDON) {
DONE = TRUE;
REPORT = FALSE;
return;
}
DD_PAYMENT_DATE = ICONV(DATE_REPLY, "D");
DD_DAY = OCONV(DD_PAYMENT_DATE, COMMON.D2).Substring(1, 2);
if (LOCATE(DD_DAY, DD_DAY_PARAM, 1, 0, 1, ref DAY_POS, "AL")) {
VALID_INPUT = TRUE;
DD_STAGE = DD_STAGE_PARAM[1, DAY_POS];
if (DD_STAGE == 1 || DD_STAGE == 3) {
if (DD_PAYMENT_DATE - DD_LAST_DATE_PARAM[1, DAY_POS] > 31) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINT(AT(3, 20) + "Please Check the payment date and enter YES to confirm it: ");
PRINT(AT(72, 20));
nrf0 = 4;
FL019 = new FL019(ref nrf0, ref WAIT);
if (WAIT != "YES") { VALID_INPUT = FALSE; }
}
} else {
nrf0 = 4;
nrf1 = " Process has been Run";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINT(ERR_LINE + "To re-run this process enter special password > ");
ECHO_OFF();
nrf0 = 20;
FL019 = new FL019(ref nrf0, ref PAZZ);
ECHO_ON();
if (PAZZ != BACS_OVERRIDE_PASSWORD) {
VALID_INPUT = FALSE;
} else {
VALID_INPUT = TRUE;
}
}
} else {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
VALID_INPUT = FALSE;
}
} while (true);
PRINTCR(AT(40, 12) + OCONV(DD_PAYMENT_DATE, "D2"));
return;
/* * */
/* ** */
L3000:;
/*  RESERVED FOR FUTURE USE */
/* * */
return;
/* * */
}
void L4000() {
/* * */
PRINTCR(AT(1, 22) + DIM_REV_VID + "Enter Field Number to change or <RETURN> to Process");
do {
if (DONE || REPLY != "") break;
PRINT(AT(75, 22) + SPACE(2) + AT(75, 22));
LENGTH_OF_INPUT = 2;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref REPLY);
// BEGIN CASE
// CASE
if (REPLY == "") {
L5000();
/*  CREATE WORK FILE */
DONE = TRUE;
}// CASE
else if (MATCH(REPLY,"0N")) {
if (REPLY < 1 || REPLY > MAX_FIELD) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
CURR_FIELD = REPLY;
}
}// CASE
else if (REPLY == COMMON.ABANDON) {
DONE = TRUE;
REPORT = COMMON.ABANDON;
}// CASE
else if (OTHERWISE) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
return;
/* ** */
}
void L5000() {
/*  PRODUCE WORK FILE */
/* ** */
PRINTCR(AT(1, 22) + COMMON.EOL + AT(78, 22) + NRM_VID + AT(2, 22) + DIM_REV_VID + "Processing - Please wait ");
CONTROL_TOTAL = 0;
CONTROL_COUNT = 0;
FILE_NAME = "FL.DD.WORK" + DD_DAY;
if (!(OPEN(FILE_NAME, out FL_DD_WORK))) {
INSTRUCTION = "CREATE-FILE " + FILE_NAME + " 1 301";
EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN(FILE_NAME, out FL_DD_WORK))) {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
INSTRUCTION = "COPY DICT FL.DD.WORK * (I)";
DATA("(DICT " + FILE_NAME);
EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
}
if (!OPENDICT(FILE_NAME, out DFL_DD_WORK)) { STOP("NO WORK FILE"); }
CLEARFILE(FL_DD_WORK);
PRINTCR(AT(60, 22) + "Work file Cleared");
/*      SELECT FL.DIRECT.DEBITS TO DD.LIST */
STATEMENT = "SELECT FL.DIRECT.DEBITS WITH CANCELLED > \"" + OCONV(DD_PAYMENT_DATE, "D2/");
STATEMENT = STATEMENT + "\" OR WITH CANCELLED = \"\"";
nrf0 = "OS";
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref STATEMENT, ref nrf0, ref DD_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
if (NOT(LIST_AVAILABLE)) {
PRINT(AT(10, 10) + "NO Direct Debits are available for processing");
PRINT(AT(10, 12) + "Check this before re-running please ");
return;
}
PRINTCR(AT(10, 22) + "Debit File Selected");
PRINTCR(AT(15, 16) + NRM_VID + "Processed : " + AT(40, 16) + CONTROL_COUNT);
EOF = FALSE;
do {
if (!(READNEXT(ref DD_KEY, 0, 0, DD_LIST))) {
EOF = TRUE;
}
if (EOF) break;
MAT(ref DIRECT_DEBIT_REC, "");
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
L5100();
/*  CHECK FOR DATE VALIDITY */
if (DIRECT_DEBIT_REQUEST != 0) { L5140(); }
L5150();
/*  GET TRANS CODE */
if (DIRECT_DEBIT_REQUEST != 0) {
L5200();
/*  PRODUCE WORK RECORD */
L5300();
/*  UPDATE CONTROL TOTALS */
WORK_REC[9] = DD_PROCESS_DATE;
WRITE(WORK_REC, FL_DD_WORK, DD_KEY);
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
TRANS_LOG_REC = WORK_REC;
nrf0 = "W";
nrf1 = "FL.DD.WORK";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
}
PRINTCR(AT(15, 17) + NRM_VID + "Errors : " + AT(40, 17) + ERROR_COUNT);
} while (true);
PRINT(AT(1, 22) + COMMON.EOL + AT(78, 22) + NRM_VID + AT(2, 22) + DIM_REV_VID + FORMAT("Processing Completed, Press <RETURN> ", "L#78"));
DD_LAST_DATE_PARAM[1, DAY_POS] = DD_PAYMENT_DATE;
DD_PROCESS_DATE_PARAM[1, DAY_POS] = DD_PROCESS_DATE;
DD_STAGE_PARAM[1, DAY_POS] = 1;
MATWRITE(CONTROLS_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL");
if (READ(ref TRANS_LOG_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL")) {
nrf0 = "W";
nrf1 = "DICT FL.DIRECT.DEBITS";
nrf2 = "BACS.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
}
RELEASE();
/*  Update ADT.LOG */
MAT(ref ADT_REC, "");
ADT_REC[ADT_RECORD_ID] = "DIRECT DEBIT FILES";
ADT_REC[ADT_DATE] = TODAYS_DATE;
ADT_REC[ADT_USER] = U_INITS;
ADT_REC[ADT_REASON] = "PREPARE DD LIST";
ADT_REC[ADT_TIME] = TIME();
if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
SEQ_NO = SEQ_NO + 1;
MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
/*  Update Control Totals */
CONTROL_REC = "";
CONTROL_REC[1] = CONTROL_COUNT;
CONTROL_REC[2] = CONTROL_TOTAL;
WRITE(CONTROL_REC, DFL_DD_WORK, "CONTROL.TOTALS");
TRANS_LOG_REC = CONTROL_REC;
nrf0 = "W";
nrf1 = "DICT FL.DD.WORK";
nrf2 = "CONTROL.TOTALS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
INPUT(out WAIT, 1);
return;
/* ** */
}
void L5100() {
/*  CHECK FOR VALID DATE AND GET AMOUNT */
/* ** */
if (LOCATE(DD_PAYMENT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref DD_PAYMENT_POS, "AR")) {
DIRECT_DEBIT_AMOUNT = DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, DD_PAYMENT_POS];
DIRECT_DEB_ADJ = DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, DD_PAYMENT_POS];
DIRECT_DEBIT_REQUEST = DIRECT_DEBIT_AMOUNT + DIRECT_DEB_ADJ;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] <= DD_PAYMENT_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] >= DD_PAYMENT_DATE) {
OUR_REF = DD_KEY;
BANK_KEY = FIELD(DD_KEY, "*", 1) + "*" + FIELD(DD_KEY, "*", 2);
if (!(READV(ref BACS_REF, COMMON.FILES[FL_BANK_DETAILS], BANK_KEY, 7))) {
BACS_REF = "";
}
if (BACS_REF != "") {
BACS_REF = "1*" + BACS_REF + "*1";
} else {
BACS_REF = OUR_REF;
}
if (BACS_SPECIAL_ROUTINE != "" && BACS_SPECIAL_ROUTINE.Substring(1, 1) != "*") {
CallAt_BACS_SPECIAL_ROUTINE = new CallAt_BACS_SPECIAL_ROUTINE(ref BACS_SPECIAL_ROUTINE, ref BACS_REF);
}
MEM_ID = FIELD(DD_KEY, "*", 2);
FREEZE_REC[FR_COUNT, 1] = MEM_ID;
FREEZE_REC[FR_COUNT, 2] = DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1];
FREEZE_REC[FR_COUNT, 3] = DIRECT_DEBIT_AMOUNT;
FREEZE_REC[FR_COUNT, 4] = DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2];
FREEZE_REC[FR_COUNT, 5] = BACS_REF;
FREEZE_REC[FR_COUNT, 6] = DIRECT_DEBIT_REQUEST;
FR_COUNT = FR_COUNT + 1;
}
DIRECT_DEBIT_REC[DIRECT_DEBIT_LAST_DATE] = DD_PAYMENT_DATE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_LAST_REQ_AMOUNT] = DIRECT_DEBIT_REQUEST;
DIRECT_DEBIT_REC[DIRECT_DEBIT_LAST_RECD_AMOUNT] = "";
} else {
DIRECT_DEBIT_REQUEST = 0;
}
return;
}
void L5140() {
/*  Check Membership/Bank record exists */
MEM_ID = FIELD(DD_KEY, "*", 2);
if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEM_ID))) {
DIRECT_DEBIT_REQUEST = 0;
ERRMSG = "Members Record MISSING - please correct before next run";
L6000();
/*  Error Report */
return;
}
MEMPOS = INDEX(DD_KEY, "*", 2);
MEMPOS = MEMPOS - 1;
BANK_KEY = DD_KEY.Substring(1, MEMPOS);
if (READ(ref BANK_DETS, COMMON.FILES[FL_BANK_DETAILS], BANK_KEY)) {
if (BANK_DETS[1] == "") {
DIRECT_DEBIT_REQUEST = 0;
ERRMSG = "Bank Details MISSING";
L6000();
/*  ERROR REPORT */
BANK_DETS = "";
}
if (BANK_DETS[1] == 0) {
DIRECT_DEBIT_REQUEST = 0;
ERRMSG = "Bank Details INVALID";
L6000();
/*  ERROR REPORT */
BANK_DETS = "";
}
if (BANK_DETS[2] == 0) {
DIRECT_DEBIT_REQUEST = 0;
ERRMSG = "Bank Details INVALID";
L6000();
/*  ERROR REPORT */
BANK_DETS = "";
}
} else {
DIRECT_DEBIT_REQUEST = 0;
ERRMSG = "Bank Details MISSING";
L6000();
/*  ERROR REPORT */
BANK_DETS = "";
}
return;
/* ** */
}
void L5150() {
/*  Get transaction code */
/* ** */
DD_WORK_REC[DD_WORK_TRANS_CODE] = BACS_PARAM[BACS_INIT_CODE];
if (BANK_DETS[6] != "") {
DD_WORK_REC[DD_WORK_TRANS_CODE] = BANK_DETS[6];
} else {
TCCNT = 1;
do {
if (TCCNT > DD_PAYMENT_POS) break;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, TCCNT] > 0) {
DD_WORK_REC[DD_WORK_TRANS_CODE] = BACS_PARAM[BACS_INTER_CODE];
TCCNT = DD_PAYMENT_POS;
}
TCCNT = TCCNT + 1;
} while (true);
}
return;
/* ** */
}
void L5200() {
/*  GENERATE WORK RECORD */
/* ** */
WORK_REC = "";
WORK_REC[1] = BANK_DETS[1];
WORK_REC[2] = BANK_DETS[2];
WORK_REC[3] = DIRECT_DEBIT_REQUEST;
WORK_REC[4] = BANK_DETS[3];
WORK_REC[5] = BANK_DETS[5];
WORK_REC[7] = DD_WORK_REC[DD_WORK_TRANS_CODE];
OUR_REF = DD_KEY;
if (!(READV(ref BACS_REF, COMMON.FILES[FL_BANK_DETAILS], BANK_KEY, 7))) {
BACS_REF = "";
}
if (BACS_REF != "") {
BACS_REF = "1*" + BACS_REF + "*1";
} else {
BACS_REF = OUR_REF;
}
if (BACS_SPECIAL_ROUTINE != "" && BACS_SPECIAL_ROUTINE.Substring(1, 1) != "*") {
CallAt_BACS_SPECIAL_ROUTINE = new CallAt_BACS_SPECIAL_ROUTINE(ref BACS_SPECIAL_ROUTINE, ref BACS_REF);
}
WORK_REC[10] = BACS_REF;
/*  add DD Type to Work Rec so that the posting will now what type */
/*  to allocate the money to (as the type could have changed by the */
/*  time the posting is done) */
/*  for multi-type sites with more than one DD Type, the posting */
/*  will not know what proportion should be allocated to what */
/*  type - therefore the first dd type only will be written to */
/*  the work rec */
FIRST_DD_TYPE = "";
if (MEMBERS_REC[MEMBER_DDFLAGS] == "" && MEMBERS_REC[MEMBER_DIRECT_DEBIT] == "Y") {
FIRST_DD_TYPE = MEMBERS_REC[MEMBER_TYPE];
} else {
DONE = FALSE;
TYPE_POS = 1;
do {
if (DONE) break;
if (MEMBERS_REC[MEMBER_DDFLAGS][1, TYPE_POS] == "Y") {
FIRST_DD_TYPE = MEMBERS_REC[MEMBER_TYPE][1, TYPE_POS];
DONE = TRUE;
} else {
TYPE_POS = TYPE_POS + 1;
if (TYPE_POS == DCOUNT(MEMBERS_REC[MEMBER_TYPE], VM) + 1) { DONE = TRUE; }
}
} while (true);
}
WORK_REC[11] = FIRST_DD_TYPE;
return;
/* ** */
}
void L5300() {
/*  UPDATE CONTROL TOTALS */
CONTROL_TOTAL = CONTROL_TOTAL + DIRECT_DEBIT_REQUEST;
CONTROL_COUNT = CONTROL_COUNT + 1;
PRINTCR(AT(40, 16) + CONTROL_COUNT);
/* ** */
return;
}
void L5400() {
/*  Process Frozen accounts */
PRINT_HEADER = TRUE;
REPORT_POS = "";
PRINTER_ON();
FR_COUNT = 1;
do {
if (FREEZE_REC[FR_COUNT] == "") break;
if (PRINT_HEADER == TRUE || REPORT_POS > 60) {
if (REPORT_POS > 60) { PRINTCR(CHAR(12)); /*  Form Feed */ }
PRINTCR(CENTRENAME[1] + " - Direct Debit Frozen Accounts for " + OCONV(DD_PAYMENT_DATE, COMMON.D2));
PRINTCR(DATE_AND_TIME);
PRINTCR("MEMBER NO        BACS REFERENCE   START FREEZE  END FREEZE  AMOUNT  REQUESTED");
PRINTCR(STR("=", 81));
PRINT();
REPORT_POS = 5;
PRINT_HEADER = FALSE;
}
PRINT(FORMAT(FREEZE_REC[FR_COUNT, 1], "L#15") + SPACE(2));
PRINT(FORMAT(FREEZE_REC[FR_COUNT, 5], "L#15") + SPACE(2));
O_SFREEZE_DATE = OCONV(FREEZE_REC[FR_COUNT, 2], "D2");
O_EFREEZE_DATE = OCONV(FREEZE_REC[FR_COUNT, 4], "D2");
PRINT(FORMAT(O_SFREEZE_DATE, "L#12") + SPACE(2));
PRINT(FORMAT(O_EFREEZE_DATE, "L#10") + SPACE(2));
PRINT(FORMAT(OCONV(FREEZE_REC[FR_COUNT, 3], "MD2"), "R#6"));
PRINTCR(FORMAT(OCONV(FREEZE_REC[FR_COUNT, 6], "MD2"), "R#10"));
REPORT_POS = REPORT_POS + 1;
FR_COUNT = FR_COUNT + 1;
} while (true);
PRINTER_OFF();
return;
/* *** */
}
void L6000() {
/*  ERROR REPORT */
/* *** */
PRINTER_ON();
if (PRINT_ERROR_HEADER == TRUE || REPORT_POS > 60) {
if (REPORT_POS > 60) { PRINTCR(CHAR(12)); /*  FORM FEED */ }
PRINTCR(CENTRENAME[1] + " - Direct Debit Error Report Report for " + OCONV(DD_PAYMENT_DATE, COMMON.D2));
PRINTCR(OCONV(TODAYS_DATE, COMMON.D2));
PRINTCR(STR("=", 79));
PRINT();
REPORT_POS = 4;
PRINT_ERROR_HEADER = FALSE;
}
PRINTCR(FORMAT(DD_KEY, "L#14") + FORMAT(OCONV(DIRECT_DEBIT_AMOUNT, COMMON.MD2), "R#10") + " - " + ERRMSG);
REPORT_POS = REPORT_POS + 1;
ERROR_COUNT = ERROR_COUNT + 1;
PRINTER_OFF();
return;
}
}
}
