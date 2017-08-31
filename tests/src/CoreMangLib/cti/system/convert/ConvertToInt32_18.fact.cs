using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_18_ConvertToInt32_18_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_18_ConvertToInt32_18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_18\\ConvertToInt32_18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
