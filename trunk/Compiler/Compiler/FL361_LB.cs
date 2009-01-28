//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL361_LB : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CONTROL = 10;
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
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar CC_NO = "";
UvVar CC_EXP = "";
UvVar AUTO_RESPONSE = "";
UvVar TODAYS_DATE = "";
UvVar CC_REF = "";
UvVar CC_REF2 = "";
FL362 FL362;
UvVar RET_FUNC = "";
UvVar EXPIRY = "";
UvVar DUMMY_EXP = "";
UvVar EXP_YEAR = "";
UvVar ACT_EXP = "";
UvVar TODAYS_ODATE = "";
UvVar CURRENT_MONTH = "";
UvVar CURRENT_YEAR = "";
UvVar CURRENT_DAY = "";
#endregion
public FL361_LB(ref UvVar CC_NO, ref UvVar CC_EXP, ref UvVar AUTO_RESPONSE) {
this.CC_NO = CC_NO;
this.CC_EXP = CC_EXP;
this.AUTO_RESPONSE = AUTO_RESPONSE;
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
/*  READS CC.REF (FROM MAG STRIPE READER) */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
INPUT(out CC_REF, 22);
if (NOT(INDEX(CC_REF, "=", 1))) {
CC_NO = CC_REF;
AUTO_RESPONSE = 0;
/*  NOT A SWIPED CARD */
return;
}
ECHO_OFF();
INPUTCR(out CC_REF2);
ECHO_ON();
CC_REF = CC_REF + CC_REF2;
if (CC_REF.Substring(1, 1) == "%") {
CC_REF = FIELD(CC_REF, "?", 2);
}
CC_NO = FIELD(CC_REF, "=", 1);
CC_NO = OCONV(CC_NO, "MCN");
FL362 = new FL362(ref CC_NO, ref RET_FUNC);
if (RET_FUNC == INVALID_DATA) {
AUTO_RESPONSE = 2;
/*  INVALID CHECK DIGIT */
return;
}
EXPIRY = FIELD(CC_REF, "=", 2).Substring(1, 4);
/*  USES PICK'S IN BUILT YEAR CONVERSION TO GET LIKELY CC EXPIRY DATE */
DUMMY_EXP = "1/" + EXPIRY.Substring(3, 2) + "/" + EXPIRY.Substring(1, 2);
EXP_YEAR = OCONV(ICONV(DUMMY_EXP, "D"), "DY");
ACT_EXP = EXP_YEAR + EXPIRY.Substring(3, 2);
TODAYS_ODATE = OCONV(TODAYS_DATE, "D4/");
CURRENT_MONTH = TODAYS_ODATE.Substring(4, 2);
CURRENT_YEAR = TODAYS_ODATE.Substring(7, 4);
CURRENT_DAY = CURRENT_YEAR + CURRENT_MONTH;
if (ACT_EXP < CURRENT_DAY) {
AUTO_RESPONSE = 3;
/*  CARD EXPIRED */
return;
}
CC_EXP = EXPIRY.Substring(3, 2) + EXPIRY.Substring(1, 2);
AUTO_RESPONSE = 1;
/*  VALID CARD & EXPIRY */
return;
}
}
}
