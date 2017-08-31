using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedInterface07_NestedInterface07_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedInterface07_NestedInterface07_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedInterface07\\NestedInterface07.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
