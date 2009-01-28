//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL739 : UvBase
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
readonly UvVar FL_COURSE_WAITING = 119;
readonly UvVar COURSE_WAIT_DETAILS = 1;
readonly UvVar COURSE_WAIT_ADDRESS = 2;
readonly UvVar COURSE_WAIT_PHONE = 3;
readonly UvVar COURSE_WAIT_DATE_BOOKED = 4;
readonly UvVar COURSE_WAIT_RECEIPT = 5;
readonly UvVar COURSE_WAIT_CLERK = 6;
readonly UvVar COURSE_WAIT_PRICE = 7;
readonly UvVar ACT_CODE_DESCRIPTION = 1;
readonly UvVar ACT_CODE_WEB_LEVEL = 2;
readonly UvVar ACT_CODE_WAIT_LIST = 3;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] WAIT_MAST_REC = new UvVar[5];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] COURSE_WAIT_REC = new UvVar[10];
UvVar[] ACT_CODE_REC = new UvVar[5];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_CONVERT_TEMP = "";
UvVar FL_WAIT_MASTER = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_ACTIVITY_CODES = "";
UvVar FL_COURSE_PARAMS = "";
UvVar COURSE_PARAMS = "";
UvVar GET_STUDENT_ID = "";
UvVar PROCESS_EXECUTE = "";
UvVar ACTIVITY_CODE = "";
FL006 FL006;
UvVar OLD_COURSE_LIST = "";
UvVar ATT = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar ID = "";
UvVar TEMP_REC = "";
UvVar STUDENT_ID = "";
UvVar NEW_STUDENT_NO = "";
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
UvVar POS = "";
UvVar CONV_DATE = "";
UvVar MVC = "";
UvVar DATE_INSERTED = "";
UvVar TEMP_ID = "";
UvVar TEMP_STUDENT_REC = "";
UvVar TEMP_DATE = "";
UvVar NO_MVS = "";
UvVar NO_CODES = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL739() {
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
/*     Convert Old Waiting Lists to new format */
PROGRAM = "FL739";
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.CONVERT.TEMP
if (!OPEN("FL.CONVERT.TEMP", out FL_CONVERT_TEMP)) { STOP("201", "FL.CONVERT.TEMP"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.MASTER
if (!OPEN("FL.WAIT.MASTER", out FL_WAIT_MASTER)) { STOP("201", "FL.WAIT.MASTER"); }

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.COURSE.WAITING

#endregion
#region INCLUDE FL.FILES FL.ACTIVITY.CODES
if (!OPEN("FL.ACTIVITY.CODES", out FL_ACTIVITY_CODES)) { STOP("201", "FL.ACTIVITY.CODES"); }

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[1, 1];
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
PRINT(AT(10, 20) + "Clearing temporary file...." + COMMON.EOL);
CLEARFILE(FL_CONVERT_TEMP);
PRINT("Done");
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
ACTIVITY_CODE = CONTROLS_REC[20];
if (!(MATREAD(ref WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE))) {
if (MATREAD(ref ACT_CODE_REC, FL_ACTIVITY_CODES, ACTIVITY_CODE)) {
MAT(ref WAIT_MAST_REC, "");
} else {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ACTIVITY_CODE);
return;
}
}
OLD_COURSE_LIST = "";
for(ATT = 5; ATT <= 19; ATT += 1) {
if (CONTROLS_REC[ATT] != "") {
OLD_COURSE_LIST = OLD_COURSE_LIST + " = \"" + CONTROLS_REC[ATT] + "]\"";
}
}
PRINT(AT(10, 20) + "Selecting old course details..." + COMMON.EOL);
INSTRUCTION = "SSELECT FL.COURSE.WAITING" + OLD_COURSE_LIST;
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
PRINT("Writing to temporary file..." + COMMON.EOL);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (MATREAD(ref COURSE_WAIT_REC, COMMON.FILES[FL_COURSE_WAITING], ID)) {
TEMP_REC = "";
TEMP_REC[1] = COURSE_WAIT_REC[COURSE_WAIT_DETAILS][1, 4];
TEMP_REC[2] = COURSE_WAIT_REC[COURSE_WAIT_DETAILS][1, 2];
TEMP_REC[3] = COURSE_WAIT_REC[COURSE_WAIT_DETAILS][1, 1];
TEMP_REC[4] = COURSE_WAIT_REC[COURSE_WAIT_ADDRESS][1, 1];
TEMP_REC[5] = COURSE_WAIT_REC[COURSE_WAIT_ADDRESS][1, 2];
TEMP_REC[6] = COURSE_WAIT_REC[COURSE_WAIT_ADDRESS][1, 3];
TEMP_REC[7] = COURSE_WAIT_REC[COURSE_WAIT_ADDRESS][1, 4];
TEMP_REC[8] = COURSE_WAIT_REC[COURSE_WAIT_ADDRESS][1, 5];
TEMP_REC[9] = COURSE_WAIT_REC[COURSE_WAIT_PHONE][1, 1];
TEMP_REC[10] = COURSE_WAIT_REC[COURSE_WAIT_PHONE][1, 2];
TEMP_REC[11] = COURSE_WAIT_REC[COURSE_WAIT_DATE_BOOKED];
TEMP_REC[12] = COURSE_WAIT_REC[COURSE_WAIT_DETAILS][1, 3];
WRITE(TEMP_REC, FL_CONVERT_TEMP, ID);
} else {
nrf0 = 2;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ID);
return;
}
} while (true);
PRINT(AT(10, 20) + "Selecting temporary file..." + COMMON.EOL);
INSTRUCTION = "SSELECT FL.CONVERT.TEMP BY 11";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
PRINT(AT(10, 20) + "Writing to new waiting list..." + COMMON.EOL);
EOF = FALSE;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (READ(ref TEMP_REC, FL_CONVERT_TEMP, ID)) {
STUDENT_ID = TRIM(TEMP_REC[12]);
if (STUDENT_ID == "") {
/*  Generate a new, numeric Id */
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref NEW_STUDENT_NO);
STUDENT_ID = NEW_STUDENT_NO;
}
if (LOCATE(STUDENT_ID, WAIT_MAST_REC[WAIT_MAST_IDS], 1, 0, 1, ref POS, "AL")) {
/*  Already enrolled */
NULL();
} else {
CONV_DATE = TEMP_REC[11];
if (CONV_DATE == "") {
/* **          WAIT.MAST.IDS<1,-1> = STUDENT.ID */
CONV_DATE = TODAYS_DATE;
/* **        END ELSE */
}
MVC = 1;
DATE_INSERTED = FALSE;
do {
TEMP_ID = WAIT_MAST_REC[WAIT_MAST_IDS][1, MVC];
if (TEMP_ID == "" || DATE_INSERTED) break;
if (!READ(ref TEMP_STUDENT_REC, FL_WAIT_STUDENTS, TEMP_ID)) { TEMP_STUDENT_REC = ""; }
if (LOCATE(ACTIVITY_CODE, TEMP_STUDENT_REC, 19, 0, 1, ref POS, "AL")) {
TEMP_DATE = TEMP_STUDENT_REC[21, POS];
} else {
TEMP_DATE = "";
}
if ((TEMP_DATE != "" && TEMP_DATE > CONV_DATE) || (TEMP_DATE == "" && CONV_DATE != "")) {
DATE_INSERTED = TRUE;
WAIT_MAST_REC[WAIT_MAST_IDS] = INSERT(WAIT_MAST_REC[WAIT_MAST_IDS], 1, MVC, 0, STUDENT_ID);
WAIT_MAST_REC[WAIT_MAST_STATUS] = INSERT(WAIT_MAST_REC[WAIT_MAST_STATUS], 1, MVC, 0, "");
}
MVC = MVC + 1;
} while (true);
if (NOT(DATE_INSERTED)) {
/*  Must have an old date */
WAIT_MAST_REC[WAIT_MAST_IDS][1, -1] = STUDENT_ID;
NO_MVS = DCOUNT(WAIT_MAST_REC[WAIT_MAST_IDS], VM);
WAIT_MAST_REC[WAIT_MAST_STATUS][1, NO_MVS] = "";
}
/* **        END */
if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID)) {
/*  Update existing persons list of courses */
if (!(LOCATE(ACTIVITY_CODE, WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], 1, 0, 1, ref POS, "AL"))) {
NO_CODES = DCOUNT(WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES], VM);
MVC = NO_CODES + 1;
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES][1, MVC] = ACTIVITY_CODE;
WAIT_STUDENT_REC[WAIT_STUD_DATES][1, MVC] = CONV_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
} else {
/*  New Record */
MAT(ref WAIT_STUDENT_REC, "");
WAIT_STUDENT_REC[WAIT_STUD_TITLE] = TEMP_REC[1];
WAIT_STUDENT_REC[WAIT_STUD_FORENAME] = TEMP_REC[2];
WAIT_STUDENT_REC[WAIT_STUD_SURNAME] = TEMP_REC[3];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] = TEMP_REC[4];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] = TEMP_REC[5];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] = TEMP_REC[6];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] = TEMP_REC[7];
WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] = TEMP_REC[8];
WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME] = TEMP_REC[9];
WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK] = TEMP_REC[10];
WAIT_STUDENT_REC[WAIT_STUD_COMMENT] = "From old list : " + FIELD(ID, "*", 1);
WAIT_STUDENT_REC[WAIT_STUD_ACTIVITY_CODES] = ACTIVITY_CODE;
WAIT_STUDENT_REC[WAIT_STUD_DATES] = CONV_DATE;
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_ID);
}
MATWRITE(WAIT_MAST_REC, FL_WAIT_MASTER, ACTIVITY_CODE);
}
}
} while (true);
PRINT("Done");
return;
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
