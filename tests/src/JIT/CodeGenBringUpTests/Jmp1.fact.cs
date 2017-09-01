using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Jmp1_Jmp1_
    {
        [OuterLoop]
        [Fact]
        public void _Jmp1_Jmp1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Jmp1\\Jmp1.cmd");
        }
    }
}
