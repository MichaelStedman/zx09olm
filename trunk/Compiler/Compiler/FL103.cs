//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL103 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FWTERM_MODE = 0;
readonly UvVar TOUCHSCREEN_MODE = 1;
readonly UvVar SILENT_MODE = 2;
readonly UvVar FL_MEMBERS = 2;
readonly UvVar MEMBER_CENTRE = 1;
readonly UvVar MEMBER_TYPE = 2;
readonly UvVar MEMBER_ORIG_PRICE = 3;
readonly UvVar MEMBER_SURNAMES = 4;
readonly UvVar MEMBER_INITIALS = 5;
readonly UvVar MEMBER_TITLES = 6;
readonly UvVar MEMBER_SEXES = 7;
readonly UvVar MEMBER_AGES = 8;
readonly UvVar MEMBER_RENEW_LETTER = 9;
readonly UvVar MEMBER_SALUTATION = 9;
readonly UvVar MEMBER_ADDRESS = 10;
readonly UvVar MEMBER_HOME_PHONE = 11;
readonly UvVar MEMBER_BUS_PHONE = 12;
readonly UvVar MEMBER_EXPIRY_DATE = 13;
readonly UvVar MEMBER_DATE_JOINED = 14;
readonly UvVar MEMBER_ISSUING_OPER = 15;
readonly UvVar MEMBER_ANALYSIS_CODES = 16;
readonly UvVar MEMBER_USED_CODES = 17;
readonly UvVar MEMBER_MAIN = 18;
readonly UvVar MEMBER_SUB = 19;
readonly UvVar MEMBER_RECEIPT = 20;
readonly UvVar MEMBER_DOBS = 21;
readonly UvVar MEMBER_LAST_CHANGED = 22;
readonly UvVar MEMBER_HF_CARD_DATE = 23;
readonly UvVar MEMBER_INSTALMENTS = 24;
readonly UvVar MEMBER_FULL_EXPIRY = 25;
readonly UvVar MEMBER_REMINDER_DATES = 26;
readonly UvVar MEMBER_RESTRICTIONS = 27;
readonly UvVar MEMBER_DIRECT_DEBIT = 28;
readonly UvVar MEMBER_FORENAMES = 29;
readonly UvVar MEMBER_COMMENTS = 30;
readonly UvVar MEMBER_PART_COMPLETE = 31;
readonly UvVar MEMBER_START_DATE = 32;
readonly UvVar MEMBER_RENEWAL_DATE = 33;
readonly UvVar MEMBER_DD_DAY = 34;
readonly UvVar MEMBER_PRICES = 35;
readonly UvVar MEMBER_WEB_BARRED = 36;
readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
readonly UvVar MEMBER_EMAIL_SALES = 38;
readonly UvVar MEMBER_DDFLAGS = 39;
readonly UvVar MEMBER_OLDNOS = 40;
readonly UvVar MEMBER_PROSPECT_NO = 41;
readonly UvVar MEMBER_APACS_NO = 42;
readonly UvVar MEMBER_MOBILE_PHONE = 43;
readonly UvVar MEMBER_JOB_TITLE = 44;
readonly UvVar MEMBER_DEPARTMENT = 45;
readonly UvVar D_MEMBERS = 65;
readonly UvVar MEMBERS = 2;
readonly UvVar CONTROL = 10;
readonly UvVar FL_DEBTORS = 43;
readonly UvVar DD_DEBTORS_DATES = 1;
readonly UvVar DD_DEBTORS_OWED = 2;
readonly UvVar DD_DEBTORS_TOTAL_OWED = 3;
readonly UvVar DD_DEBTORS_REASON = 4;
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] DEBTORS_REC = new UvVar[100];
UvVar[] DD_DEBTORS_REC = new UvVar[10];
UvVar[] DIRECT_DEBIT_REC = new UvVar[20];
#endregion
#region Variables
UvVar TICKET_REC = "";
UvVar MEMBER_REQUIRED = "";
UvVar RUN_CHECKS = "";
UvVar TODAYS_DATE = "";
UvVar REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_TEXT2 = "";
UvVar SCREEN_DATA = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar VM = "";
UvVar MEMBER = "";
UvVar PROGRAM = "";
UvVar CLEAR_MEMBER_MESS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar FL_DD_DEBTORS = "";
UvVar FL_BACS_REF = "";
UvVar HBC_TICKET_SPECIAL = "";
UvVar DAYS_TO_EXPIRE = "";
UvVar DEADLINE = "";
UvVar INDEX_REQUEST = "";
UvVar AUTO_REC = "";
UvVar PREFIX_LEN = "";
UvVar FIXED_LENGTH = "";
UvVar MULTI_CARD = "";
UvVar MEMBER_PROGRAM = "";
UvVar SMART_CARD = "";
CallAt_MEMBER_PROGRAM CallAt_MEMBER_PROGRAM;
FL019 FL019;
UvVar IFACE_TYPE = "";
UvVar SMART_MEMBER_NO = "";
UvVar DISPLAY_MODE = "";
FL_SMARTCARD FL_SMARTCARD;
UvVar TRANS_AMOUNT = "";
UvVar TRANS_TYPE = "";
UvVar TRANS_ID = "";
UvVar INTERACT = "";
UvVar CARD_ERROR_TYPE = "";
UvVar CARD_ERROR_MESS = "";
UvVar EPURSE_BALANCE = "";
UvVar LOYALTY_BALANCE = "";
UvVar APACS_NO = "";
UvVar MEMBER_NAME = "";
UvVar ANS = "";
UvVar POS = "";
UvVar SEARCH_ROUTE = "";
UvVar MEMBER_NUMBER = "";
FL000_20 FL000_20;
UvVar ACTUAL_NO = "";
FL000_40 FL000_40;
UvVar MEM_NO = "";
UvVar TITLE = "";
UvVar TYPE = "";
FL535 FL535;
UvVar DD_ID = "";
UvVar CONTINUE = "";
UvVar YES_NO = "";
UvVar DD_DEBTOR_ID = "";
UvVar MEMSHP_START = "";
UvVar EXPIRY = "";
UvVar MEM_COUNT = "";
FL292 FL292;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL103(ref UvVar TICKET_REC, ref UvVar MEMBER_REQUIRED, ref UvVar RUN_CHECKS) {
this.TICKET_REC = TICKET_REC;
this.MEMBER_REQUIRED = MEMBER_REQUIRED;
this.RUN_CHECKS = RUN_CHECKS;
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
/*  COPY OF FL383 EXCEPT THAT IT DOESNT PROMPT FOR MEMBER NO */
/*  JUST ASSUMES IT HAS BEEN ENTERED */
PROGRAM = "FL103";
CLEAR_MEMBER_MESS = TRUE;
if (TICKET_REC == CLEAR_MEMBER_MESS) {
PRINT(AT(0, 20) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK + AT(3, 20) + SPACE(40));
return;
}
/*  FILES */
#region INCLUDE FL.FILES FL.MEMBERS

/*  DJA 14.8.01 Separate file includes for web bookings */
/*              (see FL.MEMBERS.VAR for field names) */
#region INCLUDE FL.FILES FL.MEMBERS.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.DIM

SIZE_OF_MEMBERS_REC = 45;
/*  Must keep in tandem */

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.VAR

/*  Hammersmith & Fulham - Membership Card production systems */
/*  Two tier reminder system */

#endregion

#endregion
#region INCLUDE FL.FILES FL.DEBTORS

#endregion
#region INCLUDE FL.FILES FL.DD.DEBTORS

if (!OPEN("FL.DD.DEBTORS", out FL_DD_DEBTORS)) { STOP("201", "FL.DD.DEBTORS"); }

#endregion
#region INCLUDE FL.FILES FL.BACS.REF

if (!OPEN("FL.BACS.REF", out FL_BACS_REF)) { STOP("201", FL_BACS_REF); }

#endregion
#region INCLUDE FL.FILES FL.DIRECT.DEBITS

#endregion
if (MEMBER_REQUIRED == FALSE) {
if (!(READV(ref HBC_TICKET_SPECIAL, COMMON.FILES[CONTROL], "HBC.TICKET.SPECIAL", 1))) {
return;
}
if (HBC_TICKET_SPECIAL == "") { return; }
}
if (!READV(ref DAYS_TO_EXPIRE, COMMON.FILES[D_MEMBERS], "DAYS", 1)) { DAYS_TO_EXPIRE = 1; }
DEADLINE = TODAYS_DATE + DAYS_TO_EXPIRE;
if (!(READV(ref INDEX_REQUEST, COMMON.FILES[CONTROL], "INDEX.REQUEST", 1))) {
INDEX_REQUEST = "I" + VM + "S" + VM + "A";
}
if (!READ(ref AUTO_REC, COMMON.FILES[CONTROL], "AUTOMATIC.CONCESS")) { AUTO_REC = ""; }
PREFIX_LEN = AUTO_REC[2];
FIXED_LENGTH = AUTO_REC[4];
MULTI_CARD = AUTO_REC[11, 1];
L10:;
if (!(READV(ref MEMBER_PROGRAM, COMMON.FILES[CONTROL], "MEMBER.NO.ALLOCATION", 3))) {
MEMBER_PROGRAM = "";
}
if (!(READV(ref SMART_CARD, COMMON.FILES[CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (MEMBER_PROGRAM != "") {
CallAt_MEMBER_PROGRAM = new CallAt_MEMBER_PROGRAM(ref MEMBER_PROGRAM, ref MEMBER);
if (MEMBER == COMMON.ABANDON) {
TICKET_REC = "";
MEMBER_REQUIRED = COMMON.ABANDON;
return;
}
} else {
MEMBER = "";
nrf0 = 20;
FL019 = new FL019(ref nrf0, ref MEMBER);
if (MEMBER == "") {
if (SMART_CARD) {
IFACE_TYPE = 1;
SMART_MEMBER_NO = "";
DISPLAY_MODE = FWTERM_MODE;
FL_SMARTCARD = new FL_SMARTCARD(ref IFACE_TYPE, ref SMART_MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref DISPLAY_MODE, ref INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
if (SMART_MEMBER_NO != "") {
MEMBER = SMART_MEMBER_NO;
}
}
}
MEMBER = OCONV(MEMBER, "MCU");
/*  Upper Case Convert */
if (MEMBER == COMMON.ABANDON) {
TICKET_REC = "";
MEMBER_REQUIRED = COMMON.ABANDON;
return;
}
/*   THE FOLLOWING SECTION PROCESSES NUMBERS READ BY MAG STRIPE READERS AT */
/*   MAIDSTONE */
MEMBER_NAME = "Invalid";
if (MEMBER.Substring(1, 1) == ";") {
if (MEMBER.Substring(3, 1) == 0) {
MEMBER = MEMBER.Substring(4, 4);
} else {
MEMBER = MEMBER.Substring(3, 5);
}
INPUT(out ANS, 1);
}
}
if (MEMBER == "") {
MEMBER_NAME = "Non-Member";
} else {
if (LOCATE(MEMBER, INDEX_REQUEST, 1, 0, 1, ref POS, "AL")) {
SEARCH_ROUTE = MEMBER;
MEMBER_NUMBER = "";
FL000_20 = new FL000_20(ref MEMBER_NUMBER, ref SEARCH_ROUTE);
if (MEMBER_NUMBER == "") {
goto L10;
}
MEMBER = MEMBER_NUMBER;
}
if (READ(ref ACTUAL_NO, FL_BACS_REF, MEMBER)) {
MEMBER = ACTUAL_NO[1, 1];
}
if (NUM(MEMBER) && FIXED_LENGTH == "") {
FL000_40 = new FL000_40(ref MEMBER);
}
MEMBER_NAME = "";
if (!(READV(ref MEMBER_NAME, COMMON.FILES[MEMBERS], MEMBER, 4))) {
if (PREFIX_LEN > 0) {
if (FIXED_LENGTH == "") {
MEM_NO = MEMBER.Substring(PREFIX_LEN + 1, LEN(MEMBER) - PREFIX_LEN);
MEMBER = MEMBER.Substring(1, PREFIX_LEN) + FORMAT(MEM_NO, "R%5");
}
if (!(READV(ref MEMBER_NAME, COMMON.FILES[MEMBERS], MEMBER, 4))) {
MEMBER_NAME = "Invalid";
MEMBER = "";
}
} else {
MEMBER_NAME = "Invalid";
MEMBER = "";
}
}
if (MEMBER_NAME != "Invalid") {
MEMBER_NAME = MEMBER_NAME[1, 1];
if (!READV(ref TITLE, COMMON.FILES[MEMBERS], MEMBER, 6)) { TITLE = ""; }
if (!READV(ref TYPE, COMMON.FILES[MEMBERS], MEMBER, 2)) { TYPE = ""; }
/* !       PRINT @(10,20):MEMBER 'L#13':' ':TITLE<1,1>:' ':MEMBER.NAME:' (':TYPE:')' */
} else {
goto L99;
}
if (RUN_CHECKS == FALSE) { goto L99; }
if (MEMBER != "") {
if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], MEMBER))) {
MAT(ref MEMBERS_REC, "");
}
/*  check for messages */
FL535 = new FL535(ref MEMBER, ref PROGRAM);
/*  Check for Frozen direct debits */
DD_ID = "1*" + MEMBER + "*1";
if (MATREAD(ref DIRECT_DEBIT_REC, COMMON.FILES[FL_DIRECT_DEBITS], DD_ID)) {
if (DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE] != "" && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1] <= TODAYS_DATE && DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2] >= TODAYS_DATE) {
PRINT(AT(0, 23) + REV_VID);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
CONTINUE = FALSE;
do {
PRINT(AT(2, 23) + "Member's DD frozen from ");
PRINT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 1], "D2/"));
PRINT(" - ");
PRINT(OCONV(DIRECT_DEBIT_REC[DIRECT_DEBIT_FREEZE_DATE][1, 2], "D2/"));
PRINT(" Continue ? (Y/N) ");
INPUT(out YES_NO, 2);
if (YES_NO == "N" || YES_NO == "n") {
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
TICKET_REC = "";
MEMBER_REQUIRED = COMMON.ABANDON;
return;
}
if (YES_NO == "Y" || YES_NO == "y") {
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_TEXT2 + SCREEN_BACK);
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
CONTINUE = TRUE;
} else {
CONTINUE = FALSE;
}
if (CONTINUE == TRUE) break;
} while (true);
}
}
/*  Check for Debts */
if (MATREAD(ref DEBTORS_REC, COMMON.FILES[FL_DEBTORS], COMMON.CENTRE + "*" + MEMBER)) {
PRINT(AT(0, 23) + REV_VID);
/*  SCREEN.FOOT.FORE:SCREEN.FOOT.BACK: */
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
L20:;
PRINT(AT(2, 23) + "Member " + MEMBER + " is a current debtor do you wish to continue Y/N ");
INPUT(out YES_NO, 1);
if (YES_NO == "N" || YES_NO == "n") {
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
TICKET_REC = "";
return;
}
if (YES_NO == "Y" || YES_NO == "y") {
PRINT(AT(0, 23) + NRM_VID + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_TEXT2 + SCREEN_BACK);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
} else {
goto L20;
}
}
/*  Check for Direct Debit Debts */
DD_DEBTOR_ID = "1*" + MEMBER;
if (MATREAD(ref DD_DEBTORS_REC, FL_DD_DEBTORS, DD_DEBTOR_ID)) {
PRINT(AT(0, 23) + REV_VID);
/*  SCREEN.FOOT.FORE:SCREEN.FOOT.BACK: */
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
L30:;
PRINT(AT(2, 23) + "Member " + MEMBER + " is a current DD debtor.  Continue Y/N ? ");
INPUT(out YES_NO, 1);
if (YES_NO == "N" || YES_NO == "n") {
PRINT(AT(0, 23) + NRM_VID + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
TICKET_REC = "";
return;
}
if (YES_NO == "Y" || YES_NO == "y") {
PRINT(AT(0, 23) + NRM_VID + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_TEXT2 + SCREEN_BACK);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
} else {
goto L30;
}
}
/*  Check membership start date */
if (!(READV(ref MEMSHP_START, COMMON.FILES[MEMBERS], MEMBER, 32))) {
if (!READV(ref MEMSHP_START, COMMON.FILES[MEMBERS], MEMBER, 14)) { MEMSHP_START = TODAYS_DATE; }
}
if (MEMSHP_START > TODAYS_DATE) {
L40:;
PRINT(AT(78, 23) + NRM_VID);
PRINT(AT(1, 23) + REV_VID + TITLE[1, 1] + " " + MEMBER_NAME[1, 1] + "'s membership starts on " + OCONV(MEMSHP_START, "D") + ", Continue ? ");
INPUT(out YES_NO, 1);
PRINT(AT(0, 23) + COMMON.EOL);
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
// BEGIN CASE
// CASE
if (YES_NO == "N" || YES_NO == "n") {
TICKET_REC = "";
return;
}// CASE
else if (YES_NO == "Y" || YES_NO == "y") {
NULL();
}// CASE
else if (OTHERWISE) {
goto L40;
}
// END CASE
}
/*  Check for expiry date */
if (!READV(ref EXPIRY, COMMON.FILES[MEMBERS], MEMBER, 13)) { EXPIRY = TODAYS_DATE + 1; }
MEM_COUNT = DCOUNT(MEMBERS_REC[MEMBER_EXPIRY_DATE], VM);
if (MEM_COUNT > 1 || MULTI_CARD == "Y") {
nrf0 = "10";
nrf1 = "10";
FL292 = new FL292(ref MEMBERS_REC, ref DEADLINE, ref nrf0, ref nrf1, ref MEMBER_REQUIRED);
goto L99;
}
if (EXPIRY < TODAYS_DATE || EXPIRY < DEADLINE) {
L85:;
PRINT(AT(78, 23) + NRM_VID);
if (EXPIRY < TODAYS_DATE) {
PRINT(AT(1, 23) + REV_VID + TITLE[1, 1] + " " + MEMBER_NAME[1, 1] + "'s membership expired on " + OCONV(EXPIRY, "D") + ", Continue ? ");
} else {
PRINT(AT(1, 23) + DIM_VID + TITLE[1, 1] + " " + MEMBER_NAME[1, 1] + "'s membership expires on " + OCONV(EXPIRY, "D") + ", press <RETURN> ");
}
INPUT(out YES_NO, 1);
/*               PRINT @(0,23) : EOL : */
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(1, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
if (EXPIRY < TODAYS_DATE) {
// BEGIN CASE
// CASE
if (YES_NO == "N" || YES_NO == "n") {
TICKET_REC = "";
return;
}// CASE
else if (YES_NO == "Y" || YES_NO == "y") {
NULL();
}// CASE
else if (OTHERWISE) {
goto L85;
}
// END CASE
}
}
}
}
L99:;
if (NOT(MEMBER_REQUIRED == COMMON.ABANDON)) {
TICKET_REC[10] = MEMBER;
if (MEMBER == "") {
MEMBER_REQUIRED = MEMBER_NAME;
}
}
return;
}
}
}
