using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_method003_method003_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_method003_method003_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\method003\\method003.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
