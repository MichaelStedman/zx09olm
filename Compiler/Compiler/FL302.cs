//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL302 : UvBase
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
UvVar CODE = "";
UvVar ANY_SPACES = "";
#endregion
public FL302(ref UvVar CODE) {
this.CODE = CODE;
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
/*  REMOVING ANY SPACES IN 'CODE' */
CODE = TRIM(CODE);
do {
ANY_SPACES = INDEX(CODE, " ", 1);
if (NOT(ANY_SPACES)) break;
CODE = CODE.Substring(1, ANY_SPACES - 1) + CODE.Substring(ANY_SPACES + 1, 999);
} while (true);
return;
}
}
}
