using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Methods_Method004_Method004_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Methods_Method004_Method004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Methods\\Method004\\Method004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
