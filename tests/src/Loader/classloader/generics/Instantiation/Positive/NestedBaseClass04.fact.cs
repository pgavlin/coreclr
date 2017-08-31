using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedBaseClass04_NestedBaseClass04_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedBaseClass04_NestedBaseClass04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedBaseClass04\\NestedBaseClass04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
