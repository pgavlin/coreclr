using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_MultipleInterface01_MultipleInterface01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_MultipleInterface01_MultipleInterface01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\MultipleInterface01\\MultipleInterface01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
