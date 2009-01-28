//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_LIST : UvBase
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
UvVar HELP_TEXT = "";
UvVar NRM_VID = "";
UvVar REV_UND_VID = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar TOP_BAR = "";
UvVar SIDE_BAR = "";
UvVar BOT_BAR = "";
UvVar MAXLINES = "";
UvVar MAXSIZE = "";
UvVar MAXWIDTH = "";
UvVar BOXSIZE = "";
UvVar MINSIZE = "";
UvVar MINWIDTH = "";
UvVar BOXWIDTH = "";
UvVar THISLEN = "";
UvVar BOXX = "";
UvVar BOXY = "";
UvVar THISY = "";
UvVar BOXJUST = "";
UvVar ANS_REPLY = "";
#endregion
public FL_LIST(ref UvVar HELP_TEXT) {
this.HELP_TEXT = HELP_TEXT;
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
/*  routine to quickly put a help window on any screen then */
/*  remove it before returning to calling program */
INTERACT = VALID_DATA;
/*  Variables */
TOP_BAR = REV_UND_VID;
SIDE_BAR = REV_UND_VID + " " + NRM_VID;
BOT_BAR = REV_UND_VID;
/*  Copy the screen */
PRINTCR(CHAR(28) + "36,0,0,80,30" + CHAR(20));
/*  Display the box */
L0100();
/*  Paste the screen back */
PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
return;
}
void L0100() {
/*  Display help box */
MAXLINES = DCOUNT(HELP_TEXT, VM);
MAXSIZE = 20;
MAXWIDTH = 70;
BOXSIZE = 0;
MINSIZE = 10;
MINWIDTH = 20;
BOXWIDTH = 0;
for(COMMON.X = 1; COMMON.X <= MAXLINES; COMMON.X += 1) {
if (BOXSIZE < MAXSIZE) {
BOXSIZE = BOXSIZE + 1;
}
HELP_TEXT[1, COMMON.X] = " " + HELP_TEXT[1, COMMON.X] + " ";
THISLEN = LEN(HELP_TEXT[1, COMMON.X]);
if (THISLEN > BOXWIDTH) {
if (THISLEN > MAXWIDTH) {
BOXWIDTH = MAXWIDTH;
} else {
BOXWIDTH = THISLEN;
}
}
}
if (BOXWIDTH < MINWIDTH) { BOXWIDTH = MINWIDTH; }
if (BOXSIZE < MINSIZE) { BOXSIZE = MINSIZE; }
BOXX = INT((79 - BOXWIDTH) / 2);
BOXY = INT((23 - BOXSIZE) / 2);
THISY = 0;
do {
L0200();
if (INTERACT == EXIT) break;
THISY = THISY + BOXSIZE;
if (THISY > MAXLINES) {
THISY = 0;
}
} while (true);
return;
}
void L0200() {
/*  UPDATE SCREEN */
BOXJUST = "L#" + BOXWIDTH;
PRINTCR(AT(BOXX, BOXY) + TOP_BAR + FORMAT(" Help ", BOXJUST) + "  " + NRM_VID);
for(COMMON.Y = 1; COMMON.Y <= BOXSIZE; COMMON.Y += 1) {
PRINTCR(AT(BOXX, BOXY + COMMON.Y) + SIDE_BAR + FORMAT(HELP_TEXT[1, COMMON.Y + THISY], BOXJUST) + SIDE_BAR);
}
PRINT(AT(BOXX, BOXY + COMMON.Y) + BOT_BAR + FORMAT(" Press <return> ", BOXJUST) + "  " + NRM_VID);
ECHO_OFF();
INPUTCR(out ANS_REPLY);
ECHO_ON();
if (ANS_REPLY == "." || BOXSIZE < MAXSIZE) { INTERACT = EXIT; }
return;
}
}
}
