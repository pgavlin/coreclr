using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedInterface08_NestedInterface08_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedInterface08_NestedInterface08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedInterface08\\NestedInterface08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
