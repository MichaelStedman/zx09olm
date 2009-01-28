//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL728 : UvBase
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
readonly UvVar SCROLL = 1;
readonly UvVar TOGGLE = 2;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
#endregion
#region Variables
UvVar ACTION = "";
UvVar DISPLAY_MODE = "";
UvVar COURSE_DET_STUDENT_IDS = "";
UvVar REDISPLAY = "";
UvVar STUDENT_COUNT = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar PROG_MESS = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar FL_STUDENTS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_COURSE_PARAMS = "";
UvVar USE_MEMBER_COMMENTS = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar HEADING_TEXT = "";
UvVar HEADING_TEXT2 = "";
UvVar FOOTER = "";
UvVar STUDENT_LIST = "";
UvVar SURNAME_LIST = "";
UvVar NO_OF_STUDENTS = "";
UvVar STUDENT_NO = "";
UvVar STUDENT_ID = "";
UvVar SURNAME = "";
UvVar POS = "";
UvVar COURSE_DETAIL_ID = "";
UvVar CNT = "";
UvVar COURSE_LINE = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar ADDRESS_LINE1 = "";
UvVar NAME = "";
UvVar HOME_TEL = "";
UvVar WORK_TEL = "";
UvVar COURSE_BALANCE = "";
UvVar TRANS_NO = "";
UvVar COURSE_POS = "";
UvVar DATE_JOINED = "";
#endregion
public FL728(ref UvVar ACTION, ref UvVar DISPLAY_MODE, ref UvVar COURSE_DET_STUDENT_IDS, ref UvVar REDISPLAY, ref UvVar STUDENT_COUNT) {
this.ACTION = ACTION;
this.DISPLAY_MODE = DISPLAY_MODE;
this.COURSE_DET_STUDENT_IDS = COURSE_DET_STUDENT_IDS;
this.REDISPLAY = REDISPLAY;
this.STUDENT_COUNT = STUDENT_COUNT;
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
/*     DISPLAY COURSE MEMBER DETAILS */
PROGRAM = "FL728";
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
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
if (!READV(ref USE_MEMBER_COMMENTS, FL_COURSE_PARAMS, "COURSE.PARAMS", 47)) { USE_MEMBER_COMMENTS = "N"; }
USE_MEMBER_COMMENTS = USE_MEMBER_COMMENTS[1, 1];
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
if (DISPLAY_MODE == "N") {
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
} else {
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
}
if (ACTION == TOGGLE) {
STUDENT_COUNT = STUDENT_COUNT - WINDOW_DEPTH + 1;
if (STUDENT_COUNT < 1) { STUDENT_COUNT = 1; }
}
FOOTER = "";
STUDENT_LIST = "";
SURNAME_LIST = "";
NO_OF_STUDENTS = DCOUNT(COURSE_DET_STUDENT_IDS, VM);
for(STUDENT_NO = 1; STUDENT_NO <= NO_OF_STUDENTS; STUDENT_NO += 1) {
STUDENT_ID = COURSE_DET_STUDENT_IDS[1, STUDENT_NO];
if (READV(ref SURNAME, FL_STUDENTS, STUDENT_ID, 3)) {
if (!LOCATE(SURNAME, SURNAME_LIST, 0, 0, 1, ref POS, "AL")) { NULL(); }
SURNAME_LIST = INSERT(SURNAME_LIST, POS, 0, 0, SURNAME);
STUDENT_LIST = INSERT(STUDENT_LIST, 1, POS, 0, STUDENT_ID);
}
}
COURSE_DETAIL_ID = PROG_MESS[3] + "*" + PROG_MESS[2];
if (STUDENT_LIST[1, STUDENT_COUNT] == "") {
STUDENT_COUNT = 1;
}
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
STUDENT_IS_MEMBER = FALSE;
if (MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
if (USE_MEMBER_COMMENTS == "Y") {
ADDRESS_LINE1 = MEMBERS_REC[MEMBER_COMMENTS][1, 1];
} else {
ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
}
NAME = TRIM(MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_TITLES][1, 1] + " " + MEMBERS_REC[MEMBER_FORENAMES][1, 1]);
HOME_TEL = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
WORK_TEL = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
} else {
ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
NAME = TRIM(STUDENT_REC[STUDENT_SURNAME] + ", " + STUDENT_REC[STUDENT_TITLE] + " " + STUDENT_REC[STUDENT_FORENAME]);
HOME_TEL = STUDENT_REC[STUDENT_HOME_TEL];
WORK_TEL = STUDENT_REC[STUDENT_WORK_TEL];
}
COURSE_BALANCE = 0;
TRANS_NO = 1;
do {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_NO] == "") break;
if (STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_NO] == COURSE_DETAIL_ID) {
COURSE_BALANCE = COURSE_BALANCE + STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_NO];
}
TRANS_NO = TRANS_NO + 1;
} while (true);
COURSE_LINE = FORMAT(STUDENT_ID, "L#12") + FORMAT(NAME, "L#23");
if (DISPLAY_MODE == "N") {
if (LOCATE(COURSE_DETAIL_ID, STUDENT_REC[STUDENT_TRANS_DETAILS_IDS], 1, 0, 1, ref COURSE_POS, "AL")) {
DATE_JOINED = OCONV(STUDENT_REC[STUDENT_TRANS_DATES][1, COURSE_POS], "D2/");
} else {
DATE_JOINED = "";
}
COURSE_LINE = COURSE_LINE + " " + FORMAT(ADDRESS_LINE1, "L#22") + " " + FORMAT(DATE_JOINED, "L#10") + FORMAT(OCONV(COURSE_BALANCE, "MD2"), "R#7");
} else {
COURSE_LINE = COURSE_LINE + " " + FORMAT(HOME_TEL, "L#15") + FORMAT(WORK_TEL, "L#15");
}
}
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(COURSE_LINE, WINDOW_JUST));
}
STUDENT_COUNT = STUDENT_COUNT + 1;
} while (true);
INTERACT = VALID_DATA;
/*  Restart display from first date when end of list is reached */
/* !*     IF STUDENT.ID = '' THEN */
/* !*        STUDENT.COUNT = 1 */
/* !*     END */
CNT = 0;
} while (true);
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
L1000:;
/*  Display last line message */
INTERACT = INVALID_DATA;
PRINT(AT(79, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW + 1));
return;
}
}
}
