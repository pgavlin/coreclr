using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_VSW491668_VSW491668_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_VSW491668_VSW491668_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\VSW491668\\VSW491668.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
