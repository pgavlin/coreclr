using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal13_ConvertToDecimal13_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal13_ConvertToDecimal13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal13\\ConvertToDecimal13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
