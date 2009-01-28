//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_PRINT : UvBase
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
UvVar REPORT_TITLE = "";
UvVar REPORT_HEADER1 = "";
UvVar REPORT_HEADER2 = "";
UvVar OUTPUT_LINE = "";
UvVar REPORT_HDRFMT = "";
UvVar REPORT_PAGE = "";
UvVar PAGE_POS = "";
UvVar PAGE_ORIENT = "";
UvVar REPORT_LINES = "";
UvVar REPORT_FORMAT = "";
UvVar VM = "";
UvVar PRODUCT_NAME = "";
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
UvVar MAX_PAGE_POS = "";
FWSP FWSP;
FWOPENPRINTER FWOPENPRINTER;
FWNEWPAGE FWNEWPAGE;
FWCLOSEPRINTER FWCLOSEPRINTER;
FWPRINTTEXT FWPRINTTEXT;
FWDRAWLINE FWDRAWLINE;
UvVar RL = "";
UvVar REP_Y = "";
UvVar ACT_LINE = "";
UvVar THIS_FORMAT = "";
FWNEWLINE FWNEWLINE;
UvVar MAXFIELDS = "";
UvVar DL = "";
UvVar THIS_BIT = "";
UvVar THIS_LOC = "";
UvVar FONTSTYLE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
#endregion
public FL_PRINT(ref UvVar REPORT_TITLE, ref UvVar REPORT_HEADER1, ref UvVar REPORT_HEADER2, ref UvVar OUTPUT_LINE, ref UvVar REPORT_HDRFMT, ref UvVar REPORT_PAGE, ref UvVar PAGE_POS, ref UvVar PAGE_ORIENT, ref UvVar REPORT_LINES, ref UvVar REPORT_FORMAT) {
this.REPORT_TITLE = REPORT_TITLE;
this.REPORT_HEADER1 = REPORT_HEADER1;
this.REPORT_HEADER2 = REPORT_HEADER2;
this.OUTPUT_LINE = OUTPUT_LINE;
this.REPORT_HDRFMT = REPORT_HDRFMT;
this.REPORT_PAGE = REPORT_PAGE;
this.PAGE_POS = PAGE_POS;
this.PAGE_ORIENT = PAGE_ORIENT;
this.REPORT_LINES = REPORT_LINES;
this.REPORT_FORMAT = REPORT_FORMAT;
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
/*  PRINTER OUTPUT */
/*       REPORT.LINES = 600 : VM : 700 : VM : 800 */
PRODUCT_NAME = "LeisureFlex";
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
if (PAGE_ORIENT == "L") { MAX_PAGE_POS = 732.5M; } else { MAX_PAGE_POS = 1075; }
if (REPORT_PAGE == 0) {
if (PAGE_ORIENT == "L") {
nrf0 = "printer";
nrf1 = pnOrientation;
nrf2 = poLandscape;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
} else {
nrf0 = "printer";
nrf1 = pnOrientation;
nrf2 = poPortrait;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
}
nrf0 = "P";
nrf1 = "Test Print";
FWOPENPRINTER = new FWOPENPRINTER(ref nrf0, ref nrf1);
/* OR SPEC NAME OF PRT AS BELOW */
/* CALL FWOPENPRINTER("HPLJ","Test Print") */
}
if (REPORT_PAGE == 0 || PAGE_POS >= MAX_PAGE_POS) {
if (PAGE_POS >= MAX_PAGE_POS) {
FWNEWPAGE = new FWNEWPAGE();
}
PAGE_POS = 57.5M;
L0100();
}
if (REPORT_PAGE > 0) {
L0200();
} else {
/* CALL FWDRAWRECTANGLE(100,100,600,600) */
FWCLOSEPRINTER = new FWCLOSEPRINTER();
}
return;
/* **** */
/*  SUBROUTINES */
/* **** */
}
void L0100() {
/*  Set Page */
/*  PAGE START */
nrf0 = "printer";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "printer";
nrf1 = pnFontSize;
nrf2 = 24;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "printer";
nrf1 = pnFontStyle;
nrf2 = fsItalic;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = 0;
nrf1 = 0;
FWPRINTTEXT = new FWPRINTTEXT(ref nrf0, ref nrf1, ref REPORT_TITLE);
nrf0 = "printer";
nrf1 = pnFontSize;
nrf2 = 10;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "printer";
nrf1 = pnFontStyle;
nrf2 = fsNormal;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
REPORT_PAGE = REPORT_PAGE + 1;
if (PAGE_ORIENT == "L") {
nrf0 = 800;nrf1 = 755;nrf2 = "Produced by ";FWPRINTTEXT = new FWPRINTTEXT(ref nrf0, ref nrf1, ref nrf2);
nrf0 = 1050;nrf1 = 25;nrf2 = "Page ";FWPRINTTEXT = new FWPRINTTEXT(ref nrf0, ref nrf1, ref nrf2);
nrf0 = 0;
nrf1 = 750;
nrf2 = 1100;
nrf3 = 750;
FWDRAWLINE = new FWDRAWLINE(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
nrf0 = 0;
nrf1 = 40;
nrf2 = 1100;
nrf3 = 40;
FWDRAWLINE = new FWDRAWLINE(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
} else {
nrf0 = 500;nrf1 = 1100;nrf2 = "Produced by Leisureflex on ";FWPRINTTEXT = new FWPRINTTEXT(ref nrf0, ref nrf1, ref nrf2);
nrf0 = 700;nrf1 = 25;nrf2 = "Page ";FWPRINTTEXT = new FWPRINTTEXT(ref nrf0, ref nrf1, ref nrf2);
nrf0 = 0;
nrf1 = 1090;
nrf2 = 800;
nrf3 = 1090;
FWDRAWLINE = new FWDRAWLINE(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
nrf0 = 0;
nrf1 = 40;
nrf2 = 800;
nrf3 = 40;
FWDRAWLINE = new FWDRAWLINE(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
}
nrf0 = "printer";
nrf1 = pnPenWidth;
nrf2 = 1;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
/*  draw any separator lines */
for(RL = 1; RL <= DCOUNT(REPORT_LINES, VM); RL += 1) {
nrf0 = REPORT_LINES[1, RL];
nrf1 = 40;
nrf2 = REPORT_LINES[1, RL];
nrf3 = 750;
FWDRAWLINE = new FWDRAWLINE(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
}
REP_Y = 45;
PAGE_POS = REP_Y;
ACT_LINE = REPORT_HEADER1;
THIS_FORMAT = REPORT_HDRFMT;
/*          CALL FWSP("printer",pnFontName,"Courier SWC") */
/*          CALL FWSP("printer",pnFontStyle,fsBold) */
if (ACT_LINE != "") {
L0250();
}
ACT_LINE = REPORT_HEADER2;
if (ACT_LINE != "") {
L0250();
}
nrf0 = "printer";
nrf1 = pnFontStyle;
nrf2 = fsNormal;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
FWNEWLINE = new FWNEWLINE();
/*  PAGE END */
return;
}
void L0200() {
/*  Print guts */
/*    FOR X=1 TO 56 */
/*       CALL FWPRINTTEXT("","",". How are you doing?": X) */
/*       CALL FWNEWLINE */
/*    NEXT X */
ACT_LINE = OUTPUT_LINE;
THIS_FORMAT = REPORT_FORMAT;
L0250();
/* CALL FWPRINTIMAGE(1000,100,300,600,"\\Casino\uv\Dev\lfsw\PHOTOS\00001.JPG") */
return;
}
void L0250() {
/*  ACTUAL LINE */
REP_Y = INT(PAGE_POS);
MAXFIELDS = DCOUNT(ACT_LINE, "|");
for(DL = 1; DL <= MAXFIELDS; DL += 1) {
THIS_BIT = FIELD(ACT_LINE, "|", DL);
THIS_LOC = THIS_FORMAT[1, DL];
if (INDEX(THIS_LOC, "R", 1) > 0) {
nrf0 = "printer";
nrf1 = pnAlignment;
nrf2 = taRightJustify;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
} else {
nrf0 = "printer";
nrf1 = pnAlignment;
nrf2 = taLeftJustify;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
}
FONTSTYLE = 0;
/* Normal */
if (INDEX(THIS_LOC, "B", 1) > 0) {
FONTSTYLE = FONTSTYLE + fsBold;
}
if (INDEX(THIS_LOC, "I", 1) > 0) {
FONTSTYLE = FONTSTYLE + fsItalic;
}
nrf0 = "printer";
nrf1 = pnFontStyle;
FWSP = new FWSP(ref nrf0, ref nrf1, ref FONTSTYLE);
THIS_LOC = OCONV(THIS_LOC, "MCN");
FWPRINTTEXT = new FWPRINTTEXT(ref THIS_LOC, ref REP_Y, ref THIS_BIT);
}
PAGE_POS = PAGE_POS + 12.5M;
return;
/*  THE END */
L9999:;
}
}
}
