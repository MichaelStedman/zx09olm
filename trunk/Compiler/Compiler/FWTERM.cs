namespace Compiler {
class FWTERM {
public UvVar MESSAGE_QUEUE = "";
static readonly FWTERM instance = new FWTERM();
FWTERM() {
}
public static FWTERM Instance {
get { return instance; }
}
// Explicit static constructor to tell C# compiler
// not to mark type as beforefieldinit
static FWTERM() { }
}
}
