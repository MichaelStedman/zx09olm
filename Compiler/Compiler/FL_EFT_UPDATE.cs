//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_EFT_UPDATE : UvBase
{
#region Variables
UvVar FL_CONTROL = "";
UvVar EFT_SHARE = "";
UvVar AM = "";
UvVar VM = "";
UvVar IINREC = "";
UvVar ANS = "";
UvVar CARD_CONTROL = "";
UvVar MAXLINES = "";
UvVar LINE = "";
UvVar CLN = "";
#endregion
if (!OPEN("FL.CONTROL", out FL_CONTROL)) { STOP(201, "FL.CONTROL"); }
if (!OPEN("FL.EFT.SHARE", out EFT_SHARE)) { STOP(201, "CANNOT FIND EFT SHARE"); }
if (READ(ref IINREC, EFT_SHARE, "IIN.TXT")) {
PRINT("UPDATE (Y/N) : ");
INPUTCR(out ANS, 2);
if (ANS == "Y") {
CARD_CONTROL = "";
MAXLINES = DCOUNT(IINREC, AM);
for(LINE = 5; LINE <= MAXLINES; LINE += 1) {
CLN = IINREC[LINE];
CARD_CONTROL[-1] = TRIM(CLN.Substring(1, 6)) + VM + TRIM(CLN.Substring(10, 6)) + VM + TRIM(CLN.Substring(17, 16)) + VM + TRIM(CLN.Substring(66, 1)) + VM + TRIM(CLN.Substring(73, 1));
}
WRITE(CARD_CONTROL, FL_CONTROL, "EFT.CARD.CONTROL");
}
}
if (READ(ref IINREC, EFT_SHARE, "IINTABLE.TXT")) {
PRINT("UPDATE WINTI (Y/N) : ");
INPUTCR(out ANS, 2);
if (ANS == "Y") {
CARD_CONTROL = "";
MAXLINES = DCOUNT(IINREC, AM);
for(LINE = 1; LINE <= MAXLINES; LINE += 1) {
CLN = IINREC[LINE];
CARD_CONTROL[-1] = FIELD(CLN, ";", 1) + VM + FIELD(CLN, ";", 2) + VM + FIELD(CLN, ";", 9) + VM;
if (FIELD(CLN, ";", 5) != 0) {
CARD_CONTROL = CARD_CONTROL + "1" + VM;
} else {
CARD_CONTROL = CARD_CONTROL + "0" + VM;
}
CARD_CONTROL = CARD_CONTROL + FIELD(CLN, ";", 4);
}
WRITE(CARD_CONTROL, FL_CONTROL, "EFT.CARD.CONTROL");
}
}
}
}
}
