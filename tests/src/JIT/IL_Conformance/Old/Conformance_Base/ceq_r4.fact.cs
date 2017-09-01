using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ceq_r4_ceq_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ceq_r4_ceq_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ceq_r4\\ceq_r4.cmd");
        }
    }
}
