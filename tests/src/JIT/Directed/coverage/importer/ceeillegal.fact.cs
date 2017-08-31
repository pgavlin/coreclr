using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_ceeillegal_ceeillegal_
    {
        [Fact]
        public void _coverage_importer_ceeillegal_ceeillegal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\ceeillegal\\ceeillegal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
