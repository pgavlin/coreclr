using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal17_ConvertToDecimal17_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal17_ConvertToDecimal17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal17\\ConvertToDecimal17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
