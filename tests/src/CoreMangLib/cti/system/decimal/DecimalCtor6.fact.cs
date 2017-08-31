using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalCtor6_DecimalCtor6_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalCtor6_DecimalCtor6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalCtor6\\DecimalCtor6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
