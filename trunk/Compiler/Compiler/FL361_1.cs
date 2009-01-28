//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL361_1 : UvBase
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
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CC_REF = "";
UvVar CC_EXP = "";
UvVar RET_FUNC = "";
UvVar CLIENT_APP_TYPE = "";
UvVar PROGRAM = "";
FL019 FL019;
FL361_LB FL361_LB;
UvVar AUTO_RESPONSE = "";
FL006 FL006;
FL362 FL362;
UvVar VALUE1 = "";
UvVar EXP_MONTH = "";
UvVar EXP_YEAR = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL361_1(ref UvVar CC_REF, ref UvVar CC_EXP, ref UvVar RET_FUNC) {
this.CC_REF = CC_REF;
this.CC_EXP = CC_EXP;
this.RET_FUNC = RET_FUNC;
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
/*  Credit Card Subroutine */
PROMPT("");
PROGRAM = "FL361.1";
/* ******************************** */
/*   Initialize Variables         * */
/* ******************************** */
/* ******************************** */
/*  Main Process                  * */
/* ******************************** */
/* !*CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
PRINT(AT(3, 23) + SPACE(74));
do {
if (RET_FUNC == VALID_DATA || CC_REF == COMMON.ABANDON) break;
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINT(CHAR(28) + "404");
PRINTCR("Credit Card Ref ");
PRINTCR("....................");
PRINTCR(CHAR(20));
} else {
PRINT(AT(3, 23) + "Credit Card Ref ");
PRINT(AT(20, 23) + STR(".", 20));
PRINT(AT(20, 23));
}
/*  CHANGE TO ACCOMODATE SWIPE CARDS */
/*         CALL FL019(21,CC.REF) */
FL361_LB = new FL361_LB(ref CC_REF, ref CC_EXP, ref AUTO_RESPONSE);
if (AUTO_RESPONSE) {
// BEGIN CASE
// CASE
if (AUTO_RESPONSE == 1) {
RET_FUNC = VALID_DATA;
}// CASE
else if (AUTO_RESPONSE == 2) {
RET_FUNC = COMMON.ABANDON;
nrf0 = 111;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref CC_REF);
}// CASE
else if (AUTO_RESPONSE == 3) {
RET_FUNC = COMMON.ABANDON;
nrf0 = 112;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref CC_EXP);
}
// END CASE
return;
}
if (CC_REF.Substring(1, 1) == ";") { CC_REF = CC_REF.Substring(2, LEN(CC_REF) - 1); }
if (CC_REF == COMMON.ABANDON) {
RET_FUNC = COMMON.ABANDON;
} else {
FL362 = new FL362(ref CC_REF, ref RET_FUNC);
if (RET_FUNC == INVALID_DATA) {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
} while (true);
if (CC_REF == COMMON.ABANDON) { goto L999; }
VALUE1 = CC_REF;
PRINT(AT(20, 23) + FORMAT(VALUE1, "L#21"));
/*  Expiry Date */
RET_FUNC = INVALID_DATA;
do {
if (RET_FUNC == VALID_DATA || CC_EXP == COMMON.ABANDON) break;
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINT(CHAR(28) + "404");
PRINTCR("Credit Card Expiry ");
PRINTCR("....");
PRINTCR(CHAR(20));
} else {
PRINT(AT(41, 23) + "Credit Card Expiry ");
PRINT(AT(60, 23) + STR(".", 4));
PRINT(AT(60, 23));
}
nrf0 = 5;
FL019 = new FL019(ref nrf0, ref CC_EXP);
if (CC_EXP == COMMON.ABANDON) {
RET_FUNC = COMMON.ABANDON;
} else {
if (NOT(MATCH(CC_EXP,"4N"))) {
RET_FUNC = INVALID_DATA;
nrf0 = 9;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
EXP_MONTH = CC_EXP.Substring(1, 2);
EXP_YEAR = CC_EXP.Substring(3, 2);
if ((EXP_MONTH < 01 || EXP_MONTH > 12)) {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
RET_FUNC = INVALID_DATA;
} else {
/*                  CURRENT.DATE = OCONV(TODAYS.DATE,'D2/') */
/*                  CURRENT.YEAR = CURRENT.DATE[7,2]:CURRENT.DATE[4,2] */
/*                  IF EXP.YEAR:EXP.MONTH < CURRENT.YEAR THEN */
/*                     CALL FL006(PROGRAM,77,'') */
/*                     RET.FUNC = INVALID.DATA */
/*                  END ELSE */
RET_FUNC = VALID_DATA;
PRINT(AT(60, 23) + CC_EXP);
/*                  END */
}
}
}
} while (true);
L999:;
return;
}
}
}
