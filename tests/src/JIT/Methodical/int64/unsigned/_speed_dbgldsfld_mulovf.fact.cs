using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_dbgldsfld_mulovf__speed_dbgldsfld_mulovf_
    {
        [Fact]
        public void _int64_unsigned__speed_dbgldsfld_mulovf__speed_dbgldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_dbgldsfld_mulovf\\_speed_dbgldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
