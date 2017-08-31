using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_8_ConvertToInt16_8_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_8_ConvertToInt16_8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_8\\ConvertToInt16_8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
