//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_BTITLE : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CUSTOMERS = 85;
readonly UvVar CUST_NAME = 1;
readonly UvVar CUST_INITS = 2;
readonly UvVar CUST_TITLE = 3;
readonly UvVar CUST_ADDRESS1 = 4;
readonly UvVar CUST_ADDRESS2 = 5;
readonly UvVar CUST_ADDRESS3 = 6;
readonly UvVar CUST_ADDRESS4 = 7;
readonly UvVar CUST_POST = 8;
readonly UvVar CUST_HTEL = 9;
readonly UvVar CUST_WTEL = 10;
readonly UvVar CUST_COMMENTS = 11;
readonly UvVar CUST_ACCOUNTS = 12;
readonly UvVar CUST_LAST_ACC = 13;
readonly UvVar CUST_MEMBER_NO = 14;
readonly UvVar CUST_DUE = 15;
readonly UvVar CUST_ORGANISATION = 16;
readonly UvVar CUST_EMAIL_ADDRESS = 17;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CUST_REC = new UvVar[20];
#endregion
#region Variables
UvVar DICTVAR = "";
UvVar KEY = "";
UvVar CST_KEY = "";
UvVar CST_REC = "";
#endregion
public FL_BTITLE(ref UvVar DICTVAR, ref UvVar KEY) {
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
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
CST_KEY = FIELD(KEY, "/", 1);
if (!READ(ref CST_REC, COMMON.FILES[FL_CUSTOMERS], CST_KEY)) { CST_REC = ""; }
DICTVAR[1] = CST_REC[3];
return;
}
}
}
