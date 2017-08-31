using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_16_ConvertToInt64_16_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_16_ConvertToInt64_16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_16\\ConvertToInt64_16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
