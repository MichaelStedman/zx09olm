using Legacy.Library;
namespace Legacy.LeisureFlex
{
public class TEST : UvBase
{
#region Arrays
UvVar[] SUB_REC;
#endregion
#region Variables
UvVar DISCOUNT_ARRAY = "";
UvVar CODE_POS = "";
UvVar PROMOTION_DISCOUNT = "";
UvVar EACH_REWARD = "";
#endregion
public TEST(ref UvVar[] SUB_REC) {
this.SUB_REC = SUB_REC;
DISCOUNT_ARRAY = INSERT(DISCOUNT_ARRAY, 1, CODE_POS, PROMOTION_DISCOUNT[1, EACH_REWARD]);
}
}
}
