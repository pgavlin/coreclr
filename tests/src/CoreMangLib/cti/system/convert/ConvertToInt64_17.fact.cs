using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_17_ConvertToInt64_17_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_17_ConvertToInt64_17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_17\\ConvertToInt64_17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
