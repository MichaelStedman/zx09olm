//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_AGE : UvBase
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
UvVar KEY = "";
UvVar CONTENT = "";
UvVar TEMPLATE = "";
UvVar TEMPLATE_FIELD_NO = "";
UvVar AGE = "";
#endregion
public FL_AGE(ref UvVar KEY, ref UvVar CONTENT, ref UvVar TEMPLATE, ref UvVar TEMPLATE_FIELD_NO) {
this.KEY = KEY;
this.CONTENT = CONTENT;
this.TEMPLATE = TEMPLATE;
this.TEMPLATE_FIELD_NO = TEMPLATE_FIELD_NO;
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
// Return the code for a students most recent course to the date
// transfer process
AGE = ((DATE() - CONTENT) / "365");
CONTENT = INT(AGE);
return;
}
}
}
