using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _RightShiftRef_RightShiftRef_
    {
        [OuterLoop]
        [Fact]
        public void _RightShiftRef_RightShiftRef_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\RightShiftRef\\RightShiftRef.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
