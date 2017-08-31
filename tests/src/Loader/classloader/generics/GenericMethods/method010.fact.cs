using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_GenericMethods_method010_method010_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericMethods_method010_method010_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\GenericMethods\\method010\\method010.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
