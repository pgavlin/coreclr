using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPAvg2_FPAvg2_
    {
        [OuterLoop]
        [Fact]
        public void _FPAvg2_FPAvg2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPAvg2\\FPAvg2.cmd");
        }
    }
}
