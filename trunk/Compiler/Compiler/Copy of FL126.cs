//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL126 : UvBase
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
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
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] DD_WORK_REC = new UvVar[15];
#endregion
#region Variables
UvVar TYPE = "";
UvVar REFERENCE = "";
UvVar CALLING_PROG = "";
UvVar MACHINE_TYPE = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar DEBIT_SETS = "";
UvVar DEBIT_NUMBER = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar EXEC_PROG = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar FL_DDS_TRANS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_DD_WORK = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar DONE = "";
UvVar REQUEST_REPORT = "";
UvVar DDREC_REQUIRED = "";
UvVar ONE_PASS = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar ANS = "";
UvVar MEMBER_REQD = "";
UvVar TICKET_REC = "";
UvVar RUN_CHECKS = "";
FL103 FL103;
UvVar REQUIRED_ID = "";
FL006 FL006;
UvVar MEM_REC = "";
UvVar NAME = "";
FL126_1 FL126_1;
UvVar DEBIT_LIST = "";
UvVar DD_DAY = "";
UvVar WNDO_DATA_POS = "";
UvVar VALID_INPUT = "";
UvVar REPLY = "";
UvVar VALID_CODE = "";
UvVar CODE = "";
UvVar CONTROL_TOTAL = "";
UvVar ZZZ_QUOTE = "";
UvVar OPTS = "";
UvVar INSTR = "";
UvVar FILE_NAME = "";
UvVar CENTRENAME = "";
UvVar DD_LAST_RUN_DATE = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXEC_PROG CallAt_EXEC_PROG;
UvVar BACS_CONTROL_REC = "";
UvVar DD_STAGE_PARAM = "";
UvVar DD_STAGE = "";
FL306 FL306;
UvVar DATE_REQ = "";
UvVar POS = "";
UvVar DFL_DD_WORK = "";
FLTX2 FLTX2;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL126(ref UvVar TYPE, ref UvVar REFERENCE, ref UvVar CALLING_PROG) {
this.TYPE = TYPE;
this.REFERENCE = REFERENCE;
this.CALLING_PROG = CALLING_PROG;
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
/*  Routine to Enter Rejections */
/*  by Richard T */
/*  Note that I refer to DEBIT.SETS which are the total number of valid sets */
/*  contained in DEBIT.LISTS and the DEBIT.NUMBER is the one currently being */
/*  amended */
PROMPT("");
PROGRAM = "FL126";
SCREEN_CODE = PROGRAM;
INTERACT = INVALID_DATA;
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/* **************************** */
/*  CHECK FOR AUTHORISED USER * */
/* **************************** */
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
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
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.DD.WORK

if (!OPEN("FL.DD.WORK", out FL_DD_WORK)) { STOP("201", "FL.DD.WORK"); }

#endregion
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
MAT(ref DIRECT_DEBIT_REC, "");
DONE = FALSE;
REQUEST_REPORT = FALSE;
if (!(READV(ref DDREC_REQUIRED, COMMON.FILES[FL_CONTROL], "DDREC.REQD", 1))) {
DDREC_REQUIRED = TRUE;
}
ONE_PASS = FALSE;
/* ************************************ */
/*   Controlling Routine */
/* ************************************ */
L0900();
/*  Read in BACS Control file and check stage */
do {
if (TYPE == COMMON.ABANDON || DONE) break;
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref PROGRAM, ref DOTS_ONLY);
L0950();
/*  PRINT CONTROL DETAILS */
L0100();
/*  Get Identifier */
if (TYPE != COMMON.ABANDON && REFERENCE != COMMON.ABANDON && REFERENCE != FALSE) {
L0200();
/*  Display Existing Details */
L0300();
/*  Reject or Unreject Payment */
/* IF ONE.PASS # TRUE THEN */
/* TYPE = "" */
/* REFERENCE = "" */
/* END ELSE */
/* TYPE = ABANDON */
/* END */
}
if (ONE_PASS != TRUE) {
if (TYPE != COMMON.ABANDON) {
TYPE = "";
REFERENCE = "";
}
} else {
TYPE = COMMON.ABANDON;
}
} while (true);
if (REQUEST_REPORT == TRUE) {
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "ENGLISH";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PRINTER_OFF();
L0800();
/*  Print report if required */
}
return;
}
void L0100() {
/*  Routine to input and validate reference AND CHECK STAGE */
if (TYPE == "") {
DONE = FALSE;
do {
if (TYPE != "") break;
PRINT(AT(18, 3) + SPACE(6) + AT(18, 3));
LENGTH_OF_INPUT = 5;
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
else if (ANS == "D") {
TYPE = 4;
}// CASE
else if (ANS == COMMON.ABANDON) {
TYPE = ANS;
return;
}// CASE
else if (ANS == "") {
TYPE = COMMON.ABANDON;
REQUEST_REPORT = TRUE;
return;
}// CASE
else if (OTHERWISE) {
TYPE = "";
}
// END CASE
} while (true);
} else {
PRINT(AT(18, 3) + TYPE);
TYPE = "1";
ONE_PASS = TRUE;
}
if (REFERENCE == "") {
do {
if (REFERENCE != "") break;
PRINT(AT(39, 3) + SPACE(20) + AT(39, 3));
LENGTH_OF_INPUT = 15;
// BEGIN CASE
// CASE
if (TYPE == 1) {
/*  Members */
if (DDREC_REQUIRED) {
MEMBER_REQD = TRUE;
TICKET_REC = "";
RUN_CHECKS = FALSE;
FL103 = new FL103(ref TICKET_REC, ref MEMBER_REQD, ref RUN_CHECKS);
REFERENCE = TICKET_REC[10];
PRINTCR(AT(39, 3) + SPACE(20) + AT(39, 3) + REFERENCE);
/*               IF REFERENCE ="" THEN REFERENCE=ABANDON */
if (REFERENCE == "") {
REFERENCE = COMMON.ABANDON;
TYPE = COMMON.ABANDON;
return;
}
} else {
FL019 = new FL019(ref LENGTH_OF_INPUT, ref REFERENCE);
if (REFERENCE == "") { REFERENCE = COMMON.ABANDON; }
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
else if (TYPE == 4) {
/*  DELETED MEMBERS */
FL019 = new FL019(ref LENGTH_OF_INPUT, ref REQUIRED_ID);
if (!(MATREADU(ref DD_WORK_REC, FL_DD_WORK, REQUIRED_ID))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
TYPE = COMMON.ABANDON;
/* RT */
return;
}
return;
}// CASE
else if (OTHERWISE) {
REFERENCE = COMMON.ABANDON;
}
// END CASE
if (TYPE == COMMON.ABANDON) {
return;
}
} while (true);
} else {
PRINT(AT(39, 3) + REFERENCE);
}
// BEGIN CASE
// CASE
if (TYPE == 1) {
if (REFERENCE == COMMON.ABANDON) { return; }
if (READ(ref MEM_REC, COMMON.FILES[FL_MEMBERS], REFERENCE)) {
NAME = MEM_REC[6, 1] + " " + MEM_REC[5, 1] + " " + MEM_REC[4, 1];
} else {
if (DDREC_REQUIRED) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
REFERENCE = COMMON.ABANDON;
return;
} else {
NAME = "No member record";
}
}
}// CASE
else if (OTHERWISE) {
NAME = "";
}
// END CASE
/*  Call FL126.1 to get a list of valid rejectable items in FL.DD.WORK */
FL126_1 = new FL126_1(ref REFERENCE, ref TYPE, ref DEBIT_NUMBER, ref DEBIT_LIST, ref DD_DAY);
if (DEBIT_NUMBER == COMMON.ABANDON) {
TYPE = COMMON.ABANDON;
return;
}
DEBIT_SETS = DCOUNT(DEBIT_LIST, VM);
PRINTCR(AT(0, 10) + NRM_VID + COMMON.EOS);
if (DEBIT_NUMBER == COMMON.ABANDON) { return; }
if (DEBIT_NUMBER == 0) {
nrf0 = 3;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
REFERENCE = FALSE;
return;
}
PRINT(AT(78, 22) + NRM_VID + AT(2, 22) + DIM_REV_VID + SPACE(76) + NRM_VID);
/*  Get debit details (called by (N)ext (P)revious) */
WNDO_DATA_POS = 1;
REQUIRED_ID = TYPE + "*" + REFERENCE + "*" + DEBIT_LIST[1, DEBIT_NUMBER];
if (!(MATREADU(ref DD_WORK_REC, FL_DD_WORK, REQUIRED_ID))) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
TYPE = COMMON.ABANDON;
/* RT */
return;
}
return;
}
void L0200() {
/*  Display Direct Debit details and confirm rejection */
PRINTCR(AT(39, 4) + NRM_VID + FORMAT(DD_WORK_REC[DD_WORK_BACS_REF], "L#15"));
PRINTCR(AT(20, 10) + NRM_VID + AT(5, 10) + DIM_VID + FORMAT("Sort Code", "L#15") + NRM_VID);
PRINTCR(AT(22, 10) + DD_WORK_REC[DD_WORK_SORT_CODE]);
PRINTCR(AT(45, 10) + NRM_VID + AT(30, 10) + DIM_VID + FORMAT("Bank Name", "L#15") + NRM_VID);
PRINTCR(AT(52, 10) + FORMAT(DD_WORK_REC[DD_WORK_NAME], "L#25"));
PRINTCR(AT(20, 12) + NRM_VID + AT(5, 12) + DIM_VID + FORMAT("Account Name", "L#15") + NRM_VID);
PRINTCR(AT(22, 12) + DD_WORK_REC[DD_WORK_ACCT_NAME]);
PRINTCR(AT(20, 14) + NRM_VID + AT(5, 14) + DIM_VID + FORMAT("Amount of debit", "L#15") + NRM_VID);
PRINTCR(AT(22, 14) + OCONV(DD_WORK_REC[DD_WORK_AMOUNT], COMMON.MD2));
PRINTCR(AT(20, 16) + NRM_VID + AT(5, 16) + DIM_VID + FORMAT("Rejected", "L#15") + NRM_VID);
PRINTCR(AT(22, 16) + DD_WORK_REC[DD_WORK_REJECTED]);
PRINTCR(AT(20, 18) + NRM_VID + AT(5, 18) + DIM_VID + FORMAT("Reject'n Reason", "L#15") + NRM_VID);
PRINTCR(AT(22, 18) + DD_WORK_REC[DD_WORK_REJECTED_REASON]);
PRINT(AT(78, 22) + NRM_VID + AT(1, 22) + DIM_REV_VID + AT(2, 22) + FORMAT("Reject this payment (Y/N) ", "L#77") + NRM_VID);
return;
}
void L0300() {
/*  Reject (or Un-reject) a payment */
VALID_INPUT = FALSE;
do {
if (VALID_INPUT) break;
PRINT(AT(28, 22) + DIM_REV_VID + SPACE(5) + AT(28, 22));
nrf0 = 2;
FL019 = new FL019(ref nrf0, ref REPLY);
PRINT(NRM_VID);
// BEGIN CASE
// CASE
if (REPLY == COMMON.ABANDON) {
VALID_INPUT = TRUE;
}// CASE
else if (REPLY == "Y" && DD_WORK_REC[DD_WORK_REJECTED] == "") {
L0350();
L0500();
/*  MAKE ADJUSTMENT */
VALID_INPUT = TRUE;
}// CASE
else if (REPLY == "Y" && DD_WORK_REC[DD_WORK_REJECTED] == "Y") {
VALID_INPUT = FALSE;
nrf0 = 9;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (REPLY == "N" && DD_WORK_REC[DD_WORK_REJECTED] == "Y") {
L0600();
/*  MAKE - ADJUSTMENT */
}// CASE
else if (OTHERWISE) {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
return;
}
void L0350() {
/*  Rejection Code */
VALID_CODE = FALSE;
do {
if (VALID_CODE) break;
PRINT(AT(78, 22) + NRM_VID + AT(1, 22) + DIM_REV_VID + AT(2, 22) + FORMAT("Rejection Reason ", "L#77"));
PRINT(AT(20, 22));
nrf0 = 5;
FL019 = new FL019(ref nrf0, ref CODE);
PRINT(NRM_VID);
// BEGIN CASE
// CASE
if (CODE == COMMON.ABANDON) {
VALID_CODE = TRUE;
/*         CASE NUM(CODE) */
}// CASE
else if (OTHERWISE) {
DD_WORK_REC[DD_WORK_REJECTED_REASON] = CODE;
VALID_CODE = TRUE;
/*         CASE OTHERWISE */
/*            CALL FL006(PROGRAM,7,"") */
}
// END CASE
} while (true);
return;
}
void L0500() {
/*  Reject and amend totals if not already rejected */
DD_WORK_REC[DD_WORK_REJECTED] = "Y";
CONTROL_TOTAL[2] = CONTROL_TOTAL[2] - DD_WORK_REC[DD_WORK_AMOUNT];
CONTROL_TOTAL[1] = CONTROL_TOTAL[1] - 1;
PRINTCR(AT(55, 5) + NRM_VID + FORMAT(OCONV(CONTROL_TOTAL[2], "MD2"), "R#10"));
PRINTCR(AT(55, 6) + NRM_VID + FORMAT(CONTROL_TOTAL[1], "R#7"));
VALID_INPUT = TRUE;
L5000();
/*  FILE IT */
return;
}
void L0600() {
/*  Un-reject and amend totals if required */
DD_WORK_REC[DD_WORK_REJECTED] = "";
CONTROL_TOTAL[2] = CONTROL_TOTAL[2] + DD_WORK_REC[DD_WORK_AMOUNT];
CONTROL_TOTAL[1] = CONTROL_TOTAL[1] + 1;
PRINTCR(AT(55, 5) + FORMAT(OCONV(CONTROL_TOTAL[2], "MD2"), "R#10"));
PRINTCR(AT(55, 6) + FORMAT(CONTROL_TOTAL[1], "R#7"));
VALID_INPUT = TRUE;
DD_WORK_REC[DD_WORK_REJECTED_REASON] = "";
L5000();
/*  FILE IT */
return;
}
void L0800() {
/*  Print out debit report */
PRINTCR(AT(78, 22) + NRM_VID + AT(1, 22) + DIM_REV_VID + FORMAT("Do you want to print a rejection report (Y/N) ", "L#78"));
PRINT(AT(50, 22) + NRM_VID);
nrf0 = 2;
FL019 = new FL019(ref nrf0, ref REPLY);
if (REPLY == "y" || REPLY == "Y") {
ZZZ_QUOTE = "\"";
OPTS = "OS";
INSTR = "SORT " + FILE_NAME + " WITH 6 MEMBER.NO BACS.REF 1 2 5 8 TOTAL 3 ID-SUPP HEADING ";
INSTR = INSTR + ZZZ_QUOTE + CENTRENAME[1] + " - BACS Direct Rejection Report for " + OCONV(DD_LAST_RUN_DATE, COMMON.D2) + "'LT'";
INSTR = INSTR + ZZZ_QUOTE + " GRAND-TOTAL " + ZZZ_QUOTE + "Total Debits Rejected'U'";
INSTR = INSTR + ZZZ_QUOTE + "LPTR";
CallAt_EXEC_PROG = new CallAt_EXEC_PROG(ref EXEC_PROG, ref INSTR, ref OPTS, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
}
return;
}
void L0900() {
/*  Check Stage */
if (!(READ(ref BACS_CONTROL_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
DD_STAGE_PARAM = BACS_CONTROL_REC[4];
if (DD_STAGE_PARAM[1, 2] == "") {
DD_STAGE = DD_STAGE_PARAM[1, 1];
DD_DAY = BACS_CONTROL_REC[1, 1];
DD_LAST_RUN_DATE = BACS_CONTROL_REC[3, 1];
} else {
PRINT(COMMON.WASH);
FL306 = new FL306();
DD_LAST_RUN_DATE = "";
do {
if (DD_LAST_RUN_DATE != "") break;
PRINT(AT(10, 5) + "Enter Date to Process (" + OCONV(BACS_CONTROL_REC[3, 1], "D2/") + " or " + OCONV(BACS_CONTROL_REC[3, 2], "D2/") + ") ");
nrf0 = 10;
FL019 = new FL019(ref nrf0, ref DATE_REQ);
if (DATE_REQ == COMMON.ABANDON) {
DONE = TRUE;
return;
}
DD_LAST_RUN_DATE = ICONV(DATE_REQ, "D");
if (LOCATE(DD_LAST_RUN_DATE, BACS_CONTROL_REC, 3, 0, 1, ref POS, "AL")) {
DD_STAGE = BACS_CONTROL_REC[4, POS];
DD_DAY = BACS_CONTROL_REC[1, POS];
} else {
DD_LAST_RUN_DATE = "";
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} while (true);
}
if (DD_STAGE != 2) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
}
FILE_NAME = "FL.DD.WORK" + DD_DAY;
if (!(OPEN(FILE_NAME, out FL_DD_WORK))) {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
if (!OPENDICT(FILE_NAME, out DFL_DD_WORK)) { STOP("NO WORK FILE"); }
if (!READ(ref CENTRENAME, COMMON.FILES[FL_CENTRES], COMMON.CENTRE)) { COMMON.CENTRE = "CENTRE NOT KNOWN"; }
return;
}
void L0950() {
/*  Displaying Control Details */
if (READU(ref CONTROL_TOTAL, DFL_DD_WORK, "CONTROL.TOTALS")) {
PRINTCR(AT(2, 25) + NRM_VID + AT(2, 5) + REV_VID + "Rejections for " + OCONV(DD_LAST_RUN_DATE, "D2"));
PRINTCR(AT(39, 5) + NRM_VID + "Control total : " + FORMAT(OCONV(CONTROL_TOTAL[2], "MD2"), "R#10"));
PRINTCR(AT(39, 6) + NRM_VID + "Items : " + AT(54, 6) + FORMAT(CONTROL_TOTAL[1], "R#7"));
} else {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
}
return;
}
void L5000() {
/*  Editing and filing */
WRITE(CONTROL_TOTAL, DFL_DD_WORK, "CONTROL.TOTALS");
TRANS_LOG_REC = CONTROL_TOTAL;
nrf0 = "W";
nrf1 = "DICT FL.DD.WORK";
nrf2 = "CONTROL.TOTALS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
MATWRITE(DD_WORK_REC, FL_DD_WORK, REQUIRED_ID);
if (READ(ref TRANS_LOG_REC, FL_DD_WORK, REQUIRED_ID)) {
nrf0 = "W";
nrf1 = "FL.DD.WORK";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref REQUIRED_ID);
}
RELEASE();
return;
}
}
}
