using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt646_ConvertToUInt646_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt646_ConvertToUInt646_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt646\\ConvertToUInt646.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
