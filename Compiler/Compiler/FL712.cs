//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL712 : UvBase
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
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
readonly UvVar CTYPE_DESCRIPTION = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] CTYPE_REC = new UvVar[5];
#endregion
#region Variables
UvVar ERR_LINE = "";
UvVar CLR_ERR = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_COURSE_TYPES = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
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
FL006 FL006;
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
FL721 FL721;
UvVar REDISPLAY = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
FL864 FL864;
UvVar RETURNED_ANS = "";
UvVar N = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL712() {
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
/*     MAINTAIN ACTIVITY CODES/DESCRIPTIONS */
PROMPT("");
PROGRAM = "FL712";
SCREEN_CODE = PROGRAM;
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.TYPES
if (!OPEN("FL.COURSE.TYPES", out FL_COURSE_TYPES)) { STOP("201", "FL.COURSE.TYPES"); }

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
/* ************************************ */
/*   Main Processing Section          * */
/* ************************************ */
do {
PRINT(SCREEN_BACK + SCREEN_DATA);
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
MAT(ref ACT_CODE_REC, INIT);
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
MATWRITE(ACT_CODE_REC, FL_ACTIVITY_CODES, MAIN_KEY);
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
INPUT_LINE = "  Enter Field no, 'D' to Delete or <RETURN> to finish ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(79, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76));
PRINT(AT(79, 21));
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
}// CASE
else if (ANS == "D") {
RUSURE_LINE = "  Are you sure you want to delete this code? ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + RUSURE_LINE);
INPUT(out REPLY, 2);
PRINT(AT(79, 21) + NRM_VID);
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76) + AT(79, 21));
if (REPLY == "Y" || REPLY == "y") {
DELETE(FL_ACTIVITY_CODES, MAIN_KEY);
INTERACT = EXIT;
} else {
INTERACT = INVALID_DATA;
}
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
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = ACT_CODE_REC[ST_ATT][1, ST_MV];
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
PRINT(AT(ST_COL, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
ACT_CODE_REC[ST_ATT][1, ST_MV] = VALUE;
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
if (DISP_ATT != 0) {
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(ACT_CODE_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(ACT_CODE_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
}
}
return;
/* ************************ */
/*   Validation Routines  * */
/* ************************ */
}
void L1000() {
/*   ACTIVITY CODE Validation Routine */
if (ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
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
if (!(MATREADU(ref ACT_CODE_REC, FL_ACTIVITY_CODES, MAIN_KEY))) {
AMENDING = FALSE;
MAT(ref ACT_CODE_REC, INIT);
}
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
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
/*   Activity Description Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*  WEB TYPE */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
FL864 = new FL864(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
if (INTERACT != EXIT) {
ANS = RETURNED_ANS;
} else {
INTERACT = INVALID_DATA;
}
/* !*     OLD.FIELD.NO = FIELD.NO */
/* !*     OLD.FIELD.DATA = FIELD.DATA */
/* !*     GOSUB 0100 */
/* !*     GOSUB 0300 */
/* !*     FIELD.NO = OLD.FIELD.NO */
/* !*     FIELD.DATA = OLD.FIELD.DATA */
/* !*     GOSUB 0200 */
for(N = 9; N <= 19; N += 1) {
PRINT(AT(0, N) + NRM_VID + COMMON.EOL);
}
}
if (INTERACT != INVALID_DATA) {
if (ANS == "") {
INTERACT = VALID_DATA;
} else {
if (MATREAD(ref CTYPE_REC, FL_COURSE_TYPES, ANS)) {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 51;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
return;
}
void L1300() {
/*  Permit waiting list */
if (ANS == "" || ANS == "Y" || ANS == "N") {
INTERACT = VALID_DATA;
} else {
nrf0 = 52;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
/* ****************** */
/*   End of Program * */
/* ****************** */
}
}
}
