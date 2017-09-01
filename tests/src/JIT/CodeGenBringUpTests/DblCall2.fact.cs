using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblCall2_DblCall2_
    {
        [OuterLoop]
        [Fact]
        public void _DblCall2_DblCall2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblCall2\\DblCall2.cmd");
        }
    }
}
