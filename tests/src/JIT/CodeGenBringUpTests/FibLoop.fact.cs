using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FibLoop_FibLoop_
    {
        [OuterLoop]
        [Fact]
        public void _FibLoop_FibLoop_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FibLoop\\FibLoop.cmd");
        }
    }
}
