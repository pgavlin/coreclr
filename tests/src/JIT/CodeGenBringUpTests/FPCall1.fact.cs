using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _FPCall1_FPCall1_
    {
        [OuterLoop]
        [Fact]
        public void _FPCall1_FPCall1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\FPCall1\\FPCall1.cmd");
        }
    }
}
