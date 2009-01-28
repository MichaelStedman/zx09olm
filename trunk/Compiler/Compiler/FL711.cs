//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL711 : UvBase
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
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_STUDENTS = "";
UvVar SMART_CARD = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_STUDENT = "";
UvVar PAGE_NO = "";
FL710 FL710;
FL781 FL781;
FL006 FL006;
UvVar STUDENT_CODE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL711() {
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
/*     CONTROLLING ROUTINE FOR STUDENT MAINTENANCE */
PROMPT("");
PROGRAM = "FL711";
SCREEN_CODE = PROGRAM;
INTERACT = "";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

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
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
OLD_PAGE_NO = 1;
NEW_STUDENT = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref STUDENT_REC, "");
PROG_MESS = 1;
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
FL710 = new FL710(ref STUDENT_REC, ref NEW_STUDENT);
}// CASE
else if (PAGE_NO == 2) {
FL781 = new FL781(ref STUDENT_REC, ref NEW_STUDENT);
}// CASE
else if (OTHERWISE) {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
PROG_MESS[1] = OLD_PAGE_NO;
}
// END CASE
OLD_PAGE_NO = PAGE_NO;
} while (true);
if (PROG_MESS[1] == "" && PROG_MESS[2] != "") {
/*  Apply File Updates */
STUDENT_CODE = PROG_MESS[2];
MATWRITE(STUDENT_REC, FL_STUDENTS, STUDENT_CODE);
}
RELEASE();
/*  Abandon whole option if smart card site, otherwise user */
/*  is stuck in the screen until the card is removed from */
/*  the reader */
if (SMART_CARD && PROG_MESS[2] != "2") {
PROG_MESS[1] = COMMON.ABANDON;
PROG_MESS[2] = "";
}
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
