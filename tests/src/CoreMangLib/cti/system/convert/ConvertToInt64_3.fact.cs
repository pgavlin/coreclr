using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_3_ConvertToInt64_3_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_3_ConvertToInt64_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_3\\ConvertToInt64_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
