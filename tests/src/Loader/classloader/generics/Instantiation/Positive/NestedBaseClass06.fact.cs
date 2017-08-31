using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedBaseClass06_NestedBaseClass06_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedBaseClass06_NestedBaseClass06_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedBaseClass06\\NestedBaseClass06.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
