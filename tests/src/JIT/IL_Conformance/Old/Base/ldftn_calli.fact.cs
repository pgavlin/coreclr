using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_ldftn_calli_ldftn_calli_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ldftn_calli_ldftn_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ldftn_calli\\ldftn_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
