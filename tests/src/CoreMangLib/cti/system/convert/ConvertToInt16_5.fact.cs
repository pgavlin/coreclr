using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_5_ConvertToInt16_5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_5_ConvertToInt16_5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_5\\ConvertToInt16_5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
