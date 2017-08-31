using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_dbgldsfld_mulovf__il_dbgldsfld_mulovf_
    {
        [Fact]
        public void _int64_unsigned__il_dbgldsfld_mulovf__il_dbgldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_dbgldsfld_mulovf\\_il_dbgldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
