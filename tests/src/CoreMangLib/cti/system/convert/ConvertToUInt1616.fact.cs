using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1616_ConvertToUInt1616_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1616_ConvertToUInt1616_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1616\\ConvertToUInt1616.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
