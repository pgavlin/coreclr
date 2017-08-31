using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_8_ConvertToInt32_8_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_8_ConvertToInt32_8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_8\\ConvertToInt32_8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
