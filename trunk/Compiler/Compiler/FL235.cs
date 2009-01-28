//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL235 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar PRINTER_START = 1;
readonly UvVar PRINTER_END = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] PRINT_CONTROL_REC = new UvVar[5];
#endregion
#region Variables
UvVar TYPE = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
UvVar PORT_NUMBER = "";
UvVar PROGRAM = "";
UvVar FL_PRINTER_CONTROL = "";
UvVar PRINT_CONTROL_ID1 = "";
UvVar PRINT_CONTROL_ID2 = "";
UvVar PRINT_COMMAND = "";
UvVar PRINT_CONTROL = "";
UvVar POS = "";
#endregion
public FL235(ref UvVar TYPE, ref UvVar PRINT_START_COMMAND, ref UvVar PRINT_END_COMMAND, ref UvVar PRINT_COMMANDS) {
this.TYPE = TYPE;
this.PRINT_START_COMMAND = PRINT_START_COMMAND;
this.PRINT_END_COMMAND = PRINT_END_COMMAND;
this.PRINT_COMMANDS = PRINT_COMMANDS;
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
/*  Routine to set printer params  -  (Condensed print) */
PROGRAM = "FL235";
#region INCLUDE FL.FILES FL.PRINTER.CONTROL
if (!OPEN("FL.PRINTER.CONTROL", out FL_PRINTER_CONTROL)) { STOP("201", "FL.PRINTER.CONTROL"); }

#endregion
/* * Routine will only action if set for actual port or set for ALL ports */
/* * Will expect to set a start command (Condensed) and an end command. */
/* * PRINT.COMMANDS HAS BEEN SETUP FOR FUTURE SPECIALS */
// BEGIN CASE
// CASE
if (TYPE == "STANDARD") {
PRINT_CONTROL_ID1 = "PRINTER.STANDARD.PORT" + PORT_NUMBER;
PRINT_CONTROL_ID2 = "PRINTER.STANDARD.ALL";
L0100();
}// CASE
else if (TYPE == "ENGLISH") {
PRINT_CONTROL_ID1 = "PRINTER.ENGLISH.PORT" + PORT_NUMBER;
PRINT_CONTROL_ID2 = "PRINTER.ENGLISH.ALL";
L0100();
}// CASE
else if (TYPE == "USER.REPORTS") {
PRINT_CONTROL_ID1 = "PRINTER.USER.PORT" + PORT_NUMBER;
PRINT_CONTROL_ID2 = "PRINTER.USER.ALL";
L0100();
}// CASE
else if (TYPE == "COURSES.LANDSCAPE") {
PRINT_CONTROL_ID1 = "PRINTER.COURSES.LANDSCAPE.PORT" + PORT_NUMBER;
PRINT_CONTROL_ID2 = "PRINTER.COURSES.LANDSCAPE.ALL";
L0100();
}// CASE
else if (TYPE == "COURSES.PORTRAIT") {
PRINT_CONTROL_ID1 = "PRINTER.COURSES.PORTRAIT.PORT" + PORT_NUMBER;
PRINT_CONTROL_ID2 = "PRINTER.COURSES.PORTRAIT.ALL";
L0100();
}// CASE
else if (OTHERWISE) {
}
// END CASE
return;
}
void L0100() {
if (!(MATREAD(ref PRINT_CONTROL_REC, FL_PRINTER_CONTROL, PRINT_CONTROL_ID1))) {
if (!(MATREAD(ref PRINT_CONTROL_REC, FL_PRINTER_CONTROL, PRINT_CONTROL_ID2))) {
MAT(ref PRINT_CONTROL_REC, "");
}
}
if (PRINT_CONTROL_REC[PRINTER_START] != "") {
PRINT_COMMAND = PRINT_CONTROL_REC[PRINTER_START];
L0200();
PRINT_START_COMMAND = PRINT_CONTROL;
}
if (PRINT_CONTROL_REC[PRINTER_END] != "") {
PRINT_COMMAND = PRINT_CONTROL_REC[PRINTER_END];
L0200();
PRINT_END_COMMAND = PRINT_CONTROL;
}
return;
/* **************************************** */
}
void L0200() {
/*  Routine to set Control Command   * */
/* **************************************** */
PRINT_CONTROL = "";
POS = 1;
do {
if (PRINT_COMMAND[1, POS] == "") break;
PRINT_CONTROL = PRINT_CONTROL + CHAR(PRINT_COMMAND[1, POS]);
POS = POS + 1;
} while (true);
return;
/* ******************** */
/*  END                * */
/* ********************* */
}
}
}
