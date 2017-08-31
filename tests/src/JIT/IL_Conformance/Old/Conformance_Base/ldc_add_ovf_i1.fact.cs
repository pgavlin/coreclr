using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldc_add_ovf_i1_ldc_add_ovf_i1_
    {
        [Fact]
        public void _Old_Conformance_Base_ldc_add_ovf_i1_ldc_add_ovf_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_add_ovf_i1\\ldc_add_ovf_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
