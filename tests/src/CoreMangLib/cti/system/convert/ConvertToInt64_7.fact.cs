using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_7_ConvertToInt64_7_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_7_ConvertToInt64_7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_7\\ConvertToInt64_7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
