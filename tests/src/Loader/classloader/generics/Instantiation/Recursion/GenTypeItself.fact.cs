using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Recursion_GenTypeItself_GenTypeItself_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Recursion_GenTypeItself_GenTypeItself_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Recursion\\GenTypeItself\\GenTypeItself.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
