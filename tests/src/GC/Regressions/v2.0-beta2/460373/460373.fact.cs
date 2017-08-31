using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta2_460373_460373_460373_
    {
        [Fact]
        public void _v2_0_beta2_460373_460373_460373_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta2\\460373\\460373\\460373.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
