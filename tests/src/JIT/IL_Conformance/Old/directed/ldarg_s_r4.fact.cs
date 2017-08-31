using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldarg_s_r4_ldarg_s_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldarg_s_r4_ldarg_s_r4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldarg_s_r4\\ldarg_s_r4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
