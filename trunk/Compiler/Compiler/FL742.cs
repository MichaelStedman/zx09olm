//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL742 : UvBase
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
readonly UvVar FIRST_CALL = 1;
readonly UvVar SCROLL = 2;
readonly UvVar TOGGLE = 3;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
#endregion
#region Variables
UvVar ACTION = "";
UvVar TOGGLE_POS = "";
UvVar STUDENT_SELECT_LIST = "";
UvVar COURSE_DET_STUDENT_IDS = "";
UvVar REDISPLAY = "";
UvVar STUDENT_COUNT = "";
UvVar STUDENT_LIST = "";
UvVar SURNAME_LIST = "";
UvVar FULL_NAME_LIST = "";
UvVar CONCESS_LIST = "";
UvVar BALANCE_LIST = "";
UvVar PAYMENT_LIST = "";
UvVar ADJUSTMENT_LIST = "";
UvVar ERROR_LIST = "";
UvVar WINDOW_DEPTH = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar PROG_MESS = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_ENROLMENT = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar HEADING_TEXT = "";
UvVar HEADING_TEXT2 = "";
UvVar FOOTER = "";
UvVar COURSE_DETAIL_ID = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_NO = "";
UvVar STUDENT_ID = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar SURNAME = "";
UvVar NAME = "";
UvVar POS = "";
UvVar COURSE_BALANCE = "";
UvVar PAYMENTS_AND_REFUNDS = "";
UvVar ADJUSTMENT = "";
UvVar TRANS_NO = "";
UvVar ENROL_ID = "";
UvVar CONCESS = "";
UvVar CNT = "";
UvVar COURSE_LINE = "";
UvVar TEMP_STUDENT_COUNT = "";
UvVar OFFSET = "";
UvVar TOGGLE_ROW = "";
#endregion
public FL742(ref UvVar ACTION, ref UvVar TOGGLE_POS, ref UvVar STUDENT_SELECT_LIST, ref UvVar COURSE_DET_STUDENT_IDS, ref UvVar REDISPLAY, ref UvVar STUDENT_COUNT, ref UvVar STUDENT_LIST, ref UvVar SURNAME_LIST, ref UvVar FULL_NAME_LIST, ref UvVar CONCESS_LIST, ref UvVar BALANCE_LIST, ref UvVar PAYMENT_LIST, ref UvVar ADJUSTMENT_LIST, ref UvVar ERROR_LIST, ref UvVar WINDOW_DEPTH) {
this.ACTION = ACTION;
this.TOGGLE_POS = TOGGLE_POS;
this.STUDENT_SELECT_LIST = STUDENT_SELECT_LIST;
this.COURSE_DET_STUDENT_IDS = COURSE_DET_STUDENT_IDS;
this.REDISPLAY = REDISPLAY;
this.STUDENT_COUNT = STUDENT_COUNT;
this.STUDENT_LIST = STUDENT_LIST;
this.SURNAME_LIST = SURNAME_LIST;
this.FULL_NAME_LIST = FULL_NAME_LIST;
this.CONCESS_LIST = CONCESS_LIST;
this.BALANCE_LIST = BALANCE_LIST;
this.PAYMENT_LIST = PAYMENT_LIST;
this.ADJUSTMENT_LIST = ADJUSTMENT_LIST;
this.ERROR_LIST = ERROR_LIST;
this.WINDOW_DEPTH = WINDOW_DEPTH;
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
/*     DISPLAY COURSE MEMBER DETAILS FOR ENROLMENT CHANGES */
PROGRAM = "FL742";
INTERACT = INVALID_DATA;
REDISPLAY = "";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

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
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 14;
WINDOW[2] = 19;
WINDOW[3] = 45;
WINDOW[4] = 76;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
FOOTER = "";
/* **************************************************** */
/*  Main processing section                           * */
/* **************************************************** */
// BEGIN CASE
// CASE
if (ACTION == FIRST_CALL) {
L0100();
L0200();
}// CASE
else if (ACTION == SCROLL) {
L0200();
}// CASE
else if (ACTION == TOGGLE) {
L0300();
}
// END CASE
return;
/* ****************************************************** */
}
void L0100() {
/*  Load data on first call only                    * */
/* ****************************************************** */
COURSE_DETAIL_ID = PROG_MESS[3] + "*" + PROG_MESS[2];
BALANCE_LIST = "";
PAYMENT_LIST = "";
ADJUSTMENT_LIST = "";
ERROR_LIST = "";
FULL_NAME_LIST = "";
CONCESS_LIST = "";
STUDENT_LIST = "";
SURNAME_LIST = "";
NO_OF_STUDENTS = DCOUNT(COURSE_DET_STUDENT_IDS, VM);
for(STUDENT_NO = 1; STUDENT_NO <= NO_OF_STUDENTS; STUDENT_NO += 1) {
STUDENT_ID = COURSE_DET_STUDENT_IDS[1, STUDENT_NO];
if (MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) {
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
} else {
SURNAME = STUDENT_REC[STUDENT_SURNAME];
NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME].Substring(1, 1));
}
if (!LOCATE(SURNAME, SURNAME_LIST, 0, 0, 1, ref POS, "AL")) { NULL(); }
SURNAME_LIST = INSERT(SURNAME_LIST, POS, 0, 0, SURNAME);
STUDENT_LIST = INSERT(STUDENT_LIST, 1, POS, 0, STUDENT_ID);
COURSE_BALANCE = 0;
PAYMENTS_AND_REFUNDS = 0;
ADJUSTMENT = 0;
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == COURSE_DETAIL_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "P" || STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "R") {
PAYMENTS_AND_REFUNDS = PAYMENTS_AND_REFUNDS + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_NO] == "A") {
ADJUSTMENT = ADJUSTMENT + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
// END CASE
}
TRANS_NO = TRANS_NO + 1;
} while (true);
BALANCE_LIST = INSERT(BALANCE_LIST, 1, POS, 0, COURSE_BALANCE);
PAYMENT_LIST = INSERT(PAYMENT_LIST, 1, POS, 0, PAYMENTS_AND_REFUNDS);
ADJUSTMENT_LIST = INSERT(ADJUSTMENT_LIST, 1, POS, 0, ADJUSTMENT);
ERROR_LIST = INSERT(ERROR_LIST, 1, POS, 0, "");
FULL_NAME_LIST = INSERT(FULL_NAME_LIST, 1, POS, 0, NAME);
ENROL_ID = COURSE_DETAIL_ID + "*" + STUDENT_ID;
if (!READV(ref CONCESS, FL_ENROLMENT, ENROL_ID, 1)) { CONCESS = ""; }
CONCESS_LIST = INSERT(CONCESS_LIST, 1, POS, 0, CONCESS);
}
}
COURSE_DETAIL_ID = PROG_MESS[3] + "*" + PROG_MESS[2];
return;
/* **************************************************** */
}
void L0200() {
/*   Print a page of detail                       * */
/* **************************************************** */
CNT = 0;
do {
if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
do {
CNT = CNT + 1;
STUDENT_ID = STUDENT_LIST[1, STUDENT_COUNT];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(RIGHT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID);
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
COURSE_LINE = "";
COURSE_LINE = FORMAT(STUDENT_COUNT, "R#3") + SPACE(2) + FORMAT(STUDENT_ID, "L#12");
COURSE_LINE = COURSE_LINE + FORMAT(FULL_NAME_LIST[1, STUDENT_COUNT], "L#25") + SPACE(2) + FORMAT(CONCESS_LIST[1, STUDENT_COUNT], "L#10") + SPACE(2) + FORMAT(OCONV(BALANCE_LIST[1, STUDENT_COUNT], "MD2"), "R#6") + FORMAT(OCONV(PAYMENT_LIST[1, STUDENT_COUNT], "MD2"), "R#9") + FORMAT(ERROR_LIST[1, STUDENT_COUNT], "R#4");
if (STUDENT_SELECT_LIST[1, STUDENT_COUNT] == TRUE) {
PRINT(AT(78, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + REV_VID);
} else {
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + NRM_VID);
}
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(COURSE_LINE, WINDOW_JUST));
}
STUDENT_COUNT = STUDENT_COUNT + 1;
} while (true);
INTERACT = VALID_DATA;
/*  Restart display from first date when end of list is reached */
if (STUDENT_ID == "") {
STUDENT_COUNT = 1;
}
CNT = 0;
} while (true);
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
/* **************************************************** */
}
void L0300() {
/*  Scroll window as necessary prior to a toggle! * */
/* **************************************************** */
// BEGIN CASE
// CASE
if (DCOUNT(STUDENT_LIST, VM) < WINDOW_DEPTH - 1) {
/*  No scrolling necessary.  Only one screen of students */
NULL();
}// CASE
else if (STUDENT_COUNT == 1) {
/*  As there are multiple pages of students this indicates that the last */
/*  page of details is currently on-screen. */
if (TOGGLE_POS > (WINDOW_DEPTH - 1)) {
/*  Student is on a page later than page 1 */
TEMP_STUDENT_COUNT = WINDOW_DEPTH;
do {
if (!(TOGGLE_POS >= (TEMP_STUDENT_COUNT + WINDOW_DEPTH - 1))) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT + (WINDOW_DEPTH - 1);
} while (true);
/* *        STUDENT.COUNT = TEMP.STUDENT.COUNT - (WINDOW.DEPTH-1) */
STUDENT_COUNT = TEMP_STUDENT_COUNT;
L0200();
/*  Scroll */
} else {
L0200();
/*  Scroll */
}
}// CASE
else if (TOGGLE_POS < STUDENT_COUNT - (WINDOW_DEPTH - 1)) {
/*  Student is earlier in the list */
TEMP_STUDENT_COUNT = STUDENT_COUNT - (WINDOW_DEPTH - 1);
do {
if (!(TOGGLE_POS < TEMP_STUDENT_COUNT)) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT - (WINDOW_DEPTH - 1);
} while (true);
STUDENT_COUNT = TEMP_STUDENT_COUNT;
L0200();
/*  Scroll */
}// CASE
else if (TOGGLE_POS >= STUDENT_COUNT) {
/*  Student is later in the list */
TEMP_STUDENT_COUNT = STUDENT_COUNT + (WINDOW_DEPTH - 1);
do {
if (!(TOGGLE_POS > (TEMP_STUDENT_COUNT + WINDOW_DEPTH - 1))) break;
TEMP_STUDENT_COUNT = TEMP_STUDENT_COUNT + (WINDOW_DEPTH - 1);
} while (true);
STUDENT_COUNT = TEMP_STUDENT_COUNT - (WINDOW_DEPTH - 1);
L0200();
/*  Scroll */
}
// END CASE
L0400();
/*  Perform the toggle! */
return;
/* ****************************************************** */
}
void L0400() {
/*   Perform a toggle                               * */
/* ****************************************************** */
STUDENT_ID = STUDENT_LIST[1, TOGGLE_POS];
OFFSET = MOD(TOGGLE_POS, (WINDOW_DEPTH - 1));
if (OFFSET == 0) { OFFSET = (WINDOW_DEPTH - 1); }
TOGGLE_ROW = TOP_WINDOW + OFFSET + 1;
PRINT(AT(RIGHT_WINDOW, TOGGLE_ROW) + NRM_VID);
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
if (STUDENT_ID == "") {
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + NRM_VID + FORMAT("", WINDOW_JUST));
} else {
COURSE_LINE = "";
COURSE_LINE = FORMAT(TOGGLE_POS, "R#3") + SPACE(2) + FORMAT(STUDENT_ID, "L#12");
COURSE_LINE = COURSE_LINE + FORMAT(FULL_NAME_LIST[1, TOGGLE_POS], "L#25") + SPACE(2) + FORMAT(CONCESS_LIST[1, TOGGLE_POS], "L#10") + SPACE(2) + FORMAT(OCONV(BALANCE_LIST[1, TOGGLE_POS], "MD2"), "R#6") + FORMAT(OCONV(PAYMENT_LIST[1, TOGGLE_POS], "MD2"), "R#9") + FORMAT(ERROR_LIST[1, TOGGLE_POS], "R#4");
if (STUDENT_SELECT_LIST[1, TOGGLE_POS] == TRUE) {
PRINT(AT(78, TOGGLE_ROW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOGGLE_ROW) + REV_VID);
} else {
PRINT(AT(LEFT_WINDOW - 1, TOGGLE_ROW) + NRM_VID);
}
PRINT(AT(LEFT_WINDOW, TOGGLE_ROW) + FORMAT(COURSE_LINE, WINDOW_JUST));
}
}
return;
/* ********************************* */
L1000:;
/*  Display last line message  * */
/* ********************************* */
INTERACT = INVALID_DATA;
PRINT(AT(79, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW + 1));
return;
}
}
}
