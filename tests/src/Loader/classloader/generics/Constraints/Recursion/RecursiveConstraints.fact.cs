using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_Recursion_RecursiveConstraints_RecursiveConstraints_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_Recursion_RecursiveConstraints_RecursiveConstraints_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\Recursion\\RecursiveConstraints\\RecursiveConstraints.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
