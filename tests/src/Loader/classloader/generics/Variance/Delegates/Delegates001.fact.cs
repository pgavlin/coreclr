using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Delegates_Delegates001_Delegates001_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Delegates_Delegates001_Delegates001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Delegates\\Delegates001\\Delegates001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
