//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL900 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
FL901 FL901;
UvVar DP = "";
FL306 FL306;
UvVar ANS = "";
UvVar CONTROL_REC = "";
FL006 FL006;
UvVar THISDATE = "";
UvVar THISTIME = "";
UvVar COMOKEY = "";
UvVar START_POS = "";
UvVar STARTDATE = "";
UvVar RUNDAY = "";
UvVar WAKE = "";
UvVar ROUTINE = "";
CallAt_ROUTINE CallAt_ROUTINE;
UvVar STOP_DATE = "";
UvVar STOP_TIME = "";
FL002 FL002;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL900() {
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
/*  COMMENTS */
PROGRAM = "FL900";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/* * Close all open files so that File Save works */
FL901 = new FL901();
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!OPEN("FL.CONTROL", out COMMON.FILES[FL_CONTROL])) { STOP(); }
if (!OPEN("DP", out DP)) { STOP(); }
PRINT(COMMON.WASH);
FL306 = new FL306();
PRINT(AT(10, 10) + "This routine will run overnight processes at specified time");
PRINT(AT(10, 11) + "When <RETURN> is entered the session should be minimised and");
PRINTCR(AT(10, 12) + "Left to sleep");
PRINT(AT(10, 14) + "<RETURN> to continue ");
INPUTCR(out ANS, 10);
if (ANS != "") { return; }
do {
if (!(READ(ref CONTROL_REC, COMMON.FILES[FL_CONTROL], "AUTO.OVERNIGHT.PROCESSES"))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (CONTROL_REC[1] == COMMON.ABANDON) break;
THISDATE = DATE();
THISTIME = TIME();
COMOKEY = "FL900" + OCONV(THISDATE, "DWA");
EXECUTE("COMO ON ", string.Empty, string.Empty, string.Empty, string.Empty);
START_POS = 2;
do {
if (CONTROL_REC[START_POS, 2] == "") break;
THISDATE = DATE();
THISTIME = TIME();
if (ICONV(CONTROL_REC[START_POS, 1], "MT") < THISTIME) {
STARTDATE = THISDATE + 1;
RUNDAY = " Tomorrow";
} else {
RUNDAY = " Today";
STARTDATE = THISDATE;
}
if (CONTROL_REC[START_POS, 1] != "") {
PRINT(COMMON.WASH);
FL306 = new FL306();
PRINTCR(AT(10, 10) + "Will run " + CONTROL_REC[START_POS, 2] + " at " + CONTROL_REC[START_POS, 1] + RUNDAY);
do {
if (!READV(ref WAKE, DP, "WAKEUP", 1)) { WAKE = FALSE; }
if (WAKE || (TIME() > ICONV(CONTROL_REC[START_POS, 1], "MT") && DATE() >= STARTDATE)) break;
/*               SLEEP CONTROL.REC<START.POS,1> */
CRT(60);
} while (true);
if (WAKE) { STOP("PROCESS AWAKE"); }
ROUTINE = CONTROL_REC[START_POS, 2];
TODAYS_DATE = DATE();
CallAt_ROUTINE = new CallAt_ROUTINE(ref ROUTINE);
}
START_POS = START_POS + 1;
} while (true);
} while (true);
ANS = "";
STOP_DATE = DATE();
EXECUTE("COMO OFF", string.Empty, string.Empty, string.Empty, string.Empty);
STOP_TIME = TIME();
STOP_DATE = OCONV(STOP_DATE, "D2/");
STOP_TIME = OCONV(STOP_TIME, "MTS");
do {
if (ANS == "OK") break;
CRT(AT(20, 10) + "ROUTINE SET TO STOP AT " + STOP_TIME + " on " + STOP_DATE + " Enter OK ");
INPUTCR(out ANS);
} while (true);
FL002 = new FL002();
return;
}
}
}
