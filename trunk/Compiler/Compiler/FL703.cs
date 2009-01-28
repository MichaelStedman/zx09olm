//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL703 : UvBase
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
readonly UvVar COURSE_MSTR_DESC = 1;
readonly UvVar COURSE_MSTR_DATES = 2;
readonly UvVar COURSE_MSTR_ACTIVITY_CODE = 3;
readonly UvVar COURSE_MSTR_CENTRE = 4;
readonly UvVar COURSE_MSTR_WET_DRY = 5;
readonly UvVar COURSE_MSTR_AWARD_CODE1 = 6;
readonly UvVar COURSE_MSTR_PAY_CODE = 7;
readonly UvVar COURSE_MSTR_AWARD_CODE2 = 8;
readonly UvVar COURSE_MSTR_AWARD_CODE3 = 9;
readonly UvVar COURSE_MSTR_AWARD_CODE4 = 10;
readonly UvVar COURSE_MSTR_TYPE = 11;
readonly UvVar COURSE_MSTR_WEB_TYPE = 12;
readonly UvVar COURSE_MSTR_WEB_BOOKABLE = 13;
readonly UvVar COURSE_MSTR_EXCEPTIONS = 14;
readonly UvVar COURSE_DET_SESSIONS = 1;
readonly UvVar COURSE_DET_END = 2;
readonly UvVar COURSE_DET_BOOKING_DATES = 3;
readonly UvVar COURSE_DET_CLOSE_DATE = 4;
readonly UvVar COURSE_DET_SCHEDULE_CODE = 5;
readonly UvVar COURSE_DET_MAXIMUM_PLACES = 6;
readonly UvVar COURSE_DET_MINIMUM_PLACES = 7;
readonly UvVar COURSE_DET_FEE_CODE = 8;
readonly UvVar COURSE_DET_START_TIME = 9;
readonly UvVar COURSE_DET_END_TIME = 10;
readonly UvVar COURSE_DET_FREQUENCY = 11;
readonly UvVar COURSE_DET_DAYS = 12;
readonly UvVar COURSE_DET_INSTRUCTOR = 13;
readonly UvVar COURSE_DET_COMMENTS = 14;
readonly UvVar COURSE_DET_BLOCK_REF = 15;
readonly UvVar COURSE_DET_VACANCIES = 16;
readonly UvVar COURSE_DET_GROUP_NAMES = 17;
readonly UvVar COURSE_DET_GROUP_NAMES_SUMM = 18;
readonly UvVar COURSE_DET_GROUP_MAXIMUMS = 19;
readonly UvVar COURSE_DET_GROUP_VACANCIES = 20;
readonly UvVar COURSE_DET_STUDENT_IDS = 21;
readonly UvVar COURSE_DET_INSTRUCTOR2 = 22;
readonly UvVar COURSE_DET_UNAVAILABLE_SESSIONS = 23;
readonly UvVar COURSE_DET_SESSION_DATES = 24;
readonly UvVar COURSE_DET_SESSION_FLAGS = 25;
readonly UvVar ENROL_CONCESSION = 1;
readonly UvVar ENROL_PRICE = 2;
readonly UvVar ENROL_AWARD = 3;
readonly UvVar ENROL_ODD_INSTALMENT = 4;
readonly UvVar ENROL_OTHER_INSTALMENT = 5;
readonly UvVar ENROL_NO_INSTALMENTS = 6;
readonly UvVar ENROL_FULL_PRICE = 7;
readonly UvVar ENROL_FEE_OVERRIDE_USER = 8;
readonly UvVar ENROL_INST_PLAN_TOTAL = 9;
readonly UvVar ENROL_INST_FIRST_DUE = 10;
readonly UvVar ENROL_INST_NUMBER = 11;
readonly UvVar ENROL_INST_VALUE = 12;
readonly UvVar ENROL_INST_FREQUENCY = 13;
readonly UvVar ENROL_INST_DATES = 14;
readonly UvVar ENROL_INST_AMOUNTS = 15;
readonly UvVar ENROL_PREFERRED_COURSE1 = 16;
readonly UvVar ENROL_PREFERRED_COURSE2 = 17;
readonly UvVar ENROL_PREFERRED_COURSE3 = 18;
readonly UvVar ENROL_PREFERENCES_DATE = 19;
readonly UvVar ENROL_PREFERENCES_TIME = 20;
readonly UvVar ENROL_SESSIONS = 21;
readonly UvVar ENROL_SESSION_FEES = 22;
readonly UvVar ENROL_TOTAL_REDEMPTION = 23;
readonly UvVar ENROL_TOTAL_POINTS = 24;
readonly UvVar ENROL_BONUS_AWARD = 25;
readonly UvVar ENROL_PROMOTION = 26;
readonly UvVar ENROL_PERMITTED_LEVEL = 27;
readonly UvVar ENROL_MUST_PROGRESS = 28;
readonly UvVar ENROL_WEB = 29;
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
readonly UvVar FL_TICKET_FEES = 12;
readonly UvVar TICK_FEES_DESC = 1;
readonly UvVar TICK_FEES_PRICE = 2;
readonly UvVar TICK_FEES_GLCODE = 3;
readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
readonly UvVar TICK_FEES_OFF_PRICES = 5;
readonly UvVar TICK_FEES_OFF_START_MON = 6;
readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
readonly UvVar TICK_FEES_OFF_START_SAT = 8;
readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
readonly UvVar TICK_FEES_OFF_START_SUN = 10;
readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
readonly UvVar TICK_FEES_NEW_PRICE = 13;
readonly UvVar TICK_FEES_OPEN_RANGE = 14;
readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
readonly UvVar TICK_FEES_VAT_QUESTION = 20;
readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
readonly UvVar TICK_FEES_GROUP_CODE = 22;
readonly UvVar TICK_FEES_HEADCOUNT = 23;
readonly UvVar TICK_FEES_CONCESSIONS = 24;
readonly UvVar TICK_FEES_PEAK_PRICES = 25;
readonly UvVar TICK_FEES_OFF1_PRICES = 26;
readonly UvVar TICK_FEES_OFF2_PRICES = 27;
readonly UvVar TICK_FEES_OFF3_PRICES = 28;
readonly UvVar TICK_FEES_OFF4_PRICES = 29;
readonly UvVar TICK_FEES_SPLIT_OWED = 30;
readonly UvVar TICK_FEES_SPLIT_PAID = 31;
readonly UvVar TICK_FEES_SPORTS = 32;
readonly UvVar TICK_FEES_RESALE_RATE = 33;
readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
readonly UvVar TICK_FEES_TEXT = 35;
readonly UvVar TICK_FEES_MEMBER_REQ = 36;
readonly UvVar TICK_FEES_STYLE = 37;
readonly UvVar TICK_FEES_GROUPED = 38;
readonly UvVar CONCESSION = 1;
readonly UvVar MAX_PLACES = 2;
readonly UvVar ACT_PLACES = 3;
readonly UvVar LEFT_PLACES = 4;
readonly UvVar PERC_PLACES = 5;
readonly UvVar MAX_INCOME = 6;
readonly UvVar EXP_INCOME = 7;
readonly UvVar ACT_INCOME = 8;
readonly UvVar OS_INCOME = 9;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] TEMP_REC = new UvVar[50];
UvVar[] COLS = new UvVar[9];
UvVar[] JUSTS = new UvVar[9];
UvVar[] CONVS = new UvVar[9];
UvVar[] TOTALS = new UvVar[9];
UvVar[,] PRT_LINE = new UvVar[9,8];
UvVar[] MAX_FEES = new UvVar[8];
#endregion
#region Variables
UvVar NEW_COURSE = "";
UvVar DIM_VID = "";
UvVar REV_UND_VID = "";
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
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_ENROLMENT = "";
UvVar N = "";
UvVar FL_STUDENTS = "";
UvVar FIRST_LINE = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar MAIN_KEY = "";
UvVar COURSE_DATE = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
UvVar INPUT_LINE = "";
UvVar ANS = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
FL006 FL006;
UvVar ST_CONVERSION = "";
UvVar ST_JUST = "";
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
UvVar CONTROL_TICKET_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar PNTR = "";
UvVar FEE_DATE = "";
UvVar CENTRE_TICKET_CODE = "";
UvVar NO_OF_CONCESSIONS = "";
UvVar CONCESSION_NO = "";
UvVar GROUP_NAME = "";
UvVar POS = "";
UvVar COURSE_DETAIL_ID = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_NO = "";
UvVar STUDENT_ID = "";
UvVar ENROL_ID = "";
UvVar FEE_ADJUSTMENTS = "";
UvVar ORIGINAL_FEES = "";
UvVar PAYMENTS = "";
UvVar REFUNDS = "";
UvVar UNENROLMENT = "";
UvVar COURSE_BALANCE = "";
UvVar TRANS_NO = "";
UvVar GROUP = "";
UvVar GROUPS_EXIST = "";
UvVar NO_OF_GROUPS = "";
UvVar COL = "";
UvVar JUST = "";
UvVar CONV = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL703(ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar NEW_COURSE) {
this.COURSE_MSTR_REC = COURSE_MSTR_REC;
this.COURSE_DET_REC = COURSE_DET_REC;
this.NEW_COURSE = NEW_COURSE;
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
/*     COURSE STATISTICS - PAGE 3 (NEW MODULE) */
/*     Generated code (allowing for input fields) is intact although this */
/*     is a report-only display.  Temp.rec is NOT used. */
PROMPT("");
PROGRAM = "FL703";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
#region INCLUDE FL.FILES FL.COURSE.DETAILS
#region INCLUDE FL.FILES FL.COURSE.DETAILS.EQU
if (!OPEN("FL.COURSE.DETAILS", out FL_COURSE_DETAILS)) { STOP("201", "FL.COURSE.DETAILS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.DETAILS.DIM

#endregion
#region INCLUDE FL.FILES FL.COURSE.DETAILS.VAR

/*  Course maintenance, page 2, column 1 fields :- */
/*  Course maintenance, page 2, column 2 fields :- */
/*  The MV's in the following attribute correspond with */
/*  COURSE.DET.BOOKING.DATES and are only used for activity */
/*  day courses */
/*  The following attributes are also used only for activity */
/*  days. There is one attribute per date on which the course */
/*  runs, i.e. a fully expanded list of all bookable dates. */
/*  The second of the two attributes holds "Y" indicators to */
/*  show available sessions, subvalued within each date. */
/*  These attributes will be referenced when enrolling. */

#endregion

#endregion
#region INCLUDE FL.FILES FL.ENROLMENT
if (!OPEN("FL.ENROLMENT", out FL_ENROLMENT)) { STOP("201", "FL.ENROLMENT"); }

/*  Keep in line with main record */
/*  DJA 9.11.00  Concession is MV'd for activity days */
/*  The following three variables become redundant after Version 1.1 */
/*  Instalment variables */
/*  The next three values may consist of two multivalues :- */
/*   mv1 = Course Date * Course Code */
/*   mv2 = Code showing status (if processed) : */
/*           S = Successful */
/*           U = Unsuccessful */
/*           P = transferred to Priority waiting list */
/*           N = Not required */
/*  The following attribute is multivalued per session date */
/*  and then subvalued per session (1-4). It maps directly */
/*  to COURSE.DET.SESSION.DATES on FL.COURSE.DETAILS */
/*  Loyalty Bonus Scheme - redemption */
/*  Loyalty Bonus Scheme - award */
/*  The promotion name is needed for reversing both */
/*  awards and redemptions */
/*  New fields to store permitted levels for web-re-enrolment */
/*  'P'ending or 'W'eb (completed) :- */

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
MAT(ref TEMP_REC, "");
/* ******************* */
/*     DEFINE ARRAYS  * */
/* ******************* */
/*  One element per display Column */
/*  One element per display Column */
/*  One element per display Column */
/*  One element per display Column */
/*  One element per display Position */
/*  One element per Group */
COLS[CONCESSION] = 3;
COLS[MAX_PLACES] = 21;
COLS[ACT_PLACES] = 26;
COLS[LEFT_PLACES] = 32;
COLS[PERC_PLACES] = 35;
COLS[MAX_INCOME] = 41;
COLS[EXP_INCOME] = 51;
COLS[ACT_INCOME] = 61;
COLS[OS_INCOME] = 69;
JUSTS[CONCESSION] = "L#14";
JUSTS[MAX_PLACES] = "R#2";
JUSTS[ACT_PLACES] = "R#2";
JUSTS[LEFT_PLACES] = "R#2";
JUSTS[PERC_PLACES] = "R#3";
JUSTS[MAX_INCOME] = "R#8";
JUSTS[EXP_INCOME] = "R#8";
JUSTS[ACT_INCOME] = "R#8";
JUSTS[OS_INCOME] = "R#8";
MAT(ref CONVS, "MD2");
CONVS[CONCESSION] = "";
CONVS[MAX_PLACES] = "MD0";
CONVS[ACT_PLACES] = "MD0";
CONVS[LEFT_PLACES] = "MD0";
CONVS[PERC_PLACES] = "MD0";
FIRST_LINE = 7;
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
MAT(ref PRT_LINE, "");
MAT(ref TOTALS, "");
MAT(ref MAX_FEES, 0);
do {
INTERACT = VALID_DATA;
L0100();
MAIN_KEY = PROG_MESS[2];
COURSE_DATE = PROG_MESS[3];
L8000();
/*  Build statisics report */
AMENDING = TRUE;
L0300();
/*  Display data */
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
/* **      IF MAIN.KEY # "" AND INTERACT # EXIT THEN */
/* **      END */
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
INPUT_LINE = "      Enter Page no or 'F' to finish ";
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
INTERACT = FINISH;
PROG_MESS[1] = 1;
}// CASE
else if (ANS == "F") {
PROG_MESS[1] = "";
INTERACT = FINISH;
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
else if (ANS == COMMON.CLR && ST_MANDATORY == "" && FIELD_NO < 16) {
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
/*   DUMMY VALIDATION ROUTINE */
INTERACT = VALID_DATA;
return;
/* ******************************** */
}
void L8000() {
/*   Build statisics          * */
/* ******************************** */
TOTALS[MAX_PLACES] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
TOTALS[LEFT_PLACES] = COURSE_DET_REC[COURSE_DET_VACANCIES];
/*  Get concession information */
CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE];
if (READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE)) {
if (LOCATE(COURSE_DATE, CONTROL_FEE_REC, 0, 0, 1, ref PNTR, "AR")) {
FEE_DATE = COURSE_DATE;
} else {
PNTR = PNTR - 1;
if (PNTR <= 0) { PNTR = 1; }
FEE_DATE = CONTROL_FEE_REC[PNTR];
}
CENTRE_TICKET_CODE = COMMON.CENTRE + "*C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE] + "*" + FEE_DATE;
if (!MATREAD(ref TICK_FEES_REC, COMMON.FILES[FL_TICKET_FEES], CENTRE_TICKET_CODE)) { MAT(ref TICK_FEES_REC, INIT); }
} else {
MAT(ref TICK_FEES_REC, INIT);
}
/*     Find the maximum fee for each group to calculate 'maximum' income */
NO_OF_CONCESSIONS = DCOUNT(TICK_FEES_REC[TICK_FEES_CONCESSIONS], VM);
for(CONCESSION_NO = 1; CONCESSION_NO <= NO_OF_CONCESSIONS; CONCESSION_NO += 1) {
GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, CONCESSION_NO];
if (!LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref POS, "AL")) { POS = 1; }
if (TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESSION_NO] > MAX_FEES[POS]) {
MAX_FEES[POS] = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONCESSION_NO];
}
}
/*     Get the Expected and Actual income from the students on this course */
COURSE_DETAIL_ID = COURSE_DATE + "*" + MAIN_KEY;
NO_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
for(STUDENT_NO = 1; STUDENT_NO <= NO_OF_STUDENTS; STUDENT_NO += 1) {
STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_NO];
ENROL_ID = COURSE_DETAIL_ID + "*" + STUDENT_ID;
if (MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) {
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
/*  Extract course balance */
/*  Unenrolment fees are included here for completeness, but if */
/*  unenrolled the student number won't be on course details so */
/*  they won't be identified anyway */
FEE_ADJUSTMENTS = 0;
ORIGINAL_FEES = 0;
PAYMENTS = 0;
REFUNDS = 0;
UNENROLMENT = 0;
COURSE_BALANCE = 0;
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == COURSE_DETAIL_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "O") {
ORIGINAL_FEES = ORIGINAL_FEES + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "D") {
UNENROLMENT = UNENROLMENT + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P") {
PAYMENTS = PAYMENTS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "R") {
REFUNDS = REFUNDS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "A") {
FEE_ADJUSTMENTS = FEE_ADJUSTMENTS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
// END CASE
}
TRANS_NO = TRANS_NO + 1;
} while (true);
if (LOCATE(ENROL_REC[ENROL_CONCESSION][1, 1], TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref POS, "AL")) {
GROUP_NAME = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, POS];
if (!LOCATE(GROUP_NAME, COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], 1, 0, 1, ref GROUP, "AL")) { GROUP = 1; }
} else {
GROUP = 1;
}
PRT_LINE[GROUP, EXP_INCOME] = PRT_LINE[GROUP, EXP_INCOME] + ORIGINAL_FEES + UNENROLMENT + FEE_ADJUSTMENTS;
PRT_LINE[GROUP, ACT_INCOME] = PRT_LINE[GROUP, ACT_INCOME] - PAYMENTS - REFUNDS;
PRT_LINE[GROUP, OS_INCOME] = PRT_LINE[GROUP, OS_INCOME] + ORIGINAL_FEES + UNENROLMENT + FEE_ADJUSTMENTS + PAYMENTS + REFUNDS;
}
}
/*     Store the data for each group */
GROUPS_EXIST = FALSE;
NO_OF_GROUPS = DCOUNT(COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM], VM);
N = 1;
do {
if (GROUPS_EXIST || N > NO_OF_GROUPS) break;
if (COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, N] != "") { GROUPS_EXIST = TRUE; }
N = N + 1;
} while (true);
if (NOT(GROUPS_EXIST)) { NO_OF_GROUPS = 1; }
for(GROUP = 1; GROUP <= NO_OF_GROUPS; GROUP += 1) {
PRT_LINE[GROUP, CONCESSION] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, GROUP];
if (GROUPS_EXIST) {
PRT_LINE[GROUP, MAX_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, GROUP];
PRT_LINE[GROUP, LEFT_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP];
PRT_LINE[GROUP, ACT_PLACES] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, GROUP] - COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, GROUP];
} else {
PRT_LINE[1, MAX_PLACES] = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
PRT_LINE[1, LEFT_PLACES] = COURSE_DET_REC[COURSE_DET_VACANCIES];
PRT_LINE[1, ACT_PLACES] = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
}
if (PRT_LINE[GROUP, ACT_PLACES] + 0 != 0) {
PRT_LINE[GROUP, PERC_PLACES] = PRT_LINE[GROUP, ACT_PLACES] / PRT_LINE[GROUP, MAX_PLACES] * 100;
} else {
PRT_LINE[GROUP, PERC_PLACES] = 0;
}
PRT_LINE[GROUP, MAX_INCOME] = PRT_LINE[GROUP, MAX_PLACES] * MAX_FEES[GROUP];
/*     Create the column totals */
TOTALS[ACT_PLACES] = TOTALS[ACT_PLACES] + PRT_LINE[GROUP, ACT_PLACES];
/* DJA 25.6.03!* DJA 15.11.01 */
/* DJA 25.6.03!TOTALS(MAX.INCOME) = TOTALS(MAX.INCOME) + PRT.LINE(GROUP,MAX.INCOME) */
if (PRT_LINE[GROUP, MAX_INCOME] > TOTALS[MAX_INCOME]) {
TOTALS[MAX_INCOME] = PRT_LINE[GROUP, MAX_INCOME];
}
TOTALS[EXP_INCOME] = TOTALS[EXP_INCOME] + PRT_LINE[GROUP, EXP_INCOME];
TOTALS[ACT_INCOME] = TOTALS[ACT_INCOME] + PRT_LINE[GROUP, ACT_INCOME];
TOTALS[OS_INCOME] = TOTALS[OS_INCOME] + PRT_LINE[GROUP, OS_INCOME];
}
if (TOTALS[MAX_PLACES] + 0 != 0) {
TOTALS[PERC_PLACES] = TOTALS[ACT_PLACES] / TOTALS[MAX_PLACES] * 100;
}
PRINT(AT(0, 6) + REV_UND_VID);
if (NO_OF_GROUPS >= 1) {
for(GROUP = 1; GROUP <= 8; GROUP += 1) {
if (PRT_LINE[GROUP, CONCESSION] != "") {
for(I = 1; I <= 9; I += 1) {
COL = COLS[I];
JUST = JUSTS[I];
CONV = CONVS[I];
PRINT(AT(COL, GROUP + FIRST_LINE));
if (CONV != "") {
PRINT(FORMAT(OCONV(PRT_LINE[GROUP, I], CONV), JUST));
} else {
PRINT(FORMAT(PRT_LINE[GROUP, I], JUST));
}
}
}
}
}
PRINT(AT(0, 17) + DIM_VID);
for(I = 2; I <= 9; I += 1) {
COL = COLS[I];
JUST = JUSTS[I];
CONV = CONVS[I];
PRINT(AT(COL, 17));
if (CONV != "") {
PRINT(FORMAT(OCONV(TOTALS[I], CONV), JUST));
} else {
PRINT(FORMAT(TOTALS[I], JUST));
}
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
