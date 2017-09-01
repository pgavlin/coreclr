using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldc_c_cpblk_ldc_c_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldc_c_cpblk_ldc_c_cpblk_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldc_c_cpblk\\ldc_c_cpblk.cmd");
        }
    }
}
