//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_EFT_STATUS : UvBase
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
readonly UvVar SHOW_DIALOG = 1;
readonly UvVar SHOW_KEYBOARD = 2;
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar BWIDTH = 1;
readonly UvVar BXPOS = 2;
readonly UvVar BYPOS = 3;
readonly UvVar BDEPTH = 4;
readonly UvVar SEG1 = 5;
readonly UvVar SEG2 = 6;
readonly UvVar SEG3 = 7;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] BOX_DETAILS = new UvVar[15];
#endregion
#region Variables
UvVar PORT_NAME = "";
UvVar SEGMESS = "";
UvVar SEGNO = "";
UvVar EFT_PROMPT = "";
UvVar ERROR_FLAG = "";
UvVar EFT_REPLY = "";
UvVar CALLING_PROG = "";
UvVar PORT_NUMBER = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar DIM_VID = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar UND_VID = "";
UvVar VM = "";
UvVar CLIENT_APP_TYPE = "";
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
UvVar TICKET_TYPE = "";
UvVar COLOUR_ID = "";
UvVar TOUCH_CONTROL = "";
UvVar COLOUR_CONTROL = "";
UvVar TC_BIG_PROMPT = "";
UvVar TC_MEMBERSHIP_TABLES = "";
UvVar TC_TABLE_USERS = "";
UvVar TC_STAFF_SWIPES = "";
UvVar TC_SERVICE_CODE = "";
UvVar TC_SERVICE_PERCENT = "";
UvVar TC_DONE_POSITION = "";
UvVar FL_EFT_SHARE = "";
UvVar EFT_TYPE = "";
UvVar LABEL_GAP = "";
UvVar PANEL_LEFT = "";
UvVar PANEL_TOP = "";
UvVar PANEL_WIDTH = "";
UvVar PANEL_HEIGHT = "";
UvVar LABEL_LEFT = "";
UvVar LABEL_TOP = "";
UvVar LABEL_WIDTH = "";
UvVar LABEL_HEIGHT = "";
UvVar BOX_VID = "";
UvVar SEG1_VID = "";
UvVar SEG2_VID = "";
UvVar SEG3_VID = "";
UvVar BOX_KEY = "";
UvVar BJUST = "";
UvVar EFT_HEAD = "";
//UvVar CreateControls = "";
UvVar PPOS = "";
UvVar STATUS_REC = "";
FWSP FWSP;
UvVar SEGLINE = "";
UvVar AMC = "";
UvVar BRACKET_POSITION = "";
UvVar DONE = "";
UvVar MESSAGE = "";
UvVar BUTTONSIZE = "";
UvVar STYLE = "";
UvVar BUTTONS = "";
UvVar ACTION = "";
FWSHOWMESSAGEDIALOG FWSHOWMESSAGEDIALOG;
UvVar REPLY = "";
UvVar DEFAULT_STRING = "";
UvVar VALUE = "";
UvVar SECURE_MODE = "";
FWSHOWKEYBOARD FWSHOWKEYBOARD;
UvVar MODAL_RESULT = "";
FL019 FL019;
UvVar WHERE = "";
FWCC FWCC;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL_EFT_STATUS(ref UvVar PORT_NAME, ref UvVar SEGMESS, ref UvVar SEGNO, ref UvVar EFT_PROMPT, ref UvVar ERROR_FLAG, ref UvVar EFT_REPLY, ref UvVar CALLING_PROG) {
this.PORT_NAME = PORT_NAME;
this.SEGMESS = SEGMESS;
this.SEGNO = SEGNO;
this.EFT_PROMPT = EFT_PROMPT;
this.ERROR_FLAG = ERROR_FLAG;
this.EFT_REPLY = EFT_REPLY;
this.CALLING_PROG = CALLING_PROG;
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
// EFT ERROR DISPLAY (commidea/generic)
//!*CRT "TEMPORARY DEBUG: I'M IN FL.EFT.STATUS":;INPUT FLEX,2:
//********************************************************************
// IMPORTANT! This routine is called by the touchscreen program.
//            Any input or print statements must therefore be
//            conditional (see existing examples in this program).
//            Check that any routines called by this program
//            are also 'touchscreen compliant'
//********************************************************************
// segmess = segment message record <1> - <3> top <4> - <9> middle
//           <10> - <13> bottom
// SEGNO = segment to display or 0 for all
// EFT.PROMPT = <1> Text  <2> Length <3> acceptable values
// EFT.ERROR = Changes display
// EFT.REPLY = Users response
//*
PROGRAM = "FL.EFT.STATUS";
#region INCLUDE FZ.LIBRARY FW.INCLUDE
//***********************************************************

//    DEFINE CONSTANTS
//***********************************************************
//     EQU DEBUG.VERSION TO 1
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
//*****************************
// Property specific values
//    Align
//    Alignment
//    BevelShape
//    BevelStyle
//    BorderStyle
//    BrushStyle
//    ButtonStyle
//    ComboStyle
//    Font Style
//        for combinations use addition
//        i.e.  bold italic would be fsBold + fsItalic
//    Gradient Style
//    ListStyle
//    Message Buttons
//        for combinations use addition
//        i.e.  Yes and No would be mbYes + mbNo
//    Message Types
//    Orientation for Printer
//    PanelBevel
//    PenStyle
//    ScrollBars
//    Shape
//    State
//    TextFormat
// WindowState
//    Dialog Result values
//*****************************
//     LEFT     = "left"
//     TOP      = "top"
//     WIDTH    = "width"
//     HEIGHT   = "height"
//     CAPTION  = "caption"
//     TEXT     = "text"
//     ADDITEM  = "additem"
//     ITEMINDEX= "itemindex"
//     FILENAME = "filename"
//     FONTNAME = "fontname"
//     FONTSIZE = "fontsize"
//     ENABLED  = "enabled"
//     FONTBOLD = "fontbold"
//     FONTITALIC="fontitalic"
//     VISIBLE  = "visible"
//     SETFOCUS = "setfocus"
//    END OF FW.INCLUDE
//*

#endregion
// Very unlikely to have different EFT colour schemes for tickets
// and refunds (in Touchscreen) so assume 'tickets'. This saves us
// changing lots of argument strings.
TICKET_TYPE = "TICKETS";
// The FL.CONTROL include is necessary to support the subsequent
// include of TICKET.PARAMS
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FZ.LIBRARY TICKET.PARAMS
if (TICKET_TYPE == "REFUNDS") {

COLOUR_ID = "TOUCH.CONTROL.REFUNDS";
} else {
COLOUR_ID = "TOUCH.CONTROL.TICKETS";
}
if (!READ(ref TOUCH_CONTROL, COMMON.FILES[FL_CONTROL], "TOUCH.CONTROL")) { TOUCH_CONTROL = ""; }
if (!READ(ref COLOUR_CONTROL, COMMON.FILES[FL_CONTROL], COLOUR_ID)) { COLOUR_CONTROL = ""; }
if (TOUCH_CONTROL == "" || TOUCH_CONTROL.Substring(1, 1) == "*") { TOUCH_CONTROL = "Times New Roman"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = "10"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = "11"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = "12"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = "14"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = "18"; }
if (TOUCH_CONTROL != "15" && TOUCH_CONTROL != "16") {
TOUCH_CONTROL = "15";
// HEMIBTN
}
if (TOUCH_CONTROL == "" || TOUCH_CONTROL.Substring(1, 1) == "*") { TOUCH_CONTROL = "Courier New"; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = 11; }
if (TOUCH_CONTROL == "") { TOUCH_CONTROL = 16; }
if (TOUCH_CONTROL[7, 1] == "Y") {
TC_BIG_PROMPT = TRUE;
} else {
TC_BIG_PROMPT = FALSE;
}
TC_MEMBERSHIP_TABLES = TOUCH_CONTROL[8, 1];
TC_TABLE_USERS = TOUCH_CONTROL[9, 1];
TC_STAFF_SWIPES = TOUCH_CONTROL[10, 1];
TC_SERVICE_CODE = TOUCH_CONTROL[11, 1];
TC_SERVICE_PERCENT = TOUCH_CONTROL[12, 1];
TC_DONE_POSITION = TOUCH_CONTROL[13, 1];
if (TC_DONE_POSITION != "1" && TC_DONE_POSITION != "2") { TC_DONE_POSITION = "1"; }
// If using GRADBTNs for the keypad an 'ending' colour is needed
if (COLOUR_CONTROL == "") {
COLOUR_CONTROL = COLOUR_CONTROL;
}

#endregion
#region INCLUDE FL.FILES FL.EFT.SHARE

if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE)) {
} else {
if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
}

#endregion
if (!(READV(ref EFT_TYPE, COMMON.FILES[FL_CONTROL], "EFT.TYPE", 1))) {
EFT_TYPE = "RTEFT";
}
//!*     CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE)
if (CALLING_PROG == "TICKET.TOUCH") {
LABEL_GAP = 1;
//DJA 17.3.05!PANEL.LEFT   = 530
PANEL_LEFT = 230;
PANEL_TOP = 150;
PANEL_WIDTH = 270;
PANEL_HEIGHT = 260 + (14 * LABEL_GAP);
LABEL_LEFT = 0;
LABEL_TOP = 0;
LABEL_WIDTH = PANEL_WIDTH;
LABEL_HEIGHT = 20;
} else {
MAT(ref BOX_DETAILS, INIT);
BOX_VID = DIM_VID;
SEG1_VID = DIM_REV_VID;
if (ERROR_FLAG) {
SEG2_VID = REV_VID;
} else {
SEG2_VID = DIM_REV_UND_VID;
}
SEG3_VID = UND_VID;
BOX_KEY = PROGRAM + "." + CALLING_PROG + ".BOX";
if (!(MATREAD(ref BOX_DETAILS, COMMON.FILES[FL_CONTROL], BOX_KEY))) {
MAT(ref BOX_DETAILS, "");
BOX_DETAILS[BWIDTH] = 40;
BOX_DETAILS[BXPOS] = 7;
BOX_DETAILS[BYPOS] = 7;
BOX_DETAILS[BDEPTH] = 13;
BOX_DETAILS[SEG1] = 1 + VM + 3;
BOX_DETAILS[SEG2] = 4 + VM + 9;
BOX_DETAILS[SEG3] = 10 + VM + 12;
}
BJUST = "L#" + BOX_DETAILS[BWIDTH];
}
//***
// MAIN ROUTINE
//***
if (SEGNO == 0) {
L1000();
L1100();
// DRAW SEG1
L1200();
// DRAW SEG 2
L1300();
// DRAW SEG 3
L1400();
// GET PROMPT
} else {
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINT(CHAR(28) + "410" + CHAR(20));
L1000();
}
#region ON SEGNO GOSUB ...
switch ((int)SEGNO) {
case 1: L1100(); break;
case 2: L1200(); break;
case 3: L1300(); break;
}
#endregion
L1400();
// GET PROMPT
}
// Destroy touchscreen controls
// IMPORTANT: pnlEFT is now destroyed in FL.EFT because subsequent
//            calls from the latter assume the EFT controls are already
//            in existence
//!*  IF CALLING.PROG = "TICKET.TOUCH" THEN
//!*     CALL FWDC("form0.pnlEFT")
//!*  END
return;
}
void L1000() {
// DRAW BOX
EFT_HEAD = "Flex EFT Server - Port : " + PORT_NAME + ".";
if (CALLING_PROG == "TICKET.TOUCH") {
CreateControls();
} else {
PRINT(AT(BOX_DETAILS[BXPOS], BOX_DETAILS[BYPOS]) + BOX_VID + FORMAT(EFT_HEAD, BJUST) + NRM_VID);
//     FOR PPOS = BYPOS+1 TO BYPOS+BDEPTH-1 ; PRINT @(BXPOS,PPOS) : NRM.VID : SPACE(BWIDTH) : NRM.VID ; NEXT PPOS
PRINT(AT(BOX_DETAILS[BXPOS], BOX_DETAILS[BYPOS] + BOX_DETAILS[BDEPTH]) + BOX_VID + SPACE(BOX_DETAILS[BWIDTH]) + NRM_VID);
}
return;
}
void L1100() {
// DRAW SEG 1
if (SEGMESS[2] == "") {
//       READ STATUS.REC FROM FL.EFT.SHARE,"FIO":PORT.NAME:".STA" ELSE STATUS.REC = "Waiting for EFT"
if (EFT_TYPE == "WINTI") {
if (!(READ(ref STATUS_REC, FL_EFT_SHARE, "T000" + PORT_NAME + ".OUT"))) {
STATUS_REC = STR(",", 16) + "Waiting for EFT";
}
SEGMESS[2] = FIELD(STATUS_REC[1], ",", 17);
} else {
if (!READ(ref STATUS_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2")) { STATUS_REC = "Waiting for EFT"; }
//&       SEGMESS<2> = STATUS.REC<1>
SEGMESS[2] = STATUS_REC[14];
if (SEGMESS[2] == "") {
if (!READ(ref STATUS_REC, FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA")) { STATUS_REC = "Waiting for EFT"; }
SEGMESS[2] = STATUS_REC[1];
}
}
}
if (CALLING_PROG == "TICKET.TOUCH") {
nrf0 = "form0.lblEFTSeg1a";
nrf1 = pnCaption;
nrf2 = SEGMESS[1];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1b";
nrf1 = pnCaption;
nrf2 = SEGMESS[2];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1c";
nrf1 = pnCaption;
nrf2 = SEGMESS[3];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
} else {
for(PPOS = BOX_DETAILS[SEG1][1, 1]; PPOS <= BOX_DETAILS[SEG1][1, 2]; PPOS += 1) {
SEGLINE = " " + SEGMESS[PPOS];
PRINT(AT(BOX_DETAILS[BXPOS], PPOS + BOX_DETAILS[BYPOS]) + SEG1_VID + FORMAT(SEGLINE, BJUST) + NRM_VID);
}
}
SEGMESS[2] = "";
return;
}
void L1200() {
// DRAW SEG 2
if (CALLING_PROG == "TICKET.TOUCH") {
// Strip bracketed input values which don't make sense in a
// GUI environment
for(AMC = 4; AMC <= 9; AMC += 1) {
BRACKET_POSITION = INDEX(SEGMESS[AMC], "(", 1);
if (BRACKET_POSITION > 0) {
SEGMESS[AMC] = SEGMESS[AMC].Substring(1, BRACKET_POSITION - 1);
}
}
nrf0 = "form0.lblEFTSeg2a";
nrf1 = pnCaption;
nrf2 = SEGMESS[4];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2b";
nrf1 = pnCaption;
nrf2 = SEGMESS[5];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2c";
nrf1 = pnCaption;
nrf2 = SEGMESS[6];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2d";
nrf1 = pnCaption;
nrf2 = SEGMESS[7];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2e";
nrf1 = pnCaption;
nrf2 = SEGMESS[8];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2f";
nrf1 = pnCaption;
nrf2 = SEGMESS[9];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
} else {
for(PPOS = BOX_DETAILS[SEG2][1, 1]; PPOS <= BOX_DETAILS[SEG2][1, 2]; PPOS += 1) {
SEGLINE = " " + SEGMESS[PPOS];
PRINT(AT(BOX_DETAILS[BXPOS], PPOS + BOX_DETAILS[BYPOS]) + SEG2_VID + FORMAT(SEGLINE, BJUST) + NRM_VID);
}
}
return;
}
void L1300() {
// DRAW SEG 3
if (CALLING_PROG == "TICKET.TOUCH") {
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnCaption;
nrf2 = SEGMESS[10];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnCaption;
nrf2 = SEGMESS[11];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnCaption;
nrf2 = SEGMESS[12];
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
} else {
for(PPOS = BOX_DETAILS[SEG3][1, 1]; PPOS <= BOX_DETAILS[SEG3][1, 2]; PPOS += 1) {
SEGLINE = " " + SEGMESS[PPOS];
PRINT(AT(BOX_DETAILS[BXPOS], PPOS + BOX_DETAILS[BYPOS]) + SEG3_VID + FORMAT(SEGLINE, BJUST) + NRM_VID);
}
}
return;
}
void L1400() {
if (EFT_PROMPT == "") { return; }
DONE = FALSE;
do {
if (DONE) break;
if (CALLING_PROG == "TICKET.TOUCH") {
// Construct dialog parameters
MESSAGE = EFT_PROMPT[1];
// Strip any bracketed help which is meaningless in GUI environment
BRACKET_POSITION = INDEX(MESSAGE, "(", 1);
if (BRACKET_POSITION > 0) {
MESSAGE = MESSAGE.Substring(1, BRACKET_POSITION - 1);
}
BUTTONSIZE = 60;
// BEGIN CASE
// CASE
if (EFT_PROMPT[3] == "YES" || EFT_PROMPT[3] == "Y") {
STYLE = mtWarning;
BUTTONS = mbOK;
ACTION = SHOW_DIALOG;
}// CASE
else if (EFT_PROMPT[3] == "Y" + VM + "N") {
STYLE = mtConfirmation;
BUTTONS = mbYes + mbNo;
ACTION = SHOW_DIALOG;
}// CASE
else if (EFT_PROMPT[3] == "YES" + VM + "NO") {
STYLE = mtWarning;
BUTTONS = mbYes + mbNo;
ACTION = SHOW_DIALOG;
}// CASE
else if (EFT_PROMPT[3] == "") {
// Special - request authorisation code using keyboard
ACTION = SHOW_KEYBOARD;
}// CASE
else if (OTHERWISE) {
ACTION = "";
DONE = TRUE;
}
// END CASE
// Display the dialog box if necessary
// BEGIN CASE
// CASE
if (ACTION == SHOW_DIALOG) {
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref STYLE, ref BUTTONS, ref BUTTONSIZE, ref REPLY);
// BEGIN CASE
// CASE
if ((REPLY == mrYes || REPLY == mrOK) && EFT_PROMPT[3, 1] == "Y") {
EFT_REPLY = "Y";
DONE = TRUE;
}// CASE
else if ((REPLY == mrYes || REPLY == mrOK) && EFT_PROMPT[3, 1] == "YES") {
EFT_REPLY = "YES";
DONE = TRUE;
}// CASE
else if (REPLY == mrNo && EFT_PROMPT[3, 2] == "N") {
EFT_REPLY = "N";
DONE = TRUE;
}// CASE
else if (REPLY == mrNo && EFT_PROMPT[3, 2] == "NO") {
EFT_REPLY = "NO";
DONE = TRUE;
}
// END CASE
DONE = TRUE;
}// CASE
else if (ACTION == SHOW_KEYBOARD) {
DEFAULT_STRING = "";
VALUE = "";
SECURE_MODE = FALSE;
FWSHOWKEYBOARD = new FWSHOWKEYBOARD(ref MESSAGE, ref DEFAULT_STRING, ref VALUE, ref SECURE_MODE, ref MODAL_RESULT);
// BEGIN CASE
// CASE
if (MODAL_RESULT == mrOK) {
DONE = TRUE;
EFT_REPLY = VALUE;
}// CASE
else if (MODAL_RESULT == mrCancel) {
DONE = TRUE;
EFT_REPLY = "DECLINED";
}
// END CASE
}
// END CASE
} else {
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINT(CHAR(28) + "402");
PRINTCR(EFT_PROMPT[1]);
PRINTCR(EFT_PROMPT[3, 1] + "," + EFT_PROMPT[3, 1]);
if (EFT_PROMPT[3, 2] != "") {
PRINTCR(EFT_PROMPT[3, 2] + "," + EFT_PROMPT[3, 2]);
}
PRINT(CHAR(20));
} else {
PRINT(AT(BOX_DETAILS[BXPOS], BOX_DETAILS[BYPOS] + BOX_DETAILS[BDEPTH]) + BOX_VID + EFT_PROMPT[1] + " ");
}
nrf0 = EFT_PROMPT[2];
FL019 = new FL019(ref nrf0, ref EFT_REPLY);
PRINT(AT(BOX_DETAILS[BXPOS], BOX_DETAILS[BYPOS] + BOX_DETAILS[BDEPTH]) + NRM_VID);
if (EFT_PROMPT[3] == "") {
DONE = TRUE;
} else {
if (LOCATE(EFT_REPLY, EFT_PROMPT, 3, 0, 1, ref WHERE, "AL")) { DONE = TRUE; }
}
}
} while (true);
if (CALLING_PROG == "TICKET.TOUCH") {
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnCaption;
nrf2 = "";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnCaption;
nrf2 = "";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnCaption;
nrf2 = "";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
EFT_PROMPT = "";
} else {
PRINT(AT(BOX_DETAILS[BXPOS], BOX_DETAILS[BYPOS] + BOX_DETAILS[BDEPTH]) + BOX_VID + SPACE(BOX_DETAILS[BWIDTH]) + NRM_VID);
EFT_PROMPT = "";
for(PPOS = BOX_DETAILS[SEG3][1, 1]; PPOS <= BOX_DETAILS[SEG3][1, 2]; PPOS += 1) {
PRINT(AT(BOX_DETAILS[BXPOS], PPOS + BOX_DETAILS[BYPOS]) + SEG3_VID + SPACE(BOX_DETAILS[BWIDTH]) + NRM_VID);
}
}
return;
//****************************
}
void CreateControls() {
//****************************
nrf0 = "form0.pnlEFT";
nrf1 = PANEL;
FWCC = new FWCC(ref nrf0, ref nrf1, ref WINDOWFORM, ref PANEL_LEFT, ref PANEL_TOP, ref PANEL_WIDTH, ref PANEL_HEIGHT);
LABEL_TOP = LABEL_TOP + LABEL_GAP;
LABEL_LEFT = LABEL_LEFT + LABEL_GAP;
LABEL_WIDTH = LABEL_WIDTH - (LABEL_GAP * 2);
nrf0 = "form0.pnlEFT";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTHeader";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTHeader";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTHeader";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTHeader";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTHeader";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTHeader";
nrf1 = pnCaption;
FWSP = new FWSP(ref nrf0, ref nrf1, ref EFT_HEAD);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg1a";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg1a";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1a";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1a";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg1a";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg1b";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg1b";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1b";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1b";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg1b";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg1c";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg1c";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1c";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg1c";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg1c";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2a";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2a";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2a";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2a";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2a";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2b";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2b";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2b";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2b";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2b";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2c";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2c";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2c";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2c";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2c";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2d";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2d";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2d";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2d";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2d";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2e";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2e";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2e";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2e";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2e";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg2f";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg2f";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2f";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg2f";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg2f";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg3a";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg3a";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg3b";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg3b";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
nrf0 = "form0.lblEFTSeg3c";
nrf1 = LABEL;
nrf2 = "pnlEFT";
FWCC = new FWCC(ref nrf0, ref nrf1, ref nrf2, ref LABEL_LEFT, ref LABEL_TOP, ref LABEL_WIDTH, ref LABEL_HEIGHT);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnFontName;
nrf2 = "Times New Roman";
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnFontSize;
nrf2 = 11;
FWSP = new FWSP(ref nrf0, ref nrf1, ref nrf2);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
nrf0 = "form0.lblEFTSeg3c";
nrf1 = pnFontColor;
FWSP = new FWSP(ref nrf0, ref nrf1, ref COLOUR_CONTROL);
LABEL_TOP = LABEL_TOP + LABEL_HEIGHT + LABEL_GAP;
return;
}
}
}
