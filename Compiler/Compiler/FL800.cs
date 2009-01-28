//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL800 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar BOOKING_KEY = "";
UvVar PRINT_TYPE = "";
UvVar MACHINE_TYPE = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar SSTATEMENT = "";
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
public FL800(ref UvVar BOOKING_KEY, ref UvVar PRINT_TYPE) {
this.BOOKING_KEY = BOOKING_KEY;
this.PRINT_TYPE = PRINT_TYPE;
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
/*  Print Block Booking Payments */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
PROGRAM = "FL800";
if (BOOKING_KEY == "ALL") {
SSTATEMENT = "SORT FL.BLOCK.PAY BY KEY1 BY KEY BREAK-ON KEY 1 TOTAL 2 TOTAL 3 TOTAL 4 7 TOTAL 8 ID-SUPP";
} else {
SSTATEMENT = "SORT FL.BLOCK.PAY WITH KEY = \"" + BOOKING_KEY + "\" KEY 1 TOTAL 2 TOTAL 3 TOTAL 4 7 TOTAL 8 ID-SUPP";
}
if (PRINT_TYPE == "P") {
SSTATEMENT = SSTATEMENT + " LPTR";
/* * Routine to set printer parameters  (condensed print) */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "ENGLISH";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
if (PRINT_START_COMMAND != "") {
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PRINTER_OFF();
PRINTER_CLOSE();
}
}
/*  PRINT */
/*      EXECUTE SSTATEMENT */
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
return;
}
}
}
