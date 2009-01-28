//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL795 : UvBase
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
UvVar MEMBER_NO = "";
UvVar ORIGINAL_POINTS_REDEEMED = "";
UvVar ORIGINAL_VALUE_REDEEMED = "";
UvVar PROMOTION = "";
UvVar TODAYS_DATE = "";
UvVar TRANS_LOG_REC = "";
UvVar FL_BONUS = "";
UvVar BONUS_ID = "";
UvVar MONTH = "";
UvVar BON_POS = "";
UvVar VALUE_REDEEMED = "";
FLTX2 FLTX2;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL795(ref UvVar MEMBER_NO, ref UvVar ORIGINAL_POINTS_REDEEMED, ref UvVar ORIGINAL_VALUE_REDEEMED, ref UvVar PROMOTION) {
this.MEMBER_NO = MEMBER_NO;
this.ORIGINAL_POINTS_REDEEMED = ORIGINAL_POINTS_REDEEMED;
this.ORIGINAL_VALUE_REDEEMED = ORIGINAL_VALUE_REDEEMED;
this.PROMOTION = PROMOTION;
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
/*  Reverse bonus redemption ( courses) */
#region INCLUDE FL.FILES FL.BONUS
#region INCLUDE FL.FILES FL.BONUS.EQU
if (!OPEN("FL.BONUS", out FL_BONUS)) { STOP("201", "FL.BONUS"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.VAR

#endregion

#endregion
BONUS_ID = MEMBER_NO + "*" + PROMOTION;
if (MATREADU(ref BONUS_REC, FL_BONUS, BONUS_ID)) {
MONTH = OCONV(TODAYS_DATE, "DY") + FORMAT(OCONV(TODAYS_DATE, "DM"), "R%2");
if (!(LOCATE(MONTH, BONUS_REC[BONUS_MONTH], 1, 0, 1, ref BON_POS, "AR"))) {
BONUS_REC[BONUS_MONTH] = INSERT(BONUS_REC[BONUS_MONTH], 1, BON_POS, 0, MONTH);
BONUS_REC[BONUS_POINTS] = INSERT(BONUS_REC[BONUS_POINTS], 1, BON_POS, 0, "");
BONUS_REC[BONUS_SPEND] = INSERT(BONUS_REC[BONUS_SPEND], 1, BON_POS, 0, "");
BONUS_REC[BONUS_REDEEMED] = INSERT(BONUS_REC[BONUS_REDEEMED], 1, BON_POS, 0, "");
VALUE_REDEEMED = INSERT(BONUS_REC[BONUS_VALUE_REDEEMED], 1, BON_POS, 0, "");
}
/* AWARDS ONLY*       BONUS.POINTS<1,BON.POS> = BONUS.POINTS<1,BON.POS> - ORIGINAL.BONUS.AWARD */
/* AWARDS ONLY*       BONUS.SPEND<1,BON.POS> = BONUS.SPEND<1,BON.POS> - ORIGINAL.PRICE */
BONUS_REC[BONUS_REDEEMED][1, BON_POS] = BONUS_REC[BONUS_REDEEMED][1, BON_POS] - ORIGINAL_POINTS_REDEEMED;
BONUS_REC[BONUS_VALUE_REDEEMED][1, BON_POS] = BONUS_REC[BONUS_VALUE_REDEEMED][1, BON_POS] - ORIGINAL_VALUE_REDEEMED;
BONUS_REC[BONUS_NET_POINTS] = BONUS_REC[BONUS_NET_POINTS] + ORIGINAL_POINTS_REDEEMED;
MATWRITE(BONUS_REC, FL_BONUS, BONUS_ID);
if (!READ(ref TRANS_LOG_REC, FL_BONUS, BONUS_ID)) { TRANS_LOG_REC = ""; nrf0 = "W";nrf1 = "FL.BONUS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BONUS_ID); }
}
return;
/*  End of program */
}
}
}
