using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Misc_TestWithManyParams_TestWithManyParams_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Misc_TestWithManyParams_TestWithManyParams_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Misc\\TestWithManyParams\\TestWithManyParams.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
