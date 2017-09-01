using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ldind_i_ldind_i_
    {
        [Fact]
        public void _Old_Conformance_Base_ldind_i_ldind_i_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_i\\ldind_i.cmd");
        }
    }
}
