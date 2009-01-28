//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL119_GAZ : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_SCREENS = 8;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar FL_TICKET_CONTROL = 19;
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
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] TICK_CONTROL_REC = new UvVar[20];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] COURSE_MSTR_REC = new UvVar[15];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar NRM_VID = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar SCREEN_CODE = "";
UvVar FL_COURSE_MASTER = "";
UvVar CENTRENAME = "";
UvVar VALID_TYPES = "";
UvVar VALID_ACTIVITIES = "";
UvVar WNDO_REC = "";
UvVar WNDO_STA = "";
UvVar WNDO_END = "";
UvVar WNDO_POS = "";
UvVar DISPLAY_ONLY = "";
UvVar HELP_REC = "";
UvVar FINISHED = "";
UvVar AMENDING = "";
UvVar CURR_FIELD = "";
UvVar MAX_FIELD = "";
UvVar DOTS_ONLY = "";
FL000_10 FL000_10;
UvVar VALID_CODE = "";
UvVar TICK_TYPE = "";
UvVar USER_ACTION = "";
FL006 FL006;
UvVar VALID_TYPE = "";
FL019 FL019;
UvVar POS = "";
UvVar TICKET_TYPE_ID = "";
UvVar TICK_REC = "";
UvVar ORIG_TICK_ID = "";
UvVar ORIG_TICK_REC = "";
UvVar ACTIVITY = "";
UvVar TICK_FEE_ID = "";
UvVar TICK_FEE_REC = "";
UvVar COURSE_REC = "";
UvVar VALID_INPUT = "";
UvVar TICK_ATT = "";
UvVar NUMATTS = "";
UvVar TICK_LINE = "";
UvVar ACT_MIN = "";
UvVar ACT_MAX = "";
UvVar CLRLOOP = "";
UvVar FLD_CNT = "";
UvVar ANSWER = "";
UvVar FLD_LEN = "";
UvVar WNDO_JUST = "";
UvVar SCR_XPOS = "";
UvVar SCR_YPOS = "";
UvVar WNDO_PRMPT_LEN = "";
UvVar HCNT = "";
FL150 FL150;
UvVar HELP_ACTION = "";
UvVar HELP_SPC = "";
UvVar CLR_HELP = "";
UvVar WNDO_LIST = "";
UvVar WNDO_LIST_ATT = "";
UvVar ATTCNT = "";
UvVar ACTIVITY_FLAG = "";
UvVar VMCNT = "";
UvVar WNDO_LINE_LEN = "";
UvVar WNDO_PADDING = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL119_GAZ() {
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
/*  Ticket Layout Maintenance */
/*  Last updated by lfsw (MONTE_CARLO\lfsw) at 10:49:49 on 01/09/1999. */
/*  WRITTEN BY RICHARD T */
PROGRAM = "FL119.GAZ";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROMPT("");
SCREEN_CODE = PROGRAM;
/* * */
/*  Define Files Used */
/* * */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.TICKET.CONTROL

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.MASTER

if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
/*  A = Activity Day or Null for standard course :- */
/*  Optional code corresponding to FL.COURSE.TYPES :- */

#endregion
/* ** */
/* Initialise Global Variables */
/* ** */
if (!READV(ref CENTRENAME, COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRENAME = "NOTKNOWN"; }
if (!(READ(ref VALID_TYPES, COMMON.FILES[FL_TICKET_CONTROL], "VALID.LAYOUT.TYPES.GAZ"))) {
VALID_TYPES[1] = "C";
VALID_TYPES[2] = "CASUAL.FORMAT";
VALID_TYPES[3] = "N";
}
if (!(READ(ref VALID_ACTIVITIES, COMMON.FILES[FL_TICKET_CONTROL], "MASTER.CONTROL"))) {
VALID_ACTIVITIES = "UNITS";
}
/* - */
/*  in the correct format */
/* - */
if (!(READ(ref WNDO_REC, COMMON.FILES[FL_SCREENS], PROGRAM + ".WIN"))) {
WNDO_REC = 8;
WNDO_REC[2] = 21;
WNDO_REC[3] = 2;
WNDO_REC[4] = 77;
WNDO_REC[5] = "Field  Font  Description";
WNDO_REC[6] = "Select field no to amend, I to insert, D to delete";
WNDO_REC[7] = "END";
}
WNDO_STA = WNDO_REC[8, 1];
/*  Start Attribute */
WNDO_END = WNDO_REC[8, 2];
/*  End Attribute */
WNDO_POS = 1;
/*  Current Scroll Position */
DISPLAY_ONLY = FALSE;
if (!(READ(ref HELP_REC, COMMON.FILES[FL_SCREENS], PROGRAM + ".HLP"))) {
HELP_REC = 8;
HELP_REC[2] = 21;
HELP_REC[3] = 40;
HELP_REC[4] = 77;
HELP_REC[5] = "Available Options";
HELP_REC[6] = "Select Option Required ";
}
/* ****************************************************************** */
/*  CONTROL BLOCK */
/* * */
FINISHED = FALSE;
AMENDING = FALSE;
CURR_FIELD = 1;
MAX_FIELD = 3;
DOTS_ONLY = FALSE;
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
VALID_CODE = FALSE;
do {
if (VALID_CODE) break;
L1000();
/*  Get Ticket Type and Display Window */
if (FINISHED == TRUE) { return; }
if (TICK_TYPE == "B" || TICK_TYPE == "C" || TICK_TYPE == "CO") {
L1050();
/*  Get Activity Code */
if (FINISHED == TRUE) { return; }
} else {
VALID_CODE = TRUE;
}
} while (true);
L3000();
/*  Set up correct Window and Display Type for Ticket */
do {
if (FINISHED) break;
USER_ACTION = "";
L3100();
/*  Display window and get action */
// BEGIN CASE
// CASE
if (USER_ACTION == COMMON.ABANDON) {
FINISHED = TRUE;
}// CASE
else if (USER_ACTION == "I") {
L1100();
/*  Insert a Field */
}// CASE
else if (USER_ACTION == "D") {
L1200();
/*  Delete a Field */
}// CASE
else if (USER_ACTION == "END") {
/*  File it */
L5000();
/*  File it */
}// CASE
else if (MATCH(USER_ACTION,"0N") && USER_ACTION > 0) {
L1300();
/*  Amend it */
}// CASE
else if (OTHERWISE) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
/* * */
/*  END OF CONTROL BLOCK */
/* ************************************************************************* */
return;
/* *************************** */
/*  Options                  * */
/* *************************** */
/* * */
}
void L1000() {
/*  Get Ticket Layout Type */
/* * */
VALID_TYPE = FALSE;
do {
if (VALID_TYPE) break;
PRINT(AT(49, 3));
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref TICK_TYPE);
if (TICK_TYPE == COMMON.ABANDON) {
FINISHED = TRUE;
return;
}
if (LOCATE(TICK_TYPE, VALID_TYPES, 1, 0, 1, ref POS, "AL")) {
TICKET_TYPE_ID = VALID_TYPES[2, POS];
/*  Check for prefix flag */
if (VALID_TYPES[3, POS] == "Y") {
TICKET_TYPE_ID = COMMON.CENTRE + "*" + TICKET_TYPE_ID;
}
if (READ(ref TICK_REC, COMMON.FILES[FL_TICKET_CONTROL], TICKET_TYPE_ID)) {
VALID_TYPE = TRUE;
} else {
TICK_REC = 2;
TICK_REC[1, 2] = 1;
VALID_TYPE = TRUE;
}
ORIG_TICK_ID = TICKET_TYPE_ID;
ORIG_TICK_REC = TICK_REC;
VALID_TYPE = TRUE;
} else {
VALID_TYPE = FALSE;
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/* ******************************************************************* */
/*  Display error message if Type = CO - not yet available */
/* ******************************************************************* */
} while (true);
return;
}
void L1050() {
/*  Get Activity Code */
VALID_CODE = FALSE;
do {
if (VALID_CODE) break;
PRINT(AT(49, 4));
nrf0 = 12;
FL019 = new FL019(ref nrf0, ref ACTIVITY);
if (ACTIVITY == COMMON.ABANDON) {
FINISHED = TRUE;
return;
}
// BEGIN CASE
// CASE
if (TICK_TYPE == "C" && ACTIVITY != "") {
TICK_FEE_ID = "CONTROL*" + COMMON.CENTRE + "*" + ACTIVITY;
if (READ(ref TICK_FEE_REC, COMMON.FILES[FL_TICKET_FEES], TICK_FEE_ID)) {
VALID_CODE = TRUE;
TICKET_TYPE_ID = TICK_TYPE + "*" + ACTIVITY + ".FORMAT";
if (!(READ(ref TICK_REC, COMMON.FILES[FL_TICKET_CONTROL], TICKET_TYPE_ID))) {
/*  READ IN THE CASUAL.FORMAT TICK REC */
/* TICKET.TYPE.ID = ORIG.TICK.ID */
TICK_REC = ORIG_TICK_REC;
}
} else {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
VALID_CODE = FALSE;
}
}// CASE
else if (TICK_TYPE == "B" && ACTIVITY != "") {
TICK_FEE_ID = "CONTROL*" + COMMON.CENTRE + "*B*" + ACTIVITY;
if (READ(ref TICK_FEE_REC, COMMON.FILES[FL_TICKET_FEES], TICK_FEE_ID)) {
VALID_CODE = TRUE;
TICKET_TYPE_ID = TICK_TYPE + "*" + ACTIVITY + ".FORMAT";
if (!(READ(ref TICK_REC, COMMON.FILES[FL_TICKET_CONTROL], TICKET_TYPE_ID))) {
/* TICKET.TYPE.ID = ORIG.TICK.ID */
TICK_REC = ORIG_TICK_REC;
}
} else {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
VALID_CODE = FALSE;
}
}// CASE
else if (TICK_TYPE == "CO" && ACTIVITY != "") {
if (READ(ref COURSE_REC, FL_COURSE_MASTER, ACTIVITY)) {
VALID_CODE = TRUE;
TICKET_TYPE_ID = TICK_TYPE + "*" + ACTIVITY + ".FORMAT";
if (!(READ(ref TICK_REC, COMMON.FILES[FL_TICKET_CONTROL], TICKET_TYPE_ID))) {
/* TICKET.TYPE.ID = ORIG.TICK.ID */
TICK_REC = ORIG_TICK_REC;
}
} else {
nrf0 = 13;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
VALID_CODE = FALSE;
}
}// CASE
else if (ACTIVITY == "") {
VALID_CODE = TRUE;
}// CASE
else if (OTHERWISE) {
VALID_CODE = TRUE;
VALID_INPUT = FALSE;
}
// END CASE
} while (true);
return;
/* * */
}
void L1100() {
/*  Insert a Field */
/* * */
VALID_INPUT = FALSE;
PRINT(AT(WNDO_REC[3], WNDO_REC[2]) + "At what line do you wish to insert ");
do {
if (VALID_INPUT) break;
PRINT(AT(47, WNDO_REC[2]));
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref TICK_ATT);
// BEGIN CASE
// CASE
if (TICK_ATT == COMMON.ABANDON) {
VALID_INPUT = TRUE;
FINISHED = TRUE;
return;
}// CASE
else if (TICK_ATT == "") {
VALID_INPUT = TRUE;
return;
}// CASE
else if (TICK_ATT < 1 || TICK_ATT > (NUMATTS - WNDO_STA) + 2) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(TICK_ATT,"0N")) {
VALID_INPUT = TRUE;
TICK_ATT = TICK_ATT + WNDO_STA - 1;
}// CASE
else if (OTHERWISE) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
TICK_LINE = "";
DISPLAY_ONLY = TRUE;
L2000();
/*  Display Details */
DISPLAY_ONLY = FALSE;
L2000();
/*  Get/Amend Details */
if (FINISHED == TRUE) {
return;
}
TICK_REC = INSERT(TICK_REC, TICK_ATT, TICK_LINE);
return;
/* ** */
}
void L1200() {
/*  Delete a Field */
/* * */
VALID_INPUT = FALSE;
PRINT(AT(WNDO_REC[3], WNDO_REC[2]) + "Which Field do you want to delete? ");
do {
if (VALID_INPUT) break;
PRINT(AT(45, WNDO_REC[2]));
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref TICK_ATT);
// BEGIN CASE
// CASE
if (TICK_ATT == COMMON.ABANDON) {
VALID_INPUT = TRUE;
FINISHED = TRUE;
return;
}// CASE
else if (TICK_ATT == "") {
VALID_INPUT = TRUE;
return;
}// CASE
else if (TICK_ATT < 1 || TICK_ATT > (NUMATTS - WNDO_STA) + 1) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(TICK_ATT,"0N")) {
VALID_INPUT = TRUE;
TICK_ATT = TICK_ATT + WNDO_STA - 1;
}// CASE
else if (OTHERWISE) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
} while (true);
if (NUMATTS - WNDO_STA + 1 > 1) {
TICK_REC = DELETE(TICK_REC, TICK_ATT);
if (TICK_TYPE == "C" || TICK_TYPE == "B" || TICK_TYPE == "R") {
ACT_MIN = TICK_REC[1, 1];
ACT_MAX = TICK_REC[1, 1] + TICK_REC[1, 2] - 1;
if (TICK_ATT >= ACT_MIN && TICK_ATT <= ACT_MAX) {
if (TICK_REC[1, 2] > 1) {
TICK_REC[1, 2] = TICK_REC[1, 2] - 1;
} else {
nrf0 = 8;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}
} else {
nrf0 = 9;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
/* ** */
}
void L1300() {
/*  Amend a field */
/* ** */
if (WNDO_STA > 1) {
TICK_ATT = USER_ACTION + WNDO_STA;
TICK_ATT = TICK_ATT - 1;
} else {
TICK_ATT = USER_ACTION;
}
TICK_LINE = TICK_REC[TICK_ATT];
DISPLAY_ONLY = TRUE;
L2000();
/*  Display Details */
DISPLAY_ONLY = FALSE;
L2000();
/*  Get/Amend Details */
if (FINISHED == TRUE) {
return;
}
TICK_REC[TICK_ATT] = TICK_LINE;
return;
/* ** */
}
void L2000() {
/*  Amend/Insert Record Line */
/* ** */
if (DISPLAY_ONLY == TRUE) {
for(CLRLOOP = WNDO_REC[1]; CLRLOOP <= WNDO_REC[2]; CLRLOOP += 1) {
PRINTCR(AT(0, CLRLOOP) + NRM_VID + COMMON.EOL);
}
}
FLD_CNT = 1;
ANSWER = "";
do {
if (WNDO_REC[FLD_CNT + 10] == "" || FINISHED) break;
FLD_LEN = WNDO_REC[FLD_CNT + 10, 5];
WNDO_JUST = WNDO_REC[FLD_CNT + 10, 8] + "#" + FLD_LEN;
if (FLD_LEN == "") {
VALID_INPUT = TRUE;
} else {
ANSWER = "";
VALID_INPUT = FALSE;
}
SCR_XPOS = WNDO_REC[3] + 1;
SCR_YPOS = WNDO_REC[FLD_CNT + 10, 2];
do {
if (VALID_INPUT || FINISHED) break;
if (TICK_LINE[1, FLD_CNT] == "") {
PRINTCR(AT(SCR_XPOS, SCR_YPOS) + WNDO_REC[FLD_CNT + 10, 3] + STR(".", FLD_LEN));
} else {
PRINTCR(AT(SCR_XPOS, SCR_YPOS) + WNDO_REC[FLD_CNT + 10, 3] + FORMAT(TICK_LINE[1, FLD_CNT], WNDO_JUST));
}
if (DISPLAY_ONLY == FALSE) {
WNDO_PRMPT_LEN = LEN(WNDO_REC[FLD_CNT + 10, 3]);
PRINT(AT(SCR_XPOS + WNDO_PRMPT_LEN, SCR_YPOS));
nrf0 = FLD_LEN + 1;
FL019 = new FL019(ref nrf0, ref ANSWER);
// BEGIN CASE
// CASE
if (ANSWER == COMMON.ABANDON) {
FINISHED = TRUE;
VALID_INPUT = TRUE;
}// CASE
else if (ANSWER == COMMON.CLR) {
VALID_INPUT = TRUE;
TICK_LINE[1, FLD_CNT] = "";
}// CASE
else if (ANSWER == COMMON.BACK) {
VALID_INPUT = TRUE;
}// CASE
else if (ANSWER == "") {
VALID_INPUT = TRUE;
}// CASE
else if (OTHERWISE) {
/*  Validate Answer */
VALID_INPUT = FALSE;
#region ON WNDO_REC[FLD_CNT + 10, 4] GOSUB ...
switch ((int)WNDO_REC[FLD_CNT + 10, 4]) {
case 1: L2100(); break;
case 2: L2200(); break;
case 3: L2300(); break;
case 4: L2400(); break;
case 5: L2500(); break;
case 6: L2600(); break;
case 7: L2700(); break;
case 8: L2800(); break;
case 9: L2900(); break;
case 10: L2910(); break;
}
#endregion
if (VALID_INPUT == TRUE) {
TICK_LINE[1, FLD_CNT] = ANSWER;
} else {
nrf0 = 12;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
// END CASE
PRINTCR(AT(SCR_XPOS + WNDO_PRMPT_LEN, SCR_YPOS) + FORMAT(TICK_LINE[1, FLD_CNT], WNDO_JUST));
} else {
VALID_INPUT = TRUE;
}
} while (true);
if (ANSWER == COMMON.BACK) {
if (FLD_CNT > 1) {
FLD_CNT = FLD_CNT - 1;
} else {
nrf0 = 3;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
FLD_CNT = FLD_CNT + 1;
}
} while (true);
/* ** */
/*  This subroutine uses the format positioning to prompt for details */
return;
/* ** */
/* ********************************************************* */
/*  VALIDATION ROUTINES, CALLED ACCORDING TO VALUE 4 OF FL.SCREENS */
/* *************************************************************** */
}
void L2100() {
/*  Ticket Line */
if (MATCH(ANSWER,"0N") && ANSWER >= 1) {
VALID_INPUT = TRUE;
}
return;
}
void L2200() {
/*  Font */
if (MATCH(ANSWER,"0N") && ANSWER >= 1) {
VALID_INPUT = TRUE;
}
return;
}
void L2300() {
/*  Description */
VALID_INPUT = TRUE;
return;
}
void L2400() {
/*  Optional */
if (ANSWER == "O" || ANSWER == "Y") {
ANSWER = "O";
VALID_INPUT = TRUE;
}
if (ANSWER == "N") {
ANSWER = "";
VALID_INPUT = TRUE;
}
return;
}
void L2500() {
/*  Activity Info */
if (ANSWER == "?") {
COMMON.HELP = "";
for(HCNT = 1; HCNT <= DCOUNT(VALID_ACTIVITIES, AM); HCNT += 1) {
COMMON.HELP[HCNT] = FORMAT(HCNT, "R#3") + " " + VALID_ACTIVITIES[HCNT];
}
nrf0 = 1;
FL150 = new FL150(ref HELP_REC, ref COMMON.HELP, ref nrf0, ref HELP_ACTION, ref PROGRAM, ref DISPLAY_ONLY);
HELP_SPC = SPACE(HELP_REC[4] - HELP_REC[3] + 1);
for(CLR_HELP = HELP_REC[1]; CLR_HELP <= HELP_REC[2]; CLR_HELP += 1) {
PRINT(AT(HELP_REC[3], CLR_HELP) + HELP_SPC);
}
if (MATCH(HELP_ACTION,"0N")) {
ANSWER = VALID_ACTIVITIES[HELP_ACTION];
}
}
if (LOCATE(ANSWER, VALID_ACTIVITIES, 0, 0, 1, ref POS, "AL")) {
VALID_INPUT = TRUE;
}
return;
}
void L2600() {
/*  File Attribute */
VALID_INPUT = TRUE;
return;
}
void L2700() {
/*  Conversion */
VALID_INPUT = TRUE;
return;
}
void L2800() {
/*  Justification */
VALID_INPUT = TRUE;
return;
}
void L2900() {
/*  Part of ACTIVITY */
ACT_MIN = TICK_REC[1, 1];
ACT_MAX = TICK_REC[1, 2] + ACT_MIN;
ACT_MAX = ACT_MAX - 1;
// BEGIN CASE
// CASE
if (ANSWER == "") {
ANSWER = "";
VALID_INPUT = TRUE;
}// CASE
else if (ANSWER == "Y") {
ANSWER = "";
VALID_INPUT = TRUE;
if (TICK_ATT >= ACT_MAX) {
TICK_REC[1, 2] = TICK_ATT - ACT_MIN + 1;
}
if (TICK_ATT < ACT_MIN) {
TICK_REC[1, 2] = ACT_MAX - TICK_ATT + 1;
TICK_REC[1, 1] = TICK_ATT;
if (USER_ACTION == "I") {
TICK_REC[1, 2] = TICK_REC[1, 2] + 2;
}
}
}// CASE
else if (ANSWER == "N" && TICK_ATT < ACT_MIN || TICK_ATT > ACT_MAX) {
VALID_INPUT = TRUE;
ANSWER = "";
}// CASE
else if (ANSWER == "N") {
ANSWER = "";
VALID_INPUT = TRUE;
if (TICK_ATT > ACT_MIN) {
TICK_REC[1, 2] = TICK_ATT - ACT_MIN;
}
if (TICK_ATT == ACT_MIN && TICK_REC[1, 2] > 1) {
TICK_REC[1, 1] = TICK_ATT + 1;
TICK_REC[1, 2] = TICK_REC[1, 2] - 1;
} else {
if (TICK_REC[1, 2] == 1) {
nrf0 = 7;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
}// CASE
else if (OTHERWISE) {
ANSWER = "";
VALID_INPUT = FALSE;
}
// END CASE
L3000();
return;
}
void L2910() {
/*  Special Program */
VALID_INPUT = TRUE;
return;
/* ** */
}
void L3000() {
/*  Modify formatting heading and options for the window if reqd. */
/* ** */
/*  This subroutine removes unwanted fields from screen record */
// BEGIN CASE
// CASE
if (TICK_TYPE == "H" || TICK_TYPE == "F") {
if (!READ(ref WNDO_REC, COMMON.FILES[FL_SCREENS], PROGRAM + ".WIN.HF")) { NULL(); }
}// CASE
else if (TICK_TYPE == "S") {
if (!READ(ref WNDO_REC, COMMON.FILES[FL_SCREENS], PROGRAM + ".WIN.S")) { NULL(); }
}// CASE
else if (OTHERWISE) {
WNDO_STA = 2;
PRINTCR(AT(2, 5) + "Activity Line made up from fields : " + TICK_REC[1, 1] - 1 + " TO " + TICK_REC[1, 2] + TICK_REC[1, 1] - 2);
}
// END CASE
return;
/* ** */
}
void L3100() {
/*  Display/Redisplay Window */
/* ** */
NUMATTS = DCOUNT(TICK_REC, AM);
/* - */
/*  Make sure that Window only contains desired attribute range */
/* - */
if (WNDO_END > 0 && WNDO_END < NUMATTS) {
NUMATTS = WNDO_END;
}
if (WNDO_STA == "") {
WNDO_STA = 1;
}
WNDO_LIST = "";
WNDO_LIST_ATT = 1;
for(ATTCNT = WNDO_STA; ATTCNT <= NUMATTS; ATTCNT += 1) {
ACTIVITY_FLAG = "  ";
/*  Check for Activity Field (casuals, receipts and Bookings) */
if (TICK_TYPE == "C" || TICK_TYPE == "B" || TICK_TYPE == "R") {
if (ATTCNT >= TICK_REC[1, 1] && ATTCNT < TICK_REC[1, 1] + TICK_REC[1, 2]) {
ACTIVITY_FLAG = "* ";
}
}
WNDO_LIST[WNDO_LIST_ATT] = FORMAT(WNDO_LIST_ATT, "R#3") + ACTIVITY_FLAG;
VMCNT = 1;
do {
if (WNDO_REC[VMCNT + 10] == "") break;
if (WNDO_REC[VMCNT + 10, 5] != "") {
if (WNDO_REC[VMCNT + 10, 14] != "") {
WNDO_JUST = WNDO_REC[VMCNT + 10, 8] + "#" + WNDO_REC[VMCNT + 10, 14];
} else {
WNDO_JUST = WNDO_REC[VMCNT + 10, 8] + "#" + WNDO_REC[VMCNT + 10, 5];
}
WNDO_LINE_LEN = LEN(WNDO_LIST[WNDO_LIST_ATT]) + 1;
WNDO_PADDING = SPACE(WNDO_REC[VMCNT + 10, 1] - WNDO_LINE_LEN);
WNDO_LIST[WNDO_LIST_ATT] = WNDO_LIST[WNDO_LIST_ATT] + WNDO_PADDING + FORMAT(TICK_REC[ATTCNT, VMCNT], WNDO_JUST);
}
VMCNT = VMCNT + 1;
} while (true);
WNDO_LIST_ATT = WNDO_LIST_ATT + 1;
}
FL150 = new FL150(ref WNDO_REC, ref WNDO_LIST, ref WNDO_POS, ref USER_ACTION, ref PROGRAM, ref DISPLAY_ONLY);
return;
/* * */
}
void L5000() {
/* * */
/*  FILE RECORD IF REQUIRED */
/* ** */
WRITE(TICK_REC, COMMON.FILES[FL_TICKET_CONTROL], TICKET_TYPE_ID);
FINISHED = TRUE;
return;
}
}
}
