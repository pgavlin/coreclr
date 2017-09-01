using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _mul1_mul1_
    {
        [OuterLoop]
        [Fact]
        public void _mul1_mul1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul1\\mul1.cmd");
        }
    }
}
