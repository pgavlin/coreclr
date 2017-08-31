using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt3211_ConvertToUInt3211_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt3211_ConvertToUInt3211_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt3211\\ConvertToUInt3211.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
