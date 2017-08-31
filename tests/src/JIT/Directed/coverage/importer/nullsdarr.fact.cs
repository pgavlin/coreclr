using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_nullsdarr_nullsdarr_
    {
        [Fact]
        public void _coverage_importer_nullsdarr_nullsdarr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\nullsdarr\\nullsdarr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
