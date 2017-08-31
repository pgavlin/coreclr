using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_7_ConvertToInt16_7_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_7_ConvertToInt16_7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_7\\ConvertToInt16_7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
