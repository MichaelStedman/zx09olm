//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL713 : UvBase
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
UvVar[] MASTER_CENTRE_REC = new UvVar[15];
#endregion
#region Variables
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar AM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar PARAMETER_COUNT = "";
UvVar FL_MASTER_CENTRES = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar FL815_DATA_FIELDS = "";
UvVar REQUESTED_LINE_NO = "";
UvVar START_LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar TEMP_REC = "";
UvVar SPORT_COUNT = "";
UvVar SPORT_NO = "";
UvVar SPORT_CODE = "";
UvVar SUB_CODES = "";
UvVar CODE_POS = "";
UvVar SUB_KEY = "";
UvVar SUB_REC = "";
UvVar SUB_ATT = "";
UvVar SUB_DATA = "";
UvVar FW_WEB_CONTROL = "";
UvVar POS = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
FL006 FL006;
UvVar STORED_TEMP_REC = "";
UvVar STORED_SUB_CODES = "";
UvVar STORED_SUB_DATA = "";
UvVar SELECTED_CENTRE = "";
FL815 FL815;
UvVar WINDOW_CODE_LIST = "";
UvVar LEFT_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar FOOTER = "";
UvVar TEMP_ATT = "";
UvVar OK_TO_AMEND = "";
UvVar ROW = "";
UvVar RUSURE_LINE = "";
UvVar REPLY = "";
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
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar PROMPT_NO = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
FL722 FL722;
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar NO_SPORTS = "";
UvVar SUB_AMC = "";
UvVar QP_REC = "";
UvVar TEST_FILE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL713() {
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
/*     MAINTAIN CENTRE CODES/DESCRIPTIONS */
PROMPT("");
PROGRAM = "FL713";
SCREEN_CODE = PROGRAM;
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
FL815_DATA_FIELDS = "";
REQUESTED_LINE_NO = "";
START_LINE = 1;
/* ************************************ */
/*   Main Processing Section          * */
/* ************************************ */
do {
PRINT(SCREEN_BACK + SCREEN_DATA);
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
MAT(ref MASTER_CENTRE_REC, INIT);
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
if (MAIN_KEY != "" && INTERACT != EXIT) {
MATWRITE(MASTER_CENTRE_REC, FL_MASTER_CENTRES, MAIN_KEY);
WRITE(TEMP_REC, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL*" + MAIN_KEY);
SPORT_COUNT = DCOUNT(TEMP_REC, AM);
for(SPORT_NO = 1; SPORT_NO <= SPORT_COUNT; SPORT_NO += 1) {
SPORT_CODE = TEMP_REC[SPORT_NO];
if (LOCATE(SPORT_CODE, SUB_CODES, 0, 0, 1, ref CODE_POS, "AL")) {
SUB_KEY = "FW.WEB.CONTROL*" + MAIN_KEY + "*" + SPORT_CODE;
if (!READ(ref SUB_REC, COMMON.FILES[FL_CONTROL], SUB_KEY)) { SUB_REC = ""; }
for(SUB_ATT = 1; SUB_ATT <= PARAMETER_COUNT; SUB_ATT += 1) {
SUB_REC[SUB_ATT] = SUB_DATA[CODE_POS, SUB_ATT];
}
WRITE(SUB_REC, COMMON.FILES[FL_CONTROL], SUB_KEY);
}
}
/*  Now update FW.WEB.CONTROL to reflect 'Available on web' indicator */
if (!READ(ref FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL")) { FW_WEB_CONTROL = ""; }
/*  Make sure its not there or removed */
if (LOCATE(MAIN_KEY, FW_WEB_CONTROL, 2, 0, 1, ref POS, "AL")) {
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 1, POS, 0);
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 2, POS, 0);
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 3, POS, 0);
WRITE(FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL");
}
if (MASTER_CENTRE_REC[MC_WEB_BOOKABLE] == "Y" || MASTER_CENTRE_REC[MC_WEB_ENROLMENT][1, 1] == "Y") {
/*  Insert the details, alphabetically by centre description */
if (!LOCATE(MASTER_CENTRE_REC[MC_NAME], FW_WEB_CONTROL, 3, 0, 1, ref POS, "AL")) { NULL(); }
FW_WEB_CONTROL = INSERT(FW_WEB_CONTROL, 1, POS, 0, MASTER_CENTRE_REC[MC_ACCOUNT]);
FW_WEB_CONTROL = INSERT(FW_WEB_CONTROL, 2, POS, 0, MAIN_KEY);
FW_WEB_CONTROL = INSERT(FW_WEB_CONTROL, 3, POS, 0, MASTER_CENTRE_REC[MC_NAME]);
}
WRITE(FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL");
}
}
if (INTERACT == EXIT) break;
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
INPUT_LINE = "  Field no, 'D'elete, 'W'eb params or <RETURN> to finish ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(79, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76) + AT(79, 21));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "") {
INTERACT = FINISH;
}// CASE
else if (ANS == "W" && MASTER_CENTRE_REC[MC_ACCOUNT] == "") {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "W") {
STORED_TEMP_REC = TEMP_REC;
STORED_SUB_CODES = SUB_CODES;
STORED_SUB_DATA = SUB_DATA;
/*  Web parameters */
SELECTED_CENTRE = MAIN_KEY;
nrf0 = LOAD_CODES;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
nrf0 = DISPLAY_WINDOW;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
if (TEMP_REC[1] == "") {
nrf0 = INPUT_ALL;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
} else {
nrf0 = REDISPLAY;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
}
/*  Use the bottom row of the 'pop-up' window to */
/*  control the amendment and creation of web */
/*  parameters */
INTERACT = INVALID_DATA;
FOOTER = " No, 'Dn', 'In', <return> or 'F'inish ";
do {
if (!(INTERACT == INVALID_DATA)) break;
PRINT(AT(79, 1 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 1 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 1 + LEN(FOOTER), 1 + BOTTOM_WINDOW));
INPUT(out ANS, 5);
// BEGIN CASE
// CASE
if (ANS == "F") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == COMMON.ABANDON) {
if (TEMP_REC == STORED_TEMP_REC && SUB_CODES == STORED_SUB_CODES && SUB_DATA == STORED_SUB_DATA) {
INTERACT = VALID_DATA;
} else {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
TEMP_REC = STORED_TEMP_REC;
SUB_CODES = STORED_SUB_CODES;
SUB_DATA = STORED_SUB_DATA;
INTERACT = VALID_DATA;
}
}// CASE
else if (MATCH(ANS,"2N") || MATCH(ANS,"3N")) {
TEMP_ATT = ANS - 20;
// BEGIN CASE
// CASE
if (TEMP_ATT <= 0) {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
OK_TO_AMEND = TRUE;
if (TEMP_ATT > 1) {
if (TEMP_REC[TEMP_ATT - 1] == "") {
OK_TO_AMEND = FALSE;
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
if (OK_TO_AMEND) {
REQUESTED_LINE_NO = ANS;
nrf0 = INPUT_SINGLE;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
}
}
// END CASE
}// CASE
else if (MATCH(ANS,"\"D\"2N") || MATCH(ANS,"\"D\"3N")) {
TEMP_ATT = INT(TRIM(ANS.Substring(2, 3))) - 20;
// BEGIN CASE
// CASE
if (TEMP_ATT < 1) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (TEMP_REC[TEMP_ATT] == "" && TEMP_REC[TEMP_ATT + 1] == "") {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
REQUESTED_LINE_NO = TRIM(ANS.Substring(2, 3));
nrf0 = DELETE_SINGLE;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
}
// END CASE
/*  DJA 15.2.05 */
}// CASE
else if (MATCH(ANS,"\"I\"2N")) {
TEMP_ATT = ANS.Substring(2, 2) - 20;
// BEGIN CASE
// CASE
if (TEMP_ATT < 1) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (TEMP_REC[TEMP_ATT] == "") {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
REQUESTED_LINE_NO = ANS.Substring(2, 2);
nrf0 = INSERT_SINGLE;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
}
// END CASE
}// CASE
else if (ANS == "") {
/*  Scroll */
nrf0 = SCROLL;
nrf1 = MASTER_CENTRE_REC[MC_ACCOUNT];
FL815 = new FL815(ref nrf0, ref TEMP_REC, ref SUB_CODES, ref SUB_DATA, ref REQUESTED_LINE_NO, ref FL815_DATA_FIELDS, ref WINDOW_CODE_LIST, ref START_LINE, ref CODE_POS, ref INTERACT, ref SELECTED_CENTRE, ref nrf1, ref LEFT_WINDOW, ref BOTTOM_WINDOW, ref WINDOW_JUST);
INTERACT = INVALID_DATA;
}
// END CASE
} while (true);
PRINT(AT(0, 3) + NRM_VID);
for(ROW = 3; ROW <= 19; ROW += 1) {
PRINT(AT(25, ROW) + COMMON.EOL);
}
L0300();
INTERACT = INVALID_DATA;
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "D") {
RUSURE_LINE = "  Are you sure you want to delete this centre? ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + RUSURE_LINE);
INPUT(out REPLY, 2);
PRINT(AT(79, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76) + AT(79, 21));
if (REPLY == "Y" || REPLY == "y") {
DELETE(FL_MASTER_CENTRES, MAIN_KEY);
if (READ(ref FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL")) {
/*  Make sure its not there or removed */
if (LOCATE(MAIN_KEY, FW_WEB_CONTROL, 2, 0, 1, ref POS, "AL")) {
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 1, POS, 0);
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 2, POS, 0);
FW_WEB_CONTROL = DELETE(FW_WEB_CONTROL, 3, POS, 0);
WRITE(FW_WEB_CONTROL, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL");
}
}
INTERACT = EXIT;
} else {
INTERACT = INVALID_DATA;
}
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
VALUE = MASTER_CENTRE_REC[ST_ATT][1, ST_MV];
}
PRINT(SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
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
case 1: L1000(); break;
case 2: L1100(); break;
case 3: L1150(); break;
case 4: L1200(); break;
case 5: L1300(); break;
case 6: L1400(); break;
case 7: L1500(); break;
case 8: L1600(); break;
case 9: L1700(); break;
case 10: L1800(); break;
case 11: L1900(); break;
case 12: L2000(); break;
case 13: L2100(); break;
case 14: L2200(); break;
case 15: L2300(); break;
case 16: L2400(); break;
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
MASTER_CENTRE_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
PROMPT_NO = 1;
PRINT(COMMON.WASH);
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
for(PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1) {
PRINT(AT(79, PRINT_LINE) + NRM_VID);
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(76));
}
/*  Reposition cursor to prevent wyse problem */
PRINT(AT(0, 3) + NRM_VID);
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
PRINT(FORMAT(OCONV(MASTER_CENTRE_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(MASTER_CENTRE_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
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
void L1000() {
/*   CENTRE CODE Validation Routine */
if (ANS == COMMON.HELP) {
nrf0 = REDISPLAY;
FL722 = new FL722(ref ANS, ref INTERACT, ref nrf0);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
PRINT(AT(78, 23) + NRM_VID);
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
PRINT(AT(78, 23) + NRM_VID);
}
ANS = OCONV(ANS, "MCU");
INTERACT = VALID_DATA;
if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ST_ICONVERSION != "") {
VALUE = ICONV(ANS, ST_ICONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
if (!(MATREADU(ref MASTER_CENTRE_REC, FL_MASTER_CENTRES, MAIN_KEY))) {
AMENDING = FALSE;
MAT(ref MASTER_CENTRE_REC, INIT);
}
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
SUB_CODES = "";
SUB_DATA = "";
if (READ(ref TEMP_REC, COMMON.FILES[FL_CONTROL], "FW.WEB.CONTROL*" + MAIN_KEY)) {
/*  Populate SUB.CODES and SUB.DATA */
NO_SPORTS = DCOUNT(TEMP_REC, AM);
for(SPORT_NO = 1; SPORT_NO <= NO_SPORTS; SPORT_NO += 1) {
SUB_CODES[SPORT_NO] = TEMP_REC[SPORT_NO];
SUB_KEY = "FW.WEB.CONTROL*" + MAIN_KEY + "*" + TEMP_REC[SPORT_NO];
if (!READ(ref SUB_REC, COMMON.FILES[FL_CONTROL], SUB_KEY)) { SUB_REC = ""; }
for(SUB_AMC = 1; SUB_AMC <= PARAMETER_COUNT; SUB_AMC += 1) {
if (SUB_REC[SUB_AMC].Substring(1, 1) != "*") {
SUB_DATA[SPORT_NO, SUB_AMC] = SUB_REC[SUB_AMC];
}
}
}
} else {
TEMP_REC = "";
}
} else {
PRINT(ERR_LINE + "Invalid Data Format ");
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINTCR(AT(-9)); ANS = ANS.Substring(1, 2); }
PRINT(CLR_ERR);
INTERACT = INVALID_DATA;
}
} else {
INTERACT = EXIT;
}
return;
}
void L1100() {
/*   CENTRE Description Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1150() {
/*   CENTRE Short Description Validation Routine */
INTERACT = VALID_DATA;
return;
/* ******************************* */
}
void L1200() {
/*   ACCOUNT Name Validation */
/* ******************************* */
/*  Test account name with a temporary q-pointer */
QP_REC = "Q";
QP_REC[2] = ANS;
QP_REC[3] = "MD";
WRITE(QP_REC, COMMON.FILES[FL_MD], "QP.FL713");
if (OPEN("QP.FL713", out TEST_FILE)) {
INTERACT = VALID_DATA;
} else {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1300() {
/*   CENTRE Telephone Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1400() {
/*   CENTRE Address 1 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1500() {
/*   CENTRE Address 2 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1600() {
/*   CENTRE Address 3 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1700() {
/*   CENTRE Address 4 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1800() {
/*   CENTRE Address 5 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1900() {
/*   CENTRE VAT Number Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2000() {
/*   CENTRE Note 1 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2100() {
/*   CENTRE Note 2 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2200() {
/*   CENTRE Note 3 Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2300() {
/*  Available for web booking? */
ANS = OCONV(ANS, "MCU");
if (ANS == "" || ANS == "Y" || ANS == "N") {
INTERACT = VALID_DATA;
} else {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2400() {
/*  Available for web re-enrolment? */
ANS = OCONV(ANS, "MCU");
if (ANS == "" || ANS == "Y" || ANS == "N") {
INTERACT = VALID_DATA;
} else {
nrf0 = 9;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
/* ****************** */
/*   End of Program * */
/* ****************** */
}
}
}
