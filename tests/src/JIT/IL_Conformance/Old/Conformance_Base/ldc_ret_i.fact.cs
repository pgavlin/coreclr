using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_ret_i_ldc_ret_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_ret_i_ldc_ret_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_ret_i\\ldc_ret_i.cmd");
        }
    }
}
