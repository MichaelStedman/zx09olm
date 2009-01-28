//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL749 : UvBase
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
readonly UvVar AMOUNT_DUE = 1;
readonly UvVar PLAN_TOTAL = 2;
readonly UvVar START_DATE = 3;
readonly UvVar NUMBER_OF_INSTALMENTS = 4;
readonly UvVar VALUE_OF_INSTALMENTS = 5;
readonly UvVar FREQUENCY = 6;
readonly UvVar DATE_TABLE = 7;
readonly UvVar AMOUNT_TABLE = 8;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] TEMP_REC = new UvVar[20];
#endregion
#region Variables
UvVar STUDENT_ID = "";
UvVar DETAILS_ID = "";
UvVar RECALC = "";
UvVar DISPLAY_PLAN = "";
UvVar UNPAID_FEE = "";
UvVar INST_PLAN_TOTAL = "";
UvVar INST_FIRST_DUE = "";
UvVar INST_NUMBER = "";
UvVar INST_VALUE = "";
UvVar INST_FREQUENCY = "";
UvVar INST_DATES = "";
UvVar INST_AMOUNTS = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar TODAYS_DATE = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar AM = "";
UvVar VM = "";
UvVar SKIP_KEY = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_PARAMS = "";
UvVar COURSE_PARAMS = "";
UvVar INFLATE_FIRST = "";
UvVar INSTALMENT_NO = "";
UvVar PREVIOUS_NO_INSTALMENTS = "";
UvVar CLEAR_OLD_DISPLAY = "";
UvVar FIELDS_TO_DISPLAY = "";
UvVar MAX_FIELDS = "";
UvVar ALL_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar DISP_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
FL006 FL006;
UvVar LENGTH_OF_INPUT = "";
FL019 FL019;
UvVar ANS = "";
FL750 FL750;
UvVar CONV_ANS = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar MAIN_KEY = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
FL049 FL049;
UvVar ORIGINAL_VALUE = "";
UvVar ST_MANDATORY = "";
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar PROMPT_NO = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar ST_DISPLAY = "";
UvVar I = "";
UvVar SIGNIFICANT_FIELD = "";
UvVar POS = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar LAST_DISPLAY_FIELD = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar CURRENT_INSTALMENT = "";
UvVar DATE_COLUMN = "";
UvVar AMOUNT_COLUMN = "";
UvVar SCREEN_ROW = "";
UvVar AMEND_NO = "";
UvVar AMEND_STRING = "";
UvVar ORIGINAL_START_DATE = "";
UvVar TEMP_NO_OF_INSTALMENTS = "";
UvVar PAYMENT = "";
UvVar OTHER_INST = "";
UvVar FIRST_INST = "";
UvVar SINGLE_INSERTION = "";
UvVar DUE_DAY = "";
UvVar MVC = "";
UvVar ORIGINAL_PLAN_TOTAL = "";
UvVar INTERVAL_UNIT = "";
UvVar CONV_LAST_DATE = "";
UvVar LAST_MM = "";
UvVar LAST_YYYY = "";
UvVar INTERVAL = "";
UvVar CONV_START_DATE = "";
UvVar NEXT_MM = "";
UvVar NEXT_YYYY = "";
UvVar TEST_COUNT = "";
UvVar NEXT_DATE = "";
UvVar NO_VALUES = "";
UvVar LAST_VALUE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL749(ref UvVar STUDENT_ID, ref UvVar DETAILS_ID, ref UvVar[] STUDENT_REC, ref UvVar RECALC, ref UvVar DISPLAY_PLAN, ref UvVar UNPAID_FEE, ref UvVar INST_PLAN_TOTAL, ref UvVar INST_FIRST_DUE, ref UvVar INST_NUMBER, ref UvVar INST_VALUE, ref UvVar INST_FREQUENCY, ref UvVar INST_DATES, ref UvVar INST_AMOUNTS, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.STUDENT_ID = STUDENT_ID;
this.DETAILS_ID = DETAILS_ID;
this.STUDENT_REC = STUDENT_REC;
this.RECALC = RECALC;
this.DISPLAY_PLAN = DISPLAY_PLAN;
this.UNPAID_FEE = UNPAID_FEE;
this.INST_PLAN_TOTAL = INST_PLAN_TOTAL;
this.INST_FIRST_DUE = INST_FIRST_DUE;
this.INST_NUMBER = INST_NUMBER;
this.INST_VALUE = INST_VALUE;
this.INST_FREQUENCY = INST_FREQUENCY;
this.INST_DATES = INST_DATES;
this.INST_AMOUNTS = INST_AMOUNTS;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
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
/*     MAINTAIN INSTALMENT PROFILES */
PROMPT("");
SKIP_KEY = ">";
INTERACT = VALID_DATA;
PROGRAM = "FL749";
SCREEN_CODE = PROGRAM;
MAT(ref TEMP_REC, "");
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
if (COURSE_PARAMS[4, 1] == "Y") {
INFLATE_FIRST = TRUE;
} else {
INFLATE_FIRST = FALSE;
}
/*  Define data fields */
/* *   AMOUNT.DUE = INST.PLAN.TOTAL */
TEMP_REC[AMOUNT_DUE] = UNPAID_FEE;
TEMP_REC[START_DATE] = INST_FIRST_DUE;
TEMP_REC[FREQUENCY] = INST_FREQUENCY;
TEMP_REC[NUMBER_OF_INSTALMENTS] = INST_NUMBER;
TEMP_REC[VALUE_OF_INSTALMENTS] = INST_VALUE;
TEMP_REC[PLAN_TOTAL] = INST_PLAN_TOTAL;
if (RECALC == TRUE) {
/*  Recalculate plan with information passed */
L4000();
/*  Recalculate plan */
} else {
TEMP_REC[DATE_TABLE] = INST_DATES;
TEMP_REC[AMOUNT_TABLE] = INST_AMOUNTS;
/*  Display an existing plan */
INSTALMENT_NO = 1;
PREVIOUS_NO_INSTALMENTS = 1;
CLEAR_OLD_DISPLAY = FALSE;
}
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
FIELDS_TO_DISPLAY = "";
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
if (DISPLAY_PLAN == TRUE) {
CLEAR_OLD_DISPLAY = TRUE;
PREVIOUS_NO_INSTALMENTS = 42;
/*  Used when clearing revised plans */
do {
INTERACT = VALID_DATA;
L0100();
if (TEMP_REC[START_DATE] == "") {
/*  This should not happen... */
AMENDING = FALSE;
FIELDS_TO_DISPLAY = 1 + AM + 2 + AM + 3 + AM + 4 + AM + 5 + AM + 6;
TEMP_REC[PLAN_TOTAL] = TEMP_REC[AMOUNT_DUE];
L0300();
} else {
FIELDS_TO_DISPLAY = "";
L0300();
AMENDING = TRUE;
INSTALMENT_NO = 1;
CLEAR_OLD_DISPLAY = FALSE;
L3000();
}
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
}
if (INTERACT == EXIT || INTERACT == FINISH) break;
} while (true);
} else {
INTERACT = FINISH;
}
/*  Update instalment variables for return to calling program */
if (INTERACT != EXIT) {
INST_PLAN_TOTAL = TEMP_REC[PLAN_TOTAL];
INST_FIRST_DUE = TEMP_REC[START_DATE];
INST_NUMBER = TEMP_REC[NUMBER_OF_INSTALMENTS];
INST_VALUE = TEMP_REC[VALUE_OF_INSTALMENTS];
INST_FREQUENCY = TEMP_REC[FREQUENCY];
INST_DATES = TEMP_REC[DATE_TABLE];
INST_AMOUNTS = TEMP_REC[AMOUNT_TABLE];
/* *     IF PLAN.TOTAL # AMOUNT.DUE THEN */
/* *       CALL FL006(PROGRAM,25,INIT) */
/* *     END */
}
if (DISPLAY_PLAN == TRUE) { REDISPLAY = 1; }
return;
/* ************************************* */
}
void L0050() {
/*   Enter Amendment Field Number  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21));
PRINT("Field no, 'F' to Finish, 'P'rint, 'Tn' to Terminate " + SPACE(8) + AT(60, 21));
LENGTH_OF_INPUT = 4;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "P") {
/*  Print instalment plan */
nrf0 = TEMP_REC[DATE_TABLE];
nrf1 = TEMP_REC[AMOUNT_TABLE];
FL750 = new FL750(ref STUDENT_ID, ref DETAILS_ID, ref STUDENT_REC, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "F") {
/*   Check Plan Total does not exceed Amount Due */
/* *       IF PLAN.TOTAL > AMOUNT.DUE THEN */
/* *         CALL FL006(PROGRAM,17,INIT) */
/* *         INTERACT = INVALID.DATA */
/* *       END ELSE */
INTERACT = FINISH;
/* *       END */
/* !*    CASE ANS = "R" */
/* !*      GOSUB 4000   ; * Recalculate plan */
/* !*      CLEAR.OLD.DISPLAY = TRUE */
/* !*      INSTALMENT.NO     = 1 */
/* !*      GOSUB 3000   ; * Redisplay plan */
}// CASE
else if (ANS.Substring(1, 1) == "T") {
CONV_ANS = TRIM(ANS.Substring(2, 99));
if (NOT(MATCH(CONV_ANS,"1N") || MATCH(CONV_ANS,"2N"))) {
nrf0 = 12;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INSTALMENT_NO = CONV_ANS - 5;
// BEGIN CASE
// CASE
if (INSTALMENT_NO < 1) {
nrf0 = 14;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (TEMP_REC[DATE_TABLE][1, INSTALMENT_NO] == "") {
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
L6000();
/*  Terminate plan */
}
// END CASE
}
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 6 && ANS <= 47) {
/*  Amend an instalment amount */
INSTALMENT_NO = ANS - 5;
if (TEMP_REC[AMOUNT_TABLE][1, INSTALMENT_NO] == "") {
if (INSTALMENT_NO == 1) {
L5500();
/*  Add a new date field */
} else {
if (TEMP_REC[DATE_TABLE][1, INSTALMENT_NO - 1] != "") {
L5500();
/*  Add a new date field */
} else {
nrf0 = 16;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
if (TEMP_REC[DATE_TABLE][1, INSTALMENT_NO] == "") {
INTERACT = INVALID_DATA;
} else {
L5000();
/*  Amend an instalment amount field */
}
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
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = TEMP_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL - 1, ST_ROW) + NRM_VID);
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
FL019 = new FL019(ref ST_LENGTH, ref ANS);
if (!(ANS == COMMON.HELP)) break;
FL049 = new FL049(ref PROGRAM, ref FIELD_NO, ref REDISPLAY);
if (REDISPLAY) {
L0100();
L0300();
REDISPLAY = "";
}
} while (true);
ORIGINAL_VALUE = VALUE;
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK && AMENDING == FALSE && FIELD_NO == 1) {
NULL();
}// CASE
else if (ANS == COMMON.BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == SKIP_KEY && ST_MANDATORY != "") {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = INIT;
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (ANS == SKIP_KEY && ST_ATT != 0) {
INTERACT = VALID_DATA;
do {
if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
FIELD_NO = FIELD_NO - 1;
}// CASE
else if (ANS == COMMON.CLR) {
if (ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
} else {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = INIT;
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
nrf0 = "STANDARD";
nrf1 = 1;
nrf2 = INIT;
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1200(); break;
case 2: L1300(); break;
case 3: L1400(); break;
case 4: L1500(); break;
case 5: L1600(); break;
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
TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
}
if (INTERACT == VALID_DATA && VALUE != ORIGINAL_VALUE) {
/*  Auto-regenerate the profile */
L4000();
CLEAR_OLD_DISPLAY = TRUE;
INSTALMENT_NO = 1;
L3000();
}
return;
/* ******************************* */
}
void L0100() {
/*  Display Screen Format  * */
/* ******************************* */
PROMPT_NO = 1;
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
for(PRINT_LINE = 22; PRINT_LINE <= 20; PRINT_LINE += -1) {
PRINT(AT(79, PRINT_LINE) + NRM_VID);
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(76));
}
/*  Position cursor to prevent Wyse taking a chunk out of footing bar */
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
ST_DISPLAY = FIELD_DATA[1, 14];
if (ST_ICONVERSION == "") { ST_ICONVERSION = ST_CONVERSION; }
return;
}
void L0300() {
/*   Display Item Contents */
I = 1;
do {
if (I > ALL_FIELDS) break;
SIGNIFICANT_FIELD = TRUE;
if (FIELDS_TO_DISPLAY != "") {
if (!LOCATE(I, FIELDS_TO_DISPLAY, 0, 0, 1, ref POS, "AR")) { SIGNIFICANT_FIELD = FALSE; }
}
if (SIGNIFICANT_FIELD) {
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
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
/* !*           IF I = 5 THEN */
/* !** */
/* !** Show full frequency description */
/* !** */
/* !*             PRINT @(DISP.COL+3,DISP.ROW):EOL: */
/* !*             BEGIN CASE */
/* !*             CASE TEMP.REC(DISP.ATT) = "W" */
/* !*               PRINT "Weekly" */
/* !*             CASE TEMP.REC(DISP.ATT) = "F" */
/* !*               PRINT "Fortnightly" */
/* !*             CASE TEMP.REC(DISP.ATT) = "M" */
/* !*               PRINT "Monthly" */
/* !*             CASE TEMP.REC(DISP.ATT) = "Q" */
/* !*               PRINT "Quarterly" */
/* !*             END CASE */
/* !*           END */
}
}
}
I = I + 1;
} while (true);
LAST_DISPLAY_FIELD = "";
return;
/*   Validation Routines */
L1000:;
/*   Dummy Validation Routine */
INTERACT = VALID_DATA;
return;
L1100:;
/*   Dummy Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*   Plan Total Validation Routine */
CONV_ANS = ICONV(ANS, "MD2");
// BEGIN CASE
// CASE
if (NOT(NUM(ANS))) {
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS == "") {
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS < 0) {
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
/* *       IF CONV.ANS > AMOUNT.DUE THEN */
/* *         CALL FL006(PROGRAM,40,INIT) */
/* *         INTERACT = INVALID.DATA */
/* *       END ELSE */
INTERACT = VALID_DATA;
L1450();
if (CONV_ANS == 0) {
/*  Instalments 'initialised' */
L1450();
L1550();
TEMP_REC[DATE_TABLE] = "";
TEMP_REC[AMOUNT_TABLE] = "";
CLEAR_OLD_DISPLAY = TRUE;
PREVIOUS_NO_INSTALMENTS = 42;
L3000();
}
/* *       END */
}
// END CASE
return;
}
void L1250() {
/*   Remove the contents of the 'plan total' field */
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
FIELD_NO = 1;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
TEMP_REC[PLAN_TOTAL] = 0;
PRINT(AT(ST_COL, ST_ROW) + FORMAT("0.00", ST_JUST));
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
return;
}
void L1300() {
/*   Start Date Validation Routine */
CONV_ANS = ICONV(ANS, "D");
// BEGIN CASE
// CASE
if (CONV_ANS == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
return;
}
void L1400() {
/*   No. Instalments Validation Routine */
if (MATCH(ANS,"1N") || MATCH(ANS,"2N") || ANS == "") {
// BEGIN CASE
// CASE
if (ANS > 42) {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS >= 0 || ANS == "") {
TEMP_REC[NUMBER_OF_INSTALMENTS] = ANS;
INTERACT = VALID_DATA;
L1450();
if (ANS == 0) {
L1250();
/*  Clear plan total */
TEMP_REC[DATE_TABLE] = "";
TEMP_REC[AMOUNT_TABLE] = "";
CLEAR_OLD_DISPLAY = TRUE;
PREVIOUS_NO_INSTALMENTS = 42;
L3000();
}
}// CASE
else if (OTHERWISE) {
nrf0 = 6;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
// END CASE
} else {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
}
void L1450() {
/*   Remove the contents of the 'value' field */
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
FIELD_NO = 4;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
TEMP_REC[VALUE_OF_INSTALMENTS] = "";
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[VALUE_OF_INSTALMENTS], ST_JUST));
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
return;
}
void L1500() {
/*    Instalment Value Validation Routine */
CONV_ANS = ICONV(ANS, "MD2");
// BEGIN CASE
// CASE
if (NOT(NUM(ANS))) {
nrf0 = 4;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS < 0 && ANS != "") {
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (CONV_ANS > TEMP_REC[PLAN_TOTAL]) {
nrf0 = 19;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
/* *       IF NUMBER.OF.INSTALMENTS # '' THEN */
/* *         IF NUMBER.OF.INSTALMENTS * CONV.ANS > AMOUNT.DUE THEN */
/* *           CALL FL006(PROGRAM,19,INIT) */
/* *           INTERACT = INVALID.DATA */
/* *         END ELSE */
INTERACT = VALID_DATA;
TEMP_REC[VALUE_OF_INSTALMENTS] = CONV_ANS;
if (ANS != "") { L1550(); }
/* *         END */
/* *       END ELSE */
/* *         IF NUMBER.OF.INSTALMENTS = '' AND ANS = '' THEN */
/* *           CALL FL006(PROGRAM,20,INIT) */
/* *           INTERACT = INVALID.DATA */
/* *         END ELSE */
/* *           VALUE.OF.INSTALMENTS = CONV.ANS */
/* *           INTERACT = VALID.DATA */
/* *           GOSUB 1550 */
/* *         END */
/* *       END */
}
// END CASE
if (AMENDING == FALSE && INTERACT == VALID_DATA) {
/*  As this is a new plan, calculate and display the details */
L4000();
/*  Calculate the plan */
INSTALMENT_NO = 1;
CLEAR_OLD_DISPLAY = FALSE;
L3000();
/*  Display the plan */
}
return;
}
void L1550() {
/*   Remove the contents of the 'number' field */
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
FIELD_NO = 3;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
TEMP_REC[NUMBER_OF_INSTALMENTS] = "";
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[NUMBER_OF_INSTALMENTS], ST_JUST));
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
return;
}
void L1600() {
/*   Frequency Validation Routine */
if (INDEX("WFMQ", ANS, 1) && ANS != "") {
INTERACT = VALID_DATA;
/* !*      PRINT @(ST.COL+3,ST.ROW):EOL: */
/* !*      BEGIN CASE */
/* !*      CASE ANS = "W" */
/* !*        PRINT "Weekly" */
/* !*      CASE ANS = "F" */
/* !*        PRINT "Fortnightly" */
/* !*      CASE ANS = "M" */
/* !*        PRINT "Monthly" */
/* !*      CASE ANS = "Q" */
/* !*        PRINT "Quarterly" */
/* !*      END CASE */
} else {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
}
void L3000() {
/*  Routine to display all instalments in a plan */
CURRENT_INSTALMENT = INSTALMENT_NO;
do {
if (CURRENT_INSTALMENT > 42) break;
/*  Determine screen row and column numbers */
// BEGIN CASE
// CASE
if (CURRENT_INSTALMENT <= 14) {
DATE_COLUMN = 2;
AMOUNT_COLUMN = 19;
SCREEN_ROW = CURRENT_INSTALMENT + 5;
}// CASE
else if (CURRENT_INSTALMENT <= 28) {
DATE_COLUMN = 28;
AMOUNT_COLUMN = 45;
SCREEN_ROW = CURRENT_INSTALMENT - 9;
}// CASE
else if (OTHERWISE) {
DATE_COLUMN = 54;
AMOUNT_COLUMN = 71;
SCREEN_ROW = CURRENT_INSTALMENT - 23;
}
// END CASE
if (TEMP_REC[DATE_TABLE][1, CURRENT_INSTALMENT] != "" && TEMP_REC[AMOUNT_TABLE][1, CURRENT_INSTALMENT] != "") {
PRINT(AT(DATE_COLUMN + 11, SCREEN_ROW) + NRM_VID + " ");
PRINT(AT(DATE_COLUMN - 1, SCREEN_ROW) + DIM_REV_UND_VID);
PRINT(AT(DATE_COLUMN, SCREEN_ROW) + OCONV(TEMP_REC[DATE_TABLE][1, CURRENT_INSTALMENT], "D"));
PRINT(NRM_VID);
AMEND_NO = CURRENT_INSTALMENT + 5;
AMEND_STRING = AMEND_NO + ")";
PRINT(FORMAT(AMEND_STRING, "R#4"));
PRINT(AT(AMOUNT_COLUMN, SCREEN_ROW) + FORMAT(OCONV(TEMP_REC[AMOUNT_TABLE][1, CURRENT_INSTALMENT], "MD2"), "R#7"));
} else {
if ((CLEAR_OLD_DISPLAY == TRUE && CURRENT_INSTALMENT <= PREVIOUS_NO_INSTALMENTS)) {
PRINT(AT(DATE_COLUMN - 1, SCREEN_ROW) + SPACE(26));
}
}
CURRENT_INSTALMENT = CURRENT_INSTALMENT + 1;
} while (true);
CLEAR_OLD_DISPLAY = TRUE;
return;
}
void L4000() {
/*   Calculate the plan based on user input */
PREVIOUS_NO_INSTALMENTS = DCOUNT(TEMP_REC[DATE_TABLE], VM);
ORIGINAL_START_DATE = TEMP_REC[START_DATE];
TEMP_REC[AMOUNT_TABLE] = "";
TEMP_REC[DATE_TABLE] = "";
TEMP_NO_OF_INSTALMENTS = TEMP_REC[NUMBER_OF_INSTALMENTS];
if (TEMP_NO_OF_INSTALMENTS + 0 == 0) {
if (TEMP_REC[VALUE_OF_INSTALMENTS] + 0 == 0) {
TEMP_NO_OF_INSTALMENTS = 1;
} else {
TEMP_NO_OF_INSTALMENTS = INT(TEMP_REC[PLAN_TOTAL] / TEMP_REC[VALUE_OF_INSTALMENTS]);
}
}
if (TEMP_REC[PLAN_TOTAL] + 0 > 0) {
if (TEMP_REC[VALUE_OF_INSTALMENTS] + 0 > 0) {
PAYMENT = TEMP_REC[VALUE_OF_INSTALMENTS];
} else {
PAYMENT = TEMP_REC[PLAN_TOTAL] / TEMP_NO_OF_INSTALMENTS;
}
OTHER_INST = INT(PAYMENT);
if (TEMP_REC[VALUE_OF_INSTALMENTS] > 0) {
FIRST_INST = TEMP_REC[PLAN_TOTAL] - (TEMP_NO_OF_INSTALMENTS * TEMP_REC[VALUE_OF_INSTALMENTS]);
if (FIRST_INST != "") {
FIRST_INST = FIRST_INST + PAYMENT;
}
} else {
FIRST_INST = OTHER_INST + (TEMP_NO_OF_INSTALMENTS * (PAYMENT - INT(PAYMENT)));
}
SINGLE_INSERTION = FALSE;
if (INT(TEMP_NO_OF_INSTALMENTS) != TEMP_REC[NUMBER_OF_INSTALMENTS]) {
TEMP_REC[NUMBER_OF_INSTALMENTS] = INT(TEMP_NO_OF_INSTALMENTS);
if (DISPLAY_PLAN == TRUE) {
OLD_FIELD_NO = FIELD_NO;
FIELD_NO = 3;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL - 1, ST_ROW) + NRM_VID + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[NUMBER_OF_INSTALMENTS], ST_JUST));
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = DATA_FIELDS[OLD_FIELD_NO];
L0200();
}
}
/*  Set parameters for determining due dates */
L7000();
DUE_DAY = OCONV(TEMP_REC[START_DATE], "D/").Substring(1, 2);
for(MVC = 1; MVC <= TEMP_REC[NUMBER_OF_INSTALMENTS]; MVC += 1) {
L8000();
}
}
if (TEMP_REC[DATE_TABLE][1, 1] == "") { TEMP_REC[START_DATE] = ORIGINAL_START_DATE; }
return;
}
void L5000() {
/*   Amend an instalment amount field */
/*  Determine screen row and column numbers */
// BEGIN CASE
// CASE
if (INSTALMENT_NO <= 14) {
AMOUNT_COLUMN = 19;
SCREEN_ROW = INSTALMENT_NO + 5;
}// CASE
else if (INSTALMENT_NO <= 28) {
AMOUNT_COLUMN = 45;
SCREEN_ROW = INSTALMENT_NO - 9;
}// CASE
else if (OTHERWISE) {
AMOUNT_COLUMN = 71;
SCREEN_ROW = INSTALMENT_NO - 23;
}
// END CASE
/*   Check if instalment is already due */
if (TEMP_REC[DATE_TABLE][1, INSTALMENT_NO] < TODAYS_DATE) {
nrf0 = 15;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
ORIGINAL_VALUE = TEMP_REC[AMOUNT_TABLE][1, INSTALMENT_NO];
INTERACT = INVALID_DATA;
do {
PRINT(AT(AMOUNT_COLUMN, SCREEN_ROW) + NRM_VID + SPACE(7) + AT(AMOUNT_COLUMN, SCREEN_ROW));
nrf0 = 7;
FL019 = new FL019(ref nrf0, ref ANS);
if (ANS == COMMON.CLR) { ANS = 0; }
CONV_ANS = ICONV(ANS, "MD2");
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PRINT(AT(AMOUNT_COLUMN, SCREEN_ROW) + FORMAT(OCONV(ORIGINAL_VALUE, "MD2"), "R#7"));
}// CASE
else if (ANS == "") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == SKIP_KEY) {
ANS = "";
INTERACT = VALID_DATA;
}// CASE
else if (NOT(NUM(ANS))) {
nrf0 = 10;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS < 0) {
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
if (INTERACT == VALID_DATA) {
if (ANS == "") {
PRINT(AT(AMOUNT_COLUMN, SCREEN_ROW) + FORMAT(OCONV(ORIGINAL_VALUE, "MD2"), "R#7"));
} else {
ORIGINAL_PLAN_TOTAL = TEMP_REC[PLAN_TOTAL];
TEMP_REC[PLAN_TOTAL] = TEMP_REC[PLAN_TOTAL] - ORIGINAL_VALUE + CONV_ANS;
TEMP_REC[AMOUNT_TABLE][1, INSTALMENT_NO] = CONV_ANS;
PRINT(AT(AMOUNT_COLUMN, SCREEN_ROW) + FORMAT(OCONV(CONV_ANS, "MD2"), "R#7"));
if (TEMP_REC[PLAN_TOTAL] != ORIGINAL_PLAN_TOTAL) {
FIELD_NO = 2;
FIELD_DATA = DISP_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[PLAN_TOTAL], "MD2"), ST_JUST));
}
}
}
/*  Return to footing prompt */
INTERACT = INVALID_DATA;
return;
}
void L5500() {
/*   Generate a new 'instalment due' field */
SINGLE_INSERTION = TRUE;
MVC = INSTALMENT_NO;
L7000();
/*  Set up params for determining due dates */
DUE_DAY = OCONV(TEMP_REC[START_DATE], "D/").Substring(1, 2);
if (INTERVAL_UNIT == "M" && MVC > 1) {
/*  Set up 'last due date' variables */
CONV_LAST_DATE = OCONV(TEMP_REC[DATE_TABLE][1, MVC - 1], "D/");
LAST_MM = CONV_LAST_DATE.Substring(4, 2);
LAST_YYYY = CONV_LAST_DATE.Substring(7, 4);
}
L8000();
/*  Update the instalment tables */
CLEAR_OLD_DISPLAY = FALSE;
L3000();
/*  Display new date */
/*  Update and redisplay number of instalments */
TEMP_REC[NUMBER_OF_INSTALMENTS] = TEMP_REC[NUMBER_OF_INSTALMENTS] + 1;
FIELD_NO = 4;
FIELD_DATA = DISP_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[NUMBER_OF_INSTALMENTS], ST_JUST));
return;
}
void L6000() {
/*   Terminate the plan from a given point */
PREVIOUS_NO_INSTALMENTS = DCOUNT(TEMP_REC[DATE_TABLE], VM);
ORIGINAL_START_DATE = TEMP_REC[START_DATE];
do {
if (TEMP_REC[DATE_TABLE][1, INSTALMENT_NO] == "") break;
TEMP_REC[PLAN_TOTAL] = TEMP_REC[PLAN_TOTAL] - TEMP_REC[AMOUNT_TABLE][1, INSTALMENT_NO];
TEMP_REC[NUMBER_OF_INSTALMENTS] = TEMP_REC[NUMBER_OF_INSTALMENTS] - 1;
TEMP_REC[AMOUNT_TABLE] = DELETE(TEMP_REC[AMOUNT_TABLE], 1, INSTALMENT_NO, 0);
TEMP_REC[DATE_TABLE] = DELETE(TEMP_REC[DATE_TABLE], 1, INSTALMENT_NO, 0);
} while (true);
/*  Redisplay plan total */
for(FIELD_NO = 2; FIELD_NO <= 4; FIELD_NO += 2) {
FIELD_DATA = DISP_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID);
if (ST_ICONVERSION == "") {
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
} else {
PRINT(AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], "MD2"), ST_JUST));
}
}
CLEAR_OLD_DISPLAY = TRUE;
L3000();
/*  Display plan from point of termination */
if (TEMP_REC[DATE_TABLE][1, 1] == "") {
TEMP_REC[START_DATE] = ORIGINAL_START_DATE;
}
return;
}
void L7000() {
/*   Set up params for determining due dates */
// BEGIN CASE
// CASE
if (TEMP_REC[FREQUENCY] == "M") {
INTERVAL_UNIT = "M";
INTERVAL = 1;
}// CASE
else if (TEMP_REC[FREQUENCY] == "Q") {
INTERVAL_UNIT = "M";
INTERVAL = 3;
}// CASE
else if (TEMP_REC[FREQUENCY] == "F") {
INTERVAL_UNIT = "W";
INTERVAL = 2;
}// CASE
else if (TEMP_REC[FREQUENCY] == "W") {
INTERVAL_UNIT = "W";
INTERVAL = 1;
}
// END CASE
return;
}
void L8000() {
/*   Update one multivalue of the date/amount tables */
if (MVC == 1) {
TEMP_REC[DATE_TABLE][1, 1] = TEMP_REC[START_DATE];
CONV_START_DATE = OCONV(TEMP_REC[START_DATE], "D/");
LAST_MM = CONV_START_DATE.Substring(4, 2);
LAST_YYYY = CONV_START_DATE.Substring(7, 4);
}
if (MVC == TEMP_REC[NUMBER_OF_INSTALMENTS]) {
if (SINGLE_INSERTION == FALSE) {
TEMP_REC[AMOUNT_TABLE][1, MVC] = FIRST_INST;
} else {
TEMP_REC[AMOUNT_TABLE][1, MVC] = 0;
}
} else {
if (SINGLE_INSERTION == FALSE) {
TEMP_REC[AMOUNT_TABLE][1, MVC] = OTHER_INST;
} else {
TEMP_REC[AMOUNT_TABLE][1, MVC] = 0;
}
}
// BEGIN CASE
// CASE
if (INTERVAL_UNIT == "W") {
TEMP_REC[DATE_TABLE][1, MVC] = TEMP_REC[START_DATE] + (7 * (MVC - 1) * INTERVAL);
}// CASE
else if (INTERVAL_UNIT == "M") {
NEXT_MM = LAST_MM + INTERVAL;
if (NEXT_MM <= 12) {
NEXT_YYYY = LAST_YYYY;
} else {
NEXT_MM = NEXT_MM - 12;
NEXT_YYYY = LAST_YYYY + 1;
}
LAST_MM = NEXT_MM;
LAST_YYYY = NEXT_YYYY;
TEST_COUNT = 0;
do {
NEXT_DATE = (DUE_DAY - TEST_COUNT) + "/" + NEXT_MM + "/" + NEXT_YYYY;
NEXT_DATE = ICONV(NEXT_DATE, "D");
if (NEXT_DATE > 0) break;
TEST_COUNT = TEST_COUNT + 1;
} while (true);
TEMP_REC[DATE_TABLE][1, MVC] = NEXT_DATE;
}
// END CASE
/*  By default, the last instalment is inflated by any odd, rounding amount. */
/*  If the appropriate parameter has been set, swap the first and last amts. */
if (SINGLE_INSERTION == FALSE) {
if (INFLATE_FIRST) {
NO_VALUES = DCOUNT(TEMP_REC[DATE_TABLE], VM);
if (NO_VALUES > 1) {
LAST_VALUE = TEMP_REC[AMOUNT_TABLE][1, NO_VALUES];
TEMP_REC[AMOUNT_TABLE][1, NO_VALUES] = TEMP_REC[AMOUNT_TABLE][1, 1];
TEMP_REC[AMOUNT_TABLE][1, 1] = LAST_VALUE;
}
}
}
return;
/* ****************** */
/*   End of Program * */
/* ****************** */
}
}
}
