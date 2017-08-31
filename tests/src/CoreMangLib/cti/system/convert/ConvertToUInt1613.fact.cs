using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1613_ConvertToUInt1613_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1613_ConvertToUInt1613_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1613\\ConvertToUInt1613.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
