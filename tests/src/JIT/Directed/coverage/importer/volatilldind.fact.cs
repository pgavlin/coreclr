using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_volatilldind_volatilldind_
    {
        [Fact]
        public void _coverage_importer_volatilldind_volatilldind_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\volatilldind\\volatilldind.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
