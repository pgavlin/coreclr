using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_MultipleInterface11_MultipleInterface11_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_MultipleInterface11_MultipleInterface11_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\MultipleInterface11\\MultipleInterface11.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
