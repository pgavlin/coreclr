using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_9_ConvertToInt16_9_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_9_ConvertToInt16_9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_9\\ConvertToInt16_9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
