//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL803 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar VALID_DATA = 0;
readonly UvVar EXIT = 2;
readonly UvVar BACKUP = 3;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
readonly UvVar FL_SCREENS = 8;
readonly UvVar FL_BLOCK_HEADER = 87;
readonly UvVar BLOCK_SDESC = 1;
readonly UvVar BLOCK_STIME = 2;
readonly UvVar BLOCK_ETIME = 3;
readonly UvVar BLOCK_SPORT = 4;
readonly UvVar BLOCK_FLOORS1 = 5;
readonly UvVar BLOCK_FLOORS2 = 6;
readonly UvVar BLOCK_FLOORS3 = 7;
readonly UvVar BLOCK_DATES1 = 8;
readonly UvVar BLOCK_DATES2 = 9;
readonly UvVar BLOCK_DATES3 = 10;
readonly UvVar BLOCK_PRICE_REF = 11;
readonly UvVar BLOCK_LETTER = 12;
readonly UvVar BLOCK_INSTALL = 13;
readonly UvVar BLOCK_START = 14;
readonly UvVar BLOCK_FREQUENCY = 15;
readonly UvVar BLOCK_NO_INSTALLS = 16;
readonly UvVar BLOCK_NOTES = 17;
readonly UvVar BLOCK_DATE_MADE = 18;
readonly UvVar BLOCK_USER = 19;
readonly UvVar BLOCK_DEALER = 20;
readonly UvVar BLOCK_FLOORS4 = 21;
readonly UvVar BLOCK_FLOORS5 = 22;
readonly UvVar BLOCK_FLOORS6 = 23;
readonly UvVar BLOCK_FLOORS7 = 24;
readonly UvVar BLOCK_DATES4 = 25;
readonly UvVar BLOCK_DATES5 = 26;
readonly UvVar BLOCK_DATES6 = 27;
readonly UvVar BLOCK_DATES7 = 28;
readonly UvVar FL_BLOCK_PAY = 88;
readonly UvVar BLOCK_PAY_DUE = 1;
readonly UvVar BLOCK_PAY_OWES = 2;
readonly UvVar BLOCK_PAY_PAID = 3;
readonly UvVar BLOCK_PAY_OUTSTAND = 4;
readonly UvVar BLOCK_PAY_TOTAL_OWED = 5;
readonly UvVar BLOCK_PAY_TOTAL_PAID = 6;
readonly UvVar BLOCK_PAY_DATES_PAID = 7;
readonly UvVar BLOCK_PAY_AMOUNTS_PAID = 8;
readonly UvVar BLOCK_PAY_ADJ = 9;
readonly UvVar BLOCK_PAY_ADJ_TYPE = 10;
readonly UvVar BLOCK_PAY_ADJ_DATE = 11;
readonly UvVar BLOCK_PAY_ADJ_INST = 12;
readonly UvVar BLOCK_PAY_SPORTS1 = 13;
readonly UvVar BLOCK_PAY_HEADCOUNTS1 = 14;
readonly UvVar BLOCK_PAY_SPORTS2 = 15;
readonly UvVar BLOCK_PAY_HEADCOUNTS2 = 16;
readonly UvVar BLOCK_PAY_SPORTS3 = 17;
readonly UvVar BLOCK_PAY_HEADCOUNTS3 = 18;
readonly UvVar BLOCK_PAY_SPORTS4 = 19;
readonly UvVar BLOCK_PAY_HEADCOUNTS4 = 20;
readonly UvVar BLOCK_PAY_SPORTS5 = 21;
readonly UvVar BLOCK_PAY_HEADCOUNTS5 = 22;
readonly UvVar FL_CUSTOMERS = 85;
readonly UvVar CUST_NAME = 1;
readonly UvVar CUST_INITS = 2;
readonly UvVar CUST_TITLE = 3;
readonly UvVar CUST_ADDRESS1 = 4;
readonly UvVar CUST_ADDRESS2 = 5;
readonly UvVar CUST_ADDRESS3 = 6;
readonly UvVar CUST_ADDRESS4 = 7;
readonly UvVar CUST_POST = 8;
readonly UvVar CUST_HTEL = 9;
readonly UvVar CUST_WTEL = 10;
readonly UvVar CUST_COMMENTS = 11;
readonly UvVar CUST_ACCOUNTS = 12;
readonly UvVar CUST_LAST_ACC = 13;
readonly UvVar CUST_MEMBER_NO = 14;
readonly UvVar CUST_DUE = 15;
readonly UvVar CUST_ORGANISATION = 16;
readonly UvVar CUST_EMAIL_ADDRESS = 17;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar NAME = "N";
readonly UvVar DUE_DATE = "D";
readonly UvVar AMOUNT = "A";
#endregion
#region Arrays
UvVar[] BLOCK_REC = new UvVar[30];
UvVar[] BLOCK_PAY_REC = new UvVar[50];
UvVar[] CUST_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar VM = "";
UvVar EXECUTE_PROG = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
UvVar MAX_FIELDS = "";
UvVar ALL_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar DISP_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar ANS = "";
UvVar FIELD_DATA = "";
UvVar VALUE = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar REDISPLAY = "";
UvVar ST_MANDATORY = "";
FL006 FL006;
UvVar ST_ATT = "";
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar PROMPT_NO = "";
FL306 FL306;
UvVar I = "";
UvVar TEXT_COL = "";
UvVar TEXT_VIDEO = "";
UvVar AMD_NO = "";
UvVar TEXT_LEN = "";
UvVar VIDEO_OFF = "";
UvVar ST_ATT_MV = "";
UvVar ST_MV = "";
UvVar ST_DISPLAY = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar ORDER = "";
UvVar PRINT_TYPE = "";
UvVar SSTATEMENT = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar DEBTORS_GRID = "";
UvVar EOF = "";
UvVar DEBT_KEY = "";
UvVar CUST_KEY = "";
UvVar AMOUNT_DUE = "";
UvVar NO_OF_DATES = "";
UvVar DATE_NO = "";
UvVar ZZZ_DATE = "";
UvVar FIRST_DATE = "";
UvVar PNTR = "";
FL235 FL235;
UvVar PAGE_DEPTH = "";
UvVar FORM = "";
UvVar LINE_NO = "";
UvVar PAGE_NO = "";
UvVar HEADER = "";
UvVar DEBT_CNT = "";
UvVar OLD_CUST = "";
UvVar CUST_TOTAL = "";
UvVar GRAND_TOTAL = "";
UvVar ACCOUNT_KEY = "";
UvVar BOOKING_DESC = "";
UvVar CONTINUE = "";
UvVar CUST_FULL_NAME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL803() {
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
/*  Block Booking Debtors Report */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
PROGRAM = "FL803";
SCREEN_CODE = PROGRAM;
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
#region INCLUDE FL.FILES FL.BLOCK.PAY

#endregion
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
if (!READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRES_REC[CENTRE_NAME] = ""; }
/* ************************************ */
/*   Get Screen Definition Item       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[FL_SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
/* ********************************** */
/*   Extract Data Input Fields      * */
/* ********************************** */
MAX_FIELDS = 0;
ALL_FIELDS = 0;
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = INIT;
DISP_FIELDS = INIT;
do {
LINE = SC_POS[SCREEN_LINES + 1];
if (LINE == "") break;
if (LINE[1, 4] != "") {
ALL_FIELDS = ALL_FIELDS + 1;
DISP_FIELDS[ALL_FIELDS] = LINE;
if (LINE[1, 14] != "Y") {
MAX_FIELDS = MAX_FIELDS + 1;
if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0) {
FIRST_FIELD = MAX_FIELDS;
}
DATA_FIELDS[MAX_FIELDS] = LINE;
}
}
SCREEN_LINES = SCREEN_LINES + 1;
} while (true);
/* ************************************ */
/*   Main Processing Section          * */
/* ************************************ */
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO >= MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (FIELD_NO >= MAX_FIELDS) {
L0050();
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
if (INTERACT != EXIT) {
L5000();
}
}
return;
/* ************************************* */
}
void L0050() {
/*   Enter Amendment Field Number  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
PRINT(ERR_LINE);
PRINT("Enter Field no. or <RETURN> to finish ");
LENGTH_OF_INPUT = 2;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
PRINT(CLR_ERR);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "") {
INTERACT = FINISH;
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}
// END CASE
} while (INTERACT == INVALID_DATA);
return;
/* ******************************** */
}
void L0060() {
/*   Data Entry Routine       * */
/* ******************************** */
INTERACT = INVALID_DATA;
do {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
VALUE = "";
PRINT(AT(ST_COL - 1, ST_ROW));
FL019 = new FL019(ref ST_LENGTH, ref ANS);
if (!(ANS == COMMON.HELP)) break;
REDISPLAY = FALSE;
if (REDISPLAY) {
L0100();
L0300();
}
} while (true);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.SKIP && ST_MANDATORY != "") {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (ANS == COMMON.SKIP && ST_ATT != 0) {
INTERACT = VALID_DATA;
do {
if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
}// CASE
else if (ANS == COMMON.CLR) {
if (ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
} else {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1100(); break;
}
#endregion
if (INTERACT == VALID_DATA) {
if (ST_ICONVERSION != "") {
VALUE = ICONV(ANS, ST_ICONVERSION);
} else {
VALUE = ANS;
}
}
}
// END CASE
PRINT(AT(ST_COL - 1, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
PROMPT_NO = 1;
PRINT(COMMON.WASH);
FL306 = new FL306();
PRINT(AT(2, 0) + "(" + SCREEN_CODE + ")");
PRINT(AT(24, 0) + SC_POS[1]);
PRINT(AT(24, 1) + STR("=", LEN(SC_POS[1])));
for(I = 2; I <= SCREEN_LINES; I += 1) {
FIELD_DATA = SC_POS[I];
L0200();
TEXT_COL = FIELD_DATA[1, 1];
TEXT_VIDEO = FIELD_DATA[1, 7];
if (ST_ATT + 0 > 0) {
AMD_NO = "  " + PROMPT_NO;
AMD_NO = AMD_NO.Substring(LEN(AMD_NO) - 1, 2) + ")";
PRINT(AT(TEXT_COL - 4, ST_ROW) + AMD_NO);
PROMPT_NO = PROMPT_NO + 1;
}
if (TEXT_VIDEO == "D") {
TEXT_LEN = LEN(FIELD_DATA[1, 3]);
VIDEO_OFF = TEXT_LEN + TEXT_COL;
PRINT(AT(VIDEO_OFF, ST_ROW) + NRM_VID);
PRINTCR(AT(TEXT_COL - 1, ST_ROW) + DIM_VID + " ");
}
PRINT(AT(TEXT_COL, ST_ROW));
PRINT(FIELD_DATA[1, 3] + NRM_VID + " ");
PRINT(STR(".", ST_LENGTH));
}
return;
/* ********************************* */
}
void L0200() {
/*   Extract Field Data      * */
/* ********************************* */
ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
ST_ROW = FIELD_DATA[1, 2];
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT_MV = FIELD_DATA[1, 5];
ST_ATT = FIELD(ST_ATT_MV, ",", 1);
ST_MV = FIELD(ST_ATT_MV, ",", 2);
ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
ST_MANDATORY = FIELD_DATA[1, 10];
ST_ICONVERSION = FIELD_DATA[1, 12];
ST_DISPLAY = FIELD_DATA[1, 14];
if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
return;
/* ********************************* */
}
void L0300() {
/*   Display Item Contents */
/* ********************************* */
for(I = 1; I <= ALL_FIELDS; I += 1) {
FIELD_DATA = DISP_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
if (DISP_ATT != 0) {
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
}
}
return;
/* ************************ */
/*   Validation Routines  * */
/* ************************ */
}
void L1000() {
/*   Order */
INTERACT = VALID_DATA;
if (ANS == "") {
INTERACT = EXIT;
AMENDING = TRUE;
} else {
if (ANS != "N" && ANS != "A" && ANS != "D") {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
ORDER = ANS;
}
}
return;
}
void L1100() {
/*  Screen or Printer */
INTERACT = VALID_DATA;
if (ANS != "S" && ANS != "P") {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
PRINT_TYPE = ANS;
return;
}
void L5000() {
/*  Produce Report */
SSTATEMENT = "SSELECT FL.BLOCK.PAY WITH 1 < \"" + OCONV(TODAYS_DATE, "D2/") + "\" AND WITH OUTSTAND > \"" + 0 + "\"";
/*        EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
DEBTORS_GRID = "";
EOF = 0;
do {
if (!READNEXT(ref DEBT_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], DEBT_KEY))) {
MAT(ref BLOCK_PAY_REC, "");
}
CUST_KEY = FIELD(DEBT_KEY, "/", 1);
if (!(MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY))) {
MAT(ref CUST_REC, "");
}
PRINT(PRINT_END_COMMAND);
AMOUNT_DUE = 0;
NO_OF_DATES = DCOUNT(BLOCK_PAY_REC[BLOCK_PAY_DUE][1], VM);
for(DATE_NO = 1; DATE_NO <= NO_OF_DATES; DATE_NO += 1) {
ZZZ_DATE = BLOCK_PAY_REC[BLOCK_PAY_DUE][1, DATE_NO];
if (ZZZ_DATE < TODAYS_DATE) {
AMOUNT_DUE = AMOUNT_DUE + BLOCK_PAY_REC[BLOCK_PAY_OUTSTAND][1, DATE_NO];
if (BLOCK_PAY_REC[BLOCK_PAY_OUTSTAND][1, DATE_NO] > 0) {
FIRST_DATE = ZZZ_DATE;
}
}
}
if (AMOUNT_DUE > 0) {
// BEGIN CASE
// CASE
if (ORDER == NAME) {
if (!LOCATE(CUST_REC[CUST_NAME], DEBTORS_GRID, 1, 0, 1, ref PNTR, "AL")) { NULL(); }
DEBTORS_GRID = INSERT(DEBTORS_GRID, 1, PNTR, 0, CUST_REC[CUST_NAME]);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 2, PNTR, 0, DEBT_KEY);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 3, PNTR, 0, AMOUNT_DUE);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 4, PNTR, 0, FIRST_DATE);
}// CASE
else if (ORDER == DUE_DATE) {
if (!LOCATE(FIRST_DATE, DEBTORS_GRID, 4, 0, 1, ref PNTR, "AR")) { NULL(); }
DEBTORS_GRID = INSERT(DEBTORS_GRID, 1, PNTR, 0, CUST_REC[CUST_NAME]);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 2, PNTR, 0, DEBT_KEY);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 3, PNTR, 0, AMOUNT_DUE);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 4, PNTR, 0, FIRST_DATE);
}// CASE
else if (ORDER == AMOUNT) {
if (!LOCATE(AMOUNT_DUE, DEBTORS_GRID, 3, 0, 1, ref PNTR, "DR")) { NULL(); }
DEBTORS_GRID = INSERT(DEBTORS_GRID, 1, PNTR, 0, CUST_REC[CUST_NAME]);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 2, PNTR, 0, DEBT_KEY);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 3, PNTR, 0, AMOUNT_DUE);
DEBTORS_GRID = INSERT(DEBTORS_GRID, 4, PNTR, 0, FIRST_DATE);
}
// END CASE
}
} while (true);
if (PRINT_TYPE == "P") {
/* * Routine to set printer parameters  (condensed print) */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "STANDARD";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PAGE_DEPTH = 60;
FORM = CHAR(12);
} else {
PAGE_DEPTH = 20;
}
LINE_NO = 66;
PAGE_NO = 0;
HEADER = "";
HEADER[1] = SPACE(20) + "BLOCK BOOKING DEBTORS REPORT" + SPACE(20) + "Page ";
HEADER[2] = FORMAT(CENTRES_REC[CENTRE_NAME], "L#20") + STR("=", 28) + SPACE(9) + TIMEDATE();
HEADER[3] = "";
HEADER[4] = SPACE(2) + "Account No." + SPACE(6) + "Description" + SPACE(15) + "Due From" + SPACE(10) + "Amount";
HEADER[5] = SPACE(2) + "-----------" + SPACE(6) + "-----------" + SPACE(15) + "--------" + SPACE(10) + "------";
DEBT_CNT = 0;
OLD_CUST = "";
CUST_TOTAL = 0;
GRAND_TOTAL = 0;
do {
DEBT_CNT = DEBT_CNT + 1;
ACCOUNT_KEY = DEBTORS_GRID[2, DEBT_CNT];
if (ACCOUNT_KEY == "") break;
CUST_KEY = FIELD(ACCOUNT_KEY, "/", 1);
if (CUST_KEY != OLD_CUST) {
if (OLD_CUST != "") { L8000(); }
if (INTERACT == EXIT) { goto L5999; }
L7000();
/*  Print Customer Header */
if (INTERACT == EXIT) { goto L5999; }
}
if (!READV(ref BOOKING_DESC, COMMON.FILES[FL_BLOCK_HEADER], ACCOUNT_KEY, 1)) { BOOKING_DESC = "DELETED"; }
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L5999; }
PRINTCR(SPACE(2) + FORMAT(ACCOUNT_KEY, "L#12") + SPACE(5) + FORMAT(BOOKING_DESC, "L#25") + SPACE(1) + OCONV(DEBTORS_GRID[4, DEBT_CNT], "D") + SPACE(5) + FORMAT(OCONV(DEBTORS_GRID[3, DEBT_CNT], "MD2"), "R#8"));
CUST_TOTAL = CUST_TOTAL + DEBTORS_GRID[3, DEBT_CNT];
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L5999; }
PRINT();
OLD_CUST = CUST_KEY;
} while (true);
L8000();
/*  Customer Total */
if (INTERACT == EXIT) { goto L5999; }
L9000();
/*  Grand Total */
L5999:;
if (PRINT_TYPE == "S") {
PRINT(AT(1, 22) + COMMON.EOL);
PRINT(AT(60, 22) + "<RETURN> TO FINISH");
INPUTCR(out CONTINUE);
} else {
PRINTER_CLOSE();
PRINTER_OFF();
}
return;
}
void L6000() {
/*  Print Header */
if (PRINT_TYPE == "S") {
if (PAGE_NO != 0) {
PRINT(AT(1, 22) + COMMON.EOL);
PRINT(AT(50, 22) + "<RETURN> TO CONTINUE");
INPUT(out CONTINUE, 1);
if (CONTINUE == COMMON.ABANDON) { INTERACT = EXIT; goto L6999; }
}
PRINT(COMMON.WASH);
} else {
PRINTCR(FORM);
}
PAGE_NO = PAGE_NO + 1;
PRINTCR(HEADER[1] + FORMAT(PAGE_NO, "R#4"));
PRINTCR(HEADER[2]);
PRINTCR(HEADER[3]);
LINE_NO = 3;
L6999:;
return;
}
void L7000() {
if (!(MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY))) {
MAT(ref CUST_REC, "");
}
CUST_FULL_NAME = "";
CUST_FULL_NAME = CUST_REC[CUST_TITLE];
if (CUST_FULL_NAME == "") {
CUST_FULL_NAME = CUST_REC[CUST_INITS];
} else {
CUST_FULL_NAME = CUST_FULL_NAME + " " + CUST_REC[CUST_INITS];
}
CUST_FULL_NAME = TRIM(CUST_FULL_NAME);
CUST_FULL_NAME = CUST_FULL_NAME + " " + CUST_REC[CUST_NAME];
CUST_FULL_NAME = TRIM(CUST_FULL_NAME);
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L7999; }
PRINT();
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L7999; }
PRINTCR(SPACE(2) + "Customer " + FORMAT(CUST_KEY, "L#6") + SPACE(2) + FORMAT(CUST_FULL_NAME, "L#35"));
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L7999; }
PRINT();
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L7999; }
PRINTCR(HEADER[4]);
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L7999; }
PRINTCR(HEADER[5]);
L7999:;
return;
}
void L8000() {
/*  Print Customer Total */
if (CUST_TOTAL != 0) {
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L8999; }
PRINT();
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L8999; }
PRINTCR(SPACE(46) + "Total " + SPACE(9) + FORMAT(OCONV(CUST_TOTAL, "MD2"), "R#8"));
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L8999; }
PRINT();
GRAND_TOTAL = GRAND_TOTAL + CUST_TOTAL;
CUST_TOTAL = 0;
}
L8999:;
return;
}
void L9000() {
/*  Grand Total */
if (GRAND_TOTAL != 0) {
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L9999; }
PRINT();
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L6000(); }
if (INTERACT == EXIT) { goto L9999; }
PRINTCR(SPACE(40) + "Grand Total " + SPACE(8) + FORMAT(OCONV(GRAND_TOTAL, "MD2"), "R#9"));
}
L9999:;
return;
/* ************************************** */
/*  END OF PROGRAM */
/* ************************************** */
}
}
}
