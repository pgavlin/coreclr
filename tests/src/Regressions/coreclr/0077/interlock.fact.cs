using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0077_interlock_interlock_
    {
        [OuterLoop]
        [Fact]
        public void _0077_interlock_interlock_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0077\\interlock\\interlock.cmd");
        }
    }
}
