//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL890 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_TILL_CONTROL = 91;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar THIS_TILL = "";
UvVar THIS_SESSION = "";
UvVar MOP_ARRAY = "";
UvVar TRANSACTIONS = "";
UvVar MACHINE_TYPE = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar ENGLISH = "";
UvVar HEADING_STRING = "";
UvVar ENDING = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL890(ref UvVar THIS_TILL, ref UvVar THIS_SESSION, ref UvVar MOP_ARRAY, ref UvVar TRANSACTIONS) {
this.THIS_TILL = THIS_TILL;
this.THIS_SESSION = THIS_SESSION;
this.MOP_ARRAY = MOP_ARRAY;
this.TRANSACTIONS = TRANSACTIONS;
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
/*  Report for web bookings */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  files used */
/*  constants */
PROGRAM = "FL890";
SCREEN_CODE = PROGRAM;
if (THIS_TILL != "99") {
return;
}
ENGLISH = "SORT FL.RECONCILED.TICKETS WITH 16 = \"" + THIS_SESSION + "\" AND WITH TILL = \"" + THIS_TILL + "\" BY CENTRE";
HEADING_STRING = "HEADING \"Web Takings for Session " + THIS_SESSION;
ENDING = "           'DLL'";
HEADING_STRING = HEADING_STRING + ENDING + "\"";
ENGLISH = ENGLISH + " BREAK-ON CENTRE TOTAL 7 TOTAL CNT ID-SUPP " + HEADING_STRING;
ENGLISH = ENGLISH + " LPTR";
/* * Routine to set printer parameters  (condensed print) */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "ENGLISH";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
if (PRINT_START_COMMAND != "") {
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PRINTER_CLOSE();
PRINTER_OFF();
}
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref ENGLISH, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
return;
}
}
}
