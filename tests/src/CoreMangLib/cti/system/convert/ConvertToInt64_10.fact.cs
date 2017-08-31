using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_10_ConvertToInt64_10_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_10_ConvertToInt64_10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_10\\ConvertToInt64_10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
