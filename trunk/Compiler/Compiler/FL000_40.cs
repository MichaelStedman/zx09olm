//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_40 : UvBase
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
readonly UvVar MEMBERSHIP_NUMBERS = 65;
readonly UvVar APACS_MEMBER = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] APACS_REC = new UvVar[10];
#endregion
#region Variables
UvVar MEM_ID = "";
UvVar NUMBER = "";
UvVar FL_APACS_NUMBERS = "";
UvVar SMART_CARD = "";
UvVar FIXED_SMART_PREFIX = "";
UvVar NUMBER_LENGTH = "";
UvVar AUTHORITY_NAME = "";
UvVar MEM_PARAMS = "";
UvVar LEN_PREFIX = "";
UvVar FIXED_LEN = "";
UvVar CENTRE_PREFIX = "";
UvVar JUSTIF = "";
UvVar SET_PREFIX = "";
UvVar ACTUAL_ID = "";
UvVar CENTRE_CODE = "";
UvVar HBC_CENTRE_TRANSLATES = "";
UvVar CENTRE_TRANS = "";
#endregion
public FL000_40(ref UvVar MEM_ID) {
this.MEM_ID = MEM_ID;
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
/*  HELP FACILITY FOR MEMBER NUMBER ENTRY */
/*  Open Files */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.APACS.NUMBERS
if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

#endregion
/*  Assign Variables */
if (!(READV(ref SMART_CARD, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE", 1))) {
SMART_CARD = FALSE;
}
if (!(READV(ref FIXED_SMART_PREFIX, COMMON.FILES[FL_CONTROL], "FIXED.SMART.PREFIX", 1))) {
FIXED_SMART_PREFIX = "";
}
/*      READV NUMBER.LENGTH FROM MEMBERSHIP.NUMBERS,'NUMBER.LENGTH',1 ELSE */
/*         NUMBER.LENGTH = 4 */
/*      END */
if (!(READV(ref AUTHORITY_NAME, COMMON.FILES[FL_CONTROL], "AUTH.ID", 1))) {
AUTHORITY_NAME = INIT;
}
/*      READV PREFIX.LENGTH FROM FL.CONTROL,"AUTOMATIC.CONCESS",2 ELSE */
/*         PREFIX.LENGTH = 0 */
/*      END */
if (!READ(ref MEM_PARAMS, COMMON.FILES[FL_CONTROL], "AUTOMATIC.CONCESS")) { MEM_PARAMS = ""; }
if (MEM_PARAMS[2] != "") { LEN_PREFIX = MEM_PARAMS[2]; } else { LEN_PREFIX = 1; }
if (MEM_PARAMS[4] != "") { FIXED_LEN = MEM_PARAMS[4]; } else { FIXED_LEN = "F"; }
if (MEM_PARAMS[5] != "") { CENTRE_PREFIX = MEM_PARAMS[5]; } else { CENTRE_PREFIX = COMMON.CENTRE; }
if (MEM_PARAMS[6] != "") { NUMBER_LENGTH = MEM_PARAMS[6]; } else { NUMBER_LENGTH = 4; }
JUSTIF = "R%" + NUMBER_LENGTH;
SET_PREFIX = "";
if (FIXED_SMART_PREFIX != "" && LEN(MEM_ID) == 8) {
MEM_ID = FIXED_SMART_PREFIX + MEM_ID;
}
if (SMART_CARD && LEN(MEM_ID) == 16) {
if (READV(ref ACTUAL_ID, FL_APACS_NUMBERS, MEM_ID, 1)) {
MEM_ID = ACTUAL_ID;
return;
} else {
MEM_ID = "";
return;
}
}
if (CENTRE_PREFIX == "") { CENTRE_PREFIX = COMMON.CENTRE; }
if (CENTRE_PREFIX == "NONE") {
CENTRE_PREFIX = "";
if (LEN_PREFIX == "") { LEN_PREFIX = 0; }
if (LEN_PREFIX != 0) { CENTRE_PREFIX = MEM_ID.Substring(1, LEN_PREFIX); }
SET_PREFIX = "NONE";
}
CENTRE_CODE = COMMON.CENTRE;
/*  AMENDMENT FOR TANDRIDGE - REMOVE LEADING ZERO */
if (LEN(MEM_ID) > NUMBER_LENGTH) {
if (MEM_ID.Substring(1, 1) == "0") { MEM_ID = MEM_ID.Substring(2, LEN(MEM_ID) - 1); }
}
/*  END OF AMENDMENT */
if (AUTHORITY_NAME == "HBC") {
if (!(OPEN("HBC.CENTRE.TRANSLATES", out HBC_CENTRE_TRANSLATES))) {
return;
}
if (!(READV(ref CENTRE_TRANS, HBC_CENTRE_TRANSLATES, COMMON.CENTRE, 1))) {
return;
}
JUSTIF = "R%" + NUMBER_LENGTH;
MEM_ID = FORMAT(MEM_ID, JUSTIF);
MEM_ID = CENTRE_TRANS + MEM_ID;
} else {
/*   comment out the following and succeeding lines have been added */
/*         IF LEN(MEM.ID) < NUMBER.LENGTH THEN */
/*            JUSTIF = "R%":NUMBER.LENGTH */
/*            MEM.ID = MEM.ID JUSTIF */
/*         END */
/*         IF LEN.PREFIX > 0 THEN */
/*            MEM.ID = CENTRE : MEM.ID */
/*         END */
/* ** inserted the following for more thorough memno formatting 7.10.02 HS */
// BEGIN CASE
// CASE
if (LEN_PREFIX > 0 && MEM_PARAMS[5] == "NONE") {
/*                    * Attach variable prefix */
NUMBER = MEM_ID.Substring(LEN_PREFIX + 1, LEN(MEM_ID) - LEN_PREFIX);
if (FIXED_LEN == "V") {
MEM_ID = CENTRE_PREFIX + NUMBER;
} else {
NUMBER = FORMAT(NUMBER, JUSTIF);
MEM_ID = CENTRE_PREFIX + NUMBER;
}
}// CASE
else if (MEM_PARAMS[5] == "") {
/*                    * Attach Centre Code */
if (MEM_ID.Substring(1, LEN_PREFIX) == COMMON.CENTRE) {
NUMBER = MEM_ID.Substring(LEN_PREFIX + 1, LEN(MEM_ID) - LEN_PREFIX);
} else {
NUMBER = MEM_ID;
}
if (FIXED_LEN == "V") {
MEM_ID = COMMON.CENTRE + NUMBER;
} else {
NUMBER = FORMAT(NUMBER, JUSTIF);
MEM_ID = COMMON.CENTRE + FORMAT(NUMBER, JUSTIF);
}
}// CASE
else if (LEN_PREFIX == 0 && MEM_PARAMS[5] == "NONE") {
/*                    * Purely numeric no (no prefixes) */
if (FIXED_LEN == "V") {
MEM_ID = MEM_ID;
} else {
MEM_ID = FORMAT(MEM_ID, JUSTIF);
}
}// CASE
else if (MEM_PARAMS[5] != "" && MEM_PARAMS[5] != "NONE") {
/*                    * Attach fixed prefix */
if (MEM_ID.Substring(1, LEN_PREFIX) != CENTRE_PREFIX) {
if (FIXED_LEN == "V") {
MEM_ID = CENTRE_PREFIX + MEM_ID;
} else {
MEM_ID = CENTRE_PREFIX + FORMAT(MEM_ID, JUSTIF);
}
} else {
NUMBER = MEM_ID.Substring(LEN_PREFIX + 1, LEN(MEM_ID) - LEN_PREFIX);
if (FIXED_LEN == "V") {
MEM_ID = CENTRE_PREFIX + NUMBER;
} else {
MEM_ID = CENTRE_PREFIX + FORMAT(NUMBER, JUSTIF);
}
}
}
// END CASE
/* ** end of insert *** */
}
return;
}
}
}
