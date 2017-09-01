using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_sub_i_ldc_sub_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_sub_i_ldc_sub_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_sub_i\\ldc_sub_i.cmd");
        }
    }
}
