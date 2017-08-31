using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedBaseClass03_NestedBaseClass03_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedBaseClass03_NestedBaseClass03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedBaseClass03\\NestedBaseClass03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
