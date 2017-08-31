using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_neg_i4_ldc_neg_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_neg_i4_ldc_neg_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_neg_i4\\ldc_neg_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
