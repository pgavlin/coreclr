using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_i4_ldc_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_i4_ldc_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_i4\\ldc_i4.cmd");
        }
    }
}
