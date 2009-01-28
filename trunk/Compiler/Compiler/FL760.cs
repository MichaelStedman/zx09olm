//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL760 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar ENROL_REP_TYPE = 1;
readonly UvVar ENROL_REP_STUDENT_ID = 2;
readonly UvVar ENROL_REP_OLD_COURSE_DETAIL_ID = 3;
readonly UvVar ENROL_REP_NEW_COURSE_DETAIL_ID = 4;
readonly UvVar ENROL_REP_WAITING_LIST_JOINED = 5;
readonly UvVar ENROL_REP_COMMENT = 6;
readonly UvVar ENROL_REP_PREFERENCE_NO = 7;
readonly UvVar ENROL_REP_COURSE_FEE = 8;
readonly UvVar ENROL_REP_WAITING_LIST_POSITION = 9;
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] ENROL_REP_REC = new UvVar[15];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] INSTRUCTOR_REC = new UvVar[30];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_ENROLMENT_REPORT = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_INSTRUCTORS = "";
UvVar RUN_PARAMS = "";
UvVar GATEWAY = "";
UvVar PATH = "";
UvVar NO_CHARS = "";
UvVar CHARACTER = "";
UvVar WAIT_DOS_FILENAME = "";
UvVar SUCCESS_DOS_FILENAME = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EXPORT_REC = "";
UvVar EOF = "";
UvVar LETTER_COUNT = "";
UvVar LETTER_ROW = "";
UvVar LAST_LETTER_TYPE = "";
UvVar REPORT_ID = "";
UvVar ACTIVITY_DESCRIPTION = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar TITLE = "";
UvVar SURNAME = "";
UvVar FORENAME = "";
UvVar ADDRESS_LINE1 = "";
UvVar ADDRESS_LINE2 = "";
UvVar ADDRESS_LINE3 = "";
UvVar ADDRESS_LINE4 = "";
UvVar POSTCODE = "";
UvVar NEW_COURSE_CODE = "";
UvVar NEW_COURSE_DATE = "";
UvVar FREQ = "";
UvVar INSTRUCTOR_NAME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
UvVar nrf4 = "";
#endregion
public FL760() {
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
/*     EXPORT RE-ENROLMENT LETTERS VIA PICLAN */
PROGRAM = "FL760";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
#region INCLUDE FL.FILES FL.ENROLMENT.REPORT
if (!OPEN("FL.ENROLMENT.REPORT", out FL_ENROLMENT_REPORT)) { STOP("201", "FL.ENROLMENT.REPORT"); }

#endregion
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
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

#endregion
if (!READ(ref RUN_PARAMS, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { RUN_PARAMS = ""; }
GATEWAY = RUN_PARAMS[6];
PATH = RUN_PARAMS[7];
/*  Reverse any backslashes in the path */
NO_CHARS = LEN(PATH);
for(CHARACTER = 1; CHARACTER <= NO_CHARS; CHARACTER += 1) {
if (PATH.Substring(CHARACTER, 1) == "\\") {
PATH = PATH.Substring(1, CHARACTER - 1) + "/" + PATH.Substring(CHARACTER + 1, 99);
}
}
WAIT_DOS_FILENAME = RUN_PARAMS[8];
SUCCESS_DOS_FILENAME = RUN_PARAMS[9];
/*  Main processing section */
PRINT(AT(10, 17) + "Now selecting letters for export...");
INSTRUCTION = "SSELECT FL.ENROLMENT.REPORT # \"[.EXPORT\" BY TYPE BY STUDENT.SURNAME";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
PRINT("Done.");
/*  Set export header for unsuccessful enrolments */
EXPORT_REC = "";
EXPORT_REC[1] = "Student No,Title,Forenames,Surname,Address Line 1,Address Line 2,Address Line 3,Address Line 4,Post Code,Activity Code,Activity Description,List Position";
EOF = FALSE;
LETTER_COUNT = 0;
PRINT(AT(10, 19) + "Waiting list letters exported =");
LETTER_ROW = 19;
PRINT(AT(42, LETTER_ROW) + 0);
LAST_LETTER_TYPE = "";
do {
if (!READNEXT(ref REPORT_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (!MATREAD(ref ENROL_REP_REC, FL_ENROLMENT_REPORT, REPORT_ID)) { MAT(ref ENROL_REP_REC, ""); }
/*  When type changes from 'P'riority to 'S'ucessful, start exporting */
/*  a new file */
if (LAST_LETTER_TYPE != "S" && ENROL_REP_REC[ENROL_REP_TYPE] == "S") {
if (LETTER_COUNT >= 1) {
WRITE(EXPORT_REC, FL_ENROLMENT_REPORT, "WAIT.EXPORT");
INSTRUCTION = "PLDOS-EXPORT " + GATEWAY + " " + PATH + WAIT_DOS_FILENAME + ".DOC FL.ENROLMENT.REPORT WAIT.EXPORT CONV=a";
PRINT(AT(10, 21) + "Exporting letters to DOS...");
nrf0 = "O";
nrf1 = "";
nrf2 = "";
nrf3 = "";
nrf4 = "";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4);
PRINT("Done.");
}
LETTER_COUNT = 1;
LETTER_ROW = LETTER_ROW + 1;
PRINT(AT(10, LETTER_ROW) + "Re-enrolment letters exported = ");
/*  Set export header for successful enrolments */
EXPORT_REC = "";
EXPORT_REC[1] = "Student No,Title,Forenames,Surname,Address Line 1,Address Line 2,Address Line 3,Address Line 4,Post Code,Course Code,Course Description,Start Date,End Date,Instructor Name,Start Time,End Time,Frequency,Days,Comment1,Comment2,Comment3";
} else {
LETTER_COUNT = LETTER_COUNT + 1;
}
PRINT(AT(42, LETTER_ROW) + LETTER_COUNT);
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, ENROL_REP_REC[ENROL_REP_STUDENT_ID])) { MAT(ref STUDENT_REC, ""); }
if (ENROL_REP_REC[ENROL_REP_TYPE] == "P") {
if (!READV(ref ACTIVITY_DESCRIPTION, FL_ACTIVITY_CODES, ENROL_REP_REC[ENROL_REP_WAITING_LIST_JOINED], 1)) { ACTIVITY_DESCRIPTION = ""; }
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ENROL_REP_REC[ENROL_REP_STUDENT_ID])) {
STUDENT_IS_MEMBER = TRUE;
TITLE = MEMBERS_REC[MEMBER_TITLES][1, 1];
SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
FORENAME = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
ADDRESS_LINE2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
ADDRESS_LINE3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
ADDRESS_LINE4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
} else {
TITLE = STUDENT_REC[STUDENT_TITLE];
SURNAME = STUDENT_REC[STUDENT_SURNAME];
FORENAME = STUDENT_REC[STUDENT_FORENAME];
ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
ADDRESS_LINE2 = STUDENT_REC[STUDENT_ADDRESS2];
ADDRESS_LINE3 = STUDENT_REC[STUDENT_ADDRESS3];
ADDRESS_LINE4 = STUDENT_REC[STUDENT_ADDRESS4];
POSTCODE = STUDENT_REC[STUDENT_POST_CODE];
}
EXPORT_REC[1 + LETTER_COUNT] = "\"" + ENROL_REP_REC[ENROL_REP_STUDENT_ID] + "\",\"" + TITLE + "\",\"" + FORENAME + "\",\"" + SURNAME + "\",\"" + ADDRESS_LINE1 + "\",\"" + ADDRESS_LINE2 + "\",\"" + ADDRESS_LINE3 + "\",\"" + ADDRESS_LINE4 + "\",\"" + POSTCODE + "\",\"" + ENROL_REP_REC[ENROL_REP_WAITING_LIST_JOINED] + "\",\"" + ACTIVITY_DESCRIPTION + "\",\"" + ENROL_REP_REC[ENROL_REP_WAITING_LIST_POSITION] + "\"";
} else {
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID])) { MAT(ref COURSE_DET_REC, ""); }
NEW_COURSE_CODE = FIELD(ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID], "*", 2);
NEW_COURSE_DATE = FIELD(ENROL_REP_REC[ENROL_REP_NEW_COURSE_DETAIL_ID], "*", 1);
if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_DESC], FL_COURSE_MASTER, NEW_COURSE_CODE, 1)) { COURSE_MSTR_REC[COURSE_MSTR_DESC] = ""; }
// BEGIN CASE
// CASE
if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W" || COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W1") {
FREQ = "Weekly";
}// CASE
else if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "F") {
FREQ = "Fortnightly";
}// CASE
else if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "4") {
FREQ = "Four Weekly";
}// CASE
else if (COURSE_DET_REC[COURSE_DET_FREQUENCY] == "W7") {
FREQ = "Daily";
}// CASE
else if (COURSE_DET_REC[COURSE_DET_FREQUENCY].Substring(1, 1) == "W" && NUM(COURSE_DET_REC[COURSE_DET_FREQUENCY].Substring(2, 1))) {
FREQ = COURSE_DET_REC[COURSE_DET_FREQUENCY].Substring(2, 1) + " days a week";
}// CASE
else if (OTHERWISE) {
FREQ = "";
}
// END CASE
if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, COURSE_DET_REC[COURSE_DET_INSTRUCTOR])) { MAT(ref INSTRUCTOR_REC, ""); }
INSTRUCTOR_NAME = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ENROL_REP_REC[ENROL_REP_STUDENT_ID])) {
STUDENT_IS_MEMBER = TRUE;
TITLE = MEMBERS_REC[MEMBER_TITLES][1, 1];
SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
FORENAME = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
ADDRESS_LINE2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
ADDRESS_LINE3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
ADDRESS_LINE4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
} else {
TITLE = STUDENT_REC[STUDENT_TITLE];
SURNAME = STUDENT_REC[STUDENT_SURNAME];
FORENAME = STUDENT_REC[STUDENT_FORENAME];
ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
ADDRESS_LINE2 = STUDENT_REC[STUDENT_ADDRESS2];
ADDRESS_LINE3 = STUDENT_REC[STUDENT_ADDRESS3];
ADDRESS_LINE4 = STUDENT_REC[STUDENT_ADDRESS4];
POSTCODE = STUDENT_REC[STUDENT_POST_CODE];
}
EXPORT_REC[1 + LETTER_COUNT] = "\"" + ENROL_REP_REC[ENROL_REP_STUDENT_ID] + "\",\"" + TITLE + "\",\"" + FORENAME + "\",\"" + SURNAME + "\",\"" + ADDRESS_LINE1 + "\",\"" + ADDRESS_LINE2 + "\",\"" + ADDRESS_LINE3 + "\",\"" + ADDRESS_LINE4 + "\",\"" + POSTCODE + "\",\"" + NEW_COURSE_CODE + "\",\"" + COURSE_MSTR_REC[COURSE_MSTR_DESC] + "\",\"" + OCONV(NEW_COURSE_DATE, "D") + "\",\"" + OCONV(COURSE_DET_REC[COURSE_DET_END], "D") + "\",\"" + INSTRUCTOR_NAME + "\",\"" + OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT") + "\",\"" + OCONV(COURSE_DET_REC[COURSE_DET_END_TIME][1, 1], "MT") + "\",\"" + FREQ + "\",\"" + COURSE_DET_REC[COURSE_DET_DAYS] + "\",\"" + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 1] + "\",\"" + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 2] + "\",\"" + COURSE_DET_REC[COURSE_DET_COMMENTS][1, 3] + "\"";
}
LAST_LETTER_TYPE = ENROL_REP_REC[ENROL_REP_TYPE];
} while (true);
/*  Export any successful letters */
if (LETTER_COUNT >= 1 && LAST_LETTER_TYPE == "S") {
WRITE(EXPORT_REC, FL_ENROLMENT_REPORT, "SUCCESS.EXPORT");
INSTRUCTION = "PLDOS-EXPORT " + GATEWAY + " " + PATH + SUCCESS_DOS_FILENAME + ".DOC FL.ENROLMENT.REPORT SUCCESS.EXPORT CONV=a";
PRINT(AT(10, 21) + "Exporting letters to DOS..." + COMMON.EOL);
nrf0 = "O";
nrf1 = "";
nrf2 = "";
nrf3 = "";
nrf4 = "";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref nrf4);
PRINT("Done.");
}
/* ********************************************* */
/*   Return to calling program                 * */
/* ********************************************* */
return;
/* ******************************** */
/*   End of program               * */
/* ******************************** */
}
}
}
