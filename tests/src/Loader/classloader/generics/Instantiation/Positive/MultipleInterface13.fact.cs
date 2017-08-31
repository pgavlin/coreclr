using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_MultipleInterface13_MultipleInterface13_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_MultipleInterface13_MultipleInterface13_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\MultipleInterface13\\MultipleInterface13.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
