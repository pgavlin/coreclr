using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ceq_i_ceq_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ceq_i_ceq_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ceq_i\\ceq_i.cmd");
        }
    }
}
