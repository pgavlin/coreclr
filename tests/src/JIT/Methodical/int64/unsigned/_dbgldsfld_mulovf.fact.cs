using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__dbgldsfld_mulovf__dbgldsfld_mulovf_
    {
        [Fact]
        public void _int64_unsigned__dbgldsfld_mulovf__dbgldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_dbgldsfld_mulovf\\_dbgldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
