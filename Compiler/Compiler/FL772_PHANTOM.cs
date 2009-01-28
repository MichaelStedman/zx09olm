//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL772_PHANTOM : UvBase
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
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
FL002 FL002;
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar PHANTOM_TLIST = "";
UvVar POS = "";
UvVar TEMPLATE = "";
UvVar TYPE = "";
FL773_PHANTOM FL773_PHANTOM;
UvVar SUCCESSFUL = "";
#endregion
public FL772_PHANTOM() {
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
/* Open Files */
FL002 = new FL002();
PROMPT("");
INTERACT = VALID_DATA;
PROGRAM = "FL772.PHANTOM";
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(READ(ref PHANTOM_TLIST, COMMON.FILES[FL_CONTROL], "PHANTOM.TRANSFER.LIST"))) {
return;
}
/* ************************************ */
/*   Get Template Name */
/* ************************************ */
MACHINE_TYPE = "UNIVERSE";
POS = 1;
do {
if (PHANTOM_TLIST[POS, 1] == "") break;
TEMPLATE = PHANTOM_TLIST[POS, 1];
TYPE = PHANTOM_TLIST[POS, 2];
if (TYPE == "") { TYPE = "DBF"; }
FL773_PHANTOM = new FL773_PHANTOM(ref TYPE, ref TEMPLATE, ref SUCCESSFUL);
POS = POS + 1;
} while (true);
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
