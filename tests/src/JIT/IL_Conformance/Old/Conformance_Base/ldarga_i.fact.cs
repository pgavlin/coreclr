using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldarga_i_ldarga_i_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_i_ldarga_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_i\\ldarga_i.cmd");
        }
    }
}
