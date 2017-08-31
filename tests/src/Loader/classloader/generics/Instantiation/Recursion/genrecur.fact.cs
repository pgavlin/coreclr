using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Recursion_genrecur_genrecur_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Recursion_genrecur_genrecur_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Recursion\\genrecur\\genrecur.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
