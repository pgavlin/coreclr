using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Methods_Method002_Method002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Methods_Method002_Method002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Methods\\Method002\\Method002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
