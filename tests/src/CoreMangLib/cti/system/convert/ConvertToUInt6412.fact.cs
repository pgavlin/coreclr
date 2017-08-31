using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6412_ConvertToUInt6412_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6412_ConvertToUInt6412_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6412\\ConvertToUInt6412.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
