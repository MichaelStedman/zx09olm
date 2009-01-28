//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL807 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_USED_AREAS = 29;
readonly UvVar USED_START_TIME = 1;
readonly UvVar USED_FINISH_TIME = 2;
readonly UvVar USED_BOOKINGS = 3;
readonly UvVar FL_FLOOR_AREAS = 24;
readonly UvVar FLOOR_DESC = 1;
readonly UvVar FLOOR_FACILITIES = 2;
readonly UvVar FLOOR_PRICE = 3;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] USED_AREAS_REC = new UvVar[3];
UvVar[] FLOORS_REC = new UvVar[10];
#endregion
#region Variables
UvVar START_DATE = "";
UvVar END_DATE = "";
UvVar DAY_TYPE = "";
UvVar NO_DAYS = "";
UvVar FLOOR_PARAMETERS = "";
UvVar START_TIME = "";
UvVar END_TIME = "";
UvVar DURATION = "";
UvVar NO_FLOORS = "";
UvVar PRINT_FLAG = "";
UvVar DAY_NAME = "";
UvVar MACHINE_TYPE = "";
UvVar VM = "";
UvVar SVM = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar EOF = "";
UvVar PAGE_DEPTH = "";
UvVar FORM = "";
UvVar TOTAL_FLOORS = "";
UvVar TOTAL_DAYS_ARRAY = "";
UvVar ZZZ_DATE = "";
UvVar SSTATEMENT = "";
UvVar PAGE_NO = "";
UvVar LINE_NO = "";
UvVar NEW_DATE = "";
UvVar OLD_DATE = "";
UvVar NOTHING_PRINTED = "";
UvVar INTERACT = "";
UvVar HEADER = "";
UvVar NO_OF_AREAS = "";
UvVar AREA = "";
UvVar FLOOR_SPOT = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar DATE_ARRAY = "";
UvVar ALL_FLOORS = "";
UvVar TIMES = "";
UvVar CONTINUE = "";
UvVar USED_KEY = "";
UvVar USED_REC = "";
UvVar FLOOR_AREA = "";
UvVar USED_DATE = "";
UvVar PNTR = "";
UvVar STIME = "";
UvVar ETIME = "";
UvVar PREV_ETIME = "";
UvVar TEST_START = "";
UvVar TEST_END = "";
UvVar NO_OF_TIMES_POSSIBLE = "";
UvVar TIME_TO_INCLUDE = "";
UvVar NO_OF_FLOOR_AREAS_NOT_TOUCHED = "";
UvVar NO_OF_FLOORS_WITH_SPACE = "";
UvVar TOTAL_FLOORS_AVAILABLE = "";
UvVar FLOORS_TO_SHOW = "";
UvVar FLRS = "";
UvVar NO_OF_DAYS = "";
FL006 FL006;
UvVar DAY_TO_PRINT = "";
UvVar PRINT_DATE = "";
UvVar PRINT_STIME = "";
UvVar FLOORS = "";
UvVar PRINT_ETIME = "";
UvVar PRINT_FLOOR = "";
UvVar PRINT_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL807(ref UvVar START_DATE, ref UvVar END_DATE, ref UvVar DAY_TYPE, ref UvVar NO_DAYS, ref UvVar FLOOR_PARAMETERS, ref UvVar START_TIME, ref UvVar END_TIME, ref UvVar DURATION, ref UvVar NO_FLOORS, ref UvVar PRINT_FLAG, ref UvVar DAY_NAME) {
this.START_DATE = START_DATE;
this.END_DATE = END_DATE;
this.DAY_TYPE = DAY_TYPE;
this.NO_DAYS = NO_DAYS;
this.FLOOR_PARAMETERS = FLOOR_PARAMETERS;
this.START_TIME = START_TIME;
this.END_TIME = END_TIME;
this.DURATION = DURATION;
this.NO_FLOORS = NO_FLOORS;
this.PRINT_FLAG = PRINT_FLAG;
this.DAY_NAME = DAY_NAME;
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
/*  Find an Available Space */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
PROGRAM = "FL807";
/* ************************************* */
/*  INCLUDE FILES */
/* ************************************* */
#region INCLUDE FL.FILES FL.USED.AREAS
#region INCLUDE FL.FILES FL.USED.AREAS.EQU

#endregion

#region INCLUDE FL.FILES FL.USED.AREAS.DIM

#endregion
#region INCLUDE FL.FILES FL.USED.AREAS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.FLOOR.AREAS

/* REMOVED THIS TO PREVENT CONFUSION, MUST BE SENT WITH MASTER HALL MAINT PROGRAM!     EQU HALL.DESC                         TO FLOORS.REC(2) */
/*  This entry has been corrected as at 9/3/01 for Release 6.4 */
/*  Floor price was wrongly equated to floor.rec */
/*  Hall desc was only used by master hall maint so this prog was amended */

#endregion
/* ************************************* */
/*  INITIALIZE VARIABLES */
/* ************************************* */
EOF = 0;
if (PRINT_FLAG == "P") {
PRINTER_ON();
PAGE_DEPTH = 60;
FORM = CHAR(12);
} else {
PAGE_DEPTH = 20;
}
TOTAL_FLOORS = "";
TOTAL_DAYS_ARRAY = INIT;
for(ZZZ_DATE = START_DATE; ZZZ_DATE <= END_DATE; ZZZ_DATE += 1) {
if ((MOD(ZZZ_DATE, 7) + 1) == DAY_TYPE) {
TOTAL_DAYS_ARRAY[1, -1] = ZZZ_DATE;
TOTAL_DAYS_ARRAY[2, -1] = " ";
TOTAL_DAYS_ARRAY[3, -1] = " ";
TOTAL_DAYS_ARRAY[4, -1] = " ";
}
}
SSTATEMENT = INIT;
DURATION = DURATION * 60;
PAGE_NO = 0;
LINE_NO = 70;
NEW_DATE = "";
OLD_DATE = "";
NOTHING_PRINTED = FALSE;
INTERACT = "";
HEADER = "";
HEADER[1] = SPACE(8) + "BOOKING AVAILABILITY FROM " + OCONV(START_DATE, "D") + " TO " + OCONV(END_DATE, "D") + SPACE(10) + "Page ";
HEADER[2] = SPACE(34) + OCONV(START_TIME, "MT") + " TO " + OCONV(END_TIME, "MT");
HEADER[3] = "";
HEADER[4] = "  Date " + SPACE(10) + "Start Time" + SPACE(3) + "End Time" + SPACE(10) + "Floor Area";
HEADER[5] = "  ---- " + SPACE(10) + "----------" + SPACE(3) + "--------" + SPACE(10) + "----------";
/* ******************************************** */
/*  SSELECT */
/* ******************************************** */
START_DATE = OCONV(START_DATE, "D");
END_DATE = OCONV(END_DATE, "D");
SSTATEMENT = "SSELECT FL.USED.AREAS WITH CENTRE = \"" + COMMON.CENTRE + "\"";
SSTATEMENT = SSTATEMENT + " AND WITH DATE >= \"" + START_DATE + "\"";
SSTATEMENT = SSTATEMENT + " AND WITH DATE <= \"" + END_DATE + "\"";
SSTATEMENT = SSTATEMENT + " AND WITH DOW = \"" + DAY_NAME + "\"";
SSTATEMENT = SSTATEMENT + " AND WITH FLOOR = ";
NO_OF_AREAS = DCOUNT(FLOOR_PARAMETERS, " ");
for(AREA = 1; AREA <= NO_OF_AREAS; AREA += 1) {
FLOOR_SPOT = FIELD(FLOOR_PARAMETERS, " ", AREA);
TOTAL_FLOORS[1, -1] = FLOOR_SPOT;
SSTATEMENT = SSTATEMENT + "\"" + FLOOR_SPOT + "\"";
}
SSTATEMENT = SSTATEMENT + " BY DATE BY FLOOR";
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
/*      EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
/* **************************************** */
/*  LOOP ROUND USED AREAS */
/* **************************************** */
L1000();
/*  READNEXT */
OLD_DATE = NEW_DATE;
do {
DATE_ARRAY = "";
ALL_FLOORS = TOTAL_FLOORS;
do {
L2000();
/*  TEST FOR TIMES */
L1000();
/*  READNEXT */
} while (true);
L3000();
/*  UPDATE MASTER ARRAY */
OLD_DATE = NEW_DATE;
} while (true);
L4000();
/*  ASSESS POSSIBILTY OF BOOKING */
if (NOTHING_PRINTED == FALSE) {
if (PRINT_FLAG == "T") {
PRINT(AT(50, 23) + "<RETURN> to finish" + SPACE(4));
INPUT(out CONTINUE, 1);
}
}
if (PRINT_FLAG == "P") {
PRINTER_CLOSE();
PRINTER_OFF();
}
return;
/* *************************************** */
/*  SUBROUTINES */
/* *************************************** */
}
void L1000() {
if (!READNEXT(ref USED_KEY, 0, 0, RTN_LIST)) { EOF = 1; goto L1099; }
if (!READ(ref USED_REC, COMMON.FILES[FL_USED_AREAS], USED_KEY)) { USED_REC = ""; }
FLOOR_AREA = FIELD(USED_KEY, "*", 2);
USED_DATE = FIELD(USED_KEY, "*", 3);
NEW_DATE = USED_DATE;
L1099:;
return;
}
void L2000() {
if (LOCATE(FLOOR_AREA, ALL_FLOORS, 1, 0, 1, ref PNTR, "AL")) {
ALL_FLOORS = DELETE(ALL_FLOORS, 1, PNTR, 0);
}
if (!LOCATE(USED_DATE, TOTAL_DAYS_ARRAY, 1, 0, 1, ref PNTR, "AR")) { goto L2099; }
TIMES = 0;
do {
TIMES = TIMES + 1;
STIME = USED_REC[1, TIMES];
if (STIME == "") break;
ETIME = USED_REC[2, TIMES];
if (TIMES == 1) {
PREV_ETIME = STIME;
} else {
PREV_ETIME = USED_REC[2, TIMES - 1];
}
TEST_START = PREV_ETIME;
TEST_END = STIME;
if (TEST_START >= START_TIME && TEST_END <= END_TIME && (TEST_END - TEST_START) >= DURATION) {
if (LOCATE(TEST_START, DATE_ARRAY, 1, 0, 1, ref PNTR, "AR")) {
if (TEST_END < DATE_ARRAY[2, PNTR]) {
DATE_ARRAY[2, PNTR] = TEST_END;
}
DATE_ARRAY[3, PNTR, -1] = FLOOR_AREA;
} else {
DATE_ARRAY = INSERT(DATE_ARRAY, 1, PNTR, 0, TEST_START);
DATE_ARRAY = INSERT(DATE_ARRAY, 2, PNTR, 0, TEST_END);
DATE_ARRAY = INSERT(DATE_ARRAY, 3, PNTR, 1, FLOOR_AREA);
}
}
} while (true);
if (ETIME < END_TIME) {
TEST_START = ETIME;
TEST_END = END_TIME;
if ((TEST_END - TEST_START) >= DURATION) {
if (LOCATE(TEST_START, DATE_ARRAY, 1, 0, 1, ref PNTR, "AR")) {
if (TEST_END < DATE_ARRAY[2, PNTR]) {
DATE_ARRAY[2, PNTR] = TEST_END;
}
DATE_ARRAY[3, PNTR, -1] = FLOOR_AREA;
} else {
DATE_ARRAY = INSERT(DATE_ARRAY, 1, PNTR, 0, TEST_START);
DATE_ARRAY = INSERT(DATE_ARRAY, 2, PNTR, 0, TEST_END);
DATE_ARRAY = INSERT(DATE_ARRAY, 3, PNTR, 1, FLOOR_AREA);
}
}
}
L2099:;
return;
}
void L3000() {
if (LOCATE(OLD_DATE, TOTAL_DAYS_ARRAY, 1, 0, 1, ref PNTR, "AR")) {
NO_OF_TIMES_POSSIBLE = DCOUNT(DATE_ARRAY[1], VM);
if (NO_OF_TIMES_POSSIBLE == 0) {
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 1, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 2, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 3, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 4, PNTR, 0);
goto L3099;
}
for(TIME_TO_INCLUDE = 1; TIME_TO_INCLUDE <= NO_OF_TIMES_POSSIBLE; TIME_TO_INCLUDE += 1) {
NO_OF_FLOOR_AREAS_NOT_TOUCHED = DCOUNT(ALL_FLOORS, VM);
NO_OF_FLOORS_WITH_SPACE = DCOUNT(DATE_ARRAY[3, TIME_TO_INCLUDE], SVM);
TOTAL_FLOORS_AVAILABLE = NO_OF_FLOOR_AREAS_NOT_TOUCHED + NO_OF_FLOORS_WITH_SPACE;
if (TOTAL_FLOORS_AVAILABLE >= NO_FLOORS) {
FLOORS_TO_SHOW = "";
for(FLRS = 1; FLRS <= NO_OF_FLOOR_AREAS_NOT_TOUCHED; FLRS += 1) {
FLOORS_TO_SHOW = FLOORS_TO_SHOW + ALL_FLOORS[1, FLRS] + " ";
}
for(FLRS = 1; FLRS <= NO_OF_FLOORS_WITH_SPACE; FLRS += 1) {
FLOORS_TO_SHOW = FLOORS_TO_SHOW + DATE_ARRAY[3, TIME_TO_INCLUDE, FLRS] + " ";
}
FLOORS_TO_SHOW = TRIM(FLOORS_TO_SHOW);
TOTAL_DAYS_ARRAY[2, PNTR, TIME_TO_INCLUDE] = DATE_ARRAY[1, TIME_TO_INCLUDE];
TOTAL_DAYS_ARRAY[3, PNTR, TIME_TO_INCLUDE] = DATE_ARRAY[2, TIME_TO_INCLUDE];
TOTAL_DAYS_ARRAY[4, PNTR, TIME_TO_INCLUDE] = FLOORS_TO_SHOW;
}
}
if (TOTAL_DAYS_ARRAY[2, PNTR] == " ") {
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 1, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 2, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 3, PNTR, 0);
TOTAL_DAYS_ARRAY = DELETE(TOTAL_DAYS_ARRAY, 4, PNTR, 0);
}
}
L3099:;
return;
}
void L4000() {
NO_OF_DAYS = DCOUNT(TOTAL_DAYS_ARRAY[1], VM);
if (NO_OF_DAYS < NO_DAYS) {
nrf0 = 99;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
NOTHING_PRINTED = TRUE;
goto L4999;
}
for(DAY_TO_PRINT = 1; DAY_TO_PRINT <= NO_OF_DAYS; DAY_TO_PRINT += 1) {
PRINT_DATE = TOTAL_DAYS_ARRAY[1, DAY_TO_PRINT];
PRINT_STIME = TOTAL_DAYS_ARRAY[2, DAY_TO_PRINT, 1];
if (PRINT_STIME == " ") {
PRINT_STIME = START_TIME;
TOTAL_DAYS_ARRAY[3, DAY_TO_PRINT, 1] = END_TIME;
for(FLOORS = 1; FLOORS <= DCOUNT(TOTAL_FLOORS[1], VM); FLOORS += 1) {
TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1] = TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1] + TOTAL_FLOORS[1, FLOORS] + " ";
}
TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1] = TRIM(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1]);
}
PRINT_ETIME = TOTAL_DAYS_ARRAY[3, DAY_TO_PRINT, 1];
PRINT_FLOOR = FIELD(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1], " ", 1);
if (!(READV(ref FLOORS_REC[FLOOR_DESC], COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + PRINT_FLOOR, 1))) {
FLOORS_REC[FLOOR_DESC] = PRINT_FLOOR;
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT_LINE = SPACE(2) + OCONV(PRINT_DATE, "D2/") + SPACE(10) + OCONV(PRINT_STIME, "MT") + SPACE(7) + OCONV(PRINT_ETIME, "MT") + SPACE(11) + FORMAT(FLOORS_REC[FLOOR_DESC], "L#25");
PRINTCR(PRINT_LINE);
for(FLRS = 2; FLRS <= DCOUNT(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1], " "); FLRS += 1) {
PRINT_FLOOR = FIELD(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, 1], " ", FLRS);
if (!(READV(ref FLOORS_REC[FLOOR_DESC], COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + PRINT_FLOOR, 1))) {
FLOORS_REC[FLOOR_DESC] = PRINT_FLOOR;
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT_LINE = SPACE(48) + FORMAT(FLOORS_REC[FLOOR_DESC], "L#25");
PRINTCR(PRINT_LINE);
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT();
for(TIMES = 2; TIMES <= DCOUNT(TOTAL_DAYS_ARRAY[2, DAY_TO_PRINT], SVM); TIMES += 1) {
PRINT_STIME = TOTAL_DAYS_ARRAY[2, DAY_TO_PRINT, TIMES];
PRINT_ETIME = TOTAL_DAYS_ARRAY[3, DAY_TO_PRINT, TIMES];
PRINT_FLOOR = FIELD(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, TIMES], " ", 1);
if (!(READV(ref FLOORS_REC[FLOOR_DESC], COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + PRINT_FLOOR, 1))) {
FLOORS_REC[FLOOR_DESC] = PRINT_FLOOR;
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT_LINE = SPACE(20) + OCONV(PRINT_STIME, "MT") + SPACE(7) + OCONV(PRINT_ETIME, "MT") + SPACE(11) + FORMAT(FLOORS_REC[FLOOR_DESC], "L#25");
PRINTCR(PRINT_LINE);
for(FLRS = 2; FLRS <= DCOUNT(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, TIMES], " "); FLRS += 1) {
PRINT_FLOOR = FIELD(TOTAL_DAYS_ARRAY[4, DAY_TO_PRINT, TIMES], " ", FLRS);
if (!(READV(ref FLOORS_REC[FLOOR_DESC], COMMON.FILES[FL_FLOOR_AREAS], COMMON.CENTRE + "*" + PRINT_FLOOR, 1))) {
FLOORS_REC[FLOOR_DESC] = PRINT_FLOOR;
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT_LINE = SPACE(48) + FORMAT(FLOORS_REC[FLOOR_DESC], "L#25");
PRINTCR(PRINT_LINE);
}
LINE_NO = LINE_NO + 1;
if (LINE_NO > PAGE_DEPTH) { L5000(); }
if (INTERACT == COMMON.ABANDON) { goto L4999; }
PRINT();
}
}
L4999:;
return;
}
void L5000() {
/*  Print Header */
PAGE_NO = PAGE_NO + 1;
if (PRINT_FLAG == "P") {
PRINTCR(FORM);
} else {
if (PAGE_NO != 1) {
PRINT(AT(50, 23) + "<RETURN> to continue");
INPUT(out CONTINUE, 1);
if (CONTINUE == COMMON.ABANDON) { INTERACT = COMMON.ABANDON; goto L5999; }
}
PRINT(COMMON.WASH);
}
PRINTCR(HEADER[1] + FORMAT(PAGE_NO, "R#4"));
PRINTCR(HEADER[2]);
PRINTCR(HEADER[3]);
PRINTCR(HEADER[4]);
PRINTCR(HEADER[5]);
LINE_NO = 5;
L5999:;
return;
/* *********************************** */
/*  END OF PROGRAM */
/* *********************************** */
}
}
}
