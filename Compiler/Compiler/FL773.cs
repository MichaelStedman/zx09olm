//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL773 : UvBase
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
UvVar TODAYS_DATE = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar SCREEN_HEAD_BACK = "";
UvVar SCREEN_HEAD_FORE = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SC_POS = "";
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
UvVar REPLY = "";
UvVar ROW = "";
UvVar PROC_REC = "";
UvVar NO_ATTS = "";
UvVar FINISHED = "";
UvVar ATT_NO = "";
UvVar TEMP_ID = "";
UvVar INSTR = "";
UvVar TRANS_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESS = "";
UvVar ERRORS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar N = "";
FL551 FL551;
FL555 FL555;
FL776 FL776;
FL019 FL019;
UvVar PROMPT_NO = "";
FL306 FL306;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL773(ref UvVar TYPE, ref UvVar TRANSFER_NAME, ref UvVar SUCCESSFUL) {
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
PROGRAM = "FL773";
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
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
L0100();
OK_TO_PROCEED = TRUE;
if (TYPE.Substring(1, 1) == "A") {
AUTO_TRANS = TRUE;
TYPE = TYPE.Substring(2, LEN(TYPE) - 1);
} else {
AUTO_TRANS = FALSE;
}
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
/*  Tell user where exported file will reside and give them an */
/*  opportunity to abandon */
PRINT(AT(5, 5) + "This process will export data to the following location:");
PRINT(AT(5, 7) + TRANS_REC[TRANS_DIRECTORY] + DESTINATION_FILE + "." + TYPE);
REPLY = "";
if (AUTO_TRANS) { REPLY = "Y"; }
do {
if (REPLY == "Y" || REPLY == "y" || REPLY == "N" || REPLY == "n" || REPLY == COMMON.ABANDON) break;
PRINT(AT(5, 9) + "Do you wish to continue? (Y/N) " + COMMON.EOL);
INPUT(out REPLY, 2);
} while (true);
if (REPLY == "Y" || REPLY == "y") {
for(ROW = 5; ROW <= 9; ROW += 1) {
PRINT(AT(0, ROW) + COMMON.EOL);
}
L0050();
}
return;
}
void L0050() {
/*  Main processing section */
if (TRANS_REC[TRANS_PROCEDURE] != "") {
/*  DJA 29.10.99 * */
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
nrf0 = 21;
nrf1 = TRANS_REC[TRANS_PROCEDURE];
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
TRANS_REC[TRANS_PROCEDURE] = "";
}
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
for(N = 3; N <= 19; N += 1) {
PRINT(AT(0, N) + COMMON.EOL);
}
PRINT(AT(10, 6));
if (TRANS_REC[TRANS_PROCEDURE] == "" && TRANS_REC[TRANS_SELECT_LIST] == "") {
INSTR = "SELECT " + TRANS_REC[TRANS_FILENAME];
nrf0 = "COS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref TRANS_LIST, ref LIST_AVAILABLE, ref MESS, ref ERRORS);
}
/* !*     IF PROGRAM = "FL550" THEN */
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
FL551 = new FL551(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
} else {
/* ********************************** */
/* ********************************** */
/* *   CSV EXPORT */
/* ********************************** */
/* ********************************** */
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL555 = new FL555(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
}
/*  If sufficient details have been provided in the transfer, offer */
/*  the user the chance to launch Word */
if (SUCCESSFUL) {
if (AUTO_TRANS) {
TYPE = "A" + TYPE;
FL776 = new FL776(ref TRANS_REC, ref TYPE);
RQM();
} else {
FL776 = new FL776(ref TRANS_REC, ref TYPE);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + "TRANSFER COMPLETE. Press <return> to continue.");
nrf0 = 1;
FL019 = new FL019(ref nrf0, ref REPLY);
PRINT(AT(0, 3) + NRM_VID);
}
} else {
nrf0 = 91;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
PROMPT_NO = 1;
PRINT(COMMON.WASH);
FL306 = new FL306();
PRINT(AT(78, 20) + NRM_VID + AT(1, 20) + DIM_REV_VID + SPACE(76));
PRINT(AT(0, 0) + SCREEN_HEAD_BACK + SCREEN_HEAD_FORE);
PRINT(AT(1, 0) + "(" + SCREEN_CODE + ")");
PRINT(AT(65, 0) + OCONV(TODAYS_DATE, "D"));
PRINT(AT(26, 1) + SC_POS[1]);
PRINT(AT(0, 3) + NRM_VID);
return;
}
}
}
