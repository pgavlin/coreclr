using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_General_ManyGenConstraints_ManyGenConstraints_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_General_ManyGenConstraints_ManyGenConstraints_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\General\\ManyGenConstraints\\ManyGenConstraints.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
