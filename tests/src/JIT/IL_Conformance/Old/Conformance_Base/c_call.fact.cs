using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_call_c_call_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_call_c_call_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_call\\c_call.cmd");
        }
    }
}
