//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL122 : UvBase
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MEMBER_STAGE_PAYMENTS = 100;
readonly UvVar MEM_SP_ORIGINAL_FEE = 1;
readonly UvVar MEM_SP_NO_OF_INSTALMENTS = 2;
readonly UvVar MEM_SP_BALANCE = 3;
readonly UvVar MEM_SP_PAYMENTS = 4;
readonly UvVar MEM_SP_DATES = 5;
readonly UvVar MEM_SP_TICKETS = 6;
readonly UvVar MEM_SP_NEXT_DUE_DATE = 7;
readonly UvVar SP_LAST_SEQ_NO = 1;
readonly UvVar SP_USED_SEQUENCES = 2;
readonly UvVar SP_SEQ_BALANCES = 3;
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
readonly UvVar TRANS_DATE = 1;
readonly UvVar TRANS_USER = 2;
readonly UvVar TRANS_ADJ = 3;
readonly UvVar TRANS_DATES = 4;
readonly UvVar TRANS_TYPE = 5;
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
readonly UvVar CASH_DEBIT_INST_AMOUNT = 1;
readonly UvVar CASH_DEBIT_ANNUAL_FEE = 2;
readonly UvVar CASH_DEBIT_LETTER = 3;
readonly UvVar CASH_DEBIT_ORIGINAL_DATE = 4;
readonly UvVar CASH_DEBIT_NUMBER = 5;
readonly UvVar CASH_DEBIT_AMOUNTS = 6;
readonly UvVar CASH_DEBIT_DATES = 7;
readonly UvVar CASH_DEBIT_OPERATOR = 8;
readonly UvVar CASH_DEBIT_ADJ = 9;
readonly UvVar CASH_DEBIT_PAID = 10;
readonly UvVar CASH_DEBIT_TRANS_CNT = 11;
readonly UvVar CASH_DEBIT_LAST_REQ_AMOUNT = 12;
readonly UvVar CASH_DEBIT_LAST_DATE = 13;
readonly UvVar CASH_DEBIT_LAST_RECD_AMOUNT = 14;
readonly UvVar CASH_DEBIT_CANCELLED_DATE = 15;
readonly UvVar CASH_DEBIT_DEPOSIT = 16;
readonly UvVar CASH_DEBIT_ADJ_TYPE = 18;
readonly UvVar CASH_DEBIT_FREEZE_DATE = 19;
readonly UvVar FL_MEMBER_PARAMS = 64;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] MEM_SP_REC = new UvVar[10];
UvVar[] SP_CONTROL_REC = new UvVar[5];
UvVar[] BANK_REC = new UvVar[10];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] TRANS_REC = new UvVar[10];
UvVar[] AUDDIS_LOG_REC = new UvVar[20];
UvVar[] BACS_LODGEMENTS_REC = new UvVar[10];
UvVar[] CASH_DEBIT_REC = new UvVar[20];
#endregion
#region Variables
UvVar SOURCE = "";
UvVar DIRECT_DEBIT = "";
UvVar IDENTIFIER = "";
UvVar ORIGINAL_FEE = "";
UvVar DEPOSIT = "";
UvVar DEPOSIT_TICKET = "";
UvVar NO_OF_INSTALMENTS = "";
UvVar NEXT_DUE_DATE = "";
UvVar CALLING_TYPE = "";
UvVar START_DATE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar ERROR_MSG = "";
UvVar FL_MEM_SP_CONTROL = "";
UvVar FL_DDS_TRANS = "";
UvVar FL_AUDDIS_LOG = "";
UvVar MESSAGE = "";
FL006 FL006;
UvVar FL_BACS_LODGEMENTS = "";
UvVar FL_CASH_DEBITS = "";
UvVar FL_CASH_TRANS = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar LOG_AUDDIS = "";
UvVar AUDDIS_CONTROL = "";
UvVar STAGE_PAYMENT = "";
UvVar NEWDD = "";
UvVar ZZZ_STATUS = "";
UvVar REJOIN = "";
UvVar MULTIPLE_TYPES = "";
UvVar BACS_CONTROL = "";
UvVar DAYS_OF_MONTH = "";
UvVar DAY_OF_MONTH = "";
UvVar POS = "";
UvVar DATE_LAST_RUN = "";
UvVar MTH = "";
UvVar YR = "";
UvVar DATE_NEXT_RUN = "";
UvVar BANK_ID = "";
UvVar SUPPRESS_BANKDETS = "";
FL121 FL121;
UvVar IDENT = "";
UvVar ORIG_DD_STATUS = "";
UvVar WAIT = "";
UvVar CREATE_NEW = "";
UvVar EACH_ADJ = "";
UvVar LODGE_CONTROL_REC = "";
UvVar LAST_LODGE_DATE = "";
FLTX2 FLTX2;
UvVar ANSWER = "";
UvVar TOTAL_ADJS = "";
UvVar ADJ_COUNT = "";
UvVar WARNING = "";
UvVar NUMPAYS = "";
UvVar NEXT_POS = "";
UvVar PAYMENT_POS = "";
UvVar INSTALMENT1 = "";
UvVar MONTH = "";
UvVar YEAR = "";
UvVar INST = "";
UvVar END_POS = "";
UvVar TRANSFER_DATE = "";
UvVar TRANS_ID = "";
UvVar FLEX = "";
UvVar NO_OF_SEQS = "";
UvVar NEW_SEQ_NO = "";
UvVar MEM_SP_ID = "";
UvVar SEQUENCE = "";
UvVar NEW_BALANCE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL122(ref UvVar SOURCE, ref UvVar DIRECT_DEBIT, ref UvVar IDENTIFIER, ref UvVar ORIGINAL_FEE, ref UvVar DEPOSIT, ref UvVar DEPOSIT_TICKET, ref UvVar NO_OF_INSTALMENTS, ref UvVar NEXT_DUE_DATE, ref UvVar CALLING_TYPE, ref UvVar START_DATE, ref UvVar STATUS()) {
this.SOURCE = SOURCE;
this.DIRECT_DEBIT = DIRECT_DEBIT;
this.IDENTIFIER = IDENTIFIER;
this.ORIGINAL_FEE = ORIGINAL_FEE;
this.DEPOSIT = DEPOSIT;
this.DEPOSIT_TICKET = DEPOSIT_TICKET;
this.NO_OF_INSTALMENTS = NO_OF_INSTALMENTS;
this.NEXT_DUE_DATE = NEXT_DUE_DATE;
this.CALLING_TYPE = CALLING_TYPE;
this.START_DATE = START_DATE;
this.STATUS() = STATUS();
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
/*   Routine to set up Stage Payments/Direct Debit records */
PROGRAM = "FL122";
ERROR_MSG = "NO BANK DETAILS HAVE BEEN SETUP ";
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MEMBER.STAGE.PAYMENTS

#endregion
#region INCLUDE FL.FILES FL.MEM.SP.CONTROL

if (!(OPEN("FL.MEM.SP.CONTROL", out FL_MEM_SP_CONTROL))) {
STOP(201, "FL.MEM.SP.CONTROL");
}

#endregion
#region INCLUDE FL.FILES FL.BANK.DETAILS

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.DDS.TRANS

if (!OPEN("FL.DDS.TRANS", out FL_DDS_TRANS)) { STOP("201", "FL.DDS.TRANS"); }

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
#region INCLUDE FL.FILES FL.CASH.DEBITS

if (!OPEN("FL.CASH.DEBITS", out FL_CASH_DEBITS)) { STOP(201); }

#endregion
#region INCLUDE FL.FILES FL.CASH.TRANS

if (!(OPEN("FL.CASH.TRANS", out FL_CASH_TRANS))) {
EXECUTE("CREATE-FILE FL.CASH.TRANS 1 101", MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN("FL.CASH.TRANS", out FL_CASH_TRANS))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}

#endregion
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
LOG_AUDDIS = FALSE;
if (READ(ref AUDDIS_CONTROL, DFL_DIRECT_DEBITS, "AUDDIS.CONTROL")) {
LOG_AUDDIS = TRUE;
}
STAGE_PAYMENT = FALSE;
NEWDD = FALSE;
ZZZ_STATUS = "";
REJOIN = FALSE;
MULTIPLE_TYPES = FALSE;
if (READV(ref MULTIPLE_TYPES, COMMON.FILES[FL_CONTROL], "AUTOMATIC.CONCESS", 11)) {
MULTIPLE_TYPES = MULTIPLE_TYPES[1, 1];
if (MULTIPLE_TYPES == "Y") { MULTIPLE_TYPES = TRUE; } else { MULTIPLE_TYPES = FALSE; }
}
MAT(ref DIRECT_DEBIT_REC, "");
// BEGIN CASE
// CASE
if (DIRECT_DEBIT == "Y") {
/*  Read in BACS Control parameters */
if (!(READ(ref BACS_CONTROL, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ZZZ_STATUS = "ERROR";
return;
}
DAYS_OF_MONTH = BACS_CONTROL[1];
DAY_OF_MONTH = OCONV(START_DATE, COMMON.D2).Substring(1, 2);
if (!(LOCATE(DAY_OF_MONTH, DAYS_OF_MONTH, 1, 0, 1, ref POS, "AL"))) {
nrf0 = 33;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
DATE_LAST_RUN = BACS_CONTROL[3, POS];
MTH = OCONV(DATE_LAST_RUN, "DM");
YR = OCONV(DATE_LAST_RUN, "DY");
MTH = MTH + 1;
if (MTH > 12) {
MTH = 1;
YR = YR + 1;
}
DATE_NEXT_RUN = DAY_OF_MONTH + "/" + MTH + "/" + YR;
DATE_NEXT_RUN = ICONV(DATE_NEXT_RUN, "D2/");
INTERACT = VALID_DATA;
/*  Read in member's Direct Debit details */
BANK_ID = SOURCE + "*" + IDENTIFIER;
if (!(MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID))) {
MAT(ref BANK_REC, "");
SUPPRESS_BANKDETS = FALSE;
if (READV(ref SUPPRESS_BANKDETS, COMMON.FILES[FL_MEMBER_PARAMS], "SUPPRESS.BANKDETS", 1)) {
if (SUPPRESS_BANKDETS == "Y" || SUPPRESS_BANKDETS == 1) { SUPPRESS_BANKDETS = TRUE; } else { SUPPRESS_BANKDETS = FALSE; }
}
// BEGIN CASE
// CASE
if (SUPPRESS_BANKDETS == TRUE) {
NULL();
}// CASE
else if (OTHERWISE) {
FL121 = new FL121(ref SOURCE, ref IDENTIFIER, ref INTERACT, ref PROGRAM);
}
// END CASE
}
if (BANK_REC[BANK_INSTALL_RECORDS] == "") { BANK_REC[BANK_INSTALL_RECORDS] = 1; }
IDENT = BANK_ID + "*" + BANK_REC[BANK_INSTALL_RECORDS];
if (!(MATREADU(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], IDENT))) {
MAT(ref DIRECT_DEBIT_REC, "");
NEWDD = TRUE;
}
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
/*  Deal with cancelled debits */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Direct Debit has been re-instated - hit <RETURN> ");
INPUT(out WAIT, 1);
PRINT(SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
REJOIN = TRUE;
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCEL_REASON] = "";
CREATE_NEW = BACS_CONTROL[19];
if (CREATE_NEW == "Y") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_REJECTIONS] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE] = "";
} else {
if (LOCATE(START_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref POS, "AL")) {
for(EACH_ADJ = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM); EACH_ADJ <= POS; EACH_ADJ += -1) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ], 1, EACH_ADJ);
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE] = DELETE(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE], 1, EACH_ADJ);
}
}
}
/*  Auddis */
if (LOG_AUDDIS) {
if (READ(ref LODGE_CONTROL_REC, FL_BACS_LODGEMENTS, IDENTIFIER)) {
LAST_LODGE_DATE = LODGE_CONTROL_REC[1];
if (MATREAD(ref BACS_LODGEMENTS_REC, FL_BACS_LODGEMENTS, IDENTIFIER + "*" + LAST_LODGE_DATE)) {
// BEGIN CASE
// CASE
if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0C") {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER)) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, IDENTIFIER);
WRITEV("01", COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER, 6);
}
}// CASE
else if (BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0N" || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0C/0N" || BACS_LODGEMENTS_REC[BACS_LODGEMENTS_TRANS_CODE] == "0S") {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER)) {
if (BANK_REC[BANK_SORT_CODE] != BACS_LODGEMENTS_REC[BACS_LODGEMENTS_SORTCODE] || BANK_REC[BANK_ACCOUNT_NO] != BACS_LODGEMENTS_REC[BACS_LODGEMENTS_ACCNO]) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0C/0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, IDENTIFIER);
WRITEV("01", COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER, 6);
} else {
DELETE(FL_AUDDIS_LOG, IDENTIFIER);
}
} else {
DELETE(FL_AUDDIS_LOG, IDENTIFIER);
}
}
// END CASE
}
} else {
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER)) {
MAT(ref AUDDIS_LOG_REC, "");
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNAME] = BANK_REC[BANK_ACCOUNT_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_SORTCODE] = BANK_REC[BANK_SORT_CODE];
AUDDIS_LOG_REC[AUDDIS_LOG_ACCNO] = BANK_REC[BANK_ACCOUNT_NO];
AUDDIS_LOG_REC[AUDDIS_LOG_BANKNAME] = BANK_REC[BANK_NAME];
AUDDIS_LOG_REC[AUDDIS_LOG_TRANS_CODE] = "0N";
MATWRITE(AUDDIS_LOG_REC, FL_AUDDIS_LOG, IDENTIFIER);
WRITEV("01", COMMON.FILES[FL_BANK_DETAILS], "1*" + IDENTIFIER, 6);
}
}
}
}
/*  Deal with any cash schedules */
if (MATREADU(ref CASH_DEBIT_REC, FL_CASH_DEBITS, IDENTIFIER)) {
CASH_DEBIT_REC[CASH_DEBIT_CANCELLED_DATE] = TODAYS_DATE;
MATWRITE(CASH_DEBIT_REC, FL_CASH_DEBITS, IDENTIFIER);
if (READ(ref TRANS_LOG_REC, FL_CASH_DEBITS, IDENTIFIER)) {
nrf0 = "W";
nrf1 = "FL.CASH.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref IDENTIFIER);
}
ZZZ_STATUS = "CANCELLED-CASH";
}
/*  Deal with frozen debits */
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] < TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] > TODAYS_DATE) {
PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Direct Debit has been frozen - reinstate ? (Y/N) ");
INPUT(out ANSWER, 2);
PRINT(SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
if (ANSWER != "Y") { ZZZ_STATUS = "ERROR"; return; }
DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] = "";
TOTAL_ADJS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ], VM);
ADJ_COUNT = 0;
for(EACH_ADJ = 1; EACH_ADJ <= TOTAL_ADJS; EACH_ADJ += 1) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, EACH_ADJ] == "FZ") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ][1, EACH_ADJ] = "";
DIRECT_DEBIT_REC[DIRECT_DEBIT_ADJ_TYPE][1, EACH_ADJ] = "";
} else {
ADJ_COUNT = ADJ_COUNT + 1;
}
}
if (ADJ_COUNT != 0) {
PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "WARNING! Adjustments present - check they are still valid ");
INPUT(out WARNING, 1);
PRINT(SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
}
}
/*  Validate Start date and adjust if neccessary */
NUMPAYS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
if (START_DATE <= DATE_LAST_RUN) {
nrf0 = 11;
nrf1 = OCONV(DATE_NEXT_RUN, "D2");
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
START_DATE = DATE_NEXT_RUN;
}
if (!LOCATE(DATE_NEXT_RUN, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref NEXT_POS, "AR")) { NULL(); }
/* **************************************** */
/*  remove any checks for existing schedule */
/*         BEGIN CASE */
/*         CASE START.DATE > DATE.NEXT.RUN AND DIRECT.DEBIT.ORIGINAL.DATE # ""  AND NEXT.POS > NUMPAYS */
/*   old dates only */
/*   not a cancelled/frozen schedule */
/*   start date is in future */
/* IF NEXT.POS > NUMPAYS THEN */
/*            PRINT ERR.LINE:ERR.MESS.BACK:ERR.MESS.FORE: */
/*            PRINT @(2,23):SPACE(SCREEN.WIDTH - 2): */
/*            PRINT @(2,23):"This debit has expired - new dates will be set up from ": */
/*            PRINT OCONV(START.DATE,'D2/'): */
/*            INPUT WAIT,1: */
/*            PRINT SCREEN.BACK:SCREEN.TEXT:CLR.ERR: */
/*            DIRECT.DEBIT.DATES = "" */
/*            DIRECT.DEBIT.AMOUNTS = "" */
/*            DIRECT.DEBIT.ADJ = "" */
/*            DIRECT.DEBIT.PAID = "" */
/*            DIRECT.DEBIT.ADJ.TYPE = "" */
/*            DIRECT.DEBIT.REJECTIONS = "" */
/* CASE START.DATE > DATE.NEXT.RUN AND DIRECT.DEBIT.ORIGINAL.DATE # "" AND NEXT.POS <= NUMPAYS */
/*   start date in future */
/*   not a cancelled/frozen schedule */
/*   current on-going dates in schedule */
/* PRINT ERR.LINE:ERR.MESS.BACK:ERR.MESS.FORE: */
/* PRINT @(2,23):SPACE(SCREEN.WIDTH - 2): */
/* PRINT @(2,23):"Invalid start date - this is an on-going schedule ! ": */
/* INPUT WAIT,1: */
/* PRINT SCREEN.BACK:SCREEN.TEXT:CLR.ERR: */
/* STATUS = "ERROR" */
/* RETURN */
/*         CASE NEXT.POS > NUMPAYS AND DIRECT.DEBIT.ORIGINAL.DATE # "" AND START.DATE = DATE.NEXT.RUN */
/*   old dates */
/*   not a cancelled/frozen schedule */
/*   start date current */
/*            DIRECT.DEBIT.DATES = "" */
/*            DIRECT.DEBIT.AMOUNTS = "" */
/*            DIRECT.DEBIT.ADJ = "" */
/*            DIRECT.DEBIT.PAID = "" */
/*            DIRECT.DEBIT.ADJ.TYPE = "" */
/*            DIRECT.DEBIT.REJECTIONS = "" */
/*            DIRECT.DEBIT.ORIGINAL.DATE = "" */
/*         END CASE */
/* ************************************************ */
DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT] = DEPOSIT;
DIRECT_DEBIT_REC[DIRECT_DEBIT_DEPOSIT][1, 3] = DEPOSIT_TICKET;
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_ORIGINAL_DATE] = START_DATE;
/*            NUMPAYS = 3 */
NUMPAYS = 4;
/*            DIRECT.DEBIT.DEPOSIT = DEPOSIT */
/*            DIRECT.DEBIT.DEPOSIT<1,3> = DEPOSIT.TICKET */
/*            PAYMENT.POS =1 */
if (!LOCATE(START_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) { NULL(); }
} else {
NUMPAYS = DCOUNT(DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], VM);
if (!LOCATE(START_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) { NULL(); }
}
if (NO_OF_INSTALMENTS == "") { NO_OF_INSTALMENTS = 12; }
if (INT(12 / NO_OF_INSTALMENTS) != (12 / NO_OF_INSTALMENTS)) {
NO_OF_INSTALMENTS = 12;
}
/* AMD.REC<24> = NO.OF.INSTALMENTS */
/* NEW.INST.AMT = INT(ORIGINAL.FEE/NO.OF.INSTALMENTS) */
/* IF DIRECT.DEBIT.INST.AMOUNT # "" AND NEW.INST.AMT # DIRECT.DEBIT.INST.AMOUNT THEN */
/* END */
DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT] = INT((ORIGINAL_FEE) / NO_OF_INSTALMENTS);
INSTALMENT1 = ORIGINAL_FEE - (DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT] * (NO_OF_INSTALMENTS - 1));
DIRECT_DEBIT_REC[DIRECT_DEBIT_ANNUAL_FEE] = ORIGINAL_FEE;
/*         DIRECT.DEBIT.DEPOSIT = DEPOSIT:VM:DEPOSIT.TICKET */
DIRECT_DEBIT_REC[DIRECT_DEBIT_NUMBER] = NO_OF_INSTALMENTS;
/*  Set up base record */
/*  Calculate Direct Debit dates */
MONTH = OCONV(START_DATE, "DM");
YEAR = OCONV(START_DATE, "DY");
/*  add the remaining instalments (if new only do the number of debits */
/*  required after + the current) */
/* ** */
/*  second attempt !   FOR INST = PAYMENT.POS TO NUMPAYS + 3 */
/*  first attempt !   FOR INST = PAYMENT.POS TO PAYMENT.POS + 3 */
if (PAYMENT_POS + 3 < NUMPAYS) { END_POS = NUMPAYS; } else { END_POS = PAYMENT_POS + 3; }
for(INST = PAYMENT_POS; INST <= END_POS; INST += 1) {
TRANSFER_DATE = DAY_OF_MONTH + "." + MONTH + "." + YEAR;
TRANSFER_DATE = ICONV(TRANSFER_DATE, "D4/");
DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES][1, INST] = TRANSFER_DATE;
if (INST == PAYMENT_POS) {
/*               DIRECT.DEBIT.AMOUNTS<1,INST>= INSTALMENT1 - DIRECT.DEBIT.ADJ<1,INST> */
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, INST] = INSTALMENT1;
} else {
/*               DIRECT.DEBIT.AMOUNTS<1,INST> = DIRECT.DEBIT.INST.AMOUNT - DIRECT.DEBIT.ADJ<1,INST> */
DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS][1, INST] = DIRECT_DEBIT_REC[DIRECT_DEBIT_INST_AMOUNT];
}
MONTH = MONTH + 12 / NO_OF_INSTALMENTS;
if (MONTH > 12) {
/*               MONTH = MOD(MONTH,12) + 1 */
MONTH = MOD(MONTH, 12);
if (MONTH == 0) { MONTH = 12; }
YEAR = YEAR + 1;
}
}
// BEGIN CASE
// CASE
if (NEWDD) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "Y";
}// CASE
else if (REJOIN) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "Y";
}// CASE
else if (ORIG_DD_STATUS == "CANCELLED" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "UC";
}// CASE
else if (ORIG_DD_STATUS == "LIVE" && DIRECT_DEBIT_REC[DIRECT_DEBIT_CANCELLED_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "C";
}// CASE
else if (ORIG_DD_STATUS == "FROZEN" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] == "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "UF";
}// CASE
else if (ORIG_DD_STATUS == "LIVE" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "F";
}// CASE
else if (OTHERWISE) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_LETTER] = "N";
}
// END CASE
DIRECT_DEBIT_REC[DIRECT_DEBIT_OPERATOR] = U_INITS;
if (INTERACT == VALID_DATA) {
DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] = DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT] + 1;
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], IDENT);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], IDENT)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref IDENT);
}
if (CALLING_TYPE != "NEW-FL531" && CALLING_TYPE != "FL525" && CALLING_TYPE != "FL0001.1.1") {
WRITEV(BANK_REC[BANK_INSTALL_RECORDS], COMMON.FILES[FL_BANK_DETAILS], BANK_ID, 4);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_ID)) {
nrf0 = "W";
nrf1 = "FL.BANK.DETAILS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BANK_ID);
}
}
MAT(ref TRANS_REC, "");
TRANS_REC[TRANS_DATE] = TODAYS_DATE;
TRANS_REC[TRANS_USER] = U_INITS;
/*            IF NEWDD = TRUE THEN */
/*               TRANS.TYPE = "NEW DD - ":CALLING.TYPE */
/*            END ELSE */
/*               TRANS.TYPE = CALLING.TYPE */
/*            END */
// BEGIN CASE
// CASE
if (NEWDD == TRUE && ZZZ_STATUS == "CANCELLED-CASH") {
TRANS_REC[TRANS_TYPE] = "NEW DD CONVERTED FROM CASH - " + CALLING_TYPE;
}// CASE
else if (NEWDD == TRUE) {
TRANS_REC[TRANS_TYPE] = "NEW DD - " + CALLING_TYPE;
}// CASE
else if (REJOIN == TRUE) {
TRANS_REC[TRANS_TYPE] = "REJOIN - " + CALLING_TYPE;
}// CASE
else if (NOT(NEWDD)) {
TRANS_REC[TRANS_TYPE] = CALLING_TYPE;
}
// END CASE
TRANS_REC[TRANS_ADJ] = DIRECT_DEBIT_REC[DIRECT_DEBIT_AMOUNTS];
TRANS_REC[TRANS_DATES] = DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES];
TRANS_ID = IDENT + "*" + DIRECT_DEBIT_REC[DIRECT_DEBIT_TRANS_CNT];
MATWRITE(TRANS_REC, FL_DDS_TRANS, TRANS_ID);
if (READ(ref TRANS_LOG_REC, FL_DDS_TRANS, TRANS_ID)) {
nrf0 = "W";
nrf1 = "FL.DDS.TRANS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TRANS_ID);
}
} else {
PRINT(AT(0, 23) + "YOU MUST SET UP BANK DETAILS OR REMOVE DIRECT DEBIT INDICATOR");
INPUT(out FLEX, 1);
WRITEV(ERROR_MSG, COMMON.FILES[FL_DIRECT_DEBITS], IDENT, 8);
}
}// CASE
else if (DIRECT_DEBIT == "N" && STAGE_PAYMENT == TRUE) {
if (CALLING_TYPE == "NEW") {
MAT(ref MEM_SP_REC, "");
MAT(ref SP_CONTROL_REC, "");
MEM_SP_REC[MEM_SP_ORIGINAL_FEE] = ORIGINAL_FEE;
MEM_SP_REC[MEM_SP_BALANCE] = ORIGINAL_FEE - DEPOSIT;
MEM_SP_REC[MEM_SP_PAYMENTS] = DEPOSIT;
MEM_SP_REC[MEM_SP_DATES] = TODAYS_DATE;
MEM_SP_REC[MEM_SP_TICKETS] = DEPOSIT_TICKET;
MEM_SP_REC[MEM_SP_NO_OF_INSTALMENTS] = NO_OF_INSTALMENTS;
MEM_SP_REC[MEM_SP_NEXT_DUE_DATE] = NEXT_DUE_DATE;
IDENT = IDENTIFIER + "*1";
MATWRITE(MEM_SP_REC, COMMON.FILES[FL_MEMBER_STAGE_PAYMENTS], IDENT);
if (!(READ(ref TRANS_LOG_REC, COMMON.FILES[FL_MEMBER_STAGE_PAYMENTS], IDENT))) {
TRANS_LOG_REC = "";
}
nrf0 = "W";
nrf1 = "FL.MEMBER.STAGE.PAYMENTS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref IDENT);
SP_CONTROL_REC[SP_LAST_SEQ_NO] = "1";
SP_CONTROL_REC[SP_USED_SEQUENCES] = 1;
SP_CONTROL_REC[SP_SEQ_BALANCES] = ORIGINAL_FEE - DEPOSIT;
MATWRITE(SP_CONTROL_REC, FL_MEM_SP_CONTROL, IDENTIFIER);
if (!(READ(ref TRANS_LOG_REC, FL_MEM_SP_CONTROL, IDENTIFIER))) {
TRANS_LOG_REC = "";
}
nrf0 = "W";
nrf1 = "FL.MEM.SP.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref IDENTIFIER);
} else {
MAT(ref MEM_SP_REC, INIT);
if (!(MATREAD(ref SP_CONTROL_REC, FL_MEM_SP_CONTROL, IDENTIFIER))) {
MAT(ref SP_CONTROL_REC, INIT);
}
NO_OF_SEQS = DCOUNT(SP_CONTROL_REC[SP_USED_SEQUENCES], VM);
NEW_SEQ_NO = SP_CONTROL_REC[SP_LAST_SEQ_NO] + 1;
MEM_SP_ID = IDENTIFIER + "*" + NEW_SEQ_NO;
for(SEQUENCE = NO_OF_SEQS; SEQUENCE <= 1; SEQUENCE += -1) {
if (SP_CONTROL_REC[SP_SEQ_BALANCES][1, SEQUENCE] < 0) {
MEM_SP_REC[MEM_SP_BALANCE] = MEM_SP_REC[MEM_SP_BALANCE] + SP_CONTROL_REC[SP_SEQ_BALANCES][1, SEQUENCE];
MEM_SP_REC[MEM_SP_PAYMENTS][1, -1] = SP_CONTROL_REC[SP_SEQ_BALANCES][1, SEQUENCE];
MEM_SP_REC[MEM_SP_DATES][1, -1] = TODAYS_DATE;
MEM_SP_REC[MEM_SP_TICKETS][1, -1] = "CF.AMOUNT." + SP_CONTROL_REC[SP_USED_SEQUENCES][1, SEQUENCE];
SP_CONTROL_REC[SP_SEQ_BALANCES][1, SEQUENCE] = 0;
}
}
MEM_SP_REC[MEM_SP_ORIGINAL_FEE] = ORIGINAL_FEE;
MEM_SP_REC[MEM_SP_NO_OF_INSTALMENTS] = NO_OF_INSTALMENTS;
NEW_BALANCE = ORIGINAL_FEE - DEPOSIT;
MEM_SP_REC[MEM_SP_BALANCE] = MEM_SP_REC[MEM_SP_BALANCE] + NEW_BALANCE;
MEM_SP_REC[MEM_SP_PAYMENTS][1, -1] = DEPOSIT;
MEM_SP_REC[MEM_SP_DATES][1, -1] = TODAYS_DATE;
MEM_SP_REC[MEM_SP_TICKETS][1, -1] = DEPOSIT_TICKET;
MEM_SP_REC[MEM_SP_NEXT_DUE_DATE] = NEXT_DUE_DATE;
MATWRITE(MEM_SP_REC, COMMON.FILES[FL_MEMBER_STAGE_PAYMENTS], MEM_SP_ID);
if (!(READ(ref TRANS_LOG_REC, COMMON.FILES[FL_MEMBER_STAGE_PAYMENTS], MEM_SP_ID))) {
TRANS_LOG_REC = "";
}
nrf0 = "W";
nrf1 = "FL.MEMBER.STAGE.PAYMENTS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEM_SP_ID);
/*          FOR SEQUENCE = NO.OF.SEQS TO 1 STEP - 1 */
/*            IF SP.SEQ.BALANCES<1,SEQUENCE> = 0 THEN */
/*              SP.USED.SEQUENCES = DELETE(SP.USED.SEQUENCES,1,SEQUENCE) */
/*              SP.SEQUENCE.BALANCES = DELETE(SP.SEQUENCE.BALANCES,1,SEQUENCE) */
/*            END */
/*          NEXT SEQUENCE */
SP_CONTROL_REC[SP_LAST_SEQ_NO] = NEW_SEQ_NO;
SP_CONTROL_REC[SP_USED_SEQUENCES][1, -1] = NEW_SEQ_NO;
SP_CONTROL_REC[SP_SEQ_BALANCES][1, -1] = MEM_SP_REC[MEM_SP_BALANCE];
MATWRITE(SP_CONTROL_REC, FL_MEM_SP_CONTROL, IDENTIFIER);
if (!(READ(ref TRANS_LOG_REC, FL_MEM_SP_CONTROL, IDENTIFIER))) {
TRANS_LOG_REC = "";
}
nrf0 = "W";
nrf1 = "FL.MEM.SP.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref IDENTIFIER);
}
}
// END CASE
RELEASE();
return;
}
}
}