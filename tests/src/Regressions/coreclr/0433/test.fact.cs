using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0433_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _0433_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0433\\test\\test.cmd");
        }
    }
}
