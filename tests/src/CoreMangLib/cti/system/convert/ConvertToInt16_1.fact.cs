using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_1_ConvertToInt16_1_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_1_ConvertToInt16_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_1\\ConvertToInt16_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
