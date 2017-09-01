using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_jmp_jmp_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_jmp_jmp_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\jmp\\jmp.cmd");
        }
    }
}
