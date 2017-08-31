using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_CoreCLR_Method003_Method003_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_CoreCLR_Method003_Method003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\CoreCLR\\Method003\\Method003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
