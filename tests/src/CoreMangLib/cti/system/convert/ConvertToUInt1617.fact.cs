using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1617_ConvertToUInt1617_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1617_ConvertToUInt1617_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1617\\ConvertToUInt1617.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
