using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ret_ret_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ret_ret_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ret\\ret.cmd");
        }
    }
}
