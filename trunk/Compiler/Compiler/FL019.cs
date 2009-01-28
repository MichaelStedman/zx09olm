//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL019 : UvBase
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
UvVar LENGTH_OF_INPUT = "";
UvVar ANS = "";
UvVar INTERACT = "";
UvVar ANS2 = "";
UvVar I = "";
UvVar CHARACTER = "";
#endregion
public FL019(ref UvVar LENGTH_OF_INPUT, ref UvVar ANS) {
this.LENGTH_OF_INPUT = LENGTH_OF_INPUT;
this.ANS = ANS;
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
// INPUT A FIELD
INTERACT = VALID_DATA;
#region INCLUDE FZ.LIBRARY FZ019
//     $INCLUDE  INCLUDE

//     INPUT A FIELD
INPUT(out ANS, LENGTH_OF_INPUT);
ANS2 = "";
for(I = 1; I <= LENGTH_OF_INPUT; I += 1) {
CHARACTER = ANS.Substring(I, 1);
//DJA 7.10.02*   IF SEQ(CHARACTER) > 31 THEN ANS2 = ANS2 : CHARACTER
// Test for control characters above the standard ASCII set
// (Swindon were typing CTRL+SHIFT+6 and inserting attribute
//  marks into records, causing corruptions)
//!*     IF SEQ(CHARACTER) > 31 AND SEQ(CHARACTER) < 128 THEN
if (SEQ(CHARACTER) > 31) {
ANS2 = ANS2 + CHARACTER;
}
}
ANS = ANS2;
// Add this input to the trace stack
//     TRACE.STACK<1,-1> = ANS
//*********************************
//  END OF $INCLUDE INCLUDE END
//*********************************

#endregion
// Return to calling program
return;
}
}
}
