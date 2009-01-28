//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL813 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar DEBIT = 1;
readonly UvVar CREDIT = 2;
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
readonly UvVar CAL_TEXT = 1;
readonly UvVar CAL_TYPE = 2;
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
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] COURSE_DET_REC = new UvVar[25];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
UvVar[] CALENDAR_REC = new UvVar[10];
UvVar[] ENROL_REC = new UvVar[30];
UvVar[] COPY_ENROL_REC = new UvVar[30];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
#endregion
#region Variables
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar TILL_NUMBER = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_DETAILS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FL_MULTIPAY = "";
UvVar FL_COURSE_CALENDAR = "";
UvVar FL_ENROLMENT = "";
UvVar FL_COURSE_PARAMS = "";
UvVar MULTIPAY_REC = "";
UvVar BASKET_COUNT = "";
FL006 FL006;
UvVar RUN_PARAMS = "";
UvVar COURSE_PARAMS = "";
UvVar FEE_TODAY = "";
UvVar COURSE_START_DATE = "";
UvVar COURSE_CODE = "";
UvVar ADJUSTMENT_WEEKS = "";
UvVar ADJUSTMENT_AMOUNT = "";
UvVar ADJUSTMENT_REASON = "";
UvVar EXCEPTION_DATES = "";
UvVar TOTAL_SESSIONS = "";
UvVar DET_ID = "";
UvVar EX_DATE = "";
FL873 FL873;
UvVar DATE_QUALIFIES = "";
UvVar CALENDAR_ID = "";
UvVar CAL_REC = "";
UvVar STUDENT_LIST = "";
UvVar NO_STUDENTS = "";
UvVar STUDENT_MVC = "";
UvVar STUDENT_NO = "";
UvVar NO_TRANS = "";
UvVar MVC = "";
UvVar ENROL_ID = "";
UvVar ORIGINAL_CONCESSION = "";
UvVar CONTROL_TICKET_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar SALE_DATE = "";
UvVar PNTR = "";
UvVar FEE_DATE = "";
UvVar CENTRE_TICKET_CODE = "";
UvVar CONC_POS = "";
UvVar ORIGINAL_FEE = "";
UvVar ROUNDING_BIT = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL813() {
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
/*     Batch adjustments */
PROGRAM = "FL813";
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
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.CALENDAR
if (!OPEN("FL.COURSE.CALENDAR", out FL_COURSE_CALENDAR)) { STOP("201", "FL.COURSE.CALENDAR"); }

/*  Id = Internal date. If CAL.TYPE contains 'C' this is a restricted day. */

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
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
if (!READ(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) { MULTIPAY_REC = ""; }
BASKET_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
if (BASKET_COUNT > 0) {
nrf0 = 85;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (!READ(ref RUN_PARAMS, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { RUN_PARAMS = ""; }
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
FEE_TODAY = COURSE_PARAMS[49, 1];
if (FEE_TODAY == "") { FEE_TODAY = "N"; }
COURSE_START_DATE = RUN_PARAMS[6];
COURSE_CODE = OCONV(RUN_PARAMS[5], "MCU");
ADJUSTMENT_WEEKS = RUN_PARAMS[9];
ADJUSTMENT_AMOUNT = RUN_PARAMS[7];
ADJUSTMENT_REASON = RUN_PARAMS[8];
if (ADJUSTMENT_WEEKS != "" && ADJUSTMENT_AMOUNT != "") {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (ADJUSTMENT_WEEKS == "" && ADJUSTMENT_AMOUNT == "") {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
EXCEPTION_DATES = "";
TOTAL_SESSIONS = 0;
DET_ID = COURSE_START_DATE + "*" + COURSE_CODE;
if (ADJUSTMENT_WEEKS != "") {
if (!READV(ref COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS], FL_COURSE_MASTER, COURSE_CODE, 14)) { COURSE_MSTR_REC[COURSE_MSTR_EXCEPTIONS] = ""; }
if (!MATREAD(ref COURSE_DET_REC, FL_COURSE_DETAILS, DET_ID)) { MAT(ref COURSE_DET_REC, ""); }
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
if (TOTAL_SESSIONS <= 0) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}
/* ******************************************** */
/*  Strictly validate the supplied parameters * */
/* ******************************************** */
if (READV(ref STUDENT_LIST, FL_COURSE_DETAILS, DET_ID, 21)) {
if ((MATCH(ADJUSTMENT_AMOUNT,"0N") || MATCH(ADJUSTMENT_AMOUNT,"\"-\"0N")) || (MATCH(ADJUSTMENT_WEEKS,"0N") || MATCH(ADJUSTMENT_WEEKS,"\"-\"0N"))) {
L0100();
} else {
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/* ****************************************** */
/*   Return to calling program              * */
/* ****************************************** */
return;
/* ****************************************** */
}
void L0100() {
/*  Main processing section             * */
/* ****************************************** */
NO_STUDENTS = DCOUNT(STUDENT_LIST, VM);
for(STUDENT_MVC = 1; STUDENT_MVC <= NO_STUDENTS; STUDENT_MVC += 1) {
STUDENT_NO = STUDENT_LIST[1, STUDENT_MVC];
if (MATREADU(ref STUDENT_REC, FL_STUDENTS, STUDENT_NO)) {
NO_TRANS = DCOUNT(STUDENT_REC[STUDENT_TRANS_DATES], VM);
MVC = NO_TRANS + 1;
STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, MVC] = DET_ID;
STUDENT_REC[STUDENT_TRANS_DATES][1, MVC] = TODAYS_DATE;
STUDENT_REC[STUDENT_TRANS_TYPES][1, MVC] = "A";
if (ADJUSTMENT_WEEKS != "") {
/*  Deduce the charge for 'n' weeks */
ENROL_ID = DET_ID + "*" + STUDENT_NO;
if (!READV(ref ORIGINAL_CONCESSION, FL_ENROLMENT, ENROL_ID, 1)) { ORIGINAL_CONCESSION = 0; }
CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*C*" + COURSE_DET_REC[COURSE_DET_FEE_CODE];
if (READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE)) {
if (FEE_TODAY == "Y") {
SALE_DATE = TODAYS_DATE;
} else {
SALE_DATE = COURSE_START_DATE;
}
if (LOCATE(SALE_DATE, CONTROL_FEE_REC, 0, 0, 1, ref PNTR, "AR")) {
FEE_DATE = SALE_DATE;
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
if (LOCATE(ORIGINAL_CONCESSION, TICK_FEES_REC[TICK_FEES_CONCESSIONS], 1, 0, 1, ref CONC_POS, "AL")) {
ORIGINAL_FEE = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, CONC_POS];
} else {
/*  This is unreliable if the site uses pro-rata fees */
if (!READV(ref ORIGINAL_FEE, FL_ENROLMENT, ENROL_ID, 2)) { ORIGINAL_FEE = 0; }
}
/* !*CRT "ORIGINAL.CONCESSION=":ORIGINAL.CONCESSION:"  ADJUSTMENT.WEEKS=":ADJUSTMENT.WEEKS:"  TOTAL.SESSIONS=":TOTAL.SESSIONS:"  ORIGINAL.FEE=":ORIGINAL.FEE:" ENROL.ID=":ENROL.ID:;INPUT FLEX,2: */
if (ADJUSTMENT_WEEKS > 0) {
ROUNDING_BIT = 0.5M;
} else {
ROUNDING_BIT = -0.5M;
}
ADJUSTMENT_AMOUNT = INT((ADJUSTMENT_WEEKS * (ORIGINAL_FEE / TOTAL_SESSIONS)) + ROUNDING_BIT);
}
STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, MVC] = ADJUSTMENT_AMOUNT;
STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, MVC] = TRUE;
STUDENT_REC[STUDENT_TRANS_MOPS][1, MVC] = "";
STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, MVC] = ADJUSTMENT_REASON;
STUDENT_REC[STUDENT_TRANS_USER][1, MVC] = U_INITS;
STUDENT_REC[STUDENT_BALANCE] = STUDENT_REC[STUDENT_BALANCE] + ADJUSTMENT_AMOUNT;
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_NO);
}
}
nrf0 = 3;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref NO_STUDENTS);
/*  Delete run parameters after a successful run to reduce the */
/*  risk of the update being run again */
/* ** DOESN'T WORK - FL040 WRITES THEM AFTER FL813 COMPLETES *** */
/* !*  DELETE FL.CONTROL, PROGRAM:".RUN.PARAMS" */
/* !*  DELETE FL.CONTROL, PROGRAM:"#1.RUN.PARAMS" */
return;
/* ****************************************** */
/*   End of program                         * */
/* ****************************************** */
}
}
}
