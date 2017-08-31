using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Nesting_NestedGenericTypesMix_NestedGenericTypesMix_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Nesting_NestedGenericTypesMix_NestedGenericTypesMix_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Nesting\\NestedGenericTypesMix\\NestedGenericTypesMix.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
