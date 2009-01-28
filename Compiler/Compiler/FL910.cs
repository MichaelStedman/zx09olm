//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL910 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar EXIT = 2;
readonly UvVar VALID_DATA = 0;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_PASSWORDS = 1;
readonly UvVar PASS_PASS = 1;
readonly UvVar PASS_NAME = 2;
readonly UvVar PASS_STATUS = 3;
readonly UvVar PASS_PRIVILEGE = 4;
readonly UvVar PASS_SPECIAL = 5;
readonly UvVar PASS_DEPT = 6;
readonly UvVar PASS_DATE = 7;
readonly UvVar PASS_USER_CHANGED = 8;
readonly UvVar PASS_DATE_CHANGED = 9;
readonly UvVar PASS_TIME_CHANGED = 10;
readonly UvVar PASS_EMAIL_ADDRESS = 11;
readonly UvVar FL_AUTHORISED = 113;
readonly UvVar FL_VIRGIN_CONTROL = 99;
readonly UvVar DICT_FL_TICKETS = 63;
readonly UvVar DICT_FL_LEDGER_TRANSFER = 67;
readonly UvVar DICT_FL_BANKINGS = 93;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] PASS_REC = new UvVar[15];
UvVar[] VIRGIN_REC = new UvVar[20];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TRANS_LOG_REC = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar SPECIAL_PASS_REC = "";
UvVar IGNORE_NO = "";
UvVar SPECIAL_PASS = "";
FL000_10 FL000_10;
UvVar WAIT = "";
UvVar INTERACT = "";
UvVar TYPE_TO_CLEAR = "";
FL006 FL006;
FLTX2 FLTX2;
UvVar FILE_LIST_ITEM = "";
UvVar LAST_NUMBER_KEY = "";
UvVar PERIODS = "";
UvVar DATES_LIST = "";
UvVar ITEM_TO_DELETE = "";
UvVar INSTRUCTION = "";
UvVar TLIST = "";
UvVar LIST_AVAIL = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar EOF = "";
UvVar ID = "";
UvVar AUTH_REC = "";
UvVar FILES_TO_CLEAR = "";
UvVar FILE_NO = "";
UvVar FILENAME = "";
UvVar FILE_NAME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL910() {
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
/*  Clears ALL data within the system */
/*  ASSIGN FILES AND EQUATE COMMON VARIABLES     * */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL910";
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.PASSWORDS

#endregion
#region INCLUDE FL.FILES FL.AUTHORISED

/*  each attributes contains an authorised user */

#endregion
#region INCLUDE FL.FILES FL.VIRGIN.CONTROL

#endregion
/*  SCREEN DISPLAY AND PASSWORD VALIDATION     * */
if (!(READ(ref SPECIAL_PASS_REC, COMMON.FILES[FL_CONTROL], "CLEARING.PASS"))) {
SPECIAL_PASS_REC = "FLEXSYSTEMSLIMITED";
}
IGNORE_NO = MOD(DATE(), 7) + 1;
SPECIAL_PASS = SPECIAL_PASS_REC[1].Substring(1, IGNORE_NO - 1) + SPECIAL_PASS_REC[1].Substring(IGNORE_NO + 1, 99);
nrf0 = 0;FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
PRINT(AT(10, 10) + "This process will remove selected data within");
PRINT(AT(10, 12) + "your system.  Please confirm you wish to");
PRINT(AT(10, 14) + "proceed.       Type (Y/N) ");
INPUT(out WAIT, 2);
if (WAIT == "Y") {
PRINT(AT(0, 4) + COMMON.EOS);
PRINTCR("[" + SPECIAL_PASS + "]");
PRINT(AT(10, 10) + "Input VERY Special Password ");
ECHO_OFF();
INPUT(out COMMON.PASSWORD, 20);
ECHO_ON();
if (COMMON.PASSWORD != SPECIAL_PASS) {
PRINT(AT(10, 12) + "WRONG PASSWORD - TRY AGAIN !! ");
INPUT(out WAIT, 1);
return;
}
PRINT(AT(0, 4) + COMMON.EOS);
INTERACT = INVALID_DATA;
do {
PRINT(AT(0, 10) + COMMON.EOL + AT(5, 10) + "Enter (T)ickets,(B)ookings,(O)ther or (A)ll for files to clear ");
INPUTCR(out TYPE_TO_CLEAR, 1);
if (TYPE_TO_CLEAR != "T" && TYPE_TO_CLEAR != "B" && TYPE_TO_CLEAR != "O" && TYPE_TO_CLEAR != "A") {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
if (TYPE_TO_CLEAR == "A") {
TYPE_TO_CLEAR = "T";
L0100();
TYPE_TO_CLEAR = "B";
L0100();
TYPE_TO_CLEAR = "O";
L0100();
} else {
L0100();
}
if (TYPE_TO_CLEAR == "O") {
MAT(ref PASS_REC, INIT);
PASS_REC[1] = 24710;
PASS_REC[2] = "Master Password";
PASS_REC[3] = "A";
PASS_REC[4] = "M";
PASS_REC[5] = "T";
PASS_REC[7] = 99999;
MATWRITE(PASS_REC, COMMON.FILES[FL_PASSWORDS], "MSTR");
if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_PASSWORDS], "MSTR")) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.PASSWORDS";
nrf2 = "MSTR";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
}
PRINT(AT(0, 12) + COMMON.EOL + AT(10, 12) + "Resetting control items ");
PRINT(AT(0, 14) + COMMON.EOL + AT(10, 14) + "All ticket files cleared and numbers reset ");
INPUTCR(out WAIT, 1);
/*  Write last user details to special password record for security */
SPECIAL_PASS_REC[2] = U_INITS;
SPECIAL_PASS_REC[3] = DATE();
SPECIAL_PASS_REC[4] = TIME();
TRANS_LOG_REC = SPECIAL_PASS_REC;
nrf0 = "W";nrf1 = "FL.CONTROL";nrf2 = "CLEARING.PASS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
} else {
PRINT(AT(0, 4) + COMMON.EOS);
PRINT(AT(10, 10) + "Process Abandoned.");
PRINT(AT(10, 12) + "NO CLEARING HAS OCCURRED ");
}
/*  RETURN TO CALLING PROGRAM    * */
return;
}
void L0100() {
/*   MAIN PROCESS SECTION     * */
// BEGIN CASE
// CASE
if (TYPE_TO_CLEAR == "T") {
FILE_LIST_ITEM = "TICKET.FILES.TO.CLEAR";
LAST_NUMBER_KEY = COMMON.CENTRE + "*LAST.NUMBER";
nrf0 = "D";nrf1 = "DICT FL.TICKETS";nrf2 = "LAST.NUMBER.KEY";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "D";nrf1 = "DICT FL.BANKINGS";nrf2 = "BANKING.MASTER";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (TYPE_TO_CLEAR == "B") {
FILE_LIST_ITEM = "BOOKING.FILES.TO.CLEAR";
if (!(READ(ref PERIODS, COMMON.FILES[DICT_FL_LEDGER_TRANSFER], "ALL.PERIODS"))) {
PERIODS = INIT;
}
DATES_LIST = INIT;
do {
DATES_LIST = DATES_LIST + 1;
if (PERIODS[1, DATES_LIST] == "") break;
ITEM_TO_DELETE = "PERIOD*" + PERIODS[1, DATES_LIST];
nrf0 = "D";nrf1 = "DICT FL.LEDGER.TRANSFER";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ITEM_TO_DELETE);
} while (true);
nrf0 = "D";nrf1 = "DICT FL.LEDGER.TRANSFER";nrf2 = "ALL.PERIODS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (TYPE_TO_CLEAR == "O") {
FILE_LIST_ITEM = "OTHER.FILES.TO.CLEAR";
/*  Initialise 'FL.AUTHORISED' records */
INSTRUCTION = "SELECT FL.AUTHORISED";
nrf0 = "SO";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref TLIST, ref LIST_AVAIL, ref OTHERS, ref MESSAGES);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, TLIST)) { EOF = TRUE; }
if (EOF == TRUE) break;
if (READ(ref AUTH_REC, COMMON.FILES[FL_AUTHORISED], ID)) {
AUTH_REC = "MSTR";
TRANS_LOG_REC = AUTH_REC;
nrf0 = "W";nrf1 = "FL.AUTHORISED";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ID);
}
} while (true);
/*  Delete specified 'FL.CONTROL' items */
INSTRUCTION = "SELECT FL.CONTROL = \"[*COLOURS.TO.USE\"";
nrf0 = "SO";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref TLIST, ref LIST_AVAIL, ref OTHERS, ref MESSAGES);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, TLIST)) { EOF = TRUE; }
if (EOF == TRUE) break;
nrf0 = "D";nrf1 = "FL.CONTROL";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ID);
} while (true);
nrf0 = "D";nrf1 = "FL.CONTROL";nrf2 = "RESIZE.FILES";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "D";nrf1 = "FL.CONTROL";nrf2 = "ARCHIVE.DATE";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "D";nrf1 = "FL.CONTROL";nrf2 = "CUSTOMER.NO";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "D";nrf1 = "FL.CONTROL";nrf2 = "FRAME.SIZE";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "D";nrf1 = "FL.CONTROL";nrf2 = "AUTO.MULTI.BOOKING";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
/*  Copy 'FL.VIRGIN.CONTROL' items to 'FL.CONTROL' */
INSTRUCTION = "SELECT FL.VIRGIN.CONTROL";
nrf0 = "SO";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref TLIST, ref LIST_AVAIL, ref OTHERS, ref MESSAGES);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, TLIST)) { EOF = TRUE; }
if (EOF == TRUE) break;
if (MATREAD(ref VIRGIN_REC, COMMON.FILES[FL_VIRGIN_CONTROL], ID)) {
MAT(ref CONTROLS_REC, VIRGIN_REC);
MATWRITE(VIRGIN_REC, COMMON.FILES[FL_CONTROL], ID);
if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_CONTROL], ID)) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.CONTROL";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ID);
}
} while (true);
}
// END CASE
if (!(READ(ref FILES_TO_CLEAR, COMMON.FILES[FL_CONTROL], FILE_LIST_ITEM))) {
FILES_TO_CLEAR = "";
}
FILE_NO = 1;
do {
FILENAME = FILES_TO_CLEAR[FILE_NO];
if (FILENAME == "") break;
PRINT(AT(0, 10) + COMMON.EOL + AT(10, 10) + "Clearing " + FILENAME);
if (FILENAME[FILE_NO, 2] == "") {
INSTRUCTION = "CLEAR-FILE DATA " + FILENAME;
nrf0 = "C";
nrf1 = "";
FLTX2 = new FLTX2(ref nrf0, ref FILE_NAME, ref nrf1);
}
L1000();
FILE_NO = FILE_NO + 1;
} while (true);
return;
}
void L1000() {
/*      SUBROUTINE     * */
nrf0 = "O";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref TLIST, ref LIST_AVAIL, ref OTHERS, ref MESSAGES);
return;
/*    PROGRAM END     * */
}
}
}
