using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _NegRMW_NegRMW_
    {
        [OuterLoop]
        [Fact]
        public void _NegRMW_NegRMW_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NegRMW\\NegRMW.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
