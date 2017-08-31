using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Layout_Specific_Negative_ExplicitGen_Negative_ExplicitGen_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Layout_Specific_Negative_ExplicitGen_Negative_ExplicitGen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Layout\\Specific\\Negative_ExplicitGen\\Negative_ExplicitGen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
