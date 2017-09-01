using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblDiv_DblDiv_
    {
        [OuterLoop]
        [Fact]
        public void _DblDiv_DblDiv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblDiv\\DblDiv.cmd");
        }
    }
}
