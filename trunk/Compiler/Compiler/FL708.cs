//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL708 : UvBase
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
readonly UvVar INSTRUCTOR_TITLE = 1;
readonly UvVar INSTRUCTOR_FORENAME = 2;
readonly UvVar INSTRUCTOR_SURNAME = 3;
readonly UvVar INSTRUCTOR_ADDRESS1 = 4;
readonly UvVar INSTRUCTOR_ADDRESS2 = 5;
readonly UvVar INSTRUCTOR_ADDRESS3 = 6;
readonly UvVar INSTRUCTOR_ADDRESS4 = 7;
readonly UvVar INSTRUCTOR_POST_CODE = 8;
readonly UvVar INSTRUCTOR_QUAL1 = 9;
readonly UvVar INSTRUCTOR_QUAL2 = 10;
readonly UvVar INSTRUCTOR_QUAL3 = 11;
readonly UvVar INSTRUCTOR_HOME_TEL = 12;
readonly UvVar INSTRUCTOR_WORK_TEL = 13;
readonly UvVar INSTRUCTOR_SEX = 14;
readonly UvVar INSTRUCTOR_COMMENT1 = 15;
readonly UvVar INSTRUCTOR_COMMENT2 = 16;
readonly UvVar INSTRUCTOR_COMMENT3 = 17;
readonly UvVar INSTRUCTOR_COMMENT4 = 18;
readonly UvVar INSTRUCTOR_RATE_CODE = 19;
readonly UvVar INSTRUCTOR_RATE_PER_HOUR = 20;
readonly UvVar INSTRUCTOR_AVAILABLE_MONDAY = 21;
readonly UvVar INSTRUCTOR_AVAILABLE_TUESDAY = 22;
readonly UvVar INSTRUCTOR_AVAILABLE_WEDNESDAY = 23;
readonly UvVar INSTRUCTOR_AVAILABLE_THURSDAY = 24;
readonly UvVar INSTRUCTOR_AVAILABLE_FRIDAY = 25;
readonly UvVar INSTRUCTOR_AVAILABLE_SATURDAY = 26;
readonly UvVar INSTRUCTOR_AVAILABLE_SUNDAY = 27;
readonly UvVar FL_MEMBERS = 2;
readonly UvVar MEMBER_CENTRE = 1;
readonly UvVar MEMBER_TYPE = 2;
readonly UvVar MEMBER_ORIG_PRICE = 3;
readonly UvVar MEMBER_SURNAMES = 4;
readonly UvVar MEMBER_INITIALS = 5;
readonly UvVar MEMBER_TITLES = 6;
readonly UvVar MEMBER_SEXES = 7;
readonly UvVar MEMBER_AGES = 8;
readonly UvVar MEMBER_RENEW_LETTER = 9;
readonly UvVar MEMBER_SALUTATION = 9;
readonly UvVar MEMBER_ADDRESS = 10;
readonly UvVar MEMBER_HOME_PHONE = 11;
readonly UvVar MEMBER_BUS_PHONE = 12;
readonly UvVar MEMBER_EXPIRY_DATE = 13;
readonly UvVar MEMBER_DATE_JOINED = 14;
readonly UvVar MEMBER_ISSUING_OPER = 15;
readonly UvVar MEMBER_ANALYSIS_CODES = 16;
readonly UvVar MEMBER_USED_CODES = 17;
readonly UvVar MEMBER_MAIN = 18;
readonly UvVar MEMBER_SUB = 19;
readonly UvVar MEMBER_RECEIPT = 20;
readonly UvVar MEMBER_DOBS = 21;
readonly UvVar MEMBER_LAST_CHANGED = 22;
readonly UvVar MEMBER_HF_CARD_DATE = 23;
readonly UvVar MEMBER_INSTALMENTS = 24;
readonly UvVar MEMBER_FULL_EXPIRY = 25;
readonly UvVar MEMBER_REMINDER_DATES = 26;
readonly UvVar MEMBER_RESTRICTIONS = 27;
readonly UvVar MEMBER_DIRECT_DEBIT = 28;
readonly UvVar MEMBER_FORENAMES = 29;
readonly UvVar MEMBER_COMMENTS = 30;
readonly UvVar MEMBER_PART_COMPLETE = 31;
readonly UvVar MEMBER_START_DATE = 32;
readonly UvVar MEMBER_RENEWAL_DATE = 33;
readonly UvVar MEMBER_DD_DAY = 34;
readonly UvVar MEMBER_PRICES = 35;
readonly UvVar MEMBER_WEB_BARRED = 36;
readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
readonly UvVar MEMBER_EMAIL_SALES = 38;
readonly UvVar MEMBER_DDFLAGS = 39;
readonly UvVar MEMBER_OLDNOS = 40;
readonly UvVar MEMBER_PROSPECT_NO = 41;
readonly UvVar MEMBER_APACS_NO = 42;
readonly UvVar MEMBER_MOBILE_PHONE = 43;
readonly UvVar MEMBER_JOB_TITLE = 44;
readonly UvVar MEMBER_DEPARTMENT = 45;
readonly UvVar FL_TOWNS = 21;
readonly UvVar TOWN_DESC = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] TOWNS_REC = new UvVar[1];
UvVar[] TEMP_REC = new UvVar[40];
#endregion
#region Variables
UvVar NEW_INSTRUCTOR = "";
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
UvVar FL_INSTRUCTORS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar ADDRESS_LINE1_FIELD_NO = "";
UvVar POSTCODE_FIELD_NO = "";
UvVar GENDER_FIELD_NO = "";
UvVar VALID_AVAILABILITY = "";
UvVar AVAILABLE_CODE_DESCRIPTION_LIST = "";
UvVar AMENDING = "";
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar OK_TO_FILE = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ADDRESS_COMPLETE = "";
FLQAS FLQAS;
UvVar ADDRESS = "";
UvVar TEMP_ATT = "";
UvVar AMC = "";
UvVar OLD_FIELD_DATA = "";
UvVar TEMP_FIELD_NO = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar SKIP_INPUT = "";
UvVar TITLE = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
FL006 FL006;
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
FL719 FL719;
UvVar REDISPLAY = "";
UvVar MEMBER = "";
FL724 FL724;
UvVar OLD_FIELD_NO = "";
UvVar POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL708(ref UvVar[] INSTRUCTOR_REC, ref UvVar NEW_INSTRUCTOR) {
this.INSTRUCTOR_REC = INSTRUCTOR_REC;
this.NEW_INSTRUCTOR = NEW_INSTRUCTOR;
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
/*     INSTRUCTOR MAINTENANCE (NEW MODULE) */
PROMPT("");
PROGRAM = "FL708";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

#endregion
#region INCLUDE FL.FILES FL.MEMBERS

/*  DJA 14.8.01 Separate file includes for web bookings */
/*              (see FL.MEMBERS.VAR for field names) */
#region INCLUDE FL.FILES FL.MEMBERS.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.DIM

SIZE_OF_MEMBERS_REC = 45;
/*  Must keep in tandem */

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.VAR

/*  Hammersmith & Fulham - Membership Card production systems */
/*  Two tier reminder system */

#endregion

#endregion
#region INCLUDE FL.FILES FL.TOWNS

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
ADDRESS_LINE1_FIELD_NO = 5;
POSTCODE_FIELD_NO = 9;
GENDER_FIELD_NO = 13;
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
VALID_AVAILABILITY = "NONE";
VALID_AVAILABILITY[-1] = "ALL";
VALID_AVAILABILITY[-1] = "AM";
VALID_AVAILABILITY[-1] = "PM";
VALID_AVAILABILITY[-1] = "EV";
VALID_AVAILABILITY[-1] = "AM PM";
VALID_AVAILABILITY[-1] = "AM EV";
VALID_AVAILABILITY[-1] = "PM EV";
AVAILABLE_CODE_DESCRIPTION_LIST = "Unavailable";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Available All Day";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Afternoons only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Evenings only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings and Afternoons";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings and Evenings";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Afternoons and Evenings";
do {
INTERACT = VALID_DATA;
L0100();
AMENDING = FALSE;
if (PROG_MESS[2] != "") {
MAIN_KEY = PROG_MESS[2];
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
L0300();
/*  Display data */
} else {
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
}
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
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
else if (FIELD_NO == MAX_FIELDS) {
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
INPUT_LINE = "      Enter Field no, 'D'elete or 'F' to finish ";
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
/*  No paging at this time */
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "D") {
/*  Delete instructor */
INPUT_LINE = "      Delete this instructor? (Y/N) ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
if (ANS == "Y") {
DELETE(FL_INSTRUCTORS, MAIN_KEY);
MAT(ref TEMP_REC, "");
MAIN_KEY = "";
PROG_MESS[2] = "";
INTERACT = EXIT;
} else {
INTERACT = INVALID_DATA;
}
}// CASE
else if (ANS == "F") {
/*  Validate that key fields are present before allowing the user to file */
OK_TO_FILE = TRUE;
/* *       BEGIN CASE */
/* *       END CASE */
if (OK_TO_FILE) {
PROG_MESS[1] = "";
INTERACT = FINISH;
}
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
ADDRESS_COMPLETE = FALSE;
if (FIELD_NO == ADDRESS_LINE1_FIELD_NO) {
FLQAS = new FLQAS(ref ADDRESS);
if (ADDRESS != "") {
TEMP_ATT = ADDRESS_LINE1_FIELD_NO - 1;
for(AMC = 1; AMC <= 4; AMC += 1) {
TEMP_REC[AMC + ADDRESS_LINE1_FIELD_NO - 2] = "";
if (ADDRESS[AMC] != "") {
TEMP_REC[TEMP_ATT] = ADDRESS[AMC];
TEMP_ATT = TEMP_ATT + 1;
}
}
TEMP_REC[POSTCODE_FIELD_NO - 1] = ADDRESS[5];
OLD_FIELD_DATA = FIELD_DATA;
for(TEMP_FIELD_NO = ADDRESS_LINE1_FIELD_NO; TEMP_FIELD_NO <= POSTCODE_FIELD_NO; TEMP_FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[TEMP_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
FIELD_DATA = OLD_FIELD_DATA;
L0200();
ADDRESS_COMPLETE = TRUE;
ANS = TEMP_REC[ADDRESS_LINE1_FIELD_NO - 1];
}
}
SKIP_INPUT = FALSE;
if (FIELD_NO != ADDRESS_LINE1_FIELD_NO || NOT(ADDRESS_COMPLETE)) {
if (FIELD_NO == GENDER_FIELD_NO && AMENDING == FALSE && VALUE == "") {
TITLE = OCONV(TEMP_REC[1], "MCU");
// BEGIN CASE
// CASE
if (TITLE == "MRS" || TITLE == "MISS" || TITLE == "MS") {
ANS = "F";
SKIP_INPUT = TRUE;
}// CASE
else if (TITLE == "MR" || TITLE == "MSTR" || TITLE == "MASTER") {
ANS = "M";
SKIP_INPUT = TRUE;
}
// END CASE
}
if (NOT(SKIP_INPUT)) {
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
}
}
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
}// CASE
else if (ANS == "" && VALUE == "" && ST_MANDATORY == "" && FIELD_NO > 1) {
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
case 6: L1500(); break;
case 7: L1600(); break;
case 8: L1700(); break;
case 9: L1800(); break;
case 10: L1900(); break;
case 11: L2000(); break;
case 12: L2100(); break;
case 13: L2200(); break;
case 14: L2300(); break;
case 15: L2400(); break;
case 16: L2500(); break;
case 17: L2600(); break;
case 18: L2700(); break;
case 19: L2800(); break;
case 20: L2900(); break;
case 21: L3000(); break;
case 22: L3100(); break;
case 23: L3100(); break;
case 24: L3100(); break;
case 25: L3100(); break;
case 26: L3100(); break;
case 27: L3100(); break;
case 28: L3100(); break;
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
if (FIELD_NO == ADDRESS_LINE1_FIELD_NO && ADDRESS_COMPLETE && NOT(AMENDING)) {
FIELD_NO = POSTCODE_FIELD_NO;
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
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1000() {
/*   INSTRUCTOR Code Validation Routine */
INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
FL719 = new FL719(ref ANS, ref INTERACT, ref REDISPLAY);
L0100();
}
// BEGIN CASE
// CASE
if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
PROG_MESS[2] = MAIN_KEY;
if (MATREADU(ref INSTRUCTOR_REC, FL_INSTRUCTORS, MAIN_KEY)) {
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
NEW_INSTRUCTOR = FALSE;
} else {
AMENDING = FALSE;
MAT(ref TEMP_REC, "");
NEW_INSTRUCTOR = TRUE;
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76));
PRINT(AT(2, 21) + "  Enter existing membership number or press <return> ");
INPUT(out MEMBER, 9);
if (LEN(MEMBER) > 8) { PRINT(AT(-9) + " "); MEMBER = MEMBER.Substring(1, 8); }
if (MEMBER != "" && MEMBER != COMMON.ABANDON) {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER)) {
AMENDING = TRUE;
TEMP_REC[1] = MEMBERS_REC[MEMBER_TITLES][1, 1];
TEMP_REC[2] = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
TEMP_REC[3] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
TEMP_REC[4] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
TEMP_REC[5] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
TEMP_REC[6] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
TEMP_REC[7] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
TEMP_REC[8] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
TEMP_REC[14] = MEMBERS_REC[MEMBER_SEXES][1, 1];
TEMP_REC[12] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
TEMP_REC[13] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
} else {
nrf0 = 10;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + SPACE(76));
}
if (INTERACT != INVALID_DATA) {
if (AMENDING) { L0300(); }
INTERACT = VALID_DATA;
}
} else {
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PRINT(SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(0, 23) + FORMAT("", JUST));
}
}// CASE
else if (OTHERWISE) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}
// END CASE
return;
}
void L1100() {
/*  TITLE  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*  FORENAME  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1300() {
/*  SURNAME  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1400() {
/*  ADDRESS1  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1500() {
/*  ADDRESS2  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1600() {
/*   ADDRESS 3  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1700() {
/*   ADDRESS4  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1800() {
/*   POST CODE  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1900() {
/*   QUAL 1  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2000() {
/*  QUAL 2  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2100() {
/*  QUAL 3  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2200() {
/*   SEX  Validation Routine */
if (ANS == "F" || ANS == "M") {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2300() {
/*   TEL HOME  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2400() {
/*   TEL WORK  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2500() {
/*  COMMENT 1  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2600() {
/*   COMMENT 2  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2700() {
/*   COMMENT 3  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2800() {
/*  COMMENT 4  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2900() {
/*   RATE CODE  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3000() {
/*  RATE PER HOUR  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3100() {
/*  Availability  Validation Routine */
if (ANS == COMMON.HELP) {
FL724 = new FL724(ref ANS, ref VALID_AVAILABILITY, ref AVAILABLE_CODE_DESCRIPTION_LIST, ref INTERACT, ref REDISPLAY);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
if (!(LOCATE(ANS, VALID_AVAILABILITY, 0, 0, 1, ref POS, "AL"))) {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = INSTRUCTOR_REC[INSTRUCTOR_TITLE];
TEMP_REC[2] = INSTRUCTOR_REC[INSTRUCTOR_FORENAME];
TEMP_REC[3] = INSTRUCTOR_REC[INSTRUCTOR_SURNAME];
TEMP_REC[4] = INSTRUCTOR_REC[INSTRUCTOR_ADDRESS1];
TEMP_REC[5] = INSTRUCTOR_REC[INSTRUCTOR_ADDRESS2];
TEMP_REC[6] = INSTRUCTOR_REC[INSTRUCTOR_ADDRESS3];
TEMP_REC[7] = INSTRUCTOR_REC[INSTRUCTOR_ADDRESS4];
TEMP_REC[8] = INSTRUCTOR_REC[INSTRUCTOR_POST_CODE];
TEMP_REC[9] = INSTRUCTOR_REC[INSTRUCTOR_QUAL1];
TEMP_REC[10] = INSTRUCTOR_REC[INSTRUCTOR_QUAL2];
TEMP_REC[11] = INSTRUCTOR_REC[INSTRUCTOR_QUAL3];
TEMP_REC[12] = INSTRUCTOR_REC[INSTRUCTOR_HOME_TEL];
TEMP_REC[13] = INSTRUCTOR_REC[INSTRUCTOR_WORK_TEL];
TEMP_REC[14] = INSTRUCTOR_REC[INSTRUCTOR_SEX];
TEMP_REC[15] = INSTRUCTOR_REC[INSTRUCTOR_COMMENT1];
TEMP_REC[16] = INSTRUCTOR_REC[INSTRUCTOR_COMMENT2];
TEMP_REC[17] = INSTRUCTOR_REC[INSTRUCTOR_COMMENT3];
TEMP_REC[18] = INSTRUCTOR_REC[INSTRUCTOR_COMMENT4];
TEMP_REC[19] = INSTRUCTOR_REC[INSTRUCTOR_RATE_CODE];
TEMP_REC[20] = INSTRUCTOR_REC[INSTRUCTOR_RATE_PER_HOUR];
TEMP_REC[21] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_MONDAY];
TEMP_REC[22] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_TUESDAY];
TEMP_REC[23] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_WEDNESDAY];
TEMP_REC[24] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_THURSDAY];
TEMP_REC[25] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_FRIDAY];
TEMP_REC[26] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SATURDAY];
TEMP_REC[27] = INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SUNDAY];
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
INSTRUCTOR_REC[INSTRUCTOR_TITLE] = TEMP_REC[1];
INSTRUCTOR_REC[INSTRUCTOR_FORENAME] = TEMP_REC[2];
INSTRUCTOR_REC[INSTRUCTOR_SURNAME] = TEMP_REC[3];
INSTRUCTOR_REC[INSTRUCTOR_ADDRESS1] = TEMP_REC[4];
INSTRUCTOR_REC[INSTRUCTOR_ADDRESS2] = TEMP_REC[5];
INSTRUCTOR_REC[INSTRUCTOR_ADDRESS3] = TEMP_REC[6];
INSTRUCTOR_REC[INSTRUCTOR_ADDRESS4] = TEMP_REC[7];
INSTRUCTOR_REC[INSTRUCTOR_POST_CODE] = TEMP_REC[8];
INSTRUCTOR_REC[INSTRUCTOR_QUAL1] = TEMP_REC[9];
INSTRUCTOR_REC[INSTRUCTOR_QUAL2] = TEMP_REC[10];
INSTRUCTOR_REC[INSTRUCTOR_QUAL3] = TEMP_REC[11];
INSTRUCTOR_REC[INSTRUCTOR_HOME_TEL] = TEMP_REC[12];
INSTRUCTOR_REC[INSTRUCTOR_WORK_TEL] = TEMP_REC[13];
INSTRUCTOR_REC[INSTRUCTOR_SEX] = TEMP_REC[14];
INSTRUCTOR_REC[INSTRUCTOR_COMMENT1] = TEMP_REC[15];
INSTRUCTOR_REC[INSTRUCTOR_COMMENT2] = TEMP_REC[16];
INSTRUCTOR_REC[INSTRUCTOR_COMMENT3] = TEMP_REC[17];
INSTRUCTOR_REC[INSTRUCTOR_COMMENT4] = TEMP_REC[18];
INSTRUCTOR_REC[INSTRUCTOR_RATE_CODE] = TEMP_REC[19];
INSTRUCTOR_REC[INSTRUCTOR_RATE_PER_HOUR] = TEMP_REC[20];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_MONDAY] = TEMP_REC[21];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_TUESDAY] = TEMP_REC[22];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_WEDNESDAY] = TEMP_REC[23];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_THURSDAY] = TEMP_REC[24];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_FRIDAY] = TEMP_REC[25];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SATURDAY] = TEMP_REC[26];
INSTRUCTOR_REC[INSTRUCTOR_AVAILABLE_SUNDAY] = TEMP_REC[27];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
