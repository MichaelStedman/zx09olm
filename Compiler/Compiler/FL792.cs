//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL792 : UvBase
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
readonly UvVar ADEXP_NAME = 1;
readonly UvVar ADEXP_AGE = 2;
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
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] ACTIVITY_EXPORT_REC = new UvVar[5];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_ENROLMENT = "";
UvVar FL_ACTIVITY_EXPORT = "";
UvVar CONV_START_DATE = "";
UvVar CONV_END_DATE = "";
UvVar START_DATE = "";
UvVar END_DATE = "";
UvVar COURSE = "";
FL796 FL796;
UvVar RESPONSE = "";
UvVar PROCESS_EXECUTE = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar EXPORT_ID = "";
UvVar ID = "";
UvVar COURSE_CODE = "";
UvVar COURSE_START_DATE = "";
UvVar SESSION_DATE_COUNT = "";
UvVar DATE_NO = "";
UvVar DONE = "";
UvVar THIS_DATE = "";
UvVar FLAG_NO = "";
UvVar SURNAME_LIST = "";
UvVar ID_LIST = "";
UvVar FULLNAME_LIST = "";
UvVar AGE_LIST = "";
UvVar TOTAL_EXPECTED = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_NO = "";
UvVar STUDENT_ID = "";
UvVar ENROL_ID = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar NAME = "";
UvVar AGE = "";
UvVar DD_MM_YYYY = "";
UvVar NOW_YYYY = "";
UvVar NOW_MM = "";
UvVar NOW_DD = "";
UvVar EXTERNAL_DOB = "";
UvVar DOB_MM = "";
UvVar DOB_DD = "";
UvVar DOB_YYYY = "";
UvVar POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL792() {
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
/*     PREPARE ACTIVITY DAY DATA FOR EXPORT */
PROGRAM = "FL792";
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
/* !*  INCLUDE FL.FILES FL.INSTRUCTORS */
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
/* !*  INCLUDE FL.FILES FL.CENTRES */
#region INCLUDE FL.FILES FL.ACTIVITY.EXPORT
if (!OPEN("FL.ACTIVITY.EXPORT", out FL_ACTIVITY_EXPORT)) { STOP("201", "FL.ACTIVITY.EXPORT"); }

#endregion
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
CONV_START_DATE = CONTROLS_REC[5];
CONV_END_DATE = CONTROLS_REC[6];
START_DATE = OCONV(CONTROLS_REC[5], "D");
END_DATE = OCONV(CONTROLS_REC[6], "D");
COURSE = CONTROLS_REC[7];
FL796 = new FL796(ref RESPONSE);
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
INSTRUCTION = "SSELECT FL.COURSE.DETAILS WITH TYPE = \"A\" AND WITH END.DATE >= \"" + START_DATE + "\" AND WITH START.DATE <= \"" + END_DATE + "\"";
if (COURSE != "") {
INSTRUCTION = INSTRUCTION + " AND WITH COURSE.CODE = \"" + COURSE + "\"";
}
nrf0 = "S";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CLEARFILE(FL_ACTIVITY_EXPORT);
EXPORT_ID = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, ID)) { STOP(); }
COURSE_CODE = FIELD(ID, "*", 2);
if (!MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) { MAT(ref COURSE_MSTR_REC, ""); }
/* !*     MATREAD INSTRUCTOR.REC FROM FL.INSTRUCTORS, COURSE.DET.INSTRUCTOR ELSE MAT INSTRUCTOR.REC = "" */
/* !*     INSTRUCTOR1 = TRIM(INSTRUCTOR.TITLE:" ":INSTRUCTOR.FORENAME:" ":INSTRUCTOR.SURNAME) */
COURSE_START_DATE = FIELD(ID, "*", 1);
SESSION_DATE_COUNT = DCOUNT(COURSE_DET_REC[COURSE_DET_SESSION_DATES], VM);
DATE_NO = 1;
DONE = FALSE;
do {
if (DONE || DATE_NO > SESSION_DATE_COUNT) break;
THIS_DATE = COURSE_DET_REC[COURSE_DET_SESSION_DATES][1, DATE_NO];
// BEGIN CASE
// CASE
if (THIS_DATE < CONV_START_DATE) {
NULL();
}// CASE
else if (THIS_DATE > CONV_END_DATE) {
DONE = TRUE;
}// CASE
else if (OTHERWISE) {
for(FLAG_NO = 1; FLAG_NO <= COURSE_DET_REC[COURSE_DET_SESSIONS]; FLAG_NO += 1) {
L0100();
L0150();
}
}
// END CASE
DATE_NO = DATE_NO + 1;
} while (true);
} while (true);
return;
/* ********************************** */
}
void L0100() {
/*   BUILD EXPORT DETAILS       * */
/* ********************************** */
SURNAME_LIST = "";
/* !*  BALANCE.LIST = "" */
ID_LIST = "";
FULLNAME_LIST = "";
AGE_LIST = "";
/* !*  PHONE.LIST = "" */
/* !*  MEDICAL.LIST = "" */
/* !*  ADDRESS.LIST = "" */
/* !*  COMMENTS.LIST = "" */
/* !*  CONTACT.LIST  = "" */
/* !*  KEYWORD.LIST  = "" */
TOTAL_EXPECTED = 0;
NO_OF_STUDENTS = DCOUNT(COURSE_DET_REC[COURSE_DET_STUDENT_IDS], VM);
for(STUDENT_NO = 1; STUDENT_NO <= NO_OF_STUDENTS; STUDENT_NO += 1) {
STUDENT_ID = COURSE_DET_REC[COURSE_DET_STUDENT_IDS][1, STUDENT_NO];
ENROL_ID = ID + "*" + STUDENT_ID;
if (!MATREAD(ref ENROL_REC, FL_ENROLMENT, ENROL_ID)) { MAT(ref ENROL_REC, ""); }
/*  Is student enrolled for this session? */
if (ENROL_REC[ENROL_SESSIONS][1, DATE_NO, FLAG_NO] == "Y") {
TOTAL_EXPECTED = TOTAL_EXPECTED + 1;
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
STUDENT_IS_MEMBER = FALSE;
if (STUDENT_ID == "") {
NAME = "";
/* !*           WORK.TEL = "" */
/* !*           HOME.TEL = "" */
/* !*           STUDENT.DOB = "" */
/* !*           STUDENT.SURNAME = "" */
} else {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
NAME = TRIM(MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
/* !*              WORK.TEL = MEMBER.BUS.PHONE<1,1> */
/* !*              HOME.TEL = MEMBER.HOME.PHONE<1,1> */
STUDENT_REC[STUDENT_DOB] = MEMBERS_REC[MEMBER_DOBS][1, 1];
STUDENT_REC[STUDENT_SURNAME] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
/* !*              TEMP.ADDRESS = MEMBER.ADDRESS */
} else {
NAME = TRIM(STUDENT_REC[STUDENT_FORENAME] + " " + STUDENT_REC[STUDENT_SURNAME]);
/* !*              WORK.TEL = STUDENT.WORK.TEL */
/* !*              HOME.TEL = STUDENT.HOME.TEL */
/* !*              TEMP.ADDRESS = STUDENT.ADDRESS1:VM:STUDENT.ADDRESS2:VM:STUDENT.ADDRESS3:VM:STUDENT.ADDRESS4:VM:STUDENT.POST.CODE */
}
}
/* !*        N = 1 */
/* !*        MVC = 1 */
/* !*        LOOP */
/* !*           UNTIL N > 4 DO */
/* !*           IF TEMP.ADDRESS<1,MVC> = "" THEN */
/* !*              TEMP.ADDRESS = DELETE(TEMP.ADDRESS,1,MVC,0) */
/* !*           END ELSE */
/* !*              MVC = MVC + 1 */
/* !*           END */
/* !*           N = N + 1 */
/* !*        REPEAT */
/* !*        STUDENT.ADDRESS1 = TEMP.ADDRESS<1,1> */
/* !*        STUDENT.ADDRESS2 = TEMP.ADDRESS<1,2> */
/* !*        STUDENT.ADDRESS3 = TEMP.ADDRESS<1,3> */
/* !*        STUDENT.ADDRESS4 = TEMP.ADDRESS<1,4> */
/* !*        STUDENT.POST.CODE = TEMP.ADDRESS<1,5> */
/* !*        COURSE.BALANCE = 0 */
/* !*        DATE.PAID = "" */
/* !*        TRANS.NO = 1 */
/* !*        LOOP */
/* !*           UNTIL STUDENT.TRANS.DATES<1,TRANS.NO> = "" DO */
/* !*           IF STUDENT.TRANS.DETAILS.IDS<1,TRANS.NO> = ID THEN */
/* !*              COURSE.BALANCE = COURSE.BALANCE + STUDENT.TRANS.AMOUNTS<1,TRANS.NO> */
/* !*              IF STUDENT.TRANS.TYPES<1,TRANS.NO> = "P" THEN */
/* !*                 DATE.PAID = STUDENT.TRANS.DATES<1,TRANS.NO> */
/* !*              END */
/* !*           END */
/* !*           TRANS.NO = TRANS.NO + 1 */
/* !*        REPEAT */
/* !*        IF COURSE.BALANCE = 0 THEN */
/* !*           IF DATE.PAID = "" THEN */
/* !*              DATE.OR.AMOUNT = "N/A" */
/* !*           END ELSE */
/* !*              DATE.OR.AMOUNT = OCONV(DATE.PAID,"D0") */
/* !*           END */
/* !*        END ELSE */
/* !*           DATE.OR.AMOUNT = OCONV(COURSE.BALANCE, "MD2") */
/* !*        END */
/*  Calculate DOB on the day of the session */
AGE = "";
DD_MM_YYYY = OCONV(THIS_DATE, "D4/");
NOW_YYYY = DD_MM_YYYY.Substring(7, 4);
NOW_MM = DD_MM_YYYY.Substring(4, 2);
NOW_DD = DD_MM_YYYY.Substring(1, 2);
if (STUDENT_REC[STUDENT_DOB] != "") {
EXTERNAL_DOB = OCONV(STUDENT_REC[STUDENT_DOB], "D4/");
DOB_MM = FIELD(EXTERNAL_DOB, "/", 2);
DOB_DD = FIELD(EXTERNAL_DOB, "/", 1);
DOB_YYYY = FIELD(EXTERNAL_DOB, "/", 3);
AGE = NOW_YYYY - DOB_YYYY;
if (DOB_MM > NOW_MM) {
AGE = AGE - 1;
} else {
if (DOB_MM == NOW_MM) {
if (DOB_DD > NOW_DD) { AGE = AGE - 1; }
}
}
}
/*     Retrieve single set of student details */
if (!LOCATE(STUDENT_REC[STUDENT_SURNAME], SURNAME_LIST, 0, 0, 1, ref POS, "AL")) { NULL(); }
SURNAME_LIST = INSERT(SURNAME_LIST, POS, 0, 0, STUDENT_REC[STUDENT_SURNAME]);
/* !*        BALANCE.LIST = INSERT(BALANCE.LIST,POS,0,0,DATE.OR.AMOUNT) */
ID_LIST = INSERT(ID_LIST, POS, 0, 0, STUDENT_ID);
FULLNAME_LIST = INSERT(FULLNAME_LIST, POS, 0, 0, NAME);
AGE_LIST = INSERT(AGE_LIST, POS, 0, 0, AGE);
/* !*        PHONE.LIST    = INSERT(PHONE.LIST,POS,0,0,TRIM(HOME.TEL):VM:TRIM(WORK.TEL):VM:TRIM(STUDENT.CONTACT.PHONE)) */
/* !*        MEDICAL.LIST = INSERT(MEDICAL.LIST,POS,0,0,(STUDENT.MEDICAL1:VM:STUDENT.MEDICAL2:VM:STUDENT.MEDICAL3)) */
/* !*        ADDRESS.LIST = INSERT(ADDRESS.LIST,POS,0,0,(STUDENT.ADDRESS1:VM:STUDENT.ADDRESS2:VM:STUDENT.ADDRESS3:VM:STUDENT.ADDRESS4:VM:STUDENT.POST.CODE)) */
/* !*        COMMENTS.LIST = INSERT(COMMENTS.LIST,POS,0,0,(STUDENT.COMMENT1:VM:STUDENT.COMMENT2:VM:STUDENT.COMMENT3:VM:STUDENT.COMMENT4)) */
/* !*        CONTACT.LIST  = INSERT(CONTACT.LIST,POS,0,0,STUDENT.CONTACT.NAME:VM:STUDENT.DOCTOR.NAME:VM:STUDENT.DOCTOR.TEL) */
/* !*        KEYWORD.LIST  = INSERT(KEYWORD.LIST,POS,0,0,STUDENT.KEYWORD) */
}
}
return;
/* ***************************************** */
}
void L0150() {
/*  Output session details             * */
/* ***************************************** */
L0200();
for(STUDENT_NO = 1; STUDENT_NO <= TOTAL_EXPECTED; STUDENT_NO += 1) {
/*     Output single set of student details */
EXPORT_ID = EXPORT_ID + 1;
ACTIVITY_EXPORT_REC[ADEXP_NAME] = FULLNAME_LIST[STUDENT_NO];
ACTIVITY_EXPORT_REC[ADEXP_AGE] = AGE_LIST[STUDENT_NO];
MATWRITE(ACTIVITY_EXPORT_REC, FL_ACTIVITY_EXPORT, EXPORT_ID);
}
return;
/* ****************************** */
}
void L0200() {
/*   Insert dummy export    * */
/*       record to indicate     * */
/*       start of session       * */
/* ****************************** */
EXPORT_ID = EXPORT_ID + 1;
/* !*  ADEXP.NAME = COURSE.CODE: " [" : FLAG.NO : " of " : COURSE.DET.SESSIONS : "] " : OCONV(THIS.DATE,"DWA")[1,3]: " " : OCONV(THIS.DATE,"D2/") */
ACTIVITY_EXPORT_REC[ADEXP_NAME] = COURSE_CODE + " [" + FLAG_NO + "] " + OCONV(THIS_DATE, "DWA").Substring(1, 2) + " " + OCONV(THIS_DATE, "D2/");
if (COURSE_DET_REC[COURSE_DET_START_TIME][1, FLAG_NO] != "") {
ACTIVITY_EXPORT_REC[ADEXP_NAME] = ACTIVITY_EXPORT_REC[ADEXP_NAME] + " " + OCONV(COURSE_DET_REC[COURSE_DET_START_TIME][1, FLAG_NO], "MT");
}
ACTIVITY_EXPORT_REC[ADEXP_AGE] = "";
MATWRITE(ACTIVITY_EXPORT_REC, FL_ACTIVITY_EXPORT, EXPORT_ID);
return;
/*  End of program */
}
}
}
