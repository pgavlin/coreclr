using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_sub_ovf_i2_sub_ovf_i2_
    {
        [Fact]
        public void _Old_Conformance_Base_sub_ovf_i2_sub_ovf_i2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_ovf_i2\\sub_ovf_i2.cmd");
        }
    }
}
