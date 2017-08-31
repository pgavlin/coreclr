using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_IsInst005_IsInst005_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_IsInst005_IsInst005_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\IsInst005\\IsInst005.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
