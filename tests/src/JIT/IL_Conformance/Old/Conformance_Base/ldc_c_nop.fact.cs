using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_c_nop_ldc_c_nop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_c_nop_ldc_c_nop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_c_nop\\ldc_c_nop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
