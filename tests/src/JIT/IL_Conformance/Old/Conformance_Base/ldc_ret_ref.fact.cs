using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_ret_ref_ldc_ret_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_ret_ref_ldc_ret_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_ret_ref\\ldc_ret_ref.cmd");
        }
    }
}
