using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalCtor7_DecimalCtor7_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalCtor7_DecimalCtor7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalCtor7\\DecimalCtor7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
