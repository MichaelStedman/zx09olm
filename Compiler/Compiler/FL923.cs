//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL923 : UvBase
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
readonly UvVar SCREENS = 8;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_SPORTS = 23;
readonly UvVar SPORTS_DESC = 1;
readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
readonly UvVar SPORTS_CODE1 = 3;
readonly UvVar SPORTS_CODE2 = 4;
readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
readonly UvVar SPORTS_TYPE = 6;
readonly UvVar SPORTS_BOOK_OR_CAS = 7;
readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
readonly UvVar SPORTS_RESTRICTION_CODE = 9;
readonly UvVar SPORTS_PERSON_BOOKING = 10;
readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
readonly UvVar SPORTS_SETUP_TIME = 12;
readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
readonly UvVar SPORTS_PLAYERS = 14;
readonly UvVar SPORTS_ADMINISTRATOR = 15;
readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
readonly UvVar SPORTS_VISIBILITY = 17;
readonly UvVar SPORTS_SUB_LIST = 18;
readonly UvVar SPORTS_TOP_LEVEL = 19;
readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
readonly UvVar FL_TICKET_CONTROL = 19;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] SPORTS_REC;
UvVar[] TICK_CONTROL_REC;
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar NEW_RESOURCE = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar GO_BACK = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar SUBSIDIARY1_FIELD_NO = "";
UvVar SUBSIDIARY2_FIELD_NO = "";
UvVar MAIN_KEY = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
FL006 FL006;
UvVar OK_TO_FILE = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar OLD_VALUE = "";
UvVar PROMPT_NO = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar ST_VALIDATION = "";
UvVar MAX_TOTAL = "";
UvVar VAC_TOTAL = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_VALIDATION = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar N = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL923(ref UvVar[] SPORTS_REC, ref UvVar NEW_RESOURCE, ref UvVar[] TICK_CONTROL_REC) {
this.SPORTS_REC = SPORTS_REC;
this.NEW_RESOURCE = NEW_RESOURCE;
this.TICK_CONTROL_REC = TICK_CONTROL_REC;
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
/*     RESOURCE & CATEGORY MAINTENANCE PAGE 3. TICKET TEXT ETC */
PROMPT("");
PROGRAM = "FL923";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.SPORTS
#region INCLUDE FL.FILES FL.SPORTS.EQU

#endregion

#region INCLUDE FL.FILES FL.SPORTS.DIM

#endregion
#region INCLUDE FL.FILES FL.SPORTS.VAR

/*  Introduced for Warrington: */

#endregion

#endregion
#region INCLUDE FL.FILES FL.TICKET.CONTROL

#endregion
MAT(ref TEMP_REC, "");
/* ************************************ */
/*   GET SCREEN DEFINITION ITEM       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
/* ********************************** */
/*   EXTRACT DATA INPUT FIELDS      * */
/* ********************************** */
MAX_FIELDS = 0;
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = "";
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
SUBSIDIARY1_FIELD_NO = 2;
SUBSIDIARY2_FIELD_NO = 3;
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
L0100();
MAIN_KEY = PROG_MESS[2];
L8000();
/*  Build temp.rec */
/*  Set 'amending' flag */
if (NEW_RESOURCE) {
AMENDING = FALSE;
} else {
AMENDING = TRUE;
L0300();
/*  Display data */
}
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
/*  Check that the case statement below has not indicated that all */
/*  required data has been entered */
if (INTERACT != LIMIT) {
L0060();
}
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS || INTERACT == LIMIT) break;
// BEGIN CASE
// CASE
if (OTHERWISE) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (INTERACT == BACKUP && FIELD_NO > 1) {
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (FIELD_NO == MAX_FIELDS || INTERACT == LIMIT) {
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
if (MAIN_KEY != "" && INTERACT != EXIT) {
/*  Transfer data out of TEMP.REC */
L9000();
}
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "      Enter Field no, Page no or 'F' to finish ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == "") {
/*  Next page */
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = 1; }
}// CASE
else if (ANS == "F") {
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = ""; }
}// CASE
else if (ANS == "P2" && (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "R" || SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "") && SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] != "N") {
nrf0 = 50;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = ANS.Substring(2, 1); }
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* **************************************************** */
}
void L0055() {
/*  Check its ok for the user to leave page 2     * */
/* **************************************************** */
OK_TO_FILE = TRUE;
if (OK_TO_FILE == TRUE) {
INTERACT = FINISH;
}
return;
/* ******************************** */
}
void L0060() {
/*   DATA ENTRY ROUTINE       * */
/* ******************************** */
INTERACT = INVALID_DATA;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = TEMP_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == GO_BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
}// CASE
else if ((ANS == "" || ANS == COMMON.CLR) && VALUE == "" && ST_MANDATORY != "") {
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
/*  Force all entries through the validation code */
/* *   CASE ANS = "" AND VALUE = "" AND ST.MANDATORY = "" AND FIELD.NO > 1 */
/* *     INTERACT = VALID.DATA */
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1200(); break;
case 2: L1300(); break;
case 3: L1400(); break;
case 4: L1400(); break;
case 5: L1400(); break;
case 6: L1400(); break;
case 7: L1400(); break;
case 8: L1400(); break;
case 9: L1400(); break;
case 10: L1400(); break;
case 11: L1400(); break;
case 12: L1400(); break;
}
#endregion
if (INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
}
}
// END CASE
PRINT(AT(ST_COL - 1, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
OLD_VALUE = TEMP_REC[ST_ATT];
TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
/* ******************************* */
}
void L0100() {
/*   DISPLAY SCREEN FORMAT  * */
/* ******************************** */
PROMPT_NO = 1;
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
for(PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1) {
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
}
return;
/* ********************************* */
}
void L0200() {
/*   EXTRACT FIELD DATA      * */
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
ST_VALIDATION = FIELD_DATA[1, 11];
return;
/* ********************************* */
}
void L0300() {
/*   DISPLAY ITEM CONTENTS */
/* ********************************* */
MAX_TOTAL = 0;
VAC_TOTAL = 0;
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
/* *     IF DISP.ATT # 0 THEN */
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
DISP_VALIDATION = FIELD_DATA[1, 11];
PRINT(AT(DISP_COL - 2, DISP_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(DISP_COL, DISP_ROW));
if (FIELD_DATA[1, 8] == "R") {
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
} else {
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4] + 1;
}
DISP_CONVERSION = FIELD_DATA[1, 9];
// BEGIN CASE
// CASE
if (DISP_ATT == 0) {
PRINT(FORMAT(MAIN_KEY, DISP_JUST));
}// CASE
else if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
/* !!        IF TEMP.REC(DISP.ATT)<1,DISP.MV> # "" AND I = SUBSIDIARY1.FIELD.NO OR I = SUBSIDIARY2.FIELD.NO THEN */
/* !!           READ SUB.REC FROM FL.SPORTS, TEMP.REC(DISP.ATT)<1,DISP.MV> ELSE SUB.REC = "" */
/* !!           PRINT @(DISP.COL+10,DISP.ROW):SUB.REC<1> "L#30" */
/* !!        END */
}// CASE
else if (OTHERWISE) {
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
// END CASE
/* *     END */
}
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1200() {
/*  WARNING OR FIXED */
ANS = OCONV(ANS, "MCU");
if (ANS == "" || ANS == "W" || ANS == "F") {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 42;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1300() {
/*  BOOKINGS AND CASUAL (Y/N) */
ANS = OCONV(ANS, "MCU");
if (ANS == "" || ANS == "Y" || ANS == "N") {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 43;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1400() {
/*  TICKET TEXT LINE */
INTERACT = VALID_DATA;
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
/* !!  TEMP.REC(1) = SPORTS.BOOKING.LEEWAY */
/* !!  TEMP.REC(2) = SPORTS.CODE1 */
/* !!  TEMP.REC(3) = SPORTS.CODE2 */
TEMP_REC[4] = SPORTS_REC[SPORTS_TYPE];
TEMP_REC[5] = SPORTS_REC[SPORTS_BOOK_OR_CAS];
for(N = 6; N <= 15; N += 1) {
TEMP_REC[N] = TICK_CONTROL_REC[N - 5];
}
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
/* !!  SPORTS.BOOKING.LEEWAY = TEMP.REC(1) */
/* !!  SPORTS.CODE1 = TEMP.REC(2) */
/* !!  SPORTS.CODE2 = TEMP.REC(3) */
SPORTS_REC[SPORTS_TYPE] = TEMP_REC[4];
SPORTS_REC[SPORTS_BOOK_OR_CAS] = TEMP_REC[5];
for(N = 6; N <= 15; N += 1) {
TICK_CONTROL_REC[N - 5] = TEMP_REC[N];
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
