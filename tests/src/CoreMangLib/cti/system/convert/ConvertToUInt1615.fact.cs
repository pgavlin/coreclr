using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt1615_ConvertToUInt1615_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt1615_ConvertToUInt1615_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt1615\\ConvertToUInt1615.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
