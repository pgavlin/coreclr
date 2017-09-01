using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ret_i_ret_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ret_i_ret_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ret_i\\ret_i.cmd");
        }
    }
}
