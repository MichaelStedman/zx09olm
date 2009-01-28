//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CLARITY_TILLWRITE : UvBase
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
readonly UvVar FL_TILL_NUMBERS = 14;
readonly UvVar TILL_TILL_NUMBER = 1;
readonly UvVar TILL_LOCATION = 2;
readonly UvVar TILL_TICKET_PRINTER_TYPE = 3;
readonly UvVar TILL_TERMINAL_TYPE = 4;
readonly UvVar TILL_AUDITORIUM_CODE = 5;
readonly UvVar TILL_CASH_DRAWER = 6;
readonly UvVar TILL_TRANS_TICK_PRINT = 7;
readonly UvVar TILL_TICKET_PRINTER_QUE = 8;
readonly UvVar TILL_ACTUAL_PORT = 9;
readonly UvVar TILL_REC_SLIP_PRINT = 10;
readonly UvVar TILL_AMT_TENDERED = 11;
readonly UvVar TILL_POD = 12;
readonly UvVar TILL_ENDORSE_CHEQUE = 13;
readonly UvVar TILL_HOME_LOCATION = 14;
readonly UvVar TILL_MULTIUSER_TOUCHSCREEN = 15;
readonly UvVar TILL_TICKET_PRINTER_INTERFACE = 16;
readonly UvVar TILL_TICKET_PRINTER_NAME = 17;
readonly UvVar TILL_KITCHEN_PRINTER_INTERFACE = 18;
readonly UvVar TILL_KITCHEN_PRINTER_NAME = 19;
readonly UvVar TILL_LOCATION_DESC = 20;
readonly UvVar TILL_THROW_LINES = 21;
readonly UvVar TILL_TICKET_STUB = 22;
readonly UvVar FL_MD = 58;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TILL_REC = new UvVar[25];
#endregion
#region Variables
UvVar CLARITY_REC = "";
UvVar TICKET_REC = "";
UvVar AMOUNT = "";
UvVar DESCRIPTION = "";
UvVar INTERACT = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar TILL_NUMBER = "";
UvVar PROGRAM = "";
UvVar EXECUTE_PROG = "";
UvVar INTERFACE_LOG = "";
UvVar CLARITY_TILL = "";
UvVar CLARITY_PATH = "";
UvVar MD_ENTRY = "";
UvVar WORKFILE = "";
UvVar FILENAME = "";
UvVar DOS_COMMAND = "";
UvVar OPENSEQ = "";
UvVar OUT_FILE = "";
UvVar CREATE = "";
FL006 FL006;
UvVar TRANS_NO = "";
UvVar SIGN_REQD = "";
UvVar WRITE_REC = "";
UvVar WRITESEQ = "";
UvVar POS = "";
UvVar WEOFSEQ = "";
UvVar CLOSESEQ = "";
UvVar MESSAGE = "";
UvVar RESPONSE_ID = "";
UvVar INTERFACE_ID = "";
UvVar RESPONSE_REC = "";
FL_CLARITY_TILL FL_CLARITY_TILL;
UvVar BB = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_CLARITY_TILLWRITE(ref UvVar CLARITY_REC, ref UvVar TICKET_REC, ref UvVar AMOUNT, ref UvVar DESCRIPTION, ref UvVar INTERACT) {
this.CLARITY_REC = CLARITY_REC;
this.TICKET_REC = TICKET_REC;
this.AMOUNT = AMOUNT;
this.DESCRIPTION = DESCRIPTION;
this.INTERACT = INTERACT;
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
// WRITES TICKETS TO CLARITY TILL
PROGRAM = "FL.CLARITY.TILL.WRITE";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
// Equate the files to be used *
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS
#region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

#endregion

#region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

#endregion

#endregion
if (!OPEN("INTERFACE.LOG", out INTERFACE_LOG)) { NULL(); }
#region INCLUDE FL.FILES FL.MD

#endregion
INTERACT = "";
if (!(MATREAD(ref TILL_REC, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER))) {
MAT(ref TILL_REC, INIT);
}
if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "CLARITY") {
TILL_REC[TILL_TICKET_PRINTER_TYPE] = "TMT80G";
CLARITY_TILL = TRUE;
} else {
CLARITY_TILL = FALSE;
}
if (!(READ(ref CLARITY_PATH, COMMON.FILES[FL_CONTROL], "CLARITY.TILL.PATH"))) {
CLARITY_PATH = "";
}
MD_ENTRY = "F";
MD_ENTRY[2] = CLARITY_PATH[1, 1];
MD_ENTRY[3] = "D_VOC";
WRITE(MD_ENTRY, COMMON.FILES[FL_MD], "CLARITY.TILL");
if (!OPEN("CLARITY.TILL", out CLARITY_TILL)) { NULL(); }
WORKFILE = CLARITY_PATH[1, 1] + "FlexWorkFile_" + TILL_NUMBER;
FILENAME = CLARITY_PATH[1, 1] + "FlexResponse_" + TILL_NUMBER;
DOS_COMMAND = "DOS /C COPY " + WORKFILE + " " + FILENAME;
OPENSEQ
WORKFILE
CREATE
OUT_FILE
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
// Constants
TRANS_NO = TICKET_REC[14];
if (AMOUNT < 0) {
SIGN_REQD = "-";
AMOUNT = ABS(AMOUNT);
} else {
SIGN_REQD = 0;
}
WRITE_REC = "02" + FORMAT(TRANS_NO, "R#10") + SIGN_REQD + FORMAT(AMOUNT, "R%7") + FORMAT(DESCRIPTION, "L#20");
WRITESEQ
WRITE_REC
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
POS = 1;
do {
if (CLARITY_REC[POS] == "") break;
WRITESEQ
CLARITY_REC
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
POS = POS + 1;
} while (true);
WEOFSEQ
OUT_FILE
CLOSESEQ
OUT_FILE
EXECUTE(DOS_COMMAND, MESSAGE, string.Empty, string.Empty, string.Empty);
RESPONSE_ID = "FlexResponse_" + TILL_NUMBER;
INTERFACE_ID = TIME() + "*" + DATE() + "*FlexResponse_" + TILL_NUMBER;
if (READ(ref RESPONSE_REC, CLARITY_TILL, RESPONSE_ID)) {
WRITE(RESPONSE_REC, INTERFACE_LOG, INTERFACE_ID);
}
nrf0 = "ClarityResponse";
FL_CLARITY_TILL = new FL_CLARITY_TILL(ref nrf0, ref BB, ref INTERACT);
return;
}
}
