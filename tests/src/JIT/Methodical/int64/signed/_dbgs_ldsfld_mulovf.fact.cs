using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__dbgs_ldsfld_mulovf__dbgs_ldsfld_mulovf_
    {
        [Fact]
        public void _int64_signed__dbgs_ldsfld_mulovf__dbgs_ldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_dbgs_ldsfld_mulovf\\_dbgs_ldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
