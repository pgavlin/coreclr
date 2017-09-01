using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stloc_ref_stloc_ref_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stloc_ref_stloc_ref_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stloc_ref\\stloc_ref.cmd");
        }
    }
}
