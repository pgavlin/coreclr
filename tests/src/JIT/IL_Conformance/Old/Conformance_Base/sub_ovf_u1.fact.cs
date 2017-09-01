using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_ovf_u1_sub_ovf_u1_
    {
        [Fact]
        public void _Old_Conformance_Base_sub_ovf_u1_sub_ovf_u1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_ovf_u1\\sub_ovf_u1.cmd");
        }
    }
}
