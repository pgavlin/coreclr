using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1614_ConvertToUInt1614_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1614_ConvertToUInt1614_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1614\\ConvertToUInt1614.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
