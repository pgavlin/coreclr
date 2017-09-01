using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_regressions_109968_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_109968_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\109968\\test\\test.cmd");
        }
    }
}
