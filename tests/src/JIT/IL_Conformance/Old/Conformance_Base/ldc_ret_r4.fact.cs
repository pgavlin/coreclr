using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_ret_r4_ldc_ret_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_ret_r4_ldc_ret_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_ret_r4\\ldc_ret_r4.cmd");
        }
    }
}
