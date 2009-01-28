//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL126_CALL : UvBase
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
UvVar PROGRAM = "";
UvVar IDENTIFIER = "";
UvVar TYPE = "";
FL126 FL126;
#endregion
public FL126_CALL() {
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
/*  Routine Tto call Rejects from Menu */
PROGRAM = "FL126.CALL";
IDENTIFIER = "";
TYPE = "";
FL126 = new FL126(ref TYPE, ref IDENTIFIER, ref PROGRAM);
return;
}
}
}
