using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDecimal5_ConvertToDecimal5_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDecimal5_ConvertToDecimal5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDecimal5\\ConvertToDecimal5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
