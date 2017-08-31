using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_volatilstind_volatilstind_
    {
        [Fact]
        public void _coverage_importer_volatilstind_volatilstind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\volatilstind\\volatilstind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
