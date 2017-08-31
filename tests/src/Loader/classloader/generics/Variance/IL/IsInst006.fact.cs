using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_IsInst006_IsInst006_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_IsInst006_IsInst006_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\IsInst006\\IsInst006.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
