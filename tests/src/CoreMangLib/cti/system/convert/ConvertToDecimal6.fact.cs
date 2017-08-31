using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal6_ConvertToDecimal6_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal6_ConvertToDecimal6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal6\\ConvertToDecimal6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
