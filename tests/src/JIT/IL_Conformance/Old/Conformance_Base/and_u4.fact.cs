using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_and_u4_and_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_and_u4_and_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\and_u4\\and_u4.cmd");
        }
    }
}
