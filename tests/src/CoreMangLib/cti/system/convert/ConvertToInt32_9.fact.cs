using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_9_ConvertToInt32_9_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_9_ConvertToInt32_9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_9\\ConvertToInt32_9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
