using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _StaticCalls_StaticCalls_
    {
        [OuterLoop]
        [Fact]
        public void _StaticCalls_StaticCalls_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\StaticCalls\\StaticCalls.cmd");
        }
    }
}
