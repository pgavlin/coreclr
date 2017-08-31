using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_add_ovf_i8_ldc_add_ovf_i8_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_add_ovf_i8_ldc_add_ovf_i8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_add_ovf_i8\\ldc_add_ovf_i8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
