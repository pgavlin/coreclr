using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalCtor5_DecimalCtor5_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalCtor5_DecimalCtor5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalCtor5\\DecimalCtor5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
