//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL796 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] COURSE_PARAM_REC = new UvVar[60];
#endregion
#region Variables
UvVar RESPONSE = "";
UvVar FL_COURSE_PARAMS = "";
UvVar KEY_REC = "";
#endregion
public FL796(ref UvVar RESPONSE) {
this.RESPONSE = RESPONSE;
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
/*  SEE DJA */
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
if (!READ(ref KEY_REC, FL_COURSE_PARAMS, "AD.KEY")) { KEY_REC = ""; }
if (KEY_REC[1] < DATE()) {
RESPONSE = FALSE;
} else {
RESPONSE = TRUE;
}
return;
}
}
}
