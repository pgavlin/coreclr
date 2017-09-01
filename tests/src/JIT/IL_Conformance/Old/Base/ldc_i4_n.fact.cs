using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldc_i4_n_ldc_i4_n_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldc_i4_n_ldc_i4_n_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldc_i4_n\\ldc_i4_n.cmd");
        }
    }
}
