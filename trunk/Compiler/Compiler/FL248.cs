//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL248 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_NAME_SEARCH = 28;
readonly UvVar FL_DEBTORS = 43;
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
readonly UvVar FL_BOOKINGS = 6;
readonly UvVar BOOK_MEMBER = 1;
readonly UvVar BOOK_NAME = 2;
readonly UvVar BOOK_FLOOR_AREAS = 3;
readonly UvVar BOOK_PAYMENT_STAT = 4;
readonly UvVar BOOK_PRICE = 5;
readonly UvVar BOOK_CANCEL_DATE = 6;
readonly UvVar BOOK_CANCEL_REASON = 7;
readonly UvVar BOOK_MADE_USER = 8;
readonly UvVar BOOK_MADE_DATE = 9;
readonly UvVar BOOK_MADE_TIME = 10;
readonly UvVar BOOK_TICKET = 11;
readonly UvVar BOOK_CONCESS = 12;
readonly UvVar BOOK_WRITE_OFF_DATE = 13;
readonly UvVar BOOK_WRITE_OFF_USER = 14;
readonly UvVar BOOK_PER_PERSON_NOS = 15;
readonly UvVar BOOK_PERSON = 16;
readonly UvVar BOOK_PERSON_AMOUNT = 17;
readonly UvVar BOOK_PERSON_DATE = 18;
readonly UvVar BOOK_PERSON_TICKET = 19;
readonly UvVar BOOK_REDEEM_POINTS = 20;
readonly UvVar BOOK_REDEEM_VALUE = 21;
readonly UvVar BOOK_WEB = 22;
readonly UvVar BOOK_UNIT_QUANTITY = 23;
readonly UvVar BOOK_UNIT_PRICE = 24;
readonly UvVar BOOK_AUTH_CODE = 25;
readonly UvVar BOOK_BASKET_REF = 26;
readonly UvVar BOOK_BONUS_POINTS = 27;
readonly UvVar BOOK_PROMOTION = 28;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] NAME_SEARCH_REC = new UvVar[100];
UvVar[] DEBTORS_REC = new UvVar[100];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] BOOKINGS_REC = new UvVar[30];
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar NAME = "";
UvVar MEMBER = "";
UvVar DEB_REC = "";
UvVar DEBTOR_KEY = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar AM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar NO_OF_BOOKINGS = "";
UvVar UPPER_ID = "";
UvVar NAME_SREC = "";
UvVar NO_OF_LINES = "";
UvVar BOOK = "";
FLTX2 FLTX2;
UvVar DEL_DATE = "";
UvVar DEL_TIME = "";
UvVar DEL_SPORT = "";
UvVar DEL_SPNO = "";
UvVar LINE_REMOVED = "";
UvVar LINE_NO = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL248(ref UvVar NAME, ref UvVar MEMBER, ref UvVar DEB_REC, ref UvVar DEBTOR_KEY) {
this.NAME = NAME;
this.MEMBER = MEMBER;
this.DEB_REC = DEB_REC;
this.DEBTOR_KEY = DEBTOR_KEY;
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
/*  Delete all entries for particular debtor */
/*  Dated  : 13/8/98 */
/*  Author : Harjas Sidhu */
/* ********************************************************************** */
PROGRAM = "FL248";
/*  Files */
#region INCLUDE FL.FILES FL.NAME.SEARCH

#endregion
#region INCLUDE FL.FILES FL.DEBTORS

#endregion
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
#region INCLUDE FL.FILES FL.BOOKINGS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
/*  Variables */
NO_OF_BOOKINGS = DCOUNT(DEB_REC, AM);
UPPER_ID = OCONV(NAME, "MCU");
if (!READU(ref NAME_SREC, COMMON.FILES[FL_NAME_SEARCH], UPPER_ID)) { NAME_SREC = ""; }
NO_OF_LINES = DCOUNT(NAME_SREC, AM);
for(BOOK = 1; BOOK <= NO_OF_BOOKINGS; BOOK += 1) {
if (!(MATREAD(ref BOOKINGS_REC, COMMON.FILES[FL_BOOKINGS], DEB_REC[BOOK]))) {
MAT(ref BOOKINGS_REC, "");
}
BOOKINGS_REC[BOOK_WRITE_OFF_DATE] = TODAYS_DATE;
BOOKINGS_REC[BOOK_WRITE_OFF_USER] = U_INITS;
BOOKINGS_REC[BOOK_PAYMENT_STAT] = "Y";
MATWRITE(BOOKINGS_REC, COMMON.FILES[FL_BOOKINGS], DEB_REC[BOOK]);
if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_BOOKINGS], DEB_REC[BOOK])) { TRANS_LOG_REC = ""; }
nrf0 = "W";
nrf1 = "FL.BOOKINGS";
nrf2 = DEB_REC[BOOK];
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
DEL_DATE = FIELD(DEB_REC[BOOK], "*", 3);
DEL_TIME = FIELD(DEB_REC[BOOK], "*", 5);
DEL_SPORT = FIELD(DEB_REC[BOOK], "*", 2);
DEL_SPNO = FIELD(DEB_REC[BOOK], "*", 4);
/*  remove line from name search file */
LINE_REMOVED = FALSE;
for(LINE_NO = 1; LINE_NO <= NO_OF_LINES && NOT(LINE_REMOVED); LINE_NO += 1) {
if (NAME_SREC[LINE_NO, 1] == DEL_DATE && NAME_SREC[LINE_NO, 2] == DEL_TIME && NAME_SREC[LINE_NO, 4] == DEL_SPORT && NAME_SREC[LINE_NO, 5] == DEL_SPNO && NAME_SREC[LINE_NO, 3] == COMMON.CENTRE) {
/*            NAME.SREC = DELETE(NAME.SREC,LINE.NO,0,0) */
NAME_SREC[LINE_NO, 7] = "Y";
LINE_REMOVED = TRUE;
}
}
}
DELETE(COMMON.FILES[FL_DEBTORS], DEBTOR_KEY);
nrf0 = "D";
nrf1 = "FL.DEBTORS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref DEBTOR_KEY);
UPPER_ID = OCONV(NAME, "MCU");
WRITE(NAME_SREC, COMMON.FILES[FL_NAME_SEARCH], UPPER_ID);
TRANS_LOG_REC = NAME_SREC;
nrf0 = "W";nrf1 = "FL.NAME.SEARCH";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref UPPER_ID);
return;
/*  End of Program */
return;
}
}
}
