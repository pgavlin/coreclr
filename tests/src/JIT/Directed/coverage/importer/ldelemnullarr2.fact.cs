using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_ldelemnullarr2_ldelemnullarr2_
    {
        [Fact]
        public void _coverage_importer_ldelemnullarr2_ldelemnullarr2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\ldelemnullarr2\\ldelemnullarr2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
