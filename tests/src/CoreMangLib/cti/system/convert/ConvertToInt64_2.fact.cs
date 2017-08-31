using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_2_ConvertToInt64_2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_2_ConvertToInt64_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_2\\ConvertToInt64_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
