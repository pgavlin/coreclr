using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_dup8_dup8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_dup8_dup8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\dup8\\dup8.cmd");
        }
    }
}
