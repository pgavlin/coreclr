using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_mul_mul_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_mul_mul_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\mul\\mul.cmd");
        }
    }
}
