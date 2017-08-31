using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt162_ConvertToUInt162_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt162_ConvertToUInt162_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt162\\ConvertToUInt162.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
