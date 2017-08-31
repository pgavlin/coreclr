using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_1_ConvertToInt32_1_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_1_ConvertToInt32_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_1\\ConvertToInt32_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
