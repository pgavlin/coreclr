using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1610_ConvertToUInt1610_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1610_ConvertToUInt1610_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1610\\ConvertToUInt1610.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
