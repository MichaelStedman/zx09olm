//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_GETHTM : UvBase
{
#region Variables
UvVar TEXTIN = "";
UvVar TEXTOUT = "";
UvVar LAST_ROW = "";
UvVar LAST_COL = "";
UvVar THIS_ROW = "";
UvVar THIS_COL = "";
UvVar STYLE = "";
UvVar JUST = "";
UvVar COLOUR = "";
UvVar LASTAND = "";
UvVar EXPLORE_RESULT = "";
UvVar SUM_TEXT = "";
   UvVar ZZZ_class = "";
UvVar classval = "";
//UvVar class = "";
UvVar font_style = "";
UvVar terminator = "";
UvVar cell_height = "";
UvVar row_span = "";
UvVar col_span = "";
UvVar ROWSPAN = "";
UvVar AM = "";
UvVar COLSPAN = "";
#endregion
public FL_GETHTM(ref UvVar TEXTIN, ref UvVar TEXTOUT, ref UvVar LAST_ROW, ref UvVar LAST_COL, ref UvVar THIS_ROW, ref UvVar THIS_COL, ref UvVar STYLE, ref UvVar JUST, ref UvVar COLOUR) {
this.TEXTIN = TEXTIN;
this.TEXTOUT = TEXTOUT;
this.LAST_ROW = LAST_ROW;
this.LAST_COL = LAST_COL;
this.THIS_ROW = THIS_ROW;
this.THIS_COL = THIS_COL;
this.STYLE = STYLE;
this.JUST = JUST;
this.COLOUR = COLOUR;
/*  HTML CONVERTER */
/*  Richard T Jan 2001 */
TEXTOUT = "";
/*  if text contains the special command &TODAY& do the hard bit */
if (TEXTIN == "&TODAY&") {
TEXTIN = "x:fmla=\"=DAY(TODAY()) &amp;&quot;/&quot;&amp;MONTH(TODAY())&amp;&quot;/&quot;&amp;YEAR(TODAY())\"";
}
if (TEXTIN.Substring(1, 5) == "&SUM(") {
LASTAND = INDEX(TEXTIN, "&", 2);
EXPLORE_RESULT = FIELD(TEXTIN, "&", 3);
SUM_TEXT = FIELD(TEXTIN, "&", 2);
if (EXPLORE_RESULT != "") { EXPLORE_RESULT = ">" + EXPLORE_RESULT; }
TEXTIN = "x:num x:fmla=\"=" + SUM_TEXT + "\"" + EXPLORE_RESULT;
}
classval = 24 + (12 * COLOUR) + (STYLE * 3) + JUST;
if (classval == 24) {
ZZZ_class = "";
} else {
ZZZ_class = " class=xl" + classval;
}
font_style = "";
terminator = "";
cell_height = "";
row_span = "";
col_span = "";
if (LAST_ROW != THIS_ROW) {
if (STYLE != 3) {
cell_height = "height=19";
font_style = " style='height:14.25pt";
terminator = "'";
} else {
cell_height = "height=23";
font_style = " style='height:17.25pt";
terminator = "'";
}
if (LAST_ROW != 0) {
/*  Terminate Last Row */
TEXTOUT = "</tr>";
} else {
TEXTOUT = "";
}
ROWSPAN = THIS_ROW - LAST_ROW;
if (ROWSPAN > 1) {
row_span = " <tr height=" + ROWSPAN - 1 * 17 + " style='height:" + 12.75M * ROWSPAN - 1 + "pt;mso-xlrowspan:" + ROWSPAN - 1 + "'> " + AT(AM);
}
LAST_ROW = THIS_ROW;
if (row_span != "") {
TEXTOUT[-1] = row_span;
}
TEXTOUT[-1] = "<tr " + cell_height + font_style + terminator + ">";
}
COLSPAN = THIS_COL - LAST_COL;
if (COLSPAN > 1) {
col_span = " colspan=" + COLSPAN - 1;
if (STYLE != 3) {
font_style = " style='height:14.25pt;mso-ignore:colspan";
/* terminator = "'" */
terminator = "'></td" + AT(AM + "<td " + ZZZ_class + " style='height:14.25pt'");
} else {
font_style = " style='height:17.25pt;mso-ignore:colspan";
/* terminator = "'" */
terminator = "'></td" + AT(AM + "<td " + ZZZ_class + " style='height:17.25pt'");
}
}
/*  construct output */
if (NUM(TEXTIN)) {
terminator = terminator + " x:num>";
} else {
if (TEXTIN.Substring(1, 6) == "x:fmla" || TEXTIN.Substring(1, 5) == "x:num") {
if (TEXTIN.Substring(1, 6) == "x:fmla") {
terminator = terminator + " x:num ";
} else {
terminator = terminator + " ";
}
} else {
terminator = terminator + ">";
}
}
TEXTOUT[-1] = "<td " + cell_height + ZZZ_class + col_span + font_style + terminator + TEXTIN + "</td>";
LAST_COL = THIS_COL;
LAST_ROW = THIS_ROW;
return;
}
}
}
