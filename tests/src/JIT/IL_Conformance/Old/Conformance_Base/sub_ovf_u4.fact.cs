using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_sub_ovf_u4_sub_ovf_u4_
    {
        [Fact]
        public void _Old_Conformance_Base_sub_ovf_u4_sub_ovf_u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\sub_ovf_u4\\sub_ovf_u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
