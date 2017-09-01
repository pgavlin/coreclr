using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_i8_stind_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_i8_stind_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_i8\\stind_i8.cmd");
        }
    }
}
