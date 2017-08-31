using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_9_ConvertToInt64_9_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_9_ConvertToInt64_9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_9\\ConvertToInt64_9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
