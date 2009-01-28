//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CLARITY_TILL : UvBase
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
UvVar READ_TYPE = "";
UvVar CLARITY_TRANSNO = "";
UvVar INTERACT = "";
UvVar PORT_NUMBER = "";
UvVar TILL_NUMBER = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar INTERFACE_LOG = "";
UvVar TICKET_PRINTER_TYPE = "";
UvVar CLARITY_TILL = "";
UvVar CLARITY_PATH = "";
UvVar MD_ENTRY = "";
FL006 FL006;
UvVar FILENAME = "";
UvVar REC_TYPE = "";
UvVar CLARITY_REC = "";
UvVar INTERFACE_ID = "";
UvVar RESPONSE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_CLARITY_TILL(ref UvVar READ_TYPE, ref UvVar CLARITY_TRANSNO, ref UvVar INTERACT) {
this.READ_TYPE = READ_TYPE;
this.CLARITY_TRANSNO = CLARITY_TRANSNO;
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
// Check for reposnse from Clarity ePos
PROMPT("");
PROGRAM = "FL.CLARITY.TILL";
SCREEN_CODE = PROGRAM;
//********************************
//  Define Files Used            *
//********************************
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
#region INCLUDE FL.FILES FL.MD

#endregion
if (!OPEN("INTERFACE.LOG", out INTERFACE_LOG)) { NULL(); }
if (!(READV(ref TICKET_PRINTER_TYPE, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER, 3))) {
TICKET_PRINTER_TYPE = "";
}
if (!(READ(ref CLARITY_TILL, COMMON.FILES[FL_CONTROL], "CLARITY.TILL.PATH"))) {
CLARITY_TILL = "";
}
CLARITY_PATH = CLARITY_TILL[1, 1];
MD_ENTRY = "F";
MD_ENTRY[2] = CLARITY_PATH;
MD_ENTRY[3] = "D_VOC";
WRITE(MD_ENTRY, COMMON.FILES[FL_MD], "CLARITY.TILL");
if (!(OPEN("CLARITY.TILL", out CLARITY_TILL))) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
//************************************
//  Main Processing Section          *
//************************************
//CRT @(0,0):'HERE FL.CLARITY.TILL':;INPUT FLEX,1:
// BEGIN CASE
// CASE
if (READ_TYPE == "FlexStart") {
FILENAME = "FlexStart_" + TILL_NUMBER;
REC_TYPE = "";
do {
if (REC_TYPE == 01) break;
if (!READ(ref CLARITY_REC, CLARITY_TILL, FILENAME)) { CLARITY_REC = ""; }
REC_TYPE = CLARITY_REC.Substring(1, 2);
if (REC_TYPE != "01") {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
CLARITY_TRANSNO = CLARITY_REC.Substring(3, 10);
} while (true);
INTERFACE_ID = TIME() + "*" + DATE() + "*" + FILENAME;
WRITE(CLARITY_REC, INTERFACE_LOG, INTERFACE_ID);
DELETE(CLARITY_TILL, FILENAME);
}// CASE
else if (READ_TYPE == "ClarityResponse") {
FILENAME = "ClarityResponse_" + TILL_NUMBER;
RESPONSE = "";
do {
if (RESPONSE != "") break;
if (!READ(ref RESPONSE, CLARITY_TILL, FILENAME)) { RESPONSE = ""; }
if (RESPONSE.Substring(1, 2) != "98" && RESPONSE.Substring(1, 2) != "99") { RESPONSE = ""; }
RQM();
CRTCR(AT(20, 23) + "Waiting for ePos response");
} while (true);
CRT(AT(20, 23) + COMMON.EOL);
CLARITY_TRANSNO = RESPONSE.Substring(3, 10);
if (RESPONSE.Substring(1, 2) == "98") { INTERACT = COMMON.ABANDON; }
INTERFACE_ID = TIME() + "*" + DATE() + "*" + FILENAME;
WRITE(RESPONSE, INTERFACE_LOG, INTERFACE_ID);
DELETE(CLARITY_TILL, FILENAME);
//*!!** NOT SURE WE WANT TO DO THIS IF ADDING        DELETE CLARITY.TILL,"FlexResponse_":TILL.NUMBER
}
// END CASE
return;
}
}
}
