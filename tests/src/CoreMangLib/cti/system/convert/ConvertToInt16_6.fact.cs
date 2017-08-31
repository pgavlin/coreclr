using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_6_ConvertToInt16_6_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_6_ConvertToInt16_6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_6\\ConvertToInt16_6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
