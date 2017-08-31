using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _ArrayJagged_ArrayJagged_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayJagged_ArrayJagged_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayJagged\\ArrayJagged.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
