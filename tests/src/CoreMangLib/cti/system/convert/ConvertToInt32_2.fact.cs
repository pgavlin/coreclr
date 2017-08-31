using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_2_ConvertToInt32_2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_2_ConvertToInt32_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_2\\ConvertToInt32_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
