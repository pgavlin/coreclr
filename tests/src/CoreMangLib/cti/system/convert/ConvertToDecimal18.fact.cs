using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal18_ConvertToDecimal18_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal18_ConvertToDecimal18_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal18\\ConvertToDecimal18.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
