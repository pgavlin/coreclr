using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ret_r4_ret_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ret_r4_ret_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ret_r4\\ret_r4.cmd");
        }
    }
}
