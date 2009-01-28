//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL734 : UvBase
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
readonly UvVar PARTIAL = 2;
readonly UvVar NOT_PRESENT = 9;
readonly UvVar ALREADY_PRESENT = 10;
readonly UvVar FWTERM_MODE = 0;
readonly UvVar TOUCHSCREEN_MODE = 1;
readonly UvVar SILENT_MODE = 2;
readonly UvVar SCREENS = 8;
readonly UvVar FL_CONTROL = 10;
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
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
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
readonly UvVar MC_NAME = 1;
readonly UvVar MC_ACCOUNT = 2;
readonly UvVar MC_TELEPHONE = 3;
readonly UvVar MC_ADDRESS1 = 4;
readonly UvVar MC_ADDRESS2 = 5;
readonly UvVar MC_ADDRESS3 = 6;
readonly UvVar MC_ADDRESS4 = 7;
readonly UvVar MC_ADDRESS5 = 8;
readonly UvVar MC_VAT_NUMBER = 9;
readonly UvVar MC_NOTE1 = 10;
readonly UvVar MC_NOTE2 = 11;
readonly UvVar MC_NOTE3 = 12;
readonly UvVar MC_SHORT_NAME = 13;
readonly UvVar MC_WEB_BOOKABLE = 14;
readonly UvVar MC_WEB_ENROLMENT = 15;
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
readonly UvVar FL_TOWNS = 21;
readonly UvVar TOWN_DESC = 1;
readonly UvVar APACS_MEMBER = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] MASTER_CENTRE_REC = new UvVar[15];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] TOWNS_REC = new UvVar[1];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] TEMP_REC = new UvVar[40];
#endregion
#region Variables
UvVar ACTIVITY_CODE = "";
UvVar DISPLAY_MODE = "";
UvVar PASSED_STUDENT_ID = "";
UvVar CONCESSION = "";
UvVar INTERACT = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar USER_STATUS = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar GO_BACK = "";
UvVar SC_POS = "";
UvVar SCREEN_LINES = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar DOTS_ONLY = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_MASTER_CENTRES = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_APACS_NUMBERS = "";
UvVar LIST_ALLOWED = "";
FL006 FL006;
UvVar SMART_CARD = "";
UvVar COURSE_PARAMS = "";
UvVar GET_STUDENT_ID = "";
UvVar POSITION_PRIVILEGES = "";
UvVar CHECK_FOR_DUPLICATES = "";
UvVar USE_MEMBER_COMMENTS = "";
UvVar NAME_INDEX_REQUEST = "";
UvVar SOUND_INDEX_REQUEST = "";
UvVar ADDRESS_INDEX_REQUEST = "";
UvVar MAX_FIELDS = "";
UvVar FIRST_FIELD = "";
UvVar DATA_FIELDS = "";
UvVar LINE = "";
UvVar ADDRESS_LINE1_FIELD_NO = "";
UvVar POSTCODE_FIELD_NO = "";
UvVar WORK_TEL_FIELD_NO = "";
UvVar DOB_FIELD_NO = "";
UvVar POSITION_FIELD_NO = "";
UvVar PRIORITY_FIELD_NO = "";
UvVar CENTRE2_FIELD_NO = "";
UvVar FIRST_PREFERENCE_FIELD_NO = "";
UvVar CONCESSION_FIELD_NO = "";
UvVar PROCESS_LOCKED = "";
UvVar VALID_AVAILABILITY = "";
UvVar AVAILABLE_CODE_DESCRIPTION_LIST = "";
UvVar STUDENT_ID = "";
UvVar STUDENT_IS_MEMBER = "";
UvVar AMENDING = "";
UvVar FIELD_NO = "";
UvVar START_FIELD = "";
UvVar END_FIELD = "";
UvVar ANS = "";
UvVar MAIN_KEY = "";
UvVar INPUT_LINE = "";
UvVar POS = "";
FL721 FL721;
UvVar REDISPLAY = "";
UvVar CURRENT_POS = "";
UvVar SEARCH_KEY = "";
UvVar NO_CODES = "";
UvVar ACT_MVC = "";
UvVar AMENDMENT_ALLOWED = "";
UvVar NO_MVS = "";
UvVar CURRENT_STATUS = "";
UvVar PRIORITY_POS = "";
UvVar FIELD_DATA = "";
UvVar ST_ATT = "";
UvVar VALUE = "";
UvVar ST_MV = "";
UvVar VALIDATION_NECESSARY = "";
UvVar ADDRESS_COMPLETE = "";
UvVar ST_COL = "";
UvVar ST_ROW = "";
UvVar ST_JUST = "";
FLQAS FLQAS;
UvVar ADDRESS = "";
UvVar TEMP_ATT = "";
UvVar AMC = "";
UvVar OLD_FIELD_DATA = "";
UvVar TEMP_FIELD_NO = "";
UvVar ST_LENGTH = "";
UvVar SMARTCARD_READ = "";
UvVar MEMBER_PROGRAM = "";
CallAt_MEMBER_PROGRAM CallAt_MEMBER_PROGRAM;
UvVar MDISL = "";
UvVar ST_MANDATORY = "";
UvVar ST_CONVERSION = "";
UvVar IFACE_TYPE = "";
UvVar SMART_MEMBER_NO = "";
UvVar APACS_NO = "";
UvVar SMART_DISPLAY_MODE = "";
FL_SMARTCARD FL_SMARTCARD;
UvVar TRANS_AMOUNT = "";
UvVar TRANS_TYPE = "";
UvVar TRANS_ID = "";
UvVar SMARTCARD_INTERACT = "";
UvVar CARD_ERROR_TYPE = "";
UvVar CARD_ERROR_MESS = "";
UvVar EPURSE_BALANCE = "";
UvVar LOYALTY_BALANCE = "";
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
UvVar ACTIVITY = "";
UvVar ZZZ_STATUS = "";
UvVar NEW_STUDENT = "";
UvVar STUDENT_LIST = "";
UvVar STATUS_LIST = "";
UvVar CREATION_ALLOWED = "";
FL735 FL735;
UvVar TEST_POS = "";
UvVar MATCH_LIST = "";
FL723 FL723;
UvVar NEW_STUDENT_NO = "";
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
UvVar SEARCH_ROUTE = "";
UvVar MEMBER_NUMBER = "";
FL000_20 FL000_20;
UvVar PADDED_ANS = "";
FL000_40 FL000_40;
UvVar STUDENT_EXISTS = "";
UvVar MAND_SURNAME = "";
UvVar FOUND_ON_MEMBERS = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar ID = "";
UvVar RETURNED_ANS = "";
UvVar CONV_ANS = "";
FL722 FL722;
UvVar OLD_FIELD_NO = "";
FL724 FL724;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL734(ref UvVar ACTIVITY_CODE, ref UvVar DISPLAY_MODE, ref UvVar PASSED_STUDENT_ID, ref UvVar[] STUDENT_REC, ref UvVar CONCESSION, ref UvVar INTERACT) {
this.ACTIVITY_CODE = ACTIVITY_CODE;
this.DISPLAY_MODE = DISPLAY_MODE;
this.PASSED_STUDENT_ID = PASSED_STUDENT_ID;
this.STUDENT_REC = STUDENT_REC;
this.CONCESSION = CONCESSION;
this.INTERACT = INTERACT;
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
/*     WAITING LIST MAINTENANCE */
PROMPT("");
PROGRAM = "FL734";
SCREEN_CODE = PROGRAM;
DOTS_ONLY = 0;
COMMON.CLR = "\\";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

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
#region INCLUDE FL.FILES FL.MASTER.CENTRES
#region INCLUDE FL.FILES FL.MASTER.CENTRES.EQU
if (!OPEN("FL.MASTER.CENTRES", out FL_MASTER_CENTRES)) { STOP("201", "FL.MASTER.CENTRES"); }

#endregion

#region INCLUDE FL.FILES FL.MASTER.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.MASTER.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
#region INCLUDE FL.FILES FL.TOWNS

#endregion
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
if (ACTIVITY_CODE != "") {
/*  Called from course/activity day enrolment. Abort */
/*  immediately if waiting lists are turned off for this */
/*  activity code */
if (!READV(ref LIST_ALLOWED, FL_ACTIVITY_CODES, ACTIVITY_CODE, 3)) { LIST_ALLOWED = ""; }
if (LIST_ALLOWED == "N") {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
return;
}
}
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[28, 1];
POSITION_PRIVILEGES = COURSE_PARAMS[23, 1];
CHECK_FOR_DUPLICATES = COURSE_PARAMS[30, 1];
USE_MEMBER_COMMENTS = COURSE_PARAMS[47, 1];
if (CHECK_FOR_DUPLICATES == "") { CHECK_FOR_DUPLICATES = "Y"; }
if (!(READV(ref NAME_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "NAME.INDEX.REQUEST", 1))) {
NAME_INDEX_REQUEST = "I";
}
if (!(READV(ref SOUND_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "SOUND.INDEX.REQUEST", 1))) {
SOUND_INDEX_REQUEST = "S";
}
if (!READV(ref ADDRESS_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "ADDRESS.INDEX.REQUEST", 1)) { ADDRESS_INDEX_REQUEST = "A"; }
MAT(ref TEMP_REC, "");
/* ************************************ */
/*   GET SCREEN DEFINITION ITEM       * */
/* ************************************ */
if (!(READ(ref SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE))) {
PRINTCR("CANNOT READ SCREEN " + SCREEN_CODE);
STOP();
}
if (USE_MEMBER_COMMENTS == "Y") {
if (SC_POS[28, 3].Substring(1, 7) == "Medical") {
SC_POS[28, 3] = "Comment 2 ";
WRITE(SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE);
}
} else {
if (SC_POS[28, 3].Substring(1, 9) == "Comment 2") {
SC_POS[28, 3] = "Medical   ";
WRITE(SC_POS, COMMON.FILES[SCREENS], SCREEN_CODE);
}
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
ADDRESS_LINE1_FIELD_NO = 6;
POSTCODE_FIELD_NO = 10;
WORK_TEL_FIELD_NO = 12;
DOB_FIELD_NO = 15;
POSITION_FIELD_NO = 18;
PRIORITY_FIELD_NO = 19;
CENTRE2_FIELD_NO = 17;
FIRST_PREFERENCE_FIELD_NO = 21;
CONCESSION_FIELD_NO = 28;
/* ************************************ */
/*   MAIN PROCESSING SECTION          * */
/* ************************************ */
PROCESS_LOCKED = "FL." + MACHINE_TYPE + ".LOCKED";
if (!(READ(ref VALID_AVAILABILITY, FL_COURSE_PARAMS, "AVAILABILITY.CHOICES"))) {
VALID_AVAILABILITY = "NONE";
VALID_AVAILABILITY[-1] = "ALL";
VALID_AVAILABILITY[-1] = "AM";
VALID_AVAILABILITY[-1] = "PM";
VALID_AVAILABILITY[-1] = "EV";
VALID_AVAILABILITY[-1] = "AM PM";
VALID_AVAILABILITY[-1] = "AM EV";
VALID_AVAILABILITY[-1] = "PM EV";
}
if (!(READ(ref AVAILABLE_CODE_DESCRIPTION_LIST, FL_COURSE_PARAMS, "AVAILABILITY.DESCRIPTIONS"))) {
AVAILABLE_CODE_DESCRIPTION_LIST = "Unavailable";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Available All Day";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Afternoons only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Evenings only";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings and Afternoons";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Mornings and Evenings";
AVAILABLE_CODE_DESCRIPTION_LIST[-1] = "Afternoons and Evenings";
}
do {
INTERACT = VALID_DATA;
STUDENT_ID = "";
STUDENT_IS_MEMBER = FALSE;
L0100();
L0058();
/*  Initialisation */
if (AMENDING) { L0050(); } else { FIELD_NO = 1; }
if (INTERACT == VALID_DATA) {
do {
do {
L0060();
/*  The 'max.fields - 1' on the following line stops the user being */
/*  prompted for 'concession' as this data is passed over from enrolments */
/*  if necessary.  The case statement lower down is also modified. */
if (INTERACT || AMENDING == TRUE || FIELD_NO == (MAX_FIELDS - 1)) break;
// BEGIN CASE
// CASE
if (AMENDING == PARTIAL && FIELD_NO <= 2) {
/*  Jump to availability fields */
/* !!                 FIELD.NO = FIRST.PREFERENCE.FIELD.NO */
FIELD_NO = CENTRE2_FIELD_NO;
/*  DJA 8.2.05 */
}// CASE
else if ((AMENDING == FALSE || AMENDING == PARTIAL) && FIELD_NO == CENTRE2_FIELD_NO) {
FIELD_NO = FIRST_PREFERENCE_FIELD_NO;
}// CASE
else if (OTHERWISE) {
FIELD_NO = FIELD_NO + 1;
if (FIELD_NO == POSITION_FIELD_NO || FIELD_NO == PRIORITY_FIELD_NO) {
if (INDEX(POSITION_PRIVILEGES, USER_STATUS, 1)) {
/*  User is permitted to amend list positions */
NULL();
} else {
/*  Clear dots from priority field if necessary */
START_FIELD = PRIORITY_FIELD_NO;
END_FIELD = PRIORITY_FIELD_NO;
L6000();
/* !*              GOSUB 0050 */
FIELD_NO = POSITION_FIELD_NO + 2;
}
}
}
// END CASE
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
if (FIELD_NO == POSITION_FIELD_NO || FIELD_NO == PRIORITY_FIELD_NO) {
if (INDEX(POSITION_PRIVILEGES, USER_STATUS, 1)) {
/*  User is permitted to amend list positions */
NULL();
} else {
FIELD_NO = POSITION_FIELD_NO - 1;
}
}
/* !!              CASE AMENDING AND FIELD.NO = 17 AND ANS = "Y" */
/*  Jump to 'course' as the customer has made a commitment to book */
/* !!                 FIELD.NO = 18 */
}// CASE
else if (FIELD_NO == (MAX_FIELDS - 1)) {
/*  Clear dots from concession field if necessary */
START_FIELD = CONCESSION_FIELD_NO;
END_FIELD = CONCESSION_FIELD_NO;
L6000();
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
if (MAIN_KEY != "" && INTERACT != EXIT) {
/*  Updates are performed in 0050 as several different actions are possible */
}
}
if (INTERACT == EXIT) break;
} while (true);
return;
/* ************************************* */
}
void L0050() {
/*   ENTER AMENDMENT FIELD NUMBER  * */
/* ************************************* */
ACTIVITY_CODE = "";
AMENDING = TRUE;
INTERACT = INVALID_DATA;
do {
if (DISPLAY_MODE == 1) {
INPUT_LINE = "  Field No, 'R'emove, 'C'opy, 'M'ove, 'A'nother, 'F'inish ";
} else {
INPUT_LINE = "  Enter Field No or 'F' to Finish ";
}
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 3);
if (LEN(ANS) > 2) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == "") {
/*  No paging at this time */
INTERACT = INVALID_DATA;
}// CASE
else if (ANS == "F") {
L0055();
/*  Perform file updates */
if (DISPLAY_MODE == 1) {
INTERACT = FINISH;
/* !*GOSUB 0058; * Initialisation */
} else {
/*  Return to enrolments */
INTERACT = EXIT;
}
}// CASE
else if (ANS == "R" && DISPLAY_MODE == 1) {
/*  Remove student from list (i.e. delete) */
/*  DJA 24.09.04 */
/*  Lock master record now, since it was originally read 'unsafe' */
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY)) { MAT(ref WAIT_MAST_REC, ""); }
L9000();
/*  Transfer data out of temp rec */
if (LOCATE(MAIN_KEY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL")) {
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, POS, 0);
WAIT_STUDENT_REC[WAIT_STUD_DATES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_DATES], 1, POS, 0);
}
/*  After confirmation, delete the waiting list details if they are not */
/*  on any other lists */
if (WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] == "") {
/* DJA 08.02.00*      INTERACT = INVALID.DATA */
/* DJA 08.02.00*      LOOP */
/* DJA 08.02.00*         WHILE INTERACT = INVALID.DATA DO */
/* DJA 08.02.00*         INPUT.LINE = "  This person is no longer on a waiting list. Delete their details?  " */
/* DJA 08.02.00*         PRINT @(0,21):SCREEN.FOOT.BACK:SCREEN.FOOT.FORE: */
/* DJA 08.02.00*         PRINT @(2,21): INPUT.LINE: */
/* DJA 08.02.00*         INPUT ANS,3:;IF LEN(ANS) > 2 THEN PRINT @(-9):' ':;ANS=ANS[1,2] */
/* DJA 08.02.00*         PRINT @(2,21): SPACE(70): */
/* DJA 08.02.00*         BEGIN CASE */
/* DJA 08.02.00*         CASE ANS = ABANDON */
/* DJA 08.02.00*            INTERACT = EXIT */
/* DJA 08.02.00*         CASE ANS = "Y" */
DELETE(FL_WAIT_STUDENTS, STUDENT_ID);
INTERACT = VALID_DATA;
/* DJA 08.02.00*         CASE ANS = "N" */
/* DJA 08.02.00*            MATWRITE WAIT.STUDENT.REC ON FL.WAIT.STUDENTS, STUDENT.ID */
/* DJA 08.02.00*            INTERACT = VALID.DATA */
/* DJA 08.02.00*         CASE OTHERWISE */
/* DJA 08.02.00*            INTERACT = INVALID.DATA */
/* DJA 08.02.00*         END CASE */
/* DJA 08.02.00*      REPEAT */
} else {
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
if (INTERACT != EXIT) {
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, POS, 0);
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, POS, 0);
}
if (WAIT_MAST_REC[WAIT_MAST_IDS] == "") {
DELETE(FL_WAIT_MASTER, MAIN_KEY);
} else {
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY);
}
INTERACT = FINISH;
INPUT_LINE = "  This person has now been removed from this waiting list. Press <RET>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 6);
if (LEN(ANS) > 5) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
}
}// CASE
else if (ANS == "C" && DISPLAY_MODE == 1) {
/*  Copy student onto another list (leaving them on the current one) */
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "  Enter the activity waiting list on which to include this person ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 6);
if (LEN(ANS) > 5) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
if (ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
if (INTERACT != EXIT) {
L0100();
L0300();
}
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT) {
INTERACT = EXIT;
}// CASE
else if (ANS == MAIN_KEY) {
INTERACT = INVALID_DATA;
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
if (MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, ANS)) {
L0055();
/*  File any updates done in readiness for this update */
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, ANS)) { MAT(ref WAIT_MAST_REC, ""); }
TEMP_REC[18] = "";
/*  They will join the END of the list unless a priority */
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref CURRENT_POS, "AL")) {
L0056();
} else {
SEARCH_KEY = ANS;
L0057();
}
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ANS);
if (!(LOCATE(ANS, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL"))) {
NO_CODES = DCOUNT(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], VM);
ACT_MVC = NO_CODES + 1;
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, ACT_MVC] = ANS;
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, ACT_MVC] = TODAYS_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
INTERACT = FINISH;
INPUT_LINE = "  This person has now joined the other waiting list as well. Press <RET>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 6);
if (LEN(ANS) > 5) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
} else {
nrf0 = 14;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ANS);
INTERACT = INVALID_DATA;
}
}
// END CASE
} while (true);
}// CASE
else if (ANS == "M" && DISPLAY_MODE == 1) {
/*  Move student from this list to another (i.e. delete them from this list) */
INTERACT = INVALID_DATA;
do {
if (!(INTERACT == INVALID_DATA)) break;
INPUT_LINE = "  Enter the activity waiting list to which to move this person ";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 6);
if (LEN(ANS) > 5) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
PRINT(AT(2, 21) + SPACE(70));
if (ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
if (INTERACT != EXIT) {
L0100();
L0300();
}
}
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON || INTERACT == EXIT) {
INTERACT = EXIT;
}// CASE
else if (ANS == MAIN_KEY) {
INTERACT = INVALID_DATA;
nrf0 = 13;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
if (MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, ANS)) {
L0055();
/*  File any updates done in readiness for this update */
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, ANS)) { MAT(ref WAIT_MAST_REC, ""); }
TEMP_REC[18] = "";
/*  They will join the END of the list unless a priority */
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref CURRENT_POS, "AL")) {
L0056();
} else {
SEARCH_KEY = ANS;
L0057();
}
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ANS);
if (!(LOCATE(ANS, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL"))) {
NO_CODES = DCOUNT(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], VM);
ACT_MVC = NO_CODES + 1;
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, ACT_MVC] = ANS;
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, ACT_MVC] = TODAYS_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
/*  Now remove the person from the 'current' waiting list */
if (MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY)) {
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, POS, 0);
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, POS, 0);
if (WAIT_MAST_REC[WAIT_MAST_IDS] == "") {
DELETE(FL_WAIT_MASTER, MAIN_KEY);
} else {
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY);
}
}
}
if (LOCATE(MAIN_KEY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL")) {
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, POS, 0);
WAIT_STUDENT_REC[WAIT_STUD_DATES] = DELETE(WAIT_STUDENT_REC[WAIT_STUD_DATES], 1, POS, 0);
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
INTERACT = FINISH;
INPUT_LINE = "  This person has been transferred to the new list. Press <RET>";
PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
PRINT(AT(2, 21) + INPUT_LINE);
INPUT(out ANS, 6);
if (LEN(ANS) > 5) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 2); }
} else {
nrf0 = 14;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ANS);
INTERACT = INVALID_DATA;
}
}
// END CASE
} while (true);
}// CASE
else if (ANS == "A" && DISPLAY_MODE == 1) {
/*  Recall the window to allow selection of another student */
L0055();
/*  File current details */
ACTIVITY_CODE = MAIN_KEY;
INTERACT = FINISH;
}// CASE
else if (MATCH(ANS,"0N") && ANS >= 1 && ANS <= 26) {
/*  DJA 28.07.00 */
AMENDMENT_ALLOWED = TRUE;
if ((ANS + FIRST_FIELD) == POSITION_FIELD_NO || (ANS + FIRST_FIELD) == PRIORITY_FIELD_NO) {
if (INDEX(POSITION_PRIVILEGES, USER_STATUS, 1)) {
/*  User is permitted to amend list positions */
NULL();
} else {
AMENDMENT_ALLOWED = FALSE;
}
}
if (STUDENT_IS_MEMBER) {
if (ANS <= (WORK_TEL_FIELD_NO - 2) || ANS == (DOB_FIELD_NO - 2)) {
nrf0 = 25;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
AMENDMENT_ALLOWED = FALSE;
}
}
if (AMENDMENT_ALLOWED) {
FIELD_NO = ANS + FIRST_FIELD;
INTERACT = VALID_DATA;
}
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* ******************************************************** */
}
void L0055() {
/*  File updates. Called after 'F' to file and prior  * */
/*      to the more fiddly 'M'ove, 'C'opy functions etc   * */
/* ******************************************************** */
/*  DJA 27.09.04 */
/*  Lock master record now, since it was originally read 'unsafe' */
if (!MATREADU(ref WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY)) { MAT(ref WAIT_MAST_REC, ""); }
L9000();
if (!(LOCATE(MAIN_KEY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL"))) {
NO_CODES = DCOUNT(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], VM);
ACT_MVC = NO_CODES + 1;
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, ACT_MVC] = MAIN_KEY;
if (TEMP_REC[28] == "") {
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, ACT_MVC] = TODAYS_DATE;
} else {
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, ACT_MVC] = TEMP_REC[28];
}
}
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref CURRENT_POS, "AL")) {
L0056();
} else {
SEARCH_KEY = MAIN_KEY;
L0057();
}
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY);
return;
/* ************************************************************ */
}
void L0056() {
/*   Locate/insert or move student id in master record    * */
/* ************************************************************ */
/*  Validation routines are responsible for synchronising priority flags and */
/*  list positions so that any priority cases are always at the top of the list. */
/*  This code may, therefore, re-perform some tasks */
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
// BEGIN CASE
// CASE
if (TEMP_REC[18] == "") {
NULL();
}// CASE
else if (TEMP_REC[18] == CURRENT_POS) {
NULL();
}// CASE
else if (TEMP_REC[18] > NO_MVS) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, CURRENT_POS, 0);
WAIT_MAST_REC[WAIT_MAST_IDS][1, -1] = STUDENT_ID;
CURRENT_STATUS = WAIT_MAST_REC[WAIT_MAST_STATUS][1, CURRENT_POS];
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, CURRENT_POS, 0);
WAIT_MAST_REC[WAIT_MAST_STATUS][1, NO_MVS] = CURRENT_STATUS;
}// CASE
else if (OTHERWISE) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, CURRENT_POS, 0);
CURRENT_STATUS = WAIT_MAST_REC[WAIT_MAST_STATUS][1, CURRENT_POS];
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, CURRENT_POS, 0);
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, TEMP_REC[18], 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, TEMP_REC[18], 0, CURRENT_STATUS);
}
// END CASE
return;
/* ******************************************************** */
}
void L0057() {
/*   Locate and insert student */
/* ******************************************************** */
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
if (TEMP_REC[18] == "" || TEMP_REC[18] > NO_MVS) {
if (TEMP_REC[27] == "" || WAIT_MAST_REC[WAIT_MAST_IDS] == "") {
/*  Not a priority case or first entry for this list */
WAIT_MAST_REC[WAIT_MAST_IDS][1, -1] = STUDENT_ID;
WAIT_MAST_REC[WAIT_MAST_STATUS][1, NO_MVS + 1] = TEMP_REC[27];
} else {
PRIORITY_POS = 1;
do {
if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, PRIORITY_POS] != "P" || PRIORITY_POS > NO_MVS) break;
PRIORITY_POS = PRIORITY_POS + 1;
} while (true);
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, PRIORITY_POS, 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, PRIORITY_POS, 0, "P");
}
} else {
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, TEMP_REC[18], 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, TEMP_REC[18], 0, TEMP_REC[27]);
}
return;
/* *********************************************** */
}
void L0058() {
/*  Initialisation before activity selection * */
/* *********************************************** */
AMENDING = FALSE;
MAIN_KEY = "";
MAT(ref TEMP_REC, "");
MAT(ref WAIT_STUDENT_REC, "");
MAT(ref WAIT_MAST_REC, "");
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
/* **MAT WAIT.MAST.REC = "" */
/* **MAT WAIT.STUDENT.REC = "" */
/* **MAT TEMP.REC = "" */
} else {
VALUE = TEMP_REC[ST_ATT][1, ST_MV];
}
VALIDATION_NECESSARY = TRUE;
ADDRESS_COMPLETE = FALSE;
// BEGIN CASE
// CASE
if (ST_ATT == 0 && ACTIVITY_CODE != "") {
ANS = ACTIVITY_CODE;
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(ANS, ST_JUST));
/*  If display mode is '3' the student information is already known */
if (STUDENT_REC[STUDENT_SURNAME] != "" && PASSED_STUDENT_ID != "" && DISPLAY_MODE == 3 && STUDENT_REC[STUDENT_SURNAME] != "") {
STUDENT_ID = PASSED_STUDENT_ID;
/*  DJA 2.4.02 */
/*  1085 was counting WAIT.MAST.IDS but the record was null as it */
/*  hadn't been read in yet. This meant all new students placed on */
/*  the waiting list via Enrolments went straight to number one! */
MAIN_KEY = ACTIVITY_CODE;
/*  DJA 24.09.04 Change READU to READ */
if (!MATREAD(ref WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY)) { MAT(ref WAIT_MAST_REC, ""); }
L1085();
TEMP_REC[26] = CONCESSION;
START_FIELD = 29;
END_FIELD = 29;
L6000();
}
/*  DJA 28.11.01 */
}// CASE
else if (ST_ATT == 1 && DISPLAY_MODE == 3 && STUDENT_REC[STUDENT_SURNAME] == "" && PASSED_STUDENT_ID != "") {
/*  Member number was passed from enrolment */
ANS = PASSED_STUDENT_ID;
}// CASE
else if (ST_ATT == 1 && DISPLAY_MODE == "3" && STUDENT_ID != "") {
/*  Enrolment has passed the relevant details.  Skip to availability fields */
AMENDING = PARTIAL;
VALIDATION_NECESSARY = FALSE;
}// CASE
else if (OTHERWISE) {
if (FIELD_NO == ADDRESS_LINE1_FIELD_NO) {
FLQAS = new FLQAS(ref ADDRESS);
if (ADDRESS != "") {
TEMP_ATT = ADDRESS_LINE1_FIELD_NO - 1;
for(AMC = 1; AMC <= 4; AMC += 1) {
TEMP_REC[AMC + ADDRESS_LINE1_FIELD_NO - 2] = "";
if (ADDRESS[AMC] != "") {
TEMP_REC[TEMP_ATT] = ADDRESS[AMC];
TEMP_ATT = TEMP_ATT + 1;
}
}
TEMP_REC[POSTCODE_FIELD_NO - 1] = ADDRESS[5];
OLD_FIELD_DATA = FIELD_DATA;
for(TEMP_FIELD_NO = ADDRESS_LINE1_FIELD_NO; TEMP_FIELD_NO <= POSTCODE_FIELD_NO; TEMP_FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[TEMP_FIELD_NO];
L0200();
PRINT(AT(ST_COL, ST_ROW) + NRM_VID + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
FIELD_DATA = OLD_FIELD_DATA;
L0200();
ADDRESS_COMPLETE = TRUE;
ANS = TEMP_REC[ADDRESS_LINE1_FIELD_NO - 1];
}
}
if (FIELD_NO != ADDRESS_LINE1_FIELD_NO || NOT(ADDRESS_COMPLETE)) {
PRINT(AT(ST_COL - 2, ST_ROW) + SCREEN_BACK + SCREEN_DATA);
PRINTCR(AT(ST_COL, ST_ROW) + STR(".", ST_LENGTH));
PRINT(AT(ST_COL, ST_ROW));
/*  Smart card may already be positioned in the reader */
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 2) {
L0065();
}
if (NOT(SMARTCARD_READ)) {
if (FIELD_NO == 2) {
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[FL_CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
} else {
MEMBER_PROGRAM = "";
}
if (MEMBER_PROGRAM != "") {
CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref ANS);
} else {
MDISL = ST_LENGTH + 1;
INPUT(out ANS, MDISL);
if (LEN(ANS) > ST_LENGTH) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, ST_LENGTH); }
}
if (ANS == "" && VALUE == "" && FIELD_NO == 2 && SMART_CARD) {
SMARTCARD_READ = FALSE;
if (SMART_CARD && FIELD_NO == 2) {
L0065();
/*  Re-try card read in case it was presented 'late' */
}
}
}
}
}
// END CASE
// BEGIN CASE
// CASE
if (VALIDATION_NECESSARY == FALSE) {
INTERACT = VALID_DATA;
}// CASE
else if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (ANS == GO_BACK && STUDENT_IS_MEMBER && (FIELD_NO == WORK_TEL_FIELD_NO + 1 || FIELD_NO == DOB_FIELD_NO + 1)) {
NULL();
/*  not permitted */
}// CASE
else if (ANS == GO_BACK) {
INTERACT = BACKUP;
}// CASE
else if (ANS == COMMON.CLR && ST_ATT == 0) {
/*  Clear in activity code field - not valid */
NULL();
}// CASE
else if (ANS == COMMON.CLR && ST_MANDATORY == "" && FIELD_NO != 20) {
/*  Clearing the position indicator is handled in the validation code */
VALUE = "";
ANS = "";
INTERACT = VALID_DATA;
/* *     CASE (ANS = "" OR ANS = CLR) AND VALUE = "" AND ST.MANDATORY # "" */
}// CASE
else if (((ANS == "" && VALUE == "") || ANS == COMMON.CLR) && ST_MANDATORY != "") {
if (FIELD_NO == 2) {
nrf0 = 5;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
nrf0 = 6;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
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
case 2: L1050(); break;
case 3: L1100(); break;
case 4: L1200(); break;
case 5: L1300(); break;
case 6: L1400(); break;
case 7: L1500(); break;
case 8: L1600(); break;
case 9: L1700(); break;
case 10: L1800(); break;
case 11: L1900(); break;
case 12: L2000(); break;
case 13: L2100(); break;
case 14: L2110(); break;
case 15: L2120(); break;
case 16: L2130(); break;
case 17: L2140(); break;
case 18: L2170(); break;
case 19: L2180(); break;
case 20: L2190(); break;
case 21: L3100(); break;
case 22: L3100(); break;
case 23: L3100(); break;
case 24: L3100(); break;
case 25: L3100(); break;
case 26: L3100(); break;
case 27: L3100(); break;
case 28: L3200(); break;
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
if (FIELD_NO == ADDRESS_LINE1_FIELD_NO && ADDRESS_COMPLETE && NOT(AMENDING)) {
FIELD_NO = POSTCODE_FIELD_NO;
}
return;
/* ************************************* */
}
void L0065() {
/*   Read smartcard                * */
/* ************************************* */
IFACE_TYPE = 1;
SMART_MEMBER_NO = "";
APACS_NO = "";
SMART_DISPLAY_MODE = FWTERM_MODE;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref SMART_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref SMART_DISPLAY_MODE, ref SMARTCARD_INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
// BEGIN CASE
// CASE
if (SMARTCARD_INTERACT == NOT_PRESENT) {
NULL();
}// CASE
else if (SMARTCARD_INTERACT == INVALID_DATA) {
NULL();
}// CASE
else if (SMART_MEMBER_NO == "NONMEM") {
/*  Use unrecognised APACS numbers as non-member student Ids */
if (APACS_NO != "") {
ANS = APACS_NO;
SMARTCARD_READ = TRUE;
}
}// CASE
else if (OTHERWISE) {
/*  If an APACS number has been returned, now process the lookup */
/*  to convert it to a membership number. If this lookup fails, */
/*  then proceed to display an input prompt in the normal way */
if (APACS_NO != "" && SMART_MEMBER_NO == "") {
if (!READV(ref SMART_MEMBER_NO, FL_APACS_NUMBERS, APACS_NO, 1)) { SMART_MEMBER_NO = ""; }
}
if (SMART_MEMBER_NO != "") {
ANS = SMART_MEMBER_NO;
SMARTCARD_READ = TRUE;
}
}
// END CASE
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
PRINT(AT(79, PRINT_LINE) + NRM_VID);
PRINT(AT(0, PRINT_LINE) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, PRINT_LINE) + SPACE(SCREEN_WIDTH - 2));
}
/*  Display the page 1 window */
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
PRINT(AT(DISP_COL + 7, DISP_ROW) + NRM_VID + FORMAT(ACT_CODE_REC[ACT_CODE_DESCRIPTION], "L#30"));
}// CASE
else if (DISP_CONVERSION != "") {
PRINT(FORMAT(OCONV(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_CONVERSION), DISP_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(FORMAT(TEMP_REC[DISP_ATT][1, DISP_MV], DISP_JUST));
}
// END CASE
}
return;
/* ************************ */
/*   VALIDATION ROUTINES  * */
/* ************************ */
#region INCLUDE FL.PROCESSING FL734.VALIDATION
}
void L1000() {
/*   ACTIVITY Code Validation Routine */

INTERACT = VALID_DATA;
if (ANS == COMMON.HELP) {
nrf0 = "";
FL721 = new FL721(ref ANS, ref INTERACT, ref REDISPLAY, ref nrf0);
L0100();
if (INTERACT == EXIT) {
ANS = "";
INTERACT = INVALID_DATA;
}
}
// BEGIN CASE
// CASE
if (INTERACT == INVALID_DATA) {
/*  Help box abandoned */
NULL();
}// CASE
else if (ANS != "" && INTERACT == VALID_DATA) {
AMENDING = TRUE;
if (ST_CONVERSION != "") {
VALUE = ICONV(ANS, ST_CONVERSION);
} else {
VALUE = ANS;
}
if (VALUE != "") {
MAIN_KEY = VALUE;
if (MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, MAIN_KEY)) {
if (ACT_CODE_REC[ACT_CODE_WAIT_LIST] != "N") {
PRINT(AT(ST_COL + 10, ST_ROW) + NRM_VID + FORMAT(ACT_CODE_REC[ACT_CODE_DESCRIPTION], "L#30"));
/* DJA 24.09.04*  CALL @PROCESS.LOCKED( FL.WAIT.MASTER, MAIN.KEY, STATUS ) */
ZZZ_STATUS = FALSE;
if (ZZZ_STATUS == TRUE) {
nrf0 = 43;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
ANS = "";
MAIN_KEY = "";
VALUE = "";
} else {
/*  DJA 24.09.04. Change READU to READ */
if (MATREAD(ref WAIT_MAST_REC, FL_WAIT_MASTER, MAIN_KEY)) {
if (DISPLAY_MODE == 1) {
NEW_STUDENT = FALSE;
/*  Call window to select existing or new student */
STUDENT_LIST = WAIT_MAST_REC[WAIT_MAST_IDS];
STATUS_LIST = WAIT_MAST_REC[WAIT_MAST_STATUS];
ACTIVITY = MAIN_KEY;
CREATION_ALLOWED = TRUE;
FL735 = new FL735(ref MAIN_KEY, ref STUDENT_LIST, ref STATUS_LIST, ref NEW_STUDENT, ref CREATION_ALLOWED, ref STUDENT_ID, ref INTERACT, ref REDISPLAY);
L0100();
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
ANS = "";
MAIN_KEY = "";
VALUE = "";
ACTIVITY_CODE = "";
MAT(ref TEMP_REC, "");
MAT(ref WAIT_STUDENT_REC, "");
MAT(ref WAIT_MAST_REC, "");
STUDENT_ID = "";
}// CASE
else if (NEW_STUDENT) {
INTERACT = VALID_DATA;
AMENDING = FALSE;
}// CASE
else if (OTHERWISE) {
if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID)) {
TEMP_REC[1] = STUDENT_ID;
L8000();
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
TEMP_REC[18] = TEST_POS;
TEMP_REC[27] = WAIT_MAST_REC[WAIT_MAST_STATUS][1, TEST_POS];
}
/*  Display data */
L0300();
AMENDING = TRUE;
}
}
// END CASE
} else {
/*  Called by enrolment - should be a new entry */
INTERACT = VALID_DATA;
AMENDING = FALSE;
}
} else {
/*  Must be a new student */
INTERACT = VALID_DATA;
AMENDING = FALSE;
}
}
} else {
nrf0 = 55;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
MAIN_KEY = "";
VALUE = "";
}
} else {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
MAIN_KEY = "";
VALUE = "";
}
} else {
nrf0 = 7;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
MAIN_KEY = "";
VALUE = "";
}
}// CASE
else if (OTHERWISE) {
INTERACT = EXIT;
}
// END CASE
return;
}
void L1050() {
/*  Student/Member No validation routine */
if (ANS == COMMON.HELP) {
MATCH_LIST = "";
FL723 = new FL723(ref ANS, ref INTERACT, ref REDISPLAY, ref MATCH_LIST);
PRINT(AT(ST_COL, ST_ROW) + FORMAT(ANS, ST_JUST));
L0100();
START_FIELD = 1;
END_FIELD = 2;
L6000();
}
// BEGIN CASE
// CASE
if (INTERACT == EXIT) {
INTERACT = INVALID_DATA;
ANS = "";
}// CASE
else if (ANS == "N") {
/*  Create a new student number */
if (GET_STUDENT_ID == "") {
INTERACT = INVALID_DATA;
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref NEW_STUDENT_NO);
STUDENT_ID = NEW_STUDENT_NO;
ANS = STUDENT_ID;
INTERACT = VALID_DATA;
NEW_STUDENT = TRUE;
/*  Set default list position and display it */
/*  No way of knowing 'P'riority status at this time */
TEMP_REC[18] = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM) + 1;
TEMP_REC[28] = TODAYS_DATE;
START_FIELD = 19;
END_FIELD = 19;
L6000();
START_FIELD = 21;
END_FIELD = 21;
L6000();
}
}// CASE
else if (ANS == NAME_INDEX_REQUEST || ANS == SOUND_INDEX_REQUEST || ANS == ADDRESS_INDEX_REQUEST) {
SEARCH_ROUTE = ANS;
MEMBER_NUMBER = "";
FL000_20 = new FL000_20(ref MEMBER_NUMBER, ref SEARCH_ROUTE);
if (MEMBER_NUMBER == "") {
INTERACT = INVALID_DATA;
} else {
INTERACT = INVALID_DATA;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER_NUMBER)) {
INTERACT = VALID_DATA;
ANS = MEMBER_NUMBER;
STUDENT_ID = ANS;
STUDENT_IS_MEMBER = TRUE;
/*  DJA 31.07.00 */
L1075();
/*  Turn members details into a student record */
}
}
PRINT(AT(0, 23) + NRM_VID + SPACE(80));
}// CASE
else if (OTHERWISE) {
/*  See if student already exists */
/*  Unrecogised APACS number may have been passed in for use as a */
/*  non-member student identifier */
if (MATCH(PASSED_STUDENT_ID,"16N")) {
ANS = PASSED_STUDENT_ID;
PADDED_ANS = ANS;
} else {
PADDED_ANS = ANS;
if (NOT(MATCH(ANS.Substring(1, 1),"1A"))) {
FL000_40 = new FL000_40(ref PADDED_ANS);
}
}
STUDENT_IS_MEMBER = FALSE;
STUDENT_EXISTS = FALSE;
if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, ANS)) {
STUDENT_EXISTS = TRUE;
} else {
if (MATREADU(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, PADDED_ANS)) {
/*  It is just possible that there is a member on the list with */
/*  a number (when padded) which is the same as the one entered. */
/*  BUT, that the user is actually trying to assign an existing */
/*  course student to the list, with a valid, unpadded id. (Not */
/*  very likely though!) */
if (!(MATREAD(ref STUDENT_REC, FL_STUDENTS, ANS))) {
STUDENT_EXISTS = TRUE;
ANS = PADDED_ANS;
VALUE = ANS;
}
}
}
if (STUDENT_EXISTS) {
STUDENT_ID = ANS;
INTERACT = VALID_DATA;
AMENDING = TRUE;
L8000();
/*  Find position in the list */
if (LOCATE(ANS, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
TEMP_REC[18] = TEST_POS;
TEMP_REC[27] = WAIT_MAST_REC[WAIT_MAST_STATUS][1, TEST_POS];
}
L0300();
} else {
/*  The number entered may be an unpadded membership */
/*  number, but it could also be an existing id */
/*  on FL.STUDENTS. Check for the latter before launching into */
/*  the creation of a new waiting list entry for an */
/*  unrelated member */
/*  DJA 15.2.01 Be sure that student record isn't just a */
/*              skeleton one created for a member */
if (!READV(ref MAND_SURNAME, FL_STUDENTS, ANS, 3)) { MAND_SURNAME = ""; }
if (MAND_SURNAME != "") {
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, ANS)) { MAT(ref STUDENT_REC, ""); /*  Can't happen (READV succeeded) */ }
STUDENT_ID = ANS;
L1085();
INTERACT = VALID_DATA;
} else {
FOUND_ON_MEMBERS = FALSE;
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ANS)) {
FOUND_ON_MEMBERS = TRUE;
} else {
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], PADDED_ANS)) {
FOUND_ON_MEMBERS = TRUE;
ANS = PADDED_ANS;
}
}
if (FOUND_ON_MEMBERS) {
STUDENT_ID = ANS;
MEMBER_NUMBER = ANS;
STUDENT_IS_MEMBER = TRUE;
/*  DJA 31.07.00 */
L1075();
/*  Create a student record from a member record */
INTERACT = VALID_DATA;
} else {
/*  Unrecognised APACS numbers will drop to here. Treat them as */
/*  new, non-member student Ids */
if (MATCH(ANS,"16N")) {
STUDENT_ID = ANS;
INTERACT = VALID_DATA;
NEW_STUDENT = TRUE;
/*  Set default list position and display it */
/*  No way of knowing 'P'riority status at this time */
TEMP_REC[18] = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM) + 1;
TEMP_REC[28] = TODAYS_DATE;
START_FIELD = 19;
END_FIELD = 19;
L6000();
START_FIELD = 21;
END_FIELD = 21;
L6000();
} else {
nrf0 = 11;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
}
}
}
}
// END CASE
return;
/* ******************************************************* */
}
void L1075() {
/*   CREATE A STUDENT RECORD FROM A MEMBERS ONE      * */
/* ******************************************************* */
TEMP_REC[1] = MEMBER_NUMBER;
TEMP_REC[2] = MEMBERS_REC[MEMBER_TITLES][1, 1];
if (MEMBERS_REC[MEMBER_FORENAMES][1, 1] != "") {
TEMP_REC[3] = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
} else {
TEMP_REC[3] = MEMBERS_REC[MEMBER_INITIALS][1, 1];
}
TEMP_REC[4] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
TEMP_REC[5] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
TEMP_REC[6] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
TEMP_REC[7] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
TEMP_REC[8] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
TEMP_REC[9] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
TEMP_REC[10] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
TEMP_REC[11] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
TEMP_REC[14] = MEMBERS_REC[MEMBER_DOBS][1, 1];
TEMP_REC[15] = COMMON.CENTRE;
TEMP_REC[18] = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM) + 1;
TEMP_REC[28] = TODAYS_DATE;
START_FIELD = 2;
END_FIELD = 21;
L6000();
AMENDING = PARTIAL;
return;
/* ************************************************** */
}
void L1085() {
/*   Create a waiting list student from a course* */
/*       student record                             * */
/* ************************************************** */
TEMP_REC[1] = STUDENT_ID;
TEMP_REC[2] = STUDENT_REC[STUDENT_TITLE];
TEMP_REC[3] = STUDENT_REC[STUDENT_FORENAME];
TEMP_REC[4] = STUDENT_REC[STUDENT_SURNAME];
TEMP_REC[5] = STUDENT_REC[STUDENT_ADDRESS1];
TEMP_REC[6] = STUDENT_REC[STUDENT_ADDRESS2];
TEMP_REC[7] = STUDENT_REC[STUDENT_ADDRESS3];
TEMP_REC[8] = STUDENT_REC[STUDENT_ADDRESS4];
TEMP_REC[9] = STUDENT_REC[STUDENT_POST_CODE];
TEMP_REC[10] = STUDENT_REC[STUDENT_HOME_TEL];
TEMP_REC[11] = STUDENT_REC[STUDENT_WORK_TEL];
TEMP_REC[13] = STUDENT_REC[STUDENT_MEDICAL1];
TEMP_REC[14] = STUDENT_REC[STUDENT_DOB];
TEMP_REC[15] = COMMON.CENTRE;
TEMP_REC[18] = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM) + 1;
/*  Can't assume that a priority student should have the same status */
/*  on this course as on another */
TEMP_REC[28] = TODAYS_DATE;
START_FIELD = 2;
END_FIELD = 21;
L6000();
AMENDING = PARTIAL;
return;
}
void L1100() {
/*  TITLE  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1200() {
/*  FORENAME  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1300() {
/*  SURNAME  Validation Routine */
INTERACT = VALID_DATA;
/*  DJA 25.4.02 Look for existing students with forename/surname match. */
/*              Introduced to limit the creation of duplicate student */
/*              entries. */
if (CHECK_FOR_DUPLICATES == "Y" && NEW_STUDENT) {
INSTRUCTION = "SSELECT FL.STUDENTS WITH 3 = \"" + ANS + "\" AND WITH 2 = \"" + TEMP_REC[3] + "\"";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
MATCH_LIST = "";
if (LIST_AVAILABLE) {
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
MATCH_LIST[1, -1] = ID;
} while (true);
nrf0 = 50;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
FL723 = new FL723(ref RETURNED_ANS, ref INTERACT, ref REDISPLAY, ref MATCH_LIST);
if (INTERACT == VALID_DATA) {
/*  Existing student was selected */
STUDENT_ID = RETURNED_ANS;
if (!MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_ID)) { MAT(ref STUDENT_REC, ""); }
/* !*           GOSUB 8000 ; * Build TEMP.REC */
L1085();
ANS = STUDENT_REC[STUDENT_SURNAME];
/* !*           IF ENROLMENT.CALL THEN */
/* !*              VALUE = ANS */
/* !*              INTERACT = FINISH */
/* !*           END ELSE */
INTERACT = VALID_DATA;
AMENDING = TRUE;
L0100();
L0300();
/* !*           END */
} else {
/*  Continue with creation of new student */
INTERACT = VALID_DATA;
L0100();
L0300();
}
}
}
return;
}
void L1400() {
/*  ADDRESS1  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1500() {
/*  ADDRESS2  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1600() {
/*   ADDRESS 3  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1700() {
/*   ADDRESS4  Validation Routine */
if (MATREAD(ref TOWNS_REC, COMMON.FILES[FL_TOWNS], ANS)) {
ANS = TOWNS_REC[TOWN_DESC];
}
INTERACT = VALID_DATA;
return;
}
void L1800() {
/*   POST CODE  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L1900() {
/*   TEL (HOME)  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2000() {
/*  TEL (WORK)  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2100() {
/*  COMMENT  Validation Routine */
INTERACT = VALID_DATA;
return;
}
void L2110() {
/*  MEDICAL COMMENT 1 */
INTERACT = VALID_DATA;
return;
}
void L2120() {
/*  DATE OF BIRTH */
CONV_ANS = ICONV(ANS, "D");
if (ANS != "" && CONV_ANS == "") {
INTERACT = INVALID_DATA;
nrf0 = 15;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
}
void L2130() {
/*  CENTRE 1 */
if (ANS == COMMON.HELP) {
FL722 = new FL722(ref ANS, ref INTERACT, ref REDISPLAY);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (ANS == COMMON.CENTRE) {
INTERACT = VALID_DATA;
} else {
if (MATREAD(ref MASTER_CENTRE_REC, FL_MASTER_CENTRES, ANS)) {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 19;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
}
void L2140() {
/*  CENTRE 2 */
if (ANS == COMMON.HELP) {
FL722 = new FL722(ref ANS, ref INTERACT, ref REDISPLAY);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
if (ANS == COMMON.CENTRE) {
INTERACT = VALID_DATA;
} else {
if (MATREAD(ref MASTER_CENTRE_REC, FL_MASTER_CENTRES, ANS)) {
INTERACT = VALID_DATA;
} else {
INTERACT = INVALID_DATA;
nrf0 = 19;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
}
void L2170() {
/*  Position on this waiting list */
if (ANS != "0" && (ANS == "" || MATCH(ANS,"1N") || MATCH(ANS,"2N") || MATCH(ANS,"3N"))) {
// BEGIN CASE
// CASE
if (TEMP_REC[27] == "P" && ANS > 1) {
if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, ANS] != "P") {
nrf0 = 41;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
}// CASE
else if (TEMP_REC[27] != "P" && WAIT_MAST_REC[WAIT_MAST_STATUS][1, ANS] == "P") {
nrf0 = 42;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
INTERACT = VALID_DATA;
}
// END CASE
} else {
nrf0 = 17;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
}
void L2180() {
/*  Status ('P' for Priority or null) */
if (ANS == COMMON.CLR) {
ANS = "";
}
if (ANS == "P" || ANS == "") {
INTERACT = VALID_DATA;
if (ANS != VALUE) {
/*  Position on list may have changed */
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref CURRENT_POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_IDS] = DELETE(WAIT_MAST_REC[WAIT_MAST_IDS], 1, CURRENT_POS, 0);
WAIT_MAST_REC[WAIT_MAST_STATUS] = DELETE(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, CURRENT_POS, 0);
}
if (VALUE == "P") {
/*  Used to be a priority case */
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
WAIT_MAST_REC[WAIT_MAST_IDS][1, -1] = STUDENT_ID;
WAIT_MAST_REC[WAIT_MAST_STATUS][1, NO_MVS + 1] = ANS;
TEMP_REC[18] = NO_MVS + 1;
} else {
/*  Used to be a non-priority case */
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
PRIORITY_POS = 1;
do {
if (WAIT_MAST_REC[WAIT_MAST_STATUS][1, PRIORITY_POS] != "P" || PRIORITY_POS > NO_MVS) break;
PRIORITY_POS = PRIORITY_POS + 1;
} while (true);
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, PRIORITY_POS, 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, PRIORITY_POS, 0, STUDENT_ID);
TEMP_REC[18] = PRIORITY_POS;
}
/*  Redisplay list position as it may have changed */
START_FIELD = 19;
END_FIELD = 19;
L6000();
if (NO_MVS > 0) { nrf0 = 40;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1); }
}
} else {
nrf0 = 30;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
}
void L2190() {
/*  Date Joined Waiting List */
CONV_ANS = ICONV(ANS, "D");
if (ANS != "" && CONV_ANS == "") {
INTERACT = INVALID_DATA;
nrf0 = 31;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = VALID_DATA;
}
return;
}
void L3100() {
/*  Availability  Validation Routine */
if (ANS == COMMON.HELP) {
FL724 = new FL724(ref ANS, ref VALID_AVAILABILITY, ref AVAILABLE_CODE_DESCRIPTION_LIST, ref INTERACT, ref REDISPLAY);
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
L0100();
L0300();
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
}
INTERACT = VALID_DATA;
if (!(LOCATE(ANS, VALID_AVAILABILITY, 0, 0, 1, ref POS, "AL"))) {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = INVALID_DATA;
}
return;
}
void L3200() {
/*  Concession */
INTERACT = VALID_DATA;
return;

#endregion
/* ***************************************** */
}
void L6000() {
/*   Display data for selected fields  * */
/* ***************************************** */
OLD_FIELD_NO = FIELD_NO;
OLD_FIELD_DATA = FIELD_DATA;
for(FIELD_NO = START_FIELD; FIELD_NO <= END_FIELD; FIELD_NO += 1) {
FIELD_DATA = DATA_FIELDS[FIELD_NO];
L0200();
// BEGIN CASE
// CASE
if (ST_ATT == 0) {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(MAIN_KEY, ST_JUST));
PRINT(AT(ST_COL + 7, ST_ROW) + FORMAT(ACT_CODE_REC[ACT_CODE_DESCRIPTION], "L#24"));
}// CASE
else if (ST_CONVERSION != "") {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(OCONV(TEMP_REC[ST_ATT], ST_CONVERSION), ST_JUST));
}// CASE
else if (OTHERWISE) {
PRINT(SCREEN_BACK + SCREEN_DATA + AT(ST_COL, ST_ROW) + FORMAT(TEMP_REC[ST_ATT], ST_JUST));
}
// END CASE
}
FIELD_NO = OLD_FIELD_NO;
FIELD_DATA = OLD_FIELD_DATA;
L0200();
return;
/* ******************************** */
}
void L8000() {
/*   Build temp.rec           * */
/* ******************************** */
/*  TEMP.REC(1) will contain the student/member no */
if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], STUDENT_ID)) {
STUDENT_IS_MEMBER = TRUE;
TEMP_REC[2] = MEMBERS_REC[MEMBER_TITLES][1, 1];
TEMP_REC[3] = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
TEMP_REC[4] = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
TEMP_REC[5] = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
TEMP_REC[6] = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
TEMP_REC[7] = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
TEMP_REC[8] = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
TEMP_REC[9] = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
TEMP_REC[10] = MEMBERS_REC[MEMBER_HOME_PHONE][1, 1];
TEMP_REC[11] = MEMBERS_REC[MEMBER_BUS_PHONE][1, 1];
TEMP_REC[14] = MEMBERS_REC[MEMBER_DOBS][1, 1];
} else {
TEMP_REC[2] = WAIT_STUDENT_REC[WAIT_STUD_TITLE];
TEMP_REC[3] = WAIT_STUDENT_REC[WAIT_STUD_FORENAME];
TEMP_REC[4] = WAIT_STUDENT_REC[WAIT_STUD_SURNAME];
TEMP_REC[5] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1];
TEMP_REC[6] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2];
TEMP_REC[7] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3];
TEMP_REC[8] = WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4];
TEMP_REC[9] = WAIT_STUDENT_REC[WAIT_STUD_POST_CODE];
TEMP_REC[10] = WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME];
TEMP_REC[11] = WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK];
TEMP_REC[14] = WAIT_STUDENT_REC[WAIT_STUD_DOB];
}
TEMP_REC[12] = WAIT_STUDENT_REC[WAIT_STUD_COMMENT];
TEMP_REC[13] = WAIT_STUDENT_REC[WAIT_STUD_MEDICAL];
TEMP_REC[15] = WAIT_STUDENT_REC[WAIT_STUD_CENTRE];
TEMP_REC[16] = WAIT_STUDENT_REC[WAIT_STUD_CENTRE2];
TEMP_REC[17] = WAIT_STUDENT_REC[WAIT_STUD_COURSE];
TEMP_REC[18] = "";
/*  List position */
TEMP_REC[19] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_MONDAY];
TEMP_REC[20] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_TUESDAY];
TEMP_REC[21] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_WEDNESDAY];
TEMP_REC[22] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_THURSDAY];
TEMP_REC[23] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_FRIDAY];
TEMP_REC[24] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SATURDAY];
TEMP_REC[25] = WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SUNDAY];
TEMP_REC[26] = WAIT_STUDENT_REC[WAIT_STUD_CONCESSION];
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
TEMP_REC[27] = WAIT_MAST_REC[WAIT_MAST_STATUS][1, TEST_POS];
} else {
TEMP_REC[27] = "";
}
if (LOCATE(MAIN_KEY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref TEST_POS, "AL")) {
TEMP_REC[28] = WAIT_STUDENT_REC[WAIT_STUD_DATES][1, TEST_POS];
/*  Date joined */
} else {
TEMP_REC[28] = "";
}
return;
/* ******************************************* */
}
void L9000() {
/*   Transfer data out of temp.rec       * */
/* ******************************************* */
if (NOT(STUDENT_IS_MEMBER)) {
WAIT_STUDENT_REC[WAIT_STUD_TITLE] = TEMP_REC[2];
WAIT_STUDENT_REC[WAIT_STUD_FORENAME] = TEMP_REC[3];
WAIT_STUDENT_REC[WAIT_STUD_SURNAME] = TEMP_REC[4];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] = TEMP_REC[5];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] = TEMP_REC[6];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] = TEMP_REC[7];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] = TEMP_REC[8];
WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] = TEMP_REC[9];
WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME] = TEMP_REC[10];
WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK] = TEMP_REC[11];
WAIT_STUDENT_REC[WAIT_STUD_DOB] = TEMP_REC[14];
}
WAIT_STUDENT_REC[WAIT_STUD_COMMENT] = TEMP_REC[12];
WAIT_STUDENT_REC[WAIT_STUD_MEDICAL] = TEMP_REC[13];
WAIT_STUDENT_REC[WAIT_STUD_CENTRE] = TEMP_REC[15];
WAIT_STUDENT_REC[WAIT_STUD_CENTRE2] = TEMP_REC[16];
/* !!  WAIT.STUD.COURSE      = TEMP.REC(17) */
/*     List position = TEMP.REC(18) */
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_MONDAY] = TEMP_REC[19];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_TUESDAY] = TEMP_REC[20];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_WEDNESDAY] = TEMP_REC[21];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_THURSDAY] = TEMP_REC[22];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_FRIDAY] = TEMP_REC[23];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SATURDAY] = TEMP_REC[24];
WAIT_STUDENT_REC[WAIT_STUD_AVAILABLE_SUNDAY] = TEMP_REC[25];
WAIT_STUDENT_REC[WAIT_STUD_CONCESSION] = TEMP_REC[26];
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref TEST_POS, "AL")) {
WAIT_MAST_REC[WAIT_MAST_STATUS][1, TEST_POS] = TEMP_REC[27];
} else {
/*  Let the filing routines deal with the insertion for a new entry */
NULL();
}
if (LOCATE(MAIN_KEY, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref TEST_POS, "AL")) {
if (TEMP_REC[28] != "") {
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, TEST_POS] = TEMP_REC[28];
} else {
/*  Can't clear - its mandatory information */
NULL();
}
} else {
/*  Leave filing routines to handle new entries */
NULL();
}
return;
/* ****************** */
/*   END OF PROGRAM * */
/* ****************** */
}
}
}
