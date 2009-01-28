//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL550 : UvBase
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
readonly UvVar TRANS_FILENAME = 1;
readonly UvVar TRANS_SELECT_LIST = 2;
readonly UvVar TRANS_PROCEDURE = 3;
readonly UvVar TRANS_DIRECTORY = 4;
readonly UvVar TRANS_DESTINATION = 5;
readonly UvVar TRANS_SEQ_OVER = 6;
readonly UvVar TRANS_TEMPLATE = 7;
readonly UvVar TRANS_DOCUMENT = 8;
readonly UvVar TRANS_MACRO = 9;
readonly UvVar TRANS_APPLICATION = 10;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MD = 58;
readonly UvVar FL_AD_HOC_ENQUIRIES = 101;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TRANS_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar PROGRAM = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar SCREEN_HEAD_BACK = "";
UvVar SCREEN_HEAD_FORE = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar AM = "";
UvVar TRANS_LOG_REC = "";
UvVar INTERACT = "";
UvVar EXECUTE_PROG = "";
UvVar SCREEN_CODE = "";
UvVar FILE_TYPE = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar MAX_FIELDS = "";
UvVar ALL_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar DISP_FIELDS = "";
UvVar LINE = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar MAIN_ID = "";
FLTX2 FLTX2;
FL306 FL306;
UvVar OK_TO_PROCEED = "";
UvVar PROC_REC = "";
UvVar NO_ATTS = "";
UvVar FINISHED = "";
UvVar ATT_NO = "";
UvVar TEMP_ID = "";
UvVar ROW = "";
FL006 FL006;
UvVar INSTR = "";
UvVar TRANS_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESS = "";
UvVar ERRORS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar N = "";
UvVar DESTINATION_FILE = "";
UvVar FILESEQNO = "";
UvVar SEQ_ID = "";
FL551 FL551;
UvVar SUCCESSFUL = "";
FL555 FL555;
FL566 FL566;
UvVar DETAILS_REQD = "";
FL560 FL560;
UvVar STORED_TRANS_DESTINATION = "";
FL776 FL776;
FL019 FL019;
UvVar REPLY = "";
UvVar LENGTH_OF_INPUT = "";
UvVar ANS = "";
UvVar ANS2 = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar ST_ICONVERSION = "";
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
UvVar PROMPT_NO = "";
UvVar I = "";
UvVar TEXT_COL = "";
UvVar TEXT_VIDEO = "";
UvVar AMD_NO = "";
UvVar ST_ATT_MV = "";
UvVar ST_DISPLAY = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar REDISPLAY = "";
UvVar TOTAL_LENGTH = "";
UvVar POS = "";
FL769 FL769;
UvVar TRANSFER_ID = "";
UvVar OLD_FIELD_DATA = "";
UvVar OLD_FIELD_NO = "";
FL768 FL768;
UvVar TEMPLATE_ID = "";
UvVar ID = "";
UvVar CHECK_REC = "";
UvVar TEST = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL550(ref UvVar PROGRAM) {
this.PROGRAM = PROGRAM;
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
/*  Control procedure for export (both DBF and CSV as of June 98) */
PROMPT("");
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
SCREEN_CODE = PROGRAM;
// BEGIN CASE
// CASE
if (PROGRAM == "FL550") {
FILE_TYPE = "DBF";
}// CASE
else if (PROGRAM == "FL566") {
FILE_TYPE = "HTM";
}// CASE
else if (PROGRAM == "FL560") {
FILE_TYPE = "DTP";
}// CASE
else if (OTHERWISE) {
FILE_TYPE = "CSV";
}
// END CASE
/* ******************************** */
/*   Define Files Used            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MD

#endregion
#region INCLUDE FL.FILES FL.AD.HOC.ENQUIRIES

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
do {
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
MAIN_KEY = INIT;
MAT(ref TRANS_REC, "");
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
MAIN_ID = "CONTROL*" + MAIN_KEY;
MATWRITE(TRANS_REC, FL_UNIVERSE_TRANSFER, MAIN_ID);
if (!READ(ref TRANS_LOG_REC, FL_UNIVERSE_TRANSFER, MAIN_ID)) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.UNIVERSE.TRANSFER";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MAIN_ID);
/* !*           PRINT WASH: */
/* !*           CALL FL306 */
/*  Use procedure is specified */
OK_TO_PROCEED = TRUE;
if (TRANS_REC[TRANS_PROCEDURE] != "") {
/*  DJA 28.10.99 * */
/*  Validate procedure exists, strip out clear screens and */
/*  position cursor on-screen */
if (READ(ref PROC_REC, COMMON.FILES[FL_AD_HOC_ENQUIRIES], TRANS_REC[TRANS_PROCEDURE])) {
NO_ATTS = DCOUNT(PROC_REC, AM);
FINISHED = FALSE;
ATT_NO = 1;
do {
if (ATT_NO > NO_ATTS || FINISHED) break;
if (PROC_REC[ATT_NO] == "T C") {
PROC_REC = DELETE(PROC_REC, ATT_NO, 0, 0);
FINISHED = TRUE;
} else {
ATT_NO = ATT_NO + 1;
}
} while (true);
TEMP_ID = "FL550*TEMP*" + PORT_NUMBER;
WRITE(PROC_REC, COMMON.FILES[FL_MD], TEMP_ID);
/* !*    READ TESTREC FROM FL.MD,TRANS.PROCEDURE ELSE */
/* !*       TESTREC = "" */
/* !*       TESTREC<1> = 'PQ' */
/* !*       TESTREC<2> = '(FL.AD.HOC.ENQUIRIES' */
/* !*       WRITE TESTREC ON FL.MD,TRANS.PROCEDURE */
/* !*    END */
/* !*    EXECUTE TRANS.PROCEDURE */
for(ROW = 3; ROW <= 19; ROW += 1) {
PRINT(AT(0, ROW) + COMMON.EOL);
}
PRINT(AT(0, 3));
EXECUTE(TEMP_ID, string.Empty, string.Empty, string.Empty, string.Empty);
} else {
nrf0 = "FL550";
nrf1 = 21;
nrf2 = TRANS_REC[TRANS_PROCEDURE];
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
TRANS_REC[TRANS_PROCEDURE] = "";
}
}
/*  Use select list if specified */
if (TRANS_REC[TRANS_SELECT_LIST] != "") {
INSTR = "GET-LIST " + TRANS_REC[TRANS_SELECT_LIST];
nrf0 = "COS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref TRANS_LIST, ref LIST_AVAILABLE, ref MESS, ref ERRORS);
if (NOT(LIST_AVAILABLE)) {
nrf0 = "FL550";
nrf1 = 6;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
OK_TO_PROCEED = FALSE;
}
}
/*  Select the whole file if no procedure or list name */
if (OK_TO_PROCEED) {
for(N = 3; N <= 19; N += 1) {
PRINT(AT(0, N) + COMMON.EOL);
}
PRINT(AT(10, 6));
if (TRANS_REC[TRANS_PROCEDURE] == "" && TRANS_REC[TRANS_SELECT_LIST] == "") {
INSTR = "SELECT " + TRANS_REC[TRANS_FILENAME];
nrf0 = "COS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTR, ref nrf0, ref TRANS_LIST, ref LIST_AVAILABLE, ref MESS, ref ERRORS);
}
if (TRANS_REC[TRANS_SEQ_OVER] == "S") {
DESTINATION_FILE = TRANS_REC[TRANS_DESTINATION] + FILESEQNO;
SEQ_ID = "COUNT*" + MAIN_KEY;
WRITEV(FILESEQNO, FL_UNIVERSE_TRANSFER, SEQ_ID, 1);
} else {
DESTINATION_FILE = TRANS_REC[TRANS_DESTINATION];
}
/* !*            MAIN.ID = "CONTROL*":MAIN.KEY */
/* DJA 28.10.99* */
if (TRANS_REC[TRANS_TEMPLATE] == "") { TRANS_REC[TRANS_TEMPLATE] = MAIN_KEY; }
// BEGIN CASE
// CASE
if (FILE_TYPE == "DBF") {
/* ************************************* */
/* ************************************* */
/* *   DBF EXPORT */
/* ************************************* */
/* ************************************* */
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL551 = new FL551(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
}// CASE
else if (FILE_TYPE == "CSV") {
/* ********************************** */
/* ********************************** */
/* *   CSV EXPORT */
/* ********************************** */
/* ********************************** */
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL555 = new FL555(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
}// CASE
else if (FILE_TYPE == "HTM") {
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DIRECTORY];
FL566 = new FL566(ref nrf0, ref nrf1, ref nrf2, ref DESTINATION_FILE, ref TRANS_LIST, ref LIST_AVAILABLE, ref SUCCESSFUL);
}// CASE
else if (FILE_TYPE == "DTP") {
/*  NOTE TRANS DIRECTORY CONTAINS THE HEADING */
if (TRANS_REC[TRANS_APPLICATION] == "Y") {
DETAILS_REQD = TRUE;
} else {
DETAILS_REQD = FALSE;
}
nrf0 = TRANS_REC[TRANS_FILENAME];
nrf1 = TRANS_REC[TRANS_TEMPLATE];
nrf2 = TRANS_REC[TRANS_DOCUMENT];
FL560 = new FL560(ref nrf0, ref nrf1, ref nrf2, ref DETAILS_REQD, ref TRANS_LIST, ref LIST_AVAILABLE);
}
// END CASE
for(ROW = 3; ROW <= 19; ROW += 1) {
PRINT(AT(0, ROW) + COMMON.EOL);
}
/*  DJA 9/3/00 Ensure sequential file suffixes are temporarily appended to */
/*             the file name so that they can be automatically launched */
/*             in Word/Excel/etc. Strip the suffix off immediately */
/*             afterwards to ensure that it isn't written back to */
/*             FL.UNIVERSE.TRANSFER. */
if (TRANS_REC[TRANS_SEQ_OVER] == "S") {
STORED_TRANS_DESTINATION = TRANS_REC[TRANS_DESTINATION];
TRANS_REC[TRANS_DESTINATION] = TRANS_REC[TRANS_DESTINATION] + FILESEQNO;
}
if (FILE_TYPE != "DTP") {
FL776 = new FL776(ref TRANS_REC, ref FILE_TYPE);
if (TRANS_REC[TRANS_SEQ_OVER] == "S") {
TRANS_REC[TRANS_DESTINATION] = STORED_TRANS_DESTINATION;
}
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + "TRANSFER COMPLETE. Press <return> to continue.");
nrf0 = 1;
FL019 = new FL019(ref nrf0, ref REPLY);
}
PRINT(AT(0, 3) + NRM_VID);
}
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
/* !*     PRINT ERR.LINE: */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + "Enter Field no, DEL to delete or <RETURN> to start transfer ");
LENGTH_OF_INPUT = 4;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS);
/* !*     PRINT CLR.ERR: */
PRINT(AT(5, 21) + SPACE(70));
PRINT(AT(0, 3) + NRM_VID);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "") {
// BEGIN CASE
// CASE
if (TRANS_REC[TRANS_PROCEDURE] != "" && TRANS_REC[TRANS_SELECT_LIST] == "") {
nrf0 = "FL550";
nrf1 = 15;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (TRANS_REC[TRANS_PROCEDURE] == "" && TRANS_REC[TRANS_SELECT_LIST] == "") {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + "NO SELECT LIST SPECIFIED. Process the whole file? (Y/N) ");
LENGTH_OF_INPUT = 2;
FL019 = new FL019(ref LENGTH_OF_INPUT, ref ANS2);
PRINT(AT(5, 21) + SPACE(70));
PRINT(AT(0, 3) + NRM_VID);
// BEGIN CASE
// CASE
if (ANS2 == "Y" || ANS2 == "y") {
INTERACT = FINISH;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
}// CASE
else if (OTHERWISE) {
INTERACT = FINISH;
}
// END CASE
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "DEL") {
L0400();
INTERACT = FINISH;
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
/* !*     LOOP */
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
if (ST_ATT == 0) {
VALUE = MAIN_KEY;
} else {
VALUE = TRANS_REC[ST_ATT][1, ST_MV];
}
PRINT(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
FL019 = new FL019(ref ST_LENGTH, ref ANS);
/* !*        WHILE ANS = HELP DO */
/* !*     REPEAT */
// BEGIN CASE
// CASE
if (FIELD_NO > 2 && ANS == COMMON.HELP) {
nrf0 = "FL550";
nrf1 = 4;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}// CASE
else if (ANS == COMMON.ABANDON) {
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
else if (ANS == COMMON.CLR && FIELD_NO != 6) {
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
case 3: L1150(); break;
case 4: L1200(); break;
case 5: L1300(); break;
case 6: L1400(); break;
case 7: L1500(); break;
case 8: L1600(); break;
case 9: L1700(); break;
case 10: L1800(); break;
case 11: L1900(); break;
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
} else {
TRANS_REC[ST_ATT][1, ST_MV] = VALUE;
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
PRINT(AT(78, 20) + NRM_VID + AT(1, 20) + DIM_REV_VID + SPACE(76));
/* DJA* New line :- */
PRINT(AT(0, 0) + SCREEN_HEAD_BACK + SCREEN_HEAD_FORE);
/* DJA* Changed '2,' to '1,' */
PRINT(AT(1, 0) + "(" + SCREEN_CODE + ")");
/* DJA* New line :- */
PRINT(AT(65, 0) + OCONV(TODAYS_DATE, "D"));
/* DJA* Changed ',0' to ',1' */
PRINT(AT(26, 1) + SC_POS[1]);
/* DJA*   PRINT @(26,1):STR("=",LEN(SC.POS<1>)): */
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
ST_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
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
DISP_COL = FIELD_DATA[1, 1] + 1 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
PRINT(AT(DISP_COL, DISP_ROW));
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
DISP_CONVERSION = FIELD_DATA[1, 9];
if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TRANS_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
} else {
PRINT(FORMAT(TRANS_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
/* *            PRINT SPACE(2):OCONV("CONTROL*":TRANS.REC(DISP.ATT)<1,DISP.MV>,"TFL.UNIVERSE.TRANSFER;X;1;1")'L#20': */
}
}
if (TRANS_REC[TRANS_SEQ_OVER] == "S") {
PRINTCR(AT(45, 17) + "File number will be " + FILESEQNO);
}
return;
/* ****************************** */
}
void L0400() {
/*  Deletion Routine       * */
/* ****************************** */
MAIN_ID = "CONTROL*" + MAIN_KEY;
if (!READ(ref TRANS_LOG_REC, FL_UNIVERSE_TRANSFER, MAIN_ID)) { TRANS_LOG_REC = ""; }
DELETE(FL_UNIVERSE_TRANSFER, MAIN_ID);
nrf0 = "D";
nrf1 = "FL.UNIVERSE.TRANSFER";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MAIN_ID);
MAIN_KEY = "";
/* !*     PRINT ERR.LINE:"        RECORD DELETED !!!! <RETURN> to contine          ": */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(10, 21) + "THIS TRANSFER HAS BEEN DELETED.  Press <RETURN> to continue.");
INPUT(out ANS, 1);
PRINT(AT(0, 3) + NRM_VID);
return;
/* ************************ */
/*   Validation Routines  * */
/* ************************ */
}
void L1000() {
/*  Transfer Name validation */
REDISPLAY = "";
/*  Trim ANS to remove all spaces */
TOTAL_LENGTH = LEN(ANS);
POS = 1;
do {
if (POS > TOTAL_LENGTH) break;
if (ANS.Substring(POS, 1) == " ") {
if (POS == 1) {
ANS = ANS.Substring(2, 99);
} else {
ANS = ANS.Substring(1, POS - 1) + ANS.Substring(POS + 1, 99);
}
TOTAL_LENGTH = TOTAL_LENGTH - 1;
} else {
POS = POS + 1;
}
} while (true);
INTERACT = VALID_DATA;
if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ANS == COMMON.HELP) {
FL769 = new FL769(ref TRANSFER_ID, ref INTERACT, ref REDISPLAY);
PRINT(AT(0, 3) + NRM_VID);
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
NULL();
}// CASE
else if (TRANSFER_ID == "N") {
ANS = "";
/*  New transfer */
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
ANS = TRANSFER_ID;
}
// END CASE
if (INTERACT != EXIT) {
OLD_FIELD_DATA = FIELD_DATA;
OLD_FIELD_NO = FIELD_NO;
L0100();
FIELD_DATA = OLD_FIELD_DATA;
FIELD_NO = OLD_FIELD_NO;
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(ANS, ST_JUST));
REDISPLAY = "";
}
}
if (INTERACT == VALID_DATA) {
if (ST_ICONVERSION != "") {
VALUE = ICONV(ANS, ST_ICONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
MAIN_ID = "CONTROL*" + MAIN_KEY;
if (!(MATREADU(ref TRANS_REC, FL_UNIVERSE_TRANSFER, MAIN_ID))) {
AMENDING = FALSE;
MAT(ref TRANS_REC, INIT);
}
SEQ_ID = "COUNT*" + MAIN_KEY;
if (READV(ref FILESEQNO, FL_UNIVERSE_TRANSFER, SEQ_ID, 1)) {
FILESEQNO = FILESEQNO + 1;
} else {
FILESEQNO = 1;
}
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
} else {
nrf0 = "STANDARD";
nrf1 = 7;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
INTERACT = INVALID_DATA;
}
/*  Abandoned help window */
}
} else {
INTERACT = EXIT;
AMENDING = TRUE;
}
return;
}
void L1100() {
/*  Parameter Template validation */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
FL768 = new FL768(ref TEMPLATE_ID, ref INTERACT, ref REDISPLAY);
PRINT(AT(0, 3) + NRM_VID);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
if (AMENDING) {
L0300();
}
FIELD_NO = 1;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
}// CASE
else if (TEMPLATE_ID == "N") {
/*  Can't create new templates here */
nrf0 = "FL550";
nrf1 = 3;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
ANS = TEMPLATE_ID;
}
// END CASE
}
if (INTERACT == VALID_DATA) {
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
if (ANS != "") {
ID = "FILE*" + ANS;
if (READ(ref CHECK_REC, FL_UNIVERSE_TRANSFER, ID)) {
INTERACT = VALID_DATA;
} else {
nrf0 = "FL550";
nrf1 = 2;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
INTERACT = INVALID_DATA;
}
}
}
return;
}
void L1150() {
/*  Source filename validation */
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
if (OPEN(ANS, out TEST)) {
INTERACT = VALID_DATA;
} else {
nrf0 = "FL550";
nrf1 = 7;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}
return;
}
void L1200() {
/*   Select List Name */
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
/* !*     IF ANS # "" THEN */
INTERACT = VALID_DATA;
/* !*     END */
return;
}
void L1300() {
/*  Select List Procedure validation */
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
INTERACT = VALID_DATA;
return;
}
void L1400() {
/*  Output Directory Name */
if (PROGRAM == "FL560") {
INTERACT = VALID_DATA;
return;
}
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
INTERACT = VALID_DATA;
// BEGIN CASE
// CASE
if (ANS == "" || ANS == COMMON.CLR) {
if (!(READ(ref ANS, COMMON.FILES[FL_CONTROL], "UV.TRANS.DIR"))) {
ANS = "C:\\TEMP\\";
}
}// CASE
else if (ANS.Substring(1, 2) == "\\\\" && ANS.Substring(LEN(ANS), 1) == "\\") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS.Substring(2, 2) == ":\\" && ANS.Substring(LEN(ANS), 1) == "\\") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
/* !*        PRINT @(5,20) : "Example C:\TEMP\  - Remember to include last \ " */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + "Example: C:\\TEMP\\   (remember to include the last \\)");
nrf0 = "FL550";
nrf1 = 20;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
/* !*        PRINT @(5,20) : EOL */
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(5, 21) + SPACE(70));
PRINT(AT(0, 3) + NRM_VID);
}
// END CASE
return;
}
void L1500() {
/*  Output file name */
if (PROGRAM == "FL560") {
if (ANS == "Y" || ANS == "N") {
INTERACT = VALID_DATA;
}
return;
}
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
INTERACT = INVALID_DATA;
if (ANS == "") {
nrf0 = "FL550";
nrf1 = 5;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
return;
}
if (OCONV(ANS, "MCA") == ANS) {
INTERACT = VALID_DATA;
} else {
nrf0 = "FL550";
nrf1 = 5;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}
return;
}
void L1600() {
/*  Transfer file type */
if (ST_CONVERSION != "") {
ANS = OCONV(ANS, ST_CONVERSION);
}
if (ANS == "") { ANS = TRANS_REC[FIELD_NO][1, ST_MV]; }
PRINTCR(AT(ST_COL + 5, ST_ROW) + COMMON.EOL);
// BEGIN CASE
// CASE
if (ANS == "S") {
if (READV(ref FILESEQNO, FL_UNIVERSE_TRANSFER, TRANS_REC[1] + "*CNT", 1)) {
FILESEQNO = FILESEQNO + 1;
} else {
FILESEQNO = 1;
}
PRINTCR(AT(ST_COL + 5, ST_ROW) + "File number will be " + FILESEQNO);
INTERACT = VALID_DATA;
}// CASE
else if (ANS == "O") {
INTERACT = VALID_DATA;
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
nrf0 = "FL550";
nrf1 = 14;
nrf2 = "";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
}
// END CASE
return;
}
void L1700() {
/*  Application */
if (ANS == "W" || ANS == "E" || ANS == "X" || ANS == "") {
INTERACT = VALID_DATA;
} else {
nrf0 = 22;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1800() {
/*  Windows document */
INTERACT = VALID_DATA;
return;
}
void L1900() {
/*  Macro name */
INTERACT = VALID_DATA;
return;
/*   END OF ROUTINE */
/* ************************** */
/*   END                    * */
/* ************************** */
}
}
}
