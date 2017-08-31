using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Misc_ConstraintsAndInheritance_ConstraintsAndInheritance_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Misc_ConstraintsAndInheritance_ConstraintsAndInheritance_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Misc\\ConstraintsAndInheritance\\ConstraintsAndInheritance.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
