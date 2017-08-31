using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_method004_method004_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_method004_method004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\method004\\method004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
