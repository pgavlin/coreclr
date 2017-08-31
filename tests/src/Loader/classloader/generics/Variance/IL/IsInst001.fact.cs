using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_IsInst001_IsInst001_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_IsInst001_IsInst001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\IsInst001\\IsInst001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
