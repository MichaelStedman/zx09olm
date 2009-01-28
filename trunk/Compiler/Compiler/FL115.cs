//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL115 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] PRNT_ASS_REC = new UvVar[10];
#endregion
#region Variables
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar TILL_NUMBER = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar TRANS_LOG_REC = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_PRINTER_ASSIGNMENTS = "";
UvVar PR_DEFAULTS = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar KEY_COL = "";
UvVar KEY_ROW = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
FLTX2 FLTX2;
UvVar ANS = "";
UvVar REPLY = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
FL302 FL302;
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar ST_ATT_MV = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar NEW_ALLOWED = "";
FL111 FL111;
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar MACHINE_NAME = "";
UvVar PRINTER_NAME = "";
UvVar ASSIGN_CMD = "";
UvVar XX = "";
UvVar YY = "";
UvVar WAIT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL115() {
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
/*  NEW PRINTER ASSIGNMENTS(ENHANCED BY LEE & RT) */
PROMPT("");
PROGRAM = "FL115";
SCREEN_CODE = PROGRAM;
/*   DEFINE FILES USED            * */
if (!(OPEN("FL.PRINTER.ASSIGNMENTS", out FL_PRINTER_ASSIGNMENTS))) {
STOP(201, "FL.PRINTER.ASSIGNMENTS");
}
if (!(READ(ref PR_DEFAULTS, FL_PRINTER_ASSIGNMENTS, "DEFAULTS"))) {
PR_DEFAULTS = "SETPTR ,,,,,,AT ";
PR_DEFAULTS[2] = ",BRIEF,NOFMT";
WRITE(PR_DEFAULTS, FL_PRINTER_ASSIGNMENTS, "DEFAULTS");
}
/*  DIMENSION RECORDS * */
/*   GET SCREEN DEFINITION ITEM       * */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
/*   EXTRACT DATA INPUT FIELDS      * */
MAX_FIELDS = 0;
SCREEN_LINES = 0;
FIRST_FIELD = 0;
DATA_FIELDS = INIT;
MAT(ref PRNT_ASS_REC, INIT);
do {
LINE = SC_POS[SCREEN_LINES + 1];
if (LINE[1, 5] == 0) {
KEY_COL = LINE[1, 1] + 1 + LEN(LINE[1, 3]);
KEY_ROW = LINE[1, 2];
}
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
/*   MAIN PROCESSING SECTION          * */
do {
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
MAT(ref PRNT_ASS_REC, INIT);
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
if (FIELD_NO == 3) { AMENDING = TRUE; }
} while (true);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (FIELD_NO == MAX_FIELDS) {
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
L7000();
MATWRITE(PRNT_ASS_REC, FL_PRINTER_ASSIGNMENTS, MAIN_KEY);
if (!READ(ref TRANS_LOG_REC, FL_PRINTER_ASSIGNMENTS, MAIN_KEY)) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.PRINTER.ASSIGNMENTS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MAIN_KEY);
}
}
if (INTERACT == EXIT) break;
} while (true);
return;
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 21) + "Enter Field No, 'DEL' to Delete or <RETURN> to finish          ");
PRINT(AT(56, 21));
INPUT(out ANS, 4);
if (LEN(ANS) > 3) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 3); }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "") {
INTERACT = FINISH;
}// CASE
else if (ANS == "DEL") {
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
/*            PRINT @(0,21): SCREEN.FOOT.FORE: SCREEN.FOOT.BACK: */
PRINT(AT(0, 21) + DIM_REV_VID);
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 21) + "Are you sure you want to delete this printer assignment (Y/N)?    ");
PRINT(AT(65, 21));
INPUT(out REPLY, 2);
if (LEN(REPLY) > 1) { PRINT(AT(-9) + " "); REPLY = REPLY.Substring(1, 1); }
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
if (REPLY == "Y") {
nrf0 = "D";nrf1 = "FL.PRINTER.ASSIGNMENTS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MAIN_KEY);
INTERACT = FINISH;
MAIN_KEY = "";
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
}
void L0060() {
/*   DATA ENTRY ROUTINE       * */
INTERACT = INVALID_DATA;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = PRNT_ASS_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL, ST_ROW) + SCREEN_DATA);
PRINT(AT(ST_COL + 1, ST_ROW));
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
if (ST_ATT == 0) {
FL302 = new FL302(ref ANS);
PRINT(AT(ST_COL + 1, ST_ROW) + SPACE(ST_LENGTH) + AT(ST_COL + 1, ST_ROW) + ANS);
}
if (ST_ATT == 0 && ANS == "") { ANS = COMMON.ABANDON; }
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == COMMON.BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.SKIP) {
do {
if (DATA_FIELDS[FIELD_NO, 10] != "" || FIELD_NO > MAX_FIELDS) break;
FIELD_NO = FIELD_NO + 1;
} while (true);
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY != "") {
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
PRINT("This Field is Mandatory ");
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
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
case 5: L1400(); break;
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
PRINT(AT(ST_COL, ST_ROW) + SCREEN_DATA);
PRINT(AT(ST_COL + 1, ST_ROW));
if (ST_CONVERSION != "") {
PRINT(FORMAT(OCONV(VALUE, ST_CONVERSION), ST_JUST));
} else {
PRINT(FORMAT(VALUE, ST_JUST));
}
if (ST_ATT == 0) {
MAIN_KEY = VALUE;
} else {
PRNT_ASS_REC[ST_ATT][1, ST_MV] = VALUE;
}
return;
}
void L0100() {
/*  DISPLAY SCREEN FORMAT  * */
DOTS_ONLY = 0;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
for(LINE = 22; LINE <= 20; LINE += -1) {
PRINT(AT(0, LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, LINE) + SPACE(SCREEN_WIDTH - 2));
}
PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
return;
}
void L0200() {
/*   EXTRACT FIELD DATA      * */
/*         ST.COL = FIELD.DATA<1,1>+2+LEN(FIELD.DATA<1,3>) */
ST_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
ST_ROW = FIELD_DATA[1, 2];
ST_LENGTH = FIELD_DATA[1, 4];
ST_ATT_MV = FIELD_DATA[1, 5];
ST_ATT = FIELD(ST_ATT_MV, ",", 1);
ST_MV = FIELD(ST_ATT_MV, ",", 2);
ST_JUST = FIELD_DATA[1, 8] + "#" + ST_LENGTH;
ST_CONVERSION = FIELD_DATA[1, 9];
ST_MANDATORY = FIELD_DATA[1, 10];
return;
}
void L0300() {
/*   DISPLAY ITEM CONTENTS */
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
if (DISP_ATT != 0) {
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
/*               DISP.COL = FIELD.DATA<1,1>+2+LEN(FIELD.DATA<1,3>) */
DISP_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW) + SCREEN_DATA);
PRINT(AT(DISP_COL + 1, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(PRNT_ASS_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(PRNT_ASS_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
}
}
return;
/*   VALIDATION ROUTINES  * */
}
void L1000() {
/*   Validation Routine */
if (ANS == COMMON.HELP) {
NEW_ALLOWED = TRUE;
nrf0 = "ABBREVIATIONS";
FL111 = new FL111(ref ANS, ref FL_PRINTER_ASSIGNMENTS, ref nrf0, ref NEW_ALLOWED);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
/*  DISPLAY SCREEN FORMAT */
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
/*  EXTRACT FIELD DATA */
PRINT(AT(KEY_COL, KEY_ROW) + ANS);
}
if ((ANS < 0 || ANS > 999) && ANS != "ALL") {
INTERACT = INVALID_DATA;
} else {
if (MATREAD(ref PRNT_ASS_REC, FL_PRINTER_ASSIGNMENTS, ANS)) {
MACHINE_NAME = PRNT_ASS_REC[1];
PRINTER_NAME = PRNT_ASS_REC[2];
PR_DEFAULTS[1] = PRNT_ASS_REC[3];
PR_DEFAULTS[2] = PRNT_ASS_REC[4];
AMENDING = TRUE;
INTERACT = VALID_DATA;
L0300();
} else {
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(0, 21) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
REPLY = "Y";
PRNT_ASS_REC[3] = PR_DEFAULTS[1];
PRNT_ASS_REC[4] = PR_DEFAULTS[2];
PRINT(AT(2, 21) + SPACE(SCREEN_WIDTH - 2));
if (REPLY != "Y") { INTERACT = INVALID_DATA; } else { INTERACT = VALID_DATA; }
L0300();
}
}
return;
}
void L1100() {
/*   Machine Name */
if (ANS != COMMON.HELP) { INTERACT = VALID_DATA; }
/* IF ANS # "" AND ANS[1,2] # "\\" THEN */
/*  ANS = "\\":ANS */
/* END */
MACHINE_NAME = ANS;
return;
}
void L1200() {
/*  SHARE PRINTER NAME */
INTERACT = VALID_DATA;
PRINTER_NAME = ANS;
return;
}
void L1300() {
/*  Setptr Prefix */
if (ANS != "") {
PR_DEFAULTS[1] = ANS;
}
INTERACT = VALID_DATA;
return;
}
void L1400() {
/*  Setptr Suffix */
if (ANS != "") {
PR_DEFAULTS[2] = ANS;
}
INTERACT = VALID_DATA;
return;
}
void L7000() {
ASSIGN_CMD = PR_DEFAULTS[1] + MACHINE_NAME + "\\" + PRINTER_NAME + PR_DEFAULTS[2];
PRINT(AT(10, 14) + REV_VID + "A test print is being sent to the printer you have ");
PRINT(AT(10, 15) + "specified, if this does not print you need to alter");
PRINT(AT(10, 16) + "one or other of the above parameters and try again ");
PRINT(AT(10, 17) + "Press <return>                                     ");
EXECUTE(ASSIGN_CMD, XX, string.Empty, string.Empty, YY);
EXECUTE("CP FL.TILL.NUMBERS ", string.Empty, string.Empty, string.Empty, string.Empty);
if (YY == 1) {
PRINTER_ON();
for(COMMON.X = 1; COMMON.X <= 10; COMMON.X += 1) {
PRINT();
}
PRINTCR("This is a test print from Till " + TILL_NUMBER);
PRINT();
PRINTCR("The command you have specified is : ");
PRINT();
PRINTCR(ASSIGN_CMD);
PRINT();
PRINTCR("and has worked.");
PRINT();
PRINTER_OFF();
PRINTER_CLOSE();
} else {
PRINTCR(AT(10, 18) + "These paramaters do NOT recognise either the MACHINE or");
PRINTCR(AT(10, 19) + "the PRINTER names, please try again!");
}
INPUT(out WAIT, 1);
return;
/*   END OF PROGRAM               * */
}
}
}
