using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_Unbox002_Unbox002_
    {
        [Fact]
        public void _generics_Variance_IL_Unbox002_Unbox002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\Unbox002\\Unbox002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
