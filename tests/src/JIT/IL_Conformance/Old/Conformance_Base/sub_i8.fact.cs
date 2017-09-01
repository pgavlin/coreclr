using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_i8_sub_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_sub_i8_sub_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_i8\\sub_i8.cmd");
        }
    }
}
