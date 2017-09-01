using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ret_r8_ret_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ret_r8_ret_r8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ret_r8\\ret_r8.cmd");
        }
    }
}
