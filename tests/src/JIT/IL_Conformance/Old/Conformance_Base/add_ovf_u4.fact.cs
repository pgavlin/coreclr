using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_add_ovf_u4_add_ovf_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_add_ovf_u4_add_ovf_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\add_ovf_u4\\add_ovf_u4.cmd");
        }
    }
}
