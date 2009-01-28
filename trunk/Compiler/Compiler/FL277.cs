//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL277 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar BONUS_MEMBER = 1;
readonly UvVar BONUS_SCHEME = 2;
readonly UvVar BONUS_DATE_JOINED = 3;
readonly UvVar BONUS_MONTH = 4;
readonly UvVar BONUS_POINTS = 5;
readonly UvVar BONUS_SPEND = 6;
readonly UvVar BONUS_REDEEMED = 7;
readonly UvVar BONUS_VALUE_REDEEMED = 8;
readonly UvVar BONUS_NET_POINTS = 9;
readonly UvVar BONUS_LAST_ALLOCATION_DATE = 10;
readonly UvVar BONUS_LAST_ALLOCATION_TIME = 11;
readonly UvVar BONUS_DECLINED_REDEMPTIONS = 12;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BONUS_REC = new UvVar[40];
#endregion
#region Variables
UvVar REDEMPTION_REC = "";
UvVar TOTAL_REDEMPTION_VALUE = "";
UvVar TOTAL_POINTS_REDEEMED = "";
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar EXEC_PROG = "";
UvVar FL_BONUS = "";
UvVar PREVIOUS_CODE = "";
UvVar AMOUNT_REDEEMED = "";
UvVar POINTS_REDEEMED = "";
UvVar BONUS_ID = "";
UvVar NO_OF_REDEMPTIONS = "";
UvVar MONTH = "";
UvVar REDEMPTION = "";
UvVar POS = "";
UvVar VALUE_REDEEMED = "";
UvVar DECLINED_POS = "";
UvVar DECLINED_FLAG = "";
#endregion
public FL277(ref UvVar REDEMPTION_REC, ref UvVar TOTAL_REDEMPTION_VALUE, ref UvVar TOTAL_POINTS_REDEEMED) {
this.REDEMPTION_REC = REDEMPTION_REC;
this.TOTAL_REDEMPTION_VALUE = TOTAL_REDEMPTION_VALUE;
this.TOTAL_POINTS_REDEEMED = TOTAL_POINTS_REDEEMED;
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
/*  Bonus Redemption - update of files */
/*  Written :  Harjas Sidhu */
/*  Dated   :  August 99 */
/* ********************************************************************* */
PROGRAM = "FL277";
EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Files */
#region INCLUDE FL.FILES FL.BONUS
#region INCLUDE FL.FILES FL.BONUS.EQU
if (!OPEN("FL.BONUS", out FL_BONUS)) { STOP("201", "FL.BONUS"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.VAR

#endregion

#endregion
/*  Variables */
PREVIOUS_CODE = "";
AMOUNT_REDEEMED = 0;
POINTS_REDEEMED = 0;
TOTAL_REDEMPTION_VALUE = 0;
TOTAL_POINTS_REDEEMED = 0;
BONUS_ID = "";
NO_OF_REDEMPTIONS = DCOUNT(REDEMPTION_REC[1], VM);
MONTH = OCONV(TODAYS_DATE, "DY") + FORMAT(OCONV(TODAYS_DATE, "DM"), "R%2");
for(REDEMPTION = 1; REDEMPTION <= NO_OF_REDEMPTIONS; REDEMPTION += 1) {
if (NOT(REDEMPTION_REC[3, REDEMPTION] == "" || REDEMPTION_REC[2, REDEMPTION] == "")) {
BONUS_ID = REDEMPTION_REC[3, REDEMPTION] + "*" + REDEMPTION_REC[2, REDEMPTION];
if (!(MATREADU(ref BONUS_REC, FL_BONUS, BONUS_ID))) {
MAT(ref BONUS_REC, "");
}
if (!(LOCATE(MONTH, BONUS_REC[BONUS_MONTH], 1, 0, 1, ref POS, "AR"))) {
BONUS_REC[BONUS_MONTH] = INSERT(BONUS_REC[BONUS_MONTH], 1, POS, 0, MONTH);
BONUS_REC[BONUS_POINTS] = INSERT(BONUS_REC[BONUS_POINTS], 1, POS, 0, "");
BONUS_REC[BONUS_SPEND] = INSERT(BONUS_REC[BONUS_SPEND], 1, POS, 0, "");
BONUS_REC[BONUS_REDEEMED] = INSERT(BONUS_REC[BONUS_REDEEMED], 1, POS, 0, "");
VALUE_REDEEMED = INSERT(BONUS_REC[BONUS_VALUE_REDEEMED], 1, POS, 0, "");
}
POINTS_REDEEMED = REDEMPTION_REC[5, REDEMPTION];
AMOUNT_REDEEMED = REDEMPTION_REC[4, REDEMPTION];
BONUS_REC[BONUS_REDEEMED][1, POS] = BONUS_REC[BONUS_REDEEMED][1, POS] + POINTS_REDEEMED;
BONUS_REC[BONUS_VALUE_REDEEMED][1, POS] = BONUS_REC[BONUS_VALUE_REDEEMED][1, POS] + AMOUNT_REDEEMED;
BONUS_REC[BONUS_NET_POINTS] = BONUS_REC[BONUS_NET_POINTS] - POINTS_REDEEMED;
TOTAL_REDEMPTION_VALUE = TOTAL_REDEMPTION_VALUE + AMOUNT_REDEEMED;
TOTAL_POINTS_REDEEMED = TOTAL_POINTS_REDEEMED + POINTS_REDEEMED;
/* * */
if (REDEMPTION_REC[12] != "") {
DECLINED_POS = REDEMPTION_REC[12].Substring(1, 1);
DECLINED_FLAG = REDEMPTION_REC[12].Substring(2, 1);
BONUS_REC[BONUS_DECLINED_REDEMPTIONS][1, DECLINED_POS] = DECLINED_FLAG;
} else {
BONUS_REC[BONUS_DECLINED_REDEMPTIONS] = "";
}
/* * */
MATWRITE(BONUS_REC, FL_BONUS, BONUS_ID);
}
}
return;
}
}
}
