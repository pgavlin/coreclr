using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt64_11_ConvertToInt64_11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt64_11_ConvertToInt64_11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt64_11\\ConvertToInt64_11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
