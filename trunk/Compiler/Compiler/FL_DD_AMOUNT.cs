//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_DD_AMOUNT : UvBase
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
UvVar FL_DIRECT_DEBITS = "";
UvVar ADJUSTMENTS = "";
UvVar AMT = "";
#endregion
public FL_DD_AMOUNT(ref UvVar KEY, ref UvVar CONTENT, ref UvVar TEMPLATE, ref UvVar TEMPLATE_FIELD_NO) {
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
// Return dd amount for first dd date (might not be same as 
// regular instalment as it may have been adjusted - therefore 
// take adjustment into account)
if (!OPEN("FL.DIRECT.DEBITS", out FL_DIRECT_DEBITS)) { STOP(); }
if (!READV(ref ADJUSTMENTS, FL_DIRECT_DEBITS, KEY, 9)) { STOP(); }
AMT = CONTENT[1, 1] + ADJUSTMENTS[1, 1];
CONTENT = OCONV(AMT, "MD2");
return;
}
}
}
