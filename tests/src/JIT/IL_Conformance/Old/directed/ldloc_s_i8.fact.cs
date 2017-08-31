using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_directed_ldloc_s_i8_ldloc_s_i8_
    {
        [OuterLoop]
        [Fact]
        public void _Old_directed_ldloc_s_i8_ldloc_s_i8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\directed\\ldloc_s_i8\\ldloc_s_i8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
