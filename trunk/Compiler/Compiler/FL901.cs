//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL901 : UvBase
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
UvVar FILE_NO = "";
#endregion
public FL901() {
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
/*  CLOSES ALL FILES */
PROGRAM = "FL901";
FILE_NO = 1;
do {
if (FILE_NO == 121) break;
CLOSE((FILE_NO));
FILE_NO = FILE_NO + 1;
} while (true);
FILE_NO = 1;
do {
if (FILE_NO == 21) break;
CLOSE((FILE_NO));
FILE_NO = FILE_NO + 1;
} while (true);
return;
}
}
}
