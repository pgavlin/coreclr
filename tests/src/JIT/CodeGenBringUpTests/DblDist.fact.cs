using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _DblDist_DblDist_
    {
        [OuterLoop]
        [Fact]
        public void _DblDist_DblDist_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblDist\\DblDist.cmd");
        }
    }
}
