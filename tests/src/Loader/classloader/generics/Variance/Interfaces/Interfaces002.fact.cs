using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_Interfaces_Interfaces002_Interfaces002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_Interfaces_Interfaces002_Interfaces002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\Interfaces\\Interfaces002\\Interfaces002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
