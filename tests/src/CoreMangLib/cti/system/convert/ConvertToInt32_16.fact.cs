using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_16_ConvertToInt32_16_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_16_ConvertToInt32_16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_16\\ConvertToInt32_16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
