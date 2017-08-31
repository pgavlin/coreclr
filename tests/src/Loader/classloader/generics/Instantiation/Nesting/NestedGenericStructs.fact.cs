using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Nesting_NestedGenericStructs_NestedGenericStructs_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Nesting_NestedGenericStructs_NestedGenericStructs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Nesting\\NestedGenericStructs\\NestedGenericStructs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
