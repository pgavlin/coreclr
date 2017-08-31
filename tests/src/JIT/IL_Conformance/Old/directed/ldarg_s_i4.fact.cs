using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldarg_s_i4_ldarg_s_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldarg_s_i4_ldarg_s_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldarg_s_i4\\ldarg_s_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
