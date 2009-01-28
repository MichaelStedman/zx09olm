//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL306 : UvBase
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
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
#endregion
public FL306() {
#region INCLUDE FL.COMMON FL.COMMON

// FILES
//    Standard
//    Screen Control
//    Slave Printer Control
//    Special Video
//    User input control
//    Application Specific
//COMMON SC.POS
//    Theatre
//    Standard EQUates
//    Client app control
//\
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
// Print Coloured Bars
// Last updated : 12:41 08/10/92
//************************
// Print Top Bar
//************************
PRINT(AT(78, 0) + NRM_VID + AT(1, 0) + DIM_REV_VID + SPACE(75));
PRINT(AT(78, 1) + NRM_VID + AT(1, 1) + DIM_REV_VID + SPACE(75));
PRINT(AT(78, 2) + NRM_VID + AT(1, 2) + DIM_REV_VID + SPACE(75));
//************************
// Print Bottom Bar
//************************
PRINT(AT(78, 21) + NRM_VID + AT(1, 21) + DIM_REV_VID + SPACE(76));
PRINT(AT(78, 22) + NRM_VID + AT(1, 22) + DIM_REV_VID + SPACE(76) + NRM_VID);
//***********************
// The End
//***********************
return;
}
}
}
