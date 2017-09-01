using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_r4_ldc_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_r4_ldc_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_r4\\ldc_r4.cmd");
        }
    }
}
