using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldloca_s_i4_ldloca_s_i4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloca_s_i4_ldloca_s_i4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloca_s_i4\\ldloca_s_i4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
