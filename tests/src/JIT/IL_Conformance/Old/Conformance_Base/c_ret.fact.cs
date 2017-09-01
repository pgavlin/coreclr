using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_ret_c_ret_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_ret_c_ret_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_ret\\c_ret.cmd");
        }
    }
}
