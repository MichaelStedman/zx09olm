//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL781 : UvBase
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
readonly UvVar STUDENT_TITLE = 1;
readonly UvVar STUDENT_FORENAME = 2;
readonly UvVar STUDENT_SURNAME = 3;
readonly UvVar STUDENT_ADDRESS1 = 4;
readonly UvVar STUDENT_ADDRESS2 = 5;
readonly UvVar STUDENT_ADDRESS3 = 6;
readonly UvVar STUDENT_ADDRESS4 = 7;
readonly UvVar STUDENT_POST_CODE = 8;
readonly UvVar STUDENT_SEX = 9;
readonly UvVar STUDENT_HOME_TEL = 10;
readonly UvVar STUDENT_WORK_TEL = 11;
readonly UvVar STUDENT_DOB = 12;
readonly UvVar STUDENT_MEDICAL1 = 13;
readonly UvVar STUDENT_MEDICAL2 = 14;
readonly UvVar STUDENT_MEDICAL3 = 15;
readonly UvVar STUDENT_COMMENT1 = 16;
readonly UvVar STUDENT_COMMENT2 = 17;
readonly UvVar STUDENT_COMMENT3 = 18;
readonly UvVar STUDENT_COMMENT4 = 19;
readonly UvVar STUDENT_CONTACT_NAME = 20;
readonly UvVar STUDENT_CONTACT_PHONE = 21;
readonly UvVar STUDENT_DETAIL_IDS = 22;
readonly UvVar STUDENT_BALANCE = 23;
readonly UvVar STUDENT_TRANS_DETAILS_IDS = 24;
readonly UvVar STUDENT_TRANS_DATES = 25;
readonly UvVar STUDENT_TRANS_TYPES = 26;
readonly UvVar STUDENT_TRANS_AMOUNTS = 27;
readonly UvVar STUDENT_TRANS_RECEIPT_NOS = 28;
readonly UvVar STUDENT_TRANS_MOPS = 29;
readonly UvVar STUDENT_TRANS_MAN_RECEIPT = 30;
readonly UvVar STUDENT_TRANS_WEB = 30;
readonly UvVar STUDENT_TRANS_ADJ_REASON = 31;
readonly UvVar STUDENT_TRANS_USER = 32;
readonly UvVar STUDENT_OLD_NUMBERS = 33;
readonly UvVar STUDENT_AWARD1 = 34;
readonly UvVar STUDENT_AWARD2 = 35;
readonly UvVar STUDENT_AWARD3 = 36;
readonly UvVar STUDENT_AWARD4 = 37;
readonly UvVar STUDENT_DOCTOR_NAME = 38;
readonly UvVar STUDENT_DOCTOR_TEL = 39;
readonly UvVar STUDENT_KEYWORD = 40;
readonly UvVar STUDENT_AWARD5 = 41;
readonly UvVar STUDENT_AWARD6 = 42;
readonly UvVar STUDENT_AWARD7 = 43;
readonly UvVar STUDENT_AWARD8 = 44;
readonly UvVar STUDENT_AWARD9 = 45;
readonly UvVar STUDENT_AWARD10 = 46;
readonly UvVar STUDENT_AWARD11 = 47;
readonly UvVar STUDENT_AWARD12 = 48;
readonly UvVar STUDENT_GROUP_ENROLLED = 49;
readonly UvVar AWARD_DESCRIPTION = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] AWARD_REC = new UvVar[5];
UvVar[] TEMP_REC = new UvVar[40];
#endregion
#region Variables
UvVar NEW_STUDENT = "";
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
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar JUST = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_AWARDS = "";
UvVar COURSE_PARAMS = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar VALUE = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
FL714 FL714;
UvVar REDISPLAY = "";
UvVar COURSE_OCCURENCE = "";
FL006 FL006;
UvVar ST_ATT = "";
UvVar ST_MV = "";
UvVar ST_LENGTH = "";
UvVar MDISL = "";
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
FL780 FL780;
UvVar RETURNED_ANS = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL781(ref UvVar[] STUDENT_REC, ref UvVar NEW_STUDENT) {
this.STUDENT_REC = STUDENT_REC;
this.NEW_STUDENT = NEW_STUDENT;
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
/*     STUDENT MAINTENANCE (NEW MODULE - PAGE 2) */
PROMPT("");
PROGRAM = "FL781";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.COURSE.AWARDS
if (!OPEN("FL.COURSE.AWARDS", out FL_COURSE_AWARDS)) { STOP("201", "FL.COURSE.AWARDS"); }

#endregion
MAT(ref TEMP_REC, "");
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
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
AMENDING = FALSE;
L0100();
MAIN_KEY = PROG_MESS[2];
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_AWARD1] == "" && STUDENT_REC[STUDENT_AWARD2] == "" && STUDENT_REC[STUDENT_AWARD3] == "" && STUDENT_REC[STUDENT_AWARD4] == "" && STUDENT_REC[STUDENT_AWARD5] == "" && STUDENT_REC[STUDENT_AWARD6] == "" && STUDENT_REC[STUDENT_AWARD7] == "" && STUDENT_REC[STUDENT_AWARD8] == "" && STUDENT_REC[STUDENT_AWARD9] == "" && STUDENT_REC[STUDENT_AWARD10] == "" && STUDENT_REC[STUDENT_AWARD11] == "" && STUDENT_REC[STUDENT_AWARD12] == "") {
MAT(ref TEMP_REC, "");
FIELD_NO = 1;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(MAIN_KEY, ST_JUST));
FIELD_NO = 2;
}// CASE
else if (OTHERWISE) {
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
L0300();
/*  Display data */
L0050();
}
// END CASE
if (INTERACT == VALID_DATA) {
do {
do {
if (INTERACT != LIMIT) { L0060(); }
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
// BEGIN CASE
// CASE
if (NOT(AMENDING) && VALUE == "") {
/*  Finished when first null award entered */
INTERACT = LIMIT;
AMENDING = TRUE;
L0300();
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
else if (INTERACT == LIMIT || AMENDING) {
L0050();
}// CASE
else if (FIELD_NO == MAX_FIELDS) {
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
INPUT_LINE = "      Enter Field no, 'P1', <ret> to scroll, 'D'elete or 'F'inish ";
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
/*  DJA 17.12.03 */
FL714 = new FL714(ref STUDENT_REC, ref REDISPLAY, ref COURSE_OCCURENCE);
/* !*           PROG.MESS<1> = 1 */
/* !*           INTERACT = FINISH */
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "F") {
PROG_MESS[1] = "";
INTERACT = FINISH;
}// CASE
else if (ANS == "D") {
/*  Validate that their balance is zero and that they are not enrolled on */
/*  any courses */
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_BALANCE] + 0 != 0) {
nrf0 = 1;
nrf1 = OCONV(STUDENT_REC[STUDENT_BALANCE], "MD2");
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (STUDENT_REC[STUDENT_DETAIL_IDS] != "") {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "    Are you sure you wish to delete this student? (Y/N) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 4);
PRINT(AT(2, 21) + SPACE(74));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "N") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "Y") {
DELETE(FL_STUDENTS, MAIN_KEY);
INTERACT = FINISH;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
if (INTERACT == FINISH) {
/*  Deletion done */
INTERACT = EXIT;
} else {
/*  Reprompt for action */
INTERACT = INVALID_DATA;
}
}
// END CASE
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
PROG_MESS[1] = ANS.Substring(2, 1);
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
PRINT(STR(".", ST_LENGTH));
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
else if (ANS == GO_BACK && FIELD_NO == 2) {
INTERACT = INVALID_DATA;
/*  Don't allow access to key field */
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
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1) {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1100(); break;
case 3: L1100(); break;
case 4: L1100(); break;
case 5: L1100(); break;
case 6: L1100(); break;
case 7: L1100(); break;
case 8: L1100(); break;
case 9: L1100(); break;
case 10: L1100(); break;
case 11: L1100(); break;
case 12: L1100(); break;
case 13: L1100(); break;
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
/*  Display the course history window */
COURSE_OCCURENCE = DCOUNT(STUDENT_REC[STUDENT_DETAIL_IDS], VM);
FL714 = new FL714(ref STUDENT_REC, ref REDISPLAY, ref COURSE_OCCURENCE);
REDISPLAY = "";
/*  Not relevant here */
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
/* !*     CALL FL714( MAT STUDENT.REC, REDISPLAY, COURSE.OCCURENCE ) */
REDISPLAY = "";
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1000() {
/*   STUDENT Code Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1100() {
/*   Award Validation Routine */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
FL780 = new FL780(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY);
if (INTERACT != EXIT) {
ANS = RETURNED_ANS;
} else {
INTERACT = INVALID_DATA;
}
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
/* !*     CALL FL714(MAT STUDENT.REC, REDISPLAY, COURSE.OCCURENCE) */
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (INTERACT != INVALID_DATA) {
if (MATREAD(ref AWARD_REC, FL_COURSE_AWARDS, ANS)) {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = STUDENT_REC[STUDENT_AWARD1];
TEMP_REC[2] = STUDENT_REC[STUDENT_AWARD2];
TEMP_REC[3] = STUDENT_REC[STUDENT_AWARD3];
TEMP_REC[4] = STUDENT_REC[STUDENT_AWARD4];
TEMP_REC[5] = STUDENT_REC[STUDENT_AWARD5];
TEMP_REC[6] = STUDENT_REC[STUDENT_AWARD6];
TEMP_REC[7] = STUDENT_REC[STUDENT_AWARD7];
TEMP_REC[8] = STUDENT_REC[STUDENT_AWARD8];
TEMP_REC[9] = STUDENT_REC[STUDENT_AWARD9];
TEMP_REC[10] = STUDENT_REC[STUDENT_AWARD10];
TEMP_REC[11] = STUDENT_REC[STUDENT_AWARD11];
TEMP_REC[12] = STUDENT_REC[STUDENT_AWARD12];
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
STUDENT_REC[STUDENT_AWARD1] = TEMP_REC[1];
STUDENT_REC[STUDENT_AWARD2] = TEMP_REC[2];
STUDENT_REC[STUDENT_AWARD3] = TEMP_REC[3];
STUDENT_REC[STUDENT_AWARD4] = TEMP_REC[4];
STUDENT_REC[STUDENT_AWARD5] = TEMP_REC[5];
STUDENT_REC[STUDENT_AWARD6] = TEMP_REC[6];
STUDENT_REC[STUDENT_AWARD7] = TEMP_REC[7];
STUDENT_REC[STUDENT_AWARD8] = TEMP_REC[8];
STUDENT_REC[STUDENT_AWARD9] = TEMP_REC[9];
STUDENT_REC[STUDENT_AWARD10] = TEMP_REC[10];
STUDENT_REC[STUDENT_AWARD11] = TEMP_REC[11];
STUDENT_REC[STUDENT_AWARD12] = TEMP_REC[12];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
