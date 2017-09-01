using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_starg_i8_starg_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_starg_i8_starg_i8_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\starg_i8\\starg_i8.cmd");
        }
    }
}
