//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL805 : UvBase
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
UvVar[] CUST_REC = new UvVar[20];
UvVar[] BLOCK_PAY_REC = new UvVar[50];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar TODAYS_DATE = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar EOF = "";
UvVar SSTATEMENT = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar CUST_KEY = "";
UvVar AMOUNT_DUE = "";
UvVar NO_OF_ACCOUNTS = "";
UvVar ACC_NO = "";
UvVar DEBT_KEY = "";
UvVar NO_OF_DATES = "";
UvVar DATE_NO = "";
UvVar ZZZ_DATE = "";
FLTX2 FLTX2;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL805() {
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
/*  Update Amounts Due on Customers File */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL805";
PROMPT("");
/* ****************************************** */
/*  INCLUDE FILES */
/* ****************************************** */
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
#region INCLUDE FL.FILES FL.BLOCK.PAY

#endregion
/* ******************************************* */
/*  INITIALIZE VARIABLES */
/* ******************************************* */
EOF = 0;
/* ****************************************** */
/*  MAIN LOOP */
/* ****************************************** */
SSTATEMENT = "SELECT FL.CUSTOMERS";
/*      EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
do {
if (!READNEXT(ref CUST_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (!(MATREADU(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY))) {
MAT(ref CUST_REC, "");
}
AMOUNT_DUE = 0;
NO_OF_ACCOUNTS = DCOUNT(CUST_REC[CUST_ACCOUNTS][1], VM);
for(ACC_NO = 1; ACC_NO <= NO_OF_ACCOUNTS; ACC_NO += 1) {
DEBT_KEY = CUST_KEY + "/" + CUST_REC[CUST_ACCOUNTS][1, ACC_NO];
if (!(MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], DEBT_KEY))) {
MAT(ref BLOCK_PAY_REC, "");
}
NO_OF_DATES = DCOUNT(BLOCK_PAY_REC[BLOCK_PAY_DUE][1], VM);
for(DATE_NO = 1; DATE_NO <= NO_OF_DATES; DATE_NO += 1) {
ZZZ_DATE = BLOCK_PAY_REC[BLOCK_PAY_DUE][1, DATE_NO];
if (ZZZ_DATE < TODAYS_DATE) {
AMOUNT_DUE = AMOUNT_DUE + BLOCK_PAY_REC[BLOCK_PAY_OUTSTAND][1, DATE_NO];
}
}
}
CUST_REC[CUST_DUE] = AMOUNT_DUE;
MATWRITE(CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY);
if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY)) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.CUSTOMERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref CUST_KEY);
} while (true);
return;
}
}
}
