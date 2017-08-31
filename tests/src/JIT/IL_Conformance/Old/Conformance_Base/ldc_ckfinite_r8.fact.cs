using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_ckfinite_r8_ldc_ckfinite_r8_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_ckfinite_r8_ldc_ckfinite_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_ckfinite_r8\\ldc_ckfinite_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
