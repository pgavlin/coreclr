using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_MultipleInterface08_MultipleInterface08_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_MultipleInterface08_MultipleInterface08_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\MultipleInterface08\\MultipleInterface08.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
