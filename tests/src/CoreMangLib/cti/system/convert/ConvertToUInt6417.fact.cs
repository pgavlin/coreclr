using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6417_ConvertToUInt6417_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6417_ConvertToUInt6417_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6417\\ConvertToUInt6417.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
