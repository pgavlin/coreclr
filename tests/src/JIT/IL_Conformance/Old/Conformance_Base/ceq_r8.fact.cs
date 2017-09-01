using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ceq_r8_ceq_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ceq_r8_ceq_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ceq_r8\\ceq_r8.cmd");
        }
    }
}
