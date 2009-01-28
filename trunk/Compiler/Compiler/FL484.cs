//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL484 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar FL_FINANCE_MASTER = 37;
readonly UvVar FIN_MST_GROSS_AMT = 1;
readonly UvVar FIN_MST_VAT = 2;
readonly UvVar FIN_MST_ADMISSIONS = 3;
readonly UvVar FIN_MST_UNITS = 4;
readonly UvVar FIN_MST_LEDGER_CODE = 5;
readonly UvVar FIN_MST_GROUP_CODE = 6;
readonly UvVar FIN_MST_WEEK = 7;
readonly UvVar FIN_MST_PERIOD = 8;
readonly UvVar FIN_MST_GROUP_CODE_2 = 9;
readonly UvVar FIN_MST_KEY_ELEMENTS = 10;
readonly UvVar FIN_MST_POST_AMT = 11;
readonly UvVar FL_FINANCE_DESCRIPTIONS = 103;
readonly UvVar FIN_DESCRIPTION = 1;
readonly UvVar FIN_DAY_TARGET = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] FIN_MST_REC = new UvVar[11];
UvVar[] FIN_DESC_REC = new UvVar[3];
#endregion
#region Variables
UvVar START_DATE = "";
UvVar END_DATE = "";
UvVar TYPE_REQUIRED = "";
UvVar PRINT_TYPE = "";
UvVar PRINT_FLAG = "";
UvVar MACHINE_TYPE = "";
UvVar PROGRAM = "";
UvVar EXECUTE_PROG = "";
UvVar EOR = "";
UvVar DETAIL = "";
UvVar SUMMARY = "";
UvVar TOTAL_ONLY = "";
UvVar HELD_ACTIVITY = "";
UvVar HELD_LEDGER = "";
UvVar HELD_BREAK1 = "";
UvVar AMOUNT = "";
UvVar VAT = "";
UvVar ADMISSIONS = "";
UvVar UNITS = "";
UvVar LEDGER_AMOUNT = "";
UvVar LEDGER_VAT = "";
UvVar LEDGER_ADMISSIONS = "";
UvVar LEDGER_UNITS = "";
UvVar TOTAL_AMOUNT = "";
UvVar TOTAL_VAT = "";
UvVar TOTAL_ADMISSIONS = "";
UvVar TOTAL_UNITS = "";
UvVar GRAND_AMOUNT = "";
UvVar GRAND_VAT = "";
UvVar GRAND_ADMISSIONS = "";
UvVar GRAND_UNITS = "";
UvVar LCNT = "";
UvVar LINECOUNT = "";
UvVar HEAD_OF_FORM = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar PERIOD = "";
UvVar SCREEN_HEAD1 = "";
UvVar SCREEN_HEAD2 = "";
UvVar SCREEN_HEAD3 = "";
UvVar SCREEN_HEAD4 = "";
UvVar SCREEN_HEAD5 = "";
UvVar TOTAL_HEAD = "";
UvVar PAGE_NO = "";
UvVar TYPE_BREAK = "";
UvVar BREAK_HEAD = "";
UvVar BREAK_FIELD = "";
UvVar PAGE_HEAD = "";
UvVar INSTRUCTION = "";
UvVar LIST_1 = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
FL006 FL006;
UvVar FINANCE_ID = "";
UvVar FINANCE_DATE = "";
UvVar FINANCE_ACTIVITY = "";
UvVar PRINT_BREAK = "";
UvVar ANS = "";
UvVar CON = "";
UvVar NET = "";
UvVar LEDGER_DESC = "";
UvVar ACTIVITY_DESC = "";
UvVar BREAK_DETAILS = "";
UvVar LEDGER_ID = "";
UvVar CODE_ID = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL484(ref UvVar START_DATE, ref UvVar END_DATE, ref UvVar TYPE_REQUIRED, ref UvVar PRINT_TYPE, ref UvVar PRINT_FLAG) {
this.START_DATE = START_DATE;
this.END_DATE = END_DATE;
this.TYPE_REQUIRED = TYPE_REQUIRED;
this.PRINT_TYPE = PRINT_TYPE;
this.PRINT_FLAG = PRINT_FLAG;
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
/*  FINANCE REPORT (ACTIVITY WITHIN LEDGER CODE) */
PROGRAM = "FL484";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
/* ************************************** */
/*  Include Files */
/* ************************************** */
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.FINANCE.MASTER

/*   NB  Att <10> TO CONTAIN Multivalued elements of key - English Rpt */
/*   NB  Att <11> used for posting to external ledger */

#endregion
#region INCLUDE FL.FILES FL.FINANCE.DESCRIPTIONS

#endregion
/* *************************************** */
/*  Initialize Variables */
/* *************************************** */
EOR = 0;
DETAIL = "D";
SUMMARY = "S";
TOTAL_ONLY = "T";
HELD_ACTIVITY = "";
HELD_LEDGER = "";
HELD_BREAK1 = "";
AMOUNT = 0;
VAT = 0;
ADMISSIONS = 0;
UNITS = 0;
LEDGER_AMOUNT = 0;
LEDGER_VAT = 0;
LEDGER_ADMISSIONS = 0;
LEDGER_UNITS = 0;
TOTAL_AMOUNT = 0;
TOTAL_VAT = 0;
TOTAL_ADMISSIONS = 0;
TOTAL_UNITS = 0;
GRAND_AMOUNT = 0;
GRAND_VAT = 0;
GRAND_ADMISSIONS = 0;
GRAND_UNITS = 0;
LCNT = 56;
if (PRINT_FLAG == "S") {
LINECOUNT = 16;
HEAD_OF_FORM = COMMON.WASH;
} else {
/* * Routine to set printer parameters  (condensed print) */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "STANDARD";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
LINECOUNT = 56;
HEAD_OF_FORM = CHAR(12);
PRINTER_ON();
}
/* * ESTABLISH HEADINGS */
if (!READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRES_REC[CENTRE_NAME] = "UNKNOWN"; }
PERIOD = START_DATE + " - " + END_DATE;
if (PRINT_FLAG == "S") {
SCREEN_HEAD1 = "(" + PROGRAM + ")" + SPACE(49) + TIMEDATE();
SCREEN_HEAD2 = FORMAT(CENTRES_REC[CENTRE_NAME], "L#30") + "FINANCE REPORT  " + SPACE(25) + "PAGE ";
SCREEN_HEAD3 = SPACE(24) + PERIOD;
SCREEN_HEAD4 = "Ledger Cd  Activity                            Amount   Admissions";
SCREEN_HEAD5 = "                                              Amount   Admissions";
} else {
SCREEN_HEAD1 = "(" + PROGRAM + ")" + SPACE(99) + TIMEDATE();
SCREEN_HEAD2 = FORMAT(CENTRES_REC[CENTRE_NAME], "L#50") + "FINANCE REPORT  " + "(Activity within Ledger Code)" + SPACE(22) + "PAGE ";
SCREEN_HEAD3 = SPACE(58) + PERIOD;
SCREEN_HEAD4 = "Ledger Cd                               Activity                               Gross        Vat        Net   Admissions";
SCREEN_HEAD5 = "                                                                               Gross        Vat        Net   Admissions";
}
TOTAL_HEAD = SPACE(88) + "_________   _______    _________     ______";
PAGE_NO = 1;
/* ************************************ */
/*  Select Records */
/* ************************************ */
// BEGIN CASE
// CASE
if (TYPE_REQUIRED == "D") {
TYPE_BREAK = "FINANCE.DATE";
BREAK_HEAD = "Date ";
BREAK_FIELD = 10;
PAGE_HEAD = "Daily ";
}// CASE
else if (TYPE_REQUIRED == "W") {
TYPE_BREAK = "FINANCE.WEEK";
BREAK_HEAD = "Year/Week   ";
BREAK_FIELD = 7;
PAGE_HEAD = "Weekly ";
}// CASE
else if (TYPE_REQUIRED == "P") {
TYPE_BREAK = "FINANCE.PERIOD";
BREAK_HEAD = "Period ";
BREAK_FIELD = 8;
PAGE_HEAD = "Period ";
}// CASE
else if (OTHERWISE) {
TYPE_BREAK = "NONE";
BREAK_HEAD = "";
BREAK_FIELD = "";
PAGE_HEAD = "Yearly ";
}
// END CASE
// BEGIN CASE
// CASE
if (PRINT_TYPE == DETAIL) {
PAGE_HEAD = PAGE_HEAD + "Detail";
}// CASE
else if (PRINT_TYPE == SUMMARY) {
PAGE_HEAD = PAGE_HEAD + "Summary";
}// CASE
else if (PRINT_TYPE == TOTAL_ONLY) {
PAGE_HEAD = PAGE_HEAD + "Totals";
}
// END CASE
PAGE_HEAD = SPACE(INT((132 - LEN(PAGE_HEAD)) / 2)) + PAGE_HEAD;
INSTRUCTION = "SSELECT FL.FINANCE.MASTER WITH DATE >= \"" + START_DATE + "\" AND WITH DATE <= \"" + END_DATE + "\"";
if (TYPE_BREAK != "NONE") {
INSTRUCTION = INSTRUCTION + " BY " + TYPE_BREAK;
}
INSTRUCTION = INSTRUCTION + " BY FINANCE.LEDGER BY CODE BY DATE";
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref LIST_1, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (NOT(LIST_AVAILABLE)) {
PRINTER_OFF();
PRINTER_CLOSE();
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/* ****************************** */
/*   Main Process */
/* ****************************** */
if (PRINT_FLAG != "S") {
PRINT(PRINT_START_COMMAND);
}
EOR = FALSE;
do {
if (!READNEXT(ref FINANCE_ID, 0, 0, LIST_1)) { EOR = TRUE; }
if (EOR == TRUE) break;
if (!(MATREAD(ref FIN_MST_REC, COMMON.FILES[FL_FINANCE_MASTER], FINANCE_ID))) {
MAT(ref FIN_MST_REC, "");
}
FINANCE_DATE = FIELD(FINANCE_ID, "*", 1);
FINANCE_DATE = OCONV(FINANCE_DATE, "D2/");
FINANCE_ACTIVITY = FIELD(FINANCE_ID, "*", 3);
if (HELD_ACTIVITY == "") {
HELD_ACTIVITY = FINANCE_ACTIVITY;
L510();
}
FIN_MST_REC[10] = FINANCE_DATE;
if (HELD_LEDGER == "") {
HELD_LEDGER = FIN_MST_REC[FIN_MST_LEDGER_CODE];
if (BREAK_FIELD != "") {
HELD_BREAK1 = FIN_MST_REC[BREAK_FIELD];
}
PRINT_BREAK = HELD_BREAK1;
L500();
}
if (BREAK_FIELD != "") {
if (FIN_MST_REC[BREAK_FIELD] != HELD_BREAK1) {
L50();
L100();
L200();
}
}
if (FIN_MST_REC[FIN_MST_LEDGER_CODE] != HELD_LEDGER) {
L50();
L100();
}
if (FINANCE_ACTIVITY != HELD_ACTIVITY) {
L50();
}
AMOUNT = AMOUNT + FIN_MST_REC[FIN_MST_GROSS_AMT];
VAT = VAT + FIN_MST_REC[FIN_MST_VAT];
ADMISSIONS = ADMISSIONS + FIN_MST_REC[FIN_MST_ADMISSIONS];
UNITS = UNITS + FIN_MST_REC[FIN_MST_UNITS];
} while (true);
L50();
L100();
L200();
L300();
if (PRINT_FLAG != "S") {
PRINT(PRINT_END_COMMAND);
PRINTER_CLOSE();
PRINTER_OFF();
}
if (PRINT_FLAG == "S") { INPUT(out ANS, 1); }
return;
/* *********************************** */
/*  SUBROUTINES */
/* *********************************** */
}
void L50() {
if (LCNT >= LINECOUNT) {
L400();
}
if (PRINT_TYPE == DETAIL) {
if (LCNT >= LINECOUNT) { INPUT(out CON, 1); LCNT = 0; }
// BEGIN CASE
// CASE
if (PRINT_FLAG == "S") {
PRINTCR(FORMAT(PRINT_BREAK, "L#12") + FORMAT(HELD_LEDGER, "L#15") + FORMAT(HELD_ACTIVITY, "L#10") + FORMAT("", "L#15") + FORMAT(OCONV(AMOUNT, "MD2"), "R#12") + FORMAT(ADMISSIONS, "R#10"));
}// CASE
else if (OTHERWISE) {
NET = AMOUNT - VAT;
PRINTCR(FORMAT(PRINT_BREAK, "L#12") + FORMAT(LEDGER_DESC, "L#40") + FORMAT(ACTIVITY_DESC, "L#33") + FORMAT(OCONV(AMOUNT, "MD2"), "R#12") + FORMAT(OCONV(VAT, "MD2"), "R#10") + FORMAT(OCONV(NET, "MD2"), "R#12") + FORMAT(ADMISSIONS, "R#10"));
}
// END CASE
LCNT = LCNT + 1;
}
LEDGER_AMOUNT = LEDGER_AMOUNT + AMOUNT;
LEDGER_VAT = LEDGER_VAT + VAT;
LEDGER_ADMISSIONS = LEDGER_ADMISSIONS + ADMISSIONS;
LEDGER_UNITS = LEDGER_UNITS + UNITS;
AMOUNT = 0;
VAT = 0;
ADMISSIONS = 0;
UNITS = 0;
HELD_ACTIVITY = FINANCE_ACTIVITY;
L510();
return;
}
void L100() {
if (LCNT + 3 > LINECOUNT) {
L400();
}
if (PRINT_TYPE != TOTAL_ONLY) {
PRINT();
BREAK_DETAILS = "";
if (PRINT_TYPE != "D") {
BREAK_DETAILS = PRINT_BREAK;
}
if (PRINT_FLAG == "S") {
PRINTCR(FORMAT(BREAK_DETAILS, "L#12") + FORMAT(HELD_LEDGER, "L#10") + FORMAT(OCONV(LEDGER_AMOUNT, "MD2"), "R#42") + FORMAT(LEDGER_ADMISSIONS, "R#10"));
} else {
NET = LEDGER_AMOUNT - LEDGER_VAT;
LEDGER_DESC = "Total : " + FORMAT(HELD_LEDGER, "L#50");
PRINTCR(TOTAL_HEAD);
LCNT = LCNT + 1;
PRINTCR(FORMAT(BREAK_DETAILS, "L#12") + FORMAT(LEDGER_DESC, "L#73") + FORMAT(OCONV(LEDGER_AMOUNT, "MD2"), "R#12") + FORMAT(OCONV(LEDGER_VAT, "MD2"), "R#10") + FORMAT(OCONV(NET, "MD2"), "R#12") + FORMAT(LEDGER_ADMISSIONS, "R#10"));
}
PRINT();
LCNT = LCNT + 3;
}
TOTAL_AMOUNT = TOTAL_AMOUNT + LEDGER_AMOUNT;
TOTAL_VAT = TOTAL_VAT + LEDGER_VAT;
TOTAL_ADMISSIONS = TOTAL_ADMISSIONS + LEDGER_ADMISSIONS;
TOTAL_UNITS = TOTAL_UNITS + LEDGER_UNITS;
LEDGER_AMOUNT = 0;
LEDGER_VAT = 0;
LEDGER_ADMISSIONS = 0;
LEDGER_UNITS = 0;
HELD_LEDGER = FIN_MST_REC[FIN_MST_LEDGER_CODE];
L500();
return;
}
void L200() {
if (LCNT > LINECOUNT) {
L400();
}
PRINT();
if (PRINT_FLAG == "S") {
PRINTCR("Total for " + FORMAT(PRINT_BREAK, "L#8") + FORMAT(OCONV(TOTAL_AMOUNT, "MD2"), "R#46") + FORMAT(TOTAL_ADMISSIONS, "R#10"));
} else {
NET = TOTAL_AMOUNT - TOTAL_VAT;
PRINTCR(TOTAL_HEAD);
LCNT = LCNT + 1;
PRINTCR("Total     " + FORMAT(PRINT_BREAK, "L#8") + FORMAT(OCONV(TOTAL_AMOUNT, "MD2"), "R#79") + FORMAT(OCONV(TOTAL_VAT, "MD2"), "R#10") + FORMAT(OCONV(NET, "MD2"), "R#12") + FORMAT(TOTAL_ADMISSIONS, "R#10"));
}
PRINT();
GRAND_AMOUNT = GRAND_AMOUNT + TOTAL_AMOUNT;
GRAND_VAT = GRAND_VAT + TOTAL_VAT;
GRAND_ADMISSIONS = GRAND_ADMISSIONS + TOTAL_ADMISSIONS;
GRAND_UNITS = GRAND_UNITS + TOTAL_UNITS;
TOTAL_AMOUNT = 0;
TOTAL_VAT = 0;
TOTAL_ADMISSIONS = 0;
TOTAL_UNITS = 0;
LCNT = LCNT + 2;
if (BREAK_FIELD != "") {
HELD_BREAK1 = FIN_MST_REC[BREAK_FIELD];
PRINT_BREAK = HELD_BREAK1;
}
return;
}
void L300() {
if (LCNT > LINECOUNT) {
L400();
}
PRINT();
PRINT_BREAK = "        ";
NET = GRAND_AMOUNT - GRAND_VAT;
PRINTCR(TOTAL_HEAD);
PRINTCR("Grand Total " + PRINT_BREAK + FORMAT(OCONV(GRAND_AMOUNT, "MD2"), "R#78") + FORMAT(OCONV(GRAND_VAT, "MD2"), "R#10") + FORMAT(OCONV(NET, "MD2"), "R#12") + FORMAT(GRAND_ADMISSIONS, "R#10"));
PRINT();
return;
}
void L400() {
if (PAGE_NO != 1 && PRINT_FLAG == "S") {
INPUT(out CON, 1);
}
LCNT = 0;
PRINTCR(HEAD_OF_FORM);
PRINTCR(SCREEN_HEAD1);
PRINTCR(SCREEN_HEAD2 + PAGE_NO);
PRINTCR(SCREEN_HEAD3);
if (PRINT_FLAG == "P") {
PRINTCR(PAGE_HEAD);
PRINT();
}
if (PRINT_TYPE == "D") {
PRINTCR(FORMAT(BREAK_HEAD, "L#12") + SCREEN_HEAD4);
} else {
PRINTCR(SPACE(12) + SCREEN_HEAD5);
}
if (PRINT_FLAG == "P") {
PRINT();
}
PAGE_NO = PAGE_NO + 1;
PRINT_BREAK = HELD_BREAK1;
return;
}
void L500() {
/*  GET LEDGER CODE DESCRIPTION */
LEDGER_ID = "LE*" + HELD_LEDGER;
if (!READV(ref LEDGER_DESC, COMMON.FILES[FL_FINANCE_DESCRIPTIONS], LEDGER_ID, 1)) { LEDGER_DESC = ""; }
if (LEDGER_DESC == "") {
LEDGER_DESC = HELD_LEDGER;
} else {
LEDGER_DESC = "(" + HELD_LEDGER + ") " + LEDGER_DESC;
}
return;
}
void L510() {
/*  GET ACTIVITY DESCRIPTION */
CODE_ID = FIELD(FINANCE_ID, "*", 2) + "*" + FINANCE_ACTIVITY;
if (!READV(ref ACTIVITY_DESC, COMMON.FILES[FL_FINANCE_DESCRIPTIONS], CODE_ID, 1)) { ACTIVITY_DESC = ""; }
if (ACTIVITY_DESC == "") {
ACTIVITY_DESC = HELD_ACTIVITY;
} else {
ACTIVITY_DESC = "(" + HELD_ACTIVITY + ") " + ACTIVITY_DESC;
}
return;
/* ******************************** */
/*   END OF ROUTINE */
/* ******************************* */
}
}
}
