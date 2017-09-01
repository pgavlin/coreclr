using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _And1_And1_
    {
        [OuterLoop]
        [Fact]
        public void _And1_And1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\And1\\And1.cmd");
        }
    }
}
