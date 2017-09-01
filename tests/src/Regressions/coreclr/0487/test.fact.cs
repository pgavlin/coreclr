using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _0487_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _0487_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\0487\\test\\test.cmd");
        }
    }
}
