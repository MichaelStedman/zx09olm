//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FLTX1 : UvBase
{
#region Common instances
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Variables
UvVar TRANS_LOG_REC = "";
UvVar TX_LOG1 = "";
UvVar TX_LOG2 = "";
UvVar TX_CONTROL = "";
UvVar TX_ATT = "";
UvVar TX_ENABLED = "";
UvVar TX_FILES = "";
UvVar TX_ACCOUNT = "";
UvVar TX_TRANSFER = "";
UvVar TX_TRANSFER_IND = "";
UvVar TX_ERROR_LOG = "";
#endregion
public FLTX1() {
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion
if (!OPEN("TX.LOG1", out TX_LOG1)) { STOP(201, "TX.LOG1"); }
if (!OPEN("TX.LOG2", out TX_LOG2)) { STOP(201, "TX.LOG2"); }
if (!OPEN("TX.TRANSFER", out TX_TRANSFER)) { STOP(201, "TX.TRANSFER"); }
if (!OPEN("TX.CONTROL", out TX_CONTROL)) { STOP(201, "TX.CONTROL"); }
if (!OPEN("TX.ERROR.LOG", out TX_ERROR_LOG)) { STOP(201, "TX.ERROR.LOG"); }
TRANS_LOG_REC = "";
TX_ATT = "";
TX_ACCOUNT = OCONV("", "U50BB");
if (FIELD(TX_ACCOUNT, " ", 3) != "") {
TX_ACCOUNT = FIELD(TX_ACCOUNT, " ", 3);
} else {
TX_ACCOUNT = FIELD(TX_ACCOUNT, " ", 2);
}
if (!READ(ref TX_FILES, TX_CONTROL, TX_ACCOUNT + ".FILES")) { TX_FILES = ""; }
if (!READ(ref TX_ENABLED, TX_CONTROL, TX_ACCOUNT + ".ENABLED")) { TX_ENABLED = "N"; }
if (!READ(ref TX_TRANSFER_IND, TX_CONTROL, TX_ACCOUNT + ".TRANSFER")) { TX_TRANSFER_IND = "N"; }
if (TX_ENABLED == "Y") { TX_ENABLED = 1; } else { TX_ENABLED = 0; }
if (TX_TRANSFER_IND == "Y") { TX_TRANSFER_IND = 1; } else { TX_TRANSFER_IND = 0; }
return;
}
}
}
