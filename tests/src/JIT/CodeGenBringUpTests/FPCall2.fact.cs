using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPCall2_FPCall2_
    {
        [OuterLoop]
        [Fact]
        public void _FPCall2_FPCall2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPCall2\\FPCall2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
