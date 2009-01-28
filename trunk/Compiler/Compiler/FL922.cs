//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL922 : UvBase
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
readonly UvVar DISPLAY_WINDOW = 0;
readonly UvVar INPUT_ALL = 1;
readonly UvVar INPUT_SINGLE = 2;
readonly UvVar LOAD_CODES = 3;
readonly UvVar REDISPLAY = 4;
readonly UvVar INSERT_SINGLE = 5;
readonly UvVar DELETE_SINGLE = 6;
readonly UvVar SCROLL = 7;
readonly UvVar SCREENS = 8;
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
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar NEW_RESOURCE = "";
UvVar NRM_VID = "";
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
UvVar JUST = "";
FL925 FL925;
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar REQUESTED_LINE_NO = "";
UvVar START_LINE = "";
UvVar FL925_DATA_FIELDS = "";
UvVar AMENDING = "";
UvVar WINDOW_CODE_LIST = "";
UvVar CODE_POS = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar ST_ATT = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
FL006 FL006;
UvVar OK_TO_SELECT = "";
UvVar SELECTED_MV = "";
UvVar PREVIOUS_MV = "";
UvVar OK_TO_FILE = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar PROMPT_NO = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL922(ref UvVar[] SPORTS_REC, ref UvVar NEW_RESOURCE, ref UvVar[] TICK_CONTROL_REC) {
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
/*     CATEGORY & RESOURCE MAINTENANCE P2 - SUB-CATEGORIES/RESOURCES */
PROMPT("");
PROGRAM = "FL922";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
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
/*  DJA 23.12.05 FL925 Needs to know if the master code is a category */
/*               or a resource, to prevent dependant resources being */
/*               nested beneath a category */
PROG_MESS[49] = SPORTS_REC[SPORTS_CAT_OR_RESOURCE];
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
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
REQUESTED_LINE_NO = "";
START_LINE = 1;
FL925_DATA_FIELDS = INIT;
L0100();
AMENDING = FALSE;
nrf0 = LOAD_CODES;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
if (PROG_MESS[2] != "") {
MAIN_KEY = PROG_MESS[2];
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
if (TEMP_REC[12][1, 1] == "") {
/*  No sub-categories/resources currently exist */
AMENDING = FALSE;
} else {
L0300();
/*  Display data */
}
} else {
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
}
/*  Set field no to max.fields so we jump straight to */
/*  inputting all codes */
if (AMENDING) { L0050(); } else { FIELD_NO = MAX_FIELDS; }
if (INTERACT == VALID_DATA) {
do {
do {
if (FIELD_NO < MAX_FIELDS) {
L0060();
}
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
// BEGIN CASE
// CASE
if (ST_ATT == 0) {
FIELD_NO = FIELD_NO + 1;
/* !!          CASE AMENDING = FALSE AND INTERACT = VALID.DATA AND TEMP.REC(ST.ATT) = "" AND (ST.ATT >= 3 AND ST.ATT <= 9) */
/* !!            START.FIELD.NO = FIELD.NO + 1 */
/* !!            FOR FIELD.NO = START.FIELD.NO TO 11 */
/* !!              FIELD.DATA = DATA.FIELDS<FIELD.NO> */
/* !!              GOSUB 0200 */
/* !!              PRINT @(ST.COL,ST.ROW):"" ST.JUST: */
/* !!            NEXT FIELD.NO */
/* !!            FIELD.NO = 12 */
}// CASE
else if (OTHERWISE) {
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
else if (FIELD_NO == MAX_FIELDS) {
if (NOT(AMENDING)) {
nrf0 = INPUT_ALL;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
if (INTERACT != EXIT) { L0050(); }
} else {
L0050();
}
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
if (INTERACT == EXIT) { PROG_MESS[1] = COMMON.ABANDON; }
PROG_MESS[49] = "";
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
INPUT_LINE = " Field no, Page no 'Dn' to delete, <RET> to scroll or 'F'inish ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 5);
PRINT(AT(2, 21) + SPACE(74));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == "") {
nrf0 = SCROLL;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "F") {
L0055();
if (INTERACT == FINISH) {
PROG_MESS[1] = "";
}
}// CASE
else if (ANS == "P3" && SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "C") {
nrf0 = 51;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
L0055();
if (INTERACT == FINISH) {
PROG_MESS[1] = ANS.Substring(2, 1);
}
}// CASE
else if (ANS.Substring(1, 1) == "D" && ANS.Substring(2, 99) >= 100 && ANS.Substring(2, 99) <= 999) {
REQUESTED_LINE_NO = ANS.Substring(2, 99) - 89;
nrf0 = DELETE_SINGLE;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
if (INTERACT != EXIT) {
/*  Update sports.rec */
L9000();
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 100 && ANS <= 999) {
REQUESTED_LINE_NO = ANS - 89;
/*  Check this is an existing code or the next available one */
OK_TO_SELECT = TRUE;
SELECTED_MV = ANS - 99;
PREVIOUS_MV = SELECTED_MV - 1;
// BEGIN CASE
// CASE
if (SELECTED_MV == 1) {
NULL();
}// CASE
else if (TEMP_REC[12][1, SELECTED_MV] == "" && TEMP_REC[12][1, PREVIOUS_MV] == "") {
OK_TO_SELECT = FALSE;
}
// END CASE
if (OK_TO_SELECT) {
nrf0 = INPUT_SINGLE;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
/* !CRT "TEMP.REC(12)=":TEMP.REC(12):"  INTERACT=":INTERACT:;INPUT FLEX,2: */
if (INTERACT != EXIT) {
/*  Update sports.rec */
L9000();
}
} else {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ***************************************** */
}
void L0055() {
/*   Check its ok to file/update       * */
/* ***************************************** */
OK_TO_FILE = TRUE;
/* !!     BEGIN CASE */
/* !!     CASE TEMP.REC(1) > TEMP.REC(2) */
/* !!       CALL FL006(PROGRAM,9,INIT) */
/* !!       OK.TO.FILE = FALSE */
/* !!     END CASE */
if (OK_TO_FILE) {
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
/*  Deal with default values for certain fields here */
/* !!     CASE AMENDING = FALSE AND ST.ATT = 11 AND ANS = "" AND VALUE = "" */
/* !!       VALUE = TEMP.REC(2) */
/* !!       INTERACT = VALID.DATA */
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
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
/* !!    ON FIELD.NO GOSUB 1000, 1200, 1300, 1500, 1500, 1500, 1500, 1500, 1500, 1500, 1500, 2300 */
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
PRINT(AT(79, PRINT_LINE) + NRM_VID);
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
}
/*  Display the page 1 window */
nrf0 = DISPLAY_WINDOW;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
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
return;
/* ********************************* */
}
void L0300() {
/*   DISPLAY ITEM CONTENTS */
/* ********************************* */
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
/* *     IF DISP.ATT # 0 THEN */
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL - 2, DISP_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4] + 1;
DISP_CONVERSION = FIELD_DATA[1, 9];
// BEGIN CASE
// CASE
if (DISP_ATT == 0) {
PRINT(FORMAT(MAIN_KEY, DISP_JUST));
}// CASE
else if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
// END CASE
/* *     END */
}
nrf0 = REDISPLAY;
FL925 = new FL925(ref nrf0, ref TEMP_REC, ref REQUESTED_LINE_NO, ref FL925_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT);
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[12] = SPORTS_REC[SPORTS_SUB_LIST];
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
SPORTS_REC[SPORTS_SUB_LIST] = TEMP_REC[12];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
