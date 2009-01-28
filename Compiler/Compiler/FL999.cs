//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL999 : UvBase
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
readonly UvVar FL_MONITOR = 54;
readonly UvVar MON_MENU = 1;
readonly UvVar MON_DESC = 2;
readonly UvVar MON_PROG = 3;
readonly UvVar MON_OPT = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] MON_REC = new UvVar[4];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar EXECUTE_PROG = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar UNIQUE_PORT = "";
FL999_1 FL999_1;
UvVar FL_PORTS = "";
UvVar UVPROCESS = "";
UvVar UVLINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL999() {
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
/*  LOGOFF THE TERMINAL */
/*  Last updated : 14:46 23/09/92�* Compiled : 12:40 23/09/92 */
/* EXEC.FIX 05.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MONITOR

#endregion
DELETE(COMMON.FILES[FL_MONITOR], PORT_NUMBER);
/*      EXECUTE "SP-ASSIGN" */
INSTRUCTION = "SP-ASSIGN";
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
/*  FRIG FOR PKHARMONY */
/* PRINT CHAR(27):'Zy': */
if (!READV(ref UNIQUE_PORT, COMMON.FILES[FL_CONTROL], "UNIQUE.PORT", 1)) { UNIQUE_PORT = ""; }
PRINT(COMMON.WASH);
if (PORT_NUMBER > 2 && UNIQUE_PORT == "NOVELLE/TERMITE") {
FL999_1 = new FL999_1();
}
PRINT(CHAR(27) + "_X" + CHAR(27) + "\\");
if (MACHINE_TYPE == "UNIVERSE") {
if (OPEN("FL.PORTS", out FL_PORTS)) {
UVPROCESS = OCONV(0, "U50BB");
UVLINE = FIELD(UVPROCESS, " ", 1);
DELETE(FL_PORTS, UVLINE);
}
}
PRINT(COMMON.WASH);
RQM();
CHAIN("OFF");
return;
}
}
}
