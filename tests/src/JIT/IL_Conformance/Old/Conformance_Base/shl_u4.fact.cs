using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_shl_u4_shl_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_shl_u4_shl_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\shl_u4\\shl_u4.cmd");
        }
    }
}
