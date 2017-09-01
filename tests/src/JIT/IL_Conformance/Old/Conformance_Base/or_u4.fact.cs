using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_or_u4_or_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_or_u4_or_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\or_u4\\or_u4.cmd");
        }
    }
}
