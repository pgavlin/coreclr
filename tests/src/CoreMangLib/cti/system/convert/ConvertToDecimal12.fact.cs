using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal12_ConvertToDecimal12_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal12_ConvertToDecimal12_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal12\\ConvertToDecimal12.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
