using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Negative_abstract03_abstract03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Negative_abstract03_abstract03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Negative\\abstract03\\abstract03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
