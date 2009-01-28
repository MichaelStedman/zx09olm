//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL124_3 : UvBase
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
UvVar MODULE = "";
UvVar AUTHID = "";
FL133 FL133;
UvVar PROGRAM = "";
UvVar TYPE = "";
UvVar IDENTIFIER = "";
FL124 FL124;
#endregion
public FL124_3() {
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
/* ROUTINE TO START DIRECT DEBIT AMENDMENTS FROM MENU FOR MEMBERSHIPS */
/* **************************** */
/*  CHECK FOR AUTHORISED USER * */
/* **************************** */
MODULE = "DIRECT.DEBITS";
AUTHID = "BAUTH.CODE";
FL133 = new FL133(ref MODULE, ref AUTHID);
PROGRAM = "FL124.3";
TYPE = "";
IDENTIFIER = "";
FL124 = new FL124(ref TYPE, ref IDENTIFIER);
return;
}
}
}
