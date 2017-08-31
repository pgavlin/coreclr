using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_rtm_544701_544701_544701_
    {
        [OuterLoop]
        [Fact]
        public void _v2_0_rtm_544701_544701_544701_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-rtm\\544701\\544701\\544701.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
