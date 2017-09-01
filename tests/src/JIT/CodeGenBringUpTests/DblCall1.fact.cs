using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblCall1_DblCall1_
    {
        [OuterLoop]
        [Fact]
        public void _DblCall1_DblCall1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblCall1\\DblCall1.cmd");
        }
    }
}
