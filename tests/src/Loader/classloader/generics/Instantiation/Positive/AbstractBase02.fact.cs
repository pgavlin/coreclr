using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_AbstractBase02_AbstractBase02_
    {
        [Fact]
        public void _generics_Instantiation_Positive_AbstractBase02_AbstractBase02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\AbstractBase02\\AbstractBase02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
