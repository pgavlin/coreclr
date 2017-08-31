using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__speed_dbgs_ldfld_mulovf__speed_dbgs_ldfld_mulovf_
    {
        [Fact]
        public void _int64_signed__speed_dbgs_ldfld_mulovf__speed_dbgs_ldfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_speed_dbgs_ldfld_mulovf\\_speed_dbgs_ldfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
