using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ret_i4_ret_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ret_i4_ret_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ret_i4\\ret_i4.cmd");
        }
    }
}
