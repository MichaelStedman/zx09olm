//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL786 : UvBase
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
readonly UvVar COPY = 1;
readonly UvVar DUPLICATE = 2;
readonly UvVar GET = 3;
readonly UvVar PUT = 4;
readonly UvVar FLUSH = 6;
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
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_ENROLMENT = "";
UvVar FL_STUDENTS = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_COURSE = "";
UvVar OLD_COURSE_DATE = "";
FL796 FL796;
UvVar RESPONSE = "";
UvVar PAGE_NO = "";
FL787 FL787;
UvVar COURSE_CODE = "";
UvVar COURSE_DATE = "";
UvVar DETAILS_ID = "";
UvVar DATE_POS = "";
UvVar OLD_DETAILS_ID = "";
UvVar STUDENT_COUNT = "";
UvVar STUDENT_ID = "";
UvVar OLD_ENROL_ID = "";
UvVar NEW_ENROL_ID = "";
UvVar DET_COUNT = "";
UvVar DET_ID = "";
UvVar TRANS_DET_ID = "";
#endregion
public FL786() {
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
/*     CONTROLLING ROUTINE FOR ACTIVITY DAY MAINTENANCE */
PROMPT("");
PROGRAM = "FL786";
SCREEN_CODE = PROGRAM;
INTERACT = "";
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
/* ******************************** */
/*   DEFINE STANDARD VARIABLES    * */
/* ******************************** */
/*  Prog.mess<1> holds the page no.  If it is null this indicates */
/*  'finish' (i.e. update files).  It can also contain the 'abandon' */
/*  character */
/* ******************************* */
/*   MAIN PROCESSING SECTION     * */
/* ******************************* */
OLD_PAGE_NO = 1;
NEW_COURSE = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref COURSE_MSTR_REC, "");
MAT(ref COURSE_DET_REC, "");
OLD_COURSE_DATE = "";
PROG_MESS = 1;
FL796 = new FL796(ref RESPONSE);
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
FL787 = new FL787(ref COURSE_MSTR_REC, ref COURSE_DET_REC, ref NEW_COURSE, ref OLD_COURSE_DATE);
}// CASE
else if (OTHERWISE) {
PROG_MESS[1] = OLD_PAGE_NO;
}
// END CASE
OLD_PAGE_NO = PAGE_NO;
} while (true);
if (PROG_MESS[1] == "" && PROG_MESS[2] != "") {
/*  Apply File Updates */
COURSE_CODE = PROG_MESS[2];
COURSE_DATE = PROG_MESS[3];
DETAILS_ID = COURSE_DATE + "*" + COURSE_CODE;
if (NEW_COURSE) {
/*  Insert the new course date on the master record */
if (!(LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR"))) {
COURSE_MSTR_REC[COURSE_MSTR_DATES] = INSERT(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, DATE_POS, 0, COURSE_DATE);
}
} else {
/*  Existing course - if the start date has been altered update master */
/*  and detail (id) accordingly */
if (COURSE_DATE != OLD_COURSE_DATE) {
if (LOCATE(OLD_COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR")) {
COURSE_MSTR_REC[COURSE_MSTR_DATES] = DELETE(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, DATE_POS);
OLD_DETAILS_ID = OLD_COURSE_DATE + "*" + COURSE_CODE;
DELETE(FL_COURSE_DETAILS, OLD_DETAILS_ID);
}
if (!(LOCATE(COURSE_DATE, COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, 0, 1, ref DATE_POS, "DR"))) {
COURSE_MSTR_REC[COURSE_MSTR_DATES] = INSERT(COURSE_MSTR_REC[COURSE_MSTR_DATES], 1, DATE_POS, 0, COURSE_DATE);
}
/*  Change id's for any enrolment records & update all relevant student attributes */
STUDENT_COUNT = 1;
do {
STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_COUNT];
if (STUDENT_ID == "") break;
OLD_ENROL_ID = OLD_DETAILS_ID + "*" + STUDENT_ID;
NEW_ENROL_ID = DETAILS_ID + "*" + STUDENT_ID;
if (MATREAD(ref ENROL_REC, FL_ENROLMENT, OLD_ENROL_ID)) {
MATWRITE(ENROL_REC, FL_ENROLMENT, NEW_ENROL_ID);
DELETE(FL_ENROLMENT, OLD_ENROL_ID);
}
if (MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) {
DET_COUNT = 1;
do {
DET_ID = STUDENT_REC[STUDENT_DETAIL_IDS][1, DET_COUNT];
TRANS_DET_ID = STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, DET_COUNT];
if (DET_ID == "" && TRANS_DET_ID == "") break;
if (DET_ID != "" && DET_ID == OLD_DETAILS_ID) {
STUDENT_REC[STUDENT_DETAIL_IDS][1, DET_COUNT] = DETAILS_ID;
}
if (TRANS_DET_ID != "" && TRANS_DET_ID == OLD_DETAILS_ID) {
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, DET_COUNT] = DETAILS_ID;
}
DET_COUNT = DET_COUNT + 1;
} while (true);
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_ID);
}
STUDENT_COUNT = STUDENT_COUNT + 1;
} while (true);
}
}
MATWRITE(COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE);
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, DETAILS_ID);
}
RELEASE();
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
