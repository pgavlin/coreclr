using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedStruct04_NestedStruct04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_NestedStruct04_NestedStruct04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedStruct04\\NestedStruct04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
