using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_ConvertToInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_ConvertToInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32\\ConvertToInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
