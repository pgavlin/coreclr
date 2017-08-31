using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt326_ConvertToUInt326_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt326_ConvertToUInt326_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt326\\ConvertToUInt326.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
