using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalCtor4_DecimalCtor4_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalCtor4_DecimalCtor4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalCtor4\\DecimalCtor4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
