//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL102 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TILL_REC = new UvVar[25];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar SLAVE_ON = "";
UvVar SLAVE_OFF = "";
UvVar ESC = "";
UvVar PROGRAM = "";
UvVar OPEN_CASH_DRAWER = "";
UvVar ADDSMODE = "";
UvVar WYSEMODE = "";
UvVar ENHANCE_OFF = "";
UvVar ENHANCE_ON = "";
UvVar ADDS_SLAVE_ON = "";
#endregion
public FL102() {
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
/*  ROUTINE TO OPEN CASH DRAWER CONNECTED DIRECT TO TICKET.PRINTER ON WYSE */
/*  The Wyse has to be set to addsvp mode with enhance off to pass the open */
/*  drawer command through to printer. (in wyse mode sees ESC p as screen */
/*  print) */
PROGRAM = "FL102";
ESC = CHAR(27);
#region INCLUDE FL.FILES FL.TILL.NUMBERS
#region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

#endregion

#region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

#endregion

#endregion
if (!(MATREAD(ref TILL_REC, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER))) {
MAT(ref TILL_REC, "");
}
// BEGIN CASE
// CASE
if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "TMT80G" || TILL_REC[TILL_TICKET_PRINTER_TYPE] == "TMT80W" && TILL_REC[TILL_CASH_DRAWER] != "S") {
/*          OPEN.CASH.DRAWER = ESC:"p":CHAR(0):CHAR(32):CHAR(32) */
OPEN_CASH_DRAWER = ESC + "p" + CHAR(0) + CHAR(11) + CHAR(100);
}// CASE
else if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "TMT80") {
OPEN_CASH_DRAWER = ESC + "p" + CHAR(0) + CHAR(32) + CHAR(32);
}// CASE
else if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "STAR") {
OPEN_CASH_DRAWER = CHAR(28);
}// CASE
else if (OTHERWISE) {
OPEN_CASH_DRAWER = "";
}
// END CASE
// BEGIN CASE
// CASE
if (TILL_REC[TILL_CASH_DRAWER] == "WYSE") {
ESC = CHAR(27);
ADDSMODE = ESC + "~%";
WYSEMODE = ESC + "~@";
ENHANCE_OFF = ESC + "~ ";
ENHANCE_ON = ESC + "~!";
ADDS_SLAVE_ON = CHAR(18);
PRINT(AT(0, 20));
PRINT(ENHANCE_OFF);
PRINT(ADDSMODE);
PRINT(ADDS_SLAVE_ON);
PRINT(OPEN_CASH_DRAWER);
PRINT(SLAVE_OFF);
PRINT(WYSEMODE);
PRINT(ENHANCE_ON);
PRINT(AT(0, 20) + "     ");
}// CASE
else if (TILL_REC[TILL_CASH_DRAWER] == "Y") {
PRINT(SLAVE_ON);
PRINT(OPEN_CASH_DRAWER);
PRINT(SLAVE_OFF);
PRINT(AT(0, 20));
}
// END CASE
return;
}
}
}
