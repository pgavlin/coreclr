using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal_ConvertToDecimal_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal_ConvertToDecimal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal\\ConvertToDecimal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
