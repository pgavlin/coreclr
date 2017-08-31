using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _FPCall1_FPCall1_
    {
        [OuterLoop]
        [Fact]
        public void _FPCall1_FPCall1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPCall1\\FPCall1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
