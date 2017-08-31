using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalCtor3_DecimalCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalCtor3_DecimalCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalCtor3\\DecimalCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
