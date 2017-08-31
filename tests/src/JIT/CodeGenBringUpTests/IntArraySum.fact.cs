using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _IntArraySum_IntArraySum_
    {
        [OuterLoop]
        [Fact]
        public void _IntArraySum_IntArraySum_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\IntArraySum\\IntArraySum.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
