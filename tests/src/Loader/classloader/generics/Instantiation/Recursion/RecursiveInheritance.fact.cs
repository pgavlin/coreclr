using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Recursion_RecursiveInheritance_RecursiveInheritance_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Recursion_RecursiveInheritance_RecursiveInheritance_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Recursion\\RecursiveInheritance\\RecursiveInheritance.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
