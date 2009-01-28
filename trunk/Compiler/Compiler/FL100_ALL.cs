//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL100_ALL : UvBase
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
readonly UvVar FL_AD_HOC_ENQUIRIES = 101;
readonly UvVar FL_REPORTS = 71;
readonly UvVar REPORT_VERB = 1;
readonly UvVar REPORT_FILE = 2;
readonly UvVar REPORT_SELECT_1 = 3;
readonly UvVar REPORT_SELECT_2 = 4;
readonly UvVar REPORT_SELECT_3 = 5;
readonly UvVar REPORT_SELECT_4 = 6;
readonly UvVar REPORT_SELECT_5 = 7;
readonly UvVar REPORT_SORT = 8;
readonly UvVar REPORT_ASC_DSC = 9;
readonly UvVar REPORT_SHOW = 10;
readonly UvVar REPORT_BREAK = 11;
readonly UvVar REPORT_TOTAL = 12;
readonly UvVar REPORT_ID = 13;
readonly UvVar REPORT_PRINT = 14;
readonly UvVar REPORT_DETAIL = 15;
readonly UvVar REPORT_STATEMENT = 20;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar MD = 58;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] REPORTS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
#endregion
#region Variables
UvVar PROC_LOCATION = "";
UvVar MACHINE_TYPE = "";
UvVar TRANS_LOG_REC = "";
UvVar PROC = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
FL006 FL006;
UvVar FILE_LOCATION = "";
UvVar PROC_FILE = "";
UvVar ENQREC = "";
UvVar MD_ID = "";
UvVar OK_TO_FILE = "";
UvVar ALREADY_EXISTS = "";
UvVar PROC_REC = "";
FLTX2 FLTX2;
//FL000_10 FL000_10;
UvVar ID = "";
UvVar PRINTER_REQ = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
//FL235 FL235;
UvVar PROC_ID = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar WAIT = "";
UvVar RGEN_HEADER = "";
UvVar HEADER_REQUIRED = "";
UvVar HDR_STRING = "";
UvVar SHEADER = "";
UvVar HLINE = "";
UvVar HDONE = "";
UvVar PLINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL100_ALL(ref UvVar PROC_LOCATION) {
this.PROC_LOCATION = PROC_LOCATION;
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion
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
//    EXECUTES SUPPLIED PROC
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL100.ALL";
SCREEN_CODE = PROGRAM;
#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.AD.HOC.ENQUIRIES

#endregion
#region INCLUDE FL.FILES FL.REPORTS

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
PROC = FIELD(PROC_LOCATION, " ", 2);
if (PROC == "") {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
FILE_LOCATION = FIELD(PROC_LOCATION, " ", 1);
if (!(OPEN(FILE_LOCATION, out PROC_FILE))) {
STOP(201, FILE_LOCATION);
}
if (!(READ(ref ENQREC, PROC_FILE, PROC))) {
STOP(202, PROC);
}
// create the md entry
MD_ID = COMMON.CENTRE + "." + TRIM(PROC) + ".FL100";
OK_TO_FILE = FALSE;
if (!(READ(ref ALREADY_EXISTS, COMMON.FILES[MD], MD_ID))) {
OK_TO_FILE = TRUE;
}
if (OK_TO_FILE) {
PROC_REC = "";
PROC_REC[1] = "PQ";
PROC_REC[2] = "(FL.AD.HOC.ENQUIRIES " + PROC + ".FL100)";
TRANS_LOG_REC = PROC_REC;
nrf0 = "W";
nrf1 = "MD";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MD_ID);
WRITE(PROC_REC, COMMON.FILES[MD], MD_ID);
}
nrf0 = 0;
//FL000_10 = new FL000_10(ref SCREEN_CODE, ref nrf0);
PRINT(AT(10, 10) + "Executing Proc : " + PROC);
ID = TRIM(PROC);
if (!READV(ref PRINTER_REQ, COMMON.FILES[FL_REPORTS], ID, 14)) { PRINTER_REQ = ""; }
if (PRINTER_REQ == "Y" || PRINTER_REQ == "y") {
// Routine to set printer parameters  (condensed print)
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "USER.REPORTS";
//FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
if (PRINT_START_COMMAND != "") {
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
}
}
L0100();
PROC_ID = MD_ID.Substring(4, 99);
WRITE(ENQREC, COMMON.FILES[FL_AD_HOC_ENQUIRIES], PROC_ID);
nrf0 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref MD_ID, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (PRINTER_REQ == "Y" || PRINTER_REQ == "y") {
PRINTER_OFF();
PRINTER_CLOSE();
}
PRINT();
PRINT("Proc Finished, Press <RETURN> ");
INPUT(out WAIT, 1);
return;
}
void L0100() {
if (NOT(INDEX(ENQREC, "HEADING", 1))) {
if (READV(ref RGEN_HEADER, COMMON.FILES[FL_CONTROL], "RGEN.HEADER", 1)) {
HEADER_REQUIRED = TRUE;
// BEGIN CASE
if (RGEN_HEADER == "NONE") {
HDR_STRING = "H TCL-SUPP HEADING \"";
} else if (RGEN_HEADER == "CENTRE") {
if (!(MATREAD(ref CENTRES_REC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE))) {
MAT(ref CENTRES_REC, "");
}
HDR_STRING = "H HEADING \"" + COMMON.CENTRE + " - " + CENTRES_REC[CENTRE_NAME];
} else if (RGEN_HEADER == "SCREEN") {
HDR_STRING = "H HEADING \"" + SHEADER;
} else if (RGEN_HEADER == "CENTRESCREEN") {
if (!(MATREAD(ref CENTRES_REC, COMMON.FILES[FL_CENTRES], COMMON.CENTRE))) {
MAT(ref CENTRES_REC, "");
}
SHEADER = FIELD(TRIM(ENQREC[4]), " ", 3);
HDR_STRING = "H HEADING \"" + COMMON.CENTRE + " - " + CENTRES_REC[CENTRE_NAME] + " (" + SHEADER + ")";
} else if (OTHERWISE) {
HEADER_REQUIRED = FALSE;
}
if (HEADER_REQUIRED) {
HLINE = HDR_STRING + "'G'" + "'T' Page 'PL'" + "\"";
L0200();
}
}
}
return;
}
void L0200() {
HDONE = FALSE;
PLINE = 1;
do {
if (ENQREC[PLINE] == "" || HDONE) break;
if (INDEX(ENQREC[PLINE], "# P GO 20", 1)) {
HDONE = TRUE;
ENQREC = INSERT(ENQREC, PLINE, 0, 0, HLINE);
}
PLINE = PLINE + 1;
} while (true);
return;
}
}
}
