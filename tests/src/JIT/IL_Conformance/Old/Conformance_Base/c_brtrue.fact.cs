using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_c_brtrue_c_brtrue_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_c_brtrue_c_brtrue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\c_brtrue\\c_brtrue.cmd");
        }
    }
}
