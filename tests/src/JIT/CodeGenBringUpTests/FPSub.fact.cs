using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPSub_FPSub_
    {
        [OuterLoop]
        [Fact]
        public void _FPSub_FPSub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPSub\\FPSub.cmd");
        }
    }
}
