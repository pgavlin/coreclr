using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_mul_ovf_mul_ovf_
    {
        [Fact]
        public void _Old_Base_mul_ovf_mul_ovf_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\mul_ovf\\mul_ovf.cmd");
        }
    }
}
