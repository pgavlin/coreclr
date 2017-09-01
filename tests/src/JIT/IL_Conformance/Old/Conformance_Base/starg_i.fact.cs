using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_starg_i_starg_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_starg_i_starg_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\starg_i\\starg_i.cmd");
        }
    }
}
