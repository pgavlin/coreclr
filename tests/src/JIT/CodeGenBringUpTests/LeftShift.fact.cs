using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _LeftShift_LeftShift_
    {
        [OuterLoop]
        [Fact]
        public void _LeftShift_LeftShift_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LeftShift\\LeftShift.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
