using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stloc_r4_stloc_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stloc_r4_stloc_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stloc_r4\\stloc_r4.cmd");
        }
    }
}
