using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedBaseClass05_NestedBaseClass05_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedBaseClass05_NestedBaseClass05_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedBaseClass05\\NestedBaseClass05.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
