//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL773_PHANTOM : UvBase
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
readonly UvVar TRANS_FILENAME = 1;
readonly UvVar TRANS_SELECT_LIST = 2;
readonly UvVar TRANS_PROCEDURE = 3;
readonly UvVar TRANS_DIRECTORY = 4;
readonly UvVar TRANS_DESTINATION = 5;
readonly UvVar TRANS_SEQ_OVER = 6;
readonly UvVar TRANS_TEMPLATE = 7;
readonly UvVar TRANS_DOCUMENT = 8;
readonly UvVar TRANS_MACRO = 9;
readonly UvVar TRANS_APPLICATION = 10;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MD = 58;
readonly UvVar FL_AD_HOC_ENQUIRIES = 101;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TRANS_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar TYPE = "";
UvVar TRANSFER_NAME = "";
UvVar SUCCESSFUL = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar AM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar EXECUTE_PROG = "";
UvVar SCREEN_CODE = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar OK_TO_PROCEED = "";
UvVar AUTO_TRANS = "";
UvVar TRANSID = "";
FL006 FL006;
UvVar SEQ_ID = "";
UvVar FILESEQNO = "";
UvVar DESTINATION_FILE = "";
UvVar PROC_REC = "";
UvVar NO_ATTS = "";
UvVar FINISHED = "";
UvVar ATT_NO = "";
UvVar TEMP_ID = "";
UvVar ROW = "";
UvVar INSTR = "";
UvVar TRANS_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESS = "";
UvVar ERRORS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
FL551_PHANTOM FL551_PHANTOM;
FL555_PHANTOM FL555_PHANTOM;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL773_PHANTOM(ref UvVar TYPE, ref UvVar TRANSFER_NAME, ref UvVar SUCCESSFUL) {
this.TYPE = TYPE;
this.TRANSFER_NAME = TRANSFER_NAME;
this.SUCCESSFUL = SUCCESSFUL;
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
/*  Control procedure for export (both DBF and CSV as of June 98) */
PROMPT("");
PROGRAM = "FL773.PHANTOM";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
SCREEN_CODE = PROGRAM;
SUCCESSFUL = FALSE;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MD

#endregion
#region INCLUDE FL.FILES FL.AD.HOC.ENQUIRIES

#endregion
/* ************************************ */
/*   Get Screen Definition Item       * */
/* ************************************ */
OK_TO_PROCEED = TRUE;
AUTO_TRANS = FALSE;
TRANSID = "CONTROL*" + TRANSFER_NAME;
if (!(MATREAD(ref TRANS_REC, FL_UNIVERSE_TRANSFER, TRANSID))) {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref TRANSID);
return;
}
if (TRANS_REC[TRANS_SEQ_OVER] == "S") {
SEQ_ID = "COUNT*" + TRANSFER_NAME;
if (!READVU(ref FILESEQNO, FL_UNIVERSE_TRANSFER, SEQ_ID, 1)) { SEQ_ID = 0; }
FILESEQNO = FILESEQNO + 1;
DESTINATION_FILE = TRANS_REC[TRANS_DESTINATION] + FILESEQNO;
WRITEV(FILESEQNO, FL_UNIVERSE_TRANSFER, SEQ_ID, 1);
} else {
DESTINATION_FILE = TRANS_REC[TRANS_DESTINATION];
}
L0050();
return;
}
void L0050() {
/*  Main processing section */
/*  Validate procedure exists, strip out clear screens and */
/*  position cursor on-screen */
if (READ(ref PROC_REC, COMMON.FILES[FL_AD_HOC_ENQUIRIES], TRANS_REC[TRANS_PROCEDURE])) {
NO_ATTS = DCOUNT(PROC_REC, AM);
FINISHED = FALSE;
ATT_NO = 1;
do {
if (ATT_NO > NO_ATTS || FINISHED) break;
if (PROC_REC[ATT_NO] == "T C") {
PROC_REC = DELETE(PROC_REC, ATT_NO, 0, 0);
FINISHED = TRUE;
} else {
ATT_NO = ATT_NO + 1;
}
} while (true);
TEMP_ID = "FL773*TEMP*" + PORT_NUMBER;
WRITE(PROC_REC, COMMON.FILES[FL_MD], TEMP_ID);
for(ROW = 3; ROW <= 19; ROW += 1) {
PRINT(AT(0, ROW) + COMMON.EOL);
}
PRINT(AT(0, 3));
EXECUTE(TEMP_ID, string.Empty, string.Empty, string.Empty, string.Empty);
} else {
TRANS_REC[TRANS_PROCEDURE] = "";
}
/*  Use select list if specified */
if (TRANS_REC[TRANS_SELECT_LIST] != "") {
INSTR = "GET-LIST " + TRANS_REC[TRANS_SELECT_LIST];
nrf0 = "COS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref TRANS_LIST, ref LIST_AVAILABLE, ref MESS, ref ERRORS);
if (NOT(LIST_AVAILABLE)) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
OK_TO_PROCEED = TRUE;
}
/*  Select the whole file if no procedure or list name */
if (OK_TO_PROCEED) {
if (TRANS_REC[TRANS_PROCEDURE] == "" && TRANS_REC[TRANS_SELECT_LIST] == "") {
INSTR = "SELECT " + TRANS_REC[TRANS_FILENAME];
nrf0 = "COS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref TRANS_LIST, ref LIST_AVAILABLE, ref MESS, ref ERRORS);
}
if (TRANS_REC[TRANS_TEMPLATE] == "") { TRANS_REC[TRANS_TEMPLATE] = TRANSFER_NAME; }
if (TYPE == "DBF") {
/* ************************************* */
/* ************************************* */
/* *   DBF EXPORT */
/* ************************************* */
/* ************************************* */
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL551_PHANTOM = new FL551_PHANTOM(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
} else {
/* ********************************** */
/* ********************************** */
/* *   CSV EXPORT */
/* ********************************** */
/* ********************************** */
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL555_PHANTOM = new FL555_PHANTOM(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
}
}
return;
}
}
}
