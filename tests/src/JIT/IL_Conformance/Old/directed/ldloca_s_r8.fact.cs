using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldloca_s_r8_ldloca_s_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_r8_ldloca_s_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_r8\\ldloca_s_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
