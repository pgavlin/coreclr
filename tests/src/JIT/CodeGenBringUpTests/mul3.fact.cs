using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _mul3_mul3_
    {
        [OuterLoop]
        [Fact]
        public void _mul3_mul3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\mul3\\mul3.cmd");
        }
    }
}
