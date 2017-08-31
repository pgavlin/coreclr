using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt327_ConvertToUInt327_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt327_ConvertToUInt327_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt327\\ConvertToUInt327.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
