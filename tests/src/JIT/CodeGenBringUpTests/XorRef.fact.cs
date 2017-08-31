using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _XorRef_XorRef_
    {
        [OuterLoop]
        [Fact]
        public void _XorRef_XorRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\XorRef\\XorRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
