//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL710 : UvBase
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
readonly UvVar NOT_PRESENT = 9;
readonly UvVar ALREADY_PRESENT = 10;
readonly UvVar FWTERM_MODE = 0;
readonly UvVar TOUCHSCREEN_MODE = 1;
readonly UvVar SILENT_MODE = 2;
readonly UvVar SCREENS = 8;
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
readonly UvVar FL_TOWNS = 21;
readonly UvVar TOWN_DESC = 1;
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
readonly UvVar APACS_MEMBER = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] TOWNS_REC = new UvVar[1];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] TEMP_REC = new UvVar[40];
#endregion
#region Variables
UvVar NEW_STUDENT = "";
UvVar TERMINAL_TYPE = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
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
UvVar PROCESS_EXECUTE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_APACS_NUMBERS = "";
UvVar SMART_CARD = "";
UvVar COURSE_PARAMS = "";
UvVar GET_STUDENT_ID = "";
UvVar GET_CARD_NO = "";
UvVar CHECK_FOR_DUPLICATES = "";
UvVar LABEL_PRINT = "";
UvVar ATT = "";
UvVar BLANK_LEVEL_FOUND = "";
UvVar SCREEN_ATT = "";
UvVar ATT2 = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar SURNAME_FIELD_NO = "";
UvVar ADDRESS_LINE1_FIELD_NO = "";
UvVar POSTCODE_FIELD_NO = "";
UvVar GENDER_FIELD_NO = "";
UvVar DOB_FIELD_NO = "";
UvVar HOME_TEL_FIELD_NO = "";
UvVar WORK_TEL_FIELD_NO = "";
UvVar CONTACT_NAME_FIELD_NO = "";
UvVar CONTACT_TEL_FIELD_NO = "";
UvVar DR_NAME_FIELD_NO = "";
UvVar DR_TEL_FIELD_NO = "";
UvVar KEYWORD_FIELD_NO = "";
UvVar AMENDING = "";
UvVar NEW_KEY = "";
UvVar ENROLMENT_CALL = "";
UvVar NEW_STUDENT_NO = "";
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
CallAt_GET_CARD_NO CallAt_GET_CARD_NO;
UvVar MAIN_KEY = "";
UvVar FIELD_NO = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar STUDENT_IS_MEMBER = "";
FL006 FL006;
UvVar LOG_REC = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
CallAt_LABEL_PRINT CallAt_LABEL_PRINT;
UvVar AMENDMENT_ALLOWED = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ADDRESS_COMPLETE = "";
UvVar SKIP_INPUT = "";
FLQAS FLQAS;
UvVar ADDRESS = "";
UvVar TEMP_ATT = "";
UvVar AMC = "";
UvVar OLD_FIELD_DATA = "";
UvVar TEMP_FIELD_NO = "";
UvVar TITLE = "";
UvVar ST_LENGTH = "";
UvVar SMARTCARD_READ = "";
UvVar MEMBER_PROGRAM = "";
CallAt_MEMBER_PROGRAM CallAt_MEMBER_PROGRAM;
UvVar MDISL = "";
FL019 FL019;
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar IFACE_TYPE = "";
UvVar SMART_MEMBER_NO = "";
UvVar APACS_NO = "";
UvVar SMART_DISPLAY_MODE = "";
FL_SMARTCARD FL_SMARTCARD;
UvVar TRANS_AMOUNT = "";
UvVar TRANS_TYPE = "";
UvVar TRANS_ID = "";
UvVar SMARTCARD_INTERACT = "";
UvVar CARD_ERROR_TYPE = "";
UvVar CARD_ERROR_MESS = "";
UvVar EPURSE_BALANCE = "";
UvVar LOYALTY_BALANCE = "";
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
UvVar MATCH_LIST = "";
FL723 FL723;
UvVar REDISPLAY = "";
UvVar OLD_FIELD_NO = "";
UvVar PADDED_MAIN_KEY = "";
FL000_40 FL000_40;
UvVar STUDENT_EXISTS = "";
UvVar MASTER_REC = "";
UvVar N = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar ID = "";
UvVar RETURNED_ANS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL710(ref UvVar[] STUDENT_REC, ref UvVar NEW_STUDENT) {
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
/*     STUDENT MAINTENANCE (NEW MODULE) */
PROMPT("");
PROGRAM = "FL710";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
JUST = "L#10";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
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
#region INCLUDE FL.FILES FL.TOWNS

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
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
MAT(ref TEMP_REC, "");
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[1, 1];
GET_CARD_NO = COURSE_PARAMS[11, 1];
CHECK_FOR_DUPLICATES = COURSE_PARAMS[30, 1];
if (CHECK_FOR_DUPLICATES == "") { CHECK_FOR_DUPLICATES = "Y"; }
if (!READV(ref LABEL_PRINT, COMMON.FILES[FL_CONTROL], "ADDRESS.LABEL.ROUTINE", 1)) { LABEL_PRINT = ""; }
/* ************************************ */
/*   GET SCREEN DEFINITION ITEM       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
if (MATREAD(ref COURSE_PARAM_REC, FL_COURSE_PARAMS, "STUDENT.COMMENTS")) {
ATT = 1;
BLANK_LEVEL_FOUND = FALSE;
do {
if (!(ATT <= 4 && NOT(BLANK_LEVEL_FOUND))) break;
if (COURSE_PARAM_REC[ATT] == "") {
BLANK_LEVEL_FOUND = TRUE;
} else {
SCREEN_ATT = 25 + ((ATT * 2) - 1);
SC_POS[SCREEN_ATT, 3] = FORMAT(COURSE_PARAM_REC[ATT], "L#10");
}
if (NOT(BLANK_LEVEL_FOUND)) { ATT = ATT + 1; }
} while (true);
if (BLANK_LEVEL_FOUND) {
for(ATT2 = ATT; ATT2 <= 4; ATT2 += 1) {
SCREEN_ATT = 25 + ((ATT2 * 2) - 1);
SC_POS[SCREEN_ATT, 3] = FORMAT("", "L#10");
}
}
WRITE(SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE);
}
/*  Delete compiled screen because with centralised course parameters */
/*  you cannot guarantee that the compiled version is in line with */
/*  changes to customised student comments */
DELETE(COMMON.FILES[SCREENS], ("$" + SCREEN_CODE + "*" + TERMINAL_TYPE));
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
SURNAME_FIELD_NO = 4;
ADDRESS_LINE1_FIELD_NO = 5;
POSTCODE_FIELD_NO = 9;
GENDER_FIELD_NO = 10;
DOB_FIELD_NO = 11;
HOME_TEL_FIELD_NO = 16;
WORK_TEL_FIELD_NO = 17;
CONTACT_NAME_FIELD_NO = 18;
CONTACT_TEL_FIELD_NO = 19;
DR_NAME_FIELD_NO = 23;
DR_TEL_FIELD_NO = 24;
KEYWORD_FIELD_NO = 25;
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
AMENDING = FALSE;
NEW_KEY = FALSE;
ENROLMENT_CALL = FALSE;
// BEGIN CASE
// CASE
if (NEW_STUDENT && MATCH(PROG_MESS[2],"16N")) {
NEW_KEY = TRUE;
}// CASE
else if (PROG_MESS[2] == "N") {
ENROLMENT_CALL = TRUE;
/*  This routine called by enrolment screen.  Generate a new no. if poss. */
if (GET_CARD_NO == "") {
if (GET_STUDENT_ID == "") {
/*  Not possible to generate a new student no. */
PROG_MESS[2] = "";
} else {
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref NEW_STUDENT_NO);
PROG_MESS[2] = NEW_STUDENT_NO;
NEW_KEY = TRUE;
}
} else {
nrf0 = "N";
CallAt_GET_CARD_NO = new CallAt_GET_CARD_NO(ref GET_CARD_NO, ref nrf0, ref NEW_STUDENT_NO);
/*  If user abandons from the prompt, new.student.no will be null */
if (NEW_STUDENT_NO == "") {
PROG_MESS[2] = "";
} else {
PROG_MESS[2] = NEW_STUDENT_NO;
NEW_KEY = TRUE;
}
}
}
// END CASE
// BEGIN CASE
// CASE
if (PROG_MESS[2] != "" && NEW_KEY) {
L0100();
MAIN_KEY = PROG_MESS[2];
MAT(ref TEMP_REC, "");
FIELD_NO = 1;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(MAIN_KEY, ST_JUST));
FIELD_NO = 2;
}// CASE
else if (PROG_MESS[2] != "") {
L0100();
MAIN_KEY = PROG_MESS[2];
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
L0300();
/*  Display data */
L0050();
}// CASE
else if (OTHERWISE) {
L0100();
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
FIELD_NO = 1;
}
// END CASE
STUDENT_IS_MEMBER = FALSE;
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS) break;
// BEGIN CASE
// CASE
if (FIELD_NO == 5 && AMENDING == FALSE && TEMP_REC[8] != "") {
/*  Address has been successfully retrieved via the postcode */
FIELD_NO = FIELD_NO + 5;
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
/*  DJA 11.3.03 Trap data corruptions (Swindon) */
if (STUDENT_REC[STUDENT_SEX] != "M" && STUDENT_REC[STUDENT_SEX] != "F" && STUDENT_REC[STUDENT_SEX] != "") {
/*  Probably contains a postcode */
INTERACT = INVALID_DATA;
nrf0 = 40;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
if (!READU(ref LOG_REC, COMMON.FILES[FL_CONTROL], "STUDENT.LOG")) { LOG_REC = ""; }
LOG_REC[-1] = MAIN_KEY + VM + U_INITS + VM + TODAYS_DATE + VM + INT(TIME());
WRITE(LOG_REC, COMMON.FILES[FL_CONTROL], "STUDENT.LOG");
}
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
if (LABEL_PRINT != "") {
INPUT_LINE = "      Field no, <RET> to page, 'D'elete, 'F'inish or + for label ";
} else {
INPUT_LINE = "      Enter Field no, <RET> to page, 'D'elete or 'F' to finish ";
}
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
INTERACT = FINISH;
PROG_MESS[1] = 2;
}// CASE
else if (ANS == "+" && LABEL_PRINT != "") {
/*  NORFOLK SKI CLUB LABEL PRINT */
CallAt_LABEL_PRINT = new CallAt_LABEL_PRINT(ref LABEL_PRINT, ref TEMP_REC[1], ref TEMP_REC[2], ref TEMP_REC[3], ref TEMP_REC[4], ref TEMP_REC[5], ref TEMP_REC[6], ref TEMP_REC[7], ref TEMP_REC[8]);
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
/*  DJA 28.07.00 */
AMENDMENT_ALLOWED = TRUE;
if (STUDENT_IS_MEMBER) {
if (ANS <= (DOB_FIELD_NO - 1) || ANS == (HOME_TEL_FIELD_NO - 1) || ANS == (WORK_TEL_FIELD_NO - 1)) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
AMENDMENT_ALLOWED = FALSE;
}
}
if (AMENDMENT_ALLOWED) {
FIELD_NO = ANS + FIRST_FIELD - 1;
INTERACT = VALID_DATA;
}
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
if (NOT(AMENDING)) {
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
if (FIELD_NO == SURNAME_FIELD_NO) {
/*  Tell user they can base this record on a sibling's one */
PRINT(AT(2, 21) + "  You can enter a family member's student no. here to copy details.");
} else {
PRINT(AT(2, 21) + SPACE(76));
}
}
ADDRESS_COMPLETE = FALSE;
SKIP_INPUT = FALSE;
// BEGIN CASE
// CASE
if (FIELD_NO == ADDRESS_LINE1_FIELD_NO) {
FLQAS = new FLQAS(ref ADDRESS);
if (ADDRESS != "") {
TEMP_ATT = ADDRESS_LINE1_FIELD_NO - 1;
for(AMC = 1; AMC <= 4; AMC += 1) {
TEMP_REC[AMC + ADDRESS_LINE1_FIELD_NO - 2] = "";
if (ADDRESS[AMC] != "") {
/*  DJA 16.4.03 Make sure all characters returned by QAS are printable */
TEMP_REC[TEMP_ATT] = OCONV(ADDRESS[AMC], "MCP");
TEMP_ATT = TEMP_ATT + 1;
}
}
/*  DJA 16.4.03 Make sure all characters returned by QAS are printable */
TEMP_REC[POSTCODE_FIELD_NO - 1] = OCONV(ADDRESS[5], "MCP");
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
if (ADDRESS_COMPLETE) { SKIP_INPUT = TRUE; }
}// CASE
else if (FIELD_NO == GENDER_FIELD_NO && AMENDING == FALSE && VALUE == "") {
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
// END CASE
/* !*     IF FIELD.NO # ADDRESS.LINE1.FIELD.NO OR NOT(ADDRESS.COMPLETE) THEN */
if (NOT(SKIP_INPUT)) {
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(ST_COL, ST_ROW));
PRINT(STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
/*  Smart card may already be positioned in the reader */
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 1) {
L0065();
}
if (NOT(SMARTCARD_READ)) {
if (FIELD_NO == 1) {
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
} else {
MEMBER_PROGRAM = "";
}
if (MEMBER_PROGRAM != "") {
CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
} else {
MDISL = ST_LENGTH + 1;
/* DJA 7.10.02* INPUT ANS,MDISL:;IF LEN(ANS) > ST.LENGTH THEN PRINT @(-9):' ':;ANS=ANS[1,ST.LENGTH] */
FL019 = new FL019(ref MDISL, ref ANS);
}
if (ANS == "" && VALUE == "" && FIELD_NO == 1 && SMART_CARD) {
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 1) {
L0065();
/*  Re-try card read in case it was presented 'late' */
}
}
}
}
/* DJA 22.7.03*     ANS = OCONV(ANS,"MCU") */
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
PROG_MESS[1] = COMMON.ABANDON;
}// CASE
else if (ANS == GO_BACK && STUDENT_IS_MEMBER && (FIELD_NO == WORK_TEL_FIELD_NO + 1 || FIELD_NO == DOB_FIELD_NO + 1)) {
NULL();
/*  not permitted */
}// CASE
else if (ANS == GO_BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "") {
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
/* *     CASE (ANS = "" OR ANS = CLR) AND VALUE = "" AND ST.MANDATORY # "" */
}// CASE
else if (((ANS == "" && VALUE == "") || ANS == COMMON.CLR) && ST_MANDATORY != "") {
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
case 23: L3200(); break;
case 24: L3300(); break;
case 25: L3400(); break;
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
/* ************************************* */
}
void L0065() {
/*   Read smartcard                * */
/* ************************************* */
IFACE_TYPE = 1;
SMART_MEMBER_NO = "";
APACS_NO = "";
SMART_DISPLAY_MODE = FWTERM_MODE;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref SMART_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
// BEGIN CASE
// CASE
if (SMARTCARD_INTERACT == NOT_PRESENT) {
NULL();
}// CASE
else if (SMARTCARD_INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (SMART_MEMBER_NO == "NONMEM") {
/*  Use unrecognised APACS numbers as non-member student Ids */
if (APACS_NO != "") {
ANS = APACS_NO;
SMARTCARD_READ = TRUE;
}
}// CASE
else if (OTHERWISE) {
/*  If an APACS number has been returned, now process the lookup */
/*  to convert it to a membership number. If this lookup fails, */
/*  then proceed to display an input prompt in the normal way */
if (APACS_NO != "" && SMART_MEMBER_NO == "") {
if (!READV(ref SMART_MEMBER_NO, FL_APACS_NUMBERS, APACS_NO, 1)) { SMART_MEMBER_NO = ""; }
}
if (SMART_MEMBER_NO != "") {
ANS = SMART_MEMBER_NO;
SMARTCARD_READ = TRUE;
}
}
// END CASE
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
/*   STUDENT Code Validation Routine */
if (ANS == COMMON.HELP) {
MATCH_LIST = "";
FL723 = new FL723(ref ANS, ref INTERACT, ref REDISPLAY, ref MATCH_LIST);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(ANS, ST_JUST));
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (INTERACT != EXIT) {
INTERACT = VALID_DATA;
}
ANS = OCONV(ANS, "MCU");
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
ANS = "";
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "N" && (GET_STUDENT_ID != "" || GET_CARD_NO != "")) {
/*  Generate a new number */
if (GET_CARD_NO == "") {
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref ANS);
} else {
nrf0 = "N";
CallAt_GET_CARD_NO = new CallAt_GET_CARD_NO(ref GET_CARD_NO, ref nrf0, ref ANS);
}
/*  If the user abandons the prompt for a card number, ANS will be null */
if (ANS == "") {
INTERACT = INVALID_DATA;
PROG_MESS[2] = "";
} else {
MAIN_KEY = ANS;
INTERACT = VALID_DATA;
AMENDING = FALSE;
MAT(ref TEMP_REC, "");
NEW_STUDENT = TRUE;
PROG_MESS[2] = MAIN_KEY;
}
}// CASE
else if (ANS == "N" && GET_STUDENT_ID == "") {
nrf0 = 8;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
PROG_MESS[2] = MAIN_KEY;
PADDED_MAIN_KEY = MAIN_KEY;
if (NOT(MATCH(PADDED_MAIN_KEY.Substring(1, 1),"1A"))) {
FL000_40 = new FL000_40(ref PADDED_MAIN_KEY);
}
STUDENT_EXISTS = FALSE;
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, MAIN_KEY)) {
STUDENT_EXISTS = TRUE;
} else {
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, PADDED_MAIN_KEY)) {
STUDENT_EXISTS = TRUE;
MAIN_KEY = PADDED_MAIN_KEY;
/*  DJA 18.7.01 Ipswich found duplicate, unpadded student records */
/*              could be filed */
PROG_MESS[2] = MAIN_KEY;
ANS = MAIN_KEY;
VALUE = MAIN_KEY;
}
}
if (STUDENT_EXISTS) {
AMENDING = TRUE;
L8000();
/*  Build temp.rec */
NEW_STUDENT = FALSE;
} else {
INTERACT = INVALID_DATA;
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PROG_MESS[2] = "";
MAIN_KEY = "";
ANS = "";
VALUE = "";
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
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1300() {
/*   Validation Routine */
INTERACT = VALID_DATA;
/*  New mechanism for fast entry of family members */
/*  once the main member has been set up. Implemented */
/*  for Norfolk Ski Club on 22nd September 2000. */
/*  If an existing course student id has been entered */
/*  instead of a surname, retrieve the surname, address */
/*  and home tel. from the quoted record. If there is */
/*  no surname on the quoted record, do nothing - it */
/*  means its a centre member and this mechanism is */
/*  pointless if we already have all the details on */
/*  file in a family membership. */
if (READ(ref MASTER_REC, FL_STUDENTS, ANS)) {
if (MASTER_REC[3] != "") {
TEMP_REC[3] = MASTER_REC[3];
TEMP_REC[4] = MASTER_REC[4];
TEMP_REC[5] = MASTER_REC[5];
TEMP_REC[6] = MASTER_REC[6];
TEMP_REC[7] = MASTER_REC[7];
TEMP_REC[8] = MASTER_REC[8];
TEMP_REC[15] = MASTER_REC[10];
TEMP_REC[16] = MASTER_REC[11];
TEMP_REC[3] = MASTER_REC[3];
TEMP_REC[17] = MASTER_REC[20];
TEMP_REC[18] = MASTER_REC[21];
TEMP_REC[22] = MASTER_REC[38];
TEMP_REC[23] = MASTER_REC[39];
TEMP_REC[24] = MASTER_REC[40];
ANS = TEMP_REC[3];
OLD_FIELD_DATA = FIELD_DATA;
for(N = ADDRESS_LINE1_FIELD_NO; N <= POSTCODE_FIELD_NO; N += 1) {
FIELD_DATA = DATA_FIELDS[N];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
FIELD_DATA = DATA_FIELDS[HOME_TEL_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[WORK_TEL_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[CONTACT_NAME_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[CONTACT_TEL_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[DR_NAME_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[DR_TEL_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = DATA_FIELDS[KEYWORD_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
FIELD_DATA = OLD_FIELD_DATA;
L0200();
FIELD_NO = POSTCODE_FIELD_NO;
}
}
/*  DJA 25.4.02 Look for existing students with forename/surname match. */
/*              Introduced to limit the creation of duplicate student */
/*              entries. */
if (CHECK_FOR_DUPLICATES == "Y" && NEW_STUDENT) {
INSTRUCTION = "SSELECT FL.STUDENTS WITH 3 = \"" + ANS + "\" AND WITH 2 = \"" + TEMP_REC[2] + "\"";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
MATCH_LIST = "";
if (LIST_AVAILABLE) {
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
MATCH_LIST[1, -1] = ID;
} while (true);
nrf0 = 30;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
FL723 = new FL723(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY, ref MATCH_LIST);
if (INTERACT == VALID_DATA) {
/*  Existing student was selected */
PROG_MESS[2] = RETURNED_ANS;
MAIN_KEY = RETURNED_ANS;
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, MAIN_KEY)) { MAT(ref STUDENT_REC, ""); }
L8000();
/*  Build TEMP.REC */
ANS = STUDENT_REC[STUDENT_SURNAME];
if (ENROLMENT_CALL) {
VALUE = ANS;
INTERACT = FINISH;
} else {
INTERACT = VALID_DATA;
AMENDING = TRUE;
L0100();
L0300();
}
} else {
/*  Continue with creation of new student */
INTERACT = VALID_DATA;
L0100();
L0300();
}
}
}
return;
}
void L1400() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1500() {
/*   Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1600() {
/*   Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1700() {
/*   Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1800() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1900() {
/*   Gender validation Routine */
if (ANS == "M" || ANS == "F") {
/*  Does the gender tally with the Title */
// BEGIN CASE
// CASE
if (ANS == "M" && (TEMP_REC[1] == "MRS" || TEMP_REC[1] == "MISS" || TEMP_REC[1] == "MS")) {
INTERACT = INVALID_DATA;
nrf0 = 21;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (ANS == "F" && (TEMP_REC[1] == "MR" || TEMP_REC[1] == "MSTR" || TEMP_REC[1] == "MASTER")) {
INTERACT = INVALID_DATA;
nrf0 = 21;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
} else {
INTERACT = INVALID_DATA;
nrf0 = 20;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L2000() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2100() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2200() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2300() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2400() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2500() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2600() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2700() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2800() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2900() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3000() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3100() {
/*   Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3200() {
/*  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3300() {
/*  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L3400() {
/*  Validation routine */
INTERACT = VALID_DATA;
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MAIN_KEY)) {
STUDENT_IS_MEMBER = TRUE;
TEMP_REC[1] = MEMBERS_REC[MEMBER_TITLES][1, 1];
TEMP_REC[2] = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
TEMP_REC[3] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
TEMP_REC[4] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
TEMP_REC[5] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
TEMP_REC[6] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
TEMP_REC[7] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
TEMP_REC[8] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
TEMP_REC[9] = MEMBERS_REC[MEMBER_SEXES][1, 1];
TEMP_REC[10] = MEMBERS_REC[MEMBER_DOBS][1, 1];
TEMP_REC[15] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
TEMP_REC[16] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
} else {
STUDENT_IS_MEMBER = FALSE;
TEMP_REC[1] = STUDENT_REC[STUDENT_TITLE];
TEMP_REC[2] = STUDENT_REC[STUDENT_FORENAME];
TEMP_REC[3] = STUDENT_REC[STUDENT_SURNAME];
TEMP_REC[4] = STUDENT_REC[STUDENT_ADDRESS1];
TEMP_REC[5] = STUDENT_REC[STUDENT_ADDRESS2];
TEMP_REC[6] = STUDENT_REC[STUDENT_ADDRESS3];
TEMP_REC[7] = STUDENT_REC[STUDENT_ADDRESS4];
TEMP_REC[8] = STUDENT_REC[STUDENT_POST_CODE];
TEMP_REC[9] = STUDENT_REC[STUDENT_SEX];
TEMP_REC[10] = STUDENT_REC[STUDENT_DOB];
TEMP_REC[15] = STUDENT_REC[STUDENT_HOME_TEL];
TEMP_REC[16] = STUDENT_REC[STUDENT_WORK_TEL];
}
TEMP_REC[11] = STUDENT_REC[STUDENT_COMMENT1];
TEMP_REC[12] = STUDENT_REC[STUDENT_COMMENT2];
TEMP_REC[13] = STUDENT_REC[STUDENT_COMMENT3];
TEMP_REC[14] = STUDENT_REC[STUDENT_COMMENT4];
TEMP_REC[17] = STUDENT_REC[STUDENT_CONTACT_NAME];
TEMP_REC[18] = STUDENT_REC[STUDENT_CONTACT_PHONE];
TEMP_REC[19] = STUDENT_REC[STUDENT_MEDICAL1];
TEMP_REC[20] = STUDENT_REC[STUDENT_MEDICAL2];
TEMP_REC[21] = STUDENT_REC[STUDENT_MEDICAL3];
TEMP_REC[22] = STUDENT_REC[STUDENT_DOCTOR_NAME];
TEMP_REC[23] = STUDENT_REC[STUDENT_DOCTOR_TEL];
TEMP_REC[24] = STUDENT_REC[STUDENT_KEYWORD];
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
if (NOT(STUDENT_IS_MEMBER)) {
STUDENT_REC[STUDENT_TITLE] = TEMP_REC[1];
STUDENT_REC[STUDENT_FORENAME] = TEMP_REC[2];
STUDENT_REC[STUDENT_SURNAME] = TEMP_REC[3];
STUDENT_REC[STUDENT_ADDRESS1] = TEMP_REC[4];
STUDENT_REC[STUDENT_ADDRESS2] = TEMP_REC[5];
STUDENT_REC[STUDENT_ADDRESS3] = TEMP_REC[6];
STUDENT_REC[STUDENT_ADDRESS4] = TEMP_REC[7];
STUDENT_REC[STUDENT_POST_CODE] = TEMP_REC[8];
STUDENT_REC[STUDENT_SEX] = TEMP_REC[9];
STUDENT_REC[STUDENT_DOB] = TEMP_REC[10];
STUDENT_REC[STUDENT_HOME_TEL] = TEMP_REC[15];
STUDENT_REC[STUDENT_WORK_TEL] = TEMP_REC[16];
}
STUDENT_REC[STUDENT_COMMENT1] = TEMP_REC[11];
STUDENT_REC[STUDENT_COMMENT2] = TEMP_REC[12];
STUDENT_REC[STUDENT_COMMENT3] = TEMP_REC[13];
STUDENT_REC[STUDENT_COMMENT4] = TEMP_REC[14];
STUDENT_REC[STUDENT_CONTACT_NAME] = TEMP_REC[17];
STUDENT_REC[STUDENT_CONTACT_PHONE] = TEMP_REC[18];
STUDENT_REC[STUDENT_MEDICAL1] = TEMP_REC[19];
STUDENT_REC[STUDENT_MEDICAL2] = TEMP_REC[20];
STUDENT_REC[STUDENT_MEDICAL3] = TEMP_REC[21];
STUDENT_REC[STUDENT_DOCTOR_NAME] = TEMP_REC[22];
STUDENT_REC[STUDENT_DOCTOR_TEL] = TEMP_REC[23];
STUDENT_REC[STUDENT_KEYWORD] = TEMP_REC[24];
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
