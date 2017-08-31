using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal15_ConvertToDecimal15_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal15_ConvertToDecimal15_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal15\\ConvertToDecimal15.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
