using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_ldarga_r8_ldarga_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ldarga_r8_ldarga_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ldarga_r8\\ldarga_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
