using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_11_ConvertToInt32_11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_11_ConvertToInt32_11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_11\\ConvertToInt32_11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
