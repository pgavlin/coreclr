using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_17_ConvertToInt32_17_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_17_ConvertToInt32_17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_17\\ConvertToInt32_17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
