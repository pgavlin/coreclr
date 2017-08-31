using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt168_ConvertToUInt168_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt168_ConvertToUInt168_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt168\\ConvertToUInt168.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
