using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _Statics_Misc_LiteralStatic_LiteralStatic_
    {
        [Fact]
        public void _Statics_Misc_LiteralStatic_LiteralStatic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\Statics\\Misc\\LiteralStatic\\LiteralStatic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
