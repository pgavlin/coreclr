using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Regressions_607_DevDiv607_DevDiv607_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Regressions_607_DevDiv607_DevDiv607_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Regressions\\607\\DevDiv607\\DevDiv607.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
