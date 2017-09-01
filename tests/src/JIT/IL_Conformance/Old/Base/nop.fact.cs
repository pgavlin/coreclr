using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_nop_nop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_nop_nop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\nop\\nop.cmd");
        }
    }
}
