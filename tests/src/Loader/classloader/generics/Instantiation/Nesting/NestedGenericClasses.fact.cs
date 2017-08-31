using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Nesting_NestedGenericClasses_NestedGenericClasses_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Nesting_NestedGenericClasses_NestedGenericClasses_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Nesting\\NestedGenericClasses\\NestedGenericClasses.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
