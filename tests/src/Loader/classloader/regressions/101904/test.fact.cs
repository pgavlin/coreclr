using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_101904_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_101904_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\101904\\test\\test.cmd");
        }
    }
}
