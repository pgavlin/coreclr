using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Call1_Call1_
    {
        [OuterLoop]
        [Fact]
        public void _Call1_Call1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Call1\\Call1.cmd");
        }
    }
}
