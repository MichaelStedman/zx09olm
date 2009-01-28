//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL801 : UvBase
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
readonly UvVar FL_CUST_INDEX = 86;
readonly UvVar TOP_WINDOW = 1;
readonly UvVar BOTTOM_WINDOW = 2;
readonly UvVar LEFT_WINDOW = 3;
readonly UvVar RIGHT_WINDOW = 4;
readonly UvVar WIDTH = 5;
readonly UvVar CLR_LINE = 6;
readonly UvVar WINDOW_SIZE = 7;
readonly UvVar HEADING_TEXT = 8;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BLOCK_PAY_REC = new UvVar[50];
UvVar[] CUST_REC = new UvVar[20];
UvVar[] CUST_INDEX_REC = new UvVar[24];
UvVar[] BOX_DETAILS = new UvVar[10];
#endregion
#region Variables
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar MAX_FIELDS = "";
UvVar ALL_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar DISP_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar BOOKING_KEY = "";
UvVar FIELD_NO = "";
FL800 FL800;
UvVar PRINT_FLAG = "";
UvVar CONTINUE = "";
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
UvVar CUST_KEY = "";
FL389 FL389;
UvVar RESPONSE = "";
UvVar LINE_NO = "";
FL390 FL390;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL801() {
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
/*  Block Booking Payments Report */
PROMPT("");
PROGRAM = "FL801";
SCREEN_CODE = PROGRAM;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.BLOCK.PAY

#endregion
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
#region INCLUDE FL.FILES FL.CUST.INDEX

#endregion
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
MAT(ref BOX_DETAILS, INIT);
BOX_DETAILS[TOP_WINDOW] = 9;
BOX_DETAILS[BOTTOM_WINDOW] = 20;
BOX_DETAILS[LEFT_WINDOW] = 8;
BOX_DETAILS[RIGHT_WINDOW] = 77;
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
BOOKING_KEY = "";
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
FL800 = new FL800(ref BOOKING_KEY, ref PRINT_FLAG);
PRINT(AT(0, 22) + SPACE(76));
PRINT(AT(3, 22) + "<RETURN> TO CONTINUE ");
INPUTCR(out CONTINUE);
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
case 3: L1200(); break;
case 4: L1300(); break;
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
PRINTCR(AT(TEXT_COL, ST_ROW) + DIM_VID + " ");
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
PRINT(AT(DISP_COL - 1, DISP_ROW));
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
/*  Booking Key */
INTERACT = VALID_DATA;
if (!(ANS == "")) {
if (!(ANS == "ALL")) {
if (MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], ANS)) {
FIELD_NO = 3;
CUST_KEY = FIELD(ANS, "/", 1);
if (MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY)) {
PRINT(AT(34, 6) + FORMAT(CUST_KEY, "L#7"));
PRINT(AT(34, 7) + FORMAT(CUST_REC[CUST_NAME], "L#30"));
}
} else {
INTERACT = INVALID_DATA;
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
BOOKING_KEY = ANS;
return;
}
void L1100() {
/*  Customer Key */
INTERACT = VALID_DATA;
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
AMENDING = TRUE;
}// CASE
else if (ANS == "") {
}// CASE
else if (OTHERWISE) {
if (MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], ANS)) {
CUST_KEY = ANS;
PRINT(AT(34, 7) + FORMAT(CUST_REC[CUST_NAME], "L#25"));
} else {
nrf0 = 20;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
if (INTERACT != INVALID_DATA) {
/*  Display all accounts for this customer */
FL389 = new FL389(ref BOX_DETAILS, ref CUST_KEY, ref CUST_REC, ref RESPONSE, ref BOOKING_KEY);
if (RESPONSE == COMMON.ABANDON) {
INTERACT = EXIT;
} else {
for(LINE_NO = 9; LINE_NO <= 20; LINE_NO += 1) {
PRINT(AT(0, LINE_NO) + COMMON.EOL);
}
if (BOOKING_KEY != "") {
BOOKING_KEY = CUST_KEY + "/" + BOOKING_KEY;
PRINT(AT(34, 5) + FORMAT(BOOKING_KEY, "L#12"));
FIELD_NO = 3;
if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], BOOKING_KEY))) {
MAT(ref BLOCK_PAY_REC, "");
}
} else {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
AMENDING = TRUE;
}
}
}
}
// END CASE
return;
}
void L1200() {
/*  Customer Name */
INTERACT = VALID_DATA;
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
AMENDING = TRUE;
}// CASE
else if (ANS != "") {
RESPONSE = "";
VALUE = ANS;
/*   Display Customers with this name */
FL390 = new FL390(ref ANS, ref BOX_DETAILS, ref RESPONSE, ref CUST_KEY);
// BEGIN CASE
// CASE
if (RESPONSE == COMMON.ABANDON) {
INTERACT = EXIT;
AMENDING = TRUE;
}// CASE
else if (RESPONSE == FALSE) {
INTERACT = EXIT;
AMENDING = TRUE;
}// CASE
else if (OTHERWISE) {
if (!MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY)) { MAT(ref CUST_REC, ""); }
PRINT(AT(34, 6) + FORMAT(CUST_KEY, "L#7"));
FL389 = new FL389(ref BOX_DETAILS, ref CUST_KEY, ref CUST_REC, ref RESPONSE, ref BOOKING_KEY);
if (RESPONSE == COMMON.ABANDON) {
INTERACT = EXIT;
} else {
for(LINE_NO = 9; LINE_NO <= 20; LINE_NO += 1) {
PRINT(AT(0, LINE_NO) + COMMON.EOL);
}
if (BOOKING_KEY != "") {
BOOKING_KEY = CUST_KEY + "/" + BOOKING_KEY;
PRINT(AT(34, 5) + FORMAT(BOOKING_KEY, "L#12"));
if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], BOOKING_KEY))) {
MAT(ref BLOCK_PAY_REC, "");
}
} else {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
AMENDING = TRUE;
}
}
}
// END CASE
}// CASE
else if (OTHERWISE) {
INTERACT = EXIT;
AMENDING = TRUE;
}
// END CASE
return;
}
void L1300() {
/*  Print Flag */
INTERACT = VALID_DATA;
if (ANS == "") {
ANS = "S";
} else {
if (ANS != "S" && ANS != "P") {
INTERACT = INVALID_DATA;
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
PRINT_FLAG = ANS;
return;
/* ************************************** */
/*  END OF PROGRAM */
/* ************************************** */
}
}
}
