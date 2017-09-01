using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _mul2_mul2_
    {
        [OuterLoop]
        [Fact]
        public void _mul2_mul2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul2\\mul2.cmd");
        }
    }
}
