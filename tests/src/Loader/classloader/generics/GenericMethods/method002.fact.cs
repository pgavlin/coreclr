using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_method002_method002_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_method002_method002_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\method002\\method002.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
