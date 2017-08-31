using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Positive_MultipleInterface10_MultipleInterface10_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Positive_MultipleInterface10_MultipleInterface10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Positive\\MultipleInterface10\\MultipleInterface10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
