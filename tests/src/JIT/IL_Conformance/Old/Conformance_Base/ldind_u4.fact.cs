using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldind_u4_ldind_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldind_u4_ldind_u4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldind_u4\\ldind_u4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
