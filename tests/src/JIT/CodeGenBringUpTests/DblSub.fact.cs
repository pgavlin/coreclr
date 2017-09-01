using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblSub_DblSub_
    {
        [OuterLoop]
        [Fact]
        public void _DblSub_DblSub_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblSub\\DblSub.cmd");
        }
    }
}
