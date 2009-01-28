//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL362 : UvBase
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
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CARD_NO = "";
UvVar INTERACT = "";
UvVar PROG_MESS = "";
UvVar PROGRAM = "";
UvVar CHECK_TOTAL = "";
UvVar I = "";
UvVar DIGIT_TOTAL = "";
#endregion
public FL362(ref UvVar CARD_NO, ref UvVar INTERACT) {
this.CARD_NO = CARD_NO;
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
/*     CALCULATE CREDIT CARD CHECK DIGIT */
/*     DJA 9.8.01 */
/*     THIS ROUTINE IS ALSO CALLED TO VALIDATE CARD DETAILS */
/*     ENTERED BY INTERNET BOOKING CUSTOMERS. THEREFORE IT */
/*     MUST NOT DISPLAY ANYTHING, PROMPT THE USER OR DISPLAY */
/*     ERROR MESSAGES, AND IT SHOULD POPULATE PROG.MESS<17> */
/*     AND PROG.MESS<18> IF THE CARD NUMBER IS INVALID */
PROGRAM = "FL362";
/* *************************** */
/*     MAIN PROCESS SECTION  * */
/* *************************** */
if (CARD_NO == "" || CARD_NO == 0) {
INTERACT = INVALID_DATA;
return;
}
CARD_NO = FORMAT(CARD_NO, "R%20");
CHECK_TOTAL = 0;
for(I = 1; I <= 20; I += 1) {
if (CARD_NO.Substring(I, 1) != " " && MATCH(CARD_NO.Substring(I, 1),"0N")) {
if (MOD(I, 2) == 1) {
DIGIT_TOTAL = CARD_NO.Substring(I, 1) * 2;
if (DIGIT_TOTAL > 9) { DIGIT_TOTAL = DIGIT_TOTAL + 1; }
} else {
DIGIT_TOTAL = CARD_NO.Substring(I, 1);
}
CHECK_TOTAL = CHECK_TOTAL + DIGIT_TOTAL;
} else {
INTERACT = INVALID_DATA;
PROG_MESS[17] = "1019";
PROG_MESS[18] = "Invalid characters in card number";
return;
}
}
if (MOD(CHECK_TOTAL, 10) == 0) {
INTERACT = VALID_DATA;
} else {
PROG_MESS[17] = "1019";
PROG_MESS[18] = "Failed check digit calculation";
INTERACT = INVALID_DATA;
}
return;
/* ********************* */
/*     END OF PROGRAM  * */
/* ********************* */
}
}
}
