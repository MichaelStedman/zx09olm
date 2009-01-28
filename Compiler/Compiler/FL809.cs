//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL809 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_BLOCK_HEADER = 87;
readonly UvVar BLOCK_SDESC = 1;
readonly UvVar BLOCK_STIME = 2;
readonly UvVar BLOCK_ETIME = 3;
readonly UvVar BLOCK_SPORT = 4;
readonly UvVar BLOCK_FLOORS1 = 5;
readonly UvVar BLOCK_FLOORS2 = 6;
readonly UvVar BLOCK_FLOORS3 = 7;
readonly UvVar BLOCK_DATES1 = 8;
readonly UvVar BLOCK_DATES2 = 9;
readonly UvVar BLOCK_DATES3 = 10;
readonly UvVar BLOCK_PRICE_REF = 11;
readonly UvVar BLOCK_LETTER = 12;
readonly UvVar BLOCK_INSTALL = 13;
readonly UvVar BLOCK_START = 14;
readonly UvVar BLOCK_FREQUENCY = 15;
readonly UvVar BLOCK_NO_INSTALLS = 16;
readonly UvVar BLOCK_NOTES = 17;
readonly UvVar BLOCK_DATE_MADE = 18;
readonly UvVar BLOCK_USER = 19;
readonly UvVar BLOCK_DEALER = 20;
readonly UvVar BLOCK_FLOORS4 = 21;
readonly UvVar BLOCK_FLOORS5 = 22;
readonly UvVar BLOCK_FLOORS6 = 23;
readonly UvVar BLOCK_FLOORS7 = 24;
readonly UvVar BLOCK_DATES4 = 25;
readonly UvVar BLOCK_DATES5 = 26;
readonly UvVar BLOCK_DATES6 = 27;
readonly UvVar BLOCK_DATES7 = 28;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BLOCK_REC = new UvVar[30];
#endregion
#region Variables
UvVar VM = "";
UvVar PROGRAM = "";
UvVar DATE_FIELDS = "";
UvVar NO_OF_DATES = "";
UvVar DATE_NO = "";
UvVar ZZZ_DATE = "";
UvVar FLOORS = "";
UvVar START_TIME = "";
UvVar END_TIME = "";
FLOOR_UNLOCK FLOOR_UNLOCK;
#endregion
public FL809(ref UvVar[] BLOCK_REC) {
this.BLOCK_REC = BLOCK_REC;
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
/*  Cancel Locks */
PROGRAM = "FL809";
/* *********************************** */
/*  INCLUDE FILES */
/* *********************************** */
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
/* *********************************** */
/*  MAIN PROCESS */
/* *********************************** */
/* PRINT BLOCK.REC(8) */
/* PRINT BLOCK.REC(5) */
/* PRINT BLOCK.STIME */
/* PRINT BLOCK.ETIME */
/*  Dates on Pages 1 - 3 */
for(DATE_FIELDS = 1; DATE_FIELDS <= 3; DATE_FIELDS += 1) {
NO_OF_DATES = DCOUNT(BLOCK_REC[DATE_FIELDS + 7][1], VM);
for(DATE_NO = 1; DATE_NO <= NO_OF_DATES; DATE_NO += 1) {
ZZZ_DATE = BLOCK_REC[DATE_FIELDS + 7][1, DATE_NO];
FLOORS = BLOCK_REC[DATE_FIELDS + 4][1];
START_TIME = BLOCK_REC[BLOCK_STIME][1, DATE_FIELDS];
END_TIME = BLOCK_REC[BLOCK_ETIME][1, DATE_FIELDS];
FLOOR_UNLOCK = new FLOOR_UNLOCK(ref FLOORS, ref ZZZ_DATE, ref START_TIME, ref END_TIME);
}
}
/*  Dates on Pages 4 - 7 */
for(DATE_FIELDS = 1; DATE_FIELDS <= 4; DATE_FIELDS += 1) {
NO_OF_DATES = DCOUNT(BLOCK_REC[DATE_FIELDS + 24][1], VM);
for(DATE_NO = 1; DATE_NO <= NO_OF_DATES; DATE_NO += 1) {
ZZZ_DATE = BLOCK_REC[DATE_FIELDS + 24][1, DATE_NO];
FLOORS = BLOCK_REC[DATE_FIELDS + 20][1];
START_TIME = BLOCK_REC[BLOCK_STIME][1, DATE_FIELDS + 3];
END_TIME = BLOCK_REC[BLOCK_ETIME][1, DATE_FIELDS + 3];
FLOOR_UNLOCK = new FLOOR_UNLOCK(ref FLOORS, ref ZZZ_DATE, ref START_TIME, ref END_TIME);
}
}
return;
/* *********************************** */
/*  END OF PROGRAM */
/* *********************************** */
}
}
}
