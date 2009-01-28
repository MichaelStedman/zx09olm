//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_20 : UvBase
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
readonly UvVar EXIT = 2;
readonly UvVar BACKUP = 3;
readonly UvVar ERROR = 7;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
readonly UvVar FL_CONTROL = 10;
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
readonly UvVar FL_FULL_NAME_INDEX = 110;
readonly UvVar FNI_MEMBER_IDS = 1;
readonly UvVar FNI_INITS = 2;
readonly UvVar FNI_NAMES = 3;
readonly UvVar FNI_ADDRESS_LINE1S = 4;
readonly UvVar FNI_DOBS = 5;
readonly UvVar FL_SOUNDSLIKE_NAME_INDEX = 111;
readonly UvVar SNI_MEMBER_IDS = 1;
readonly UvVar SNI_INITS = 2;
readonly UvVar SNI_NAMES = 3;
readonly UvVar SNI_ADDRESS_LINE1S = 4;
readonly UvVar FL_ADDRESS_INDEX = 81;
readonly UvVar ADD_INDEX_MEMBER_IDS = 1;
readonly UvVar ADD_INDEX_INITS = 2;
readonly UvVar ADD_INDEX_NAMES = 3;
readonly UvVar ADD_INDEX_ADDRESS_LINE1S = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] FNI_REC = new UvVar[5];
UvVar[] SNI_REC = new UvVar[5];
UvVar[] ADD_INDEX_REC = new UvVar[5];
#endregion
#region Variables
UvVar MEMBER_NUMBER = "";
UvVar SEARCH_ROUTE = "";
UvVar SCREEN_FOOT_BACK = "";
UvVar SCREEN_FOOT_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar PROGRAM = "";
UvVar THROWAWAY_CHARACTERS = "";
UvVar MEMBER_SEARCH_TYPE = "";
FL000_21 FL000_21;
UvVar INTERACT = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar NAME_INDEX_REQUEST = "";
UvVar SOUND_INDEX_REQUEST = "";
UvVar ADDRESS_INDEX_REQUEST = "";
UvVar DOB_INDEX_REQUEST = "";
UvVar DOB = "";
UvVar SELECTION = "";
UvVar MEMBER_NAMES = "";
UvVar INITIALS_SUPPLIED = "";
UvVar MEMBER_NAME = "";
UvVar CHOOSE = "";
UvVar NOT_FOUND = "";
UvVar INDEX_NUMBER = "";
UvVar CONTINUE = "";
UvVar ANOTHER_ROUTE = "";
UvVar REDUCED_NAME = "";
UvVar LETTER_COUNT = "";
UvVar LETTER = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL000_20(ref UvVar MEMBER_NUMBER, ref UvVar SEARCH_ROUTE) {
this.MEMBER_NUMBER = MEMBER_NUMBER;
this.SEARCH_ROUTE = SEARCH_ROUTE;
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
/*  INDEXING MEMBERSHIP NAMES */
PROGRAM = "FL000.20";
THROWAWAY_CHARACTERS = "AEIOU-+&";
/*  files */
/*  Check for new version of search */
if (!(READV(ref MEMBER_SEARCH_TYPE, COMMON.FILES[FL_CONTROL], "MEMBER.SEARCH.TYPE", 1))) {
MEMBER_SEARCH_TYPE = "NEW";
}
/*      IF MEMBER.SEARCH.TYPE = "NEW" THEN */
/*       CALL FL000.21(MEMBER.NUMBER,SEARCH.ROUTE,1,INTERACT) */
/* IF INTERACT # ERROR THEN */
/*       RETURN */
/* END */
/*      END */
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
#region INCLUDE FL.FILES FL.FULL.NAME.INDEX

#endregion
#region INCLUDE FL.FILES FL.SOUNDSLIKE.NAME.INDEX

#endregion
#region INCLUDE FL.FILES FL.ADDRESS.INDEX

#endregion
/*  name/sound index request keys */
if (!(READV(ref NAME_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "NAME.INDEX.REQUEST", 1))) {
NAME_INDEX_REQUEST = "I";
}
if (!(READV(ref SOUND_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "SOUND.INDEX.REQUEST", 1))) {
SOUND_INDEX_REQUEST = "S";
}
if (!READV(ref ADDRESS_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "ADDRESS.INDEX.REQUEST", 1)) { ADDRESS_INDEX_REQUEST = "A"; }
if (!READV(ref DOB_INDEX_REQUEST, COMMON.FILES[FL_CONTROL], "DOB.INDEX.REQUEST", 1)) { DOB_INDEX_REQUEST = "D"; }
DOB = "";
SELECTION = FALSE;
do {
if (SELECTION == TRUE || SELECTION == COMMON.ABANDON) break;
/*         PRINT @(0,23):SCREEN.FOOT.FORE:SCREEN.FOOT.BACK: */
/*         PRINT @(2,23):SPACE(SCREEN.WIDTH-2) : */
// BEGIN CASE
// CASE
if (SEARCH_ROUTE == NAME_INDEX_REQUEST || SEARCH_ROUTE == SOUND_INDEX_REQUEST || SEARCH_ROUTE == DOB_INDEX_REQUEST) {
if (MEMBER_SEARCH_TYPE == "NEW" && SEARCH_ROUTE != DOB_INDEX_REQUEST) {
nrf0 = 1;
FL000_21 = new FL000_21(ref MEMBER_NUMBER, ref SEARCH_ROUTE, ref nrf0, ref INTERACT);
if (INTERACT != ERROR) {
return;
}
}
/*  Surname & Initials Input */
L10:;
PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + "Enter Surname and or Initials ");
INPUT(out MEMBER_NAMES, 25);
/*  chuck out Numeric */
if (NUM(MEMBER_NAMES)) {
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
goto L10;
}
/*  seperate Surname & Initials */
if (SEARCH_ROUTE == "D") {
DOB = "";
do {
if (DOB != "") break;
PRINT(AT(53, 23) + "DOB " + SPACE(15) + AT(58, 23));
INPUTCR(out DOB, 10);
DOB = ICONV(DOB, "D");
} while (true);
}
INITIALS_SUPPLIED = INDEX(MEMBER_NAMES, " ", 1);
if (INITIALS_SUPPLIED) {
MEMBER_NAME = FIELD(MEMBER_NAMES, " ", 1);
MEMBER_NAME = OCONV(MEMBER_NAME, "MCU");
MEMBERS_REC[MEMBER_INITIALS] = FIELD(MEMBER_NAMES, " ", 2);
MEMBERS_REC[MEMBER_INITIALS] = OCONV(MEMBERS_REC[MEMBER_INITIALS], "MCU");
} else {
MEMBER_NAME = MEMBER_NAMES;
MEMBER_NAME = OCONV(MEMBER_NAME, "MCU");
MEMBERS_REC[MEMBER_INITIALS] = "";
}
// BEGIN CASE
// CASE
if (SEARCH_ROUTE == NAME_INDEX_REQUEST) {
CHOOSE = "";
NOT_FOUND = "";
if (MATREAD(ref FNI_REC, COMMON.FILES[FL_FULL_NAME_INDEX], MEMBER_NAME)) {
if (!LOCATE(MEMBERS_REC[MEMBER_INITIALS], FNI_REC[FNI_INITS], 1, 0, 1, ref INDEX_NUMBER, "AL")) { INDEX_NUMBER = 1; }
do {
if (FNI_REC[FNI_MEMBER_IDS][1, INDEX_NUMBER] == "" || CHOOSE == "S") break;
if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], FNI_REC[FNI_MEMBER_IDS][1, INDEX_NUMBER]))) {
MAT(ref MEMBERS_REC, "");
}
PRINT(AT(2, 23) + COMMON.EOL + MEMBERS_REC[MEMBER_INITIALS][1, 1] + ". " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_ADDRESS][1, 1] + " No " + FNI_REC[FNI_MEMBER_IDS][1, INDEX_NUMBER] + " S - Select,  N - next item. ");
INPUT(out CHOOSE, 2);
INDEX_NUMBER = INDEX_NUMBER + 1;
} while (true);
if (CHOOSE == "S") {
MEMBER_NUMBER = FNI_REC[FNI_MEMBER_IDS][1, INDEX_NUMBER - 1];
SELECTION = TRUE;
}
} else {
NOT_FOUND = "Name not found .";
}
if (SELECTION == FALSE) {
CONTINUE = FALSE;
do {
if (CONTINUE == TRUE) break;
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + NOT_FOUND + " Do you want to try (S)oundslike or (A)ddress ? ");
INPUT(out ANOTHER_ROUTE, 2);
// BEGIN CASE
// CASE
if (ANOTHER_ROUTE == "S") {
SEARCH_ROUTE = SOUND_INDEX_REQUEST;
CONTINUE = TRUE;
}// CASE
else if (ANOTHER_ROUTE == "A") {
SEARCH_ROUTE = ADDRESS_INDEX_REQUEST;
CONTINUE = TRUE;
}// CASE
else if (ANOTHER_ROUTE == COMMON.ABANDON) {
SELECTION = COMMON.ABANDON;
CONTINUE = TRUE;
}
// END CASE
} while (true);
}
}// CASE
else if (SEARCH_ROUTE == SOUND_INDEX_REQUEST || SEARCH_ROUTE == DOB_INDEX_REQUEST) {
REDUCED_NAME = INIT;
for(LETTER_COUNT = 1; LETTER_COUNT <= LEN(MEMBER_NAME); LETTER_COUNT += 1) {
LETTER = MEMBER_NAME.Substring(LETTER_COUNT, 1);
if (MATCH(LETTER,"1A") && NOT(INDEX(THROWAWAY_CHARACTERS, LETTER, 1))) {
REDUCED_NAME = REDUCED_NAME + LETTER;
}
}
NOT_FOUND = "";
if (MATREAD(ref SNI_REC, COMMON.FILES[FL_SOUNDSLIKE_NAME_INDEX], REDUCED_NAME)) {
if (!LOCATE(MEMBERS_REC[MEMBER_INITIALS], SNI_REC[SNI_INITS], 1, 0, 1, ref INDEX_NUMBER, "AL")) { INDEX_NUMBER = 1; }
CHOOSE = "";
do {
if (SNI_REC[SNI_MEMBER_IDS][1, INDEX_NUMBER] == "" || CHOOSE == "S") break;
if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], SNI_REC[SNI_MEMBER_IDS][1, INDEX_NUMBER]))) {
MAT(ref MEMBERS_REC, "");
}
if (DOB == "" || DOB == MEMBERS_REC[MEMBER_DOBS][1, 1]) {
PRINT(AT(2, 23) + COMMON.EOL + MEMBERS_REC[MEMBER_INITIALS][1, 1] + ". " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_ADDRESS][1, 1] + " No " + SNI_REC[SNI_MEMBER_IDS][1, INDEX_NUMBER] + " S - Select,  N - next item. ");
INPUT(out CHOOSE, 2);
}
INDEX_NUMBER = INDEX_NUMBER + 1;
} while (true);
if (CHOOSE == "S") {
MEMBER_NUMBER = SNI_REC[SNI_MEMBER_IDS][1, INDEX_NUMBER - 1];
SELECTION = TRUE;
}
} else {
NOT_FOUND = "Name not found .";
}
if (SELECTION == FALSE) {
CONTINUE = FALSE;
do {
if (CONTINUE == TRUE) break;
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + NOT_FOUND + " Do you want to try (A)ddress ? ");
INPUT(out ANOTHER_ROUTE, 2);
// BEGIN CASE
// CASE
if (ANOTHER_ROUTE == "A") {
SEARCH_ROUTE = ADDRESS_INDEX_REQUEST;
CONTINUE = TRUE;
}// CASE
else if (ANOTHER_ROUTE == COMMON.ABANDON) {
SELECTION = COMMON.ABANDON;
CONTINUE = TRUE;
}
// END CASE
} while (true);
}
}
// END CASE
}// CASE
else if (SEARCH_ROUTE == ADDRESS_INDEX_REQUEST) {
/*  Address Line 1 Input */
PRINT(AT(0, 23) + SCREEN_FOOT_FORE + SCREEN_FOOT_BACK);
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
L20:;
PRINT(AT(2, 23) + "Enter Address Line ");
INPUT(out MEMBERS_REC[MEMBER_ADDRESS], 30);
/*  chuck out Numeric */
if (NUM(MEMBERS_REC[MEMBER_ADDRESS])) {
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
goto L20;
}
REDUCED_NAME = INIT;
for(LETTER_COUNT = 1; LETTER_COUNT <= LEN(MEMBERS_REC[MEMBER_ADDRESS]); LETTER_COUNT += 1) {
LETTER = MEMBERS_REC[MEMBER_ADDRESS].Substring(LETTER_COUNT, 1);
if (MATCH(LETTER,"1A") && NOT(INDEX(THROWAWAY_CHARACTERS, LETTER, 1))) {
REDUCED_NAME = REDUCED_NAME + LETTER;
}
}
NOT_FOUND = "";
if (MATREAD(ref ADD_INDEX_REC, COMMON.FILES[FL_ADDRESS_INDEX], REDUCED_NAME)) {
INDEX_NUMBER = 1;
CHOOSE = "";
do {
if (ADD_INDEX_REC[ADD_INDEX_MEMBER_IDS][1, INDEX_NUMBER] == "" || CHOOSE == "S") break;
if (!(MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], ADD_INDEX_REC[ADD_INDEX_MEMBER_IDS][1, INDEX_NUMBER]))) {
MAT(ref MEMBERS_REC, "");
}
PRINT(AT(2, 23) + COMMON.EOL + MEMBERS_REC[MEMBER_INITIALS][1, 1] + ". " + MEMBERS_REC[MEMBER_SURNAMES][1, 1] + ", " + MEMBERS_REC[MEMBER_ADDRESS][1, 1] + " No " + ADD_INDEX_REC[ADD_INDEX_MEMBER_IDS][1, INDEX_NUMBER] + " S - Select,  N - next item. ");
INPUT(out CHOOSE, 2);
INDEX_NUMBER = INDEX_NUMBER + 1;
} while (true);
if (CHOOSE == "S") {
MEMBER_NUMBER = ADD_INDEX_REC[ADD_INDEX_MEMBER_IDS][1, INDEX_NUMBER - 1];
SELECTION = TRUE;
}
} else {
NOT_FOUND = "Address not found .";
}
if (SELECTION == FALSE) {
CONTINUE = FALSE;
do {
if (CONTINUE == TRUE) break;
PRINT(AT(2, 23) + SPACE(SCREEN_WIDTH - 2));
PRINT(AT(2, 23) + NOT_FOUND + " Do you want to try (N)ame or (S)oundslike ? ");
INPUT(out ANOTHER_ROUTE, 2);
// BEGIN CASE
// CASE
if (ANOTHER_ROUTE == "N") {
SEARCH_ROUTE = NAME_INDEX_REQUEST;
CONTINUE = TRUE;
}// CASE
else if (ANOTHER_ROUTE == "S") {
SEARCH_ROUTE = SOUND_INDEX_REQUEST;
CONTINUE = TRUE;
}// CASE
else if (ANOTHER_ROUTE == COMMON.ABANDON) {
SELECTION = COMMON.ABANDON;
CONTINUE = TRUE;
}
// END CASE
} while (true);
}
}
// END CASE
} while (true);
if (SELECTION == COMMON.ABANDON) { MEMBER_NUMBER = ""; }
PRINT(AT(0, 23) + COMMON.EOL);
return;
}
}
}
