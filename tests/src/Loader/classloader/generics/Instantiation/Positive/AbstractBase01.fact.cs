using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_AbstractBase01_AbstractBase01_
    {
        [Fact]
        public void _generics_Instantiation_Positive_AbstractBase01_AbstractBase01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\AbstractBase01\\AbstractBase01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
