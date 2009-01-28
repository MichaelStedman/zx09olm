//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL100_AH1 : UvBase
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
UvVar PROGRAM = "";
UvVar PROCNAME = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar WAIT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL100_AH1() {
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
/*  EXECUTES PROC */
/* EXEC.FIX 05.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL100.AH1";
PROCNAME = "AH1";
/*      PRINT @(0,0):EOL: */
/*      PRINT @(0,0):"(":PROGRAM:")" */
/*      PRINT @(64,0):OCONV(TODAYS.DATE,"D"): */
/*      EXECUTE PROCNAME */
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref PROCNAME, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
PRINT();
PRINT("Report Finished, Press <RETURN> ");
INPUT(out WAIT, 1);
return;
}
}
}
