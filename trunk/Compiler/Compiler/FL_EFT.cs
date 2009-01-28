//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_EFT : UvBase
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
UvVar SWIPE_DETAILS = "";
UvVar CARD_NO = "";
UvVar CARD_EXP = "";
UvVar CARD_ISSUE = "";
UvVar CARD_START = "";
UvVar TRANS_AMOUNT = "";
UvVar EFT_CONF = "";
UvVar INTERACT = "";
UvVar CALLING_PROG = "";
UvVar CARD_CVS = "";
UvVar PORT_NUMBER = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar PROG_MESS = "";
UvVar AM = "";
UvVar VM = "";
UvVar CLIENT_APP_TYPE = "";
UvVar CARD_HOUSENAMENO = "";
UvVar CARD_POSTCODE = "";
UvVar SPARE1 = "";
UvVar SPARE2 = "";
UvVar SPARE3 = "";
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
UvVar PORT_NAME = "";
UvVar FL_EFT_ERRORS = "";
UvVar FL_EFT_SHARE = "";
UvVar EFT_PROMPT = "";
UvVar EFT_ERRFLAG = "";
UvVar BATCH_JOB = "";
UvVar EFT_ACCEPTED = "";
UvVar EFT_DECLINED = "";
UvVar EFT_AUTHCODE = "";
UvVar EFT_SEQNO = "";
UvVar LOG_AMOUNT = "";
UvVar CUST_PRT_REC = "";
UvVar SALE_PRT_REC = "";
UvVar CHIPANDPINREC = "";
UvVar CHIPANDPIN = "";
UvVar POS = "";
UvVar CHIPANDPINTX = "";
UvVar EFT_MIN_AMOUNT = "";
UvVar MESSAGE = "";
FWSHOWMESSAGEDIALOG FWSHOWMESSAGEDIALOG;
UvVar REPLY = "";
FL006 FL006;
UvVar EFT_TYPE = "";
FWEFTPORT FWEFTPORT;
FL_RTEFT_PORT FL_RTEFT_PORT;
UvVar EFT_STATUS = "";
UvVar EFT_INTERACT = "";
UvVar SEGMESS = "";
FL_CHIPANDPIN FL_CHIPANDPIN;
UvVar EFT_EXP = "";
UvVar TRANS_TYPE = "";
UvVar AUTH_CODE = "";
UvVar ERROR_CODE = "";
UvVar ERROR_DESC = "";
UvVar RESULT_CODE = "";
UvVar USER_MESSAGE = "";
UvVar MEMBER_NO = "";
UvVar SLIP_PRINT_ROUTINE = "";
UvVar SIGSLIP_REQ = "";
FL_RTEFT FL_RTEFT;
UvVar AUTH_STEP = "";
UvVar MAX_STEPS = "";
FL_EFT_STATUS FL_EFT_STATUS;
FWDC FWDC;
UvVar FL_CHIP_SHARE = "";
UvVar EFT_REPLY = "";
FL_WINTI FL_WINTI;
FL_CC_ENCODE FL_CC_ENCODE;
UvVar EFT_LOGKEY = "";
UvVar EFT_LOGREC = "";
UvVar USERMESS = "";
UvVar OUTREC = "";
UvVar PHONE_NO = "";
UvVar SLOOP = "";
UvVar ACK_LOG = "";
UvVar ANS = "";
UvVar EFT_CONFTYPE = "";
CallAt_SLIP_PRINT_ROUTINE CallAt_SLIP_PRINT_ROUTINE;
UvVar EFT_MERCHANT = "";
FL_WINTI_CONF FL_WINTI_CONF;
FL_RTEFT_CONF FL_RTEFT_CONF;
UvVar EFT_SLIPTYPE = "";
UvVar PRINT_REC = "";
UvVar EFT_MATCH = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL_EFT(ref UvVar SWIPE_DETAILS, ref UvVar CARD_NO, ref UvVar CARD_EXP, ref UvVar CARD_ISSUE, ref UvVar CARD_START, ref UvVar TRANS_AMOUNT, ref UvVar EFT_CONF, ref UvVar INTERACT, ref UvVar CALLING_PROG, ref UvVar CARD_CVS) {
this.SWIPE_DETAILS = SWIPE_DETAILS;
this.CARD_NO = CARD_NO;
this.CARD_EXP = CARD_EXP;
this.CARD_ISSUE = CARD_ISSUE;
this.CARD_START = CARD_START;
this.TRANS_AMOUNT = TRANS_AMOUNT;
this.EFT_CONF = EFT_CONF;
this.INTERACT = INTERACT;
this.CALLING_PROG = CALLING_PROG;
this.CARD_CVS = CARD_CVS;
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
// Real time eft Theatreflex Interface (commidea/generic)
// NOTE AVS NOT IN LEISURE AT THE MOMENT
CARD_HOUSENAMENO = "";
CARD_POSTCODE = "";
SPARE1 = "";
SPARE2 = "";
SPARE3 = "";
//********************************************************************
// IMPORTANT! This routine is called by the touchscreen program
//            as well as FWEFT the 'silent' eBooking version.
//            Any input or print statements must therefore be
//            conditional (see existing examples in this program).
//            Check that any routines called by this program
//            are also 'touchscreen compliant'
//********************************************************************
PROGRAM = "FL.EFT";
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
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.EFT.SHARE

if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE)) {
} else {
if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
}

#endregion
// The following prog.mess variables are used to pass error details
// back to FWEFT (for web payments)
PROG_MESS[17] = "";
// Error message number
PROG_MESS[18] = "";
// Error message description
EFT_PROMPT = "";
EFT_ERRFLAG = FALSE;
BATCH_JOB = FALSE;
EFT_ACCEPTED = "1";
EFT_DECLINED = "9";
EFT_AUTHCODE = "";
EFT_SEQNO = "";
LOG_AMOUNT = TRANS_AMOUNT;
// ACTUAL MONEY
CUST_PRT_REC = "";
SALE_PRT_REC = "";
//*!     CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE)
if (!READ(ref CHIPANDPINREC, FL_EFT_SHARE, "CHIPANDPIN.PORTS")) { CHIPANDPINREC = FALSE; }
CHIPANDPIN = FALSE;
if (CHIPANDPINREC[1] == TRUE) {
if (CHIPANDPINREC[2] == "ALL") {
CHIPANDPIN = TRUE;
}
if (LOCATE(PORT_NUMBER, CHIPANDPINREC, 2, 0, 1, ref POS, "AL")) {
CHIPANDPIN = TRUE;
}
}
if (CHIPANDPIN == TRUE && CARD_NO == "") {
CHIPANDPINTX = TRUE;
} else {
CHIPANDPINTX = FALSE;
}
if (!READV(ref EFT_MIN_AMOUNT, COMMON.FILES[FL_CONTROL], "EFT.MIN.AMOUNT", 1)) { EFT_MIN_AMOUNT = 500; }
if (ABS(TRANS_AMOUNT) < EFT_MIN_AMOUNT) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
MESSAGE = "Ticket total is less than minimum transaction value";
nrf0 = mtError;
nrf1 = mbOK;
nrf2 = 60;
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
}// CASE
else if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = "Total is less than minimum transaction value";
}// CASE
else if (OTHERWISE) {
nrf0 = "1";
nrf1 = "BELOW MINIMUM TRANSACTION VALUE ";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
// END CASE
INTERACT = INVALID_DATA;
return;
}
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
EFT_TYPE = "WINTI";
}// CASE
else if (OTHERWISE) {
if (!(READV(ref EFT_TYPE, COMMON.FILES[FL_CONTROL], "EFT.TYPE", 1))) {
EFT_TYPE = "WINTI";
}
}
// END CASE
//*
// SNAP DISPLAY
//*
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
NULL();
}// CASE
else if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINTCR(CHAR(28) + "408,7,7,46,21" + CHAR(20));
PRINTCR(CHAR(28) + "36,7,7,46,21" + CHAR(20));
} else {
PRINTCR(CHAR(28) + "36,0,0,80,30" + CHAR(20));
}
}
// END CASE
// MAIN BLOCK
PORT_NAME = "";
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
nrf0 = 1;
FWEFTPORT = new FWEFTPORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref INTERACT);
}// CASE
else if (OTHERWISE) {
nrf0 = 1;
FL_RTEFT_PORT = new FL_RTEFT_PORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref INTERACT, ref CHIPANDPINTX);
}
// END CASE
if (INTERACT == INVALID_DATA) {
return;
}
//*
// Check the current status of eft and action it
//*
if (!READV(ref EFT_STATUS, COMMON.FILES[FL_CONTROL], "EFT.STATUS", 1)) { EFT_STATUS = 1; }
EFT_INTERACT = "";
L0050();
if (EFT_INTERACT != "") {
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
INTERACT = EFT_INTERACT;
nrf0 = 0;
FL_RTEFT_PORT = new FL_RTEFT_PORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref INTERACT, ref CHIPANDPINTX);
}
// END CASE
return;
}
//*
// Eft Presumed OK - try to continue
//*
if (CHIPANDPIN && CARD_NO == "") {
EFT_INTERACT = "";
SEGMESS = "";
SEGMESS[2] = "Please see Chip and pin device";
SEGMESS[3] = "Eft Port " + PORT_NAME + "Chip and Pin Transaction";
EFT_PROMPT = "";
EFT_ERRFLAG = FALSE;
L0100();
FL_CHIPANDPIN = new FL_CHIPANDPIN(ref PORT_NAME, ref TRANS_AMOUNT, ref SWIPE_DETAILS, ref CARD_NO, ref EFT_EXP, ref CARD_ISSUE, ref CARD_START, ref TRANS_TYPE, ref AUTH_CODE, ref ERROR_CODE, ref ERROR_DESC, ref RESULT_CODE, ref USER_MESSAGE, ref EFT_CONF, ref MEMBER_NO, ref CALLING_PROG, ref CUST_PRT_REC, ref SALE_PRT_REC);
if (ERROR_CODE != 0) { INTERACT = INVALID_DATA; }
} else {
//*
// DELETE OLD FILES
//*
RQM();
if (EFT_TYPE == "WINTI") {
DELETE(FL_EFT_SHARE, "T000" + PORT_NAME + ".OUT");
CRT(1);
DELETE(FL_EFT_SHARE, "T000" + PORT_NAME + ".CNF");
} else {
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU1");
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2");
CRT(1);
DELETE(FL_EFT_SHARE, "FIO" + PORT_NAME + ".STA");
}
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE*" + PORT_NUMBER, 1))) {
if (!(READV(ref SLIP_PRINT_ROUTINE, COMMON.FILES[FL_CONTROL], "SLIP.PRINT.ROUTINE", 1))) {
SLIP_PRINT_ROUTINE = "FL00017";
}
}
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
SIGSLIP_REQ = FALSE;
}// CASE
else if (OTHERWISE) {
if (!READV(ref SIGSLIP_REQ, COMMON.FILES[FL_CONTROL], "EFT.SIG.REQ", 1)) { SIGSLIP_REQ = 1; }
}
// END CASE
MEMBER_NO = EFT_CONF;
if (CARD_EXP != "") {
EFT_EXP = CARD_EXP.Substring(3, 2) + CARD_EXP.Substring(1, 2);
// DJA 20.4.00 VNA was occurring in FL.RTEFT
} else {
EFT_EXP = "";
}
if (CARD_START != "") {
//           CARD.START = CARD.START[3,2]:CARD.START[1,2]
} else {
CARD_START = "";
}
INTERACT = VALID_DATA;
AUTH_STEP = 0;
MAX_STEPS = 5;
do {
if (INTERACT != VALID_DATA || AUTH_STEP > 5) break;
AUTH_STEP = AUTH_STEP + 1;
#region ON AUTH_STEP GOSUB ...
switch ((int)AUTH_STEP) {
case 1: L0100(); break;
case 2: L0200(); break;
case 3: L0300(); break;
case 4: L0400(); break;
case 5: L0500(); break;
}
#endregion
} while (true);
}
//*
// RESTORE DISPLAY
//*
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
// IMPORTANT: FL.EFT.STATUS cannot destroy the panel
//            because this program will make subsequent
//            calls which assume the controls are all
//            present & correct
nrf0 = "form0.pnlEFT";
FWDC = new FWDC(ref nrf0);
nrf0 = 0;
FL_RTEFT_PORT = new FL_RTEFT_PORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref REPLY, ref CHIPANDPINTX);
}// CASE
else if (CALLING_PROG == "FWEFT") {
// Use REPLY to avoid overwriting significant data in INTERACT
nrf0 = 0;
FWEFTPORT = new FWEFTPORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref REPLY);
}// CASE
else if (OTHERWISE) {
PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
nrf0 = 0;
FL_RTEFT_PORT = new FL_RTEFT_PORT(ref CALLING_PROG, ref PORT_NAME, ref nrf0, ref REPLY, ref CHIPANDPINTX);
}
// END CASE
if (CLIENT_APP_TYPE.Substring(1, 1) == "W") {
PRINTCR(CHAR(28) + "409" + CHAR(20));
}
if (OPEN("FL.CHIP.SHARE", out FL_CHIP_SHARE)) {
DELETE(FL_CHIP_SHARE, "T000" + PORT_NAME + ".OUT");
DELETE(FL_CHIP_SHARE, "T000" + PORT_NAME + ".out");
}
return;
//****
// SUBROUTINES
//****
}
void L0050() {
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
L0100();
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
else if (OTHERWISE) {
SEGMESS = "UNKNOWN STATUS";
L0100();
}
// END CASE
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
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref EFT_ERRFLAG, ref EFT_REPLY, ref CALLING_PROG);
}
// END CASE
return;
//**
}
void L0200() {
// Set up transaction type
//*****
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
BATCH_JOB = TRUE;
if (PROG_MESS[21] < 2) {
TRANS_TYPE = 2;
} else {
TRANS_TYPE = 8;
// DJA 30.7.01
}
}// CASE
else if (CALLING_PROG.Substring(1, 3) == "FWT") {
BATCH_JOB = TRUE;
TRANS_TYPE = 2;
//ECOMMERCE
BATCH_JOB = TRUE;
}// CASE
else if (OTHERWISE) {
if (SWIPE_DETAILS == "" && CHIPANDPINTX == FALSE) {
//IF SWIPE.DETAILS = "" THEN
if (READV(ref TRANS_TYPE, COMMON.FILES[FL_CONTROL], "EFT*CHS*" + CALLING_PROG, 1)) {
BATCH_JOB = TRUE;
} else {
SEGMESS = "Manually Entered Card";
SEGMESS[2] = "Waiting for input";
EFT_PROMPT = "Is the customer present? (Y/N)" + AM + 3 + AM + "Y" + VM + "N";
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
if (EFT_REPLY == "N") {
TRANS_TYPE = "8";
} else {
TRANS_TYPE = "0";
}
}
} else {
if (READV(ref TRANS_TYPE, COMMON.FILES[FL_CONTROL], "EFT*CHS*" + CALLING_PROG, 1)) {
BATCH_JOB = TRUE;
} else {
TRANS_TYPE = "0";
}
}
}
// END CASE
if (TRANS_AMOUNT < 0) {
if (EFT_TYPE == "WINTI") {
TRANS_TYPE = TRANS_TYPE + "2";
} else {
TRANS_TYPE = TRANS_TYPE + "4";
}
TRANS_AMOUNT = ABS(TRANS_AMOUNT);
} else {
if (EFT_TYPE == "WINTI") {
TRANS_TYPE = TRANS_TYPE + "1";
} else {
TRANS_TYPE = TRANS_TYPE + "0";
}
}
return;
//*****
}
void L0300() {
// Get Authorisation & log request
//*****
if (EFT_TYPE == "WINTI") {
FL_WINTI = new FL_WINTI(ref PORT_NAME, ref TRANS_AMOUNT, ref SWIPE_DETAILS, ref CARD_NO, ref EFT_EXP, ref CARD_ISSUE, ref CARD_START, ref TRANS_TYPE, ref AUTH_CODE, ref ERROR_CODE, ref ERROR_DESC, ref RESULT_CODE, ref USER_MESSAGE, ref EFT_CONF, ref MEMBER_NO, ref CALLING_PROG, ref CUST_PRT_REC, ref SALE_PRT_REC, ref CARD_CVS, ref CARD_HOUSENAMENO, ref CARD_POSTCODE, ref SPARE1, ref SPARE2, ref SPARE3);
} else {
FL_RTEFT = new FL_RTEFT(ref PORT_NAME, ref TRANS_AMOUNT, ref SWIPE_DETAILS, ref CARD_NO, ref EFT_EXP, ref CARD_ISSUE, ref CARD_START, ref TRANS_TYPE, ref AUTH_CODE, ref ERROR_CODE, ref ERROR_DESC, ref RESULT_CODE, ref USER_MESSAGE, ref EFT_CONF, ref MEMBER_NO, ref CALLING_PROG, ref CUST_PRT_REC, ref SALE_PRT_REC);
}
FL_CC_ENCODE = new FL_CC_ENCODE(ref CARD_NO);
EFT_LOGKEY = PORT_NAME + "*" + TODAYS_DATE + "*" + TIME() + "*" + EFT_CONF[2];
EFT_LOGREC = EFT_CONF;
EFT_LOGREC[5] = MEMBER_NO;
EFT_LOGREC[6] = LOG_AMOUNT;
if (SWIPE_DETAILS != "") {
EFT_LOGREC[7] = "SWIPED";
} else {
EFT_LOGREC[7] = "";
}
//!!     EFT.LOGREC<7>=SWIPE.DETAILS
EFT_LOGREC[8] = CARD_NO;
EFT_LOGREC[9] = EFT_EXP;
EFT_LOGREC[10] = CARD_ISSUE;
EFT_LOGREC[11] = CARD_START;
EFT_LOGREC[12] = TRANS_TYPE;
EFT_LOGREC[13] = ERROR_CODE;
EFT_LOGREC[14] = ERROR_DESC;
EFT_LOGREC[15] = RESULT_CODE;
EFT_LOGREC[16] = USER_MESSAGE;
EFT_LOGREC[21] = TRIM(FIELD(SALE_PRT_REC[3], ":", 2));
WRITE(EFT_LOGREC, FL_EFT_LOG, EFT_LOGKEY);
return;
//*****
}
void L0400() {
// Deal with error message
//*****
if (EFT_TYPE == "WINTI") {
//!*CRT "<<<RESULT.CODE=":RESULT.CODE:;INPUT FLEX,2:
if (RESULT_CODE != 6 && RESULT_CODE != 0) {
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE + "*WINTI"))) {
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE))) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
}
if (RESULT_CODE == 2) {
if (READV(ref OUTREC, FL_EFT_SHARE, "T000" + PORT_NAME + ".OUT", 1)) {
PHONE_NO = FIELD(OUTREC, ",", 16);
USERMESS[7] = "Call : " + PHONE_NO;
}
}
SEGMESS[2] = "Result code : " + RESULT_CODE + "  Error : " + ERROR_CODE;
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
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
ACK_LOG = "";
WRITE(ACK_LOG, FL_EFT_LOG, U_INITS + "*" + TODAYS_DATE + "*" + TIME());
}
// END CASE
}
} else {
// Not WinTi
if (RESULT_CODE < 7) {
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE))) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
if (RESULT_CODE == 5) {
if (READV(ref PHONE_NO, FL_EFT_SHARE, "FIO" + PORT_NAME + ".OU2", 13)) {
USERMESS[7] = "Call : " + PHONE_NO;
}
}
SEGMESS[2] = "Result code : " + RESULT_CODE + "  Error : " + ERROR_CODE;
for(SLOOP = 1; SLOOP <= 8; SLOOP += 1) {
SEGMESS[3 + SLOOP] = USERMESS[SLOOP];
}
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message " + AM + 3 + AM + "YES";
} else {
EFT_PROMPT = "Have you read this message? (YES) " + AM + 3 + AM + "YES";
}
nrf0 = 0;
nrf1 = 1;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
ACK_LOG = "";
WRITE(ACK_LOG, FL_EFT_LOG, U_INITS + "*" + TODAYS_DATE + "*" + TIME());
}
}
return;
//*****
}
void L0500() {
// Confirm Transaction
//*****
ANS = "";
if (ERROR_CODE != 1) {
EFT_CONFTYPE = "";
//  -STET* MOVED NEXT LINE TO LATER ON
if (ERROR_CODE == 7) {
if (CALLING_PROG == "FWEFT") {
EFT_CONFTYPE = EFT_DECLINED;
EFT_AUTHCODE = "";
//!*  PROG.MESS<17> = 1019
//!*  PROG.MESS<18> = "Transaction declined"
//!*  INTERACT = INVALID.DATA
} else {
L0600();
}
}
if (ERROR_CODE < 1 || ERROR_CODE == 7) {
if (EFT_CONFTYPE != EFT_DECLINED) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
if (TRANS_TYPE.Substring(1, 1) != "8" || SIGSLIP_REQ == 1) {
CallAt_SLIP_PRINT_ROUTINE = new CallAt_SLIP_PRINT_ROUTINE(ref SLIP_PRINT_ROUTINE, ref SALE_PRT_REC);
}
}
// END CASE
if (BATCH_JOB == TRUE) {
ANS = "Y";
} else {
//IF ERROR.CODE = 7 THEN
//ANS = "Y"
//END ELSE
EFT_PROMPT = "Proceed? (Y/N) " + AM + 3 + AM + "Y" + VM + "N";
SEGMESS = "";
SEGMESS[2] = "Waiting for input";
if (TRANS_TYPE.Substring(1, 1) == "8") {
SEGMESS[6] = "Proceed? (Y/N)";
SEGMESS[7] = "";
} else {
SEGMESS[6] = "Check the signature";
SEGMESS[7] = "";
}
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref ANS, ref CALLING_PROG);
EFT_PROMPT = "";
//END
}
if (ANS == "Y") {
EFT_CONFTYPE = 1;
EFT_PROMPT = "";
// -STET* MOVED IT HERE
//                 IF ERROR.CODE = 7 THEN GOSUB 0600;* Get Auth code
} else {
EFT_CONFTYPE = 9;
ERROR_CODE = 9;
// TRANSACTION REVERSED
INTERACT = INVALID_DATA;
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE))) {
USERMESS = "TRANSACTION ABORTED BY OPERATOR";
}
SEGMESS[2] = "Result code : " + RESULT_CODE + "  Error : " + ERROR_CODE;
for(SLOOP = 1; SLOOP <= 5; SLOOP += 1) {
SEGMESS[3 + SLOOP] = USERMESS[SLOOP];
}
nrf0 = 0;
nrf1 = "";
nrf2 = 1;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref nrf1, ref nrf2, ref EFT_REPLY, ref CALLING_PROG);
}
}
EFT_CONF[4] = EFT_CONFTYPE;
if (EFT_CONF[1] == "") {
EFT_CONF[1] = EFT_AUTHCODE;
} else {
EFT_AUTHCODE = EFT_CONF[1];
}
EFT_SEQNO = EFT_CONF[2];
EFT_MERCHANT = EFT_CONF[3];
if (EFT_TYPE == "WINTI") {
//!*CRT "ABOUT TO CALL FL.WINTI.CONF":;INPUT FLEX,1:
FL_WINTI_CONF = new FL_WINTI_CONF(ref ERROR_CODE, ref PORT_NAME, ref EFT_CONFTYPE, ref EFT_AUTHCODE, ref EFT_SEQNO, ref EFT_MERCHANT, ref CALLING_PROG);
//!*CRT "ERROR.CODE=":ERROR.CODE:;INPUT FLEX,1:
} else {
FL_RTEFT_CONF = new FL_RTEFT_CONF(ref ERROR_CODE, ref PORT_NAME, ref EFT_CONFTYPE, ref EFT_AUTHCODE, ref EFT_SEQNO, ref EFT_MERCHANT, ref CALLING_PROG);
}
if (EFT_CONFTYPE == 9) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
PROG_MESS[17] = 1019;
PROG_MESS[18] = "Transaction declined";
INTERACT = INVALID_DATA;
}// CASE
else if (OTHERWISE) {
EFT_SLIPTYPE = 3;
PRINT_REC = SALE_PRT_REC;
PRINT_REC[1] = "TRANSACTION CANCELLED";
PRINT_REC[2] = "AUDIT COPY";
PRINT_REC[3] = "***VOID***";
PRINT_REC[7] = "PLEASE KEEP THIS ABORT VOUCHER";
PRINT_REC[8] = "VOID TRANSACTION";
PRINT_REC[13] = "";
CallAt_SLIP_PRINT_ROUTINE = new CallAt_SLIP_PRINT_ROUTINE(ref SLIP_PRINT_ROUTINE, ref PRINT_REC);
INTERACT = INVALID_DATA;
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "An error has occurred. Please ensure that you have read the message" + AM + 3 + AM + "Y";
} else {
EFT_PROMPT = "Proceed? (Y) " + AM + 3 + AM + "Y";
}
}
// END CASE
} else {
if (RESULT_CODE > 0) {
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
CallAt_SLIP_PRINT_ROUTINE = new CallAt_SLIP_PRINT_ROUTINE(ref SLIP_PRINT_ROUTINE, ref CUST_PRT_REC);
}
// END CASE
}
}
} else {
//** REMOVE THE NEXT BIT IF ABORT VOUCHER NOT REQD
if (EFT_TYPE == "WINTI") {
//!*           BEGIN CASE
//!*           CASE CALLING.PROG = "FWEFT"
//!*           CASE OTHERWISE
if (RESULT_CODE == 5) {
EFT_CONFTYPE = "9";
EFT_CONF[4] = EFT_CONFTYPE;
if (EFT_CONF[1] == "") {
EFT_CONF[1] = EFT_AUTHCODE;
} else {
EFT_AUTHCODE = EFT_CONF[1];
}
EFT_SEQNO = EFT_CONF[2];
EFT_MERCHANT = EFT_CONF[3];
FL_WINTI_CONF = new FL_WINTI_CONF(ref ERROR_CODE, ref PORT_NAME, ref EFT_CONFTYPE, ref EFT_AUTHCODE, ref EFT_SEQNO, ref EFT_MERCHANT, ref CALLING_PROG);
if (CALLING_PROG != "FWEFT") {
PRINT_REC = SALE_PRT_REC;
PRINT_REC[1] = "TRANSACTION CANCELLED";
PRINT_REC[2] = "AUDIT COPY";
PRINT_REC[3] = "***VOID***";
PRINT_REC[7] = "PLEASE KEEP THIS ABORT VOUCHER";
PRINT_REC[8] = "DECLINED TRANSACTION";
PRINT_REC[13] = "";
CallAt_SLIP_PRINT_ROUTINE = new CallAt_SLIP_PRINT_ROUTINE(ref SLIP_PRINT_ROUTINE, ref PRINT_REC);
}
}
//!*           END CASE
} else {
// Not WinTi
if (ERROR_CODE == 4 && RESULT_CODE == 6) {
PRINT_REC = SALE_PRT_REC;
PRINT_REC[1] = "TRANSACTION CANCELLED";
PRINT_REC[2] = "AUDIT COPY";
PRINT_REC[3] = "***VOID***";
PRINT_REC[7] = "PLEASE KEEP THIS ABORT VOUCHER";
PRINT_REC[8] = "DECLINED TRANSACTION";
PRINT_REC[13] = "";
CallAt_SLIP_PRINT_ROUTINE = new CallAt_SLIP_PRINT_ROUTINE(ref SLIP_PRINT_ROUTINE, ref PRINT_REC);
}
}
EFT_CONFTYPE = 9;
ERROR_CODE = 9;
// Transaction aborted
INTERACT = INVALID_DATA;
}
EFT_LOGREC[4] = EFT_CONFTYPE;
EFT_LOGREC[20] = ERROR_CODE;
WRITE(EFT_LOGREC, FL_EFT_LOG, EFT_LOGKEY);
} else {
INTERACT = INVALID_DATA;
// BEGIN CASE
// CASE
if (CALLING_PROG == "TICKET.TOUCH") {
EFT_PROMPT = "Please ensure that your supervisor is informed about this error" + AM + 4 + AM + "YES";
}// CASE
else if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Is your supervisor aware? (YES) " + AM + 4 + AM + "YES";
}
// END CASE
}
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*COMPLETE*" + ERROR_CODE))) {
USERMESS = "TRANSACTION COMPLETE " + ERROR_CODE;
}
for(SLOOP = 1; SLOOP <= 5; SLOOP += 1) {
SEGMESS[3 + SLOOP] = USERMESS[SLOOP];
}
// BEGIN CASE
// CASE
if (CALLING_PROG == "FWEFT") {
NULL();
}// CASE
else if (OTHERWISE) {
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_REPLY, ref CALLING_PROG);
}
// END CASE
return;
}
void L0600() {
// Get manual auth code
//*****
if (!(READV(ref EFT_MATCH, COMMON.FILES[FL_CONTROL], "EFT.AUTHMATCH", 1))) {
EFT_MATCH = "4A0N";
}
INTERACT = INVALID_DATA;
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE + "*1"))) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
SEGMESS = "Result code : " + RESULT_CODE + "  Error : " + ERROR_CODE;
EFT_PROMPT = "Authorised? (Y/N)  " + AM + 10 + AM + "Y" + VM + "N";
for(SLOOP = 1; SLOOP <= 8; SLOOP += 1) {
SEGMESS[4 + SLOOP] = USERMESS[SLOOP];
}
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_AUTHCODE, ref CALLING_PROG);
if (EFT_AUTHCODE != "N") {
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE + "*3"))) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
for(SLOOP = 1; SLOOP <= 3; SLOOP += 1) {
SEGMESS[9 + SLOOP] = USERMESS[SLOOP];
}
do {
if (INTERACT == VALID_DATA) break;
EFT_PROMPT = "Auth Code   " + AM + 10 + AM + "";
INTERACT = INVALID_DATA;
nrf0 = 0;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref EFT_AUTHCODE, ref CALLING_PROG);
// BEGIN CASE
// CASE
if (EFT_AUTHCODE == "DECLINED") {
EFT_CONFTYPE = EFT_DECLINED;
INTERACT = VALID_DATA;
}// CASE
else if (TRIM(EFT_AUTHCODE) == "") {
if (CALLING_PROG == "TICKET.TOUCH") {
MESSAGE = "Missing or invalid authorisation code";
nrf0 = mtError;
nrf1 = mbOK;
nrf2 = 60;
FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
} else {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
INTERACT = INVALID_DATA;
//           CASE NUM (EFT.AUTHCODE) OR EFT.AUTHCODE MATCHES EFT.MATCH
}// CASE
else if (OTHERWISE) {
EFT_PROMPT = "Confirm : " + EFT_AUTHCODE + " (YES/NO)" + AM + 4 + AM + "YES" + VM + "NO";
if (!(READ(ref USERMESS, FL_EFT_ERRORS, "FLEX*" + ERROR_CODE + "*2"))) {
USERMESS = "UNEXPECTED ERROR CODE <" + ERROR_CODE + ">";
}
for(SLOOP = 1; SLOOP <= 3; SLOOP += 1) {
SEGMESS[9 + SLOOP] = USERMESS[SLOOP];
}
nrf0 = 3;
nrf1 = 0;
FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref SEGMESS, ref nrf0, ref EFT_PROMPT, ref nrf1, ref ANS, ref CALLING_PROG);
if (ANS == "YES") {
INTERACT = VALID_DATA;
EFT_CONFTYPE = EFT_ACCEPTED;
} else {
INTERACT = INVALID_DATA;
}
//           CASE OTHERWISE
//              CALL FL006(PROGRAM,2,"")
}
// END CASE
} while (true);
} else {
EFT_CONFTYPE = EFT_DECLINED;
EFT_AUTHCODE = "";
}
SEGMESS = "";
SEGMESS[6] = "Processing...";
SALE_PRT_REC[10] = "Auth Code : " + EFT_AUTHCODE;
CUST_PRT_REC[10] = "Auth Code : " + EFT_AUTHCODE;
return;
}
}
}
