using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal1_ConvertToDecimal1_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal1_ConvertToDecimal1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal1\\ConvertToDecimal1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
