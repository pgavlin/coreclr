using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_AbstractBase06_AbstractBase06_
    {
        [Fact]
        public void _generics_Instantiation_Positive_AbstractBase06_AbstractBase06_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\AbstractBase06\\AbstractBase06.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
