using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_17_ConvertToInt16_17_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_17_ConvertToInt16_17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_17\\ConvertToInt16_17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
