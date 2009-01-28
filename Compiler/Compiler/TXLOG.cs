namespace Compiler {
class TXLOG {
public UvVar TRANS_LOG_REC = "";
public UvVar TX_LOG1 = "";
public UvVar TX_LOG2 = "";
public UvVar TX_CONTROL = "";
public UvVar TX_ATT = "";
public UvVar TX_ENABLED = "";
public UvVar TX_FILES = "";
public UvVar TX_ACCOUNT = "";
public UvVar TX_TRANSFER = "";
public UvVar TX_TRANSFER_IND = "";
static readonly TXLOG instance = new TXLOG();
TXLOG() {
}
public static TXLOG Instance {
get { return instance; }
}
// Explicit static constructor to tell C# compiler
// not to mark type as beforefieldinit
static TXLOG() { }
}
}
