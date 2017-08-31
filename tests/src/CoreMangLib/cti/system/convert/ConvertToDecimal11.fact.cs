using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal11_ConvertToDecimal11_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal11_ConvertToDecimal11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal11\\ConvertToDecimal11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
