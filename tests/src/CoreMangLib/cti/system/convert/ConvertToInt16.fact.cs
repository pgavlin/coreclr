using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_ConvertToInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_ConvertToInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16\\ConvertToInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
