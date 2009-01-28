//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL427 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_UNBOOKED = 27;
readonly UvVar UNBOOKED_DURATION = 1;
readonly UvVar FL_SPORTS = 23;
readonly UvVar SPORTS_DESC = 1;
readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
readonly UvVar SPORTS_CODE1 = 3;
readonly UvVar SPORTS_CODE2 = 4;
readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
readonly UvVar SPORTS_TYPE = 6;
readonly UvVar SPORTS_BOOK_OR_CAS = 7;
readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
readonly UvVar SPORTS_RESTRICTION_CODE = 9;
readonly UvVar SPORTS_PERSON_BOOKING = 10;
readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
readonly UvVar SPORTS_SETUP_TIME = 12;
readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
readonly UvVar SPORTS_PLAYERS = 14;
readonly UvVar SPORTS_ADMINISTRATOR = 15;
readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
readonly UvVar SPORTS_VISIBILITY = 17;
readonly UvVar SPORTS_SUB_LIST = 18;
readonly UvVar SPORTS_TOP_LEVEL = 19;
readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] UNBOOKED_REC = new UvVar[150];
UvVar[] SPORTS_REC = new UvVar[25];
#endregion
#region Variables
UvVar INTERACT = "";
UvVar SP_CODE1 = "";
UvVar SP_CODE2 = "";
UvVar WR_DATE = "";
UvVar WR_DATE2 = "";
UvVar UNBK_REC = "";
UvVar UNBK_REC2 = "";
UvVar UNBK_REC_SAVED1 = "";
UvVar UNBK_REC_SAVED2 = "";
UvVar REC1 = "";
UvVar RECORD = "";
UvVar ENTRY_TIME = "";
UvVar SP_BOOKING_LEEWAY = "";
UvVar DAY = "";
UvVar DAY2 = "";
UvVar TODAYS_DATE = "";
UvVar PROGRAM = "";
UvVar TWINK = "";
UvVar BOOK_ID = "";
UvVar DURA1 = "";
UvVar BOOK_ID2 = "";
UvVar DURA2 = "";
UvVar NO_OF_ATTS = "";
UvVar TIME_CHECK = "";
#endregion
public FL427(ref UvVar INTERACT, ref UvVar SP_CODE1, ref UvVar SP_CODE2, ref UvVar WR_DATE, ref UvVar WR_DATE2, ref UvVar UNBK_REC, ref UvVar UNBK_REC2, ref UvVar UNBK_REC_SAVED1, ref UvVar UNBK_REC_SAVED2, ref UvVar REC1, ref UvVar RECORD, ref UvVar ENTRY_TIME, ref UvVar SP_BOOKING_LEEWAY, ref UvVar DAY, ref UvVar DAY2) {
this.INTERACT = INTERACT;
this.SP_CODE1 = SP_CODE1;
this.SP_CODE2 = SP_CODE2;
this.WR_DATE = WR_DATE;
this.WR_DATE2 = WR_DATE2;
this.UNBK_REC = UNBK_REC;
this.UNBK_REC2 = UNBK_REC2;
this.UNBK_REC_SAVED1 = UNBK_REC_SAVED1;
this.UNBK_REC_SAVED2 = UNBK_REC_SAVED2;
this.REC1 = REC1;
this.RECORD = RECORD;
this.ENTRY_TIME = ENTRY_TIME;
this.SP_BOOKING_LEEWAY = SP_BOOKING_LEEWAY;
this.DAY = DAY;
this.DAY2 = DAY2;
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
/*  Get Unbooked Records */
/*  old prog num was FL0001.3.1.1.UNBOOK */
PROGRAM = "FL427";
PROMPT("");
/* ********************************* */
/*  Define Files */
/* ********************************* */
#region INCLUDE FL.FILES FL.UNBOOKED
#region INCLUDE FL.FILES FL.UNBOOKED.EQU

#endregion

#region INCLUDE FL.FILES FL.UNBOOKED.DIM

#endregion
#region INCLUDE FL.FILES FL.UNBOOKED.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.SPORTS
#region INCLUDE FL.FILES FL.SPORTS.EQU

#endregion

#region INCLUDE FL.FILES FL.SPORTS.DIM

#endregion
#region INCLUDE FL.FILES FL.SPORTS.VAR

/*  Introduced for Warrington: */

#endregion

#endregion
/* ********************************* */
/*  Initialize Variables */
/* ********************************* */
TWINK = "*";
INTERACT = "";
/* ********************************* */
/*  Main Process */
/* ********************************* */
BOOK_ID = COMMON.CENTRE + TWINK + SP_CODE1 + TWINK + WR_DATE;
if (!(READ(ref UNBK_REC, COMMON.FILES[FL_UNBOOKED], BOOK_ID))) {
UNBK_REC = "";
/*         CALL FL006(PROGRAM,7,'') */
/*         INTERACT = ABANDON */
/*         GO 99 */
}
DURA1 = UNBK_REC[1, 1];
UNBK_REC = DELETE(UNBK_REC, 1, 0, 0);
if (SP_CODE2 == "") {
BOOK_ID2 = COMMON.CENTRE + TWINK + SP_CODE1 + TWINK + WR_DATE2;
} else {
BOOK_ID2 = COMMON.CENTRE + TWINK + SP_CODE2 + TWINK + WR_DATE;
}
if (!READ(ref UNBK_REC2, COMMON.FILES[FL_UNBOOKED], BOOK_ID2)) { UNBK_REC2 = INIT; }
DURA2 = UNBK_REC2[1, 1];
UNBK_REC2 = DELETE(UNBK_REC2, 1, 0, 0);
DAY = MOD(WR_DATE, 7);
if (DAY == 0) { DAY = 7; }
DAY2 = MOD(WR_DATE2, 7);
if (DAY2 == 0) { DAY2 = 7; }
if (WR_DATE == TODAYS_DATE) {
UNBK_REC_SAVED1 = UNBK_REC;
NO_OF_ATTS = DCOUNT(UNBK_REC, CHAR(254));
for(TIME_CHECK = 1; TIME_CHECK <= NO_OF_ATTS; TIME_CHECK += 1) {
if (UNBK_REC[TIME_CHECK, 2] < (ENTRY_TIME - SP_BOOKING_LEEWAY)) {
UNBK_REC = DELETE(UNBK_REC, TIME_CHECK, 0, 0);
TIME_CHECK = TIME_CHECK - 1;
NO_OF_ATTS = NO_OF_ATTS - 1;
}
}
if (SP_CODE2 != "") {
UNBK_REC_SAVED2 = UNBK_REC2;
NO_OF_ATTS = DCOUNT(UNBK_REC2, CHAR(254));
for(TIME_CHECK = 1; TIME_CHECK <= NO_OF_ATTS; TIME_CHECK += 1) {
if (UNBK_REC2[TIME_CHECK, 2] < (ENTRY_TIME - SP_BOOKING_LEEWAY)) {
UNBK_REC2 = DELETE(UNBK_REC2, TIME_CHECK, 0, 0);
TIME_CHECK = TIME_CHECK - 1;
NO_OF_ATTS = NO_OF_ATTS - 1;
}
}
}
}
if (REC1 == TRUE) {
RECORD = UNBK_REC;
} else {
RECORD = UNBK_REC2;
}
L99:;
return;
/* **************************** */
/*  END OF PROGRAM */
/* **************************** */
}
}
}
