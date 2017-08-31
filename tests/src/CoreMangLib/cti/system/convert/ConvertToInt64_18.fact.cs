using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_18_ConvertToInt64_18_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_18_ConvertToInt64_18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_18\\ConvertToInt64_18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
