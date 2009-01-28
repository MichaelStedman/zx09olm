//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL772 : UvBase
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
UvVar PROG_MESS = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar TEMPLATE = "";
UvVar TYPE = "";
FL773 FL773;
UvVar SUCCESSFUL = "";
#endregion
public FL772() {
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
/*   Automatic Run of export ROUTINES */
PROMPT("");
INTERACT = VALID_DATA;
PROGRAM = "FL772";
/* ************************************ */
/*   Get Template Name */
/* ************************************ */
/*  DJA 29.10.99 */
TEMPLATE = FIELD(PROG_MESS, ",", 1);
TYPE = FIELD(PROG_MESS, ",", 2);
if (TYPE == "") { TYPE = "DBF"; }
FL773 = new FL773(ref TYPE, ref TEMPLATE, ref SUCCESSFUL);
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
