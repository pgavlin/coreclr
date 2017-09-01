using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_i8_ldc_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_i8_ldc_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_i8\\ldc_i8.cmd");
        }
    }
}
