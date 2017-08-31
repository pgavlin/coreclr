using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    class _interlock_interlock_
    {
        [OuterLoop]
        [Fact]
        public void _interlock_interlock_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\common\\interlock\\interlock.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
