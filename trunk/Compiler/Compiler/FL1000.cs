//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL1000 : UvBase
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
UvVar MACHINE_TYPE = "";
UvVar EXECUTE_PROG = "";
UvVar GET_TICKETS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar ERRORS = "";
UvVar ACTIVE = "";
UvVar FLEX = "";
UvVar TICK = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL1000() {
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
/*  EXECUTE TEST */
MACHINE_TYPE = "FUJITSU";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
GET_TICKETS = "SELECT FL.TICKETS";
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref GET_TICKETS, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
ERRORS = SYSTEM(17);
ACTIVE = SYSTEM(11);
COMMON.EOL = FALSE;
PRINT(COMMON.WASH);
PRINTCR("ERRORS" + ERRORS + "@");
PRINT("ACTIVE" + ACTIVE + "@@");
INPUTCR(out FLEX, 1);
do {
if (!READNEXT(ref TICK, 0, 0, RTN_LIST)) { COMMON.EOL = TRUE; }
if (COMMON.EOL) break;
PRINTCR(TICK);
} while (true);
INPUTCR(out FLEX, 1);
return;
}
}
}
