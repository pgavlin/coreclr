using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPCall2_FPCall2_
    {
        [OuterLoop]
        [Fact]
        public void _FPCall2_FPCall2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPCall2\\FPCall2.cmd");
        }
    }
}
