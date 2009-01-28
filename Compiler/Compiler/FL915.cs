//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL915 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar VM = "";
UvVar FL_STUDENTS = "";
UvVar FL_COURSE_MASTER = "";
UvVar FIRST_PAGE = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar START_DATE = "";
UvVar END_DATE = "";
UvVar CONV_START_DATE = "";
UvVar CONV_END_DATE = "";
UvVar REQUESTED_COURSE = "";
UvVar REQUESTED_CENTRE = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar TOT = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar STUDENT_ID = "";
UvVar STUD_REC = "";
UvVar MVC = "";
UvVar OK_TO_PROCEED = "";
UvVar THIS_CODE = "";
UvVar THIS_CENTRE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL915() {
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
/*  Course adjustment enquiry */
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
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
FIRST_PAGE = TRUE;
PROGRAM = "FL915";
PRINT(AT(0, 20));
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
START_DATE = OCONV(CONTROLS_REC[5], "D");
END_DATE = OCONV(CONTROLS_REC[6], "D");
CONV_START_DATE = CONTROLS_REC[5];
CONV_END_DATE = CONTROLS_REC[6];
REQUESTED_COURSE = CONTROLS_REC[7];
REQUESTED_CENTRE = CONTROLS_REC[8];
PROMPT("");
/* !!  EXECUTE "LS.LASER" */
PRINT();
/* !!  PRINT @(0,0):EOS: */
/* !!  PRINT @(0,0):"(FL915)          Course Adjustment Enquiry" */
/* !!  PRINT @(0,1):"                 =========================" */
/* !!10* */
/* !!  PRINT @(10,3): "Start Date: ":EOL:;INPUT START.DATE,12: */
/* !!  PRINT */
/* !!  IF START.DATE = "." OR START.DATE = "" THEN RETURN */
/* !!  CONV.START.DATE = ICONV(START.DATE,"D") */
/* !!  IF CONV.START.DATE = "" THEN GO 10 */
/* !!  PRINT @(22,3):OCONV(CONV.START.DATE,"D"): */
/* !!20* */
/* !!  PRINT @(10,5): "End Date:   ":EOL:;INPUT END.DATE,12: */
/* !!  PRINT */
/* !!  IF END.DATE = "" OR END.DATE = "." THEN RETURN */
/* !!  CONV.END.DATE = ICONV(END.DATE,"D") */
/* !!  IF CONV.END.DATE = "" THEN GO 20 */
/* !!  PRINT @(22,5):OCONV(CONV.END.DATE,"D"): */
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "COURSES.LANDSCAPE";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
TOT = 0;
/* !     SELECT FL.STUDENTS */
INSTRUCTION = "SSELECT FL.STUDENTS BY ID";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
PRINTCR("(FL915)  Course Adjustments From " + OCONV(CONV_START_DATE, "D") + " to " + OCONV(CONV_END_DATE, "D"));
PRINT();
PRINT(FORMAT("Student", "L#8"));
PRINT(FORMAT("Course", "L#16"));
PRINT(FORMAT("Starts", "L#13"));
PRINT(FORMAT("Amount", "R#9") + SPACE(2));
PRINT(FORMAT("User", "L#8"));
PRINT(FORMAT("Actioned on", "L#13"));
PRINTCR("Reason");
PRINT();
EOF = 0;
do {
if (!READNEXT(ref STUDENT_ID, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (!READ(ref STUD_REC, FL_STUDENTS, STUDENT_ID)) { STUD_REC = ""; }
for(MVC = 1; MVC <= DCOUNT(STUD_REC[25], VM); MVC += 1) {
if (STUD_REC[25, MVC] >= CONV_START_DATE && STUD_REC[25, MVC] <= CONV_END_DATE && STUD_REC[26, MVC] == "A" && NOT(STUD_REC[30, MVC] == "T")) {
OK_TO_PROCEED = TRUE;
THIS_CODE = FIELD(STUD_REC[24, MVC], "*", 2);
if (REQUESTED_CENTRE != "") {
/*  If user specified a centre, see if this course is relevant */
if (!READV(ref THIS_CENTRE, FL_COURSE_MASTER, THIS_CODE, 4)) { THIS_CENTRE = ""; }
if (THIS_CENTRE == "" || THIS_CENTRE == REQUESTED_CENTRE) {
OK_TO_PROCEED = TRUE;
} else {
OK_TO_PROCEED = FALSE;
}
}
if (REQUESTED_COURSE != "") {
/*  User is only interested in a specific course code */
if (THIS_CODE != REQUESTED_COURSE) {
OK_TO_PROCEED = FALSE;
}
}
if (OK_TO_PROCEED) {
PRINTCR(FORMAT(STUDENT_ID, "L#8") + FORMAT(THIS_CODE, "L#14") + "  " + OCONV(FIELD(STUD_REC[24, MVC], "*", 1), "D") + "  " + FORMAT(OCONV(STUD_REC[27, MVC], "MD2"), "R#9") + "  " + FORMAT(STUD_REC[32, MVC], "L#6") + "  " + OCONV(STUD_REC[25, MVC], "D") + "  " + STUD_REC[31, MVC]);
TOT = TOT + STUD_REC[27, MVC];
}
}
}
} while (true);
PRINT();
PRINTCR(FORMAT(("TOTAL = " + OCONV(TOT, "MD2")), "R#46"));
/* DJA!PRINT PRINT.END.COMMAND: */
PRINTER_CLOSE();
PRINTER_OFF();
/* !!     PRINT @(10,15):"Process complete - press <return>":;INPUT CONT,1: */
return;
}
}
}
