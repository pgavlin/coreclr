using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6418_ConvertToUInt6418_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6418_ConvertToUInt6418_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6418\\ConvertToUInt6418.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
