using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ceq_i4_ceq_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ceq_i4_ceq_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ceq_i4\\ceq_i4.cmd");
        }
    }
}
