using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldloc_s_r4_ldloc_s_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_r4_ldloc_s_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_r4\\ldloc_s_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
