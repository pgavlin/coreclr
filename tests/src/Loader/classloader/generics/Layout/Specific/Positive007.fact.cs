using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_Specific_Positive007_Positive007_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_Specific_Positive007_Positive007_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\Specific\\Positive007\\Positive007.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
