using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Interfaces_Interfaces001_Interfaces001_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Interfaces_Interfaces001_Interfaces001_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Interfaces\\Interfaces001\\Interfaces001.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
