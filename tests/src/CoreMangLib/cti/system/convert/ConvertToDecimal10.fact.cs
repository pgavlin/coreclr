using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal10_ConvertToDecimal10_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal10_ConvertToDecimal10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal10\\ConvertToDecimal10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
