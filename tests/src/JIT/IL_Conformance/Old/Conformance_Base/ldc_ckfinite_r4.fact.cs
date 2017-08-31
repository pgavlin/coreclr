using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_ckfinite_r4_ldc_ckfinite_r4_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_ckfinite_r4_ldc_ckfinite_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_ckfinite_r4\\ldc_ckfinite_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
