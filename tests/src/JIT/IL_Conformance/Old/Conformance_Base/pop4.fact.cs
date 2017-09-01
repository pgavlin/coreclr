using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_pop4_pop4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_pop4_pop4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\pop4\\pop4.cmd");
        }
    }
}
