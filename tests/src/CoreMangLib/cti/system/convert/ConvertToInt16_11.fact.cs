using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToInt16_11_ConvertToInt16_11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToInt16_11_ConvertToInt16_11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToInt16_11\\ConvertToInt16_11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
