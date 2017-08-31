using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1611_ConvertToUInt1611_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1611_ConvertToUInt1611_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1611\\ConvertToUInt1611.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
