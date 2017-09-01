using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ret_i8_ret_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ret_i8_ret_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ret_i8\\ret_i8.cmd");
        }
    }
}
