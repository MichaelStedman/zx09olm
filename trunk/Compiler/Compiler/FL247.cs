//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL247 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar MEMBERS = 2;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MEMBER_PARAMS = 64;
readonly UvVar FL_BANK_DETAILS = 108;
readonly UvVar BANK_SORT_CODE = 1;
readonly UvVar BANK_ACCOUNT_NO = 2;
readonly UvVar BANK_NAME = 3;
readonly UvVar BANK_INSTALL_RECORDS = 4;
readonly UvVar BANK_ACCOUNT_NAME = 5;
readonly UvVar BANK_TRANS_CODE = 6;
readonly UvVar BANK_BACS_REF = 7;
readonly UvVar BANK_HOLDERS_ADDRESS = 8;
readonly UvVar FL_DIRECT_DEBITS = 117;
readonly UvVar DIRECT_DEBIT_INST_AMOUNT = 1;
readonly UvVar DIRECT_DEBIT_ANNUAL_FEE = 2;
readonly UvVar DIRECT_DEBIT_LETTER = 3;
readonly UvVar DIRECT_DEBIT_ORIGINAL_DATE = 4;
readonly UvVar DIRECT_DEBIT_NUMBER = 5;
readonly UvVar DIRECT_DEBIT_AMOUNTS = 6;
readonly UvVar DIRECT_DEBIT_DATES = 7;
readonly UvVar DIRECT_DEBIT_OPERATOR = 8;
readonly UvVar DIRECT_DEBIT_ADJ = 9;
readonly UvVar DIRECT_DEBIT_PAID = 10;
readonly UvVar DIRECT_DEBIT_TRANS_CNT = 11;
readonly UvVar DIRECT_DEBIT_LAST_REQ_AMOUNT = 12;
readonly UvVar DIRECT_DEBIT_LAST_DATE = 13;
readonly UvVar DIRECT_DEBIT_LAST_RECD_AMOUNT = 14;
readonly UvVar DIRECT_DEBIT_CANCELLED_DATE = 15;
readonly UvVar DIRECT_DEBIT_DEPOSIT = 16;
readonly UvVar DIRECT_DEBIT_REJECTIONS = 17;
readonly UvVar DIRECT_DEBIT_ADJ_TYPE = 18;
readonly UvVar DIRECT_DEBIT_FREEZE_DATE = 19;
readonly UvVar DIRECT_DEBIT_CANCEL_REASON = 20;
readonly UvVar CASH_DEBIT_INST_AMOUNT = 1;
readonly UvVar CASH_DEBIT_ANNUAL_FEE = 2;
readonly UvVar CASH_DEBIT_LETTER = 3;
readonly UvVar CASH_DEBIT_ORIGINAL_DATE = 4;
readonly UvVar CASH_DEBIT_NUMBER = 5;
readonly UvVar CASH_DEBIT_AMOUNTS = 6;
readonly UvVar CASH_DEBIT_DATES = 7;
readonly UvVar CASH_DEBIT_OPERATOR = 8;
readonly UvVar CASH_DEBIT_ADJ = 9;
readonly UvVar CASH_DEBIT_PAID = 10;
readonly UvVar CASH_DEBIT_TRANS_CNT = 11;
readonly UvVar CASH_DEBIT_LAST_REQ_AMOUNT = 12;
readonly UvVar CASH_DEBIT_LAST_DATE = 13;
readonly UvVar CASH_DEBIT_LAST_RECD_AMOUNT = 14;
readonly UvVar CASH_DEBIT_CANCELLED_DATE = 15;
readonly UvVar CASH_DEBIT_DEPOSIT = 16;
readonly UvVar CASH_DEBIT_ADJ_TYPE = 18;
readonly UvVar CASH_DEBIT_FREEZE_DATE = 19;
readonly UvVar DELETED_CASH_INST_AMOUNT = 1;
readonly UvVar DELETED_CASH_ANNUAL_FEE = 2;
readonly UvVar DELETED_CASH_LETTER = 3;
readonly UvVar DELETED_CASH_ORIGINAL_DATE = 4;
readonly UvVar DELETED_CASH_NUMBER = 5;
readonly UvVar DELETED_CASH_AMOUNTS = 6;
readonly UvVar DELETED_CASH_DATES = 7;
readonly UvVar DELETED_CASH_OPERATOR = 8;
readonly UvVar DELETED_CASH_ADJ = 9;
readonly UvVar DELETED_CASH_PAID = 10;
readonly UvVar DELETED_CASH_TRANS_CNT = 11;
readonly UvVar DELETED_CASH_LAST_REQ_AMOUNT = 12;
readonly UvVar DELETED_CASH_LAST_DATE = 13;
readonly UvVar DELETED_CASH_LAST_RECD_AMOUNT = 14;
readonly UvVar DELETED_CASH_CANCELLED_DATE = 15;
readonly UvVar DELETED_CASH_DEPOSIT = 16;
readonly UvVar DELETED_CASH_ADJ_TYPE = 18;
readonly UvVar DELETED_CASH_FREEZE_DATE = 19;
readonly UvVar DELETED_SORT_CODE = 1;
readonly UvVar DELETED_ACCOUNT_NO = 2;
readonly UvVar DELETED_NAME = 3;
readonly UvVar DELETED_INSTALL_RECORDS = 4;
readonly UvVar DELETED_ACCOUNT_NAME = 5;
readonly UvVar DELETED_TRANS_CODE = 6;
readonly UvVar DELETED_BACS_REF = 7;
readonly UvVar DELETED_HOLDERS_ADDRESS = 8;
readonly UvVar DELETED_INST_AMOUNT = 11;
readonly UvVar DELETED_ANNUAL_FEE = 12;
readonly UvVar DELETED_LETTER = 13;
readonly UvVar DELETED_ORIGINAL_DATE = 14;
readonly UvVar DELETED_NUMBER = 15;
readonly UvVar DELETED_AMOUNTS = 16;
readonly UvVar DELETED_DATES = 17;
readonly UvVar DELETED_OPERATOR = 18;
readonly UvVar DELETED_ADJ = 19;
readonly UvVar DELETED_PAID = 20;
readonly UvVar DELETED_TRANS_CNT = 21;
readonly UvVar DELETED_LAST_REQ_AMOUNT = 22;
readonly UvVar DELETED_LAST_DATE = 23;
readonly UvVar DELETED_LAST_RECD_AMOUNT = 24;
readonly UvVar DELETED_CANCELLED_DATE = 25;
readonly UvVar DELETED_DEPOSIT = 26;
readonly UvVar DELETED_REJECTIONS = 27;
readonly UvVar DELETED_ADJ_TYPE = 28;
readonly UvVar DELETED_FREEZE_DATE = 29;
readonly UvVar DELETED_DEBTOR_DATES = 31;
readonly UvVar DELETED_DEBTOR_OWED = 32;
readonly UvVar FL_MEMBER_USAGE = 61;
readonly UvVar USAGE_DATE = 1;
readonly UvVar LIMIT_REACHED_DATE = 2;
readonly UvVar USAGE_TIME = 3;
readonly UvVar TIME_DISCLAIMER = 4;
readonly UvVar USER_TIME_DISCLRS = 5;
readonly UvVar USER_DATE_DISCLRS = 6;
readonly UvVar USAGE_COUNTER = 7;
readonly UvVar USAGE_DOOR_LOG = 8;
readonly UvVar BONUS_MEMBER = 1;
readonly UvVar BONUS_SCHEME = 2;
readonly UvVar BONUS_DATE_JOINED = 3;
readonly UvVar BONUS_MONTH = 4;
readonly UvVar BONUS_POINTS = 5;
readonly UvVar BONUS_SPEND = 6;
readonly UvVar BONUS_REDEEMED = 7;
readonly UvVar BONUS_VALUE_REDEEMED = 8;
readonly UvVar BONUS_NET_POINTS = 9;
readonly UvVar BONUS_LAST_ALLOCATION_DATE = 10;
readonly UvVar BONUS_LAST_ALLOCATION_TIME = 11;
readonly UvVar BONUS_DECLINED_REDEMPTIONS = 12;
readonly UvVar LOST_MEMBER = 1;
readonly UvVar LOST_SCHEME = 2;
readonly UvVar LOST_DATE_JOINED = 3;
readonly UvVar LOST_MONTH = 4;
readonly UvVar LOST_POINTS = 5;
readonly UvVar LOST_SPEND = 6;
readonly UvVar LOST_REDEEMED = 7;
readonly UvVar LOST_VALUE_REDEEMED = 8;
readonly UvVar LOST_NET_POINTS = 9;
readonly UvVar FL_DEBTORS = 43;
readonly UvVar STUDENT_TITLE = 1;
readonly UvVar STUDENT_FORENAME = 2;
readonly UvVar STUDENT_SURNAME = 3;
readonly UvVar STUDENT_ADDRESS1 = 4;
readonly UvVar STUDENT_ADDRESS2 = 5;
readonly UvVar STUDENT_ADDRESS3 = 6;
readonly UvVar STUDENT_ADDRESS4 = 7;
readonly UvVar STUDENT_POST_CODE = 8;
readonly UvVar STUDENT_SEX = 9;
readonly UvVar STUDENT_HOME_TEL = 10;
readonly UvVar STUDENT_WORK_TEL = 11;
readonly UvVar STUDENT_DOB = 12;
readonly UvVar STUDENT_MEDICAL1 = 13;
readonly UvVar STUDENT_MEDICAL2 = 14;
readonly UvVar STUDENT_MEDICAL3 = 15;
readonly UvVar STUDENT_COMMENT1 = 16;
readonly UvVar STUDENT_COMMENT2 = 17;
readonly UvVar STUDENT_COMMENT3 = 18;
readonly UvVar STUDENT_COMMENT4 = 19;
readonly UvVar STUDENT_CONTACT_NAME = 20;
readonly UvVar STUDENT_CONTACT_PHONE = 21;
readonly UvVar STUDENT_DETAIL_IDS = 22;
readonly UvVar STUDENT_BALANCE = 23;
readonly UvVar STUDENT_TRANS_DETAILS_IDS = 24;
readonly UvVar STUDENT_TRANS_DATES = 25;
readonly UvVar STUDENT_TRANS_TYPES = 26;
readonly UvVar STUDENT_TRANS_AMOUNTS = 27;
readonly UvVar STUDENT_TRANS_RECEIPT_NOS = 28;
readonly UvVar STUDENT_TRANS_MOPS = 29;
readonly UvVar STUDENT_TRANS_MAN_RECEIPT = 30;
readonly UvVar STUDENT_TRANS_WEB = 30;
readonly UvVar STUDENT_TRANS_ADJ_REASON = 31;
readonly UvVar STUDENT_TRANS_USER = 32;
readonly UvVar STUDENT_OLD_NUMBERS = 33;
readonly UvVar STUDENT_AWARD1 = 34;
readonly UvVar STUDENT_AWARD2 = 35;
readonly UvVar STUDENT_AWARD3 = 36;
readonly UvVar STUDENT_AWARD4 = 37;
readonly UvVar STUDENT_DOCTOR_NAME = 38;
readonly UvVar STUDENT_DOCTOR_TEL = 39;
readonly UvVar STUDENT_KEYWORD = 40;
readonly UvVar STUDENT_AWARD5 = 41;
readonly UvVar STUDENT_AWARD6 = 42;
readonly UvVar STUDENT_AWARD7 = 43;
readonly UvVar STUDENT_AWARD8 = 44;
readonly UvVar STUDENT_AWARD9 = 45;
readonly UvVar STUDENT_AWARD10 = 46;
readonly UvVar STUDENT_AWARD11 = 47;
readonly UvVar STUDENT_AWARD12 = 48;
readonly UvVar STUDENT_GROUP_ENROLLED = 49;
readonly UvVar WAIT_STUD_TITLE = 1;
readonly UvVar WAIT_STUD_FORENAME = 2;
readonly UvVar WAIT_STUD_SURNAME = 3;
readonly UvVar WAIT_STUD_ADDRESS1 = 4;
readonly UvVar WAIT_STUD_ADDRESS2 = 5;
readonly UvVar WAIT_STUD_ADDRESS3 = 6;
readonly UvVar WAIT_STUD_ADDRESS4 = 7;
readonly UvVar WAIT_STUD_POST_CODE = 8;
readonly UvVar WAIT_STUD_TEL_HOME = 9;
readonly UvVar WAIT_STUD_TEL_WORK = 10;
readonly UvVar WAIT_STUD_COMMENT = 11;
readonly UvVar WAIT_STUD_AVAILABLE_MONDAY = 12;
readonly UvVar WAIT_STUD_AVAILABLE_TUESDAY = 13;
readonly UvVar WAIT_STUD_AVAILABLE_WEDNESDAY = 14;
readonly UvVar WAIT_STUD_AVAILABLE_THURSDAY = 15;
readonly UvVar WAIT_STUD_AVAILABLE_FRIDAY = 16;
readonly UvVar WAIT_STUD_AVAILABLE_SATURDAY = 17;
readonly UvVar WAIT_STUD_AVAILABLE_SUNDAY = 18;
readonly UvVar WAIT_STUD_ACTIVITY_CODES = 19;
readonly UvVar WAIT_STUD_CONCESSION = 20;
readonly UvVar WAIT_STUD_DATES = 21;
readonly UvVar WAIT_STUD_DOB = 22;
readonly UvVar WAIT_STUD_CONTACTED = 23;
readonly UvVar WAIT_STUD_CENTRE = 24;
readonly UvVar WAIT_STUD_COURSE = 25;
readonly UvVar WAIT_STUD_MEDICAL = 26;
readonly UvVar WAIT_STUD_CENTRE2 = 27;
readonly UvVar DD_WORK_SORT_CODE = 1;
readonly UvVar DD_WORK_ACCT_NO = 2;
readonly UvVar DD_WORK_AMOUNT = 3;
readonly UvVar DD_WORK_NAME = 4;
readonly UvVar DD_WORK_ACCT_NAME = 5;
readonly UvVar DD_WORK_REJECTED = 6;
readonly UvVar DD_WORK_TRANS_CODE = 7;
readonly UvVar DD_WORK_REJECTED_REASON = 8;
readonly UvVar DD_WORK_DATE = 9;
readonly UvVar DD_WORK_BACS_REF = 10;
readonly UvVar DD_WORK_MEMBER_TYPE = 11;
readonly UvVar DD_DEBTORS_DATES = 1;
readonly UvVar DD_DEBTORS_OWED = 2;
readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
readonly UvVar DD_DEBTORS_REASON = 4;
readonly UvVar ADT_RECORD_ID = 1;
readonly UvVar ADT_DATE = 2;
readonly UvVar ADT_USER = 3;
readonly UvVar ADT_ORIG_VALUE = 4;
readonly UvVar ADT_NEW_VALUE = 5;
readonly UvVar ADT_REASON = 6;
readonly UvVar ADT_TIME = 7;
readonly UvVar APACS_MEMBER = 1;
readonly UvVar AUDDIS_LOG_SORTCODE = 1;
readonly UvVar AUDDIS_LOG_ACCNO = 2;
readonly UvVar AUDDIS_LOG_BANKNAME = 3;
readonly UvVar AUDDIS_LOG_ACCNAME = 4;
readonly UvVar AUDDIS_LOG_TRANS_CODE = 5;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] BANK_REC = new UvVar[10];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
UvVar[] CASH_DEBIT_REC = new UvVar[20];
UvVar[] DELETED_CASH_REC = new UvVar[20];
UvVar[] DELETED_DEBITS_REC = new UvVar[50];
UvVar[] USAGE_REC = new UvVar[10];
UvVar[] BONUS_REC = new UvVar[40];
UvVar[] BONUS_LOST_REC = new UvVar[40];
UvVar[] DEBTORS_REC = new UvVar[100];
UvVar[] STUDENT_REC = new UvVar[60];
UvVar[] WAIT_STUDENT_REC = new UvVar[35];
UvVar[] DD_WORK_REC = new UvVar[15];
UvVar[] DD_DEBTORS_REC = new UvVar[10];
UvVar[] ADT_REC = new UvVar[30];
UvVar[] COURSE_PARAM_REC = new UvVar[60];
UvVar[] APACS_REC = new UvVar[10];
UvVar[] AUDDIS_LOG_REC = new UvVar[20];
#endregion
#region Variables
UvVar MEMBERS_REC = "";
UvVar DD_ID = "";
UvVar NEW_USAGE_KEY = "";
UvVar BONUS_FLAG = "";
UvVar DEBTORS_FLAG = "";
UvVar COURSE_STUDENT_NO = "";
UvVar ALL_FILES_DELETE = "";
UvVar CALLING_PROGRAM = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar AMD_KEY = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar EXECUTE_PROG = "";
UvVar FL_CASH_DEBITS = "";
UvVar FL_DELETED_CASH = "";
UvVar FL_DELETED_DEBITS = "";
UvVar FL_BONUS = "";
UvVar FL_BONUS_LOST = "";
UvVar FL_STUDENTS = "";
UvVar FL_WAIT_STUDENTS = "";
UvVar FL_DD_WORK = "";
UvVar FL_DD_DEBTORS = "";
UvVar FL_ADT_LOG = "";
UvVar DICT_ADT_LOG = "";
UvVar FL_COURSE_PARAMS = "";
UvVar FL_APACS_NUMBERS = "";
UvVar FL_AUDDIS_LOG = "";
UvVar MESSAGE = "";
FL006 FL006;
UvVar FL_MUDEL_WORK = "";
UvVar FL_BONUS_WORK = "";
UvVar FL_BONLST_WORK = "";
UvVar FL_BACS_REF = "";
UvVar NEW_STUDENT_NO = "";
UvVar MEMBER_SUFFIX = "";
UvVar MEM_PARAMS_REC = "";
UvVar MEM_TYPE_LIST = "";
UvVar SUB_FEES_INCLUDE = "";
UvVar MULTIPLE_TYPES = "";
UvVar COURSE_PARAMS = "";
UvVar GET_STUDENT_ID = "";
UvVar PHOTO_REQUIRED = "";
UvVar PHOTO_SITE = "";
UvVar FL_PHOTO_FOLDER = "";
UvVar SUB_MEMBERS_LIST = "";
UvVar RECORD_TYPE = "";
UvVar MASTER_LIST = "";
UvVar NO_OF_SUBS = "";
UvVar SUB_MEMBER = "";
UvVar STUDENT_KEY = "";
UvVar STUDENT = "";
UvVar SUB_KEY = "";
UvVar SUB_REC = "";
FLTX2 FLTX2;
UvVar ADT_MEMBER_ID = "";
UvVar PHOTO_THERE = "";
FL000_45 FL000_45;
UvVar MEM_ID = "";
UvVar BASE_REC = "";
UvVar NAME = "";
UvVar MASTER_REC = "";
UvVar PNTR = "";
UvVar REFERENCE = "";
UvVar AMD_KEYZ = "";
UvVar MEMBERS_RECZ = "";
UvVar DEL_REC = "";
UvVar BANK_DETS_ID = "";
UvVar DD_DEBTOR_ID = "";
UvVar START_DATE = "";
UvVar BANK_ARRAY = "";
UvVar DEBIT_ARRAY = "";
UvVar DELETED_ARRAY = "";
UvVar DEBTOR_ARRAY = "";
UvVar NEW_MEMBER_NO = "";
UvVar REC_COUNT = "";
UvVar MUDEL_REC = "";
UvVar USAGE_KEY = "";
UvVar USG_REC = "";
UvVar BON_REC = "";
UvVar BONUS_KEY = "";
UvVar LOST_REC = "";
UvVar LOST_KEY = "";
UvVar DEBTOR_KEY = "";
UvVar DEB_REC = "";
FL248 FL248;
CallAt_GET_STUDENT_ID CallAt_GET_STUDENT_ID;
FL766 FL766;
UvVar WAIT_STUD_SEX = "";
UvVar SEQ_NO = "";
UvVar CASH_REC = "";
UvVar APACS_NO = "";
UvVar APACS_REF = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL247(ref UvVar MEMBERS_REC, ref UvVar DD_ID, ref UvVar NEW_USAGE_KEY, ref UvVar BONUS_FLAG, ref UvVar DEBTORS_FLAG, ref UvVar COURSE_STUDENT_NO, ref UvVar ALL_FILES_DELETE, ref UvVar CALLING_PROGRAM) {
this.MEMBERS_REC = MEMBERS_REC;
this.DD_ID = DD_ID;
this.NEW_USAGE_KEY = NEW_USAGE_KEY;
this.BONUS_FLAG = BONUS_FLAG;
this.DEBTORS_FLAG = DEBTORS_FLAG;
this.COURSE_STUDENT_NO = COURSE_STUDENT_NO;
this.ALL_FILES_DELETE = ALL_FILES_DELETE;
this.CALLING_PROGRAM = CALLING_PROGRAM;
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
/*  Delete Member/Submember record */
/*  Dated  : 13/8/98 */
/* ******************************************************************** */
PROGRAM = "FL247";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Files */
#region INCLUDE FL.FILES FL.BANK.DETAILS

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
#region INCLUDE FL.FILES FL.CASH.DEBITS

if (!OPEN("FL.CASH.DEBITS", out FL_CASH_DEBITS)) { STOP(201); }

#endregion
#region INCLUDE FL.FILES FL.DELETED.CASH
if (!(OPEN("FL.DELETED.CASH", out FL_DELETED_CASH))) {

EXECUTE("CREATE-FILE FL.DELETED.CASH 1 109", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.DELETED.CASH", out FL_DELETED_CASH)) { STOP(201, "CANNOT OPEN FL.DELETED.CASH"); }
}

#endregion
#region INCLUDE FL.FILES FL.DELETED.DEBITS

if (!(OPEN("FL.DELETED.DEBITS", out FL_DELETED_DEBITS))) {
STOP(201, "FL.DELETED.DEBITS");
}
/*  Bank Details lines 1 - 10 */
/*  Direct Debits lines 11 - 30 */
/*  DD Debtors lines 31 - 40 */

#endregion
#region INCLUDE FL.FILES FL.MEMBER.USAGE

/*  This item separated into three components */
/*  by DJA 9.7.01 in conjunction with eBookings */
/*  upgrade */
#region INCLUDE FL.FILES FL.MEMBER.USAGE.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBER.USAGE.DIM

#endregion
#region INCLUDE FL.FILES FL.MEMBER.USAGE.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BONUS
#region INCLUDE FL.FILES FL.BONUS.EQU
if (!OPEN("FL.BONUS", out FL_BONUS)) { STOP("201", "FL.BONUS"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BONUS.LOST
#region INCLUDE FL.FILES FL.BONUS.LOST.EQU
if (!OPEN("FL.BONUS.LOST", out FL_BONUS_LOST)) { STOP("201", "FL.BONUS.LOST"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.LOST.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.LOST.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.DEBTORS

#endregion
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
#region INCLUDE FL.FILES FL.WAIT.STUDENTS
if (!OPEN("FL.WAIT.STUDENTS", out FL_WAIT_STUDENTS)) { STOP("201", "FL.WAIT.STUDENTS"); }

/*  Important - keep Wait.Stud.Dates (21) in tandem */

#endregion
#region INCLUDE FL.FILES FL.DD.WORK

if (!OPEN("FL.DD.WORK", out FL_DD_WORK)) { STOP("201", "FL.DD.WORK"); }

#endregion
#region INCLUDE FL.FILES FL.DD.DEBTORS

if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

#endregion
#region INCLUDE FL.FILES FL.ADT.LOG

if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
/*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
#region INCLUDE FL.FILES FL.AUDDIS.LOG
if (!(OPEN("FL.AUDDIS.LOG", out FL_AUDDIS_LOG))) {

EXECUTE("CREATE-FILE FL.AUDDIS.LOG 1 101", MESSAGE, string.Empty, string.Empty, string.Empty);
if (!(OPEN("FL.AUDDIS.LOG", out FL_AUDDIS_LOG))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}

#endregion
if (!(OPEN("FL.MUDEL.WORK", out FL_MUDEL_WORK))) {
EXECUTE("CREATE-FILE FL.MUDEL.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.MUDEL.WORK", out FL_MUDEL_WORK)) { STOP(201, "FL.MUDEL.WORK"); }
}
if (!(OPEN("FL.BONUS.WORK", out FL_BONUS_WORK))) {
EXECUTE("CREATE-FILE FL.BONUS.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.BONUS.WORK", out FL_BONUS_WORK)) { STOP(201, "FL.BONUS.WORK"); }
}
if (!(OPEN("FL.BONLST.WORK", out FL_BONLST_WORK))) {
EXECUTE("CREATE-FILE FL.BONLST.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.BONLST.WORK", out FL_BONLST_WORK)) { STOP(201, "FL.BONLST.WORK"); }
}
if (!OPEN("FL.BACS.REF", out FL_BACS_REF)) { STOP(201, "NO FL.BACS.REF FILE"); }
MAT(ref STUDENT_REC, "");
NEW_STUDENT_NO = "";
if (!(READV(ref MEMBER_SUFFIX, COMMON.FILES[FL_MEMBER_PARAMS], "DELETION.SUFFIX", 1))) {
MEMBER_SUFFIX = "A";
}
if (!(READ(ref MEM_PARAMS_REC, COMMON.FILES[FL_CONTROL], "AUTOMATIC.CONCESS"))) {
MEM_PARAMS_REC = "";
}
MEM_TYPE_LIST = FALSE;
SUB_FEES_INCLUDE = FALSE;
if (MEM_PARAMS_REC[11, 1] == "Y") {
MULTIPLE_TYPES = TRUE;
MEM_TYPE_LIST = TRUE;
SUB_FEES_INCLUDE = TRUE;
} else {
MULTIPLE_TYPES = FALSE;
if (MEM_PARAMS_REC[11, 2] == "Y") {
MEM_TYPE_LIST = TRUE;
}
if (MEM_PARAMS_REC[11, 2] == "S") {
MEM_TYPE_LIST = TRUE;
SUB_FEES_INCLUDE = TRUE;
}
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[1, 1];
if (GET_STUDENT_ID == "") { GET_STUDENT_ID = "N"; }
/*  Establish photo params */
if (!(READV(ref PHOTO_REQUIRED, COMMON.FILES[FL_CONTROL], "PHOTO.REQUIRED", 1))) {
PHOTO_REQUIRED = "N";
PHOTO_SITE = FALSE;
}
if (PHOTO_REQUIRED == "Y") {
if (OPEN("FL.PHOTO.FOLDER", out FL_PHOTO_FOLDER)) {
PHOTO_SITE = TRUE;
} else {
PHOTO_SITE = FALSE;
nrf0 = 1;
nrf1 = "NO PHOTO FILE";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
/*  Establish whether Member or Submember */
if (MEMBERS_REC[19] != "") {
SUB_MEMBERS_LIST = MEMBERS_REC[19];
RECORD_TYPE = "MASTER";
} else {
MASTER_LIST = MEMBERS_REC[18];
RECORD_TYPE = "SUB.MEMBER";
}
if (MEMBERS_REC[18] == "" && MEMBERS_REC[19] == "") {
RECORD_TYPE = "NORMAL";
}
/*  Deletion if Main Member */
if (RECORD_TYPE == "MASTER") {
NO_OF_SUBS = COUNT(SUB_MEMBERS_LIST, VM) + 1;
for(SUB_MEMBER = 1; SUB_MEMBER <= NO_OF_SUBS; SUB_MEMBER += 1) {
STUDENT_KEY = SUB_MEMBERS_LIST[1, SUB_MEMBER];
L0550();
if (STUDENT && GET_STUDENT_ID == "N") {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_STUDENT_NO = "NOT.DELETED";
return;
}
}
STUDENT_KEY = AMD_KEY;
L0550();
if (STUDENT && GET_STUDENT_ID == "N") {
nrf0 = 3;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_STUDENT_NO = "NOT.DELETED";
return;
}
for(SUB_MEMBER = 1; SUB_MEMBER <= NO_OF_SUBS; SUB_MEMBER += 1) {
SUB_KEY = SUB_MEMBERS_LIST[1, SUB_MEMBER];
if (!READ(ref SUB_REC, COMMON.FILES[MEMBERS], SUB_KEY)) { SUB_REC = MEMBERS_REC; }
DELETE(COMMON.FILES[MEMBERS], SUB_KEY);
nrf0 = "D";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SUB_KEY);
ADT_MEMBER_ID = SUB_KEY;
L0600();
/*  Update ADT.LOG */
if (PHOTO_SITE) {
if (READV(ref PHOTO_THERE, FL_PHOTO_FOLDER, SUB_KEY + ".JPG", 1)) {
EXECUTE("DELETE FL.PHOTO.FOLDER ", string.Empty, string.Empty, string.Empty, string.Empty);
}
}
FL000_45 = new FL000_45(ref SUB_KEY, ref SUB_REC);
MEM_ID = SUB_KEY;
BASE_REC = SUB_REC;
L0500();
/*  Amend Courses records */
NAME = SUB_REC[4, 1];
L0800();
/*  Remove APACS link */
if (ALL_FILES_DELETE == "Y") {
L0200();
/*  Amend Member Usage */
L0300();
/*  Delete Bonus Records */
L0400();
/*  Write off debtors records */
}
}
MEM_ID = AMD_KEY;
NAME = MEMBERS_REC[4, 1];
L0100();
/*  Delete any Direct Debit records */
L0700();
/*  Delete any Cash Debit records */
L0800();
/*  Remove APACS link */
BASE_REC = MEMBERS_REC;
L0500();
/*  Amend Courses records */
if (ALL_FILES_DELETE == "Y") {
L0200();
/*  Amend Member Usage */
L0300();
/*  Delete Bonus Records */
L0400();
/*  Write off debtors records */
}
}
/*  Deletion if Submember */
if (RECORD_TYPE == "SUB.MEMBER") {
STUDENT_KEY = AMD_KEY;
L0550();
if (STUDENT && GET_STUDENT_ID == "N") {
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_STUDENT_NO = "NOT.DELETED";
return;
}
if (!(READ(ref MASTER_REC, COMMON.FILES[MEMBERS], MASTER_LIST))) {
MASTER_REC = "";
}
if (LOCATE(AMD_KEY, MASTER_REC[19], 1, 0, 1, ref PNTR, "AL")) {
MASTER_REC = DELETE(MASTER_REC, 19, PNTR, 0);
if (SUB_FEES_INCLUDE) {
MASTER_REC[3] = MASTER_REC[3] - MEMBERS_REC[3];
}
PNTR = PNTR + 1;
for(REFERENCE = 4; REFERENCE <= 8; REFERENCE += 1) {
MASTER_REC = DELETE(MASTER_REC, REFERENCE, PNTR, 0);
}
MASTER_REC = DELETE(MASTER_REC, 21, PNTR, 0);
/*  Remove Sub's DOB */
MASTER_REC = DELETE(MASTER_REC, 29, PNTR, 0);
/*  Remove Sub's Forename */
}
if (MASTER_REC != "") {
WRITE(MASTER_REC, COMMON.FILES[MEMBERS], MASTER_LIST);
TRANS_LOG_REC = MASTER_REC;
nrf0 = "W";nrf1 = "FL.MEMBERS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MASTER_LIST);
}
MEM_ID = AMD_KEY;
NAME = MEMBERS_REC[4, 1];
BASE_REC = MEMBERS_REC;
L0500();
/*  Amend Courses records */
L0800();
/*  Remove APACS link */
if (ALL_FILES_DELETE == "Y") {
L0200();
/*  Amend Member Usage */
L0300();
/*  Delete Bonus Records */
L0400();
/*  Write off debtors records */
}
}
/*  Deletion if single member */
if (RECORD_TYPE == "NORMAL") {
MEM_ID = AMD_KEY;
STUDENT_KEY = MEM_ID;
L0550();
if (STUDENT && GET_STUDENT_ID == "N") {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
COURSE_STUDENT_NO = "NOT.DELETED";
return;
}
NAME = MEMBERS_REC[4, 1];
L0100();
/*  Delete any Direct Debit records */
L0700();
/*  Delete any Cash Debit records */
BASE_REC = MEMBERS_REC;
L0500();
/*  Amend Courses records */
L0800();
/*  Remove APACS link */
if (ALL_FILES_DELETE == "Y") {
L0200();
/*  Amend Member Usage */
L0300();
/*  Delete Bonus Records */
L0400();
/*  Write off debtors records */
}
}
DELETE(COMMON.FILES[MEMBERS], AMD_KEY);
nrf0 = "D";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref AMD_KEY);
ADT_MEMBER_ID = AMD_KEY;
L0600();
AMD_KEYZ = AMD_KEY;
MEMBERS_RECZ = MEMBERS_REC;
FL000_45 = new FL000_45(ref AMD_KEYZ, ref MEMBERS_RECZ);
if (PHOTO_SITE) {
if (READV(ref PHOTO_THERE, FL_PHOTO_FOLDER, AMD_KEY + ".JPG", 1)) {
EXECUTE("DELETE FL.PHOTO.FOLDER ", string.Empty, string.Empty, string.Empty, string.Empty);
}
}
return;
}
void L0100() {
/*  Delete Direct Debits if necessary */
MAT(ref DELETED_DEBITS_REC, "");
DEL_REC = FALSE;
BANK_DETS_ID = "1*" + AMD_KEY;
DD_ID = "1*" + AMD_KEY + "*1";
DD_DEBTOR_ID = BANK_DETS_ID;
START_DATE = TODAYS_DATE;
if (MATREAD(ref BANK_REC, COMMON.FILES[FL_BANK_DETAILS], BANK_DETS_ID)) {
for(BANK_ARRAY = 1; BANK_ARRAY <= 10; BANK_ARRAY += 1) {
DELETED_DEBITS_REC[BANK_ARRAY] = BANK_REC[BANK_ARRAY];
}
DELETE(FL_BACS_REF, BANK_REC[BANK_BACS_REF]);
DELETE(COMMON.FILES[FL_BANK_DETAILS], BANK_DETS_ID);
nrf0 = "D";
nrf1 = "FL.BANK.DETAILS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BANK_DETS_ID);
DEL_REC = TRUE;
}
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID)) {
for(DEBIT_ARRAY = 1; DEBIT_ARRAY <= 20; DEBIT_ARRAY += 1) {
DELETED_ARRAY = DEBIT_ARRAY + 10;
DELETED_DEBITS_REC[DELETED_ARRAY] = DIRECT_DEBIT_REC[DEBIT_ARRAY];
}
DELETE(COMMON.FILES[FL_DIRECT_DEBITS], DD_ID);
nrf0 = "D";
nrf1 = "FL.DIRECT.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_ID);
DEL_REC = TRUE;
}
if (MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID)) {
for(DEBTOR_ARRAY = 1; DEBTOR_ARRAY <= 10; DEBTOR_ARRAY += 1) {
DELETED_ARRAY = DEBTOR_ARRAY + 30;
DELETED_DEBITS_REC[DELETED_ARRAY] = DD_DEBTORS_REC[DEBTOR_ARRAY];
}
DELETE(FL_DD_DEBTORS, DD_DEBTOR_ID);
nrf0 = "D";
nrf1 = "FL.DD.DEBTORS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DD_DEBTOR_ID);
DEL_REC = TRUE;
}
if (DEL_REC == TRUE) {
MATWRITE(DELETED_DEBITS_REC, FL_DELETED_DEBITS, AMD_KEY);
if (READ(ref TRANS_LOG_REC, FL_DELETED_DEBITS, AMD_KEY)) {
nrf0 = "W";
nrf1 = "FL.DELETED.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref AMD_KEY);
}
}
return;
}
void L0200() {
/*  Amend Member Usage Records */
NEW_MEMBER_NO = MEM_ID + MEMBER_SUFFIX;
REC_COUNT = 1;
if (READ(ref MUDEL_REC, FL_MUDEL_WORK, MEM_ID)) {
do {
USAGE_KEY = MUDEL_REC[REC_COUNT];
if (USAGE_KEY == "") break;
if (!READ(ref USG_REC, COMMON.FILES[FL_MEMBER_USAGE], USAGE_KEY)) { USG_REC = ""; }
NEW_USAGE_KEY = NEW_MEMBER_NO + "*" + FIELD(USAGE_KEY, "*", 2) + "*" + FIELD(USAGE_KEY, "*", 3);
WRITE(USG_REC, COMMON.FILES[FL_MEMBER_USAGE], NEW_USAGE_KEY);
TRANS_LOG_REC = USG_REC;
nrf0 = "W";
nrf1 = "FL.MEMBER.USAGE";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref NEW_USAGE_KEY);
DELETE(COMMON.FILES[FL_MEMBER_USAGE], USAGE_KEY);
nrf0 = "D";
nrf1 = "FL.MEMBER.USAGE";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref USAGE_KEY);
REC_COUNT = REC_COUNT + 1;
} while (true);
}
return;
}
void L0300() {
/*  Delete Bonus records */
REC_COUNT = 1;
if (READ(ref BON_REC, FL_BONUS_WORK, MEM_ID)) {
do {
BONUS_KEY = BON_REC[REC_COUNT];
if (BONUS_KEY == "") break;
DELETE(FL_BONUS, BONUS_KEY);
nrf0 = "D";
nrf1 = "FL.BONUS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BONUS_KEY);
BONUS_FLAG = TRUE;
REC_COUNT = REC_COUNT + 1;
} while (true);
}
REC_COUNT = 1;
if (READ(ref LOST_REC, FL_BONLST_WORK, MEM_ID)) {
do {
LOST_KEY = LOST_REC[REC_COUNT];
if (LOST_KEY == "") break;
DELETE(FL_BONUS_LOST, BONUS_KEY);
nrf0 = "D";
nrf1 = "FL.BONUS.LOST";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref BONUS_KEY);
BONUS_FLAG = TRUE;
REC_COUNT = REC_COUNT + 1;
} while (true);
return;
}
}
void L0400() {
/*  Write off debtors record */
DEBTOR_KEY = COMMON.CENTRE + "*" + MEM_ID;
if (READ(ref DEB_REC, COMMON.FILES[FL_DEBTORS], DEBTOR_KEY)) {
FL248 = new FL248(ref NAME, ref MEM_ID, ref DEB_REC, ref DEBTOR_KEY);
DEBTORS_FLAG = TRUE;
}
return;
}
void L0550() {
/*  Check if student */
STUDENT = TRUE;
if (!(MATREAD(ref STUDENT_REC, FL_STUDENTS, STUDENT_KEY))) {
if (!(MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, STUDENT_KEY))) {
STUDENT = FALSE;
return;
}
}
return;
}
void L0500() {
/*  Amend Courses records */
if (!(MATREAD(ref STUDENT_REC, FL_STUDENTS, MEM_ID))) {
if (!(MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, MEM_ID))) {
return;
}
}
if (!READ(ref COURSE_PARAMS, FL_COURSE_PARAMS, "COURSE.PARAMS")) { COURSE_PARAMS = ""; }
GET_STUDENT_ID = COURSE_PARAMS[1, 1];
if (GET_STUDENT_ID == "") {
GET_STUDENT_ID = "FL.STUDENT.PREFIX";
}
nrf0 = "N";
CallAt_GET_STUDENT_ID = new CallAt_GET_STUDENT_ID(ref GET_STUDENT_ID, ref nrf0, ref NEW_STUDENT_NO);
nrf0 = TRUE;
nrf1 = "";
nrf2 = "";
FL766 = new FL766(ref MEM_ID, ref NEW_STUDENT_NO, ref STUDENT_REC, ref nrf0, ref nrf1, ref nrf2);
MAT(ref STUDENT_REC, "");
MAT(ref WAIT_STUDENT_REC, "");
/*  DJA 4.8.00 */
/*  As membership record is being deleted, selected */
/*  details must now be stored on FL.STUDENTS for */
/*  the first time. */
/*  The student record(s) must be re-read because they have already */
/*  been written by FL766 */
if (MATREAD(ref STUDENT_REC, FL_STUDENTS, NEW_STUDENT_NO)) {
STUDENT_REC[STUDENT_TITLE] = BASE_REC[6, 1];
STUDENT_REC[STUDENT_FORENAME] = BASE_REC[29, 1];
STUDENT_REC[STUDENT_SURNAME] = BASE_REC[4, 1];
STUDENT_REC[STUDENT_ADDRESS1] = BASE_REC[10, 1];
STUDENT_REC[STUDENT_ADDRESS2] = BASE_REC[10, 2];
STUDENT_REC[STUDENT_ADDRESS3] = BASE_REC[10, 3];
STUDENT_REC[STUDENT_ADDRESS4] = BASE_REC[10, 4];
STUDENT_REC[STUDENT_POST_CODE] = BASE_REC[10, 5];
STUDENT_REC[STUDENT_SEX] = BASE_REC[7, 1];
STUDENT_REC[STUDENT_HOME_TEL] = BASE_REC[11, 1];
STUDENT_REC[STUDENT_WORK_TEL] = BASE_REC[12, 1];
STUDENT_REC[STUDENT_DOB] = BASE_REC[21, 1];
MATWRITE(STUDENT_REC, FL_STUDENTS, NEW_STUDENT_NO);
}
if (MATREAD(ref WAIT_STUDENT_REC, FL_WAIT_STUDENTS, NEW_STUDENT_NO)) {
WAIT_STUDENT_REC[WAIT_STUD_TITLE] = BASE_REC[6, 1];
WAIT_STUDENT_REC[WAIT_STUD_FORENAME] = BASE_REC[29, 1];
WAIT_STUDENT_REC[WAIT_STUD_SURNAME] = BASE_REC[4, 1];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS1] = BASE_REC[10, 1];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS2] = BASE_REC[10, 2];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS3] = BASE_REC[10, 3];
WAIT_STUDENT_REC[WAIT_STUD_ADDRESS4] = BASE_REC[10, 4];
WAIT_STUDENT_REC[WAIT_STUD_POST_CODE] = BASE_REC[10, 5];
WAIT_STUD_SEX = BASE_REC[7, 1];
WAIT_STUDENT_REC[WAIT_STUD_TEL_HOME] = BASE_REC[11, 1];
WAIT_STUDENT_REC[WAIT_STUD_TEL_WORK] = BASE_REC[12, 1];
WAIT_STUDENT_REC[WAIT_STUD_DOB] = BASE_REC[21, 1];
MATWRITE(WAIT_STUDENT_REC, FL_WAIT_STUDENTS, NEW_STUDENT_NO);
}
if (STUDENT_REC[STUDENT_SURNAME] != "") {
COURSE_STUDENT_NO = NEW_STUDENT_NO;
} else {
if (WAIT_STUDENT_REC[WAIT_STUD_SURNAME] != "") { COURSE_STUDENT_NO = NEW_STUDENT_NO; }
}
return;
}
void L0600() {
/*  Update ADT.LOG */
MAT(ref ADT_REC, "");
ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + ADT_MEMBER_ID;
ADT_REC[ADT_DATE] = TODAYS_DATE;
ADT_REC[ADT_USER] = U_INITS;
ADT_REC[ADT_REASON] = "MEMBERSHIP DELETED - " + CALLING_PROGRAM;
ADT_REC[ADT_TIME] = TIME();
if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
SEQ_NO = SEQ_NO + 1;
MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
return;
}
void L0700() {
/*  Delete Cash Debit record */
if (READ(ref CASH_REC, FL_CASH_DEBITS, MEM_ID)) {
WRITE(CASH_REC, FL_DELETED_CASH, MEM_ID);
TRANS_LOG_REC = CASH_REC;
nrf0 = "W";
nrf1 = "FL.DELETED.CASH";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEM_ID);
DELETE(FL_CASH_DEBITS, MEM_ID);
nrf0 = "D";
nrf1 = "FL.CASH.DEBITS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEM_ID);
}
return;
}
void L0800() {
/*  Remove APACS link */
APACS_NO = MEMBERS_REC[42];
if (READ(ref APACS_REF, FL_APACS_NUMBERS, APACS_NO)) {
DELETE(FL_APACS_NUMBERS, APACS_NO);
nrf0 = "D";
nrf1 = "FL.APACS.NUMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref APACS_NO);
}
return;
/*  End of Program */
return;
}
}
}
