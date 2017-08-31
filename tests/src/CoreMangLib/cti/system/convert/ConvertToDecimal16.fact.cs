using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal16_ConvertToDecimal16_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal16_ConvertToDecimal16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal16\\ConvertToDecimal16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
