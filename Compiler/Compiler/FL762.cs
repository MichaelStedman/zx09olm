//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL762 : UvBase
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
readonly UvVar INVALID_DATA = 5;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar FILENAME = "";
UvVar INTERACT = "";
UvVar MACHINE_TYPE = "";
UvVar PROGRAM = "";
UvVar FL_PRINT_FILES = "";
UvVar PROCESS_EXECUTE = "";
FL019 FL019;
UvVar ANS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OUTPUT = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
FL006 FL006;
UvVar INSTRUCTION = "";
UvVar MESSAGE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL762(ref UvVar FILENAME, ref UvVar INTERACT) {
this.FILENAME = FILENAME;
this.INTERACT = INTERACT;
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
/*     EXPORT DATA TO DOS FLOPPY - AP/PRO VERSION ONLY�1.0 */
/* *   EQU TAB TO CHAR(9) */
PROGRAM = "FL762";
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
if (!OPEN("FL.PRINT.FILES", out FL_PRINT_FILES)) { STOP("201", "FL.PRINT.FILES"); }
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
PRINT(AT(10, 19) + "Insert a blank MS-DOS formatted floppy disk into");
PRINT(AT(10, 20) + "floppy disk drive - then press <RETURN> ");
nrf0 = 3;
FL019 = new FL019(ref nrf0, ref ANS);
if (ANS != "") { return; }
nrf0 = "SET-FLOPPY";
nrf1 = "O";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref nrf0, ref nrf1, ref RTN_LIST, ref LIST_AVAILABLE, ref OUTPUT, ref ERRORS);
OUTPUT = OUTPUT[1];
INTERACT = INVALID_DATA;
if (OUTPUT != "BLOCK SIZE: 500") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
} else {
L0100();
INTERACT = VALID_DATA;
}
return;
/* ************************************ */
}
void L0100() {
/*    PROCESS ITEM FOR EXPORT */
/* ************************************ */
PRINT(AT(10, 21) + "Saving export item to floppy disk... ");
/*  The original lines from door access used 'C'oncatenate and 'E' */
/*  to append a character between items.  This was because multiple */
/*  log items were being exported. */
/* *   DATA "0D0A" */
/* *   DATA DOS.FILE */
/* *   EXECUTE "EXPORT FL.EXPORT * (CEO)" CAPTURING OUTPUT */
DATA("");
/*  <Return> to continue at prompt */
INSTRUCTION = "EXPORT FL.PRINT.FILES " + FILENAME + " (O)";
nrf0 = "O";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EXECUTE("T-DET", string.Empty, string.Empty, string.Empty, string.Empty);
PRINT("DONE.");
DELETE(FL_PRINT_FILES, FILENAME);
return;
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
