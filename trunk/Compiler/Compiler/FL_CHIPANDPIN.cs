//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CHIPANDPIN : UvBase
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
readonly UvVar FL_CONTROL = 10;
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
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar PORT_NAME = "";
UvVar TRANS_AMOUNT = "";
UvVar SWIPE_DETS = "";
UvVar CARD_NO = "";
UvVar CARD_EXP = "";
UvVar CARD_ISSUE = "";
UvVar CARD_START = "";
UvVar TRANS_TYPE = "";
UvVar AUTH_CODE = "";
UvVar ERROR_CODE = "";
UvVar ERROR_DESC = "";
UvVar RESULT_CODE = "";
UvVar USER_MESSAGE = "";
UvVar EFT_CONF = "";
UvVar PATRON_NO = "";
UvVar CALLING_PROG = "";
UvVar CUST_PRT_REC = "";
UvVar SALE_PRT_REC = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar PROG_MESS = "";
UvVar AM = "";
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
UvVar FL_EFT_LOG = "";
UvVar FL_EFT_ERRORS = "";
UvVar FL_CHIP_SHARE = "";
UvVar USER_REF = "";
UvVar EFT_INTERACT = "";
UvVar MERCH_REF = "";
UvVar TXNO = "";
UvVar CLARITY_CHIP = "";
UvVar INTERACT = "";
UvVar CHIP_PREFIX = "";
UvVar LODGE_TYPE = "";
UvVar CHIP_TRANS_TYPE = "";
UvVar USER_MESS = "";
UvVar TX_TYPE = "";
UvVar SEGMESS = "";
UvVar EFT_MERCHANT = "";
UvVar EFT_PROMPT = "";
UvVar EFT_ERRFLAG = "";
UvVar BATCH_JOB = "";
UvVar EFT_ACCEPTED = "";
UvVar TX_CASHBACK = "";
UvVar EFT_DECLINED = "";
UvVar EFT_AUTHCODE = "";
UvVar EFT_SEQNO = "";
UvVar LOG_AMOUNT = "";
UvVar XML = "";
UvVar TREC = "";
UvVar CNF_ID = "";
UvVar OUT_ID = "";
UvVar EFT_LOGKEY = "";
UvVar EFT_LOGREC = "";
//FL_EFT_STATUS FL_EFT_STATUS;
UvVar EFT_REPLY = "";
UvVar TERMID = "";
UvVar TLOCKREC = "";
UvVar TLOCKED = "";
UvVar DONE = "";
UvVar LLOOP = "";
UvVar LOCKREC = "";
UvVar TERMIDXML = "";
UvVar TSP = "";
UvVar TEP = "";
UvVar STATUS = "";
UvVar TX_AMOUNT = "";
UvVar WAIT = "";
UvVar SYSTEM14 = "";
UvVar KEY = "";
UvVar TOUCH_REPLY = "";
UvVar EFT_STATUS = "";
UvVar OREC = "";
FL_CC_ENCODE FL_CC_ENCODE;
UvVar REF_PHONE = "";
UvVar XMLFIELD = "";
UvVar XMLDATA = "";
UvVar USERMESS = "";
UvVar CC_EXP = "";
UvVar CARD_SWIPE = "";
UvVar SWIPE_DETAILS = "";
UvVar SLOOP = "";
UvVar ACK_LOG = "";
UvVar XDATA = "";
UvVar STARTED = "";
UvVar XLOOP = "";
UvVar STPOS = "";
UvVar ENDPOS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_CHIPANDPIN(ref UvVar PORT_NAME, ref UvVar TRANS_AMOUNT, ref UvVar SWIPE_DETS, ref UvVar CARD_NO, ref UvVar CARD_EXP, ref UvVar CARD_ISSUE, ref UvVar CARD_START, ref UvVar TRANS_TYPE, ref UvVar AUTH_CODE, ref UvVar ERROR_CODE, ref UvVar ERROR_DESC, ref UvVar RESULT_CODE, ref UvVar USER_MESSAGE, ref UvVar EFT_CONF, ref UvVar PATRON_NO, ref UvVar CALLING_PROG, ref UvVar CUST_PRT_REC, ref UvVar SALE_PRT_REC) {
this.PORT_NAME = PORT_NAME;
this.TRANS_AMOUNT = TRANS_AMOUNT;
this.SWIPE_DETS = SWIPE_DETS;
this.CARD_NO = CARD_NO;
this.CARD_EXP = CARD_EXP;
this.CARD_ISSUE = CARD_ISSUE;
this.CARD_START = CARD_START;
this.TRANS_TYPE = TRANS_TYPE;
this.AUTH_CODE = AUTH_CODE;
this.ERROR_CODE = ERROR_CODE;
this.ERROR_DESC = ERROR_DESC;
this.RESULT_CODE = RESULT_CODE;
this.USER_MESSAGE = USER_MESSAGE;
this.EFT_CONF = EFT_CONF;
this.PATRON_NO = PATRON_NO;
this.CALLING_PROG = CALLING_PROG;
this.CUST_PRT_REC = CUST_PRT_REC;
this.SALE_PRT_REC = SALE_PRT_REC;
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
// Chip and pin interace (Commidea / ILINK)
//********************************************************************
// IMPORTANT! This routine is called by the touchscreen program
//            as well as FWEFT the 'silent' eBooking version.
//            Any input or print statements must therefore be
//            conditional (see existing examples in this program).
//            Check that any routines called by this program
//            are also 'touchscreen compliant'
//********************************************************************
PROGRAM = "FL.CHIPANDPIN";
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
#region INCLUDE FL.FILES FL.EFT.LOG
if (!OPEN("FL.EFT.LOG", out FL_EFT_LOG)) { STOP(201, "FL.EFT.LOG"); }

//$** Key : PORT.NAME*TODAYS.DATE*TIME
//$*     EQU EFT.AUTH.CODE                        TO EFT.REC(1)
//$*     EQU EFT.SEQ.NO                           TO EFT.REC(2)
//$*     EQU EFT.MERCHANT.SESSION                 TO EFT.REC(3)
//$** (4) N/A
//$* Name or Member no
//$*     EQU EFT.TRANS.AMOUNT                     TO EFT.REC(6)
//$*     EQU EFT.SWIPE.DETAILS                    TO EFT.REC(7)
//$*     EQU EFT.CC.REF                           TO EFT.REC(8)
//$*     EQU EFT.CC.EXP                           TO EFT.REC(9)
//$*     EQU EFT.ISSUE.NO                         TO EFT.REC(10)
//$*     EQU EFT.START.DATE                       TO EFT.REC(11)
//$*     EQU EFT.TRANS.TYPE                       TO EFT.REC(12)
//$**    00 - PURCHASE  04 - REFUND - CUSTOMER PRESENT
//$**    80 - PURCHASE  84 - REFUND - CUSTOMER NOT PRESENT
//$*     EQU EFT.ERROR.CODE.FLEX                  TO EFT.REC(13)
//$*     EQU EFT.ERROR.DESC.FLEX                  TO EFT.REC(14)
//$*     EQU EFT.RESULT.CODE                      TO EFT.REC(15)
//$*     EQU EFT.MESSAGE                          TO EFT.REC(16)

#endregion
#region INCLUDE FL.FILES FL.EFT.ERRORS

if (!OPEN("FL.EFT.ERRORS", out FL_EFT_ERRORS)) { STOP(201, "FL.EFT.ERRORS"); }

#endregion
#region INCLUDE FL.FILES FL.CHIP.SHARE

// THIS SHOULD POINT TO A SUB FOLDER CALLED CHIP IN THE SAME FOLDER THAT
// FL.EFT.SHARE POINTS TO.  IT IS USUALLY D:\FLEX\EFT\LIVE\CHIP
if (OPEN("FL.CHIP.SHARE*" + PORT_NUMBER, out FL_CHIP_SHARE)) {
} else {
if (!OPEN("FL.CHIP.SHARE", out FL_CHIP_SHARE)) { STOP(201, "FL.CHIP.SHARE"); }
}

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
USER_REF = "";
EFT_INTERACT = "";
MERCH_REF = COMMON.CENTRE + FORMAT(PORT_NUMBER, "R%3") + U_INITS;
TXNO = DATE() + (FORMAT(INT(TIME()), "R%6"));
if (!(READV(ref CLARITY_CHIP, COMMON.FILES[FL_CONTROL], "CLARITY.CHIP", 1))) {
CLARITY_CHIP = FALSE;
}
// USE C000 FOR SOCKET PROGRAM IF THAT EVER GETS FIXED BY COMMIDEA
CHIP_PREFIX = "C000";
CHIP_PREFIX = "T000";
LODGE_TYPE = "D";
LODGE_TYPE = "T";
CHIP_TRANS_TYPE = "0000";
CARD_EXP = "";
USER_MESS = "";
CARD_ISSUE = "";
CARD_START = "";
CRLF = CHAR(13) + CHAR(10);
CRLF = "";
// MAY
TX_TYPE = "";
SEGMESS = "";
// The following prog.mess variables are used to pass error details
// back to FWEFT (for web payments)
PROG_MESS[17] = "";
// Error message number
PROG_MESS[18] = "";
// Error message description
if (!READV(ref EFT_MERCHANT, COMMON.FILES[FL_CONTROL], "EFT.MERCHANT", 1)) { EFT_MERCHANT = "001"; }
EFT_PROMPT = "";
EFT_ERRFLAG = FALSE;
BATCH_JOB = FALSE;
EFT_ACCEPTED = "1";
TX_CASHBACK = 0;
EFT_DECLINED = "9";
EFT_AUTHCODE = "";
EFT_SEQNO = "";
ERROR_CODE = "";
ERROR_DESC = "";
LOG_AMOUNT = TRANS_AMOUNT;
// ACTUAL MONEY
XML = "";
//*
// DELETE OLD FILES
//*
RQM();
//TREC = "CANCELBILL"
//      WRITE TREC ON FL.CHIP.SHARE,CHIP.PREFIX:PORT.NAME:".in"
//     Delete Upper and Lower case versions of these filenames
CRT(1);
CNF_ID = CHIP_PREFIX + PORT_NAME + ".CNF";
DELETE(FL_CHIP_SHARE, CNF_ID);
CNF_ID = CHIP_PREFIX + PORT_NAME + ".cnf";
DELETE(FL_CHIP_SHARE, CNF_ID);
CRT(1);
OUT_ID = CHIP_PREFIX + PORT_NAME + ".OUT";
DELETE(FL_CHIP_SHARE, OUT_ID);
OUT_ID = CHIP_PREFIX + PORT_NAME + ".out";
DELETE(FL_CHIP_SHARE, OUT_ID);
INTERACT = VALID_DATA;
L0200();
//COMPOSE T RECORD
if (CLARITY_CHIP && EFT_INTERACT == INVALID_DATA) {
INTERACT = INVALID_DATA;
} else {
L0300();
//PROCESS TRANSACTION
}
EFT_LOGKEY = "CHIP:" + PORT_NAME + "*" + TODAYS_DATE + "*" + TIME() + "*" + EFT_CONF[2];
EFT_LOGREC = EFT_CONF;
EFT_LOGREC[5] = USER_REF;
EFT_LOGREC[6] = LOG_AMOUNT;
EFT_LOGREC[7] = "CHIPANDPIN";
EFT_LOGREC[8] = CARD_NO;
EFT_LOGREC[9] = CARD_EXP;
EFT_LOGREC[10] = CARD_ISSUE;
EFT_LOGREC[11] = CARD_START;
EFT_LOGREC[12] = TX_TYPE;
EFT_LOGREC[13] = ERROR_CODE;
EFT_LOGREC[14] = ERROR_DESC;
EFT_LOGREC[15] = ERROR_CODE;
EFT_LOGREC[16] = USER_MESS;
WRITE(EFT_LOGREC, FL_EFT_LOG, EFT_LOGKEY);
RESULT_CODE = ERROR_CODE;
if (NOT(CLARITY_CHIP)) {
TREC = "CANCELBILL";
WRITE(TREC, FL_CHIP_SHARE, CHIP_PREFIX + PORT_NAME + ".in");
}
return;
//******
}
void L0100() {
// Set up Status
//******
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
nrf0 = 0;
//FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref EFT_ERRFLAG, ref EFT_REPLY, ref CALLING_PROG);
}
// END CASE
return;
//*****
}
void L0200() {
// COMPOSE RECORD
//*****
if (CLARITY_CHIP) {
TERMID = -1;
// this will only work for 1-1 relations
// CREATE TERM LOC XML
TLOCKREC = "<?xml version=\"1.0\" standalone=\"yes\"?>" + CRLF;
TLOCKREC[-1] = "<TermLockIn>" + CRLF;
TLOCKREC[-1] = "<POSID>" + INT(PORT_NAME) + "</POSID>" + CRLF;
TLOCKREC[-1] = "<TerminalID>" + TERMID + "</TerminalID>" + CRLF;
TLOCKREC[-1] = "</TermLockIn>" + CRLF;
//         WRITE TLOCKREC ON FL.CHIP.SHARE,"TermLockIn.xml"
TLOCKED = FALSE;
DONE = FALSE;
for(LLOOP = 1; LLOOP <= 60 && NOT(DONE); LLOOP += 1) {
if (TERMID == -1) {
DONE = TRUE;
TLOCKED = TRUE;
}
CRT(1);
if (READ(ref LOCKREC, FL_CHIP_SHARE, "TermLockOut.xml")) {
if (INDEX(LOCKREC, "<LockStatus>1</LockStatus>", 1)) {
TLOCKED = TRUE;
TERMIDXML = LOCKREC.Substring(INDEX(LOCKREC, "<TerminalID>", 1), 99);
TSP = INDEX(TERMIDXML, ">", 1) + 1;
TEP = INDEX(TERMIDXML, "<\\", 1) - 1;
TERMID = TERMIDXML.Substring(TSP, (TEP - TSP));
DONE = TRUE;
} else {
DONE = TRUE;
}
}
}
if (NOT(TLOCKED)) {
STATUS = 4;
EFT_INTERACT = INVALID_DATA;
L0600();
return;
}
//COMPOSE TX RECORD
if (TRANS_AMOUNT >= 0) {
TX_TYPE = 10;
} else {
TX_TYPE = 20;
}
TREC = "<?xml version=\"1.0\" standalone=\"yes\"?>" + CRLF;
TREC[-1] = "<Tx" + TXNO + "In>" + CRLF;
TREC[-1] = "<POSID>" + INT(PORT_NAME) + "</POSID>" + CRLF;
TREC[-1] = "<TerminalID>" + TERMID + "</TerminalID>" + CRLF;
TREC[-1] = "<TxType>" + TX_TYPE + "</TxType>" + CRLF;
TREC[-1] = "<Amount>" + TRANS_AMOUNT + "</Amount>" + CRLF;
TREC[-1] = "<TxStatus>0</TxStatus>" + CRLF;
TREC[-1] = "<CardNo>0</CardNo>" + CRLF;
TREC[-1] = "<ReferenceNumber>" + MERCH_REF + "</ReferenceNumber>";
TREC[-1] = "<StartDate>0</StartDate>" + CRLF;
TREC[-1] = "<IssueNo>0</IssueNo>" + CRLF;
TREC[-1] = "<Swiped>0</Swiped>" + CRLF;
TREC[-1] = "</Tx" + TXNO + "In>" + CRLF;
} else {
if (TRANS_AMOUNT >= 0) {
TX_TYPE = "01";
} else {
TX_TYPE = "02";
}
TX_AMOUNT = ABS(TRANS_AMOUNT) / 100;
USER_REF = EFT_CONF;
TREC = LODGE_TYPE + "," + FORMAT(EFT_MERCHANT, "R%3") + "," + TX_TYPE + "," + CHIP_TRANS_TYPE + ",,,,,,," + TX_AMOUNT + "," + TX_CASHBACK + ",,,,,,,,,,," + FORMAT(MERCH_REF, "L#50");
}
return;
//*****
}
void L0300() {
// PROCESS TRANSACTION
//*****
if (CLARITY_CHIP) {
WRITE(TREC, FL_CHIP_SHARE, "Tx" + TXNO + "In.xml");
} else {
WRITE(TREC, FL_CHIP_SHARE, CHIP_PREFIX + PORT_NAME + ".in");
}
DONE = FALSE;
for(WAIT = 1; WAIT <= 600 && NOT(DONE); WAIT += 1) {
do {
if (MACHINE_TYPE == "UNIVERSE") {
SYSTEM14 = OCONV(0, "U7201");
} else {
SYSTEM14 = SYSTEM(14);
}
if (!(SYSTEM14)) break;
ECHO_OFF();
INPUTCR(out KEY, 1);
if (SEQ(KEY) > 90) {
INPUTCR(out TOUCH_REPLY);
KEY = TOUCH_REPLY[1, 3];
}
ECHO_ON();
if (KEY == "Q") {
//               SEGMESS = "are you sure you want to quit (Y/N)"
EFT_PROMPT = "Are you sure you want to quit (Y/N)" + AT(AM + 3 + AT(AM + "Y�N"));
EFT_STATUS = 3;
L0100();
if (EFT_REPLY == "Y") {
WAIT = 1000;
}
//            END ELSE
//SEGMESS = "Caution Press Q to Quit only if":@AM : "you have been told by your" : @AM : "Supervisor"
//               GOSUB 0100
}
} while (true);
RQM();
SEGMESS = "PROCESSING " + WAIT + " seconds";
if (CLARITY_CHIP) {
if (READ(ref OREC, FL_CHIP_SHARE, "Tx" + TXNO + "Out.xml")) {
DONE = TRUE;
DELETE(FL_CHIP_SHARE, "Tx" + TXNO + "Out.xml");
}
} else {
if (READ(ref OREC, FL_CHIP_SHARE, CHIP_PREFIX + PORT_NAME + ".out")) {
DONE = TRUE;
}
}
}
ECHO_ON();
if (DONE == FALSE && NOT(CLARITY_CHIP)) {
TREC = "CANCELBILL";
WRITE(TREC, FL_CHIP_SHARE, CHIP_PREFIX + PORT_NAME + ".in");
INTERACT = INVALID_DATA;
ERROR_DESC = "NO REPLY FROM CHIP AND PIN";
ERROR_CODE = 9999;
EFT_STATUS = 3;
L0500();
// DISPLAY RESULT
} else {
if (DONE) {
L0400();
// PROCESS RESULT
} else {
TREC = "";
TX_TYPE = "99";
TREC = "<?xml version=\"1.0\" standalone=\"yes\"?>" + CRLF;
TREC[-1] = "<Tx" + TXNO + "In>" + CRLF;
TREC[-1] = "<POSID>" + INT(PORT_NAME) + "</POSID>" + CRLF;
TREC[-1] = "<TerminalID>" + TERMID + "</TerminalID>" + CRLF;
TREC[-1] = "<TxType>" + TX_TYPE + "</TxType>" + CRLF;
TREC[-1] = "</Tx" + TXNO + "In>" + CRLF;
WRITE(TREC, FL_CHIP_SHARE, "Tx" + TXNO + "In.xml");
}
}
return;
//****
}
void L0400() {
// PROCESS RESULT
//****
if (CLARITY_CHIP == FALSE) {
ERROR_CODE = FIELD(OREC, ",", 1);
if (ERROR_CODE != 0) {
INTERACT = INVALID_DATA;
L0600();
// DEAL WITH ERROR
//EFT.STATUS = 3
//        GOSUB 0500
}
CARD_EXP = FIELD(OREC, ",", 7);
CARD_ISSUE = FIELD(OREC, ",", 8);
CARD_START = FIELD(OREC, ",", 9);
CARD_NO = FIELD(OREC, ",", 6);
FL_CC_ENCODE = new FL_CC_ENCODE(ref CARD_NO);
EFT_SEQNO = FIELD(OREC, ",", 15);
USER_REF = EFT_SEQNO;
AUTH_CODE = FIELD(OREC, ",", 16);
REF_PHONE = FIELD(OREC, ",", 17);
USER_MESS = FIELD(OREC, ",", 18);
EFT_CONF = AUTH_CODE + AM + EFT_SEQNO + AM + EFT_MERCHANT;
return;
} else {
XML = OREC;
XMLFIELD = "TxStatus";
L0900();
// GET XML
ERROR_CODE = XMLDATA;
if (ERROR_CODE != 0) {
// Get error from clarity pos and report it
EFT_STATUS = 2;
XML = OREC;
XMLFIELD = "TxStatusDesc";
L0900();
USERMESS = XMLDATA;
INTERACT = INVALID_DATA;
L0600();
L0500();
//            RETURN
}
XMLFIELD = "ExpiryDate";
L0900();
CC_EXP = XMLDATA;
XMLFIELD = "IssueNumber";
L0900();
CARD_ISSUE = XMLDATA;
XMLFIELD = "CardNumber";
L0900();
CARD_NO = XMLDATA;
FL_CC_ENCODE = new FL_CC_ENCODE(ref CARD_NO);
XMLFIELD = "SwipedTrack";
L0900();
CARD_SWIPE = XMLDATA;
XMLFIELD = "StartDate";
L0900();
CARD_EXP = XMLDATA;
XMLFIELD = "Message";
L0900();
USER_MESS = XMLDATA;
XMLFIELD = "AuthCode";
L0900();
AUTH_CODE = XMLDATA;
XMLFIELD = "TranID";
L0900();
EFT_SEQNO = XMLDATA;
EFT_CONF = AUTH_CODE + AM + EFT_SEQNO + AM + EFT_MERCHANT;
}
return;
}
void L0500() {
// Display Current Status of EFT
//****
// BEGIN CASE
// CASE
if (EFT_STATUS == 1) {
EFT_INTERACT = "";
SEGMESS = "";
SEGMESS[2] = "Please Wait";
SEGMESS[2] = "EFT port " + PORT_NAME + " Transaction in progress";
SEGMESS[6] = "Please wait";
EFT_PROMPT = "";
EFT_ERRFLAG = FALSE;
L0100();
// No action reqd
}// CASE
else if (EFT_STATUS == 2) {
EFT_INTERACT = INVALID_DATA;
if (!READ(ref SEGMESS, FL_EFT_ERRORS, "FLEX*STATUS*" + EFT_STATUS)) { SEGMESS = "UNKNOWN STATUS"; }
if (!(READ(ref EFT_PROMPT, FL_EFT_ERRORS, "FLEX*STATUS*PROMPT*" + EFT_STATUS))) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message " + AM + 3 + AM + "YES";
}// CASE
else if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = SEGMESS;
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Have you read this message? (YES) " + AM + 3 + AM + "YES";
}
// END CASE
}
//            GOSUB 0100
CARD_NO = INIT;
CARD_EXP = INIT;
CARD_ISSUE = INIT;
CARD_START = INIT;
SWIPE_DETAILS = INIT;
}// CASE
else if (EFT_STATUS == 3) {
if (!READ(ref SEGMESS, FL_EFT_ERRORS, "FLEX*STATUS*" + EFT_STATUS)) { SEGMESS = "UNKNOWN STATUS"; }
if (!(READ(ref EFT_PROMPT, FL_EFT_ERRORS, "FLEX*STATUS*PROMPT*" + EFT_STATUS))) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message " + AM + 3 + AM + "YES";
}// CASE
else if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = SEGMESS;
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Have you read this message? (YES) " + AM + 3 + AM + "YES";
}
// END CASE
}
EFT_INTERACT = VALID_DATA;
L0100();
}// CASE
else if (EFT_STATUS == 4) {
if (!READ(ref SEGMESS, FL_EFT_ERRORS, "FLEX*STATUS*" + EFT_STATUS)) { SEGMESS = "UNKNOWN STATUS"; }
if (!(READ(ref EFT_PROMPT, FL_EFT_ERRORS, "FLEX*STATUS*PROMPT*" + EFT_STATUS))) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message " + AM + 3 + AM + "YES";
}// CASE
else if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = SEGMESS;
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Have you read this message? (YES) " + AM + 3 + AM + "YES";
}
// END CASE
}
EFT_INTERACT = INVALID_DATA;
L0100();
}// CASE
else if (OTHERWISE) {
SEGMESS = "UNKNOWN STATUS";
L0100();
}
// END CASE
return;
//*****
}
void L0600() {
// Read Error
//*****
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE + "*CHIP"))) {
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE))) {
if (CLARITY_CHIP == FALSE) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
}
}
L0610:
// Clarity chip error handler comes in here
SEGMESS[2] = "Commidea Error Code : " + ERROR_CODE;
for(SLOOP = 1; SLOOP <= 8; SLOOP += 1) {
SEGMESS[3 + SLOOP] = USERMESS[SLOOP];
}
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message " + AM + 3 + AM + "YES";
}// CASE
else if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = USERMESS;
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Have you read this message? (YES) " + AM + 3 + AM + "YES";
}
// END CASE
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
nrf0 = 0;
nrf1 = 1;
//FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
ACK_LOG = "";
WRITE(ACK_LOG, FL_EFT_LOG, U_INITS + "*" + TODAYS_DATE + "*" + TIME());
}
// END CASE
return;
}
void L0900() {
// GET XML
// XMLFIELD= REQUIRED FIELD
// XML = XML
// XMLDATA = DATA
XDATA = "";
DONE = FALSE;
STARTED = TRUE;
for(XLOOP = 1; XLOOP <= DCOUNT(XML, AT(AM)) && NOT(DONE); XLOOP += 1) {
STPOS = INDEX(XML[XLOOP], "<" + XMLFIELD + ">", 1);
ENDPOS = INDEX(XML[XLOOP], "</" + XMLFIELD + ">", 1);
if (STPOS > 0) {
XDATA = XML[XLOOP];
STARTED = TRUE;
if (ENDPOS > 0) {
DONE = TRUE;
}
} else {
if (ENDPOS > 0) {
XDATA = XDATA + XML[XLOOP];
DONE = TRUE;
} else {
if (STARTED == TRUE) {
XDATA = XDATA + XML[XLOOP];
}
}
}
}
// SHOULD HAVE A COMPLETE STRING OF XML
STPOS = INDEX(XDATA, "<" + XMLFIELD + ">", 1);
ENDPOS = INDEX(XDATA, "</" + XMLFIELD + ">", 1);
STPOS = STPOS + LEN("<" + XMLFIELD + ">");
ENDPOS = ENDPOS - STPOS;
//      ENDPOS = ENDPOS + 1
XMLDATA = XDATA.Substring(STPOS, ENDPOS);
return;
}
}
}
