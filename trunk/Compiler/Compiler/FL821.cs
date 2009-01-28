//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL821 : UvBase
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar MC_NAME = 1;
readonly UvVar MC_ACCOUNT = 2;
readonly UvVar MC_TELEPHONE = 3;
readonly UvVar MC_ADDRESS1 = 4;
readonly UvVar MC_ADDRESS2 = 5;
readonly UvVar MC_ADDRESS3 = 6;
readonly UvVar MC_ADDRESS4 = 7;
readonly UvVar MC_ADDRESS5 = 8;
readonly UvVar MC_VAT_NUMBER = 9;
readonly UvVar MC_NOTE1 = 10;
readonly UvVar MC_NOTE2 = 11;
readonly UvVar MC_NOTE3 = 12;
readonly UvVar MC_SHORT_NAME = 13;
readonly UvVar MC_WEB_BOOKABLE = 14;
readonly UvVar MC_WEB_ENROLMENT = 15;
readonly UvVar FL_MD = 58;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] SUB_REC;
UvVar[] MASTER_CENTRE_REC = new UvVar[15];
#endregion
#region Variables
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar SELECTED_CENTRE = "";
UvVar SELECTED_ACTIVITY = "";
UvVar ACCOUNT_NAME = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar DIM_UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar INPUT_LINE = "";
UvVar PARAMETER_COUNT = "";
UvVar FL_MASTER_CENTRES = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar HEADING_TEXT = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar N = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar ANS = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar MDISL = "";
UvVar ANS2 = "";
UvVar I = "";
UvVar CHARACTER = "";
UvVar ST_MANDATORY = "";
FL006 FL006;
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar SCREEN_LINE = "";
UvVar ST_TYPE = "";
UvVar ST_DESC = "";
UvVar ST_ATT_MV = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar CONV_ANS = "";
UvVar CNT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL821(ref UvVar[] SUB_REC, ref UvVar INTERACT, ref UvVar REDISPLAY, ref UvVar SELECTED_CENTRE, ref UvVar SELECTED_ACTIVITY, ref UvVar ACCOUNT_NAME) {
this.SUB_REC = SUB_REC;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
this.SELECTED_CENTRE = SELECTED_CENTRE;
this.SELECTED_ACTIVITY = SELECTED_ACTIVITY;
this.ACCOUNT_NAME = ACCOUNT_NAME;
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
/*     MAINTAIN WEB BOOKING PARAMETERS FOR A SINGLE ACTIVITY */
PROMPT("");
/* !*  EQU DISPLAY.WINDOW TO 0, INPUT.ALL TO 1, INPUT.SINGLE TO 2, LOAD.CODES TO 3, REDISPLAY TO 4, INSERT.SINGLE TO 5, DELETE.SINGLE TO 6, SCROLL TO 7 */
PROGRAM = "FL821";
SCREEN_CODE = PROGRAM;
INPUT_LINE = "";
/*  DJA 7.12.04 */
PARAMETER_COUNT = 18;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.MASTER.CENTRES
#region INCLUDE FL.FILES FL.MASTER.CENTRES.EQU
if (!OPEN("FL.MASTER.CENTRES", out FL_MASTER_CENTRES)) { STOP("201", "FL.MASTER.CENTRES"); }

#endregion

#region INCLUDE FL.FILES FL.MASTER.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.MASTER.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.MD

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 8;
WINDOW[2] = 18;
WINDOW[3] = 1;
WINDOW[4] = 77;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
/* !*  HEADING.TEXT2 = WINDOW<6> */
L3000();
/*  Display window */
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
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = INIT;
do {
LINE = SC_POS[SCREEN_LINES + 1];
if (LINE == "") break;
if (LINE[1, 4] != "") {
MAX_FIELDS = MAX_FIELDS + 1;
if (FIELD(LINE[1, 5], ",", 1) + 0 > 0 && FIRST_FIELD == 0) {
FIRST_FIELD = MAX_FIELDS;
}
DATA_FIELDS[MAX_FIELDS] = LINE;
}
SCREEN_LINES = SCREEN_LINES + 1;
} while (true);
/* ************************************ */
/*   Main Processing Section          * */
/* ************************************ */
do {
PRINT(SCREEN_BACK + SCREEN_DATA);
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
for(N = 1; N <= PARAMETER_COUNT; N += 1) {
if (SUB_REC[N] != "") { AMENDING = TRUE; }
}
MAIN_KEY = INIT;
if (AMENDING) {
L0300();
L0050();
} else {
FIELD_NO = 1;
}
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
else if (INTERACT == FINISH) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (FIELD_NO >= MAX_FIELDS) {
L0050();
}// CASE
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (INTERACT != INVALID_DATA) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
/* !*        IF MAIN.KEY # "" AND INTERACT # EXIT THEN */
/* !*        END */
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   Enter Amendment Field Number  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "  Field no or <return> to finish ";
PRINT(AT(79, BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, BOTTOM_WINDOW) + DIM_UND_VID + FORMAT(INPUT_LINE, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 1 + LEN(INPUT_LINE), BOTTOM_WINDOW));
INPUT(out ANS, 3);
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
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ******************************** */
}
void L0060() {
/*   Data Entry Routine       * */
/* ******************************** */
INTERACT = INVALID_DATA;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = SUB_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL, ST_ROW) + DIM_VID + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINTCR(AT(-9)); ANS = ANS.Substring(1, ST_LENGTH); }
ANS2 = "";
for(I = 1; I <= ST_LENGTH; I += 1) {
CHARACTER = ANS.Substring(I, 1);
if (SEQ(CHARACTER) > 31) { ANS2 = ANS2 + CHARACTER; }
}
ANS = ANS2;
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.SKIP && ST_MANDATORY != "") {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
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
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1100(); break;
case 2: L1200(); break;
case 3: L1300(); break;
case 4: L1400(); break;
case 5: L1500(); break;
case 6: L1600(); break;
case 7: L1700(); break;
case 8: L1800(); break;
case 9: L1900(); break;
case 10: L2000(); break;
case 11: L2100(); break;
case 12: L2200(); break;
case 13: L2300(); break;
case 14: L2400(); break;
case 15: L2500(); break;
case 16: L2600(); break;
case 17: L2700(); break;
case 18: L2800(); break;
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
PRINT(AT(ST_COL, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
SUB_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
/* !*     PROMPT.NO = 1 */
/* !*     DOTS.ONLY = 0 */
/* !*     CALL FL000.10 (SCREEN.CODE,DOTS.ONLY) */
/*  Reposition cursor to prevent wyse problem */
/* !*     PRINT @(0,3):NRM.VID: */
SCREEN_LINES = DCOUNT(SC_POS, AM);
for(SCREEN_LINE = 1; SCREEN_LINE <= SCREEN_LINES; SCREEN_LINE += 1) {
FIELD_DATA = SC_POS[SCREEN_LINE];
L0200();
PRINT(AT(78, ST_ROW) + NRM_VID);
// BEGIN CASE
// CASE
if (ST_TYPE == "SA") {
PRINT(AT(ST_COL, ST_ROW) + DIM_VID + FORMAT(ST_DESC, ST_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(AT(ST_COL - 1 - LEN(ST_DESC), ST_ROW) + DIM_VID + FORMAT(ST_DESC, "L#" + LEN(ST_DESC)));
}
// END CASE
}
return;
/* ********************************* */
}
void L0200() {
/*   Extract Field Data      * */
/* ********************************* */
ST_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
ST_ROW = FIELD_DATA[1, 2];
ST_DESC = FIELD_DATA[1, 3];
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT_MV = FIELD_DATA[1, 5];
ST_ATT = FIELD(ST_ATT_MV, ",", 1);
ST_MV = FIELD(ST_ATT_MV, ",", 2);
ST_TYPE = FIELD_DATA[1, 7];
ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
ST_MANDATORY = FIELD_DATA[1, 10];
ST_ICONVERSION = FIELD_DATA[1, 12];
if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
return;
/* ********************************* */
}
void L0300() {
/*   Display Item Contents */
/* ********************************* */
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
if (DISP_ATT != 0) {
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(SUB_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(SUB_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
} else {
PRINT(FORMAT(MAIN_KEY, DISP_JUST));
}
}
return;
/* ************************ */
/*   Validation Routines  * */
/* ************************ */
}
void L1100() {
/*   BOOK AHEAD START Description Validation Routine */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 101;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1200() {
/*   BOOK AHEAD (MEMBERS) Validation Routine */
// BEGIN CASE
// CASE
if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N") || MATCH(ANS,"4N")) {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "") {
/*  Warn user that standard LeisureFlex member bookaheads will be used */
nrf0 = 203;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = VALID_DATA;
PRINT(AT(ST_COL, ST_ROW) + DIM_VID);
PRINT(AT(ST_COL, ST_ROW));
}// CASE
else if (OTHERWISE) {
nrf0 = 102;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
return;
}
void L1300() {
/*   BOOKINGS START (MINS) */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 103;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1400() {
/*   BOOK-AHEAD START TIME Validation Routine */
if (MATCH(ANS,"1N\":\"2N") || MATCH(ANS,"2N\":\"2N")) {
CONV_ANS = ICONV(ANS, "MT");
if (CONV_ANS != "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 104;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
nrf0 = 104;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1500() {
/*   CHECK ROUTINE (e.g. FWSUNBED) Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1600() {
/*   BOOK-AHEAD (NON-MEMBERS) Validation Routine */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N") || MATCH(ANS,"4N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 106;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1700() {
/*   MAX COURTS PER TIMESLOT Validation Routine */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 107;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1800() {
/*   MAX SUCCESSIVE COURTS Validation Routine */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 108;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1900() {
/*  JUNIOR CUT-OFF TIME */
if (MATCH(ANS,"1N\":\"2N") || MATCH(ANS,"2N\":\"2N")) {
CONV_ANS = ICONV(ANS, "MT");
if (CONV_ANS != "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 109;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
nrf0 = 109;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2000() {
/*  Grouping Minutes */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N") || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 110;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2100() {
/*  Hide columns where nothing bookable */
if (ANS == "Y" || ANS == "N" || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 111;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2200() {
/*  First player payment only */
if (ANS == "Y" || ANS == "N" || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 112;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2300() {
/*  Hide availability counts in timetable display */
if (ANS == "Y" || ANS == "N" || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 113;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2400() {
/*  Multi-basket entry Quantity selection permitted (e.g. seminar places) */
if (ANS == "Y" || ANS == "N" || ANS == "" || MATCH(ANS,"1N") || MATCH(ANS,"2N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 114;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2500() {
/*  Payment terms */
/*      'Y' = pay when booked  'N' = Optional payment */
/*      'A' = Authorisation code must be supplied */
if (ANS == "Y" || ANS == "N" || ANS == "" || ANS == "A") {
INTERACT = VALID_DATA;
} else {
nrf0 = 115;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2600() {
/*  Allow court/area selection */
if (ANS == "Y" || ANS == "N" || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 116;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2700() {
/*  Send booking notification emails to resource administrator */
if (ANS == "Y" || ANS == "N" || ANS == "" || ANS == "T") {
INTERACT = VALID_DATA;
} else {
nrf0 = 117;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2800() {
/*  Unit Quantity selection permitted (e.g. buffet/tea & biscuits) */
if (ANS == "" || MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N")) {
INTERACT = VALID_DATA;
} else {
nrf0 = 118;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L3000() {
/*  Display window */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + DIM_UND_VID + FORMAT((HEADING_TEXT + SELECTED_ACTIVITY + "'"), WINDOW_JUST));
CNT = 0;
do {
CNT = CNT + 1;
if (CNT >= WINDOW_DEPTH) break;
/*  DJA! DES! */
/*  If adding new parameters, the next two lines need to add 1 less */
PRINT(AT(79, CNT + 4) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + 3) + DIM_VID + FORMAT("", WINDOW_JUST));
} while (true);
PRINT(AT(79, BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, BOTTOM_WINDOW) + DIM_UND_VID + FORMAT(INPUT_LINE, WINDOW_JUST));
return;
/* ****************** */
/*   End of Program * */
/* ****************** */
}
}
}
