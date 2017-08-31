using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_vsw305955_GenericAssertin_GenericAssertin_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_vsw305955_GenericAssertin_GenericAssertin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\vsw305955\\GenericAssertin\\GenericAssertin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
