//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_RTEFT_CONF : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar ERROR_CODE = "";
UvVar PORT_NAME = "";
UvVar EFT_CONFTYPE = "";
UvVar EFT_AUTH = "";
UvVar EFT_SEQ = "";
UvVar EFT_MERCH = "";
UvVar CALLING_PROG = "";
UvVar PORT_NUMBER = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar FL_EFT_SHARE = "";
UvVar FL_EFT_ERRORS = "";
UvVar EFT_ACCEPTED = "";
UvVar EFT_DECLINED = "";
UvVar EFT_PROMPT = "";
UvVar RESULT_CODE = "";
UvVar MAX_STAGE1_RETRYS = "";
UvVar MAX_STAGE2_RETRYS = "";
UvVar CONF_REC = "";
UvVar RESPONSE = "";
UvVar RETRYS = "";
UvVar PROGRESS_MAX = "";
UvVar STATUS_REC = "";
UvVar SEGMESS = "";
UvVar PROGRESS_COUNT = "";
UvVar ACCT_REC = "";
FL_EFT_STATUS FL_EFT_STATUS;
UvVar EFT_REPLY = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_RTEFT_CONF(ref UvVar ERROR_CODE, ref UvVar PORT_NAME, ref UvVar EFT_CONFTYPE, ref UvVar EFT_AUTH, ref UvVar EFT_SEQ, ref UvVar EFT_MERCH, ref UvVar CALLING_PROG) {
this.ERROR_CODE = ERROR_CODE;
this.PORT_NAME = PORT_NAME;
this.EFT_CONFTYPE = EFT_CONFTYPE;
this.EFT_AUTH = EFT_AUTH;
this.EFT_SEQ = EFT_SEQ;
this.EFT_MERCH = EFT_MERCH;
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
/* EFT Transation Confirmation / Denial (commidea) */
PROGRAM = "FL.RTEFT.CONF";
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
EFT_ACCEPTED = "1";
EFT_DECLINED = "9";
EFT_PROMPT = "";
RESULT_CODE = "N/A";
MAX_STAGE1_RETRYS = 30;
MAX_STAGE2_RETRYS = 180;
/* * */
/*  PERFORM AUTHORISATION */
/*  OR DECLINATION */
/* ** */
CONF_REC = "";
CONF_REC[1] = EFT_CONFTYPE;
CONF_REC[2] = EFT_AUTH;
CONF_REC[3] = EFT_SEQ;
CONF_REC[4] = EFT_MERCH;
WRITE(CONF_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".CNF");
/*      WRITE CONF.REC ON FL.EFT.SHARE,"FLXC":PORT.NAME:".CNF" */
if (EFT_CONFTYPE == EFT_DECLINED) {
L0200();
/* Wait for confirmation of rejection */
} else {
/*  WAIT FOR CONFIRMATION OF CONFIRMATION */
RESPONSE = FALSE;
RETRYS = 0;
PROGRESS_MAX = MAX_STAGE1_RETRYS;
/*  ONLY GET FINAL CONFIRMATION IF NOT ALREADY SORT */
/*         IF ERROR.CODE # 7 THEN */
STATUS_REC = "";
/* !!        DELETE FL.EFT.SHARE,"FIO":PORT.NAME:".STA" */
CRT(1);
do {
if (RESPONSE || RETRYS > MAX_STAGE1_RETRYS) break;
if (READ(ref STATUS_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA")) {
if (INDEX(STATUS_REC, "Confirmed", 1) > 0) {
RESPONSE = TRUE;
} else {
SEGMESS = "";
SEGMESS[6] = "Waiting for final confirmation";
L0300();
}
} else {
CRT(1);
}
if (RESPONSE == FALSE) {
if (CALLING_PROG == "TICKET.TOUCH") {
if (RETRYS == 0) { ShowProgress(); }
}
}
RETRYS = RETRYS + 1;
if (RESPONSE == FALSE) {
if (CALLING_PROG == "TICKET.TOUCH") {
PROGRESS_COUNT = RETRYS;
UpdateProgress();
}
}
} while (true);
if (CALLING_PROG == "TICKET.TOUCH") {
HideProgress();
}
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
RESULT_CODE = ACCT_REC[1];
EFT_CONFTYPE = EFT_DECLINED;
CONF_REC = "";
CONF_REC[1] = EFT_CONFTYPE;
CONF_REC[2] = EFT_AUTH;
CONF_REC[3] = EFT_SEQ;
CONF_REC[4] = EFT_MERCH;
WRITE(CONF_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".CNF");
/*            WRITE CONF.REC ON FL.EFT.SHARE,"FLXC":PORT.NAME:".CNF" */
L0200();
/*  get abort confirmation */
}
/*         END */
CRT(1);
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2");
}
return;
/* **** */
}
void L0200() {
/*  Wait for abort confirmation */
/* **** */
SEGMESS = "";
SEGMESS[6] = "Waiting for Abort Confirmation";
/* * */
/*  Sleep 1 second then try to get response from server */
/* * */
RESPONSE = FALSE;
RETRYS = 0;
PROGRESS_MAX = MAX_STAGE2_RETRYS;
do {
CRT(1);
if (RESPONSE || RETRYS > MAX_STAGE1_RETRYS) break;
if (READ(ref ACCT_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1")) { RESPONSE = TRUE; } else { RETRYS = RETRYS + 1; }
SEGMESS[6] = "Waiting for Abort Confirmation";
L0300();
} while (true);
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
}
RESULT_CODE = ACCT_REC[1];
RESPONSE = FALSE;
RETRYS = 0;
do {
CRT(1);
if (RESPONSE || RETRYS > MAX_STAGE2_RETRYS) break;
if (READ(ref ACCT_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2")) {
RESPONSE = TRUE;
} else {
if (CALLING_PROG == "TICKET.TOUCH" && RETRYS == 0) {
ShowProgress();
}
RETRYS = RETRYS + 1;
if (CALLING_PROG == "TICKET.TOUCH") {
PROGRESS_COUNT = RETRYS;
UpdateProgress();
}
}
if ((RETRYS / 10) == INT(RETRYS / 10)) {
SEGMESS[6] = "Waiting for Abort Confirmation";
L0300();
}
} while (true);
if (CALLING_PROG == "TICKET.TOUCH" && RETRYS > 0) {
HideProgress();
}
if (RESPONSE == FALSE) {
ACCT_REC = "-1";
ERROR_CODE = 2;
}
SEGMESS[6] = "Waiting for Abort Confirmation";
L0300();
/* *** */
ERROR_CODE = 10;
INTERACT = INVALID_DATA;
return;
/* **** */
}
void L0300() {
/*  PROGRESS UPDATE */
/* **** */
RQM();
/*      READ STATUS.REC FROM FL.EFT.SHARE,"FIO":PORT.NAME:".STA" ELSE STATUS.REC = "Waiting for EFT" */
/*      PRINT ERR.LINE : EOL : ERR.LINE : DIM.VID:STATUS.REC<1> "L#40" :NRM.VID: */
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
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
