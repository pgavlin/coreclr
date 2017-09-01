using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_Conv_I8_Conv_I8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_Conv_I8_Conv_I8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\Conv_I8\\Conv_I8.cmd");
        }
    }
}
