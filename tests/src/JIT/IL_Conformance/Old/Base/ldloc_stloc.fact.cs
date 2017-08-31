using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_ldloc_stloc_ldloc_stloc_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldloc_stloc_ldloc_stloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldloc_stloc\\ldloc_stloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
