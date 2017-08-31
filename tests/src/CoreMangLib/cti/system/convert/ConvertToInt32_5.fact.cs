using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt32_5_ConvertToInt32_5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt32_5_ConvertToInt32_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt32_5\\ConvertToInt32_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
