using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_NestedInterface02_NestedInterface02_
    {
        [Fact]
        public void _generics_Instantiation_Positive_NestedInterface02_NestedInterface02_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\NestedInterface02\\NestedInterface02.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
