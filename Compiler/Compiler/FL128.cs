//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL128 : UvBase
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
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] DD_WORK_REC = new UvVar[15];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar SCREEN_CODE = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar FL_DD_WORK = "";
UvVar DFL_DD_WORK = "";
UvVar DFL_DIRECT_DEBITS = "";
UvVar DONE = "";
UvVar ERRMSG = "";
UvVar DEBIT_COUNT = "";
UvVar POST_TOTAL = "";
UvVar EOF = "";
UvVar DD_KEY = "";
UvVar CONTROL_TOTALS = "";
FLTX2 FLTX2;
UvVar BACS_CONTROL_REC = "";
UvVar WAIT = "";
UvVar TITLE = "";
UvVar TITLEX = "";
UvVar SCLINE = "";
FL006 FL006;
UvVar SPECIALS_PASS = "";
UvVar PASSWD = "";
UvVar DEBIT_DATE = "";
UvVar VALID_INPUT = "";
FL019 FL019;
UvVar REPLY = "";
UvVar REJECTED = "";
UvVar WORK_REC = "";
UvVar DD_AMOUNT = "";
UvVar PAYMENT_POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL128() {
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
/*  DIRECT DEBIT UN-POSTING ROUTINE */
/*  WRITTEN BY RICHARD T */
PROGRAM = "FL128";
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
#region INCLUDE FL.FILES FL.DD.WORK

if (!OPEN("FL.DD.WORK", out FL_DD_WORK)) { STOP("201", "FL.DD.WORK"); }

#endregion
if (!OPENDICT("FL.DD.WORK", out DFL_DD_WORK)) { STOP("NO WORK FILE"); }
if (!OPENDICT("FL.DIRECT.DEBITS", out DFL_DIRECT_DEBITS)) { STOP("NO DIRECT DEBIT FILE"); }
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
/* ************************************************************************* */
/*  CONTROL BLOCK */
/* * */
DONE = FALSE;
ERRMSG = "";
L0800();
/*  SET UP SCREEN AND ENSURE THAT IT IS OK TO POST */
if (DONE) { return; }
DEBIT_COUNT = 0;
POST_TOTAL = 0;
/* * */
/*  Select DD work file and then post att 3 into FL.DIRECT.DEBITS */
/* * */
SELECT(FL_DD_WORK);
EOF = FALSE;
do {
if (!READNEXT(ref DD_KEY, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
if (DD_KEY != "FLOPPY.REC") {
L1000();
/*  ACTION ADJUSTMENT AND UPDATE CONTROL TOTALS */
L2000();
/*  GENEREATE REPORT (IF REQUIRED) */
}
} while (true);
WRITE(CONTROL_TOTALS, DFL_DD_WORK, "CONTROL.TOTALS");
TRANS_LOG_REC = CONTROL_TOTALS;
nrf0 = "W";
nrf1 = "DICT FL.DD.WORK";
nrf2 = "CONTROL.TOTALS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
BACS_CONTROL_REC[4] = 2;
/*  UPDATE STAGE */
WRITE(BACS_CONTROL_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL");
TRANS_LOG_REC = BACS_CONTROL_REC;
nrf0 = "W";
nrf1 = "DICT FL.DIRECT.DEBITS";
nrf2 = "BACS.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
RELEASE();
RELEASE();
PRINT(AT(1, 22) + CONTROL_TOTALS[1] + " Items unposted, Press <RETURN>");
INPUTCR(out WAIT, 2);
return;
/* * */
}
void L0800() {
/*  Read in Control and set up screen and prompt to continue */
/* ** */
PRINT(COMMON.WASH);
TITLE = "Direct Debit Unposting Routine";
TITLEX = INT((80 - LEN(TITLE)) / 2);
for(SCLINE = 0; SCLINE <= 2; SCLINE += 1) {
PRINT(AT(78, SCLINE) + NRM_VID + AT(1, SCLINE) + DIM_REV_VID + SPACE(76));
}
PRINTCR(AT(2, 0) + "(" + PROGRAM + ")");
PRINTCR(AT(TITLEX, 1) + TITLE);
/* * */
/*  READ IN CONTROL DETAILS AND CONTROL TOTALS */
/* * */
if (!(READU(ref BACS_CONTROL_REC, DFL_DIRECT_DEBITS, "BACS.CONTROL"))) {
nrf0 = 1;
nrf1 = "DIRECT DEBITS NOT SET UP";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
if (BACS_CONTROL_REC[4] != 3) {
nrf0 = 2;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
if (!(READV(ref SPECIALS_PASS, COMMON.FILES[FL_CONTROL], "SPECIALS.PASS", 1))) {
SPECIALS_PASS = "LETMEIN";
}
do {
PRINT(AT(10, 8) + NRM_VID + "Enter Special Password ");
ECHO_OFF();
INPUTCR(out PASSWD);
ECHO_ON();
PRINTCR(AT(10, 8) + COMMON.EOL);
if (PASSWD == SPECIALS_PASS || PASSWD == COMMON.ABANDON) break;
} while (true);
if (PASSWD == COMMON.ABANDON) {
DONE = TRUE;
return;
}
if (!(READU(ref CONTROL_TOTALS, DFL_DD_WORK, "CONTROL.TOTALS"))) {
nrf0 = 3;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
DONE = TRUE;
return;
}
DEBIT_DATE = BACS_CONTROL_REC[3];
PRINTCR(AT(10, 10) + NRM_VID + "Direct Debit Date : " + OCONV(DEBIT_DATE, COMMON.D2));
PRINTCR(AT(10, 14) + "Control Total     : " + OCONV(CONTROL_TOTALS[4], COMMON.MD2));
PRINTCR(AT(10, 15) + "Number of Debits  : " + CONTROL_TOTALS[3]);
VALID_INPUT = FALSE;
PRINT(AT(10, 20) + "Are you sure that you want to UNPOST the direct debits (Y/N) ");
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
return;
/* * */
}
void L1000() {
/*  UNPOST AMOUNT OR 0 (IF REJECTED) */
/* * */
if (!(READ(ref WORK_REC, FL_DD_WORK, DD_KEY))) {
nrf0 = 7;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
return;
}
DD_AMOUNT = WORK_REC[3];
REJECTED = WORK_REC[6];
if (REJECTED == "Y") { DD_AMOUNT = 0; }
MAT(ref DIRECT_DEBIT_REC, "");
if (!(MATREADU(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY))) {
nrf0 = 7;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
return;
}
if (LOCATE(DEBIT_DATE, DIRECT_DEBIT_REC[DIRECT_DEBIT_DATES], 1, 0, 1, ref PAYMENT_POS, "AR")) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS] != "") {
DIRECT_DEBIT_REC[DIRECT_DEBIT_PAID][1, PAYMENT_POS] = "";
/*            DIRECT.DEBIT.BALANCE = DIRECT.DEBIT.BALANCE + DD.AMOUNT */
MATWRITE(DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
if (READ(ref TRANS_LOG_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
RELEASE();
CONTROL_TOTALS[3] = CONTROL_TOTALS[3] - 1;
CONTROL_TOTALS[4] = CONTROL_TOTALS[4] - DD_AMOUNT;
} else {
ERRMSG = "NOT POSTED";
L2100();
}
} else {
nrf0 = 7;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
L2100();
/*  PRINT TO ERROR REPORT IF REQD IN FUTURE */
}
return;
/* * */
}
void L2000() {
/* * ADD REPORTING CODE HERE IF REQUIRED */
/* * */
return;
/* * */
}
void L2100() {
/*  ERROR REPORTING */
/* * */
PRINTCR(ERRMSG);
return;
}
}
}
