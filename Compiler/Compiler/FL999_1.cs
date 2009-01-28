//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL999_1 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TILL_REC = new UvVar[25];
UvVar[] LINES = new UvVar[10];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar CHANNEL = "";
UvVar I = "";
UvVar UNIQUE_PORT = "";
UvVar PORT_REC = "";
#endregion
public FL999_1() {
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
/*  RECORDS LOGOFF DETAILS FOR NETWORKS WHERE PORT NUMBER NOT FIXED (LONGLEAT) */
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
CHANNEL = "";
I = 1;
/* **MIG*** */
if (!(READ(ref UNIQUE_PORT, COMMON.FILES[FL_CONTROL], "UNIQUE.PORT"))) {
UNIQUE_PORT = "";
}
if (UNIQUE_PORT != "NOVELL/TERMITE") {
return;
}
if (PORT_REC[4] == "" && PORT_REC[2] != CHANNEL) {
PORT_REC[4] = TIMEDATE();
WRITE(PORT_REC, COMMON.FILES[FL_TILL_NUMBERS], LINES[I]);
EXECUTE("OFF", string.Empty, string.Empty, string.Empty, string.Empty);
}
PORT_NUMBER = PORT_REC[1];
PORT_REC[2] = CHANNEL;
PORT_REC[3] = TIMEDATE();
PORT_REC[4] = "";
WRITE(PORT_REC, COMMON.FILES[FL_TILL_NUMBERS], LINES[I]);
return;
}
}
}
