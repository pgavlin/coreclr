using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_AbstractBase07_AbstractBase07_
    {
        [Fact]
        public void _generics_Instantiation_Positive_AbstractBase07_AbstractBase07_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\AbstractBase07\\AbstractBase07.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
