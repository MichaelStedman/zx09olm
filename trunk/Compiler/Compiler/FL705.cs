//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL705 : UvBase
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
readonly UvVar SCHED_START = 1;
readonly UvVar SCHED_END = 2;
readonly UvVar SCHED_BOOKING_DATES = 3;
readonly UvVar SCHED_CLOSE_DATE = 4;
readonly UvVar SCHED_COURSE_CODES = 5;
readonly UvVar SCHED_BLOCK_REFS = 6;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] SCHEDULE_REC = new UvVar[15];
UvVar[] TEMP_REC = new UvVar[50];
#endregion
#region Variables
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_SCHEDULES = "";
UvVar OLD_PAGE_NO = "";
UvVar NEW_SCHEDULE = "";
UvVar PAGE_NO = "";
FL706 FL706;
FL006 FL006;
UvVar SCHEDULE_CODE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL705() {
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
/*     CONTROLLING ROUTINE FOR SCHEDULE MAINTENANCE */
PROMPT("");
PROGRAM = "FL705";
SCREEN_CODE = PROGRAM;
INTERACT = "";
/* ******************************** */
/*   DEFINE FILES USED            * */
/* ******************************** */
#region INCLUDE FL.FILES FL.SCHEDULES

if (!OPEN("FL.SCHEDULES", out FL_SCHEDULES)) { STOP("201", "FL.SCHEDULES"); }

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
NEW_SCHEDULE = FALSE;
do {
MAT(ref TEMP_REC, "");
MAT(ref SCHEDULE_REC, "");
PROG_MESS = 1;
do {
if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
PAGE_NO = PROG_MESS[1];
// BEGIN CASE
// CASE
if (PAGE_NO == 1) {
FL706 = new FL706(ref SCHEDULE_REC, ref NEW_SCHEDULE);
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
SCHEDULE_CODE = PROG_MESS[2];
MATWRITE(SCHEDULE_REC, FL_SCHEDULES, SCHEDULE_CODE);
}
RELEASE();
if (!(PROG_MESS[2] != "")) break;
} while (true);
return;
}
}
}
