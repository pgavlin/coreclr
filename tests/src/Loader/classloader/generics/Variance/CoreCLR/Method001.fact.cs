using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_CoreCLR_Method001_Method001_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_CoreCLR_Method001_Method001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\CoreCLR\\Method001\\Method001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
