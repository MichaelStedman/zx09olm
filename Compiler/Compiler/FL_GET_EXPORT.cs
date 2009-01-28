//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_GET_EXPORT : UvBase
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
UvVar TYPE = "";
UvVar DATA_FOLDER = "";
UvVar DATA_SHARE = "";
UvVar PORT_NUMBER = "";
UvVar HTM_FOLDER = "";
UvVar EXPORTS_FOLDER = "";
UvVar DRIVE = "";
UvVar HTM_SHARE = "";
UvVar HOSTNAME = "";
UvVar EXPORTS_SHARE = "";
#endregion
public FL_GET_EXPORT(ref UvVar TYPE, ref UvVar DATA_FOLDER, ref UvVar DATA_SHARE) {
this.TYPE = TYPE;
this.DATA_FOLDER = DATA_FOLDER;
this.DATA_SHARE = DATA_SHARE;
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
// use this program to set export directory vars
// BEGIN CASE
// CASE
if (TYPE == "HTM") {
L0100();
}// CASE
else if (OTHERWISE) {
L0200();
}
// END CASE
return;
//**
}
void L0100() {
// HTM INFORMATION
//**
//*AB**     READV HTM.FOLDER FROM FL.CONTROL,"HTM.FOLDER" ,1 ELSE
//*AB**        READV EXPORTS.FOLDER FROM FL.CONTROL,"EXPORTS.FOLDER",1 THEN
//*AB**           HTM.FOLDER = EXPORTS.FOLDER:"REPORTS\"
//*AB**        END ELSE
//*AB**DRIVE = SYSTEM(32)[1,1]
//*AB**           HTM.FOLDER = DRIVE:":\EXPORTS\REPORTS\"
//*AB**        END
//*AB**     END
HTM_FOLDER = "";
if (!(READV(ref HTM_FOLDER, COMMON.FILES[FL_CONTROL], "HTM.FOLDER*" + PORT_NUMBER, 1))) {
if (!(READV(ref HTM_FOLDER, COMMON.FILES[FL_CONTROL], "HTM.FOLDER", 1))) {
if (!(READV(ref EXPORTS_FOLDER, COMMON.FILES[FL_CONTROL], "EXPORTS.FOLDER*" + PORT_NUMBER, 1))) {
if (!(READV(ref EXPORTS_FOLDER, COMMON.FILES[FL_CONTROL], "EXPORTS.FOLDER", 1))) {
DRIVE = SYSTEM(32).Substring(1, 1);
HTM_FOLDER = DRIVE + ":\\EXPORTS\\REPORTS\\";
}
}
}
if (HTM_FOLDER == "") {
HTM_FOLDER = EXPORTS_FOLDER + "REPORTS/";
}
}
if (HTM_FOLDER.Substring(2, 1) == ":") {
if (!(READV(ref HTM_SHARE, COMMON.FILES[FL_CONTROL], "HTM.SHARE", 1))) {
EXECUTE("DOS /C \"HOSTNAME\"", HOSTNAME, string.Empty, string.Empty, string.Empty);
HOSTNAME = CHANGE(HOSTNAME, "-");
HTM_SHARE = "\\\\" + HOSTNAME[1] + FIELD(HTM_FOLDER, ":", 2);
}
} else {
HTM_SHARE = HTM_FOLDER;
}
DATA_FOLDER = HTM_FOLDER;
DATA_SHARE = HTM_SHARE;
return;
//**
}
void L0200() {
// OTHER INFORMATION
//**
if (!(READV(ref EXPORTS_FOLDER, COMMON.FILES[FL_CONTROL], "EXPORTS.FOLDER*" + PORT_NUMBER, 1))) {
if (!(READV(ref EXPORTS_FOLDER, COMMON.FILES[FL_CONTROL], "EXPORTS.FOLDER", 1))) {
DRIVE = SYSTEM(32).Substring(1, 1);
EXPORTS_FOLDER = DRIVE + ":\\EXPORTS\\";
}
}
if (EXPORTS_FOLDER.Substring(2, 1) == ":") {
if (!(READV(ref EXPORTS_SHARE, COMMON.FILES[FL_CONTROL], "EXPORTS.SHARE", 1))) {
EXECUTE("DOS /C \"HOSTNAME\"", HOSTNAME, string.Empty, string.Empty, string.Empty);
HOSTNAME = CHANGE(HOSTNAME, "-");
EXPORTS_SHARE = "\\\\" + HOSTNAME[1] + FIELD(EXPORTS_FOLDER, ":", 2);
}
} else {
EXPORTS_SHARE = EXPORTS_FOLDER;
}
DATA_FOLDER = EXPORTS_FOLDER;
DATA_SHARE = EXPORTS_SHARE;
return;
}
}
}
