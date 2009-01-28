//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CC_ENCODE : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar CARD_NO = "";
UvVar ENCODE_CARD = "";
UvVar NEWNO = "";
UvVar CARD_LEN = "";
UvVar RIGHTPART = "";
#endregion
public FL_CC_ENCODE(ref UvVar CARD_NO) {
this.CARD_NO = CARD_NO;
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
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(READV(ref ENCODE_CARD, COMMON.FILES[FL_CONTROL], "CC.ENCODE", 1))) {
ENCODE_CARD = TRUE;
}
if (ENCODE_CARD && CARD_NO != "") {
//         NEWNO = CARD.NO[1,1]
CARD_LEN = LEN(CARD_NO);
if (CARD_LEN > 5) {
RIGHTPART = CARD_NO.Substring(CARD_LEN - 3, 4);
} else {
RIGHTPART = "****";
}
//         NEWNO = NEWNO : STR("*",CARD.LEN-5) : RIGHTPART
NEWNO = STR("*", CARD_LEN - 4) + RIGHTPART;
CARD_NO = NEWNO;
}
return;
}
}
}
