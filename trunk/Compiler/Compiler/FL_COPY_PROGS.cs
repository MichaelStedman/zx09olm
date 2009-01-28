//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_COPY_PROGS : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] TRANS_REC = new UvVar[20];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar TRANS_LOG_REC = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar PROCESS_EXECUTE = "";
UvVar EOF = "";
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
FL306 FL306;
UvVar CONTINUE = "";
UvVar CENTRE_CODE = "";
UvVar TRANS_ID = "";
FL006 FL006;
UvVar FILENAME = "";
UvVar LEEWAY_DATE = "";
UvVar INSTRUCTION = "";
UvVar LIST_1 = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_EXECUTE_PROG CallAt_PROCESS_EXECUTE;
//FL555 FL555;
UvVar SUCCESSFUL = "";
UvVar DD_KEY = "";
UvVar DD_REC = "";
FLTX2 FLTX2;
UvVar ANS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL_COPY_PROGS() {
#region INCLUDE FL.COMMON FL.COMMON

// FILES
//    Standard
//    Screen Control
//    Slave Printer Control
//    Special Video
//    User input control
//    Application Specific
//COMMON SC.POS
//    Theatre
//    Standard EQUates
//    Client app control
//\
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
// Prepares export for New Direct Debit Schedules
// Written :  23 Jun 99
// Author  :  Harjas Sidhu
//*********************************************************************
PROGRAM = "FL258";
// Define files used
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
// Initialise variables
INTERACT = VALID_DATA;
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
EOF = FALSE;
// Check for authorised user
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
//**************************
//      MAIN PROCESSING    *
//**************************
PRINT(COMMON.WASH);
FL306 = new FL306();
PRINTCR(AT(1, 0) + SCREEN_FOOT_BACK + "(FL258)");
PRINTCR(AT(65, 0) + OCONV(TODAYS_DATE, "D"));
PRINT(AT(20, 1) + "Direct Debit New Schedules Export ");
PRINT(AT(20, 2) + "=================================");
PRINT(SCREEN_TEXT);
PRINT(AT(10, 8));
PRINTCR("This procedure will produce a file of new Direct Debits.");
PRINT(AT(10, 9));
PRINT("Continue ? (Y/N) ");
INPUT(out CONTINUE, 2);
PRINT(AT(10, 11) + "Enter Centre Code (<RETURN> for all) ");
INPUT(out CENTRE_CODE, 3);
if (CENTRE_CODE == COMMON.ABANDON) { return; }
if (CONTINUE != "Y" && CONTINUE != "y") { return; }
TRANS_ID = "CONTROL*" + PROGRAM;
if (!(MATREAD(ref TRANS_REC, FL_UNIVERSE_TRANSFER, TRANS_ID))) {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
PRINT(AT(10, 13) + "Enter Filename (<RETURN> for " + TRANS_REC[TRANS_DESTINATION] + ") ");
INPUT(out FILENAME, 20);
if (FILENAME == COMMON.ABANDON) { return; } else { TRANS_REC[TRANS_DESTINATION] = FILENAME; }
LEEWAY_DATE = OCONV(TODAYS_DATE + 30, COMMON.D2);
//INSTRUCTION = 'SELECT FL.DIRECT.DEBITS WITH CANCELLED = "" AND WITH FROZEN = "" AND WITH 3 = "Y"'
if (CENTRE_CODE == "") {
INSTRUCTION = "SELECT FL.DIRECT.DEBITS WITH CANCELLED >= \" " + LEEWAY_DATE + "\" OR WITH CANCELLED = \"\" AND WITH FROZEN = \"\" AND WITH 3 = \"Y\"";
} else {
INSTRUCTION = "SELECT FL.DIRECT.DEBITS WITH CANCELLED >= \" " + LEEWAY_DATE + "\" OR WITH CANCELLED = \"\" AND WITH FROZEN = \"\" AND WITH 3 = \"Y\" AND WITH CENTRE = \"" + CENTRE_CODE + "\"";
}
nrf0 = "OS";
CallAt_PROCESS_EXECUTE = new CallAt_EXECUTE_PROG(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref LIST_1, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_DIRECTORY];
nrf2 = TRANS_REC[TRANS_DESTINATION];
//FL555 = new FL555(ref nrf0, ref PROGRAM, ref nrf1, ref nrf2, ref LIST_1, ref LIST_AVAILABLE, ref SUCCESSFUL);
// amend direct debit record letter indicator to show new schedule
// letter has been sent
nrf0 = "OS";
CallAt_PROCESS_EXECUTE = new CallAt_EXECUTE_PROG(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref LIST_1, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref DD_KEY, 0, 0, LIST_1)) { EOF = 1; }
if (EOF) break;
if (READ(ref DD_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY)) {
DD_REC[3] = "N";
WRITE(DD_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_KEY);
TRANS_LOG_REC = DD_REC;
nrf0 = "W";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_KEY);
}
} while (true);
}
PRINT(AT(10, 19) + "Process Complete (File = " + TRANS_REC[TRANS_DESTINATION] + " )");
INPUTCR(out ANS, 1);
return;
}
}
}
