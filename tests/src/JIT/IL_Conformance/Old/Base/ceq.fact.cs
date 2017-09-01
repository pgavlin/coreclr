using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ceq_ceq_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ceq_ceq_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ceq\\ceq.cmd");
        }
    }
}
