using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_8_ConvertToInt64_8_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_8_ConvertToInt64_8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_8\\ConvertToInt64_8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
