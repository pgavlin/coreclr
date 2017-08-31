using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta2_452950_452950_452950_
    {
        [Fact]
        public void _v2_0_beta2_452950_452950_452950_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta2\\452950\\452950\\452950.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
