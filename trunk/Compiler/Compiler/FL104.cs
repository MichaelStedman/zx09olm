//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL104 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CENTRES_REC = new UvVar[4];
#endregion
#region Variables
UvVar PRINT_DETAILS = "";
UvVar CALLING_PROGRAM = "";
UvVar TYPE = "";
UvVar PROGRAM = "";
UvVar HEAD_OF_FORM = "";
UvVar HEAD1 = "";
UvVar HEAD2 = "";
UvVar LINE_POS = "";
#endregion
public FL104(ref UvVar PRINT_DETAILS, ref UvVar CALLING_PROGRAM, ref UvVar TYPE) {
this.PRINT_DETAILS = PRINT_DETAILS;
this.CALLING_PROGRAM = CALLING_PROGRAM;
this.TYPE = TYPE;
#region INCLUDE FL.COMMON FL.COMMON

/*  FILES */
/*     Standard */
/*     Screen Control */
/*     Slave Printer Control */
/*     Special Video */
/*     User input control */
/*     Application Specific */
/* COMMON SC.POS */
/*     Theatre */
/*     Standard EQUates */
/*     Client app control */
/* \ */
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
/*  Routine to print reconciliation slips to system printer */
PROGRAM = "FL104";
/*  Include files */
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
/* * Printer controls */
if (!(READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1))) {
CENTRES_REC[CENTRE_NAME] = "Unknown";
}
HEAD_OF_FORM = CHAR(12);
HEAD1 = "(" + PROGRAM + ")" + SPACE(103) + TIMEDATE();
HEAD2 = FORMAT(CENTRES_REC[CENTRE_NAME], "L#50") + "Reconciliation Slip  (" + TYPE + ")";
PRINTER_ON();
PRINTCR(HEAD_OF_FORM);
PRINTCR(HEAD1);
PRINTCR(HEAD2);
PRINT();
PRINT();
LINE_POS = 1;
do {
if (PRINT_DETAILS[LINE_POS] == "") break;
PRINTCR(PRINT_DETAILS[LINE_POS, 1]);
LINE_POS = LINE_POS + 1;
} while (true);
PRINTER_OFF();
PRINTER_CLOSE();
return;
}
}
}
