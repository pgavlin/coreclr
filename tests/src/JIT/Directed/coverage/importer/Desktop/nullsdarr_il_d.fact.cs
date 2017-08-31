using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_Desktop_nullsdarr_il_d_nullsdarr_il_d_
    {
        [Fact]
        public void _coverage_importer_Desktop_nullsdarr_il_d_nullsdarr_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\Desktop\\nullsdarr_il_d\\nullsdarr_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
