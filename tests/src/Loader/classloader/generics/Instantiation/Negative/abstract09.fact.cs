using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Negative_abstract09_abstract09_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Negative_abstract09_abstract09_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Negative\\abstract09\\abstract09.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
