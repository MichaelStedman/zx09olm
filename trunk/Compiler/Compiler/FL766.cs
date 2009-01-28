//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL766 : UvBase
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
readonly UvVar INVALID_DATA = 5;
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
readonly UvVar WAIT_STUD_TITLE = 1;
readonly UvVar WAIT_STUD_FORENAME = 2;
readonly UvVar WAIT_STUD_SURNAME = 3;
readonly UvVar WAIT_STUD_ADDRESS1 = 4;
readonly UvVar WAIT_STUD_ADDRESS2 = 5;
readonly UvVar WAIT_STUD_ADDRESS3 = 6;
readonly UvVar WAIT_STUD_ADDRESS4 = 7;
readonly UvVar WAIT_STUD_POST_CODE = 8;
readonly UvVar WAIT_STUD_TEL_HOME = 9;
readonly UvVar WAIT_STUD_TEL_WORK = 10;
readonly UvVar WAIT_STUD_COMMENT = 11;
readonly UvVar WAIT_STUD_AVAILABLE_MONDAY = 12;
readonly UvVar WAIT_STUD_AVAILABLE_TUESDAY = 13;
readonly UvVar WAIT_STUD_AVAILABLE_WEDNESDAY = 14;
readonly UvVar WAIT_STUD_AVAILABLE_THURSDAY = 15;
readonly UvVar WAIT_STUD_AVAILABLE_FRIDAY = 16;
readonly UvVar WAIT_STUD_AVAILABLE_SATURDAY = 17;
readonly UvVar WAIT_STUD_AVAILABLE_SUNDAY = 18;
readonly UvVar WAIT_STUD_ACTIVITY_CODES = 19;
readonly UvVar WAIT_STUD_CONCESSION = 20;
readonly UvVar WAIT_STUD_DATES = 21;
readonly UvVar WAIT_STUD_DOB = 22;
readonly UvVar WAIT_STUD_CONTACTED = 23;
readonly UvVar WAIT_STUD_CENTRE = 24;
readonly UvVar WAIT_STUD_COURSE = 25;
readonly UvVar WAIT_STUD_MEDICAL = 26;
readonly UvVar WAIT_STUD_CENTRE2 = 27;
readonly UvVar WAIT_MAST_IDS = 1;
readonly UvVar WAIT_MAST_STATUS = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] WAIT_MAST_REC = new UvVar[5];
#endregion
#region Variables
UvVar OLD_STUDENT_ID = "";
UvVar NEW_STUDENT_ID = "";
UvVar READ_AND_WRITE = "";
UvVar INTERACT = "";
UvVar ERROR_MESSAGE = "";
UvVar VM = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_STUDENTS = "";
UvVar FL_ENROLMENT = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_WAIT_MASTER = "";
UvVar COURSE_PARAMS = "";
UvVar GET_STUDENT_ID = "";
UvVar EXISTING_STUDENT = "";
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
UvVar NO_OF_COURSES = "";
UvVar COURSE_NO = "";
UvVar COURSE_DET_ID = "";
UvVar OLD_ENROL_ID = "";
UvVar NEW_ENROL_ID = "";
UvVar POS = "";
UvVar NO_OF_ACTIVITIES = "";
UvVar ACTIVITY_COUNT = "";
UvVar ACTIVITY_CODE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL766(ref UvVar OLD_STUDENT_ID, ref UvVar NEW_STUDENT_ID, ref UvVar[] STUDENT_REC, ref UvVar READ_AND_WRITE, ref UvVar INTERACT, ref UvVar ERROR_MESSAGE) {
this.OLD_STUDENT_ID = OLD_STUDENT_ID;
this.NEW_STUDENT_ID = NEW_STUDENT_ID;
this.STUDENT_REC = STUDENT_REC;
this.READ_AND_WRITE = READ_AND_WRITE;
this.INTERACT = INTERACT;
this.ERROR_MESSAGE = ERROR_MESSAGE;
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
/*  Convert all occurrences of a student id to a different one */
/*  Typically used when a enrolled student becomes a centre */
/*  member for the first time. Also used by membership */
/*  obliteration procedure developed for Wrekin. */
/*  Student.rec may not be passed.  If not, read.and.write */
/*  should be set to true, and it becomes the responsibility of */
/*  this routine to read and update student.rec.  This routine */
/*  ALWAYS writes to the other files.  This mechanism allows the */
/*  Payments option to switch student id's while its processing */
/*  a payment (i.e. writing transactions to fl.students). */
/*  Include relevant file information */
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
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[28, 1];
/*  Main processing section */
INTERACT = VALID_DATA;
ERROR_MESSAGE = "";
EXISTING_STUDENT = TRUE;
if (READ_AND_WRITE == TRUE) {
if (!MATREADU(ref STUDENT_REC, FL_STUDENTS, OLD_STUDENT_ID)) { EXISTING_STUDENT = FALSE; }
}
if (EXISTING_STUDENT) {
if (NEW_STUDENT_ID == "") {
if (GET_STUDENT_ID == "") {
/*  Error - can't generate a number */
INTERACT = INVALID_DATA;
ERROR_MESSAGE = "No routine for generating student numbers";
} else {
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref NEW_STUDENT_ID);
}
}
if (INTERACT == VALID_DATA) {
NO_OF_COURSES = DCOUNT(STUDENT_REC[STUDENT_DETAIL_IDS], VM);
for(COURSE_NO = 1; COURSE_NO <= NO_OF_COURSES; COURSE_NO += 1) {
COURSE_DET_ID = STUDENT_REC[STUDENT_DETAIL_IDS][1, COURSE_NO];
OLD_ENROL_ID = COURSE_DET_ID + "*" + OLD_STUDENT_ID;
NEW_ENROL_ID = COURSE_DET_ID + "*" + NEW_STUDENT_ID;
if (!MATREADU(ref ENROL_REC, FL_ENROLMENT, OLD_ENROL_ID)) { MAT(ref ENROL_REC, ""); }
MATWRITE(ENROL_REC, FL_ENROLMENT, NEW_ENROL_ID);
DELETE(FL_ENROLMENT, OLD_ENROL_ID);
if (!MATREADU(ref COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID)) { MAT(ref COURSE_DET_REC, ""); }
if (LOCATE(OLD_STUDENT_ID, COURSE_DET_REC[COURSE_DET_STUDENT_IDS], 1, 0, 1, ref POS, "AL")) {
COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, POS] = NEW_STUDENT_ID;
MATWRITE(COURSE_DET_REC, FL_COURSE_DETAILS, COURSE_DET_ID);
} else {
RELEASE();
}
}
if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, OLD_STUDENT_ID)) {
NO_OF_ACTIVITIES = DCOUNT(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], VM);
for(ACTIVITY_COUNT = 1; ACTIVITY_COUNT <= NO_OF_ACTIVITIES; ACTIVITY_COUNT += 1) {
ACTIVITY_CODE = WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, ACTIVITY_COUNT];
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE)) { MAT(ref WAIT_MAST_REC, ""); }
if (LOCATE(OLD_STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_IDS][1, POS] = NEW_STUDENT_ID;
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
}
}
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, NEW_STUDENT_ID);
DELETE(FL_WAIT_STUDENTS, OLD_STUDENT_ID);
}
/*  Record previous student number for audit trail (via English) */
STUDENT_REC[STUDENT_OLD_NUMBERS][1, -1] = OLD_STUDENT_ID;
if (READ_AND_WRITE == TRUE) {
MATWRITE(STUDENT_REC, FL_STUDENTS, NEW_STUDENT_ID);
DELETE(FL_STUDENTS, OLD_STUDENT_ID);
}
/*  Can't generate new number - calling program should check Interact */
}
/*  Never been a student - no action required */
}
/*  Return to calling program */
return;
/*  End of program */
}
}
}
