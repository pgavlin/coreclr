using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Variance_IL_InterfaceInheritanceTest2_InterfaceInheritanceTest2_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Variance_IL_InterfaceInheritanceTest2_InterfaceInheritanceTest2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Variance\\IL\\InterfaceInheritanceTest2\\InterfaceInheritanceTest2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
