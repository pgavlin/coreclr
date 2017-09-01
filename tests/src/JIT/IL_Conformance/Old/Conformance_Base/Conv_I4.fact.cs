using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_Conv_I4_Conv_I4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_Conv_I4_Conv_I4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\Conv_I4\\Conv_I4.cmd");
        }
    }
}
