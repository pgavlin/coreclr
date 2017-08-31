using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_bgt_s_bgt_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_bgt_s_bgt_s_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\bgt_s\\bgt_s.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
