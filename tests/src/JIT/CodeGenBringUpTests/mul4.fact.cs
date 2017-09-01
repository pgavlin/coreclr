using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _mul4_mul4_
    {
        [OuterLoop]
        [Fact]
        public void _mul4_mul4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul4\\mul4.cmd");
        }
    }
}
