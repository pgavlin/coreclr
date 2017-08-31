using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_Specific_Positive009_Positive009_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_Specific_Positive009_Positive009_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\Specific\\Positive009\\Positive009.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
