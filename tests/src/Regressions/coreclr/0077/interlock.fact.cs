using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _0077_interlock_interlock_
    {
        [OuterLoop]
        [Fact]
        public void _0077_interlock_interlock_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\0077\\interlock\\interlock.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
