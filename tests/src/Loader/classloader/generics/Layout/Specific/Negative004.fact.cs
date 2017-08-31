using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_Specific_Negative004_Negative004_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_Specific_Negative004_Negative004_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\Specific\\Negative004\\Negative004.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
