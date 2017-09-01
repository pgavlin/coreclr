using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_vsw305955_GenericAssertin_GenericAssertin_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw305955_GenericAssertin_GenericAssertin_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw305955\\GenericAssertin\\GenericAssertin.cmd");
        }
    }
}
