using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ceq_i8_ceq_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ceq_i8_ceq_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ceq_i8\\ceq_i8.cmd");
        }
    }
}
