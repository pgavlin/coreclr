using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0044_nullable_nullable_
    {
        [OuterLoop]
        [Fact]
        public void _0044_nullable_nullable_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0044\\nullable\\nullable.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
