//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL782 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar CAL_TEXT = 1;
readonly UvVar CAL_TYPE = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar UL = "_";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] CALENDAR_REC = new UvVar[10];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar VM = "";
UvVar COURSE = "";
UvVar PROGRAM = "";
UvVar CR = "";
UvVar FF = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_INSTRUCTORS = "";
UvVar FL_ENROLMENT = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar SHOW_TEL = "";
UvVar PAGE_DEPTH = "";
UvVar FIRST_PAGE = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar START_DATE = "";
UvVar END_DATE = "";
UvVar INSTRUCTOR = "";
UvVar REQUESTED_CENTRE = "";
UvVar PROCESS_EXECUTE = "";
UvVar INSTRUCTION = "";
UvVar PAGE_NUMBER = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar ID = "";
UvVar COURSE_CODE = "";
UvVar INSTRUCTOR1 = "";
UvVar INSTRUCTOR2 = "";
UvVar COURSE_START_DATE = "";
UvVar EXCEPTION_DATES = "";
UvVar TOTAL_SESSIONS = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar MAX_BOXES = "";
UvVar BOXES_PRINTED = "";
UvVar NO_OF_BOXES = "";
UvVar LINE_COUNT = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_NO = "";
UvVar STUDENT_ID = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar NAME = "";
UvVar ENROL_ID = "";
UvVar STUDENT_PHONE = "";
UvVar NOTES = "";
UvVar BOX_NO = "";
UvVar START_BOX = "";
UvVar END_BOX = "";
UvVar EXTRA_ROWS = "";
UvVar ROW = "";
UvVar MEDICAL_TEXT = "";
UvVar AWARD_TEXT = "";
UvVar PHONE_TEXT = "";
UvVar LINE_LENGTH = "";
UvVar PADDING_JUST = "";
UvVar TITLE = "";
UvVar UNDERLINE = "";
UvVar EX_POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL782() {
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
/*     COURSE ATTENDANCE REGISTER WITH AWARDS (WEST WICKHAM) */
PROGRAM = "FL782";
/* *EXECUTE "SETPTR ,,,,,1,AT UVDEFAULT,BRIEF" */
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

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
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

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
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.CALENDAR
if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

/*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

#endregion
if (!READV(ref SHOW_TEL, FL_COURSE_PARAMS, "COURSE.PARAMS", 9)) { SHOW_TEL = "Y"; }
if (!READV(ref PAGE_DEPTH, FL_COURSE_PARAMS, "COURSE.PARAMS", 44)) { PAGE_DEPTH = ""; }
if (PAGE_DEPTH == "") { PAGE_DEPTH = 28; }
if (PAGE_DEPTH == "") { PAGE_DEPTH = 28; }
/* * Routine to set printer parameters  (condensed print) */
FIRST_PAGE = TRUE;
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "COURSES.LANDSCAPE";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
/* DJA 6.1.04* PAGE.DEPTH = 32 */
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
PRINT(AT(0, 20));
if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
START_DATE = OCONV(CONTROLS_REC[5], "D");
END_DATE = OCONV(CONTROLS_REC[6], "D");
COURSE = CONTROLS_REC[7];
INSTRUCTOR = CONTROLS_REC[8];
REQUESTED_CENTRE = CONTROLS_REC[9];
if (!(READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1))) {
CENTRES_REC[CENTRE_NAME] = "LeisureFlex";
}
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
if (REQUESTED_CENTRE == "") {
INSTRUCTION = "SSELECT FL.COURSE.DETAILS WITH TYPE = \"\" AND WITH START.DATE >= \"" + START_DATE + "\"";
} else {
INSTRUCTION = "SSELECT FL.COURSE.DETAILS WITH CENTRE.CODE = \"" + REQUESTED_CENTRE + "\" AND WITH TYPE = \"\" AND WITH START.DATE >= \"" + START_DATE + "\"";
}
if (END_DATE != "") {
INSTRUCTION = INSTRUCTION + "AND WITH START.DATE <= \"" + END_DATE + "\"";
}
if (COURSE != "") {
INSTRUCTION = INSTRUCTION + " AND WITH COURSE.CODE = \"" + COURSE + "\"";
}
if (INSTRUCTOR != "") {
INSTRUCTION = INSTRUCTION + " AND WITH 13 = \"" + INSTRUCTOR + "\"";
}
PAGE_NUMBER = 0;
nrf0 = "S";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, ID)) { STOP(); }
COURSE_CODE = FIELD(ID, "*", 2);
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, COURSE_DET_REC[COURSE_DET_INSTRUCTOR])) { MAT(ref INSTRUCTOR_REC, ""); }
INSTRUCTOR1 = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
if (!MATREAD(ref INSTRUCTOR_REC, FL_INSTRUCTORS, COURSE_DET_REC[COURSE_DET_INSTRUCTOR2])) { MAT(ref INSTRUCTOR_REC, ""); }
INSTRUCTOR2 = TRIM(INSTRUCTOR_REC[INSTRUCTOR_TITLE] + " " + INSTRUCTOR_REC[INSTRUCTOR_FORENAME] + " " + INSTRUCTOR_REC[INSTRUCTOR_SURNAME]);
COURSE_START_DATE = FIELD(ID, "*", 1);
EXCEPTION_DATES = "";
TOTAL_SESSIONS = 0;
EX_DATE = COURSE_START_DATE;
do {
if (EX_DATE > COURSE_DET_REC[COURSE_DET_END]) break;
FL873 = new FL873(ref EX_DATE, ref COURSE_START_DATE, ref COURSE_DET_REC, ref DATE_QUALIFIES);
if (DATE_QUALIFIES) {
if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] != "N") {
if (COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] == "Y") {
CALENDAR_ID = EX_DATE;
} else {
CALENDAR_ID = COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] + "*" + EX_DATE;
}
if (READ(ref CAL_REC, FL_COURSE_CALENDAR, CALENDAR_ID)) {
if (CAL_REC[2] == "C") {
/*  Courses do not run on this day */
EXCEPTION_DATES[-1] = EX_DATE;
} else {
TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
}
} else {
TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
}
} else {
TOTAL_SESSIONS = TOTAL_SESSIONS + 1;
}
}
EX_DATE = EX_DATE + 1;
} while (true);
MAX_BOXES = 14;
BOXES_PRINTED = 0;
do {
if (BOXES_PRINTED == TOTAL_SESSIONS) break;
NO_OF_BOXES = TOTAL_SESSIONS - BOXES_PRINTED;
if (NO_OF_BOXES > MAX_BOXES) { NO_OF_BOXES = MAX_BOXES; }
L0100();
BOXES_PRINTED = BOXES_PRINTED + NO_OF_BOXES;
} while (true);
} while (true);
/* *     PRINTER ON */
/* !*  CALL FL235("STANDARD",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
/* DJA 14.03.06!PRINT PRINT.END.COMMAND: */
PRINTER_CLOSE();
PRINTER_OFF();
return;
/* ********************************** */
}
void L0100() {
/*   PRINT ATTENDANCE REGISTER  * */
/* ********************************** */
LINE_COUNT = 0;
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
NO_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
for(STUDENT_NO = 1; STUDENT_NO <= COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES]; STUDENT_NO += 1) {
STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_NO];
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
STUDENT_IS_MEMBER = FALSE;
if (STUDENT_ID == "") {
NAME = "";
STUDENT_REC[STUDENT_WORK_TEL] = "";
STUDENT_REC[STUDENT_HOME_TEL] = "";
STUDENT_REC[STUDENT_DOB] = "";
STUDENT_REC[STUDENT_SURNAME] = "";
} else {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
NAME = TRIM(MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
STUDENT_REC[STUDENT_WORK_TEL] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
STUDENT_REC[STUDENT_HOME_TEL] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
STUDENT_REC[STUDENT_DOB] = MEMBERS_REC[MEMBER_DOBS][1, 1];
STUDENT_REC[STUDENT_SURNAME] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
} else {
NAME = TRIM(STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
}
}
ENROL_ID = ID + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
STUDENT_PHONE = STUDENT_REC[STUDENT_HOME_TEL];
if (STUDENT_PHONE == "") {
STUDENT_PHONE = STUDENT_REC[STUDENT_WORK_TEL];
}
/*  DJA 17.11.03 */
if (SHOW_TEL == "N") {
STUDENT_PHONE = "";
}
NOTES = "";
/*     Print single set of student details */
if (LINE_COUNT <= 0) {
L0200();
LINE_COUNT = PAGE_DEPTH;
}
LINE_COUNT = LINE_COUNT - 2;
PRINT(FORMAT(STUDENT_NO, "R#2") + "|");
PRINT(FORMAT(STUDENT_ID, "L#8") + "|");
PRINT(FORMAT(NAME, "L#20") + "|");
/* !*     PRINT TRIM(STUDENT.PHONE "R#14") "L#14":"": */
PRINT(FORMAT(OCONV(STUDENT_REC[STUDENT_DOB], "D2/"), "R#8") + "|");
PRINT(FORMAT(STUDENT_REC[STUDENT_MEDICAL1], "L#20") + "|");
for(BOX_NO = START_BOX; BOX_NO <= END_BOX; BOX_NO += 1) {
PRINT("  |");
}
PRINT(FORMAT(NOTES, "L#10") + "|");
PRINTCR(TRIM(STUDENT_REC[STUDENT_AWARD1] + " " + STUDENT_REC[STUDENT_AWARD2]));
if (STUDENT_REC[STUDENT_MEDICAL3] == "") {
EXTRA_ROWS = 1;
} else {
EXTRA_ROWS = 2;
}
if (STUDENT_REC[STUDENT_AWARD11] != "" || STUDENT_REC[STUDENT_AWARD12] != "") {
EXTRA_ROWS = 6;
} else {
if (STUDENT_REC[STUDENT_AWARD9] != "" || STUDENT_REC[STUDENT_AWARD10] != "") {
EXTRA_ROWS = 5;
} else {
if (STUDENT_REC[STUDENT_AWARD7] != "" || STUDENT_REC[STUDENT_AWARD8] != "") {
EXTRA_ROWS = 4;
} else {
if (STUDENT_REC[STUDENT_AWARD5] != "" || STUDENT_REC[STUDENT_AWARD6] != "") {
EXTRA_ROWS = 3;
}
}
}
}
for(ROW = 1; ROW <= EXTRA_ROWS; ROW += 1) {
if (ROW == 1) {
MEDICAL_TEXT = STUDENT_REC[STUDENT_MEDICAL2];
AWARD_TEXT = TRIM(STUDENT_REC[STUDENT_AWARD3] + " " + STUDENT_REC[STUDENT_AWARD4]);
PHONE_TEXT = STUDENT_PHONE;
} else {
MEDICAL_TEXT = STUDENT_REC[STUDENT_MEDICAL3];
// BEGIN CASE
// CASE
if (ROW == 2) {
AWARD_TEXT = TRIM(STUDENT_REC[STUDENT_AWARD5] + " " + STUDENT_REC[STUDENT_AWARD6]);
}// CASE
else if (ROW == 3) {
AWARD_TEXT = TRIM(STUDENT_REC[STUDENT_AWARD7] + " " + STUDENT_REC[STUDENT_AWARD8]);
}// CASE
else if (ROW == 4) {
AWARD_TEXT = TRIM(STUDENT_REC[STUDENT_AWARD9] + " " + STUDENT_REC[STUDENT_AWARD10]);
}// CASE
else if (ROW == 5) {
AWARD_TEXT = TRIM(STUDENT_REC[STUDENT_AWARD11] + " " + STUDENT_REC[STUDENT_AWARD12]);
}// CASE
else if (OTHERWISE) {
AWARD_TEXT = "";
}
// END CASE
PHONE_TEXT = "";
}
PRINT(SPACE(2) + "|" + SPACE(8) + "|" + FORMAT(PHONE_TEXT, "L#20") + "|" + SPACE(8) + "|" + FORMAT(MEDICAL_TEXT, "L#20") + "|");
for(BOX_NO = START_BOX; BOX_NO <= END_BOX; BOX_NO += 1) {
PRINT("  |");
}
PRINT(SPACE(10) + "|" + AWARD_TEXT);
if (ROW < EXTRA_ROWS) { PRINT(); }
}
PRINTCR(CR + STR(UL, LINE_LENGTH));
}
LINE_COUNT = LINE_COUNT - 1;
/*  Print numbered boxes at foot of last page */
/*  First row of 8 :- */
if (LINE_COUNT < 5) {
L0200();
LINE_COUNT = PAGE_DEPTH;
}
BOX_NO = 1;
L0300();
LINE_COUNT = LINE_COUNT - 5;
if (LINE_COUNT < 5) {
L0200();
LINE_COUNT = PAGE_DEPTH;
}
/*  Second row of 8 boxes */
BOX_NO = 9;
L0300();
/* *     PRINTER OFF */
return;
/* ****************************** */
}
void L0200() {
/*   PRINT REPORT HEADINGS  * */
/* ****************************** */
if (NO_OF_BOXES > 3) {
PADDING_JUST = "L#" + NO_OF_BOXES * 3;
} else {
PADDING_JUST = "L#11";
}
LINE_LENGTH = 89 + NO_OF_BOXES * 3;
PAGE_NUMBER = PAGE_NUMBER + 1;
TITLE = "Course Attendance Register - " + CENTRES_REC[CENTRE_NAME];
UNDERLINE = STR("=", LEN(TITLE));
if (MACHINE_TYPE == "UNIVERSE") {
if (FIRST_PAGE) {
FIRST_PAGE = FALSE;
} else {
PAGE();
}
} else {
PRINT(FF);
}
PRINT("(" + PROGRAM + ")" + SPACE(20) + FORMAT(TITLE, "L#63"));
PRINT(TIMEDATE());
PRINT("  Page ");
PRINTCR(PAGE_NUMBER);
PRINTCR(SPACE(27) + UNDERLINE);
PRINT("Code:          " + FORMAT(COURSE_CODE, "L#8"));
PRINTCR(SPACE(11) + "Description:  " + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], "L#49") + "Max Places:  " + COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES]);
PRINT("Session(s) on: ");
if (MATCH(COURSE_DET_REC[COURSE_DET_FREQUENCY],"'W'1N")) {
if (COURSE_DET_REC[COURSE_DET_DAYS] != "") {
PRINT(FORMAT(COURSE_DET_REC[COURSE_DET_DAYS], "L#19"));
} else {
PRINT(FORMAT(OCONV(COURSE_START_DATE, "DWA"), "L#19"));
}
} else {
PRINT(FORMAT(OCONV(COURSE_START_DATE, "DWA"), "L#19"));
}
PRINTCR("Instructors:  " + FORMAT((INSTRUCTOR1 + SPACE(3) + INSTRUCTOR2), "L#46"));
PRINT("Time:          " + FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, 1], "MT"), "L#5"));
PRINT(SPACE(13));
PRINT("Course Dates:  " + OCONV(COURSE_START_DATE, "D") + " - ");
PRINT(OCONV(COURSE_DET_REC[COURSE_DET_END], "D"));
if (EXCEPTION_DATES != "") {
PRINT(" except ");
EX_POS = 1;
do {
EX_DATE = EXCEPTION_DATES[EX_POS];
if (EX_DATE == "") break;
if (EX_POS > 1) { PRINT(", "); }
PRINT(OCONV(EX_DATE, "D"));
EX_POS = EX_POS + 1;
} while (true);
}
PRINT();
/* !*  PRINT SPACE(20):"Maximum Places:  ":COURSE.DET.MAXIMUM.PLACES */
PRINT(SPACE(48) + FORMAT(("(" + OCONV(COURSE_START_DATE, "DWA") + ")"), "L#11"));
PRINT(SPACE(3));
PRINTCR("(" + OCONV(COURSE_DET_REC[COURSE_DET_END], "DWA") + ")");
PRINTCR(STR(UL, LINE_LENGTH));
PRINT("   STUDENT  NAME AND             DATE OF  MEDICAL              ");
PRINTCR(FORMAT("ATTENDANCE", PADDING_JUST) + "LESSON     AWARDS");
PRINT("   NUMBER   TELEPHONE            BIRTH    DETAILS" + SPACE(14));
PRINTCR(FORMAT("", PADDING_JUST) + "CONDITIONS");
PRINT(SPACE(63));
START_BOX = BOXES_PRINTED + 1;
END_BOX = START_BOX + NO_OF_BOXES - 1;
for(BOX_NO = START_BOX; BOX_NO <= END_BOX; BOX_NO += 1) {
PRINT(FORMAT(BOX_NO, "R#2") + " ");
}
PRINT(CR);
PRINTCR(STR(UL, LINE_LENGTH));
return;
/* ********************************************** */
}
void L0300() {
/*  Print a row of blank boxes              * */
/* ********************************************** */
PRINTCR(STR(UL, 121));
PRINT("|");
for(COMMON.X = 1; COMMON.X <= 8; COMMON.X += 1) {
PRINT(SPACE(6) + FORMAT((COMMON.X + BOX_NO - 1), "R#2") + SPACE(6) + "|");
}
PRINT(CR);
PRINT(STR(UL, 121));
for(COMMON.X = 1; COMMON.X <= 3; COMMON.X += 1) {
PRINT();
PRINT("|");
for(COMMON.Y = 1; COMMON.Y <= 8; COMMON.Y += 1) {
PRINT(SPACE(14) + "|");
}
}
PRINT(CR);
PRINTCR(STR(UL, 121));
return;
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}