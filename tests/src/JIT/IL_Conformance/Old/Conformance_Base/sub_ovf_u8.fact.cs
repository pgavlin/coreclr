using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_sub_ovf_u8_sub_ovf_u8_
    {
        [Fact]
        public void _Old_Conformance_Base_sub_ovf_u8_sub_ovf_u8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_ovf_u8\\sub_ovf_u8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
