using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ldc_ldc_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldc_ldc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldc\\ldc.cmd");
        }
    }
}
