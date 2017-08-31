using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal9_ConvertToDecimal9_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal9_ConvertToDecimal9_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal9\\ConvertToDecimal9.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
