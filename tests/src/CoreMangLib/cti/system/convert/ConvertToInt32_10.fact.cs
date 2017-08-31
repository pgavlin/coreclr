using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_10_ConvertToInt32_10_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_10_ConvertToInt32_10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_10\\ConvertToInt32_10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
