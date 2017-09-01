using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_decimal_DecimalToInt32_DecimalToInt32_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalToInt32_DecimalToInt32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalToInt32\\DecimalToInt32.cmd");
        }
    }
}
