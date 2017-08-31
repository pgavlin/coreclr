using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0828_Test0828_Test0828_
    {
        [OuterLoop]
        [Fact]
        public void _0828_Test0828_Test0828_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0828\\Test0828\\Test0828.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
