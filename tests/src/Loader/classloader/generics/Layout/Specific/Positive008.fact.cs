using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_Specific_Positive008_Positive008_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_Specific_Positive008_Positive008_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\Specific\\Positive008\\Positive008.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
