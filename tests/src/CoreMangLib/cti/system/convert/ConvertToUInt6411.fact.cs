using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6411_ConvertToUInt6411_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6411_ConvertToUInt6411_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6411\\ConvertToUInt6411.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
