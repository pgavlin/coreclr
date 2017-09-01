using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stind_ref_stind_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stind_ref_stind_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stind_ref\\stind_ref.cmd");
        }
    }
}
