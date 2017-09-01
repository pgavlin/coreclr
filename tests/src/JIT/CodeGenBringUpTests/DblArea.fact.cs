using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblArea_DblArea_
    {
        [OuterLoop]
        [Fact]
        public void _DblArea_DblArea_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblArea\\DblArea.cmd");
        }
    }
}
