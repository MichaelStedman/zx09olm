//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL285 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar TICKET_REC = "";
UvVar BONUS_REDEEM_REC = "";
UvVar TICKET_CODE = "";
UvVar CODE_FEE = "";
UvVar NUMB = "";
UvVar CODE_CONCESS = "";
UvVar PERIOD = "";
UvVar MEMBER_NO = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar CODE_POS = "";
UvVar RED_POS = "";
UvVar REDEMPTION_CODE = "";
#endregion
public FL285(ref UvVar TICKET_REC, ref UvVar BONUS_REDEEM_REC, ref UvVar TICKET_CODE, ref UvVar CODE_FEE, ref UvVar NUMB, ref UvVar CODE_CONCESS, ref UvVar PERIOD, ref UvVar MEMBER_NO) {
this.TICKET_REC = TICKET_REC;
this.BONUS_REDEEM_REC = BONUS_REDEEM_REC;
this.TICKET_CODE = TICKET_CODE;
this.CODE_FEE = CODE_FEE;
this.NUMB = NUMB;
this.CODE_CONCESS = CODE_CONCESS;
this.PERIOD = PERIOD;
this.MEMBER_NO = MEMBER_NO;
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
/*   Update of TICKET.REC where bonus redemption has occurred ' */
/* ********************************************************************* */
PROGRAM = "FL285";
CODE_POS = DCOUNT(TICKET_REC[1], VM) + 1;
/* RED.POS = CODE.POS */
if (LOCATE(TICKET_CODE, BONUS_REDEEM_REC, 1, 0, 1, ref RED_POS, "AL")) {
do {
REDEMPTION_CODE = BONUS_REDEEM_REC[1, RED_POS];
if (REDEMPTION_CODE == "") break;
if (NOT(BONUS_REDEEM_REC[10, RED_POS])) {
TICKET_REC[1, CODE_POS] = TICKET_CODE;
TICKET_REC[2, CODE_POS] = 1;
TICKET_REC[3, CODE_POS] = CODE_FEE - BONUS_REDEEM_REC[4, RED_POS];
TICKET_REC[10, CODE_POS] = MEMBER_NO;
TICKET_REC[11, CODE_POS] = PERIOD;
TICKET_REC[13, CODE_POS] = CODE_CONCESS;
TICKET_REC[25, CODE_POS] = BONUS_REDEEM_REC[2, RED_POS];
TICKET_REC[27, CODE_POS] = BONUS_REDEEM_REC[4, RED_POS];
TICKET_REC[28, CODE_POS] = BONUS_REDEEM_REC[5, RED_POS];
BONUS_REDEEM_REC[10, RED_POS] = TRUE;
NUMB = NUMB - 1;
CODE_POS = CODE_POS + 1;
}
RED_POS = RED_POS + 1;
} while (true);
}
if (NUMB != 0) {
TICKET_REC[1, CODE_POS] = TICKET_CODE;
TICKET_REC[2, CODE_POS] = NUMB;
TICKET_REC[3, CODE_POS] = CODE_FEE - BONUS_REDEEM_REC[4, RED_POS];
/*         TICKET.REC<3,CODE.POS> = CODE.FEE */
TICKET_REC[10, CODE_POS] = MEMBER_NO;
TICKET_REC[11, CODE_POS] = PERIOD;
TICKET_REC[13, CODE_POS] = CODE_CONCESS;
}
return;
}
}
}
