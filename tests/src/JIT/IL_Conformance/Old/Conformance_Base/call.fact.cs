using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_call_call_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_call_call_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\call\\call.cmd");
        }
    }
}
