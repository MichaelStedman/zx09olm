//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL127 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
readonly UvVar TRANS_DATE = 1;
readonly UvVar TRANS_USER = 2;
readonly UvVar TRANS_ADJ = 3;
readonly UvVar TRANS_DATES = 4;
readonly UvVar TRANS_TYPE = 5;
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
readonly UvVar DD_POST_AMT = 1;
readonly UvVar DD_POST_UNITS = 2;
readonly UvVar DD_POST_DATE = 3;
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar ADT_RECORD_ID = 1;
readonly UvVar ADT_DATE = 2;
readonly UvVar ADT_USER = 3;
readonly UvVar ADT_ORIG_VALUE = 4;
readonly UvVar ADT_NEW_VALUE = 5;
readonly UvVar ADT_REASON = 6;
readonly UvVar ADT_TIME = 7;
readonly UvVar DD_DEBTORS_DATES = 1;
readonly UvVar DD_DEBTORS_OWED = 2;
readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
readonly UvVar DD_DEBTORS_REASON = 4;
readonly UvVar FL_BANK_DETAILS = 108;
readonly UvVar BANK_SORT_CODE = 1;
readonly UvVar BANK_ACCOUNT_NO = 2;
readonly UvVar BANK_NAME = 3;
readonly UvVar BANK_INSTALL_RECORDS = 4;
readonly UvVar BANK_ACCOUNT_NAME = 5;
readonly UvVar BANK_TRANS_CODE = 6;
readonly UvVar BANK_BACS_REF = 7;
readonly UvVar BANK_HOLDERS_ADDRESS = 8;
readonly UvVar BACS_NAME = 1;
readonly UvVar BACS_SORT = 2;
readonly UvVar BACS_BANK_ACC = 3;
readonly UvVar BACS_USER = 4;
readonly UvVar BACS_BUREAU = 5;
readonly UvVar BACS_INIT_CODE = 7;
readonly UvVar BACS_INTER_CODE = 8;
readonly UvVar BACS_FILE_SUFFIX = 9;
readonly UvVar BACS_CENTRE_CODES = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] DD_WORK_REC = new UvVar[15];
UvVar[] TRANS_REC = new UvVar[10];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] DD_POST_REC = new UvVar[15];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] ADT_REC = new UvVar[30];
UvVar[] DD_DEBTORS_REC = new UvVar[10];
UvVar[] BANK_REC = new UvVar[10];
UvVar[] BACS_PARAM = new UvVar[15];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar SCREEN_CODE = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar FL_DD_WORK = "";
UvVar FL_DDS_TRANS = "";
UvVar FL_DD_POST = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_ADT_LOG = "";
UvVar DICT_ADT_LOG = "";
UvVar FL_DD_DEBTORS = "";
UvVar FL_MEMBER_PARAMS = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar ERRMSG = "";
UvVar NO_BEFORE = "";
UvVar NO_AFTER = "";
UvVar NO_TO_VIEW = "";
UvVar DONE = "";
UvVar PRINT_ERROR_HEADER = "";
UvVar PRINT_BANK_NAME = "";
UvVar POST_OWNSITE_ONLY = "";
UvVar REPORT_POS = "";
UvVar COPY_FILENAME = "";
UvVar DD_COPY = "";
UvVar STATEMENT = "";
UvVar MSG = "";
UvVar ERROR_COUNT = "";
UvVar LOCATION = "";
DD_DATE_SEQUENCE DD_DATE_SEQUENCE;
UvVar FLEX = "";
UvVar EOF = "";
UvVar FROZEN_ACCOUNT = "";
UvVar O_DEBIT_DATE = "";
UvVar DEBIT_DATE = "";
UvVar DAY = "";
UvVar MONTH = "";
UvVar YEAR = "";
UvVar NEXT_RUN = "";
UvVar NEW_EXPIRY = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXEC_PROG CallAt_EXEC_PROG;
UvVar DD_KEY = "";
UvVar PAYMENT_POS = "";
UvVar MEMBER_ID = "";
UvVar MEMBERS_DD_DAY = "";
FLTX2 FLTX2;
UvVar TYPE_COUNT = "";
UvVar MEM_REC = "";
UvVar MEM_REC_EXISTS = "";
UvVar CONTROL_TOTALS = "";
UvVar DFL_DD_WORK = "";
UvVar BACS_CONTROL_REC = "";
UvVar PARAM_POS = "";
UvVar DATE_STAMP = "";
UvVar FL_DD_WORK_COPY = "";
UvVar INSTRUCTION = "";
UvVar MESSAGE = "";
FL006 FL006;
UvVar FILE_NAME = "";
UvVar SEQ_NO = "";
UvVar REJECTIONS = "";
FL135 FL135;
FL591 FL591;
UvVar DD_DAY = "";
UvVar WAIT = "";
UvVar INSTR = "";
UvVar OPTS = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
FL167 FL167;
UvVar CENTREREC = "";
UvVar TITLE = "";
UvVar TITLEX = "";
UvVar SCLINE = "";
UvVar DD_EXP_LEEWAY = "";
UvVar EXPIRE_ON_REJECTION = "";
UvVar UPDATE_DEBTORS = "";
UvVar DD_STAGE_PARAM = "";
UvVar DD_STAGE = "";
FL019 FL019;
UvVar DATE_REQ = "";
UvVar VALID_INPUT = "";
UvVar REPLY = "";
UvVar REJECTED = "";
UvVar DD_REC_EXISTS = "";
UvVar WORK_REC = "";
UvVar DD_AMOUNT = "";
UvVar REJECTED_REASON = "";
UvVar DD_DATE = "";
UvVar TRANS_CODE = "";
UvVar BANK_ID = "";
UvVar DD_DEBTOR_ID = "";
UvVar PNTR = "";
UvVar POST_ID = "";
UvVar MEM_TYPE = "";
UvVar DD_FLAGS = "";
UvVar NO_CARDS = "";
UvVar TRIES = "";
UvVar SUBMEMS = "";
UvVar NO_SUBMEMS = "";
UvVar PARENT_MEMBER_ID = "";
UvVar NO_DDS = "";
UvVar LAST_SCHEDULED_DATE = "";
UvVar NEXT_DEBIT_DATE = "";
UvVar DELVAL = "";
UvVar CARD_COUNT = "";
UvVar CARD = "";
UvVar EXP_RESET = "";
UvVar SEQNO = "";
UvVar UNIQUE_ID = "";
UvVar TRANS_ID = "";
UvVar TEST_REC = "";
UvVar NEXT_RUN_DATE = "";
UvVar LAST_POS = "";
UvVar LAST_DATE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL127() {
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
/*  DIRECT DEBIT POSTING ROUTINE */
/*  Last updated by lfsw (MONTE_CARLO\lfsw) at 16:02:54 on 17/09/1999. */
/*  WRITTEN BY RICHARD T */
PROGRAM = "FL127";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
SCREEN_CODE = PROGRAM;
/* **************************** */
/*  CHECK FOR AUTHORISED USER * */
/* **************************** */
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
/*  Define Files Used */
#region INCLUDE FL.FILES FL.DD.WORK

if (!OPEN("FL.DD.WORK", out FL_DD_WORK)) { STOP("201", "FL.DD.WORK"); }

#endregion
#region INCLUDE FL.FILES FL.DDS.TRANS

if (!OPEN("FL.DDS.TRANS", out FL_DDS_TRANS)) { STOP("201", "FL.DDS.TRANS"); }

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.DD.POST

if (!OPEN("FL.DD.POST", out FL_DD_POST)) { STOP("201", FL_DD_POST); }

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
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.ADT.LOG

if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
/*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

#endregion
#region INCLUDE FL.FILES FL.DD.DEBTORS

if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

#endregion
#region INCLUDE FL.FILES FL.MEMBER.PARAMS

if (!OPEN("FL.MEMBER.PARAMS", out FL_MEMBER_PARAMS)) { STOP("201", "FL.MEMBER.PARAMS"); }

#endregion
#region INCLUDE FL.FILES FL.BANK.DETAILS

#endregion
#region INCLUDE FL.FILES FL.BACS.PARAM.EQU

#endregion
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
/* ********************************************************************** */
/*  CONTROL BLOCK */
ERRMSG = INIT;
NO_BEFORE = 3;
NO_AFTER = 3;
NO_TO_VIEW = NO_BEFORE + NO_AFTER + 1;
DONE = FALSE;
MAT(ref DD_DEBTORS_REC, "");
PRINT_ERROR_HEADER = TRUE;
if (!(READ(ref PRINT_BANK_NAME, DFL_DIRECT_DEBITS, "PRINT.BANK.NAME"))) {
PRINT_BANK_NAME = FALSE;
}
if (!(READV(ref POST_OWNSITE_ONLY, FL_MEMBER_PARAMS, "POST.OWNSITE.ONLY", 1))) {
POST_OWNSITE_ONLY = FALSE;
}
if (POST_OWNSITE_ONLY == "Y") { POST_OWNSITE_ONLY = TRUE; }
REPORT_POS = 0;
L0800();
/*  SET UP SCREEN AND ENSURE THAT IT IS OK TO POST */
if (DONE) { return; }
/* ** */
/*  take copy of direct debit file before posting */
/* ** */
COPY_FILENAME = "DDSB4POST." + TODAYS_DATE;
if (!(OPEN(COPY_FILENAME, out DD_COPY))) {
STATEMENT = "CREATE-FILE " + COPY_FILENAME + " 1 1009";
EXECUTE(STATEMENT, MSG, string.Empty, string.Empty, string.Empty);
if (!OPEN(COPY_FILENAME, out DD_COPY)) { STOP(201, "CANNOT OPEN DD COPY"); }
}
STATEMENT = "CLEAR-FILE " + COPY_FILENAME;
EXECUTE(STATEMENT, MSG, string.Empty, string.Empty, string.Empty);
STATEMENT = "COPY FL.DIRECT.DEBITS * (I)";
DATA("(" + COPY_FILENAME);
EXECUTE(STATEMENT, MSG, string.Empty, string.Empty, string.Empty);
/* ** */
/* * */
/*  check date sequence */
/* * */
ERROR_COUNT = 0;
LOCATION = "BEFORE POST";
DD_DATE_SEQUENCE = new DD_DATE_SEQUENCE(ref ERROR_COUNT, ref LOCATION);
if (ERROR_COUNT != 0) {
PRINT(AT(10, 10) + "ERROR !  DATES OUT OF SEQUENCE. PLEASE CALL FLEX ");
INPUT(out FLEX, 1);
return;
}
/* * */
/* ******************************************************************** */
/*  Process FROZEN accounts */
EOF = FALSE;
FROZEN_ACCOUNT = TRUE;
O_DEBIT_DATE = OCONV(DEBIT_DATE, "D");
DAY = OCONV(DEBIT_DATE, "DD");
MONTH = OCONV(DEBIT_DATE, "DM");
YEAR = OCONV(DEBIT_DATE, "DY");
MONTH = MONTH + 1;
if (MONTH > 12) {
MONTH = MONTH - 12;
YEAR = YEAR + 1;
}
NEXT_RUN = ICONV(DAY + "/" + MONTH + "/" + YEAR, "D");
NEW_EXPIRY = TODAYS_DATE + 3650;
STATEMENT = "SELECT FL.DIRECT.DEBITS WITH FROZEN AND WITH FROZEN.START <= \"" + O_DEBIT_DATE + "\" AND WITH FROZEN.END >= \"" + O_DEBIT_DATE + "\"";
nrf0 = "OS";
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref STATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref DD_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
if (LOCATE(DEBIT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS] == "") {
MEMBER_ID = FIELD(DD_KEY, "*", 2);
/* *!                    READV MEMBERS.DD.DAY FROM FL.MEMBERS,MEMBER.ID,34 ELSE */
/* *!                       MEMBERS.DD.DAY = OCONV(DIRECT.DEBIT.DATES<1,1>,D2)[1,2] */
/* *!                    END */
if (!READV(ref MEMBERS_DD_DAY, COMMON.FILES[FL_MEMBERS], MEMBER_ID, 34)) { MEMBERS_DD_DAY = ""; }
if (MEMBERS_DD_DAY == "") {
MEMBERS_DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1], COMMON.D2).Substring(1, 2);
}
L6000();
/*  Generate new months and remove old DD req */
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
/*  unexpire membership if freeze ends before next run */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] < NEXT_RUN) {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID)) {
for(TYPE_COUNT = 1; TYPE_COUNT <= DCOUNT(MEMBERS_REC[MEMBER_TYPE], VM); TYPE_COUNT += 1) {
if (MEMBERS_REC[MEMBER_DDFLAGS][1, TYPE_COUNT] == "Y") {
MEMBERS_REC[MEMBER_EXPIRY_DATE][1, TYPE_COUNT] = NEW_EXPIRY;
}
}
}
}
}
}
}
} while (true);
}
/* * */
/*  check date sequence */
/* * */
ERROR_COUNT = 0;
LOCATION = "AFTER PROCESSING FREEZES";
DD_DATE_SEQUENCE = new DD_DATE_SEQUENCE(ref ERROR_COUNT, ref LOCATION);
if (ERROR_COUNT != 0) {
PRINT(AT(10, 10) + "ERROR !  DATES OUT OF SEQUENCE. PLEASE CALL FLEX ");
INPUT(out FLEX, 1);
}
/* * */
/*  End of processing for FROZEN accounts */
/* ******************************************************************** */
/*  For all LIVE (unfrozen) DDS, select FL.DD.WORK file */
/*  and then post att 3 (inst amt) into FL.DIRECT.DEBITS paid field */
if (!(MATREAD(ref BACS_PARAM, COMMON.FILES[FL_CONTROL], "BACS.PARAM"))) {
BACS_PARAM[BACS_INIT_CODE] = 01;
BACS_PARAM[BACS_INTER_CODE] = 17;
}
FROZEN_ACCOUNT = FALSE;
SELECT(FL_DD_WORK);
EOF = FALSE;
do {
RELEASE();
RELEASE();
if (!READNEXT(ref DD_KEY, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
MEMBER_ID = FIELD(DD_KEY, "*", 2);
/*         IF POST.OWNSITE.ONLY THEN */
if (READ(ref MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID)) {
MEM_REC_EXISTS = TRUE;
}
/*         END */
if (DD_KEY != "FLOPPY.REC") {
L1000();
/*  Action payment and update Control Totals */
}
L0100:;
} while (true);
WRITE(CONTROL_TOTALS, DFL_DD_WORK, "CONTROL.TOTALS");
TRANS_LOG_REC = CONTROL_TOTALS;
nrf0 = "W";
nrf1 = "DICT FL.DD.WORK";
nrf2 = "CONTROL.TOTALS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
BACS_CONTROL_REC[4, PARAM_POS] = 3;
/*  UPDATE STAGE */
WRITE(BACS_CONTROL_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL");
TRANS_LOG_REC = BACS_CONTROL_REC;
nrf0 = "W";
nrf1 = "DICT FL.DIRECT.DEBITS";
nrf2 = "BACS.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
RELEASE();
RELEASE();
/*  Create copy of DD Work file for Direct Debit Stats */
/*  as per SERCO requirements - 7/3/01 */
MONTH = OCONV(TODAYS_DATE, "DM");
MONTH = FORMAT(MONTH, "R%2");
YEAR = OCONV(TODAYS_DATE, "DY");
DATE_STAMP = TODAYS_DATE;
COPY_FILENAME = "FL.DD.WORK." + DATE_STAMP;
if (!(OPEN(COPY_FILENAME, out FL_DD_WORK_COPY))) {
INSTRUCTION = "CREATE-FILE " + COPY_FILENAME + " 1 301";
EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN(COPY_FILENAME, out FL_DD_WORK_COPY))) {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
INSTRUCTION = "COPY DICT FL.DD.WORK * (I)";
DATA("(DICT " + COPY_FILENAME);
EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
}
CLEARFILE(FL_DD_WORK_COPY);
INSTRUCTION = "COPY " + FILE_NAME + " * (I";
DATA("(" + COPY_FILENAME);
EXECUTE(INSTRUCTION, MESSAGE, string.Empty, string.Empty, string.Empty);
/*  Update ADT.LOG */
MAT(ref ADT_REC, "");
ADT_REC[ADT_RECORD_ID] = "DIRECT DEBIT FILES";
ADT_REC[ADT_DATE] = TODAYS_DATE;
ADT_REC[ADT_USER] = U_INITS;
ADT_REC[ADT_REASON] = "POST DIRECT DEBITS";
ADT_REC[ADT_TIME] = TIME();
if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
SEQ_NO = SEQ_NO + 1;
MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
PRINTCR(AT(10, 16) + "Rejections                 : " + REJECTIONS);
FL135 = new FL135();
FL591 = new FL591(ref DEBIT_DATE, ref DD_DAY);
PRINT(AT(1, 22) + CONTROL_TOTALS[3] + " Items processed, Press <RETURN>");
INPUTCR(out WAIT, 2);
// BEGIN CASE
// CASE
if (PRINT_BANK_NAME && NOT(POST_OWNSITE_ONLY)) {
INSTR = "SORT FL.DD.WORK" + DD_DAY + " WITH 6 # \"Y\" MEMBER.NO BACS.REF 1 2 4 5 TOTAL 3 HEADER \"BACS POST REPORT ";
}// CASE
else if (PRINT_BANK_NAME == FALSE && NOT(POST_OWNSITE_ONLY)) {
INSTR = "SORT FL.DD.WORK" + DD_DAY + " WITH 6 # \"Y\" MEMBER.NO BACS.REF 1 2 5 TOTAL 3 HEADER \"BACS POST REPORT ";
}// CASE
else if (PRINT_BANK_NAME && POST_OWNSITE_ONLY) {
INSTR = "SORT FL.DD.WORK" + DD_DAY + " WITH 6 # \"Y\" AND WITH MEMBER.CENTRE = \"" + COMMON.CENTRE + "\" MEMBER.NO BACS.REF 1 2 4 5 TOTAL 3 HEADER \"BACS POST REPORT ";
}// CASE
else if (PRINT_BANK_NAME == FALSE && POST_OWNSITE_ONLY) {
INSTR = "SORT FL.DD.WORK" + DD_DAY + " WITH 6 # \"Y\" AND WITH MEMBER.CENTRE = \"" + COMMON.CENTRE + "\" MEMBER.NO BACS.REF 1 2 5 TOTAL 3 HEADER \"BACS POST REPORT ";
}
// END CASE
INSTR = INSTR + "'DL'";
INSTR = INSTR + "\" ID-SUPP LPTR";
OPTS = "OS";
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "USER.REPORTS";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
if (PRINT_START_COMMAND != "") {
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
}
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref INSTR, ref OPTS, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
PRINTER_OFF();
PRINTER_CLOSE();
/* * */
/*  check date sequence */
/* * */
ERROR_COUNT = 0;
LOCATION = "AFTER NORMAL POST";
DD_DATE_SEQUENCE = new DD_DATE_SEQUENCE(ref ERROR_COUNT, ref LOCATION);
if (ERROR_COUNT != 0) {
PRINT(AT(10, 10) + "ERROR !  DATES OUT OF SEQUENCE. PLEASE CALL FLEX ");
INPUT(out FLEX, 1);
}
/* * */
L0200();
/*  Process adjusted direct debits */
/* * */
/*  check date sequence */
/* * */
ERROR_COUNT = 0;
LOCATION = "AFTER PROCESSING ADJUSTMENTS";
DD_DATE_SEQUENCE = new DD_DATE_SEQUENCE(ref ERROR_COUNT, ref LOCATION);
if (ERROR_COUNT != 0) {
PRINT(AT(10, 10) + "ERROR !  DATES OUT OF SEQUENCE. PLEASE CALL FLEX ");
INPUT(out FLEX, 1);
}
/* * */
FL167 = new FL167();
return;
/* ******************************************************************** */
/*                       S U B R O U T I N E S */
/* ******************************************************************** */
/* ******************************************************************** */
}
void L0800() {
/*  Read in Control and set up screen and prompt to continue */
/* ******************************************************************** */
PRINT(COMMON.WASH);
if (!READ(ref CENTREREC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE)) { CENTREREC = "NOT KNOWN"; }
TITLE = CENTREREC[1] + " - Direct Debit Posting Routine";
TITLEX = INT((80 - LEN(TITLE)) / 2);
for(SCLINE = 0; SCLINE <= 2; SCLINE += 1) {
PRINT(AT(78, SCLINE) + NRM_VID + AT(1, SCLINE) + DIM_REV_VID + SPACE(76));
}
PRINTCR(AT(2, 0) + "(" + PROGRAM + ")");
PRINTCR(AT(TITLEX, 1) + TITLE);
/*  Read in Control Details and Control Totals */
if (!(READU(ref BACS_CONTROL_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 1;
nrf1 = "DIRECT DEBITS NOT SET UP";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
DD_EXP_LEEWAY = BACS_CONTROL_REC[13];
EXPIRE_ON_REJECTION = BACS_CONTROL_REC[14];
UPDATE_DEBTORS = BACS_CONTROL_REC[15];
DD_STAGE_PARAM = BACS_CONTROL_REC[4];
if (DD_STAGE_PARAM[1, 2] == "") {
DD_STAGE = DD_STAGE_PARAM[1, 1];
DD_DAY = BACS_CONTROL_REC[1, 1];
DEBIT_DATE = BACS_CONTROL_REC[3, 1];
PARAM_POS = 1;
} else {
DEBIT_DATE = "";
do {
if (DEBIT_DATE != "") break;
PRINT(AT(10, 5) + NRM_VID + "Enter Date to Process (" + OCONV(BACS_CONTROL_REC[3, 1], "D2/") + " or " + OCONV(BACS_CONTROL_REC[3, 2], "D2/") + ") ");
nrf0 = 10;
FL019 = new FL019(ref nrf0, ref DATE_REQ);
if (DATE_REQ == COMMON.ABANDON) {
DONE = TRUE;
return;
}
DEBIT_DATE = ICONV(DATE_REQ, "D");
if (LOCATE(DEBIT_DATE, BACS_CONTROL_REC, 3, 0, 1, ref PARAM_POS, "AL")) {
DD_STAGE = BACS_CONTROL_REC[4, PARAM_POS];
DD_DAY = BACS_CONTROL_REC[1, PARAM_POS];
} else {
DEBIT_DATE = "";
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} while (true);
}
if (DD_STAGE != 2) {
nrf0 = 2;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
FILE_NAME = "FL.DD.WORK" + DD_DAY;
if (!(OPEN(FILE_NAME, out FL_DD_WORK))) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
if (!OPENDICT(FILE_NAME, out DFL_DD_WORK)) { STOP("NO WORK FILE"); }
if (!(READU(ref CONTROL_TOTALS, DFL_DD_WORK, "CONTROL.TOTALS"))) {
nrf0 = 3;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
CONTROL_TOTALS[3] = 0;
CONTROL_TOTALS[4] = 0;
REJECTIONS = 0;
PRINTCR(AT(10, 10) + NRM_VID + "Direct Debit Date          : " + OCONV(DEBIT_DATE, COMMON.D2));
PRINTCR(AT(10, 14) + "Control Total              : " + OCONV(CONTROL_TOTALS[2], COMMON.MD2));
PRINTCR(AT(10, 15) + "Number of Original Debits  : " + CONTROL_TOTALS[1]);
VALID_INPUT = FALSE;
PRINT(AT(10, 20) + "Are you sure that you want to post the direct debits (Y/N) ");
do {
if (VALID_INPUT || DONE) break;
PRINT(AT(70, 20));
nrf0 = 2;
FL019 = new FL019(ref nrf0, ref REPLY);
if (REPLY == "Y") {
VALID_INPUT = TRUE;
}
if (REPLY == COMMON.ABANDON || REPLY == "N") {
DONE = TRUE;
}
} while (true);
O_DEBIT_DATE = OCONV(DEBIT_DATE, "D");
return;
/* ******************************************************************** */
}
void L1000() {
/*  POST AMOUNT OR 0 (IF REJECTED) */
/* ******************************************************************** */
DD_REC_EXISTS = TRUE;
MEM_REC_EXISTS = TRUE;
MAT(ref TRANS_REC, "");
if (!(READ(ref WORK_REC, FL_DD_WORK, DD_KEY))) {
ERRMSG = "Possible corrupted record";
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
if (!(MATREADU(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY))) {
DD_REC_EXISTS = FALSE;
}
if (!(READU(ref MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID))) {
MEM_REC_EXISTS = FALSE;
}
if (DD_REC_EXISTS && MEM_REC_EXISTS) {
if (MEM_REC[34] != "") {
MEMBERS_DD_DAY = MEM_REC[34];
} else {
MEMBERS_DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1], COMMON.D2).Substring(1, 2);
}
L6000();
/*  Generate next inst & remove 1st */
}
TRANS_REC[TRANS_TYPE] = "POST ERROR - No DD.WORK rec";
DD_AMOUNT = 0;
REJECTED = "";
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
L9000();
/*  Update POSTing file */
return;
}
DD_AMOUNT = WORK_REC[3];
REJECTED = WORK_REC[6];
REJECTED_REASON = WORK_REC[8];
DD_DATE = WORK_REC[9];
if (REJECTED != "Y") {
TRANS_CODE = BACS_PARAM[BACS_INTER_CODE];
BANK_ID = "1*" + MEMBER_ID;
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID)) {
if (BANK_REC[BANK_SORT_CODE] != WORK_REC[1] || BANK_REC[BANK_ACCOUNT_NO] != WORK_REC[2]) {
TRANS_CODE = BACS_PARAM[BACS_INIT_CODE];
}
}
WRITEV(TRANS_CODE, COMMON.FILES[FL_BANK_DETAILS], BANK_ID, 6);
}
if (REJECTED == "Y") {
REJECTIONS = REJECTIONS + 1;
if (UPDATE_DEBTORS == "Y") {
DD_DEBTOR_ID = FIELD(DD_KEY, "*", 1) + "*" + FIELD(DD_KEY, "*", 2);
if (!(MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID))) {
MAT(ref DD_DEBTORS_REC, "");
}
if (!(LOCATE(DEBIT_DATE, DD_DEBTORS_REC[DD_DEBTORS_DATES], 1, 0, 1, ref PNTR, "AR"))) {
DD_DEBTORS_REC[DD_DEBTORS_DATES] = INSERT(DD_DEBTORS_REC[DD_DEBTORS_DATES], 1, PNTR, 0, DEBIT_DATE);
DD_DEBTORS_REC[DD_DEBTORS_OWED] = INSERT(DD_DEBTORS_REC[DD_DEBTORS_OWED], 1, PNTR, 0, DD_AMOUNT);
DD_DEBTORS_REC[DD_DEBTORS_TOTAL_OWED] = DD_DEBTORS_REC[DD_DEBTORS_TOTAL_OWED] + DD_AMOUNT;
DD_DEBTORS_REC[DD_DEBTORS_REASON] = INSERT(DD_DEBTORS_REC[DD_DEBTORS_REASON], 1, PNTR, 0, REJECTED_REASON);
}
}
DD_AMOUNT = 0;
}
MAT(ref DIRECT_DEBIT_REC, "");
if (!(MATREADU(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY))) {
ERRMSG = "Possible Corrupted File - Not on FL.DIRECT.DEBITS";
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
DD_REC_EXISTS = FALSE;
TRANS_REC[TRANS_TYPE] = "POST ERROR - No Direct Debit Rec";
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
L9000();
/*  Update POSTing file */
return;
}
if (!(READU(ref MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID))) {
ERRMSG = "Possible Corrupted File - Not on FL.MEMBERS";
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
MEM_REC_EXISTS = FALSE;
MEM_REC = "";
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
L9000();
/*  Update POSTing file */
}
if (LOCATE(DEBIT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LAST_RECD_AMOUNT] = DD_AMOUNT;
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS] = DD_AMOUNT;
DIRECT_DEBIT_REC[DIRECT_DEBIT_REJECTIONS][1, PAYMENT_POS] = REJECTED_REASON;
if (MEM_REC[34] != "") {
MEMBERS_DD_DAY = MEM_REC[34];
} else {
MEMBERS_DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1], COMMON.D2).Substring(1, 2);
}
L6000();
/*  Generate next instalment & remove first */
/*  Log the posting */
if (MEM_REC_EXISTS) {
TRANS_REC[TRANS_TYPE] = "POST";
} else {
TRANS_REC[TRANS_TYPE] = "POST ERROR - No Membership Rec";
}
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
/*  Update posting file for inclusion in Finance Files */
if (REJECTED != "Y") {
if (WORK_REC[11] != "") {
POST_ID = TODAYS_DATE + "*" + WORK_REC[11];
if (!(MATREADU(ref DD_POST_REC, FL_DD_POST, POST_ID))) {
MAT(ref DD_POST_REC, "");
}
DD_POST_REC[DD_POST_AMT] = DD_POST_REC[DD_POST_AMT] + DD_AMOUNT;
DD_POST_REC[DD_POST_UNITS] = DD_POST_REC[DD_POST_UNITS] + 1;
DD_POST_REC[DD_POST_DATE] = DEBIT_DATE;
MATWRITE(DD_POST_REC, FL_DD_POST, POST_ID);
} else {
if (!READV(ref MEM_TYPE, COMMON.FILES[FL_MEMBERS], MEMBER_ID, 2)) { MEM_TYPE = "XXX"; }
if (!READV(ref DD_FLAGS, COMMON.FILES[FL_MEMBERS], MEMBER_ID, 39)) { DD_FLAGS = ""; }
if (DD_FLAGS == "" || DD_FLAGS == "N") { DD_FLAGS = "Y"; }
NO_CARDS = DCOUNT(MEM_TYPE, VM);
DONE = FALSE;
for(TRIES = 1; TRIES <= NO_CARDS; TRIES += 1) {
if (DD_FLAGS[1, TRIES] == "Y") {
POST_ID = TODAYS_DATE + "*" + MEM_TYPE[1, TRIES];
if (!(MATREADU(ref DD_POST_REC, FL_DD_POST, POST_ID))) {
MAT(ref DD_POST_REC, "");
}
DD_POST_REC[DD_POST_AMT] = DD_POST_REC[DD_POST_AMT] + DD_AMOUNT;
DD_POST_REC[DD_POST_UNITS] = DD_POST_REC[DD_POST_UNITS] + 1;
DD_POST_REC[DD_POST_DATE] = DEBIT_DATE;
MATWRITE(DD_POST_REC, FL_DD_POST, POST_ID);
DONE = TRUE;
}
}
if (NOT(DONE)) {
POST_ID = TODAYS_DATE + "*" + MEM_TYPE[1, 1];
if (!(MATREADU(ref DD_POST_REC, FL_DD_POST, POST_ID))) {
MAT(ref DD_POST_REC, "");
}
DD_POST_REC[DD_POST_AMT] = DD_POST_REC[DD_POST_AMT] + DD_AMOUNT;
DD_POST_REC[DD_POST_UNITS] = DD_POST_REC[DD_POST_UNITS] + 1;
DD_POST_REC[DD_POST_DATE] = DEBIT_DATE;
MATWRITE(DD_POST_REC, FL_DD_POST, POST_ID);
}
}
}
/*  If payment Rejected Expire Membership. */
L7000();
SUBMEMS = MEM_REC[19];
NO_SUBMEMS = DCOUNT(SUBMEMS, VM);
PARENT_MEMBER_ID = MEMBER_ID;
for(TRIES = NO_SUBMEMS; TRIES <= 1; TRIES += -1) {
MEMBER_ID = SUBMEMS[1, TRIES];
if (READU(ref MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID)) {
L7000();
} else {
ERRMSG = "Sub Member " + MEMBER_ID + " located in " + PARENT_MEMBER_ID + " was not found and has been deleted. Please investigate and/or call Flex";
SUBMEMS = DELETE(PARENT_MEMBER_ID, 1, TRIES);
L2100();
}
}
MEMBER_ID = PARENT_MEMBER_ID;
if (READU(ref MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID)) {
MEM_REC[19] = SUBMEMS;
WRITE(MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID);
TRANS_LOG_REC = MEM_REC;
nrf0 = "W";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBER_ID);
}
} else {
ERRMSG = "Some money has already been paid *CHECK DETAILS*";
L2100();
TRANS_REC[TRANS_TYPE] = "POST ERROR - money already paid";
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
L9000();
/*  Update POSTing file */
}
} else {
ERRMSG = "Record/DebDate Not found possible cancel'tn";
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
TRANS_REC[TRANS_TYPE] = "POST ERROR - current debit date not in schedule";
L8000();
/*  Update TRANS rec & CONTROL TOTALS */
L9000();
/*  Update POSTing file */
}
return;
/* ******************************************************************** */
}
void L2100() {
/*  Error Reporting */
/* ******************************************************************** */
PRINTER_ON();
if (PRINT_ERROR_HEADER == TRUE || REPORT_POS > 60) {
if (REPORT_POS > 60) { PRINTCR(CHAR(12)); /*  FORM FEED */ }
PRINTCR(CENTREREC[1] + " - Direct Debit Posting Report for " + OCONV(DEBIT_DATE, COMMON.D2));
PRINTCR(OCONV(TODAYS_DATE, COMMON.D2));
PRINTCR(STR("=", 79));
PRINT();
REPORT_POS = 4;
PRINT_ERROR_HEADER = FALSE;
}
PRINTCR(FORMAT(DD_KEY, "L#14") + FORMAT(OCONV(DD_AMOUNT, COMMON.MD2), "R#10") + " - " + ERRMSG);
REPORT_POS = REPORT_POS + 1;
PRINTER_OFF();
return;
/* ******************************************************************** */
}
void L6000() {
/*  Generate new months & remove old debit req. */
/* ******************************************************************** */
NO_DDS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
if (NO_DDS - PAYMENT_POS <= NO_AFTER) {
LAST_SCHEDULED_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, NO_DDS];
if (LAST_SCHEDULED_DATE < DEBIT_DATE) {
nrf0 = 60;
nrf1 = DD_KEY + "SERIOUS ERROR";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
MONTH = OCONV(LAST_SCHEDULED_DATE, "DM");
YEAR = OCONV(LAST_SCHEDULED_DATE, "DY");
MONTH = MONTH + 12 / DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER];
if (MONTH > 12) {
MONTH = MOD(MONTH, 12);
if (MONTH == 0) { MONTH = 12; }
YEAR = YEAR + 1;
}
NEXT_DEBIT_DATE = ICONV(MEMBERS_DD_DAY + "/" + MONTH + "/" + YEAR, "D");
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, -1] = NEXT_DEBIT_DATE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, -1] = DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT];
if (FROZEN_ACCOUNT) {
/*            DIRECT.DEBIT.ADJ<1,DCOUNT(DIRECT.DEBIT.DATES,VM)> = -DIRECT.DEBIT.INST.AMOUNT */
/* DIRECT.DEBIT.ADJ.TYPE<1,DCOUNT(DIRECT.DEBIT.DATES,VM)> = "FZ" */
}
}
/*  Remove Old */
/*  If there are more than the required number of instalments to view */
/*  remove the first instalment */
DELVAL = 1;
/*      IF PAYMENT.POS > NO.BEFORE THEN */
if (PAYMENT_POS > NO_BEFORE && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, DELVAL] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, DELVAL] != 0) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, DELVAL);
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS], 1, DELVAL);
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ], 1, DELVAL);
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE], 1, DELVAL);
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID], 1, DELVAL);
DIRECT_DEBIT_REC[DIRECT_DEBIT_REJECTIONS] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_REJECTIONS], 1, DELVAL);
}
return;
/* ******************************************************************** */
}
void L7000() {
/*  If payment Rejected Expire Membership */
/* ******************************************************************** */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") { return; }
if (EXPIRE_ON_REJECTION == "Y") {
if (REJECTED == "Y") {
CARD_COUNT = DCOUNT(MEM_REC[13], VM);
for(CARD = 1; CARD <= CARD_COUNT; CARD += 1) {
MEM_REC[13, CARD] = TODAYS_DATE;
}
if (MEM_REC_EXISTS) {
WRITE(MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID);
TRANS_LOG_REC = MEM_REC;
nrf0 = "W";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBER_ID);
}
}
}
/*  check to see if last month's pymt was rejected - if so */
/*  need to warn that exp date is now being reset */
if (DD_EXP_LEEWAY != "" && DD_EXP_LEEWAY[1, 1] != "*" && NUM(DD_EXP_LEEWAY)) {
if (REJECTED != "Y") {
EXP_RESET = FALSE;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS - 1] == 0) {
CARD_COUNT = DCOUNT(MEM_REC[13], VM);
for(CARD = 1; CARD <= CARD_COUNT; CARD += 1) {
if (MEM_REC[13, CARD] < TODAYS_DATE - DD_EXP_LEEWAY) {
EXP_RESET = TRUE;
}
}
if (EXP_RESET) {
ERRMSG = "Exp date reset although previous payment rejected";
L2100();
}
}
/*            IF MEM.REC<13,1> < TODAYS.DATE + DD.EXP.LEEWAY THEN */
CARD_COUNT = DCOUNT(MEM_REC[13], VM);
if (!READV(ref DD_FLAGS, COMMON.FILES[FL_MEMBERS], MEMBER_ID, 39)) { DD_FLAGS = "Y"; }
if (DD_FLAGS == "" || DD_FLAGS == "N") { DD_FLAGS = "Y"; }
for(CARD = 1; CARD <= CARD_COUNT; CARD += 1) {
if (MEM_REC[13, CARD] < TODAYS_DATE + DD_EXP_LEEWAY && DD_FLAGS[1, CARD] == "Y") {
MEM_REC[13, CARD] = TODAYS_DATE + DD_EXP_LEEWAY;
}
}
if (MEM_REC_EXISTS) {
WRITE(MEM_REC, COMMON.FILES[FL_MEMBERS], MEMBER_ID);
TRANS_LOG_REC = MEM_REC;
nrf0 = "W";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBER_ID);
}
/*            END */
}
}
return;
/* ******************************************************************** */
}
void L8000() {
/*  Update FL.DDS.TRANS & Control Totals */
/* ******************************************************************** */
if (DD_REC_EXISTS == FALSE) {
SEQNO = 1;
UNIQUE_ID = FALSE;
do {
if (UNIQUE_ID) break;
TRANS_ID = DD_KEY + "*ERROR" + SEQNO;
if (READ(ref TEST_REC, FL_DDS_TRANS, TRANS_ID)) {
SEQNO = SEQNO + 1;
} else {
UNIQUE_ID = TRUE;
}
} while (true);
} else {
DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] = DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] + 1;
TRANS_ID = DD_KEY + "*" + DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT];
}
TRANS_REC[TRANS_DATE] = TODAYS_DATE;
TRANS_REC[TRANS_USER] = U_INITS;
TRANS_REC[TRANS_ADJ] = DD_AMOUNT;
TRANS_REC[TRANS_DATES] = DEBIT_DATE;
MATWRITE(TRANS_REC, FL_DDS_TRANS, TRANS_ID);
if (READ(ref TRANS_LOG_REC, FL_DDS_TRANS, TRANS_ID)) {
nrf0 = "W";
nrf1 = "FL.DDS.TRANS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TRANS_ID);
}
if (REJECTED == "Y" && UPDATE_DEBTORS == "Y") {
MATWRITE(DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID);
if (READ(ref TRANS_LOG_REC, FL_DD_DEBTORS, DD_DEBTOR_ID)) {
nrf0 = "W";
nrf1 = "FL.DD.DEBTORS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_DEBTOR_ID);
}
}
if (DD_REC_EXISTS) {
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
}
RELEASE();
CONTROL_TOTALS[3] = CONTROL_TOTALS[3] + 1;
PRINTCR(AT(10, 16) + "Rejections : " + REJECTIONS);
PRINTCR(AT(10, 17) + "Processing : " + CONTROL_TOTALS[3]);
CONTROL_TOTALS[4] = CONTROL_TOTALS[4] + DD_AMOUNT;
return;
/* ******************************************************************** */
}
void L9000() {
/*  Update POSTing file */
/* ******************************************************************** */
MEM_TYPE = "ERROR";
POST_ID = TODAYS_DATE + "*" + MEM_TYPE;
if (!(MATREADU(ref DD_POST_REC, FL_DD_POST, POST_ID))) {
MAT(ref DD_POST_REC, "");
}
DD_POST_REC[DD_POST_AMT] = DD_POST_REC[DD_POST_AMT] + DD_AMOUNT;
DD_POST_REC[DD_POST_UNITS] = DD_POST_REC[DD_POST_UNITS] + 1;
DD_POST_REC[DD_POST_DATE] = DEBIT_DATE;
MATWRITE(DD_POST_REC, FL_DD_POST, POST_ID);
if (READ(ref TRANS_LOG_REC, FL_DD_POST, POST_ID)) {
nrf0 = "W";
nrf1 = "FL.DD.POST";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref POST_ID);
}
return;
/* ******************************************************************** */
}
void L0200() {
/*  Process ADJUSTED accounts */
/* ******************************************************************** */
EOF = FALSE;
STATEMENT = "SELECT FL.DIRECT.DEBITS WITH FROZEN = \"\" AND WITH CANCELLED = \"\"";
nrf0 = "OS";
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref STATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref DD_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
DAY = OCONV(DEBIT_DATE, "DD");
MONTH = OCONV(DEBIT_DATE, "DM");
YEAR = OCONV(DEBIT_DATE, "DY");
MONTH = MONTH + 12 / DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER];
if (MONTH > 12) {
MONTH = MOD(MONTH, 12);
if (MONTH == 0) { MONTH = 12; }
YEAR = YEAR + 1;
}
NEXT_RUN_DATE = ICONV(DAY + "/" + MONTH + "/" + YEAR, "D");
LAST_POS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
LAST_DATE = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, LAST_POS];
if (LOCATE(DEBIT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) {
MEMBER_ID = FIELD(DD_KEY, "*", 2);
/* *!                 READV MEMBERS.DD.DAY FROM FL.MEMBERS,MEMBER.ID,34 ELSE */
/* *!                    MEMBERS.DD.DAY = OCONV(DIRECT.DEBIT.DATES<1,1>,'DD') */
/* *!                 END */
if (!READV(ref MEMBERS_DD_DAY, COMMON.FILES[FL_MEMBERS], MEMBER_ID, 34)) { MEMBERS_DD_DAY = ""; }
if (MEMBERS_DD_DAY == "") {
MEMBERS_DD_DAY = OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, 1], "DD");
}
L6000();
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
}
}
} while (true);
}
return;
/* ******************************************************************** */
/*  End of Program */
/* ******************************************************************** */
}
}
}
