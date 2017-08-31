using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1618_ConvertToUInt1618_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1618_ConvertToUInt1618_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1618\\ConvertToUInt1618.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
