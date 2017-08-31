using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__speed_relldsfld_mulovf__speed_relldsfld_mulovf_
    {
        [Fact]
        public void _int64_unsigned__speed_relldsfld_mulovf__speed_relldsfld_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_speed_relldsfld_mulovf\\_speed_relldsfld_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
