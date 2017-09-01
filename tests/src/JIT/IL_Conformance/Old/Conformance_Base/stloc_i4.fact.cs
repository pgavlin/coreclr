using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stloc_i4_stloc_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stloc_i4_stloc_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stloc_i4\\stloc_i4.cmd");
        }
    }
}
