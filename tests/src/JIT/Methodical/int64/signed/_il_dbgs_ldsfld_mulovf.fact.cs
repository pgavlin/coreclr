using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_signed__il_dbgs_ldsfld_mulovf__il_dbgs_ldsfld_mulovf_
    {
        [Fact]
        public void _int64_signed__il_dbgs_ldsfld_mulovf__il_dbgs_ldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\signed\\_il_dbgs_ldsfld_mulovf\\_il_dbgs_ldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
