using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Conformance_Base_brtrue_brtrue_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_brtrue_brtrue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\brtrue\\brtrue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
