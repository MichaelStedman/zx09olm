//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL785 : UvBase
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
readonly UvVar ERROR = 7;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
readonly UvVar FL_SCREENS = 8;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar TRANS_FILENAME = 1;
readonly UvVar TRANS_SELECT_LIST = 2;
readonly UvVar TRANS_PROCEDURE = 3;
readonly UvVar TRANS_DIRECTORY = 4;
readonly UvVar TRANS_DESTINATION = 5;
readonly UvVar TRANS_SEQ_OVER = 6;
readonly UvVar TRANS_TEMPLATE = 7;
readonly UvVar TRANS_DOCUMENT = 8;
readonly UvVar TRANS_MACRO = 9;
readonly UvVar TRANS_APPLICATION = 10;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] TRANS_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar SCREEN_CODE = "";
UvVar MONTH_CONV = "";
UvVar M = "";
UvVar IDATE = "";
UvVar FL_MEMBER_STATS = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar DFL_MEMBER_STATS = "";
UvVar LIST_FILE = "";
UvVar CENTRENAME = "";
UvVar LETTER_CONTROL = "";
FL006 FL006;
UvVar DONE = "";
UvVar EDIT = "";
UvVar PERIOD_NO = "";
UvVar INTERACT = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar PERIOD_CONTROL = "";
UvVar DDMONTH = "";
FL019 FL019;
UvVar ANS = "";
UvVar MAXFIELD = "";
UvVar CURR_FIELD = "";
UvVar PERIOD_REC = "";
UvVar PERIOD_OVERRIDE = "";
UvVar ANS2 = "";
UvVar LETTER_LOOP = "";
UvVar WORDTYPE = "";
UvVar FUT_REC = "";
UvVar THE_LIST = "";
FL773 FL773;
UvVar SUCCESSFUL = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL785() {
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
/*  WRITTEN BY RICHARD T */
PROGRAM = "FL785";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
SCREEN_CODE = PROGRAM;
/* * */
/*  Define Files Used */
/* * */
MONTH_CONV = "";
for(M = 1; M <= 12; M += 1) {
IDATE = ICONV("1/" + M + "/00", "D2/");
MONTH_CONV[M] = OCONV(OCONV(IDATE, "DMA"), "MCT");
}
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.MEMBER.STATS
if (!(OPEN("FL.MEMBER.STATS", out FL_MEMBER_STATS))) {

STOP(201, "FL.MEMBER.RENEWAL.STATS");
}

#endregion
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
if (!(OPENDICT("FL.MEMBER.STATS", out DFL_MEMBER_STATS))) {
STOP(201, "DICT FL.MEMBER.STATS");
}
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(OPEN("&SAVEDLISTS&", out LIST_FILE))) {
STOP(201, "&SAVEDLISTS&");
}
/* ** */
/* Initialise Global Variables */
/* ** */
if (!READV(ref CENTRENAME, COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRENAME = "NOTKNOWN"; }
if (!(READ(ref LETTER_CONTROL, COMMON.FILES[FL_CONTROL], "FL785.PARAMS"))) {
nrf0 = 8;
nrf1 = "FL785.PARAMS MISSING FROM CONTROL";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/* ****************************************************************** */
/*  CONTROL BLOCK */
/* * */
DONE = FALSE;
EDIT = FALSE;
PERIOD_NO = INIT;
INTERACT = INVALID_DATA;
DOTS_ONLY = FALSE;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
if (PERIOD_NO == INIT) {
L1000();
/* Get Period Number */
}
if (INTERACT != EXIT) {
/* get period control */
/*  containing <1> as date of stat compilation */
/*  <2+> contains last run date for letter *see letter.control* */
if (READ(ref PERIOD_CONTROL, FL_MEMBER_STATS, PERIOD_NO + "*CONTROL")) {
PRINT(AT(28, 4) + PERIOD_NO.Substring(5, 2) + PERIOD_NO.Substring(1, 4));
PRINTCR(AT(56, 4) + OCONV(PERIOD_CONTROL[1], "D4"));
/*  Write dictionary item for report to use to pass dd month to word */
/*            DDMONTH = OCONV("1/":PERIOD.NO[5,2]:"/":PERIOD.NO[1,4],"DMA") */
DDMONTH = MONTH_CONV[PERIOD_NO.Substring(5, 2)];
WRITEV(DDMONTH, DFL_MEMBER_STATS, "DDMONTH", 1);
L2000();
/*  Display Letter Options */
} else {
nrf0 = 7;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
}
}
do {
if (INTERACT == EXIT) break;
PRINTCR(AT(2, 22) + "Enter required option or '.' to quit");
PRINT(AT(41, 22));
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref ANS);
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
WRITE(PERIOD_CONTROL, FL_MEMBER_STATS, PERIOD_NO + "*CONTROL");
INTERACT = EXIT;
}// CASE
else if (MATCH(ANS,"0N")) {
if (ANS < 1 || ANS > MAXFIELD) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
CURR_FIELD = ANS;
L3000();
/*  Produce Letter */
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(28, 4) + PERIOD_NO.Substring(5, 2) + PERIOD_NO.Substring(1, 4));
PRINTCR(AT(56, 4) + OCONV(PERIOD_CONTROL[1], "D4"));
L2000();
/* Redraw Screen */
}
}// CASE
else if (OTHERWISE) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
return;
/* * */
/*  END OF PROGRAM */
/* * */
/* * */
}
void L1000() {
/*  Get Period Number */
/* * */
INTERACT = INVALID_DATA;
if (READ(ref PERIOD_REC, COMMON.FILES[FL_CONTROL], "MK102.PERIOD")) {
PERIOD_NO = PERIOD_REC[1];
PERIOD_OVERRIDE = PERIOD_REC[2];
INTERACT = VALID_DATA;
} else {
PERIOD_OVERRIDE = TRUE;
}
if (PERIOD_OVERRIDE == FALSE) {
PRINT(AT(28, 4) + PERIOD_NO.Substring(5, 2) + PERIOD_NO.Substring(1, 4));
return;
}
INTERACT = INVALID_DATA;
do {
if (INTERACT == VALID_DATA || INTERACT == EXIT) break;
PRINT(AT(28, 4));
nrf0 = 24;
FL019 = new FL019(ref nrf0, ref ANS2);
ANS2 = ANS2.Substring(3, 4) + ANS2.Substring(1, 2);
/* PRINT @(10,10):'[[[':ANS2:']]]':;INPUT FLEX,1: */
// BEGIN CASE
// CASE
if (ANS2 == "" && PERIOD_NO != "") {
INTERACT = VALID_DATA;
}// CASE
else if (ANS2 == COMMON.ABANDON) {
INTERACT = EXIT;
}// CASE
else if (MATCH(ANS2,("6N")) && LEN(ANS2) == 6) {
/*            READ PERIOD.TEST FROM FL.MEMBER.STATS,ANS2 THEN */
PERIOD_NO = ANS2;
INTERACT = VALID_DATA;
/*            END ELSE */
/*               INTERACT = INVALID.DATA */
/*               CALL FL006(PROGRAM,3,"") ; * Period not run */
/*            END */
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
return;
/* * */
}
void L2000() {
/* * */
MAXFIELD = "";
MAXFIELD = DCOUNT(LETTER_CONTROL, AM) - 10;
for(LETTER_LOOP = 1; LETTER_LOOP <= MAXFIELD; LETTER_LOOP += 1) {
PRINTCR(AT(1, 6 + LETTER_LOOP) + FORMAT(LETTER_LOOP, "R#2") + ".");
PRINT(AT(5, 6 + LETTER_LOOP) + FORMAT(LETTER_CONTROL[10 + LETTER_LOOP, 1], "L#45"));
PRINTCR(OCONV(PERIOD_CONTROL[1 + LETTER_LOOP], "D4"));
}
return;
/* * */
}
void L3000() {
/*  Produce the letter (or at least try to) */
if (!(READV(ref WORDTYPE, COMMON.FILES[FL_CONTROL], "WORDTYPE*" + PORT_NUMBER, 1))) {
if (!(READV(ref WORDTYPE, COMMON.FILES[FL_CONTROL], "WORDTYPE", 1))) {
WORDTYPE = "";
}
}
FUT_REC = LETTER_CONTROL[1];
FUT_REC[2] = LETTER_CONTROL[CURR_FIELD + 10, 3];
/* List name */
FUT_REC[3] = "";
/* Select Proc */
FUT_REC[4] = LETTER_CONTROL[4];
FUT_REC[5] = LETTER_CONTROL[CURR_FIELD + 10, 4];
/* Data file */
FUT_REC[6] = LETTER_CONTROL[6];
FUT_REC[7] = LETTER_CONTROL[7];
FUT_REC[8] = LETTER_CONTROL[8] + LETTER_CONTROL[CURR_FIELD + 10, 2] + WORDTYPE;
FUT_REC[9] = "";
FUT_REC[10] = LETTER_CONTROL[CURR_FIELD + 10, 6];
if (!(READ(ref THE_LIST, FL_MEMBER_STATS, LETTER_CONTROL[CURR_FIELD + 10, 7] + PERIOD_NO))) {
nrf0 = 10;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
return;
}
WRITE(THE_LIST, LIST_FILE, LETTER_CONTROL[CURR_FIELD + 10, 3]);
WRITE(FUT_REC, FL_UNIVERSE_TRANSFER, "CONTROL*FL785*DDMEM");
if (!(READV(ref WORDTYPE, COMMON.FILES[FL_CONTROL], "WORDTYPE*" + PORT_NUMBER, 1))) {
if (!(READV(ref WORDTYPE, COMMON.FILES[FL_CONTROL], "WORDTYPE", 1))) {
WORDTYPE = "";
}
}
nrf0 = LETTER_CONTROL[CURR_FIELD + 10, 5];
nrf1 = "FL785*DDMEM";
FL773 = new FL773(ref nrf0, ref nrf1, ref SUCCESSFUL);
if (SUCCESSFUL) {
PERIOD_CONTROL[CURR_FIELD + 1] = TODAYS_DATE;
}
return;
}
}
}
