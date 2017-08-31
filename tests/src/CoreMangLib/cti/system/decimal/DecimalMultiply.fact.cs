using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_decimal_DecimalMultiply_DecimalMultiply_
    {
        [OuterLoop]
        [Fact]
        public void _system_decimal_DecimalMultiply_DecimalMultiply_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\decimal\\DecimalMultiply\\DecimalMultiply.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
