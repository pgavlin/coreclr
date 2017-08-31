using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_6_ConvertToInt64_6_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_6_ConvertToInt64_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_6\\ConvertToInt64_6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
