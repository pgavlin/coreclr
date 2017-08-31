using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta2_471729_471729_471729_
    {
        [OuterLoop]
        [Fact]
        public void _v2_0_beta2_471729_471729_471729_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta2\\471729\\471729\\471729.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
