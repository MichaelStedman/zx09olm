//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_15_STD : UvBase
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
readonly UvVar UNPRINTED_TICKETS = 35;
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
UvVar TICKET_KEY = "";
UvVar TICKET_REC = "";
UvVar HEADKEY = "";
UvVar FOOTKEY = "";
UvVar THROW_BEFORE = "";
UvVar THROW_AFTER = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar SLAVE_ON = "";
UvVar SLAVE_OFF = "";
UvVar SLAVE_DBL_WID_ON = "";
UvVar SLAVE_DBL_WID_OFF = "";
UvVar SLAVE_RED_ON = "";
UvVar SLAVE_RED_OFF = "";
UvVar LINE_FEED = "";
UvVar AM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar EXECUTE_PROG = "";
UvVar SPOOLER_STAR_START = "";
UvVar SPOOLER_STAR_IGNORE = "";
FL006 FL006;
UvVar ESC = "";
UvVar NORMAL = "";
UvVar BOTTOM_LINE = "";
UvVar BLANK_ON = "";
UvVar BLANK_OFF = "";
UvVar CUT_MARK = "";
UvVar PRINTER_TYPE = "";
UvVar RESET_SCREEN = "";
UvVar RTN_LIST = "";
UvVar AVAILABLE = "";
UvVar MESSAGE = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar TJ = "";
UvVar RJ = "";
UvVar LINE = "";
UvVar TICKET_LINE = "";
UvVar LINE1 = "";
UvVar LINE2 = "";
UvVar REM = "";
UvVar HEADFOOT = "";
UvVar CUT_AFTER = "";
UvVar CUT = "";
UvVar TMT80_BIG = "";
UvVar XX = "";
FLTX2 FLTX2;
FL099 FL099;
UvVar TICKET_HEAD = "";
UvVar HEADNO = "";
UvVar SECONDQUOTE = "";
UvVar INTERACT = "";
UvVar TEXT = "";
UvVar UPTO = "";
UvVar PRNT_TYPE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL000_15_STD(ref UvVar TICKET_KEY, ref UvVar TICKET_REC, ref UvVar HEADKEY, ref UvVar FOOTKEY, ref UvVar THROW_BEFORE, ref UvVar THROW_AFTER) {
this.TICKET_KEY = TICKET_KEY;
this.TICKET_REC = TICKET_REC;
this.HEADKEY = HEADKEY;
this.FOOTKEY = FOOTKEY;
this.THROW_BEFORE = THROW_BEFORE;
this.THROW_AFTER = THROW_AFTER;
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
/*  PRINT DIFF TICKETS */
PROGRAM = "FL000.15.STD";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Equate the files to be used * */
#region INCLUDE FL.FILES FL.TILL.NUMBERS
#region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

#endregion

#region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

#endregion

#endregion
SPOOLER_STAR_START = "";
SPOOLER_STAR_IGNORE = "";
/*     PRINTER CONTROL STATEMENTS    * */
if (!(MATREAD(ref TILL_REC, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
ESC = CHAR(27);
NORMAL = "";
if (TILL_REC[TILL_TRANS_TICK_PRINT] == "Y") {
BOTTOM_LINE = AT(0, 22);
BLANK_ON = ESC + "G3";
BLANK_OFF = ESC + "G ";
LINE_FEED = "";
} else {
BOTTOM_LINE = AT(0, 23);
BLANK_ON = "";
BLANK_OFF = "";
}
CUT_MARK = "";
PRINTER_TYPE = TILL_REC[TILL_TICKET_PRINTER_TYPE];
RESET_SCREEN = INIT;
if (PRINTER_TYPE == "NONE" || PRINTER_TYPE == "SYSTEM") {
/*        WRITE TICKET.REC ON UNPRINTED.TICKETS , TICKET.KEY */
return;
}
if (TILL_REC[TILL_TICKET_PRINTER_QUE] != "" && TILL_REC[TILL_TICKET_PRINTER_QUE] != "NONE") {
nrf0 = TILL_REC[TILL_TICKET_PRINTER_QUE];
nrf1 = "";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref nrf0, ref nrf1, ref RTN_LIST, ref AVAILABLE, ref MESSAGE, ref OTHERS);
PRINTER_ON();
SLAVE_ON = "";
SLAVE_OFF = "";
BOTTOM_LINE = "";
if (PRINTER_TYPE == "STAR") {
SPOOLER_STAR_START = CHAR(17);
SPOOLER_STAR_IGNORE = CHAR(19);
}
}
/*  print text depending on which type of printer */
// BEGIN CASE
// CASE
if (PRINTER_TYPE == "GAZ" || PRINTER_TYPE == "GAZBAR") {
NORMAL = ESC + "M0101";
TJ = "L#26";
RJ = "R#26";
do {
if (THROW_BEFORE < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(FORMAT(" ", TJ) + LINE_FEED);
PRINT(SLAVE_OFF);
THROW_BEFORE = THROW_BEFORE - 1;
} while (true);
LINE = 1;
do {
if (TICKET_REC[LINE] == "") break;
/*  split the line into two */
TICKET_LINE = TICKET_REC[LINE, 1];
LINE1 = TICKET_LINE.Substring(1, 26);
LINE2 = TICKET_LINE.Substring(27, LEN(TICKET_LINE) - 26);
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(FORMAT(LINE1, TJ) + LINE_FEED);
/* PRINT TICKET.REC<LINE,2>:TICKET.LINE:LINE.FEED */
PRINT(SLAVE_OFF);
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(FORMAT(LINE2, RJ) + LINE_FEED);
PRINT(SLAVE_OFF);
LINE = LINE + 1;
if (REM[LINE, 15] == 0) {
RQM();
}
} while (true);
if (FOOTKEY != "") {
HEADFOOT = FOOTKEY;
L20();
/*  FOOTER */
}
do {
if (THROW_AFTER < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(FORMAT(" ", TJ) + LINE_FEED);
PRINT(SLAVE_OFF);
THROW_AFTER = THROW_AFTER - 1;
} while (true);
/*  cut the ticket */
// BEGIN CASE
// CASE
if (PRINTER_TYPE == "GAZ") {
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(CHAR(27) + "d" + LINE_FEED);
PRINTCR(LINE_FEED);
PRINTCR(LINE_FEED);
PRINTCR(LINE_FEED);
PRINTCR(CHAR(27) + "C" + LINE_FEED);
PRINT(SLAVE_OFF);
for(CUT_AFTER = 1; CUT_AFTER <= 12; CUT_AFTER += 1) {
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(LINE_FEED);
PRINT(SLAVE_OFF);
}
}// CASE
else if (PRINTER_TYPE == "GAZBAR") {
/*  CUT BAR PRINTER GAZELLE */
CUT = CHAR(27) + "C";
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
/*          PRINT CHAR(14) : */
PRINT();
PRINT(" ");
PRINT(CUT);
for(COMMON.X = 1; COMMON.X <= 4; COMMON.X += 1) {
PRINTCR(" ");
}
PRINT(SLAVE_OFF);
}
// END CASE
HEADFOOT = HEADKEY;
L20();
/*  HEADER */
}// CASE
else if (PRINTER_TYPE == "TICKET") {
do {
if (THROW_BEFORE < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(" " + LINE_FEED);
PRINT(SLAVE_OFF);
THROW_BEFORE = THROW_BEFORE - 1;
} while (true);
HEADFOOT = HEADKEY;
L10();
/*  HEADER */
LINE = 1;
do {
if (TICKET_REC[LINE] == "") break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(TICKET_REC[LINE, 2] + TICKET_REC[LINE, 1] + LINE_FEED);
PRINT(SLAVE_OFF);
LINE = LINE + 1;
} while (true);
if (FOOTKEY != "") {
HEADFOOT = FOOTKEY;
L10();
/*  FOOTER */
}
do {
if (THROW_AFTER < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(" " + LINE_FEED);
PRINT(SLAVE_OFF);
THROW_AFTER = THROW_AFTER - 1;
} while (true);
}// CASE
else if (PRINTER_TYPE == "STAR" || PRINTER_TYPE == "DL3300") {
/* @!        LOOP */
/* @!           UNTIL THROW.BEFORE < 1 DO */
/* @!           PRINT @(2,23):SLAVE.ON: */
/* @!           PRINT ' ':LINE.FEED */
/* @!           PRINT SLAVE.OFF: */
/* @!           THROW.BEFORE = THROW.BEFORE - 1 */
/* @!        REPEAT */
/* @!        HEADFOOT = HEADKEY */
/* @!        GOSUB 10 ; * HEADER */
LINE = 1;
do {
if (TICKET_REC[LINE] == "") break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINT(SPOOLER_STAR_IGNORE);
PRINTCR(SPOOLER_STAR_START + TICKET_REC[LINE, 2] + TICKET_REC[LINE, 1] + LINE_FEED);
PRINT(SPOOLER_STAR_IGNORE);
PRINT(SLAVE_OFF);
LINE = LINE + 1;
} while (true);
if (FOOTKEY != "") {
HEADFOOT = FOOTKEY;
L10();
/*  FOOTER */
}
do {
if (THROW_AFTER < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(SPOOLER_STAR_START + " " + LINE_FEED);
PRINT(SPOOLER_STAR_IGNORE);
PRINT(SLAVE_OFF);
THROW_AFTER = THROW_AFTER - 1;
} while (true);
HEADFOOT = HEADKEY;
L10();
/*  HEADER */
}// CASE
else if (PRINTER_TYPE == "TMT80" || PRINTER_TYPE == "TMT80G" || PRINTER_TYPE == "TMU925" || PRINTER_TYPE == "TMT80W") {
/*  Next bit added to stop large print on a dot matrix TMT80 @ Rivermead */
if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "TMT80W") {
/* !**!!PRINT CHAR(28):"46,W,TMT80":CHAR(20): */
}
if (PRINTER_TYPE != "TMT80") {
NORMAL = ESC + CHAR(33) + CHAR(64);
} else {
NORMAL = "";
}
TMT80_BIG = ESC + CHAR(33) + CHAR(16);
CUT_MARK = " " + AM + " " + AM + " " + " " + AM + " " + AM + " " + AM + ESC + "i";
TJ = "L#26";
RJ = "R#26";
LINE = 1;
do {
if (TICKET_REC[LINE] == "") break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(TICKET_REC[LINE, 2] + TICKET_REC[LINE, 1]);
PRINT(SLAVE_OFF);
LINE = LINE + 1;
} while (true);
if (FOOTKEY != "") {
HEADFOOT = FOOTKEY;
L20();
/*  FOOTER */
}
do {
if (THROW_AFTER < 1) break;
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(" ");
PRINT(SLAVE_OFF);
THROW_AFTER = THROW_AFTER - 1;
} while (true);
RQM();
/* **** DO NOT KWOW WHY BUT THE FOLLOWING SEEMS TO BE REQUIRED TO CUT *** */
PRINT(SLAVE_ON);
PRINTCR(SLAVE_ON);
PRINTCR(" ");
PRINTCR(" ");
PRINTCR(" ");
PRINTCR(" ");
/* PRINT CUT.MARK */
PRINTCR(CHAR(27) + "i");
PRINT(SLAVE_OFF);
HEADFOOT = HEADKEY;
L20();
/*  HEADER */
if (PRINTER_TYPE != "TMT80" && PRINTER_TYPE != "TMT80G") {
for(XX = 1; XX <= 4; XX += 1) {
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINT();
PRINT(SLAVE_OFF);
}
}
/*      CASE PRINTER.TYPE = 'DL3300' */
}// CASE
else if (PRINTER_TYPE == "AB710") {
}// CASE
else if (OTHERWISE) {
/*  catch all */
WRITE(TICKET_REC, COMMON.FILES[UNPRINTED_TICKETS], TICKET_KEY);
TRANS_LOG_REC = TICKET_REC;
nrf0 = "W";nrf1 = "FL.UNPRINTED.TICKETS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TICKET_KEY);
}
// END CASE
PRINT(BOTTOM_LINE);
PRINT(SPACE(70));
PRINT(BOTTOM_LINE + BLANK_OFF);
if (TILL_REC[TILL_TICKET_PRINTER_QUE] != "" && TILL_REC[TILL_TICKET_PRINTER_QUE] != "NONE") {
PRINTER_OFF();
PRINTER_CLOSE();
FL099 = new FL099();
}
/* PRINT NORMAL: */
return;
}
void L10() {
/*  ticket header subroutine - ABLE 510/710 */
if (!(READ(ref TICKET_HEAD, COMMON.FILES[FL_CONTROL], COMMON.CENTRE + "*" + HEADFOOT))) {
if (!(READ(ref TICKET_HEAD, COMMON.FILES[FL_CONTROL], HEADFOOT))) {
TICKET_HEAD = "";
}
}
if (TICKET_HEAD != "") {
HEADNO = 1;
do {
if (TICKET_HEAD[HEADNO] == "") break;
if (TICKET_HEAD[HEADNO].Substring(1, 1) == "'") {
SECONDQUOTE = INDEX(TICKET_HEAD[HEADNO], "'", 2);
INTERACT = TICKET_HEAD[HEADNO].Substring(2, SECONDQUOTE - 2);
TEXT = TICKET_HEAD[HEADNO].Substring(SECONDQUOTE + 1, LEN(TICKET_HEAD[HEADNO]) - SECONDQUOTE);
// BEGIN CASE
// CASE
if (INTERACT == "DW") {
TICKET_HEAD[HEADNO] = SLAVE_DBL_WID_ON + TEXT;
}// CASE
else if (INTERACT == "RO") {
TICKET_HEAD[HEADNO] = SLAVE_RED_ON + TEXT;
}// CASE
else if (INTERACT == "DWRO" || INTERACT == "RODW") {
TICKET_HEAD[HEADNO] = SLAVE_DBL_WID_ON + SLAVE_RED_ON + TEXT;
}// CASE
else if (OTHERWISE) {
}
// END CASE
}
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(SPOOLER_STAR_START + TICKET_HEAD[HEADNO] + LINE_FEED);
PRINT(SPOOLER_STAR_IGNORE);
PRINT(SLAVE_OFF);
HEADNO = HEADNO + 1;
} while (true);
}
return;
}
void L20() {
/*  ticket header subroutine - ABLE GAZELLE */
if (!(READ(ref TICKET_HEAD, COMMON.FILES[FL_CONTROL], COMMON.CENTRE + "*" + HEADFOOT))) {
if (!(READ(ref TICKET_HEAD, COMMON.FILES[FL_CONTROL], HEADFOOT))) {
TICKET_HEAD = "";
}
}
if (TICKET_HEAD != "") {
HEADNO = 1;
do {
if (TICKET_HEAD[HEADNO] == "") break;
if (TICKET_HEAD[HEADNO].Substring(1, 1) == "'") {
SECONDQUOTE = INDEX(TICKET_HEAD[HEADNO], "'", 2);
INTERACT = TICKET_HEAD[HEADNO].Substring(2, SECONDQUOTE - 2);
TEXT = TICKET_HEAD[HEADNO].Substring(SECONDQUOTE + 1, LEN(TICKET_HEAD[HEADNO]) - SECONDQUOTE);
// BEGIN CASE
// CASE
if (INTERACT == "DW") {
TICKET_HEAD[HEADNO] = SLAVE_DBL_WID_ON + TEXT + SLAVE_DBL_WID_OFF;
}// CASE
else if (INTERACT == "RO") {
TICKET_HEAD[HEADNO] = SLAVE_RED_ON + TEXT + SLAVE_RED_OFF;
}// CASE
else if (INTERACT == "DWRO" || INTERACT == "RODW") {
TICKET_HEAD[HEADNO] = SLAVE_DBL_WID_ON + SLAVE_RED_ON + TEXT + SLAVE_RED_OFF + SLAVE_DBL_WID_OFF;
}// CASE
else if (OTHERWISE) {
}
// END CASE
}
if (TICKET_HEAD[HEADNO].Substring(1, 1) == "\"") {
UPTO = INDEX(TICKET_HEAD[HEADNO], "\"", 2);
PRNT_TYPE = TICKET_HEAD[HEADNO].Substring(2, UPTO - 2);
PRINT(SLAVE_ON);
if (TILL_REC[TILL_TICKET_PRINTER_TYPE] == "TMT80G") {
PRINT(TMT80_BIG);
} else {
PRINTCR(ESC + PRNT_TYPE);
}
PRINT(SLAVE_OFF);
TICKET_HEAD[HEADNO] = TICKET_HEAD[HEADNO].Substring(UPTO + 1, 999);
}
PRINT(BOTTOM_LINE + BLANK_ON);
PRINT(SLAVE_ON);
PRINTCR(FORMAT(TICKET_HEAD[HEADNO], TJ));
PRINTCR(NORMAL);
PRINT(SLAVE_OFF);
HEADNO = HEADNO + 1;
} while (true);
}
return;
}
}
}
