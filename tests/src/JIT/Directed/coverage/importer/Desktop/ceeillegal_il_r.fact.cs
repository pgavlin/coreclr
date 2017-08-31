using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_ceeillegal_il_r_ceeillegal_il_r_
    {
        [Fact]
        public void _coverage_importer_Desktop_ceeillegal_il_r_ceeillegal_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\ceeillegal_il_r\\ceeillegal_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
