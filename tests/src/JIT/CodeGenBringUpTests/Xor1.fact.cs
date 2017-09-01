using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Xor1_Xor1_
    {
        [OuterLoop]
        [Fact]
        public void _Xor1_Xor1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Xor1\\Xor1.cmd");
        }
    }
}
