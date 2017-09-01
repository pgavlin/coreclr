using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _ArrayJagged_ArrayJagged_
    {
        [OuterLoop]
        [Fact]
        public void _ArrayJagged_ArrayJagged_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\ArrayJagged\\ArrayJagged.cmd");
        }
    }
}
