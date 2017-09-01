using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_i4_sub_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_sub_i4_sub_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_i4\\sub_i4.cmd");
        }
    }
}
