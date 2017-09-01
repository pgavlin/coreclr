using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0044_nullable_nullable_
    {
        [OuterLoop]
        [Fact]
        public void _0044_nullable_nullable_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0044\\nullable\\nullable.cmd");
        }
    }
}
