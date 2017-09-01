using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Or1_Or1_
    {
        [OuterLoop]
        [Fact]
        public void _Or1_Or1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Or1\\Or1.cmd");
        }
    }
}
