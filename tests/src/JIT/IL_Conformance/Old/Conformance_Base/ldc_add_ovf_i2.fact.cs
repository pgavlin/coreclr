using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_add_ovf_i2_ldc_add_ovf_i2_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_add_ovf_i2_ldc_add_ovf_i2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_add_ovf_i2\\ldc_add_ovf_i2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
