using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_ldfld_mulovf__dbgs_ldfld_mulovf_
    {
        [Fact]
        public void _int64_signed__dbgs_ldfld_mulovf__dbgs_ldfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_ldfld_mulovf\\_dbgs_ldfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
