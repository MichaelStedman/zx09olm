//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_WINTI : UvBase
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
UvVar CARD_CVS = "";
UvVar CARD_HOUSENORNAME = "";
UvVar CARD_POSTCODE = "";
UvVar SPARE1 = "";
UvVar SPARE2 = "";
UvVar SPARE3 = "";
UvVar PORT_NUMBER = "";
UvVar U_INITS = "";
UvVar PROG_MESS = "";
UvVar AM = "";
UvVar VM = "";
UvVar TXFILE_TYPE = "";
UvVar FL_EFT_SHARE = "";
UvVar FL_EFT_ERRORS = "";
UvVar SOCKET_MODE = "";
UvVar CHIPANDPINREC = "";
UvVar CHIPANDPIN = "";
UvVar CASHBACK_VALUE = "";
UvVar PRGS_IND = "";
UvVar POUND_SIGN = "";
UvVar MERCH_REF = "";
UvVar MAX_STAGE1_TIME = "";
UvVar MAX_STAGE2_TIME = "";
UvVar EFTDATA_REC = "";
UvVar EFT_MERCHANT = "";
UvVar TRANS_T = "";
UvVar SLIP_PRINT_ROUTINE = "";
UvVar ALWAYS_PRINT_SLIP = "";
UvVar ALWAYS_PROMPT_SLIP = "";
UvVar EFT_STARS = "";
UvVar EFT_AVS = "";
UvVar AVS = "";
UvVar MXHOUSENAMELEN = "";
UvVar CARD_HOUSENAME = "";
UvVar EFT_CUST_STARS = "";
UvVar EFT_SALE_STARS = "";
FL_WINTI_SOCKET FL_WINTI_SOCKET;
UvVar ACCT_REC = "";
UvVar INTERACT = "";
UvVar RESPONSE = "";
UvVar CHIPANDPINLEFTIN = "";
UvVar PRINT_SLIP_NOW = "";
UvVar EFT_PROMPT = "";
UvVar SEGMESS = "";
FL_EFT_STATUS FL_EFT_STATUS;
UvVar ANS = "";
UvVar ERROR_REC = "";
UvVar RETRYS = "";
UvVar PROGRESS_MAX = "";
UvVar MAX_STAGE_TIME = "";
UvVar PROGRESS_COUNT = "";
UvVar EFT_VOUCH_TYPE = "";
UvVar EFT_CARDNO_SALE = "";
UvVar EFT_CARDNO_CUST = "";
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
public FL_WINTI(ref UvVar PORT_NAME, ref UvVar SALE_AMNT, ref UvVar SWIPE_DETS, ref UvVar CARD_NO, ref UvVar CARD_EXP, ref UvVar CARD_ISSUE, ref UvVar CARD_START, ref UvVar TRANS_TYPE, ref UvVar AUTH_CODE, ref UvVar ERROR_CODE, ref UvVar ERROR_DESC, ref UvVar RESULT_CODE, ref UvVar USER_MESSAGE, ref UvVar EFT_CONF, ref UvVar PATRON_NO, ref UvVar CALLING_PROG, ref UvVar CUST_PRT_REC, ref UvVar SALE_PRT_REC, ref UvVar CARD_CVS, ref UvVar CARD_HOUSENORNAME, ref UvVar CARD_POSTCODE, ref UvVar SPARE1, ref UvVar SPARE2, ref UvVar SPARE3) {
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
this.CARD_CVS = CARD_CVS;
this.CARD_HOUSENORNAME = CARD_HOUSENORNAME;
this.CARD_POSTCODE = CARD_POSTCODE;
this.SPARE1 = SPARE1;
this.SPARE2 = SPARE2;
this.SPARE3 = SPARE3;
/* CRT TRANS.TYPE */
/* CRT "TRANS.TYPE " : TRANS.TYPE */
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
TXFILE_TYPE = "T";
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
/* **                 ** */
/*   SOCKET EXTENSION  * */
/* **                 ** */
if (!(READV(ref SOCKET_MODE, FL_EFT_SHARE, "EFT.CONNECT", 7))) {
SOCKET_MODE = FALSE;
}
if (SOCKET_MODE == "") { SOCKET_MODE = FALSE; }
/* ** CHIP AND PIN EXTENSION */
if (!READ(ref CHIPANDPINREC, FL_EFT_SHARE, "CHIPANDPIN.PORTS")) { CHIPANDPINREC = FALSE; }
CHIPANDPIN = FALSE;
if (CHIPANDPINREC[1] == TRUE) {
TXFILE_TYPE = "T";
CHIPANDPIN = TRUE;
}
/* * */
/*  Set Variables */
/* * */
CASHBACK_VALUE = "";
/*  RESERVED FOR FUTURE EXPANSION */
PRGS_IND = 1;
POUND_SIGN = CHAR(156);
MERCH_REF = "";
MERCH_REF = COMMON.CENTRE + FORMAT(PORT_NUMBER, "R%3") + U_INITS;
EFT_CONF = "";
MAT(ref EFT_PRINT_REC, "");
AUTH_CODE = "NOT AUTHORISED";
ERROR_CODE = 6;
MAX_STAGE1_TIME = 120;
MAX_STAGE2_TIME = 360;
EFTDATA_REC = "";
/*  Ecommerce Transactions */
if (TRANS_TYPE.Substring(1, 1) == 2) {
if (!READV(ref EFT_MERCHANT, COMMON.FILES[FL_CONTROL], "EFT.ECOM.MERCHANT", 1)) { EFT_MERCHANT = "999"; }
TRANS_T = "0208";
} else {
TRANS_T = FORMAT(TRANS_TYPE.Substring(1, 1), "R%4");
if (!READV(ref EFT_MERCHANT, COMMON.FILES[FL_CONTROL], "EFT.MERCHANT", 1)) { EFT_MERCHANT = "001"; }
}
RESULT_CODE = "-1";
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE*" + PORT_NUMBER, 1))) {
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE", 1))) {
SLIP_PRINT_ROUTINE = "FL00017";
}
}
if (INDEX(SLIP_PRINT_ROUTINE, "GAZ", 1) > 0) {
POUND_SIGN = "";
}
if (CALLING_PROG == "FWEFT") {
ALWAYS_PRINT_SLIP = FALSE;
ALWAYS_PROMPT_SLIP = FALSE;
} else {
if (!(READV(ref ALWAYS_PRINT_SLIP, COMMON.FILES[FL_CONTROL], "ALWAYS.PRINT.SLIP", 1))) {
ALWAYS_PRINT_SLIP = 1;
}
if (!(READV(ref ALWAYS_PROMPT_SLIP, COMMON.FILES[FL_CONTROL], "ALWAYS.PROMPT.SLIP", 1))) {
ALWAYS_PROMPT_SLIP = 0;
}
}
if (!(READ(ref EFT_STARS, COMMON.FILES[FL_CONTROL], "EFT.STARS"))) {
EFT_STARS = 8 + AM + 0;
}
if (!READV(ref EFT_AVS, COMMON.FILES[FL_CONTROL], "EFT.AVS", 1)) { EFT_AVS = FALSE; }
AVS = "";
if (EFT_AVS == TRUE) {
AVS = ";" + CARD_POSTCODE + ";";
MXHOUSENAMELEN = 40 - LEN(AVS);
CARD_HOUSENAME = OCONV(CARD_HOUSENAME, "MCAN");
if (LEN(CARD_HOUSENAME) > MXHOUSENAMELEN) { CARD_HOUSENAME = CARD_HOUSENAME.Substring(1, MXHOUSENAMELEN); }
AVS = CARD_HOUSENAME + AVS;
}
EFT_CUST_STARS = EFT_STARS[1];
EFT_SALE_STARS = EFT_STARS[2];
/*  The following prog.mess variables are used to pass error details */
/*  back to FWEFT (for web payments) */
PROG_MESS[17] = "";
/*  Error message number */
PROG_MESS[18] = "";
/*  Error message description */
EFTDATA_REC = TXFILE_TYPE + "," + EFT_MERCHANT + ",0" + TRANS_TYPE.Substring(2, 1) + "," + TRANS_T;
EFTDATA_REC = "T" + "," + EFT_MERCHANT + ",0" + TRANS_TYPE.Substring(2, 1) + "," + TRANS_T;
EFTDATA_REC = EFTDATA_REC + ",,";
if (SWIPE_DETS != "") {
SWIPE_DETS = FIELD(SWIPE_DETS, "?", 1) + "?0";
CARD_CVS = "";
EFTDATA_REC = EFTDATA_REC + SWIPE_DETS + "," + CARD_CVS + ",,,,";
} else {
EFTDATA_REC = EFTDATA_REC + CARD_NO + "," + CARD_CVS + "," + CARD_EXP.Substring(3, 2) + CARD_EXP.Substring(1, 2) + "," + CARD_ISSUE + "," + CARD_START.Substring(3, 2) + CARD_START.Substring(1, 2) + ",";
}
EFTDATA_REC = EFTDATA_REC + OCONV(SALE_AMNT, "MD2") + "," + CASHBACK_VALUE + ",,,,,," + AVS + ",,,,," + FORMAT(MERCH_REF, "L#50");
/* ** */
L0010:;
/*  Remove old Data files */
/* * */
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT");
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".CNF");
/* * */
/*  Write Request */
/* * */
if (SOCKET_MODE) {
nrf0 = 0;
FL_WINTI_SOCKET = new FL_WINTI_SOCKET(ref EFTDATA_REC, ref ACCT_REC, ref nrf0, ref CALLING_PROG, ref INTERACT, ref PORT_NAME);
if (FIELD(ACCT_REC[1], ",", 2) == 1) {
RESPONSE = TRUE;
}
if (FIELD(ACCT_REC[1], ",", 1) == -200) {
CHIPANDPINLEFTIN = TRUE;
}
/* CRT "HERE " ; INPUT FLEX */
RESULT_CODE = FIELD(ACCT_REC, ",", 1);
if (LEN(RESULT_CODE) == 7) {
RESULT_CODE = RESULT_CODE.Substring(1, 1);
}
if (RESULT_CODE >= 0 && RESULT_CODE < 7) {
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
PRGS_IND = PRGS_IND + 1;
/* CRT "ACCT.REC" : ACCT.REC ; INPUT FLEX */
L0700();
L0050();
if (CALLING_PROG != "FWEFT") {
L0100();
/* Prepare House Copy */
L0200();
/*  Prepare Customer Copy */
}
AUTH_CODE = FIELD(ACCT_REC, ",", 21);
}
/* * */
/*  GET ERROR CODE IF REQUIRED */
/* * */
if (!(READ(ref ERROR_REC, FL_EFT_ERRORS, RESULT_CODE + "*WINTI"))) {
if (!(READ(ref ERROR_REC, FL_EFT_ERRORS, RESULT_CODE))) {
ERROR_REC = "NOT KNOWN";
ERROR_REC[2] = "6";
}
}
ERROR_DESC = ERROR_REC[1];
ERROR_CODE = ERROR_REC[2];
USER_MESSAGE = FIELD(ACCT_REC, ",", 16) + VM + FIELD(ACCT_REC, ",", 17);
/* *** */
} else {
WRITE(EFTDATA_REC, FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".IN");
/*       WRITE EFTDATA.REC ON FL.EFT.SHARE,"FLXT0":PORT.NAME:".IN" */
RESPONSE = FALSE;
L0700();
/* * */
/*  Sleep 1 second then try to get response from server */
/* * */
L0700();
RESPONSE = FALSE;
RETRYS = 0;
CHIPANDPINLEFTIN = FALSE;
PROGRESS_MAX = MAX_STAGE1_TIME;
MAX_STAGE_TIME = TIME() + MAX_STAGE1_TIME;
do {
if (RESPONSE || TIME() > MAX_STAGE_TIME) break;
if (READ(ref ACCT_REC, FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT")) {
if (FIELD(ACCT_REC[1], ",", 2) == 1) {
RESPONSE = TRUE;
}
if (FIELD(ACCT_REC[1], ",", 1) == -200) {
CHIPANDPINLEFTIN = TRUE;
}
}
if (RESPONSE == FALSE) {
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
if (CHIPANDPINLEFTIN) {
goto L0010;
/*  RESTART - CARD LEFT IN */
}
if (CALLING_PROG == "TICKET.TOUCH" && RETRYS > 0) {
HideProgress();
}
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
/* ** */
/*  Remove old Data files */
/* * */
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT");
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".IN");
/* * */
}
RESULT_CODE = FIELD(ACCT_REC, ",", 1);
if (LEN(RESULT_CODE) == 7) {
RESULT_CODE = RESULT_CODE.Substring(1, 1);
}
EFT_CONF = FIELD(ACCT_REC, ",", 15) + AM + FIELD(ACCT_REC, ",", 14) + AM + FIELD(ACCT_REC, ",", 17);
/* ** */
/*  IF RESULT CODE IS NOT 7 (PREVIOUSLY AUTHORISED) THEN CARRY ON */
/* ** */
/* CRT "RESULT.CODE" ; INPUT FLEX */
if (RESULT_CODE >= 0 && RESULT_CODE < 7) {
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
if (READ(ref ACCT_REC, FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT")) {
RESPONSE = FIELD(ACCT_REC, ",", 2);
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
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT");
/* * */
}
PRGS_IND = PRGS_IND + 1;
/* CRT "ACCT.REC" : ACCT.REC ; INPUT FLEX */
L0700();
L0050();
if (CALLING_PROG != "FWEFT") {
L0100();
/* Prepare House Copy */
L0200();
/*  Prepare Customer Copy */
}
AUTH_CODE = FIELD(ACCT_REC, ",", 21);
}
RESULT_CODE = FIELD(ACCT_REC, ",", 1);
/* * */
/*  GET ERROR CODE IF REQUIRED */
/* * */
if (!(READ(ref ERROR_REC, FL_EFT_ERRORS, RESULT_CODE + "*WINTI"))) {
if (!(READ(ref ERROR_REC, FL_EFT_ERRORS, RESULT_CODE))) {
ERROR_REC = "NOT KNOWN";
ERROR_REC[2] = "6";
}
}
ERROR_DESC = ERROR_REC[1];
ERROR_CODE = ERROR_REC[2];
USER_MESSAGE = FIELD(ACCT_REC, ",", 16) + VM + FIELD(ACCT_REC, ",", 17);
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".IN");
}
/* ** DELETE OLD STUFF FOR SERCO */
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".OUT");
DELETE(FL_EFT_SHARE, TXFILE_TYPE + "000" + PORT_NAME + ".CNF");
return;
/* ******************** */
}
void L0050() {
/*  ASSIGN RETURN CODE VARIABLES */
/* ********************************** */
if (TRANS_TYPE.Substring(2, 1) == "2") {
EFT_PRINT_REC[EFT_TXTYPE] = "REFUND";
EFT_VOUCH_TYPE = "REFUND VOUCHER";
} else {
EFT_PRINT_REC[EFT_TXTYPE] = "DEBIT";
EFT_VOUCH_TYPE = "SALES VOUCHER";
}
EFT_PRINT_REC[EFT_CARDNO] = FIELD(ACCT_REC, ",", 5);
if (EFT_SALE_STARS > 0) {
EFT_CARDNO_SALE = STR("*", EFT_SALE_STARS) + EFT_PRINT_REC[EFT_CARDNO].Substring(EFT_SALE_STARS + 1, LEN(EFT_PRINT_REC[EFT_CARDNO]));
} else {
EFT_CARDNO_SALE = EFT_PRINT_REC[EFT_CARDNO];
}
if (EFT_CUST_STARS > 0) {
EFT_CARDNO_CUST = STR("*", EFT_CUST_STARS) + EFT_PRINT_REC[EFT_CARDNO].Substring(EFT_CUST_STARS + 1, LEN(EFT_PRINT_REC[EFT_CARDNO]));
} else {
EFT_CARDNO_CUST = EFT_PRINT_REC[EFT_CARDNO];
}
EFT_PRINT_REC[EFT_EXPINF] = "Exp: " + FIELD(ACCT_REC, ",", 6);
if (FIELD(ACCT_REC, ",", 8) != "") {
EFT_PRINT_REC[EFT_EXPINF] = "Start: " + FIELD(ACCT_REC, ",", 8) + " " + EFT_PRINT_REC[EFT_EXPINF];
}
if (FIELD(ACCT_REC, ",", 7) != "") {
EFT_PRINT_REC[EFT_EXPINF] = EFT_PRINT_REC[EFT_EXPINF] + " Issue " + FIELD(ACCT_REC, ",", 7);
}
if (CARD_EXP == "") { CARD_EXP = EFT_PRINT_REC[EFT_EXPINF]; }
EFT_PRINT_REC[EFT_AMOUNT] = SALE_AMNT;
/*      EFT.DATE = ACCT.REC<7>[1,6] */
EFT_PRINT_REC[EFT_DATE] = OCONV(DATE(), "D2/");
EFT_PRINT_REC[EFT_TIME] = OCONV(TIME(), "MTH");
EFT_PRINT_REC[EFT_EXTRAS] = FIELD(ACCT_REC, ",", 10) + " " + FIELD(ACCT_REC, ",", 11) + " " + FIELD(ACCT_REC, ",", 14);
EFT_CONF = FIELD(ACCT_REC, ",", 15) + AM + FIELD(ACCT_REC, ",", 14) + AM + MERCH_REF;
EFT_PRINT_REC[EFT_SCHEME] = FIELD(ACCT_REC, ",", 12);
EFT_PRINT_REC[EFT_AUTH_CODE] = FIELD(ACCT_REC, ",", 15);
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
SALE_PRT_REC[4] = "Card No   : " + EFT_CARDNO_SALE;
if (SWIPE_DETS == "") {
if (TRANS_TYPE.Substring(1, 1) == "8") {
SALE_PRT_REC[4] = SALE_PRT_REC[4] + " (Keyed-CHNP)";
} else {
SALE_PRT_REC[4] = SALE_PRT_REC[4] + " (Keyed) ";
}
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
CUST_PRT_REC[4] = "Card No   : " + EFT_CARDNO_CUST;
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
if (CALLING_PROG != "FWEFT" && CALLING_PROG != "FL.EFT.NET") {
nrf0 = "";
nrf1 = 1;
nrf2 = "";
nrf3 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref EFT_REPLY, ref CALLING_PROG);
}
if (RESPONSE == FALSE) { RQM(); }
/* !*  END */
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
