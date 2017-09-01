using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_i1_stind_i1_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_i1_stind_i1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_i1\\stind_i1.cmd");
        }
    }
}
