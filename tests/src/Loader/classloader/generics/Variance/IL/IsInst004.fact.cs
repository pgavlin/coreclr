using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_IsInst004_IsInst004_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_IsInst004_IsInst004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\IsInst004\\IsInst004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
