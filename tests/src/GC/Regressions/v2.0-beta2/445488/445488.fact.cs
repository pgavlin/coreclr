using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta2_445488_445488_445488_
    {
        [Fact]
        public void _v2_0_beta2_445488_445488_445488_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta2\\445488\\445488\\445488.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
