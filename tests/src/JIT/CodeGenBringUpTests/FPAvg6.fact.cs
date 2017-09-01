using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPAvg6_FPAvg6_
    {
        [OuterLoop]
        [Fact]
        public void _FPAvg6_FPAvg6_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAvg6\\FPAvg6.cmd");
        }
    }
}
