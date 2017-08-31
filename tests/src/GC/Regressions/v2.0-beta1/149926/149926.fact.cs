using CoreclrTestLib;
using Xunit;

namespace GC_Regressions
{
    class _v2_0_beta1_149926_149926_149926_
    {
        [Fact]
        public void _v2_0_beta1_149926_149926_149926_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Regressions\\v2.0-beta1\\149926\\149926\\149926.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
