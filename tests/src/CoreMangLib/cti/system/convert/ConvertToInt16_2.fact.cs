using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_2_ConvertToInt16_2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_2_ConvertToInt16_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_2\\ConvertToInt16_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
