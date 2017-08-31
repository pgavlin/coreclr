using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0792_Test0792_Test0792_
    {
        [OuterLoop]
        [Fact]
        public void _0792_Test0792_Test0792_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0792\\Test0792\\Test0792.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
