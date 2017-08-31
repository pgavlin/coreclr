using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_rtm_494226_494226_494226_
    {
        [Fact]
        public void _v2_0_rtm_494226_494226_494226_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-rtm\\494226\\494226\\494226.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
