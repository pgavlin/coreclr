using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedBaseClass01_NestedBaseClass01_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedBaseClass01_NestedBaseClass01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedBaseClass01\\NestedBaseClass01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
