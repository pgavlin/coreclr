using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblVar_DblVar_
    {
        [OuterLoop]
        [Fact]
        public void _DblVar_DblVar_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblVar\\DblVar.cmd");
        }
    }
}
