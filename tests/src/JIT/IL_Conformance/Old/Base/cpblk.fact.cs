using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_Base_cpblk_cpblk_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_cpblk_cpblk_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\cpblk\\cpblk.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
