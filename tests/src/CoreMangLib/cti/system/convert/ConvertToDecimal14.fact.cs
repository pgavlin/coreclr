using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal14_ConvertToDecimal14_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal14_ConvertToDecimal14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal14\\ConvertToDecimal14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
