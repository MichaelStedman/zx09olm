//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL709 : UvBase
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
UvVar[] INSTRUCTOR_REC = new UvVar[30];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_INSTRUCTORS = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_INSTRUCTOR = "";
UvVar PAGE_NO = "";
FL708 FL708;
FL006 FL006;
UvVar INSTRUCTOR_CODE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL709() {
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
/*     CONTROLLING ROUTINE FOR INSTRUCTOR MAINTENANCE */
PROMPT("");
PROGRAM = "FL709";
SCREEN_CODE = PROGRAM;
INTERACT = "";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.INSTRUCTORS
if (!OPEN("FL.INSTRUCTORS", out FL_INSTRUCTORS)) { STOP("201", "FL.INSTRUCTORS"); }

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
NEW_INSTRUCTOR = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref INSTRUCTOR_REC, "");
PROG_MESS = 1;
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
FL708 = new FL708(ref INSTRUCTOR_REC, ref NEW_INSTRUCTOR);
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
INSTRUCTOR_CODE = PROG_MESS[2];
MATWRITE(INSTRUCTOR_REC, FL_INSTRUCTORS, INSTRUCTOR_CODE);
}
RELEASE();
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
