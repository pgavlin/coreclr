using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_starg_r8_starg_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_starg_r8_starg_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\starg_r8\\starg_r8.cmd");
        }
    }
}
