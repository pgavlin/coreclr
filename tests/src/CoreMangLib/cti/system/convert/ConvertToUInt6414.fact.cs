using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt6414_ConvertToUInt6414_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt6414_ConvertToUInt6414_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt6414\\ConvertToUInt6414.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
