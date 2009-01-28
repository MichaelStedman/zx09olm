//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_RTEFT_PORT : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
FWTERM FWTERM = FWTERM.Instance;
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
readonly UvVar DEBUG_VERSION = 0;
readonly UvVar EDITBOX = 0;
readonly UvVar LABEL = 1;
readonly UvVar GROUPBOX = 2;
readonly UvVar MEMO = 3;
readonly UvVar BUTTON = 4;
readonly UvVar IMAGE = 5;
readonly UvVar LISTBOX = 6;
readonly UvVar COMBO = 7;
readonly UvVar SHAPE = 8;
readonly UvVar BEVEL = 9;
readonly UvVar CHECKBOX = 10;
readonly UvVar RADIOBUTTON = 11;
readonly UvVar BITBTN = 12;
readonly UvVar STRINGGRID = 13;
readonly UvVar PANEL = 14;
readonly UvVar HEMIBTN = 15;
readonly UvVar GRADBTN = 16;
readonly UvVar MEMOCR = 17;
readonly UvVar HOVERLABEL = 18;
readonly UvVar PLU = 19;
readonly UvVar pnActive = 0;
readonly UvVar pnActiveControl = 1;
readonly UvVar pnActiveMDIChild = 2;
readonly UvVar pnAddItem = 3;
readonly UvVar pnAlign = 4;
readonly UvVar pnAlignment = 5;
readonly UvVar pnAllowGrayed = 6;
readonly UvVar pnAutoScroll = 7;
readonly UvVar pnAutoSelect = 8;
readonly UvVar pnAutoSize = 9;
readonly UvVar pnBevelShape = 10;
readonly UvVar pnBevelStyle = 11;
readonly UvVar pnBorderIcons = 12;
readonly UvVar pnBorderStyle = 13;
readonly UvVar pnBoundsRect = 14;
readonly UvVar pnBrushColor = 15;
readonly UvVar pnBrushStyle = 16;
readonly UvVar pnCancel = 17;
readonly UvVar pnCanvas = 18;
readonly UvVar pnCaption = 19;
readonly UvVar pnCenter = 20;
readonly UvVar pnCharCase = 21;
readonly UvVar pnChecked = 22;
readonly UvVar pnClientHandle = 23;
readonly UvVar pnClientHeight = 24;
readonly UvVar pnClientOrigin = 25;
readonly UvVar pnClientRect = 26;
readonly UvVar pnClientWidth = 27;
readonly UvVar pnColor = 28;
readonly UvVar pnColumns = 29;
readonly UvVar pnComboStyle = 30;
readonly UvVar pnComponentCount = 31;
readonly UvVar pnComponentIndex = 32;
readonly UvVar pnComponents = 33;
readonly UvVar pnControlCount = 34;
readonly UvVar pnControls = 35;
readonly UvVar pnCtl3D = 36;
readonly UvVar pnCursor = 37;
readonly UvVar pnDefault = 38;
readonly UvVar pnDragCursor = 39;
readonly UvVar pnDragMode = 40;
readonly UvVar pnDropdownCount = 41;
readonly UvVar pnEnabled = 42;
readonly UvVar pnExtendedSelect = 43;
readonly UvVar pnFileName = 44;
readonly UvVar pnFocusControl = 45;
readonly UvVar pnFontColor = 46;
readonly UvVar pnFontName = 47;
readonly UvVar pnFontSize = 48;
readonly UvVar pnFormStyle = 49;
readonly UvVar pnHandle = 50;
readonly UvVar pnHeight = 51;
readonly UvVar pnHelpContext = 52;
readonly UvVar pnHideSelection = 53;
readonly UvVar pnHint = 54;
readonly UvVar pnHorzScrollBar = 55;
readonly UvVar pnIcon = 56;
readonly UvVar pnIntegralHeight = 57;
readonly UvVar pnInterval = 58;
readonly UvVar pnItemHeight = 59;
readonly UvVar pnItemIndex = 60;
readonly UvVar pnItems = 61;
readonly UvVar pnKeyPreview = 62;
readonly UvVar pnLeft = 63;
readonly UvVar pnLines = 64;
readonly UvVar pnListStyle = 65;
readonly UvVar pnMaxLength = 66;
readonly UvVar pnMDIChildCount = 67;
readonly UvVar pnMDIChildren = 68;
readonly UvVar pnMenu = 69;
readonly UvVar pnModalResult = 70;
readonly UvVar pnModified = 71;
readonly UvVar pnMultiselect = 72;
readonly UvVar pnObjectMenuItem = 73;
readonly UvVar pnOEMConvert = 74;
readonly UvVar pnOwner = 75;
readonly UvVar pnParent = 76;
readonly UvVar pnParentColor = 77;
readonly UvVar pnParentCtl3D = 78;
readonly UvVar pnParentFont = 79;
readonly UvVar pnParentShowHint = 80;
readonly UvVar pnPasswordChar = 81;
readonly UvVar pnPenColor = 82;
readonly UvVar pnPenStyle = 83;
readonly UvVar pnPicture = 84;
readonly UvVar pnPixelsPerInch = 85;
readonly UvVar pnPopupMenu = 86;
readonly UvVar pnPosition = 87;
readonly UvVar pnPrintScale = 88;
readonly UvVar pnReadOnly = 89;
readonly UvVar pnScaled = 90;
readonly UvVar pnScrollBars = 91;
readonly UvVar pnSelCount = 92;
readonly UvVar pnSelected = 93;
readonly UvVar pnSelLength = 94;
readonly UvVar pnSelStart = 95;
readonly UvVar pnSelText = 96;
readonly UvVar pnSelTSelStart = 97;
readonly UvVar pnShape = 98;
readonly UvVar pnShowAccelChar = 99;
readonly UvVar pnShowHint = 100;
readonly UvVar pnShowing = 101;
readonly UvVar pnSorted = 102;
readonly UvVar pnState = 103;
readonly UvVar pnStretch = 104;
readonly UvVar pnTabOrder = 105;
readonly UvVar pnTabStop = 106;
readonly UvVar pnTag = 107;
readonly UvVar pnText = 108;
readonly UvVar pnTileMode = 109;
readonly UvVar pnTop = 110;
readonly UvVar pnTopIndex = 111;
readonly UvVar pnTransparent = 112;
readonly UvVar pnVertScrollBar = 113;
readonly UvVar pnVisible = 114;
readonly UvVar pnWantReturns = 115;
readonly UvVar pnWantTabs = 116;
readonly UvVar pnWidth = 117;
readonly UvVar pnWindowMenu = 118;
readonly UvVar pnWindowState = 119;
readonly UvVar pnWordwrap = 120;
readonly UvVar pnColCount = 121;
readonly UvVar pnDefaultRowHeight = 122;
readonly UvVar pnFixedColor = 123;
readonly UvVar pnFixedCols = 124;
readonly UvVar pnFixedRows = 125;
readonly UvVar pnGridlineWidth = 126;
readonly UvVar pnRowCount = 127;
readonly UvVar pnCol = 128;
readonly UvVar pnRow = 129;
readonly UvVar pnTopRow = 130;
readonly UvVar pnVisibleRowCount = 131;
readonly UvVar pnPanelBevelInner = 132;
readonly UvVar pnPanelBevelOuter = 133;
readonly UvVar pnPanelBevelWidth = 134;
readonly UvVar pnAllowAllUp = 135;
readonly UvVar pnAttenControl = 136;
readonly UvVar pnFaceColor = 137;
readonly UvVar pnFaceShaded = 138;
readonly UvVar pnFaceTransparent = 139;
readonly UvVar pnGroupIndex = 140;
readonly UvVar pnBevelInner = 141;
readonly UvVar pnBevelOuter = 142;
readonly UvVar pnBevelWidth = 143;
readonly UvVar pnBeginColor = 144;
readonly UvVar pnEndColor = 145;
readonly UvVar pnGradientStyle = 146;
readonly UvVar pnFontStyle = 147;
readonly UvVar pnFullText = 148;
readonly UvVar pnHoverFontColor = 149;
readonly UvVar pnHoverFontName = 150;
readonly UvVar pnHoverFontSize = 151;
readonly UvVar pnHoverFontStyle = 152;
readonly UvVar pnButtonFontColor = 153;
readonly UvVar pnButtonFontName = 154;
readonly UvVar pnButtonFontSize = 155;
readonly UvVar pnButtonFontStyle = 156;
readonly UvVar pnLabelFontColor = 157;
readonly UvVar pnLabelFontName = 158;
readonly UvVar pnLabelFontSize = 159;
readonly UvVar pnLabelFontStyle = 160;
readonly UvVar pnGap = 161;
readonly UvVar pnButtonStyle = 162;
readonly UvVar pnDefaultColWidth = 163;
readonly UvVar pnFormattedText = 164;
readonly UvVar pnTextFormat = 165;
readonly UvVar pnOrientation = 166;
readonly UvVar pnPenWidth = 167;
readonly UvVar pnNavigate = 168;
readonly UvVar pnHyperlink = 169;
readonly UvVar alNone = 0;
readonly UvVar alTop = 1;
readonly UvVar alBottom = 2;
readonly UvVar alLeft = 3;
readonly UvVar alRight = 4;
readonly UvVar alClient = 5;
readonly UvVar taLeftJustify = 0;
readonly UvVar taRightJustify = 1;
readonly UvVar taCenterJustify = 2;
readonly UvVar bsBox = 0;
readonly UvVar bsFrame = 1;
readonly UvVar bsTopLine = 2;
readonly UvVar bsBottomLine = 3;
readonly UvVar bsLeftLine = 4;
readonly UvVar bsRightLine = 5;
readonly UvVar bsLowered = 0;
readonly UvVar bsRaised = 1;
readonly UvVar bsNone = 0;
readonly UvVar bsSingle = 1;
readonly UvVar bsSizeable = 2;
readonly UvVar bsDialog = 3;
readonly UvVar bsSolid = 0;
readonly UvVar bsClear = 1;
readonly UvVar bsHorizontal = 2;
readonly UvVar bsVertical = 3;
readonly UvVar bsFDiagonal = 4;
readonly UvVar bsBDiagonal = 5;
readonly UvVar bsCross = 6;
readonly UvVar bsDiagCross = 7;
readonly UvVar btsNone = 0;
readonly UvVar btsPLU = 1;
readonly UvVar btsKeyPad = 2;
readonly UvVar btsMOP = 3;
readonly UvVar btsNavigate = 4;
readonly UvVar csDropDown = 0;
readonly UvVar csSimple = 1;
readonly UvVar csDropDownList = 2;
readonly UvVar csOwnerDrawFixed = 3;
readonly UvVar csOwnerDrawVariable = 4;
readonly UvVar fsNormal = 0;
readonly UvVar fsBold = 1;
readonly UvVar fsItalic = 2;
readonly UvVar fsUnderline = 4;
readonly UvVar fsStrikeout = 8;
readonly UvVar gsHorizontal = 0;
readonly UvVar gsVertical = 1;
readonly UvVar gsElliptic = 2;
readonly UvVar gsRectangle = 3;
readonly UvVar gsVertCenter = 4;
readonly UvVar gsHorizCenter = 5;
readonly UvVar lbStandard = 0;
readonly UvVar lbOwnerDrawFixed = 1;
readonly UvVar lbOwnerDrawVariable = 2;
readonly UvVar mbYes = 1;
readonly UvVar mbNo = 2;
readonly UvVar mbOK = 4;
readonly UvVar mbCancel = 8;
readonly UvVar mbAbort = 16;
readonly UvVar mbRetry = 32;
readonly UvVar mbIgnore = 64;
readonly UvVar mbAll = 128;
readonly UvVar mbHelp = 256;
readonly UvVar mtWarning = 0;
readonly UvVar mtError = 1;
readonly UvVar mtInformation = 2;
readonly UvVar mtConfirmation = 3;
readonly UvVar mtCustom = 4;
readonly UvVar poPortrait = 0;
readonly UvVar poLandscape = 1;
readonly UvVar bvNone = 0;
readonly UvVar bvLowered = 1;
readonly UvVar bvRaised = 2;
readonly UvVar psSolid = 0;
readonly UvVar psDash = 1;
readonly UvVar psDot = 2;
readonly UvVar psDashDot = 3;
readonly UvVar psDashDotDot = 4;
readonly UvVar psClear = 5;
readonly UvVar psInsideFrame = 6;
readonly UvVar ssNone = 0;
readonly UvVar ssHorizontal = 1;
readonly UvVar ssVertical = 2;
readonly UvVar ssBoth = 3;
readonly UvVar stRectangle = 0;
readonly UvVar stSquare = 1;
readonly UvVar stRoundRect = 2;
readonly UvVar stRoundSquare = 3;
readonly UvVar stEllipse = 4;
readonly UvVar stCircle = 5;
readonly UvVar cbUnchecked = 0;
readonly UvVar cbChecked = 1;
readonly UvVar cbGrayed = 2;
readonly UvVar tfNameOnly = 0;
readonly UvVar tfColRow = 1;
readonly UvVar tfRowCol = 2;
readonly UvVar tfCaption = 3;
readonly UvVar wsNormal = 0;
readonly UvVar wsMinimized = 1;
readonly UvVar wsMaximized = 2;
readonly UvVar mrNone = 0;
readonly UvVar mrOK = 1;
readonly UvVar mrCancel = 2;
readonly UvVar mrAbort = 3;
readonly UvVar mrRetry = 4;
readonly UvVar mrIgnore = 5;
readonly UvVar mrYes = 6;
readonly UvVar mrNo = 7;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CALLING_PROG = "";
UvVar PORT_NAME = "";
UvVar NEW_ALLOCATION = "";
UvVar INTERACT = "";
UvVar CHIPANDPIN = "";
UvVar PORT_NUMBER = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar CRLF = "";
UvVar SOC = "";
UvVar EOC = "";
UvVar RUNPROGRAM = "";
UvVar SETHOSTAPPNAME = "";
UvVar SHOWCURSOR = "";
UvVar HIDECURSOR = "";
UvVar GETIPADDRESS = "";
UvVar SCGETDATAITEM = "";
UvVar SCGETISSUER = "";
UvVar SCGETAUTHLEVEL = "";
UvVar SCGETERRORCODE = "";
UvVar SCSETTESTMODE = "";
UvVar GETRFID = "";
UvVar GETTILLNUMBER = "";
UvVar SCGETPINRETRIES = "";
UvVar SCPRESENTPIN = "";
UvVar BANKVALIDATE = "";
UvVar OPENWINDOW = "";
UvVar CLOSEWINDOW = "";
UvVar CC = "";
UvVar DELETECONTROL = "";
UvVar SPC = "";
UvVar GP = "";
UvVar CM = "";
UvVar CLEARWINDOW = "";
UvVar SETGRIDCELL = "";
UvVar GETGRIDCELL = "";
UvVar SETGRIDCOLWIDTHS = "";
UvVar GETGRIDCOLWIDTHS = "";
UvVar SETGRIDROWHEIGHTS = "";
UvVar GETGRIDROWHEIGHTS = "";
UvVar SHOWKEYBOARD = "";
UvVar SETTOPMOSTWINDOW = "";
UvVar SHOWDEBUGWINDOW = "";
UvVar DEBUGPRINT = "";
UvVar SHOWMESSAGEDIALOG = "";
UvVar STARTFORMSMODE = "";
UvVar ENDFORMSMODE = "";
UvVar OPENPRINTER = "";
UvVar CLOSEPRINTER = "";
UvVar NEWPAGE = "";
UvVar PRINTTEXT = "";
UvVar PRINTIMAGE = "";
UvVar NEWLINE = "";
UvVar DRAWLINE = "";
UvVar DRAWRECTANGLE = "";
UvVar WINDOWFORM = "";
UvVar FL_EFT_SHARE = "";
UvVar PORT_ALLOCATION = "";
FL006 FL006;
UvVar PA = "";
UvVar PORTS_IN_USE = "";
UvVar CONVPOS = "";
UvVar MESSAGE = "";
FWSHOWMESSAGEDIALOG FWSHOWMESSAGEDIALOG;
UvVar REPLY = "";
UvVar FOUND = "";
UvVar PROGRESS_MAX = "";
UvVar PROGRESS_COUNT = "";
UvVar MAX_PORTS = "";
UvVar ENTRY_TIME = "";
UvVar THIS_PORT = "";
UvVar LAST_TIME = "";
UvVar THIS_TIME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL_RTEFT_PORT(ref UvVar CALLING_PROG, ref UvVar PORT_NAME, ref UvVar NEW_ALLOCATION, ref UvVar INTERACT, ref UvVar CHIPANDPIN) {
this.CALLING_PROG = CALLING_PROG;
this.PORT_NAME = PORT_NAME;
this.NEW_ALLOCATION = NEW_ALLOCATION;
this.INTERACT = INTERACT;
this.CHIPANDPIN = CHIPANDPIN;
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
/*  Real Time Eft - Port number allocator (commidea) */
/* ******************************************************************** */
/*  IMPORTANT! This routine is called by the touchscreen program. */
/*             Any input or print statements must therefore be */
/*             conditional (see existing examples in this program). */
/*             Check that any routines called by this program */
/*             are also 'touchscreen compliant' */
/* ******************************************************************** */
/*  R Turner Oct 1998 */
PROGRAM = "FL.RTEFT.PORT";
/* *** */
/*  OPEN FILES */
/* *** */
#region INCLUDE FZ.LIBRARY FW.INCLUDE
/* *********************************************************** */

/*     DEFINE CONSTANTS */
/* *********************************************************** */
/*      EQU DEBUG.VERSION TO 1 */
CRLF = CHAR(13) + CHAR(10);
SOC = CHAR(28);
EOC = CHAR(20);
RUNPROGRAM = SOC + "4,";
SETHOSTAPPNAME = SOC + "33,";
SHOWCURSOR = SOC + "34,";
HIDECURSOR = SOC + "35,";
GETIPADDRESS = SOC + "49";
SCGETDATAITEM = SOC + "55,";
SCGETISSUER = SOC + "56,";
SCGETAUTHLEVEL = SOC + "57,";
SCGETERRORCODE = SOC + "58,";
SCSETTESTMODE = SOC + "59,";
GETRFID = SOC + "60,";
GETTILLNUMBER = SOC + "61,";
SCGETPINRETRIES = SOC + "62,";
SCPRESENTPIN = SOC + "63,";
BANKVALIDATE = SOC + "64,";
OPENWINDOW = SOC + "100,";
CLOSEWINDOW = SOC + "101,";
CC = SOC + "102,";
DELETECONTROL = SOC + "103,";
SPC = SOC + "104,";
GP = SOC + "105,";
CM = SOC + "106,";
CLEARWINDOW = SOC + "107,";
SETGRIDCELL = SOC + "108,";
GETGRIDCELL = SOC + "109,";
SETGRIDCOLWIDTHS = SOC + "110,";
GETGRIDCOLWIDTHS = SOC + "111,";
SETGRIDROWHEIGHTS = SOC + "112,";
GETGRIDROWHEIGHTS = SOC + "113,";
SHOWKEYBOARD = SOC + "114,";
SETTOPMOSTWINDOW = SOC + "115,";
SHOWDEBUGWINDOW = SOC + "116,";
DEBUGPRINT = SOC + "117,";
SHOWMESSAGEDIALOG = SOC + "118,";
STARTFORMSMODE = SOC + "119,";
ENDFORMSMODE = SOC + "120,";
OPENPRINTER = SOC + "200,";
CLOSEPRINTER = SOC + "201,";
NEWPAGE = SOC + "202,";
PRINTTEXT = SOC + "203,";
PRINTIMAGE = SOC + "204,";
NEWLINE = SOC + "205,";
DRAWLINE = SOC + "206,";
DRAWRECTANGLE = SOC + "207,";
WINDOWFORM = "windowform";
/* ***************************** */
/*  Property specific values */
/*     Align */
/*     Alignment */
/*     BevelShape */
/*     BevelStyle */
/*     BorderStyle */
/*     BrushStyle */
/*     ButtonStyle */
/*     ComboStyle */
/*     Font Style */
/*         for combinations use addition */
/*         i.e.  bold italic would be fsBold + fsItalic */
/*     Gradient Style */
/*     ListStyle */
/*     Message Buttons */
/*         for combinations use addition */
/*         i.e.  Yes and No would be mbYes + mbNo */
/*     Message Types */
/*     Orientation for Printer */
/*     PanelBevel */
/*     PenStyle */
/*     ScrollBars */
/*     Shape */
/*     State */
/*     TextFormat */
/*  WindowState */
/*     Dialog Result values */
/* ***************************** */
/*      LEFT     = "left" */
/*      TOP      = "top" */
/*      WIDTH    = "width" */
/*      HEIGHT   = "height" */
/*      CAPTION  = "caption" */
/*      TEXT     = "text" */
/*      ADDITEM  = "additem" */
/*      ITEMINDEX= "itemindex" */
/*      FILENAME = "filename" */
/*      FONTNAME = "fontname" */
/*      FONTSIZE = "fontsize" */
/*      ENABLED  = "enabled" */
/*      FONTBOLD = "fontbold" */
/*      FONTITALIC="fontitalic" */
/*      VISIBLE  = "visible" */
/*      SETFOCUS = "setfocus" */
/*     END OF FW.INCLUDE */
/* * */

#endregion
#region INCLUDE FL.FILES FL.EFT.SHARE

if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE)) {
} else {
if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
}

#endregion
/*  Read in current port allocation, or set it up if not already there */
if (!(READ(ref PORT_ALLOCATION, FL_EFT_SHARE, "EFT.PORTS"))) {
nrf0 = "EFTPORTS";
nrf1 = 2;
nrf2 = "EFT.SHARE, EFT.PORTS NOT SET UP";
FL006 = new FL006(ref nrf0, ref nrf1, ref nrf2);
PORT_ALLOCATION = "";
for(PA = 1; PA <= 16; PA += 1) {
PORT_ALLOCATION[1] = PORT_ALLOCATION[1] + PA + VM;
/*            PORT.ALLOCATION<2> = PORT.ALLOCATION<2> : "0" : OCONV((PA-1),"MCDX") : VM */
PORT_ALLOCATION[2, -1] = FORMAT(PA, "R%4");
}
WRITE(PORT_ALLOCATION, FL_EFT_SHARE, "EFT.PORTS");
}
/*  remove port from active port list */
if (CHIPANDPIN == TRUE && PORT_ALLOCATION[3] == "SHARED") {
if (NEW_ALLOCATION == FALSE) {
if (PORT_ALLOCATION[3] == "SHARED" || PORT_ALLOCATION[3] == "DYNAMIC") {
if (READU(ref PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE")) {
if (LOCATE(PORT_NAME, PORTS_IN_USE, 1, 0, 1, ref CONVPOS, "AL")) {
PORTS_IN_USE[1, CONVPOS] = "";
PORTS_IN_USE[2, CONVPOS] = "";
WRITEU(PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE");
}
}
RELEASE();
return;
}
}
}
/*  Locate the current port in the conversion list */
if (LOCATE(PORT_NUMBER, PORT_ALLOCATION, 1, 0, 1, ref CONVPOS, "AL")) {
PORT_NAME = PORT_ALLOCATION[2, CONVPOS];
INTERACT = VALID_DATA;
} else {
if (CALLING_PROG == "TICKET.TOUCH") {
MESSAGE = "This is not a valid EFT workstation";
nrf0 = mtError;
nrf1 = mbOK;
nrf2 = 60;
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
} else {
nrf0 = 1;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
PORT_NAME = "99";
INTERACT = INVALID_DATA;
}
if (PORT_ALLOCATION[3] != "DYNAMIC" && PORT_ALLOCATION[3] != "SHARED") {
return;
} else {
if (INTERACT != INVALID_DATA) {
if (PORT_ALLOCATION[3] == "SHARED") {
L0200();
/*  GET SHARED READER */
} else {
L0100();
/*  GET PORT ALLOCATION */
}
}
}
return;
}
void L0100() {
/*  GET NEXT AVAILABLE PORT */
FOUND = FALSE;
PROGRESS_MAX = 120;
PROGRESS_COUNT = 0;
MAX_PORTS = DCOUNT(PORT_ALLOCATION[2], VM);
ENTRY_TIME = TIME();
do {
if (FOUND || TIME() - ENTRY_TIME > 120) break;
if (!(READU(ref PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE"))) {
PORTS_IN_USE = "";
}
THIS_PORT = 0;
do {
THIS_PORT = THIS_PORT + 1;
if (FOUND || THIS_PORT > MAX_PORTS) break;
LAST_TIME = PORTS_IN_USE[2, THIS_PORT];
THIS_TIME = FORMAT(DATE(), "R%5") + FORMAT(INT(TIME()), "R%5");
if (THIS_TIME - LAST_TIME > 3600) { PORTS_IN_USE[1, THIS_PORT] = ""; }
if (PORTS_IN_USE[1, THIS_PORT] == "") {
PORTS_IN_USE[1, THIS_PORT] = PORT_ALLOCATION[2, THIS_PORT];
PORT_NAME = PORT_ALLOCATION[2, THIS_PORT];
PORTS_IN_USE[2, THIS_PORT] = FORMAT(DATE(), "R%5") + FORMAT(INT(TIME()), "R%5");
FOUND = TRUE;
WRITEU(PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE");
RELEASE();
}
} while (true);
RELEASE();
if (CALLING_PROG == "TICKET.TOUCH") {
if (PROGRESS_COUNT == 0) { ShowProgress(); }
PROGRESS_COUNT = PROGRESS_COUNT + 1;
UpdateProgress();
} else {
PRINT(AT(0, 23) + "Waiting for port : " + FORMAT(OCONV(TIME(), "MTS"), "L#10"));
}
CRT(1);
} while (true);
if (CALLING_PROG == "TICKET.TOUCH") {
if (PROGRESS_COUNT > 0) {
HideProgress();
}
} else {
PRINT(AT(0, 23) + SPACE(70));
}
if (NOT(FOUND)) {
INTERACT = INVALID_DATA;
if (CALLING_PROG == "TICKET.TOUCH") {
MESSAGE = "Unable to retrieve port";
nrf0 = mtError;
nrf1 = mbOK;
nrf2 = 60;
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
} else {
nrf0 = 10;
nrf1 = "unable to get port";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
/* *************************************** */
}
void L0200() {
/*  WAIT FOR DEVICE TO BECOME AVAILABLE */
FOUND = FALSE;
if (CHIPANDPIN == FALSE) { return; }
PORT_NAME = PORT_ALLOCATION[4, CONVPOS];
if (PORT_NAME == "") {
INTERACT = INVALID_DATA;
nrf0 = 4;nrf1 = "SHARED READER NOT SET UP";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
PROGRESS_MAX = 120;
PROGRESS_COUNT = 0;
MAX_PORTS = DCOUNT(PORT_ALLOCATION[2], VM);
ENTRY_TIME = TIME();
do {
if (FOUND || TIME() - ENTRY_TIME > 120) break;
if (!(READU(ref PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE"))) {
PORTS_IN_USE = "";
}
if (LOCATE(PORT_NAME, PORTS_IN_USE, 1, 0, 1, ref THIS_PORT, "AL")) {
LAST_TIME = PORTS_IN_USE[2, THIS_PORT];
THIS_TIME = FORMAT(DATE(), "R%5") + FORMAT(INT(TIME()), "R%5");
if (THIS_TIME - LAST_TIME > 3600) { PORTS_IN_USE[1, THIS_PORT] = ""; }
if (PORTS_IN_USE[1, THIS_PORT] == "") {
PORTS_IN_USE[1, THIS_PORT] = PORT_ALLOCATION[2, THIS_PORT];
PORTS_IN_USE[2, THIS_PORT] = FORMAT(DATE(), "R%5") + FORMAT(INT(TIME()), "R%5");
FOUND = TRUE;
WRITEU(PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE");
}
} else {
PORTS_IN_USE[1, THIS_PORT] = PORT_NAME;
PORTS_IN_USE[2, THIS_PORT] = FORMAT(DATE(), "R%5") + FORMAT(INT(TIME()), "R%5");
FOUND = TRUE;
WRITEU(PORTS_IN_USE, FL_EFT_SHARE, "EFT.PORTS.IN.USE");
}
RELEASE();
if (CALLING_PROG == "TICKET.TOUCH") {
if (PROGRESS_COUNT == 0) { ShowProgress(); }
PROGRESS_COUNT = PROGRESS_COUNT + 1;
UpdateProgress();
} else {
PRINT(AT(0, 23) + "Waiting for device : " + FORMAT(OCONV(TIME(), "MTS"), "L#10"));
}
CRT(1);
} while (true);
if (CALLING_PROG == "TICKET.TOUCH") {
if (PROGRESS_COUNT > 0) {
HideProgress();
}
} else {
PRINT(AT(0, 23) + SPACE(70));
}
if (NOT(FOUND)) {
INTERACT = INVALID_DATA;
if (CALLING_PROG == "TICKET.TOUCH") {
MESSAGE = "Unable to retrieve port";
nrf0 = mtError;
nrf1 = mbOK;
nrf2 = 60;
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
} else {
nrf0 = 10;
nrf1 = "unable to get port";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
return;
/* *************************************** */
}
void ShowProgress() {
PRINTCR(CHAR(28) + "12," + PROGRESS_MAX + ",100,100" + CHAR(20));
return;
/* *************************************** */
}
void UpdateProgress() {
PRINTCR(CHAR(28) + "13," + PROGRESS_COUNT + CHAR(20));
return;
/* *************************************** */
}
void HideProgress() {
PRINTCR(CHAR(28) + "14" + CHAR(20));
return;
}
}
}
