using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_starg_i4_starg_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_starg_i4_starg_i4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\starg_i4\\starg_i4.cmd");
        }
    }
}
