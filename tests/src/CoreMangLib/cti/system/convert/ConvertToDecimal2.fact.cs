using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal2_ConvertToDecimal2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal2_ConvertToDecimal2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal2\\ConvertToDecimal2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
