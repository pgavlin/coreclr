using CoreclrTestLib;
using Xunit;

namespace Regressions_assemblyref
{
    public class _test_test_
    {
        [OuterLoop]
        [Fact]
        public void _test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\assemblyref\\test\\test.cmd");
        }
    }
}
