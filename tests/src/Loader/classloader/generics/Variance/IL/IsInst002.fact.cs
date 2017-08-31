using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_IsInst002_IsInst002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_IsInst002_IsInst002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\IsInst002\\IsInst002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
