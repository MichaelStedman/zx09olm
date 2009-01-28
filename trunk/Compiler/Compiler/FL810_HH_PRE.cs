//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL810_HH_PRE : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_TILL_CONTROL = 91;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
FL810_HH FL810_HH;
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
FL000_10 FL000_10;
UvVar FDATE = "";
UvVar TEST_FDATE = "";
UvVar FIRST_DATE = "";
UvVar PRINT_TYPE = "";
UvVar HH_TILL = "";
UvVar SSTATEMENT = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar CONTINUE = "";
UvVar EOF = "";
UvVar TILL_KEY = "";
UvVar FLEX = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL810_HH_PRE() {
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
/*  RECONCILIATIONS REPORT */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL810.HH";
nrf0 = 0;
FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
/*  Open Files */
#region INCLUDE FL.FILES FL.TILL.CONTROL

#endregion
/*  prompt for dates */
PRINT(AT(0, 4) + COMMON.EOS);
PRINT(AT(10, 10) + "Input Date                    " + COMMON.EOL);
PRINT(AT(10, 12) + "(T)icket or (R)eport Printer  " + COMMON.EOL);
PRINT(AT(10, 14) + "Input Handheld Till Number " + COMMON.EOL);
do {
PRINT(AT(50, 10) + COMMON.EOL);
PRINT(AT(50, 10));
INPUT(out FDATE, 12);
if (FDATE == "") {
FDATE = OCONV(TODAYS_DATE, COMMON.D2);
}
TEST_FDATE = ICONV(FDATE, COMMON.D2);
if (TEST_FDATE != "" || FDATE == COMMON.ABANDON || FDATE == "") break;
} while (true);
if (FDATE == COMMON.ABANDON || FDATE == "") {
return;
}
FIRST_DATE = OCONV(TEST_FDATE, "D");
PRINTCR(AT(50, 10) + FIRST_DATE);
do {
PRINT(AT(50, 12) + COMMON.EOL);
PRINT(AT(50, 12));
INPUT(out PRINT_TYPE, 2);
if (PRINT_TYPE == "") {
PRINT_TYPE = "T";
}
if (PRINT_TYPE != "T" && PRINT_TYPE != "R" && PRINT_TYPE != COMMON.ABANDON) {
PRINT_TYPE = "";
}
if (PRINT_TYPE != "" || PRINT_TYPE == COMMON.ABANDON) break;
} while (true);
if (PRINT_TYPE == COMMON.ABANDON) {
return;
}
PRINT(AT(50, 12) + PRINT_TYPE);
do {
PRINT(AT(50, 14) + COMMON.EOL);
PRINT(AT(50, 14));
INPUT(out HH_TILL, 5);
if (HH_TILL == "") {
HH_TILL = COMMON.ABANDON;
}
if (HH_TILL != "" || HH_TILL == COMMON.ABANDON) break;
} while (true);
if (HH_TILL == COMMON.ABANDON) {
return;
}
PRINT(AT(20, 16) + "Please Wait, Producing Report");
SSTATEMENT = "SSELECT FL.TILL.CONTROL WITH 4 = \"" + FIRST_DATE + "\" AND WITH KEY2 = \"" + HH_TILL + "\" AND WITH KEY1 = \"SESSION\" AND WITH 7 = \"3\" BY SESSION";
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (NOT(LIST_AVAILABLE)) {
PRINT(AT(20, 20) + "NO ITEMS PRESENT");
INPUTCR(out CONTINUE, 1);
return;
}
/*  Re-Print Reconciliation Slips & Get Totals */
PRINT(AT(50, 15) + "Session :");
EOF = 0;
do {
if (!READNEXT(ref TILL_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
PRINT(AT(60, 15) + FIELD(TILL_KEY, ".", 3));
FL810_HH = new FL810_HH(ref TILL_KEY, ref FIRST_DATE, ref PRINT_TYPE);
} while (true);
PRINT("FINISHED ");
INPUT(out FLEX, 1);
return;
}
/* 0�0�(FL810.HH)����SH */
/* 6�1�Reconciliation Report (HandHelds)����SH */
/* 23�3�����SB */
}
}
