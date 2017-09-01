using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_nop_c_nop_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_nop_c_nop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_nop\\c_nop.cmd");
        }
    }
}
