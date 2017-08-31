using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Delegates_Delegates002_Delegates002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Delegates_Delegates002_Delegates002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Delegates\\Delegates002\\Delegates002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
