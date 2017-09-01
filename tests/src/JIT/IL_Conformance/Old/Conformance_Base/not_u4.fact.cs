using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_not_u4_not_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_not_u4_not_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\not_u4\\not_u4.cmd");
        }
    }
}
