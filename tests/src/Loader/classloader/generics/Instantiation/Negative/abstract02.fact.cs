using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Negative_abstract02_abstract02_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Negative_abstract02_abstract02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Negative\\abstract02\\abstract02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
