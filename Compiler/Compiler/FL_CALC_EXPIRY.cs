//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CALC_EXPIRY : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar EXPIRY_PARAM = "";
UvVar OLD_EXPIRY = "";
UvVar NEW_EXPIRY = "";
UvVar PROGRAM = "";
UvVar EXPIRY_DATE = "";
UvVar EXPIRY_CALC = "";
UvVar ERRNO = "";
FL006 FL006;
UvVar NO_OF_MONTHS = "";
UvVar NO_OF_DAYS = "";
UvVar EXP_DAY = "";
UvVar EXP_MTH = "";
UvVar EXP_YR = "";
UvVar MONTH_NO = "";
UvVar O_EXPIRY = "";
UvVar I_EXPIRY = "";
//CallAt_EXPIRY_CALC CallAt_EXPIRY_CALC;
UvVar TEST_DATE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL_CALC_EXPIRY(ref UvVar EXPIRY_PARAM, ref UvVar OLD_EXPIRY, ref UvVar NEW_EXPIRY) {
this.EXPIRY_PARAM = EXPIRY_PARAM;
this.OLD_EXPIRY = OLD_EXPIRY;
this.NEW_EXPIRY = NEW_EXPIRY;
//**********************************************************************
// Program Name : FL.CALC.EXPIRY
// Description  : Calculate a new expiry date from the passed parameters
//                and old expiry date.
//                NEW.EXPIRY will be returned as null if any errors are
//                encountered.
// Note         : This routine assumes that OLD.EXPIRY is not null.  The
//                calling program must assign the old expiry date or set
//                it to some other date (usually today's date).
// Called from  : FL525
//**********************************************************************
// This routine handles the following possibilities for calculating the
// new expiry date:
// 1. If EXPIRY.PARAM<1> matches "0N" and is 4 digits or less, then the
//    new expiry date is calculated as old expiry date plus that number.
// 2. If EXPIRY.PARAM<1> matches "5N" then it is assumed to be the new
//    expiry date in internal format.
// 3. If the last 3 characters of EXPIRY.PARAM<1> are "MTH" then the
//    rest of EXPIRY.PARAM<1> is taken to be a number of months.
//    e.g. the new expiry for 3MTH will be the old expiry date plus 3
//    months.  If there is a number specified in EXPIRY.PARAMS<2> then
//    it will be added onto the expiry date.
// 4. If EXPIRY.PARAM<1> = 'Y' then it calls the program specified in
//    EXPIRY.PARAM<2>.
// 5. If EXPIRY.PARAM<1> is in a valid external date format then the new
//    expiry date is the internal format of that date.
//**********************************************************************
// Amendment Log
// Date      Name          Description
// ----      ----          -----------
// 10-01-08  Owen          New program.
//**********************************************************************
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
PROGRAM = "FL.CALC.EXPIRY";
// Extract parameters.
EXPIRY_DATE = EXPIRY_PARAM[1];
EXPIRY_CALC = EXPIRY_PARAM[2];
NEW_EXPIRY = "";
ERRNO = 0;
// Decide which method to use.
// BEGIN CASE
// CASE
if (OLD_EXPIRY == "") {
ERRNO = 1;
// No processing - calling program must set this.
}// CASE
else if (MATCH(EXPIRY_DATE,"0N") && LEN(EXPIRY_DATE) <= 4) {
L100();
// Method 1.
}// CASE
else if (MATCH(EXPIRY_DATE,"5N")) {
L200();
// Method 2.
}// CASE
else if (EXPIRY_DATE.Substring(3) == "MTH") {
L300();
// Method 3.
}// CASE
else if (EXPIRY_DATE == "Y") {
L400();
// Method 4.
}// CASE
else if (OTHERWISE) {
L500();
// Method 5.
}
// END CASE
if (ERRNO) {
nrf0 = "";
FL006 = new FL006(ref PROGRAM, ref ERRNO, ref nrf0);
}
return;
// Method 1 - add a number of days.
}
void L100() {
NEW_EXPIRY = OLD_EXPIRY + EXPIRY_DATE;
return;
// Method 2 - return fixed date.
}
void L200() {
NEW_EXPIRY = EXPIRY_DATE;
return;
// Method 3 - add a number of months and (optionally) days.
}
void L300() {
NO_OF_MONTHS = EXPIRY_DATE.Substring(1, LEN(EXPIRY_DATE) - 3);
NO_OF_DAYS = EXPIRY_CALC;
if (NO_OF_DAYS == "") {
NO_OF_DAYS = 0;
}
if ((MATCH(NO_OF_MONTHS,"0N")) && (MATCH(NO_OF_DAYS,"0N"))) {
EXP_DAY = OCONV(OLD_EXPIRY, "DD");
EXP_MTH = OCONV(OLD_EXPIRY, "DM");
EXP_YR = OCONV(OLD_EXPIRY, "DY");
for(MONTH_NO = 1; MONTH_NO <= NO_OF_MONTHS; MONTH_NO += 1) {
EXP_MTH += 1;
if (EXP_MTH == 13) {
EXP_MTH = 1;
EXP_YR += 1;
}
}
O_EXPIRY = EXP_DAY + "/" + EXP_MTH + "/" + EXP_YR;
I_EXPIRY = ICONV(O_EXPIRY, "D2/");
if (I_EXPIRY == "") {
EXP_MTH += 1;
if (EXP_MTH == 13) {
EXP_MTH = 1;
EXP_YR += 1;
}
O_EXPIRY = "1/" + EXP_MTH + "/" + EXP_YR;
I_EXPIRY = ICONV(O_EXPIRY, "D2/");
I_EXPIRY -= 1;
}
NEW_EXPIRY = I_EXPIRY + EXPIRY_CALC;
} else {
ERRNO = 2;
}
return;
// Method 4 - call a site specific routine.
}
void L400() {
if (EXPIRY_CALC == "") {
ERRNO = 3;
} else {
//CallAt_EXPIRY_CALC = new CallAt_EXPIRY_CALC(ref EXPIRY_CALC, ref OLD_EXPIRY, ref NEW_EXPIRY);
}
return;
// Method 5 - if EXPIRY.DATE is a valid date format then use that.
}
void L500() {
TEST_DATE = ICONV(EXPIRY_DATE, "D2/");
if (TEST_DATE == "") {
ERRNO = 4;
} else {
EXPIRY_DATE = TEST_DATE;
}
return;
}
}
}
