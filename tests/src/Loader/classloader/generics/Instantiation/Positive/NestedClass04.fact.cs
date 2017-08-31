using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedClass04_NestedClass04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_NestedClass04_NestedClass04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedClass04\\NestedClass04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
