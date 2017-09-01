using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0857_override_override_
    {
        [OuterLoop]
        [Fact]
        public void _0857_override_override_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0857\\override\\override.cmd");
        }
    }
}
