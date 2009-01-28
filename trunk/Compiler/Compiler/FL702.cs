//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL702 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar NEW_COURSE = "";
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
UvVar CONCESSION_ROW = "";
UvVar CONCESSION_LENGTH = "";
UvVar CONCESSION_JUST = "";
UvVar CONCESSION_COL = "";
UvVar TOTAL_MAX_COL = "";
UvVar TOTAL_VAC_COL = "";
UvVar TOTAL_ROW = "";
UvVar MAX_JUST = "";
UvVar VAC_JUST = "";
UvVar MAX_TOTAL = "";
UvVar VAC_TOTAL = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar MAIN_KEY = "";
UvVar COURSE_DATE = "";
UvVar CONTROL_TICKET_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar PNTR = "";
UvVar FEE_DATE = "";
UvVar CENTRE_TICKET_CODE = "";
UvVar CNT = "";
UvVar ROW = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
UvVar SEARCH_STRING = "";
UvVar ST_ATT = "";
UvVar START_FIELD_NO = "";
UvVar FIELD_DATA = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
UvVar NO_ENROLLED = "";
UvVar ANS = "";
UvVar ATT = "";
UvVar TEMP_LIST = "";
UvVar LIST_POS = "";
FL006 FL006;
UvVar SUMM_ATT = "";
UvVar GROUP_NAME = "";
UvVar INPUT_LINE = "";
UvVar OK_TO_FILE = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar MDISL = "";
UvVar ST_LENGTH = "";
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar OLD_VALUE = "";
UvVar OLD_FIELD_NO = "";
UvVar OLD_FIELD_DATA = "";
UvVar PROMPT_NO = "";
FL000_10 FL000_10;
UvVar PRINT_LINE = "";
UvVar ST_ATT_MV = "";
UvVar ST_VALIDATION = "";
UvVar I = "";
UvVar DISP_ATT_MV = "";
UvVar DISP_ATT = "";
UvVar DISP_MV = "";
UvVar DISP_COL = "";
UvVar DISP_ROW = "";
UvVar DISP_VALIDATION = "";
UvVar DISP_JUST = "";
UvVar DISP_CONVERSION = "";
UvVar MVC = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL702(ref UvVar[] COURSE_MSTR_REC, ref UvVar[] COURSE_DET_REC, ref UvVar NEW_COURSE) {
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
/*     COURSE RESTRICTIONS - PAGE 2 (NEW MODULE) */
PROMPT("");
PROGRAM = "FL702";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
CONCESSION_ROW = 5;
CONCESSION_LENGTH = 13;
CONCESSION_JUST = "L#" + CONCESSION_LENGTH;
CONCESSION_COL = 7;
TOTAL_MAX_COL = 52;
TOTAL_VAC_COL = 61;
TOTAL_ROW = 13;
MAX_JUST = "R#4";
VAC_JUST = "R#4";
/*  These totals are currently maintained but not displayed as they have */
/*  no meaning */
MAX_TOTAL = 0;
VAC_TOTAL = 0;
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
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

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
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
do {
INTERACT = VALID_DATA;
L0100();
MAIN_KEY = PROG_MESS[2];
COURSE_DATE = PROG_MESS[3];
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
CNT = 1;
PRINT(AT(CONCESSION_COL - 1, CONCESSION_ROW) + NRM_VID);
if (TICK_FEES_REC[TICK_FEES_CONCESSIONS] != "") {
for(ROW = CONCESSION_ROW; ROW <= (CONCESSION_ROW + 14); ROW += 1) {
PRINT(AT(CONCESSION_COL, ROW) + FORMAT(TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, CNT], CONCESSION_JUST));
CNT = CNT + 1;
}
}
L8000();
/*  Build temp.rec */
/*  Set 'amending' flag */
if (TEMP_REC[1] == "" && TEMP_REC[16] == "") {
AMENDING = FALSE;
} else {
AMENDING = TRUE;
L0300();
/*  Display data */
}
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
/*  Check that the case statement below has not indicated that all */
/*  required data has been entered */
if (INTERACT != LIMIT) {
L0060();
}
if (INTERACT || AMENDING || FIELD_NO == MAX_FIELDS || INTERACT == LIMIT) break;
SEARCH_STRING = "." + ST_ATT + ".";
// BEGIN CASE
/* DJA 15.6.99*CASE FIELD.NO < 15 AND INTERACT = VALID.DATA AND TICK.FEES.CONCESSIONS<1,(ST.ATT+1)> = "" */
// CASE
if (INTERACT == VALID_DATA && ((FIELD_NO < 15 && TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, (ST_ATT + 1)] == "") || FIELD_NO == 15)) {
/*  When all concessions have been allocated, jump to 'restrictions' */
/*  and clear remaining dots in the concession column. */
/*  It is also necessary at this point to generate the summarised list */
/*  of group names for use on the right hand side of the screen, and to */
/*  put these into 'temp.rec' and also to display them */
START_FIELD_NO = FIELD_NO + 1;
for(FIELD_NO = START_FIELD_NO; FIELD_NO <= 15; FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
}
L0040();
}// CASE
else if (INDEX(".17.20.23.26.29.32.35.38.", SEARCH_STRING, 1) && TEMP_REC[ST_ATT + 2] == "") {
/*  Jump to foot of screen when next group name (in generated list) is null */
/*  Also, clear remaining dots from screen */
START_FIELD_NO = FIELD_NO + 3;
for(FIELD_NO = START_FIELD_NO; FIELD_NO <= 38; FIELD_NO += 3) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
/*  ...and clear vacancy field too */
FIELD_DATA = DATA_FIELDS[FIELD_NO + 1];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
}
INTERACT = LIMIT;
}// CASE
else if (INDEX(".17.20.23.26.29.32.35.38.", SEARCH_STRING, 1)) {
/*  Group maximum fields ; jump over the group names (which are generated) */
/*  and over the group vacancies (which are calculated) */
if (FIELD_NO > MAX_FIELDS) {
INTERACT = LIMIT;
} else {
FIELD_NO = FIELD_NO + 3;
}
}// CASE
else if (OTHERWISE) {
FIELD_NO = FIELD_NO + 1;
}
// END CASE
} while (true);
NO_ENROLLED = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
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
else if (FIELD_NO == MAX_FIELDS || INTERACT == LIMIT) {
L0050();
}// CASE
else if (FIELD_NO <= 15 && NO_ENROLLED < 1 && INTERACT == VALID_DATA && AMENDING == TRUE && NOT(ANS == "")) {
/*  Clear and re-calc the concession groupings. */
for(ATT = 16; ATT <= 39; ATT += 1) {
TEMP_REC[ATT] = "";
}
for(FIELD_NO = 16; FIELD_NO <= 39; FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT("", ST_JUST));
}
L0040();
/*              GOSUB 0050 */
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
/* ************************************************ */
}
void L0040() {
/*  Recalculate concession groupings          * */
/* ************************************************ */
TEMP_LIST = "";
for(ATT = 1; ATT <= 15; ATT += 1) {
if (TEMP_REC[ATT] != "") {
if (!(LOCATE(TEMP_REC[ATT], TEMP_LIST, 0, 0, 1, ref LIST_POS, "AL"))) {
TEMP_LIST[-1] = TEMP_REC[ATT];
}
}
}
/*  Warn that if there's more than 8 groups, only the 1st eight are */
/*  recognised */
if (TEMP_LIST[9] != "") {
nrf0 = 9;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
if (TEMP_LIST != "") {
ATT = 1;
SUMM_ATT = 16;
do {
GROUP_NAME = TEMP_LIST[ATT];
if (GROUP_NAME == "" || SUMM_ATT > 37) break;
TEMP_REC[SUMM_ATT] = GROUP_NAME;
SUMM_ATT = SUMM_ATT + 3;
ATT = ATT + 1;
} while (true);
}
for(FIELD_NO = 16; FIELD_NO <= 37; FIELD_NO += 3) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
FIELD_NO = 17;
AMENDING = FALSE;
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
INPUT_LINE = "      Enter Field no, Page no or 'F' to finish ";
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
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = 3; }
}// CASE
else if (ANS == "F") {
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = ""; }
}// CASE
else if (ANS.Substring(1, 1) == "P" || ANS.Substring(1, 1) == "p") {
L0055();
if (INTERACT == FINISH) { PROG_MESS[1] = ANS.Substring(2, 1); }
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= MAX_FIELDS - FIRST_FIELD + 1) {
/*  Translate amendment nos > 15 into appropriate field nos.  There are 2 */
/*  inputs per amendment no. in this range */
if (ANS > 15) {
FIELD_NO = 17 + ((ANS - 16) * 3);
/*  Check this is a valid, summarised group name */
if (TEMP_REC[FIELD_NO] == "") {
nrf0 = 6;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
}
} else {
NO_ENROLLED = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
if (NO_ENROLLED > 0) {
INTERACT = INVALID_DATA;
nrf0 = 10;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
FIELD_NO = ANS + FIRST_FIELD - 1;
/*  Check this is a valid concession group */
if (TICK_FEES_REC[TICK_FEES_CONCESSIONS][1, FIELD_NO] == "") {
INTERACT = INVALID_DATA;
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
}
}
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* **************************************************** */
}
void L0055() {
/*  Check its ok for the user to leave page 2     * */
/* **************************************************** */
OK_TO_FILE = TRUE;
/* **IF MAX.TOTAL > COURSE.DET.MAXIMUM.PLACES THEN */
/* ** OK.TO.FILE = FALSE */
/* ** CALL FL006(PROGRAM,8,COURSE.DET.MAXIMUM.PLACES) */
/* **END */
if (OK_TO_FILE == TRUE) {
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
/*  Force all entries through the validation code */
/* *   CASE ANS = "" AND VALUE = "" AND ST.MANDATORY = "" AND FIELD.NO > 1 */
/* *     INTERACT = VALID.DATA */
}// CASE
else if (OTHERWISE) {
#region ON FIELD_NO GOSUB ...
switch ((int)FIELD_NO) {
case 1: L1000(); break;
case 2: L1000(); break;
case 3: L1000(); break;
case 4: L1000(); break;
case 5: L1000(); break;
case 6: L1000(); break;
case 7: L1000(); break;
case 8: L1000(); break;
case 9: L1000(); break;
case 10: L1000(); break;
case 11: L1000(); break;
case 12: L1000(); break;
case 13: L1000(); break;
case 14: L1000(); break;
case 15: L1000(); break;
case 16: L2500(); break;
case 17: L2600(); break;
case 18: L2700(); break;
case 19: L2500(); break;
case 20: L2600(); break;
case 21: L2700(); break;
case 22: L2500(); break;
case 23: L2600(); break;
case 24: L2700(); break;
case 25: L2500(); break;
case 26: L2600(); break;
case 27: L2700(); break;
case 28: L2500(); break;
case 29: L2600(); break;
case 30: L2700(); break;
case 31: L2500(); break;
case 32: L2600(); break;
case 33: L2700(); break;
case 34: L2500(); break;
case 35: L2600(); break;
case 36: L2700(); break;
case 37: L2500(); break;
case 38: L2600(); break;
case 39: L2700(); break;
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
OLD_VALUE = TEMP_REC[ST_ATT];
TEMP_REC[ST_ATT][1, ST_MV] = VALUE;
/*  When group maximums are entered for the first time or amended, the */
/*  group vacancies need to be set/adjusted */
SEARCH_STRING = "." + ST_ATT + ".";
if (INDEX(".17.20.23.26.29.32.35.38.", SEARCH_STRING, 1)) {
if (NEW_COURSE) {
if (TEMP_REC[ST_ATT + 1] == "") {
TEMP_REC[ST_ATT + 1] = VALUE;
VAC_TOTAL = VAC_TOTAL + VALUE;
} else {
TEMP_REC[ST_ATT + 1] = TEMP_REC[ST_ATT + 1] - OLD_VALUE + VALUE;
VAC_TOTAL = VAC_TOTAL - OLD_VALUE + VALUE;
}
} else {
/*  Adjust existing vacancies */
TEMP_REC[ST_ATT + 1] = TEMP_REC[ST_ATT + 1] - OLD_VALUE + VALUE;
VAC_TOTAL = VAC_TOTAL - OLD_VALUE + VALUE;
}
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
FIELD_NO = FIELD_NO + 1;
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
/*  Reset variables */
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
L3100();
/*  Redisplay vacant total */
}
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
ST_VALIDATION = FIELD_DATA[1, 11];
return;
/* ********************************* */
}
void L0300() {
/*   DISPLAY ITEM CONTENTS */
/* ********************************* */
MAX_TOTAL = 0;
VAC_TOTAL = 0;
for(I = 1; I <= MAX_FIELDS; I += 1) {
FIELD_DATA = DATA_FIELDS[I];
DISP_ATT_MV = FIELD_DATA[1, 5];
DISP_ATT = FIELD(DISP_ATT_MV, ",", 1);
/* *     IF DISP.ATT # 0 THEN */
DISP_MV = FIELD(DISP_ATT_MV, ",", 2);
DISP_COL = FIELD_DATA[1, 1] + 2 + LEN(FIELD_DATA[1, 3]);
DISP_ROW = FIELD_DATA[1, 2];
DISP_VALIDATION = FIELD_DATA[1, 11];
PRINT(AT(DISP_COL - 2, DISP_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINT(AT(DISP_COL, DISP_ROW));
if (FIELD_DATA[1, 8] == "R") {
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4];
} else {
DISP_JUST = FIELD_DATA[1, 8] + "#" + FIELD_DATA[1, 4] + 1;
}
DISP_CONVERSION = FIELD_DATA[1, 9];
// BEGIN CASE
// CASE
if (DISP_ATT == 0) {
PRINT(FORMAT(MAIN_KEY, DISP_JUST));
}// CASE
else if (DISP_VALIDATION == "DM") {
/*  Max places field */
MAX_TOTAL = MAX_TOTAL + TEMP_REC[DISP_ATT];
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}// CASE
else if (DISP_VALIDATION == "DV") {
/*  Vacant places field */
VAC_TOTAL = VAC_TOTAL + TEMP_REC[DISP_ATT];
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
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
/*  Print maximum and vacant place totals on right hand side of screen */
L3000();
/*  Print max total */
L3100();
/*  Print vacant total */
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
}
void L1000() {
/*   Concession group Validation Routine */
// BEGIN CASE
// CASE
if (AMENDING == FALSE && (ANS == "" || ANS == COMMON.CLR)) {
INTERACT = VALID_DATA;
ANS = "";
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
return;
}
void L2500() {
/*   GROUP 1 RESTRICTION - DUMMY ROUTINE */
return;
}
void L2600() {
/*  GROUP 1 MAX */
// BEGIN CASE
// CASE
if (ANS == "" && VALUE != "") {
INTERACT = VALID_DATA;
VALUE = ANS;
}// CASE
else if (ANS == "" && TEMP_REC[ST_ATT - 1] != "") {
/*  Loop to ascertain how many of the maximum course places are available */
/*  and use this as the default. */
/* **PLACES.TOTAL = 0 */
/* **FOR ATT = 17 TO 38 STEP 3 */
/* ** PLACES.TOTAL = PLACES.TOTAL + TEMP.REC(ATT) */
/* **NEXT ATT */
/* **       ANS = COURSE.DET.MAXIMUM.PLACES - PLACES.TOTAL */
ANS = COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES];
MAX_TOTAL = MAX_TOTAL + ANS - VALUE;
L3000();
/*  Update max total on screen */
INTERACT = VALID_DATA;
}// CASE
else if (NUM(ANS)) {
if (ANS > COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES]) {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
} else {
INTERACT = VALID_DATA;
MAX_TOTAL = MAX_TOTAL + ANS - VALUE;
L3000();
/*  Update max total on screen */
}
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
return;
}
void L2700() {
/*  DUMMY VALIDATION ROUTINE FOR GROUP VACANCY FIELDS */
return;
/* **************************************** */
}
void L3000() {
/*   Update on-screen max total       * */
/* **************************************** */
/* *PRINT @(TOTAL.MAX.COL,TOTAL.ROW) : MAX.TOTAL MAX.JUST : */
return;
/* **************************************** */
}
void L3100() {
/*   Update on-screen vacancy total   * */
/* **************************************** */
/* *PRINT @(TOTAL.VAC.COL,TOTAL.ROW) : VAC.TOTAL VAC.JUST : */
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
TEMP_REC[1] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 1];
TEMP_REC[2] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 2];
TEMP_REC[3] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 3];
TEMP_REC[4] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 4];
TEMP_REC[5] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 5];
TEMP_REC[6] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 6];
TEMP_REC[7] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 7];
TEMP_REC[8] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 8];
TEMP_REC[9] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 9];
TEMP_REC[10] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 10];
TEMP_REC[11] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 11];
TEMP_REC[12] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 12];
TEMP_REC[13] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 13];
TEMP_REC[14] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 14];
TEMP_REC[15] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 15];
MVC = 1;
for(ATT = 16; ATT <= 37; ATT += 3) {
TEMP_REC[ATT] = COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, MVC];
TEMP_REC[ATT + 1] = COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, MVC];
TEMP_REC[ATT + 2] = COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, MVC];
MVC = MVC + 1;
/*  Check if there's a corresponding group maximum.  If so, set the */
/*  default vacancy */
if (TEMP_REC[ATT + 2] == "" && TEMP_REC[ATT + 1] != "" && NEW_COURSE) {
TEMP_REC[ATT + 2] = TEMP_REC[ATT + 1];
}
}
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 1] = TEMP_REC[1];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 2] = TEMP_REC[2];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 3] = TEMP_REC[3];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 4] = TEMP_REC[4];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 5] = TEMP_REC[5];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 6] = TEMP_REC[6];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 7] = TEMP_REC[7];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 8] = TEMP_REC[8];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 9] = TEMP_REC[9];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 10] = TEMP_REC[10];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 11] = TEMP_REC[11];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 12] = TEMP_REC[12];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 13] = TEMP_REC[13];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 14] = TEMP_REC[14];
COURSE_DET_REC[COURSE_DET_GROUP_NAMES][1, 15] = TEMP_REC[15];
MVC = 1;
for(ATT = 16; ATT <= 37; ATT += 3) {
COURSE_DET_REC[COURSE_DET_GROUP_NAMES_SUMM][1, MVC] = TEMP_REC[ATT];
COURSE_DET_REC[COURSE_DET_GROUP_MAXIMUMS][1, MVC] = TEMP_REC[ATT + 1];
COURSE_DET_REC[COURSE_DET_GROUP_VACANCIES][1, MVC] = TEMP_REC[ATT + 2];
MVC = MVC + 1;
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
