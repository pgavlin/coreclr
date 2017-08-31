using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_ldc_mulovf__dbgs_ldc_mulovf_
    {
        [Fact]
        public void _int64_signed__dbgs_ldc_mulovf__dbgs_ldc_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_ldc_mulovf\\_dbgs_ldc_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
