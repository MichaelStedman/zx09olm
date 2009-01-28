//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_RTEFT : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CONTROL = 10;
readonly UvVar EFT_SLIPTYPE = 1;
readonly UvVar EFT_TXTYPE = 2;
readonly UvVar EFT_CARDNO = 3;
readonly UvVar EFT_EXPINF = 4;
readonly UvVar EFT_AMOUNT = 5;
readonly UvVar EFT_DATE = 6;
readonly UvVar EFT_TIME = 7;
readonly UvVar EFT_EXTRAS = 8;
readonly UvVar EFT_SCHEME = 9;
readonly UvVar EFT_AUTH_CODE = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] EFT_PRINT_REC = new UvVar[10];
#endregion
#region Variables
UvVar PORT_NAME = "";
UvVar SALE_AMNT = "";
UvVar SWIPE_DETS = "";
UvVar CARD_NO = "";
UvVar CARD_EXP = "";
UvVar CARD_ISSUE = "";
UvVar CARD_START = "";
UvVar TRANS_TYPE = "";
UvVar AUTH_CODE = "";
UvVar ERROR_CODE = "";
UvVar ERROR_DESC = "";
UvVar RESULT_CODE = "";
UvVar USER_MESSAGE = "";
UvVar EFT_CONF = "";
UvVar PATRON_NO = "";
UvVar CALLING_PROG = "";
UvVar CUST_PRT_REC = "";
UvVar SALE_PRT_REC = "";
UvVar PORT_NUMBER = "";
UvVar AM = "";
UvVar VM = "";
UvVar FL_EFT_SHARE = "";
UvVar FL_EFT_ERRORS = "";
UvVar PRGS_IND = "";
UvVar MAX_STAGE1_TIME = "";
UvVar MAX_STAGE2_TIME = "";
UvVar EFTDATA_REC = "";
UvVar POUND_SIGN = "";
UvVar SLIP_PRINT_ROUTINE = "";
UvVar ALWAYS_PRINT_SLIP = "";
UvVar ALWAYS_PROMPT_SLIP = "";
UvVar RESPONSE = "";
UvVar RETRYS = "";
UvVar PROGRESS_MAX = "";
UvVar MAX_STAGE_TIME = "";
UvVar ACCT_REC = "";
UvVar PROGRESS_COUNT = "";
UvVar PRINT_SLIP_NOW = "";
UvVar EFT_PROMPT = "";
UvVar SEGMESS = "";
FL_EFT_STATUS FL_EFT_STATUS;
UvVar ANS = "";
UvVar ERROR_REC = "";
UvVar EFT_VOUCH_TYPE = "";
FL_FULL_ADDRESS FL_FULL_ADDRESS;
UvVar FULL_ADDRESS = "";
UvVar EFT_REPLY = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
#endregion
public FL_RTEFT(ref UvVar PORT_NAME, ref UvVar SALE_AMNT, ref UvVar SWIPE_DETS, ref UvVar CARD_NO, ref UvVar CARD_EXP, ref UvVar CARD_ISSUE, ref UvVar CARD_START, ref UvVar TRANS_TYPE, ref UvVar AUTH_CODE, ref UvVar ERROR_CODE, ref UvVar ERROR_DESC, ref UvVar RESULT_CODE, ref UvVar USER_MESSAGE, ref UvVar EFT_CONF, ref UvVar PATRON_NO, ref UvVar CALLING_PROG, ref UvVar CUST_PRT_REC, ref UvVar SALE_PRT_REC) {
this.PORT_NAME = PORT_NAME;
this.SALE_AMNT = SALE_AMNT;
this.SWIPE_DETS = SWIPE_DETS;
this.CARD_NO = CARD_NO;
this.CARD_EXP = CARD_EXP;
this.CARD_ISSUE = CARD_ISSUE;
this.CARD_START = CARD_START;
this.TRANS_TYPE = TRANS_TYPE;
this.AUTH_CODE = AUTH_CODE;
this.ERROR_CODE = ERROR_CODE;
this.ERROR_DESC = ERROR_DESC;
this.RESULT_CODE = RESULT_CODE;
this.USER_MESSAGE = USER_MESSAGE;
this.EFT_CONF = EFT_CONF;
this.PATRON_NO = PATRON_NO;
this.CALLING_PROG = CALLING_PROG;
this.CUST_PRT_REC = CUST_PRT_REC;
this.SALE_PRT_REC = SALE_PRT_REC;
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
/*  Flex Real Time EFT (commidea) interface program */
/* * */
/*  OPEN shared FILE */
/* * */
#region INCLUDE FL.FILES FL.EFT.SHARE

if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE)) {
} else {
if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
}

#endregion
#region INCLUDE FL.FILES FL.EFT.ERRORS

if (!OPEN("FL.EFT.ERRORS", out FL_EFT_ERRORS)) { STOP(201, "FL.EFT.ERRORS"); }

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.EFT.EQUATES

/*  Electronic fund transfer equates */

#endregion
/* * */
/*  Set Variables */
/* * */
PRGS_IND = 1;
EFT_CONF = "";
MAT(ref EFT_PRINT_REC, "");
AUTH_CODE = "NOT AUTHORISED";
ERROR_CODE = 6;
MAX_STAGE1_TIME = 120;
MAX_STAGE2_TIME = 180;
EFTDATA_REC = "";
RESULT_CODE = "-1";
POUND_SIGN = CHAR(156);
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE*" + PORT_NUMBER, 1))) {
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE", 1))) {
SLIP_PRINT_ROUTINE = "FL00017";
}
}
if (!(READV(ref ALWAYS_PRINT_SLIP, COMMON.FILES[FL_CONTROL], "ALWAYS.PRINT.SLIP", 1))) {
ALWAYS_PRINT_SLIP = 1;
}
if (!(READV(ref ALWAYS_PROMPT_SLIP, COMMON.FILES[FL_CONTROL], "ALWAYS.PROMPT.SLIP", 1))) {
ALWAYS_PROMPT_SLIP = 0;
}
/* * */
/* * */
EFTDATA_REC = FORMAT(TRANS_TYPE, "R%2") + " ";
/*      EFTDATA.REC<1> = EFTDATA.REC<1>:ABS(OCONV(SALE.AMNT,"MCN")) :" 0": CHAR(13) */
EFTDATA_REC[1] = EFTDATA_REC[1] + SALE_AMNT + " 0" + CHAR(13);
if (SWIPE_DETS != "") {
EFTDATA_REC[2] = SWIPE_DETS + CHAR(163);
} else {
EFTDATA_REC[2] = EFTDATA_REC[2] + CHAR(31);
EFTDATA_REC = EFTDATA_REC + CARD_NO + CHAR(31);
EFTDATA_REC = EFTDATA_REC + CARD_EXP;
if (CARD_START || CARD_ISSUE != "") {
EFTDATA_REC = EFTDATA_REC + CHAR(31) + CARD_ISSUE;
}
if (CARD_START != "") {
EFTDATA_REC = EFTDATA_REC + CHAR(31) + CARD_START;
}
EFTDATA_REC = EFTDATA_REC + CHAR(13);
}
/* ** */
/*  Remove old Data files */
/* * */
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA");
/* * */
/*  Write Request */
/* * */
WRITE(EFTDATA_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".IN");
/*      WRITE EFTDATA.REC ON FL.EFT.SHARE,"FLXIO":PORT.NAME:".IN" */
RESPONSE = FALSE;
L0700();
/* * */
/*  Sleep 1 second then try to get response from server */
/* * */
L0700();
RESPONSE = FALSE;
RETRYS = 0;
PROGRESS_MAX = MAX_STAGE1_TIME;
MAX_STAGE_TIME = TIME() + MAX_STAGE1_TIME;
do {
if (RESPONSE || TIME() > MAX_STAGE_TIME) break;
if (READ(ref ACCT_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1")) {
RESPONSE = TRUE;
} else {
if (CALLING_PROG == "TICKET.TOUCH") {
if (RETRYS == 0) { ShowProgress(); }
}
RETRYS = RETRYS + 1;
if (CALLING_PROG == "TICKET.TOUCH") {
PROGRESS_COUNT = RETRYS;
UpdateProgress();
}
}
/*        PRGS.IND = PRGS.IND + 1 */
L0700();
} while (true);
if (CALLING_PROG == "TICKET.TOUCH" && RETRYS > 0) {
HideProgress();
}
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
/* ** */
/*  Remove old Data files */
/* * */
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA");
/* * */
}
RESULT_CODE = ACCT_REC[1];
EFT_CONF = ACCT_REC[11] + AM + ACCT_REC[12] + AM + ACCT_REC[15];
/* ** */
/*  IF RESULT CODE IS NOT 7 (PREVIOUSLY AUTHORISED) THEN CARRY ON */
/* ** */
if (RESULT_CODE.Substring(1, 1) == "4" || RESULT_CODE.Substring(1, 1) == "7") {
PRINT_SLIP_NOW = TRUE;
if (TRANS_TYPE.Substring(1, 1) != 0 && ALWAYS_PROMPT_SLIP) {
EFT_PROMPT = "Print Slip (Y/N) " + AM + 3 + AM + "Y" + VM + "N";
SEGMESS = "";
SEGMESS[2] = "Printing Slip";
SEGMESS[6] = "If the customer is not present";
SEGMESS[7] = "a signature slip may not be required";
SEGMESS[10] = "Do you require a signature slip";
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref ANS, ref CALLING_PROG);
EFT_PROMPT = "";
if (OCONV(ANS, "MCU") == "N") {
PRINT_SLIP_NOW = FALSE;
}
}
/* ** */
/*  if transaction is customer present print signature slip */
/* ** */
RESPONSE = FALSE;
RETRYS = 0;
PROGRESS_MAX = MAX_STAGE2_TIME;
MAX_STAGE_TIME = TIME() + MAX_STAGE2_TIME;
do {
if (RESPONSE || TIME() > MAX_STAGE_TIME) break;
if (READ(ref ACCT_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2")) {
RESPONSE = TRUE;
} else {
if (CALLING_PROG == "TICKET.TOUCH") {
if (RETRYS == 0) { ShowProgress(); }
}
RETRYS = RETRYS + 1;
if (CALLING_PROG == "TICKET.TOUCH") {
PROGRESS_COUNT = RETRYS;
UpdateProgress();
}
}
if ((RETRYS / 10) == INT(RETRYS / 10)) {
PRGS_IND = PRGS_IND + 1;
L0700();
}
} while (true);
if (CALLING_PROG == "TICKET.TOUCH" && RETRYS > 0) {
HideProgress();
}
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
ERROR_CODE = 2;
/* ** */
/*  Remove old Data files */
/* * */
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2");
/* * */
}
PRGS_IND = PRGS_IND + 1;
L0700();
L0050();
L0100();
/* Prepare House Copy */
L0200();
/*  Prepare Customer Copy */
AUTH_CODE = ACCT_REC[11];
}
RESULT_CODE = ACCT_REC[1];
/* * */
/*  GET ERROR CODE IF REQUIRED */
/* * */
if (!(READ(ref ERROR_REC, FL_EFT_ERRORS, RESULT_CODE))) {
ERROR_REC = "NOT KNOWN";
ERROR_REC[2] = "6";
}
ERROR_DESC = ERROR_REC[1];
ERROR_CODE = ERROR_REC[2];
USER_MESSAGE = ACCT_REC[13] + VM + ACCT_REC[14];
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".IN");
return;
/* ******************** */
}
void L0050() {
/*  ASSIGN RETURN CODE VARIABLES */
/* ********************************** */
if (ACCT_REC[2] == "132" || ACCT_REC[2] == "04" || ACCT_REC[2] == "84") {
EFT_PRINT_REC[EFT_TXTYPE] = "REFUND";
EFT_VOUCH_TYPE = "REFUND VOUCHER";
} else {
EFT_PRINT_REC[EFT_TXTYPE] = "DEBIT";
EFT_VOUCH_TYPE = "SALES VOUCHER";
}
EFT_PRINT_REC[EFT_CARDNO] = ACCT_REC[3];
CARD_NO = EFT_PRINT_REC[EFT_CARDNO];
EFT_PRINT_REC[EFT_EXPINF] = ACCT_REC[4];
if (CARD_EXP == "") { CARD_EXP = EFT_PRINT_REC[EFT_EXPINF]; }
EFT_PRINT_REC[EFT_AMOUNT] = ACCT_REC[5];
/*      EFT.DATE = ACCT.REC<7>[1,6] */
EFT_PRINT_REC[EFT_DATE] = ICONV(ACCT_REC[7].Substring(1, 2) + "/" + ACCT_REC[7].Substring(3, 2) + "/" + ACCT_REC[7].Substring(5, 2), "D2/");
EFT_PRINT_REC[EFT_TIME] = ICONV(ACCT_REC[7].Substring(7, 2) + ":" + ACCT_REC[7].Substring(9, 2), "MTH");
EFT_PRINT_REC[EFT_EXTRAS] = ACCT_REC[8] + " " + ACCT_REC[9] + " " + ACCT_REC[12];
EFT_CONF = ACCT_REC[11] + AM + ACCT_REC[12] + AM + ACCT_REC[15];
EFT_PRINT_REC[EFT_SCHEME] = ACCT_REC[10];
EFT_PRINT_REC[EFT_AUTH_CODE] = ACCT_REC[11];
return;
/* ******************* */
}
void L0100() {
/*  Print Copy to be Signed */
/* ******************* */
EFT_PRINT_REC[EFT_SLIPTYPE] = "1";
SALE_PRT_REC = EFT_VOUCH_TYPE;
SALE_PRT_REC[2] = "RETAILER'S COPY";
SALE_PRT_REC[3] = "Card Type : " + EFT_PRINT_REC[EFT_SCHEME];
SALE_PRT_REC[4] = "Card No   : " + EFT_PRINT_REC[EFT_CARDNO];
if (SWIPE_DETS == "") {
SALE_PRT_REC[4] = SALE_PRT_REC[4] + " (Keyed) ";
}
SALE_PRT_REC[5] = EFT_PRINT_REC[EFT_EXPINF];
SALE_PRT_REC[6] = "Total :   " + POUND_SIGN + OCONV(EFT_PRINT_REC[EFT_AMOUNT], "MD2");
SALE_PRT_REC[7] = "Please Check Slip and Sign Below";
SALE_PRT_REC[8] = "PLEASE " + EFT_PRINT_REC[EFT_TXTYPE] + " MY ACCOUNT AS SHOWN";
SALE_PRT_REC[9] = EFT_PRINT_REC[EFT_EXTRAS] + " " + EFT_PRINT_REC[EFT_DATE] + " " + EFT_PRINT_REC[EFT_TIME];
SALE_PRT_REC[10] = "Auth Code : " + EFT_PRINT_REC[EFT_AUTH_CODE];
SALE_PRT_REC[12] = PATRON_NO;
SALE_PRT_REC[13] = STR(".", 75);
SALE_PRT_REC[14] = "#";
SALE_PRT_REC[15] = OCONV(DATE(), "D4/") + " " + OCONV(TIME(), "MT");
FL_FULL_ADDRESS = new FL_FULL_ADDRESS(ref COMMON.CENTRE, ref FULL_ADDRESS);
SALE_PRT_REC[16] = FULL_ADDRESS;
return;
/* ******************* */
}
void L0200() {
/*  Print Customer copy */
/* ******************* */
EFT_PRINT_REC[EFT_SLIPTYPE] = 2;
CUST_PRT_REC = EFT_VOUCH_TYPE;
CUST_PRT_REC[2] = "CUSTOMER'S COPY";
CUST_PRT_REC[3] = "Card Type : " + EFT_PRINT_REC[EFT_SCHEME];
CUST_PRT_REC[4] = "Card No   : " + EFT_PRINT_REC[EFT_CARDNO];
if (SWIPE_DETS == "") {
CUST_PRT_REC[4] = CUST_PRT_REC[4] + " (Keyed) ";
}
CUST_PRT_REC[5] = EFT_PRINT_REC[EFT_EXPINF];
CUST_PRT_REC[6] = "Total :   " + POUND_SIGN + OCONV(EFT_PRINT_REC[EFT_AMOUNT], "MD2");
CUST_PRT_REC[7] = "PLEASE KEEP FOR YOUR RECORDS";
CUST_PRT_REC[8] = "YOUR ACCOUNT WILL BE " + EFT_PRINT_REC[EFT_TXTYPE] + "ED";
/*      CUST.PRT.REC<9> = EFT.CONF<2> : "*": EFT.EXTRAS: " " :EFT.DATE: " " : EFT.TIME */
CUST_PRT_REC[9] = EFT_PRINT_REC[EFT_EXTRAS] + " " + EFT_PRINT_REC[EFT_DATE] + " " + EFT_PRINT_REC[EFT_TIME];
CUST_PRT_REC[10] = "Auth Code : " + EFT_PRINT_REC[EFT_AUTH_CODE];
CUST_PRT_REC[11] = "AS SHOWN, THANK YOU";
CUST_PRT_REC[12] = PATRON_NO;
CUST_PRT_REC[14] = "#";
CUST_PRT_REC[15] = OCONV(DATE(), "D4/") + " " + OCONV(TIME(), "MT");
FL_FULL_ADDRESS = new FL_FULL_ADDRESS(ref COMMON.CENTRE, ref FULL_ADDRESS);
CUST_PRT_REC[16] = FULL_ADDRESS;
return;
/* ************** */
}
void L0700() {
/*  UPDATE PROGRESS */
/* ********************* */
nrf0 = "";
nrf1 = 1;
nrf2 = "";
nrf3 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref EFT_REPLY, ref CALLING_PROG);
if (RESPONSE == FALSE) { RQM(); }
return;
/* *************************************** */
}
void ShowProgress() {
PRINTCR(CHAR(28) + "12," + PROGRESS_MAX + ",100,100" + CHAR(20));
return;
/* *************************************** */
}
void UpdateProgress() {
PRINTCR(CHAR(28) + "13," + PROGRESS_COUNT + CHAR(20));
return;
/* *************************************** */
}
void HideProgress() {
PRINTCR(CHAR(28) + "14" + CHAR(20));
return;
}
}
}
