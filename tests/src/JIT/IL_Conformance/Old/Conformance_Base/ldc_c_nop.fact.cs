using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_c_nop_ldc_c_nop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_c_nop_ldc_c_nop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_c_nop\\ldc_c_nop.cmd");
        }
    }
}
