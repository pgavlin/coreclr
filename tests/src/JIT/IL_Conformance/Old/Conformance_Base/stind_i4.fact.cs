using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_i4_stind_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_i4_stind_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_i4\\stind_i4.cmd");
        }
    }
}
