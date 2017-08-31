using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedStruct02_NestedStruct02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_NestedStruct02_NestedStruct02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedStruct02\\NestedStruct02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
