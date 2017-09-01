using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _interlock_interlock_
    {
        [OuterLoop]
        [Fact]
        public void _interlock_interlock_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\interlock\\interlock.cmd");
        }
    }
}
