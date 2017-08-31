using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_sub_ovf_u4_ldc_sub_ovf_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_sub_ovf_u4_ldc_sub_ovf_u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_sub_ovf_u4\\ldc_sub_ovf_u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
