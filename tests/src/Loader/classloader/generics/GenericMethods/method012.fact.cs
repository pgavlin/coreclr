using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_method012_method012_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_method012_method012_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\method012\\method012.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
