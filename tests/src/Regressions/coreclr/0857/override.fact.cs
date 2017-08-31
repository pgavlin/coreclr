using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0857_override_override_
    {
        [OuterLoop]
        [Fact]
        public void _0857_override_override_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0857\\override\\override.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
