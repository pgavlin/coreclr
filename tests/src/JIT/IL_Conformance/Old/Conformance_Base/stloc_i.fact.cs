using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_stloc_i_stloc_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_stloc_i_stloc_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\stloc_i\\stloc_i.cmd");
        }
    }
}
