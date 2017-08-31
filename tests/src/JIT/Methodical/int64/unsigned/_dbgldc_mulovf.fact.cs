using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__dbgldc_mulovf__dbgldc_mulovf_
    {
        [Fact]
        public void _int64_unsigned__dbgldc_mulovf__dbgldc_mulovf_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_dbgldc_mulovf\\_dbgldc_mulovf.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
