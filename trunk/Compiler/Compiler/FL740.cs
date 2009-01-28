//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL740 : UvBase
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
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
readonly UvVar WAIT_MAST_IDS = 1;
readonly UvVar WAIT_MAST_STATUS = 2;
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
readonly UvVar AVAILABLE_MONDAY = 1;
readonly UvVar AVAILABLE_TUESDAY = 2;
readonly UvVar AVAILABLE_WEDNESDAY = 3;
readonly UvVar AVAILABLE_THURSDAY = 4;
readonly UvVar AVAILABLE_FRIDAY = 5;
readonly UvVar AVAILABLE_SATURDAY = 6;
readonly UvVar AVAILABLE_SUNDAY = 7;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] AVAILABLE = new UvVar[7];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_COURSE_DETAILS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FIRST_PAGE = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar PAGE_DEPTH = "";
UvVar FF = "";
UvVar PROCESS_EXECUTE = "";
UvVar ACTIVITY_CODE_LIST = "";
UvVar SELECT_CRITERIA = "";
UvVar NO_OF_WORDS = "";
UvVar WORD_NO = "";
UvVar ACTIVITY_CODE = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar PAGE_NUMBER = "";
UvVar OLD_ACT_CODE = "";
UvVar EOF = "";
UvVar COURSE_CODE = "";
UvVar NO_OF_IDS = "";
UvVar ID_NO = "";
UvVar PRINT_STUDENT_HEADING = "";
UvVar LINE_COUNT = "";
UvVar WAIT_ID = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar FULL_NAME = "";
UvVar ZZZ_STATUS = "";
UvVar TEST_POS = "";
UvVar DATE_JOINED = "";
UvVar ADDRESS = "";
UvVar DAY = "";
UvVar COURSE_FOUND = "";
UvVar NO_OF_COURSES = "";
UvVar COURSE_COUNT = "";
UvVar DETAIL_ID = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL740() {
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
/*     WAITING LIST REPORT */
PROGRAM = "FL740";
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

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
/* * Routine to set printer parameters  (condensed print) */
FIRST_PAGE = TRUE;
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "COURSES.LANDSCAPE";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
PAGE_DEPTH = 37;
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
ACTIVITY_CODE_LIST = CONTROLS_REC[5];
SELECT_CRITERIA = "";
NO_OF_WORDS = DCOUNT(ACTIVITY_CODE_LIST, " ");
for(WORD_NO = 1; WORD_NO <= NO_OF_WORDS; WORD_NO += 1) {
ACTIVITY_CODE = FIELD(ACTIVITY_CODE_LIST, " ", WORD_NO);
SELECT_CRITERIA = SELECT_CRITERIA + " \"" + ACTIVITY_CODE + "\"";
}
if (ACTIVITY_CODE_LIST == "") {
INSTRUCTION = "SSELECT FL.COURSE.MASTER BY 3";
} else {
INSTRUCTION = "SSELECT FL.COURSE.MASTER BY 3 WITH 3 = " + SELECT_CRITERIA;
}
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
PAGE_NUMBER = 1;
OLD_ACT_CODE = "";
EOF = FALSE;
do {
if (!READNEXT(ref COURSE_CODE, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (MATREAD(ref COURSE_MSTR_REC, FL_COURSE_MASTER, COURSE_CODE)) {
if (COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE] != OLD_ACT_CODE) {
L0100();
/*  Print students on waiting list */
PRINTER_ON();
L0200();
/*  Print page heading of new waiting list */
PRINTER_OFF();
L0300();
/*  Print course heading of new waiting list */
OLD_ACT_CODE = COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE];
}
L0400();
/*  Print course details */
}
} while (true);
L0100();
/*  Print students on waiting list */
/* !*  CALL FL235("STANDARD",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
PRINTER_ON();
/* DJA 13.03.06!PRINT PRINT.END.COMMAND: */
PRINTER_CLOSE();
PRINTER_OFF();
return;
/* *************************************** */
}
void L0100() {
/*   PRINT STUDENTS ON WAITING LIST  * */
/* *************************************** */
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
if (OLD_ACT_CODE != "") {
if (!(MATREAD(ref WAIT_MAST_REC, FL_WAIT_MASTER, OLD_ACT_CODE))) {
MAT(ref WAIT_MAST_REC, "");
}
NO_OF_IDS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
for(ID_NO = 1; ID_NO <= NO_OF_IDS; ID_NO += 1) {
if (PRINT_STUDENT_HEADING) {
PRINT_STUDENT_HEADING = FALSE;
PRINT();
PRINT(FORMAT("Ref/Joined", "L#14"));
PRINT(FORMAT("Student Name", "L#30"));
PRINT(FORMAT("Home/Work", "L#13"));
PRINT(FORMAT("D.O.B.", "L#13"));
PRINT("Mon  Tue  Wed  Thu  Fri  Sat  Sun  ");
PRINTCR("Comments");
PRINTCR(STR("-", 130));
LINE_COUNT = LINE_COUNT - 3;
if (LINE_COUNT < 1) { L0200(); }
}
WAIT_ID = WAIT_MAST_REC[WAIT_MAST_IDS][1, ID_NO];
if (!(MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, WAIT_ID))) {
MAT(ref WAIT_STUDENT_REC, "");
}
L0150();
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], WAIT_ID)) {
STUDENT_IS_MEMBER = TRUE;
FULL_NAME = TRIM(MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1] + " " + MEMBERS_REC[MEMBER_SURNAMES][1, 1]);
WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
WAIT_STUDENT_REC[WAIT_STUD_DOB] = MEMBERS_REC[MEMBER_DOBS][1, 1];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
} else {
FULL_NAME = TRIM(WAIT_STUDENT_REC[WAIT_STUD_TITLE] + " " + WAIT_STUDENT_REC[WAIT_STUD_FORENAME] + " " + WAIT_STUDENT_REC[WAIT_STUD_SURNAME]);
}
PRINT(FORMAT(WAIT_ID, "L#14"));
PRINT(FORMAT(FULL_NAME, "L#30"));
PRINT(FORMAT(WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME], "L#13"));
if (WAIT_STUDENT_REC[WAIT_STUD_DOB] != "") {
PRINT(FORMAT(OCONV(WAIT_STUDENT_REC[WAIT_STUD_DOB], "D"), "L#13"));
} else {
PRINT(SPACE(13));
}
PRINT(FORMAT(AVAILABLE[AVAILABLE_MONDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_TUESDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_WEDNESDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_THURSDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_FRIDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_SATURDAY], "L#5"));
PRINT(FORMAT(AVAILABLE[AVAILABLE_SUNDAY], "L#5"));
PRINTCR(FORMAT(WAIT_STUDENT_REC[WAIT_STUD_COMMENT], "L#25"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
ZZZ_STATUS = WAIT_MAST_REC[WAIT_MAST_STATUS][1, ID_NO];
if (LOCATE(OLD_ACT_CODE, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref TEST_POS, "AL")) {
DATE_JOINED = WAIT_STUDENT_REC[WAIT_STUD_DATES][1, TEST_POS];
if (DATE_JOINED != "") { DATE_JOINED = OCONV(DATE_JOINED, "D"); }
} else {
DATE_JOINED = "";
}
ADDRESS = "";
if (WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] != "") { ADDRESS[-1] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1]; }
if (WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] != "") { ADDRESS[-1] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2]; }
if (WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] != "") { ADDRESS[-1] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3]; }
if (WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] != "") { ADDRESS[-1] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4]; }
if (WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] != "") { ADDRESS[-1] = WAIT_STUDENT_REC[WAIT_STUD_POST_CODE]; }
PRINT(FORMAT(DATE_JOINED, "L#14"));
PRINT(FORMAT(ADDRESS[1], "L#30"));
PRINTCR(FORMAT(WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK], "L#13"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
if (ZZZ_STATUS == "P" || ADDRESS[2] != "") {
if (ZZZ_STATUS == "P") {
PRINT(FORMAT("*Priority*", "L#14"));
} else {
PRINT(SPACE(14));
}
PRINTCR(FORMAT(ADDRESS[2], "L#30"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
}
if (ADDRESS[3] != "") {
PRINTCR(SPACE(14) + FORMAT(ADDRESS[3], "L#30"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
}
if (ADDRESS[4] != "") {
PRINTCR(SPACE(14) + FORMAT(ADDRESS[4], "L#30"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
}
PRINT();
/*  Leave a line between students */
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
}
}
PRINTER_OFF();
return;
/* ******************************************** */
}
void L0150() {
/*   STRIP IMBEDDED SPACE FROM AVAILABLE  * */
/* ******************************************** */
AVAILABLE[AVAILABLE_MONDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_MONDAY];
AVAILABLE[AVAILABLE_TUESDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_TUESDAY];
AVAILABLE[AVAILABLE_WEDNESDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_WEDNESDAY];
AVAILABLE[AVAILABLE_THURSDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_THURSDAY];
AVAILABLE[AVAILABLE_FRIDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_FRIDAY];
AVAILABLE[AVAILABLE_SATURDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SATURDAY];
AVAILABLE[AVAILABLE_SUNDAY] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SUNDAY];
for(DAY = 1; DAY <= 7; DAY += 1) {
AVAILABLE[DAY] = OCONV(AVAILABLE[DAY], "MCT");
if (AVAILABLE[DAY].Substring(3, 1) == " ") {
AVAILABLE[DAY] = AVAILABLE[DAY].Substring(1, 2) + AVAILABLE[DAY].Substring(4, 2);
}
}
return;
/* *********************************** */
}
void L0200() {
/*   PRINT WAITING LIST HEADING  * */
/* *********************************** */
if (!(MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE]))) {
MAT(ref ACT_CODE_REC, "");
}
if (MACHINE_TYPE == "UNIVERSE") {
if (FIRST_PAGE) {
FIRST_PAGE = FALSE;
} else {
PAGE();
}
} else {
PRINT(FF);
}
PRINT("(" + PROGRAM + ")" + SPACE(30) + "COURSES WAITING LIST");
PRINT(SPACE(20) + OCONV(TIME(), "MTS") + SPACE(5));
PRINT(OCONV(TODAYS_DATE, "D"));
PRINT(SPACE(10) + "Page ");
PRINTCR(PAGE_NUMBER);
PRINTCR(SPACE(37) + "====================");
PRINT();
PRINT("Activity Code  " + FORMAT(COURSE_MSTR_REC[COURSE_MSTR_ACTIVITY_CODE], "L#10"));
PRINT("Description  " + ACT_CODE_REC[ACT_CODE_DESCRIPTION]);
PRINT();
PAGE_NUMBER = PAGE_NUMBER + 1;
LINE_COUNT = PAGE_DEPTH;
PRINT_STUDENT_HEADING = TRUE;
return;
/* ************************************ */
}
void L0300() {
/*   PRINT COURSE DETAIL HEADING  * */
/* ************************************ */
PRINTER_ON();
PRINT(FORMAT("Code", "L#10"));
PRINT(FORMAT("Description", "L#35"));
PRINT(FORMAT("From", "L#13"));
PRINT(FORMAT("To", "L#13"));
PRINT(FORMAT("Closes", "L#13"));
PRINT(FORMAT("Max", "R#4"));
PRINTCR(FORMAT("Vac", "R#4"));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
PRINTCR(STR("-", 130));
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
PRINTER_OFF();
return;
/* ***************************** */
}
void L0400() {
/*   PRINT COURSE DETAILS  * */
/* ***************************** */
PRINTER_ON();
COURSE_FOUND = FALSE;
NO_OF_COURSES = DCOUNT(COURSE_MSTR_REC[COURSE_MSTR_DATES], VM);
for(COURSE_COUNT = 1; COURSE_COUNT <= NO_OF_COURSES; COURSE_COUNT += 1) {
DETAIL_ID = COURSE_MSTR_REC[COURSE_MSTR_DATES][1, COURSE_COUNT] + "*" + COURSE_CODE;
if (MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DETAIL_ID)) {
if (COURSE_DET_REC[COURSE_DET_VACANCIES] > 0 && COURSE_DET_REC[COURSE_DET_END] >= TODAYS_DATE) {
if (NOT(COURSE_FOUND)) {
PRINT(FORMAT(COURSE_CODE, "L#10"));
PRINT(FORMAT(COURSE_MSTR_REC[COURSE_MSTR_DESC], "L#35"));
} else {
PRINT(SPACE(45));
}
COURSE_FOUND = TRUE;
PRINT(FORMAT(OCONV(COURSE_MSTR_REC[COURSE_MSTR_DATES][1, COURSE_COUNT], "D"), "L#13"));
PRINT(FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_END], "D"), "L#13"));
PRINT(FORMAT(OCONV(COURSE_DET_REC[COURSE_DET_CLOSE_DATE], "D"), "L#13"));
PRINT(FORMAT(COURSE_DET_REC[COURSE_DET_MAXIMUM_PLACES], "R#4"));
if (COURSE_MSTR_REC[COURSE_MSTR_TYPE] == "A") {
PRINTCR(SPACE(4));
} else {
PRINTCR(FORMAT(COURSE_DET_REC[COURSE_DET_VACANCIES], "R#4"));
}
}
}
}
LINE_COUNT = LINE_COUNT - 1;
if (LINE_COUNT < 1) { L0200(); }
PRINTER_OFF();
return;
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
