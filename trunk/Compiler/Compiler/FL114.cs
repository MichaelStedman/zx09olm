//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL114 : UvBase
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
UvVar TICKET_TYPE = "";
UvVar TICKET_REC = "";
UvVar TICKET_CODE = "";
UvVar LINE_TOTAL = "";
UvVar TICKET_TOTAL = "";
UvVar POD_MESSAGE = "";
UvVar PORT_NUMBER = "";
UvVar SLAVE_ON = "";
UvVar SLAVE_OFF = "";
UvVar TICKET_POD = "";
UvVar LINE_TOT = "";
UvVar RUN_TOT = "";
UvVar SELECT_PRINTER = "";
UvVar SELECT_POD = "";
#endregion
public FL114(ref UvVar TICKET_TYPE, ref UvVar TICKET_REC, ref UvVar TICKET_CODE, ref UvVar LINE_TOTAL, ref UvVar TICKET_TOTAL, ref UvVar POD_MESSAGE) {
this.TICKET_TYPE = TICKET_TYPE;
this.TICKET_REC = TICKET_REC;
this.TICKET_CODE = TICKET_CODE;
this.LINE_TOTAL = LINE_TOTAL;
this.TICKET_TOTAL = TICKET_TOTAL;
this.POD_MESSAGE = POD_MESSAGE;
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
#region INCLUDE FL.FILES FL.TILL.NUMBERS
#region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

#endregion

#region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

#endregion

#endregion
if (!READV(ref TICKET_POD, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER, 12)) { TICKET_POD = "N"; }
if (TICKET_POD == "N") {
return;
}
if (TICKET_TYPE == "REFUNDS") {
LINE_TOT = 0 - LINE_TOTAL;
RUN_TOT = 0 - TICKET_TOTAL;
} else {
LINE_TOT = LINE_TOTAL;
RUN_TOT = TICKET_TOTAL;
}
SELECT_PRINTER = CHAR(27) + CHAR(61) + CHAR(1);
SELECT_POD = CHAR(27) + CHAR(61) + CHAR(2);
PRINT(SLAVE_ON);
PRINT(SELECT_POD);
// BEGIN CASE
// CASE
if (TICKET_TYPE == "COURSES") {
PRINT(FORMAT(TICKET_REC, "L#13") + FORMAT(OCONV(LINE_TOT, "MD2"), "R#6") + " ");
PRINT(FORMAT(POD_MESSAGE, "L#13") + FORMAT(OCONV(RUN_TOT, "MD2"), "R#6") + " ");
}// CASE
else if (TICKET_TYPE == "POD.MESSAGE") {
PRINT(POD_MESSAGE);
}// CASE
else if (OTHERWISE) {
PRINT(FORMAT(TICKET_REC, "L#13") + FORMAT(OCONV(LINE_TOT, "MD2"), "R#6") + " ");
PRINT(SPACE(4) + "Total Due" + FORMAT(OCONV(RUN_TOT, "MD2"), "R#6") + " ");
}
// END CASE
PRINT(SELECT_PRINTER);
PRINT(SLAVE_OFF);
return;
}
}
}
