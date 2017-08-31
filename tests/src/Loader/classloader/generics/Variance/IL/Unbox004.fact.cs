using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_Unbox004_Unbox004_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_Unbox004_Unbox004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\Unbox004\\Unbox004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
