using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _And1_And1_
    {
        [OuterLoop]
        [Fact]
        public void _And1_And1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\And1\\And1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
