//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_BDATESDUE : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_BLOCK_PAY = 88;
readonly UvVar BLOCK_PAY_DUE = 1;
readonly UvVar BLOCK_PAY_OWES = 2;
readonly UvVar BLOCK_PAY_PAID = 3;
readonly UvVar BLOCK_PAY_OUTSTAND = 4;
readonly UvVar BLOCK_PAY_TOTAL_OWED = 5;
readonly UvVar BLOCK_PAY_TOTAL_PAID = 6;
readonly UvVar BLOCK_PAY_DATES_PAID = 7;
readonly UvVar BLOCK_PAY_AMOUNTS_PAID = 8;
readonly UvVar BLOCK_PAY_ADJ = 9;
readonly UvVar BLOCK_PAY_ADJ_TYPE = 10;
readonly UvVar BLOCK_PAY_ADJ_DATE = 11;
readonly UvVar BLOCK_PAY_ADJ_INST = 12;
readonly UvVar BLOCK_PAY_SPORTS1 = 13;
readonly UvVar BLOCK_PAY_HEADCOUNTS1 = 14;
readonly UvVar BLOCK_PAY_SPORTS2 = 15;
readonly UvVar BLOCK_PAY_HEADCOUNTS2 = 16;
readonly UvVar BLOCK_PAY_SPORTS3 = 17;
readonly UvVar BLOCK_PAY_HEADCOUNTS3 = 18;
readonly UvVar BLOCK_PAY_SPORTS4 = 19;
readonly UvVar BLOCK_PAY_HEADCOUNTS4 = 20;
readonly UvVar BLOCK_PAY_SPORTS5 = 21;
readonly UvVar BLOCK_PAY_HEADCOUNTS5 = 22;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BLOCK_PAY_REC = new UvVar[50];
#endregion
#region Variables
UvVar DICTVAR = "";
UvVar KEY = "";
UvVar VM = "";
UvVar NO_OF_DATES = "";
UvVar DT = "";
#endregion
public FL_BDATESDUE(ref UvVar DICTVAR, ref UvVar KEY) {
this.DICTVAR = DICTVAR;
this.KEY = KEY;
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
#region INCLUDE FL.FILES FL.BLOCK.PAY

#endregion
if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], KEY))) {
MAT(ref BLOCK_PAY_REC, "");
}
NO_OF_DATES = DCOUNT(BLOCK_PAY_REC[BLOCK_PAY_DUE][1], VM);
for(DT = 1; DT <= NO_OF_DATES; DT += 1) {
DICTVAR[DT] = BLOCK_PAY_REC[BLOCK_PAY_DUE][1, DT];
}
return;
}
}
}
