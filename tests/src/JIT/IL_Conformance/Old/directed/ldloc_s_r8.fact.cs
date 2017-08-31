using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldloc_s_r8_ldloc_s_r8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_r8_ldloc_s_r8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_r8\\ldloc_s_r8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
