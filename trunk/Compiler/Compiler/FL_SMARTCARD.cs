//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_SMARTCARD : UvBase
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
      readonly UvVar FWTERM_MODE = 0;
      readonly UvVar TOUCHSCREEN_MODE = 1;
      readonly UvVar SILENT_MODE = 2;
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
      readonly UvVar APACS_MEMBER = 1;
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      readonly UvVar EPURSE_APACS_NO = 1;
      readonly UvVar EPURSE_MEM_NO = 2;
      readonly UvVar EPURSE_DATE = 3;
      readonly UvVar EPURSE_TIME = 4;
      readonly UvVar EPURSE_USER = 5;
      readonly UvVar EPURSE_AMOUNT = 6;
      readonly UvVar EPURSE_CRED_OR_DEB = 7;
      readonly UvVar NOT_PRESENT = 9;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] APACS_REC = new UvVar[10];
      UvVar[] EPURSE_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar IFACE_TYPE = "";
      UvVar MEMBER_NO = "";
      UvVar TRANS_AMOUNT = "";
      UvVar TRANS_TYPE = "";
      UvVar TRANS_ID = "";
      UvVar DISPLAY_MODE = "";
      UvVar INTERACT = "";
      UvVar CARD_ERROR_TYPE = "";
      UvVar CARD_ERROR_MESS = "";
      UvVar EPURSE_BALANCE = "";
      UvVar LOYALTY_BALANCE = "";
      UvVar APACS_NO = "";
      UvVar U_INITS = "";
      FL006 FL006;
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
      UvVar PROGRAM = "";
      UvVar FL_APACS_NUMBERS = "";
      UvVar FL_EPURSE_LOG = "";
      UvVar SMART_REC = "";
      UvVar MESSAGE = "";
      FWSHOWMESSAGEDIALOG FWSHOWMESSAGEDIALOG;
      UvVar REPLY = "";
      UvVar SMART_CARD = "";
      UvVar APACS_ONLY_CARDS = "";
      UvVar GET_NUMBER_PROG = "";
      UvVar UPDATE_EPURSE_PROG = "";
      UvVar UPDATE_LOYALTY_PROG = "";
      CallAt_GET_NUMBER_PROG CallAt_GET_NUMBER_PROG;
      CallAt_UPDATE_EPURSE_PROG CallAt_UPDATE_EPURSE_PROG;
      UvVar EPURSE_TRANS_ID = "";
      FL00019 FL00019;
      UvVar CNT = "";
      UvVar ANS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL_SMARTCARD(ref UvVar IFACE_TYPE, ref UvVar MEMBER_NO, ref UvVar TRANS_AMOUNT, ref UvVar TRANS_TYPE, ref UvVar TRANS_ID, ref UvVar DISPLAY_MODE, ref UvVar INTERACT, ref UvVar CARD_ERROR_TYPE, ref UvVar CARD_ERROR_MESS, ref UvVar EPURSE_BALANCE, ref UvVar LOYALTY_BALANCE, ref UvVar APACS_NO)
      {
         this.IFACE_TYPE = IFACE_TYPE;
         this.MEMBER_NO = MEMBER_NO;
         this.TRANS_AMOUNT = TRANS_AMOUNT;
         this.TRANS_TYPE = TRANS_TYPE;
         this.TRANS_ID = TRANS_ID;
         this.DISPLAY_MODE = DISPLAY_MODE;
         this.INTERACT = INTERACT;
         this.CARD_ERROR_TYPE = CARD_ERROR_TYPE;
         this.CARD_ERROR_MESS = CARD_ERROR_MESS;
         this.EPURSE_BALANCE = EPURSE_BALANCE;
         this.LOYALTY_BALANCE = LOYALTY_BALANCE;
         this.APACS_NO = APACS_NO;
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
         /*  Interacts with smartcard readers */
         /*  DISPLAY.MODE */
         /*  ------------ */
         /*  FWTERM.MODE       Free to use FL006, FL019, PRINT, INPUT etc */
         /*  TOUCHSCREEN.MODE  All user interaction via GUI controls */
         /*  SILENT.MODE       e.g. for Web. Pass back any errors. NO user */
         /*                    interaction is possible. */
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
         PROGRAM = "FL.SMARTCARD";
         /*  Argument Definitions */
         /*  IFACE.TYPE */
         /*   1 - Get the Member number on the Card */
         /*   2 - Request an update of either the EPurse or the Loyalty points */
         /*   4 - Write the supplied Member number on the Card */
         /*  MEMBER.NO */
         /*   Six digit Member number */
         /*   "NONMEMBER" if no Member number present on Card */
         /*  TRANS.AMOUNT */
         /*   Amount in pence (can be negative) */
         /*   Points (can be negative) */
         /*  TRANS.TYPE */
         /*   E   -  Update the Epurse (money) */
         /*   B   -  Update the Loyalty Points (points) */
         /*   ETU -  Update the Epurse (money) for top-up */
         /*  TRANS.ID */
         /*   A unique reference number (from Flex) */
         /*  INTERACT */
         /*   Error Codes */
         /*  CARD.ERROR.TYPE */
         /*   C - Card present and authorised by PCL */
         /*   H - Hotlisted */
         /*   E - General read error */
         /*  CARD.ERROR.MESS */
         /*   40 Character message following either "H" or "E" card error */
         /*  EPURSE.BALANCE */
         /*   Current Epurse Value (in pence) */
         /*  LOYALTY.BALANCE */
         /*   Current Loyalty points */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.APACS.NUMBERS
         if (!OPEN("FL.APACS.NUMBERS", out FL_APACS_NUMBERS)) { STOP("201", "FL.APACS.NUMBERS"); }

         #endregion
         #region INCLUDE FL.FILES FL.EPURSE.LOG
         if (!OPEN("FL.EPURSE.LOG", out FL_EPURSE_LOG)) { STOP(201, "UNABLE TO OPEN FL.EPURSE.LOG"); }

         /*  <7> Contains (D)ebit or (C)redit */

         #endregion
         if (!(READ(ref SMART_REC, COMMON.FILES[FL_CONTROL], "SMART.CARD.SITE")))
         {
            // BEGIN CASE
            // CASE
            if (DISPLAY_MODE == FWTERM_MODE)
            {
               nrf0 = 1;
               nrf1 = 100;
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (DISPLAY_MODE == TOUCHSCREEN_MODE)
            {
               MESSAGE = "Smartcard parameters have not been configured";
               nrf0 = mtError;
               nrf1 = mbOK;
               nrf2 = 60;
               FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
            }// CASE
            else if (OTHERWISE)
            {
               /*  Silent mode */
               NULL();
            }
            // END CASE
            return;
         }
         if (SMART_REC[1, 1] == TRUE)
         {
            SMART_CARD = TRUE;
            APACS_ONLY_CARDS = SMART_REC[2, 1];
            GET_NUMBER_PROG = SMART_REC[3, 1];
            UPDATE_EPURSE_PROG = SMART_REC[4, 1];
            UPDATE_LOYALTY_PROG = SMART_REC[5, 1];
         }
         CARD_ERROR_TYPE = "";
         // BEGIN CASE
         // CASE
         if (IFACE_TYPE == 1)
         {
            /*  Check for Member Number */
            CallAt_GET_NUMBER_PROG = new CallAt_GET_NUMBER_PROG(ref GET_NUMBER_PROG, ref IFACE_TYPE, ref MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
         }// CASE
         else if (IFACE_TYPE == 2)
         {
            /*  Update ePurse Balance */
            if (TRANS_TYPE == "ETU")
            {
               PROGRAM = PROGRAM + ".TOPUP";
               TRANS_TYPE = "E";
            }
            CallAt_UPDATE_EPURSE_PROG = new CallAt_UPDATE_EPURSE_PROG(ref UPDATE_EPURSE_PROG, ref IFACE_TYPE, ref MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
            if (TRANS_AMOUNT != 0 && INTERACT == VALID_DATA)
            {
               MAT(ref EPURSE_REC, "");
               EPURSE_REC[EPURSE_APACS_NO] = APACS_NO;
               EPURSE_REC[EPURSE_MEM_NO] = MEMBER_NO;
               EPURSE_REC[EPURSE_AMOUNT] = TRANS_AMOUNT;
               EPURSE_REC[EPURSE_USER] = U_INITS;
               EPURSE_REC[EPURSE_TIME] = TIME();
               EPURSE_REC[EPURSE_DATE] = DATE();
               EPURSE_TRANS_ID = TRANS_ID;
               if (TRANS_TYPE == "ETU")
               {
                  EPURSE_REC[EPURSE_CRED_OR_DEB] = "C";
               }
               else
               {
                  EPURSE_REC[EPURSE_CRED_OR_DEB] = "D";
               }
               FL00019 = new FL00019(ref EPURSE_REC, ref TRANS_ID, ref EPURSE_BALANCE, ref PROGRAM);
               EPURSE_TRANS_ID = COMMON.CENTRE + "/" + EPURSE_TRANS_ID;
               MATWRITE(EPURSE_REC, FL_EPURSE_LOG, EPURSE_TRANS_ID);
            }
         }// CASE
         else if (IFACE_TYPE == 99)
         {
            /*  Remove Card */
            CNT = 0;
            do
            {
               CNT = CNT + 1;
               IFACE_TYPE = 1;
               if (CNT > 1)
               {
                  // BEGIN CASE
                  // CASE
                  if (DISPLAY_MODE == FWTERM_MODE)
                  {
                     nrf0 = "PCL.SMART.CODE"; nrf1 = 999; FL006 = new FL006(ref nrf0, ref nrf1, ref CNT);
                  }// CASE
                  else if (DISPLAY_MODE == TOUCHSCREEN_MODE)
                  {
                     /* !*MESSAGE = "Please remove the smartcard from the reader (request: ":CNT:")" */
                     MESSAGE = "Please remove the smartcard from the reader";
                     nrf0 = mtError;
                     nrf1 = mbOK;
                     nrf2 = 60;
                     FWSHOWMESSAGEDIALOG = new FWSHOWMESSAGEDIALOG(ref MESSAGE, ref nrf0, ref nrf1, ref nrf2, ref REPLY);
                  }// CASE
                  else if (OTHERWISE)
                  {
                     /*  Silent mode */
                     NULL();
                  }
                  // END CASE
               }
               CallAt_GET_NUMBER_PROG = new CallAt_GET_NUMBER_PROG(ref GET_NUMBER_PROG, ref IFACE_TYPE, ref MEMBER_NO, ref TRANS_AMOUNT, ref TRANS_TYPE, ref TRANS_ID, ref INTERACT, ref CARD_ERROR_TYPE, ref CARD_ERROR_MESS, ref EPURSE_BALANCE, ref LOYALTY_BALANCE, ref APACS_NO);
               if (INTERACT == NOT_PRESENT) break;
            } while (true);
            /* *********************************** */
         }
         // END CASE
         ANS = "INVAL";
         /*  Return to calling program */
         return;
         /* ********************* */
         /*   End of program    * */
         /* ********************* */
      }
   }
}
