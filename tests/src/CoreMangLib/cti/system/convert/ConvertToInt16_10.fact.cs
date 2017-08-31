using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_10_ConvertToInt16_10_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_10_ConvertToInt16_10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_10\\ConvertToInt16_10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
