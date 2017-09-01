using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_starg_ref_starg_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_starg_ref_starg_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\starg_ref\\starg_ref.cmd");
        }
    }
}
