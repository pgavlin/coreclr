using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_relldfld_mulovf__il_relldfld_mulovf_
    {
        [Fact]
        public void _int64_unsigned__il_relldfld_mulovf__il_relldfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_relldfld_mulovf\\_il_relldfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
