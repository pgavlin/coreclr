using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_sub_ovf_u1_ldc_sub_ovf_u1_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_sub_ovf_u1_ldc_sub_ovf_u1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_sub_ovf_u1\\ldc_sub_ovf_u1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
