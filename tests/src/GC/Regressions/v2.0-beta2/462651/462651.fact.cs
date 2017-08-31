using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta2_462651_462651_462651_
    {
        [OuterLoop]
        [Fact]
        public void _v2_0_beta2_462651_462651_462651_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta2\\462651\\462651\\462651.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
